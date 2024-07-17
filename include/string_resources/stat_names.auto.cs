namespace PkmnEngine.Strings {
	public static class STAT_NAMES {
		#region Keys
		/// <summary>
		/// HP
		/// </summary>
		public static readonly StringResource HIT_POINTS = new("HIT_POINTS", 0);
		/// <summary>
		/// Attack
		/// </summary>
		public static readonly StringResource ATTACK = new("ATTACK", 0);
		/// <summary>
		/// Defense
		/// </summary>
		public static readonly StringResource DEFENSE = new("DEFENSE", 0);
		/// <summary>
		/// Sp. Atk
		/// </summary>
		public static readonly StringResource SPECIAL_ATTACK = new("SPECIAL_ATTACK", 0);
		/// <summary>
		/// Sp. Def
		/// </summary>
		public static readonly StringResource SPECIAL_DEFENSE = new("SPECIAL_DEFENSE", 0);
		/// <summary>
		/// Speed
		/// </summary>
		public static readonly StringResource SPEED = new("SPEED", 0);
		/// <summary>
		/// Accuracy
		/// </summary>
		public static readonly StringResource ACCURACY = new("ACCURACY", 0);
		/// <summary>
		/// Evasiveness
		/// </summary>
		public static readonly StringResource EVASION = new("EVASION", 0);
		#endregion

		internal static System.Collections.Generic.Dictionary<StringResource, System.Collections.Generic.Dictionary<Language, string>> resources = new() {
			{HIT_POINTS, new() {{Language.ENG, "HP"}, {Language.JPN, "HP"}, {Language.GER, "KP"}, {Language.FRE, "PV"}, {Language.SPN, "PS"}, {Language.ITA, "PS"}, {Language.KOR, "HP"}, {Language.CHN_SIM, "HP"}, {Language.CHN_TRA, "HP"}, }},
			{ATTACK, new() {{Language.ENG, "Attack"}, {Language.JPN, "攻撃"}, {Language.GER, "Ang."}, {Language.FRE, "Attaque"}, {Language.SPN, "Ataque"}, {Language.ITA, "Attacco"}, {Language.KOR, "공격"}, {Language.CHN_SIM, "攻击"}, {Language.CHN_TRA, "攻擊"}, }},
			{DEFENSE, new() {{Language.ENG, "Defense"}, {Language.JPN, "防御"}, {Language.GER, "Vert."}, {Language.FRE, "Défense"}, {Language.SPN, "Defensa"}, {Language.ITA, "Difesa"}, {Language.KOR, "방어"}, {Language.CHN_SIM, "防御"}, {Language.CHN_TRA, "防禦"}, }},
			{SPECIAL_ATTACK, new() {{Language.ENG, "Sp. Atk"}, {Language.JPN, "特攻"}, {Language.GER, "Sp.-Ang."}, {Language.FRE, "Atq. Spé."}, {Language.SPN, "At. Esp."}, {Language.ITA, "Att. Sp."}, {Language.KOR, "특수공격"}, {Language.CHN_SIM, "特攻"}, {Language.CHN_TRA, "特攻"}, }},
			{SPECIAL_DEFENSE, new() {{Language.ENG, "Sp. Def"}, {Language.JPN, "特防"}, {Language.GER, "Sp.-Vert."}, {Language.FRE, "Déf. Spé."}, {Language.SPN, "Def. Esp."}, {Language.ITA, "Dif. Sp."}, {Language.KOR, "특수방어"}, {Language.CHN_SIM, "特防"}, {Language.CHN_TRA, "特防"}, }},
			{SPEED, new() {{Language.ENG, "Speed"}, {Language.JPN, "素早さ"}, {Language.GER, "Init."}, {Language.FRE, "Vitesse"}, {Language.SPN, "Velocidad"}, {Language.ITA, "Velocità"}, {Language.KOR, "스피드"}, {Language.CHN_SIM, "速度"}, {Language.CHN_TRA, "速度"}, }},
			{ACCURACY, new() {{Language.ENG, "Accuracy"}, {Language.JPN, "命中率"}, {Language.GER, "Genauigkeit"}, {Language.FRE, "Précision"}, {Language.SPN, "Precisión"}, {Language.ITA, "Precisione"}, {Language.KOR, "명중"}, {Language.CHN_SIM, "命中率"}, {Language.CHN_TRA, "命中率"}, }},
			{EVASION, new() {{Language.ENG, "Evasiveness"}, {Language.JPN, "回避率"}, {Language.GER, "Ausweichwert"}, {Language.FRE, "Esquive"}, {Language.SPN, "Evasión"}, {Language.ITA, "Elusione"}, {Language.KOR, "회피"}, {Language.CHN_SIM, "闪避率"}, {Language.CHN_TRA, "閃避率"}, }},
		};
	}
}
