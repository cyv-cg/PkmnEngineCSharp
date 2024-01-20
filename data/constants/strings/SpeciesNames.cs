using static PkmnEngine.Global;

namespace PkmnEngine.Strings {
	public static class SpeciesNames {
		public static string gMonNames(Species species, Language lang) {
			switch (species) {
				case Species.NONE:
					return lang switch {
						Language.ENG => "???",
						Language.JPN => "???",
						Language.GER => "???",
						Language.FRE => "???",
						Language.ITA => "???",
						Language.SPN => "???",
						Language.KOR => "???",
						Language.CHN_SIM => "???",
						Language.CHN_TRA => "???",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BULBASAUR:
					return lang switch {
						Language.ENG => "Bulbasaur",
						Language.JPN => "フシギダネ",
						Language.GER => "Bisasam",
						Language.FRE => "Bulbizarre",
						Language.ITA => "Bulbasaur",
						Language.SPN => "Bulbasaur",
						Language.KOR => "이상해씨",
						Language.CHN_SIM => "妙蛙种子",
						Language.CHN_TRA => "妙蛙種子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IVYSAUR:
					return lang switch {
						Language.ENG => "Ivysaur",
						Language.JPN => "フシギソウ",
						Language.GER => "Bisaknosp",
						Language.FRE => "Herbizarre",
						Language.ITA => "Ivysaur",
						Language.SPN => "Ivysaur",
						Language.KOR => "이상해풀",
						Language.CHN_SIM => "妙蛙草",
						Language.CHN_TRA => "妙蛙草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VENUSAUR:
					return lang switch {
						Language.ENG => "Venusaur",
						Language.JPN => "フシギバナ",
						Language.GER => "Bisaflor",
						Language.FRE => "Florizarre",
						Language.ITA => "Venusaur",
						Language.SPN => "Venusaur",
						Language.KOR => "이상해꽃",
						Language.CHN_SIM => "妙蛙花",
						Language.CHN_TRA => "妙蛙花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VENUSAUR_MEGA_VENUSAUR:
					return lang switch {
						Language.ENG => "Venusaur",
						Language.JPN => "フシギバナ",
						Language.GER => "Bisaflor",
						Language.FRE => "Florizarre",
						Language.ITA => "Venusaur",
						Language.SPN => "Venusaur",
						Language.KOR => "이상해꽃",
						Language.CHN_SIM => "妙蛙花",
						Language.CHN_TRA => "妙蛙花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARMANDER:
					return lang switch {
						Language.ENG => "Charmander",
						Language.JPN => "ヒトカゲ",
						Language.GER => "Glumanda",
						Language.FRE => "Salamèche",
						Language.ITA => "Charmander",
						Language.SPN => "Charmander",
						Language.KOR => "파이리",
						Language.CHN_SIM => "小火龙",
						Language.CHN_TRA => "小火龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARMELEON:
					return lang switch {
						Language.ENG => "Charmeleon",
						Language.JPN => "リザード",
						Language.GER => "Glutexo",
						Language.FRE => "Reptincel",
						Language.ITA => "Charmeleon",
						Language.SPN => "Charmeleon",
						Language.KOR => "리자드",
						Language.CHN_SIM => "火恐龙",
						Language.CHN_TRA => "火恐龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARIZARD:
					return lang switch {
						Language.ENG => "Charizard",
						Language.JPN => "リザードン",
						Language.GER => "Glurak",
						Language.FRE => "Dracaufeu",
						Language.ITA => "Charizard",
						Language.SPN => "Charizard",
						Language.KOR => "리자몽",
						Language.CHN_SIM => "喷火龙",
						Language.CHN_TRA => "噴火龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARIZARD_MEGA_CHARIZARD_X:
					return lang switch {
						Language.ENG => "Charizard",
						Language.JPN => "リザードン",
						Language.GER => "Glurak",
						Language.FRE => "Dracaufeu",
						Language.ITA => "Charizard",
						Language.SPN => "Charizard",
						Language.KOR => "리자몽",
						Language.CHN_SIM => "喷火龙",
						Language.CHN_TRA => "噴火龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARIZARD_MEGA_CHARIZARD_Y:
					return lang switch {
						Language.ENG => "Charizard",
						Language.JPN => "リザードン",
						Language.GER => "Glurak",
						Language.FRE => "Dracaufeu",
						Language.ITA => "Charizard",
						Language.SPN => "Charizard",
						Language.KOR => "리자몽",
						Language.CHN_SIM => "喷火龙",
						Language.CHN_TRA => "噴火龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SQUIRTLE:
					return lang switch {
						Language.ENG => "Squirtle",
						Language.JPN => "ゼニガメ",
						Language.GER => "Schiggy",
						Language.FRE => "Carapuce",
						Language.ITA => "Squirtle",
						Language.SPN => "Squirtle",
						Language.KOR => "꼬부기",
						Language.CHN_SIM => "杰尼龟",
						Language.CHN_TRA => "傑尼龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WARTORTLE:
					return lang switch {
						Language.ENG => "Wartortle",
						Language.JPN => "カメール",
						Language.GER => "Schillok",
						Language.FRE => "Carabaffe",
						Language.ITA => "Wartortle",
						Language.SPN => "Wartortle",
						Language.KOR => "어니부기",
						Language.CHN_SIM => "卡咪龟",
						Language.CHN_TRA => "卡咪龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLASTOISE:
					return lang switch {
						Language.ENG => "Blastoise",
						Language.JPN => "カメックス",
						Language.GER => "Turtok",
						Language.FRE => "Tortank",
						Language.ITA => "Blastoise",
						Language.SPN => "Blastoise",
						Language.KOR => "거북왕",
						Language.CHN_SIM => "水箭龟",
						Language.CHN_TRA => "水箭龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLASTOISE_MEGA_BLASTOISE:
					return lang switch {
						Language.ENG => "Blastoise",
						Language.JPN => "カメックス",
						Language.GER => "Turtok",
						Language.FRE => "Tortank",
						Language.ITA => "Blastoise",
						Language.SPN => "Blastoise",
						Language.KOR => "거북왕",
						Language.CHN_SIM => "水箭龟",
						Language.CHN_TRA => "水箭龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CATERPIE:
					return lang switch {
						Language.ENG => "Caterpie",
						Language.JPN => "キャタピー",
						Language.GER => "Raupy",
						Language.FRE => "Chenipan",
						Language.ITA => "Caterpie",
						Language.SPN => "Caterpie",
						Language.KOR => "캐터피",
						Language.CHN_SIM => "绿毛虫",
						Language.CHN_TRA => "綠毛蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.METAPOD:
					return lang switch {
						Language.ENG => "Metapod",
						Language.JPN => "トランセル",
						Language.GER => "Safcon",
						Language.FRE => "Chrysacier",
						Language.ITA => "Metapod",
						Language.SPN => "Metapod",
						Language.KOR => "단데기",
						Language.CHN_SIM => "铁甲蛹",
						Language.CHN_TRA => "鐵甲蛹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BUTTERFREE:
					return lang switch {
						Language.ENG => "Butterfree",
						Language.JPN => "バタフリー",
						Language.GER => "Smettbo",
						Language.FRE => "Papilusion",
						Language.ITA => "Butterfree",
						Language.SPN => "Butterfree",
						Language.KOR => "버터플",
						Language.CHN_SIM => "巴大蝶",
						Language.CHN_TRA => "巴大蝶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WEEDLE:
					return lang switch {
						Language.ENG => "Weedle",
						Language.JPN => "ビードル",
						Language.GER => "Hornliu",
						Language.FRE => "Aspicot",
						Language.ITA => "Weedle",
						Language.SPN => "Weedle",
						Language.KOR => "뿔충이",
						Language.CHN_SIM => "独角虫",
						Language.CHN_TRA => "獨角蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KAKUNA:
					return lang switch {
						Language.ENG => "Kakuna",
						Language.JPN => "コクーン",
						Language.GER => "Kokuna",
						Language.FRE => "Coconfort",
						Language.ITA => "Kakuna",
						Language.SPN => "Kakuna",
						Language.KOR => "딱충이",
						Language.CHN_SIM => "铁壳蛹",
						Language.CHN_TRA => "鐵殼蛹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BEEDRILL:
					return lang switch {
						Language.ENG => "Beedrill",
						Language.JPN => "スピアー",
						Language.GER => "Bibor",
						Language.FRE => "Dardargnan",
						Language.ITA => "Beedrill",
						Language.SPN => "Beedrill",
						Language.KOR => "독침붕",
						Language.CHN_SIM => "大针蜂",
						Language.CHN_TRA => "大針蜂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BEEDRILL_MEGA_BEEDRILL:
					return lang switch {
						Language.ENG => "Beedrill",
						Language.JPN => "スピアー",
						Language.GER => "Bibor",
						Language.FRE => "Dardargnan",
						Language.ITA => "Beedrill",
						Language.SPN => "Beedrill",
						Language.KOR => "독침붕",
						Language.CHN_SIM => "大针蜂",
						Language.CHN_TRA => "大針蜂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIDGEY:
					return lang switch {
						Language.ENG => "Pidgey",
						Language.JPN => "ポッポ",
						Language.GER => "Taubsi",
						Language.FRE => "Roucool",
						Language.ITA => "Pidgey",
						Language.SPN => "Pidgey",
						Language.KOR => "구구",
						Language.CHN_SIM => "波波",
						Language.CHN_TRA => "波波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIDGEOTTO:
					return lang switch {
						Language.ENG => "Pidgeotto",
						Language.JPN => "ピジョン",
						Language.GER => "Tauboga",
						Language.FRE => "Roucoups",
						Language.ITA => "Pidgeotto",
						Language.SPN => "Pidgeotto",
						Language.KOR => "피죤",
						Language.CHN_SIM => "比比鸟",
						Language.CHN_TRA => "比比鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIDGEOT:
					return lang switch {
						Language.ENG => "Pidgeotto",
						Language.JPN => "ピジョン",
						Language.GER => "Tauboga",
						Language.FRE => "Roucoups",
						Language.ITA => "Pidgeotto",
						Language.SPN => "Pidgeotto",
						Language.KOR => "피죤",
						Language.CHN_SIM => "比比鸟",
						Language.CHN_TRA => "比比鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIDGEOT_MEGA_PIDGEOT:
					return lang switch {
						Language.ENG => "Pidgeotto",
						Language.JPN => "ピジョン",
						Language.GER => "Tauboga",
						Language.FRE => "Roucoups",
						Language.ITA => "Pidgeotto",
						Language.SPN => "Pidgeotto",
						Language.KOR => "피죤",
						Language.CHN_SIM => "比比鸟",
						Language.CHN_TRA => "比比鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RATTATA:
					return lang switch {
						Language.ENG => "Rattata",
						Language.JPN => "コラッタ",
						Language.GER => "Rattfratz",
						Language.FRE => "Rattata",
						Language.ITA => "Rattata",
						Language.SPN => "Rattata",
						Language.KOR => "꼬렛",
						Language.CHN_SIM => "小拉达",
						Language.CHN_TRA => "小拉達",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RATTATA_ALOLAN_RATTATA:
					return lang switch {
						Language.ENG => "Rattata",
						Language.JPN => "コラッタ",
						Language.GER => "Rattfratz",
						Language.FRE => "Rattata",
						Language.ITA => "Rattata",
						Language.SPN => "Rattata",
						Language.KOR => "꼬렛",
						Language.CHN_SIM => "小拉达",
						Language.CHN_TRA => "小拉達",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RATICATE:
					return lang switch {
						Language.ENG => "Raticate",
						Language.JPN => "ラッタ",
						Language.GER => "Rattikarl",
						Language.FRE => "Rattatac",
						Language.ITA => "Raticate",
						Language.SPN => "Raticate",
						Language.KOR => "레트라",
						Language.CHN_SIM => "拉达",
						Language.CHN_TRA => "拉達",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RATICATE_ALOLAN_RATICATE:
					return lang switch {
						Language.ENG => "Raticate",
						Language.JPN => "ラッタ",
						Language.GER => "Rattikarl",
						Language.FRE => "Rattatac",
						Language.ITA => "Raticate",
						Language.SPN => "Raticate",
						Language.KOR => "레트라",
						Language.CHN_SIM => "拉达",
						Language.CHN_TRA => "拉達",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPEAROW:
					return lang switch {
						Language.ENG => "Spearow",
						Language.JPN => "オニスズメ",
						Language.GER => "Habitak",
						Language.FRE => "Piafabec",
						Language.ITA => "Spearow",
						Language.SPN => "Spearow",
						Language.KOR => "깨비참",
						Language.CHN_SIM => "烈雀",
						Language.CHN_TRA => "烈雀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FEAROW:
					return lang switch {
						Language.ENG => "Fearow",
						Language.JPN => "オニドリル",
						Language.GER => "Ibitak",
						Language.FRE => "Rapasdepic",
						Language.ITA => "Fearow",
						Language.SPN => "Fearow",
						Language.KOR => "깨비드릴조",
						Language.CHN_SIM => "大嘴雀",
						Language.CHN_TRA => "大嘴雀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EKANS:
					return lang switch {
						Language.ENG => "Ekans",
						Language.JPN => "アーボ",
						Language.GER => "Rettan",
						Language.FRE => "Abo",
						Language.ITA => "Ekans",
						Language.SPN => "Ekans",
						Language.KOR => "아보",
						Language.CHN_SIM => "阿柏蛇",
						Language.CHN_TRA => "阿柏蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARBOK:
					return lang switch {
						Language.ENG => "Arbok",
						Language.JPN => "アーボック",
						Language.GER => "Arbok",
						Language.FRE => "Arbok",
						Language.ITA => "Arbok",
						Language.SPN => "Arbok",
						Language.KOR => "아보크",
						Language.CHN_SIM => "阿柏怪",
						Language.CHN_TRA => "阿柏怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIKACHU:
					return lang switch {
						Language.ENG => "Pikachu",
						Language.JPN => "ピカチュウ",
						Language.GER => "Pikachu",
						Language.FRE => "Pikachu",
						Language.ITA => "Pikachu",
						Language.SPN => "Pikachu",
						Language.KOR => "피카츄",
						Language.CHN_SIM => "皮卡丘",
						Language.CHN_TRA => "皮卡丘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIKACHU_PARTNER_PIKACHU:
					return lang switch {
						Language.ENG => "Pikachu",
						Language.JPN => "ピカチュウ",
						Language.GER => "Pikachu",
						Language.FRE => "Pikachu",
						Language.ITA => "Pikachu",
						Language.SPN => "Pikachu",
						Language.KOR => "피카츄",
						Language.CHN_SIM => "皮卡丘",
						Language.CHN_TRA => "皮卡丘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAICHU:
					return lang switch {
						Language.ENG => "Raichu",
						Language.JPN => "ライチュウ",
						Language.GER => "Raichu",
						Language.FRE => "Raichu",
						Language.ITA => "Raichu",
						Language.SPN => "Raichu",
						Language.KOR => "라이츄",
						Language.CHN_SIM => "雷丘",
						Language.CHN_TRA => "雷丘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAICHU_ALOLAN_RAICHU:
					return lang switch {
						Language.ENG => "Raichu",
						Language.JPN => "ライチュウ",
						Language.GER => "Raichu",
						Language.FRE => "Raichu",
						Language.ITA => "Raichu",
						Language.SPN => "Raichu",
						Language.KOR => "라이츄",
						Language.CHN_SIM => "雷丘",
						Language.CHN_TRA => "雷丘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDSHREW:
					return lang switch {
						Language.ENG => "Sandshrew",
						Language.JPN => "サンド",
						Language.GER => "Sandan",
						Language.FRE => "Sabelette",
						Language.ITA => "Sandshrew",
						Language.SPN => "Sandshrew",
						Language.KOR => "모래두지",
						Language.CHN_SIM => "穿山鼠",
						Language.CHN_TRA => "穿山鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDSHREW_ALOLAN_SANDSHREW:
					return lang switch {
						Language.ENG => "Sandshrew",
						Language.JPN => "サンド",
						Language.GER => "Sandan",
						Language.FRE => "Sabelette",
						Language.ITA => "Sandshrew",
						Language.SPN => "Sandshrew",
						Language.KOR => "모래두지",
						Language.CHN_SIM => "穿山鼠",
						Language.CHN_TRA => "穿山鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDSLASH:
					return lang switch {
						Language.ENG => "Sandslash",
						Language.JPN => "サンドパン",
						Language.GER => "Sandamer",
						Language.FRE => "Sablaireau",
						Language.ITA => "Sandslash",
						Language.SPN => "Sandslash",
						Language.KOR => "고지",
						Language.CHN_SIM => "穿山王",
						Language.CHN_TRA => "穿山王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDSLASH_ALOLAN_SANDSLASH:
					return lang switch {
						Language.ENG => "Sandslash",
						Language.JPN => "サンドパン",
						Language.GER => "Sandamer",
						Language.FRE => "Sablaireau",
						Language.ITA => "Sandslash",
						Language.SPN => "Sandslash",
						Language.KOR => "고지",
						Language.CHN_SIM => "穿山王",
						Language.CHN_TRA => "穿山王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIDORAN_F:
					return lang switch {
						Language.ENG => "Nidoran♀",
						Language.JPN => "ニドラン♀",
						Language.GER => "Nidoran♀",
						Language.FRE => "Nidoran♀",
						Language.ITA => "Nidoran♀",
						Language.SPN => "Nidoran♀",
						Language.KOR => "니드런♀",
						Language.CHN_SIM => "尼多兰",
						Language.CHN_TRA => "尼多蘭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIDORINA:
					return lang switch {
						Language.ENG => "Nidorina",
						Language.JPN => "ニドリーナ",
						Language.GER => "Nidorina",
						Language.FRE => "Nidorina",
						Language.ITA => "Nidorina",
						Language.SPN => "Nidorina",
						Language.KOR => "니드리나",
						Language.CHN_SIM => "尼多娜",
						Language.CHN_TRA => "尼多娜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIDOQUEEN:
					return lang switch {
						Language.ENG => "Nidoqueen",
						Language.JPN => "ニドクイン",
						Language.GER => "Nidoqueen",
						Language.FRE => "Nidoqueen",
						Language.ITA => "Nidoqueen",
						Language.SPN => "Nidoqueen",
						Language.KOR => "니드퀸",
						Language.CHN_SIM => "尼多后",
						Language.CHN_TRA => "尼多后",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIDORAN_M:
					return lang switch {
						Language.ENG => "Nidoran♂",
						Language.JPN => "ニドラン♂",
						Language.GER => "Nidoran♂",
						Language.FRE => "Nidoran♂",
						Language.ITA => "Nidoran♂",
						Language.SPN => "Nidoran♂",
						Language.KOR => "니드런♂",
						Language.CHN_SIM => "尼多朗",
						Language.CHN_TRA => "尼多朗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIDORINO:
					return lang switch {
						Language.ENG => "Nidorino",
						Language.JPN => "ニドリーノ",
						Language.GER => "Nidorino",
						Language.FRE => "Nidorino",
						Language.ITA => "Nidorino",
						Language.SPN => "Nidorino",
						Language.KOR => "니드리노",
						Language.CHN_SIM => "尼多力诺",
						Language.CHN_TRA => "尼多力諾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIDOKING:
					return lang switch {
						Language.ENG => "Nidoking",
						Language.JPN => "ニドキング",
						Language.GER => "Nidoking",
						Language.FRE => "Nidoking",
						Language.ITA => "Nidoking",
						Language.SPN => "Nidoking",
						Language.KOR => "니드킹",
						Language.CHN_SIM => "尼多王",
						Language.CHN_TRA => "尼多王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLEFAIRY:
					return lang switch {
						Language.ENG => "Clefairy",
						Language.JPN => "ピッピ",
						Language.GER => "Piepi",
						Language.FRE => "Mélofée",
						Language.ITA => "Clefairy",
						Language.SPN => "Clefairy",
						Language.KOR => "삐삐",
						Language.CHN_SIM => "皮皮",
						Language.CHN_TRA => "皮皮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLEFABLE:
					return lang switch {
						Language.ENG => "Clefable",
						Language.JPN => "ピクシー",
						Language.GER => "Pixi",
						Language.FRE => "Mélodelfe",
						Language.ITA => "Clefable",
						Language.SPN => "Clefable",
						Language.KOR => "픽시",
						Language.CHN_SIM => "皮可西",
						Language.CHN_TRA => "皮可西",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VULPIX:
					return lang switch {
						Language.ENG => "Vulpix",
						Language.JPN => "ロコン",
						Language.GER => "Vulpix",
						Language.FRE => "Goupix",
						Language.ITA => "Vulpix",
						Language.SPN => "Vulpix",
						Language.KOR => "식스테일",
						Language.CHN_SIM => "六尾",
						Language.CHN_TRA => "六尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VULPIX_ALOLAN_VULPIX:
					return lang switch {
						Language.ENG => "Vulpix",
						Language.JPN => "ロコン",
						Language.GER => "Vulpix",
						Language.FRE => "Goupix",
						Language.ITA => "Vulpix",
						Language.SPN => "Vulpix",
						Language.KOR => "식스테일",
						Language.CHN_SIM => "六尾",
						Language.CHN_TRA => "六尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NINETALES:
					return lang switch {
						Language.ENG => "Ninetales",
						Language.JPN => "キュウコン",
						Language.GER => "Vulnona",
						Language.FRE => "Feunard",
						Language.ITA => "Ninetales",
						Language.SPN => "Ninetales",
						Language.KOR => "나인테일",
						Language.CHN_SIM => "九尾",
						Language.CHN_TRA => "九尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NINETALES_ALOLAN_NINETALES:
					return lang switch {
						Language.ENG => "Ninetales",
						Language.JPN => "キュウコン",
						Language.GER => "Vulnona",
						Language.FRE => "Feunard",
						Language.ITA => "Ninetales",
						Language.SPN => "Ninetales",
						Language.KOR => "나인테일",
						Language.CHN_SIM => "九尾",
						Language.CHN_TRA => "九尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JIGGLYPUFF:
					return lang switch {
						Language.ENG => "Jigglypuff",
						Language.JPN => "プリン",
						Language.GER => "Pummeluff",
						Language.FRE => "Rondoudou",
						Language.ITA => "Jigglypuff",
						Language.SPN => "Jigglypuff",
						Language.KOR => "푸린",
						Language.CHN_SIM => "胖丁",
						Language.CHN_TRA => "胖丁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WIGGLYTUFF:
					return lang switch {
						Language.ENG => "Wigglytuff",
						Language.JPN => "プクリン",
						Language.GER => "Knuddeluff",
						Language.FRE => "Grodoudou",
						Language.ITA => "Wigglytuff",
						Language.SPN => "Wigglytuff",
						Language.KOR => "푸크린",
						Language.CHN_SIM => "胖可丁",
						Language.CHN_TRA => "胖可丁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZUBAT:
					return lang switch {
						Language.ENG => "Zubat",
						Language.JPN => "ズバット",
						Language.GER => "Zubat",
						Language.FRE => "Nosferapti",
						Language.ITA => "Zubat",
						Language.SPN => "Zubat",
						Language.KOR => "주뱃",
						Language.CHN_SIM => "超音蝠",
						Language.CHN_TRA => "超音蝠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLBAT:
					return lang switch {
						Language.ENG => "Golbat",
						Language.JPN => "ゴルバット",
						Language.GER => "Golbat",
						Language.FRE => "Nosferalto",
						Language.ITA => "Golbat",
						Language.SPN => "Golbat",
						Language.KOR => "골뱃",
						Language.CHN_SIM => "大嘴蝠",
						Language.CHN_TRA => "大嘴蝠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ODDISH:
					return lang switch {
						Language.ENG => "Oddish",
						Language.JPN => "ナゾノクサ",
						Language.GER => "Myrapla",
						Language.FRE => "Mystherbe",
						Language.ITA => "Oddish",
						Language.SPN => "Oddish",
						Language.KOR => "뚜벅쵸",
						Language.CHN_SIM => "走路草",
						Language.CHN_TRA => "走路草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLOOM:
					return lang switch {
						Language.ENG => "Gloom",
						Language.JPN => "クサイハナ",
						Language.GER => "Duflor",
						Language.FRE => "Ortide",
						Language.ITA => "Gloom",
						Language.SPN => "Gloom",
						Language.KOR => "냄새꼬",
						Language.CHN_SIM => "臭臭花",
						Language.CHN_TRA => "臭臭花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VILEPLUME:
					return lang switch {
						Language.ENG => "Vileplume",
						Language.JPN => "ラフレシア",
						Language.GER => "Giflor",
						Language.FRE => "Rafflesia",
						Language.ITA => "Vileplume",
						Language.SPN => "Vileplume",
						Language.KOR => "라플레시아",
						Language.CHN_SIM => "霸王花",
						Language.CHN_TRA => "霸王花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PARAS:
					return lang switch {
						Language.ENG => "Paras",
						Language.JPN => "パラス",
						Language.GER => "Paras",
						Language.FRE => "Paras",
						Language.ITA => "Paras",
						Language.SPN => "Paras",
						Language.KOR => "파라스",
						Language.CHN_SIM => "派拉斯",
						Language.CHN_TRA => "派拉斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PARASECT:
					return lang switch {
						Language.ENG => "Parasect",
						Language.JPN => "パラセクト",
						Language.GER => "Parasek",
						Language.FRE => "Parasect",
						Language.ITA => "Parasect",
						Language.SPN => "Parasect",
						Language.KOR => "파라섹트",
						Language.CHN_SIM => "派拉斯特",
						Language.CHN_TRA => "派拉斯特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VENONAT:
					return lang switch {
						Language.ENG => "Venonat",
						Language.JPN => "コンパン",
						Language.GER => "Bluzuk",
						Language.FRE => "Mimitoss",
						Language.ITA => "Venonat",
						Language.SPN => "Venonat",
						Language.KOR => "콘팡",
						Language.CHN_SIM => "毛球",
						Language.CHN_TRA => "毛球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VENOMOTH:
					return lang switch {
						Language.ENG => "Venomoth",
						Language.JPN => "モルフォン",
						Language.GER => "Omot",
						Language.FRE => "Aéromite",
						Language.ITA => "Venomoth",
						Language.SPN => "Venomoth",
						Language.KOR => "도나리",
						Language.CHN_SIM => "摩鲁蛾",
						Language.CHN_TRA => "摩魯蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIGLETT:
					return lang switch {
						Language.ENG => "Diglett",
						Language.JPN => "ディグダ",
						Language.GER => "Digda",
						Language.FRE => "Taupiqueur",
						Language.ITA => "Diglett",
						Language.SPN => "Diglett",
						Language.KOR => "디그다",
						Language.CHN_SIM => "地鼠",
						Language.CHN_TRA => "地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIGLETT_ALOLAN_DIGLETT:
					return lang switch {
						Language.ENG => "Diglett",
						Language.JPN => "ディグダ",
						Language.GER => "Digda",
						Language.FRE => "Taupiqueur",
						Language.ITA => "Diglett",
						Language.SPN => "Diglett",
						Language.KOR => "디그다",
						Language.CHN_SIM => "地鼠",
						Language.CHN_TRA => "地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUGTRIO:
					return lang switch {
						Language.ENG => "Dugtrio",
						Language.JPN => "ダグトリオ",
						Language.GER => "Digdri",
						Language.FRE => "Triopikeur",
						Language.ITA => "Dugtrio",
						Language.SPN => "Dugtrio",
						Language.KOR => "닥트리오",
						Language.CHN_SIM => "三地鼠",
						Language.CHN_TRA => "三地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUGTRIO_ALOLAN_DUGTRIO:
					return lang switch {
						Language.ENG => "Dugtrio",
						Language.JPN => "ダグトリオ",
						Language.GER => "Digdri",
						Language.FRE => "Triopikeur",
						Language.ITA => "Dugtrio",
						Language.SPN => "Dugtrio",
						Language.KOR => "닥트리오",
						Language.CHN_SIM => "三地鼠",
						Language.CHN_TRA => "三地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEOWTH:
					return lang switch {
						Language.ENG => "Meowth",
						Language.JPN => "ニャース",
						Language.GER => "Mauzi",
						Language.FRE => "Miaouss",
						Language.ITA => "Meowth",
						Language.SPN => "Meowth",
						Language.KOR => "나옹",
						Language.CHN_SIM => "喵喵",
						Language.CHN_TRA => "喵喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEOWTH_ALOLAN_MEOWTH:
					return lang switch {
						Language.ENG => "Meowth",
						Language.JPN => "ニャース",
						Language.GER => "Mauzi",
						Language.FRE => "Miaouss",
						Language.ITA => "Meowth",
						Language.SPN => "Meowth",
						Language.KOR => "나옹",
						Language.CHN_SIM => "喵喵",
						Language.CHN_TRA => "喵喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEOWTH_GALARIAN_MEOWTH:
					return lang switch {
						Language.ENG => "Meowth",
						Language.JPN => "ニャース",
						Language.GER => "Mauzi",
						Language.FRE => "Miaouss",
						Language.ITA => "Meowth",
						Language.SPN => "Meowth",
						Language.KOR => "나옹",
						Language.CHN_SIM => "喵喵",
						Language.CHN_TRA => "喵喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PERSIAN:
					return lang switch {
						Language.ENG => "Persian",
						Language.JPN => "ペルシアン",
						Language.GER => "Snobilikat",
						Language.FRE => "Persian",
						Language.ITA => "Persian",
						Language.SPN => "Persian",
						Language.KOR => "페르시온",
						Language.CHN_SIM => "猫老大",
						Language.CHN_TRA => "貓老大",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PERSIAN_ALOLAN_PERSIAN:
					return lang switch {
						Language.ENG => "Persian",
						Language.JPN => "ペルシアン",
						Language.GER => "Snobilikat",
						Language.FRE => "Persian",
						Language.ITA => "Persian",
						Language.SPN => "Persian",
						Language.KOR => "페르시온",
						Language.CHN_SIM => "猫老大",
						Language.CHN_TRA => "貓老大",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PSYDUCK:
					return lang switch {
						Language.ENG => "Psyduck",
						Language.JPN => "コダック",
						Language.GER => "Enton",
						Language.FRE => "Psykokwak",
						Language.ITA => "Psyduck",
						Language.SPN => "Psyduck",
						Language.KOR => "고라파덕",
						Language.CHN_SIM => "可达鸭",
						Language.CHN_TRA => "可達鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLDUCK:
					return lang switch {
						Language.ENG => "Golduck",
						Language.JPN => "ゴルダック",
						Language.GER => "Entoron",
						Language.FRE => "Akwakwak",
						Language.ITA => "Golduck",
						Language.SPN => "Golduck",
						Language.KOR => "골덕",
						Language.CHN_SIM => "哥达鸭",
						Language.CHN_TRA => "哥達鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANKEY:
					return lang switch {
						Language.ENG => "Mankey",
						Language.JPN => "マンキー",
						Language.GER => "Menki",
						Language.FRE => "Férosinge",
						Language.ITA => "Mankey",
						Language.SPN => "Mankey",
						Language.KOR => "망키",
						Language.CHN_SIM => "猴怪",
						Language.CHN_TRA => "猴怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PRIMEAPE:
					return lang switch {
						Language.ENG => "Primeape",
						Language.JPN => "オコリザル",
						Language.GER => "Rasaff",
						Language.FRE => "Colossinge",
						Language.ITA => "Primeape",
						Language.SPN => "Primeape",
						Language.KOR => "성원숭",
						Language.CHN_SIM => "火暴猴",
						Language.CHN_TRA => "火爆猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROWLITHE:
					return lang switch {
						Language.ENG => "Growlithe",
						Language.JPN => "ガーディ",
						Language.GER => "Fukano",
						Language.FRE => "Caninos",
						Language.ITA => "Growlithe",
						Language.SPN => "Growlithe",
						Language.KOR => "가디",
						Language.CHN_SIM => "卡蒂狗",
						Language.CHN_TRA => "卡蒂狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROWLITHE_HISUIAN_GROWLITHE:
					return lang switch {
						Language.ENG => "Growlithe",
						Language.JPN => "ガーディ",
						Language.GER => "Fukano",
						Language.FRE => "Caninos",
						Language.ITA => "Growlithe",
						Language.SPN => "Growlithe",
						Language.KOR => "가디",
						Language.CHN_SIM => "卡蒂狗",
						Language.CHN_TRA => "卡蒂狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCANINE:
					return lang switch {
						Language.ENG => "Arcanine",
						Language.JPN => "ウインディ",
						Language.GER => "Arkani",
						Language.FRE => "Arcanin",
						Language.ITA => "Arcanine",
						Language.SPN => "Arcanine",
						Language.KOR => "윈디",
						Language.CHN_SIM => "风速狗",
						Language.CHN_TRA => "風速狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCANINE_HISUIAN_ARCANINE:
					return lang switch {
						Language.ENG => "Arcanine",
						Language.JPN => "ウインディ",
						Language.GER => "Arkani",
						Language.FRE => "Arcanin",
						Language.ITA => "Arcanine",
						Language.SPN => "Arcanine",
						Language.KOR => "윈디",
						Language.CHN_SIM => "风速狗",
						Language.CHN_TRA => "風速狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POLIWAG:
					return lang switch {
						Language.ENG => "Poliwag",
						Language.JPN => "ニョロモ",
						Language.GER => "Quapsel",
						Language.FRE => "Ptitard",
						Language.ITA => "Poliwag",
						Language.SPN => "Poliwag",
						Language.KOR => "발챙이",
						Language.CHN_SIM => "蚊香蝌蚪",
						Language.CHN_TRA => "蚊香蝌蚪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POLIWHIRL:
					return lang switch {
						Language.ENG => "Poliwhirl",
						Language.JPN => "ニョロゾ",
						Language.GER => "Quaputzi",
						Language.FRE => "Têtarte",
						Language.ITA => "Poliwhirl",
						Language.SPN => "Poliwhirl",
						Language.KOR => "슈륙챙이",
						Language.CHN_SIM => "蚊香君",
						Language.CHN_TRA => "蚊香君",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POLIWRATH:
					return lang switch {
						Language.ENG => "Poliwrath",
						Language.JPN => "ニョロボン",
						Language.GER => "Quappo",
						Language.FRE => "Tartard",
						Language.ITA => "Poliwrath",
						Language.SPN => "Poliwrath",
						Language.KOR => "강챙이",
						Language.CHN_SIM => "蚊香泳士",
						Language.CHN_TRA => "蚊香泳士",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ABRA:
					return lang switch {
						Language.ENG => "Abra",
						Language.JPN => "ケーシィ",
						Language.GER => "Abra",
						Language.FRE => "Abra",
						Language.ITA => "Abra",
						Language.SPN => "Abra",
						Language.KOR => "캐이시",
						Language.CHN_SIM => "凯西",
						Language.CHN_TRA => "凱西",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KADABRA:
					return lang switch {
						Language.ENG => "Kadabra",
						Language.JPN => "ユンゲラー",
						Language.GER => "Kadabra",
						Language.FRE => "Kadabra",
						Language.ITA => "Kadabra",
						Language.SPN => "Kadabra",
						Language.KOR => "윤겔라",
						Language.CHN_SIM => "勇基拉",
						Language.CHN_TRA => "勇基拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ALAKAZAM:
					return lang switch {
						Language.ENG => "Alakazam",
						Language.JPN => "フーディン",
						Language.GER => "Simsala",
						Language.FRE => "Alakazam",
						Language.ITA => "Alakazam",
						Language.SPN => "Alakazam",
						Language.KOR => "후딘",
						Language.CHN_SIM => "胡地",
						Language.CHN_TRA => "胡地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ALAKAZAM_MEGA_ALAKAZAM:
					return lang switch {
						Language.ENG => "Alakazam",
						Language.JPN => "フーディン",
						Language.GER => "Simsala",
						Language.FRE => "Alakazam",
						Language.ITA => "Alakazam",
						Language.SPN => "Alakazam",
						Language.KOR => "후딘",
						Language.CHN_SIM => "胡地",
						Language.CHN_TRA => "胡地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MACHOP:
					return lang switch {
						Language.ENG => "Machop",
						Language.JPN => "ワンリキー",
						Language.GER => "Machollo",
						Language.FRE => "Machoc",
						Language.ITA => "Machop",
						Language.SPN => "Machop",
						Language.KOR => "알통몬",
						Language.CHN_SIM => "腕力",
						Language.CHN_TRA => "腕力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MACHOKE:
					return lang switch {
						Language.ENG => "Machoke",
						Language.JPN => "ゴーリキー",
						Language.GER => "Maschock",
						Language.FRE => "Machopeur",
						Language.ITA => "Machoke",
						Language.SPN => "Machoke",
						Language.KOR => "근육몬",
						Language.CHN_SIM => "豪力",
						Language.CHN_TRA => "豪力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MACHAMP:
					return lang switch {
						Language.ENG => "Machamp",
						Language.JPN => "カイリキー",
						Language.GER => "Machomei",
						Language.FRE => "Mackogneur",
						Language.ITA => "Machamp",
						Language.SPN => "Machamp",
						Language.KOR => "괴력몬",
						Language.CHN_SIM => "怪力",
						Language.CHN_TRA => "怪力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BELLSPROUT:
					return lang switch {
						Language.ENG => "Bellsprout",
						Language.JPN => "マダツボミ",
						Language.GER => "Knofensa",
						Language.FRE => "Chétiflor",
						Language.ITA => "Bellsprout",
						Language.SPN => "Bellsprout",
						Language.KOR => "모다피",
						Language.CHN_SIM => "喇叭芽",
						Language.CHN_TRA => "喇叭芽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WEEPINBELL:
					return lang switch {
						Language.ENG => "Weepinbell",
						Language.JPN => "ウツドン",
						Language.GER => "Ultrigaria",
						Language.FRE => "Boustiflor",
						Language.ITA => "Weepinbell",
						Language.SPN => "Weepinbell",
						Language.KOR => "우츠동",
						Language.CHN_SIM => "口呆花",
						Language.CHN_TRA => "口呆花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VICTREEBEL:
					return lang switch {
						Language.ENG => "Victreebel",
						Language.JPN => "ウツボット",
						Language.GER => "Sarzenia",
						Language.FRE => "Empiflor",
						Language.ITA => "Victreebel",
						Language.SPN => "Victreebel",
						Language.KOR => "우츠보트",
						Language.CHN_SIM => "大食花",
						Language.CHN_TRA => "大食花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TENTACOOL:
					return lang switch {
						Language.ENG => "Tentacool",
						Language.JPN => "メノクラゲ",
						Language.GER => "Tentacha",
						Language.FRE => "Tentacool",
						Language.ITA => "Tentacool",
						Language.SPN => "Tentacool",
						Language.KOR => "왕눈해",
						Language.CHN_SIM => "玛瑙水母",
						Language.CHN_TRA => "瑪瑙水母",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TENTACRUEL:
					return lang switch {
						Language.ENG => "Tentacruel",
						Language.JPN => "ドククラゲ",
						Language.GER => "Tentoxa",
						Language.FRE => "Tentacruel",
						Language.ITA => "Tentacruel",
						Language.SPN => "Tentacruel",
						Language.KOR => "독파리",
						Language.CHN_SIM => "毒刺水母",
						Language.CHN_TRA => "毒刺水母",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GEODUDE:
					return lang switch {
						Language.ENG => "Geodude",
						Language.JPN => "イシツブテ",
						Language.GER => "Kleinstein",
						Language.FRE => "Racaillou",
						Language.ITA => "Geodude",
						Language.SPN => "Geodude",
						Language.KOR => "꼬마돌",
						Language.CHN_SIM => "小拳石",
						Language.CHN_TRA => "小拳石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GEODUDE_ALOLAN_GEODUDE:
					return lang switch {
						Language.ENG => "Geodude",
						Language.JPN => "イシツブテ",
						Language.GER => "Kleinstein",
						Language.FRE => "Racaillou",
						Language.ITA => "Geodude",
						Language.SPN => "Geodude",
						Language.KOR => "꼬마돌",
						Language.CHN_SIM => "小拳石",
						Language.CHN_TRA => "小拳石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRAVELER:
					return lang switch {
						Language.ENG => "Graveler",
						Language.JPN => "ゴローン",
						Language.GER => "Georok",
						Language.FRE => "Gravalanch",
						Language.ITA => "Graveler",
						Language.SPN => "Graveler",
						Language.KOR => "데구리",
						Language.CHN_SIM => "隆隆石",
						Language.CHN_TRA => "隆隆石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRAVELER_ALOLAN_GRAVELER:
					return lang switch {
						Language.ENG => "Graveler",
						Language.JPN => "ゴローン",
						Language.GER => "Georok",
						Language.FRE => "Gravalanch",
						Language.ITA => "Graveler",
						Language.SPN => "Graveler",
						Language.KOR => "데구리",
						Language.CHN_SIM => "隆隆石",
						Language.CHN_TRA => "隆隆石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLEM:
					return lang switch {
						Language.ENG => "Golem",
						Language.JPN => "ゴローニャ",
						Language.GER => "Geowaz",
						Language.FRE => "Grolem",
						Language.ITA => "Golem",
						Language.SPN => "Golem",
						Language.KOR => "딱구리",
						Language.CHN_SIM => "隆隆岩",
						Language.CHN_TRA => "隆隆岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLEM_ALOLAN_GOLEM:
					return lang switch {
						Language.ENG => "Golem",
						Language.JPN => "ゴローニャ",
						Language.GER => "Geowaz",
						Language.FRE => "Grolem",
						Language.ITA => "Golem",
						Language.SPN => "Golem",
						Language.KOR => "딱구리",
						Language.CHN_SIM => "隆隆岩",
						Language.CHN_TRA => "隆隆岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PONYTA:
					return lang switch {
						Language.ENG => "Ponyta",
						Language.JPN => "ポニータ",
						Language.GER => "Ponita",
						Language.FRE => "Ponyta",
						Language.ITA => "Ponyta",
						Language.SPN => "Ponyta",
						Language.KOR => "포니타",
						Language.CHN_SIM => "小火马",
						Language.CHN_TRA => "小火馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PONYTA_GALARIAN_PONYTA:
					return lang switch {
						Language.ENG => "Ponyta",
						Language.JPN => "ポニータ",
						Language.GER => "Ponita",
						Language.FRE => "Ponyta",
						Language.ITA => "Ponyta",
						Language.SPN => "Ponyta",
						Language.KOR => "포니타",
						Language.CHN_SIM => "小火马",
						Language.CHN_TRA => "小火馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAPIDASH:
					return lang switch {
						Language.ENG => "Rapidash",
						Language.JPN => "ギャロップ",
						Language.GER => "Gallopa",
						Language.FRE => "Galopa",
						Language.ITA => "Rapidash",
						Language.SPN => "Rapidash",
						Language.KOR => "날쌩마",
						Language.CHN_SIM => "烈焰马",
						Language.CHN_TRA => "烈焰馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAPIDASH_GALARIAN_RAPIDASH:
					return lang switch {
						Language.ENG => "Rapidash",
						Language.JPN => "ギャロップ",
						Language.GER => "Gallopa",
						Language.FRE => "Galopa",
						Language.ITA => "Rapidash",
						Language.SPN => "Rapidash",
						Language.KOR => "날쌩마",
						Language.CHN_SIM => "烈焰马",
						Language.CHN_TRA => "烈焰馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWPOKE:
					return lang switch {
						Language.ENG => "Slowpoke",
						Language.JPN => "ヤドン",
						Language.GER => "Flegmon",
						Language.FRE => "Ramoloss",
						Language.ITA => "Slowpoke",
						Language.SPN => "Slowpoke",
						Language.KOR => "야돈",
						Language.CHN_SIM => "呆呆兽",
						Language.CHN_TRA => "呆呆獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWPOKE_GALARIAN_SLOWPOKE:
					return lang switch {
						Language.ENG => "Slowpoke",
						Language.JPN => "ヤドン",
						Language.GER => "Flegmon",
						Language.FRE => "Ramoloss",
						Language.ITA => "Slowpoke",
						Language.SPN => "Slowpoke",
						Language.KOR => "야돈",
						Language.CHN_SIM => "呆呆兽",
						Language.CHN_TRA => "呆呆獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWBRO:
					return lang switch {
						Language.ENG => "Slowbro",
						Language.JPN => "ヤドラン",
						Language.GER => "Lahmus",
						Language.FRE => "Flagadoss",
						Language.ITA => "Slowbro",
						Language.SPN => "Slowbro",
						Language.KOR => "야도란",
						Language.CHN_SIM => "呆壳兽",
						Language.CHN_TRA => "呆殼獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWBRO_MEGA_SLOWBRO:
					return lang switch {
						Language.ENG => "Slowbro",
						Language.JPN => "ヤドラン",
						Language.GER => "Lahmus",
						Language.FRE => "Flagadoss",
						Language.ITA => "Slowbro",
						Language.SPN => "Slowbro",
						Language.KOR => "야도란",
						Language.CHN_SIM => "呆壳兽",
						Language.CHN_TRA => "呆殼獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWBRO_GALARIAN_SLOWBRO:
					return lang switch {
						Language.ENG => "Slowbro",
						Language.JPN => "ヤドラン",
						Language.GER => "Lahmus",
						Language.FRE => "Flagadoss",
						Language.ITA => "Slowbro",
						Language.SPN => "Slowbro",
						Language.KOR => "야도란",
						Language.CHN_SIM => "呆壳兽",
						Language.CHN_TRA => "呆殼獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGNEMITE:
					return lang switch {
						Language.ENG => "Magnemite",
						Language.JPN => "コイル",
						Language.GER => "Magnetilo",
						Language.FRE => "Magnéti",
						Language.ITA => "Magnemite",
						Language.SPN => "Magnemite",
						Language.KOR => "코일",
						Language.CHN_SIM => "小磁怪",
						Language.CHN_TRA => "小磁怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGNETON:
					return lang switch {
						Language.ENG => "Magneton",
						Language.JPN => "レアコイル",
						Language.GER => "Magneton",
						Language.FRE => "Magnéton",
						Language.ITA => "Magneton",
						Language.SPN => "Magneton",
						Language.KOR => "레어코일",
						Language.CHN_SIM => "三合一磁怪",
						Language.CHN_TRA => "三合一磁怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FARFETCH_D:
					return lang switch {
						Language.ENG => "Farfetch’d",
						Language.JPN => "カモネギ",
						Language.GER => "Porenta",
						Language.FRE => "Canarticho",
						Language.ITA => "Farfetch’d",
						Language.SPN => "Farfetch’d",
						Language.KOR => "파오리",
						Language.CHN_SIM => "大葱鸭",
						Language.CHN_TRA => "大蔥鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FARFETCH_D_GALARIAN_FARFETCH_D:
					return lang switch {
						Language.ENG => "Farfetch’d",
						Language.JPN => "カモネギ",
						Language.GER => "Porenta",
						Language.FRE => "Canarticho",
						Language.ITA => "Farfetch’d",
						Language.SPN => "Farfetch’d",
						Language.KOR => "파오리",
						Language.CHN_SIM => "大葱鸭",
						Language.CHN_TRA => "大蔥鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DODUO:
					return lang switch {
						Language.ENG => "Doduo",
						Language.JPN => "ドードー",
						Language.GER => "Dodu",
						Language.FRE => "Doduo",
						Language.ITA => "Doduo",
						Language.SPN => "Doduo",
						Language.KOR => "두두",
						Language.CHN_SIM => "嘟嘟",
						Language.CHN_TRA => "嘟嘟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DODRIO:
					return lang switch {
						Language.ENG => "Dodrio",
						Language.JPN => "ドードリオ",
						Language.GER => "Dodri",
						Language.FRE => "Dodrio",
						Language.ITA => "Dodrio",
						Language.SPN => "Dodrio",
						Language.KOR => "두트리오",
						Language.CHN_SIM => "嘟嘟利",
						Language.CHN_TRA => "嘟嘟利",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEEL:
					return lang switch {
						Language.ENG => "Seel",
						Language.JPN => "パウワウ",
						Language.GER => "Jurob",
						Language.FRE => "Otaria",
						Language.ITA => "Seel",
						Language.SPN => "Seel",
						Language.KOR => "쥬쥬",
						Language.CHN_SIM => "小海狮",
						Language.CHN_TRA => "小海獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEWGONG:
					return lang switch {
						Language.ENG => "Dewgong",
						Language.JPN => "ジュゴン",
						Language.GER => "Jugong",
						Language.FRE => "Lamantine",
						Language.ITA => "Dewgong",
						Language.SPN => "Dewgong",
						Language.KOR => "쥬레곤",
						Language.CHN_SIM => "白海狮",
						Language.CHN_TRA => "白海獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRIMER:
					return lang switch {
						Language.ENG => "Grimer",
						Language.JPN => "ベトベター",
						Language.GER => "Sleima",
						Language.FRE => "Tadmorv",
						Language.ITA => "Grimer",
						Language.SPN => "Grimer",
						Language.KOR => "질퍽이",
						Language.CHN_SIM => "臭泥",
						Language.CHN_TRA => "臭泥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRIMER_ALOLAN_GRIMER:
					return lang switch {
						Language.ENG => "Grimer",
						Language.JPN => "ベトベター",
						Language.GER => "Sleima",
						Language.FRE => "Tadmorv",
						Language.ITA => "Grimer",
						Language.SPN => "Grimer",
						Language.KOR => "질퍽이",
						Language.CHN_SIM => "臭泥",
						Language.CHN_TRA => "臭泥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUK:
					return lang switch {
						Language.ENG => "Muk",
						Language.JPN => "ベトベトン",
						Language.GER => "Sleimok",
						Language.FRE => "Grotadmorv",
						Language.ITA => "Muk",
						Language.SPN => "Muk",
						Language.KOR => "질뻐기",
						Language.CHN_SIM => "臭臭泥",
						Language.CHN_TRA => "臭臭泥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUK_ALOLAN_MUK:
					return lang switch {
						Language.ENG => "Muk",
						Language.JPN => "ベトベトン",
						Language.GER => "Sleimok",
						Language.FRE => "Grotadmorv",
						Language.ITA => "Muk",
						Language.SPN => "Muk",
						Language.KOR => "질뻐기",
						Language.CHN_SIM => "臭臭泥",
						Language.CHN_TRA => "臭臭泥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHELLDER:
					return lang switch {
						Language.ENG => "Shellder",
						Language.JPN => "シェルダー",
						Language.GER => "Muschas",
						Language.FRE => "Kokiyas",
						Language.ITA => "Shellder",
						Language.SPN => "Shellder",
						Language.KOR => "셀러",
						Language.CHN_SIM => "大舌贝",
						Language.CHN_TRA => "大舌貝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLOYSTER:
					return lang switch {
						Language.ENG => "Cloyster",
						Language.JPN => "パルシェン",
						Language.GER => "Austos",
						Language.FRE => "Crustabri",
						Language.ITA => "Cloyster",
						Language.SPN => "Cloyster",
						Language.KOR => "파르셀",
						Language.CHN_SIM => "刺甲贝",
						Language.CHN_TRA => "刺甲貝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GASTLY:
					return lang switch {
						Language.ENG => "Gastly",
						Language.JPN => "ゴース",
						Language.GER => "Nebulak",
						Language.FRE => "Fantominus",
						Language.ITA => "Gastly",
						Language.SPN => "Gastly",
						Language.KOR => "고오스",
						Language.CHN_SIM => "鬼斯",
						Language.CHN_TRA => "鬼斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HAUNTER:
					return lang switch {
						Language.ENG => "Haunter",
						Language.JPN => "ゴースト",
						Language.GER => "Alpollo",
						Language.FRE => "Spectrum",
						Language.ITA => "Haunter",
						Language.SPN => "Haunter",
						Language.KOR => "고우스트",
						Language.CHN_SIM => "鬼斯通",
						Language.CHN_TRA => "鬼斯通",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GENGAR:
					return lang switch {
						Language.ENG => "Gengar",
						Language.JPN => "ゲンガー",
						Language.GER => "Gengar",
						Language.FRE => "Ectoplasma",
						Language.ITA => "Gengar",
						Language.SPN => "Gengar",
						Language.KOR => "팬텀",
						Language.CHN_SIM => "耿鬼",
						Language.CHN_TRA => "耿鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GENGAR_MEGA_GENGAR:
					return lang switch {
						Language.ENG => "Gengar",
						Language.JPN => "ゲンガー",
						Language.GER => "Gengar",
						Language.FRE => "Ectoplasma",
						Language.ITA => "Gengar",
						Language.SPN => "Gengar",
						Language.KOR => "팬텀",
						Language.CHN_SIM => "耿鬼",
						Language.CHN_TRA => "耿鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ONIX:
					return lang switch {
						Language.ENG => "Onix",
						Language.JPN => "イワーク",
						Language.GER => "Onix",
						Language.FRE => "Onix",
						Language.ITA => "Onix",
						Language.SPN => "Onix",
						Language.KOR => "롱스톤",
						Language.CHN_SIM => "大岩蛇",
						Language.CHN_TRA => "大岩蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DROWZEE:
					return lang switch {
						Language.ENG => "Drowzee",
						Language.JPN => "スリープ",
						Language.GER => "Traumato",
						Language.FRE => "Soporifik",
						Language.ITA => "Drowzee",
						Language.SPN => "Drowzee",
						Language.KOR => "슬리프",
						Language.CHN_SIM => "催眠貘",
						Language.CHN_TRA => "催眠貘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HYPNO:
					return lang switch {
						Language.ENG => "Hypno",
						Language.JPN => "スリーパー",
						Language.GER => "Hypno",
						Language.FRE => "Hypnomade",
						Language.ITA => "Hypno",
						Language.SPN => "Hypno",
						Language.KOR => "슬리퍼",
						Language.CHN_SIM => "引梦貘人",
						Language.CHN_TRA => "引夢貘人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KRABBY:
					return lang switch {
						Language.ENG => "Krabby",
						Language.JPN => "クラブ",
						Language.GER => "Krabby",
						Language.FRE => "Krabby",
						Language.ITA => "Krabby",
						Language.SPN => "Krabby",
						Language.KOR => "크랩",
						Language.CHN_SIM => "大钳蟹",
						Language.CHN_TRA => "大鉗蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KINGLER:
					return lang switch {
						Language.ENG => "Kingler",
						Language.JPN => "キングラー",
						Language.GER => "Kingler",
						Language.FRE => "Krabboss",
						Language.ITA => "Kingler",
						Language.SPN => "Kingler",
						Language.KOR => "킹크랩",
						Language.CHN_SIM => "巨钳蟹",
						Language.CHN_TRA => "巨鉗蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VOLTORB:
					return lang switch {
						Language.ENG => "Voltorb",
						Language.JPN => "ビリリダマ",
						Language.GER => "Voltobal",
						Language.FRE => "Voltorbe",
						Language.ITA => "Voltorb",
						Language.SPN => "Voltorb",
						Language.KOR => "찌리리공",
						Language.CHN_SIM => "霹雳电球",
						Language.CHN_TRA => "霹靂電球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VOLTORB_HISUIAN_VOLTORB:
					return lang switch {
						Language.ENG => "Voltorb",
						Language.JPN => "ビリリダマ",
						Language.GER => "Voltobal",
						Language.FRE => "Voltorbe",
						Language.ITA => "Voltorb",
						Language.SPN => "Voltorb",
						Language.KOR => "찌리리공",
						Language.CHN_SIM => "霹雳电球",
						Language.CHN_TRA => "霹靂電球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELECTRODE:
					return lang switch {
						Language.ENG => "Electrode",
						Language.JPN => "マルマイン",
						Language.GER => "Lektrobal",
						Language.FRE => "Électrode",
						Language.ITA => "Electrode",
						Language.SPN => "Electrode",
						Language.KOR => "붐볼",
						Language.CHN_SIM => "顽皮雷弹",
						Language.CHN_TRA => "頑皮雷彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELECTRODE_HISUIAN_ELECTRODE:
					return lang switch {
						Language.ENG => "Electrode",
						Language.JPN => "マルマイン",
						Language.GER => "Lektrobal",
						Language.FRE => "Électrode",
						Language.ITA => "Electrode",
						Language.SPN => "Electrode",
						Language.KOR => "붐볼",
						Language.CHN_SIM => "顽皮雷弹",
						Language.CHN_TRA => "頑皮雷彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EXEGGCUTE:
					return lang switch {
						Language.ENG => "Exeggcute",
						Language.JPN => "タマタマ",
						Language.GER => "Owei",
						Language.FRE => "Noeunoeuf",
						Language.ITA => "Exeggcute",
						Language.SPN => "Exeggcute",
						Language.KOR => "아라리",
						Language.CHN_SIM => "蛋蛋",
						Language.CHN_TRA => "蛋蛋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EXEGGUTOR:
					return lang switch {
						Language.ENG => "Exeggutor",
						Language.JPN => "ナッシー",
						Language.GER => "Kokowei",
						Language.FRE => "Noadkoko",
						Language.ITA => "Exeggutor",
						Language.SPN => "Exeggutor",
						Language.KOR => "나시",
						Language.CHN_SIM => "椰蛋树",
						Language.CHN_TRA => "椰蛋樹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EXEGGUTOR_ALOLAN_EXEGGUTOR:
					return lang switch {
						Language.ENG => "Exeggutor",
						Language.JPN => "ナッシー",
						Language.GER => "Kokowei",
						Language.FRE => "Noadkoko",
						Language.ITA => "Exeggutor",
						Language.SPN => "Exeggutor",
						Language.KOR => "나시",
						Language.CHN_SIM => "椰蛋树",
						Language.CHN_TRA => "椰蛋樹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CUBONE:
					return lang switch {
						Language.ENG => "Cubone",
						Language.JPN => "カラカラ",
						Language.GER => "Tragosso",
						Language.FRE => "Osselait",
						Language.ITA => "Cubone",
						Language.SPN => "Cubone",
						Language.KOR => "탕구리",
						Language.CHN_SIM => "卡拉卡拉",
						Language.CHN_TRA => "卡拉卡拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAROWAK:
					return lang switch {
						Language.ENG => "Marowak",
						Language.JPN => "ガラガラ",
						Language.GER => "Knogga",
						Language.FRE => "Ossatueur",
						Language.ITA => "Marowak",
						Language.SPN => "Marowak",
						Language.KOR => "텅구리",
						Language.CHN_SIM => "嘎啦嘎啦",
						Language.CHN_TRA => "嘎啦嘎啦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAROWAK_ALOLAN_MAROWAK:
					return lang switch {
						Language.ENG => "Marowak",
						Language.JPN => "ガラガラ",
						Language.GER => "Knogga",
						Language.FRE => "Ossatueur",
						Language.ITA => "Marowak",
						Language.SPN => "Marowak",
						Language.KOR => "텅구리",
						Language.CHN_SIM => "嘎啦嘎啦",
						Language.CHN_TRA => "嘎啦嘎啦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HITMONLEE:
					return lang switch {
						Language.ENG => "Hitmonlee",
						Language.JPN => "サワムラー",
						Language.GER => "Kicklee",
						Language.FRE => "Kicklee",
						Language.ITA => "Hitmonlee",
						Language.SPN => "Hitmonlee",
						Language.KOR => "시라소몬",
						Language.CHN_SIM => "飞腿郎",
						Language.CHN_TRA => "飛腿郎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HITMONCHAN:
					return lang switch {
						Language.ENG => "Hitmonchan",
						Language.JPN => "エビワラー",
						Language.GER => "Nockchan",
						Language.FRE => "Tygnon",
						Language.ITA => "Hitmonchan",
						Language.SPN => "Hitmonchan",
						Language.KOR => "홍수몬",
						Language.CHN_SIM => "快拳郎",
						Language.CHN_TRA => "快拳郎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LICKITUNG:
					return lang switch {
						Language.ENG => "Lickitung",
						Language.JPN => "ベロリンガ",
						Language.GER => "Schlurp",
						Language.FRE => "Excelangue",
						Language.ITA => "Lickitung",
						Language.SPN => "Lickitung",
						Language.KOR => "내루미",
						Language.CHN_SIM => "大舌头",
						Language.CHN_TRA => "大舌頭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KOFFING:
					return lang switch {
						Language.ENG => "Koffing",
						Language.JPN => "ドガース",
						Language.GER => "Smogon",
						Language.FRE => "Smogo",
						Language.ITA => "Koffing",
						Language.SPN => "Koffing",
						Language.KOR => "또가스",
						Language.CHN_SIM => "瓦斯弹",
						Language.CHN_TRA => "瓦斯彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WEEZING:
					return lang switch {
						Language.ENG => "Weezing",
						Language.JPN => "マタドガス",
						Language.GER => "Smogmog",
						Language.FRE => "Smogogo",
						Language.ITA => "Weezing",
						Language.SPN => "Weezing",
						Language.KOR => "또도가스",
						Language.CHN_SIM => "双弹瓦斯",
						Language.CHN_TRA => "雙彈瓦斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WEEZING_GALARIAN_WEEZING:
					return lang switch {
						Language.ENG => "Weezing",
						Language.JPN => "マタドガス",
						Language.GER => "Smogmog",
						Language.FRE => "Smogogo",
						Language.ITA => "Weezing",
						Language.SPN => "Weezing",
						Language.KOR => "또도가스",
						Language.CHN_SIM => "双弹瓦斯",
						Language.CHN_TRA => "雙彈瓦斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RHYHORN:
					return lang switch {
						Language.ENG => "Rhyhorn",
						Language.JPN => "サイホーン",
						Language.GER => "Rihorn",
						Language.FRE => "Rhinocorne",
						Language.ITA => "Rhyhorn",
						Language.SPN => "Rhyhorn",
						Language.KOR => "뿔카노",
						Language.CHN_SIM => "独角犀牛",
						Language.CHN_TRA => "獨角犀牛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RHYDON:
					return lang switch {
						Language.ENG => "Rhydon",
						Language.JPN => "サイドン",
						Language.GER => "Rizeros",
						Language.FRE => "Rhinoféros",
						Language.ITA => "Rhydon",
						Language.SPN => "Rhydon",
						Language.KOR => "코뿌리",
						Language.CHN_SIM => "钻角犀兽",
						Language.CHN_TRA => "鑽角犀獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHANSEY:
					return lang switch {
						Language.ENG => "Chansey",
						Language.JPN => "ラッキー",
						Language.GER => "Chaneira",
						Language.FRE => "Leveinard",
						Language.ITA => "Chansey",
						Language.SPN => "Chansey",
						Language.KOR => "럭키",
						Language.CHN_SIM => "吉利蛋",
						Language.CHN_TRA => "吉利蛋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TANGELA:
					return lang switch {
						Language.ENG => "Tangela",
						Language.JPN => "モンジャラ",
						Language.GER => "Tangela",
						Language.FRE => "Saquedeneu",
						Language.ITA => "Tangela",
						Language.SPN => "Tangela",
						Language.KOR => "덩쿠리",
						Language.CHN_SIM => "蔓藤怪",
						Language.CHN_TRA => "蔓藤怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KANGASKHAN:
					return lang switch {
						Language.ENG => "Kangaskhan",
						Language.JPN => "ガルーラ",
						Language.GER => "Kangama",
						Language.FRE => "Kangourex",
						Language.ITA => "Kangaskhan",
						Language.SPN => "Kangaskhan",
						Language.KOR => "캥카",
						Language.CHN_SIM => "袋兽",
						Language.CHN_TRA => "袋獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KANGASKHAN_MEGA_KANGASKHAN:
					return lang switch {
						Language.ENG => "Kangaskhan",
						Language.JPN => "ガルーラ",
						Language.GER => "Kangama",
						Language.FRE => "Kangourex",
						Language.ITA => "Kangaskhan",
						Language.SPN => "Kangaskhan",
						Language.KOR => "캥카",
						Language.CHN_SIM => "袋兽",
						Language.CHN_TRA => "袋獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HORSEA:
					return lang switch {
						Language.ENG => "Horsea",
						Language.JPN => "タッツー",
						Language.GER => "Seeper",
						Language.FRE => "Hypotrempe",
						Language.ITA => "Horsea",
						Language.SPN => "Horsea",
						Language.KOR => "쏘드라",
						Language.CHN_SIM => "墨海马",
						Language.CHN_TRA => "墨海馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEADRA:
					return lang switch {
						Language.ENG => "Seadra",
						Language.JPN => "シードラ",
						Language.GER => "Seemon",
						Language.FRE => "Hypocéan",
						Language.ITA => "Seadra",
						Language.SPN => "Seadra",
						Language.KOR => "시드라",
						Language.CHN_SIM => "海刺龙",
						Language.CHN_TRA => "海刺龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLDEEN:
					return lang switch {
						Language.ENG => "Goldeen",
						Language.JPN => "トサキント",
						Language.GER => "Goldini",
						Language.FRE => "Poissirène",
						Language.ITA => "Goldeen",
						Language.SPN => "Goldeen",
						Language.KOR => "콘치",
						Language.CHN_SIM => "角金鱼",
						Language.CHN_TRA => "角金魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEAKING:
					return lang switch {
						Language.ENG => "Seaking",
						Language.JPN => "アズマオウ",
						Language.GER => "Golking",
						Language.FRE => "Poissoroy",
						Language.ITA => "Seaking",
						Language.SPN => "Seaking",
						Language.KOR => "왕콘치",
						Language.CHN_SIM => "金鱼王",
						Language.CHN_TRA => "金魚王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STARYU:
					return lang switch {
						Language.ENG => "Staryu",
						Language.JPN => "ヒトデマン",
						Language.GER => "Sterndu",
						Language.FRE => "Stari",
						Language.ITA => "Staryu",
						Language.SPN => "Staryu",
						Language.KOR => "별가사리",
						Language.CHN_SIM => "海星星",
						Language.CHN_TRA => "海星星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STARMIE:
					return lang switch {
						Language.ENG => "Starmie",
						Language.JPN => "スターミー",
						Language.GER => "Starmie",
						Language.FRE => "Staross",
						Language.ITA => "Starmie",
						Language.SPN => "Starmie",
						Language.KOR => "아쿠스타",
						Language.CHN_SIM => "宝石海星",
						Language.CHN_TRA => "寶石海星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MR_MIME:
					return lang switch {
						Language.ENG => "Mr. Mime",
						Language.JPN => "バリヤード",
						Language.GER => "Pantimos",
						Language.FRE => "M. Mime",
						Language.ITA => "Mr. Mime",
						Language.SPN => "Mr. Mime",
						Language.KOR => "마임맨",
						Language.CHN_SIM => "魔墙人偶",
						Language.CHN_TRA => "魔牆人偶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MR_MIME_GALARIAN_MR_MIME:
					return lang switch {
						Language.ENG => "Mr. Mime",
						Language.JPN => "バリヤード",
						Language.GER => "Pantimos",
						Language.FRE => "M. Mime",
						Language.ITA => "Mr. Mime",
						Language.SPN => "Mr. Mime",
						Language.KOR => "마임맨",
						Language.CHN_SIM => "魔墙人偶",
						Language.CHN_TRA => "魔牆人偶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCYTHER:
					return lang switch {
						Language.ENG => "Scyther",
						Language.JPN => "ストライク",
						Language.GER => "Sichlor",
						Language.FRE => "Insécateur",
						Language.ITA => "Scyther",
						Language.SPN => "Scyther",
						Language.KOR => "스라크",
						Language.CHN_SIM => "飞天螳螂",
						Language.CHN_TRA => "飛天螳螂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JYNX:
					return lang switch {
						Language.ENG => "Jynx",
						Language.JPN => "ルージュラ",
						Language.GER => "Rossana",
						Language.FRE => "Lippoutou",
						Language.ITA => "Jynx",
						Language.SPN => "Jynx",
						Language.KOR => "루주라",
						Language.CHN_SIM => "迷唇姐",
						Language.CHN_TRA => "迷唇姐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELECTABUZZ:
					return lang switch {
						Language.ENG => "Electabuzz",
						Language.JPN => "エレブー",
						Language.GER => "Elektek",
						Language.FRE => "Élektek",
						Language.ITA => "Electabuzz",
						Language.SPN => "Electabuzz",
						Language.KOR => "에레브",
						Language.CHN_SIM => "电击兽",
						Language.CHN_TRA => "電擊獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGMAR:
					return lang switch {
						Language.ENG => "Magmar",
						Language.JPN => "ブーバー",
						Language.GER => "Magmar",
						Language.FRE => "Magmar",
						Language.ITA => "Magmar",
						Language.SPN => "Magmar",
						Language.KOR => "마그마",
						Language.CHN_SIM => "鸭嘴火兽",
						Language.CHN_TRA => "鴨嘴火獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PINSIR:
					return lang switch {
						Language.ENG => "Pinsir",
						Language.JPN => "カイロス",
						Language.GER => "Pinsir",
						Language.FRE => "Scarabrute",
						Language.ITA => "Pinsir",
						Language.SPN => "Pinsir",
						Language.KOR => "쁘사이저",
						Language.CHN_SIM => "凯罗斯",
						Language.CHN_TRA => "凱羅斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PINSIR_MEGA_PINSIR:
					return lang switch {
						Language.ENG => "Pinsir",
						Language.JPN => "カイロス",
						Language.GER => "Pinsir",
						Language.FRE => "Scarabrute",
						Language.ITA => "Pinsir",
						Language.SPN => "Pinsir",
						Language.KOR => "쁘사이저",
						Language.CHN_SIM => "凯罗斯",
						Language.CHN_TRA => "凱羅斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAUROS:
					return lang switch {
						Language.ENG => "Tauros",
						Language.JPN => "ケンタロス",
						Language.GER => "Tauros",
						Language.FRE => "Tauros",
						Language.ITA => "Tauros",
						Language.SPN => "Tauros",
						Language.KOR => "켄타로스",
						Language.CHN_SIM => "肯泰罗",
						Language.CHN_TRA => "肯泰羅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAUROS_COMBAT_BREED:
					return lang switch {
						Language.ENG => "Tauros",
						Language.JPN => "ケンタロス",
						Language.GER => "Tauros",
						Language.FRE => "Tauros",
						Language.ITA => "Tauros",
						Language.SPN => "Tauros",
						Language.KOR => "켄타로스",
						Language.CHN_SIM => "肯泰罗",
						Language.CHN_TRA => "肯泰羅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAUROS_BLAZE_BREED:
					return lang switch {
						Language.ENG => "Tauros",
						Language.JPN => "ケンタロス",
						Language.GER => "Tauros",
						Language.FRE => "Tauros",
						Language.ITA => "Tauros",
						Language.SPN => "Tauros",
						Language.KOR => "켄타로스",
						Language.CHN_SIM => "肯泰罗",
						Language.CHN_TRA => "肯泰羅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAUROS_AQUA_BREED:
					return lang switch {
						Language.ENG => "Tauros",
						Language.JPN => "ケンタロス",
						Language.GER => "Tauros",
						Language.FRE => "Tauros",
						Language.ITA => "Tauros",
						Language.SPN => "Tauros",
						Language.KOR => "켄타로스",
						Language.CHN_SIM => "肯泰罗",
						Language.CHN_TRA => "肯泰羅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGIKARP:
					return lang switch {
						Language.ENG => "Magikarp",
						Language.JPN => "コイキング",
						Language.GER => "Karpador",
						Language.FRE => "Magicarpe",
						Language.ITA => "Magikarp",
						Language.SPN => "Magikarp",
						Language.KOR => "잉어킹",
						Language.CHN_SIM => "鲤鱼王",
						Language.CHN_TRA => "鯉魚王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GYARADOS:
					return lang switch {
						Language.ENG => "Gyarados",
						Language.JPN => "ギャラドス",
						Language.GER => "Garados",
						Language.FRE => "Léviator",
						Language.ITA => "Gyarados",
						Language.SPN => "Gyarados",
						Language.KOR => "갸라도스",
						Language.CHN_SIM => "暴鲤龙",
						Language.CHN_TRA => "暴鯉龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GYARADOS_MEGA_GYARADOS:
					return lang switch {
						Language.ENG => "Gyarados",
						Language.JPN => "ギャラドス",
						Language.GER => "Garados",
						Language.FRE => "Léviator",
						Language.ITA => "Gyarados",
						Language.SPN => "Gyarados",
						Language.KOR => "갸라도스",
						Language.CHN_SIM => "暴鲤龙",
						Language.CHN_TRA => "暴鯉龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LAPRAS:
					return lang switch {
						Language.ENG => "Lapras",
						Language.JPN => "ラプラス",
						Language.GER => "Lapras",
						Language.FRE => "Lokhlass",
						Language.ITA => "Lapras",
						Language.SPN => "Lapras",
						Language.KOR => "라프라스",
						Language.CHN_SIM => "拉普拉斯",
						Language.CHN_TRA => "拉普拉斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DITTO:
					return lang switch {
						Language.ENG => "Ditto",
						Language.JPN => "メタモン",
						Language.GER => "Ditto",
						Language.FRE => "Métamorph",
						Language.ITA => "Ditto",
						Language.SPN => "Ditto",
						Language.KOR => "메타몽",
						Language.CHN_SIM => "百变怪",
						Language.CHN_TRA => "百變怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EEVEE:
					return lang switch {
						Language.ENG => "Eevee",
						Language.JPN => "イーブイ",
						Language.GER => "Evoli",
						Language.FRE => "Évoli",
						Language.ITA => "Eevee",
						Language.SPN => "Eevee",
						Language.KOR => "이브이",
						Language.CHN_SIM => "伊布",
						Language.CHN_TRA => "伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EEVEE_PARTNER_EEVEE:
					return lang switch {
						Language.ENG => "Eevee",
						Language.JPN => "イーブイ",
						Language.GER => "Evoli",
						Language.FRE => "Évoli",
						Language.ITA => "Eevee",
						Language.SPN => "Eevee",
						Language.KOR => "이브이",
						Language.CHN_SIM => "伊布",
						Language.CHN_TRA => "伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VAPOREON:
					return lang switch {
						Language.ENG => "Vaporeon",
						Language.JPN => "シャワーズ",
						Language.GER => "Aquana",
						Language.FRE => "Aquali",
						Language.ITA => "Vaporeon",
						Language.SPN => "Vaporeon",
						Language.KOR => "샤미드",
						Language.CHN_SIM => "水伊布",
						Language.CHN_TRA => "水伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JOLTEON:
					return lang switch {
						Language.ENG => "Jolteon",
						Language.JPN => "サンダース",
						Language.GER => "Blitza",
						Language.FRE => "Voltali",
						Language.ITA => "Jolteon",
						Language.SPN => "Jolteon",
						Language.KOR => "쥬피썬더",
						Language.CHN_SIM => "雷伊布",
						Language.CHN_TRA => "雷伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLAREON:
					return lang switch {
						Language.ENG => "Flareon",
						Language.JPN => "ブースター",
						Language.GER => "Flamara",
						Language.FRE => "Pyroli",
						Language.ITA => "Flareon",
						Language.SPN => "Flareon",
						Language.KOR => "부스터",
						Language.CHN_SIM => "火伊布",
						Language.CHN_TRA => "火伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PORYGON:
					return lang switch {
						Language.ENG => "Porygon",
						Language.JPN => "ポリゴン",
						Language.GER => "Porygon",
						Language.FRE => "Porygon",
						Language.ITA => "Porygon",
						Language.SPN => "Porygon",
						Language.KOR => "폴리곤",
						Language.CHN_SIM => "多边兽",
						Language.CHN_TRA => "多邊獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OMANYTE:
					return lang switch {
						Language.ENG => "Omanyte",
						Language.JPN => "オムナイト",
						Language.GER => "Amonitas",
						Language.FRE => "Amonita",
						Language.ITA => "Omanyte",
						Language.SPN => "Omanyte",
						Language.KOR => "암나이트",
						Language.CHN_SIM => "菊石兽",
						Language.CHN_TRA => "菊石獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OMASTAR:
					return lang switch {
						Language.ENG => "Omastar",
						Language.JPN => "オムスター",
						Language.GER => "Amoroso",
						Language.FRE => "Amonistar",
						Language.ITA => "Omastar",
						Language.SPN => "Omastar",
						Language.KOR => "암스타",
						Language.CHN_SIM => "多刺菊石兽",
						Language.CHN_TRA => "多刺菊石獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KABUTO:
					return lang switch {
						Language.ENG => "Kabuto",
						Language.JPN => "カブト",
						Language.GER => "Kabuto",
						Language.FRE => "Kabuto",
						Language.ITA => "Kabuto",
						Language.SPN => "Kabuto",
						Language.KOR => "투구",
						Language.CHN_SIM => "化石盔",
						Language.CHN_TRA => "化石盔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KABUTOPS:
					return lang switch {
						Language.ENG => "Kabutops",
						Language.JPN => "カブトプス",
						Language.GER => "Kabutops",
						Language.FRE => "Kabutops",
						Language.ITA => "Kabutops",
						Language.SPN => "Kabutops",
						Language.KOR => "투구푸스",
						Language.CHN_SIM => "镰刀盔",
						Language.CHN_TRA => "鐮刀盔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AERODACTYL:
					return lang switch {
						Language.ENG => "Aerodactyl",
						Language.JPN => "プテラ",
						Language.GER => "Aerodactyl",
						Language.FRE => "Ptéra",
						Language.ITA => "Aerodactyl",
						Language.SPN => "Aerodactyl",
						Language.KOR => "프테라",
						Language.CHN_SIM => "化石翼龙",
						Language.CHN_TRA => "化石翼龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AERODACTYL_MEGA_AERODACTYL:
					return lang switch {
						Language.ENG => "Aerodactyl",
						Language.JPN => "プテラ",
						Language.GER => "Aerodactyl",
						Language.FRE => "Ptéra",
						Language.ITA => "Aerodactyl",
						Language.SPN => "Aerodactyl",
						Language.KOR => "프테라",
						Language.CHN_SIM => "化石翼龙",
						Language.CHN_TRA => "化石翼龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNORLAX:
					return lang switch {
						Language.ENG => "Snorlax",
						Language.JPN => "カビゴン",
						Language.GER => "Relaxo",
						Language.FRE => "Ronflex",
						Language.ITA => "Snorlax",
						Language.SPN => "Snorlax",
						Language.KOR => "잠만보",
						Language.CHN_SIM => "卡比兽",
						Language.CHN_TRA => "卡比獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARTICUNO:
					return lang switch {
						Language.ENG => "Articuno",
						Language.JPN => "フリーザー",
						Language.GER => "Arktos",
						Language.FRE => "Artikodin",
						Language.ITA => "Articuno",
						Language.SPN => "Articuno",
						Language.KOR => "프리져",
						Language.CHN_SIM => "急冻鸟",
						Language.CHN_TRA => "急凍鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARTICUNO_GALARIAN_ARTICUNO:
					return lang switch {
						Language.ENG => "Articuno",
						Language.JPN => "フリーザー",
						Language.GER => "Arktos",
						Language.FRE => "Artikodin",
						Language.ITA => "Articuno",
						Language.SPN => "Articuno",
						Language.KOR => "프리져",
						Language.CHN_SIM => "急冻鸟",
						Language.CHN_TRA => "急凍鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZAPDOS:
					return lang switch {
						Language.ENG => "Zapdos",
						Language.JPN => "サンダー",
						Language.GER => "Zapdos",
						Language.FRE => "Électhor",
						Language.ITA => "Zapdos",
						Language.SPN => "Zapdos",
						Language.KOR => "썬더",
						Language.CHN_SIM => "闪电鸟",
						Language.CHN_TRA => "閃電鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZAPDOS_GALARIAN_ZAPDOS:
					return lang switch {
						Language.ENG => "Zapdos",
						Language.JPN => "サンダー",
						Language.GER => "Zapdos",
						Language.FRE => "Électhor",
						Language.ITA => "Zapdos",
						Language.SPN => "Zapdos",
						Language.KOR => "썬더",
						Language.CHN_SIM => "闪电鸟",
						Language.CHN_TRA => "閃電鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MOLTRES:
					return lang switch {
						Language.ENG => "Moltres",
						Language.JPN => "ファイヤー",
						Language.GER => "Lavados",
						Language.FRE => "Sulfura",
						Language.ITA => "Moltres",
						Language.SPN => "Moltres",
						Language.KOR => "파이어",
						Language.CHN_SIM => "火焰鸟",
						Language.CHN_TRA => "火焰鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MOLTRES_GALARIAN_MOLTRES:
					return lang switch {
						Language.ENG => "Moltres",
						Language.JPN => "ファイヤー",
						Language.GER => "Lavados",
						Language.FRE => "Sulfura",
						Language.ITA => "Moltres",
						Language.SPN => "Moltres",
						Language.KOR => "파이어",
						Language.CHN_SIM => "火焰鸟",
						Language.CHN_TRA => "火焰鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRATINI:
					return lang switch {
						Language.ENG => "Dratini",
						Language.JPN => "ミニリュウ",
						Language.GER => "Dratini",
						Language.FRE => "Minidraco",
						Language.ITA => "Dratini",
						Language.SPN => "Dratini",
						Language.KOR => "미뇽",
						Language.CHN_SIM => "迷你龙",
						Language.CHN_TRA => "迷你龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAGONAIR:
					return lang switch {
						Language.ENG => "Dragonair",
						Language.JPN => "ハクリュー",
						Language.GER => "Dragonir",
						Language.FRE => "Draco",
						Language.ITA => "Dragonair",
						Language.SPN => "Dragonair",
						Language.KOR => "신뇽",
						Language.CHN_SIM => "哈克龙",
						Language.CHN_TRA => "哈克龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAGONITE:
					return lang switch {
						Language.ENG => "Dragonite",
						Language.JPN => "カイリュー",
						Language.GER => "Dragoran",
						Language.FRE => "Dracolosse",
						Language.ITA => "Dragonite",
						Language.SPN => "Dragonite",
						Language.KOR => "망나뇽",
						Language.CHN_SIM => "快龙",
						Language.CHN_TRA => "快龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEWTWO:
					return lang switch {
						Language.ENG => "Mewtwo",
						Language.JPN => "ミュウツー",
						Language.GER => "Mewtu",
						Language.FRE => "Mewtwo",
						Language.ITA => "Mewtwo",
						Language.SPN => "Mewtwo",
						Language.KOR => "뮤츠",
						Language.CHN_SIM => "超梦",
						Language.CHN_TRA => "超夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEWTWO_MEGA_MEWTWO_X:
					return lang switch {
						Language.ENG => "Mewtwo",
						Language.JPN => "ミュウツー",
						Language.GER => "Mewtu",
						Language.FRE => "Mewtwo",
						Language.ITA => "Mewtwo",
						Language.SPN => "Mewtwo",
						Language.KOR => "뮤츠",
						Language.CHN_SIM => "超梦",
						Language.CHN_TRA => "超夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEWTWO_MEGA_MEWTWO_Y:
					return lang switch {
						Language.ENG => "Mewtwo",
						Language.JPN => "ミュウツー",
						Language.GER => "Mewtu",
						Language.FRE => "Mewtwo",
						Language.ITA => "Mewtwo",
						Language.SPN => "Mewtwo",
						Language.KOR => "뮤츠",
						Language.CHN_SIM => "超梦",
						Language.CHN_TRA => "超夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEW:
					return lang switch {
						Language.ENG => "Mewtwo",
						Language.JPN => "ミュウツー",
						Language.GER => "Mewtu",
						Language.FRE => "Mewtwo",
						Language.ITA => "Mewtwo",
						Language.SPN => "Mewtwo",
						Language.KOR => "뮤츠",
						Language.CHN_SIM => "超梦",
						Language.CHN_TRA => "超夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHIKORITA:
					return lang switch {
						Language.ENG => "Chikorita",
						Language.JPN => "チコリータ",
						Language.GER => "Endivie",
						Language.FRE => "Germignon",
						Language.ITA => "Chikorita",
						Language.SPN => "Chikorita",
						Language.KOR => "치코리타",
						Language.CHN_SIM => "菊草叶",
						Language.CHN_TRA => "菊草葉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BAYLEEF:
					return lang switch {
						Language.ENG => "Bayleef",
						Language.JPN => "ベイリーフ",
						Language.GER => "Lorblatt",
						Language.FRE => "Macronium",
						Language.ITA => "Bayleef",
						Language.SPN => "Bayleef",
						Language.KOR => "베이리프",
						Language.CHN_SIM => "月桂叶",
						Language.CHN_TRA => "月桂葉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEGANIUM:
					return lang switch {
						Language.ENG => "Meganium",
						Language.JPN => "メガニウム",
						Language.GER => "Meganie",
						Language.FRE => "Méganium",
						Language.ITA => "Meganium",
						Language.SPN => "Meganium",
						Language.KOR => "메가니움",
						Language.CHN_SIM => "大竺葵",
						Language.CHN_TRA => "大竺葵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CYNDAQUIL:
					return lang switch {
						Language.ENG => "Cyndaquil",
						Language.JPN => "ヒノアラシ",
						Language.GER => "Feurigel",
						Language.FRE => "Héricendre",
						Language.ITA => "Cyndaquil",
						Language.SPN => "Cyndaquil",
						Language.KOR => "브케인",
						Language.CHN_SIM => "火球鼠",
						Language.CHN_TRA => "火球鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QUILAVA:
					return lang switch {
						Language.ENG => "Quilava",
						Language.JPN => "マグマラシ",
						Language.GER => "Igelavar",
						Language.FRE => "Feurisson",
						Language.ITA => "Quilava",
						Language.SPN => "Quilava",
						Language.KOR => "마그케인",
						Language.CHN_SIM => "火岩鼠",
						Language.CHN_TRA => "火岩鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYPHLOSION:
					return lang switch {
						Language.ENG => "Typhlosion",
						Language.JPN => "バクフーン",
						Language.GER => "Tornupto",
						Language.FRE => "Typhlosion",
						Language.ITA => "Typhlosion",
						Language.SPN => "Typhlosion",
						Language.KOR => "블레이범",
						Language.CHN_SIM => "火暴兽",
						Language.CHN_TRA => "火爆獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYPHLOSION_HISUIAN_TYPHLOSION:
					return lang switch {
						Language.ENG => "Typhlosion",
						Language.JPN => "バクフーン",
						Language.GER => "Tornupto",
						Language.FRE => "Typhlosion",
						Language.ITA => "Typhlosion",
						Language.SPN => "Typhlosion",
						Language.KOR => "블레이범",
						Language.CHN_SIM => "火暴兽",
						Language.CHN_TRA => "火爆獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOTODILE:
					return lang switch {
						Language.ENG => "Totodile",
						Language.JPN => "ワニノコ",
						Language.GER => "Karnimani",
						Language.FRE => "Kaiminus",
						Language.ITA => "Totodile",
						Language.SPN => "Totodile",
						Language.KOR => "리아코",
						Language.CHN_SIM => "小锯鳄",
						Language.CHN_TRA => "小鋸鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CROCONAW:
					return lang switch {
						Language.ENG => "Croconaw",
						Language.JPN => "アリゲイツ",
						Language.GER => "Tyracroc",
						Language.FRE => "Crocrodil",
						Language.ITA => "Croconaw",
						Language.SPN => "Croconaw",
						Language.KOR => "엘리게이",
						Language.CHN_SIM => "蓝鳄",
						Language.CHN_TRA => "藍鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FERALIGATR:
					return lang switch {
						Language.ENG => "Feraligatr",
						Language.JPN => "オーダイル",
						Language.GER => "Impergator",
						Language.FRE => "Aligatueur",
						Language.ITA => "Feraligatr",
						Language.SPN => "Feraligatr",
						Language.KOR => "장크로다일",
						Language.CHN_SIM => "大力鳄",
						Language.CHN_TRA => "大力鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SENTRET:
					return lang switch {
						Language.ENG => "Sentret",
						Language.JPN => "オタチ",
						Language.GER => "Wiesor",
						Language.FRE => "Fouinette",
						Language.ITA => "Sentret",
						Language.SPN => "Sentret",
						Language.KOR => "꼬리선",
						Language.CHN_SIM => "尾立",
						Language.CHN_TRA => "尾立",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FURRET:
					return lang switch {
						Language.ENG => "Furret",
						Language.JPN => "オオタチ",
						Language.GER => "Wiesenior",
						Language.FRE => "Fouinar",
						Language.ITA => "Furret",
						Language.SPN => "Furret",
						Language.KOR => "다꼬리",
						Language.CHN_SIM => "大尾立",
						Language.CHN_TRA => "大尾立",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOOTHOOT:
					return lang switch {
						Language.ENG => "Hoothoot",
						Language.JPN => "ホーホー",
						Language.GER => "Hoothoot",
						Language.FRE => "Hoothoot",
						Language.ITA => "Hoothoot",
						Language.SPN => "Hoothoot",
						Language.KOR => "부우부",
						Language.CHN_SIM => "咕咕",
						Language.CHN_TRA => "咕咕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NOCTOWL:
					return lang switch {
						Language.ENG => "Noctowl",
						Language.JPN => "ヨルノズク",
						Language.GER => "Noctuh",
						Language.FRE => "Noarfang",
						Language.ITA => "Noctowl",
						Language.SPN => "Noctowl",
						Language.KOR => "야부엉",
						Language.CHN_SIM => "猫头夜鹰",
						Language.CHN_TRA => "貓頭夜鷹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LEDYBA:
					return lang switch {
						Language.ENG => "Ledyba",
						Language.JPN => "レディバ",
						Language.GER => "Ledyba",
						Language.FRE => "Coxy",
						Language.ITA => "Ledyba",
						Language.SPN => "Ledyba",
						Language.KOR => "레디바",
						Language.CHN_SIM => "芭瓢虫",
						Language.CHN_TRA => "芭瓢蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LEDIAN:
					return lang switch {
						Language.ENG => "Ledian",
						Language.JPN => "レディアン",
						Language.GER => "Ledian",
						Language.FRE => "Coxyclaque",
						Language.ITA => "Ledian",
						Language.SPN => "Ledian",
						Language.KOR => "레디안",
						Language.CHN_SIM => "安瓢虫",
						Language.CHN_TRA => "安瓢蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPINARAK:
					return lang switch {
						Language.ENG => "Spinarak",
						Language.JPN => "イトマル",
						Language.GER => "Webarak",
						Language.FRE => "Mimigal",
						Language.ITA => "Spinarak",
						Language.SPN => "Spinarak",
						Language.KOR => "페이검",
						Language.CHN_SIM => "圆丝蛛",
						Language.CHN_TRA => "圓絲蛛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARIADOS:
					return lang switch {
						Language.ENG => "Ariados",
						Language.JPN => "アリアドス",
						Language.GER => "Ariados",
						Language.FRE => "Migalos",
						Language.ITA => "Ariados",
						Language.SPN => "Ariados",
						Language.KOR => "아리아도스",
						Language.CHN_SIM => "阿利多斯",
						Language.CHN_TRA => "阿利多斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CROBAT:
					return lang switch {
						Language.ENG => "Crobat",
						Language.JPN => "クロバット",
						Language.GER => "Iksbat",
						Language.FRE => "Nostenfer",
						Language.ITA => "Crobat",
						Language.SPN => "Crobat",
						Language.KOR => "크로뱃",
						Language.CHN_SIM => "叉字蝠",
						Language.CHN_TRA => "叉字蝠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHINCHOU:
					return lang switch {
						Language.ENG => "Chinchou",
						Language.JPN => "チョンチー",
						Language.GER => "Lampi",
						Language.FRE => "Loupio",
						Language.ITA => "Chinchou",
						Language.SPN => "Chinchou",
						Language.KOR => "초라기",
						Language.CHN_SIM => "灯笼鱼",
						Language.CHN_TRA => "燈籠魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LANTURN:
					return lang switch {
						Language.ENG => "Lanturn",
						Language.JPN => "ランターン",
						Language.GER => "Lanturn",
						Language.FRE => "Lanturn",
						Language.ITA => "Lanturn",
						Language.SPN => "Lanturn",
						Language.KOR => "랜턴",
						Language.CHN_SIM => "电灯怪",
						Language.CHN_TRA => "電燈怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PICHU:
					return lang switch {
						Language.ENG => "Pichu",
						Language.JPN => "ピチュー",
						Language.GER => "Pichu",
						Language.FRE => "Pichu",
						Language.ITA => "Pichu",
						Language.SPN => "Pichu",
						Language.KOR => "피츄",
						Language.CHN_SIM => "皮丘",
						Language.CHN_TRA => "皮丘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLEFFA:
					return lang switch {
						Language.ENG => "Cleffa",
						Language.JPN => "ピィ",
						Language.GER => "Pii",
						Language.FRE => "Mélo",
						Language.ITA => "Cleffa",
						Language.SPN => "Cleffa",
						Language.KOR => "삐",
						Language.CHN_SIM => "皮宝宝",
						Language.CHN_TRA => "皮寶寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IGGLYBUFF:
					return lang switch {
						Language.ENG => "Igglybuff",
						Language.JPN => "ププリン",
						Language.GER => "Fluffeluff",
						Language.FRE => "Toudoudou",
						Language.ITA => "Igglybuff",
						Language.SPN => "Igglybuff",
						Language.KOR => "푸푸린",
						Language.CHN_SIM => "宝宝丁",
						Language.CHN_TRA => "寶寶丁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOGEPI:
					return lang switch {
						Language.ENG => "Togepi",
						Language.JPN => "トゲピー",
						Language.GER => "Togepi",
						Language.FRE => "Togepi",
						Language.ITA => "Togepi",
						Language.SPN => "Togepi",
						Language.KOR => "토게피",
						Language.CHN_SIM => "波克比",
						Language.CHN_TRA => "波克比",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOGETIC:
					return lang switch {
						Language.ENG => "Togetic",
						Language.JPN => "トゲチック",
						Language.GER => "Togetic",
						Language.FRE => "Togetic",
						Language.ITA => "Togetic",
						Language.SPN => "Togetic",
						Language.KOR => "토게틱",
						Language.CHN_SIM => "波克基古",
						Language.CHN_TRA => "波克基古",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NATU:
					return lang switch {
						Language.ENG => "Natu",
						Language.JPN => "ネイティ",
						Language.GER => "Natu",
						Language.FRE => "Natu",
						Language.ITA => "Natu",
						Language.SPN => "Natu",
						Language.KOR => "네이티",
						Language.CHN_SIM => "天然雀",
						Language.CHN_TRA => "天然雀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.XATU:
					return lang switch {
						Language.ENG => "Xatu",
						Language.JPN => "ネイティオ",
						Language.GER => "Xatu",
						Language.FRE => "Xatu",
						Language.ITA => "Xatu",
						Language.SPN => "Xatu",
						Language.KOR => "네이티오",
						Language.CHN_SIM => "天然鸟",
						Language.CHN_TRA => "天然鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAREEP:
					return lang switch {
						Language.ENG => "Mareep",
						Language.JPN => "メリープ",
						Language.GER => "Voltilamm",
						Language.FRE => "Wattouat",
						Language.ITA => "Mareep",
						Language.SPN => "Mareep",
						Language.KOR => "메리프",
						Language.CHN_SIM => "咩利羊",
						Language.CHN_TRA => "咩利羊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLAAFFY:
					return lang switch {
						Language.ENG => "Flaaffy",
						Language.JPN => "モココ",
						Language.GER => "Waaty",
						Language.FRE => "Lainergie",
						Language.ITA => "Flaaffy",
						Language.SPN => "Flaaffy",
						Language.KOR => "보송송",
						Language.CHN_SIM => "茸茸羊",
						Language.CHN_TRA => "茸茸羊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AMPHAROS:
					return lang switch {
						Language.ENG => "Ampharos",
						Language.JPN => "デンリュウ",
						Language.GER => "Ampharos",
						Language.FRE => "Pharamp",
						Language.ITA => "Ampharos",
						Language.SPN => "Ampharos",
						Language.KOR => "전룡",
						Language.CHN_SIM => "电龙",
						Language.CHN_TRA => "電龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AMPHAROS_MEGA_AMPHAROS:
					return lang switch {
						Language.ENG => "Ampharos",
						Language.JPN => "デンリュウ",
						Language.GER => "Ampharos",
						Language.FRE => "Pharamp",
						Language.ITA => "Ampharos",
						Language.SPN => "Ampharos",
						Language.KOR => "전룡",
						Language.CHN_SIM => "电龙",
						Language.CHN_TRA => "電龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BELLOSSOM:
					return lang switch {
						Language.ENG => "Bellossom",
						Language.JPN => "キレイハナ",
						Language.GER => "Blubella",
						Language.FRE => "Joliflor",
						Language.ITA => "Bellossom",
						Language.SPN => "Bellossom",
						Language.KOR => "아르코",
						Language.CHN_SIM => "美丽花",
						Language.CHN_TRA => "美麗花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MARILL:
					return lang switch {
						Language.ENG => "Marill",
						Language.JPN => "マリル",
						Language.GER => "Marill",
						Language.FRE => "Marill",
						Language.ITA => "Marill",
						Language.SPN => "Marill",
						Language.KOR => "마릴",
						Language.CHN_SIM => "玛力露",
						Language.CHN_TRA => "瑪力露",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AZUMARILL:
					return lang switch {
						Language.ENG => "Azumarill",
						Language.JPN => "マリルリ",
						Language.GER => "Azumarill",
						Language.FRE => "Azumarill",
						Language.ITA => "Azumarill",
						Language.SPN => "Azumarill",
						Language.KOR => "마릴리",
						Language.CHN_SIM => "玛力露丽",
						Language.CHN_TRA => "瑪力露麗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SUDOWOODO:
					return lang switch {
						Language.ENG => "Sudowoodo",
						Language.JPN => "ウソッキー",
						Language.GER => "Mogelbaum",
						Language.FRE => "Simularbre",
						Language.ITA => "Sudowoodo",
						Language.SPN => "Sudowoodo",
						Language.KOR => "꼬지모",
						Language.CHN_SIM => "树才怪",
						Language.CHN_TRA => "樹才怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POLITOED:
					return lang switch {
						Language.ENG => "Politoed",
						Language.JPN => "ニョロトノ",
						Language.GER => "Quaxo",
						Language.FRE => "Tarpaud",
						Language.ITA => "Politoed",
						Language.SPN => "Politoed",
						Language.KOR => "왕구리",
						Language.CHN_SIM => "蚊香蛙皇",
						Language.CHN_TRA => "蚊香蛙皇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOPPIP:
					return lang switch {
						Language.ENG => "Hoppip",
						Language.JPN => "ハネッコ",
						Language.GER => "Hoppspross",
						Language.FRE => "Granivol",
						Language.ITA => "Hoppip",
						Language.SPN => "Hoppip",
						Language.KOR => "통통코",
						Language.CHN_SIM => "毽子草",
						Language.CHN_TRA => "毽子草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKIPLOOM:
					return lang switch {
						Language.ENG => "Skiploom",
						Language.JPN => "ポポッコ",
						Language.GER => "Hubelupf",
						Language.FRE => "Floravol",
						Language.ITA => "Skiploom",
						Language.SPN => "Skiploom",
						Language.KOR => "두코",
						Language.CHN_SIM => "毽子花",
						Language.CHN_TRA => "毽子花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JUMPLUFF:
					return lang switch {
						Language.ENG => "Jumpluff",
						Language.JPN => "ワタッコ",
						Language.GER => "Papungha",
						Language.FRE => "Cotovol",
						Language.ITA => "Jumpluff",
						Language.SPN => "Jumpluff",
						Language.KOR => "솜솜코",
						Language.CHN_SIM => "毽子棉",
						Language.CHN_TRA => "毽子棉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AIPOM:
					return lang switch {
						Language.ENG => "Aipom",
						Language.JPN => "エイパム",
						Language.GER => "Griffel",
						Language.FRE => "Capumain",
						Language.ITA => "Aipom",
						Language.SPN => "Aipom",
						Language.KOR => "에이팜",
						Language.CHN_SIM => "长尾怪手",
						Language.CHN_TRA => "長尾怪手",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SUNKERN:
					return lang switch {
						Language.ENG => "Sunkern",
						Language.JPN => "ヒマナッツ",
						Language.GER => "Sonnkern",
						Language.FRE => "Tournegrin",
						Language.ITA => "Sunkern",
						Language.SPN => "Sunkern",
						Language.KOR => "해너츠",
						Language.CHN_SIM => "向日种子",
						Language.CHN_TRA => "向日種子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SUNFLORA:
					return lang switch {
						Language.ENG => "Sunflora",
						Language.JPN => "キマワリ",
						Language.GER => "Sonnflora",
						Language.FRE => "Héliatronc",
						Language.ITA => "Sunflora",
						Language.SPN => "Sunflora",
						Language.KOR => "해루미",
						Language.CHN_SIM => "向日花怪",
						Language.CHN_TRA => "向日花怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YANMA:
					return lang switch {
						Language.ENG => "Yanma",
						Language.JPN => "ヤンヤンマ",
						Language.GER => "Yanma",
						Language.FRE => "Yanma",
						Language.ITA => "Yanma",
						Language.SPN => "Yanma",
						Language.KOR => "왕자리",
						Language.CHN_SIM => "蜻蜻蜓",
						Language.CHN_TRA => "蜻蜻蜓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WOOPER:
					return lang switch {
						Language.ENG => "Wooper",
						Language.JPN => "ウパー",
						Language.GER => "Felino",
						Language.FRE => "Axoloto",
						Language.ITA => "Wooper",
						Language.SPN => "Wooper",
						Language.KOR => "우파",
						Language.CHN_SIM => "乌波",
						Language.CHN_TRA => "烏波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WOOPER_PALDEAN_WOOPER:
					return lang switch {
						Language.ENG => "Wooper",
						Language.JPN => "ウパー",
						Language.GER => "Felino",
						Language.FRE => "Axoloto",
						Language.ITA => "Wooper",
						Language.SPN => "Wooper",
						Language.KOR => "우파",
						Language.CHN_SIM => "乌波",
						Language.CHN_TRA => "烏波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QUAGSIRE:
					return lang switch {
						Language.ENG => "Quagsire",
						Language.JPN => "ヌオー",
						Language.GER => "Morlord",
						Language.FRE => "Maraiste",
						Language.ITA => "Quagsire",
						Language.SPN => "Quagsire",
						Language.KOR => "누오",
						Language.CHN_SIM => "沼王",
						Language.CHN_TRA => "沼王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ESPEON:
					return lang switch {
						Language.ENG => "Espeon",
						Language.JPN => "エーフィ",
						Language.GER => "Psiana",
						Language.FRE => "Mentali",
						Language.ITA => "Espeon",
						Language.SPN => "Espeon",
						Language.KOR => "에브이",
						Language.CHN_SIM => "太阳伊布",
						Language.CHN_TRA => "太陽伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.UMBREON:
					return lang switch {
						Language.ENG => "Umbreon",
						Language.JPN => "ブラッキー",
						Language.GER => "Nachtara",
						Language.FRE => "Noctali",
						Language.ITA => "Umbreon",
						Language.SPN => "Umbreon",
						Language.KOR => "블래키",
						Language.CHN_SIM => "月亮伊布",
						Language.CHN_TRA => "月亮伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MURKROW:
					return lang switch {
						Language.ENG => "Murkrow",
						Language.JPN => "ヤミカラス",
						Language.GER => "Kramurx",
						Language.FRE => "Cornèbre",
						Language.ITA => "Murkrow",
						Language.SPN => "Murkrow",
						Language.KOR => "니로우",
						Language.CHN_SIM => "黑暗鸦",
						Language.CHN_TRA => "黑暗鴉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWKING:
					return lang switch {
						Language.ENG => "Slowking",
						Language.JPN => "ヤドキング",
						Language.GER => "Laschoking",
						Language.FRE => "Roigada",
						Language.ITA => "Slowking",
						Language.SPN => "Slowking",
						Language.KOR => "야도킹",
						Language.CHN_SIM => "呆呆王",
						Language.CHN_TRA => "呆呆王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLOWKING_GALARIAN_SLOWKING:
					return lang switch {
						Language.ENG => "Slowking",
						Language.JPN => "ヤドキング",
						Language.GER => "Laschoking",
						Language.FRE => "Roigada",
						Language.ITA => "Slowking",
						Language.SPN => "Slowking",
						Language.KOR => "야도킹",
						Language.CHN_SIM => "呆呆王",
						Language.CHN_TRA => "呆呆王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MISDREAVUS:
					return lang switch {
						Language.ENG => "Misdreavus",
						Language.JPN => "ムウマ",
						Language.GER => "Traunfugil",
						Language.FRE => "Feuforêve",
						Language.ITA => "Misdreavus",
						Language.SPN => "Misdreavus",
						Language.KOR => "무우마",
						Language.CHN_SIM => "梦妖",
						Language.CHN_TRA => "夢妖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.UNOWN:
					return lang switch {
						Language.ENG => "Unown",
						Language.JPN => "アンノーン",
						Language.GER => "Icognito",
						Language.FRE => "Zarbi",
						Language.ITA => "Unown",
						Language.SPN => "Unown",
						Language.KOR => "안농",
						Language.CHN_SIM => "未知图腾",
						Language.CHN_TRA => "未知圖騰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WOBBUFFET:
					return lang switch {
						Language.ENG => "Wobbuffet",
						Language.JPN => "ソーナンス",
						Language.GER => "Woingenau",
						Language.FRE => "Qulbutoké",
						Language.ITA => "Wobbuffet",
						Language.SPN => "Wobbuffet",
						Language.KOR => "마자용",
						Language.CHN_SIM => "果然翁",
						Language.CHN_TRA => "果然翁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIRAFARIG:
					return lang switch {
						Language.ENG => "Girafarig",
						Language.JPN => "キリンリキ",
						Language.GER => "Girafarig",
						Language.FRE => "Girafarig",
						Language.ITA => "Girafarig",
						Language.SPN => "Girafarig",
						Language.KOR => "키링키",
						Language.CHN_SIM => "麒麟奇",
						Language.CHN_TRA => "麒麟奇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PINECO:
					return lang switch {
						Language.ENG => "Pineco",
						Language.JPN => "クヌギダマ",
						Language.GER => "Tannza",
						Language.FRE => "Pomdepik",
						Language.ITA => "Pineco",
						Language.SPN => "Pineco",
						Language.KOR => "피콘",
						Language.CHN_SIM => "榛果球",
						Language.CHN_TRA => "榛果球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FORRETRESS:
					return lang switch {
						Language.ENG => "Forretress",
						Language.JPN => "フォレトス",
						Language.GER => "Forstellka",
						Language.FRE => "Foretress",
						Language.ITA => "Forretress",
						Language.SPN => "Forretress",
						Language.KOR => "쏘콘",
						Language.CHN_SIM => "佛烈托斯",
						Language.CHN_TRA => "佛烈托斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUNSPARCE:
					return lang switch {
						Language.ENG => "Dunsparce",
						Language.JPN => "ノコッチ",
						Language.GER => "Dummisel",
						Language.FRE => "Insolourdo",
						Language.ITA => "Dunsparce",
						Language.SPN => "Dunsparce",
						Language.KOR => "노고치",
						Language.CHN_SIM => "土龙弟弟",
						Language.CHN_TRA => "土龍弟弟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLIGAR:
					return lang switch {
						Language.ENG => "Gligar",
						Language.JPN => "グライガー",
						Language.GER => "Skorgla",
						Language.FRE => "Scorplane",
						Language.ITA => "Gligar",
						Language.SPN => "Gligar",
						Language.KOR => "글라이거",
						Language.CHN_SIM => "天蝎",
						Language.CHN_TRA => "天蠍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STEELIX:
					return lang switch {
						Language.ENG => "Steelix",
						Language.JPN => "ハガネール",
						Language.GER => "Stahlos",
						Language.FRE => "Steelix",
						Language.ITA => "Steelix",
						Language.SPN => "Steelix",
						Language.KOR => "강철톤",
						Language.CHN_SIM => "大钢蛇",
						Language.CHN_TRA => "大鋼蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STEELIX_MEGA_STEELIX:
					return lang switch {
						Language.ENG => "Steelix",
						Language.JPN => "ハガネール",
						Language.GER => "Stahlos",
						Language.FRE => "Steelix",
						Language.ITA => "Steelix",
						Language.SPN => "Steelix",
						Language.KOR => "강철톤",
						Language.CHN_SIM => "大钢蛇",
						Language.CHN_TRA => "大鋼蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNUBBULL:
					return lang switch {
						Language.ENG => "Snubbull",
						Language.JPN => "ブルー",
						Language.GER => "Snubbull",
						Language.FRE => "Snubbull",
						Language.ITA => "Snubbull",
						Language.SPN => "Snubbull",
						Language.KOR => "블루",
						Language.CHN_SIM => "布鲁",
						Language.CHN_TRA => "布魯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRANBULL:
					return lang switch {
						Language.ENG => "Granbull",
						Language.JPN => "グランブル",
						Language.GER => "Granbull",
						Language.FRE => "Granbull",
						Language.ITA => "Granbull",
						Language.SPN => "Granbull",
						Language.KOR => "그랑블루",
						Language.CHN_SIM => "布鲁皇",
						Language.CHN_TRA => "布魯皇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QWILFISH:
					return lang switch {
						Language.ENG => "Qwilfish",
						Language.JPN => "ハリーセン",
						Language.GER => "Baldorfish",
						Language.FRE => "Qwilfish",
						Language.ITA => "Qwilfish",
						Language.SPN => "Qwilfish",
						Language.KOR => "침바루",
						Language.CHN_SIM => "千针鱼",
						Language.CHN_TRA => "千針魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QWILFISH_HISUIAN_QWILFISH:
					return lang switch {
						Language.ENG => "Qwilfish",
						Language.JPN => "ハリーセン",
						Language.GER => "Baldorfish",
						Language.FRE => "Qwilfish",
						Language.ITA => "Qwilfish",
						Language.SPN => "Qwilfish",
						Language.KOR => "침바루",
						Language.CHN_SIM => "千针鱼",
						Language.CHN_TRA => "千針魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCIZOR:
					return lang switch {
						Language.ENG => "Scizor",
						Language.JPN => "ハッサム",
						Language.GER => "Scherox",
						Language.FRE => "Cizayox",
						Language.ITA => "Scizor",
						Language.SPN => "Scizor",
						Language.KOR => "핫삼",
						Language.CHN_SIM => "巨钳螳螂",
						Language.CHN_TRA => "巨鉗螳螂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCIZOR_MEGA_SCIZOR:
					return lang switch {
						Language.ENG => "Scizor",
						Language.JPN => "ハッサム",
						Language.GER => "Scherox",
						Language.FRE => "Cizayox",
						Language.ITA => "Scizor",
						Language.SPN => "Scizor",
						Language.KOR => "핫삼",
						Language.CHN_SIM => "巨钳螳螂",
						Language.CHN_TRA => "巨鉗螳螂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHUCKLE:
					return lang switch {
						Language.ENG => "Shuckle",
						Language.JPN => "ツボツボ",
						Language.GER => "Pottrott",
						Language.FRE => "Caratroc",
						Language.ITA => "Shuckle",
						Language.SPN => "Shuckle",
						Language.KOR => "단단지",
						Language.CHN_SIM => "壶壶",
						Language.CHN_TRA => "壺壺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HERACROSS:
					return lang switch {
						Language.ENG => "Heracross",
						Language.JPN => "ヘラクロス",
						Language.GER => "Skaraborn",
						Language.FRE => "Scarhino",
						Language.ITA => "Heracross",
						Language.SPN => "Heracross",
						Language.KOR => "헤라크로스",
						Language.CHN_SIM => "赫拉克罗斯",
						Language.CHN_TRA => "赫拉克羅斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HERACROSS_MEGA_HERACROSS:
					return lang switch {
						Language.ENG => "Heracross",
						Language.JPN => "ヘラクロス",
						Language.GER => "Skaraborn",
						Language.FRE => "Scarhino",
						Language.ITA => "Heracross",
						Language.SPN => "Heracross",
						Language.KOR => "헤라크로스",
						Language.CHN_SIM => "赫拉克罗斯",
						Language.CHN_TRA => "赫拉克羅斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNEASEL:
					return lang switch {
						Language.ENG => "Sneasel",
						Language.JPN => "ニューラ",
						Language.GER => "Sniebel",
						Language.FRE => "Farfuret",
						Language.ITA => "Sneasel",
						Language.SPN => "Sneasel",
						Language.KOR => "포푸니",
						Language.CHN_SIM => "狃拉",
						Language.CHN_TRA => "狃拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNEASEL_HISUIAN_SNEASEL:
					return lang switch {
						Language.ENG => "Sneasel",
						Language.JPN => "ニューラ",
						Language.GER => "Sniebel",
						Language.FRE => "Farfuret",
						Language.ITA => "Sneasel",
						Language.SPN => "Sneasel",
						Language.KOR => "포푸니",
						Language.CHN_SIM => "狃拉",
						Language.CHN_TRA => "狃拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TEDDIURSA:
					return lang switch {
						Language.ENG => "Teddiursa",
						Language.JPN => "ヒメグマ",
						Language.GER => "Teddiursa",
						Language.FRE => "Teddiursa",
						Language.ITA => "Teddiursa",
						Language.SPN => "Teddiursa",
						Language.KOR => "깜지곰",
						Language.CHN_SIM => "熊宝宝",
						Language.CHN_TRA => "熊寶寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.URSARING:
					return lang switch {
						Language.ENG => "Ursaring",
						Language.JPN => "リングマ",
						Language.GER => "Ursaring",
						Language.FRE => "Ursaring",
						Language.ITA => "Ursaring",
						Language.SPN => "Ursaring",
						Language.KOR => "링곰",
						Language.CHN_SIM => "圈圈熊",
						Language.CHN_TRA => "圈圈熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLUGMA:
					return lang switch {
						Language.ENG => "Slugma",
						Language.JPN => "マグマッグ",
						Language.GER => "Schneckmag",
						Language.FRE => "Limagma",
						Language.ITA => "Slugma",
						Language.SPN => "Slugma",
						Language.KOR => "마그마그",
						Language.CHN_SIM => "熔岩虫",
						Language.CHN_TRA => "熔岩蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGCARGO:
					return lang switch {
						Language.ENG => "Magcargo",
						Language.JPN => "マグカルゴ",
						Language.GER => "Magcargo",
						Language.FRE => "Volcaropod",
						Language.ITA => "Magcargo",
						Language.SPN => "Magcargo",
						Language.KOR => "마그카르고",
						Language.CHN_SIM => "熔岩蜗牛",
						Language.CHN_TRA => "熔岩蝸牛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWINUB:
					return lang switch {
						Language.ENG => "Swinub",
						Language.JPN => "ウリムー",
						Language.GER => "Quiekel",
						Language.FRE => "Marcacrin",
						Language.ITA => "Swinub",
						Language.SPN => "Swinub",
						Language.KOR => "꾸꾸리",
						Language.CHN_SIM => "小山猪",
						Language.CHN_TRA => "小山豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PILOSWINE:
					return lang switch {
						Language.ENG => "Piloswine",
						Language.JPN => "イノムー",
						Language.GER => "Keifel",
						Language.FRE => "Cochignon",
						Language.ITA => "Piloswine",
						Language.SPN => "Piloswine",
						Language.KOR => "메꾸리",
						Language.CHN_SIM => "长毛猪",
						Language.CHN_TRA => "長毛豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CORSOLA:
					return lang switch {
						Language.ENG => "Corsola",
						Language.JPN => "サニーゴ",
						Language.GER => "Corasonn",
						Language.FRE => "Corayon",
						Language.ITA => "Corsola",
						Language.SPN => "Corsola",
						Language.KOR => "코산호",
						Language.CHN_SIM => "太阳珊瑚",
						Language.CHN_TRA => "太陽珊瑚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CORSOLA_GALARIAN_CORSOLA:
					return lang switch {
						Language.ENG => "Corsola",
						Language.JPN => "サニーゴ",
						Language.GER => "Corasonn",
						Language.FRE => "Corayon",
						Language.ITA => "Corsola",
						Language.SPN => "Corsola",
						Language.KOR => "코산호",
						Language.CHN_SIM => "太阳珊瑚",
						Language.CHN_TRA => "太陽珊瑚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REMORAID:
					return lang switch {
						Language.ENG => "Remoraid",
						Language.JPN => "テッポウオ",
						Language.GER => "Remoraid",
						Language.FRE => "Rémoraid",
						Language.ITA => "Remoraid",
						Language.SPN => "Remoraid",
						Language.KOR => "총어",
						Language.CHN_SIM => "铁炮鱼",
						Language.CHN_TRA => "鐵炮魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OCTILLERY:
					return lang switch {
						Language.ENG => "Octillery",
						Language.JPN => "オクタン",
						Language.GER => "Octillery",
						Language.FRE => "Octillery",
						Language.ITA => "Octillery",
						Language.SPN => "Octillery",
						Language.KOR => "대포무노",
						Language.CHN_SIM => "章鱼桶",
						Language.CHN_TRA => "章魚桶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DELIBIRD:
					return lang switch {
						Language.ENG => "Delibird",
						Language.JPN => "デリバード",
						Language.GER => "Botogel",
						Language.FRE => "Cadoizo",
						Language.ITA => "Delibird",
						Language.SPN => "Delibird",
						Language.KOR => "딜리버드",
						Language.CHN_SIM => "信使鸟",
						Language.CHN_TRA => "信使鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANTINE:
					return lang switch {
						Language.ENG => "Mantine",
						Language.JPN => "マンタイン",
						Language.GER => "Mantax",
						Language.FRE => "Démanta",
						Language.ITA => "Mantine",
						Language.SPN => "Mantine",
						Language.KOR => "만타인",
						Language.CHN_SIM => "巨翅飞鱼",
						Language.CHN_TRA => "巨翅飛魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKARMORY:
					return lang switch {
						Language.ENG => "Skarmory",
						Language.JPN => "エアームド",
						Language.GER => "Panzaeron",
						Language.FRE => "Airmure",
						Language.ITA => "Skarmory",
						Language.SPN => "Skarmory",
						Language.KOR => "무장조",
						Language.CHN_SIM => "盔甲鸟",
						Language.CHN_TRA => "盔甲鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOUNDOUR:
					return lang switch {
						Language.ENG => "Houndour",
						Language.JPN => "デルビル",
						Language.GER => "Hunduster",
						Language.FRE => "Malosse",
						Language.ITA => "Houndour",
						Language.SPN => "Houndour",
						Language.KOR => "델빌",
						Language.CHN_SIM => "戴鲁比",
						Language.CHN_TRA => "戴魯比",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOUNDOOM:
					return lang switch {
						Language.ENG => "Houndoom",
						Language.JPN => "ヘルガー",
						Language.GER => "Hundemon",
						Language.FRE => "Démolosse",
						Language.ITA => "Houndoom",
						Language.SPN => "Houndoom",
						Language.KOR => "헬가",
						Language.CHN_SIM => "黑鲁加",
						Language.CHN_TRA => "黑魯加",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOUNDOOM_MEGA_HOUNDOOM:
					return lang switch {
						Language.ENG => "Houndoom",
						Language.JPN => "ヘルガー",
						Language.GER => "Hundemon",
						Language.FRE => "Démolosse",
						Language.ITA => "Houndoom",
						Language.SPN => "Houndoom",
						Language.KOR => "헬가",
						Language.CHN_SIM => "黑鲁加",
						Language.CHN_TRA => "黑魯加",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KINGDRA:
					return lang switch {
						Language.ENG => "Kingdra",
						Language.JPN => "キングドラ",
						Language.GER => "Seedraking",
						Language.FRE => "Hyporoi",
						Language.ITA => "Kingdra",
						Language.SPN => "Kingdra",
						Language.KOR => "킹드라",
						Language.CHN_SIM => "刺龙王",
						Language.CHN_TRA => "刺龍王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PHANPY:
					return lang switch {
						Language.ENG => "Phanpy",
						Language.JPN => "ゴマゾウ",
						Language.GER => "Phanpy",
						Language.FRE => "Phanpy",
						Language.ITA => "Phanpy",
						Language.SPN => "Phanpy",
						Language.KOR => "코코리",
						Language.CHN_SIM => "小小象",
						Language.CHN_TRA => "小小象",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DONPHAN:
					return lang switch {
						Language.ENG => "Donphan",
						Language.JPN => "ドンファン",
						Language.GER => "Donphan",
						Language.FRE => "Donphan",
						Language.ITA => "Donphan",
						Language.SPN => "Donphan",
						Language.KOR => "코리갑",
						Language.CHN_SIM => "顿甲",
						Language.CHN_TRA => "頓甲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PORYGON2:
					return lang switch {
						Language.ENG => "Porygon2",
						Language.JPN => "ポリゴン２",
						Language.GER => "Porygon2",
						Language.FRE => "Porygon2",
						Language.ITA => "Porygon2",
						Language.SPN => "Porygon2",
						Language.KOR => "폴리곤2",
						Language.CHN_SIM => "多边兽２型",
						Language.CHN_TRA => "多邊獸Ⅱ",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STANTLER:
					return lang switch {
						Language.ENG => "Stantler",
						Language.JPN => "オドシシ",
						Language.GER => "Damhirplex",
						Language.FRE => "Cerfrousse",
						Language.ITA => "Stantler",
						Language.SPN => "Stantler",
						Language.KOR => "노라키",
						Language.CHN_SIM => "惊角鹿",
						Language.CHN_TRA => "驚角鹿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SMEARGLE:
					return lang switch {
						Language.ENG => "Smeargle",
						Language.JPN => "ドーブル",
						Language.GER => "Farbeagle",
						Language.FRE => "Queulorior",
						Language.ITA => "Smeargle",
						Language.SPN => "Smeargle",
						Language.KOR => "루브도",
						Language.CHN_SIM => "图图犬",
						Language.CHN_TRA => "圖圖犬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYROGUE:
					return lang switch {
						Language.ENG => "Tyrogue",
						Language.JPN => "バルキー",
						Language.GER => "Rabauz",
						Language.FRE => "Debugant",
						Language.ITA => "Tyrogue",
						Language.SPN => "Tyrogue",
						Language.KOR => "배루키",
						Language.CHN_SIM => "无畏小子",
						Language.CHN_TRA => "無畏小子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HITMONTOP:
					return lang switch {
						Language.ENG => "Hitmontop",
						Language.JPN => "カポエラー",
						Language.GER => "Kapoera",
						Language.FRE => "Kapoera",
						Language.ITA => "Hitmontop",
						Language.SPN => "Hitmontop",
						Language.KOR => "카포에라",
						Language.CHN_SIM => "战舞郎",
						Language.CHN_TRA => "戰舞郎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SMOOCHUM:
					return lang switch {
						Language.ENG => "Smoochum",
						Language.JPN => "ムチュール",
						Language.GER => "Kussilla",
						Language.FRE => "Lippouti",
						Language.ITA => "Smoochum",
						Language.SPN => "Smoochum",
						Language.KOR => "뽀뽀라",
						Language.CHN_SIM => "迷唇娃",
						Language.CHN_TRA => "迷唇娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELEKID:
					return lang switch {
						Language.ENG => "Elekid",
						Language.JPN => "エレキッド",
						Language.GER => "Elekid",
						Language.FRE => "Élekid",
						Language.ITA => "Elekid",
						Language.SPN => "Elekid",
						Language.KOR => "에레키드",
						Language.CHN_SIM => "电击怪",
						Language.CHN_TRA => "電擊怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGBY:
					return lang switch {
						Language.ENG => "Magby",
						Language.JPN => "ブビィ",
						Language.GER => "Magby",
						Language.FRE => "Magby",
						Language.ITA => "Magby",
						Language.SPN => "Magby",
						Language.KOR => "마그비",
						Language.CHN_SIM => "鸭嘴宝宝",
						Language.CHN_TRA => "鴨嘴寶寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MILTANK:
					return lang switch {
						Language.ENG => "Miltank",
						Language.JPN => "ミルタンク",
						Language.GER => "Miltank",
						Language.FRE => "Écrémeuh",
						Language.ITA => "Miltank",
						Language.SPN => "Miltank",
						Language.KOR => "밀탱크",
						Language.CHN_SIM => "大奶罐",
						Language.CHN_TRA => "大奶罐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLISSEY:
					return lang switch {
						Language.ENG => "Blissey",
						Language.JPN => "ハピナス",
						Language.GER => "Heiteira",
						Language.FRE => "Leuphorie",
						Language.ITA => "Blissey",
						Language.SPN => "Blissey",
						Language.KOR => "해피너스",
						Language.CHN_SIM => "幸福蛋",
						Language.CHN_TRA => "幸福蛋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAIKOU:
					return lang switch {
						Language.ENG => "Raikou",
						Language.JPN => "ライコウ",
						Language.GER => "Raikou",
						Language.FRE => "Raikou",
						Language.ITA => "Raikou",
						Language.SPN => "Raikou",
						Language.KOR => "라이코",
						Language.CHN_SIM => "雷公",
						Language.CHN_TRA => "雷公",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ENTEI:
					return lang switch {
						Language.ENG => "Entei",
						Language.JPN => "エンテイ",
						Language.GER => "Entei",
						Language.FRE => "Entei",
						Language.ITA => "Entei",
						Language.SPN => "Entei",
						Language.KOR => "앤테이",
						Language.CHN_SIM => "炎帝",
						Language.CHN_TRA => "炎帝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SUICUNE:
					return lang switch {
						Language.ENG => "Suicune",
						Language.JPN => "スイクン",
						Language.GER => "Suicune",
						Language.FRE => "Suicune",
						Language.ITA => "Suicune",
						Language.SPN => "Suicune",
						Language.KOR => "스이쿤",
						Language.CHN_SIM => "水君",
						Language.CHN_TRA => "水君",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LARVITAR:
					return lang switch {
						Language.ENG => "Larvitar",
						Language.JPN => "ヨーギラス",
						Language.GER => "Larvitar",
						Language.FRE => "Embrylex",
						Language.ITA => "Larvitar",
						Language.SPN => "Larvitar",
						Language.KOR => "애버라스",
						Language.CHN_SIM => "幼基拉斯",
						Language.CHN_TRA => "幼基拉斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PUPITAR:
					return lang switch {
						Language.ENG => "Pupitar",
						Language.JPN => "サナギラス",
						Language.GER => "Pupitar",
						Language.FRE => "Ymphect",
						Language.ITA => "Pupitar",
						Language.SPN => "Pupitar",
						Language.KOR => "데기라스",
						Language.CHN_SIM => "沙基拉斯",
						Language.CHN_TRA => "沙基拉斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYRANITAR:
					return lang switch {
						Language.ENG => "Tyranitar",
						Language.JPN => "バンギラス",
						Language.GER => "Despotar",
						Language.FRE => "Tyranocif",
						Language.ITA => "Tyranitar",
						Language.SPN => "Tyranitar",
						Language.KOR => "마기라스",
						Language.CHN_SIM => "班基拉斯",
						Language.CHN_TRA => "班基拉斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYRANITAR_MEGA_TYRANITAR:
					return lang switch {
						Language.ENG => "Tyranitar",
						Language.JPN => "バンギラス",
						Language.GER => "Despotar",
						Language.FRE => "Tyranocif",
						Language.ITA => "Tyranitar",
						Language.SPN => "Tyranitar",
						Language.KOR => "마기라스",
						Language.CHN_SIM => "班基拉斯",
						Language.CHN_TRA => "班基拉斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUGIA:
					return lang switch {
						Language.ENG => "Lugia",
						Language.JPN => "ルギア",
						Language.GER => "Lugia",
						Language.FRE => "Lugia",
						Language.ITA => "Lugia",
						Language.SPN => "Lugia",
						Language.KOR => "루기아",
						Language.CHN_SIM => "洛奇亚",
						Language.CHN_TRA => "洛奇亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HO_OH:
					return lang switch {
						Language.ENG => "Ho-Oh",
						Language.JPN => "ホウオウ",
						Language.GER => "Ho-Oh",
						Language.FRE => "Ho-Oh",
						Language.ITA => "Ho-Oh",
						Language.SPN => "Ho-Oh",
						Language.KOR => "칠색조",
						Language.CHN_SIM => "凤王",
						Language.CHN_TRA => "鳳王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CELEBI:
					return lang switch {
						Language.ENG => "Celebi",
						Language.JPN => "セレビィ",
						Language.GER => "Celebi",
						Language.FRE => "Celebi",
						Language.ITA => "Celebi",
						Language.SPN => "Celebi",
						Language.KOR => "세레비",
						Language.CHN_SIM => "时拉比",
						Language.CHN_TRA => "時拉比",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TREECKO:
					return lang switch {
						Language.ENG => "Treecko",
						Language.JPN => "キモリ",
						Language.GER => "Geckarbor",
						Language.FRE => "Arcko",
						Language.ITA => "Treecko",
						Language.SPN => "Treecko",
						Language.KOR => "나무지기",
						Language.CHN_SIM => "木守宫",
						Language.CHN_TRA => "木守宮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROVYLE:
					return lang switch {
						Language.ENG => "Grovyle",
						Language.JPN => "ジュプトル",
						Language.GER => "Reptain",
						Language.FRE => "Massko",
						Language.ITA => "Grovyle",
						Language.SPN => "Grovyle",
						Language.KOR => "나무돌이",
						Language.CHN_SIM => "森林蜥蜴",
						Language.CHN_TRA => "森林蜥蜴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCEPTILE:
					return lang switch {
						Language.ENG => "Sceptile",
						Language.JPN => "ジュカイン",
						Language.GER => "Gewaldro",
						Language.FRE => "Jungko",
						Language.ITA => "Sceptile",
						Language.SPN => "Sceptile",
						Language.KOR => "나무킹",
						Language.CHN_SIM => "蜥蜴王",
						Language.CHN_TRA => "蜥蜴王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCEPTILE_MEGA_SCEPTILE:
					return lang switch {
						Language.ENG => "Sceptile",
						Language.JPN => "ジュカイン",
						Language.GER => "Gewaldro",
						Language.FRE => "Jungko",
						Language.ITA => "Sceptile",
						Language.SPN => "Sceptile",
						Language.KOR => "나무킹",
						Language.CHN_SIM => "蜥蜴王",
						Language.CHN_TRA => "蜥蜴王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TORCHIC:
					return lang switch {
						Language.ENG => "Torchic",
						Language.JPN => "アチャモ",
						Language.GER => "Flemmli",
						Language.FRE => "Poussifeu",
						Language.ITA => "Torchic",
						Language.SPN => "Torchic",
						Language.KOR => "아차모",
						Language.CHN_SIM => "火稚鸡",
						Language.CHN_TRA => "火稚雞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COMBUSKEN:
					return lang switch {
						Language.ENG => "Combusken",
						Language.JPN => "ワカシャモ",
						Language.GER => "Jungglut",
						Language.FRE => "Galifeu",
						Language.ITA => "Combusken",
						Language.SPN => "Combusken",
						Language.KOR => "영치코",
						Language.CHN_SIM => "力壮鸡",
						Language.CHN_TRA => "力壯雞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLAZIKEN:
					return lang switch {
						Language.ENG => "Blaziken",
						Language.JPN => "バシャーモ",
						Language.GER => "Lohgock",
						Language.FRE => "Braségali",
						Language.ITA => "Blaziken",
						Language.SPN => "Blaziken",
						Language.KOR => "번치코",
						Language.CHN_SIM => "火焰鸡",
						Language.CHN_TRA => "火焰雞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLAZIKEN_MEGA_BLAZIKEN:
					return lang switch {
						Language.ENG => "Blaziken",
						Language.JPN => "バシャーモ",
						Language.GER => "Lohgock",
						Language.FRE => "Braségali",
						Language.ITA => "Blaziken",
						Language.SPN => "Blaziken",
						Language.KOR => "번치코",
						Language.CHN_SIM => "火焰鸡",
						Language.CHN_TRA => "火焰雞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUDKIP:
					return lang switch {
						Language.ENG => "Mudkip",
						Language.JPN => "ミズゴロウ",
						Language.GER => "Hydropi",
						Language.FRE => "Gobou",
						Language.ITA => "Mudkip",
						Language.SPN => "Mudkip",
						Language.KOR => "물짱이",
						Language.CHN_SIM => "水跃鱼",
						Language.CHN_TRA => "水躍魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MARSHTOMP:
					return lang switch {
						Language.ENG => "Marshtomp",
						Language.JPN => "ヌマクロー",
						Language.GER => "Moorabbel",
						Language.FRE => "Flobio",
						Language.ITA => "Marshtomp",
						Language.SPN => "Marshtomp",
						Language.KOR => "늪짱이",
						Language.CHN_SIM => "沼跃鱼",
						Language.CHN_TRA => "沼躍魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWAMPERT:
					return lang switch {
						Language.ENG => "Swampert",
						Language.JPN => "ラグラージ",
						Language.GER => "Sumpex",
						Language.FRE => "Laggron",
						Language.ITA => "Swampert",
						Language.SPN => "Swampert",
						Language.KOR => "대짱이",
						Language.CHN_SIM => "巨沼怪",
						Language.CHN_TRA => "巨沼怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWAMPERT_MEGA_SWAMPERT:
					return lang switch {
						Language.ENG => "Swampert",
						Language.JPN => "ラグラージ",
						Language.GER => "Sumpex",
						Language.FRE => "Laggron",
						Language.ITA => "Swampert",
						Language.SPN => "Swampert",
						Language.KOR => "대짱이",
						Language.CHN_SIM => "巨沼怪",
						Language.CHN_TRA => "巨沼怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POOCHYENA:
					return lang switch {
						Language.ENG => "Poochyena",
						Language.JPN => "ポチエナ",
						Language.GER => "Fiffyen",
						Language.FRE => "Medhyèna",
						Language.ITA => "Poochyena",
						Language.SPN => "Poochyena",
						Language.KOR => "포챠나",
						Language.CHN_SIM => "土狼犬",
						Language.CHN_TRA => "土狼犬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MIGHTYENA:
					return lang switch {
						Language.ENG => "Mightyena",
						Language.JPN => "グラエナ",
						Language.GER => "Magnayen",
						Language.FRE => "Grahyèna",
						Language.ITA => "Mightyena",
						Language.SPN => "Mightyena",
						Language.KOR => "그라에나",
						Language.CHN_SIM => "大狼犬",
						Language.CHN_TRA => "大狼犬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZIGZAGOON:
					return lang switch {
						Language.ENG => "Zigzagoon",
						Language.JPN => "ジグザグマ",
						Language.GER => "Zigzachs",
						Language.FRE => "Zigzaton",
						Language.ITA => "Zigzagoon",
						Language.SPN => "Zigzagoon",
						Language.KOR => "지그제구리",
						Language.CHN_SIM => "蛇纹熊",
						Language.CHN_TRA => "蛇紋熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZIGZAGOON_GALARIAN_ZIGZAGOON:
					return lang switch {
						Language.ENG => "Zigzagoon",
						Language.JPN => "ジグザグマ",
						Language.GER => "Zigzachs",
						Language.FRE => "Zigzaton",
						Language.ITA => "Zigzagoon",
						Language.SPN => "Zigzagoon",
						Language.KOR => "지그제구리",
						Language.CHN_SIM => "蛇纹熊",
						Language.CHN_TRA => "蛇紋熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LINOONE:
					return lang switch {
						Language.ENG => "Linoone",
						Language.JPN => "マッスグマ",
						Language.GER => "Geradaks",
						Language.FRE => "Linéon",
						Language.ITA => "Linoone",
						Language.SPN => "Linoone",
						Language.KOR => "직구리",
						Language.CHN_SIM => "直冲熊",
						Language.CHN_TRA => "直衝熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LINOONE_GALARIAN_LINOONE:
					return lang switch {
						Language.ENG => "Linoone",
						Language.JPN => "マッスグマ",
						Language.GER => "Geradaks",
						Language.FRE => "Linéon",
						Language.ITA => "Linoone",
						Language.SPN => "Linoone",
						Language.KOR => "직구리",
						Language.CHN_SIM => "直冲熊",
						Language.CHN_TRA => "直衝熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WURMPLE:
					return lang switch {
						Language.ENG => "Wurmple",
						Language.JPN => "ケムッソ",
						Language.GER => "Waumpel",
						Language.FRE => "Chenipotte",
						Language.ITA => "Wurmple",
						Language.SPN => "Wurmple",
						Language.KOR => "개무소",
						Language.CHN_SIM => "刺尾虫",
						Language.CHN_TRA => "刺尾蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SILCOON:
					return lang switch {
						Language.ENG => "Silcoon",
						Language.JPN => "カラサリス",
						Language.GER => "Schaloko",
						Language.FRE => "Armulys",
						Language.ITA => "Silcoon",
						Language.SPN => "Silcoon",
						Language.KOR => "실쿤",
						Language.CHN_SIM => "甲壳茧",
						Language.CHN_TRA => "甲殼繭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BEAUTIFLY:
					return lang switch {
						Language.ENG => "Beautifly",
						Language.JPN => "アゲハント",
						Language.GER => "Papinella",
						Language.FRE => "Charmillon",
						Language.ITA => "Beautifly",
						Language.SPN => "Beautifly",
						Language.KOR => "뷰티플라이",
						Language.CHN_SIM => "狩猎凤蝶",
						Language.CHN_TRA => "狩獵鳳蝶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CASCOON:
					return lang switch {
						Language.ENG => "Cascoon",
						Language.JPN => "マユルド",
						Language.GER => "Panekon",
						Language.FRE => "Blindalys",
						Language.ITA => "Cascoon",
						Language.SPN => "Cascoon",
						Language.KOR => "카스쿤",
						Language.CHN_SIM => "盾甲茧",
						Language.CHN_TRA => "盾甲繭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUSTOX:
					return lang switch {
						Language.ENG => "Dustox",
						Language.JPN => "ドクケイル",
						Language.GER => "Pudox",
						Language.FRE => "Papinox",
						Language.ITA => "Dustox",
						Language.SPN => "Dustox",
						Language.KOR => "독케일",
						Language.CHN_SIM => "毒粉蛾",
						Language.CHN_TRA => "毒粉蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LOTAD:
					return lang switch {
						Language.ENG => "Lotad",
						Language.JPN => "ハスボー",
						Language.GER => "Loturzel",
						Language.FRE => "Nénupiot",
						Language.ITA => "Lotad",
						Language.SPN => "Lotad",
						Language.KOR => "연꽃몬",
						Language.CHN_SIM => "莲叶童子",
						Language.CHN_TRA => "蓮葉童子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LOMBRE:
					return lang switch {
						Language.ENG => "Lombre",
						Language.JPN => "ハスブレロ",
						Language.GER => "Lombrero",
						Language.FRE => "Lombre",
						Language.ITA => "Lombre",
						Language.SPN => "Lombre",
						Language.KOR => "로토스",
						Language.CHN_SIM => "莲帽小童",
						Language.CHN_TRA => "蓮帽小童",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUDICOLO:
					return lang switch {
						Language.ENG => "Ludicolo",
						Language.JPN => "ルンパッパ",
						Language.GER => "Kappalores",
						Language.FRE => "Ludicolo",
						Language.ITA => "Ludicolo",
						Language.SPN => "Ludicolo",
						Language.KOR => "로파파",
						Language.CHN_SIM => "乐天河童",
						Language.CHN_TRA => "樂天河童",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEEDOT:
					return lang switch {
						Language.ENG => "Seedot",
						Language.JPN => "タネボー",
						Language.GER => "Samurzel",
						Language.FRE => "Grainipiot",
						Language.ITA => "Seedot",
						Language.SPN => "Seedot",
						Language.KOR => "도토링",
						Language.CHN_SIM => "橡实果",
						Language.CHN_TRA => "橡實果",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NUZLEAF:
					return lang switch {
						Language.ENG => "Nuzleaf",
						Language.JPN => "コノハナ",
						Language.GER => "Blanas",
						Language.FRE => "Pifeuil",
						Language.ITA => "Nuzleaf",
						Language.SPN => "Nuzleaf",
						Language.KOR => "잎새코",
						Language.CHN_SIM => "长鼻叶",
						Language.CHN_TRA => "長鼻葉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHIFTRY:
					return lang switch {
						Language.ENG => "Shiftry",
						Language.JPN => "ダーテング",
						Language.GER => "Tengulist",
						Language.FRE => "Tengalice",
						Language.ITA => "Shiftry",
						Language.SPN => "Shiftry",
						Language.KOR => "다탱구",
						Language.CHN_SIM => "狡猾天狗",
						Language.CHN_TRA => "狡猾天狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAILLOW:
					return lang switch {
						Language.ENG => "Taillow",
						Language.JPN => "スバメ",
						Language.GER => "Schwalbini",
						Language.FRE => "Nirondelle",
						Language.ITA => "Taillow",
						Language.SPN => "Taillow",
						Language.KOR => "테일로",
						Language.CHN_SIM => "傲骨燕",
						Language.CHN_TRA => "傲骨燕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWELLOW:
					return lang switch {
						Language.ENG => "Swellow",
						Language.JPN => "オオスバメ",
						Language.GER => "Schwalboss",
						Language.FRE => "Hélédelle",
						Language.ITA => "Swellow",
						Language.SPN => "Swellow",
						Language.KOR => "스왈로",
						Language.CHN_SIM => "大王燕",
						Language.CHN_TRA => "大王燕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WINGULL:
					return lang switch {
						Language.ENG => "Wingull",
						Language.JPN => "キャモメ",
						Language.GER => "Wingull",
						Language.FRE => "Goélise",
						Language.ITA => "Wingull",
						Language.SPN => "Wingull",
						Language.KOR => "갈모매",
						Language.CHN_SIM => "长翅鸥",
						Language.CHN_TRA => "長翅鷗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PELIPPER:
					return lang switch {
						Language.ENG => "Pelipper",
						Language.JPN => "ペリッパー",
						Language.GER => "Pelipper",
						Language.FRE => "Bekipan",
						Language.ITA => "Pelipper",
						Language.SPN => "Pelipper",
						Language.KOR => "패리퍼",
						Language.CHN_SIM => "大嘴鸥",
						Language.CHN_TRA => "大嘴鷗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RALTS:
					return lang switch {
						Language.ENG => "Ralts",
						Language.JPN => "ラルトス",
						Language.GER => "Trasla",
						Language.FRE => "Tarsal",
						Language.ITA => "Ralts",
						Language.SPN => "Ralts",
						Language.KOR => "랄토스",
						Language.CHN_SIM => "拉鲁拉丝",
						Language.CHN_TRA => "拉魯拉絲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KIRLIA:
					return lang switch {
						Language.ENG => "Kirlia",
						Language.JPN => "キルリア",
						Language.GER => "Kirlia",
						Language.FRE => "Kirlia",
						Language.ITA => "Kirlia",
						Language.SPN => "Kirlia",
						Language.KOR => "킬리아",
						Language.CHN_SIM => "奇鲁莉安",
						Language.CHN_TRA => "奇魯莉安",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GARDEVOIR:
					return lang switch {
						Language.ENG => "Gardevoir",
						Language.JPN => "サーナイト",
						Language.GER => "Guardevoir",
						Language.FRE => "Gardevoir",
						Language.ITA => "Gardevoir",
						Language.SPN => "Gardevoir",
						Language.KOR => "가디안",
						Language.CHN_SIM => "沙奈朵",
						Language.CHN_TRA => "沙奈朵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GARDEVOIR_MEGA_GARDEVOIR:
					return lang switch {
						Language.ENG => "Gardevoir",
						Language.JPN => "サーナイト",
						Language.GER => "Guardevoir",
						Language.FRE => "Gardevoir",
						Language.ITA => "Gardevoir",
						Language.SPN => "Gardevoir",
						Language.KOR => "가디안",
						Language.CHN_SIM => "沙奈朵",
						Language.CHN_TRA => "沙奈朵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SURSKIT:
					return lang switch {
						Language.ENG => "Surskit",
						Language.JPN => "アメタマ",
						Language.GER => "Gehweiher",
						Language.FRE => "Arakdo",
						Language.ITA => "Surskit",
						Language.SPN => "Surskit",
						Language.KOR => "비구술",
						Language.CHN_SIM => "溜溜糖球",
						Language.CHN_TRA => "溜溜糖球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MASQUERAIN:
					return lang switch {
						Language.ENG => "Masquerain",
						Language.JPN => "アメモース",
						Language.GER => "Maskeregen",
						Language.FRE => "Maskadra",
						Language.ITA => "Masquerain",
						Language.SPN => "Masquerain",
						Language.KOR => "비나방",
						Language.CHN_SIM => "雨翅蛾",
						Language.CHN_TRA => "雨翅蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHROOMISH:
					return lang switch {
						Language.ENG => "Shroomish",
						Language.JPN => "キノココ",
						Language.GER => "Knilz",
						Language.FRE => "Balignon",
						Language.ITA => "Shroomish",
						Language.SPN => "Shroomish",
						Language.KOR => "버섯꼬",
						Language.CHN_SIM => "蘑蘑菇",
						Language.CHN_TRA => "蘑蘑菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRELOOM:
					return lang switch {
						Language.ENG => "Breloom",
						Language.JPN => "キノガッサ",
						Language.GER => "Kapilz",
						Language.FRE => "Chapignon",
						Language.ITA => "Breloom",
						Language.SPN => "Breloom",
						Language.KOR => "버섯모",
						Language.CHN_SIM => "斗笠菇",
						Language.CHN_TRA => "斗笠菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLAKOTH:
					return lang switch {
						Language.ENG => "Slakoth",
						Language.JPN => "ナマケロ",
						Language.GER => "Bummelz",
						Language.FRE => "Parecool",
						Language.ITA => "Slakoth",
						Language.SPN => "Slakoth",
						Language.KOR => "게을로",
						Language.CHN_SIM => "懒人獭",
						Language.CHN_TRA => "懶人獺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VIGOROTH:
					return lang switch {
						Language.ENG => "Vigoroth",
						Language.JPN => "ヤルキモノ",
						Language.GER => "Muntier",
						Language.FRE => "Vigoroth",
						Language.ITA => "Vigoroth",
						Language.SPN => "Vigoroth",
						Language.KOR => "발바로",
						Language.CHN_SIM => "过动猿",
						Language.CHN_TRA => "過動猿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLAKING:
					return lang switch {
						Language.ENG => "Slaking",
						Language.JPN => "ケッキング",
						Language.GER => "Letarking",
						Language.FRE => "Monaflèmit",
						Language.ITA => "Slaking",
						Language.SPN => "Slaking",
						Language.KOR => "게을킹",
						Language.CHN_SIM => "请假王",
						Language.CHN_TRA => "請假王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NINCADA:
					return lang switch {
						Language.ENG => "Nincada",
						Language.JPN => "ツチニン",
						Language.GER => "Nincada",
						Language.FRE => "Ningale",
						Language.ITA => "Nincada",
						Language.SPN => "Nincada",
						Language.KOR => "토중몬",
						Language.CHN_SIM => "土居忍士",
						Language.CHN_TRA => "土居忍士",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NINJASK:
					return lang switch {
						Language.ENG => "Ninjask",
						Language.JPN => "テッカニン",
						Language.GER => "Ninjask",
						Language.FRE => "Ninjask",
						Language.ITA => "Ninjask",
						Language.SPN => "Ninjask",
						Language.KOR => "아이스크",
						Language.CHN_SIM => "铁面忍者",
						Language.CHN_TRA => "鐵面忍者",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHEDINJA:
					return lang switch {
						Language.ENG => "Shedinja",
						Language.JPN => "ヌケニン",
						Language.GER => "Ninjatom",
						Language.FRE => "Munja",
						Language.ITA => "Shedinja",
						Language.SPN => "Shedinja",
						Language.KOR => "껍질몬",
						Language.CHN_SIM => "脱壳忍者",
						Language.CHN_TRA => "脫殼忍者",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WHISMUR:
					return lang switch {
						Language.ENG => "Whismur",
						Language.JPN => "ゴニョニョ",
						Language.GER => "Flurmel",
						Language.FRE => "Chuchmur",
						Language.ITA => "Whismur",
						Language.SPN => "Whismur",
						Language.KOR => "소곤룡",
						Language.CHN_SIM => "咕妞妞",
						Language.CHN_TRA => "咕妞妞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LOUDRED:
					return lang switch {
						Language.ENG => "Loudred",
						Language.JPN => "ドゴーム",
						Language.GER => "Krakeelo",
						Language.FRE => "Ramboum",
						Language.ITA => "Loudred",
						Language.SPN => "Loudred",
						Language.KOR => "노공룡",
						Language.CHN_SIM => "吼爆弹",
						Language.CHN_TRA => "吼爆彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EXPLOUD:
					return lang switch {
						Language.ENG => "Exploud",
						Language.JPN => "バクオング",
						Language.GER => "Krawumms",
						Language.FRE => "Brouhabam",
						Language.ITA => "Exploud",
						Language.SPN => "Exploud",
						Language.KOR => "폭음룡",
						Language.CHN_SIM => "爆音怪",
						Language.CHN_TRA => "爆音怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAKUHITA:
					return lang switch {
						Language.ENG => "Makuhita",
						Language.JPN => "マクノシタ",
						Language.GER => "Makuhita",
						Language.FRE => "Makuhita",
						Language.ITA => "Makuhita",
						Language.SPN => "Makuhita",
						Language.KOR => "마크탕",
						Language.CHN_SIM => "幕下力士",
						Language.CHN_TRA => "幕下力士",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HARIYAMA:
					return lang switch {
						Language.ENG => "Hariyama",
						Language.JPN => "ハリテヤマ",
						Language.GER => "Hariyama",
						Language.FRE => "Hariyama",
						Language.ITA => "Hariyama",
						Language.SPN => "Hariyama",
						Language.KOR => "하리뭉",
						Language.CHN_SIM => "铁掌力士",
						Language.CHN_TRA => "鐵掌力士",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AZURILL:
					return lang switch {
						Language.ENG => "Azurill",
						Language.JPN => "ルリリ",
						Language.GER => "Azurill",
						Language.FRE => "Azurill",
						Language.ITA => "Azurill",
						Language.SPN => "Azurill",
						Language.KOR => "루리리",
						Language.CHN_SIM => "露力丽",
						Language.CHN_TRA => "露力麗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NOSEPASS:
					return lang switch {
						Language.ENG => "Nosepass",
						Language.JPN => "ノズパス",
						Language.GER => "Nasgnet",
						Language.FRE => "Tarinor",
						Language.ITA => "Nosepass",
						Language.SPN => "Nosepass",
						Language.KOR => "코코파스",
						Language.CHN_SIM => "朝北鼻",
						Language.CHN_TRA => "朝北鼻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKITTY:
					return lang switch {
						Language.ENG => "Skitty",
						Language.JPN => "エネコ",
						Language.GER => "Eneco",
						Language.FRE => "Skitty",
						Language.ITA => "Skitty",
						Language.SPN => "Skitty",
						Language.KOR => "에나비",
						Language.CHN_SIM => "向尾喵",
						Language.CHN_TRA => "向尾喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DELCATTY:
					return lang switch {
						Language.ENG => "Delcatty",
						Language.JPN => "エネコロロ",
						Language.GER => "Enekoro",
						Language.FRE => "Delcatty",
						Language.ITA => "Delcatty",
						Language.SPN => "Delcatty",
						Language.KOR => "델케티",
						Language.CHN_SIM => "优雅猫",
						Language.CHN_TRA => "優雅貓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SABLEYE:
					return lang switch {
						Language.ENG => "Sableye",
						Language.JPN => "ヤミラミ",
						Language.GER => "Zobiris",
						Language.FRE => "Ténéfix",
						Language.ITA => "Sableye",
						Language.SPN => "Sableye",
						Language.KOR => "깜까미",
						Language.CHN_SIM => "勾魂眼",
						Language.CHN_TRA => "勾魂眼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SABLEYE_MEGA_SABLEYE:
					return lang switch {
						Language.ENG => "Sableye",
						Language.JPN => "ヤミラミ",
						Language.GER => "Zobiris",
						Language.FRE => "Ténéfix",
						Language.ITA => "Sableye",
						Language.SPN => "Sableye",
						Language.KOR => "깜까미",
						Language.CHN_SIM => "勾魂眼",
						Language.CHN_TRA => "勾魂眼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAWILE:
					return lang switch {
						Language.ENG => "Mawile",
						Language.JPN => "クチート",
						Language.GER => "Flunkifer",
						Language.FRE => "Mysdibule",
						Language.ITA => "Mawile",
						Language.SPN => "Mawile",
						Language.KOR => "입치트",
						Language.CHN_SIM => "大嘴娃",
						Language.CHN_TRA => "大嘴娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAWILE_MEGA_MAWILE:
					return lang switch {
						Language.ENG => "Mawile",
						Language.JPN => "クチート",
						Language.GER => "Flunkifer",
						Language.FRE => "Mysdibule",
						Language.ITA => "Mawile",
						Language.SPN => "Mawile",
						Language.KOR => "입치트",
						Language.CHN_SIM => "大嘴娃",
						Language.CHN_TRA => "大嘴娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARON:
					return lang switch {
						Language.ENG => "Aron",
						Language.JPN => "ココドラ",
						Language.GER => "Stollunior",
						Language.FRE => "Galekid",
						Language.ITA => "Aron",
						Language.SPN => "Aron",
						Language.KOR => "가보리",
						Language.CHN_SIM => "可可多拉",
						Language.CHN_TRA => "可可多拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LAIRON:
					return lang switch {
						Language.ENG => "Lairon",
						Language.JPN => "コドラ",
						Language.GER => "Stollrak",
						Language.FRE => "Galegon",
						Language.ITA => "Lairon",
						Language.SPN => "Lairon",
						Language.KOR => "갱도라",
						Language.CHN_SIM => "可多拉",
						Language.CHN_TRA => "可多拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AGGRON:
					return lang switch {
						Language.ENG => "Aggron",
						Language.JPN => "ボスゴドラ",
						Language.GER => "Stolloss",
						Language.FRE => "Galeking",
						Language.ITA => "Aggron",
						Language.SPN => "Aggron",
						Language.KOR => "보스로라",
						Language.CHN_SIM => "波士可多拉",
						Language.CHN_TRA => "波士可多拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AGGRON_MEGA_AGGRON:
					return lang switch {
						Language.ENG => "Aggron",
						Language.JPN => "ボスゴドラ",
						Language.GER => "Stolloss",
						Language.FRE => "Galeking",
						Language.ITA => "Aggron",
						Language.SPN => "Aggron",
						Language.KOR => "보스로라",
						Language.CHN_SIM => "波士可多拉",
						Language.CHN_TRA => "波士可多拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEDITITE:
					return lang switch {
						Language.ENG => "Meditite",
						Language.JPN => "アサナン",
						Language.GER => "Meditie",
						Language.FRE => "Méditikka",
						Language.ITA => "Meditite",
						Language.SPN => "Meditite",
						Language.KOR => "요가랑",
						Language.CHN_SIM => "玛沙那",
						Language.CHN_TRA => "瑪沙那",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEDICHAM:
					return lang switch {
						Language.ENG => "Medicham",
						Language.JPN => "チャーレム",
						Language.GER => "Meditalis",
						Language.FRE => "Charmina",
						Language.ITA => "Medicham",
						Language.SPN => "Medicham",
						Language.KOR => "요가램",
						Language.CHN_SIM => "恰雷姆",
						Language.CHN_TRA => "恰雷姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEDICHAM_MEGA_MEDICHAM:
					return lang switch {
						Language.ENG => "Medicham",
						Language.JPN => "チャーレム",
						Language.GER => "Meditalis",
						Language.FRE => "Charmina",
						Language.ITA => "Medicham",
						Language.SPN => "Medicham",
						Language.KOR => "요가램",
						Language.CHN_SIM => "恰雷姆",
						Language.CHN_TRA => "恰雷姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELECTRIKE:
					return lang switch {
						Language.ENG => "Electrike",
						Language.JPN => "ラクライ",
						Language.GER => "Frizelbliz",
						Language.FRE => "Dynavolt",
						Language.ITA => "Electrike",
						Language.SPN => "Electrike",
						Language.KOR => "썬더라이",
						Language.CHN_SIM => "落雷兽",
						Language.CHN_TRA => "落雷獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANECTRIC:
					return lang switch {
						Language.ENG => "Manectric",
						Language.JPN => "ライボルト",
						Language.GER => "Voltenso",
						Language.FRE => "Élecsprint",
						Language.ITA => "Manectric",
						Language.SPN => "Manectric",
						Language.KOR => "썬더볼트",
						Language.CHN_SIM => "雷电兽",
						Language.CHN_TRA => "雷電獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANECTRIC_MEGA_MANECTRIC:
					return lang switch {
						Language.ENG => "Manectric",
						Language.JPN => "ライボルト",
						Language.GER => "Voltenso",
						Language.FRE => "Élecsprint",
						Language.ITA => "Manectric",
						Language.SPN => "Manectric",
						Language.KOR => "썬더볼트",
						Language.CHN_SIM => "雷电兽",
						Language.CHN_TRA => "雷電獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PLUSLE:
					return lang switch {
						Language.ENG => "Plusle",
						Language.JPN => "プラスル",
						Language.GER => "Plusle",
						Language.FRE => "Posipi",
						Language.ITA => "Plusle",
						Language.SPN => "Plusle",
						Language.KOR => "플러시",
						Language.CHN_SIM => "正电拍拍",
						Language.CHN_TRA => "正電拍拍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MINUN:
					return lang switch {
						Language.ENG => "Minun",
						Language.JPN => "マイナン",
						Language.GER => "Minun",
						Language.FRE => "Négapi",
						Language.ITA => "Minun",
						Language.SPN => "Minun",
						Language.KOR => "마이농",
						Language.CHN_SIM => "负电拍拍",
						Language.CHN_TRA => "負電拍拍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VOLBEAT:
					return lang switch {
						Language.ENG => "Volbeat",
						Language.JPN => "バルビート",
						Language.GER => "Volbeat",
						Language.FRE => "Muciole",
						Language.ITA => "Volbeat",
						Language.SPN => "Volbeat",
						Language.KOR => "볼비트",
						Language.CHN_SIM => "电萤虫",
						Language.CHN_TRA => "電螢蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ILLUMISE:
					return lang switch {
						Language.ENG => "Illumise",
						Language.JPN => "イルミーゼ",
						Language.GER => "Illumise",
						Language.FRE => "Lumivole",
						Language.ITA => "Illumise",
						Language.SPN => "Illumise",
						Language.KOR => "네오비트",
						Language.CHN_SIM => "甜甜萤",
						Language.CHN_TRA => "甜甜螢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROSELIA:
					return lang switch {
						Language.ENG => "Roselia",
						Language.JPN => "ロゼリア",
						Language.GER => "Roselia",
						Language.FRE => "Rosélia",
						Language.ITA => "Roselia",
						Language.SPN => "Roselia",
						Language.KOR => "로젤리아",
						Language.CHN_SIM => "毒蔷薇",
						Language.CHN_TRA => "毒薔薇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GULPIN:
					return lang switch {
						Language.ENG => "Gulpin",
						Language.JPN => "ゴクリン",
						Language.GER => "Schluppuck",
						Language.FRE => "Gloupti",
						Language.ITA => "Gulpin",
						Language.SPN => "Gulpin",
						Language.KOR => "꼴깍몬",
						Language.CHN_SIM => "溶食兽",
						Language.CHN_TRA => "溶食獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWALOT:
					return lang switch {
						Language.ENG => "Swalot",
						Language.JPN => "マルノーム",
						Language.GER => "Schlukwech",
						Language.FRE => "Avaltout",
						Language.ITA => "Swalot",
						Language.SPN => "Swalot",
						Language.KOR => "꿀꺽몬",
						Language.CHN_SIM => "吞食兽",
						Language.CHN_TRA => "吞食獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CARVANHA:
					return lang switch {
						Language.ENG => "Carvanha",
						Language.JPN => "キバニア",
						Language.GER => "Kanivanha",
						Language.FRE => "Carvanha",
						Language.ITA => "Carvanha",
						Language.SPN => "Carvanha",
						Language.KOR => "샤프니아",
						Language.CHN_SIM => "利牙鱼",
						Language.CHN_TRA => "利牙魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHARPEDO:
					return lang switch {
						Language.ENG => "Sharpedo",
						Language.JPN => "サメハダー",
						Language.GER => "Tohaido",
						Language.FRE => "Sharpedo",
						Language.ITA => "Sharpedo",
						Language.SPN => "Sharpedo",
						Language.KOR => "샤크니아",
						Language.CHN_SIM => "巨牙鲨",
						Language.CHN_TRA => "巨牙鯊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHARPEDO_MEGA_SHARPEDO:
					return lang switch {
						Language.ENG => "Sharpedo",
						Language.JPN => "サメハダー",
						Language.GER => "Tohaido",
						Language.FRE => "Sharpedo",
						Language.ITA => "Sharpedo",
						Language.SPN => "Sharpedo",
						Language.KOR => "샤크니아",
						Language.CHN_SIM => "巨牙鲨",
						Language.CHN_TRA => "巨牙鯊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WAILMER:
					return lang switch {
						Language.ENG => "Wailmer",
						Language.JPN => "ホエルコ",
						Language.GER => "Wailmer",
						Language.FRE => "Wailmer",
						Language.ITA => "Wailmer",
						Language.SPN => "Wailmer",
						Language.KOR => "고래왕자",
						Language.CHN_SIM => "吼吼鲸",
						Language.CHN_TRA => "吼吼鯨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WAILORD:
					return lang switch {
						Language.ENG => "Wailord",
						Language.JPN => "ホエルオー",
						Language.GER => "Wailord",
						Language.FRE => "Wailord",
						Language.ITA => "Wailord",
						Language.SPN => "Wailord",
						Language.KOR => "고래왕",
						Language.CHN_SIM => "吼鲸王",
						Language.CHN_TRA => "吼鯨王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NUMEL:
					return lang switch {
						Language.ENG => "Numel",
						Language.JPN => "ドンメル",
						Language.GER => "Camaub",
						Language.FRE => "Chamallot",
						Language.ITA => "Numel",
						Language.SPN => "Numel",
						Language.KOR => "둔타",
						Language.CHN_SIM => "呆火驼",
						Language.CHN_TRA => "呆火駝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CAMERUPT:
					return lang switch {
						Language.ENG => "Camerupt",
						Language.JPN => "バクーダ",
						Language.GER => "Camerupt",
						Language.FRE => "Camérupt",
						Language.ITA => "Camerupt",
						Language.SPN => "Camerupt",
						Language.KOR => "폭타",
						Language.CHN_SIM => "喷火驼",
						Language.CHN_TRA => "噴火駝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CAMERUPT_MEGA_CAMERUPT:
					return lang switch {
						Language.ENG => "Camerupt",
						Language.JPN => "バクーダ",
						Language.GER => "Camerupt",
						Language.FRE => "Camérupt",
						Language.ITA => "Camerupt",
						Language.SPN => "Camerupt",
						Language.KOR => "폭타",
						Language.CHN_SIM => "喷火驼",
						Language.CHN_TRA => "噴火駝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TORKOAL:
					return lang switch {
						Language.ENG => "Torkoal",
						Language.JPN => "コータス",
						Language.GER => "Qurtel",
						Language.FRE => "Chartor",
						Language.ITA => "Torkoal",
						Language.SPN => "Torkoal",
						Language.KOR => "코터스",
						Language.CHN_SIM => "煤炭龟",
						Language.CHN_TRA => "煤炭龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPOINK:
					return lang switch {
						Language.ENG => "Spoink",
						Language.JPN => "バネブー",
						Language.GER => "Spoink",
						Language.FRE => "Spoink",
						Language.ITA => "Spoink",
						Language.SPN => "Spoink",
						Language.KOR => "피그점프",
						Language.CHN_SIM => "跳跳猪",
						Language.CHN_TRA => "跳跳豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRUMPIG:
					return lang switch {
						Language.ENG => "Grumpig",
						Language.JPN => "ブーピッグ",
						Language.GER => "Groink",
						Language.FRE => "Groret",
						Language.ITA => "Grumpig",
						Language.SPN => "Grumpig",
						Language.KOR => "피그킹",
						Language.CHN_SIM => "噗噗猪",
						Language.CHN_TRA => "噗噗豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPINDA:
					return lang switch {
						Language.ENG => "Spinda",
						Language.JPN => "パッチール",
						Language.GER => "Pandir",
						Language.FRE => "Spinda",
						Language.ITA => "Spinda",
						Language.SPN => "Spinda",
						Language.KOR => "얼루기",
						Language.CHN_SIM => "晃晃斑",
						Language.CHN_TRA => "晃晃斑",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TRAPINCH:
					return lang switch {
						Language.ENG => "Trapinch",
						Language.JPN => "ナックラー",
						Language.GER => "Knacklion",
						Language.FRE => "Kraknoix",
						Language.ITA => "Trapinch",
						Language.SPN => "Trapinch",
						Language.KOR => "톱치",
						Language.CHN_SIM => "大颚蚁",
						Language.CHN_TRA => "大顎蟻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VIBRAVA:
					return lang switch {
						Language.ENG => "Vibrava",
						Language.JPN => "ビブラーバ",
						Language.GER => "Vibrava",
						Language.FRE => "Vibraninf",
						Language.ITA => "Vibrava",
						Language.SPN => "Vibrava",
						Language.KOR => "비브라바",
						Language.CHN_SIM => "超音波幼虫",
						Language.CHN_TRA => "超音波幼蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLYGON:
					return lang switch {
						Language.ENG => "Flygon",
						Language.JPN => "フライゴン",
						Language.GER => "Libelldra",
						Language.FRE => "Libégon",
						Language.ITA => "Flygon",
						Language.SPN => "Flygon",
						Language.KOR => "플라이곤",
						Language.CHN_SIM => "沙漠蜻蜓",
						Language.CHN_TRA => "沙漠蜻蜓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CACNEA:
					return lang switch {
						Language.ENG => "Cacnea",
						Language.JPN => "サボネア",
						Language.GER => "Tuska",
						Language.FRE => "Cacnea",
						Language.ITA => "Cacnea",
						Language.SPN => "Cacnea",
						Language.KOR => "선인왕",
						Language.CHN_SIM => "刺球仙人掌",
						Language.CHN_TRA => "刺球仙人掌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CACTURNE:
					return lang switch {
						Language.ENG => "Cacturne",
						Language.JPN => "ノクタス",
						Language.GER => "Noktuska",
						Language.FRE => "Cacturne",
						Language.ITA => "Cacturne",
						Language.SPN => "Cacturne",
						Language.KOR => "밤선인",
						Language.CHN_SIM => "梦歌仙人掌",
						Language.CHN_TRA => "夢歌仙人掌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWABLU:
					return lang switch {
						Language.ENG => "Swablu",
						Language.JPN => "チルット",
						Language.GER => "Wablu",
						Language.FRE => "Tylton",
						Language.ITA => "Swablu",
						Language.SPN => "Swablu",
						Language.KOR => "파비코",
						Language.CHN_SIM => "青绵鸟",
						Language.CHN_TRA => "青綿鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ALTARIA:
					return lang switch {
						Language.ENG => "Altaria",
						Language.JPN => "チルタリス",
						Language.GER => "Altaria",
						Language.FRE => "Altaria",
						Language.ITA => "Altaria",
						Language.SPN => "Altaria",
						Language.KOR => "파비코리",
						Language.CHN_SIM => "七夕青鸟",
						Language.CHN_TRA => "七夕青鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ALTARIA_MEGA_ALTARIA:
					return lang switch {
						Language.ENG => "Altaria",
						Language.JPN => "チルタリス",
						Language.GER => "Altaria",
						Language.FRE => "Altaria",
						Language.ITA => "Altaria",
						Language.SPN => "Altaria",
						Language.KOR => "파비코리",
						Language.CHN_SIM => "七夕青鸟",
						Language.CHN_TRA => "七夕青鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZANGOOSE:
					return lang switch {
						Language.ENG => "Zangoose",
						Language.JPN => "ザングース",
						Language.GER => "Sengo",
						Language.FRE => "Mangriff",
						Language.ITA => "Zangoose",
						Language.SPN => "Zangoose",
						Language.KOR => "쟝고",
						Language.CHN_SIM => "猫鼬斩",
						Language.CHN_TRA => "貓鼬斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEVIPER:
					return lang switch {
						Language.ENG => "Seviper",
						Language.JPN => "ハブネーク",
						Language.GER => "Vipitis",
						Language.FRE => "Séviper",
						Language.ITA => "Seviper",
						Language.SPN => "Seviper",
						Language.KOR => "세비퍼",
						Language.CHN_SIM => "饭匙蛇",
						Language.CHN_TRA => "飯匙蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUNATONE:
					return lang switch {
						Language.ENG => "Lunatone",
						Language.JPN => "ルナトーン",
						Language.GER => "Lunastein",
						Language.FRE => "Séléroc",
						Language.ITA => "Lunatone",
						Language.SPN => "Lunatone",
						Language.KOR => "루나톤",
						Language.CHN_SIM => "月石",
						Language.CHN_TRA => "月石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SOLROCK:
					return lang switch {
						Language.ENG => "Solrock",
						Language.JPN => "ソルロック",
						Language.GER => "Sonnfel",
						Language.FRE => "Solaroc",
						Language.ITA => "Solrock",
						Language.SPN => "Solrock",
						Language.KOR => "솔록",
						Language.CHN_SIM => "太阳岩",
						Language.CHN_TRA => "太陽岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BARBOACH:
					return lang switch {
						Language.ENG => "Barboach",
						Language.JPN => "ドジョッチ",
						Language.GER => "Schmerbe",
						Language.FRE => "Barloche",
						Language.ITA => "Barboach",
						Language.SPN => "Barboach",
						Language.KOR => "미꾸리",
						Language.CHN_SIM => "泥泥鳅",
						Language.CHN_TRA => "泥泥鰍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WHISCASH:
					return lang switch {
						Language.ENG => "Whiscash",
						Language.JPN => "ナマズン",
						Language.GER => "Welsar",
						Language.FRE => "Barbicha",
						Language.ITA => "Whiscash",
						Language.SPN => "Whiscash",
						Language.KOR => "메깅",
						Language.CHN_SIM => "鲶鱼王",
						Language.CHN_TRA => "鯰魚王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CORPHISH:
					return lang switch {
						Language.ENG => "Corphish",
						Language.JPN => "ヘイガニ",
						Language.GER => "Krebscorps",
						Language.FRE => "Écrapince",
						Language.ITA => "Corphish",
						Language.SPN => "Corphish",
						Language.KOR => "가재군",
						Language.CHN_SIM => "龙虾小兵",
						Language.CHN_TRA => "龍蝦小兵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRAWDAUNT:
					return lang switch {
						Language.ENG => "Crawdaunt",
						Language.JPN => "シザリガー",
						Language.GER => "Krebutack",
						Language.FRE => "Colhomard",
						Language.ITA => "Crawdaunt",
						Language.SPN => "Crawdaunt",
						Language.KOR => "가재장군",
						Language.CHN_SIM => "铁螯龙虾",
						Language.CHN_TRA => "鐵螯龍蝦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BALTOY:
					return lang switch {
						Language.ENG => "Baltoy",
						Language.JPN => "ヤジロン",
						Language.GER => "Puppance",
						Language.FRE => "Balbuto",
						Language.ITA => "Baltoy",
						Language.SPN => "Baltoy",
						Language.KOR => "오뚝군",
						Language.CHN_SIM => "天秤偶",
						Language.CHN_TRA => "天秤偶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLAYDOL:
					return lang switch {
						Language.ENG => "Claydol",
						Language.JPN => "ネンドール",
						Language.GER => "Lepumentas",
						Language.FRE => "Kaorine",
						Language.ITA => "Claydol",
						Language.SPN => "Claydol",
						Language.KOR => "점토도리",
						Language.CHN_SIM => "念力土偶",
						Language.CHN_TRA => "念力土偶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LILEEP:
					return lang switch {
						Language.ENG => "Lileep",
						Language.JPN => "リリーラ",
						Language.GER => "Liliep",
						Language.FRE => "Lilia",
						Language.ITA => "Lileep",
						Language.SPN => "Lileep",
						Language.KOR => "릴링",
						Language.CHN_SIM => "触手百合",
						Language.CHN_TRA => "觸手百合",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRADILY:
					return lang switch {
						Language.ENG => "Cradily",
						Language.JPN => "ユレイドル",
						Language.GER => "Wielie",
						Language.FRE => "Vacilys",
						Language.ITA => "Cradily",
						Language.SPN => "Cradily",
						Language.KOR => "릴리요",
						Language.CHN_SIM => "摇篮百合",
						Language.CHN_TRA => "搖籃百合",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ANORITH:
					return lang switch {
						Language.ENG => "Anorith",
						Language.JPN => "アノプス",
						Language.GER => "Anorith",
						Language.FRE => "Anorith",
						Language.ITA => "Anorith",
						Language.SPN => "Anorith",
						Language.KOR => "아노딥스",
						Language.CHN_SIM => "太古羽虫",
						Language.CHN_TRA => "太古羽蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARMALDO:
					return lang switch {
						Language.ENG => "Armaldo",
						Language.JPN => "アーマルド",
						Language.GER => "Armaldo",
						Language.FRE => "Armaldo",
						Language.ITA => "Armaldo",
						Language.SPN => "Armaldo",
						Language.KOR => "아말도",
						Language.CHN_SIM => "太古盔甲",
						Language.CHN_TRA => "太古盔甲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FEEBAS:
					return lang switch {
						Language.ENG => "Feebas",
						Language.JPN => "ヒンバス",
						Language.GER => "Barschwa",
						Language.FRE => "Barpau",
						Language.ITA => "Feebas",
						Language.SPN => "Feebas",
						Language.KOR => "빈티나",
						Language.CHN_SIM => "丑丑鱼",
						Language.CHN_TRA => "醜醜魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MILOTIC:
					return lang switch {
						Language.ENG => "Milotic",
						Language.JPN => "ミロカロス",
						Language.GER => "Milotic",
						Language.FRE => "Milobellus",
						Language.ITA => "Milotic",
						Language.SPN => "Milotic",
						Language.KOR => "밀로틱",
						Language.CHN_SIM => "美纳斯",
						Language.CHN_TRA => "美納斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CASTFORM:
					return lang switch {
						Language.ENG => "Castform",
						Language.JPN => "ポワルン",
						Language.GER => "Formeo",
						Language.FRE => "Morphéo",
						Language.ITA => "Castform",
						Language.SPN => "Castform",
						Language.KOR => "캐스퐁",
						Language.CHN_SIM => "飘浮泡泡",
						Language.CHN_TRA => "飄浮泡泡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CASTFORM_SUNNY_FORM:
					return lang switch {
						Language.ENG => "Castform",
						Language.JPN => "ポワルン",
						Language.GER => "Formeo",
						Language.FRE => "Morphéo",
						Language.ITA => "Castform",
						Language.SPN => "Castform",
						Language.KOR => "캐스퐁",
						Language.CHN_SIM => "飘浮泡泡",
						Language.CHN_TRA => "飄浮泡泡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CASTFORM_RAINY_FORM:
					return lang switch {
						Language.ENG => "Castform",
						Language.JPN => "ポワルン",
						Language.GER => "Formeo",
						Language.FRE => "Morphéo",
						Language.ITA => "Castform",
						Language.SPN => "Castform",
						Language.KOR => "캐스퐁",
						Language.CHN_SIM => "飘浮泡泡",
						Language.CHN_TRA => "飄浮泡泡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CASTFORM_SNOWY_FORM:
					return lang switch {
						Language.ENG => "Castform",
						Language.JPN => "ポワルン",
						Language.GER => "Formeo",
						Language.FRE => "Morphéo",
						Language.ITA => "Castform",
						Language.SPN => "Castform",
						Language.KOR => "캐스퐁",
						Language.CHN_SIM => "飘浮泡泡",
						Language.CHN_TRA => "飄浮泡泡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KECLEON:
					return lang switch {
						Language.ENG => "Kecleon",
						Language.JPN => "カクレオン",
						Language.GER => "Kecleon",
						Language.FRE => "Kecleon",
						Language.ITA => "Kecleon",
						Language.SPN => "Kecleon",
						Language.KOR => "켈리몬",
						Language.CHN_SIM => "变隐龙",
						Language.CHN_TRA => "變隱龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHUPPET:
					return lang switch {
						Language.ENG => "Shuppet",
						Language.JPN => "カゲボウズ",
						Language.GER => "Shuppet",
						Language.FRE => "Polichombr",
						Language.ITA => "Shuppet",
						Language.SPN => "Shuppet",
						Language.KOR => "어둠대신",
						Language.CHN_SIM => "怨影娃娃",
						Language.CHN_TRA => "怨影娃娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BANETTE:
					return lang switch {
						Language.ENG => "Banette",
						Language.JPN => "ジュペッタ",
						Language.GER => "Banette",
						Language.FRE => "Branette",
						Language.ITA => "Banette",
						Language.SPN => "Banette",
						Language.KOR => "다크펫",
						Language.CHN_SIM => "诅咒娃娃",
						Language.CHN_TRA => "詛咒娃娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BANETTE_MEGA_BANETTE:
					return lang switch {
						Language.ENG => "Banette",
						Language.JPN => "ジュペッタ",
						Language.GER => "Banette",
						Language.FRE => "Branette",
						Language.ITA => "Banette",
						Language.SPN => "Banette",
						Language.KOR => "다크펫",
						Language.CHN_SIM => "诅咒娃娃",
						Language.CHN_TRA => "詛咒娃娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUSKULL:
					return lang switch {
						Language.ENG => "Duskull",
						Language.JPN => "ヨマワル",
						Language.GER => "Zwirrlicht",
						Language.FRE => "Skelénox",
						Language.ITA => "Duskull",
						Language.SPN => "Duskull",
						Language.KOR => "해골몽",
						Language.CHN_SIM => "夜巡灵",
						Language.CHN_TRA => "夜巡靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUSCLOPS:
					return lang switch {
						Language.ENG => "Dusclops",
						Language.JPN => "サマヨール",
						Language.GER => "Zwirrklop",
						Language.FRE => "Téraclope",
						Language.ITA => "Dusclops",
						Language.SPN => "Dusclops",
						Language.KOR => "미라몽",
						Language.CHN_SIM => "彷徨夜灵",
						Language.CHN_TRA => "彷徨夜靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TROPIUS:
					return lang switch {
						Language.ENG => "Tropius",
						Language.JPN => "トロピウス",
						Language.GER => "Tropius",
						Language.FRE => "Tropius",
						Language.ITA => "Tropius",
						Language.SPN => "Tropius",
						Language.KOR => "트로피우스",
						Language.CHN_SIM => "热带龙",
						Language.CHN_TRA => "熱帶龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHIMECHO:
					return lang switch {
						Language.ENG => "Chimecho",
						Language.JPN => "チリーン",
						Language.GER => "Palimpalim",
						Language.FRE => "Éoko",
						Language.ITA => "Chimecho",
						Language.SPN => "Chimecho",
						Language.KOR => "치렁",
						Language.CHN_SIM => "风铃铃",
						Language.CHN_TRA => "風鈴鈴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ABSOL:
					return lang switch {
						Language.ENG => "Absol",
						Language.JPN => "アブソル",
						Language.GER => "Absol",
						Language.FRE => "Absol",
						Language.ITA => "Absol",
						Language.SPN => "Absol",
						Language.KOR => "앱솔",
						Language.CHN_SIM => "阿勃梭鲁",
						Language.CHN_TRA => "阿勃梭魯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ABSOL_MEGA_ABSOL:
					return lang switch {
						Language.ENG => "Absol",
						Language.JPN => "アブソル",
						Language.GER => "Absol",
						Language.FRE => "Absol",
						Language.ITA => "Absol",
						Language.SPN => "Absol",
						Language.KOR => "앱솔",
						Language.CHN_SIM => "阿勃梭鲁",
						Language.CHN_TRA => "阿勃梭魯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WYNAUT:
					return lang switch {
						Language.ENG => "Wynaut",
						Language.JPN => "ソーナノ",
						Language.GER => "Isso",
						Language.FRE => "Okéoké",
						Language.ITA => "Wynaut",
						Language.SPN => "Wynaut",
						Language.KOR => "마자",
						Language.CHN_SIM => "小果然",
						Language.CHN_TRA => "小果然",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNORUNT:
					return lang switch {
						Language.ENG => "Snorunt",
						Language.JPN => "ユキワラシ",
						Language.GER => "Schneppke",
						Language.FRE => "Stalgamin",
						Language.ITA => "Snorunt",
						Language.SPN => "Snorunt",
						Language.KOR => "눈꼬마",
						Language.CHN_SIM => "雪童子",
						Language.CHN_TRA => "雪童子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLALIE:
					return lang switch {
						Language.ENG => "Glalie",
						Language.JPN => "オニゴーリ",
						Language.GER => "Firnontor",
						Language.FRE => "Oniglali",
						Language.ITA => "Glalie",
						Language.SPN => "Glalie",
						Language.KOR => "얼음귀신",
						Language.CHN_SIM => "冰鬼护",
						Language.CHN_TRA => "冰鬼護",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLALIE_MEGA_GLALIE:
					return lang switch {
						Language.ENG => "Glalie",
						Language.JPN => "オニゴーリ",
						Language.GER => "Firnontor",
						Language.FRE => "Oniglali",
						Language.ITA => "Glalie",
						Language.SPN => "Glalie",
						Language.KOR => "얼음귀신",
						Language.CHN_SIM => "冰鬼护",
						Language.CHN_TRA => "冰鬼護",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPHEAL:
					return lang switch {
						Language.ENG => "Spheal",
						Language.JPN => "タマザラシ",
						Language.GER => "Seemops",
						Language.FRE => "Obalie",
						Language.ITA => "Spheal",
						Language.SPN => "Spheal",
						Language.KOR => "대굴레오",
						Language.CHN_SIM => "海豹球",
						Language.CHN_TRA => "海豹球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEALEO:
					return lang switch {
						Language.ENG => "Sealeo",
						Language.JPN => "トドグラー",
						Language.GER => "Seejong",
						Language.FRE => "Phogleur",
						Language.ITA => "Sealeo",
						Language.SPN => "Sealeo",
						Language.KOR => "씨레오",
						Language.CHN_SIM => "海魔狮",
						Language.CHN_TRA => "海魔獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WALREIN:
					return lang switch {
						Language.ENG => "Walrein",
						Language.JPN => "トドゼルガ",
						Language.GER => "Walraisa",
						Language.FRE => "Kaimorse",
						Language.ITA => "Walrein",
						Language.SPN => "Walrein",
						Language.KOR => "씨카이저",
						Language.CHN_SIM => "帝牙海狮",
						Language.CHN_TRA => "帝牙海獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLAMPERL:
					return lang switch {
						Language.ENG => "Clamperl",
						Language.JPN => "パールル",
						Language.GER => "Perlu",
						Language.FRE => "Coquiperl",
						Language.ITA => "Clamperl",
						Language.SPN => "Clamperl",
						Language.KOR => "진주몽",
						Language.CHN_SIM => "珍珠贝",
						Language.CHN_TRA => "珍珠貝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HUNTAIL:
					return lang switch {
						Language.ENG => "Huntail",
						Language.JPN => "ハンテール",
						Language.GER => "Aalabyss",
						Language.FRE => "Serpang",
						Language.ITA => "Huntail",
						Language.SPN => "Huntail",
						Language.KOR => "헌테일",
						Language.CHN_SIM => "猎斑鱼",
						Language.CHN_TRA => "獵斑魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOREBYSS:
					return lang switch {
						Language.ENG => "Gorebyss",
						Language.JPN => "サクラビス",
						Language.GER => "Saganabyss",
						Language.FRE => "Rosabyss",
						Language.ITA => "Gorebyss",
						Language.SPN => "Gorebyss",
						Language.KOR => "분홍장이",
						Language.CHN_SIM => "樱花鱼",
						Language.CHN_TRA => "櫻花魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RELICANTH:
					return lang switch {
						Language.ENG => "Relicanth",
						Language.JPN => "ジーランス",
						Language.GER => "Relicanth",
						Language.FRE => "Relicanth",
						Language.ITA => "Relicanth",
						Language.SPN => "Relicanth",
						Language.KOR => "시라칸",
						Language.CHN_SIM => "古空棘鱼",
						Language.CHN_TRA => "古空棘魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUVDISC:
					return lang switch {
						Language.ENG => "Luvdisc",
						Language.JPN => "ラブカス",
						Language.GER => "Liebiskus",
						Language.FRE => "Lovdisc",
						Language.ITA => "Luvdisc",
						Language.SPN => "Luvdisc",
						Language.KOR => "사랑동이",
						Language.CHN_SIM => "爱心鱼",
						Language.CHN_TRA => "愛心魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BAGON:
					return lang switch {
						Language.ENG => "Bagon",
						Language.JPN => "タツベイ",
						Language.GER => "Kindwurm",
						Language.FRE => "Draby",
						Language.ITA => "Bagon",
						Language.SPN => "Bagon",
						Language.KOR => "아공이",
						Language.CHN_SIM => "宝贝龙",
						Language.CHN_TRA => "寶貝龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHELGON:
					return lang switch {
						Language.ENG => "Shelgon",
						Language.JPN => "コモルー",
						Language.GER => "Draschel",
						Language.FRE => "Drackhaus",
						Language.ITA => "Shelgon",
						Language.SPN => "Shelgon",
						Language.KOR => "쉘곤",
						Language.CHN_SIM => "甲壳龙",
						Language.CHN_TRA => "甲殼龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SALAMENCE:
					return lang switch {
						Language.ENG => "Salamence",
						Language.JPN => "ボーマンダ",
						Language.GER => "Brutalanda",
						Language.FRE => "Drattak",
						Language.ITA => "Salamence",
						Language.SPN => "Salamence",
						Language.KOR => "보만다",
						Language.CHN_SIM => "暴飞龙",
						Language.CHN_TRA => "暴飛龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SALAMENCE_MEGA_SALAMENCE:
					return lang switch {
						Language.ENG => "Salamence",
						Language.JPN => "ボーマンダ",
						Language.GER => "Brutalanda",
						Language.FRE => "Drattak",
						Language.ITA => "Salamence",
						Language.SPN => "Salamence",
						Language.KOR => "보만다",
						Language.CHN_SIM => "暴飞龙",
						Language.CHN_TRA => "暴飛龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BELDUM:
					return lang switch {
						Language.ENG => "Beldum",
						Language.JPN => "ダンバル",
						Language.GER => "Tanhel",
						Language.FRE => "Terhal",
						Language.ITA => "Beldum",
						Language.SPN => "Beldum",
						Language.KOR => "메탕",
						Language.CHN_SIM => "铁哑铃",
						Language.CHN_TRA => "鐵啞鈴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.METANG:
					return lang switch {
						Language.ENG => "Metang",
						Language.JPN => "メタング",
						Language.GER => "Metang",
						Language.FRE => "Métang",
						Language.ITA => "Metang",
						Language.SPN => "Metang",
						Language.KOR => "메탕구",
						Language.CHN_SIM => "金属怪",
						Language.CHN_TRA => "金屬怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.METAGROSS:
					return lang switch {
						Language.ENG => "Metagross",
						Language.JPN => "メタグロス",
						Language.GER => "Metagross",
						Language.FRE => "Métalosse",
						Language.ITA => "Metagross",
						Language.SPN => "Metagross",
						Language.KOR => "메타그로스",
						Language.CHN_SIM => "巨金怪",
						Language.CHN_TRA => "巨金怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.METAGROSS_MEGA_METAGROSS:
					return lang switch {
						Language.ENG => "Metagross",
						Language.JPN => "メタグロス",
						Language.GER => "Metagross",
						Language.FRE => "Métalosse",
						Language.ITA => "Metagross",
						Language.SPN => "Metagross",
						Language.KOR => "메타그로스",
						Language.CHN_SIM => "巨金怪",
						Language.CHN_TRA => "巨金怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REGIROCK:
					return lang switch {
						Language.ENG => "Regirock",
						Language.JPN => "レジロック",
						Language.GER => "Regirock",
						Language.FRE => "Regirock",
						Language.ITA => "Regirock",
						Language.SPN => "Regirock",
						Language.KOR => "레지락",
						Language.CHN_SIM => "雷吉洛克",
						Language.CHN_TRA => "雷吉洛克",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REGICE:
					return lang switch {
						Language.ENG => "Regice",
						Language.JPN => "レジアイス",
						Language.GER => "Regice",
						Language.FRE => "Regice",
						Language.ITA => "Regice",
						Language.SPN => "Regice",
						Language.KOR => "레지아이스",
						Language.CHN_SIM => "雷吉艾斯",
						Language.CHN_TRA => "雷吉艾斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REGISTEEL:
					return lang switch {
						Language.ENG => "Registeel",
						Language.JPN => "レジスチル",
						Language.GER => "Registeel",
						Language.FRE => "Registeel",
						Language.ITA => "Registeel",
						Language.SPN => "Registeel",
						Language.KOR => "레지스틸",
						Language.CHN_SIM => "雷吉斯奇鲁",
						Language.CHN_TRA => "雷吉斯奇魯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LATIAS:
					return lang switch {
						Language.ENG => "Latias",
						Language.JPN => "ラティアス",
						Language.GER => "Latias",
						Language.FRE => "Latias",
						Language.ITA => "Latias",
						Language.SPN => "Latias",
						Language.KOR => "라티아스",
						Language.CHN_SIM => "拉帝亚斯",
						Language.CHN_TRA => "拉帝亞斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LATIAS_MEGA_LATIAS:
					return lang switch {
						Language.ENG => "Latias",
						Language.JPN => "ラティアス",
						Language.GER => "Latias",
						Language.FRE => "Latias",
						Language.ITA => "Latias",
						Language.SPN => "Latias",
						Language.KOR => "라티아스",
						Language.CHN_SIM => "拉帝亚斯",
						Language.CHN_TRA => "拉帝亞斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LATIOS:
					return lang switch {
						Language.ENG => "Latios",
						Language.JPN => "ラティオス",
						Language.GER => "Latios",
						Language.FRE => "Latios",
						Language.ITA => "Latios",
						Language.SPN => "Latios",
						Language.KOR => "라티오스",
						Language.CHN_SIM => "拉帝欧斯",
						Language.CHN_TRA => "拉帝歐斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LATIOS_MEGA_LATIOS:
					return lang switch {
						Language.ENG => "Latios",
						Language.JPN => "ラティオス",
						Language.GER => "Latios",
						Language.FRE => "Latios",
						Language.ITA => "Latios",
						Language.SPN => "Latios",
						Language.KOR => "라티오스",
						Language.CHN_SIM => "拉帝欧斯",
						Language.CHN_TRA => "拉帝歐斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KYOGRE:
					return lang switch {
						Language.ENG => "Kyogre",
						Language.JPN => "カイオーガ",
						Language.GER => "Kyogre",
						Language.FRE => "Kyogre",
						Language.ITA => "Kyogre",
						Language.SPN => "Kyogre",
						Language.KOR => "가이오가",
						Language.CHN_SIM => "盖欧卡",
						Language.CHN_TRA => "蓋歐卡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KYOGRE_PRIMAL_KYOGRE:
					return lang switch {
						Language.ENG => "Kyogre",
						Language.JPN => "カイオーガ",
						Language.GER => "Kyogre",
						Language.FRE => "Kyogre",
						Language.ITA => "Kyogre",
						Language.SPN => "Kyogre",
						Language.KOR => "가이오가",
						Language.CHN_SIM => "盖欧卡",
						Language.CHN_TRA => "蓋歐卡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROUDON:
					return lang switch {
						Language.ENG => "Groudon",
						Language.JPN => "グラードン",
						Language.GER => "Groudon",
						Language.FRE => "Groudon",
						Language.ITA => "Groudon",
						Language.SPN => "Groudon",
						Language.KOR => "그란돈",
						Language.CHN_SIM => "固拉多",
						Language.CHN_TRA => "固拉多",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROUDON_PRIMAL_GROUDON:
					return lang switch {
						Language.ENG => "Groudon",
						Language.JPN => "グラードン",
						Language.GER => "Groudon",
						Language.FRE => "Groudon",
						Language.ITA => "Groudon",
						Language.SPN => "Groudon",
						Language.KOR => "그란돈",
						Language.CHN_SIM => "固拉多",
						Language.CHN_TRA => "固拉多",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAYQUAZA:
					return lang switch {
						Language.ENG => "Rayquaza",
						Language.JPN => "レックウザ",
						Language.GER => "Rayquaza",
						Language.FRE => "Rayquaza",
						Language.ITA => "Rayquaza",
						Language.SPN => "Rayquaza",
						Language.KOR => "레쿠쟈",
						Language.CHN_SIM => "烈空坐",
						Language.CHN_TRA => "烈空坐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAYQUAZA_MEGA_RAYQUAZA:
					return lang switch {
						Language.ENG => "Rayquaza",
						Language.JPN => "レックウザ",
						Language.GER => "Rayquaza",
						Language.FRE => "Rayquaza",
						Language.ITA => "Rayquaza",
						Language.SPN => "Rayquaza",
						Language.KOR => "레쿠쟈",
						Language.CHN_SIM => "烈空坐",
						Language.CHN_TRA => "烈空坐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JIRACHI:
					return lang switch {
						Language.ENG => "Jirachi",
						Language.JPN => "ジラーチ",
						Language.GER => "Jirachi",
						Language.FRE => "Jirachi",
						Language.ITA => "Jirachi",
						Language.SPN => "Jirachi",
						Language.KOR => "지라치",
						Language.CHN_SIM => "基拉祈",
						Language.CHN_TRA => "基拉祈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEOXYS_NORMAL_FORME:
					return lang switch {
						Language.ENG => "Deoxys",
						Language.JPN => "デオキシス",
						Language.GER => "Deoxys",
						Language.FRE => "Deoxys",
						Language.ITA => "Deoxys",
						Language.SPN => "Deoxys",
						Language.KOR => "테오키스",
						Language.CHN_SIM => "代欧奇希斯",
						Language.CHN_TRA => "代歐奇希斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEOXYS_ATTACK_FORME:
					return lang switch {
						Language.ENG => "Deoxys",
						Language.JPN => "デオキシス",
						Language.GER => "Deoxys",
						Language.FRE => "Deoxys",
						Language.ITA => "Deoxys",
						Language.SPN => "Deoxys",
						Language.KOR => "테오키스",
						Language.CHN_SIM => "代欧奇希斯",
						Language.CHN_TRA => "代歐奇希斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEOXYS_DEFENSE_FORME:
					return lang switch {
						Language.ENG => "Deoxys",
						Language.JPN => "デオキシス",
						Language.GER => "Deoxys",
						Language.FRE => "Deoxys",
						Language.ITA => "Deoxys",
						Language.SPN => "Deoxys",
						Language.KOR => "테오키스",
						Language.CHN_SIM => "代欧奇希斯",
						Language.CHN_TRA => "代歐奇希斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEOXYS_SPEED_FORME:
					return lang switch {
						Language.ENG => "Deoxys",
						Language.JPN => "デオキシス",
						Language.GER => "Deoxys",
						Language.FRE => "Deoxys",
						Language.ITA => "Deoxys",
						Language.SPN => "Deoxys",
						Language.KOR => "테오키스",
						Language.CHN_SIM => "代欧奇希斯",
						Language.CHN_TRA => "代歐奇希斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TURTWIG:
					return lang switch {
						Language.ENG => "Turtwig",
						Language.JPN => "ナエトル",
						Language.GER => "Chelast",
						Language.FRE => "Tortipouss",
						Language.ITA => "Turtwig",
						Language.SPN => "Turtwig",
						Language.KOR => "모부기",
						Language.CHN_SIM => "草苗龟",
						Language.CHN_TRA => "草苗龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROTLE:
					return lang switch {
						Language.ENG => "Grotle",
						Language.JPN => "ハヤシガメ",
						Language.GER => "Chelcarain",
						Language.FRE => "Boskara",
						Language.ITA => "Grotle",
						Language.SPN => "Grotle",
						Language.KOR => "수풀부기",
						Language.CHN_SIM => "树林龟",
						Language.CHN_TRA => "樹林龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TORTERRA:
					return lang switch {
						Language.ENG => "Torterra",
						Language.JPN => "ドダイトス",
						Language.GER => "Chelterrar",
						Language.FRE => "Torterra",
						Language.ITA => "Torterra",
						Language.SPN => "Torterra",
						Language.KOR => "토대부기",
						Language.CHN_SIM => "土台龟",
						Language.CHN_TRA => "土台龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHIMCHAR:
					return lang switch {
						Language.ENG => "Chimchar",
						Language.JPN => "ヒコザル",
						Language.GER => "Panflam",
						Language.FRE => "Ouisticram",
						Language.ITA => "Chimchar",
						Language.SPN => "Chimchar",
						Language.KOR => "불꽃숭이",
						Language.CHN_SIM => "小火焰猴",
						Language.CHN_TRA => "小火焰猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MONFERNO:
					return lang switch {
						Language.ENG => "Monferno",
						Language.JPN => "モウカザル",
						Language.GER => "Panpyro",
						Language.FRE => "Chimpenfeu",
						Language.ITA => "Monferno",
						Language.SPN => "Monferno",
						Language.KOR => "파이숭이",
						Language.CHN_SIM => "猛火猴",
						Language.CHN_TRA => "猛火猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.INFERNAPE:
					return lang switch {
						Language.ENG => "Infernape",
						Language.JPN => "ゴウカザル",
						Language.GER => "Panferno",
						Language.FRE => "Simiabraz",
						Language.ITA => "Infernape",
						Language.SPN => "Infernape",
						Language.KOR => "초염몽",
						Language.CHN_SIM => "烈焰猴",
						Language.CHN_TRA => "烈焰猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIPLUP:
					return lang switch {
						Language.ENG => "Piplup",
						Language.JPN => "ポッチャマ",
						Language.GER => "Plinfa",
						Language.FRE => "Tiplouf",
						Language.ITA => "Piplup",
						Language.SPN => "Piplup",
						Language.KOR => "팽도리",
						Language.CHN_SIM => "波加曼",
						Language.CHN_TRA => "波加曼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PRINPLUP:
					return lang switch {
						Language.ENG => "Prinplup",
						Language.JPN => "ポッタイシ",
						Language.GER => "Pliprin",
						Language.FRE => "Prinplouf",
						Language.ITA => "Prinplup",
						Language.SPN => "Prinplup",
						Language.KOR => "팽태자",
						Language.CHN_SIM => "波皇子",
						Language.CHN_TRA => "波皇子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EMPOLEON:
					return lang switch {
						Language.ENG => "Empoleon",
						Language.JPN => "エンペルト",
						Language.GER => "Impoleon",
						Language.FRE => "Pingoléon",
						Language.ITA => "Empoleon",
						Language.SPN => "Empoleon",
						Language.KOR => "엠페르트",
						Language.CHN_SIM => "帝王拿波",
						Language.CHN_TRA => "帝王拿波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STARLY:
					return lang switch {
						Language.ENG => "Starly",
						Language.JPN => "ムックル",
						Language.GER => "Staralili",
						Language.FRE => "Étourmi",
						Language.ITA => "Starly",
						Language.SPN => "Starly",
						Language.KOR => "찌르꼬",
						Language.CHN_SIM => "姆克儿",
						Language.CHN_TRA => "姆克兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STARAVIA:
					return lang switch {
						Language.ENG => "Staravia",
						Language.JPN => "ムクバード",
						Language.GER => "Staravia",
						Language.FRE => "Étourvol",
						Language.ITA => "Staravia",
						Language.SPN => "Staravia",
						Language.KOR => "찌르버드",
						Language.CHN_SIM => "姆克鸟",
						Language.CHN_TRA => "姆克鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STARAPTOR:
					return lang switch {
						Language.ENG => "Staraptor",
						Language.JPN => "ムクホーク",
						Language.GER => "Staraptor",
						Language.FRE => "Étouraptor",
						Language.ITA => "Staraptor",
						Language.SPN => "Staraptor",
						Language.KOR => "찌르호크",
						Language.CHN_SIM => "姆克鹰",
						Language.CHN_TRA => "姆克鷹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BIDOOF:
					return lang switch {
						Language.ENG => "Bidoof",
						Language.JPN => "ビッパ",
						Language.GER => "Bidiza",
						Language.FRE => "Keunotor",
						Language.ITA => "Bidoof",
						Language.SPN => "Bidoof",
						Language.KOR => "비버니",
						Language.CHN_SIM => "大牙狸",
						Language.CHN_TRA => "大牙狸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BIBAREL:
					return lang switch {
						Language.ENG => "Bibarel",
						Language.JPN => "ビーダル",
						Language.GER => "Bidifas",
						Language.FRE => "Castorno",
						Language.ITA => "Bibarel",
						Language.SPN => "Bibarel",
						Language.KOR => "비버통",
						Language.CHN_SIM => "大尾狸",
						Language.CHN_TRA => "大尾狸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KRICKETOT:
					return lang switch {
						Language.ENG => "Kricketot",
						Language.JPN => "コロボーシ",
						Language.GER => "Zirpurze",
						Language.FRE => "Crikzik",
						Language.ITA => "Kricketot",
						Language.SPN => "Kricketot",
						Language.KOR => "귀뚤뚜기",
						Language.CHN_SIM => "圆法师",
						Language.CHN_TRA => "圓法師",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KRICKETUNE:
					return lang switch {
						Language.ENG => "Kricketune",
						Language.JPN => "コロトック",
						Language.GER => "Zirpeise",
						Language.FRE => "Mélokrik",
						Language.ITA => "Kricketune",
						Language.SPN => "Kricketune",
						Language.KOR => "귀뚤톡크",
						Language.CHN_SIM => "音箱蟀",
						Language.CHN_TRA => "音箱蟀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHINX:
					return lang switch {
						Language.ENG => "Shinx",
						Language.JPN => "コリンク",
						Language.GER => "Sheinux",
						Language.FRE => "Lixy",
						Language.ITA => "Shinx",
						Language.SPN => "Shinx",
						Language.KOR => "꼬링크",
						Language.CHN_SIM => "小猫怪",
						Language.CHN_TRA => "小貓怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUXIO:
					return lang switch {
						Language.ENG => "Luxio",
						Language.JPN => "ルクシオ",
						Language.GER => "Luxio",
						Language.FRE => "Luxio",
						Language.ITA => "Luxio",
						Language.SPN => "Luxio",
						Language.KOR => "럭시오",
						Language.CHN_SIM => "勒克猫",
						Language.CHN_TRA => "勒克貓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUXRAY:
					return lang switch {
						Language.ENG => "Luxray",
						Language.JPN => "レントラー",
						Language.GER => "Luxtra",
						Language.FRE => "Luxray",
						Language.ITA => "Luxray",
						Language.SPN => "Luxray",
						Language.KOR => "렌트라",
						Language.CHN_SIM => "伦琴猫",
						Language.CHN_TRA => "倫琴貓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BUDEW:
					return lang switch {
						Language.ENG => "Budew",
						Language.JPN => "スボミー",
						Language.GER => "Knospi",
						Language.FRE => "Rozbouton",
						Language.ITA => "Budew",
						Language.SPN => "Budew",
						Language.KOR => "꼬몽울",
						Language.CHN_SIM => "含羞苞",
						Language.CHN_TRA => "含羞苞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROSERADE:
					return lang switch {
						Language.ENG => "Roserade",
						Language.JPN => "ロズレイド",
						Language.GER => "Roserade",
						Language.FRE => "Roserade",
						Language.ITA => "Roserade",
						Language.SPN => "Roserade",
						Language.KOR => "로즈레이드",
						Language.CHN_SIM => "罗丝雷朵",
						Language.CHN_TRA => "羅絲雷朵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRANIDOS:
					return lang switch {
						Language.ENG => "Cranidos",
						Language.JPN => "ズガイドス",
						Language.GER => "Koknodon",
						Language.FRE => "Kranidos",
						Language.ITA => "Cranidos",
						Language.SPN => "Cranidos",
						Language.KOR => "두개도스",
						Language.CHN_SIM => "头盖龙",
						Language.CHN_TRA => "頭蓋龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RAMPARDOS:
					return lang switch {
						Language.ENG => "Rampardos",
						Language.JPN => "ラムパルド",
						Language.GER => "Rameidon",
						Language.FRE => "Charkos",
						Language.ITA => "Rampardos",
						Language.SPN => "Rampardos",
						Language.KOR => "램펄드",
						Language.CHN_SIM => "战槌龙",
						Language.CHN_TRA => "戰槌龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHIELDON:
					return lang switch {
						Language.ENG => "Shieldon",
						Language.JPN => "タテトプス",
						Language.GER => "Schilterus",
						Language.FRE => "Dinoclier",
						Language.ITA => "Shieldon",
						Language.SPN => "Shieldon",
						Language.KOR => "방패톱스",
						Language.CHN_SIM => "盾甲龙",
						Language.CHN_TRA => "盾甲龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BASTIODON:
					return lang switch {
						Language.ENG => "Bastiodon",
						Language.JPN => "トリデプス",
						Language.GER => "Bollterus",
						Language.FRE => "Bastiodon",
						Language.ITA => "Bastiodon",
						Language.SPN => "Bastiodon",
						Language.KOR => "바리톱스",
						Language.CHN_SIM => "护城龙",
						Language.CHN_TRA => "護城龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BURMY_PLANT_CLOAK:
					return lang switch {
						Language.ENG => "Burmy",
						Language.JPN => "ミノムッチ",
						Language.GER => "Burmy",
						Language.FRE => "Cheniti",
						Language.ITA => "Burmy",
						Language.SPN => "Burmy",
						Language.KOR => "도롱충이",
						Language.CHN_SIM => "结草儿",
						Language.CHN_TRA => "結草兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BURMY_SANDY_CLOAK:
					return lang switch {
						Language.ENG => "Burmy",
						Language.JPN => "ミノムッチ",
						Language.GER => "Burmy",
						Language.FRE => "Cheniti",
						Language.ITA => "Burmy",
						Language.SPN => "Burmy",
						Language.KOR => "도롱충이",
						Language.CHN_SIM => "结草儿",
						Language.CHN_TRA => "結草兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BURMY_TRASH_CLOAK:
					return lang switch {
						Language.ENG => "Burmy",
						Language.JPN => "ミノムッチ",
						Language.GER => "Burmy",
						Language.FRE => "Cheniti",
						Language.ITA => "Burmy",
						Language.SPN => "Burmy",
						Language.KOR => "도롱충이",
						Language.CHN_SIM => "结草儿",
						Language.CHN_TRA => "結草兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WORMADAM_PLANT_CLOAK:
					return lang switch {
						Language.ENG => "Wormadam",
						Language.JPN => "ミノマダム",
						Language.GER => "Burmadame",
						Language.FRE => "Cheniselle",
						Language.ITA => "Wormadam",
						Language.SPN => "Wormadam",
						Language.KOR => "도롱마담",
						Language.CHN_SIM => "结草贵妇",
						Language.CHN_TRA => "結草貴婦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WORMADAM_SANDY_CLOAK:
					return lang switch {
						Language.ENG => "Wormadam",
						Language.JPN => "ミノマダム",
						Language.GER => "Burmadame",
						Language.FRE => "Cheniselle",
						Language.ITA => "Wormadam",
						Language.SPN => "Wormadam",
						Language.KOR => "도롱마담",
						Language.CHN_SIM => "结草贵妇",
						Language.CHN_TRA => "結草貴婦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WORMADAM_TRASH_CLOAK:
					return lang switch {
						Language.ENG => "Wormadam",
						Language.JPN => "ミノマダム",
						Language.GER => "Burmadame",
						Language.FRE => "Cheniselle",
						Language.ITA => "Wormadam",
						Language.SPN => "Wormadam",
						Language.KOR => "도롱마담",
						Language.CHN_SIM => "结草贵妇",
						Language.CHN_TRA => "結草貴婦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MOTHIM:
					return lang switch {
						Language.ENG => "Mothim",
						Language.JPN => "ガーメイル",
						Language.GER => "Moterpel",
						Language.FRE => "Papilord",
						Language.ITA => "Mothim",
						Language.SPN => "Mothim",
						Language.KOR => "나메일",
						Language.CHN_SIM => "绅士蛾",
						Language.CHN_TRA => "紳士蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COMBEE:
					return lang switch {
						Language.ENG => "Combee",
						Language.JPN => "ミツハニー",
						Language.GER => "Wadribie",
						Language.FRE => "Apitrini",
						Language.ITA => "Combee",
						Language.SPN => "Combee",
						Language.KOR => "세꿀버리",
						Language.CHN_SIM => "三蜜蜂",
						Language.CHN_TRA => "三蜜蜂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VESPIQUEN:
					return lang switch {
						Language.ENG => "Vespiquen",
						Language.JPN => "ビークイン",
						Language.GER => "Honweisel",
						Language.FRE => "Apireine",
						Language.ITA => "Vespiquen",
						Language.SPN => "Vespiquen",
						Language.KOR => "비퀸",
						Language.CHN_SIM => "蜂女王",
						Language.CHN_TRA => "蜂女王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PACHIRISU:
					return lang switch {
						Language.ENG => "Pachirisu",
						Language.JPN => "パチリス",
						Language.GER => "Pachirisu",
						Language.FRE => "Pachirisu",
						Language.ITA => "Pachirisu",
						Language.SPN => "Pachirisu",
						Language.KOR => "파치리스",
						Language.CHN_SIM => "帕奇利兹",
						Language.CHN_TRA => "帕奇利茲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BUIZEL:
					return lang switch {
						Language.ENG => "Buizel",
						Language.JPN => "ブイゼル",
						Language.GER => "Bamelin",
						Language.FRE => "Mustébouée",
						Language.ITA => "Buizel",
						Language.SPN => "Buizel",
						Language.KOR => "브이젤",
						Language.CHN_SIM => "泳圈鼬",
						Language.CHN_TRA => "泳圈鼬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLOATZEL:
					return lang switch {
						Language.ENG => "Floatzel",
						Language.JPN => "フローゼル",
						Language.GER => "Bojelin",
						Language.FRE => "Mustéflott",
						Language.ITA => "Floatzel",
						Language.SPN => "Floatzel",
						Language.KOR => "플로젤",
						Language.CHN_SIM => "浮潜鼬",
						Language.CHN_TRA => "浮潛鼬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHERUBI:
					return lang switch {
						Language.ENG => "Cherubi",
						Language.JPN => "チェリンボ",
						Language.GER => "Kikugi",
						Language.FRE => "Ceribou",
						Language.ITA => "Cherubi",
						Language.SPN => "Cherubi",
						Language.KOR => "체리버",
						Language.CHN_SIM => "樱花宝",
						Language.CHN_TRA => "櫻花寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHERRIM:
					return lang switch {
						Language.ENG => "Cherrim",
						Language.JPN => "チェリム",
						Language.GER => "Kinoso",
						Language.FRE => "Ceriflor",
						Language.ITA => "Cherrim",
						Language.SPN => "Cherrim",
						Language.KOR => "체리꼬",
						Language.CHN_SIM => "樱花儿",
						Language.CHN_TRA => "櫻花兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHELLOS:
					return lang switch {
						Language.ENG => "Shellos",
						Language.JPN => "カラナクシ",
						Language.GER => "Schalellos",
						Language.FRE => "Sancoki",
						Language.ITA => "Shellos",
						Language.SPN => "Shellos",
						Language.KOR => "깝질무",
						Language.CHN_SIM => "无壳海兔",
						Language.CHN_TRA => "無殼海兔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GASTRODON:
					return lang switch {
						Language.ENG => "Gastrodon",
						Language.JPN => "トリトドン",
						Language.GER => "Gastrodon",
						Language.FRE => "Tritosor",
						Language.ITA => "Gastrodon",
						Language.SPN => "Gastrodon",
						Language.KOR => "트리토돈",
						Language.CHN_SIM => "海兔兽",
						Language.CHN_TRA => "海兔獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AMBIPOM:
					return lang switch {
						Language.ENG => "Ambipom",
						Language.JPN => "エテボース",
						Language.GER => "Ambidiffel",
						Language.FRE => "Capidextre",
						Language.ITA => "Ambipom",
						Language.SPN => "Ambipom",
						Language.KOR => "겟핸보숭",
						Language.CHN_SIM => "双尾怪手",
						Language.CHN_TRA => "雙尾怪手",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRIFLOON:
					return lang switch {
						Language.ENG => "Drifloon",
						Language.JPN => "フワンテ",
						Language.GER => "Driftlon",
						Language.FRE => "Baudrive",
						Language.ITA => "Drifloon",
						Language.SPN => "Drifloon",
						Language.KOR => "흔들풍손",
						Language.CHN_SIM => "飘飘球",
						Language.CHN_TRA => "飄飄球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRIFBLIM:
					return lang switch {
						Language.ENG => "Drifblim",
						Language.JPN => "フワライド",
						Language.GER => "Drifzepeli",
						Language.FRE => "Grodrive",
						Language.ITA => "Drifblim",
						Language.SPN => "Drifblim",
						Language.KOR => "둥실라이드",
						Language.CHN_SIM => "随风球",
						Language.CHN_TRA => "隨風球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BUNEARY:
					return lang switch {
						Language.ENG => "Buneary",
						Language.JPN => "ミミロル",
						Language.GER => "Haspiror",
						Language.FRE => "Laporeille",
						Language.ITA => "Buneary",
						Language.SPN => "Buneary",
						Language.KOR => "이어롤",
						Language.CHN_SIM => "卷卷耳",
						Language.CHN_TRA => "捲捲耳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LOPUNNY:
					return lang switch {
						Language.ENG => "Lopunny",
						Language.JPN => "ミミロップ",
						Language.GER => "Schlapor",
						Language.FRE => "Lockpin",
						Language.ITA => "Lopunny",
						Language.SPN => "Lopunny",
						Language.KOR => "이어롭",
						Language.CHN_SIM => "长耳兔",
						Language.CHN_TRA => "長耳兔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LOPUNNY_MEGA_LOPUNNY:
					return lang switch {
						Language.ENG => "Lopunny",
						Language.JPN => "ミミロップ",
						Language.GER => "Schlapor",
						Language.FRE => "Lockpin",
						Language.ITA => "Lopunny",
						Language.SPN => "Lopunny",
						Language.KOR => "이어롭",
						Language.CHN_SIM => "长耳兔",
						Language.CHN_TRA => "長耳兔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MISMAGIUS:
					return lang switch {
						Language.ENG => "Mismagius",
						Language.JPN => "ムウマージ",
						Language.GER => "Traunmagil",
						Language.FRE => "Magirêve",
						Language.ITA => "Mismagius",
						Language.SPN => "Mismagius",
						Language.KOR => "무우마직",
						Language.CHN_SIM => "梦妖魔",
						Language.CHN_TRA => "夢妖魔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HONCHKROW:
					return lang switch {
						Language.ENG => "Honchkrow",
						Language.JPN => "ドンカラス",
						Language.GER => "Kramshef",
						Language.FRE => "Corboss",
						Language.ITA => "Honchkrow",
						Language.SPN => "Honchkrow",
						Language.KOR => "돈크로우",
						Language.CHN_SIM => "乌鸦头头",
						Language.CHN_TRA => "烏鴉頭頭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLAMEOW:
					return lang switch {
						Language.ENG => "Glameow",
						Language.JPN => "ニャルマー",
						Language.GER => "Charmian",
						Language.FRE => "Chaglam",
						Language.ITA => "Glameow",
						Language.SPN => "Glameow",
						Language.KOR => "나옹마",
						Language.CHN_SIM => "魅力喵",
						Language.CHN_TRA => "魅力喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PURUGLY:
					return lang switch {
						Language.ENG => "Purugly",
						Language.JPN => "ブニャット",
						Language.GER => "Shnurgarst",
						Language.FRE => "Chaffreux",
						Language.ITA => "Purugly",
						Language.SPN => "Purugly",
						Language.KOR => "몬냥이",
						Language.CHN_SIM => "东施喵",
						Language.CHN_TRA => "東施喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHINGLING:
					return lang switch {
						Language.ENG => "Chingling",
						Language.JPN => "リーシャン",
						Language.GER => "Klingplim",
						Language.FRE => "Korillon",
						Language.ITA => "Chingling",
						Language.SPN => "Chingling",
						Language.KOR => "랑딸랑",
						Language.CHN_SIM => "铃铛响",
						Language.CHN_TRA => "鈴鐺響",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STUNKY:
					return lang switch {
						Language.ENG => "Stunky",
						Language.JPN => "スカンプー",
						Language.GER => "Skunkapuh",
						Language.FRE => "Moufouette",
						Language.ITA => "Stunky",
						Language.SPN => "Stunky",
						Language.KOR => "스컹뿡",
						Language.CHN_SIM => "臭鼬噗",
						Language.CHN_TRA => "臭鼬噗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKUNTANK:
					return lang switch {
						Language.ENG => "Skuntank",
						Language.JPN => "スカタンク",
						Language.GER => "Skuntank",
						Language.FRE => "Moufflair",
						Language.ITA => "Skuntank",
						Language.SPN => "Skuntank",
						Language.KOR => "스컹탱크",
						Language.CHN_SIM => "坦克臭鼬",
						Language.CHN_TRA => "坦克臭鼬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRONZOR:
					return lang switch {
						Language.ENG => "Bronzor",
						Language.JPN => "ドーミラー",
						Language.GER => "Bronzel",
						Language.FRE => "Archéomire",
						Language.ITA => "Bronzor",
						Language.SPN => "Bronzor",
						Language.KOR => "동미러",
						Language.CHN_SIM => "铜镜怪",
						Language.CHN_TRA => "銅鏡怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRONZONG:
					return lang switch {
						Language.ENG => "Bronzong",
						Language.JPN => "ドータクン",
						Language.GER => "Bronzong",
						Language.FRE => "Archéodong",
						Language.ITA => "Bronzong",
						Language.SPN => "Bronzong",
						Language.KOR => "동탁군",
						Language.CHN_SIM => "青铜钟",
						Language.CHN_TRA => "青銅鐘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BONSLY:
					return lang switch {
						Language.ENG => "Bonsly",
						Language.JPN => "ウソハチ",
						Language.GER => "Mobai",
						Language.FRE => "Manzaï",
						Language.ITA => "Bonsly",
						Language.SPN => "Bonsly",
						Language.KOR => "꼬지지",
						Language.CHN_SIM => "盆才怪",
						Language.CHN_TRA => "盆才怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MIME_JR:
					return lang switch {
						Language.ENG => "Mime Jr.",
						Language.JPN => "マネネ",
						Language.GER => "Pantimimi",
						Language.FRE => "Mime Jr.",
						Language.ITA => "Mime Jr.",
						Language.SPN => "Mime Jr.",
						Language.KOR => "흉내내",
						Language.CHN_SIM => "魔尼尼",
						Language.CHN_TRA => "魔尼尼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HAPPINY:
					return lang switch {
						Language.ENG => "Happiny",
						Language.JPN => "ピンプク",
						Language.GER => "Wonneira",
						Language.FRE => "Ptiravi",
						Language.ITA => "Happiny",
						Language.SPN => "Happiny",
						Language.KOR => "핑복",
						Language.CHN_SIM => "小福蛋",
						Language.CHN_TRA => "小福蛋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHATOT:
					return lang switch {
						Language.ENG => "Chatot",
						Language.JPN => "ペラップ",
						Language.GER => "Plaudagei",
						Language.FRE => "Pijako",
						Language.ITA => "Chatot",
						Language.SPN => "Chatot",
						Language.KOR => "페라페",
						Language.CHN_SIM => "聒噪鸟",
						Language.CHN_TRA => "聒噪鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPIRITOMB:
					return lang switch {
						Language.ENG => "Spiritomb",
						Language.JPN => "ミカルゲ",
						Language.GER => "Kryppuk",
						Language.FRE => "Spiritomb",
						Language.ITA => "Spiritomb",
						Language.SPN => "Spiritomb",
						Language.KOR => "화강돌",
						Language.CHN_SIM => "花岩怪",
						Language.CHN_TRA => "花岩怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIBLE:
					return lang switch {
						Language.ENG => "Gible",
						Language.JPN => "フカマル",
						Language.GER => "Kaumalat",
						Language.FRE => "Griknot",
						Language.ITA => "Gible",
						Language.SPN => "Gible",
						Language.KOR => "딥상어동",
						Language.CHN_SIM => "圆陆鲨",
						Language.CHN_TRA => "圓陸鯊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GABITE:
					return lang switch {
						Language.ENG => "Gabite",
						Language.JPN => "ガバイト",
						Language.GER => "Knarksel",
						Language.FRE => "Carmache",
						Language.ITA => "Gabite",
						Language.SPN => "Gabite",
						Language.KOR => "한바이트",
						Language.CHN_SIM => "尖牙陆鲨",
						Language.CHN_TRA => "尖牙陸鯊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GARCHOMP:
					return lang switch {
						Language.ENG => "Garchomp",
						Language.JPN => "ガブリアス",
						Language.GER => "Knakrack",
						Language.FRE => "Carchacrok",
						Language.ITA => "Garchomp",
						Language.SPN => "Garchomp",
						Language.KOR => "한카리아스",
						Language.CHN_SIM => "烈咬陆鲨",
						Language.CHN_TRA => "烈咬陸鯊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GARCHOMP_MEGA_GARCHOMP:
					return lang switch {
						Language.ENG => "Garchomp",
						Language.JPN => "ガブリアス",
						Language.GER => "Knakrack",
						Language.FRE => "Carchacrok",
						Language.ITA => "Garchomp",
						Language.SPN => "Garchomp",
						Language.KOR => "한카리아스",
						Language.CHN_SIM => "烈咬陆鲨",
						Language.CHN_TRA => "烈咬陸鯊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUNCHLAX:
					return lang switch {
						Language.ENG => "Munchlax",
						Language.JPN => "ゴンベ",
						Language.GER => "Mampfaxo",
						Language.FRE => "Goinfrex",
						Language.ITA => "Munchlax",
						Language.SPN => "Munchlax",
						Language.KOR => "먹고자",
						Language.CHN_SIM => "小卡比兽",
						Language.CHN_TRA => "小卡比獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RIOLU:
					return lang switch {
						Language.ENG => "Riolu",
						Language.JPN => "リオル",
						Language.GER => "Riolu",
						Language.FRE => "Riolu",
						Language.ITA => "Riolu",
						Language.SPN => "Riolu",
						Language.KOR => "리오르",
						Language.CHN_SIM => "利欧路",
						Language.CHN_TRA => "利歐路",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUCARIO:
					return lang switch {
						Language.ENG => "Lucario",
						Language.JPN => "ルカリオ",
						Language.GER => "Lucario",
						Language.FRE => "Lucario",
						Language.ITA => "Lucario",
						Language.SPN => "Lucario",
						Language.KOR => "루카리오",
						Language.CHN_SIM => "路卡利欧",
						Language.CHN_TRA => "路卡利歐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUCARIO_MEGA_LUCARIO:
					return lang switch {
						Language.ENG => "Lucario",
						Language.JPN => "ルカリオ",
						Language.GER => "Lucario",
						Language.FRE => "Lucario",
						Language.ITA => "Lucario",
						Language.SPN => "Lucario",
						Language.KOR => "루카리오",
						Language.CHN_SIM => "路卡利欧",
						Language.CHN_TRA => "路卡利歐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HIPPOPOTAS:
					return lang switch {
						Language.ENG => "Hippopotas",
						Language.JPN => "ヒポポタス",
						Language.GER => "Hippopotas",
						Language.FRE => "Hippopotas",
						Language.ITA => "Hippopotas",
						Language.SPN => "Hippopotas",
						Language.KOR => "히포포타스",
						Language.CHN_SIM => "沙河马",
						Language.CHN_TRA => "沙河馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HIPPOWDON:
					return lang switch {
						Language.ENG => "Hippowdon",
						Language.JPN => "カバルドン",
						Language.GER => "Hippoterus",
						Language.FRE => "Hippodocus",
						Language.ITA => "Hippowdon",
						Language.SPN => "Hippowdon",
						Language.KOR => "하마돈",
						Language.CHN_SIM => "河马兽",
						Language.CHN_TRA => "河馬獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKORUPI:
					return lang switch {
						Language.ENG => "Skorupi",
						Language.JPN => "スコルピ",
						Language.GER => "Pionskora",
						Language.FRE => "Rapion",
						Language.ITA => "Skorupi",
						Language.SPN => "Skorupi",
						Language.KOR => "스콜피",
						Language.CHN_SIM => "钳尾蝎",
						Language.CHN_TRA => "鉗尾蠍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAPION:
					return lang switch {
						Language.ENG => "Drapion",
						Language.JPN => "ドラピオン",
						Language.GER => "Piondragi",
						Language.FRE => "Drascore",
						Language.ITA => "Drapion",
						Language.SPN => "Drapion",
						Language.KOR => "드래피온",
						Language.CHN_SIM => "龙王蝎",
						Language.CHN_TRA => "龍王蠍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CROAGUNK:
					return lang switch {
						Language.ENG => "Croagunk",
						Language.JPN => "グレッグル",
						Language.GER => "Glibunkel",
						Language.FRE => "Cradopaud",
						Language.ITA => "Croagunk",
						Language.SPN => "Croagunk",
						Language.KOR => "삐딱구리",
						Language.CHN_SIM => "不良蛙",
						Language.CHN_TRA => "不良蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOXICROAK:
					return lang switch {
						Language.ENG => "Toxicroak",
						Language.JPN => "ドクロッグ",
						Language.GER => "Toxiquak",
						Language.FRE => "Coatox",
						Language.ITA => "Toxicroak",
						Language.SPN => "Toxicroak",
						Language.KOR => "독개굴",
						Language.CHN_SIM => "毒骷蛙",
						Language.CHN_TRA => "毒骷蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CARNIVINE:
					return lang switch {
						Language.ENG => "Carnivine",
						Language.JPN => "マスキッパ",
						Language.GER => "Venuflibis",
						Language.FRE => "Vortente",
						Language.ITA => "Carnivine",
						Language.SPN => "Carnivine",
						Language.KOR => "무스틈니",
						Language.CHN_SIM => "尖牙笼",
						Language.CHN_TRA => "尖牙籠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FINNEON:
					return lang switch {
						Language.ENG => "Finneon",
						Language.JPN => "ケイコウオ",
						Language.GER => "Finneon",
						Language.FRE => "Écayon",
						Language.ITA => "Finneon",
						Language.SPN => "Finneon",
						Language.KOR => "형광어",
						Language.CHN_SIM => "荧光鱼",
						Language.CHN_TRA => "螢光魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUMINEON:
					return lang switch {
						Language.ENG => "Lumineon",
						Language.JPN => "ネオラント",
						Language.GER => "Lumineon",
						Language.FRE => "Luminéon",
						Language.ITA => "Lumineon",
						Language.SPN => "Lumineon",
						Language.KOR => "네오라이트",
						Language.CHN_SIM => "霓虹鱼",
						Language.CHN_TRA => "霓虹魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANTYKE:
					return lang switch {
						Language.ENG => "Mantyke",
						Language.JPN => "タマンタ",
						Language.GER => "Mantirps",
						Language.FRE => "Babimanta",
						Language.ITA => "Mantyke",
						Language.SPN => "Mantyke",
						Language.KOR => "타만타",
						Language.CHN_SIM => "小球飞鱼",
						Language.CHN_TRA => "小球飛魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNOVER:
					return lang switch {
						Language.ENG => "Snover",
						Language.JPN => "ユキカブリ",
						Language.GER => "Shnebedeck",
						Language.FRE => "Blizzi",
						Language.ITA => "Snover",
						Language.SPN => "Snover",
						Language.KOR => "눈쓰개",
						Language.CHN_SIM => "雪笠怪",
						Language.CHN_TRA => "雪笠怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ABOMASNOW:
					return lang switch {
						Language.ENG => "Abomasnow",
						Language.JPN => "ユキノオー",
						Language.GER => "Rexblisar",
						Language.FRE => "Blizzaroi",
						Language.ITA => "Abomasnow",
						Language.SPN => "Abomasnow",
						Language.KOR => "눈설왕",
						Language.CHN_SIM => "暴雪王",
						Language.CHN_TRA => "暴雪王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ABOMASNOW_MEGA_ABOMASNOW:
					return lang switch {
						Language.ENG => "Abomasnow",
						Language.JPN => "ユキノオー",
						Language.GER => "Rexblisar",
						Language.FRE => "Blizzaroi",
						Language.ITA => "Abomasnow",
						Language.SPN => "Abomasnow",
						Language.KOR => "눈설왕",
						Language.CHN_SIM => "暴雪王",
						Language.CHN_TRA => "暴雪王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WEAVILE:
					return lang switch {
						Language.ENG => "Weavile",
						Language.JPN => "マニューラ",
						Language.GER => "Snibunna",
						Language.FRE => "Dimoret",
						Language.ITA => "Weavile",
						Language.SPN => "Weavile",
						Language.KOR => "포푸니라",
						Language.CHN_SIM => "玛狃拉",
						Language.CHN_TRA => "瑪狃拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGNEZONE:
					return lang switch {
						Language.ENG => "Magnezone",
						Language.JPN => "ジバコイル",
						Language.GER => "Magnezone",
						Language.FRE => "Magnézone",
						Language.ITA => "Magnezone",
						Language.SPN => "Magnezone",
						Language.KOR => "자포코일",
						Language.CHN_SIM => "自爆磁怪",
						Language.CHN_TRA => "自爆磁怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LICKILICKY:
					return lang switch {
						Language.ENG => "Lickilicky",
						Language.JPN => "ベロベルト",
						Language.GER => "Schlurplek",
						Language.FRE => "Coudlangue",
						Language.ITA => "Lickilicky",
						Language.SPN => "Lickilicky",
						Language.KOR => "내룸벨트",
						Language.CHN_SIM => "大舌舔",
						Language.CHN_TRA => "大舌舔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RHYPERIOR:
					return lang switch {
						Language.ENG => "Rhyperior",
						Language.JPN => "ドサイドン",
						Language.GER => "Rihornior",
						Language.FRE => "Rhinastoc",
						Language.ITA => "Rhyperior",
						Language.SPN => "Rhyperior",
						Language.KOR => "거대코뿌리",
						Language.CHN_SIM => "超甲狂犀",
						Language.CHN_TRA => "超甲狂犀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TANGROWTH:
					return lang switch {
						Language.ENG => "Tangrowth",
						Language.JPN => "モジャンボ",
						Language.GER => "Tangoloss",
						Language.FRE => "Bouldeneu",
						Language.ITA => "Tangrowth",
						Language.SPN => "Tangrowth",
						Language.KOR => "덩쿠림보",
						Language.CHN_SIM => "巨蔓藤",
						Language.CHN_TRA => "巨蔓藤",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELECTIVIRE:
					return lang switch {
						Language.ENG => "Electivire",
						Language.JPN => "エレキブル",
						Language.GER => "Elevoltek",
						Language.FRE => "Élekable",
						Language.ITA => "Electivire",
						Language.SPN => "Electivire",
						Language.KOR => "에레키블",
						Language.CHN_SIM => "电击魔兽",
						Language.CHN_TRA => "電擊魔獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGMORTAR:
					return lang switch {
						Language.ENG => "Magmortar",
						Language.JPN => "ブーバーン",
						Language.GER => "Magbrant",
						Language.FRE => "Maganon",
						Language.ITA => "Magmortar",
						Language.SPN => "Magmortar",
						Language.KOR => "마그마번",
						Language.CHN_SIM => "鸭嘴炎兽",
						Language.CHN_TRA => "鴨嘴炎獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOGEKISS:
					return lang switch {
						Language.ENG => "Togekiss",
						Language.JPN => "トゲキッス",
						Language.GER => "Togekiss",
						Language.FRE => "Togekiss",
						Language.ITA => "Togekiss",
						Language.SPN => "Togekiss",
						Language.KOR => "토게키스",
						Language.CHN_SIM => "波克基斯",
						Language.CHN_TRA => "波克基斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YANMEGA:
					return lang switch {
						Language.ENG => "Yanmega",
						Language.JPN => "メガヤンマ",
						Language.GER => "Yanmega",
						Language.FRE => "Yanmega",
						Language.ITA => "Yanmega",
						Language.SPN => "Yanmega",
						Language.KOR => "메가자리",
						Language.CHN_SIM => "远古巨蜓",
						Language.CHN_TRA => "遠古巨蜓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LEAFEON:
					return lang switch {
						Language.ENG => "Leafeon",
						Language.JPN => "リーフィア",
						Language.GER => "Folipurba",
						Language.FRE => "Phyllali",
						Language.ITA => "Leafeon",
						Language.SPN => "Leafeon",
						Language.KOR => "리피아",
						Language.CHN_SIM => "叶伊布",
						Language.CHN_TRA => "葉伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLACEON:
					return lang switch {
						Language.ENG => "Glaceon",
						Language.JPN => "グレイシア",
						Language.GER => "Glaziola",
						Language.FRE => "Givrali",
						Language.ITA => "Glaceon",
						Language.SPN => "Glaceon",
						Language.KOR => "글레이시아",
						Language.CHN_SIM => "冰伊布",
						Language.CHN_TRA => "冰伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLISCOR:
					return lang switch {
						Language.ENG => "Gliscor",
						Language.JPN => "グライオン",
						Language.GER => "Skorgro",
						Language.FRE => "Scorvol",
						Language.ITA => "Gliscor",
						Language.SPN => "Gliscor",
						Language.KOR => "글라이온",
						Language.CHN_SIM => "天蝎王",
						Language.CHN_TRA => "天蠍王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAMOSWINE:
					return lang switch {
						Language.ENG => "Mamoswine",
						Language.JPN => "マンムー",
						Language.GER => "Mamutel",
						Language.FRE => "Mammochon",
						Language.ITA => "Mamoswine",
						Language.SPN => "Mamoswine",
						Language.KOR => "맘모꾸리",
						Language.CHN_SIM => "象牙猪",
						Language.CHN_TRA => "象牙豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PORYGON_Z:
					return lang switch {
						Language.ENG => "Porygon-Z",
						Language.JPN => "ポリゴンＺ",
						Language.GER => "Porygon-Z",
						Language.FRE => "Porygon-Z",
						Language.ITA => "Porygon-Z",
						Language.SPN => "Porygon-Z",
						Language.KOR => "폴리곤Z",
						Language.CHN_SIM => "多边兽乙型",
						Language.CHN_TRA => "多邊獸Ｚ",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GALLADE:
					return lang switch {
						Language.ENG => "Gallade",
						Language.JPN => "エルレイド",
						Language.GER => "Galagladi",
						Language.FRE => "Gallame",
						Language.ITA => "Gallade",
						Language.SPN => "Gallade",
						Language.KOR => "엘레이드",
						Language.CHN_SIM => "艾路雷朵",
						Language.CHN_TRA => "艾路雷朵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GALLADE_MEGA_GALLADE:
					return lang switch {
						Language.ENG => "Gallade",
						Language.JPN => "エルレイド",
						Language.GER => "Galagladi",
						Language.FRE => "Gallame",
						Language.ITA => "Gallade",
						Language.SPN => "Gallade",
						Language.KOR => "엘레이드",
						Language.CHN_SIM => "艾路雷朵",
						Language.CHN_TRA => "艾路雷朵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PROBOPASS:
					return lang switch {
						Language.ENG => "Probopass",
						Language.JPN => "ダイノーズ",
						Language.GER => "Voluminas",
						Language.FRE => "Tarinorme",
						Language.ITA => "Probopass",
						Language.SPN => "Probopass",
						Language.KOR => "대코파스",
						Language.CHN_SIM => "大朝北鼻",
						Language.CHN_TRA => "大朝北鼻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUSKNOIR:
					return lang switch {
						Language.ENG => "Dusknoir",
						Language.JPN => "ヨノワール",
						Language.GER => "Zwirrfinst",
						Language.FRE => "Noctunoir",
						Language.ITA => "Dusknoir",
						Language.SPN => "Dusknoir",
						Language.KOR => "야느와르몽",
						Language.CHN_SIM => "黑夜魔灵",
						Language.CHN_TRA => "黑夜魔靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FROSLASS:
					return lang switch {
						Language.ENG => "Froslass",
						Language.JPN => "ユキメノコ",
						Language.GER => "Frosdedje",
						Language.FRE => "Momartik",
						Language.ITA => "Froslass",
						Language.SPN => "Froslass",
						Language.KOR => "눈여아",
						Language.CHN_SIM => "雪妖女",
						Language.CHN_TRA => "雪妖女",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROTOM:
					return lang switch {
						Language.ENG => "Rotom",
						Language.JPN => "ロトム",
						Language.GER => "Rotom",
						Language.FRE => "Motisma",
						Language.ITA => "Rotom",
						Language.SPN => "Rotom",
						Language.KOR => "로토무",
						Language.CHN_SIM => "洛托姆",
						Language.CHN_TRA => "洛托姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROTOM_HEAT_ROTOM:
					return lang switch {
						Language.ENG => "Rotom",
						Language.JPN => "ロトム",
						Language.GER => "Rotom",
						Language.FRE => "Motisma",
						Language.ITA => "Rotom",
						Language.SPN => "Rotom",
						Language.KOR => "로토무",
						Language.CHN_SIM => "洛托姆",
						Language.CHN_TRA => "洛托姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROTOM_WASH_ROTOM:
					return lang switch {
						Language.ENG => "Rotom",
						Language.JPN => "ロトム",
						Language.GER => "Rotom",
						Language.FRE => "Motisma",
						Language.ITA => "Rotom",
						Language.SPN => "Rotom",
						Language.KOR => "로토무",
						Language.CHN_SIM => "洛托姆",
						Language.CHN_TRA => "洛托姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROTOM_FROST_ROTOM:
					return lang switch {
						Language.ENG => "Rotom",
						Language.JPN => "ロトム",
						Language.GER => "Rotom",
						Language.FRE => "Motisma",
						Language.ITA => "Rotom",
						Language.SPN => "Rotom",
						Language.KOR => "로토무",
						Language.CHN_SIM => "洛托姆",
						Language.CHN_TRA => "洛托姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROTOM_FAN_ROTOM:
					return lang switch {
						Language.ENG => "Rotom",
						Language.JPN => "ロトム",
						Language.GER => "Rotom",
						Language.FRE => "Motisma",
						Language.ITA => "Rotom",
						Language.SPN => "Rotom",
						Language.KOR => "로토무",
						Language.CHN_SIM => "洛托姆",
						Language.CHN_TRA => "洛托姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROTOM_MOW_ROTOM:
					return lang switch {
						Language.ENG => "Rotom",
						Language.JPN => "ロトム",
						Language.GER => "Rotom",
						Language.FRE => "Motisma",
						Language.ITA => "Rotom",
						Language.SPN => "Rotom",
						Language.KOR => "로토무",
						Language.CHN_SIM => "洛托姆",
						Language.CHN_TRA => "洛托姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.UXIE:
					return lang switch {
						Language.ENG => "Uxie",
						Language.JPN => "ユクシー",
						Language.GER => "Selfe",
						Language.FRE => "Créhelf",
						Language.ITA => "Uxie",
						Language.SPN => "Uxie",
						Language.KOR => "유크시",
						Language.CHN_SIM => "由克希",
						Language.CHN_TRA => "由克希",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MESPRIT:
					return lang switch {
						Language.ENG => "Mesprit",
						Language.JPN => "エムリット",
						Language.GER => "Vesprit",
						Language.FRE => "Créfollet",
						Language.ITA => "Mesprit",
						Language.SPN => "Mesprit",
						Language.KOR => "엠라이트",
						Language.CHN_SIM => "艾姆利多",
						Language.CHN_TRA => "艾姆利多",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AZELF:
					return lang switch {
						Language.ENG => "Azelf",
						Language.JPN => "アグノム",
						Language.GER => "Tobutz",
						Language.FRE => "Créfadet",
						Language.ITA => "Azelf",
						Language.SPN => "Azelf",
						Language.KOR => "아그놈",
						Language.CHN_SIM => "亚克诺姆",
						Language.CHN_TRA => "亞克諾姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIALGA:
					return lang switch {
						Language.ENG => "Dialga",
						Language.JPN => "ディアルガ",
						Language.GER => "Dialga",
						Language.FRE => "Dialga",
						Language.ITA => "Dialga",
						Language.SPN => "Dialga",
						Language.KOR => "디아루가",
						Language.CHN_SIM => "帝牙卢卡",
						Language.CHN_TRA => "帝牙盧卡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIALGA_ORIGIN_FORME:
					return lang switch {
						Language.ENG => "Dialga",
						Language.JPN => "ディアルガ",
						Language.GER => "Dialga",
						Language.FRE => "Dialga",
						Language.ITA => "Dialga",
						Language.SPN => "Dialga",
						Language.KOR => "디아루가",
						Language.CHN_SIM => "帝牙卢卡",
						Language.CHN_TRA => "帝牙盧卡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PALKIA:
					return lang switch {
						Language.ENG => "Palkia",
						Language.JPN => "パルキア",
						Language.GER => "Palkia",
						Language.FRE => "Palkia",
						Language.ITA => "Palkia",
						Language.SPN => "Palkia",
						Language.KOR => "펄기아",
						Language.CHN_SIM => "帕路奇亚",
						Language.CHN_TRA => "帕路奇亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PALKIA_ORIGIN_FORME:
					return lang switch {
						Language.ENG => "Palkia",
						Language.JPN => "パルキア",
						Language.GER => "Palkia",
						Language.FRE => "Palkia",
						Language.ITA => "Palkia",
						Language.SPN => "Palkia",
						Language.KOR => "펄기아",
						Language.CHN_SIM => "帕路奇亚",
						Language.CHN_TRA => "帕路奇亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HEATRAN:
					return lang switch {
						Language.ENG => "Heatran",
						Language.JPN => "ヒードラン",
						Language.GER => "Heatran",
						Language.FRE => "Heatran",
						Language.ITA => "Heatran",
						Language.SPN => "Heatran",
						Language.KOR => "히드런",
						Language.CHN_SIM => "席多蓝恩",
						Language.CHN_TRA => "席多藍恩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REGIGIGAS:
					return lang switch {
						Language.ENG => "Regigigas",
						Language.JPN => "レジギガス",
						Language.GER => "Regigigas",
						Language.FRE => "Regigigas",
						Language.ITA => "Regigigas",
						Language.SPN => "Regigigas",
						Language.KOR => "레지기가스",
						Language.CHN_SIM => "雷吉奇卡斯",
						Language.CHN_TRA => "雷吉奇卡斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIRATINA_ALTERED_FORME:
					return lang switch {
						Language.ENG => "Giratina",
						Language.JPN => "ギラティナ",
						Language.GER => "Giratina",
						Language.FRE => "Giratina",
						Language.ITA => "Giratina",
						Language.SPN => "Giratina",
						Language.KOR => "기라티나",
						Language.CHN_SIM => "骑拉帝纳",
						Language.CHN_TRA => "騎拉帝納",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIRATINA_ORIGIN_FORME:
					return lang switch {
						Language.ENG => "Giratina",
						Language.JPN => "ギラティナ",
						Language.GER => "Giratina",
						Language.FRE => "Giratina",
						Language.ITA => "Giratina",
						Language.SPN => "Giratina",
						Language.KOR => "기라티나",
						Language.CHN_SIM => "骑拉帝纳",
						Language.CHN_TRA => "騎拉帝納",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRESSELIA:
					return lang switch {
						Language.ENG => "Cresselia",
						Language.JPN => "クレセリア",
						Language.GER => "Cresselia",
						Language.FRE => "Cresselia",
						Language.ITA => "Cresselia",
						Language.SPN => "Cresselia",
						Language.KOR => "크레세리아",
						Language.CHN_SIM => "克雷色利亚",
						Language.CHN_TRA => "克雷色利亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PHIONE:
					return lang switch {
						Language.ENG => "Phione",
						Language.JPN => "フィオネ",
						Language.GER => "Phione",
						Language.FRE => "Phione",
						Language.ITA => "Phione",
						Language.SPN => "Phione",
						Language.KOR => "피오네",
						Language.CHN_SIM => "霏欧纳",
						Language.CHN_TRA => "霏歐納",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANAPHY:
					return lang switch {
						Language.ENG => "Manaphy",
						Language.JPN => "マナフィ",
						Language.GER => "Manaphy",
						Language.FRE => "Manaphy",
						Language.ITA => "Manaphy",
						Language.SPN => "Manaphy",
						Language.KOR => "마나피",
						Language.CHN_SIM => "玛纳霏",
						Language.CHN_TRA => "瑪納霏",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARKRAI:
					return lang switch {
						Language.ENG => "Darkrai",
						Language.JPN => "ダークライ",
						Language.GER => "Darkrai",
						Language.FRE => "Darkrai",
						Language.ITA => "Darkrai",
						Language.SPN => "Darkrai",
						Language.KOR => "다크라이",
						Language.CHN_SIM => "达克莱伊",
						Language.CHN_TRA => "達克萊伊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHAYMIN_LAND_FORME:
					return lang switch {
						Language.ENG => "Shaymin",
						Language.JPN => "シェイミ",
						Language.GER => "Shaymin",
						Language.FRE => "Shaymin",
						Language.ITA => "Shaymin",
						Language.SPN => "Shaymin",
						Language.KOR => "쉐이미",
						Language.CHN_SIM => "谢米",
						Language.CHN_TRA => "謝米",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHAYMIN_SKY_FORME:
					return lang switch {
						Language.ENG => "Shaymin",
						Language.JPN => "シェイミ",
						Language.GER => "Shaymin",
						Language.FRE => "Shaymin",
						Language.ITA => "Shaymin",
						Language.SPN => "Shaymin",
						Language.KOR => "쉐이미",
						Language.CHN_SIM => "谢米",
						Language.CHN_TRA => "謝米",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCEUS:
					return lang switch {
						Language.ENG => "Arceus",
						Language.JPN => "アルセウス",
						Language.GER => "Arceus",
						Language.FRE => "Arceus",
						Language.ITA => "Arceus",
						Language.SPN => "Arceus",
						Language.KOR => "아르세우스",
						Language.CHN_SIM => "阿尔宙斯",
						Language.CHN_TRA => "阿爾宙斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VICTINI:
					return lang switch {
						Language.ENG => "Victini",
						Language.JPN => "ビクティニ",
						Language.GER => "Victini",
						Language.FRE => "Victini",
						Language.ITA => "Victini",
						Language.SPN => "Victini",
						Language.KOR => "비크티니",
						Language.CHN_SIM => "比克提尼",
						Language.CHN_TRA => "比克提尼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNIVY:
					return lang switch {
						Language.ENG => "Snivy",
						Language.JPN => "ツタージャ",
						Language.GER => "Serpifeu",
						Language.FRE => "Vipélierre",
						Language.ITA => "Snivy",
						Language.SPN => "Snivy",
						Language.KOR => "주리비얀",
						Language.CHN_SIM => "藤藤蛇",
						Language.CHN_TRA => "藤藤蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SERVINE:
					return lang switch {
						Language.ENG => "Servine",
						Language.JPN => "ジャノビー",
						Language.GER => "Efoserp",
						Language.FRE => "Lianaja",
						Language.ITA => "Servine",
						Language.SPN => "Servine",
						Language.KOR => "샤비",
						Language.CHN_SIM => "青藤蛇",
						Language.CHN_TRA => "青藤蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SERPERIOR:
					return lang switch {
						Language.ENG => "Serperior",
						Language.JPN => "ジャローダ",
						Language.GER => "Serpiroyal",
						Language.FRE => "Majaspic",
						Language.ITA => "Serperior",
						Language.SPN => "Serperior",
						Language.KOR => "샤로다",
						Language.CHN_SIM => "君主蛇",
						Language.CHN_TRA => "君主蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TEPIG:
					return lang switch {
						Language.ENG => "Tepig",
						Language.JPN => "ポカブ",
						Language.GER => "Floink",
						Language.FRE => "Gruikui",
						Language.ITA => "Tepig",
						Language.SPN => "Tepig",
						Language.KOR => "뚜꾸리",
						Language.CHN_SIM => "暖暖猪",
						Language.CHN_TRA => "暖暖豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIGNITE:
					return lang switch {
						Language.ENG => "Pignite",
						Language.JPN => "チャオブー",
						Language.GER => "Ferkokel",
						Language.FRE => "Grotichon",
						Language.ITA => "Pignite",
						Language.SPN => "Pignite",
						Language.KOR => "차오꿀",
						Language.CHN_SIM => "炒炒猪",
						Language.CHN_TRA => "炒炒豬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EMBOAR:
					return lang switch {
						Language.ENG => "Emboar",
						Language.JPN => "エンブオー",
						Language.GER => "Flambirex",
						Language.FRE => "Roitiflam",
						Language.ITA => "Emboar",
						Language.SPN => "Emboar",
						Language.KOR => "염무왕",
						Language.CHN_SIM => "炎武王",
						Language.CHN_TRA => "炎武王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OSHAWOTT:
					return lang switch {
						Language.ENG => "Oshawott",
						Language.JPN => "ミジュマル",
						Language.GER => "Ottaro",
						Language.FRE => "Moustillon",
						Language.ITA => "Oshawott",
						Language.SPN => "Oshawott",
						Language.KOR => "수댕이",
						Language.CHN_SIM => "水水獭",
						Language.CHN_TRA => "水水獺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEWOTT:
					return lang switch {
						Language.ENG => "Dewott",
						Language.JPN => "フタチマル",
						Language.GER => "Zwottronin",
						Language.FRE => "Mateloutre",
						Language.ITA => "Dewott",
						Language.SPN => "Dewott",
						Language.KOR => "쌍검자비",
						Language.CHN_SIM => "双刃丸",
						Language.CHN_TRA => "雙刃丸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SAMUROTT:
					return lang switch {
						Language.ENG => "Samurott",
						Language.JPN => "ダイケンキ",
						Language.GER => "Admurai",
						Language.FRE => "Clamiral",
						Language.ITA => "Samurott",
						Language.SPN => "Samurott",
						Language.KOR => "대검귀",
						Language.CHN_SIM => "大剑鬼",
						Language.CHN_TRA => "大劍鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SAMUROTT_HISUIAN_SAMUROTT:
					return lang switch {
						Language.ENG => "Samurott",
						Language.JPN => "ダイケンキ",
						Language.GER => "Admurai",
						Language.FRE => "Clamiral",
						Language.ITA => "Samurott",
						Language.SPN => "Samurott",
						Language.KOR => "대검귀",
						Language.CHN_SIM => "大剑鬼",
						Language.CHN_TRA => "大劍鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PATRAT:
					return lang switch {
						Language.ENG => "Patrat",
						Language.JPN => "ミネズミ",
						Language.GER => "Nagelotz",
						Language.FRE => "Ratentif",
						Language.ITA => "Patrat",
						Language.SPN => "Patrat",
						Language.KOR => "보르쥐",
						Language.CHN_SIM => "探探鼠",
						Language.CHN_TRA => "探探鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WATCHOG:
					return lang switch {
						Language.ENG => "Watchog",
						Language.JPN => "ミルホッグ",
						Language.GER => "Kukmarda",
						Language.FRE => "Miradar",
						Language.ITA => "Watchog",
						Language.SPN => "Watchog",
						Language.KOR => "보르그",
						Language.CHN_SIM => "步哨鼠",
						Language.CHN_TRA => "步哨鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LILLIPUP:
					return lang switch {
						Language.ENG => "Lillipup",
						Language.JPN => "ヨーテリー",
						Language.GER => "Yorkleff",
						Language.FRE => "Ponchiot",
						Language.ITA => "Lillipup",
						Language.SPN => "Lillipup",
						Language.KOR => "요테리",
						Language.CHN_SIM => "小约克",
						Language.CHN_TRA => "小約克",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HERDIER:
					return lang switch {
						Language.ENG => "Herdier",
						Language.JPN => "ハーデリア",
						Language.GER => "Terribark",
						Language.FRE => "Ponchien",
						Language.ITA => "Herdier",
						Language.SPN => "Herdier",
						Language.KOR => "하데리어",
						Language.CHN_SIM => "哈约克",
						Language.CHN_TRA => "哈約克",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STOUTLAND:
					return lang switch {
						Language.ENG => "Stoutland",
						Language.JPN => "ムーランド",
						Language.GER => "Bissbark",
						Language.FRE => "Mastouffe",
						Language.ITA => "Stoutland",
						Language.SPN => "Stoutland",
						Language.KOR => "바랜드",
						Language.CHN_SIM => "长毛狗",
						Language.CHN_TRA => "長毛狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PURRLOIN:
					return lang switch {
						Language.ENG => "Purrloin",
						Language.JPN => "チョロネコ",
						Language.GER => "Felilou",
						Language.FRE => "Chacripan",
						Language.ITA => "Purrloin",
						Language.SPN => "Purrloin",
						Language.KOR => "쌔비냥",
						Language.CHN_SIM => "扒手猫",
						Language.CHN_TRA => "扒手貓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LIEPARD:
					return lang switch {
						Language.ENG => "Liepard",
						Language.JPN => "レパルダス",
						Language.GER => "Kleoparda",
						Language.FRE => "Léopardus",
						Language.ITA => "Liepard",
						Language.SPN => "Liepard",
						Language.KOR => "레파르다스",
						Language.CHN_SIM => "酷豹",
						Language.CHN_TRA => "酷豹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PANSAGE:
					return lang switch {
						Language.ENG => "Pansage",
						Language.JPN => "ヤナップ",
						Language.GER => "Vegimak",
						Language.FRE => "Feuillajou",
						Language.ITA => "Pansage",
						Language.SPN => "Pansage",
						Language.KOR => "야나프",
						Language.CHN_SIM => "花椰猴",
						Language.CHN_TRA => "花椰猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SIMISAGE:
					return lang switch {
						Language.ENG => "Simisage",
						Language.JPN => "ヤナッキー",
						Language.GER => "Vegichita",
						Language.FRE => "Feuiloutan",
						Language.ITA => "Simisage",
						Language.SPN => "Simisage",
						Language.KOR => "야나키",
						Language.CHN_SIM => "花椰猿",
						Language.CHN_TRA => "花椰猿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PANSEAR:
					return lang switch {
						Language.ENG => "Pansear",
						Language.JPN => "バオップ",
						Language.GER => "Grillmak",
						Language.FRE => "Flamajou",
						Language.ITA => "Pansear",
						Language.SPN => "Pansear",
						Language.KOR => "바오프",
						Language.CHN_SIM => "爆香猴",
						Language.CHN_TRA => "爆香猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SIMISEAR:
					return lang switch {
						Language.ENG => "Simisear",
						Language.JPN => "バオッキー",
						Language.GER => "Grillchita",
						Language.FRE => "Flamoutan",
						Language.ITA => "Simisear",
						Language.SPN => "Simisear",
						Language.KOR => "바오키",
						Language.CHN_SIM => "爆香猿",
						Language.CHN_TRA => "爆香猿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PANPOUR:
					return lang switch {
						Language.ENG => "Panpour",
						Language.JPN => "ヒヤップ",
						Language.GER => "Sodamak",
						Language.FRE => "Flotajou",
						Language.ITA => "Panpour",
						Language.SPN => "Panpour",
						Language.KOR => "앗차프",
						Language.CHN_SIM => "冷水猴",
						Language.CHN_TRA => "冷水猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SIMIPOUR:
					return lang switch {
						Language.ENG => "Simipour",
						Language.JPN => "ヒヤッキー",
						Language.GER => "Sodachita",
						Language.FRE => "Flotoutan",
						Language.ITA => "Simipour",
						Language.SPN => "Simipour",
						Language.KOR => "앗차키",
						Language.CHN_SIM => "冷水猿",
						Language.CHN_TRA => "冷水猿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUNNA:
					return lang switch {
						Language.ENG => "Munna",
						Language.JPN => "ムンナ",
						Language.GER => "Somniam",
						Language.FRE => "Munna",
						Language.ITA => "Munna",
						Language.SPN => "Munna",
						Language.KOR => "몽나",
						Language.CHN_SIM => "食梦梦",
						Language.CHN_TRA => "食夢夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUSHARNA:
					return lang switch {
						Language.ENG => "Musharna",
						Language.JPN => "ムシャーナ",
						Language.GER => "Somnivora",
						Language.FRE => "Mushana",
						Language.ITA => "Musharna",
						Language.SPN => "Musharna",
						Language.KOR => "몽얌나",
						Language.CHN_SIM => "梦梦蚀",
						Language.CHN_TRA => "夢夢蝕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIDOVE:
					return lang switch {
						Language.ENG => "Pidove",
						Language.JPN => "マメパト",
						Language.GER => "Dusselgurr",
						Language.FRE => "Poichigeon",
						Language.ITA => "Pidove",
						Language.SPN => "Pidove",
						Language.KOR => "콩둘기",
						Language.CHN_SIM => "豆豆鸽",
						Language.CHN_TRA => "豆豆鴿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TRANQUILL:
					return lang switch {
						Language.ENG => "Tranquill",
						Language.JPN => "ハトーボー",
						Language.GER => "Navitaub",
						Language.FRE => "Colombeau",
						Language.ITA => "Tranquill",
						Language.SPN => "Tranquill",
						Language.KOR => "유토브",
						Language.CHN_SIM => "咕咕鸽",
						Language.CHN_TRA => "咕咕鴿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.UNFEZANT:
					return lang switch {
						Language.ENG => "Unfezant",
						Language.JPN => "ケンホロウ",
						Language.GER => "Fasasnob",
						Language.FRE => "Déflaisan",
						Language.ITA => "Unfezant",
						Language.SPN => "Unfezant",
						Language.KOR => "켄호로우",
						Language.CHN_SIM => "高傲雉鸡",
						Language.CHN_TRA => "高傲雉雞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLITZLE:
					return lang switch {
						Language.ENG => "Blitzle",
						Language.JPN => "シママ",
						Language.GER => "Elezeba",
						Language.FRE => "Zébibron",
						Language.ITA => "Blitzle",
						Language.SPN => "Blitzle",
						Language.KOR => "줄뮤마",
						Language.CHN_SIM => "斑斑马",
						Language.CHN_TRA => "斑斑馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZEBSTRIKA:
					return lang switch {
						Language.ENG => "Zebstrika",
						Language.JPN => "ゼブライカ",
						Language.GER => "Zebritz",
						Language.FRE => "Zéblitz",
						Language.ITA => "Zebstrika",
						Language.SPN => "Zebstrika",
						Language.KOR => "제브라이카",
						Language.CHN_SIM => "雷电斑马",
						Language.CHN_TRA => "雷電斑馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROGGENROLA:
					return lang switch {
						Language.ENG => "Roggenrola",
						Language.JPN => "ダンゴロ",
						Language.GER => "Kiesling",
						Language.FRE => "Nodulithe",
						Language.ITA => "Roggenrola",
						Language.SPN => "Roggenrola",
						Language.KOR => "단굴",
						Language.CHN_SIM => "石丸子",
						Language.CHN_TRA => "石丸子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BOLDORE:
					return lang switch {
						Language.ENG => "Boldore",
						Language.JPN => "ガントル",
						Language.GER => "Sedimantur",
						Language.FRE => "Géolithe",
						Language.ITA => "Boldore",
						Language.SPN => "Boldore",
						Language.KOR => "암트르",
						Language.CHN_SIM => "地幔岩",
						Language.CHN_TRA => "地幔岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIGALITH:
					return lang switch {
						Language.ENG => "Gigalith",
						Language.JPN => "ギガイアス",
						Language.GER => "Brockoloss",
						Language.FRE => "Gigalithe",
						Language.ITA => "Gigalith",
						Language.SPN => "Gigalith",
						Language.KOR => "기가이어스",
						Language.CHN_SIM => "庞岩怪",
						Language.CHN_TRA => "龐岩怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WOOBAT:
					return lang switch {
						Language.ENG => "Woobat",
						Language.JPN => "コロモリ",
						Language.GER => "Fleknoil",
						Language.FRE => "Chovsourir",
						Language.ITA => "Woobat",
						Language.SPN => "Woobat",
						Language.KOR => "또르박쥐",
						Language.CHN_SIM => "滚滚蝙蝠",
						Language.CHN_TRA => "滾滾蝙蝠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWOOBAT:
					return lang switch {
						Language.ENG => "Swoobat",
						Language.JPN => "ココロモリ",
						Language.GER => "Fletiamo",
						Language.FRE => "Rhinolove",
						Language.ITA => "Swoobat",
						Language.SPN => "Swoobat",
						Language.KOR => "맘박쥐",
						Language.CHN_SIM => "心蝙蝠",
						Language.CHN_TRA => "心蝙蝠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRILBUR:
					return lang switch {
						Language.ENG => "Drilbur",
						Language.JPN => "モグリュー",
						Language.GER => "Rotomurf",
						Language.FRE => "Rototaupe",
						Language.ITA => "Drilbur",
						Language.SPN => "Drilbur",
						Language.KOR => "두더류",
						Language.CHN_SIM => "螺钉地鼠",
						Language.CHN_TRA => "螺釘地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EXCADRILL:
					return lang switch {
						Language.ENG => "Excadrill",
						Language.JPN => "ドリュウズ",
						Language.GER => "Stalobor",
						Language.FRE => "Minotaupe",
						Language.ITA => "Excadrill",
						Language.SPN => "Excadrill",
						Language.KOR => "몰드류",
						Language.CHN_SIM => "龙头地鼠",
						Language.CHN_TRA => "龍頭地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AUDINO:
					return lang switch {
						Language.ENG => "Audino",
						Language.JPN => "タブンネ",
						Language.GER => "Ohrdoch",
						Language.FRE => "Nanméouïe",
						Language.ITA => "Audino",
						Language.SPN => "Audino",
						Language.KOR => "다부니",
						Language.CHN_SIM => "差不多娃娃",
						Language.CHN_TRA => "差不多娃娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AUDINO_MEGA_AUDINO:
					return lang switch {
						Language.ENG => "Audino",
						Language.JPN => "タブンネ",
						Language.GER => "Ohrdoch",
						Language.FRE => "Nanméouïe",
						Language.ITA => "Audino",
						Language.SPN => "Audino",
						Language.KOR => "다부니",
						Language.CHN_SIM => "差不多娃娃",
						Language.CHN_TRA => "差不多娃娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TIMBURR:
					return lang switch {
						Language.ENG => "Timburr",
						Language.JPN => "ドッコラー",
						Language.GER => "Praktibalk",
						Language.FRE => "Charpenti",
						Language.ITA => "Timburr",
						Language.SPN => "Timburr",
						Language.KOR => "으랏차",
						Language.CHN_SIM => "搬运小匠",
						Language.CHN_TRA => "搬運小匠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GURDURR:
					return lang switch {
						Language.ENG => "Gurdurr",
						Language.JPN => "ドテッコツ",
						Language.GER => "Strepoli",
						Language.FRE => "Ouvrifier",
						Language.ITA => "Gurdurr",
						Language.SPN => "Gurdurr",
						Language.KOR => "토쇠골",
						Language.CHN_SIM => "铁骨土人",
						Language.CHN_TRA => "鐵骨土人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CONKELDURR:
					return lang switch {
						Language.ENG => "Conkeldurr",
						Language.JPN => "ローブシン",
						Language.GER => "Meistagrif",
						Language.FRE => "Bétochef",
						Language.ITA => "Conkeldurr",
						Language.SPN => "Conkeldurr",
						Language.KOR => "노보청",
						Language.CHN_SIM => "修建老匠",
						Language.CHN_TRA => "修建老匠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYMPOLE:
					return lang switch {
						Language.ENG => "Tympole",
						Language.JPN => "オタマロ",
						Language.GER => "Schallquap",
						Language.FRE => "Tritonde",
						Language.ITA => "Tympole",
						Language.SPN => "Tympole",
						Language.KOR => "동챙이",
						Language.CHN_SIM => "圆蝌蚪",
						Language.CHN_TRA => "圓蝌蚪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PALPITOAD:
					return lang switch {
						Language.ENG => "Palpitoad",
						Language.JPN => "ガマガル",
						Language.GER => "Mebrana",
						Language.FRE => "Batracné",
						Language.ITA => "Palpitoad",
						Language.SPN => "Palpitoad",
						Language.KOR => "두까비",
						Language.CHN_SIM => "蓝蟾蜍",
						Language.CHN_TRA => "藍蟾蜍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEISMITOAD:
					return lang switch {
						Language.ENG => "Seismitoad",
						Language.JPN => "ガマゲロゲ",
						Language.GER => "Branawarz",
						Language.FRE => "Crapustule",
						Language.ITA => "Seismitoad",
						Language.SPN => "Seismitoad",
						Language.KOR => "두빅굴",
						Language.CHN_SIM => "蟾蜍王",
						Language.CHN_TRA => "蟾蜍王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.THROH:
					return lang switch {
						Language.ENG => "Throh",
						Language.JPN => "ナゲキ",
						Language.GER => "Jiutesto",
						Language.FRE => "Judokrak",
						Language.ITA => "Throh",
						Language.SPN => "Throh",
						Language.KOR => "던지미",
						Language.CHN_SIM => "投摔鬼",
						Language.CHN_TRA => "投摔鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SAWK:
					return lang switch {
						Language.ENG => "Sawk",
						Language.JPN => "ダゲキ",
						Language.GER => "Karadonis",
						Language.FRE => "Karaclée",
						Language.ITA => "Sawk",
						Language.SPN => "Sawk",
						Language.KOR => "타격귀",
						Language.CHN_SIM => "打击鬼",
						Language.CHN_TRA => "打擊鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SEWADDLE:
					return lang switch {
						Language.ENG => "Sewaddle",
						Language.JPN => "クルミル",
						Language.GER => "Strawickl",
						Language.FRE => "Larveyette",
						Language.ITA => "Sewaddle",
						Language.SPN => "Sewaddle",
						Language.KOR => "두르보",
						Language.CHN_SIM => "虫宝包",
						Language.CHN_TRA => "蟲寶包",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWADLOON:
					return lang switch {
						Language.ENG => "Swadloon",
						Language.JPN => "クルマユ",
						Language.GER => "Folikon",
						Language.FRE => "Couverdure",
						Language.ITA => "Swadloon",
						Language.SPN => "Swadloon",
						Language.KOR => "두르쿤",
						Language.CHN_SIM => "宝包茧",
						Language.CHN_TRA => "寶包繭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LEAVANNY:
					return lang switch {
						Language.ENG => "Leavanny",
						Language.JPN => "ハハコモリ",
						Language.GER => "Matrifol",
						Language.FRE => "Manternel",
						Language.ITA => "Leavanny",
						Language.SPN => "Leavanny",
						Language.KOR => "모아머",
						Language.CHN_SIM => "保姆虫",
						Language.CHN_TRA => "保母蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VENIPEDE:
					return lang switch {
						Language.ENG => "Venipede",
						Language.JPN => "フシデ",
						Language.GER => "Toxiped",
						Language.FRE => "Venipatte",
						Language.ITA => "Venipede",
						Language.SPN => "Venipede",
						Language.KOR => "마디네",
						Language.CHN_SIM => "百足蜈蚣",
						Language.CHN_TRA => "百足蜈蚣",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WHIRLIPEDE:
					return lang switch {
						Language.ENG => "Whirlipede",
						Language.JPN => "ホイーガ",
						Language.GER => "Rollum",
						Language.FRE => "Scobolide",
						Language.ITA => "Whirlipede",
						Language.SPN => "Whirlipede",
						Language.KOR => "휠구",
						Language.CHN_SIM => "车轮球",
						Language.CHN_TRA => "車輪毬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCOLIPEDE:
					return lang switch {
						Language.ENG => "Scolipede",
						Language.JPN => "ペンドラー",
						Language.GER => "Cerapendra",
						Language.FRE => "Brutapode",
						Language.ITA => "Scolipede",
						Language.SPN => "Scolipede",
						Language.KOR => "펜드라",
						Language.CHN_SIM => "蜈蚣王",
						Language.CHN_TRA => "蜈蚣王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COTTONEE:
					return lang switch {
						Language.ENG => "Cottonee",
						Language.JPN => "モンメン",
						Language.GER => "Waumboll",
						Language.FRE => "Doudouvet",
						Language.ITA => "Cottonee",
						Language.SPN => "Cottonee",
						Language.KOR => "소미안",
						Language.CHN_SIM => "木棉球",
						Language.CHN_TRA => "木棉球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WHIMSICOTT:
					return lang switch {
						Language.ENG => "Whimsicott",
						Language.JPN => "エルフーン",
						Language.GER => "Elfun",
						Language.FRE => "Farfaduvet",
						Language.ITA => "Whimsicott",
						Language.SPN => "Whimsicott",
						Language.KOR => "엘풍",
						Language.CHN_SIM => "风妖精",
						Language.CHN_TRA => "風妖精",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PETILIL:
					return lang switch {
						Language.ENG => "Petilil",
						Language.JPN => "チュリネ",
						Language.GER => "Lilminip",
						Language.FRE => "Chlorobule",
						Language.ITA => "Petilil",
						Language.SPN => "Petilil",
						Language.KOR => "치릴리",
						Language.CHN_SIM => "百合根娃娃",
						Language.CHN_TRA => "百合根娃娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LILLIGANT:
					return lang switch {
						Language.ENG => "Lilligant",
						Language.JPN => "ドレディア",
						Language.GER => "Dressella",
						Language.FRE => "Fragilady",
						Language.ITA => "Lilligant",
						Language.SPN => "Lilligant",
						Language.KOR => "드레디어",
						Language.CHN_SIM => "裙儿小姐",
						Language.CHN_TRA => "裙兒小姐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LILLIGANT_HISUIAN_LILLIGANT:
					return lang switch {
						Language.ENG => "Lilligant",
						Language.JPN => "ドレディア",
						Language.GER => "Dressella",
						Language.FRE => "Fragilady",
						Language.ITA => "Lilligant",
						Language.SPN => "Lilligant",
						Language.KOR => "드레디어",
						Language.CHN_SIM => "裙儿小姐",
						Language.CHN_TRA => "裙兒小姐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BASCULIN_RED_STRIPED_FORM:
					return lang switch {
						Language.ENG => "Basculin",
						Language.JPN => "バスラオ",
						Language.GER => "Barschuft",
						Language.FRE => "Bargantua",
						Language.ITA => "Basculin",
						Language.SPN => "Basculin",
						Language.KOR => "배쓰나이",
						Language.CHN_SIM => "野蛮鲈鱼",
						Language.CHN_TRA => "野蠻鱸魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BASCULIN_BLUE_STRIPED_FORM:
					return lang switch {
						Language.ENG => "Basculin",
						Language.JPN => "バスラオ",
						Language.GER => "Barschuft",
						Language.FRE => "Bargantua",
						Language.ITA => "Basculin",
						Language.SPN => "Basculin",
						Language.KOR => "배쓰나이",
						Language.CHN_SIM => "野蛮鲈鱼",
						Language.CHN_TRA => "野蠻鱸魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BASCULIN_WHITE_STRIPED_FORM:
					return lang switch {
						Language.ENG => "Basculin",
						Language.JPN => "バスラオ",
						Language.GER => "Barschuft",
						Language.FRE => "Bargantua",
						Language.ITA => "Basculin",
						Language.SPN => "Basculin",
						Language.KOR => "배쓰나이",
						Language.CHN_SIM => "野蛮鲈鱼",
						Language.CHN_TRA => "野蠻鱸魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDILE:
					return lang switch {
						Language.ENG => "Sandile",
						Language.JPN => "メグロコ",
						Language.GER => "Ganovil",
						Language.FRE => "Mascaïman",
						Language.ITA => "Sandile",
						Language.SPN => "Sandile",
						Language.KOR => "깜눈크",
						Language.CHN_SIM => "黑眼鳄",
						Language.CHN_TRA => "黑眼鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KROKOROK:
					return lang switch {
						Language.ENG => "Krokorok",
						Language.JPN => "ワルビル",
						Language.GER => "Rokkaiman",
						Language.FRE => "Escroco",
						Language.ITA => "Krokorok",
						Language.SPN => "Krokorok",
						Language.KOR => "악비르",
						Language.CHN_SIM => "混混鳄",
						Language.CHN_TRA => "混混鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KROOKODILE:
					return lang switch {
						Language.ENG => "Krookodile",
						Language.JPN => "ワルビアル",
						Language.GER => "Rabigator",
						Language.FRE => "Crocorible",
						Language.ITA => "Krookodile",
						Language.SPN => "Krookodile",
						Language.KOR => "악비아르",
						Language.CHN_SIM => "流氓鳄",
						Language.CHN_TRA => "流氓鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARUMAKA:
					return lang switch {
						Language.ENG => "Darumaka",
						Language.JPN => "ダルマッカ",
						Language.GER => "Flampion",
						Language.FRE => "Darumarond",
						Language.ITA => "Darumaka",
						Language.SPN => "Darumaka",
						Language.KOR => "달막화",
						Language.CHN_SIM => "火红不倒翁",
						Language.CHN_TRA => "火紅不倒翁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARUMAKA_GALARIAN_DARUMAKA:
					return lang switch {
						Language.ENG => "Darumaka",
						Language.JPN => "ダルマッカ",
						Language.GER => "Flampion",
						Language.FRE => "Darumarond",
						Language.ITA => "Darumaka",
						Language.SPN => "Darumaka",
						Language.KOR => "달막화",
						Language.CHN_SIM => "火红不倒翁",
						Language.CHN_TRA => "火紅不倒翁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARMANITAN_STANDARD_MODE:
					return lang switch {
						Language.ENG => "Darmanitan",
						Language.JPN => "ヒヒダルマ",
						Language.GER => "Flampivian",
						Language.FRE => "Darumacho",
						Language.ITA => "Darmanitan",
						Language.SPN => "Darmanitan",
						Language.KOR => "불비달마",
						Language.CHN_SIM => "达摩狒狒",
						Language.CHN_TRA => "達摩狒狒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARMANITAN_ZEN_MODE:
					return lang switch {
						Language.ENG => "Darmanitan",
						Language.JPN => "ヒヒダルマ",
						Language.GER => "Flampivian",
						Language.FRE => "Darumacho",
						Language.ITA => "Darmanitan",
						Language.SPN => "Darmanitan",
						Language.KOR => "불비달마",
						Language.CHN_SIM => "达摩狒狒",
						Language.CHN_TRA => "達摩狒狒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARMANITAN_GALARIAN_STANDARD_MODE:
					return lang switch {
						Language.ENG => "Darmanitan",
						Language.JPN => "ヒヒダルマ",
						Language.GER => "Flampivian",
						Language.FRE => "Darumacho",
						Language.ITA => "Darmanitan",
						Language.SPN => "Darmanitan",
						Language.KOR => "불비달마",
						Language.CHN_SIM => "达摩狒狒",
						Language.CHN_TRA => "達摩狒狒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARMANITAN_GALARIAN_ZEN_MODE:
					return lang switch {
						Language.ENG => "Darmanitan",
						Language.JPN => "ヒヒダルマ",
						Language.GER => "Flampivian",
						Language.FRE => "Darumacho",
						Language.ITA => "Darmanitan",
						Language.SPN => "Darmanitan",
						Language.KOR => "불비달마",
						Language.CHN_SIM => "达摩狒狒",
						Language.CHN_TRA => "達摩狒狒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MARACTUS:
					return lang switch {
						Language.ENG => "Maractus",
						Language.JPN => "マラカッチ",
						Language.GER => "Maracamba",
						Language.FRE => "Maracachi",
						Language.ITA => "Maractus",
						Language.SPN => "Maractus",
						Language.KOR => "마라카치",
						Language.CHN_SIM => "沙铃仙人掌",
						Language.CHN_TRA => "沙鈴仙人掌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DWEBBLE:
					return lang switch {
						Language.ENG => "Dwebble",
						Language.JPN => "イシズマイ",
						Language.GER => "Lithomith",
						Language.FRE => "Crabicoque",
						Language.ITA => "Dwebble",
						Language.SPN => "Dwebble",
						Language.KOR => "돌살이",
						Language.CHN_SIM => "石居蟹",
						Language.CHN_TRA => "石居蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRUSTLE:
					return lang switch {
						Language.ENG => "Crustle",
						Language.JPN => "イワパレス",
						Language.GER => "Castellith",
						Language.FRE => "Crabaraque",
						Language.ITA => "Crustle",
						Language.SPN => "Crustle",
						Language.KOR => "암팰리스",
						Language.CHN_SIM => "岩殿居蟹",
						Language.CHN_TRA => "岩殿居蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCRAGGY:
					return lang switch {
						Language.ENG => "Scraggy",
						Language.JPN => "ズルッグ",
						Language.GER => "Zurrokex",
						Language.FRE => "Baggiguane",
						Language.ITA => "Scraggy",
						Language.SPN => "Scraggy",
						Language.KOR => "곤율랭",
						Language.CHN_SIM => "滑滑小子",
						Language.CHN_TRA => "滑滑小子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCRAFTY:
					return lang switch {
						Language.ENG => "Scrafty",
						Language.JPN => "ズルズキン",
						Language.GER => "Irokex",
						Language.FRE => "Baggaïd",
						Language.ITA => "Scrafty",
						Language.SPN => "Scrafty",
						Language.KOR => "곤율거니",
						Language.CHN_SIM => "头巾混混",
						Language.CHN_TRA => "頭巾混混",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SIGILYPH:
					return lang switch {
						Language.ENG => "Sigilyph",
						Language.JPN => "シンボラー",
						Language.GER => "Symvolara",
						Language.FRE => "Cryptéro",
						Language.ITA => "Sigilyph",
						Language.SPN => "Sigilyph",
						Language.KOR => "심보러",
						Language.CHN_SIM => "象征鸟",
						Language.CHN_TRA => "象徵鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YAMASK:
					return lang switch {
						Language.ENG => "Yamask",
						Language.JPN => "デスマス",
						Language.GER => "Makabaja",
						Language.FRE => "Tutafeh",
						Language.ITA => "Yamask",
						Language.SPN => "Yamask",
						Language.KOR => "데스마스",
						Language.CHN_SIM => "哭哭面具",
						Language.CHN_TRA => "哭哭面具",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YAMASK_GALARIAN_YAMASK:
					return lang switch {
						Language.ENG => "Yamask",
						Language.JPN => "デスマス",
						Language.GER => "Makabaja",
						Language.FRE => "Tutafeh",
						Language.ITA => "Yamask",
						Language.SPN => "Yamask",
						Language.KOR => "데스마스",
						Language.CHN_SIM => "哭哭面具",
						Language.CHN_TRA => "哭哭面具",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COFAGRIGUS:
					return lang switch {
						Language.ENG => "Cofagrigus",
						Language.JPN => "デスカーン",
						Language.GER => "Echnatoll",
						Language.FRE => "Tutankafer",
						Language.ITA => "Cofagrigus",
						Language.SPN => "Cofagrigus",
						Language.KOR => "데스니칸",
						Language.CHN_SIM => "迭失棺",
						Language.CHN_TRA => "死神棺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TIRTOUGA:
					return lang switch {
						Language.ENG => "Tirtouga",
						Language.JPN => "プロトーガ",
						Language.GER => "Galapaflos",
						Language.FRE => "Carapagos",
						Language.ITA => "Tirtouga",
						Language.SPN => "Tirtouga",
						Language.KOR => "프로토가",
						Language.CHN_SIM => "原盖海龟",
						Language.CHN_TRA => "原蓋海龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CARRACOSTA:
					return lang switch {
						Language.ENG => "Carracosta",
						Language.JPN => "アバゴーラ",
						Language.GER => "Karippas",
						Language.FRE => "Mégapagos",
						Language.ITA => "Carracosta",
						Language.SPN => "Carracosta",
						Language.KOR => "늑골라",
						Language.CHN_SIM => "肋骨海龟",
						Language.CHN_TRA => "肋骨海龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCHEN:
					return lang switch {
						Language.ENG => "Archen",
						Language.JPN => "アーケン",
						Language.GER => "Flapteryx",
						Language.FRE => "Arkéapti",
						Language.ITA => "Archen",
						Language.SPN => "Archen",
						Language.KOR => "아켄",
						Language.CHN_SIM => "始祖小鸟",
						Language.CHN_TRA => "始祖小鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCHEOPS:
					return lang switch {
						Language.ENG => "Archeops",
						Language.JPN => "アーケオス",
						Language.GER => "Aeropteryx",
						Language.FRE => "Aéroptéryx",
						Language.ITA => "Archeops",
						Language.SPN => "Archeops",
						Language.KOR => "아케오스",
						Language.CHN_SIM => "始祖大鸟",
						Language.CHN_TRA => "始祖大鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TRUBBISH:
					return lang switch {
						Language.ENG => "Trubbish",
						Language.JPN => "ヤブクロン",
						Language.GER => "Unratütox",
						Language.FRE => "Miamiasme",
						Language.ITA => "Trubbish",
						Language.SPN => "Trubbish",
						Language.KOR => "깨봉이",
						Language.CHN_SIM => "破破袋",
						Language.CHN_TRA => "破破袋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GARBODOR:
					return lang switch {
						Language.ENG => "Garbodor",
						Language.JPN => "ダストダス",
						Language.GER => "Deponitox",
						Language.FRE => "Miasmax",
						Language.ITA => "Garbodor",
						Language.SPN => "Garbodor",
						Language.KOR => "더스트나",
						Language.CHN_SIM => "灰尘山",
						Language.CHN_TRA => "灰塵山",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZORUA:
					return lang switch {
						Language.ENG => "Zorua",
						Language.JPN => "ゾロア",
						Language.GER => "Zorua",
						Language.FRE => "Zorua",
						Language.ITA => "Zorua",
						Language.SPN => "Zorua",
						Language.KOR => "조로아",
						Language.CHN_SIM => "索罗亚",
						Language.CHN_TRA => "索羅亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZORUA_HISUIAN_ZORUA:
					return lang switch {
						Language.ENG => "Zorua",
						Language.JPN => "ゾロア",
						Language.GER => "Zorua",
						Language.FRE => "Zorua",
						Language.ITA => "Zorua",
						Language.SPN => "Zorua",
						Language.KOR => "조로아",
						Language.CHN_SIM => "索罗亚",
						Language.CHN_TRA => "索羅亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZOROARK:
					return lang switch {
						Language.ENG => "Zoroark",
						Language.JPN => "ゾロアーク",
						Language.GER => "Zoroark",
						Language.FRE => "Zoroark",
						Language.ITA => "Zoroark",
						Language.SPN => "Zoroark",
						Language.KOR => "조로아크",
						Language.CHN_SIM => "索罗亚克",
						Language.CHN_TRA => "索羅亞克",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZOROARK_HISUIAN_ZOROARK:
					return lang switch {
						Language.ENG => "Zoroark",
						Language.JPN => "ゾロアーク",
						Language.GER => "Zoroark",
						Language.FRE => "Zoroark",
						Language.ITA => "Zoroark",
						Language.SPN => "Zoroark",
						Language.KOR => "조로아크",
						Language.CHN_SIM => "索罗亚克",
						Language.CHN_TRA => "索羅亞克",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MINCCINO:
					return lang switch {
						Language.ENG => "Minccino",
						Language.JPN => "チラーミィ",
						Language.GER => "Picochilla",
						Language.FRE => "Chinchidou",
						Language.ITA => "Minccino",
						Language.SPN => "Minccino",
						Language.KOR => "치라미",
						Language.CHN_SIM => "泡沫栗鼠",
						Language.CHN_TRA => "泡沫栗鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CINCCINO:
					return lang switch {
						Language.ENG => "Cinccino",
						Language.JPN => "チラチーノ",
						Language.GER => "Chillabell",
						Language.FRE => "Pashmilla",
						Language.ITA => "Cinccino",
						Language.SPN => "Cinccino",
						Language.KOR => "치라치노",
						Language.CHN_SIM => "奇诺栗鼠",
						Language.CHN_TRA => "奇諾栗鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOTHITA:
					return lang switch {
						Language.ENG => "Gothita",
						Language.JPN => "ゴチム",
						Language.GER => "Mollimorba",
						Language.FRE => "Scrutella",
						Language.ITA => "Gothita",
						Language.SPN => "Gothita",
						Language.KOR => "고디탱",
						Language.CHN_SIM => "哥德宝宝",
						Language.CHN_TRA => "哥德寶寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOTHORITA:
					return lang switch {
						Language.ENG => "Gothorita",
						Language.JPN => "ゴチミル",
						Language.GER => "Hypnomorba",
						Language.FRE => "Mesmérella",
						Language.ITA => "Gothorita",
						Language.SPN => "Gothorita",
						Language.KOR => "고디보미",
						Language.CHN_SIM => "哥德小童",
						Language.CHN_TRA => "哥德小童",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOTHITELLE:
					return lang switch {
						Language.ENG => "Gothitelle",
						Language.JPN => "ゴチルゼル",
						Language.GER => "Morbitesse",
						Language.FRE => "Sidérella",
						Language.ITA => "Gothitelle",
						Language.SPN => "Gothitelle",
						Language.KOR => "고디모아젤",
						Language.CHN_SIM => "哥德小姐",
						Language.CHN_TRA => "哥德小姐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SOLOSIS:
					return lang switch {
						Language.ENG => "Solosis",
						Language.JPN => "ユニラン",
						Language.GER => "Monozyto",
						Language.FRE => "Nucléos",
						Language.ITA => "Solosis",
						Language.SPN => "Solosis",
						Language.KOR => "유니란",
						Language.CHN_SIM => "单卵细胞球",
						Language.CHN_TRA => "單卵細胞球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUOSION:
					return lang switch {
						Language.ENG => "Duosion",
						Language.JPN => "ダブラン",
						Language.GER => "Mitodos",
						Language.FRE => "Méios",
						Language.ITA => "Duosion",
						Language.SPN => "Duosion",
						Language.KOR => "듀란",
						Language.CHN_SIM => "双卵细胞球",
						Language.CHN_TRA => "雙卵細胞球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REUNICLUS:
					return lang switch {
						Language.ENG => "Reuniclus",
						Language.JPN => "ランクルス",
						Language.GER => "Zytomega",
						Language.FRE => "Symbios",
						Language.ITA => "Reuniclus",
						Language.SPN => "Reuniclus",
						Language.KOR => "란쿨루스",
						Language.CHN_SIM => "人造细胞卵",
						Language.CHN_TRA => "人造細胞卵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUCKLETT:
					return lang switch {
						Language.ENG => "Ducklett",
						Language.JPN => "コアルヒー",
						Language.GER => "Piccolente",
						Language.FRE => "Couaneton",
						Language.ITA => "Ducklett",
						Language.SPN => "Ducklett",
						Language.KOR => "꼬지보리",
						Language.CHN_SIM => "鸭宝宝",
						Language.CHN_TRA => "鴨寶寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWANNA:
					return lang switch {
						Language.ENG => "Swanna",
						Language.JPN => "スワンナ",
						Language.GER => "Swaroness",
						Language.FRE => "Lakmécygne",
						Language.ITA => "Swanna",
						Language.SPN => "Swanna",
						Language.KOR => "스완나",
						Language.CHN_SIM => "舞天鹅",
						Language.CHN_TRA => "舞天鵝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VANILLITE:
					return lang switch {
						Language.ENG => "Vanillite",
						Language.JPN => "バニプッチ",
						Language.GER => "Gelatini",
						Language.FRE => "Sorbébé",
						Language.ITA => "Vanillite",
						Language.SPN => "Vanillite",
						Language.KOR => "바닐프티",
						Language.CHN_SIM => "迷你冰",
						Language.CHN_TRA => "迷你冰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VANILLISH:
					return lang switch {
						Language.ENG => "Vanillish",
						Language.JPN => "バニリッチ",
						Language.GER => "Gelatroppo",
						Language.FRE => "Sorboul",
						Language.ITA => "Vanillish",
						Language.SPN => "Vanillish",
						Language.KOR => "바닐리치",
						Language.CHN_SIM => "多多冰",
						Language.CHN_TRA => "多多冰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VANILLUXE:
					return lang switch {
						Language.ENG => "Vanilluxe",
						Language.JPN => "バイバニラ",
						Language.GER => "Gelatwino",
						Language.FRE => "Sorbouboul",
						Language.ITA => "Vanilluxe",
						Language.SPN => "Vanilluxe",
						Language.KOR => "배바닐라",
						Language.CHN_SIM => "双倍多多冰",
						Language.CHN_TRA => "雙倍多多冰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEERLING:
					return lang switch {
						Language.ENG => "Deerling",
						Language.JPN => "シキジカ",
						Language.GER => "Sesokitz",
						Language.FRE => "Vivaldaim",
						Language.ITA => "Deerling",
						Language.SPN => "Deerling",
						Language.KOR => "사철록",
						Language.CHN_SIM => "四季鹿",
						Language.CHN_TRA => "四季鹿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SAWSBUCK:
					return lang switch {
						Language.ENG => "Sawsbuck",
						Language.JPN => "メブキジカ",
						Language.GER => "Kronjuwild",
						Language.FRE => "Haydaim",
						Language.ITA => "Sawsbuck",
						Language.SPN => "Sawsbuck",
						Language.KOR => "바라철록",
						Language.CHN_SIM => "萌芽鹿",
						Language.CHN_TRA => "萌芽鹿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EMOLGA:
					return lang switch {
						Language.ENG => "Emolga",
						Language.JPN => "エモンガ",
						Language.GER => "Emolga",
						Language.FRE => "Emolga",
						Language.ITA => "Emolga",
						Language.SPN => "Emolga",
						Language.KOR => "에몽가",
						Language.CHN_SIM => "电飞鼠",
						Language.CHN_TRA => "電飛鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KARRABLAST:
					return lang switch {
						Language.ENG => "Karrablast",
						Language.JPN => "カブルモ",
						Language.GER => "Laukaps",
						Language.FRE => "Carabing",
						Language.ITA => "Karrablast",
						Language.SPN => "Karrablast",
						Language.KOR => "딱정곤",
						Language.CHN_SIM => "盖盖虫",
						Language.CHN_TRA => "蓋蓋蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ESCAVALIER:
					return lang switch {
						Language.ENG => "Escavalier",
						Language.JPN => "シュバルゴ",
						Language.GER => "Cavalanzas",
						Language.FRE => "Lançargot",
						Language.ITA => "Escavalier",
						Language.SPN => "Escavalier",
						Language.KOR => "슈바르고",
						Language.CHN_SIM => "骑士蜗牛",
						Language.CHN_TRA => "騎士蝸牛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FOONGUS:
					return lang switch {
						Language.ENG => "Foongus",
						Language.JPN => "タマゲタケ",
						Language.GER => "Tarnpignon",
						Language.FRE => "Trompignon",
						Language.ITA => "Foongus",
						Language.SPN => "Foongus",
						Language.KOR => "깜놀버슬",
						Language.CHN_SIM => "哎呀球菇",
						Language.CHN_TRA => "哎呀球菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AMOONGUSS:
					return lang switch {
						Language.ENG => "Amoonguss",
						Language.JPN => "モロバレル",
						Language.GER => "Hutsassa",
						Language.FRE => "Gaulet",
						Language.ITA => "Amoonguss",
						Language.SPN => "Amoonguss",
						Language.KOR => "뽀록나",
						Language.CHN_SIM => "败露球菇",
						Language.CHN_TRA => "敗露球菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FRILLISH:
					return lang switch {
						Language.ENG => "Frillish",
						Language.JPN => "プルリル",
						Language.GER => "Quabbel",
						Language.FRE => "Viskuse",
						Language.ITA => "Frillish",
						Language.SPN => "Frillish",
						Language.KOR => "탱그릴",
						Language.CHN_SIM => "轻飘飘",
						Language.CHN_TRA => "輕飄飄",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JELLICENT:
					return lang switch {
						Language.ENG => "Jellicent",
						Language.JPN => "ブルンゲル",
						Language.GER => "Apoquallyp",
						Language.FRE => "Moyade",
						Language.ITA => "Jellicent",
						Language.SPN => "Jellicent",
						Language.KOR => "탱탱겔",
						Language.CHN_SIM => "胖嘟嘟",
						Language.CHN_TRA => "胖嘟嘟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ALOMOMOLA:
					return lang switch {
						Language.ENG => "Alomomola",
						Language.JPN => "ママンボウ",
						Language.GER => "Mamolida",
						Language.FRE => "Mamanbo",
						Language.ITA => "Alomomola",
						Language.SPN => "Alomomola",
						Language.KOR => "맘복치",
						Language.CHN_SIM => "保姆曼波",
						Language.CHN_TRA => "保母曼波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JOLTIK:
					return lang switch {
						Language.ENG => "Joltik",
						Language.JPN => "バチュル",
						Language.GER => "Wattzapf",
						Language.FRE => "Statitik",
						Language.ITA => "Joltik",
						Language.SPN => "Joltik",
						Language.KOR => "파쪼옥",
						Language.CHN_SIM => "电电虫",
						Language.CHN_TRA => "電電蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GALVANTULA:
					return lang switch {
						Language.ENG => "Galvantula",
						Language.JPN => "デンチュラ",
						Language.GER => "Voltula",
						Language.FRE => "Mygavolt",
						Language.ITA => "Galvantula",
						Language.SPN => "Galvantula",
						Language.KOR => "전툴라",
						Language.CHN_SIM => "电蜘蛛",
						Language.CHN_TRA => "電蜘蛛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FERROSEED:
					return lang switch {
						Language.ENG => "Ferroseed",
						Language.JPN => "テッシード",
						Language.GER => "Kastadur",
						Language.FRE => "Grindur",
						Language.ITA => "Ferroseed",
						Language.SPN => "Ferroseed",
						Language.KOR => "철시드",
						Language.CHN_SIM => "种子铁球",
						Language.CHN_TRA => "種子鐵球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FERROTHORN:
					return lang switch {
						Language.ENG => "Ferrothorn",
						Language.JPN => "ナットレイ",
						Language.GER => "Tentantel",
						Language.FRE => "Noacier",
						Language.ITA => "Ferrothorn",
						Language.SPN => "Ferrothorn",
						Language.KOR => "너트령",
						Language.CHN_SIM => "坚果哑铃",
						Language.CHN_TRA => "堅果啞鈴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KLINK:
					return lang switch {
						Language.ENG => "Klink",
						Language.JPN => "ギアル",
						Language.GER => "Klikk",
						Language.FRE => "Tic",
						Language.ITA => "Klink",
						Language.SPN => "Klink",
						Language.KOR => "기어르",
						Language.CHN_SIM => "齿轮儿",
						Language.CHN_TRA => "齒輪兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KLANG:
					return lang switch {
						Language.ENG => "Klang",
						Language.JPN => "ギギアル",
						Language.GER => "Kliklak",
						Language.FRE => "Clic",
						Language.ITA => "Klang",
						Language.SPN => "Klang",
						Language.KOR => "기기어르",
						Language.CHN_SIM => "齿轮组",
						Language.CHN_TRA => "齒輪組",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KLINKLANG:
					return lang switch {
						Language.ENG => "Klinklang",
						Language.JPN => "ギギギアル",
						Language.GER => "Klikdiklak",
						Language.FRE => "Cliticlic",
						Language.ITA => "Klinklang",
						Language.SPN => "Klinklang",
						Language.KOR => "기기기어르",
						Language.CHN_SIM => "齿轮怪",
						Language.CHN_TRA => "齒輪怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYNAMO:
					return lang switch {
						Language.ENG => "Tynamo",
						Language.JPN => "シビシラス",
						Language.GER => "Zapplardin",
						Language.FRE => "Anchwatt",
						Language.ITA => "Tynamo",
						Language.SPN => "Tynamo",
						Language.KOR => "저리어",
						Language.CHN_SIM => "麻麻小鱼",
						Language.CHN_TRA => "麻麻小魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EELEKTRIK:
					return lang switch {
						Language.ENG => "Eelektrik",
						Language.JPN => "シビビール",
						Language.GER => "Zapplalek",
						Language.FRE => "Lampéroie",
						Language.ITA => "Eelektrik",
						Language.SPN => "Eelektrik",
						Language.KOR => "저리릴",
						Language.CHN_SIM => "麻麻鳗",
						Language.CHN_TRA => "麻麻鰻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EELEKTROSS:
					return lang switch {
						Language.ENG => "Eelektross",
						Language.JPN => "シビルドン",
						Language.GER => "Zapplarang",
						Language.FRE => "Ohmassacre",
						Language.ITA => "Eelektross",
						Language.SPN => "Eelektross",
						Language.KOR => "저리더프",
						Language.CHN_SIM => "麻麻鳗鱼王",
						Language.CHN_TRA => "麻麻鰻魚王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELGYEM:
					return lang switch {
						Language.ENG => "Elgyem",
						Language.JPN => "リグレー",
						Language.GER => "Pygraulon",
						Language.FRE => "Lewsor",
						Language.ITA => "Elgyem",
						Language.SPN => "Elgyem",
						Language.KOR => "리그레",
						Language.CHN_SIM => "小灰怪",
						Language.CHN_TRA => "小灰怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BEHEEYEM:
					return lang switch {
						Language.ENG => "Beheeyem",
						Language.JPN => "オーベム",
						Language.GER => "Megalon",
						Language.FRE => "Neitram",
						Language.ITA => "Beheeyem",
						Language.SPN => "Beheeyem",
						Language.KOR => "벰크",
						Language.CHN_SIM => "大宇怪",
						Language.CHN_TRA => "大宇怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LITWICK:
					return lang switch {
						Language.ENG => "Litwick",
						Language.JPN => "ヒトモシ",
						Language.GER => "Lichtel",
						Language.FRE => "Funécire",
						Language.ITA => "Litwick",
						Language.SPN => "Litwick",
						Language.KOR => "불켜미",
						Language.CHN_SIM => "烛光灵",
						Language.CHN_TRA => "燭光靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LAMPENT:
					return lang switch {
						Language.ENG => "Lampent",
						Language.JPN => "ランプラー",
						Language.GER => "Laternecto",
						Language.FRE => "Mélancolux",
						Language.ITA => "Lampent",
						Language.SPN => "Lampent",
						Language.KOR => "램프라",
						Language.CHN_SIM => "灯火幽灵",
						Language.CHN_TRA => "燈火幽靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHANDELURE:
					return lang switch {
						Language.ENG => "Chandelure",
						Language.JPN => "シャンデラ",
						Language.GER => "Skelabra",
						Language.FRE => "Lugulabre",
						Language.ITA => "Chandelure",
						Language.SPN => "Chandelure",
						Language.KOR => "샹델라",
						Language.CHN_SIM => "水晶灯火灵",
						Language.CHN_TRA => "水晶燈火靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AXEW:
					return lang switch {
						Language.ENG => "Axew",
						Language.JPN => "キバゴ",
						Language.GER => "Milza",
						Language.FRE => "Coupenotte",
						Language.ITA => "Axew",
						Language.SPN => "Axew",
						Language.KOR => "터검니",
						Language.CHN_SIM => "牙牙",
						Language.CHN_TRA => "牙牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FRAXURE:
					return lang switch {
						Language.ENG => "Fraxure",
						Language.JPN => "オノンド",
						Language.GER => "Sharfax",
						Language.FRE => "Incisache",
						Language.ITA => "Fraxure",
						Language.SPN => "Fraxure",
						Language.KOR => "액슨도",
						Language.CHN_SIM => "斧牙龙",
						Language.CHN_TRA => "斧牙龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HAXORUS:
					return lang switch {
						Language.ENG => "Haxorus",
						Language.JPN => "オノノクス",
						Language.GER => "Maxax",
						Language.FRE => "Tranchodon",
						Language.ITA => "Haxorus",
						Language.SPN => "Haxorus",
						Language.KOR => "액스라이즈",
						Language.CHN_SIM => "双斧战龙",
						Language.CHN_TRA => "雙斧戰龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CUBCHOO:
					return lang switch {
						Language.ENG => "Cubchoo",
						Language.JPN => "クマシュン",
						Language.GER => "Petznief",
						Language.FRE => "Polarhume",
						Language.ITA => "Cubchoo",
						Language.SPN => "Cubchoo",
						Language.KOR => "코고미",
						Language.CHN_SIM => "喷嚏熊",
						Language.CHN_TRA => "噴嚏熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BEARTIC:
					return lang switch {
						Language.ENG => "Beartic",
						Language.JPN => "ツンベアー",
						Language.GER => "Siberio",
						Language.FRE => "Polagriffe",
						Language.ITA => "Beartic",
						Language.SPN => "Beartic",
						Language.KOR => "툰베어",
						Language.CHN_SIM => "冻原熊",
						Language.CHN_TRA => "凍原熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRYOGONAL:
					return lang switch {
						Language.ENG => "Cryogonal",
						Language.JPN => "フリージオ",
						Language.GER => "Frigometri",
						Language.FRE => "Hexagel",
						Language.ITA => "Cryogonal",
						Language.SPN => "Cryogonal",
						Language.KOR => "프리지오",
						Language.CHN_SIM => "几何雪花",
						Language.CHN_TRA => "幾何雪花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHELMET:
					return lang switch {
						Language.ENG => "Shelmet",
						Language.JPN => "チョボマキ",
						Language.GER => "Schnuthelm",
						Language.FRE => "Escargaume",
						Language.ITA => "Shelmet",
						Language.SPN => "Shelmet",
						Language.KOR => "쪼마리",
						Language.CHN_SIM => "小嘴蜗",
						Language.CHN_TRA => "小嘴蝸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ACCELGOR:
					return lang switch {
						Language.ENG => "Accelgor",
						Language.JPN => "アギルダー",
						Language.GER => "Hydragil",
						Language.FRE => "Limaspeed",
						Language.ITA => "Accelgor",
						Language.SPN => "Accelgor",
						Language.KOR => "어지리더",
						Language.CHN_SIM => "敏捷虫",
						Language.CHN_TRA => "敏捷蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STUNFISK:
					return lang switch {
						Language.ENG => "Stunfisk",
						Language.JPN => "マッギョ",
						Language.GER => "Flunschlik",
						Language.FRE => "Limonde",
						Language.ITA => "Stunfisk",
						Language.SPN => "Stunfisk",
						Language.KOR => "메더",
						Language.CHN_SIM => "泥巴鱼",
						Language.CHN_TRA => "泥巴魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STUNFISK_GALARIAN_STUNFISK:
					return lang switch {
						Language.ENG => "Stunfisk",
						Language.JPN => "マッギョ",
						Language.GER => "Flunschlik",
						Language.FRE => "Limonde",
						Language.ITA => "Stunfisk",
						Language.SPN => "Stunfisk",
						Language.KOR => "메더",
						Language.CHN_SIM => "泥巴鱼",
						Language.CHN_TRA => "泥巴魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MIENFOO:
					return lang switch {
						Language.ENG => "Mienfoo",
						Language.JPN => "コジョフー",
						Language.GER => "Lin-Fu",
						Language.FRE => "Kungfouine",
						Language.ITA => "Mienfoo",
						Language.SPN => "Mienfoo",
						Language.KOR => "비조푸",
						Language.CHN_SIM => "功夫鼬",
						Language.CHN_TRA => "功夫鼬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MIENSHAO:
					return lang switch {
						Language.ENG => "Mienshao",
						Language.JPN => "コジョンド",
						Language.GER => "Wie-Shu",
						Language.FRE => "Shaofouine",
						Language.ITA => "Mienshao",
						Language.SPN => "Mienshao",
						Language.KOR => "비조도",
						Language.CHN_SIM => "师父鼬",
						Language.CHN_TRA => "師父鼬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRUDDIGON:
					return lang switch {
						Language.ENG => "Druddigon",
						Language.JPN => "クリムガン",
						Language.GER => "Shardrago",
						Language.FRE => "Drakkarmin",
						Language.ITA => "Druddigon",
						Language.SPN => "Druddigon",
						Language.KOR => "크리만",
						Language.CHN_SIM => "赤面龙",
						Language.CHN_TRA => "赤面龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLETT:
					return lang switch {
						Language.ENG => "Golett",
						Language.JPN => "ゴビット",
						Language.GER => "Golbit",
						Language.FRE => "Gringolem",
						Language.ITA => "Golett",
						Language.SPN => "Golett",
						Language.KOR => "골비람",
						Language.CHN_SIM => "泥偶小人",
						Language.CHN_TRA => "泥偶小人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLURK:
					return lang switch {
						Language.ENG => "Golurk",
						Language.JPN => "ゴルーグ",
						Language.GER => "Golgantes",
						Language.FRE => "Golemastoc",
						Language.ITA => "Golurk",
						Language.SPN => "Golurk",
						Language.KOR => "골루그",
						Language.CHN_SIM => "泥偶巨人",
						Language.CHN_TRA => "泥偶巨人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PAWNIARD:
					return lang switch {
						Language.ENG => "Pawniard",
						Language.JPN => "コマタナ",
						Language.GER => "Gladiantri",
						Language.FRE => "Scalpion",
						Language.ITA => "Pawniard",
						Language.SPN => "Pawniard",
						Language.KOR => "자망칼",
						Language.CHN_SIM => "驹刀小兵",
						Language.CHN_TRA => "駒刀小兵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BISHARP:
					return lang switch {
						Language.ENG => "Bisharp",
						Language.JPN => "キリキザン",
						Language.GER => "Caesurio",
						Language.FRE => "Scalproie",
						Language.ITA => "Bisharp",
						Language.SPN => "Bisharp",
						Language.KOR => "절각참",
						Language.CHN_SIM => "劈斩司令",
						Language.CHN_TRA => "劈斬司令",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BOUFFALANT:
					return lang switch {
						Language.ENG => "Bouffalant",
						Language.JPN => "バッフロン",
						Language.GER => "Bisofank",
						Language.FRE => "Frison",
						Language.ITA => "Bouffalant",
						Language.SPN => "Bouffalant",
						Language.KOR => "버프론",
						Language.CHN_SIM => "爆炸头水牛",
						Language.CHN_TRA => "爆炸頭水牛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RUFFLET:
					return lang switch {
						Language.ENG => "Rufflet",
						Language.JPN => "ワシボン",
						Language.GER => "Geronimatz",
						Language.FRE => "Furaiglon",
						Language.ITA => "Rufflet",
						Language.SPN => "Rufflet",
						Language.KOR => "수리둥보",
						Language.CHN_SIM => "毛头小鹰",
						Language.CHN_TRA => "毛頭小鷹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRAVIARY:
					return lang switch {
						Language.ENG => "Braviary",
						Language.JPN => "ウォーグル",
						Language.GER => "Washakwil",
						Language.FRE => "Gueriaigle",
						Language.ITA => "Braviary",
						Language.SPN => "Braviary",
						Language.KOR => "워글",
						Language.CHN_SIM => "勇士雄鹰",
						Language.CHN_TRA => "勇士雄鷹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRAVIARY_HISUIAN_BRAVIARY:
					return lang switch {
						Language.ENG => "Braviary",
						Language.JPN => "ウォーグル",
						Language.GER => "Washakwil",
						Language.FRE => "Gueriaigle",
						Language.ITA => "Braviary",
						Language.SPN => "Braviary",
						Language.KOR => "워글",
						Language.CHN_SIM => "勇士雄鹰",
						Language.CHN_TRA => "勇士雄鷹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VULLABY:
					return lang switch {
						Language.ENG => "Vullaby",
						Language.JPN => "バルチャイ",
						Language.GER => "Skallyk",
						Language.FRE => "Vostourno",
						Language.ITA => "Vullaby",
						Language.SPN => "Vullaby",
						Language.KOR => "벌차이",
						Language.CHN_SIM => "秃鹰丫头",
						Language.CHN_TRA => "禿鷹丫頭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MANDIBUZZ:
					return lang switch {
						Language.ENG => "Mandibuzz",
						Language.JPN => "バルジーナ",
						Language.GER => "Grypheldis",
						Language.FRE => "Vaututrice",
						Language.ITA => "Mandibuzz",
						Language.SPN => "Mandibuzz",
						Language.KOR => "버랜지나",
						Language.CHN_SIM => "秃鹰娜",
						Language.CHN_TRA => "禿鷹娜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HEATMOR:
					return lang switch {
						Language.ENG => "Heatmor",
						Language.JPN => "クイタラン",
						Language.GER => "Furnifraß",
						Language.FRE => "Aflamanoir",
						Language.ITA => "Heatmor",
						Language.SPN => "Heatmor",
						Language.KOR => "앤티골",
						Language.CHN_SIM => "熔蚁兽",
						Language.CHN_TRA => "熔蟻獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DURANT:
					return lang switch {
						Language.ENG => "Durant",
						Language.JPN => "アイアント",
						Language.GER => "Fermicula",
						Language.FRE => "Fermite",
						Language.ITA => "Durant",
						Language.SPN => "Durant",
						Language.KOR => "아이앤트",
						Language.CHN_SIM => "铁蚁",
						Language.CHN_TRA => "鐵蟻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEINO:
					return lang switch {
						Language.ENG => "Deino",
						Language.JPN => "モノズ",
						Language.GER => "Kapuno",
						Language.FRE => "Solochi",
						Language.ITA => "Deino",
						Language.SPN => "Deino",
						Language.KOR => "모노두",
						Language.CHN_SIM => "单首龙",
						Language.CHN_TRA => "單首龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZWEILOUS:
					return lang switch {
						Language.ENG => "Zweilous",
						Language.JPN => "ジヘッド",
						Language.GER => "Duodino",
						Language.FRE => "Diamat",
						Language.ITA => "Zweilous",
						Language.SPN => "Zweilous",
						Language.KOR => "디헤드",
						Language.CHN_SIM => "双首暴龙",
						Language.CHN_TRA => "雙首暴龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HYDREIGON:
					return lang switch {
						Language.ENG => "Hydreigon",
						Language.JPN => "サザンドラ",
						Language.GER => "Trikephalo",
						Language.FRE => "Trioxhydre",
						Language.ITA => "Hydreigon",
						Language.SPN => "Hydreigon",
						Language.KOR => "삼삼드래",
						Language.CHN_SIM => "三首恶龙",
						Language.CHN_TRA => "三首惡龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LARVESTA:
					return lang switch {
						Language.ENG => "Larvesta",
						Language.JPN => "メラルバ",
						Language.GER => "Ignivor",
						Language.FRE => "Pyronille",
						Language.ITA => "Larvesta",
						Language.SPN => "Larvesta",
						Language.KOR => "활화르바",
						Language.CHN_SIM => "燃烧虫",
						Language.CHN_TRA => "燃燒蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VOLCARONA:
					return lang switch {
						Language.ENG => "Volcarona",
						Language.JPN => "ウルガモス",
						Language.GER => "Ramoth",
						Language.FRE => "Pyrax",
						Language.ITA => "Volcarona",
						Language.SPN => "Volcarona",
						Language.KOR => "불카모스",
						Language.CHN_SIM => "火神蛾",
						Language.CHN_TRA => "火神蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COBALION:
					return lang switch {
						Language.ENG => "Cobalion",
						Language.JPN => "コバルオン",
						Language.GER => "Kobalium",
						Language.FRE => "Cobaltium",
						Language.ITA => "Cobalion",
						Language.SPN => "Cobalion",
						Language.KOR => "코바르온",
						Language.CHN_SIM => "勾帕路翁",
						Language.CHN_TRA => "勾帕路翁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TERRAKION:
					return lang switch {
						Language.ENG => "Terrakion",
						Language.JPN => "テラキオン",
						Language.GER => "Terrakium",
						Language.FRE => "Terrakium",
						Language.ITA => "Terrakion",
						Language.SPN => "Terrakion",
						Language.KOR => "테라키온",
						Language.CHN_SIM => "代拉基翁",
						Language.CHN_TRA => "代拉基翁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VIRIZION:
					return lang switch {
						Language.ENG => "Virizion",
						Language.JPN => "ビリジオン",
						Language.GER => "Viridium",
						Language.FRE => "Viridium",
						Language.ITA => "Virizion",
						Language.SPN => "Virizion",
						Language.KOR => "비리디온",
						Language.CHN_SIM => "毕力吉翁",
						Language.CHN_TRA => "畢力吉翁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TORNADUS_INCARNATE_FORME:
					return lang switch {
						Language.ENG => "Tornadus",
						Language.JPN => "トルネロス",
						Language.GER => "Boreos",
						Language.FRE => "Boréas",
						Language.ITA => "Tornadus",
						Language.SPN => "Tornadus",
						Language.KOR => "토네로스",
						Language.CHN_SIM => "龙卷云",
						Language.CHN_TRA => "龍捲雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TORNADUS_THERIAN_FORME:
					return lang switch {
						Language.ENG => "Tornadus",
						Language.JPN => "トルネロス",
						Language.GER => "Boreos",
						Language.FRE => "Boréas",
						Language.ITA => "Tornadus",
						Language.SPN => "Tornadus",
						Language.KOR => "토네로스",
						Language.CHN_SIM => "龙卷云",
						Language.CHN_TRA => "龍捲雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.THUNDURUS_INCARNATE_FORME:
					return lang switch {
						Language.ENG => "Thundurus",
						Language.JPN => "ボルトロス",
						Language.GER => "Voltolos",
						Language.FRE => "Fulguris",
						Language.ITA => "Thundurus",
						Language.SPN => "Thundurus",
						Language.KOR => "볼트로스",
						Language.CHN_SIM => "雷电云",
						Language.CHN_TRA => "雷電雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.THUNDURUS_THERIAN_FORME:
					return lang switch {
						Language.ENG => "Thundurus",
						Language.JPN => "ボルトロス",
						Language.GER => "Voltolos",
						Language.FRE => "Fulguris",
						Language.ITA => "Thundurus",
						Language.SPN => "Thundurus",
						Language.KOR => "볼트로스",
						Language.CHN_SIM => "雷电云",
						Language.CHN_TRA => "雷電雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RESHIRAM:
					return lang switch {
						Language.ENG => "Reshiram",
						Language.JPN => "レシラム",
						Language.GER => "Reshiram",
						Language.FRE => "Reshiram",
						Language.ITA => "Reshiram",
						Language.SPN => "Reshiram",
						Language.KOR => "레시라무",
						Language.CHN_SIM => "莱希拉姆",
						Language.CHN_TRA => "萊希拉姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZEKROM:
					return lang switch {
						Language.ENG => "Zekrom",
						Language.JPN => "ゼクロム",
						Language.GER => "Zekrom",
						Language.FRE => "Zekrom",
						Language.ITA => "Zekrom",
						Language.SPN => "Zekrom",
						Language.KOR => "제크로무",
						Language.CHN_SIM => "捷克罗姆",
						Language.CHN_TRA => "捷克羅姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LANDORUS_INCARNATE_FORME:
					return lang switch {
						Language.ENG => "Landorus",
						Language.JPN => "ランドロス",
						Language.GER => "Demeteros",
						Language.FRE => "Démétéros",
						Language.ITA => "Landorus",
						Language.SPN => "Landorus",
						Language.KOR => "랜드로스",
						Language.CHN_SIM => "土地云",
						Language.CHN_TRA => "土地雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LANDORUS_THERIAN_FORME:
					return lang switch {
						Language.ENG => "Landorus",
						Language.JPN => "ランドロス",
						Language.GER => "Demeteros",
						Language.FRE => "Démétéros",
						Language.ITA => "Landorus",
						Language.SPN => "Landorus",
						Language.KOR => "랜드로스",
						Language.CHN_SIM => "土地云",
						Language.CHN_TRA => "土地雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KYUREM:
					return lang switch {
						Language.ENG => "Kyurem",
						Language.JPN => "キュレム",
						Language.GER => "Kyurem",
						Language.FRE => "Kyurem",
						Language.ITA => "Kyurem",
						Language.SPN => "Kyurem",
						Language.KOR => "큐레무",
						Language.CHN_SIM => "酋雷姆",
						Language.CHN_TRA => "酋雷姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KYUREM_WHITE_KYUREM:
					return lang switch {
						Language.ENG => "Kyurem",
						Language.JPN => "キュレム",
						Language.GER => "Kyurem",
						Language.FRE => "Kyurem",
						Language.ITA => "Kyurem",
						Language.SPN => "Kyurem",
						Language.KOR => "큐레무",
						Language.CHN_SIM => "酋雷姆",
						Language.CHN_TRA => "酋雷姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KYUREM_BLACK_KYUREM:
					return lang switch {
						Language.ENG => "Kyurem",
						Language.JPN => "キュレム",
						Language.GER => "Kyurem",
						Language.FRE => "Kyurem",
						Language.ITA => "Kyurem",
						Language.SPN => "Kyurem",
						Language.KOR => "큐레무",
						Language.CHN_SIM => "酋雷姆",
						Language.CHN_TRA => "酋雷姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KELDEO_ORDINARY_FORM:
					return lang switch {
						Language.ENG => "Keldeo",
						Language.JPN => "ケルディオ",
						Language.GER => "Keldeo",
						Language.FRE => "Keldeo",
						Language.ITA => "Keldeo",
						Language.SPN => "Keldeo",
						Language.KOR => "케르디오",
						Language.CHN_SIM => "凯路迪欧",
						Language.CHN_TRA => "凱路迪歐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KELDEO_RESOLUTE_FORM:
					return lang switch {
						Language.ENG => "Keldeo",
						Language.JPN => "ケルディオ",
						Language.GER => "Keldeo",
						Language.FRE => "Keldeo",
						Language.ITA => "Keldeo",
						Language.SPN => "Keldeo",
						Language.KOR => "케르디오",
						Language.CHN_SIM => "凯路迪欧",
						Language.CHN_TRA => "凱路迪歐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MELOETTA_ARIA_FORME:
					return lang switch {
						Language.ENG => "Meloetta",
						Language.JPN => "メロエッタ",
						Language.GER => "Meloetta",
						Language.FRE => "Meloetta",
						Language.ITA => "Meloetta",
						Language.SPN => "Meloetta",
						Language.KOR => "메로엣타",
						Language.CHN_SIM => "美洛耶塔",
						Language.CHN_TRA => "美洛耶塔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MELOETTA_PIROUETTE_FORME:
					return lang switch {
						Language.ENG => "Meloetta",
						Language.JPN => "メロエッタ",
						Language.GER => "Meloetta",
						Language.FRE => "Meloetta",
						Language.ITA => "Meloetta",
						Language.SPN => "Meloetta",
						Language.KOR => "메로엣타",
						Language.CHN_SIM => "美洛耶塔",
						Language.CHN_TRA => "美洛耶塔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GENESECT:
					return lang switch {
						Language.ENG => "Genesect",
						Language.JPN => "ゲノセクト",
						Language.GER => "Genesect",
						Language.FRE => "Genesect",
						Language.ITA => "Genesect",
						Language.SPN => "Genesect",
						Language.KOR => "게노세크트",
						Language.CHN_SIM => "盖诺赛克特",
						Language.CHN_TRA => "蓋諾賽克特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHESPIN:
					return lang switch {
						Language.ENG => "Chespin",
						Language.JPN => "ハリマロン",
						Language.GER => "Igamaro",
						Language.FRE => "Marisson",
						Language.ITA => "Chespin",
						Language.SPN => "Chespin",
						Language.KOR => "도치마론",
						Language.CHN_SIM => "哈力栗",
						Language.CHN_TRA => "哈力栗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QUILLADIN:
					return lang switch {
						Language.ENG => "Quilladin",
						Language.JPN => "ハリボーグ",
						Language.GER => "Igastarnish",
						Language.FRE => "Boguérisse",
						Language.ITA => "Quilladin",
						Language.SPN => "Quilladin",
						Language.KOR => "도치보구",
						Language.CHN_SIM => "胖胖哈力",
						Language.CHN_TRA => "胖胖哈力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHESNAUGHT:
					return lang switch {
						Language.ENG => "Chesnaught",
						Language.JPN => "ブリガロン",
						Language.GER => "Brigaron",
						Language.FRE => "Blindépique",
						Language.ITA => "Chesnaught",
						Language.SPN => "Chesnaught",
						Language.KOR => "브리가론",
						Language.CHN_SIM => "布里卡隆",
						Language.CHN_TRA => "布里卡隆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FENNEKIN:
					return lang switch {
						Language.ENG => "Fennekin",
						Language.JPN => "フォッコ",
						Language.GER => "Fynx",
						Language.FRE => "Feunnec",
						Language.ITA => "Fennekin",
						Language.SPN => "Fennekin",
						Language.KOR => "푸호꼬",
						Language.CHN_SIM => "火狐狸",
						Language.CHN_TRA => "火狐狸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRAIXEN:
					return lang switch {
						Language.ENG => "Braixen",
						Language.JPN => "テールナー",
						Language.GER => "Rutena",
						Language.FRE => "Roussil",
						Language.ITA => "Braixen",
						Language.SPN => "Braixen",
						Language.KOR => "테르나",
						Language.CHN_SIM => "长尾火狐",
						Language.CHN_TRA => "長尾火狐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DELPHOX:
					return lang switch {
						Language.ENG => "Delphox",
						Language.JPN => "マフォクシー",
						Language.GER => "Fennexis",
						Language.FRE => "Goupelin",
						Language.ITA => "Delphox",
						Language.SPN => "Delphox",
						Language.KOR => "마폭시",
						Language.CHN_SIM => "妖火红狐",
						Language.CHN_TRA => "妖火紅狐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FROAKIE:
					return lang switch {
						Language.ENG => "Froakie",
						Language.JPN => "ケロマツ",
						Language.GER => "Froxy",
						Language.FRE => "Grenousse",
						Language.ITA => "Froakie",
						Language.SPN => "Froakie",
						Language.KOR => "개구마르",
						Language.CHN_SIM => "呱呱泡蛙",
						Language.CHN_TRA => "呱呱泡蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FROGADIER:
					return lang switch {
						Language.ENG => "Frogadier",
						Language.JPN => "ゲコガシラ",
						Language.GER => "Amphizel",
						Language.FRE => "Croâporal",
						Language.ITA => "Frogadier",
						Language.SPN => "Frogadier",
						Language.KOR => "개굴반장",
						Language.CHN_SIM => "呱头蛙",
						Language.CHN_TRA => "呱頭蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRENINJA:
					return lang switch {
						Language.ENG => "Greninja",
						Language.JPN => "ゲッコウガ",
						Language.GER => "Quajutsu",
						Language.FRE => "Amphinobi",
						Language.ITA => "Greninja",
						Language.SPN => "Greninja",
						Language.KOR => "개굴닌자",
						Language.CHN_SIM => "甲贺忍蛙",
						Language.CHN_TRA => "甲賀忍蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRENINJA_ASH_GRENINJA:
					return lang switch {
						Language.ENG => "Greninja",
						Language.JPN => "ゲッコウガ",
						Language.GER => "Quajutsu",
						Language.FRE => "Amphinobi",
						Language.ITA => "Greninja",
						Language.SPN => "Greninja",
						Language.KOR => "개굴닌자",
						Language.CHN_SIM => "甲贺忍蛙",
						Language.CHN_TRA => "甲賀忍蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BUNNELBY:
					return lang switch {
						Language.ENG => "Bunnelby",
						Language.JPN => "ホルビー",
						Language.GER => "Scoppel",
						Language.FRE => "Sapereau",
						Language.ITA => "Bunnelby",
						Language.SPN => "Bunnelby",
						Language.KOR => "파르빗",
						Language.CHN_SIM => "掘掘兔",
						Language.CHN_TRA => "掘掘兔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIGGERSBY:
					return lang switch {
						Language.ENG => "Diggersby",
						Language.JPN => "ホルード",
						Language.GER => "Grebbit",
						Language.FRE => "Excavarenne",
						Language.ITA => "Diggersby",
						Language.SPN => "Diggersby",
						Language.KOR => "파르토",
						Language.CHN_SIM => "掘地兔",
						Language.CHN_TRA => "掘地兔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLETCHLING:
					return lang switch {
						Language.ENG => "Fletchling",
						Language.JPN => "ヤヤコマ",
						Language.GER => "Dartiri",
						Language.FRE => "Passerouge",
						Language.ITA => "Fletchling",
						Language.SPN => "Fletchling",
						Language.KOR => "화살꼬빈",
						Language.CHN_SIM => "小箭雀",
						Language.CHN_TRA => "小箭雀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLETCHINDER:
					return lang switch {
						Language.ENG => "Fletchinder",
						Language.JPN => "ヒノヤコマ",
						Language.GER => "Dartignis",
						Language.FRE => "Braisillon",
						Language.ITA => "Fletchinder",
						Language.SPN => "Fletchinder",
						Language.KOR => "불화살빈",
						Language.CHN_SIM => "火箭雀",
						Language.CHN_TRA => "火箭雀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TALONFLAME:
					return lang switch {
						Language.ENG => "Talonflame",
						Language.JPN => "ファイアロー",
						Language.GER => "Fiaro",
						Language.FRE => "Flambusard",
						Language.ITA => "Talonflame",
						Language.SPN => "Talonflame",
						Language.KOR => "파이어로",
						Language.CHN_SIM => "烈箭鹰",
						Language.CHN_TRA => "烈箭鷹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCATTERBUG:
					return lang switch {
						Language.ENG => "Scatterbug",
						Language.JPN => "コフキムシ",
						Language.GER => "Purmel",
						Language.FRE => "Lépidonille",
						Language.ITA => "Scatterbug",
						Language.SPN => "Scatterbug",
						Language.KOR => "분이벌레",
						Language.CHN_SIM => "粉蝶虫",
						Language.CHN_TRA => "粉蝶蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPEWPA:
					return lang switch {
						Language.ENG => "Spewpa",
						Language.JPN => "コフーライ",
						Language.GER => "Puponcho",
						Language.FRE => "Pérégrain",
						Language.ITA => "Spewpa",
						Language.SPN => "Spewpa",
						Language.KOR => "분떠도리",
						Language.CHN_SIM => "粉蝶蛹",
						Language.CHN_TRA => "粉蝶蛹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VIVILLON:
					return lang switch {
						Language.ENG => "Vivillon",
						Language.JPN => "ビビヨン",
						Language.GER => "Vivillon",
						Language.FRE => "Prismillon",
						Language.ITA => "Vivillon",
						Language.SPN => "Vivillon",
						Language.KOR => "비비용",
						Language.CHN_SIM => "彩粉蝶",
						Language.CHN_TRA => "彩粉蝶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LITLEO:
					return lang switch {
						Language.ENG => "Litleo",
						Language.JPN => "シシコ",
						Language.GER => "Leufeo",
						Language.FRE => "Hélionceau",
						Language.ITA => "Litleo",
						Language.SPN => "Litleo",
						Language.KOR => "레오꼬",
						Language.CHN_SIM => "小狮狮",
						Language.CHN_TRA => "小獅獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PYROAR:
					return lang switch {
						Language.ENG => "Pyroar",
						Language.JPN => "カエンジシ",
						Language.GER => "Pyroleo",
						Language.FRE => "Némélios",
						Language.ITA => "Pyroar",
						Language.SPN => "Pyroar",
						Language.KOR => "화염레오",
						Language.CHN_SIM => "火炎狮",
						Language.CHN_TRA => "火炎獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLAB_B_:
					return lang switch {
						Language.ENG => "Flabébé",
						Language.JPN => "フラベベ",
						Language.GER => "Flabébé",
						Language.FRE => "Flabébé",
						Language.ITA => "Flabébé",
						Language.SPN => "Flabébé",
						Language.KOR => "플라베베",
						Language.CHN_SIM => "花蓓蓓",
						Language.CHN_TRA => "花蓓蓓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLOETTE:
					return lang switch {
						Language.ENG => "Floette",
						Language.JPN => "フラエッテ",
						Language.GER => "Floette",
						Language.FRE => "Floette",
						Language.ITA => "Floette",
						Language.SPN => "Floette",
						Language.KOR => "플라엣테",
						Language.CHN_SIM => "花叶蒂",
						Language.CHN_TRA => "花葉蒂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLORGES:
					return lang switch {
						Language.ENG => "Florges",
						Language.JPN => "フラージェス",
						Language.GER => "Florges",
						Language.FRE => "Florges",
						Language.ITA => "Florges",
						Language.SPN => "Florges",
						Language.KOR => "플라제스",
						Language.CHN_SIM => "花洁夫人",
						Language.CHN_TRA => "花潔夫人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKIDDO:
					return lang switch {
						Language.ENG => "Skiddo",
						Language.JPN => "メェークル",
						Language.GER => "Mähikel",
						Language.FRE => "Cabriolaine",
						Language.ITA => "Skiddo",
						Language.SPN => "Skiddo",
						Language.KOR => "메이클",
						Language.CHN_SIM => "坐骑小羊",
						Language.CHN_TRA => "坐騎小羊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOGOAT:
					return lang switch {
						Language.ENG => "Gogoat",
						Language.JPN => "ゴーゴート",
						Language.GER => "Chevrumm",
						Language.FRE => "Chevroum",
						Language.ITA => "Gogoat",
						Language.SPN => "Gogoat",
						Language.KOR => "고고트",
						Language.CHN_SIM => "坐骑山羊",
						Language.CHN_TRA => "坐騎山羊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PANCHAM:
					return lang switch {
						Language.ENG => "Pancham",
						Language.JPN => "ヤンチャム",
						Language.GER => "Pam-Pam",
						Language.FRE => "Pandespiègle",
						Language.ITA => "Pancham",
						Language.SPN => "Pancham",
						Language.KOR => "판짱",
						Language.CHN_SIM => "顽皮熊猫",
						Language.CHN_TRA => "頑皮熊貓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PANGORO:
					return lang switch {
						Language.ENG => "Pangoro",
						Language.JPN => "ゴロンダ",
						Language.GER => "Pandagro",
						Language.FRE => "Pandarbare",
						Language.ITA => "Pangoro",
						Language.SPN => "Pangoro",
						Language.KOR => "부란다",
						Language.CHN_SIM => "霸道熊猫",
						Language.CHN_TRA => "流氓熊貓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FURFROU:
					return lang switch {
						Language.ENG => "Furfrou",
						Language.JPN => "トリミアン",
						Language.GER => "Coiffwaff",
						Language.FRE => "Couafarel",
						Language.ITA => "Furfrou",
						Language.SPN => "Furfrou",
						Language.KOR => "트리미앙",
						Language.CHN_SIM => "多丽米亚",
						Language.CHN_TRA => "多麗米亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ESPURR:
					return lang switch {
						Language.ENG => "Espurr",
						Language.JPN => "ニャスパー",
						Language.GER => "Psiau",
						Language.FRE => "Psystigri",
						Language.ITA => "Espurr",
						Language.SPN => "Espurr",
						Language.KOR => "냐스퍼",
						Language.CHN_SIM => "妙喵",
						Language.CHN_TRA => "妙喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEOWSTIC_MALE:
					return lang switch {
						Language.ENG => "Meowstic",
						Language.JPN => "ニャオニクス",
						Language.GER => "Psiaugon",
						Language.FRE => "Mistigrix",
						Language.ITA => "Meowstic",
						Language.SPN => "Meowstic",
						Language.KOR => "냐오닉스",
						Language.CHN_SIM => "超能妙喵",
						Language.CHN_TRA => "超能妙喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEOWSTIC_FEMALE:
					return lang switch {
						Language.ENG => "Meowstic",
						Language.JPN => "ニャオニクス",
						Language.GER => "Psiaugon",
						Language.FRE => "Mistigrix",
						Language.ITA => "Meowstic",
						Language.SPN => "Meowstic",
						Language.KOR => "냐오닉스",
						Language.CHN_SIM => "超能妙喵",
						Language.CHN_TRA => "超能妙喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HONEDGE:
					return lang switch {
						Language.ENG => "Honedge",
						Language.JPN => "ヒトツキ",
						Language.GER => "Gramokles",
						Language.FRE => "Monorpale",
						Language.ITA => "Honedge",
						Language.SPN => "Honedge",
						Language.KOR => "단칼빙",
						Language.CHN_SIM => "独剑鞘",
						Language.CHN_TRA => "獨劍鞘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DOUBLADE:
					return lang switch {
						Language.ENG => "Doublade",
						Language.JPN => "ニダンギル",
						Language.GER => "Duokles",
						Language.FRE => "Dimoclès",
						Language.ITA => "Doublade",
						Language.SPN => "Doublade",
						Language.KOR => "쌍검킬",
						Language.CHN_SIM => "双剑鞘",
						Language.CHN_TRA => "雙劍鞘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AEGISLASH_SHIELD_FORME:
					return lang switch {
						Language.ENG => "Aegislash",
						Language.JPN => "ギルガルド",
						Language.GER => "Durengard",
						Language.FRE => "Exagide",
						Language.ITA => "Aegislash",
						Language.SPN => "Aegislash",
						Language.KOR => "킬가르도",
						Language.CHN_SIM => "坚盾剑怪",
						Language.CHN_TRA => "堅盾劍怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AEGISLASH_BLADE_FORME:
					return lang switch {
						Language.ENG => "Aegislash",
						Language.JPN => "ギルガルド",
						Language.GER => "Durengard",
						Language.FRE => "Exagide",
						Language.ITA => "Aegislash",
						Language.SPN => "Aegislash",
						Language.KOR => "킬가르도",
						Language.CHN_SIM => "坚盾剑怪",
						Language.CHN_TRA => "堅盾劍怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPRITZEE:
					return lang switch {
						Language.ENG => "Spritzee",
						Language.JPN => "シュシュプ",
						Language.GER => "Parfi",
						Language.FRE => "Fluvetin",
						Language.ITA => "Spritzee",
						Language.SPN => "Spritzee",
						Language.KOR => "슈쁘",
						Language.CHN_SIM => "粉香香",
						Language.CHN_TRA => "粉香香",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AROMATISSE:
					return lang switch {
						Language.ENG => "Aromatisse",
						Language.JPN => "フレフワン",
						Language.GER => "Parfinesse",
						Language.FRE => "Cocotine",
						Language.ITA => "Aromatisse",
						Language.SPN => "Aromatisse",
						Language.KOR => "프레프티르",
						Language.CHN_SIM => "芳香精",
						Language.CHN_TRA => "芳香精",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SWIRLIX:
					return lang switch {
						Language.ENG => "Swirlix",
						Language.JPN => "ペロッパフ",
						Language.GER => "Flauschling",
						Language.FRE => "Sucroquin",
						Language.ITA => "Swirlix",
						Language.SPN => "Swirlix",
						Language.KOR => "나룸퍼프",
						Language.CHN_SIM => "绵绵泡芙",
						Language.CHN_TRA => "綿綿泡芙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLURPUFF:
					return lang switch {
						Language.ENG => "Slurpuff",
						Language.JPN => "ペロリーム",
						Language.GER => "Sabbaione",
						Language.FRE => "Cupcanaille",
						Language.ITA => "Slurpuff",
						Language.SPN => "Slurpuff",
						Language.KOR => "나루림",
						Language.CHN_SIM => "胖甜妮",
						Language.CHN_TRA => "胖甜妮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.INKAY:
					return lang switch {
						Language.ENG => "Inkay",
						Language.JPN => "マーイーカ",
						Language.GER => "Iscalar",
						Language.FRE => "Sepiatop",
						Language.ITA => "Inkay",
						Language.SPN => "Inkay",
						Language.KOR => "오케이징",
						Language.CHN_SIM => "好啦鱿",
						Language.CHN_TRA => "好啦魷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MALAMAR:
					return lang switch {
						Language.ENG => "Malamar",
						Language.JPN => "カラマネロ",
						Language.GER => "Calamanero",
						Language.FRE => "Sepiatroce",
						Language.ITA => "Malamar",
						Language.SPN => "Malamar",
						Language.KOR => "칼라마네로",
						Language.CHN_SIM => "乌贼王",
						Language.CHN_TRA => "烏賊王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BINACLE:
					return lang switch {
						Language.ENG => "Binacle",
						Language.JPN => "カメテテ",
						Language.GER => "Bithora",
						Language.FRE => "Opermine",
						Language.ITA => "Binacle",
						Language.SPN => "Binacle",
						Language.KOR => "거북손손",
						Language.CHN_SIM => "龟脚脚",
						Language.CHN_TRA => "龜腳腳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BARBARACLE:
					return lang switch {
						Language.ENG => "Barbaracle",
						Language.JPN => "ガメノデス",
						Language.GER => "Thanathora",
						Language.FRE => "Golgopathe",
						Language.ITA => "Barbaracle",
						Language.SPN => "Barbaracle",
						Language.KOR => "거북손데스",
						Language.CHN_SIM => "龟足巨铠",
						Language.CHN_TRA => "龜足巨鎧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKRELP:
					return lang switch {
						Language.ENG => "Skrelp",
						Language.JPN => "クズモー",
						Language.GER => "Algitt",
						Language.FRE => "Venalgue",
						Language.ITA => "Skrelp",
						Language.SPN => "Skrelp",
						Language.KOR => "수레기",
						Language.CHN_SIM => "垃垃藻",
						Language.CHN_TRA => "垃垃藻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAGALGE:
					return lang switch {
						Language.ENG => "Dragalge",
						Language.JPN => "ドラミドロ",
						Language.GER => "Tandrak",
						Language.FRE => "Kravarech",
						Language.ITA => "Dragalge",
						Language.SPN => "Dragalge",
						Language.KOR => "드래캄",
						Language.CHN_SIM => "毒藻龙",
						Language.CHN_TRA => "毒藻龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLAUNCHER:
					return lang switch {
						Language.ENG => "Clauncher",
						Language.JPN => "ウデッポウ",
						Language.GER => "Scampisto",
						Language.FRE => "Flingouste",
						Language.ITA => "Clauncher",
						Language.SPN => "Clauncher",
						Language.KOR => "완철포",
						Language.CHN_SIM => "铁臂枪虾",
						Language.CHN_TRA => "鐵臂槍蝦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLAWITZER:
					return lang switch {
						Language.ENG => "Clawitzer",
						Language.JPN => "ブロスター",
						Language.GER => "Wummer",
						Language.FRE => "Gamblast",
						Language.ITA => "Clawitzer",
						Language.SPN => "Clawitzer",
						Language.KOR => "블로스터",
						Language.CHN_SIM => "钢炮臂虾",
						Language.CHN_TRA => "鋼炮臂蝦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HELIOPTILE:
					return lang switch {
						Language.ENG => "Helioptile",
						Language.JPN => "エリキテル",
						Language.GER => "Eguana",
						Language.FRE => "Galvaran",
						Language.ITA => "Helioptile",
						Language.SPN => "Helioptile",
						Language.KOR => "목도리키텔",
						Language.CHN_SIM => "伞电蜥",
						Language.CHN_TRA => "傘電蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HELIOLISK:
					return lang switch {
						Language.ENG => "Heliolisk",
						Language.JPN => "エレザード",
						Language.GER => "Elezard",
						Language.FRE => "Iguolta",
						Language.ITA => "Heliolisk",
						Language.SPN => "Heliolisk",
						Language.KOR => "일레도리자드",
						Language.CHN_SIM => "光电伞蜥",
						Language.CHN_TRA => "光電傘蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYRUNT:
					return lang switch {
						Language.ENG => "Tyrunt",
						Language.JPN => "チゴラス",
						Language.GER => "Balgoras",
						Language.FRE => "Ptyranidur",
						Language.ITA => "Tyrunt",
						Language.SPN => "Tyrunt",
						Language.KOR => "티고라스",
						Language.CHN_SIM => "宝宝暴龙",
						Language.CHN_TRA => "寶寶暴龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYRANTRUM:
					return lang switch {
						Language.ENG => "Tyrantrum",
						Language.JPN => "ガチゴラス",
						Language.GER => "Monargoras",
						Language.FRE => "Rexillius",
						Language.ITA => "Tyrantrum",
						Language.SPN => "Tyrantrum",
						Language.KOR => "견고라스",
						Language.CHN_SIM => "怪颚龙",
						Language.CHN_TRA => "怪顎龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AMAURA:
					return lang switch {
						Language.ENG => "Amaura",
						Language.JPN => "アマルス",
						Language.GER => "Amarino",
						Language.FRE => "Amagara",
						Language.ITA => "Amaura",
						Language.SPN => "Amaura",
						Language.KOR => "아마루스",
						Language.CHN_SIM => "冰雪龙",
						Language.CHN_TRA => "冰雪龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AURORUS:
					return lang switch {
						Language.ENG => "Aurorus",
						Language.JPN => "アマルルガ",
						Language.GER => "Amagarga",
						Language.FRE => "Dragmara",
						Language.ITA => "Aurorus",
						Language.SPN => "Aurorus",
						Language.KOR => "아마루르가",
						Language.CHN_SIM => "冰雪巨龙",
						Language.CHN_TRA => "冰雪巨龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SYLVEON:
					return lang switch {
						Language.ENG => "Sylveon",
						Language.JPN => "ニンフィア",
						Language.GER => "Feelinara",
						Language.FRE => "Nymphali",
						Language.ITA => "Sylveon",
						Language.SPN => "Sylveon",
						Language.KOR => "님피아",
						Language.CHN_SIM => "仙子伊布",
						Language.CHN_TRA => "仙子伊布",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HAWLUCHA:
					return lang switch {
						Language.ENG => "Hawlucha",
						Language.JPN => "ルチャブル",
						Language.GER => "Resladero",
						Language.FRE => "Brutalibré",
						Language.ITA => "Hawlucha",
						Language.SPN => "Hawlucha",
						Language.KOR => "루차불",
						Language.CHN_SIM => "摔角鹰人",
						Language.CHN_TRA => "摔角鷹人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEDENNE:
					return lang switch {
						Language.ENG => "Dedenne",
						Language.JPN => "デデンネ",
						Language.GER => "Dedenne",
						Language.FRE => "Dedenne",
						Language.ITA => "Dedenne",
						Language.SPN => "Dedenne",
						Language.KOR => "데덴네",
						Language.CHN_SIM => "咚咚鼠",
						Language.CHN_TRA => "咚咚鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CARBINK:
					return lang switch {
						Language.ENG => "Carbink",
						Language.JPN => "メレシー",
						Language.GER => "Rocara",
						Language.FRE => "Strassie",
						Language.ITA => "Carbink",
						Language.SPN => "Carbink",
						Language.KOR => "멜리시",
						Language.CHN_SIM => "小碎钻",
						Language.CHN_TRA => "小碎鑽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOOMY:
					return lang switch {
						Language.ENG => "Goomy",
						Language.JPN => "ヌメラ",
						Language.GER => "Viscora",
						Language.FRE => "Mucuscule",
						Language.ITA => "Goomy",
						Language.SPN => "Goomy",
						Language.KOR => "미끄메라",
						Language.CHN_SIM => "黏黏宝",
						Language.CHN_TRA => "黏黏寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLIGGOO:
					return lang switch {
						Language.ENG => "Sliggoo",
						Language.JPN => "ヌメイル",
						Language.GER => "Viscargot",
						Language.FRE => "Colimucus",
						Language.ITA => "Sliggoo",
						Language.SPN => "Sliggoo",
						Language.KOR => "미끄네일",
						Language.CHN_SIM => "黏美儿",
						Language.CHN_TRA => "黏美兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLIGGOO_HISUIAN_SLIGGOO:
					return lang switch {
						Language.ENG => "Sliggoo",
						Language.JPN => "ヌメイル",
						Language.GER => "Viscargot",
						Language.FRE => "Colimucus",
						Language.ITA => "Sliggoo",
						Language.SPN => "Sliggoo",
						Language.KOR => "미끄네일",
						Language.CHN_SIM => "黏美儿",
						Language.CHN_TRA => "黏美兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOODRA:
					return lang switch {
						Language.ENG => "Goodra",
						Language.JPN => "ヌメルゴン",
						Language.GER => "Viscogon",
						Language.FRE => "Muplodocus",
						Language.ITA => "Goodra",
						Language.SPN => "Goodra",
						Language.KOR => "미끄래곤",
						Language.CHN_SIM => "黏美龙",
						Language.CHN_TRA => "黏美龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOODRA_HISUIAN_GOODRA:
					return lang switch {
						Language.ENG => "Goodra",
						Language.JPN => "ヌメルゴン",
						Language.GER => "Viscogon",
						Language.FRE => "Muplodocus",
						Language.ITA => "Goodra",
						Language.SPN => "Goodra",
						Language.KOR => "미끄래곤",
						Language.CHN_SIM => "黏美龙",
						Language.CHN_TRA => "黏美龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KLEFKI:
					return lang switch {
						Language.ENG => "Klefki",
						Language.JPN => "クレッフィ",
						Language.GER => "Clavion",
						Language.FRE => "Trousselin",
						Language.ITA => "Klefki",
						Language.SPN => "Klefki",
						Language.KOR => "클레피",
						Language.CHN_SIM => "钥圈儿",
						Language.CHN_TRA => "鑰圈兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PHANTUMP:
					return lang switch {
						Language.ENG => "Phantump",
						Language.JPN => "ボクレー",
						Language.GER => "Paragoni",
						Language.FRE => "Brocélôme",
						Language.ITA => "Phantump",
						Language.SPN => "Phantump",
						Language.KOR => "나목령",
						Language.CHN_SIM => "小木灵",
						Language.CHN_TRA => "小木靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TREVENANT:
					return lang switch {
						Language.ENG => "Trevenant",
						Language.JPN => "オーロット",
						Language.GER => "Trombork",
						Language.FRE => "Desséliande",
						Language.ITA => "Trevenant",
						Language.SPN => "Trevenant",
						Language.KOR => "대로트",
						Language.CHN_SIM => "朽木妖",
						Language.CHN_TRA => "朽木妖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PUMPKABOO_AVERAGE_SIZE:
					return lang switch {
						Language.ENG => "Pumpkaboo",
						Language.JPN => "バケッチャ",
						Language.GER => "Irrbis",
						Language.FRE => "Pitrouille",
						Language.ITA => "Pumpkaboo",
						Language.SPN => "Pumpkaboo",
						Language.KOR => "호바귀",
						Language.CHN_SIM => "南瓜精",
						Language.CHN_TRA => "南瓜精",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PUMPKABOO_SMALL_SIZE:
					return lang switch {
						Language.ENG => "Pumpkaboo",
						Language.JPN => "バケッチャ",
						Language.GER => "Irrbis",
						Language.FRE => "Pitrouille",
						Language.ITA => "Pumpkaboo",
						Language.SPN => "Pumpkaboo",
						Language.KOR => "호바귀",
						Language.CHN_SIM => "南瓜精",
						Language.CHN_TRA => "南瓜精",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PUMPKABOO_LARGE_SIZE:
					return lang switch {
						Language.ENG => "Pumpkaboo",
						Language.JPN => "バケッチャ",
						Language.GER => "Irrbis",
						Language.FRE => "Pitrouille",
						Language.ITA => "Pumpkaboo",
						Language.SPN => "Pumpkaboo",
						Language.KOR => "호바귀",
						Language.CHN_SIM => "南瓜精",
						Language.CHN_TRA => "南瓜精",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PUMPKABOO_SUPER_SIZE:
					return lang switch {
						Language.ENG => "Pumpkaboo",
						Language.JPN => "バケッチャ",
						Language.GER => "Irrbis",
						Language.FRE => "Pitrouille",
						Language.ITA => "Pumpkaboo",
						Language.SPN => "Pumpkaboo",
						Language.KOR => "호바귀",
						Language.CHN_SIM => "南瓜精",
						Language.CHN_TRA => "南瓜精",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOURGEIST_AVERAGE_SIZE:
					return lang switch {
						Language.ENG => "Gourgeist",
						Language.JPN => "パンプジン",
						Language.GER => "Pumpdjinn",
						Language.FRE => "Banshitrouye",
						Language.ITA => "Gourgeist",
						Language.SPN => "Gourgeist",
						Language.KOR => "펌킨인",
						Language.CHN_SIM => "南瓜怪人",
						Language.CHN_TRA => "南瓜怪人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOURGEIST_SMALL_SIZE:
					return lang switch {
						Language.ENG => "Gourgeist",
						Language.JPN => "パンプジン",
						Language.GER => "Pumpdjinn",
						Language.FRE => "Banshitrouye",
						Language.ITA => "Gourgeist",
						Language.SPN => "Gourgeist",
						Language.KOR => "펌킨인",
						Language.CHN_SIM => "南瓜怪人",
						Language.CHN_TRA => "南瓜怪人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOURGEIST_LARGE_SIZE:
					return lang switch {
						Language.ENG => "Gourgeist",
						Language.JPN => "パンプジン",
						Language.GER => "Pumpdjinn",
						Language.FRE => "Banshitrouye",
						Language.ITA => "Gourgeist",
						Language.SPN => "Gourgeist",
						Language.KOR => "펌킨인",
						Language.CHN_SIM => "南瓜怪人",
						Language.CHN_TRA => "南瓜怪人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOURGEIST_SUPER_SIZE:
					return lang switch {
						Language.ENG => "Gourgeist",
						Language.JPN => "パンプジン",
						Language.GER => "Pumpdjinn",
						Language.FRE => "Banshitrouye",
						Language.ITA => "Gourgeist",
						Language.SPN => "Gourgeist",
						Language.KOR => "펌킨인",
						Language.CHN_SIM => "南瓜怪人",
						Language.CHN_TRA => "南瓜怪人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BERGMITE:
					return lang switch {
						Language.ENG => "Bergmite",
						Language.JPN => "カチコール",
						Language.GER => "Arktip",
						Language.FRE => "Grelaçon",
						Language.ITA => "Bergmite",
						Language.SPN => "Bergmite",
						Language.KOR => "꽁어름",
						Language.CHN_SIM => "冰宝",
						Language.CHN_TRA => "冰寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AVALUGG:
					return lang switch {
						Language.ENG => "Avalugg",
						Language.JPN => "クレベース",
						Language.GER => "Arktilas",
						Language.FRE => "Séracrawl",
						Language.ITA => "Avalugg",
						Language.SPN => "Avalugg",
						Language.KOR => "크레베이스",
						Language.CHN_SIM => "冰岩怪",
						Language.CHN_TRA => "冰岩怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.AVALUGG_HISUIAN_AVALUGG:
					return lang switch {
						Language.ENG => "Avalugg",
						Language.JPN => "クレベース",
						Language.GER => "Arktilas",
						Language.FRE => "Séracrawl",
						Language.ITA => "Avalugg",
						Language.SPN => "Avalugg",
						Language.KOR => "크레베이스",
						Language.CHN_SIM => "冰岩怪",
						Language.CHN_TRA => "冰岩怪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NOIBAT:
					return lang switch {
						Language.ENG => "Noibat",
						Language.JPN => "オンバット",
						Language.GER => "eF-eM",
						Language.FRE => "Sonistrelle",
						Language.ITA => "Noibat",
						Language.SPN => "Noibat",
						Language.KOR => "음뱃",
						Language.CHN_SIM => "嗡蝠",
						Language.CHN_TRA => "嗡蝠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NOIVERN:
					return lang switch {
						Language.ENG => "Noivern",
						Language.JPN => "オンバーン",
						Language.GER => "UHaFnir",
						Language.FRE => "Bruyverne",
						Language.ITA => "Noivern",
						Language.SPN => "Noivern",
						Language.KOR => "음번",
						Language.CHN_SIM => "音波龙",
						Language.CHN_TRA => "音波龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.XERNEAS:
					return lang switch {
						Language.ENG => "Xerneas",
						Language.JPN => "ゼルネアス",
						Language.GER => "Xerneas",
						Language.FRE => "Xerneas",
						Language.ITA => "Xerneas",
						Language.SPN => "Xerneas",
						Language.KOR => "제르네아스",
						Language.CHN_SIM => "哲尔尼亚斯",
						Language.CHN_TRA => "哲爾尼亞斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YVELTAL:
					return lang switch {
						Language.ENG => "Yveltal",
						Language.JPN => "イベルタル",
						Language.GER => "Yveltal",
						Language.FRE => "Yveltal",
						Language.ITA => "Yveltal",
						Language.SPN => "Yveltal",
						Language.KOR => "이벨타르",
						Language.CHN_SIM => "伊裴尔塔尔",
						Language.CHN_TRA => "伊裴爾塔爾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZYGARDE_50P_FORME:
					return lang switch {
						Language.ENG => "Zygarde",
						Language.JPN => "ジガルデ",
						Language.GER => "Zygarde",
						Language.FRE => "Zygarde",
						Language.ITA => "Zygarde",
						Language.SPN => "Zygarde",
						Language.KOR => "지가르데",
						Language.CHN_SIM => "基格尔德",
						Language.CHN_TRA => "基格爾德",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZYGARDE_10P_FORME:
					return lang switch {
						Language.ENG => "Zygarde",
						Language.JPN => "ジガルデ",
						Language.GER => "Zygarde",
						Language.FRE => "Zygarde",
						Language.ITA => "Zygarde",
						Language.SPN => "Zygarde",
						Language.KOR => "지가르데",
						Language.CHN_SIM => "基格尔德",
						Language.CHN_TRA => "基格爾德",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZYGARDE_COMPLETE_FORME:
					return lang switch {
						Language.ENG => "Zygarde",
						Language.JPN => "ジガルデ",
						Language.GER => "Zygarde",
						Language.FRE => "Zygarde",
						Language.ITA => "Zygarde",
						Language.SPN => "Zygarde",
						Language.KOR => "지가르데",
						Language.CHN_SIM => "基格尔德",
						Language.CHN_TRA => "基格爾德",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIANCIE:
					return lang switch {
						Language.ENG => "Diancie",
						Language.JPN => "ディアンシー",
						Language.GER => "Diancie",
						Language.FRE => "Diancie",
						Language.ITA => "Diancie",
						Language.SPN => "Diancie",
						Language.KOR => "디안시",
						Language.CHN_SIM => "蒂安希",
						Language.CHN_TRA => "蒂安希",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DIANCIE_MEGA_DIANCIE:
					return lang switch {
						Language.ENG => "Diancie",
						Language.JPN => "ディアンシー",
						Language.GER => "Diancie",
						Language.FRE => "Diancie",
						Language.ITA => "Diancie",
						Language.SPN => "Diancie",
						Language.KOR => "디안시",
						Language.CHN_SIM => "蒂安希",
						Language.CHN_TRA => "蒂安希",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOOPA_HOOPA_CONFINED:
					return lang switch {
						Language.ENG => "Hoopa",
						Language.JPN => "フーパ",
						Language.GER => "Hoopa",
						Language.FRE => "Hoopa",
						Language.ITA => "Hoopa",
						Language.SPN => "Hoopa",
						Language.KOR => "후파",
						Language.CHN_SIM => "胡帕",
						Language.CHN_TRA => "胡帕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOOPA_HOOPA_UNBOUND:
					return lang switch {
						Language.ENG => "Hoopa",
						Language.JPN => "フーパ",
						Language.GER => "Hoopa",
						Language.FRE => "Hoopa",
						Language.ITA => "Hoopa",
						Language.SPN => "Hoopa",
						Language.KOR => "후파",
						Language.CHN_SIM => "胡帕",
						Language.CHN_TRA => "胡帕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VOLCANION:
					return lang switch {
						Language.ENG => "Volcanion",
						Language.JPN => "ボルケニオン",
						Language.GER => "Volcanion",
						Language.FRE => "Volcanion",
						Language.ITA => "Volcanion",
						Language.SPN => "Volcanion",
						Language.KOR => "볼케니온",
						Language.CHN_SIM => "波尔凯尼恩",
						Language.CHN_TRA => "波爾凱尼恩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROWLET:
					return lang switch {
						Language.ENG => "Rowlet",
						Language.JPN => "モクロー",
						Language.GER => "Bauz",
						Language.FRE => "Brindibou",
						Language.ITA => "Rowlet",
						Language.SPN => "Rowlet",
						Language.KOR => "나몰빼미",
						Language.CHN_SIM => "木木枭",
						Language.CHN_TRA => "木木梟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DARTRIX:
					return lang switch {
						Language.ENG => "Dartrix",
						Language.JPN => "フクスロー",
						Language.GER => "Arboretoss",
						Language.FRE => "Efflèche",
						Language.ITA => "Dartrix",
						Language.SPN => "Dartrix",
						Language.KOR => "빼미스로우",
						Language.CHN_SIM => "投羽枭",
						Language.CHN_TRA => "投羽梟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DECIDUEYE:
					return lang switch {
						Language.ENG => "Decidueye",
						Language.JPN => "ジュナイパー",
						Language.GER => "Silvarro",
						Language.FRE => "Archéduc",
						Language.ITA => "Decidueye",
						Language.SPN => "Decidueye",
						Language.KOR => "모크나이퍼",
						Language.CHN_SIM => "狙射树枭",
						Language.CHN_TRA => "狙射樹梟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DECIDUEYE_HISUIAN_DECIDUEYE:
					return lang switch {
						Language.ENG => "Decidueye",
						Language.JPN => "ジュナイパー",
						Language.GER => "Silvarro",
						Language.FRE => "Archéduc",
						Language.ITA => "Decidueye",
						Language.SPN => "Decidueye",
						Language.KOR => "모크나이퍼",
						Language.CHN_SIM => "狙射树枭",
						Language.CHN_TRA => "狙射樹梟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LITTEN:
					return lang switch {
						Language.ENG => "Litten",
						Language.JPN => "ニャビー",
						Language.GER => "Flamiau",
						Language.FRE => "Flamiaou",
						Language.ITA => "Litten",
						Language.SPN => "Litten",
						Language.KOR => "냐오불",
						Language.CHN_SIM => "火斑喵",
						Language.CHN_TRA => "火斑喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TORRACAT:
					return lang switch {
						Language.ENG => "Torracat",
						Language.JPN => "ニャヒート",
						Language.GER => "Miezunder",
						Language.FRE => "Matoufeu",
						Language.ITA => "Torracat",
						Language.SPN => "Torracat",
						Language.KOR => "냐오히트",
						Language.CHN_SIM => "炎热喵",
						Language.CHN_TRA => "炎熱喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.INCINEROAR:
					return lang switch {
						Language.ENG => "Incineroar",
						Language.JPN => "ガオガエン",
						Language.GER => "Fuegro",
						Language.FRE => "Félinferno",
						Language.ITA => "Incineroar",
						Language.SPN => "Incineroar",
						Language.KOR => "어흥염",
						Language.CHN_SIM => "炽焰咆哮虎",
						Language.CHN_TRA => "熾焰咆哮虎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POPPLIO:
					return lang switch {
						Language.ENG => "Popplio",
						Language.JPN => "アシマリ",
						Language.GER => "Robball",
						Language.FRE => "Otaquin",
						Language.ITA => "Popplio",
						Language.SPN => "Popplio",
						Language.KOR => "누리공",
						Language.CHN_SIM => "球球海狮",
						Language.CHN_TRA => "球球海獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRIONNE:
					return lang switch {
						Language.ENG => "Brionne",
						Language.JPN => "オシャマリ",
						Language.GER => "Marikeck",
						Language.FRE => "Otarlette",
						Language.ITA => "Brionne",
						Language.SPN => "Brionne",
						Language.KOR => "키요공",
						Language.CHN_SIM => "花漾海狮",
						Language.CHN_TRA => "花漾海獅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PRIMARINA:
					return lang switch {
						Language.ENG => "Primarina",
						Language.JPN => "アシレーヌ",
						Language.GER => "Primarene",
						Language.FRE => "Oratoria",
						Language.ITA => "Primarina",
						Language.SPN => "Primarina",
						Language.KOR => "누리레느",
						Language.CHN_SIM => "西狮海壬",
						Language.CHN_TRA => "西獅海壬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PIKIPEK:
					return lang switch {
						Language.ENG => "Pikipek",
						Language.JPN => "ツツケラ",
						Language.GER => "Peppeck",
						Language.FRE => "Picassaut",
						Language.ITA => "Pikipek",
						Language.SPN => "Pikipek",
						Language.KOR => "콕코구리",
						Language.CHN_SIM => "小笃儿",
						Language.CHN_TRA => "小篤兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TRUMBEAK:
					return lang switch {
						Language.ENG => "Trumbeak",
						Language.JPN => "ケララッパ",
						Language.GER => "Trompeck",
						Language.FRE => "Piclairon",
						Language.ITA => "Trumbeak",
						Language.SPN => "Trumbeak",
						Language.KOR => "크라파",
						Language.CHN_SIM => "喇叭啄鸟",
						Language.CHN_TRA => "喇叭啄鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOUCANNON:
					return lang switch {
						Language.ENG => "Toucannon",
						Language.JPN => "ドデカバシ",
						Language.GER => "Tukanon",
						Language.FRE => "Bazoucan",
						Language.ITA => "Toucannon",
						Language.SPN => "Toucannon",
						Language.KOR => "왕큰부리",
						Language.CHN_SIM => "铳嘴大鸟",
						Language.CHN_TRA => "銃嘴大鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YUNGOOS:
					return lang switch {
						Language.ENG => "Yungoos",
						Language.JPN => "ヤングース",
						Language.GER => "Mangunior",
						Language.FRE => "Manglouton",
						Language.ITA => "Yungoos",
						Language.SPN => "Yungoos",
						Language.KOR => "영구스",
						Language.CHN_SIM => "猫鼬少",
						Language.CHN_TRA => "貓鼬少",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GUMSHOOS:
					return lang switch {
						Language.ENG => "Gumshoos",
						Language.JPN => "デカグース",
						Language.GER => "Manguspektor",
						Language.FRE => "Argouste",
						Language.ITA => "Gumshoos",
						Language.SPN => "Gumshoos",
						Language.KOR => "형사구스",
						Language.CHN_SIM => "猫鼬探长",
						Language.CHN_TRA => "貓鼬探長",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRUBBIN:
					return lang switch {
						Language.ENG => "Grubbin",
						Language.JPN => "アゴジムシ",
						Language.GER => "Mabula",
						Language.FRE => "Larvibule",
						Language.ITA => "Grubbin",
						Language.SPN => "Grubbin",
						Language.KOR => "턱지충이",
						Language.CHN_SIM => "强颚鸡母虫",
						Language.CHN_TRA => "強顎雞母蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARJABUG:
					return lang switch {
						Language.ENG => "Charjabug",
						Language.JPN => "デンヂムシ",
						Language.GER => "Akkup",
						Language.FRE => "Chrysapile",
						Language.ITA => "Charjabug",
						Language.SPN => "Charjabug",
						Language.KOR => "전지충이",
						Language.CHN_SIM => "虫电宝",
						Language.CHN_TRA => "蟲電寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VIKAVOLT:
					return lang switch {
						Language.ENG => "Vikavolt",
						Language.JPN => "クワガノン",
						Language.GER => "Donarion",
						Language.FRE => "Lucanon",
						Language.ITA => "Vikavolt",
						Language.SPN => "Vikavolt",
						Language.KOR => "투구뿌논",
						Language.CHN_SIM => "锹农炮虫",
						Language.CHN_TRA => "鍬農炮蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRABRAWLER:
					return lang switch {
						Language.ENG => "Crabrawler",
						Language.JPN => "マケンカニ",
						Language.GER => "Krabbox",
						Language.FRE => "Crabagarre",
						Language.ITA => "Crabrawler",
						Language.SPN => "Crabrawler",
						Language.KOR => "오기지게",
						Language.CHN_SIM => "好胜蟹",
						Language.CHN_TRA => "好勝蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRABOMINABLE:
					return lang switch {
						Language.ENG => "Crabominable",
						Language.JPN => "ケケンカニ",
						Language.GER => "Krawell",
						Language.FRE => "Crabominable",
						Language.ITA => "Crabominable",
						Language.SPN => "Crabominable",
						Language.KOR => "모단단게",
						Language.CHN_SIM => "好胜毛蟹",
						Language.CHN_TRA => "好勝毛蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORICORIO_BAILE_STYLE:
					return lang switch {
						Language.ENG => "Oricorio",
						Language.JPN => "オドリドリ",
						Language.GER => "Choreogel",
						Language.FRE => "Plumeline",
						Language.ITA => "Oricorio",
						Language.SPN => "Oricorio",
						Language.KOR => "춤추새",
						Language.CHN_SIM => "花舞鸟",
						Language.CHN_TRA => "花舞鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORICORIO_POM_POM_STYLE:
					return lang switch {
						Language.ENG => "Oricorio",
						Language.JPN => "オドリドリ",
						Language.GER => "Choreogel",
						Language.FRE => "Plumeline",
						Language.ITA => "Oricorio",
						Language.SPN => "Oricorio",
						Language.KOR => "춤추새",
						Language.CHN_SIM => "花舞鸟",
						Language.CHN_TRA => "花舞鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORICORIO_PA_U_STYLE:
					return lang switch {
						Language.ENG => "Oricorio",
						Language.JPN => "オドリドリ",
						Language.GER => "Choreogel",
						Language.FRE => "Plumeline",
						Language.ITA => "Oricorio",
						Language.SPN => "Oricorio",
						Language.KOR => "춤추새",
						Language.CHN_SIM => "花舞鸟",
						Language.CHN_TRA => "花舞鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORICORIO_SENSU_STYLE:
					return lang switch {
						Language.ENG => "Oricorio",
						Language.JPN => "オドリドリ",
						Language.GER => "Choreogel",
						Language.FRE => "Plumeline",
						Language.ITA => "Oricorio",
						Language.SPN => "Oricorio",
						Language.KOR => "춤추새",
						Language.CHN_SIM => "花舞鸟",
						Language.CHN_TRA => "花舞鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CUTIEFLY:
					return lang switch {
						Language.ENG => "Cutiefly",
						Language.JPN => "アブリー",
						Language.GER => "Wommel",
						Language.FRE => "Bombydou",
						Language.ITA => "Cutiefly",
						Language.SPN => "Cutiefly",
						Language.KOR => "에블리",
						Language.CHN_SIM => "萌虻",
						Language.CHN_TRA => "萌虻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RIBOMBEE:
					return lang switch {
						Language.ENG => "Ribombee",
						Language.JPN => "アブリボン",
						Language.GER => "Bandelby",
						Language.FRE => "Rubombelle",
						Language.ITA => "Ribombee",
						Language.SPN => "Ribombee",
						Language.KOR => "에리본",
						Language.CHN_SIM => "蝶结萌虻",
						Language.CHN_TRA => "蝶結萌虻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROCKRUFF:
					return lang switch {
						Language.ENG => "Rockruff",
						Language.JPN => "イワンコ",
						Language.GER => "Wuffels",
						Language.FRE => "Rocabot",
						Language.ITA => "Rockruff",
						Language.SPN => "Rockruff",
						Language.KOR => "암멍이",
						Language.CHN_SIM => "岩狗狗",
						Language.CHN_TRA => "岩狗狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROCKRUFF_OWN_TEMPO_ROCKRUFF:
					return lang switch {
						Language.ENG => "Rockruff",
						Language.JPN => "イワンコ",
						Language.GER => "Wuffels",
						Language.FRE => "Rocabot",
						Language.ITA => "Rockruff",
						Language.SPN => "Rockruff",
						Language.KOR => "암멍이",
						Language.CHN_SIM => "岩狗狗",
						Language.CHN_TRA => "岩狗狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LYCANROC_MIDDAY_FORM:
					return lang switch {
						Language.ENG => "Lycanroc",
						Language.JPN => "ルガルガン",
						Language.GER => "Wolwerock",
						Language.FRE => "Lougaroc",
						Language.ITA => "Lycanroc",
						Language.SPN => "Lycanroc",
						Language.KOR => "루가루암",
						Language.CHN_SIM => "鬃岩狼人",
						Language.CHN_TRA => "鬃岩狼人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LYCANROC_MIDNIGHT_FORM:
					return lang switch {
						Language.ENG => "Lycanroc",
						Language.JPN => "ルガルガン",
						Language.GER => "Wolwerock",
						Language.FRE => "Lougaroc",
						Language.ITA => "Lycanroc",
						Language.SPN => "Lycanroc",
						Language.KOR => "루가루암",
						Language.CHN_SIM => "鬃岩狼人",
						Language.CHN_TRA => "鬃岩狼人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LYCANROC_DUSK_FORM:
					return lang switch {
						Language.ENG => "Lycanroc",
						Language.JPN => "ルガルガン",
						Language.GER => "Wolwerock",
						Language.FRE => "Lougaroc",
						Language.ITA => "Lycanroc",
						Language.SPN => "Lycanroc",
						Language.KOR => "루가루암",
						Language.CHN_SIM => "鬃岩狼人",
						Language.CHN_TRA => "鬃岩狼人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WISHIWASHI_SOLO_FORM:
					return lang switch {
						Language.ENG => "Wishiwashi",
						Language.JPN => "ヨワシ",
						Language.GER => "Lusardin",
						Language.FRE => "Froussardine",
						Language.ITA => "Wishiwashi",
						Language.SPN => "Wishiwashi",
						Language.KOR => "약어리",
						Language.CHN_SIM => "弱丁鱼",
						Language.CHN_TRA => "弱丁魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WISHIWASHI_SCHOOL_FORM:
					return lang switch {
						Language.ENG => "Wishiwashi",
						Language.JPN => "ヨワシ",
						Language.GER => "Lusardin",
						Language.FRE => "Froussardine",
						Language.ITA => "Wishiwashi",
						Language.SPN => "Wishiwashi",
						Language.KOR => "약어리",
						Language.CHN_SIM => "弱丁鱼",
						Language.CHN_TRA => "弱丁魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAREANIE:
					return lang switch {
						Language.ENG => "Mareanie",
						Language.JPN => "ヒドイデ",
						Language.GER => "Garstella",
						Language.FRE => "Vorastérie",
						Language.ITA => "Mareanie",
						Language.SPN => "Mareanie",
						Language.KOR => "시마사리",
						Language.CHN_SIM => "好坏星",
						Language.CHN_TRA => "好壞星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOXAPEX:
					return lang switch {
						Language.ENG => "Toxapex",
						Language.JPN => "ドヒドイデ",
						Language.GER => "Aggrostella",
						Language.FRE => "Prédastérie",
						Language.ITA => "Toxapex",
						Language.SPN => "Toxapex",
						Language.KOR => "더시마사리",
						Language.CHN_SIM => "超坏星",
						Language.CHN_TRA => "超壞星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUDBRAY:
					return lang switch {
						Language.ENG => "Mudbray",
						Language.JPN => "ドロバンコ",
						Language.GER => "Pampuli",
						Language.FRE => "Tiboudet",
						Language.ITA => "Mudbray",
						Language.SPN => "Mudbray",
						Language.KOR => "머드나기",
						Language.CHN_SIM => "泥驴仔",
						Language.CHN_TRA => "泥驢仔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MUDSDALE:
					return lang switch {
						Language.ENG => "Mudsdale",
						Language.JPN => "バンバドロ",
						Language.GER => "Pampross",
						Language.FRE => "Bourrinos",
						Language.ITA => "Mudsdale",
						Language.SPN => "Mudsdale",
						Language.KOR => "만마드",
						Language.CHN_SIM => "重泥挽马",
						Language.CHN_TRA => "重泥挽馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DEWPIDER:
					return lang switch {
						Language.ENG => "Dewpider",
						Language.JPN => "シズクモ",
						Language.GER => "Araqua",
						Language.FRE => "Araqua",
						Language.ITA => "Dewpider",
						Language.SPN => "Dewpider",
						Language.KOR => "물거미",
						Language.CHN_SIM => "滴蛛",
						Language.CHN_TRA => "滴蛛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARAQUANID:
					return lang switch {
						Language.ENG => "Araquanid",
						Language.JPN => "オニシズクモ",
						Language.GER => "Aranestro",
						Language.FRE => "Tarenbulle",
						Language.ITA => "Araquanid",
						Language.SPN => "Araquanid",
						Language.KOR => "깨비물거미",
						Language.CHN_SIM => "滴蛛霸",
						Language.CHN_TRA => "滴蛛霸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FOMANTIS:
					return lang switch {
						Language.ENG => "Fomantis",
						Language.JPN => "カリキリ",
						Language.GER => "Imantis",
						Language.FRE => "Mimantis",
						Language.ITA => "Fomantis",
						Language.SPN => "Fomantis",
						Language.KOR => "짜랑랑",
						Language.CHN_SIM => "伪螳草",
						Language.CHN_TRA => "偽螳草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LURANTIS:
					return lang switch {
						Language.ENG => "Lurantis",
						Language.JPN => "ラランテス",
						Language.GER => "Mantidea",
						Language.FRE => "Floramantis",
						Language.ITA => "Lurantis",
						Language.SPN => "Lurantis",
						Language.KOR => "라란티스",
						Language.CHN_SIM => "兰螳花",
						Language.CHN_TRA => "蘭螳花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MORELULL:
					return lang switch {
						Language.ENG => "Morelull",
						Language.JPN => "ネマシュ",
						Language.GER => "Bubungus",
						Language.FRE => "Spododo",
						Language.ITA => "Morelull",
						Language.SPN => "Morelull",
						Language.KOR => "자마슈",
						Language.CHN_SIM => "睡睡菇",
						Language.CHN_TRA => "睡睡菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHIINOTIC:
					return lang switch {
						Language.ENG => "Shiinotic",
						Language.JPN => "マシェード",
						Language.GER => "Lamellux",
						Language.FRE => "Lampignon",
						Language.ITA => "Shiinotic",
						Language.SPN => "Shiinotic",
						Language.KOR => "마셰이드",
						Language.CHN_SIM => "灯罩夜菇",
						Language.CHN_TRA => "燈罩夜菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SALANDIT:
					return lang switch {
						Language.ENG => "Salandit",
						Language.JPN => "ヤトウモリ",
						Language.GER => "Molunk",
						Language.FRE => "Tritox",
						Language.ITA => "Salandit",
						Language.SPN => "Salandit",
						Language.KOR => "야도뇽",
						Language.CHN_SIM => "夜盗火蜥",
						Language.CHN_TRA => "夜盜火蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SALAZZLE:
					return lang switch {
						Language.ENG => "Salazzle",
						Language.JPN => "エンニュート",
						Language.GER => "Amfira",
						Language.FRE => "Malamandre",
						Language.ITA => "Salazzle",
						Language.SPN => "Salazzle",
						Language.KOR => "염뉴트",
						Language.CHN_SIM => "焰后蜥",
						Language.CHN_TRA => "焰后蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STUFFUL:
					return lang switch {
						Language.ENG => "Stufful",
						Language.JPN => "ヌイコグマ",
						Language.GER => "Velursi",
						Language.FRE => "Nounourson",
						Language.ITA => "Stufful",
						Language.SPN => "Stufful",
						Language.KOR => "포곰곰",
						Language.CHN_SIM => "童偶熊",
						Language.CHN_TRA => "童偶熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BEWEAR:
					return lang switch {
						Language.ENG => "Bewear",
						Language.JPN => "キテルグマ",
						Language.GER => "Kosturso",
						Language.FRE => "Chelours",
						Language.ITA => "Bewear",
						Language.SPN => "Bewear",
						Language.KOR => "이븐곰",
						Language.CHN_SIM => "穿着熊",
						Language.CHN_TRA => "穿著熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BOUNSWEET:
					return lang switch {
						Language.ENG => "Bounsweet",
						Language.JPN => "アマカジ",
						Language.GER => "Frubberl",
						Language.FRE => "Croquine",
						Language.ITA => "Bounsweet",
						Language.SPN => "Bounsweet",
						Language.KOR => "달콤아",
						Language.CHN_SIM => "甜竹竹",
						Language.CHN_TRA => "甜竹竹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STEENEE:
					return lang switch {
						Language.ENG => "Steenee",
						Language.JPN => "アママイコ",
						Language.GER => "Frubaila",
						Language.FRE => "Candine",
						Language.ITA => "Steenee",
						Language.SPN => "Steenee",
						Language.KOR => "달무리나",
						Language.CHN_SIM => "甜舞妮",
						Language.CHN_TRA => "甜舞妮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TSAREENA:
					return lang switch {
						Language.ENG => "Tsareena",
						Language.JPN => "アマージョ",
						Language.GER => "Fruyal",
						Language.FRE => "Sucreine",
						Language.ITA => "Tsareena",
						Language.SPN => "Tsareena",
						Language.KOR => "달코퀸",
						Language.CHN_SIM => "甜冷美后",
						Language.CHN_TRA => "甜冷美后",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COMFEY:
					return lang switch {
						Language.ENG => "Comfey",
						Language.JPN => "キュワワー",
						Language.GER => "Curelei",
						Language.FRE => "Guérilande",
						Language.ITA => "Comfey",
						Language.SPN => "Comfey",
						Language.KOR => "큐아링",
						Language.CHN_SIM => "花疗环环",
						Language.CHN_TRA => "花療環環",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORANGURU:
					return lang switch {
						Language.ENG => "Oranguru",
						Language.JPN => "ヤレユータン",
						Language.GER => "Kommandutan",
						Language.FRE => "Gouroutan",
						Language.ITA => "Oranguru",
						Language.SPN => "Oranguru",
						Language.KOR => "하랑우탄",
						Language.CHN_SIM => "智挥猩",
						Language.CHN_TRA => "智揮猩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PASSIMIAN:
					return lang switch {
						Language.ENG => "Passimian",
						Language.JPN => "ナゲツケサル",
						Language.GER => "Quartermak",
						Language.FRE => "Quartermac",
						Language.ITA => "Passimian",
						Language.SPN => "Passimian",
						Language.KOR => "내던숭이",
						Language.CHN_SIM => "投掷猴",
						Language.CHN_TRA => "投擲猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WIMPOD:
					return lang switch {
						Language.ENG => "Wimpod",
						Language.JPN => "コソクムシ",
						Language.GER => "Reißlaus",
						Language.FRE => "Sovkipou",
						Language.ITA => "Wimpod",
						Language.SPN => "Wimpod",
						Language.KOR => "꼬시레",
						Language.CHN_SIM => "胆小虫",
						Language.CHN_TRA => "膽小蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOLISOPOD:
					return lang switch {
						Language.ENG => "Golisopod",
						Language.JPN => "グソクムシャ",
						Language.GER => "Tectass",
						Language.FRE => "Sarmuraï",
						Language.ITA => "Golisopod",
						Language.SPN => "Golisopod",
						Language.KOR => "갑주무사",
						Language.CHN_SIM => "具甲武者",
						Language.CHN_TRA => "具甲武者",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDYGAST:
					return lang switch {
						Language.ENG => "Sandygast",
						Language.JPN => "スナバァ",
						Language.GER => "Sankabuh",
						Language.FRE => "Bacabouh",
						Language.ITA => "Sandygast",
						Language.SPN => "Sandygast",
						Language.KOR => "모래꿍",
						Language.CHN_SIM => "沙丘娃",
						Language.CHN_TRA => "沙丘娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PALOSSAND:
					return lang switch {
						Language.ENG => "Palossand",
						Language.JPN => "シロデスナ",
						Language.GER => "Colossand",
						Language.FRE => "Trépassable",
						Language.ITA => "Palossand",
						Language.SPN => "Palossand",
						Language.KOR => "모래성이당",
						Language.CHN_SIM => "噬沙堡爷",
						Language.CHN_TRA => "噬沙堡爺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PYUKUMUKU:
					return lang switch {
						Language.ENG => "Pyukumuku",
						Language.JPN => "ナマコブシ",
						Language.GER => "Gufa",
						Language.FRE => "Concombaffe",
						Language.ITA => "Pyukumuku",
						Language.SPN => "Pyukumuku",
						Language.KOR => "해무기",
						Language.CHN_SIM => "拳海参",
						Language.CHN_TRA => "拳海參",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TYPE_NULL:
					return lang switch {
						Language.ENG => "Type: Null",
						Language.JPN => "タイプ：ヌル",
						Language.GER => "Typ:Null",
						Language.FRE => "Type:0",
						Language.ITA => "Tipo Zero",
						Language.SPN => "Código Cero",
						Language.KOR => "타입:널",
						Language.CHN_SIM => "属性：空",
						Language.CHN_TRA => "屬性：空",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SILVALLY:
					return lang switch {
						Language.ENG => "Silvally",
						Language.JPN => "シルヴァディ",
						Language.GER => "Amigento",
						Language.FRE => "Silvallié",
						Language.ITA => "Silvally",
						Language.SPN => "Silvally",
						Language.KOR => "실버디",
						Language.CHN_SIM => "银伴战兽",
						Language.CHN_TRA => "銀伴戰獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MINIOR_METEOR_FORM:
					return lang switch {
						Language.ENG => "Minior",
						Language.JPN => "メテノ",
						Language.GER => "Meteno",
						Language.FRE => "Météno",
						Language.ITA => "Minior",
						Language.SPN => "Minior",
						Language.KOR => "메테노",
						Language.CHN_SIM => "小陨星",
						Language.CHN_TRA => "小隕星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MINIOR_CORE_FORM:
					return lang switch {
						Language.ENG => "Minior",
						Language.JPN => "メテノ",
						Language.GER => "Meteno",
						Language.FRE => "Météno",
						Language.ITA => "Minior",
						Language.SPN => "Minior",
						Language.KOR => "메테노",
						Language.CHN_SIM => "小陨星",
						Language.CHN_TRA => "小隕星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KOMALA:
					return lang switch {
						Language.ENG => "Komala",
						Language.JPN => "ネッコアラ",
						Language.GER => "Koalelu",
						Language.FRE => "Dodoala",
						Language.ITA => "Komala",
						Language.SPN => "Komala",
						Language.KOR => "자말라",
						Language.CHN_SIM => "树枕尾熊",
						Language.CHN_TRA => "樹枕尾熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TURTONATOR:
					return lang switch {
						Language.ENG => "Turtonator",
						Language.JPN => "バクガメス",
						Language.GER => "Tortunator",
						Language.FRE => "Boumata",
						Language.ITA => "Turtonator",
						Language.SPN => "Turtonator",
						Language.KOR => "폭거북스",
						Language.CHN_SIM => "爆焰龟兽",
						Language.CHN_TRA => "爆焰龜獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOGEDEMARU:
					return lang switch {
						Language.ENG => "Togedemaru",
						Language.JPN => "トゲデマル",
						Language.GER => "Togedemaru",
						Language.FRE => "Togedemaru",
						Language.ITA => "Togedemaru",
						Language.SPN => "Togedemaru",
						Language.KOR => "토게데마루",
						Language.CHN_SIM => "托戈德玛尔",
						Language.CHN_TRA => "托戈德瑪爾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MIMIKYU:
					return lang switch {
						Language.ENG => "Mimikyu",
						Language.JPN => "ミミッキュ",
						Language.GER => "Mimigma",
						Language.FRE => "Mimiqui",
						Language.ITA => "Mimikyu",
						Language.SPN => "Mimikyu",
						Language.KOR => "따라큐",
						Language.CHN_SIM => "谜拟丘",
						Language.CHN_TRA => "謎擬Ｑ",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRUXISH:
					return lang switch {
						Language.ENG => "Bruxish",
						Language.JPN => "ハギギシリ",
						Language.GER => "Knirfish",
						Language.FRE => "Denticrisse",
						Language.ITA => "Bruxish",
						Language.SPN => "Bruxish",
						Language.KOR => "치갈기",
						Language.CHN_SIM => "磨牙彩皮鱼",
						Language.CHN_TRA => "磨牙彩皮魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAMPA:
					return lang switch {
						Language.ENG => "Drampa",
						Language.JPN => "ジジーロン",
						Language.GER => "Sen-Long",
						Language.FRE => "Draïeul",
						Language.ITA => "Drampa",
						Language.SPN => "Drampa",
						Language.KOR => "할비롱",
						Language.CHN_SIM => "老翁龙",
						Language.CHN_TRA => "老翁龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DHELMISE:
					return lang switch {
						Language.ENG => "Dhelmise",
						Language.JPN => "ダダリン",
						Language.GER => "Moruda",
						Language.FRE => "Sinistrail",
						Language.ITA => "Dhelmise",
						Language.SPN => "Dhelmise",
						Language.KOR => "타타륜",
						Language.CHN_SIM => "破破舵轮",
						Language.CHN_TRA => "破破舵輪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.JANGMO_O:
					return lang switch {
						Language.ENG => "Jangmo-o",
						Language.JPN => "ジャラコ",
						Language.GER => "Miniras",
						Language.FRE => "Bébécaille",
						Language.ITA => "Jangmo-o",
						Language.SPN => "Jangmo-o",
						Language.KOR => "짜랑꼬",
						Language.CHN_SIM => "心鳞宝",
						Language.CHN_TRA => "心鱗寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HAKAMO_O:
					return lang switch {
						Language.ENG => "Hakamo-o",
						Language.JPN => "ジャランゴ",
						Language.GER => "Mediras",
						Language.FRE => "Écaïd",
						Language.ITA => "Hakamo-o",
						Language.SPN => "Hakamo-o",
						Language.KOR => "짜랑고우",
						Language.CHN_SIM => "鳞甲龙",
						Language.CHN_TRA => "鱗甲龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KOMMO_O:
					return lang switch {
						Language.ENG => "Kommo-o",
						Language.JPN => "ジャラランガ",
						Language.GER => "Grandiras",
						Language.FRE => "Ékaïser",
						Language.ITA => "Kommo-o",
						Language.SPN => "Kommo-o",
						Language.KOR => "짜랑고우거",
						Language.CHN_SIM => "杖尾鳞甲龙",
						Language.CHN_TRA => "杖尾鱗甲龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAPU_KOKO:
					return lang switch {
						Language.ENG => "Tapu Koko",
						Language.JPN => "カプ・コケコ",
						Language.GER => "Kapu-Riki",
						Language.FRE => "Tokorico",
						Language.ITA => "Tapu Koko",
						Language.SPN => "Tapu Koko",
						Language.KOR => "카푸꼬꼬꼭",
						Language.CHN_SIM => "卡璞・鸣鸣",
						Language.CHN_TRA => "卡璞・鳴鳴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAPU_LELE:
					return lang switch {
						Language.ENG => "Tapu Lele",
						Language.JPN => "カプ・テテフ",
						Language.GER => "Kapu-Fala",
						Language.FRE => "Tokopiyon",
						Language.ITA => "Tapu Lele",
						Language.SPN => "Tapu Lele",
						Language.KOR => "카푸나비나",
						Language.CHN_SIM => "卡璞・蝶蝶",
						Language.CHN_TRA => "卡璞・蝶蝶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAPU_BULU:
					return lang switch {
						Language.ENG => "Tapu Bulu",
						Language.JPN => "カプ・ブルル",
						Language.GER => "Kapu-Toro",
						Language.FRE => "Tokotoro",
						Language.ITA => "Tapu Bulu",
						Language.SPN => "Tapu Bulu",
						Language.KOR => "카푸브루루",
						Language.CHN_SIM => "卡璞・哞哞",
						Language.CHN_TRA => "卡璞・哞哞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAPU_FINI:
					return lang switch {
						Language.ENG => "Tapu Fini",
						Language.JPN => "カプ・レヒレ",
						Language.GER => "Kapu-Kime",
						Language.FRE => "Tokopisco",
						Language.ITA => "Tapu Fini",
						Language.SPN => "Tapu Fini",
						Language.KOR => "카푸느지느",
						Language.CHN_SIM => "卡璞・鳍鳍",
						Language.CHN_TRA => "卡璞・鰭鰭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COSMOG:
					return lang switch {
						Language.ENG => "Cosmog",
						Language.JPN => "コスモッグ",
						Language.GER => "Cosmog",
						Language.FRE => "Cosmog",
						Language.ITA => "Cosmog",
						Language.SPN => "Cosmog",
						Language.KOR => "코스모그",
						Language.CHN_SIM => "科斯莫古",
						Language.CHN_TRA => "科斯莫古",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COSMOEM:
					return lang switch {
						Language.ENG => "Cosmoem",
						Language.JPN => "コスモウム",
						Language.GER => "Cosmovum",
						Language.FRE => "Cosmovum",
						Language.ITA => "Cosmoem",
						Language.SPN => "Cosmoem",
						Language.KOR => "코스모움",
						Language.CHN_SIM => "科斯莫姆",
						Language.CHN_TRA => "科斯莫姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SOLGALEO:
					return lang switch {
						Language.ENG => "Solgaleo",
						Language.JPN => "ソルガレオ",
						Language.GER => "Solgaleo",
						Language.FRE => "Solgaleo",
						Language.ITA => "Solgaleo",
						Language.SPN => "Solgaleo",
						Language.KOR => "솔가레오",
						Language.CHN_SIM => "索尔迦雷欧",
						Language.CHN_TRA => "索爾迦雷歐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LUNALA:
					return lang switch {
						Language.ENG => "Lunala",
						Language.JPN => "ルナアーラ",
						Language.GER => "Lunala",
						Language.FRE => "Lunala",
						Language.ITA => "Lunala",
						Language.SPN => "Lunala",
						Language.KOR => "루나아라",
						Language.CHN_SIM => "露奈雅拉",
						Language.CHN_TRA => "露奈雅拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NIHILEGO:
					return lang switch {
						Language.ENG => "Nihilego",
						Language.JPN => "ウツロイド",
						Language.GER => "Anego",
						Language.FRE => "Zéroïd",
						Language.ITA => "Nihilego",
						Language.SPN => "Nihilego",
						Language.KOR => "텅비드",
						Language.CHN_SIM => "虚吾伊德",
						Language.CHN_TRA => "虛吾伊德",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BUZZWOLE:
					return lang switch {
						Language.ENG => "Buzzwole",
						Language.JPN => "マッシブーン",
						Language.GER => "Masskito",
						Language.FRE => "Mouscoto",
						Language.ITA => "Buzzwole",
						Language.SPN => "Buzzwole",
						Language.KOR => "매시붕",
						Language.CHN_SIM => "爆肌蚊",
						Language.CHN_TRA => "爆肌蚊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PHEROMOSA:
					return lang switch {
						Language.ENG => "Pheromosa",
						Language.JPN => "フェローチェ",
						Language.GER => "Schabelle",
						Language.FRE => "Cancrelove",
						Language.ITA => "Pheromosa",
						Language.SPN => "Pheromosa",
						Language.KOR => "페로코체",
						Language.CHN_SIM => "费洛美螂",
						Language.CHN_TRA => "費洛美螂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.XURKITREE:
					return lang switch {
						Language.ENG => "Xurkitree",
						Language.JPN => "デンジュモク",
						Language.GER => "Voltriant",
						Language.FRE => "Câblifère",
						Language.ITA => "Xurkitree",
						Language.SPN => "Xurkitree",
						Language.KOR => "전수목",
						Language.CHN_SIM => "电束木",
						Language.CHN_TRA => "電束木",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CELESTEELA:
					return lang switch {
						Language.ENG => "Celesteela",
						Language.JPN => "テッカグヤ",
						Language.GER => "Kaguron",
						Language.FRE => "Bamboiselle",
						Language.ITA => "Celesteela",
						Language.SPN => "Celesteela",
						Language.KOR => "철화구야",
						Language.CHN_SIM => "铁火辉夜",
						Language.CHN_TRA => "鐵火輝夜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KARTANA:
					return lang switch {
						Language.ENG => "Kartana",
						Language.JPN => "カミツルギ",
						Language.GER => "Katagami",
						Language.FRE => "Katagami",
						Language.ITA => "Kartana",
						Language.SPN => "Kartana",
						Language.KOR => "종이신도",
						Language.CHN_SIM => "纸御剑",
						Language.CHN_TRA => "紙御劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GUZZLORD:
					return lang switch {
						Language.ENG => "Guzzlord",
						Language.JPN => "アクジキング",
						Language.GER => "Schlingking",
						Language.FRE => "Engloutyran",
						Language.ITA => "Guzzlord",
						Language.SPN => "Guzzlord",
						Language.KOR => "악식킹",
						Language.CHN_SIM => "恶食大王",
						Language.CHN_TRA => "惡食大王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NECROZMA:
					return lang switch {
						Language.ENG => "Necrozma",
						Language.JPN => "ネクロズマ",
						Language.GER => "Necrozma",
						Language.FRE => "Necrozma",
						Language.ITA => "Necrozma",
						Language.SPN => "Necrozma",
						Language.KOR => "네크로즈마",
						Language.CHN_SIM => "奈克洛兹玛",
						Language.CHN_TRA => "奈克洛茲瑪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NECROZMA_DUSK_MANE_NECROZMA:
					return lang switch {
						Language.ENG => "Necrozma",
						Language.JPN => "ネクロズマ",
						Language.GER => "Necrozma",
						Language.FRE => "Necrozma",
						Language.ITA => "Necrozma",
						Language.SPN => "Necrozma",
						Language.KOR => "네크로즈마",
						Language.CHN_SIM => "奈克洛兹玛",
						Language.CHN_TRA => "奈克洛茲瑪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NECROZMA_DAWN_WINGS_NECROZMA:
					return lang switch {
						Language.ENG => "Necrozma",
						Language.JPN => "ネクロズマ",
						Language.GER => "Necrozma",
						Language.FRE => "Necrozma",
						Language.ITA => "Necrozma",
						Language.SPN => "Necrozma",
						Language.KOR => "네크로즈마",
						Language.CHN_SIM => "奈克洛兹玛",
						Language.CHN_TRA => "奈克洛茲瑪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NECROZMA_ULTRA_NECROZMA:
					return lang switch {
						Language.ENG => "Necrozma",
						Language.JPN => "ネクロズマ",
						Language.GER => "Necrozma",
						Language.FRE => "Necrozma",
						Language.ITA => "Necrozma",
						Language.SPN => "Necrozma",
						Language.KOR => "네크로즈마",
						Language.CHN_SIM => "奈克洛兹玛",
						Language.CHN_TRA => "奈克洛茲瑪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAGEARNA:
					return lang switch {
						Language.ENG => "Magearna",
						Language.JPN => "マギアナ",
						Language.GER => "Magearna",
						Language.FRE => "Magearna",
						Language.ITA => "Magearna",
						Language.SPN => "Magearna",
						Language.KOR => "마기아나",
						Language.CHN_SIM => "玛机雅娜",
						Language.CHN_TRA => "瑪機雅娜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MARSHADOW:
					return lang switch {
						Language.ENG => "Marshadow",
						Language.JPN => "マーシャドー",
						Language.GER => "Marshadow",
						Language.FRE => "Marshadow",
						Language.ITA => "Marshadow",
						Language.SPN => "Marshadow",
						Language.KOR => "마샤도",
						Language.CHN_SIM => "玛夏多",
						Language.CHN_TRA => "瑪夏多",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POIPOLE:
					return lang switch {
						Language.ENG => "Poipole",
						Language.JPN => "ベベノム",
						Language.GER => "Venicro",
						Language.FRE => "Vémini",
						Language.ITA => "Poipole",
						Language.SPN => "Poipole",
						Language.KOR => "베베놈",
						Language.CHN_SIM => "毒贝比",
						Language.CHN_TRA => "毒貝比",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NAGANADEL:
					return lang switch {
						Language.ENG => "Naganadel",
						Language.JPN => "アーゴヨン",
						Language.GER => "Agoyon",
						Language.FRE => "Mandrillon",
						Language.ITA => "Naganadel",
						Language.SPN => "Naganadel",
						Language.KOR => "아고용",
						Language.CHN_SIM => "四颚针龙",
						Language.CHN_TRA => "四顎針龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STAKATAKA:
					return lang switch {
						Language.ENG => "Stakataka",
						Language.JPN => "ツンデツンデ",
						Language.GER => "Muramura",
						Language.FRE => "Ama-Ama",
						Language.ITA => "Stakataka",
						Language.SPN => "Stakataka",
						Language.KOR => "차곡차곡",
						Language.CHN_SIM => "垒磊石",
						Language.CHN_TRA => "壘磊石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLACEPHALON:
					return lang switch {
						Language.ENG => "Blacephalon",
						Language.JPN => "ズガドーン",
						Language.GER => "Kopplosio",
						Language.FRE => "Pierroteknik",
						Language.ITA => "Blacephalon",
						Language.SPN => "Blacephalon",
						Language.KOR => "두파팡",
						Language.CHN_SIM => "砰头小丑",
						Language.CHN_TRA => "砰頭小丑",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZERAORA:
					return lang switch {
						Language.ENG => "Zeraora",
						Language.JPN => "ゼラオラ",
						Language.GER => "Zeraora",
						Language.FRE => "Zeraora",
						Language.ITA => "Zeraora",
						Language.SPN => "Zeraora",
						Language.KOR => "제라오라",
						Language.CHN_SIM => "捷拉奥拉",
						Language.CHN_TRA => "捷拉奧拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MELTAN:
					return lang switch {
						Language.ENG => "Meltan",
						Language.JPN => "メルタン",
						Language.GER => "Meltan",
						Language.FRE => "Meltan",
						Language.ITA => "Meltan",
						Language.SPN => "Meltan",
						Language.KOR => "멜탄",
						Language.CHN_SIM => "美录坦",
						Language.CHN_TRA => "美錄坦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MELMETAL:
					return lang switch {
						Language.ENG => "Melmetal",
						Language.JPN => "メルメタル",
						Language.GER => "Melmetal",
						Language.FRE => "Melmetal",
						Language.ITA => "Melmetal",
						Language.SPN => "Melmetal",
						Language.KOR => "멜메탈",
						Language.CHN_SIM => "美录梅塔",
						Language.CHN_TRA => "美錄梅塔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GROOKEY:
					return lang switch {
						Language.ENG => "Grookey",
						Language.JPN => "サルノリ",
						Language.GER => "Chimpep",
						Language.FRE => "Ouistempo",
						Language.ITA => "Grookey",
						Language.SPN => "Grookey",
						Language.KOR => "흥나숭",
						Language.CHN_SIM => "敲音猴",
						Language.CHN_TRA => "敲音猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.THWACKEY:
					return lang switch {
						Language.ENG => "Thwackey",
						Language.JPN => "バチンキー",
						Language.GER => "Chimstix",
						Language.FRE => "Badabouin",
						Language.ITA => "Thwackey",
						Language.SPN => "Thwackey",
						Language.KOR => "채키몽",
						Language.CHN_SIM => "啪咚猴",
						Language.CHN_TRA => "啪咚猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RILLABOOM:
					return lang switch {
						Language.ENG => "Rillaboom",
						Language.JPN => "ゴリランダー",
						Language.GER => "Gortrom",
						Language.FRE => "Gorythmic",
						Language.ITA => "Rillaboom",
						Language.SPN => "Rillaboom",
						Language.KOR => "고릴타",
						Language.CHN_SIM => "轰擂金刚猩",
						Language.CHN_TRA => "轟擂金剛猩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCORBUNNY:
					return lang switch {
						Language.ENG => "Scorbunny",
						Language.JPN => "ヒバニー",
						Language.GER => "Hopplo",
						Language.FRE => "Flambino",
						Language.ITA => "Scorbunny",
						Language.SPN => "Scorbunny",
						Language.KOR => "염버니",
						Language.CHN_SIM => "炎兔儿",
						Language.CHN_TRA => "炎兔兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RABOOT:
					return lang switch {
						Language.ENG => "Raboot",
						Language.JPN => "ラビフット",
						Language.GER => "Kickerlo",
						Language.FRE => "Lapyro",
						Language.ITA => "Raboot",
						Language.SPN => "Raboot",
						Language.KOR => "래비풋",
						Language.CHN_SIM => "腾蹴小将",
						Language.CHN_TRA => "騰蹴小將",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CINDERACE:
					return lang switch {
						Language.ENG => "Cinderace",
						Language.JPN => "エースバーン",
						Language.GER => "Liberlo",
						Language.FRE => "Pyrobut",
						Language.ITA => "Cinderace",
						Language.SPN => "Cinderace",
						Language.KOR => "에이스번",
						Language.CHN_SIM => "闪焰王牌",
						Language.CHN_TRA => "閃焰王牌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SOBBLE:
					return lang switch {
						Language.ENG => "Sobble",
						Language.JPN => "メッソン",
						Language.GER => "Memmeon",
						Language.FRE => "Larméléon",
						Language.ITA => "Sobble",
						Language.SPN => "Sobble",
						Language.KOR => "울머기",
						Language.CHN_SIM => "泪眼蜥",
						Language.CHN_TRA => "淚眼蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRIZZILE:
					return lang switch {
						Language.ENG => "Drizzile",
						Language.JPN => "ジメレオン",
						Language.GER => "Phlegleon",
						Language.FRE => "Arrozard",
						Language.ITA => "Drizzile",
						Language.SPN => "Drizzile",
						Language.KOR => "누겔레온",
						Language.CHN_SIM => "变涩蜥",
						Language.CHN_TRA => "變澀蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.INTELEON:
					return lang switch {
						Language.ENG => "Inteleon",
						Language.JPN => "インテレオン",
						Language.GER => "Intelleon",
						Language.FRE => "Lézargus",
						Language.ITA => "Inteleon",
						Language.SPN => "Inteleon",
						Language.KOR => "인텔리레온",
						Language.CHN_SIM => "千面避役",
						Language.CHN_TRA => "千面避役",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKWOVET:
					return lang switch {
						Language.ENG => "Skwovet",
						Language.JPN => "ホシガリス",
						Language.GER => "Raffel",
						Language.FRE => "Rongourmand",
						Language.ITA => "Skwovet",
						Language.SPN => "Skwovet",
						Language.KOR => "탐리스",
						Language.CHN_SIM => "贪心栗鼠",
						Language.CHN_TRA => "貪心栗鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GREEDENT:
					return lang switch {
						Language.ENG => "Greedent",
						Language.JPN => "ヨクバリス",
						Language.GER => "Schlaraffel",
						Language.FRE => "Rongrigou",
						Language.ITA => "Greedent",
						Language.SPN => "Greedent",
						Language.KOR => "요씽리스",
						Language.CHN_SIM => "藏饱栗鼠",
						Language.CHN_TRA => "藏飽栗鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROOKIDEE:
					return lang switch {
						Language.ENG => "Rookidee",
						Language.JPN => "ココガラ",
						Language.GER => "Meikro",
						Language.FRE => "Minisange",
						Language.ITA => "Rookidee",
						Language.SPN => "Rookidee",
						Language.KOR => "파라꼬",
						Language.CHN_SIM => "稚山雀",
						Language.CHN_TRA => "稚山雀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CORVISQUIRE:
					return lang switch {
						Language.ENG => "Corvisquire",
						Language.JPN => "アオガラス",
						Language.GER => "Kranoviz",
						Language.FRE => "Bleuseille",
						Language.ITA => "Corvisquire",
						Language.SPN => "Corvisquire",
						Language.KOR => "파크로우",
						Language.CHN_SIM => "蓝鸦",
						Language.CHN_TRA => "藍鴉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CORVIKNIGHT:
					return lang switch {
						Language.ENG => "Corviknight",
						Language.JPN => "アーマーガア",
						Language.GER => "Krarmor",
						Language.FRE => "Corvaillus",
						Language.ITA => "Corviknight",
						Language.SPN => "Corviknight",
						Language.KOR => "아머까오",
						Language.CHN_SIM => "钢铠鸦",
						Language.CHN_TRA => "鋼鎧鴉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BLIPBUG:
					return lang switch {
						Language.ENG => "Blipbug",
						Language.JPN => "サッチムシ",
						Language.GER => "Sensect",
						Language.FRE => "Larvadar",
						Language.ITA => "Blipbug",
						Language.SPN => "Blipbug",
						Language.KOR => "두루지벌레",
						Language.CHN_SIM => "索侦虫",
						Language.CHN_TRA => "索偵蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DOTTLER:
					return lang switch {
						Language.ENG => "Dottler",
						Language.JPN => "レドームシ",
						Language.GER => "Keradar",
						Language.FRE => "Coléodôme",
						Language.ITA => "Dottler",
						Language.SPN => "Dottler",
						Language.KOR => "레돔벌레",
						Language.CHN_SIM => "天罩虫",
						Language.CHN_TRA => "天罩蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORBEETLE:
					return lang switch {
						Language.ENG => "Orbeetle",
						Language.JPN => "イオルブ",
						Language.GER => "Maritellit",
						Language.FRE => "Astronelle",
						Language.ITA => "Orbeetle",
						Language.SPN => "Orbeetle",
						Language.KOR => "이올브",
						Language.CHN_SIM => "以欧路普",
						Language.CHN_TRA => "以歐路普",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NICKIT:
					return lang switch {
						Language.ENG => "Nickit",
						Language.JPN => "クスネ",
						Language.GER => "Kleptifux",
						Language.FRE => "Goupilou",
						Language.ITA => "Nickit",
						Language.SPN => "Nickit",
						Language.KOR => "훔처우",
						Language.CHN_SIM => "狡小狐",
						Language.CHN_TRA => "偷兒狐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.THIEVUL:
					return lang switch {
						Language.ENG => "Thievul",
						Language.JPN => "フォクスライ",
						Language.GER => "Gaunux",
						Language.FRE => "Roublenard",
						Language.ITA => "Thievul",
						Language.SPN => "Thievul",
						Language.KOR => "폭슬라이",
						Language.CHN_SIM => "猾大狐",
						Language.CHN_TRA => "狐大盜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GOSSIFLEUR:
					return lang switch {
						Language.ENG => "Gossifleur",
						Language.JPN => "ヒメンカ",
						Language.GER => "Cottini",
						Language.FRE => "Tournicoton",
						Language.ITA => "Gossifleur",
						Language.SPN => "Gossifleur",
						Language.KOR => "꼬모카",
						Language.CHN_SIM => "幼棉棉",
						Language.CHN_TRA => "幼棉棉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ELDEGOSS:
					return lang switch {
						Language.ENG => "Eldegoss",
						Language.JPN => "ワタシラガ",
						Language.GER => "Cottomi",
						Language.FRE => "Blancoton",
						Language.ITA => "Eldegoss",
						Language.SPN => "Eldegoss",
						Language.KOR => "백솜모카",
						Language.CHN_SIM => "白蓬蓬",
						Language.CHN_TRA => "白蓬蓬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WOOLOO:
					return lang switch {
						Language.ENG => "Wooloo",
						Language.JPN => "ウールー",
						Language.GER => "Wolly",
						Language.FRE => "Moumouton",
						Language.ITA => "Wooloo",
						Language.SPN => "Wooloo",
						Language.KOR => "우르",
						Language.CHN_SIM => "毛辫羊",
						Language.CHN_TRA => "毛辮羊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUBWOOL:
					return lang switch {
						Language.ENG => "Dubwool",
						Language.JPN => "バイウールー",
						Language.GER => "Zwollock",
						Language.FRE => "Moumouflon",
						Language.ITA => "Dubwool",
						Language.SPN => "Dubwool",
						Language.KOR => "배우르",
						Language.CHN_SIM => "毛毛角羊",
						Language.CHN_TRA => "毛毛角羊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHEWTLE:
					return lang switch {
						Language.ENG => "Chewtle",
						Language.JPN => "カムカメ",
						Language.GER => "Kamehaps",
						Language.FRE => "Khélocrok",
						Language.ITA => "Chewtle",
						Language.SPN => "Chewtle",
						Language.KOR => "깨물부기",
						Language.CHN_SIM => "咬咬龟",
						Language.CHN_TRA => "咬咬龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DREDNAW:
					return lang switch {
						Language.ENG => "Drednaw",
						Language.JPN => "カジリガメ",
						Language.GER => "Kamalm",
						Language.FRE => "Torgamord",
						Language.ITA => "Drednaw",
						Language.SPN => "Drednaw",
						Language.KOR => "갈가부기",
						Language.CHN_SIM => "暴噬龟",
						Language.CHN_TRA => "暴噬龜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.YAMPER:
					return lang switch {
						Language.ENG => "Yamper",
						Language.JPN => "ワンパチ",
						Language.GER => "Voldi",
						Language.FRE => "Voltoutou",
						Language.ITA => "Yamper",
						Language.SPN => "Yamper",
						Language.KOR => "멍파치",
						Language.CHN_SIM => "来电汪",
						Language.CHN_TRA => "來電汪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BOLTUND:
					return lang switch {
						Language.ENG => "Boltund",
						Language.JPN => "パルスワン",
						Language.GER => "Bellektro",
						Language.FRE => "Fulgudog",
						Language.ITA => "Boltund",
						Language.SPN => "Boltund",
						Language.KOR => "펄스멍",
						Language.CHN_SIM => "逐电犬",
						Language.CHN_TRA => "逐電犬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROLYCOLY:
					return lang switch {
						Language.ENG => "Rolycoly",
						Language.JPN => "タンドン",
						Language.GER => "Klonkett",
						Language.FRE => "Charbi",
						Language.ITA => "Rolycoly",
						Language.SPN => "Rolycoly",
						Language.KOR => "탄동",
						Language.CHN_SIM => "小炭仔",
						Language.CHN_TRA => "小炭仔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CARKOL:
					return lang switch {
						Language.ENG => "Carkol",
						Language.JPN => "トロッゴン",
						Language.GER => "Wagong",
						Language.FRE => "Wagomine",
						Language.ITA => "Carkol",
						Language.SPN => "Carkol",
						Language.KOR => "탄차곤",
						Language.CHN_SIM => "大炭车",
						Language.CHN_TRA => "大炭車",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COALOSSAL:
					return lang switch {
						Language.ENG => "Coalossal",
						Language.JPN => "セキタンザン",
						Language.GER => "Montecarbo",
						Language.FRE => "Monthracite",
						Language.ITA => "Coalossal",
						Language.SPN => "Coalossal",
						Language.KOR => "석탄산",
						Language.CHN_SIM => "巨炭山",
						Language.CHN_TRA => "巨炭山",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.APPLIN:
					return lang switch {
						Language.ENG => "Applin",
						Language.JPN => "カジッチュ",
						Language.GER => "Knapfel",
						Language.FRE => "Verpom",
						Language.ITA => "Applin",
						Language.SPN => "Applin",
						Language.KOR => "과사삭벌레",
						Language.CHN_SIM => "啃果虫",
						Language.CHN_TRA => "啃果蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLAPPLE:
					return lang switch {
						Language.ENG => "Flapple",
						Language.JPN => "アップリュー",
						Language.GER => "Drapfel",
						Language.FRE => "Pomdrapi",
						Language.ITA => "Flapple",
						Language.SPN => "Flapple",
						Language.KOR => "애프룡",
						Language.CHN_SIM => "苹裹龙",
						Language.CHN_TRA => "蘋裹龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.APPLETUN:
					return lang switch {
						Language.ENG => "Appletun",
						Language.JPN => "タルップル",
						Language.GER => "Schlapfel",
						Language.FRE => "Dratatin",
						Language.ITA => "Appletun",
						Language.SPN => "Appletun",
						Language.KOR => "단지래플",
						Language.CHN_SIM => "丰蜜龙",
						Language.CHN_TRA => "豐蜜龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SILICOBRA:
					return lang switch {
						Language.ENG => "Silicobra",
						Language.JPN => "スナヘビ",
						Language.GER => "Salanga",
						Language.FRE => "Dunaja",
						Language.ITA => "Silicobra",
						Language.SPN => "Silicobra",
						Language.KOR => "모래뱀",
						Language.CHN_SIM => "沙包蛇",
						Language.CHN_TRA => "沙包蛇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDACONDA:
					return lang switch {
						Language.ENG => "Sandaconda",
						Language.JPN => "サダイジャ",
						Language.GER => "Sanaconda",
						Language.FRE => "Dunaconda",
						Language.ITA => "Sandaconda",
						Language.SPN => "Sandaconda",
						Language.KOR => "사다이사",
						Language.CHN_SIM => "沙螺蟒",
						Language.CHN_TRA => "沙螺蟒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CRAMORANT:
					return lang switch {
						Language.ENG => "Cramorant",
						Language.JPN => "ウッウ",
						Language.GER => "Urgl",
						Language.FRE => "Nigosier",
						Language.ITA => "Cramorant",
						Language.SPN => "Cramorant",
						Language.KOR => "윽우지",
						Language.CHN_SIM => "古月鸟",
						Language.CHN_TRA => "古月鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARROKUDA:
					return lang switch {
						Language.ENG => "Arrokuda",
						Language.JPN => "サシカマス",
						Language.GER => "Pikuda",
						Language.FRE => "Embrochet",
						Language.ITA => "Arrokuda",
						Language.SPN => "Arrokuda",
						Language.KOR => "찌로꼬치",
						Language.CHN_SIM => "刺梭鱼",
						Language.CHN_TRA => "刺梭魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BARRASKEWDA:
					return lang switch {
						Language.ENG => "Barraskewda",
						Language.JPN => "カマスジョー",
						Language.GER => "Barrakiefa",
						Language.FRE => "Hastacuda",
						Language.ITA => "Barraskewda",
						Language.SPN => "Barraskewda",
						Language.KOR => "꼬치조",
						Language.CHN_SIM => "戽斗尖梭",
						Language.CHN_TRA => "戽斗尖梭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOXEL:
					return lang switch {
						Language.ENG => "Toxel",
						Language.JPN => "エレズン",
						Language.GER => "Toxel",
						Language.FRE => "Toxizap",
						Language.ITA => "Toxel",
						Language.SPN => "Toxel",
						Language.KOR => "일레즌",
						Language.CHN_SIM => "电音婴",
						Language.CHN_TRA => "毒電嬰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOXTRICITY_AMPED_FORM:
					return lang switch {
						Language.ENG => "Toxtricity",
						Language.JPN => "ストリンダー",
						Language.GER => "Riffex",
						Language.FRE => "Salarsen",
						Language.ITA => "Toxtricity",
						Language.SPN => "Toxtricity",
						Language.KOR => "스트린더",
						Language.CHN_SIM => "颤弦蝾螈",
						Language.CHN_TRA => "顫弦蠑螈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOXTRICITY_LOW_KEY_FORM:
					return lang switch {
						Language.ENG => "Toxtricity",
						Language.JPN => "ストリンダー",
						Language.GER => "Riffex",
						Language.FRE => "Salarsen",
						Language.ITA => "Toxtricity",
						Language.SPN => "Toxtricity",
						Language.KOR => "스트린더",
						Language.CHN_SIM => "颤弦蝾螈",
						Language.CHN_TRA => "顫弦蠑螈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SIZZLIPEDE:
					return lang switch {
						Language.ENG => "Sizzlipede",
						Language.JPN => "ヤクデ",
						Language.GER => "Thermopod",
						Language.FRE => "Grillepattes",
						Language.ITA => "Sizzlipede",
						Language.SPN => "Sizzlipede",
						Language.KOR => "태우지네",
						Language.CHN_SIM => "烧火蚣",
						Language.CHN_TRA => "燒火蚣",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CENTISKORCH:
					return lang switch {
						Language.ENG => "Centiskorch",
						Language.JPN => "マルヤクデ",
						Language.GER => "Infernopod",
						Language.FRE => "Scolocendre",
						Language.ITA => "Centiskorch",
						Language.SPN => "Centiskorch",
						Language.KOR => "다태우지네",
						Language.CHN_SIM => "焚焰蚣",
						Language.CHN_TRA => "焚焰蚣",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLOBBOPUS:
					return lang switch {
						Language.ENG => "Clobbopus",
						Language.JPN => "タタッコ",
						Language.GER => "Klopptopus",
						Language.FRE => "Poulpaf",
						Language.ITA => "Clobbopus",
						Language.SPN => "Clobbopus",
						Language.KOR => "때때무노",
						Language.CHN_SIM => "拳拳蛸",
						Language.CHN_TRA => "拳拳蛸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRAPPLOCT:
					return lang switch {
						Language.ENG => "Grapploct",
						Language.JPN => "オトスパス",
						Language.GER => "Kaocto",
						Language.FRE => "Krakos",
						Language.ITA => "Grapploct",
						Language.SPN => "Grapploct",
						Language.KOR => "케오퍼스",
						Language.CHN_SIM => "八爪武师",
						Language.CHN_TRA => "八爪武師",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SINISTEA:
					return lang switch {
						Language.ENG => "Sinistea",
						Language.JPN => "ヤバチャ",
						Language.GER => "Fatalitee",
						Language.FRE => "Théffroi",
						Language.ITA => "Sinistea",
						Language.SPN => "Sinistea",
						Language.KOR => "데인차",
						Language.CHN_SIM => "来悲茶",
						Language.CHN_TRA => "來悲茶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.POLTEAGEIST:
					return lang switch {
						Language.ENG => "Polteageist",
						Language.JPN => "ポットデス",
						Language.GER => "Mortipot",
						Language.FRE => "Polthégeist",
						Language.ITA => "Polteageist",
						Language.SPN => "Polteageist",
						Language.KOR => "포트데스",
						Language.CHN_SIM => "怖思壶",
						Language.CHN_TRA => "怖思壺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HATENNA:
					return lang switch {
						Language.ENG => "Hatenna",
						Language.JPN => "ミブリム",
						Language.GER => "Brimova",
						Language.FRE => "Bibichut",
						Language.ITA => "Hatenna",
						Language.SPN => "Hatenna",
						Language.KOR => "몸지브림",
						Language.CHN_SIM => "迷布莉姆",
						Language.CHN_TRA => "迷布莉姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HATTREM:
					return lang switch {
						Language.ENG => "Hattrem",
						Language.JPN => "テブリム",
						Language.GER => "Brimano",
						Language.FRE => "Chapotus",
						Language.ITA => "Hattrem",
						Language.SPN => "Hattrem",
						Language.KOR => "손지브림",
						Language.CHN_SIM => "提布莉姆",
						Language.CHN_TRA => "提布莉姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HATTERENE:
					return lang switch {
						Language.ENG => "Hatterene",
						Language.JPN => "ブリムオン",
						Language.GER => "Silembrim",
						Language.FRE => "Sorcilence",
						Language.ITA => "Hatterene",
						Language.SPN => "Hatterene",
						Language.KOR => "브리무음",
						Language.CHN_SIM => "布莉姆温",
						Language.CHN_TRA => "布莉姆溫",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IMPIDIMP:
					return lang switch {
						Language.ENG => "Impidimp",
						Language.JPN => "ベロバー",
						Language.GER => "Bähmon",
						Language.FRE => "Grimalin",
						Language.ITA => "Impidimp",
						Language.SPN => "Impidimp",
						Language.KOR => "메롱꿍",
						Language.CHN_SIM => "捣蛋小妖",
						Language.CHN_TRA => "搗蛋小妖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MORGREM:
					return lang switch {
						Language.ENG => "Morgrem",
						Language.JPN => "ギモー",
						Language.GER => "Pelzebub",
						Language.FRE => "Fourbelin",
						Language.ITA => "Morgrem",
						Language.SPN => "Morgrem",
						Language.KOR => "쏘겨모",
						Language.CHN_SIM => "诈唬魔",
						Language.CHN_TRA => "詐唬魔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRIMMSNARL:
					return lang switch {
						Language.ENG => "Grimmsnarl",
						Language.JPN => "オーロンゲ",
						Language.GER => "Olangaar",
						Language.FRE => "Angoliath",
						Language.ITA => "Grimmsnarl",
						Language.SPN => "Grimmsnarl",
						Language.KOR => "오롱털",
						Language.CHN_SIM => "长毛巨魔",
						Language.CHN_TRA => "長毛巨魔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OBSTAGOON:
					return lang switch {
						Language.ENG => "Obstagoon",
						Language.JPN => "タチフサグマ",
						Language.GER => "Barrikadax",
						Language.FRE => "Ixon",
						Language.ITA => "Obstagoon",
						Language.SPN => "Obstagoon",
						Language.KOR => "가로막구리",
						Language.CHN_SIM => "堵拦熊",
						Language.CHN_TRA => "堵攔熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PERRSERKER:
					return lang switch {
						Language.ENG => "Perrserker",
						Language.JPN => "ニャイキング",
						Language.GER => "Mauzinger",
						Language.FRE => "Berserkatt",
						Language.ITA => "Perrserker",
						Language.SPN => "Perrserker",
						Language.KOR => "나이킹",
						Language.CHN_SIM => "喵头目",
						Language.CHN_TRA => "喵頭目",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CURSOLA:
					return lang switch {
						Language.ENG => "Cursola",
						Language.JPN => "サニゴーン",
						Language.GER => "Gorgasonn",
						Language.FRE => "Corayôme",
						Language.ITA => "Cursola",
						Language.SPN => "Cursola",
						Language.KOR => "산호르곤",
						Language.CHN_SIM => "魔灵珊瑚",
						Language.CHN_TRA => "魔靈珊瑚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SIRFETCH_D:
					return lang switch {
						Language.ENG => "Sirfetch’d",
						Language.JPN => "ネギガナイト",
						Language.GER => "Lauchzelot",
						Language.FRE => "Palarticho",
						Language.ITA => "Sirfetch’d",
						Language.SPN => "Sirfetch’d",
						Language.KOR => "창파나이트",
						Language.CHN_SIM => "葱游兵",
						Language.CHN_TRA => "蔥遊兵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MR_RIME:
					return lang switch {
						Language.ENG => "Mr. Rime",
						Language.JPN => "バリコオル",
						Language.GER => "Pantifrost",
						Language.FRE => "M. Glaquette",
						Language.ITA => "Mr. Rime",
						Language.SPN => "Mr. Rime",
						Language.KOR => "마임꽁꽁",
						Language.CHN_SIM => "踏冰人偶",
						Language.CHN_TRA => "踏冰人偶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RUNERIGUS:
					return lang switch {
						Language.ENG => "Runerigus",
						Language.JPN => "デスバーン",
						Language.GER => "Oghnatoll",
						Language.FRE => "Tutétékri",
						Language.ITA => "Runerigus",
						Language.SPN => "Runerigus",
						Language.KOR => "데스판",
						Language.CHN_SIM => "迭失板",
						Language.CHN_TRA => "死神板",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MILCERY:
					return lang switch {
						Language.ENG => "Milcery",
						Language.JPN => "マホミル",
						Language.GER => "Hokumil",
						Language.FRE => "Crèmy",
						Language.ITA => "Milcery",
						Language.SPN => "Milcery",
						Language.KOR => "마빌크",
						Language.CHN_SIM => "小仙奶",
						Language.CHN_TRA => "小仙奶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ALCREMIE:
					return lang switch {
						Language.ENG => "Alcremie",
						Language.JPN => "マホイップ",
						Language.GER => "Pokusan",
						Language.FRE => "Charmilly",
						Language.ITA => "Alcremie",
						Language.SPN => "Alcremie",
						Language.KOR => "마휘핑",
						Language.CHN_SIM => "霜奶仙",
						Language.CHN_TRA => "霜奶仙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FALINKS:
					return lang switch {
						Language.ENG => "Falinks",
						Language.JPN => "タイレーツ",
						Language.GER => "Legios",
						Language.FRE => "Hexadron",
						Language.ITA => "Falinks",
						Language.SPN => "Falinks",
						Language.KOR => "대여르",
						Language.CHN_SIM => "列阵兵",
						Language.CHN_TRA => "列陣兵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PINCURCHIN:
					return lang switch {
						Language.ENG => "Pincurchin",
						Language.JPN => "バチンウニ",
						Language.GER => "Britzigel",
						Language.FRE => "Wattapik",
						Language.ITA => "Pincurchin",
						Language.SPN => "Pincurchin",
						Language.KOR => "찌르성게",
						Language.CHN_SIM => "啪嚓海胆",
						Language.CHN_TRA => "啪嚓海膽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNOM:
					return lang switch {
						Language.ENG => "Snom",
						Language.JPN => "ユキハミ",
						Language.GER => "Snomnom",
						Language.FRE => "Frissonille",
						Language.ITA => "Snom",
						Language.SPN => "Snom",
						Language.KOR => "누니머기",
						Language.CHN_SIM => "雪吞虫",
						Language.CHN_TRA => "雪吞蟲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FROSMOTH:
					return lang switch {
						Language.ENG => "Frosmoth",
						Language.JPN => "モスノウ",
						Language.GER => "Mottineva",
						Language.FRE => "Beldeneige",
						Language.ITA => "Frosmoth",
						Language.SPN => "Frosmoth",
						Language.KOR => "모스노우",
						Language.CHN_SIM => "雪绒蛾",
						Language.CHN_TRA => "雪絨蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.STONJOURNER:
					return lang switch {
						Language.ENG => "Stonjourner",
						Language.JPN => "イシヘンジン",
						Language.GER => "Humanolith",
						Language.FRE => "Dolman",
						Language.ITA => "Stonjourner",
						Language.SPN => "Stonjourner",
						Language.KOR => "돌헨진",
						Language.CHN_SIM => "巨石丁",
						Language.CHN_TRA => "巨石丁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EISCUE_ICE_FACE:
					return lang switch {
						Language.ENG => "Eiscue",
						Language.JPN => "コオリッポ",
						Language.GER => "Kubuin",
						Language.FRE => "Bekaglaçon",
						Language.ITA => "Eiscue",
						Language.SPN => "Eiscue",
						Language.KOR => "빙큐보",
						Language.CHN_SIM => "冰砌鹅",
						Language.CHN_TRA => "冰砌鵝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.EISCUE_NOICE_FACE:
					return lang switch {
						Language.ENG => "Eiscue",
						Language.JPN => "コオリッポ",
						Language.GER => "Kubuin",
						Language.FRE => "Bekaglaçon",
						Language.ITA => "Eiscue",
						Language.SPN => "Eiscue",
						Language.KOR => "빙큐보",
						Language.CHN_SIM => "冰砌鹅",
						Language.CHN_TRA => "冰砌鵝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.INDEEDEE_MALE:
					return lang switch {
						Language.ENG => "Indeedee",
						Language.JPN => "イエッサン",
						Language.GER => "Servol",
						Language.FRE => "Wimessir",
						Language.ITA => "Indeedee",
						Language.SPN => "Indeedee",
						Language.KOR => "에써르",
						Language.CHN_SIM => "爱管侍",
						Language.CHN_TRA => "愛管侍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.INDEEDEE_FEMALE:
					return lang switch {
						Language.ENG => "Indeedee",
						Language.JPN => "イエッサン",
						Language.GER => "Servol",
						Language.FRE => "Wimessir",
						Language.ITA => "Indeedee",
						Language.SPN => "Indeedee",
						Language.KOR => "에써르",
						Language.CHN_SIM => "爱管侍",
						Language.CHN_TRA => "愛管侍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MORPEKO_FULL_BELLY_MODE:
					return lang switch {
						Language.ENG => "Morpeko",
						Language.JPN => "モルペコ",
						Language.GER => "Morpeko",
						Language.FRE => "Morpeko",
						Language.ITA => "Morpeko",
						Language.SPN => "Morpeko",
						Language.KOR => "모르페코",
						Language.CHN_SIM => "莫鲁贝可",
						Language.CHN_TRA => "莫魯貝可",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MORPEKO_HANGRY_MODE:
					return lang switch {
						Language.ENG => "Morpeko",
						Language.JPN => "モルペコ",
						Language.GER => "Morpeko",
						Language.FRE => "Morpeko",
						Language.ITA => "Morpeko",
						Language.SPN => "Morpeko",
						Language.KOR => "모르페코",
						Language.CHN_SIM => "莫鲁贝可",
						Language.CHN_TRA => "莫魯貝可",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CUFANT:
					return lang switch {
						Language.ENG => "Cufant",
						Language.JPN => "ゾウドウ",
						Language.GER => "Kupfanti",
						Language.FRE => "Charibari",
						Language.ITA => "Cufant",
						Language.SPN => "Cufant",
						Language.KOR => "끼리동",
						Language.CHN_SIM => "铜象",
						Language.CHN_TRA => "銅象",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.COPPERAJAH:
					return lang switch {
						Language.ENG => "Copperajah",
						Language.JPN => "ダイオウドウ",
						Language.GER => "Patinaraja",
						Language.FRE => "Pachyradjah",
						Language.ITA => "Copperajah",
						Language.SPN => "Copperajah",
						Language.KOR => "대왕끼리동",
						Language.CHN_SIM => "大王铜象",
						Language.CHN_TRA => "大王銅象",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRACOZOLT:
					return lang switch {
						Language.ENG => "Dracozolt",
						Language.JPN => "パッチラゴン",
						Language.GER => "Lectragon",
						Language.FRE => "Galvagon",
						Language.ITA => "Dracozolt",
						Language.SPN => "Dracozolt",
						Language.KOR => "파치래곤",
						Language.CHN_SIM => "雷鸟龙",
						Language.CHN_TRA => "雷鳥龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCTOZOLT:
					return lang switch {
						Language.ENG => "Arctozolt",
						Language.JPN => "パッチルドン",
						Language.GER => "Lecryodon",
						Language.FRE => "Galvagla",
						Language.ITA => "Arctozolt",
						Language.SPN => "Arctozolt",
						Language.KOR => "파치르돈",
						Language.CHN_SIM => "雷鸟海兽",
						Language.CHN_TRA => "雷鳥海獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRACOVISH:
					return lang switch {
						Language.ENG => "Dracovish",
						Language.JPN => "ウオノラゴン",
						Language.GER => "Pescragon",
						Language.FRE => "Hydragon",
						Language.ITA => "Dracovish",
						Language.SPN => "Dracovish",
						Language.KOR => "어래곤",
						Language.CHN_SIM => "鳃鱼龙",
						Language.CHN_TRA => "鰓魚龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCTOVISH:
					return lang switch {
						Language.ENG => "Arctovish",
						Language.JPN => "ウオチルドン",
						Language.GER => "Pescryodon",
						Language.FRE => "Hydragla",
						Language.ITA => "Arctovish",
						Language.SPN => "Arctovish",
						Language.KOR => "어치르돈",
						Language.CHN_SIM => "鳃鱼海兽",
						Language.CHN_TRA => "鰓魚海獸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DURALUDON:
					return lang switch {
						Language.ENG => "Duraludon",
						Language.JPN => "ジュラルドン",
						Language.GER => "Duraludon",
						Language.FRE => "Duralugon",
						Language.ITA => "Duraludon",
						Language.SPN => "Duraludon",
						Language.KOR => "두랄루돈",
						Language.CHN_SIM => "铝钢龙",
						Language.CHN_TRA => "鋁鋼龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DREEPY:
					return lang switch {
						Language.ENG => "Dreepy",
						Language.JPN => "ドラメシヤ",
						Language.GER => "Grolldra",
						Language.FRE => "Fantyrm",
						Language.ITA => "Dreepy",
						Language.SPN => "Dreepy",
						Language.KOR => "드라꼰",
						Language.CHN_SIM => "多龙梅西亚",
						Language.CHN_TRA => "多龍梅西亞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAKLOAK:
					return lang switch {
						Language.ENG => "Drakloak",
						Language.JPN => "ドロンチ",
						Language.GER => "Phandra",
						Language.FRE => "Dispareptil",
						Language.ITA => "Drakloak",
						Language.SPN => "Drakloak",
						Language.KOR => "드래런치",
						Language.CHN_SIM => "多龙奇",
						Language.CHN_TRA => "多龍奇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DRAGAPULT:
					return lang switch {
						Language.ENG => "Dragapult",
						Language.JPN => "ドラパルト",
						Language.GER => "Katapuldra",
						Language.FRE => "Lanssorien",
						Language.ITA => "Dragapult",
						Language.SPN => "Dragapult",
						Language.KOR => "드래펄트",
						Language.CHN_SIM => "多龙巴鲁托",
						Language.CHN_TRA => "多龍巴魯托",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZACIAN_HERO_OF_MANY_BATTLES:
					return lang switch {
						Language.ENG => "Zacian",
						Language.JPN => "ザシアン",
						Language.GER => "Zacian",
						Language.FRE => "Zacian",
						Language.ITA => "Zacian",
						Language.SPN => "Zacian",
						Language.KOR => "자시안",
						Language.CHN_SIM => "苍响",
						Language.CHN_TRA => "蒼響",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZACIAN_CROWNED_SWORD:
					return lang switch {
						Language.ENG => "Zacian",
						Language.JPN => "ザシアン",
						Language.GER => "Zacian",
						Language.FRE => "Zacian",
						Language.ITA => "Zacian",
						Language.SPN => "Zacian",
						Language.KOR => "자시안",
						Language.CHN_SIM => "苍响",
						Language.CHN_TRA => "蒼響",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZAMAZENTA_HERO_OF_MANY_BATTLES:
					return lang switch {
						Language.ENG => "Zamazenta",
						Language.JPN => "ザマゼンタ",
						Language.GER => "Zamazenta",
						Language.FRE => "Zamazenta",
						Language.ITA => "Zamazenta",
						Language.SPN => "Zamazenta",
						Language.KOR => "자마젠타",
						Language.CHN_SIM => "藏玛然特",
						Language.CHN_TRA => "藏瑪然特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZAMAZENTA_CROWNED_SHIELD:
					return lang switch {
						Language.ENG => "Zamazenta",
						Language.JPN => "ザマゼンタ",
						Language.GER => "Zamazenta",
						Language.FRE => "Zamazenta",
						Language.ITA => "Zamazenta",
						Language.SPN => "Zamazenta",
						Language.KOR => "자마젠타",
						Language.CHN_SIM => "藏玛然特",
						Language.CHN_TRA => "藏瑪然特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ETERNATUS:
					return lang switch {
						Language.ENG => "Eternatus",
						Language.JPN => "ムゲンダイナ",
						Language.GER => "Endynalos",
						Language.FRE => "Éthernatos",
						Language.ITA => "Eternatus",
						Language.SPN => "Eternatus",
						Language.KOR => "무한다이노",
						Language.CHN_SIM => "无极汰那",
						Language.CHN_TRA => "無極汰那",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ETERNATUS_ETERNAMAX:
					return lang switch {
						Language.ENG => "Eternatus",
						Language.JPN => "ムゲンダイナ",
						Language.GER => "Endynalos",
						Language.FRE => "Éthernatos",
						Language.ITA => "Eternatus",
						Language.SPN => "Eternatus",
						Language.KOR => "무한다이노",
						Language.CHN_SIM => "无极汰那",
						Language.CHN_TRA => "無極汰那",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KUBFU:
					return lang switch {
						Language.ENG => "Kubfu",
						Language.JPN => "ダクマ",
						Language.GER => "Dakuma",
						Language.FRE => "Wushours",
						Language.ITA => "Kubfu",
						Language.SPN => "Kubfu",
						Language.KOR => "치고마",
						Language.CHN_SIM => "熊徒弟",
						Language.CHN_TRA => "熊徒弟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.URSHIFU_SINGLE_STRIKE_STYLE:
					return lang switch {
						Language.ENG => "Urshifu",
						Language.JPN => "ウーラオス",
						Language.GER => "Wulaosu",
						Language.FRE => "Shifours",
						Language.ITA => "Urshifu",
						Language.SPN => "Urshifu",
						Language.KOR => "우라오스",
						Language.CHN_SIM => "武道熊师",
						Language.CHN_TRA => "武道熊師",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.URSHIFU_RAPID_STRIKE_STYLE:
					return lang switch {
						Language.ENG => "Urshifu",
						Language.JPN => "ウーラオス",
						Language.GER => "Wulaosu",
						Language.FRE => "Shifours",
						Language.ITA => "Urshifu",
						Language.SPN => "Urshifu",
						Language.KOR => "우라오스",
						Language.CHN_SIM => "武道熊师",
						Language.CHN_TRA => "武道熊師",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ZARUDE:
					return lang switch {
						Language.ENG => "Zarude",
						Language.JPN => "ザルード",
						Language.GER => "Zarude",
						Language.FRE => "Zarude",
						Language.ITA => "Zarude",
						Language.SPN => "Zarude",
						Language.KOR => "자루도",
						Language.CHN_SIM => "萨戮德",
						Language.CHN_TRA => "薩戮德",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REGIELEKI:
					return lang switch {
						Language.ENG => "Regieleki",
						Language.JPN => "レジエレキ",
						Language.GER => "Regieleki",
						Language.FRE => "Regieleki",
						Language.ITA => "Regieleki",
						Language.SPN => "Regieleki",
						Language.KOR => "레지에레키",
						Language.CHN_SIM => "雷吉艾勒奇",
						Language.CHN_TRA => "雷吉艾勒奇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REGIDRAGO:
					return lang switch {
						Language.ENG => "Regidrago",
						Language.JPN => "レジドラゴ",
						Language.GER => "Regidrago",
						Language.FRE => "Regidrago",
						Language.ITA => "Regidrago",
						Language.SPN => "Regidrago",
						Language.KOR => "레지드래고",
						Language.CHN_SIM => "雷吉铎拉戈",
						Language.CHN_TRA => "雷吉鐸拉戈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLASTRIER:
					return lang switch {
						Language.ENG => "Glastrier",
						Language.JPN => "ブリザポス",
						Language.GER => "Polaross",
						Language.FRE => "Blizzeval",
						Language.ITA => "Glastrier",
						Language.SPN => "Glastrier",
						Language.KOR => "블리자포스",
						Language.CHN_SIM => "雪暴马",
						Language.CHN_TRA => "雪暴馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPECTRIER:
					return lang switch {
						Language.ENG => "Spectrier",
						Language.JPN => "レイスポス",
						Language.GER => "Phantoross",
						Language.FRE => "Spectreval",
						Language.ITA => "Spectrier",
						Language.SPN => "Spectrier",
						Language.KOR => "레이스포스",
						Language.CHN_SIM => "灵幽马",
						Language.CHN_TRA => "靈幽馬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CALYREX:
					return lang switch {
						Language.ENG => "Calyrex",
						Language.JPN => "バドレックス",
						Language.GER => "Coronospa",
						Language.FRE => "Sylveroy",
						Language.ITA => "Calyrex",
						Language.SPN => "Calyrex",
						Language.KOR => "버드렉스",
						Language.CHN_SIM => "蕾冠王",
						Language.CHN_TRA => "蕾冠王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CALYREX_ICE_RIDER:
					return lang switch {
						Language.ENG => "Calyrex",
						Language.JPN => "バドレックス",
						Language.GER => "Coronospa",
						Language.FRE => "Sylveroy",
						Language.ITA => "Calyrex",
						Language.SPN => "Calyrex",
						Language.KOR => "버드렉스",
						Language.CHN_SIM => "蕾冠王",
						Language.CHN_TRA => "蕾冠王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CALYREX_SHADOW_RIDER:
					return lang switch {
						Language.ENG => "Calyrex",
						Language.JPN => "バドレックス",
						Language.GER => "Coronospa",
						Language.FRE => "Sylveroy",
						Language.ITA => "Calyrex",
						Language.SPN => "Calyrex",
						Language.KOR => "버드렉스",
						Language.CHN_SIM => "蕾冠王",
						Language.CHN_TRA => "蕾冠王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WYRDEER:
					return lang switch {
						Language.ENG => "Wyrdeer",
						Language.JPN => "アヤシシ",
						Language.GER => "Damythir",
						Language.FRE => "Cerbyllin",
						Language.ITA => "Wyrdeer",
						Language.SPN => "Wyrdeer",
						Language.KOR => "신비록",
						Language.CHN_SIM => "诡角鹿",
						Language.CHN_TRA => "詭角鹿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KLEAVOR:
					return lang switch {
						Language.ENG => "Kleavor",
						Language.JPN => "バサギリ",
						Language.GER => "Axantor",
						Language.FRE => "Hachécateur",
						Language.ITA => "Kleavor",
						Language.SPN => "Kleavor",
						Language.KOR => "사마자르",
						Language.CHN_SIM => "劈斧螳螂",
						Language.CHN_TRA => "劈斧螳螂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.URSALUNA:
					return lang switch {
						Language.ENG => "Ursaluna",
						Language.JPN => "ガチグマ",
						Language.GER => "Ursaluna",
						Language.FRE => "Ursaking",
						Language.ITA => "Ursaluna",
						Language.SPN => "Ursaluna",
						Language.KOR => "다투곰",
						Language.CHN_SIM => "月月熊",
						Language.CHN_TRA => "月月熊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BASCULEGION_MALE:
					return lang switch {
						Language.ENG => "Basculegion",
						Language.JPN => "イダイトウ",
						Language.GER => "Salmagnis",
						Language.FRE => "Paragruel",
						Language.ITA => "Basculegion",
						Language.SPN => "Basculegion",
						Language.KOR => "대쓰여너",
						Language.CHN_SIM => "幽尾玄鱼",
						Language.CHN_TRA => "幽尾玄魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BASCULEGION_FEMALE:
					return lang switch {
						Language.ENG => "Basculegion",
						Language.JPN => "イダイトウ",
						Language.GER => "Salmagnis",
						Language.FRE => "Paragruel",
						Language.ITA => "Basculegion",
						Language.SPN => "Basculegion",
						Language.KOR => "대쓰여너",
						Language.CHN_SIM => "幽尾玄鱼",
						Language.CHN_TRA => "幽尾玄魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SNEASLER:
					return lang switch {
						Language.ENG => "Sneasler",
						Language.JPN => "オオニューラ",
						Language.GER => "Snieboss",
						Language.FRE => "Farfurex",
						Language.ITA => "Sneasler",
						Language.SPN => "Sneasler",
						Language.KOR => "포푸니크",
						Language.CHN_SIM => "大狃拉",
						Language.CHN_TRA => "大狃拉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OVERQWIL:
					return lang switch {
						Language.ENG => "Overqwil",
						Language.JPN => "ハリーマン",
						Language.GER => "Myriador",
						Language.FRE => "Qwilpik",
						Language.ITA => "Overqwil",
						Language.SPN => "Overqwil",
						Language.KOR => "장침바루",
						Language.CHN_SIM => "万针鱼",
						Language.CHN_TRA => "萬針魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ENAMORUS_INCARNATE_FORME:
					return lang switch {
						Language.ENG => "Enamorus",
						Language.JPN => "ラブトロス",
						Language.GER => "Cupidos",
						Language.FRE => "Amovénus",
						Language.ITA => "Enamorus",
						Language.SPN => "Enamorus",
						Language.KOR => "러브로스",
						Language.CHN_SIM => "眷恋云",
						Language.CHN_TRA => "眷戀雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ENAMORUS_THERIAN_FORME:
					return lang switch {
						Language.ENG => "Enamorus",
						Language.JPN => "ラブトロス",
						Language.GER => "Cupidos",
						Language.FRE => "Amovénus",
						Language.ITA => "Enamorus",
						Language.SPN => "Enamorus",
						Language.KOR => "러브로스",
						Language.CHN_SIM => "眷恋云",
						Language.CHN_TRA => "眷戀雲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPRIGATITO:
					return lang switch {
						Language.ENG => "Sprigatito",
						Language.JPN => "ニャオハ",
						Language.GER => "Felori",
						Language.FRE => "Poussacha",
						Language.ITA => "Sprigatito",
						Language.SPN => "Sprigatito",
						Language.KOR => "나오하",
						Language.CHN_SIM => "新叶喵",
						Language.CHN_TRA => "新葉喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLORAGATO:
					return lang switch {
						Language.ENG => "Floragato",
						Language.JPN => "ニャローテ",
						Language.GER => "Feliospa",
						Language.FRE => "Matourgeon",
						Language.ITA => "Floragato",
						Language.SPN => "Floragato",
						Language.KOR => "나로테",
						Language.CHN_SIM => "蒂蕾喵",
						Language.CHN_TRA => "蒂蕾喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MEOWSCARADA:
					return lang switch {
						Language.ENG => "Meowscarada",
						Language.JPN => "マスカーニャ",
						Language.GER => "Maskagato",
						Language.FRE => "Miascarade",
						Language.ITA => "Meowscarada",
						Language.SPN => "Meowscarada",
						Language.KOR => "마스카나",
						Language.CHN_SIM => "魔幻假面喵",
						Language.CHN_TRA => "魔幻假面喵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FUECOCO:
					return lang switch {
						Language.ENG => "Fuecoco",
						Language.JPN => "ホゲータ",
						Language.GER => "Krokel",
						Language.FRE => "Chochodile",
						Language.ITA => "Fuecoco",
						Language.SPN => "Fuecoco",
						Language.KOR => "뜨아거",
						Language.CHN_SIM => "呆火鳄",
						Language.CHN_TRA => "呆火鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CROCALOR:
					return lang switch {
						Language.ENG => "Crocalor",
						Language.JPN => "アチゲータ",
						Language.GER => "Lokroko",
						Language.FRE => "Crocogril",
						Language.ITA => "Crocalor",
						Language.SPN => "Crocalor",
						Language.KOR => "악뜨거",
						Language.CHN_SIM => "炙烫鳄",
						Language.CHN_TRA => "炙燙鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SKELEDIRGE:
					return lang switch {
						Language.ENG => "Skeledirge",
						Language.JPN => "ラウドボーン",
						Language.GER => "Skelokrok",
						Language.FRE => "Flâmigator",
						Language.ITA => "Skeledirge",
						Language.SPN => "Skeledirge",
						Language.KOR => "라우드본",
						Language.CHN_SIM => "骨纹巨声鳄",
						Language.CHN_TRA => "骨紋巨聲鱷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QUAXLY:
					return lang switch {
						Language.ENG => "Quaxly",
						Language.JPN => "クワッス",
						Language.GER => "Kwaks",
						Language.FRE => "Coiffeton",
						Language.ITA => "Quaxly",
						Language.SPN => "Quaxly",
						Language.KOR => "꾸왁스",
						Language.CHN_SIM => "润水鸭",
						Language.CHN_TRA => "潤水鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QUAXWELL:
					return lang switch {
						Language.ENG => "Quaxwell",
						Language.JPN => "ウェルカモ",
						Language.GER => "Fuentente",
						Language.FRE => "Canarbello",
						Language.ITA => "Quaxwell",
						Language.SPN => "Quaxwell",
						Language.KOR => "아꾸왁",
						Language.CHN_SIM => "涌跃鸭",
						Language.CHN_TRA => "湧躍鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.QUAQUAVAL:
					return lang switch {
						Language.ENG => "Quaquaval",
						Language.JPN => "ウェーニバル",
						Language.GER => "Bailonda",
						Language.FRE => "Palmaval",
						Language.ITA => "Quaquaval",
						Language.SPN => "Quaquaval",
						Language.KOR => "웨이니발",
						Language.CHN_SIM => "狂欢浪舞鸭",
						Language.CHN_TRA => "狂歡浪舞鴨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LECHONK:
					return lang switch {
						Language.ENG => "Lechonk",
						Language.JPN => "グルトン",
						Language.GER => "Ferkuli",
						Language.FRE => "Gourmelet",
						Language.ITA => "Lechonk",
						Language.SPN => "Lechonk",
						Language.KOR => "맛보돈",
						Language.CHN_SIM => "爱吃豚",
						Language.CHN_TRA => "愛吃豚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OINKOLOGNE_MALE:
					return lang switch {
						Language.ENG => "Oinkologne",
						Language.JPN => "パフュートン",
						Language.GER => "Fragrunz",
						Language.FRE => "Fragroin",
						Language.ITA => "Oinkologne",
						Language.SPN => "Oinkologne",
						Language.KOR => "퍼퓨돈",
						Language.CHN_SIM => "飘香豚",
						Language.CHN_TRA => "飄香豚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.OINKOLOGNE_FEMALE:
					return lang switch {
						Language.ENG => "Oinkologne",
						Language.JPN => "パフュートン",
						Language.GER => "Fragrunz",
						Language.FRE => "Fragroin",
						Language.ITA => "Oinkologne",
						Language.SPN => "Oinkologne",
						Language.KOR => "퍼퓨돈",
						Language.CHN_SIM => "飘香豚",
						Language.CHN_TRA => "飄香豚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TAROUNTULA:
					return lang switch {
						Language.ENG => "Tarountula",
						Language.JPN => "タマンチュラ",
						Language.GER => "Tarundel",
						Language.FRE => "Tissenboule",
						Language.ITA => "Tarountula",
						Language.SPN => "Tarountula",
						Language.KOR => "타랜툴라",
						Language.CHN_SIM => "团珠蛛",
						Language.CHN_TRA => "團珠蛛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SPIDOPS:
					return lang switch {
						Language.ENG => "Spidops",
						Language.JPN => "ワナイダー",
						Language.GER => "Spinsidias",
						Language.FRE => "Filentrappe",
						Language.ITA => "Spidops",
						Language.SPN => "Spidops",
						Language.KOR => "트래피더",
						Language.CHN_SIM => "操陷蛛",
						Language.CHN_TRA => "操陷蛛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NYMBLE:
					return lang switch {
						Language.ENG => "Nymble",
						Language.JPN => "マメバッタ",
						Language.GER => "Micrick",
						Language.FRE => "Lilliterelle",
						Language.ITA => "Nymble",
						Language.SPN => "Nymble",
						Language.KOR => "콩알뚜기",
						Language.CHN_SIM => "豆蟋蟀",
						Language.CHN_TRA => "豆蟋蟀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.LOKIX:
					return lang switch {
						Language.ENG => "Lokix",
						Language.JPN => "エクスレッグ",
						Language.GER => "Lextremo",
						Language.FRE => "Gambex",
						Language.ITA => "Lokix",
						Language.SPN => "Lokix",
						Language.KOR => "엑스레그",
						Language.CHN_SIM => "烈腿蝗",
						Language.CHN_TRA => "烈腿蝗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PAWMI:
					return lang switch {
						Language.ENG => "Pawmi",
						Language.JPN => "パモ",
						Language.GER => "Pamo",
						Language.FRE => "Pohm",
						Language.ITA => "Pawmi",
						Language.SPN => "Pawmi",
						Language.KOR => "빠모",
						Language.CHN_SIM => "布拨",
						Language.CHN_TRA => "布撥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PAWMO:
					return lang switch {
						Language.ENG => "Pawmo",
						Language.JPN => "パモット",
						Language.GER => "Pamamo",
						Language.FRE => "Pohmotte",
						Language.ITA => "Pawmo",
						Language.SPN => "Pawmo",
						Language.KOR => "빠모트",
						Language.CHN_SIM => "布土拨",
						Language.CHN_TRA => "布土撥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PAWMOT:
					return lang switch {
						Language.ENG => "Pawmot",
						Language.JPN => "パーモット",
						Language.GER => "Pamomamo",
						Language.FRE => "Pohmarmotte",
						Language.ITA => "Pawmot",
						Language.SPN => "Pawmot",
						Language.KOR => "빠르모트",
						Language.CHN_SIM => "巴布土拨",
						Language.CHN_TRA => "巴布土撥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TANDEMAUS:
					return lang switch {
						Language.ENG => "Tandemaus",
						Language.JPN => "ワッカネズミ",
						Language.GER => "Zwieps",
						Language.FRE => "Compagnol",
						Language.ITA => "Tandemaus",
						Language.SPN => "Tandemaus",
						Language.KOR => "두리쥐",
						Language.CHN_SIM => "一对鼠",
						Language.CHN_TRA => "一對鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAUSHOLD_FAMILY_OF_FOUR:
					return lang switch {
						Language.ENG => "Maushold",
						Language.JPN => "イッカネズミ",
						Language.GER => "Famieps",
						Language.FRE => "Famignol",
						Language.ITA => "Maushold",
						Language.SPN => "Maushold",
						Language.KOR => "파밀리쥐",
						Language.CHN_SIM => "一家鼠",
						Language.CHN_TRA => "一家鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MAUSHOLD_FAMILY_OF_THREE:
					return lang switch {
						Language.ENG => "Maushold",
						Language.JPN => "イッカネズミ",
						Language.GER => "Famieps",
						Language.FRE => "Famignol",
						Language.ITA => "Maushold",
						Language.SPN => "Maushold",
						Language.KOR => "파밀리쥐",
						Language.CHN_SIM => "一家鼠",
						Language.CHN_TRA => "一家鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FIDOUGH:
					return lang switch {
						Language.ENG => "Fidough",
						Language.JPN => "パピモッチ",
						Language.GER => "Hefel",
						Language.FRE => "Pâtachiot",
						Language.ITA => "Fidough",
						Language.SPN => "Fidough",
						Language.KOR => "쫀도기",
						Language.CHN_SIM => "狗仔包",
						Language.CHN_TRA => "狗仔包",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DACHSBUN:
					return lang switch {
						Language.ENG => "Dachsbun",
						Language.JPN => "バウッツェル",
						Language.GER => "Backel",
						Language.FRE => "Briochien",
						Language.ITA => "Dachsbun",
						Language.SPN => "Dachsbun",
						Language.KOR => "바우첼",
						Language.CHN_SIM => "麻花犬",
						Language.CHN_TRA => "麻花犬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SMOLIV:
					return lang switch {
						Language.ENG => "Smoliv",
						Language.JPN => "ミニーブ",
						Language.GER => "Olini",
						Language.FRE => "Olivini",
						Language.ITA => "Smoliv",
						Language.SPN => "Smoliv",
						Language.KOR => "미니브",
						Language.CHN_SIM => "迷你芙",
						Language.CHN_TRA => "迷你芙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DOLLIV:
					return lang switch {
						Language.ENG => "Dolliv",
						Language.JPN => "オリーニョ",
						Language.GER => "Olivinio",
						Language.FRE => "Olivado",
						Language.ITA => "Dolliv",
						Language.SPN => "Dolliv",
						Language.KOR => "올리뇨",
						Language.CHN_SIM => "奥利纽",
						Language.CHN_TRA => "奧利紐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARBOLIVA:
					return lang switch {
						Language.ENG => "Arboliva",
						Language.JPN => "オリーヴァ",
						Language.GER => "Olithena",
						Language.FRE => "Arboliva",
						Language.ITA => "Arboliva",
						Language.SPN => "Arboliva",
						Language.KOR => "올리르바",
						Language.CHN_SIM => "奥利瓦",
						Language.CHN_TRA => "奧利瓦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SQUAWKABILLY_GREEN_PLUMAGE:
					return lang switch {
						Language.ENG => "Squawkabilly",
						Language.JPN => "イキリンコ",
						Language.GER => "Krawalloro",
						Language.FRE => "Tapatoès",
						Language.ITA => "Squawkabilly",
						Language.SPN => "Squawkabilly",
						Language.KOR => "시비꼬",
						Language.CHN_SIM => "怒鹦哥",
						Language.CHN_TRA => "怒鸚哥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SQUAWKABILLY_BLUE_PLUMAGE:
					return lang switch {
						Language.ENG => "Squawkabilly",
						Language.JPN => "イキリンコ",
						Language.GER => "Krawalloro",
						Language.FRE => "Tapatoès",
						Language.ITA => "Squawkabilly",
						Language.SPN => "Squawkabilly",
						Language.KOR => "시비꼬",
						Language.CHN_SIM => "怒鹦哥",
						Language.CHN_TRA => "怒鸚哥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SQUAWKABILLY_YELLOW_PLUMAGE:
					return lang switch {
						Language.ENG => "Squawkabilly",
						Language.JPN => "イキリンコ",
						Language.GER => "Krawalloro",
						Language.FRE => "Tapatoès",
						Language.ITA => "Squawkabilly",
						Language.SPN => "Squawkabilly",
						Language.KOR => "시비꼬",
						Language.CHN_SIM => "怒鹦哥",
						Language.CHN_TRA => "怒鸚哥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SQUAWKABILLY_WHITE_PLUMAGE:
					return lang switch {
						Language.ENG => "Squawkabilly",
						Language.JPN => "イキリンコ",
						Language.GER => "Krawalloro",
						Language.FRE => "Tapatoès",
						Language.ITA => "Squawkabilly",
						Language.SPN => "Squawkabilly",
						Language.KOR => "시비꼬",
						Language.CHN_SIM => "怒鹦哥",
						Language.CHN_TRA => "怒鸚哥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NACLI:
					return lang switch {
						Language.ENG => "Nacli",
						Language.JPN => "コジオ",
						Language.GER => "Geosali",
						Language.FRE => "Selutin",
						Language.ITA => "Nacli",
						Language.SPN => "Nacli",
						Language.KOR => "베베솔트",
						Language.CHN_SIM => "盐石宝",
						Language.CHN_TRA => "鹽石寶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.NACLSTACK:
					return lang switch {
						Language.ENG => "Naclstack",
						Language.JPN => "ジオヅム",
						Language.GER => "Sedisal",
						Language.FRE => "Amassel",
						Language.ITA => "Naclstack",
						Language.SPN => "Naclstack",
						Language.KOR => "스태솔트",
						Language.CHN_SIM => "盐石垒",
						Language.CHN_TRA => "鹽石壘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GARGANACL:
					return lang switch {
						Language.ENG => "Garganacl",
						Language.JPN => "キョジオーン",
						Language.GER => "Saltigant",
						Language.FRE => "Gigansel",
						Language.ITA => "Garganacl",
						Language.SPN => "Garganacl",
						Language.KOR => "콜로솔트",
						Language.CHN_SIM => "盐石巨灵",
						Language.CHN_TRA => "鹽石巨靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHARCADET:
					return lang switch {
						Language.ENG => "Charcadet",
						Language.JPN => "カルボウ",
						Language.GER => "Knarbon",
						Language.FRE => "Charbambin",
						Language.ITA => "Charcadet",
						Language.SPN => "Charcadet",
						Language.KOR => "카르본",
						Language.CHN_SIM => "炭小侍",
						Language.CHN_TRA => "炭小侍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARMAROUGE:
					return lang switch {
						Language.ENG => "Armarouge",
						Language.JPN => "グレンアルマ",
						Language.GER => "Crimanzo",
						Language.FRE => "Carmadura",
						Language.ITA => "Armarouge",
						Language.SPN => "Armarouge",
						Language.KOR => "카디나르마",
						Language.CHN_SIM => "红莲铠骑",
						Language.CHN_TRA => "紅蓮鎧騎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CERULEDGE:
					return lang switch {
						Language.ENG => "Ceruledge",
						Language.JPN => "ソウブレイズ",
						Language.GER => "Azugladis",
						Language.FRE => "Malvalame",
						Language.ITA => "Ceruledge",
						Language.SPN => "Ceruledge",
						Language.KOR => "파라블레이즈",
						Language.CHN_SIM => "苍炎刃鬼",
						Language.CHN_TRA => "蒼炎刃鬼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TADBULB:
					return lang switch {
						Language.ENG => "Tadbulb",
						Language.JPN => "ズピカ",
						Language.GER => "Blipp",
						Language.FRE => "Têtampoule",
						Language.ITA => "Tadbulb",
						Language.SPN => "Tadbulb",
						Language.KOR => "빈나두",
						Language.CHN_SIM => "光蚪仔",
						Language.CHN_TRA => "光蚪仔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BELLIBOLT:
					return lang switch {
						Language.ENG => "Bellibolt",
						Language.JPN => "ハラバリー",
						Language.GER => "Wampitz",
						Language.FRE => "Ampibidou",
						Language.ITA => "Bellibolt",
						Language.SPN => "Bellibolt",
						Language.KOR => "찌리배리",
						Language.CHN_SIM => "电肚蛙",
						Language.CHN_TRA => "電肚蛙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WATTREL:
					return lang switch {
						Language.ENG => "Wattrel",
						Language.JPN => "カイデン",
						Language.GER => "Voltrel",
						Language.FRE => "Zapétrel",
						Language.ITA => "Wattrel",
						Language.SPN => "Wattrel",
						Language.KOR => "찌리비",
						Language.CHN_SIM => "电海燕",
						Language.CHN_TRA => "電海燕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KILOWATTREL:
					return lang switch {
						Language.ENG => "Kilowattrel",
						Language.JPN => "タイカイデン",
						Language.GER => "Voltrean",
						Language.FRE => "Fulgulairo",
						Language.ITA => "Kilowattrel",
						Language.SPN => "Kilowattrel",
						Language.KOR => "찌리비크",
						Language.CHN_SIM => "大电海燕",
						Language.CHN_TRA => "大電海燕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MASCHIFF:
					return lang switch {
						Language.ENG => "Maschiff",
						Language.JPN => "オラチフ",
						Language.GER => "Mobtiff",
						Language.FRE => "Grondogue",
						Language.ITA => "Maschiff",
						Language.SPN => "Maschiff",
						Language.KOR => "오라티프",
						Language.CHN_SIM => "偶叫獒",
						Language.CHN_TRA => "偶叫獒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MABOSSTIFF:
					return lang switch {
						Language.ENG => "Mabosstiff",
						Language.JPN => "マフィティフ",
						Language.GER => "Mastifioso",
						Language.FRE => "Dogrino",
						Language.ITA => "Mabosstiff",
						Language.SPN => "Mabosstiff",
						Language.KOR => "마피티프",
						Language.CHN_SIM => "獒教父",
						Language.CHN_TRA => "獒教父",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SHROODLE:
					return lang switch {
						Language.ENG => "Shroodle",
						Language.JPN => "シルシュルー",
						Language.GER => "Sproxi",
						Language.FRE => "Gribouraigne",
						Language.ITA => "Shroodle",
						Language.SPN => "Shroodle",
						Language.KOR => "땃쭈르",
						Language.CHN_SIM => "滋汁鼹",
						Language.CHN_TRA => "滋汁鼴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GRAFAIAI:
					return lang switch {
						Language.ENG => "Grafaiai",
						Language.JPN => "タギングル",
						Language.GER => "Affiti",
						Language.FRE => "Tag-Tag",
						Language.ITA => "Grafaiai",
						Language.SPN => "Grafaiai",
						Language.KOR => "태깅구르",
						Language.CHN_SIM => "涂标客",
						Language.CHN_TRA => "塗標客",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRAMBLIN:
					return lang switch {
						Language.ENG => "Bramblin",
						Language.JPN => "アノクサ",
						Language.GER => "Weherba",
						Language.FRE => "Virovent",
						Language.ITA => "Bramblin",
						Language.SPN => "Bramblin",
						Language.KOR => "그푸리",
						Language.CHN_SIM => "纳噬草",
						Language.CHN_TRA => "納噬草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRAMBLEGHAST:
					return lang switch {
						Language.ENG => "Brambleghast",
						Language.JPN => "アノホラグサ",
						Language.GER => "Horrerba",
						Language.FRE => "Virevorreur",
						Language.ITA => "Brambleghast",
						Language.SPN => "Brambleghast",
						Language.KOR => "공푸리",
						Language.CHN_SIM => "怖纳噬草",
						Language.CHN_TRA => "怖納噬草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOEDSCOOL:
					return lang switch {
						Language.ENG => "Toedscool",
						Language.JPN => "ノノクラゲ",
						Language.GER => "Tentagra",
						Language.FRE => "Terracool",
						Language.ITA => "Toedscool",
						Language.SPN => "Toedscool",
						Language.KOR => "들눈해",
						Language.CHN_SIM => "原野水母",
						Language.CHN_TRA => "原野水母",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TOEDSCRUEL:
					return lang switch {
						Language.ENG => "Toedscruel",
						Language.JPN => "リククラゲ",
						Language.GER => "Tenterra",
						Language.FRE => "Terracruel",
						Language.ITA => "Toedscruel",
						Language.SPN => "Toedscruel",
						Language.KOR => "육파리",
						Language.CHN_SIM => "陆地水母",
						Language.CHN_TRA => "陸地水母",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KLAWF:
					return lang switch {
						Language.ENG => "Klawf",
						Language.JPN => "ガケガニ",
						Language.GER => "Klibbe",
						Language.FRE => "Craparoi",
						Language.ITA => "Klawf",
						Language.SPN => "Klawf",
						Language.KOR => "절벼게",
						Language.CHN_SIM => "毛崖蟹",
						Language.CHN_TRA => "毛崖蟹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CAPSAKID:
					return lang switch {
						Language.ENG => "Capsakid",
						Language.JPN => "カプサイジ",
						Language.GER => "Chilingel",
						Language.FRE => "Pimito",
						Language.ITA => "Capsakid",
						Language.SPN => "Capsakid",
						Language.KOR => "캡싸이",
						Language.CHN_SIM => "热辣娃",
						Language.CHN_TRA => "熱辣娃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCOVILLAIN:
					return lang switch {
						Language.ENG => "Scovillain",
						Language.JPN => "スコヴィラン",
						Language.GER => "Halupenjo",
						Language.FRE => "Scovilain",
						Language.ITA => "Scovillain",
						Language.SPN => "Scovillain",
						Language.KOR => "스코빌런",
						Language.CHN_SIM => "狠辣椒",
						Language.CHN_TRA => "狠辣椒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RELLOR:
					return lang switch {
						Language.ENG => "Rellor",
						Language.JPN => "シガロコ",
						Language.GER => "Relluk",
						Language.FRE => "Léboulérou",
						Language.ITA => "Rellor",
						Language.SPN => "Rellor",
						Language.KOR => "구르데",
						Language.CHN_SIM => "虫滚泥",
						Language.CHN_TRA => "蟲滾泥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.RABSCA:
					return lang switch {
						Language.ENG => "Rabsca",
						Language.JPN => "ベラカス",
						Language.GER => "Skarabaks",
						Language.FRE => "Bérasca",
						Language.ITA => "Rabsca",
						Language.SPN => "Rabsca",
						Language.KOR => "베라카스",
						Language.CHN_SIM => "虫甲圣",
						Language.CHN_TRA => "蟲甲聖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLITTLE:
					return lang switch {
						Language.ENG => "Flittle",
						Language.JPN => "ヒラヒナ",
						Language.GER => "Flattutu",
						Language.FRE => "Flotillon",
						Language.ITA => "Flittle",
						Language.SPN => "Flittle",
						Language.KOR => "하느라기",
						Language.CHN_SIM => "飘飘雏",
						Language.CHN_TRA => "飄飄雛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ESPATHRA:
					return lang switch {
						Language.ENG => "Espathra",
						Language.JPN => "クエスパトラ",
						Language.GER => "Psiopatra",
						Language.FRE => "Cléopsytra",
						Language.ITA => "Espathra",
						Language.SPN => "Espathra",
						Language.KOR => "클레스퍼트라",
						Language.CHN_SIM => "超能艳鸵",
						Language.CHN_TRA => "超能豔鴕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TINKATINK:
					return lang switch {
						Language.ENG => "Tinkatink",
						Language.JPN => "カヌチャン",
						Language.GER => "Forgita",
						Language.FRE => "Forgerette",
						Language.ITA => "Tinkatink",
						Language.SPN => "Tinkatink",
						Language.KOR => "어리짱",
						Language.CHN_SIM => "小锻匠",
						Language.CHN_TRA => "小鍛匠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TINKATUFF:
					return lang switch {
						Language.ENG => "Tinkatuff",
						Language.JPN => "ナカヌチャン",
						Language.GER => "Tafforgita",
						Language.FRE => "Forgella",
						Language.ITA => "Tinkatuff",
						Language.SPN => "Tinkatuff",
						Language.KOR => "벼리짱",
						Language.CHN_SIM => "巧锻匠",
						Language.CHN_TRA => "巧鍛匠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TINKATON:
					return lang switch {
						Language.ENG => "Tinkaton",
						Language.JPN => "デカヌチャン",
						Language.GER => "Granforgita",
						Language.FRE => "Forgelina",
						Language.ITA => "Tinkaton",
						Language.SPN => "Tinkaton",
						Language.KOR => "두드리짱",
						Language.CHN_SIM => "巨锻匠",
						Language.CHN_TRA => "巨鍛匠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WIGLETT:
					return lang switch {
						Language.ENG => "Wiglett",
						Language.JPN => "ウミディグダ",
						Language.GER => "Schligda",
						Language.FRE => "Taupikeau",
						Language.ITA => "Wiglett",
						Language.SPN => "Wiglett",
						Language.KOR => "바다그다",
						Language.CHN_SIM => "海地鼠",
						Language.CHN_TRA => "海地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WUGTRIO:
					return lang switch {
						Language.ENG => "Wugtrio",
						Language.JPN => "ウミトリオ",
						Language.GER => "Schligdri",
						Language.FRE => "Triopikeau",
						Language.ITA => "Wugtrio",
						Language.SPN => "Wugtrio",
						Language.KOR => "바닥트리오",
						Language.CHN_SIM => "三海地鼠",
						Language.CHN_TRA => "三海地鼠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BOMBIRDIER:
					return lang switch {
						Language.ENG => "Bombirdier",
						Language.JPN => "オトシドリ",
						Language.GER => "Adebom",
						Language.FRE => "Lestombaile",
						Language.ITA => "Bombirdier",
						Language.SPN => "Bombirdier",
						Language.KOR => "떨구새",
						Language.CHN_SIM => "下石鸟",
						Language.CHN_TRA => "下石鳥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FINIZEN:
					return lang switch {
						Language.ENG => "Finizen",
						Language.JPN => "ナミイルカ",
						Language.GER => "Normifin",
						Language.FRE => "Dofin",
						Language.ITA => "Finizen",
						Language.SPN => "Finizen",
						Language.KOR => "맨돌핀",
						Language.CHN_SIM => "波普海豚",
						Language.CHN_TRA => "波普海豚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PALAFIN_ZERO_FORM:
					return lang switch {
						Language.ENG => "Palafin",
						Language.JPN => "イルカマン",
						Language.GER => "Delfinator",
						Language.FRE => "Superdofin",
						Language.ITA => "Palafin",
						Language.SPN => "Palafin",
						Language.KOR => "돌핀맨",
						Language.CHN_SIM => "海豚侠",
						Language.CHN_TRA => "海豚俠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.PALAFIN_HERO_FORM:
					return lang switch {
						Language.ENG => "Palafin",
						Language.JPN => "イルカマン",
						Language.GER => "Delfinator",
						Language.FRE => "Superdofin",
						Language.ITA => "Palafin",
						Language.SPN => "Palafin",
						Language.KOR => "돌핀맨",
						Language.CHN_SIM => "海豚侠",
						Language.CHN_TRA => "海豚俠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VAROOM:
					return lang switch {
						Language.ENG => "Varoom",
						Language.JPN => "ブロロン",
						Language.GER => "Knattox",
						Language.FRE => "Vrombi",
						Language.ITA => "Varoom",
						Language.SPN => "Varoom",
						Language.KOR => "부르롱",
						Language.CHN_SIM => "噗隆隆",
						Language.CHN_TRA => "噗隆隆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.REVAVROOM:
					return lang switch {
						Language.ENG => "Revavroom",
						Language.JPN => "ブロロローム",
						Language.GER => "Knattatox",
						Language.FRE => "Vrombotor",
						Language.ITA => "Revavroom",
						Language.SPN => "Revavroom",
						Language.KOR => "부르르룸",
						Language.CHN_SIM => "普隆隆姆",
						Language.CHN_TRA => "普隆隆姆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CYCLIZAR:
					return lang switch {
						Language.ENG => "Cyclizar",
						Language.JPN => "モトトカゲ",
						Language.GER => "Mopex",
						Language.FRE => "Motorizard",
						Language.ITA => "Cyclizar",
						Language.SPN => "Cyclizar",
						Language.KOR => "모토마",
						Language.CHN_SIM => "摩托蜥",
						Language.CHN_TRA => "摩托蜥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ORTHWORM:
					return lang switch {
						Language.ENG => "Orthworm",
						Language.JPN => "ミミズズ",
						Language.GER => "Schlurm",
						Language.FRE => "Ferdeter",
						Language.ITA => "Orthworm",
						Language.SPN => "Orthworm",
						Language.KOR => "꿈트렁",
						Language.CHN_SIM => "拖拖蚓",
						Language.CHN_TRA => "拖拖蚓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLIMMET:
					return lang switch {
						Language.ENG => "Glimmet",
						Language.JPN => "キラーメ",
						Language.GER => "Lumispross",
						Language.FRE => "Germéclat",
						Language.ITA => "Glimmet",
						Language.SPN => "Glimmet",
						Language.KOR => "초롱순",
						Language.CHN_SIM => "晶光芽",
						Language.CHN_TRA => "晶光芽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GLIMMORA:
					return lang switch {
						Language.ENG => "Glimmora",
						Language.JPN => "キラフロル",
						Language.GER => "Lumiflora",
						Language.FRE => "Floréclat",
						Language.ITA => "Glimmora",
						Language.SPN => "Glimmora",
						Language.KOR => "킬라플로르",
						Language.CHN_SIM => "晶光花",
						Language.CHN_TRA => "晶光花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GREAVARD:
					return lang switch {
						Language.ENG => "Greavard",
						Language.JPN => "ボチ",
						Language.GER => "Gruff",
						Language.FRE => "Toutombe",
						Language.ITA => "Greavard",
						Language.SPN => "Greavard",
						Language.KOR => "망망이",
						Language.CHN_SIM => "墓仔狗",
						Language.CHN_TRA => "墓仔狗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.HOUNDSTONE:
					return lang switch {
						Language.ENG => "Houndstone",
						Language.JPN => "ハカドッグ",
						Language.GER => "Friedwuff",
						Language.FRE => "Tomberro",
						Language.ITA => "Houndstone",
						Language.SPN => "Houndstone",
						Language.KOR => "묘두기",
						Language.CHN_SIM => "墓扬犬",
						Language.CHN_TRA => "墓揚犬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLAMIGO:
					return lang switch {
						Language.ENG => "Flamigo",
						Language.JPN => "カラミンゴ",
						Language.GER => "Flaminkno",
						Language.FRE => "Flamenroule",
						Language.ITA => "Flamigo",
						Language.SPN => "Flamigo",
						Language.KOR => "꼬이밍고",
						Language.CHN_SIM => "缠红鹤",
						Language.CHN_TRA => "纏紅鶴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CETODDLE:
					return lang switch {
						Language.ENG => "Cetoddle",
						Language.JPN => "アルクジラ",
						Language.GER => "Flaniwal",
						Language.FRE => "Piétacé",
						Language.ITA => "Cetoddle",
						Language.SPN => "Cetoddle",
						Language.KOR => "터벅고래",
						Language.CHN_SIM => "走鲸",
						Language.CHN_TRA => "走鯨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CETITAN:
					return lang switch {
						Language.ENG => "Cetitan",
						Language.JPN => "ハルクジラ",
						Language.GER => "Kolowal",
						Language.FRE => "Balbalèze",
						Language.ITA => "Cetitan",
						Language.SPN => "Cetitan",
						Language.KOR => "우락고래",
						Language.CHN_SIM => "浩大鲸",
						Language.CHN_TRA => "浩大鯨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.VELUZA:
					return lang switch {
						Language.ENG => "Veluza",
						Language.JPN => "ミガルーサ",
						Language.GER => "Agiluza",
						Language.FRE => "Délestin",
						Language.ITA => "Veluza",
						Language.SPN => "Veluza",
						Language.KOR => "가비루사",
						Language.CHN_SIM => "轻身鳕",
						Language.CHN_TRA => "輕身鱈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DONDOZO:
					return lang switch {
						Language.ENG => "Dondozo",
						Language.JPN => "ヘイラッシャ",
						Language.GER => "Heerashai",
						Language.FRE => "Oyacata",
						Language.ITA => "Dondozo",
						Language.SPN => "Dondozo",
						Language.KOR => "어써러셔",
						Language.CHN_SIM => "吃吼霸",
						Language.CHN_TRA => "吃吼霸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TATSUGIRI_CURLY_FORM:
					return lang switch {
						Language.ENG => "Tatsugiri",
						Language.JPN => "シャリタツ",
						Language.GER => "Nigiragi",
						Language.FRE => "Nigirigon",
						Language.ITA => "Tatsugiri",
						Language.SPN => "Tatsugiri",
						Language.KOR => "싸리용",
						Language.CHN_SIM => "米立龙",
						Language.CHN_TRA => "米立龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TATSUGIRI_DROOPY_FORM:
					return lang switch {
						Language.ENG => "Tatsugiri",
						Language.JPN => "シャリタツ",
						Language.GER => "Nigiragi",
						Language.FRE => "Nigirigon",
						Language.ITA => "Tatsugiri",
						Language.SPN => "Tatsugiri",
						Language.KOR => "싸리용",
						Language.CHN_SIM => "米立龙",
						Language.CHN_TRA => "米立龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TATSUGIRI_STRETCHY_FORM:
					return lang switch {
						Language.ENG => "Tatsugiri",
						Language.JPN => "シャリタツ",
						Language.GER => "Nigiragi",
						Language.FRE => "Nigirigon",
						Language.ITA => "Tatsugiri",
						Language.SPN => "Tatsugiri",
						Language.KOR => "싸리용",
						Language.CHN_SIM => "米立龙",
						Language.CHN_TRA => "米立龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ANNIHILAPE:
					return lang switch {
						Language.ENG => "Annihilape",
						Language.JPN => "コノヨザル",
						Language.GER => "Epitaff",
						Language.FRE => "Courrousinge",
						Language.ITA => "Annihilape",
						Language.SPN => "Annihilape",
						Language.KOR => "저승갓숭",
						Language.CHN_SIM => "弃世猴",
						Language.CHN_TRA => "棄世猴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CLODSIRE:
					return lang switch {
						Language.ENG => "Clodsire",
						Language.JPN => "ドオー",
						Language.GER => "Suelord",
						Language.FRE => "Terraiste",
						Language.ITA => "Clodsire",
						Language.SPN => "Clodsire",
						Language.KOR => "토오",
						Language.CHN_SIM => "土王",
						Language.CHN_TRA => "土王",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FARIGIRAF:
					return lang switch {
						Language.ENG => "Farigiraf",
						Language.JPN => "リキキリン",
						Language.GER => "Farigiraf",
						Language.FRE => "Farigiraf",
						Language.ITA => "Farigiraf",
						Language.SPN => "Farigiraf",
						Language.KOR => "키키링",
						Language.CHN_SIM => "奇麒麟",
						Language.CHN_TRA => "奇麒麟",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUDUNSPARCE_TWO_SEGMENT_FORM:
					return lang switch {
						Language.ENG => "Dudunsparce",
						Language.JPN => "ノココッチ",
						Language.GER => "Dummimisel",
						Language.FRE => "Deusolourdo",
						Language.ITA => "Dudunsparce",
						Language.SPN => "Dudunsparce",
						Language.KOR => "노고고치",
						Language.CHN_SIM => "土龙节节",
						Language.CHN_TRA => "土龍節節",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.DUDUNSPARCE_THREE_SEGMENT_FORM:
					return lang switch {
						Language.ENG => "Dudunsparce",
						Language.JPN => "ノココッチ",
						Language.GER => "Dummimisel",
						Language.FRE => "Deusolourdo",
						Language.ITA => "Dudunsparce",
						Language.SPN => "Dudunsparce",
						Language.KOR => "노고고치",
						Language.CHN_SIM => "土龙节节",
						Language.CHN_TRA => "土龍節節",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KINGAMBIT:
					return lang switch {
						Language.ENG => "Kingambit",
						Language.JPN => "ドドゲザン",
						Language.GER => "Gladimperio",
						Language.FRE => "Scalpereur",
						Language.ITA => "Kingambit",
						Language.SPN => "Kingambit",
						Language.KOR => "대도각참",
						Language.CHN_SIM => "仆刀将军",
						Language.CHN_TRA => "仆斬將軍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GREAT_TUSK:
					return lang switch {
						Language.ENG => "Great Tusk",
						Language.JPN => "イダイナキバ",
						Language.GER => "Riesenzahn",
						Language.FRE => "Fort-Ivoire",
						Language.ITA => "Grandizanne",
						Language.SPN => "Colmilargo",
						Language.KOR => "위대한엄니",
						Language.CHN_SIM => "雄伟牙",
						Language.CHN_TRA => "雄偉牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SCREAM_TAIL:
					return lang switch {
						Language.ENG => "Scream Tail",
						Language.JPN => "サケブシッポ",
						Language.GER => "Brüllschweif",
						Language.FRE => "Hurle-Queue",
						Language.ITA => "Codaurlante",
						Language.SPN => "Colagrito",
						Language.KOR => "우렁찬꼬리",
						Language.CHN_SIM => "吼叫尾",
						Language.CHN_TRA => "吼叫尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BRUTE_BONNET:
					return lang switch {
						Language.ENG => "Brute Bonnet",
						Language.JPN => "アラブルタケ",
						Language.GER => "Wutpilz",
						Language.FRE => "Fongus-Furie",
						Language.ITA => "Fungofurioso",
						Language.SPN => "Furioseta",
						Language.KOR => "사나운버섯",
						Language.CHN_SIM => "猛恶菇",
						Language.CHN_TRA => "猛惡菇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FLUTTER_MANE:
					return lang switch {
						Language.ENG => "Flutter Mane",
						Language.JPN => "ハバタクカミ",
						Language.GER => "Flatterhaar",
						Language.FRE => "Flotte-Mèche",
						Language.ITA => "Crinealato",
						Language.SPN => "Melenaleteo",
						Language.KOR => "날개치는머리",
						Language.CHN_SIM => "振翼发",
						Language.CHN_TRA => "振翼髮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SLITHER_WING:
					return lang switch {
						Language.ENG => "Slither Wing",
						Language.JPN => "チヲハウハネ",
						Language.GER => "Kriechflügel",
						Language.FRE => "Rampe-Ailes",
						Language.ITA => "Alirasenti",
						Language.SPN => "Reptalada",
						Language.KOR => "땅을기는날개",
						Language.CHN_SIM => "爬地翅",
						Language.CHN_TRA => "爬地翅",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.SANDY_SHOCKS:
					return lang switch {
						Language.ENG => "Sandy Shocks",
						Language.JPN => "スナノケガワ",
						Language.GER => "Sandfell",
						Language.FRE => "Pelage-Sablé",
						Language.ITA => "Peldisabbia",
						Language.SPN => "Pelarena",
						Language.KOR => "모래털가죽",
						Language.CHN_SIM => "沙铁皮",
						Language.CHN_TRA => "沙鐵皮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_TREADS:
					return lang switch {
						Language.ENG => "Iron Treads",
						Language.JPN => "テツノワダチ",
						Language.GER => "Eisenrad",
						Language.FRE => "Roue-de-Fer",
						Language.ITA => "Solcoferreo",
						Language.SPN => "Ferrodada",
						Language.KOR => "무쇠바퀴",
						Language.CHN_SIM => "铁辙迹",
						Language.CHN_TRA => "鐵轍跡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_BUNDLE:
					return lang switch {
						Language.ENG => "Iron Bundle",
						Language.JPN => "テツノツツミ",
						Language.GER => "Eisenbündel",
						Language.FRE => "Hotte-de-Fer",
						Language.ITA => "Saccoferreo",
						Language.SPN => "Ferrosaco",
						Language.KOR => "무쇠보따리",
						Language.CHN_SIM => "铁包袱",
						Language.CHN_TRA => "鐵包袱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_HANDS:
					return lang switch {
						Language.ENG => "Iron Hands",
						Language.JPN => "テツノカイナ",
						Language.GER => "Eisenhand",
						Language.FRE => "Paume-de-Fer",
						Language.ITA => "Manoferrea",
						Language.SPN => "Ferropalmas",
						Language.KOR => "무쇠손",
						Language.CHN_SIM => "铁臂膀",
						Language.CHN_TRA => "鐵臂膀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_JUGULIS:
					return lang switch {
						Language.ENG => "Iron Jugulis",
						Language.JPN => "テツノコウベ",
						Language.GER => "Eisenhals",
						Language.FRE => "Têtes-de-Fer",
						Language.ITA => "Colloferreo",
						Language.SPN => "Ferrocuello",
						Language.KOR => "무쇠머리",
						Language.CHN_SIM => "铁脖颈",
						Language.CHN_TRA => "鐵脖頸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_MOTH:
					return lang switch {
						Language.ENG => "Iron Moth",
						Language.JPN => "テツノドクガ",
						Language.GER => "Eisenfalter",
						Language.FRE => "Mite-de-Fer",
						Language.ITA => "Falenaferrea",
						Language.SPN => "Ferropolilla",
						Language.KOR => "무쇠독나방",
						Language.CHN_SIM => "铁毒蛾",
						Language.CHN_TRA => "鐵毒蛾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_THORNS:
					return lang switch {
						Language.ENG => "Iron Thorns",
						Language.JPN => "テツノイバラ",
						Language.GER => "Eisendorn",
						Language.FRE => "Épine-de-Fer",
						Language.ITA => "Spineferree",
						Language.SPN => "Ferropúas",
						Language.KOR => "무쇠가시",
						Language.CHN_SIM => "铁荆棘",
						Language.CHN_TRA => "鐵荊棘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.FRIGIBAX:
					return lang switch {
						Language.ENG => "Frigibax",
						Language.JPN => "セビエ",
						Language.GER => "Frospino",
						Language.FRE => "Frigodo",
						Language.ITA => "Frigibax",
						Language.SPN => "Frigibax",
						Language.KOR => "드니차",
						Language.CHN_SIM => "凉脊龙",
						Language.CHN_TRA => "涼脊龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ARCTIBAX:
					return lang switch {
						Language.ENG => "Arctibax",
						Language.JPN => "セゴール",
						Language.GER => "Cryospino",
						Language.FRE => "Cryodo",
						Language.ITA => "Arctibax",
						Language.SPN => "Arctibax",
						Language.KOR => "드니꽁",
						Language.CHN_SIM => "冻脊龙",
						Language.CHN_TRA => "凍脊龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.BAXCALIBUR:
					return lang switch {
						Language.ENG => "Baxcalibur",
						Language.JPN => "セグレイブ",
						Language.GER => "Espinodon",
						Language.FRE => "Glaivodo",
						Language.ITA => "Baxcalibur",
						Language.SPN => "Baxcalibur",
						Language.KOR => "드닐레이브",
						Language.CHN_SIM => "戟脊龙",
						Language.CHN_TRA => "戟脊龍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIMMIGHOUL_CHEST_FORM:
					return lang switch {
						Language.ENG => "Gimmighoul",
						Language.JPN => "コレクレー",
						Language.GER => "Gierspenst",
						Language.FRE => "Mordudor",
						Language.ITA => "Gimmighoul",
						Language.SPN => "Gimmighoul",
						Language.KOR => "모으령",
						Language.CHN_SIM => "索财灵",
						Language.CHN_TRA => "索財靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GIMMIGHOUL_ROAMING_FORM:
					return lang switch {
						Language.ENG => "Gimmighoul",
						Language.JPN => "コレクレー",
						Language.GER => "Gierspenst",
						Language.FRE => "Mordudor",
						Language.ITA => "Gimmighoul",
						Language.SPN => "Gimmighoul",
						Language.KOR => "모으령",
						Language.CHN_SIM => "索财灵",
						Language.CHN_TRA => "索財靈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.GHOLDENGO:
					return lang switch {
						Language.ENG => "Gholdengo",
						Language.JPN => "サーフゴー",
						Language.GER => "Monetigo",
						Language.FRE => "Gromago",
						Language.ITA => "Gholdengo",
						Language.SPN => "Gholdengo",
						Language.KOR => "타부자고",
						Language.CHN_SIM => "赛富豪",
						Language.CHN_TRA => "賽富豪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WO_CHIEN:
					return lang switch {
						Language.ENG => "Wo-Chien",
						Language.JPN => "チオンジェン",
						Language.GER => "Chongjian",
						Language.FRE => "Chongjian",
						Language.ITA => "Wo-Chien",
						Language.SPN => "Wo-Chien",
						Language.KOR => "총지엔",
						Language.CHN_SIM => "古简蜗",
						Language.CHN_TRA => "古簡蝸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHIEN_PAO:
					return lang switch {
						Language.ENG => "Chien-Pao",
						Language.JPN => "パオジアン",
						Language.GER => "Baojian",
						Language.FRE => "Baojian",
						Language.ITA => "Chien-Pao",
						Language.SPN => "Chien-Pao",
						Language.KOR => "파오젠",
						Language.CHN_SIM => "古剑豹",
						Language.CHN_TRA => "古劍豹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.TING_LU:
					return lang switch {
						Language.ENG => "Ting-Lu",
						Language.JPN => "ディンルー",
						Language.GER => "Dinglu",
						Language.FRE => "Dinglu",
						Language.ITA => "Ting-Lu",
						Language.SPN => "Ting-Lu",
						Language.KOR => "딩루",
						Language.CHN_SIM => "古鼎鹿",
						Language.CHN_TRA => "古鼎鹿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.CHI_YU:
					return lang switch {
						Language.ENG => "Chi-Yu",
						Language.JPN => "イーユイ",
						Language.GER => "Yuyu",
						Language.FRE => "Yuyu",
						Language.ITA => "Chi-Yu",
						Language.SPN => "Chi-Yu",
						Language.KOR => "위유이",
						Language.CHN_SIM => "古玉鱼",
						Language.CHN_TRA => "古玉魚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.ROARING_MOON:
					return lang switch {
						Language.ENG => "Roaring Moon",
						Language.JPN => "トドロクツキ",
						Language.GER => "Donnersichel",
						Language.FRE => "Rugit-Lune",
						Language.ITA => "Lunaruggente",
						Language.SPN => "Bramaluna",
						Language.KOR => "고동치는달",
						Language.CHN_SIM => "轰鸣月",
						Language.CHN_TRA => "轟鳴月",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_VALIANT:
					return lang switch {
						Language.ENG => "Iron Valiant",
						Language.JPN => "テツノブジン",
						Language.GER => "Eisenkrieger",
						Language.FRE => "Garde-de-Fer",
						Language.ITA => "Eroeferreo",
						Language.SPN => "Ferropaladín",
						Language.KOR => "무쇠무인",
						Language.CHN_SIM => "铁武者",
						Language.CHN_TRA => "鐵武者",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.KORAIDON:
					return lang switch {
						Language.ENG => "Koraidon",
						Language.JPN => "コライドン",
						Language.GER => "Koraidon",
						Language.FRE => "Koraidon",
						Language.ITA => "Koraidon",
						Language.SPN => "Koraidon",
						Language.KOR => "코라이돈",
						Language.CHN_SIM => "故勒顿",
						Language.CHN_TRA => "故勒頓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.MIRAIDON:
					return lang switch {
						Language.ENG => "Miraidon",
						Language.JPN => "ミライドン",
						Language.GER => "Miraidon",
						Language.FRE => "Miraidon",
						Language.ITA => "Miraidon",
						Language.SPN => "Miraidon",
						Language.KOR => "미라이돈",
						Language.CHN_SIM => "密勒顿",
						Language.CHN_TRA => "密勒頓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.WALKING_WAKE:
					return lang switch {
						Language.ENG => "Walking Wake",
						Language.JPN => "ウネルミナモ",
						Language.GER => "Windewoge",
						Language.FRE => "Serpente-Eau",
						Language.ITA => "Acquecrespe",
						Language.SPN => "Ondulagua",
						Language.KOR => "굽이치는물결",
						Language.CHN_SIM => "波荡水",
						Language.CHN_TRA => "波盪水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case Species.IRON_LEAVES:
					return lang switch {
						Language.ENG => "Iron Leaves",
						Language.JPN => "テツノイサハ",
						Language.GER => "Eisenblatt",
						Language.FRE => "Vert-de-Fer",
						Language.ITA => "Fogliaferrea",
						Language.SPN => "Ferroverdor",
						Language.KOR => "무쇠잎새",
						Language.CHN_SIM => "铁斑叶",
						Language.CHN_TRA => "鐵斑葉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				default:
					throw new SpeciesNotRecognizedException(species);
			}
		}
	}
}