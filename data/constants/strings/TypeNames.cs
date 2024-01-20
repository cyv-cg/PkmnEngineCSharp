namespace PkmnEngine.Strings {
	public static class TypeNames {
		public static string gTypeNames(Type type, Language lang) {
			switch (type) {
				case Type.NONE:
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
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.FIGHTING:
					return lang switch {
						Language.ENG => "Fighting",
						Language.JPN => "かくとう",
						Language.GER => "Kampf",
						Language.FRE => "Combat",
						Language.ITA => "Lotta",
						Language.SPN => "Lucha",
						Language.KOR => "격투",
						Language.CHN_SIM => "格斗",
						Language.CHN_TRA => "格鬥",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.FLYING:
					return lang switch {
						Language.ENG => "Flying",
						Language.JPN => "ひこう",
						Language.GER => "Flug",
						Language.FRE => "Vol",
						Language.ITA => "Volante",
						Language.SPN => "Volador",
						Language.KOR => "비행",
						Language.CHN_SIM => "飞行",
						Language.CHN_TRA => "飛行",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.POISON:
					return lang switch {
						Language.ENG => "Poison",
						Language.JPN => "どく",
						Language.GER => "Gift",
						Language.FRE => "Poison",
						Language.ITA => "Veleno",
						Language.SPN => "Veneno",
						Language.KOR => "독",
						Language.CHN_SIM => "毒",
						Language.CHN_TRA => "毒",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.GROUND:
					return lang switch {
						Language.ENG => "Ground",
						Language.JPN => "じめん",
						Language.GER => "Boden",
						Language.FRE => "Sol",
						Language.ITA => "Terra",
						Language.SPN => "Tierra",
						Language.KOR => "땅",
						Language.CHN_SIM => "地面",
						Language.CHN_TRA => "地面",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.ROCK:
					return lang switch {
						Language.ENG => "Rock",
						Language.JPN => "いわ",
						Language.GER => "Gestein",
						Language.FRE => "Roche",
						Language.ITA => "Roccia",
						Language.SPN => "Roca",
						Language.KOR => "바위",
						Language.CHN_SIM => "岩石",
						Language.CHN_TRA => "岩石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.BUG:
					return lang switch {
						Language.ENG => "Bug",
						Language.JPN => "むし",
						Language.GER => "Käfer",
						Language.FRE => "Insecte",
						Language.ITA => "Coleottero",
						Language.SPN => "Bicho",
						Language.KOR => "벌레",
						Language.CHN_SIM => "虫",
						Language.CHN_TRA => "蟲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.GHOST:
					return lang switch {
						Language.ENG => "Ghost",
						Language.JPN => "ゴースト",
						Language.GER => "Geist",
						Language.FRE => "Spectre",
						Language.ITA => "Spettro",
						Language.SPN => "Fantasma",
						Language.KOR => "고스트",
						Language.CHN_SIM => "幽灵",
						Language.CHN_TRA => "幽靈",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.STEEL:
					return lang switch {
						Language.ENG => "Steel",
						Language.JPN => "はがね",
						Language.GER => "Stahl",
						Language.FRE => "Acier",
						Language.ITA => "Acciaio",
						Language.SPN => "Acero",
						Language.KOR => "강철",
						Language.CHN_SIM => "钢",
						Language.CHN_TRA => "鋼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.NORMAL:
					return lang switch {
						Language.ENG => "Normal",
						Language.JPN => "ノーマル",
						Language.GER => "Normal",
						Language.FRE => "Normal",
						Language.ITA => "Normale",
						Language.SPN => "Normal",
						Language.KOR => "노말",
						Language.CHN_SIM => "一般",
						Language.CHN_TRA => "一般",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.FIRE:
					return lang switch {
						Language.ENG => "Fire",
						Language.JPN => "ほのお",
						Language.GER => "Feuer",
						Language.FRE => "Feu",
						Language.ITA => "Fuoco",
						Language.SPN => "Fuego",
						Language.KOR => "불꽃",
						Language.CHN_SIM => "火",
						Language.CHN_TRA => "火",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.WATER:
					return lang switch {
						Language.ENG => "Water",
						Language.JPN => "みず",
						Language.GER => "Wasser",
						Language.FRE => "Eau",
						Language.ITA => "Acqua",
						Language.SPN => "Agua",
						Language.KOR => "물",
						Language.CHN_SIM => "水",
						Language.CHN_TRA => "水",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.GRASS:
					return lang switch {
						Language.ENG => "Grass",
						Language.JPN => "くさ",
						Language.GER => "Pflanze",
						Language.FRE => "Plante",
						Language.ITA => "Erba",
						Language.SPN => "Planta",
						Language.KOR => "풀",
						Language.CHN_SIM => "草",
						Language.CHN_TRA => "草",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.ELECTRIC:
					return lang switch {
						Language.ENG => "Electric",
						Language.JPN => "でんき",
						Language.GER => "Elektro",
						Language.FRE => "Électrik",
						Language.ITA => "Elettro",
						Language.SPN => "Eléctrico",
						Language.KOR => "전기",
						Language.CHN_SIM => "电",
						Language.CHN_TRA => "電",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.PSYCHIC:
					return lang switch {
						Language.ENG => "Psychic",
						Language.JPN => "エスパー",
						Language.GER => "Psycho",
						Language.FRE => "Psy",
						Language.ITA => "Psico",
						Language.SPN => "Psíquico",
						Language.KOR => "에스퍼",
						Language.CHN_SIM => "超能力",
						Language.CHN_TRA => "超能力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.ICE:
					return lang switch {
						Language.ENG => "Ice",
						Language.JPN => "こおり",
						Language.GER => "Eis",
						Language.FRE => "Glace",
						Language.ITA => "Ghiaccio",
						Language.SPN => "Hielo",
						Language.KOR => "얼음",
						Language.CHN_SIM => "冰",
						Language.CHN_TRA => "冰",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.DRAGON:
					return lang switch {
						Language.ENG => "Dragon",
						Language.JPN => "ドラゴン",
						Language.GER => "Drache",
						Language.FRE => "Dragon",
						Language.ITA => "Drago",
						Language.SPN => "Dragón",
						Language.KOR => "드래곤",
						Language.CHN_SIM => "龙",
						Language.CHN_TRA => "龍",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.DARK:
					return lang switch {
						Language.ENG => "Dark",
						Language.JPN => "あく",
						Language.GER => "Unlicht",
						Language.FRE => "Ténèbres",
						Language.ITA => "Buio",
						Language.SPN => "Siniestro",
						Language.KOR => "악",
						Language.CHN_SIM => "恶",
						Language.CHN_TRA => "惡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Type.FAIRY:
					return lang switch {
						Language.ENG => "Fairy",
						Language.JPN => "フェアリー",
						Language.GER => "Fee",
						Language.FRE => "Fée",
						Language.ITA => "Folletto",
						Language.SPN => "Hada",
						Language.KOR => "페어리",
						Language.CHN_SIM => "妖精",
						Language.CHN_TRA => "妖精",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				default:
					throw new System.ArgumentException();
			};
		}
	}
}