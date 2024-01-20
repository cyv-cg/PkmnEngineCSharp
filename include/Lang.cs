using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using System;

namespace PkmnEngine.Strings {
	public static class Lang {
		public static string StringFormat(string str)
		{
			switch (gSaveBlock.language) {
				case Language.ENG:
				case Language.GER:
				case Language.FRE:
				case Language.ITA:
				case Language.SPN:
				case Language.KOR:
				case Language.CHN_SIM:
				case Language.CHN_TRA:
					return str;
				case Language.JPN: {
					// Japanese strings will require special formatting.
					// Find text between {|}
					u16 nInx = (u16)str.IndexOf("{");
					while (nInx < str.Length) {
						u16 nIny = (u16)str.IndexOf("|"), nInz = (u16)str.IndexOf("}");
						if (nIny >= str.Length || nInz >= str.Length) {
							break;
						}

						// Kanji component will be between {|
						string kanji = str.Substring(nInx + 1, nIny - nInx - 1);
						// Kana component will be between |}
						string kana = str.Substring(nIny + 1, nInz - nIny - 1);

						// Replace the {kanji|kana} part of the public static string with kanji(kana)
						// Remove the {|}
						//str.erase(nInx, nInz - nInx + 1);
						str = str.Substring(0, nInx) + str.Substring(nInz + 1, str.Length - nInz - 1);
						// Replace
						str = str.Insert(nInx, kanji + (gSaveBlock.JPN_USE_FURIGANA ? "(" + kana + ")" : ""));
						nInx = (u16)str.IndexOf("{");
					}
					return str;
				}
				default:
					throw new LanguageNotRecognizedException(gSaveBlock.language);
			}
		}

		public static string GetBattleMessage(BattleMessage messageID, params string[] mnemonic) {
			string raw = StringFormat(BattleMessages.gBattleMessageText(messageID, gSaveBlock.language));
			try {
				u8 i = 0;
				u16 nInx = (u16)raw.IndexOf("\\$");
				while (nInx < raw.Length) {
					raw = raw.Substring(0, nInx) + raw.Substring(nInx + 2, raw.Length - nInx - 2);
					raw = raw.Insert(nInx, mnemonic[i]);
					i++;
					nInx = (u16)raw.IndexOf("\\$");
				}
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			return raw;
		}
		public static string GetMonName(Species speciesID) {
			return StringFormat(SpeciesNames.gMonNames(speciesID, gSaveBlock.language));
		}
		public static string GetMoveName(BattleMoveID moveID) {
			return StringFormat(MoveNames.gMoveNames(moveID, gSaveBlock.language));
		}
		public static string GetAbilityName(Ability abilityID) {
			return StringFormat(AbilityNames.gAbilityNames(abilityID, gSaveBlock.language));
		}
		public static string GetStatName(Stat statID) {
			return StringFormat(StatNames.gStatNames(statID, gSaveBlock.language));
		}
		public static string GetTypeName(Type typeID) {
			return StringFormat(TypeNames.gTypeNames(typeID, gSaveBlock.language));
		}
	}
}