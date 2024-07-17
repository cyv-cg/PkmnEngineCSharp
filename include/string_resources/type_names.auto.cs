namespace PkmnEngine.Strings {
	public static class TYPE_NAMES {
		#region Keys
		/// <summary>
		/// ???
		/// </summary>
		public static readonly StringResource NONE = new("NONE", 0);
		/// <summary>
		/// Fighting
		/// </summary>
		public static readonly StringResource FIGHTING = new("FIGHTING", 0);
		/// <summary>
		/// Flying
		/// </summary>
		public static readonly StringResource FLYING = new("FLYING", 0);
		/// <summary>
		/// Poison
		/// </summary>
		public static readonly StringResource POISON = new("POISON", 0);
		/// <summary>
		/// Ground
		/// </summary>
		public static readonly StringResource GROUND = new("GROUND", 0);
		/// <summary>
		/// Rock
		/// </summary>
		public static readonly StringResource ROCK = new("ROCK", 0);
		/// <summary>
		/// Bug
		/// </summary>
		public static readonly StringResource BUG = new("BUG", 0);
		/// <summary>
		/// Ghost
		/// </summary>
		public static readonly StringResource GHOST = new("GHOST", 0);
		/// <summary>
		/// Steel
		/// </summary>
		public static readonly StringResource STEEL = new("STEEL", 0);
		/// <summary>
		/// Normal
		/// </summary>
		public static readonly StringResource NORMAL = new("NORMAL", 0);
		/// <summary>
		/// Fire
		/// </summary>
		public static readonly StringResource FIRE = new("FIRE", 0);
		/// <summary>
		/// Water
		/// </summary>
		public static readonly StringResource WATER = new("WATER", 0);
		/// <summary>
		/// Grass
		/// </summary>
		public static readonly StringResource GRASS = new("GRASS", 0);
		/// <summary>
		/// Electric
		/// </summary>
		public static readonly StringResource ELECTRIC = new("ELECTRIC", 0);
		/// <summary>
		/// Psychic
		/// </summary>
		public static readonly StringResource PSYCHIC = new("PSYCHIC", 0);
		/// <summary>
		/// Ice
		/// </summary>
		public static readonly StringResource ICE = new("ICE", 0);
		/// <summary>
		/// Dragon
		/// </summary>
		public static readonly StringResource DRAGON = new("DRAGON", 0);
		/// <summary>
		/// Dark
		/// </summary>
		public static readonly StringResource DARK = new("DARK", 0);
		/// <summary>
		/// Fairy
		/// </summary>
		public static readonly StringResource FAIRY = new("FAIRY", 0);
		#endregion

		internal static System.Collections.Generic.Dictionary<StringResource, System.Collections.Generic.Dictionary<Language, string>> resources = new() {
			{NONE, new() {{Language.ENG, "???"}, {Language.JPN, "???"}, {Language.GER, "???"}, {Language.FRE, "???"}, {Language.SPN, "???"}, {Language.ITA, "???"}, {Language.KOR, "???"}, {Language.CHN_SIM, "???"}, {Language.CHN_TRA, "???"}, }},
			{FIGHTING, new() {{Language.ENG, "Fighting"}, {Language.JPN, "かくとう"}, {Language.GER, "Kampf"}, {Language.FRE, "Combat"}, {Language.SPN, "Lucha"}, {Language.ITA, "Lotta"}, {Language.KOR, "격투"}, {Language.CHN_SIM, "格斗"}, {Language.CHN_TRA, "格鬥"}, }},
			{FLYING, new() {{Language.ENG, "Flying"}, {Language.JPN, "ひこう"}, {Language.GER, "Flug"}, {Language.FRE, "Vol"}, {Language.SPN, "Volador"}, {Language.ITA, "Volante"}, {Language.KOR, "비행"}, {Language.CHN_SIM, "飞行"}, {Language.CHN_TRA, "飛行"}, }},
			{POISON, new() {{Language.ENG, "Poison"}, {Language.JPN, "どく"}, {Language.GER, "Gift"}, {Language.FRE, "Poison"}, {Language.SPN, "Veneno"}, {Language.ITA, "Veleno"}, {Language.KOR, "독"}, {Language.CHN_SIM, "毒"}, {Language.CHN_TRA, "毒"}, }},
			{GROUND, new() {{Language.ENG, "Ground"}, {Language.JPN, "じめん"}, {Language.GER, "Boden"}, {Language.FRE, "Sol"}, {Language.SPN, "Tierra"}, {Language.ITA, "Terra"}, {Language.KOR, "땅"}, {Language.CHN_SIM, "地面"}, {Language.CHN_TRA, "地面"}, }},
			{ROCK, new() {{Language.ENG, "Rock"}, {Language.JPN, "いわ"}, {Language.GER, "Gestein"}, {Language.FRE, "Roche"}, {Language.SPN, "Roca"}, {Language.ITA, "Roccia"}, {Language.KOR, "바위"}, {Language.CHN_SIM, "岩石"}, {Language.CHN_TRA, "岩石"}, }},
			{BUG, new() {{Language.ENG, "Bug"}, {Language.JPN, "むし"}, {Language.GER, "Käfer"}, {Language.FRE, "Insecte"}, {Language.SPN, "Bicho"}, {Language.ITA, "Coleottero"}, {Language.KOR, "벌레"}, {Language.CHN_SIM, "虫"}, {Language.CHN_TRA, "蟲"}, }},
			{GHOST, new() {{Language.ENG, "Ghost"}, {Language.JPN, "ゴースト"}, {Language.GER, "Geist"}, {Language.FRE, "Spectre"}, {Language.SPN, "Fantasma"}, {Language.ITA, "Spettro"}, {Language.KOR, "고스트"}, {Language.CHN_SIM, "幽灵"}, {Language.CHN_TRA, "幽靈"}, }},
			{STEEL, new() {{Language.ENG, "Steel"}, {Language.JPN, "はがね"}, {Language.GER, "Stahl"}, {Language.FRE, "Acier"}, {Language.SPN, "Acero"}, {Language.ITA, "Acciaio"}, {Language.KOR, "강철"}, {Language.CHN_SIM, "钢"}, {Language.CHN_TRA, "鋼"}, }},
			{NORMAL, new() {{Language.ENG, "Normal"}, {Language.JPN, "ノーマル"}, {Language.GER, "Normal"}, {Language.FRE, "Normal"}, {Language.SPN, "Normal"}, {Language.ITA, "Normale"}, {Language.KOR, "노말"}, {Language.CHN_SIM, "一般"}, {Language.CHN_TRA, "一般"}, }},
			{FIRE, new() {{Language.ENG, "Fire"}, {Language.JPN, "ほのお"}, {Language.GER, "Feuer"}, {Language.FRE, "Feu"}, {Language.SPN, "Fuego"}, {Language.ITA, "Fuoco"}, {Language.KOR, "불꽃"}, {Language.CHN_SIM, "火"}, {Language.CHN_TRA, "火"}, }},
			{WATER, new() {{Language.ENG, "Water"}, {Language.JPN, "みず"}, {Language.GER, "Wasser"}, {Language.FRE, "Eau"}, {Language.SPN, "Agua"}, {Language.ITA, "Acqua"}, {Language.KOR, "물"}, {Language.CHN_SIM, "水"}, {Language.CHN_TRA, "水"}, }},
			{GRASS, new() {{Language.ENG, "Grass"}, {Language.JPN, "くさ"}, {Language.GER, "Pflanze"}, {Language.FRE, "Plante"}, {Language.SPN, "Planta"}, {Language.ITA, "Erba"}, {Language.KOR, "풀"}, {Language.CHN_SIM, "草"}, {Language.CHN_TRA, "草"}, }},
			{ELECTRIC, new() {{Language.ENG, "Electric"}, {Language.JPN, "でんき"}, {Language.GER, "Elektro"}, {Language.FRE, "Électrik"}, {Language.SPN, "Eléctrico"}, {Language.ITA, "Elettro"}, {Language.KOR, "전기"}, {Language.CHN_SIM, "电"}, {Language.CHN_TRA, "電"}, }},
			{PSYCHIC, new() {{Language.ENG, "Psychic"}, {Language.JPN, "エスパー"}, {Language.GER, "Psycho"}, {Language.FRE, "Psy"}, {Language.SPN, "Psíquico"}, {Language.ITA, "Psico"}, {Language.KOR, "에스퍼"}, {Language.CHN_SIM, "超能力"}, {Language.CHN_TRA, "超能力"}, }},
			{ICE, new() {{Language.ENG, "Ice"}, {Language.JPN, "こおり"}, {Language.GER, "Eis"}, {Language.FRE, "Glace"}, {Language.SPN, "Hielo"}, {Language.ITA, "Ghiaccio"}, {Language.KOR, "얼음"}, {Language.CHN_SIM, "冰"}, {Language.CHN_TRA, "冰"}, }},
			{DRAGON, new() {{Language.ENG, "Dragon"}, {Language.JPN, "ドラゴン"}, {Language.GER, "Drache"}, {Language.FRE, "Dragon"}, {Language.SPN, "Dragón"}, {Language.ITA, "Drago"}, {Language.KOR, "드래곤"}, {Language.CHN_SIM, "龙"}, {Language.CHN_TRA, "龍"}, }},
			{DARK, new() {{Language.ENG, "Dark"}, {Language.JPN, "あく"}, {Language.GER, "Unlicht"}, {Language.FRE, "Ténèbres"}, {Language.SPN, "Siniestro"}, {Language.ITA, "Buio"}, {Language.KOR, "악"}, {Language.CHN_SIM, "恶"}, {Language.CHN_TRA, "惡"}, }},
			{FAIRY, new() {{Language.ENG, "Fairy"}, {Language.JPN, "フェアリー"}, {Language.GER, "Fee"}, {Language.FRE, "Fée"}, {Language.SPN, "Hada"}, {Language.ITA, "Folletto"}, {Language.KOR, "페어리"}, {Language.CHN_SIM, "妖精"}, {Language.CHN_TRA, "妖精"}, }},
		};
	}
}
