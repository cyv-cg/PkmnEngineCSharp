// Build with g++
// /usr/bin/g++ -fdiagnostics-color=always -g compile_strings.cpp -o compile_strings

#include <iostream>
#include <fstream>
#include <vector>
#include <map>
#include <algorithm>

#include <filesystem>
namespace fs = std::filesystem;

// Use rapidxml to parse xml data
// https://rapidxml.sourceforge.net/
#include "rapidxml/rapidxml.hpp"

using namespace std;
using namespace rapidxml;


const int n_langs = 9;
// Set up langs to search over.
const char *langs[] = {"en", "ja", "de", "fr", "es", "it", "ko", "zh-cn", "zh-tw"};
string LANG_KEYS[] = {
	"Language.ENG", 
	"Language.JPN", 
	"Language.GER", 
	"Language.FRE", 
	"Language.SPN", 
	"Language.ITA", 
	"Language.KOR", 
	"Language.CHN_SIM", 
	"Language.CHN_TRA"
};

string xml_file;
string cs_file;
string cs_class;

bool b_WriteLines(vector<string> lines) {
	std::ofstream o_stream(cs_file);
	if (!o_stream.is_open()) {
		return false;
	}

	for (uint16_t i = 0; i < lines.size(); i++) {
		o_stream << lines[i];
	}
	o_stream.close();

	return true;
}

string BuildKey(string key, string params, string enText) {
	string upperKey = key;
	transform(upperKey.begin(), upperKey.end(), upperKey.begin(), ::toupper);
	return "\t\t/// <summary>\n\t\t/// " + enText + "\n\t\t/// </summary>\n\t\tpublic static readonly StringResource " + upperKey + " = new(\"" + key + "\", " + params + ");\n";
}
string BuildVal(string key, map<const char*, string> dict) {
	string upperKey = key;
	transform(upperKey.begin(), upperKey.end(), upperKey.begin(), ::toupper);

	string val = "\t\t\t{" + upperKey + ", new() {";
	for (int i = 0; i < n_langs; i++) {
		val = val + "{" + LANG_KEYS[i] + ", \"" + dict[langs[i]] + "\"}, ";
	}
	val += "}},\n";

	return val;
}

void BuildLines(vector<string> keys, map<string, string> paramMap, map<string, map<const char*, string>> dict) {
	string lines1[] = {
		"namespace PkmnEngine.Strings {\n",
		"	public static class ", cs_class, " {\n",
		"		#region Keys\n",
	};
	string lines2[] = {
		"		#endregion\n",
		"\n",
		"		internal static System.Collections.Generic.Dictionary<StringResource, System.Collections.Generic.Dictionary<Language, string>> resources = new() {\n",
	};
	string lines3[] = {
		"		};\n"
		"	}\n",
		"}\n"
	};

	vector<string> cs_keys;
	vector<string> cs_vals;

	for (string key : keys) {
		cs_keys.push_back(BuildKey(key, paramMap[key], dict[key]["en"]));
		cs_vals.push_back(BuildVal(key, dict[key]));
	}

	vector<string> out;

	for (string l : lines1) {
		out.push_back(l);
	}
	for (string l : cs_keys) {
		out.push_back(l);
	}
	for (string l : lines2) {
		out.push_back(l);
	}
	for (string l : cs_vals) {
		out.push_back(l);
	}
	for (string l : lines3) {
		out.push_back(l);
	}

	b_WriteLines(out);

	cs_keys.clear();
	cs_vals.clear();
	out.clear();
}

void Compile(string file) {
	xml_file = file;
	cs_file = xml_file + ".auto.cs";
	xml_file = xml_file + ".xml";
	cs_class = file;
	transform(cs_class.begin(), cs_class.end(), cs_class.begin(), ::toupper);

	ifstream i_stream(xml_file);
	xml_document<> doc;

	// Read file into vector.
	vector<char> buffer((istreambuf_iterator<char>(i_stream)), istreambuf_iterator<char>());
	buffer.push_back('\0');
	doc.parse<0>(&buffer[0]);

	// Store the root node.
	xml_node<char> *root = doc.first_node();

	vector<string> keys;
	map<string, string> paramMap;
	map<string, map<const char*, string>> textDict;

	// Loop over all nodes.
	for (xml_node<char> *node = root->first_node(); node != NULL; node = node->next_sibling()) {
		// Find the key.
		string key = node->first_node("key")->value();

		// Don't compile strings with a default key.
		if (key.find("key") != string::npos) {
			continue;
		}

		keys.push_back(key);

		// Find the number of params.
		paramMap[key] = "0";
		for (uint8_t i = 1; i < 255; i++) {
			string text = node->first_node("text")->first_node("en")->value();
			if (text.find("{" + to_string(i) + "}") != std::string::npos) {
				paramMap[key] = to_string(i);
			}
			else {
				break;
			}
		}

		// Find the text for each "supported" language.
		const char *lang;
		for (int i = 0; i < n_langs; i++) {
			lang = langs[i];
			string text = node->first_node("text")->first_node(lang)->value();
			textDict[key][lang] = text;
		}
	}

	BuildLines(keys, paramMap, textDict);

	buffer.clear();
	keys.clear();
	paramMap.clear();
	textDict.clear();
}

std::vector<std::string> Split(std::string str, std::string delim) {
	std::vector<std::string> values;
	std::string temp = str;
	uint32_t len = 0;

	while (true) {
		uint32_t position = 0;
		try {
			position = temp.find(delim);
			temp = str.substr(len, position);
			len += temp.length() + delim.length();
			values.push_back(temp);
			temp = str.substr(len, str.length());
		}
		catch (std::exception e) {
			break;
		}
	}

	return values;
}

int main(int argc, char* argv[]) {
	if (argc < 2) { // Compile EVERYTHING
		vector<string> xml_files;
		string path = ".";
		for (const auto &entry : fs::directory_iterator(path)) {
			if (entry.path().extension() == ".xml" && entry.path().filename() != "temp.xml") {
				xml_files.push_back(Split(entry.path().filename().generic_string(), ".")[0]);
			}
		}

		for (string file : xml_files) {
			Compile(file);
		}
	} // Or compile only the given file
	else {
		Compile(argv[1]);
	}
}