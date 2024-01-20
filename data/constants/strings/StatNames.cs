namespace PkmnEngine.Strings {
	public static class StatNames {
		public static string gStatNames(Stat stat, Language lang) {
			switch (stat) {
				case Stat.HIT_POINTS:
					return lang switch {
						Language.ENG => "HP",
						Language.JPN => "HP",
						Language.GER => "KP",
						Language.FRE => "PV",
						Language.ITA => "PS",
						Language.SPN => "PS",
						Language.KOR => "HP",
						Language.CHN_SIM => "HP",
						Language.CHN_TRA => "HP",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.ATTACK:
					return lang switch {
						Language.ENG => "Attack",
						Language.JPN => "{攻撃|こうげき}",
						Language.GER => "Ang.",
						Language.FRE => "Attaque",
						Language.ITA => "Attacco",
						Language.SPN => "Ataque",
						Language.KOR => "공격",
						Language.CHN_SIM => "攻击",
						Language.CHN_TRA => "攻擊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.DEFENSE:
					return lang switch {
						Language.ENG => "Defense",
						Language.JPN => "{防御|ぼうぎょ}",
						Language.GER => "Vert.",
						Language.FRE => "Défense",
						Language.ITA => "Difesa",
						Language.SPN => "Defensa",
						Language.KOR => "방어",
						Language.CHN_SIM => "防御",
						Language.CHN_TRA => "防禦",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.SPECIAL_ATTACK:
					return lang switch {
						Language.ENG => "Sp. Atk",
						Language.JPN => "{特攻|とくこう}",
						Language.GER => "Sp.-Ang.",
						Language.FRE => "Atq. Spé.",
						Language.ITA => "Att. Sp.",
						Language.SPN => "At. Esp.",
						Language.KOR => "특수공격",
						Language.CHN_SIM => "特攻",
						Language.CHN_TRA => "特攻",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.SPECIAL_DEFENSE:
					return lang switch {
						Language.ENG => "Sp. Def",
						Language.JPN => "{特防|とくぼう}",
						Language.GER => "Sp.-Vert.",
						Language.FRE => "Déf. Spé.",
						Language.ITA => "Dif. Sp.",
						Language.SPN => "Def. Esp.",
						Language.KOR => "특수방어",
						Language.CHN_SIM => "特防",
						Language.CHN_TRA => "特防",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.SPEED:
					return lang switch {
						Language.ENG => "Speed",
						Language.JPN => "{素早|すばや}さ",
						Language.GER => "Init.",
						Language.FRE => "Vitesse",
						Language.ITA => "Velocità",
						Language.SPN => "Velocidad",
						Language.KOR => "스피드",
						Language.CHN_SIM => "速度",
						Language.CHN_TRA => "速度",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.ACCURACY:
					return lang switch {
						Language.ENG => "Accuracy",
						Language.JPN => "{命中率|めいちゅうりつ}",
						Language.GER => "Genauigkeit",
						Language.FRE => "Précision",
						Language.ITA => "Precisione",
						Language.SPN => "Precisión",
						Language.KOR => "명중",
						Language.CHN_SIM => "命中率",
						Language.CHN_TRA => "命中率",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Stat.EVASION:
					return lang switch {
						Language.ENG => "Evasiveness",
						Language.JPN => "{回避率|かいひりつ}",
						Language.GER => "Ausweichwert",
						Language.FRE => "Esquive",
						Language.ITA => "Elusione",
						Language.SPN => "Evasión",
						Language.KOR => "회피",
						Language.CHN_SIM => "闪避率",
						Language.CHN_TRA => "閃避率",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				default:
					throw new System.ArgumentException();
			};
		}
	}
}