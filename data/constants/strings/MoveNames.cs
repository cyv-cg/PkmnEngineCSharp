using static PkmnEngine.Global;

namespace PkmnEngine.Strings {
	public static class MoveNames {
		public static string gMoveNames(BattleMoveID move, Language lang) {
			switch (move) {
				case BattleMoveID.NONE:
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
				case BattleMoveID.ABSORB:
					return lang switch {
						Language.ENG => "Absorb",
						Language.JPN => "すいとる",
						Language.GER => "Absorber",
						Language.FRE => "Vol-Vie",
						Language.ITA => "Assorbimento",
						Language.SPN => "Absorber",
						Language.KOR => "흡수",
						Language.CHN_SIM => "吸取",
						Language.CHN_TRA => "吸取",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ACCELEROCK:
					return lang switch {
						Language.ENG => "Accelerock",
						Language.JPN => "アクセルロック",
						Language.GER => "Turbofelsen",
						Language.FRE => "Vif Roc",
						Language.ITA => "Rocciarapida",
						Language.SPN => "Roca Veloz",
						Language.KOR => "액셀록",
						Language.CHN_SIM => "冲岩",
						Language.CHN_TRA => "衝岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ACID:
					return lang switch {
						Language.ENG => "Acid",
						Language.JPN => "ようかいえき",
						Language.GER => "Säure",
						Language.FRE => "Acide",
						Language.ITA => "Acido",
						Language.SPN => "Ácido",
						Language.KOR => "용해액",
						Language.CHN_SIM => "溶解液",
						Language.CHN_TRA => "溶解液",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ACID_ARMOR:
					return lang switch {
						Language.ENG => "Acid Armor",
						Language.JPN => "とける",
						Language.GER => "Säurepanzer",
						Language.FRE => "Acidarmure",
						Language.ITA => "Scudo Acido",
						Language.SPN => "Armadura Ácida",
						Language.KOR => "녹기",
						Language.CHN_SIM => "溶化",
						Language.CHN_TRA => "溶化",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ACID_SPRAY:
					return lang switch {
						Language.ENG => "Acid Spray",
						Language.JPN => "アシッドボム",
						Language.GER => "Säurespeier",
						Language.FRE => "Bombe Acide",
						Language.ITA => "Acidobomba",
						Language.SPN => "Bomba Ácida",
						Language.KOR => "애시드봄",
						Language.CHN_SIM => "酸液炸弹",
						Language.CHN_TRA => "酸液炸彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ACROBATICS:
					return lang switch {
						Language.ENG => "Acrobatics",
						Language.JPN => "アクロバット",
						Language.GER => "Akrobatik",
						Language.FRE => "Acrobatie",
						Language.ITA => "Acrobazia",
						Language.SPN => "Acróbata",
						Language.KOR => "애크러뱃",
						Language.CHN_SIM => "杂技",
						Language.CHN_TRA => "雜技",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ACUPRESSURE:
					return lang switch {
						Language.ENG => "Acupressure",
						Language.JPN => "つぼをつく",
						Language.GER => "Akupressur",
						Language.FRE => "Acupression",
						Language.ITA => "Acupressione",
						Language.SPN => "Acupresión",
						Language.KOR => "경혈찌르기",
						Language.CHN_SIM => "点穴",
						Language.CHN_TRA => "點穴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AERIAL_ACE:
					return lang switch {
						Language.ENG => "Aerial Ace",
						Language.JPN => "つばめがえし",
						Language.GER => "Aero-Ass",
						Language.FRE => "Aéropique",
						Language.ITA => "Aeroassalto",
						Language.SPN => "Golpe Aéreo",
						Language.KOR => "제비반환",
						Language.CHN_SIM => "燕返",
						Language.CHN_TRA => "燕返",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AEROBLAST:
					return lang switch {
						Language.ENG => "Aeroblast",
						Language.JPN => "エアロブラスト",
						Language.GER => "Luftstoß",
						Language.FRE => "Aéroblast",
						Language.ITA => "Aerocolpo",
						Language.SPN => "Aerochorro",
						Language.KOR => "에어로블라스트",
						Language.CHN_SIM => "气旋攻击",
						Language.CHN_TRA => "氣旋攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AFTER_YOU:
					return lang switch {
						Language.ENG => "After You",
						Language.JPN => "おさきにどうぞ",
						Language.GER => "Galanterie",
						Language.FRE => "Après Vous",
						Language.ITA => "Cortesia",
						Language.SPN => "Cede Paso",
						Language.KOR => "당신먼저",
						Language.CHN_SIM => "您先请",
						Language.CHN_TRA => "您先請",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AGILITY:
					return lang switch {
						Language.ENG => "Agility",
						Language.JPN => "こうそくいどう",
						Language.GER => "Agilität",
						Language.FRE => "Hâte",
						Language.ITA => "Agilità",
						Language.SPN => "Agilidad",
						Language.KOR => "고속이동",
						Language.CHN_SIM => "高速移动",
						Language.CHN_TRA => "高速移動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AIR_CUTTER:
					return lang switch {
						Language.ENG => "Air Cutter",
						Language.JPN => "エアカッター",
						Language.GER => "Windschnitt",
						Language.FRE => "Tranch'Air",
						Language.ITA => "Aerasoio",
						Language.SPN => "Aire Afilado",
						Language.KOR => "에어커터",
						Language.CHN_SIM => "空气利刃",
						Language.CHN_TRA => "空氣利刃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AIR_SLASH:
					return lang switch {
						Language.ENG => "Air Slash",
						Language.JPN => "エアスラッシュ",
						Language.GER => "Luftschnitt",
						Language.FRE => "Lame d'Air",
						Language.ITA => "Eterelama",
						Language.SPN => "Tajo Aéreo",
						Language.KOR => "에어슬래시",
						Language.CHN_SIM => "空气之刃",
						Language.CHN_TRA => "空氣斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ALLY_SWITCH:
					return lang switch {
						Language.ENG => "Ally Switch",
						Language.JPN => "サイドチェンジ",
						Language.GER => "Seitentausch",
						Language.FRE => "Interversion",
						Language.ITA => "Cambiaposto",
						Language.SPN => "Cambio Banda",
						Language.KOR => "사이드체인지",
						Language.CHN_SIM => "交换场地",
						Language.CHN_TRA => "交換場地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AMNESIA:
					return lang switch {
						Language.ENG => "Amnesia",
						Language.JPN => "ドわすれ",
						Language.GER => "Amnesie",
						Language.FRE => "Amnésie",
						Language.ITA => "Amnesia",
						Language.SPN => "Amnesia",
						Language.KOR => "망각술",
						Language.CHN_SIM => "瞬间失忆",
						Language.CHN_TRA => "瞬間失憶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ANCHOR_SHOT:
					return lang switch {
						Language.ENG => "Anchor Shot",
						Language.JPN => "アンカーショット",
						Language.GER => "Ankerschuss",
						Language.FRE => "Ancrage",
						Language.ITA => "Colpo d'Ancora",
						Language.SPN => "Anclaje",
						Language.KOR => "앵커샷",
						Language.CHN_SIM => "掷锚",
						Language.CHN_TRA => "擲錨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ANCIENT_POWER:
					return lang switch {
						Language.ENG => "Ancient Power",
						Language.JPN => "げんしのちから",
						Language.GER => "Antik-Kraft",
						Language.FRE => "Pouvoir Antique",
						Language.ITA => "Forzantica",
						Language.SPN => "Poder Pasado",
						Language.KOR => "원시의힘",
						Language.CHN_SIM => "原始之力",
						Language.CHN_TRA => "原始之力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.APPLE_ACID:
					return lang switch {
						Language.ENG => "Apple Acid",
						Language.JPN => "りんごさ",
						Language.GER => "Apfelsäure",
						Language.FRE => "Acide Malique",
						Language.ITA => "Acido Malico",
						Language.SPN => "Ácido Málico",
						Language.KOR => "사과산",
						Language.CHN_SIM => "苹果酸",
						Language.CHN_TRA => "蘋果酸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AQUA_CUTTER:
					return lang switch {
						Language.ENG => "Aqua Cutter",
						Language.JPN => "アクアカッタ",
						Language.GER => "Aquaschnitt",
						Language.FRE => "Tranch’Aqua",
						Language.ITA => "Idrotaglio",
						Language.SPN => "Tajo Acuático",
						Language.KOR => "아쿠아커터",
						Language.CHN_SIM => "水波刀",
						Language.CHN_TRA => "水波刀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AQUA_JET:
					return lang switch {
						Language.ENG => "Aqua Jet",
						Language.JPN => "アクアジェット",
						Language.GER => "Wasserdüse",
						Language.FRE => "Aqua-Jet",
						Language.ITA => "Acquagetto",
						Language.SPN => "Acua Jet",
						Language.KOR => "아쿠아제트",
						Language.CHN_SIM => "水流喷射",
						Language.CHN_TRA => "水流噴射",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AQUA_RING:
					return lang switch {
						Language.ENG => "Aqua Ring",
						Language.JPN => "アクアリング",
						Language.GER => "Wasserring",
						Language.FRE => "Anneau Hydro",
						Language.ITA => "Acquanello",
						Language.SPN => "Acua Aro",
						Language.KOR => "아쿠아링",
						Language.CHN_SIM => "水流环",
						Language.CHN_TRA => "水流環",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AQUA_STEP:
					return lang switch {
						Language.ENG => "Aqua Step",
						Language.JPN => "アクアステッ",
						Language.GER => "Wogentanz",
						Language.FRE => "Danse Aquatique",
						Language.ITA => "Idroballetto",
						Language.SPN => "Danza Acuática",
						Language.KOR => "아쿠아스텝",
						Language.CHN_SIM => "流水旋舞",
						Language.CHN_TRA => "流水旋舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AQUA_TAIL:
					return lang switch {
						Language.ENG => "Aqua Tail",
						Language.JPN => "アクアテール",
						Language.GER => "Nassschweif",
						Language.FRE => "Hydroqueue",
						Language.ITA => "Idrondata",
						Language.SPN => "Acua Cola",
						Language.KOR => "아쿠아테일",
						Language.CHN_SIM => "水流尾",
						Language.CHN_TRA => "水流尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ARM_THRUST:
					return lang switch {
						Language.ENG => "Arm Thrust",
						Language.JPN => "つっぱり",
						Language.GER => "Armstoß",
						Language.FRE => "Cogne",
						Language.ITA => "Sberletese",
						Language.SPN => "Empujón",
						Language.KOR => "손바닥치기",
						Language.CHN_SIM => "猛推",
						Language.CHN_TRA => "猛推",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ARMOR_CANNON:
					return lang switch {
						Language.ENG => "Armor Cannon",
						Language.JPN => "アーマーキャノ",
						Language.GER => "Rüstungskanone",
						Language.FRE => "Canon Blindé",
						Language.ITA => "Corazza Cannone",
						Language.SPN => "Cañón Armadura",
						Language.KOR => "아머캐논",
						Language.CHN_SIM => "铠农炮",
						Language.CHN_TRA => "鎧農炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AROMATHERAPY:
					return lang switch {
						Language.ENG => "Aromatherapy",
						Language.JPN => "アロマセラピー",
						Language.GER => "Aromakur",
						Language.FRE => "Aromathérapi",
						Language.ITA => "Aromaterapia",
						Language.SPN => "Aromaterapia",
						Language.KOR => "아로마테라피",
						Language.CHN_SIM => "芳香治疗",
						Language.CHN_TRA => "芳香治療",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AROMATIC_MIST:
					return lang switch {
						Language.ENG => "Aromatic Mist",
						Language.JPN => "アロマミスト",
						Language.GER => "Duftwolke",
						Language.FRE => "Brume Capiteuse",
						Language.ITA => "Nebularoma",
						Language.SPN => "Niebla Aromática",
						Language.KOR => "아로마미스트",
						Language.CHN_SIM => "芳香薄雾",
						Language.CHN_TRA => "芳香薄霧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ASSIST:
					return lang switch {
						Language.ENG => "Assist",
						Language.JPN => "ねこのて",
						Language.GER => "Zuschuss",
						Language.FRE => "Assistance",
						Language.ITA => "Assistente",
						Language.SPN => "Ayuda",
						Language.KOR => "조수",
						Language.CHN_SIM => "借助",
						Language.CHN_TRA => "借助",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ASSURANCE:
					return lang switch {
						Language.ENG => "Assurance",
						Language.JPN => "ダメおし",
						Language.GER => "Gewissheit",
						Language.FRE => "Assurance",
						Language.ITA => "Garanzia",
						Language.SPN => "Buena Baza",
						Language.KOR => "승부굳히기",
						Language.CHN_SIM => "恶意追击",
						Language.CHN_TRA => "惡意追擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ASTONISH:
					return lang switch {
						Language.ENG => "Astonish",
						Language.JPN => "おどろかす",
						Language.GER => "Erstauner",
						Language.FRE => "Étonnement",
						Language.ITA => "Sgomento",
						Language.SPN => "Impresionar",
						Language.KOR => "놀래키기",
						Language.CHN_SIM => "惊吓",
						Language.CHN_TRA => "驚嚇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ASTRAL_BARRAGE:
					return lang switch {
						Language.ENG => "Astral Barrage",
						Language.JPN => "アストラルビッ",
						Language.GER => "Astralfragmente",
						Language.FRE => "Éclat Spectral",
						Language.ITA => "Schegge Astrali",
						Language.SPN => "Orbes Espectro",
						Language.KOR => "아스트랄비트",
						Language.CHN_SIM => "星碎",
						Language.CHN_TRA => "星碎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ATTACK_ORDER:
					return lang switch {
						Language.ENG => "Attack Order",
						Language.JPN => "こうげきしれい",
						Language.GER => "Schlagbefehl",
						Language.FRE => "Appel Attak",
						Language.ITA => "Comandourto",
						Language.SPN => "Al Ataque",
						Language.KOR => "공격지령",
						Language.CHN_SIM => "攻击指令",
						Language.CHN_TRA => "攻擊指令",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ATTRACT:
					return lang switch {
						Language.ENG => "Attract",
						Language.JPN => "メロメロ",
						Language.GER => "Anziehung",
						Language.FRE => "Attraction",
						Language.ITA => "Attrazione",
						Language.SPN => "Atracción",
						Language.KOR => "헤롱헤롱",
						Language.CHN_SIM => "迷人",
						Language.CHN_TRA => "迷人",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AURA_SPHERE:
					return lang switch {
						Language.ENG => "Aura Sphere",
						Language.JPN => "はどうだん",
						Language.GER => "Aurasphäre",
						Language.FRE => "Aurasphère",
						Language.ITA => "Forzasfera",
						Language.SPN => "Esfera Aural",
						Language.KOR => "파동탄",
						Language.CHN_SIM => "波导弹",
						Language.CHN_TRA => "波導彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AURA_WHEEL:
					return lang switch {
						Language.ENG => "Aura Wheel",
						Language.JPN => "オーラぐる",
						Language.GER => "Aura-Rad",
						Language.FRE => "Roue Libre",
						Language.ITA => "Ruota d’Aura",
						Language.SPN => "Rueda Aural",
						Language.KOR => "오라휠",
						Language.CHN_SIM => "气场轮",
						Language.CHN_TRA => "氣場輪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AURORA_BEAM:
					return lang switch {
						Language.ENG => "Aurora Beam",
						Language.JPN => "オーロラビーム",
						Language.GER => "Aurorastrahl",
						Language.FRE => "Onde Boréale",
						Language.ITA => "Raggiaurora",
						Language.SPN => "Rayo Aurora",
						Language.KOR => "오로라빔",
						Language.CHN_SIM => "极光束",
						Language.CHN_TRA => "極光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AURORA_VEIL:
					return lang switch {
						Language.ENG => "Aurora Veil",
						Language.JPN => "オーロラベール",
						Language.GER => "Auroraschleier",
						Language.FRE => "Voile Aurore",
						Language.ITA => "Velaurora",
						Language.SPN => "Velo Aurora",
						Language.KOR => "오로라베일",
						Language.CHN_SIM => "极光幕",
						Language.CHN_TRA => "極光幕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AUTOTOMIZE:
					return lang switch {
						Language.ENG => "Autotomize",
						Language.JPN => "ボディパージ",
						Language.GER => "Autotomie",
						Language.FRE => "Allègement",
						Language.ITA => "Sganciapesi",
						Language.SPN => "Aligerar",
						Language.KOR => "바디퍼지",
						Language.CHN_SIM => "身体轻量化",
						Language.CHN_TRA => "身體輕量化",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AVALANCHE:
					return lang switch {
						Language.ENG => "Avalanche",
						Language.JPN => "ゆきなだれ",
						Language.GER => "Lawine",
						Language.FRE => "Avalanche",
						Language.ITA => "Slavina",
						Language.SPN => "Alud",
						Language.KOR => "눈사태",
						Language.CHN_SIM => "雪崩",
						Language.CHN_TRA => "雪崩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.AXE_KICK:
					return lang switch {
						Language.ENG => "Axe Kick",
						Language.JPN => "かかとおと",
						Language.GER => "Fersenkick",
						Language.FRE => "Talon-Marteau",
						Language.ITA => "Calcio ad Ascia",
						Language.SPN => "Patada Hacha",
						Language.KOR => "발꿈치찍기",
						Language.CHN_SIM => "下压踢",
						Language.CHN_TRA => "下壓踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BABY_DOLL_EYES:
					return lang switch {
						Language.ENG => "Baby-Doll Eyes",
						Language.JPN => "つぶらなひとみ",
						Language.GER => "Kulleraugen",
						Language.FRE => "Regard Touchant",
						Language.ITA => "Occhioni Teneri",
						Language.SPN => "Ojitos Tiernos",
						Language.KOR => "초롱초롱눈동자",
						Language.CHN_SIM => "圆瞳",
						Language.CHN_TRA => "圓瞳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BANEFUL_BUNKER:
					return lang switch {
						Language.ENG => "Baneful Bunker",
						Language.JPN => "トーチカ",
						Language.GER => "Bunker",
						Language.FRE => "Blockhaus",
						Language.ITA => "Fortino",
						Language.SPN => "Búnker",
						Language.KOR => "토치카",
						Language.CHN_SIM => "碉堡",
						Language.CHN_TRA => "碉堡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BARB_BARRAGE:
					return lang switch {
						Language.ENG => "Barb Barrage",
						Language.JPN => "どくばりセンボ",
						Language.GER => "Giftstachelregen",
						Language.FRE => "Multitoxik",
						Language.ITA => "Mille Fielespine",
						Language.SPN => "Mil Púas Tóxicas",
						Language.KOR => "독침천발",
						Language.CHN_SIM => "毒千针",
						Language.CHN_TRA => "毒千針",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BARRAGE:
					return lang switch {
						Language.ENG => "Barrage",
						Language.JPN => "たまなげ",
						Language.GER => "Stakkato",
						Language.FRE => "Pilonnage",
						Language.ITA => "Attacco Pioggia",
						Language.SPN => "Presa",
						Language.KOR => "구슬던지기",
						Language.CHN_SIM => "投球",
						Language.CHN_TRA => "投球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BARRIER:
					return lang switch {
						Language.ENG => "Barrier",
						Language.JPN => "バリアー",
						Language.GER => "Barriere",
						Language.FRE => "Bouclier",
						Language.ITA => "Barriera",
						Language.SPN => "Barrera",
						Language.KOR => "배리어",
						Language.CHN_SIM => "屏障",
						Language.CHN_TRA => "屏障",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BATON_PASS:
					return lang switch {
						Language.ENG => "Baton Pass",
						Language.JPN => "バトンタッチ",
						Language.GER => "Stafette",
						Language.FRE => "Relais",
						Language.ITA => "Staffetta",
						Language.SPN => "Relevo",
						Language.KOR => "배턴터치",
						Language.CHN_SIM => "接棒",
						Language.CHN_TRA => "接棒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BEAK_BLAST:
					return lang switch {
						Language.ENG => "Beak Blast",
						Language.JPN => "くちばしキャノン",
						Language.GER => "Schnabelkanone",
						Language.FRE => "Bec-Canon",
						Language.ITA => "Cannonbecco",
						Language.SPN => "Pico Cañón",
						Language.KOR => "부리캐논",
						Language.CHN_SIM => "鸟嘴加农炮",
						Language.CHN_TRA => "鳥嘴加農炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BEAT_UP:
					return lang switch {
						Language.ENG => "Beat Up",
						Language.JPN => "ふくろだたき",
						Language.GER => "Prügler",
						Language.FRE => "Baston",
						Language.ITA => "Picchiaduro",
						Language.SPN => "Paliza",
						Language.KOR => "집단구타",
						Language.CHN_SIM => "围攻",
						Language.CHN_TRA => "圍攻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BEHEMOTH_BASH:
					return lang switch {
						Language.ENG => "Behemoth Bash",
						Language.JPN => "きょじゅうだ",
						Language.GER => "Gigantenstoß",
						Language.FRE => "Aegis Maxima",
						Language.ITA => "Colpo Maestoso",
						Language.SPN => "Embate Supremo",
						Language.KOR => "거수탄",
						Language.CHN_SIM => "巨兽弹",
						Language.CHN_TRA => "巨獸彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BEHEMOTH_BLADE:
					return lang switch {
						Language.ENG => "Behemoth Blade",
						Language.JPN => "きょじゅうざ",
						Language.GER => "Gigantenhieb",
						Language.FRE => "Gladius Maximus",
						Language.ITA => "Taglio Maestoso",
						Language.SPN => "Tajo Supremo",
						Language.KOR => "거수참",
						Language.CHN_SIM => "巨兽斩",
						Language.CHN_TRA => "巨獸斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BELCH:
					return lang switch {
						Language.ENG => "Belch",
						Language.JPN => "ゲップ",
						Language.GER => "Rülpser",
						Language.FRE => "Éructation",
						Language.ITA => "Rutto",
						Language.SPN => "Eructo",
						Language.KOR => "트림",
						Language.CHN_SIM => "打嗝",
						Language.CHN_TRA => "打嗝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BELLY_DRUM:
					return lang switch {
						Language.ENG => "Belly Drum",
						Language.JPN => "はらだいこ",
						Language.GER => "Bauchtrommel",
						Language.FRE => "Cognobidon",
						Language.ITA => "Panciamburo",
						Language.SPN => "Tambor",
						Language.KOR => "배북",
						Language.CHN_SIM => "腹鼓",
						Language.CHN_TRA => "腹鼓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BESTOW:
					return lang switch {
						Language.ENG => "Bestow",
						Language.JPN => "ギフトパス",
						Language.GER => "Offerte",
						Language.FRE => "Passe-Cadeau",
						Language.ITA => "Cediregalo",
						Language.SPN => "Ofrenda",
						Language.KOR => "기프트패스",
						Language.CHN_SIM => "传递礼物",
						Language.CHN_TRA => "傳遞禮物",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BIDE:
					return lang switch {
						Language.ENG => "Bide",
						Language.JPN => "がまん",
						Language.GER => "Geduld",
						Language.FRE => "Patience",
						Language.ITA => "Pazienza",
						Language.SPN => "Venganza",
						Language.KOR => "참기",
						Language.CHN_SIM => "忍耐",
						Language.CHN_TRA => "忍耐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BIND:
					return lang switch {
						Language.ENG => "Bind",
						Language.JPN => "しめつける",
						Language.GER => "Klammergriff",
						Language.FRE => "Étreinte",
						Language.ITA => "Legatutto",
						Language.SPN => "Atadura",
						Language.KOR => "조이기",
						Language.CHN_SIM => "绑紧",
						Language.CHN_TRA => "綁緊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BITE:
					return lang switch {
						Language.ENG => "Bite",
						Language.JPN => "かみつく",
						Language.GER => "Biss",
						Language.FRE => "Morsure",
						Language.ITA => "Morso",
						Language.SPN => "Mordisco",
						Language.KOR => "물기",
						Language.CHN_SIM => "咬住",
						Language.CHN_TRA => "咬住",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BITTER_BLADE:
					return lang switch {
						Language.ENG => "Bitter Blade",
						Language.JPN => "むねんのつる",
						Language.GER => "Reueschwert",
						Language.FRE => "Lame en Peine",
						Language.ITA => "Lama del Rimorso",
						Language.SPN => "Espada Lamento",
						Language.KOR => "원념의칼",
						Language.CHN_SIM => "悔念剑",
						Language.CHN_TRA => "悔念劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BITTER_MALICE:
					return lang switch {
						Language.ENG => "Bitter Malice",
						Language.JPN => "うらみつら",
						Language.GER => "Niedertracht",
						Language.FRE => "Cœur de Rancœur",
						Language.ITA => "Livore",
						Language.SPN => "Rencor Reprimido",
						Language.KOR => "천추지한",
						Language.CHN_SIM => "冤冤相报",
						Language.CHN_TRA => "冤冤相報",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BLAST_BURN:
					return lang switch {
						Language.ENG => "Blast Burn",
						Language.JPN => "ブラストバーン",
						Language.GER => "Lohekanonade",
						Language.FRE => "Rafale Feu",
						Language.ITA => "Incendio",
						Language.SPN => "Anillo Ígneo",
						Language.KOR => "블라스트번",
						Language.CHN_SIM => "爆炸烈焰",
						Language.CHN_TRA => "爆炸烈焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BLAZE_KICK:
					return lang switch {
						Language.ENG => "Blaze Kick",
						Language.JPN => "ブレイズキック",
						Language.GER => "Feuerfeger",
						Language.FRE => "Pied Brûleur",
						Language.ITA => "Calciardente",
						Language.SPN => "Patada Ígnea",
						Language.KOR => "블레이즈킥",
						Language.CHN_SIM => "火焰踢",
						Language.CHN_TRA => "火焰踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BLEAKWIND_STORM:
					return lang switch {
						Language.ENG => "Bleakwind Storm",
						Language.JPN => "こがらしあら",
						Language.GER => "Polarorkan",
						Language.FRE => "Typhon Hivernal",
						Language.ITA => "Tempesta Boreale",
						Language.SPN => "Vendaval Gélido",
						Language.KOR => "찬바람폭풍",
						Language.CHN_SIM => "枯叶风暴",
						Language.CHN_TRA => "枯葉風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BLIZZARD:
					return lang switch {
						Language.ENG => "Blizzard",
						Language.JPN => "ふぶき",
						Language.GER => "Blizzard",
						Language.FRE => "Blizzard",
						Language.ITA => "Bora",
						Language.SPN => "Ventisca",
						Language.KOR => "눈보라",
						Language.CHN_SIM => "暴风雪",
						Language.CHN_TRA => "暴風雪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BLOCK:
					return lang switch {
						Language.ENG => "Block",
						Language.JPN => "とおせんぼう",
						Language.GER => "Rückentzug",
						Language.FRE => "Barrage",
						Language.ITA => "Blocco",
						Language.SPN => "Bloqueo",
						Language.KOR => "블록",
						Language.CHN_SIM => "挡路",
						Language.CHN_TRA => "擋路",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BLUE_FLARE:
					return lang switch {
						Language.ENG => "Blue Flare",
						Language.JPN => "あおいほのお",
						Language.GER => "Blauflammen",
						Language.FRE => "Flamme Bleue",
						Language.ITA => "Fuocoblu",
						Language.SPN => "Llama Azul",
						Language.KOR => "푸른불꽃",
						Language.CHN_SIM => "青焰",
						Language.CHN_TRA => "青焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BODY_PRESS:
					return lang switch {
						Language.ENG => "Body Press",
						Language.JPN => "ボディプレ",
						Language.GER => "Body Press",
						Language.FRE => "Big Splash",
						Language.ITA => "Schiacciacorpo",
						Language.SPN => "Plancha Corporal",
						Language.KOR => "바디프레스",
						Language.CHN_SIM => "扑击",
						Language.CHN_TRA => "撲擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BODY_SLAM:
					return lang switch {
						Language.ENG => "Body Slam",
						Language.JPN => "のしかかり",
						Language.GER => "Bodyslam",
						Language.FRE => "Plaquage",
						Language.ITA => "Corposcontro",
						Language.SPN => "Golpe Cuerpo",
						Language.KOR => "누르기",
						Language.CHN_SIM => "泰山压顶",
						Language.CHN_TRA => "泰山壓頂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BOLT_BEAK:
					return lang switch {
						Language.ENG => "Bolt Beak",
						Language.JPN => "でんげきくちば",
						Language.GER => "Schockschnabel",
						Language.FRE => "Prise de Bec",
						Language.ITA => "Beccoshock",
						Language.SPN => "Electropico",
						Language.KOR => "전격부리",
						Language.CHN_SIM => "电喙",
						Language.CHN_TRA => "電喙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BOLT_STRIKE:
					return lang switch {
						Language.ENG => "Bolt Strike",
						Language.JPN => "らいげき",
						Language.GER => "Blitzschlag",
						Language.FRE => "Charge Foudre",
						Language.ITA => "Lucesiluro",
						Language.SPN => "Ataque Fulgor",
						Language.KOR => "뇌격",
						Language.CHN_SIM => "雷击",
						Language.CHN_TRA => "雷擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BONE_CLUB:
					return lang switch {
						Language.ENG => "Bone Club",
						Language.JPN => "ホネこんぼう",
						Language.GER => "Knochenkeule",
						Language.FRE => "Massd'Os",
						Language.ITA => "Ossoclava",
						Language.SPN => "Hueso Palo",
						Language.KOR => "뼈다귀치기",
						Language.CHN_SIM => "骨棒",
						Language.CHN_TRA => "骨棒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BONE_RUSH:
					return lang switch {
						Language.ENG => "Bone Rush",
						Language.JPN => "ボーンラッシュ",
						Language.GER => "Knochenhatz",
						Language.FRE => "Charge-Os",
						Language.ITA => "Ossoraffica",
						Language.SPN => "Ataque Óseo",
						Language.KOR => "본러시",
						Language.CHN_SIM => "骨棒乱打",
						Language.CHN_TRA => "骨棒亂打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BONEMERANG:
					return lang switch {
						Language.ENG => "Bonemerang",
						Language.JPN => "ホネブーメラン",
						Language.GER => "Knochmerang",
						Language.FRE => "Osmerang",
						Language.ITA => "Ossomerang",
						Language.SPN => "Huesomerang",
						Language.KOR => "뼈다귀부메랑",
						Language.CHN_SIM => "骨头回力镖",
						Language.CHN_TRA => "骨頭回力鏢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BOOMBURST:
					return lang switch {
						Language.ENG => "Boomburst",
						Language.JPN => "ばくおんぱ",
						Language.GER => "Überschallknall",
						Language.FRE => "Bang Sonique",
						Language.ITA => "Ondaboato",
						Language.SPN => "Estruendo",
						Language.KOR => "폭음파",
						Language.CHN_SIM => "爆音波",
						Language.CHN_TRA => "爆音波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BOUNCE:
					return lang switch {
						Language.ENG => "Bounce",
						Language.JPN => "とびはねる",
						Language.GER => "Sprungfeder",
						Language.FRE => "Rebond",
						Language.ITA => "Rimbalzo",
						Language.SPN => "Bote",
						Language.KOR => "뛰어오르기",
						Language.CHN_SIM => "弹跳",
						Language.CHN_TRA => "彈跳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BRANCH_POKE:
					return lang switch {
						Language.ENG => "Branch Poke",
						Language.JPN => "えだづ",
						Language.GER => "Zweigstoß",
						Language.FRE => "Tapotige",
						Language.ITA => "Ramostoccata",
						Language.SPN => "Punzada Rama",
						Language.KOR => "가지찌르기",
						Language.CHN_SIM => "木枝突刺",
						Language.CHN_TRA => "木枝突刺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BRAVE_BIRD:
					return lang switch {
						Language.ENG => "Brave Bird",
						Language.JPN => "ブレイブバード",
						Language.GER => "Sturzflug",
						Language.FRE => "Rapace",
						Language.ITA => "Baldeali",
						Language.SPN => "Pájaro Osado",
						Language.KOR => "브레이브버드",
						Language.CHN_SIM => "勇鸟猛攻",
						Language.CHN_TRA => "勇鳥猛攻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BREAKING_SWIPE:
					return lang switch {
						Language.ENG => "Breaking Swipe",
						Language.JPN => "ワイドブレイカ",
						Language.GER => "Breitseite",
						Language.FRE => "Abattage",
						Language.ITA => "Vastoimpatto",
						Language.SPN => "Vasto Impacto",
						Language.KOR => "와이드브레이커",
						Language.CHN_SIM => "广域破坏",
						Language.CHN_TRA => "廣域破壞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BRICK_BREAK:
					return lang switch {
						Language.ENG => "Brick Break",
						Language.JPN => "かわらわり",
						Language.GER => "Durchbruch",
						Language.FRE => "Casse-Brique",
						Language.ITA => "Breccia",
						Language.SPN => "Demolición",
						Language.KOR => "깨트리기",
						Language.CHN_SIM => "劈瓦",
						Language.CHN_TRA => "劈瓦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BRINE:
					return lang switch {
						Language.ENG => "Brine",
						Language.JPN => "しおみず",
						Language.GER => "Lake",
						Language.FRE => "Saumure",
						Language.ITA => "Acquadisale",
						Language.SPN => "Salmuera",
						Language.KOR => "소금물",
						Language.CHN_SIM => "盐水",
						Language.CHN_TRA => "鹽水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BRUTAL_SWING:
					return lang switch {
						Language.ENG => "Brutal Swing",
						Language.JPN => "ぶんまわす",
						Language.GER => "Wirbler",
						Language.FRE => "Centrifugifle",
						Language.ITA => "Vorticolpo",
						Language.SPN => "Giro Vil",
						Language.KOR => "세차게휘두르기",
						Language.CHN_SIM => "狂舞挥打",
						Language.CHN_TRA => "狂舞揮打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BUBBLE:
					return lang switch {
						Language.ENG => "Bubble",
						Language.JPN => "あわ",
						Language.GER => "Blubber",
						Language.FRE => "Écume",
						Language.ITA => "Bolla",
						Language.SPN => "Burbuja",
						Language.KOR => "거품",
						Language.CHN_SIM => "泡沫",
						Language.CHN_TRA => "泡沫",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BUBBLE_BEAM:
					return lang switch {
						Language.ENG => "Bubble Beam",
						Language.JPN => "バブルこうせん",
						Language.GER => "Blubbstrahl",
						Language.FRE => "Bulles d'O",
						Language.ITA => "Bollaraggio",
						Language.SPN => "Rayo Burbuja",
						Language.KOR => "거품광선",
						Language.CHN_SIM => "泡沫光线",
						Language.CHN_TRA => "泡沫光線",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BUG_BITE:
					return lang switch {
						Language.ENG => "Bug Bite",
						Language.JPN => "むしくい",
						Language.GER => "Käferbiss",
						Language.FRE => "Piqûre",
						Language.ITA => "Coleomorso",
						Language.SPN => "Picadura",
						Language.KOR => "벌레먹기",
						Language.CHN_SIM => "虫咬",
						Language.CHN_TRA => "蟲咬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BUG_BUZZ:
					return lang switch {
						Language.ENG => "Bug Buzz",
						Language.JPN => "むしのさざめき",
						Language.GER => "Käfergebrumm",
						Language.FRE => "Bourdon",
						Language.ITA => "Ronzio",
						Language.SPN => "Zumbido",
						Language.KOR => "벌레의야단법석",
						Language.CHN_SIM => "虫鸣",
						Language.CHN_TRA => "蟲鳴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BULK_UP:
					return lang switch {
						Language.ENG => "Bulk Up",
						Language.JPN => "ビルドアップ",
						Language.GER => "Protzer",
						Language.FRE => "Gonflette",
						Language.ITA => "Granfisico",
						Language.SPN => "Corpulencia",
						Language.KOR => "벌크업",
						Language.CHN_SIM => "健美",
						Language.CHN_TRA => "健美",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BULLDOZE:
					return lang switch {
						Language.ENG => "Bulldoze",
						Language.JPN => "じならし",
						Language.GER => "Dampfwalze",
						Language.FRE => "Piétisol",
						Language.ITA => "Battiterra",
						Language.SPN => "Terratemblor",
						Language.KOR => "땅고르기",
						Language.CHN_SIM => "重踏",
						Language.CHN_TRA => "重踏",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BULLET_PUNCH:
					return lang switch {
						Language.ENG => "Bullet Punch",
						Language.JPN => "バレットパンチ",
						Language.GER => "Patronenhieb",
						Language.FRE => "Pisto-Poing",
						Language.ITA => "Pugnoscarica",
						Language.SPN => "Puño Bala",
						Language.KOR => "불릿펀치",
						Language.CHN_SIM => "子弹拳",
						Language.CHN_TRA => "子彈拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BULLET_SEED:
					return lang switch {
						Language.ENG => "Bullet Seed",
						Language.JPN => "タネマシンガン",
						Language.GER => "Kugelsaat",
						Language.FRE => "Balle Graine",
						Language.ITA => "Semitraglia",
						Language.SPN => "Recurrente",
						Language.KOR => "씨기관총",
						Language.CHN_SIM => "种子机关枪",
						Language.CHN_TRA => "種子機關槍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BURN_UP:
					return lang switch {
						Language.ENG => "Burn Up",
						Language.JPN => "もえつきる",
						Language.GER => "Ausbrennen",
						Language.FRE => "Flamme Ultime",
						Language.ITA => "Ultima Fiamma",
						Language.SPN => "Llama Final",
						Language.KOR => "불사르기",
						Language.CHN_SIM => "燃尽",
						Language.CHN_TRA => "燃盡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.BURNING_JEALOUSY:
					return lang switch {
						Language.ENG => "Burning Jealousy",
						Language.JPN => "しっとのほの",
						Language.GER => "Neidflammen",
						Language.FRE => "Feu Envieux",
						Language.ITA => "Fiamminvidia",
						Language.SPN => "Envidia Ardiente",
						Language.KOR => "질투의불꽃",
						Language.CHN_SIM => "妒火",
						Language.CHN_TRA => "妒火",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CALM_MIND:
					return lang switch {
						Language.ENG => "Calm Mind",
						Language.JPN => "めいそう",
						Language.GER => "Gedankengut",
						Language.FRE => "Plénitude",
						Language.ITA => "Calmamente",
						Language.SPN => "Paz Mental",
						Language.KOR => "명상",
						Language.CHN_SIM => "冥想",
						Language.CHN_TRA => "冥想",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CAMOUFLAGE:
					return lang switch {
						Language.ENG => "Camouflage",
						Language.JPN => "ほごしょく",
						Language.GER => "Tarnung",
						Language.FRE => "Camouflage",
						Language.ITA => "Camuffamento",
						Language.SPN => "Camuflaje",
						Language.KOR => "보호색",
						Language.CHN_SIM => "保护色",
						Language.CHN_TRA => "保護色",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CAPTIVATE:
					return lang switch {
						Language.ENG => "Captivate",
						Language.JPN => "ゆうわく",
						Language.GER => "Liebreiz",
						Language.FRE => "Séduction",
						Language.ITA => "Incanto",
						Language.SPN => "Seducción",
						Language.KOR => "유혹",
						Language.CHN_SIM => "诱惑",
						Language.CHN_TRA => "誘惑",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CEASELESS_EDGE:
					return lang switch {
						Language.ENG => "Ceaseless Edge",
						Language.JPN => "ひけん・ちえな",
						Language.GER => "Klingenschwall",
						Language.FRE => "Vagues à Lames",
						Language.ITA => "Lama Milleflutti",
						Language.SPN => "Tajo Metralla",
						Language.KOR => "비검천중파",
						Language.CHN_SIM => "秘剑・千重涛",
						Language.CHN_TRA => "秘劍・千重濤",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHARGE:
					return lang switch {
						Language.ENG => "Charge",
						Language.JPN => "じゅうでん",
						Language.GER => "Ladevorgang",
						Language.FRE => "Chargeur",
						Language.ITA => "Sottocarica",
						Language.SPN => "Carga",
						Language.KOR => "충전",
						Language.CHN_SIM => "充电",
						Language.CHN_TRA => "充電",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHARGE_BEAM:
					return lang switch {
						Language.ENG => "Charge Beam",
						Language.JPN => "チャージビーム",
						Language.GER => "Ladestrahl",
						Language.FRE => "Rayon Chargé",
						Language.ITA => "Raggioscossa",
						Language.SPN => "Rayo Carga",
						Language.KOR => "차지빔",
						Language.CHN_SIM => "充电光束",
						Language.CHN_TRA => "充電光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHARM:
					return lang switch {
						Language.ENG => "Charm",
						Language.JPN => "あまえる",
						Language.GER => "Charme",
						Language.FRE => "Charme",
						Language.ITA => "Fascino",
						Language.SPN => "Encanto",
						Language.KOR => "애교부리기",
						Language.CHN_SIM => "撒娇",
						Language.CHN_TRA => "撒嬌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHATTER:
					return lang switch {
						Language.ENG => "Chatter",
						Language.JPN => "おしゃべり",
						Language.GER => "Geschwätz",
						Language.FRE => "Babil",
						Language.ITA => "Schiamazzo",
						Language.SPN => "Cháchara",
						Language.KOR => "수다",
						Language.CHN_SIM => "喋喋不休",
						Language.CHN_TRA => "喋喋不休",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHILLING_WATER:
					return lang switch {
						Language.ENG => "Chilling Water",
						Language.JPN => "ひやみ",
						Language.GER => "Kalte Dusche",
						Language.FRE => "Douche Froide",
						Language.ITA => "Doccia Fredda",
						Language.SPN => "Agua Fría",
						Language.KOR => "찬물끼얹기",
						Language.CHN_SIM => "泼冷水",
						Language.CHN_TRA => "潑冷水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHILLY_RECEPTION:
					return lang switch {
						Language.ENG => "Chilly Reception",
						Language.JPN => "さむいギャ",
						Language.GER => "Eisige Stimmung",
						Language.FRE => "Neigeux de Mots",
						Language.ITA => "Freddura",
						Language.SPN => "Fría Acogida",
						Language.KOR => "썰렁개그",
						Language.CHN_SIM => "冷笑话",
						Language.CHN_TRA => "冷笑話",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHIP_AWAY:
					return lang switch {
						Language.ENG => "Chip Away",
						Language.JPN => "なしくずし",
						Language.GER => "Zermürben",
						Language.FRE => "Attrition",
						Language.ITA => "Insidia",
						Language.SPN => "Guardia Baja",
						Language.KOR => "야금야금",
						Language.CHN_SIM => "逐步击破",
						Language.CHN_TRA => "逐步擊破",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CHLOROBLAST:
					return lang switch {
						Language.ENG => "Chloroblast",
						Language.JPN => "クロロブラス",
						Language.GER => "Chlorostrahl",
						Language.FRE => "Herblast",
						Language.ITA => "Clorofillaser",
						Language.SPN => "Clorofiláser",
						Language.KOR => "클로로블라스트",
						Language.CHN_SIM => "叶绿爆震",
						Language.CHN_TRA => "葉綠爆震",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CIRCLE_THROW:
					return lang switch {
						Language.ENG => "Circle Throw",
						Language.JPN => "ともえなげ",
						Language.GER => "Überkopfwurf",
						Language.FRE => "Projection",
						Language.ITA => "Ribaltiro",
						Language.SPN => "Llave Giro",
						Language.KOR => "배대뒤치기",
						Language.CHN_SIM => "巴投",
						Language.CHN_TRA => "巴投",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CLAMP:
					return lang switch {
						Language.ENG => "Clamp",
						Language.JPN => "からではさむ",
						Language.GER => "Schnapper",
						Language.FRE => "Claquoir",
						Language.ITA => "Tenaglia",
						Language.SPN => "Tenaza",
						Language.KOR => "껍질끼우기",
						Language.CHN_SIM => "贝壳夹击",
						Language.CHN_TRA => "貝殼夾擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CLANGING_SCALES:
					return lang switch {
						Language.ENG => "Clanging Scales",
						Language.JPN => "スケイルノイズ",
						Language.GER => "Schuppenrasseln",
						Language.FRE => "Vibrécaille",
						Language.ITA => "Clamorsquame",
						Language.SPN => "Fragor Escamas",
						Language.KOR => "스케일노이즈",
						Language.CHN_SIM => "鳞片噪音",
						Language.CHN_TRA => "鱗片噪音",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CLANGOROUS_SOUL:
					return lang switch {
						Language.ENG => "Clangorous Soul",
						Language.JPN => "ソウルビー",
						Language.GER => "Seelentanz",
						Language.FRE => "Dracacophonie",
						Language.ITA => "Dracofonia",
						Language.SPN => "Estruendo Escama",
						Language.KOR => "소울비트",
						Language.CHN_SIM => "魂舞烈音爆",
						Language.CHN_TRA => "魂舞烈音爆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CLEAR_SMOG:
					return lang switch {
						Language.ENG => "Clear Smog",
						Language.JPN => "クリアスモッグ",
						Language.GER => "Klärsmog",
						Language.FRE => "Bain de Smog",
						Language.ITA => "Pulifumo",
						Language.SPN => "Niebla Clara",
						Language.KOR => "클리어스모그",
						Language.CHN_SIM => "清除之烟",
						Language.CHN_TRA => "清除之煙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CLOSE_COMBAT:
					return lang switch {
						Language.ENG => "Close Combat",
						Language.JPN => "インファイト",
						Language.GER => "Nahkampf",
						Language.FRE => "Close Combat",
						Language.ITA => "Zuffa",
						Language.SPN => "A Bocajarro",
						Language.KOR => "인파이트",
						Language.CHN_SIM => "近身战",
						Language.CHN_TRA => "近身戰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COACHING:
					return lang switch {
						Language.ENG => "Coaching",
						Language.JPN => "コーチン",
						Language.GER => "Coaching",
						Language.FRE => "Coaching",
						Language.ITA => "Coaching",
						Language.SPN => "Motivación",
						Language.KOR => "코칭",
						Language.CHN_SIM => "指导",
						Language.CHN_TRA => "指導",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COIL:
					return lang switch {
						Language.ENG => "Coil",
						Language.JPN => "とぐろをまく",
						Language.GER => "Einrollen",
						Language.FRE => "Enroulement",
						Language.ITA => "Arrotola",
						Language.SPN => "Enrosque",
						Language.KOR => "똬리틀기",
						Language.CHN_SIM => "盘蜷",
						Language.CHN_TRA => "盤蜷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COLLISION_COURSE:
					return lang switch {
						Language.ENG => "Collision Course",
						Language.JPN => "アクセルブレイ",
						Language.GER => "Kollisionskurs",
						Language.FRE => "Nitro Crash",
						Language.ITA => "Turboschianto",
						Language.SPN => "Nitrochoque",
						Language.KOR => "액셀브레이크",
						Language.CHN_SIM => "全开猛撞",
						Language.CHN_TRA => "全開猛撞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COMET_PUNCH:
					return lang switch {
						Language.ENG => "Comet Punch",
						Language.JPN => "れんぞくパンチ",
						Language.GER => "Kometenhieb",
						Language.FRE => "Poing Comète",
						Language.ITA => "Cometapugno",
						Language.SPN => "Puño Cometa",
						Language.KOR => "연속펀치",
						Language.CHN_SIM => "连续拳",
						Language.CHN_TRA => "連續拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COMEUPPANCE:
					return lang switch {
						Language.ENG => "Comeuppance",
						Language.JPN => "ほうふ",
						Language.GER => "Vendetta",
						Language.FRE => "Vindicte",
						Language.ITA => "Ritorsione",
						Language.SPN => "Resarcimiento",
						Language.KOR => "앙갚음",
						Language.CHN_SIM => "复仇",
						Language.CHN_TRA => "復仇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CONFIDE:
					return lang switch {
						Language.ENG => "Confide",
						Language.JPN => "ないしょばなし",
						Language.GER => "Vertrauenssache",
						Language.FRE => "Confidence",
						Language.ITA => "Confidenza",
						Language.SPN => "Confidencia",
						Language.KOR => "비밀이야기",
						Language.CHN_SIM => "密语",
						Language.CHN_TRA => "密語",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CONFUSE_RAY:
					return lang switch {
						Language.ENG => "Confuse Ray",
						Language.JPN => "あやしいひかり",
						Language.GER => "Konfustrahl",
						Language.FRE => "Onde Folie",
						Language.ITA => "Stordiraggio",
						Language.SPN => "Rayo Confuso",
						Language.KOR => "이상한빛",
						Language.CHN_SIM => "奇异之光",
						Language.CHN_TRA => "奇異之光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CONFUSION:
					return lang switch {
						Language.ENG => "Confusion",
						Language.JPN => "ねんりき",
						Language.GER => "Konfusion",
						Language.FRE => "Choc Mental",
						Language.ITA => "Confusione",
						Language.SPN => "Confusión",
						Language.KOR => "염동력",
						Language.CHN_SIM => "念力",
						Language.CHN_TRA => "念力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CONSTRICT:
					return lang switch {
						Language.ENG => "Constrict",
						Language.JPN => "からみつく",
						Language.GER => "Umklammerung",
						Language.FRE => "Constriction",
						Language.ITA => "Limitazione",
						Language.SPN => "Restricción",
						Language.KOR => "휘감기",
						Language.CHN_SIM => "缠绕",
						Language.CHN_TRA => "纏繞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CONVERSION:
					return lang switch {
						Language.ENG => "Conversion",
						Language.JPN => "テクスチャー",
						Language.GER => "Umwandlung",
						Language.FRE => "Conversion",
						Language.ITA => "Conversione",
						Language.SPN => "Conversión",
						Language.KOR => "텍스처",
						Language.CHN_SIM => "纹理",
						Language.CHN_TRA => "紋理",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CONVERSION_2:
					return lang switch {
						Language.ENG => "Conversion 2",
						Language.JPN => "テクスチャー２",
						Language.GER => "Umwandlung2",
						Language.FRE => "Conversion2",
						Language.ITA => "Conversione2",
						Language.SPN => "Conversión2",
						Language.KOR => "텍스처2",
						Language.CHN_SIM => "纹理２",
						Language.CHN_TRA => "紋理２",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COPYCAT:
					return lang switch {
						Language.ENG => "Copycat",
						Language.JPN => "まねっこ",
						Language.GER => "Imitator",
						Language.FRE => "Photocopie",
						Language.ITA => "Copione",
						Language.SPN => "Copión",
						Language.KOR => "흉내쟁이",
						Language.CHN_SIM => "仿效",
						Language.CHN_TRA => "仿效",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CORE_ENFORCER:
					return lang switch {
						Language.ENG => "Core Enforcer",
						Language.JPN => "コアパニッシャー",
						Language.GER => "Sanktionskern",
						Language.FRE => "Sanction Suprême",
						Language.ITA => "Nucleocastigo",
						Language.SPN => "Núcleo Castigo",
						Language.KOR => "코어퍼니셔",
						Language.CHN_SIM => "核心惩罚者",
						Language.CHN_TRA => "核心懲罰者",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CORROSIVE_GAS:
					return lang switch {
						Language.ENG => "Corrosive Gas",
						Language.JPN => "ふしょくガ",
						Language.GER => "Korrosionsgas",
						Language.FRE => "Gaz Corrosif",
						Language.ITA => "Gas Corrosivo",
						Language.SPN => "Gas Corrosivo",
						Language.KOR => "부식가스",
						Language.CHN_SIM => "腐蚀气体",
						Language.CHN_TRA => "腐蝕氣體",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COSMIC_POWER:
					return lang switch {
						Language.ENG => "Cosmic Power",
						Language.JPN => "コスモパワー",
						Language.GER => "Kosmik-Kraft",
						Language.FRE => "Force Cosmik",
						Language.ITA => "Cosmoforza",
						Language.SPN => "Masa Cósmica",
						Language.KOR => "코스믹파워",
						Language.CHN_SIM => "宇宙力量",
						Language.CHN_TRA => "宇宙力量",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COTTON_GUARD:
					return lang switch {
						Language.ENG => "Cotton Guard",
						Language.JPN => "コットンガード",
						Language.GER => "Watteschild",
						Language.FRE => "Cotogarde",
						Language.ITA => "Cotonscudo",
						Language.SPN => "Rizo Algodón",
						Language.KOR => "코튼가드",
						Language.CHN_SIM => "棉花防守",
						Language.CHN_TRA => "棉花防守",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COTTON_SPORE:
					return lang switch {
						Language.ENG => "Cotton Spore",
						Language.JPN => "わたほうし",
						Language.GER => "Baumwollsaat",
						Language.FRE => "Spore Coton",
						Language.ITA => "Cottonspora",
						Language.SPN => "Esporagodón",
						Language.KOR => "목화포자",
						Language.CHN_SIM => "棉孢子",
						Language.CHN_TRA => "棉孢子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COUNTER:
					return lang switch {
						Language.ENG => "Counter",
						Language.JPN => "カウンター",
						Language.GER => "Konter",
						Language.FRE => "Riposte",
						Language.ITA => "Contrattacco",
						Language.SPN => "Contraataque",
						Language.KOR => "카운터",
						Language.CHN_SIM => "双倍奉还",
						Language.CHN_TRA => "雙倍奉還",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COURT_CHANGE:
					return lang switch {
						Language.ENG => "Court Change",
						Language.JPN => "コートチェン",
						Language.GER => "Seitenwechsel",
						Language.FRE => "Change-Côté",
						Language.ITA => "Cambiocampo",
						Language.SPN => "Cambio de Cancha",
						Language.KOR => "코트체인지",
						Language.CHN_SIM => "换场",
						Language.CHN_TRA => "換場",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.COVET:
					return lang switch {
						Language.ENG => "Covet",
						Language.JPN => "ほしがる",
						Language.GER => "Bezirzer",
						Language.FRE => "Implore",
						Language.ITA => "Supplica",
						Language.SPN => "Antojo",
						Language.KOR => "탐내기",
						Language.CHN_SIM => "渴望",
						Language.CHN_TRA => "渴望",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CRABHAMMER:
					return lang switch {
						Language.ENG => "Crabhammer",
						Language.JPN => "クラブハンマー",
						Language.GER => "Krabbhammer",
						Language.FRE => "Pince-Masse",
						Language.ITA => "Martellata",
						Language.SPN => "Martillazo",
						Language.KOR => "집게해머",
						Language.CHN_SIM => "蟹钳锤",
						Language.CHN_TRA => "蟹鉗錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CRAFTY_SHIELD:
					return lang switch {
						Language.ENG => "Crafty Shield",
						Language.JPN => "トリックガード",
						Language.GER => "Trickschutz",
						Language.FRE => "Vigilance",
						Language.ITA => "Truccodifesa",
						Language.SPN => "Truco Defensa",
						Language.KOR => "트릭가드",
						Language.CHN_SIM => "戏法防守",
						Language.CHN_TRA => "戲法防守",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CROSS_CHOP:
					return lang switch {
						Language.ENG => "Cross Chop",
						Language.JPN => "クロスチョップ",
						Language.GER => "Kreuzhieb",
						Language.FRE => "Coup-Croix",
						Language.ITA => "Incrocolpo",
						Language.SPN => "Tajo Cruzado",
						Language.KOR => "크로스촙",
						Language.CHN_SIM => "十字劈",
						Language.CHN_TRA => "十字劈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CROSS_POISON:
					return lang switch {
						Language.ENG => "Cross Poison",
						Language.JPN => "クロスポイズン",
						Language.GER => "Giftstreich",
						Language.FRE => "Poison-Croix",
						Language.ITA => "Velenocroce",
						Language.SPN => "Veneno X",
						Language.KOR => "크로스포이즌",
						Language.CHN_SIM => "十字毒刃",
						Language.CHN_TRA => "十字毒刃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CRUNCH:
					return lang switch {
						Language.ENG => "Crunch",
						Language.JPN => "かみくだく",
						Language.GER => "Knirscher",
						Language.FRE => "Mâchouille",
						Language.ITA => "Sgranocchio",
						Language.SPN => "Triturar",
						Language.KOR => "깨물어부수기",
						Language.CHN_SIM => "咬碎",
						Language.CHN_TRA => "咬碎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CRUSH_CLAW:
					return lang switch {
						Language.ENG => "Crush Claw",
						Language.JPN => "ブレイククロー",
						Language.GER => "Zermalmklaue",
						Language.FRE => "Éclate Griffe",
						Language.ITA => "Tritartigli",
						Language.SPN => "Garra Brutal",
						Language.KOR => "브레이크클로",
						Language.CHN_SIM => "撕裂爪",
						Language.CHN_TRA => "撕裂爪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CRUSH_GRIP:
					return lang switch {
						Language.ENG => "Crush Grip",
						Language.JPN => "にぎりつぶす",
						Language.GER => "Quetschgriff",
						Language.FRE => "Presse",
						Language.ITA => "Sbriciolmano",
						Language.SPN => "Agarrón",
						Language.KOR => "묵사발",
						Language.CHN_SIM => "捏碎",
						Language.CHN_TRA => "捏碎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CURSE:
					return lang switch {
						Language.ENG => "Curse",
						Language.JPN => "のろい",
						Language.GER => "Fluch",
						Language.FRE => "Malédiction",
						Language.ITA => "Maledizione",
						Language.SPN => "Maldición",
						Language.KOR => "저주",
						Language.CHN_SIM => "咒术",
						Language.CHN_TRA => "詛咒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.CUT:
					return lang switch {
						Language.ENG => "Cut",
						Language.JPN => "いあいぎり",
						Language.GER => "Zerschneider",
						Language.FRE => "Coupe",
						Language.ITA => "Taglio",
						Language.SPN => "Corte",
						Language.KOR => "풀베기",
						Language.CHN_SIM => "居合劈",
						Language.CHN_TRA => "居合斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DARK_PULSE:
					return lang switch {
						Language.ENG => "Dark Pulse",
						Language.JPN => "あくのはどう",
						Language.GER => "Finsteraura",
						Language.FRE => "Vibrobscur",
						Language.ITA => "Neropulsar",
						Language.SPN => "Pulso Umbrío",
						Language.KOR => "악의파동",
						Language.CHN_SIM => "恶之波动",
						Language.CHN_TRA => "惡之波動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DARK_VOID:
					return lang switch {
						Language.ENG => "Dark Void",
						Language.JPN => "ダークホール",
						Language.GER => "Schlummerort",
						Language.FRE => "Trou Noir",
						Language.ITA => "Vuototetro",
						Language.SPN => "Brecha Negra",
						Language.KOR => "다크홀",
						Language.CHN_SIM => "暗黑洞",
						Language.CHN_TRA => "暗黑洞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DARKEST_LARIAT:
					return lang switch {
						Language.ENG => "Darkest Lariat",
						Language.JPN => "DDラリアト",
						Language.GER => "Dark Lariat",
						Language.FRE => "Dark Lariat",
						Language.ITA => "Braccioteso",
						Language.SPN => "Lariat Oscuro",
						Language.KOR => "DD래리어트",
						Language.CHN_SIM => "ＤＤ金勾臂",
						Language.CHN_TRA => "ＤＤ金勾臂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DAZZLING_GLEAM:
					return lang switch {
						Language.ENG => "Dazzling Gleam",
						Language.JPN => "マジカルシャイン",
						Language.GER => "Zauberschein",
						Language.FRE => "Éclat Magique",
						Language.ITA => "Magibrillio",
						Language.SPN => "Brillo Mágico",
						Language.KOR => "매지컬샤인",
						Language.CHN_SIM => "魔法闪耀",
						Language.CHN_TRA => "魔法閃耀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DECORATE:
					return lang switch {
						Language.ENG => "Decorate",
						Language.JPN => "デコレーショ",
						Language.GER => "Verzierung",
						Language.FRE => "Nappage",
						Language.ITA => "Decorazione",
						Language.SPN => "Decoración",
						Language.KOR => "데코레이션",
						Language.CHN_SIM => "装饰",
						Language.CHN_TRA => "裝飾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DEFEND_ORDER:
					return lang switch {
						Language.ENG => "Defend Order",
						Language.JPN => "ぼうぎょしれい",
						Language.GER => "Blockbefehl",
						Language.FRE => "Appel Défense",
						Language.ITA => "Comandoscudo",
						Language.SPN => "A Defender",
						Language.KOR => "방어지령",
						Language.CHN_SIM => "防御指令",
						Language.CHN_TRA => "防禦指令",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DEFENSE_CURL:
					return lang switch {
						Language.ENG => "Defense Curl",
						Language.JPN => "まるくなる",
						Language.GER => "Einigler",
						Language.FRE => "Boul'Armure",
						Language.ITA => "Ricciolscudo",
						Language.SPN => "Rizo Defensa",
						Language.KOR => "웅크리기",
						Language.CHN_SIM => "变圆",
						Language.CHN_TRA => "變圓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DEFOG:
					return lang switch {
						Language.ENG => "Defog",
						Language.JPN => "きりばらい",
						Language.GER => "Auflockern",
						Language.FRE => "Anti-Brume",
						Language.ITA => "Scacciabruma",
						Language.SPN => "Despejar",
						Language.KOR => "안개제거",
						Language.CHN_SIM => "清除浓雾",
						Language.CHN_TRA => "清除濃霧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DESTINY_BOND:
					return lang switch {
						Language.ENG => "Destiny Bond",
						Language.JPN => "みちづれ",
						Language.GER => "Abgangsbund",
						Language.FRE => "Prélèvem. Destin",
						Language.ITA => "Destinobbligato",
						Language.SPN => "Mismo Destino",
						Language.KOR => "길동무",
						Language.CHN_SIM => "同命",
						Language.CHN_TRA => "同命",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DETECT:
					return lang switch {
						Language.ENG => "Detect",
						Language.JPN => "みきり",
						Language.GER => "Scanner",
						Language.FRE => "Détection",
						Language.ITA => "Individua",
						Language.SPN => "Detección",
						Language.KOR => "판별",
						Language.CHN_SIM => "看穿",
						Language.CHN_TRA => "看穿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DIAMOND_STORM:
					return lang switch {
						Language.ENG => "Diamond Storm",
						Language.JPN => "ダイヤストーム",
						Language.GER => "Diamantsturm",
						Language.FRE => "Orage Adamantin",
						Language.ITA => "Diamantempesta",
						Language.SPN => "Torm. Diamantes",
						Language.KOR => "다이아스톰",
						Language.CHN_SIM => "钻石风暴",
						Language.CHN_TRA => "鑽石風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DIG:
					return lang switch {
						Language.ENG => "Dig",
						Language.JPN => "あなをほる",
						Language.GER => "Schaufler",
						Language.FRE => "Tunnel",
						Language.ITA => "Fossa",
						Language.SPN => "Excavar",
						Language.KOR => "구멍파기",
						Language.CHN_SIM => "挖洞",
						Language.CHN_TRA => "挖洞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DIRE_CLAW:
					return lang switch {
						Language.ENG => "Dire Claw",
						Language.JPN => "フェイタルクロ",
						Language.GER => "Unheilsklauen",
						Language.FRE => "Griffes Funestes",
						Language.ITA => "Artigli Fatali",
						Language.SPN => "Garra Nociva",
						Language.KOR => "페이탈클로",
						Language.CHN_SIM => "克命爪",
						Language.CHN_TRA => "剋命爪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DISABLE:
					return lang switch {
						Language.ENG => "Disable",
						Language.JPN => "かなしばり",
						Language.GER => "Aussetzer",
						Language.FRE => "Entrave",
						Language.ITA => "Inibitore",
						Language.SPN => "Anulación",
						Language.KOR => "사슬묶기",
						Language.CHN_SIM => "定身法",
						Language.CHN_TRA => "定身法",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DISARMING_VOICE:
					return lang switch {
						Language.ENG => "Disarming Voice",
						Language.JPN => "チャームボイス",
						Language.GER => "Säuselstimme",
						Language.FRE => "Voix Enjôleuse",
						Language.ITA => "Incantavoce",
						Language.SPN => "Voz Cautivadora",
						Language.KOR => "차밍보이스",
						Language.CHN_SIM => "魅惑之声",
						Language.CHN_TRA => "魅惑之聲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DISCHARGE:
					return lang switch {
						Language.ENG => "Discharge",
						Language.JPN => "ほうでん",
						Language.GER => "Ladungsstoß",
						Language.FRE => "Coup d'Jus",
						Language.ITA => "Scarica",
						Language.SPN => "Chispazo",
						Language.KOR => "방전",
						Language.CHN_SIM => "放电",
						Language.CHN_TRA => "放電",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DIVE:
					return lang switch {
						Language.ENG => "Dive",
						Language.JPN => "ダイビング",
						Language.GER => "Taucher",
						Language.FRE => "Plongée",
						Language.ITA => "Sub",
						Language.SPN => "Buceo",
						Language.KOR => "다이빙",
						Language.CHN_SIM => "潜水",
						Language.CHN_TRA => "潛水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DIZZY_PUNCH:
					return lang switch {
						Language.ENG => "Dizzy Punch",
						Language.JPN => "ピヨピヨパンチ",
						Language.GER => "Irrschlag",
						Language.FRE => "Uppercut",
						Language.ITA => "Stordipugno",
						Language.SPN => "Puño Mareo",
						Language.KOR => "잼잼펀치",
						Language.CHN_SIM => "迷昏拳",
						Language.CHN_TRA => "迷昏拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOODLE:
					return lang switch {
						Language.ENG => "Doodle",
						Language.JPN => "うつし",
						Language.GER => "Abpausen",
						Language.FRE => "Décalquage",
						Language.ITA => "Ricalco",
						Language.SPN => "Decalcomanía",
						Language.KOR => "베껴그리기",
						Language.CHN_SIM => "描绘",
						Language.CHN_TRA => "描繪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOOM_DESIRE:
					return lang switch {
						Language.ENG => "Doom Desire",
						Language.JPN => "はめつのねがい",
						Language.GER => "Kismetwunsch",
						Language.FRE => "Carnareket",
						Language.ITA => "Obbliderio",
						Language.SPN => "Deseo Oculto",
						Language.KOR => "파멸의소원",
						Language.CHN_SIM => "破灭之愿",
						Language.CHN_TRA => "破滅之願",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_HIT:
					return lang switch {
						Language.ENG => "Double Hit",
						Language.JPN => "ダブルアタック",
						Language.GER => "Doppelschlag",
						Language.FRE => "Coup Double",
						Language.ITA => "Doppiosmash",
						Language.SPN => "Doble Golpe",
						Language.KOR => "더블어택",
						Language.CHN_SIM => "二连击",
						Language.CHN_TRA => "二連擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_IRON_BASH:
					return lang switch {
						Language.ENG => "Double Iron Bash",
						Language.JPN => "ダブルパンツァ",
						Language.GER => "Panzerfäuste",
						Language.FRE => "Écrous d’Poing",
						Language.ITA => "Pugni Corazzati",
						Language.SPN => "Ferropuño Doble",
						Language.KOR => "더블펀처",
						Language.CHN_SIM => "钢拳双击",
						Language.CHN_TRA => "鋼拳雙擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_KICK:
					return lang switch {
						Language.ENG => "Double Kick",
						Language.JPN => "にどげり",
						Language.GER => "Doppelkick",
						Language.FRE => "Double Pied",
						Language.ITA => "Doppiocalcio",
						Language.SPN => "Doble Patada",
						Language.KOR => "두번차기",
						Language.CHN_SIM => "二连踢",
						Language.CHN_TRA => "二連踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_SHOCK:
					return lang switch {
						Language.ENG => "Double Shock",
						Language.JPN => "でんこうそうげ",
						Language.GER => "Zweifachladung",
						Language.FRE => "Double Décharge",
						Language.ITA => "Doppiolampo",
						Language.SPN => "Electropalmas",
						Language.KOR => "전광쌍격",
						Language.CHN_SIM => "电光双击",
						Language.CHN_TRA => "電光雙擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_SLAP:
					return lang switch {
						Language.ENG => "Double Slap",
						Language.JPN => "おうふくビンタ",
						Language.GER => "Duplexhieb",
						Language.FRE => "Torgnoles",
						Language.ITA => "Doppiasberla",
						Language.SPN => "Doble Bofetón",
						Language.KOR => "연속뺨치기",
						Language.CHN_SIM => "连环巴掌",
						Language.CHN_TRA => "連環巴掌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_TEAM:
					return lang switch {
						Language.ENG => "Double Team",
						Language.JPN => "かげぶんしん",
						Language.GER => "Doppelteam",
						Language.FRE => "Reflet",
						Language.ITA => "Doppioteam",
						Language.SPN => "Doble Equipo",
						Language.KOR => "그림자분신",
						Language.CHN_SIM => "影子分身",
						Language.CHN_TRA => "影子分身",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DOUBLE_EDGE:
					return lang switch {
						Language.ENG => "Double-Edge",
						Language.JPN => "すてみタックル",
						Language.GER => "Risikotackle",
						Language.FRE => "Damoclès",
						Language.ITA => "Sdoppiatore",
						Language.SPN => "Doble Filo",
						Language.KOR => "이판사판태클",
						Language.CHN_SIM => "舍身冲撞",
						Language.CHN_TRA => "捨身衝撞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRACO_METEOR:
					return lang switch {
						Language.ENG => "Draco Meteor",
						Language.JPN => "りゅうせいぐん",
						Language.GER => "Draco Meteor",
						Language.FRE => "Draco Météor",
						Language.ITA => "Dragobolide",
						Language.SPN => "Cometa Draco",
						Language.KOR => "용성군",
						Language.CHN_SIM => "流星群",
						Language.CHN_TRA => "流星群",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_ASCENT:
					return lang switch {
						Language.ENG => "Dragon Ascent",
						Language.JPN => "ガリョウテンセイ",
						Language.GER => "Zenitstürmer",
						Language.FRE => "Draco Ascension",
						Language.ITA => "Ascesa del Drago",
						Language.SPN => "Ascenso Draco",
						Language.KOR => "화룡점정",
						Language.CHN_SIM => "画龙点睛",
						Language.CHN_TRA => "畫龍點睛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_BREATH:
					return lang switch {
						Language.ENG => "Dragon Breath",
						Language.JPN => "りゅうのいぶき",
						Language.GER => "Feuerodem",
						Language.FRE => "Dracosouffle",
						Language.ITA => "Dragospiro",
						Language.SPN => "Dragoaliento",
						Language.KOR => "용의숨결",
						Language.CHN_SIM => "龙息",
						Language.CHN_TRA => "龍息",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_CLAW:
					return lang switch {
						Language.ENG => "Dragon Claw",
						Language.JPN => "ドラゴンクロー",
						Language.GER => "Drachenklaue",
						Language.FRE => "Dracogriffe",
						Language.ITA => "Dragartigli",
						Language.SPN => "Garra Dragón",
						Language.KOR => "드래곤클로",
						Language.CHN_SIM => "龙爪",
						Language.CHN_TRA => "龍爪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_DANCE:
					return lang switch {
						Language.ENG => "Dragon Dance",
						Language.JPN => "りゅうのまい",
						Language.GER => "Drachentanz",
						Language.FRE => "Danse Draco",
						Language.ITA => "Dragodanza",
						Language.SPN => "Danza Dragón",
						Language.KOR => "용의춤",
						Language.CHN_SIM => "龙之舞",
						Language.CHN_TRA => "龍之舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_DARTS:
					return lang switch {
						Language.ENG => "Dragon Darts",
						Language.JPN => "ドラゴンアロ",
						Language.GER => "Drachenpfeile",
						Language.FRE => "Draco-Flèches",
						Language.ITA => "Dragofrecce",
						Language.SPN => "Dracoflechas",
						Language.KOR => "드래곤애로",
						Language.CHN_SIM => "龙箭",
						Language.CHN_TRA => "龍箭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_ENERGY:
					return lang switch {
						Language.ENG => "Dragon Energy",
						Language.JPN => "ドラゴンエナジ",
						Language.GER => "Drachenkräfte",
						Language.FRE => "Draco-Énergie",
						Language.ITA => "Dragoenergia",
						Language.SPN => "Dracoenergía",
						Language.KOR => "드래곤에너지",
						Language.CHN_SIM => "巨龙威能",
						Language.CHN_TRA => "巨龍威能",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_HAMMER:
					return lang switch {
						Language.ENG => "Dragon Hammer",
						Language.JPN => "ドラゴンハンマー",
						Language.GER => "Drachenhammer",
						Language.FRE => "Draco-Marteau",
						Language.ITA => "Marteldrago",
						Language.SPN => "Martillo Dragón",
						Language.KOR => "드래곤해머",
						Language.CHN_SIM => "龙锤",
						Language.CHN_TRA => "龍錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_PULSE:
					return lang switch {
						Language.ENG => "Dragon Pulse",
						Language.JPN => "りゅうのはどう",
						Language.GER => "Drachenpuls",
						Language.FRE => "Dracochoc",
						Language.ITA => "Dragopulsar",
						Language.SPN => "Pulso Dragón",
						Language.KOR => "용의파동",
						Language.CHN_SIM => "龙之波动",
						Language.CHN_TRA => "龍之波動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_RAGE:
					return lang switch {
						Language.ENG => "Dragon Rage",
						Language.JPN => "りゅうのいかり",
						Language.GER => "Drachenwut",
						Language.FRE => "Draco-Rage",
						Language.ITA => "Ira di Drago",
						Language.SPN => "Furia Dragón",
						Language.KOR => "용의분노",
						Language.CHN_SIM => "龙之怒",
						Language.CHN_TRA => "龍之怒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_RUSH:
					return lang switch {
						Language.ENG => "Dragon Rush",
						Language.JPN => "ドラゴンダイブ",
						Language.GER => "Drachenstoß",
						Language.FRE => "Dracocharge",
						Language.ITA => "Dragofuria",
						Language.SPN => "Carga Dragón",
						Language.KOR => "드래곤다이브",
						Language.CHN_SIM => "龙之俯冲",
						Language.CHN_TRA => "龍之俯衝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAGON_TAIL:
					return lang switch {
						Language.ENG => "Dragon Tail",
						Language.JPN => "ドラゴンテール",
						Language.GER => "Drachenrute",
						Language.FRE => "Draco-Queue",
						Language.ITA => "Codadrago",
						Language.SPN => "Cola Dragón",
						Language.KOR => "드래곤테일",
						Language.CHN_SIM => "龙尾",
						Language.CHN_TRA => "龍尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAIN_PUNCH:
					return lang switch {
						Language.ENG => "Drain Punch",
						Language.JPN => "ドレインパンチ",
						Language.GER => "Ableithieb",
						Language.FRE => "Vampipoing",
						Language.ITA => "Assorbipugno",
						Language.SPN => "Puño Drenaje",
						Language.KOR => "드레인펀치",
						Language.CHN_SIM => "吸取拳",
						Language.CHN_TRA => "吸取拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRAINING_KISS:
					return lang switch {
						Language.ENG => "Draining Kiss",
						Language.JPN => "ドレインキッス",
						Language.GER => "Diebeskuss",
						Language.FRE => "Vampibaiser",
						Language.ITA => "Assorbibacio",
						Language.SPN => "Beso Drenaje",
						Language.KOR => "드레인키스",
						Language.CHN_SIM => "吸取之吻",
						Language.CHN_TRA => "吸取之吻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DREAM_EATER:
					return lang switch {
						Language.ENG => "Dream Eater",
						Language.JPN => "ゆめくい",
						Language.GER => "Traumfresser",
						Language.FRE => "Dévorêve",
						Language.ITA => "Mangiasogni",
						Language.SPN => "Come Sueños",
						Language.KOR => "꿈먹기",
						Language.CHN_SIM => "食梦",
						Language.CHN_TRA => "食夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRILL_PECK:
					return lang switch {
						Language.ENG => "Drill Peck",
						Language.JPN => "ドリルくちばし",
						Language.GER => "Bohrschnabel",
						Language.FRE => "Bec Vrille",
						Language.ITA => "Perforbecco",
						Language.SPN => "Pico Taladro",
						Language.KOR => "회전부리",
						Language.CHN_SIM => "啄钻",
						Language.CHN_TRA => "啄鑽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRILL_RUN:
					return lang switch {
						Language.ENG => "Drill Run",
						Language.JPN => "ドリルライナー",
						Language.GER => "Schlagbohrer",
						Language.FRE => "Tunnelier",
						Language.ITA => "Giravvita",
						Language.SPN => "Taladradora",
						Language.KOR => "드릴라이너",
						Language.CHN_SIM => "直冲钻",
						Language.CHN_TRA => "直衝鑽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DRUM_BEATING:
					return lang switch {
						Language.ENG => "Drum Beating",
						Language.JPN => "ドラムアタッ",
						Language.GER => "Trommelschläge",
						Language.FRE => "Tambour Battant",
						Language.ITA => "Tamburattacco",
						Language.SPN => "Batería Asalto",
						Language.KOR => "드럼어택",
						Language.CHN_SIM => "鼓击",
						Language.CHN_TRA => "鼓擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DUAL_CHOP:
					return lang switch {
						Language.ENG => "Dual Chop",
						Language.JPN => "ダブルチョップ",
						Language.GER => "Doppelhieb",
						Language.FRE => "Double Baffe",
						Language.ITA => "Doppiocolpo",
						Language.SPN => "Golpe Bis",
						Language.KOR => "더블촙",
						Language.CHN_SIM => "二连劈",
						Language.CHN_TRA => "二連劈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DUAL_WINGBEAT:
					return lang switch {
						Language.ENG => "Dual Wingbeat",
						Language.JPN => "ダブルウイン",
						Language.GER => "Doppelflügel",
						Language.FRE => "Double Volée",
						Language.ITA => "Doppia Ala",
						Language.SPN => "Ala Bis",
						Language.KOR => "더블윙",
						Language.CHN_SIM => "双翼",
						Language.CHN_TRA => "雙翼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DYNAMAX_CANNON:
					return lang switch {
						Language.ENG => "Dynamax Cannon",
						Language.JPN => "ダイマックスほ",
						Language.GER => "Dynamax-Kanone",
						Language.FRE => "Canon Dynamax",
						Language.ITA => "Cannone Dynamax",
						Language.SPN => "Cañón Dinamax",
						Language.KOR => "다이맥스포",
						Language.CHN_SIM => "极巨炮",
						Language.CHN_TRA => "極巨炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.DYNAMIC_PUNCH:
					return lang switch {
						Language.ENG => "Dynamic Punch",
						Language.JPN => "ばくれつパンチ",
						Language.GER => "Wuchtschlag",
						Language.FRE => "Dynamopoing",
						Language.ITA => "Dinamipugno",
						Language.SPN => "Puño Dinámico",
						Language.KOR => "폭발펀치",
						Language.CHN_SIM => "爆裂拳",
						Language.CHN_TRA => "爆裂拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EARTH_POWER:
					return lang switch {
						Language.ENG => "Earth Power",
						Language.JPN => "だいちのちから",
						Language.GER => "Erdkräfte",
						Language.FRE => "Telluriforce",
						Language.ITA => "Geoforza",
						Language.SPN => "Tierra Viva",
						Language.KOR => "대지의힘",
						Language.CHN_SIM => "大地之力",
						Language.CHN_TRA => "大地之力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EARTHQUAKE:
					return lang switch {
						Language.ENG => "Earthquake",
						Language.JPN => "じしん",
						Language.GER => "Erdbeben",
						Language.FRE => "Séisme",
						Language.ITA => "Terremoto",
						Language.SPN => "Terremoto",
						Language.KOR => "지진",
						Language.CHN_SIM => "地震",
						Language.CHN_TRA => "地震",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ECHOED_VOICE:
					return lang switch {
						Language.ENG => "Echoed Voice",
						Language.JPN => "エコーボイス",
						Language.GER => "Widerhall",
						Language.FRE => "Écho",
						Language.ITA => "Echeggiavoce",
						Language.SPN => "Eco Voz",
						Language.KOR => "에코보이스",
						Language.CHN_SIM => "回声",
						Language.CHN_TRA => "回聲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EERIE_IMPULSE:
					return lang switch {
						Language.ENG => "Eerie Impulse",
						Language.JPN => "かいでんぱ",
						Language.GER => "Mystowellen",
						Language.FRE => "Ondes Étranges",
						Language.ITA => "Elettromistero",
						Language.SPN => "Onda Anómala",
						Language.KOR => "괴전파",
						Language.CHN_SIM => "怪异电波",
						Language.CHN_TRA => "怪異電波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EERIE_SPELL:
					return lang switch {
						Language.ENG => "Eerie Spell",
						Language.JPN => "ぶきみなじゅも",
						Language.GER => "Schauderspruch",
						Language.FRE => "Sort Sinistre",
						Language.ITA => "Inquietantesimo",
						Language.SPN => "Conjuro Funesto",
						Language.KOR => "섬뜩한주문",
						Language.CHN_SIM => "诡异咒语",
						Language.CHN_TRA => "詭異咒語",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EGG_BOMB:
					return lang switch {
						Language.ENG => "Egg Bomb",
						Language.JPN => "タマゴばくだん",
						Language.GER => "Eierbombe",
						Language.FRE => "Bomb'Œuf",
						Language.ITA => "Uovobomba",
						Language.SPN => "Bomba Huevo",
						Language.KOR => "알폭탄",
						Language.CHN_SIM => "炸蛋",
						Language.CHN_TRA => "炸蛋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ELECTRIC_TERRAIN:
					return lang switch {
						Language.ENG => "Electric Terrain",
						Language.JPN => "エレキフィールド",
						Language.GER => "Elektrofeld",
						Language.FRE => "Champ Électrifié",
						Language.ITA => "Campo Elettrico",
						Language.SPN => "Campo Eléctrico",
						Language.KOR => "일렉트릭필드",
						Language.CHN_SIM => "电气场地",
						Language.CHN_TRA => "電氣場地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ELECTRIFY:
					return lang switch {
						Language.ENG => "Electrify",
						Language.JPN => "そうでん",
						Language.GER => "Elektrifizierung",
						Language.FRE => "Électrisation",
						Language.ITA => "Elettrocontagio",
						Language.SPN => "Electrificación",
						Language.KOR => "송전",
						Language.CHN_SIM => "输电",
						Language.CHN_TRA => "輸電",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ELECTRO_BALL:
					return lang switch {
						Language.ENG => "Electro Ball",
						Language.JPN => "エレキボール",
						Language.GER => "Elektroball",
						Language.FRE => "Boule Élek",
						Language.ITA => "Energisfera",
						Language.SPN => "Bola Voltio",
						Language.KOR => "일렉트릭볼",
						Language.CHN_SIM => "电球",
						Language.CHN_TRA => "電球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ELECTRO_DRIFT:
					return lang switch {
						Language.ENG => "Electro Drift",
						Language.JPN => "イナズマドライ",
						Language.GER => "Blitztour",
						Language.FRE => "Turbo Volt",
						Language.ITA => "Fulmiscatto",
						Language.SPN => "Electroderrape",
						Language.KOR => "라이트닝드라이브",
						Language.CHN_SIM => "闪电猛冲",
						Language.CHN_TRA => "閃電猛衝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ELECTROWEB:
					return lang switch {
						Language.ENG => "Electroweb",
						Language.JPN => "エレキネット",
						Language.GER => "Elektronetz",
						Language.FRE => "Toile Élek",
						Language.ITA => "Elettrotela",
						Language.SPN => "Electrotela",
						Language.KOR => "일렉트릭네트",
						Language.CHN_SIM => "电网",
						Language.CHN_TRA => "電網",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EMBARGO:
					return lang switch {
						Language.ENG => "Embargo",
						Language.JPN => "さしおさえ",
						Language.GER => "Itemsperre",
						Language.FRE => "Embargo",
						Language.ITA => "Divieto",
						Language.SPN => "Embargo",
						Language.KOR => "금제",
						Language.CHN_SIM => "查封",
						Language.CHN_TRA => "查封",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EMBER:
					return lang switch {
						Language.ENG => "Ember",
						Language.JPN => "ひのこ",
						Language.GER => "Glut",
						Language.FRE => "Flammèche",
						Language.ITA => "Braciere",
						Language.SPN => "Ascuas",
						Language.KOR => "불꽃세례",
						Language.CHN_SIM => "火花",
						Language.CHN_TRA => "火花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ENCORE:
					return lang switch {
						Language.ENG => "Encore",
						Language.JPN => "アンコール",
						Language.GER => "Zugabe",
						Language.FRE => "Encore",
						Language.ITA => "Ripeti",
						Language.SPN => "Otra Vez",
						Language.KOR => "앙코르",
						Language.CHN_SIM => "再来一次",
						Language.CHN_TRA => "再來一次",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ENDEAVOR:
					return lang switch {
						Language.ENG => "Endeavor",
						Language.JPN => "がむしゃら",
						Language.GER => "Notsituation",
						Language.FRE => "Effort",
						Language.ITA => "Rimonta",
						Language.SPN => "Esfuerzo",
						Language.KOR => "죽기살기",
						Language.CHN_SIM => "蛮干",
						Language.CHN_TRA => "蠻幹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ENDURE:
					return lang switch {
						Language.ENG => "Endure",
						Language.JPN => "こらえる",
						Language.GER => "Ausdauer",
						Language.FRE => "Ténacité",
						Language.ITA => "Resistenza",
						Language.SPN => "Aguante",
						Language.KOR => "버티기",
						Language.CHN_SIM => "挺住",
						Language.CHN_TRA => "挺住",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ENERGY_BALL:
					return lang switch {
						Language.ENG => "Energy Ball",
						Language.JPN => "エナジーボール",
						Language.GER => "Energieball",
						Language.FRE => "Éco-Sphère",
						Language.ITA => "Energipalla",
						Language.SPN => "Energibola",
						Language.KOR => "에너지볼",
						Language.CHN_SIM => "能量球",
						Language.CHN_TRA => "能量球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ENTRAINMENT:
					return lang switch {
						Language.ENG => "Entrainment",
						Language.JPN => "なかまづくり",
						Language.GER => "Zwango",
						Language.FRE => "Ten-danse",
						Language.ITA => "Saltamicizia",
						Language.SPN => "Danza Amiga",
						Language.KOR => "동료만들기",
						Language.CHN_SIM => "找伙伴",
						Language.CHN_TRA => "找夥伴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ERUPTION:
					return lang switch {
						Language.ENG => "Eruption",
						Language.JPN => "ふんか",
						Language.GER => "Eruption",
						Language.FRE => "Éruption",
						Language.ITA => "Eruzione",
						Language.SPN => "Estallido",
						Language.KOR => "분화",
						Language.CHN_SIM => "喷火",
						Language.CHN_TRA => "噴火",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ESPER_WING:
					return lang switch {
						Language.ENG => "Esper Wing",
						Language.JPN => "オーラウイン",
						Language.GER => "Auraschwingen",
						Language.FRE => "Ailes Psycho",
						Language.ITA => "Ali d’Aura",
						Language.SPN => "Ala Aural",
						Language.KOR => "오라윙",
						Language.CHN_SIM => "气场之翼",
						Language.CHN_TRA => "氣場之翼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ETERNABEAM:
					return lang switch {
						Language.ENG => "Eternabeam",
						Language.JPN => "ムゲンダイビー",
						Language.GER => "Unendynastrahlen",
						Language.FRE => "Laser Infinimax",
						Language.ITA => "Raggio Infinito",
						Language.SPN => "Rayo Infinito",
						Language.KOR => "무한다이빔",
						Language.CHN_SIM => "无极光束",
						Language.CHN_TRA => "無極光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EXPANDING_FORCE:
					return lang switch {
						Language.ENG => "Expanding Force",
						Language.JPN => "ワイドフォー",
						Language.GER => "Flächenmacht",
						Language.FRE => "Vaste Pouvoir",
						Language.ITA => "Vastenergia",
						Language.SPN => "Vasta Fuerza",
						Language.KOR => "와이드포스",
						Language.CHN_SIM => "广域战力",
						Language.CHN_TRA => "廣域戰力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EXPLOSION:
					return lang switch {
						Language.ENG => "Explosion",
						Language.JPN => "だいばくはつ",
						Language.GER => "Explosion",
						Language.FRE => "Explosion",
						Language.ITA => "Esplosione",
						Language.SPN => "Explosión",
						Language.KOR => "대폭발",
						Language.CHN_SIM => "大爆炸",
						Language.CHN_TRA => "大爆炸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EXTRASENSORY:
					return lang switch {
						Language.ENG => "Extrasensory",
						Language.JPN => "じんつうりき",
						Language.GER => "Sondersensor",
						Language.FRE => "Extrasenseur",
						Language.ITA => "Extrasenso",
						Language.SPN => "Paranormal",
						Language.KOR => "신통력",
						Language.CHN_SIM => "神通力",
						Language.CHN_TRA => "神通力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.EXTREME_SPEED:
					return lang switch {
						Language.ENG => "Extreme Speed",
						Language.JPN => "しんそく",
						Language.GER => "Turbotempo",
						Language.FRE => "Vitesse Extrême",
						Language.ITA => "Extrarapido",
						Language.SPN => "Veloc. Extrema",
						Language.KOR => "신속",
						Language.CHN_SIM => "神速",
						Language.CHN_TRA => "神速",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FACADE:
					return lang switch {
						Language.ENG => "Facade",
						Language.JPN => "からげんき",
						Language.GER => "Fassade",
						Language.FRE => "Façade",
						Language.ITA => "Facciata",
						Language.SPN => "Imagen",
						Language.KOR => "객기",
						Language.CHN_SIM => "硬撑",
						Language.CHN_TRA => "硬撐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FAIRY_LOCK:
					return lang switch {
						Language.ENG => "Fairy Lock",
						Language.JPN => "フェアリーロック",
						Language.GER => "Feenschloss",
						Language.FRE => "Verrou Enchanté",
						Language.ITA => "Blocco Fatato",
						Language.SPN => "Cerrojo Feérico",
						Language.KOR => "페어리록",
						Language.CHN_SIM => "妖精之锁",
						Language.CHN_TRA => "妖精之鎖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FAIRY_WIND:
					return lang switch {
						Language.ENG => "Fairy Wind",
						Language.JPN => "ようせいのかぜ",
						Language.GER => "Feenbrise",
						Language.FRE => "Vent Féérique",
						Language.ITA => "Vento di Fata",
						Language.SPN => "Viento Feérico",
						Language.KOR => "요정의바람",
						Language.CHN_SIM => "妖精之风",
						Language.CHN_TRA => "妖精之風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FAKE_OUT:
					return lang switch {
						Language.ENG => "Fake Out",
						Language.JPN => "ねこだまし",
						Language.GER => "Mogelhieb",
						Language.FRE => "Bluff",
						Language.ITA => "Bruciapelo",
						Language.SPN => "Sorpresa",
						Language.KOR => "속이기",
						Language.CHN_SIM => "击掌奇袭",
						Language.CHN_TRA => "擊掌奇襲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FAKE_TEARS:
					return lang switch {
						Language.ENG => "Fake Tears",
						Language.JPN => "うそなき",
						Language.GER => "Trugträne",
						Language.FRE => "Croco Larme",
						Language.ITA => "Falselacrime",
						Language.SPN => "Llanto Falso",
						Language.KOR => "거짓울음",
						Language.CHN_SIM => "假哭",
						Language.CHN_TRA => "假哭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FALSE_SURRENDER:
					return lang switch {
						Language.ENG => "False Surrender",
						Language.JPN => "どげざつ",
						Language.GER => "Kniefalltrick",
						Language.FRE => "Fourbette",
						Language.ITA => "Supplicolpo",
						Language.SPN => "Irreverencia",
						Language.KOR => "사죄의찌르기",
						Language.CHN_SIM => "假跪真撞",
						Language.CHN_TRA => "假跪真撞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FALSE_SWIPE:
					return lang switch {
						Language.ENG => "False Swipe",
						Language.JPN => "みねうち",
						Language.GER => "Trugschlag",
						Language.FRE => "Faux-Chage",
						Language.ITA => "Falsofinale",
						Language.SPN => "Falsotortazo",
						Language.KOR => "칼등치기",
						Language.CHN_SIM => "点到为止",
						Language.CHN_TRA => "點到為止",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FEATHER_DANCE:
					return lang switch {
						Language.ENG => "Feather Dance",
						Language.JPN => "フェザーダンス",
						Language.GER => "Daunenreigen",
						Language.FRE => "Danse-Plume",
						Language.ITA => "Danzadipiume",
						Language.SPN => "Danza Pluma",
						Language.KOR => "깃털댄스",
						Language.CHN_SIM => "羽毛舞",
						Language.CHN_TRA => "羽毛舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FEINT:
					return lang switch {
						Language.ENG => "Feint",
						Language.JPN => "フェイント",
						Language.GER => "Offenlegung",
						Language.FRE => "Ruse",
						Language.ITA => "Fintoattacco",
						Language.SPN => "Amago",
						Language.KOR => "페인트",
						Language.CHN_SIM => "佯攻",
						Language.CHN_TRA => "佯攻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FEINT_ATTACK:
					return lang switch {
						Language.ENG => "Feint Attack",
						Language.JPN => "だましうち",
						Language.GER => "Finte",
						Language.FRE => "Feinte",
						Language.ITA => "Finta",
						Language.SPN => "Finta",
						Language.KOR => "속여때리기",
						Language.CHN_SIM => "出奇一击",
						Language.CHN_TRA => "出奇一擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FELL_STINGER:
					return lang switch {
						Language.ENG => "Fell Stinger",
						Language.JPN => "とどめばり",
						Language.GER => "Stachelfinale",
						Language.FRE => "Dard Mortel",
						Language.ITA => "Pungiglione",
						Language.SPN => "Aguijón Letal",
						Language.KOR => "마지막일침",
						Language.CHN_SIM => "致命针刺",
						Language.CHN_TRA => "致命針刺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIERY_DANCE:
					return lang switch {
						Language.ENG => "Fiery Dance",
						Language.JPN => "ほのおのまい",
						Language.GER => "Feuerreigen",
						Language.FRE => "Danse du Feu",
						Language.ITA => "Voldifuoco",
						Language.SPN => "Danza Llama",
						Language.KOR => "불꽃춤",
						Language.CHN_SIM => "火之舞",
						Language.CHN_TRA => "火之舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIERY_WRATH:
					return lang switch {
						Language.ENG => "Fiery Wrath",
						Language.JPN => "もえあがるいか",
						Language.GER => "Brennender Zorn",
						Language.FRE => "Fureur Ardente",
						Language.ITA => "Furia Ardente",
						Language.SPN => "Furia Candente",
						Language.KOR => "타오르는분노",
						Language.CHN_SIM => "怒火中烧",
						Language.CHN_TRA => "怒火中燒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FILLET_AWAY:
					return lang switch {
						Language.ENG => "Fillet Away",
						Language.JPN => "みをけず",
						Language.GER => "Abspaltung",
						Language.FRE => "Décharnement",
						Language.ITA => "Alleggerimento",
						Language.SPN => "Deslome",
						Language.KOR => "제살깎기",
						Language.CHN_SIM => "甩肉",
						Language.CHN_TRA => "甩肉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FINAL_GAMBIT:
					return lang switch {
						Language.ENG => "Final Gambit",
						Language.JPN => "いのちがけ",
						Language.GER => "Wagemut",
						Language.FRE => "Tout ou Rien",
						Language.ITA => "Azzardo",
						Language.SPN => "Sacrificio",
						Language.KOR => "목숨걸기",
						Language.CHN_SIM => "搏命",
						Language.CHN_TRA => "搏命",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRE_BLAST:
					return lang switch {
						Language.ENG => "Fire Blast",
						Language.JPN => "だいもんじ",
						Language.GER => "Feuersturm",
						Language.FRE => "Déflagration",
						Language.ITA => "Fuocobomba",
						Language.SPN => "Llamarada",
						Language.KOR => "불대문자",
						Language.CHN_SIM => "大字爆炎",
						Language.CHN_TRA => "大字爆炎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRE_FANG:
					return lang switch {
						Language.ENG => "Fire Fang",
						Language.JPN => "ほのおのキバ",
						Language.GER => "Feuerzahn",
						Language.FRE => "Crocs Feu",
						Language.ITA => "Rogodenti",
						Language.SPN => "Colmillo Ígneo",
						Language.KOR => "불꽃엄니",
						Language.CHN_SIM => "火焰牙",
						Language.CHN_TRA => "火焰牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRE_LASH:
					return lang switch {
						Language.ENG => "Fire Lash",
						Language.JPN => "ほのおのムチ",
						Language.GER => "Feuerpeitsche",
						Language.FRE => "Fouet de Feu",
						Language.ITA => "Frusta di Fuoco",
						Language.SPN => "Látigo Ígneo",
						Language.KOR => "불꽃채찍",
						Language.CHN_SIM => "火焰鞭",
						Language.CHN_TRA => "火焰鞭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRE_PLEDGE:
					return lang switch {
						Language.ENG => "Fire Pledge",
						Language.JPN => "ほのおのちかい",
						Language.GER => "Feuersäulen",
						Language.FRE => "Aire de Feu",
						Language.ITA => "Fiammapatto",
						Language.SPN => "Voto Fuego",
						Language.KOR => "불꽃의맹세",
						Language.CHN_SIM => "火之誓约",
						Language.CHN_TRA => "火之誓約",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRE_PUNCH:
					return lang switch {
						Language.ENG => "Fire Punch",
						Language.JPN => "ほのおのパンチ",
						Language.GER => "Feuerschlag",
						Language.FRE => "Poing de Feu",
						Language.ITA => "Fuocopugno",
						Language.SPN => "Puño Fuego",
						Language.KOR => "불꽃펀치",
						Language.CHN_SIM => "火焰拳",
						Language.CHN_TRA => "火焰拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRE_SPIN:
					return lang switch {
						Language.ENG => "Fire Spin",
						Language.JPN => "ほのおのうず",
						Language.GER => "Feuerwirbel",
						Language.FRE => "Danse Flamme",
						Language.ITA => "Turbofuoco",
						Language.SPN => "Giro Fuego",
						Language.KOR => "회오리불꽃",
						Language.CHN_SIM => "火焰旋涡",
						Language.CHN_TRA => "火焰旋渦",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FIRST_IMPRESSION:
					return lang switch {
						Language.ENG => "First Impression",
						Language.JPN => "であいがしら",
						Language.GER => "Überrumpler",
						Language.FRE => "Escarmouche",
						Language.ITA => "Schermaglia",
						Language.SPN => "Escaramuza",
						Language.KOR => "만나자마자",
						Language.CHN_SIM => "迎头一击",
						Language.CHN_TRA => "迎頭一擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FISHIOUS_REND:
					return lang switch {
						Language.ENG => "Fishious Rend",
						Language.JPN => "エラが",
						Language.GER => "Kiemenbiss",
						Language.FRE => "Branchicrok",
						Language.ITA => "Branchiomorso",
						Language.SPN => "Branquibocado",
						Language.KOR => "아가미물기",
						Language.CHN_SIM => "鳃咬",
						Language.CHN_TRA => "鰓咬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FISSURE:
					return lang switch {
						Language.ENG => "Fissure",
						Language.JPN => "じわれ",
						Language.GER => "Geofissur",
						Language.FRE => "Abîme",
						Language.ITA => "Abisso",
						Language.SPN => "Fisura",
						Language.KOR => "땅가르기",
						Language.CHN_SIM => "地裂",
						Language.CHN_TRA => "地裂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLAIL:
					return lang switch {
						Language.ENG => "Flail",
						Language.JPN => "じたばた",
						Language.GER => "Dreschflegel",
						Language.FRE => "Fléau",
						Language.ITA => "Flagello",
						Language.SPN => "Azote",
						Language.KOR => "바둥바둥",
						Language.CHN_SIM => "抓狂",
						Language.CHN_TRA => "抓狂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLAME_BURST:
					return lang switch {
						Language.ENG => "Flame Burst",
						Language.JPN => "はじけるほのお",
						Language.GER => "Funkenflug",
						Language.FRE => "Rebondifeu",
						Language.ITA => "Pirolancio",
						Language.SPN => "Pirotecnia",
						Language.KOR => "불꽃튀기기",
						Language.CHN_SIM => "烈焰溅射",
						Language.CHN_TRA => "烈焰濺射",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLAME_CHARGE:
					return lang switch {
						Language.ENG => "Flame Charge",
						Language.JPN => "ニトロチャージ",
						Language.GER => "Nitroladung",
						Language.FRE => "Nitrocharge",
						Language.ITA => "Nitrocarica",
						Language.SPN => "Nitrocarga",
						Language.KOR => "니트로차지",
						Language.CHN_SIM => "蓄能焰袭",
						Language.CHN_TRA => "蓄能焰襲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLAME_WHEEL:
					return lang switch {
						Language.ENG => "Flame Wheel",
						Language.JPN => "かえんぐるま",
						Language.GER => "Flammenrad",
						Language.FRE => "Roue de Feu",
						Language.ITA => "Ruotafuoco",
						Language.SPN => "Rueda Fuego",
						Language.KOR => "화염바퀴",
						Language.CHN_SIM => "火焰轮",
						Language.CHN_TRA => "火焰輪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLAMETHROWER:
					return lang switch {
						Language.ENG => "Flamethrower",
						Language.JPN => "かえんほうしゃ",
						Language.GER => "Flammenwurf",
						Language.FRE => "Lance-Flammes",
						Language.ITA => "Lanciafiamme",
						Language.SPN => "Lanzallamas",
						Language.KOR => "화염방사",
						Language.CHN_SIM => "喷射火焰",
						Language.CHN_TRA => "噴射火焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLARE_BLITZ:
					return lang switch {
						Language.ENG => "Flare Blitz",
						Language.JPN => "フレアドライブ",
						Language.GER => "Flammenblitz",
						Language.FRE => "Boutefeu",
						Language.ITA => "Fuococarica",
						Language.SPN => "Envite Ígneo",
						Language.KOR => "플레어드라이브",
						Language.CHN_SIM => "闪焰冲锋",
						Language.CHN_TRA => "閃焰衝鋒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLASH:
					return lang switch {
						Language.ENG => "Flash",
						Language.JPN => "フラッシュ",
						Language.GER => "Blitz",
						Language.FRE => "Flash",
						Language.ITA => "Flash",
						Language.SPN => "Destello",
						Language.KOR => "플래시",
						Language.CHN_SIM => "闪光",
						Language.CHN_TRA => "閃光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLASH_CANNON:
					return lang switch {
						Language.ENG => "Flash Cannon",
						Language.JPN => "ラスターカノン",
						Language.GER => "Lichtkanone",
						Language.FRE => "Luminocanon",
						Language.ITA => "Cannonflash",
						Language.SPN => "Foco Resplandor",
						Language.KOR => "러스터캐논",
						Language.CHN_SIM => "加农光炮",
						Language.CHN_TRA => "加農光炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLATTER:
					return lang switch {
						Language.ENG => "Flatter",
						Language.JPN => "おだてる",
						Language.GER => "Schmeichler",
						Language.FRE => "Flatterie",
						Language.ITA => "Adulazione",
						Language.SPN => "Camelo",
						Language.KOR => "부추기기",
						Language.CHN_SIM => "吹捧",
						Language.CHN_TRA => "吹捧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLEUR_CANNON:
					return lang switch {
						Language.ENG => "Fleur Cannon",
						Language.JPN => "フルールカノン",
						Language.GER => "Kanonenbouquet",
						Language.FRE => "Canon Floral",
						Language.ITA => "Cannonfiore",
						Language.SPN => "Cañón Floral",
						Language.KOR => "플뢰르캐논",
						Language.CHN_SIM => "花朵加农炮",
						Language.CHN_TRA => "花朵加農炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLING:
					return lang switch {
						Language.ENG => "Fling",
						Language.JPN => "なげつける",
						Language.GER => "Schleuder",
						Language.FRE => "Dégommage",
						Language.ITA => "Lancio",
						Language.SPN => "Lanzamiento",
						Language.KOR => "내던지기",
						Language.CHN_SIM => "投掷",
						Language.CHN_TRA => "投擲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLIP_TURN:
					return lang switch {
						Language.ENG => "Flip Turn",
						Language.JPN => "クイックター",
						Language.GER => "Rollwende",
						Language.FRE => "Eau Revoir",
						Language.ITA => "Virata",
						Language.SPN => "Viraje",
						Language.KOR => "퀵턴",
						Language.CHN_SIM => "快速折返",
						Language.CHN_TRA => "快速折返",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLORAL_HEALING:
					return lang switch {
						Language.ENG => "Floral Healing",
						Language.JPN => "フラワーヒール",
						Language.GER => "Florakur",
						Language.FRE => "Soin Floral",
						Language.ITA => "Cura Floreale",
						Language.SPN => "Cura Floral",
						Language.KOR => "플라워힐",
						Language.CHN_SIM => "花疗",
						Language.CHN_TRA => "花療",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLOWER_SHIELD:
					return lang switch {
						Language.ENG => "Flower Shield",
						Language.JPN => "フラワーガード",
						Language.GER => "Floraschutz",
						Language.FRE => "Garde Florale",
						Language.ITA => "Fiordifesa",
						Language.SPN => "Defensa Floral",
						Language.KOR => "플라워가드",
						Language.CHN_SIM => "鲜花防守",
						Language.CHN_TRA => "鮮花防守",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLOWER_TRICK:
					return lang switch {
						Language.ENG => "Flower Trick",
						Language.JPN => "トリックフラワ",
						Language.GER => "Blumentrick",
						Language.FRE => "Magie Florale",
						Language.ITA => "Prestigiafiore",
						Language.SPN => "Truco Floral",
						Language.KOR => "트릭플라워",
						Language.CHN_SIM => "千变万花",
						Language.CHN_TRA => "千變萬花",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLY:
					return lang switch {
						Language.ENG => "Fly",
						Language.JPN => "そらをとぶ",
						Language.GER => "Fliegen",
						Language.FRE => "Vol",
						Language.ITA => "Volo",
						Language.SPN => "Vuelo",
						Language.KOR => "공중날기",
						Language.CHN_SIM => "飞翔",
						Language.CHN_TRA => "飛翔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FLYING_PRESS:
					return lang switch {
						Language.ENG => "Flying Press",
						Language.JPN => "フライングプレス",
						Language.GER => "Flying Press",
						Language.FRE => "Flying Press",
						Language.ITA => "Schiacciatuffo",
						Language.SPN => "Plancha Voladora",
						Language.KOR => "플라잉프레스",
						Language.CHN_SIM => "飞身重压",
						Language.CHN_TRA => "飛身重壓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FOCUS_BLAST:
					return lang switch {
						Language.ENG => "Focus Blast",
						Language.JPN => "きあいだま",
						Language.GER => "Fokusstoß",
						Language.FRE => "Exploforce",
						Language.ITA => "Focalcolpo",
						Language.SPN => "Onda Certera",
						Language.KOR => "기합구슬",
						Language.CHN_SIM => "真气弹",
						Language.CHN_TRA => "真氣彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FOCUS_ENERGY:
					return lang switch {
						Language.ENG => "Focus Energy",
						Language.JPN => "きあいだめ",
						Language.GER => "Energiefokus",
						Language.FRE => "Puissance",
						Language.ITA => "Focalenergia",
						Language.SPN => "Foco Energía",
						Language.KOR => "기충전",
						Language.CHN_SIM => "聚气",
						Language.CHN_TRA => "聚氣",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FOCUS_PUNCH:
					return lang switch {
						Language.ENG => "Focus Punch",
						Language.JPN => "きあいパンチ",
						Language.GER => "Power-Punch",
						Language.FRE => "Mitra-Poing",
						Language.ITA => "Centripugno",
						Language.SPN => "Puño Certero",
						Language.KOR => "힘껏펀치",
						Language.CHN_SIM => "真气拳",
						Language.CHN_TRA => "真氣拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FOLLOW_ME:
					return lang switch {
						Language.ENG => "Follow Me",
						Language.JPN => "このゆびとまれ",
						Language.GER => "Spotlight",
						Language.FRE => "Par Ici",
						Language.ITA => "Sonoqui",
						Language.SPN => "Señuelo",
						Language.KOR => "날따름",
						Language.CHN_SIM => "看我嘛",
						Language.CHN_TRA => "看我嘛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FORCE_PALM:
					return lang switch {
						Language.ENG => "Force Palm",
						Language.JPN => "はっけい",
						Language.GER => "Kraftwelle",
						Language.FRE => "Forte-Paume",
						Language.ITA => "Palmoforza",
						Language.SPN => "Palmeo",
						Language.KOR => "발경",
						Language.CHN_SIM => "发劲",
						Language.CHN_TRA => "發勁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FORESIGHT:
					return lang switch {
						Language.ENG => "Foresight",
						Language.JPN => "みやぶる",
						Language.GER => "Gesichte",
						Language.FRE => "Clairvoyance",
						Language.ITA => "Preveggenza",
						Language.SPN => "Profecía",
						Language.KOR => "꿰뚫어보기",
						Language.CHN_SIM => "识破",
						Language.CHN_TRA => "識破",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FOREST_S_CURSE:
					return lang switch {
						Language.ENG => "Forest's Curse",
						Language.JPN => "もりののろい",
						Language.GER => "Waldesfluch",
						Language.FRE => "Maléfice Sylvain",
						Language.ITA => "Schiacciatuffo",
						Language.SPN => "Condena Silvana",
						Language.KOR => "숲의저주",
						Language.CHN_SIM => "森林咒术",
						Language.CHN_TRA => "森林詛咒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FOUL_PLAY:
					return lang switch {
						Language.ENG => "Foul Play",
						Language.JPN => "イカサマ",
						Language.GER => "Schmarotzer",
						Language.FRE => "Tricherie",
						Language.ITA => "Ripicca",
						Language.SPN => "Juego Sucio",
						Language.KOR => "속임수",
						Language.CHN_SIM => "移花接木",
						Language.CHN_TRA => "欺詐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FREEZE_SHOCK:
					return lang switch {
						Language.ENG => "Freeze Shock",
						Language.JPN => "フリーズボルト",
						Language.GER => "Frostvolt",
						Language.FRE => "Éclair Gelé",
						Language.ITA => "Elettrogelo",
						Language.SPN => "Rayo Gélido",
						Language.KOR => "프리즈볼트",
						Language.CHN_SIM => "冰冻伏特",
						Language.CHN_TRA => "冰凍伏特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FREEZE_DRY:
					return lang switch {
						Language.ENG => "Freeze-Dry",
						Language.JPN => "フリーズドライ",
						Language.GER => "Gefriertrockner",
						Language.FRE => "Lyophilisation",
						Language.ITA => "Liofilizzazione",
						Language.SPN => "Liofilización",
						Language.KOR => "프리즈드라이",
						Language.CHN_SIM => "冷冻干燥",
						Language.CHN_TRA => "冷凍乾燥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FREEZING_GLARE:
					return lang switch {
						Language.ENG => "Freezing Glare",
						Language.JPN => "いてつくしせ",
						Language.GER => "Eisiger Blick",
						Language.FRE => "Regard Glaçant",
						Language.ITA => "Sguardo Gelido",
						Language.SPN => "Mirada Heladora",
						Language.KOR => "얼어붙는시선",
						Language.CHN_SIM => "冰冷视线",
						Language.CHN_TRA => "冰冷視線",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FRENZY_PLANT:
					return lang switch {
						Language.ENG => "Frenzy Plant",
						Language.JPN => "ハードプラント",
						Language.GER => "Flora-Statue",
						Language.FRE => "Végé-Attak",
						Language.ITA => "Radicalbero",
						Language.SPN => "Planta Feroz",
						Language.KOR => "하드플랜트",
						Language.CHN_SIM => "疯狂植物",
						Language.CHN_TRA => "瘋狂植物",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FROST_BREATH:
					return lang switch {
						Language.ENG => "Frost Breath",
						Language.JPN => "こおりのいぶき",
						Language.GER => "Eisesodem",
						Language.FRE => "Souffle Glacé",
						Language.ITA => "Alitogelido",
						Language.SPN => "Vaho Gélido",
						Language.KOR => "얼음숨결",
						Language.CHN_SIM => "冰息",
						Language.CHN_TRA => "冰息",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FRUSTRATION:
					return lang switch {
						Language.ENG => "Frustration",
						Language.JPN => "やつあたり",
						Language.GER => "Frustration",
						Language.FRE => "Frustration",
						Language.ITA => "Frustrazione",
						Language.SPN => "Frustración",
						Language.KOR => "화풀이",
						Language.CHN_SIM => "迁怒",
						Language.CHN_TRA => "遷怒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FURY_ATTACK:
					return lang switch {
						Language.ENG => "Fury Attack",
						Language.JPN => "みだれづき",
						Language.GER => "Furienschlag",
						Language.FRE => "Furie",
						Language.ITA => "Furia",
						Language.SPN => "Ataque Furia",
						Language.KOR => "마구찌르기",
						Language.CHN_SIM => "乱击",
						Language.CHN_TRA => "亂擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FURY_CUTTER:
					return lang switch {
						Language.ENG => "Fury Cutter",
						Language.JPN => "れんぞくぎり",
						Language.GER => "Zornklinge",
						Language.FRE => "Taillade",
						Language.ITA => "Tagliofuria",
						Language.SPN => "Cortefuria",
						Language.KOR => "연속자르기",
						Language.CHN_SIM => "连斩",
						Language.CHN_TRA => "連斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FURY_SWIPES:
					return lang switch {
						Language.ENG => "Fury Swipes",
						Language.JPN => "みだれひっかき",
						Language.GER => "Kratzfurie",
						Language.FRE => "Combo-Griffe",
						Language.ITA => "Sfuriate",
						Language.SPN => "Golpes Furia",
						Language.KOR => "마구할퀴기",
						Language.CHN_SIM => "乱抓",
						Language.CHN_TRA => "亂抓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FUSION_BOLT:
					return lang switch {
						Language.ENG => "Fusion Bolt",
						Language.JPN => "クロスサンダー",
						Language.GER => "Kreuzdonner",
						Language.FRE => "Éclair Croix",
						Language.ITA => "Incrotuono",
						Language.SPN => "Rayo Fusión",
						Language.KOR => "크로스썬더",
						Language.CHN_SIM => "交错闪电",
						Language.CHN_TRA => "交錯閃電",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FUSION_FLARE:
					return lang switch {
						Language.ENG => "Fusion Flare",
						Language.JPN => "クロスフレイム",
						Language.GER => "Kreuzflamme",
						Language.FRE => "Flamme Croix",
						Language.ITA => "Incrofiamma",
						Language.SPN => "Llama Fusión",
						Language.KOR => "크로스플레임",
						Language.CHN_SIM => "交错火焰",
						Language.CHN_TRA => "交錯火焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.FUTURE_SIGHT:
					return lang switch {
						Language.ENG => "Future Sight",
						Language.JPN => "みらいよち",
						Language.GER => "Seher",
						Language.FRE => "Prescience",
						Language.ITA => "Divinazione",
						Language.SPN => "Premonición",
						Language.KOR => "미래예지",
						Language.CHN_SIM => "预知未来",
						Language.CHN_TRA => "預知未來",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GASTRO_ACID:
					return lang switch {
						Language.ENG => "Gastro Acid",
						Language.JPN => "いえき",
						Language.GER => "Magensäfte",
						Language.FRE => "Suc Digestif",
						Language.ITA => "Gastroacido",
						Language.SPN => "Bilis",
						Language.KOR => "위액",
						Language.CHN_SIM => "胃液",
						Language.CHN_TRA => "胃液",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GEAR_GRIND:
					return lang switch {
						Language.ENG => "Gear Grind",
						Language.JPN => "ギアソーサー",
						Language.GER => "Klikkdiskus",
						Language.FRE => "Lancécrou",
						Language.ITA => "Ingracolpo",
						Language.SPN => "Rueda Doble",
						Language.KOR => "기어소서",
						Language.CHN_SIM => "齿轮飞盘",
						Language.CHN_TRA => "齒輪飛盤",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GEAR_UP:
					return lang switch {
						Language.ENG => "Gear Up",
						Language.JPN => "アシストギア",
						Language.GER => "Hilfsmechanik",
						Language.FRE => "Engrenage",
						Language.ITA => "Marciainpiù",
						Language.SPN => "Piñón Auxiliar",
						Language.KOR => "어시스트기어",
						Language.CHN_SIM => "辅助齿轮",
						Language.CHN_TRA => "輔助齒輪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GEOMANCY:
					return lang switch {
						Language.ENG => "Geomancy",
						Language.JPN => "ジオコントロール",
						Language.GER => "Geokontrolle",
						Language.FRE => "Géo-Contrôle",
						Language.ITA => "Geocontrollo",
						Language.SPN => "Geocontrol",
						Language.KOR => "지오컨트롤",
						Language.CHN_SIM => "大地掌控",
						Language.CHN_TRA => "大地掌控",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GIGA_DRAIN:
					return lang switch {
						Language.ENG => "Giga Drain",
						Language.JPN => "ギガドレイン",
						Language.GER => "Gigasauger",
						Language.FRE => "Giga-Sangsue",
						Language.ITA => "Gigassorbimento",
						Language.SPN => "Gigadrenado",
						Language.KOR => "기가드레인",
						Language.CHN_SIM => "终极吸取",
						Language.CHN_TRA => "終極吸取",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GIGA_IMPACT:
					return lang switch {
						Language.ENG => "Giga Impact",
						Language.JPN => "ギガインパクト",
						Language.GER => "Gigastoß",
						Language.FRE => "Giga Impact",
						Language.ITA => "Gigaimpatto",
						Language.SPN => "Giga Impacto",
						Language.KOR => "기가임팩트",
						Language.CHN_SIM => "终极冲击",
						Language.CHN_TRA => "終極衝擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GIGATON_HAMMER:
					return lang switch {
						Language.ENG => "Gigaton Hammer",
						Language.JPN => "デカハンマ",
						Language.GER => "Riesenhammer",
						Language.FRE => "Marteau Mastoc",
						Language.ITA => "Granmartello",
						Language.SPN => "Martillo Colosal",
						Language.KOR => "거대해머",
						Language.CHN_SIM => "巨力锤",
						Language.CHN_TRA => "巨力錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GLACIAL_LANCE:
					return lang switch {
						Language.ENG => "Glacial Lance",
						Language.JPN => "ブリザードラン",
						Language.GER => "Blizzardlanze",
						Language.FRE => "Lance de Glace",
						Language.ITA => "Lancia Glaciale",
						Language.SPN => "Lanza Glacial",
						Language.KOR => "블리자드랜스",
						Language.CHN_SIM => "雪矛",
						Language.CHN_TRA => "雪矛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GLACIATE:
					return lang switch {
						Language.ENG => "Glaciate",
						Language.JPN => "こごえるせかい",
						Language.GER => "Eiszeit",
						Language.FRE => "Ère Glaciaire",
						Language.ITA => "Gelamondo",
						Language.SPN => "Mundo Gélido",
						Language.KOR => "얼어붙은세계",
						Language.CHN_SIM => "冰封世界",
						Language.CHN_TRA => "冰封世界",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GLAIVE_RUSH:
					return lang switch {
						Language.ENG => "Glaive Rush",
						Language.JPN => "きょけんとつげ",
						Language.GER => "Großklingenstoß",
						Language.FRE => "Charge Glaive",
						Language.ITA => "Spadoncarica",
						Language.SPN => "Asalto Espadón",
						Language.KOR => "대검돌격",
						Language.CHN_SIM => "巨剑突击",
						Language.CHN_TRA => "巨劍突擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GLARE:
					return lang switch {
						Language.ENG => "Glare",
						Language.JPN => "へびにらみ",
						Language.GER => "Giftblick",
						Language.FRE => "Regard Médusant",
						Language.ITA => "Sguardo Feroce",
						Language.SPN => "Deslumbrar",
						Language.KOR => "뱀눈초리",
						Language.CHN_SIM => "大蛇瞪眼",
						Language.CHN_TRA => "大蛇瞪眼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRASS_KNOT:
					return lang switch {
						Language.ENG => "Grass Knot",
						Language.JPN => "くさむすび",
						Language.GER => "Strauchler",
						Language.FRE => "Nœud Herbe",
						Language.ITA => "Laccioerboso",
						Language.SPN => "Hierba Lazo",
						Language.KOR => "풀묶기",
						Language.CHN_SIM => "打草结",
						Language.CHN_TRA => "打草結",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRASS_PLEDGE:
					return lang switch {
						Language.ENG => "Grass Pledge",
						Language.JPN => "くさのちかい",
						Language.GER => "Pflanzensäulen",
						Language.FRE => "Aire de Plante",
						Language.ITA => "Erbapatto",
						Language.SPN => "Voto Planta",
						Language.KOR => "풀의맹세",
						Language.CHN_SIM => "草之誓约",
						Language.CHN_TRA => "草之誓約",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRASS_WHISTLE:
					return lang switch {
						Language.ENG => "Grass Whistle",
						Language.JPN => "くさぶえ",
						Language.GER => "Grasflöte",
						Language.FRE => "Siffl'Herbe",
						Language.ITA => "Meloderba",
						Language.SPN => "Silbato",
						Language.KOR => "풀피리",
						Language.CHN_SIM => "草笛",
						Language.CHN_TRA => "草笛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRASSY_TERRAIN:
					return lang switch {
						Language.ENG => "Grassy Terrain",
						Language.JPN => "グラスフィールド",
						Language.GER => "Grasfeld",
						Language.FRE => "Champ Herbu",
						Language.ITA => "Campo Erboso",
						Language.SPN => "Campo de Hierba",
						Language.KOR => "그래스필드",
						Language.CHN_SIM => "青草场地",
						Language.CHN_TRA => "青草場地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRAV_APPLE:
					return lang switch {
						Language.ENG => "Grav Apple",
						Language.JPN => "Ｇのちか",
						Language.GER => "Gravitation",
						Language.FRE => "Force G",
						Language.ITA => "Forza G",
						Language.SPN => "Fuerza G",
						Language.KOR => "G의힘",
						Language.CHN_SIM => "万有引力",
						Language.CHN_TRA => "萬有引力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRAVITY:
					return lang switch {
						Language.ENG => "Gravity",
						Language.JPN => "じゅうりょく",
						Language.GER => "Erdanziehung",
						Language.FRE => "Gravité",
						Language.ITA => "Gravità",
						Language.SPN => "Gravedad",
						Language.KOR => "중력",
						Language.CHN_SIM => "重力",
						Language.CHN_TRA => "重力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GROWL:
					return lang switch {
						Language.ENG => "Growl",
						Language.JPN => "なきごえ",
						Language.GER => "Heuler",
						Language.FRE => "Rugissement",
						Language.ITA => "Ruggito",
						Language.SPN => "Gruñido",
						Language.KOR => "울음소리",
						Language.CHN_SIM => "叫声",
						Language.CHN_TRA => "叫聲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GROWTH:
					return lang switch {
						Language.ENG => "Growth",
						Language.JPN => "せいちょう",
						Language.GER => "Wachstum",
						Language.FRE => "Croissance",
						Language.ITA => "Crescita",
						Language.SPN => "Desarrollo",
						Language.KOR => "성장",
						Language.CHN_SIM => "生长",
						Language.CHN_TRA => "生長",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GRUDGE:
					return lang switch {
						Language.ENG => "Grudge",
						Language.JPN => "おんねん",
						Language.GER => "Nachspiel",
						Language.FRE => "Rancune",
						Language.ITA => "Rancore",
						Language.SPN => "Rabia",
						Language.KOR => "원념",
						Language.CHN_SIM => "怨念",
						Language.CHN_TRA => "怨念",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GUARD_SPLIT:
					return lang switch {
						Language.ENG => "Guard Split",
						Language.JPN => "ガードシェア",
						Language.GER => "Schutzteiler",
						Language.FRE => "Partage Garde",
						Language.ITA => "Paridifesa",
						Language.SPN => "Isoguardia",
						Language.KOR => "가드셰어",
						Language.CHN_SIM => "防守平分",
						Language.CHN_TRA => "防守平分",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GUARD_SWAP:
					return lang switch {
						Language.ENG => "Guard Swap",
						Language.JPN => "ガードスワップ",
						Language.GER => "Schutztausch",
						Language.FRE => "Permugarde",
						Language.ITA => "Barattoscudo",
						Language.SPN => "Cambia Defensa",
						Language.KOR => "가드스왑",
						Language.CHN_SIM => "防守互换",
						Language.CHN_TRA => "防守互換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GUILLOTINE:
					return lang switch {
						Language.ENG => "Guillotine",
						Language.JPN => "ハサミギロチン",
						Language.GER => "Guillotine",
						Language.FRE => "Guillotine",
						Language.ITA => "Ghigliottina",
						Language.SPN => "Guillotina",
						Language.KOR => "가위자르기",
						Language.CHN_SIM => "极落钳",
						Language.CHN_TRA => "斷頭鉗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GUNK_SHOT:
					return lang switch {
						Language.ENG => "Gunk Shot",
						Language.JPN => "ダストシュート",
						Language.GER => "Mülltreffer",
						Language.FRE => "Détricanon",
						Language.ITA => "Sporcolancio",
						Language.SPN => "Lanza Mugre",
						Language.KOR => "더스트슈트",
						Language.CHN_SIM => "垃圾射击",
						Language.CHN_TRA => "垃圾射擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GUST:
					return lang switch {
						Language.ENG => "Gust",
						Language.JPN => "かぜおこし",
						Language.GER => "Windstoß",
						Language.FRE => "Tornade",
						Language.ITA => "Raffica",
						Language.SPN => "Tornado",
						Language.KOR => "바람일으키기",
						Language.CHN_SIM => "起风",
						Language.CHN_TRA => "起風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.GYRO_BALL:
					return lang switch {
						Language.ENG => "Gyro Ball",
						Language.JPN => "ジャイロボール",
						Language.GER => "Gyroball",
						Language.FRE => "Gyroballe",
						Language.ITA => "Vortexpalla",
						Language.SPN => "Giro Bola",
						Language.KOR => "자이로볼",
						Language.CHN_SIM => "陀螺球",
						Language.CHN_TRA => "陀螺球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HAIL:
					return lang switch {
						Language.ENG => "Hail",
						Language.JPN => "あられ",
						Language.GER => "Hagelsturm",
						Language.FRE => "Grêle",
						Language.ITA => "Grandine",
						Language.SPN => "Granizo",
						Language.KOR => "싸라기눈",
						Language.CHN_SIM => "冰雹",
						Language.CHN_TRA => "冰雹",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HAMMER_ARM:
					return lang switch {
						Language.ENG => "Hammer Arm",
						Language.JPN => "アームハンマー",
						Language.GER => "Hammerarm",
						Language.FRE => "Marto-Poing",
						Language.ITA => "Martelpugno",
						Language.SPN => "Machada",
						Language.KOR => "암해머",
						Language.CHN_SIM => "臂锤",
						Language.CHN_TRA => "臂錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HAPPY_HOUR:
					return lang switch {
						Language.ENG => "Happy Hour",
						Language.JPN => "ハッピータイム",
						Language.GER => "Goldene Zeiten",
						Language.FRE => "Étrennes",
						Language.ITA => "Cuccagna",
						Language.SPN => "Paga Extra",
						Language.KOR => "해피타임",
						Language.CHN_SIM => "欢乐时光",
						Language.CHN_TRA => "歡樂時光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HARDEN:
					return lang switch {
						Language.ENG => "Harden",
						Language.JPN => "かたくなる",
						Language.GER => "Härtner",
						Language.FRE => "Armure",
						Language.ITA => "Rafforzatore",
						Language.SPN => "Fortaleza",
						Language.KOR => "단단해지기",
						Language.CHN_SIM => "变硬",
						Language.CHN_TRA => "變硬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HAZE:
					return lang switch {
						Language.ENG => "Haze",
						Language.JPN => "くろいきり",
						Language.GER => "Dunkelnebel",
						Language.FRE => "Buée Noire",
						Language.ITA => "Nube",
						Language.SPN => "Niebla",
						Language.KOR => "흑안개",
						Language.CHN_SIM => "黑雾",
						Language.CHN_TRA => "黑霧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAD_CHARGE:
					return lang switch {
						Language.ENG => "Head Charge",
						Language.JPN => "アフロブレイク",
						Language.GER => "Steinschädel",
						Language.FRE => "Peignée",
						Language.ITA => "Ricciolata",
						Language.SPN => "Ariete",
						Language.KOR => "아프로브레이크",
						Language.CHN_SIM => "爆炸头突击",
						Language.CHN_TRA => "爆炸頭突擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAD_SMASH:
					return lang switch {
						Language.ENG => "Head Smash",
						Language.JPN => "もろはのずつき",
						Language.GER => "Kopfstoß",
						Language.FRE => "Fracass'Tête",
						Language.ITA => "Zuccata",
						Language.SPN => "Testarazo",
						Language.KOR => "양날박치기",
						Language.CHN_SIM => "双刃头锤",
						Language.CHN_TRA => "雙刃頭錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEADBUTT:
					return lang switch {
						Language.ENG => "Headbutt",
						Language.JPN => "ずつき",
						Language.GER => "Kopfnuss",
						Language.FRE => "Coup d'Boule",
						Language.ITA => "Bottintesta",
						Language.SPN => "Golpe Cabeza",
						Language.KOR => "박치기",
						Language.CHN_SIM => "头锤",
						Language.CHN_TRA => "頭錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEADLONG_RUSH:
					return lang switch {
						Language.ENG => "Headlong Rush",
						Language.JPN => "ぶちかま",
						Language.GER => "Schmetterramme",
						Language.FRE => "Assaut Frontal",
						Language.ITA => "Scontro Frontale",
						Language.SPN => "Arremetida",
						Language.KOR => "들이받기",
						Language.CHN_SIM => "突飞猛扑",
						Language.CHN_TRA => "突飛猛撲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAL_BELL:
					return lang switch {
						Language.ENG => "Heal Bell",
						Language.JPN => "いやしのすず",
						Language.GER => "Vitalglocke",
						Language.FRE => "Glas de Soin",
						Language.ITA => "Rintoccasana",
						Language.SPN => "Campana Cura",
						Language.KOR => "치료방울",
						Language.CHN_SIM => "治愈铃声",
						Language.CHN_TRA => "治癒鈴聲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAL_BLOCK:
					return lang switch {
						Language.ENG => "Heal Block",
						Language.JPN => "かいふくふうじ",
						Language.GER => "Heilblockade",
						Language.FRE => "Anti-Soin",
						Language.ITA => "Anticura",
						Language.SPN => "Anticura",
						Language.KOR => "회복봉인",
						Language.CHN_SIM => "回复封锁",
						Language.CHN_TRA => "回復封鎖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAL_ORDER:
					return lang switch {
						Language.ENG => "Heal Order",
						Language.JPN => "かいふくしれい",
						Language.GER => "Heilbefehl",
						Language.FRE => "Appel Soins",
						Language.ITA => "Comandocura",
						Language.SPN => "Auxilio",
						Language.KOR => "회복지령",
						Language.CHN_SIM => "回复指令",
						Language.CHN_TRA => "回復指令",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAL_PULSE:
					return lang switch {
						Language.ENG => "Heal Pulse",
						Language.JPN => "いやしのはどう",
						Language.GER => "Heilwoge",
						Language.FRE => "Vibra Soin",
						Language.ITA => "Ondasana",
						Language.SPN => "Pulso Cura",
						Language.KOR => "치유파동",
						Language.CHN_SIM => "治愈波动",
						Language.CHN_TRA => "治癒波動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEALING_WISH:
					return lang switch {
						Language.ENG => "Healing Wish",
						Language.JPN => "いやしのねがい",
						Language.GER => "Heilopfer",
						Language.FRE => "Vœu Soin",
						Language.ITA => "Curardore",
						Language.SPN => "Deseo Cura",
						Language.KOR => "치유소원",
						Language.CHN_SIM => "治愈之愿",
						Language.CHN_TRA => "治癒之願",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEART_STAMP:
					return lang switch {
						Language.ENG => "Heart Stamp",
						Language.JPN => "ハートスタンプ",
						Language.GER => "Herzstempel",
						Language.FRE => "Crèvecœur",
						Language.ITA => "Cuorestampo",
						Language.SPN => "Arrumaco",
						Language.KOR => "하트스탬프",
						Language.CHN_SIM => "爱心印章",
						Language.CHN_TRA => "愛心印章",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEART_SWAP:
					return lang switch {
						Language.ENG => "Heart Swap",
						Language.JPN => "ハートスワップ",
						Language.GER => "Statustausch",
						Language.FRE => "Permucœur",
						Language.ITA => "Cuorbaratto",
						Language.SPN => "Cambia Almas",
						Language.KOR => "하트스왑",
						Language.CHN_SIM => "心灵互换",
						Language.CHN_TRA => "心靈互換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAT_CRASH:
					return lang switch {
						Language.ENG => "Heat Crash",
						Language.JPN => "ヒートスタンプ",
						Language.GER => "Brandstempel",
						Language.FRE => "Tacle Feu",
						Language.ITA => "Marchiafuoco",
						Language.SPN => "Golpe Calor",
						Language.KOR => "히트스탬프",
						Language.CHN_SIM => "高温重压",
						Language.CHN_TRA => "高溫重壓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAT_WAVE:
					return lang switch {
						Language.ENG => "Heat Wave",
						Language.JPN => "ねっぷう",
						Language.GER => "Hitzewelle",
						Language.FRE => "Canicule",
						Language.ITA => "Ondacalda",
						Language.SPN => "Onda Ígnea",
						Language.KOR => "열풍",
						Language.CHN_SIM => "热风",
						Language.CHN_TRA => "熱風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEAVY_SLAM:
					return lang switch {
						Language.ENG => "Heavy Slam",
						Language.JPN => "ヘビーボンバー",
						Language.GER => "Rammboss",
						Language.FRE => "Tacle Lourd",
						Language.ITA => "Pesobomba",
						Language.SPN => "Cuerpo Pesado",
						Language.KOR => "헤비봄버",
						Language.CHN_SIM => "重磅冲撞",
						Language.CHN_TRA => "重磅衝撞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HELPING_HAND:
					return lang switch {
						Language.ENG => "Helping Hand",
						Language.JPN => "てだすけ",
						Language.GER => "Rechte Hand",
						Language.FRE => "Coup d'Main",
						Language.ITA => "Altruismo",
						Language.SPN => "Refuerzo",
						Language.KOR => "도우미",
						Language.CHN_SIM => "帮助",
						Language.CHN_TRA => "幫助",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HEX:
					return lang switch {
						Language.ENG => "Hex",
						Language.JPN => "たたりめ",
						Language.GER => "Bürde",
						Language.FRE => "Châtiment",
						Language.ITA => "Sciagura",
						Language.SPN => "Infortunio",
						Language.KOR => "병상첨병",
						Language.CHN_SIM => "祸不单行",
						Language.CHN_TRA => "禍不單行",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HIDDEN_POWER:
					return lang switch {
						Language.ENG => "Hidden Power",
						Language.JPN => "めざめるパワー",
						Language.GER => "Kraftreserve",
						Language.FRE => "Puissance Cachée",
						Language.ITA => "Introforza",
						Language.SPN => "Poder Oculto",
						Language.KOR => "잠재파워",
						Language.CHN_SIM => "觉醒力量",
						Language.CHN_TRA => "覺醒力量",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HIGH_HORSEPOWER:
					return lang switch {
						Language.ENG => "High Horsepower",
						Language.JPN => "１０まんばりき",
						Language.GER => "Pferdestärke",
						Language.FRE => "Cavalerie Lourde",
						Language.ITA => "Forza Equina",
						Language.SPN => "Fuerza Equina",
						Language.KOR => "10만마력",
						Language.CHN_SIM => "十万马力",
						Language.CHN_TRA => "十萬馬力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HIGH_JUMP_KICK:
					return lang switch {
						Language.ENG => "High Jump Kick",
						Language.JPN => "とびひざげり",
						Language.GER => "Turmkick",
						Language.FRE => "Pied Voltige",
						Language.ITA => "Calcinvolo",
						Language.SPN => "Pat. Salto Alta",
						Language.KOR => "무릎차기",
						Language.CHN_SIM => "飞膝踢",
						Language.CHN_TRA => "飛膝踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HOLD_BACK:
					return lang switch {
						Language.ENG => "Hold Back",
						Language.JPN => "てかげん",
						Language.GER => "Zurückhaltung",
						Language.FRE => "Retenue",
						Language.ITA => "Riguardo",
						Language.SPN => "Clemencia",
						Language.KOR => "적당히손봐주기",
						Language.CHN_SIM => "手下留情",
						Language.CHN_TRA => "手下留情",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HONE_CLAWS:
					return lang switch {
						Language.ENG => "Hone Claws",
						Language.JPN => "つめとぎ",
						Language.GER => "Klauenwetzer",
						Language.FRE => "Aiguisage",
						Language.ITA => "Unghiaguzze",
						Language.SPN => "Afilagarras",
						Language.KOR => "손톱갈기",
						Language.CHN_SIM => "磨爪",
						Language.CHN_TRA => "磨爪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HORN_ATTACK:
					return lang switch {
						Language.ENG => "Horn Attack",
						Language.JPN => "つのでつく",
						Language.GER => "Hornattacke",
						Language.FRE => "Koud'Korne",
						Language.ITA => "Incornata",
						Language.SPN => "Cornada",
						Language.KOR => "뿔찌르기",
						Language.CHN_SIM => "角撞",
						Language.CHN_TRA => "角撞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HORN_DRILL:
					return lang switch {
						Language.ENG => "Horn Drill",
						Language.JPN => "つのドリル",
						Language.GER => "Hornbohrer",
						Language.FRE => "Empal'Korne",
						Language.ITA => "Perforcorno",
						Language.SPN => "Perforador",
						Language.KOR => "뿔드릴",
						Language.CHN_SIM => "角钻",
						Language.CHN_TRA => "角鑽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HORN_LEECH:
					return lang switch {
						Language.ENG => "Horn Leech",
						Language.JPN => "ウッドホーン",
						Language.GER => "Holzgeweih",
						Language.FRE => "Encornebois",
						Language.ITA => "Legnicorno",
						Language.SPN => "Asta Drenaje",
						Language.KOR => "우드혼",
						Language.CHN_SIM => "木角",
						Language.CHN_TRA => "木角",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HOWL:
					return lang switch {
						Language.ENG => "Howl",
						Language.JPN => "とおぼえ",
						Language.GER => "Jauler",
						Language.FRE => "Grondement",
						Language.ITA => "Gridodilotta",
						Language.SPN => "Aullido",
						Language.KOR => "멀리짖기",
						Language.CHN_SIM => "长嚎",
						Language.CHN_TRA => "長嚎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HURRICANE:
					return lang switch {
						Language.ENG => "Hurricane",
						Language.JPN => "ぼうふう",
						Language.GER => "Orkan",
						Language.FRE => "Vent Violent",
						Language.ITA => "Tifone",
						Language.SPN => "Vendaval",
						Language.KOR => "폭풍",
						Language.CHN_SIM => "暴风",
						Language.CHN_TRA => "暴風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYDRO_CANNON:
					return lang switch {
						Language.ENG => "Hydro Cannon",
						Language.JPN => "ハイドロカノン",
						Language.GER => "Aquahaubitze",
						Language.FRE => "Hydroblast",
						Language.ITA => "Idrocannone",
						Language.SPN => "Hidrocañón",
						Language.KOR => "하이드로캐논",
						Language.CHN_SIM => "加农水炮",
						Language.CHN_TRA => "加農水炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYDRO_PUMP:
					return lang switch {
						Language.ENG => "Hydro Pump",
						Language.JPN => "ハイドロポンプ",
						Language.GER => "Hydropumpe",
						Language.FRE => "Hydrocanon",
						Language.ITA => "Idropompa",
						Language.SPN => "Hidrobomba",
						Language.KOR => "하이드로펌프",
						Language.CHN_SIM => "水炮",
						Language.CHN_TRA => "水炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYDRO_STEAM:
					return lang switch {
						Language.ENG => "Hydro Steam",
						Language.JPN => "ハイドロスチー",
						Language.GER => "Hydrodampf",
						Language.FRE => "Hydrovapeur",
						Language.ITA => "Idrovapore",
						Language.SPN => "Hidrovapor",
						Language.KOR => "하이드로스팀",
						Language.CHN_SIM => "水蒸气",
						Language.CHN_TRA => "水蒸氣",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPER_BEAM:
					return lang switch {
						Language.ENG => "Hyper Beam",
						Language.JPN => "はかいこうせん",
						Language.GER => "Hyperstrahl",
						Language.FRE => "Ultralaser",
						Language.ITA => "Iper Raggio",
						Language.SPN => "Hiperrayo",
						Language.KOR => "파괴광선",
						Language.CHN_SIM => "破坏光线",
						Language.CHN_TRA => "破壞光線",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPER_DRILL:
					return lang switch {
						Language.ENG => "Hyper Drill",
						Language.JPN => "ハイパードリ",
						Language.GER => "Hyperbohrer",
						Language.FRE => "Hyperceuse",
						Language.ITA => "Ipertrapano",
						Language.SPN => "Hipertaladro",
						Language.KOR => "하이퍼드릴",
						Language.CHN_SIM => "强力钻",
						Language.CHN_TRA => "強力鑽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPER_FANG:
					return lang switch {
						Language.ENG => "Hyper Fang",
						Language.JPN => "ひっさつまえば",
						Language.GER => "Hyperzahn",
						Language.FRE => "Croc de Mort",
						Language.ITA => "Iperzanna",
						Language.SPN => "Hipercolmillo",
						Language.KOR => "필살앞니",
						Language.CHN_SIM => "终结门牙",
						Language.CHN_TRA => "必殺門牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPER_VOICE:
					return lang switch {
						Language.ENG => "Hyper Voice",
						Language.JPN => "ハイパーボイス",
						Language.GER => "Schallwelle",
						Language.FRE => "Mégaphone",
						Language.ITA => "Granvoce",
						Language.SPN => "Vozarrón",
						Language.KOR => "하이퍼보이스",
						Language.CHN_SIM => "巨声",
						Language.CHN_TRA => "巨聲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPERSPACE_FURY:
					return lang switch {
						Language.ENG => "Hyperspace Fury",
						Language.JPN => "いじげんラッシュ",
						Language.GER => "Dimensionswahn",
						Language.FRE => "Furie Dimension",
						Language.ITA => "Urtodimensionale",
						Language.SPN => "Cerco Dimensión",
						Language.KOR => "이차원러시",
						Language.CHN_SIM => "异次元猛攻",
						Language.CHN_TRA => "異次元猛攻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPERSPACE_HOLE:
					return lang switch {
						Language.ENG => "Hyperspace Hole",
						Language.JPN => "いじげんホール",
						Language.GER => "Dimensionsloch",
						Language.FRE => "TrouDimensionnel",
						Language.ITA => "Forodimensionale",
						Language.SPN => "Paso Dimensional",
						Language.KOR => "이차원홀",
						Language.CHN_SIM => "异次元洞",
						Language.CHN_TRA => "異次元洞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.HYPNOSIS:
					return lang switch {
						Language.ENG => "Hypnosis",
						Language.JPN => "さいみんじゅつ",
						Language.GER => "Hypnose",
						Language.FRE => "Hypnose",
						Language.ITA => "Ipnosi",
						Language.SPN => "Hipnosis",
						Language.KOR => "최면술",
						Language.CHN_SIM => "催眠术",
						Language.CHN_TRA => "催眠術",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_BALL:
					return lang switch {
						Language.ENG => "Ice Ball",
						Language.JPN => "アイスボール",
						Language.GER => "Frostbeule",
						Language.FRE => "Ball'Glace",
						Language.ITA => "Palla Gelo",
						Language.SPN => "Bola Hielo",
						Language.KOR => "아이스볼",
						Language.CHN_SIM => "冰球",
						Language.CHN_TRA => "冰球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_BEAM:
					return lang switch {
						Language.ENG => "Ice Beam",
						Language.JPN => "れいとうビーム",
						Language.GER => "Eisstrahl",
						Language.FRE => "Laser Glace",
						Language.ITA => "Geloraggio",
						Language.SPN => "Rayo Hielo",
						Language.KOR => "냉동빔",
						Language.CHN_SIM => "冰冻光束",
						Language.CHN_TRA => "冰凍光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_BURN:
					return lang switch {
						Language.ENG => "Ice Burn",
						Language.JPN => "コールドフレア",
						Language.GER => "Frosthauch",
						Language.FRE => "Feu Glacé",
						Language.ITA => "Vampagelida",
						Language.SPN => "Llama Gélida",
						Language.KOR => "콜드플레어",
						Language.CHN_SIM => "极寒冷焰",
						Language.CHN_TRA => "極寒冷焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_FANG:
					return lang switch {
						Language.ENG => "Ice Fang",
						Language.JPN => "こおりのキバ",
						Language.GER => "Eiszahn",
						Language.FRE => "Crocs Givre",
						Language.ITA => "Gelodenti",
						Language.SPN => "Colmillo Hielo",
						Language.KOR => "얼음엄니",
						Language.CHN_SIM => "冰冻牙",
						Language.CHN_TRA => "冰凍牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_HAMMER:
					return lang switch {
						Language.ENG => "Ice Hammer",
						Language.JPN => "アイスハンマー",
						Language.GER => "Eishammer",
						Language.FRE => "Marteau de Glace",
						Language.ITA => "Martelgelo",
						Language.SPN => "Martillo Hielo",
						Language.KOR => "아이스해머",
						Language.CHN_SIM => "冰锤",
						Language.CHN_TRA => "冰錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_PUNCH:
					return lang switch {
						Language.ENG => "Ice Punch",
						Language.JPN => "れいとうパンチ",
						Language.GER => "Eishieb",
						Language.FRE => "Poing-Glace",
						Language.ITA => "Gelopugno",
						Language.SPN => "Puño Hielo",
						Language.KOR => "냉동펀치",
						Language.CHN_SIM => "冰冻拳",
						Language.CHN_TRA => "冰凍拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_SHARD:
					return lang switch {
						Language.ENG => "Ice Shard",
						Language.JPN => "こおりのつぶて",
						Language.GER => "Eissplitter",
						Language.FRE => "Éclats Glace",
						Language.ITA => "Geloscheggia",
						Language.SPN => "Canto Helado",
						Language.KOR => "얼음뭉치",
						Language.CHN_SIM => "冰砾",
						Language.CHN_TRA => "冰礫",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICE_SPINNER:
					return lang switch {
						Language.ENG => "Ice Spinner",
						Language.JPN => "アイススピナ",
						Language.GER => "Eiskreisel",
						Language.FRE => "Cryo-Pirouette",
						Language.ITA => "Vortighiaccio",
						Language.SPN => "Pirueta Helada",
						Language.KOR => "아이스스피너",
						Language.CHN_SIM => "冰旋",
						Language.CHN_TRA => "冰旋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICICLE_CRASH:
					return lang switch {
						Language.ENG => "Icicle Crash",
						Language.JPN => "つららおとし",
						Language.GER => "Eiszapfhagel",
						Language.FRE => "Chute Glace",
						Language.ITA => "Scagliagelo",
						Language.SPN => "Chuzos",
						Language.KOR => "고드름떨구기",
						Language.CHN_SIM => "冰柱坠击",
						Language.CHN_TRA => "冰柱墜擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICICLE_SPEAR:
					return lang switch {
						Language.ENG => "Icicle Spear",
						Language.JPN => "つららばり",
						Language.GER => "Eisspeer",
						Language.FRE => "Stalagtite",
						Language.ITA => "Gelolancia",
						Language.SPN => "Carámbano",
						Language.KOR => "고드름침",
						Language.CHN_SIM => "冰锥",
						Language.CHN_TRA => "冰錐",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ICY_WIND:
					return lang switch {
						Language.ENG => "Icy Wind",
						Language.JPN => "こごえるかぜ",
						Language.GER => "Eissturm",
						Language.FRE => "Vent Glace",
						Language.ITA => "Ventogelato",
						Language.SPN => "Viento Hielo",
						Language.KOR => "얼어붙은바람",
						Language.CHN_SIM => "冰冻之风",
						Language.CHN_TRA => "冰凍之風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.IMPRISON:
					return lang switch {
						Language.ENG => "Imprison",
						Language.JPN => "ふういん",
						Language.GER => "Begrenzer",
						Language.FRE => "Possessif",
						Language.ITA => "Esclusiva",
						Language.SPN => "Cerca",
						Language.KOR => "봉인",
						Language.CHN_SIM => "封印",
						Language.CHN_TRA => "封印",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.INCINERATE:
					return lang switch {
						Language.ENG => "Incinerate",
						Language.JPN => "やきつくす",
						Language.GER => "Einäschern",
						Language.FRE => "Calcination",
						Language.ITA => "Bruciatutto",
						Language.SPN => "Calcinación",
						Language.KOR => "불태우기",
						Language.CHN_SIM => "烧净",
						Language.CHN_TRA => "燒盡",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.INFERNAL_PARADE:
					return lang switch {
						Language.ENG => "Infernal Parade",
						Language.JPN => "ひゃっきやこ",
						Language.GER => "Phantomparade",
						Language.FRE => "Cortège Funèbre",
						Language.ITA => "Corteo Spettrale",
						Language.SPN => "Marcha Espectral",
						Language.KOR => "백귀야행",
						Language.CHN_SIM => "群魔乱舞",
						Language.CHN_TRA => "群魔亂舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.INFERNO:
					return lang switch {
						Language.ENG => "Inferno",
						Language.JPN => "れんごく",
						Language.GER => "Inferno",
						Language.FRE => "Feu d'Enfer",
						Language.ITA => "Marchiatura",
						Language.SPN => "Infierno",
						Language.KOR => "연옥",
						Language.CHN_SIM => "烈火深渊",
						Language.CHN_TRA => "煉獄",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.INFESTATION:
					return lang switch {
						Language.ENG => "Infestation",
						Language.JPN => "まとわりつく",
						Language.GER => "Plage",
						Language.FRE => "Harcèlement",
						Language.ITA => "Assillo",
						Language.SPN => "Acoso",
						Language.KOR => "엉겨붙기",
						Language.CHN_SIM => "纠缠不休",
						Language.CHN_TRA => "死纏爛打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.INGRAIN:
					return lang switch {
						Language.ENG => "Ingrain",
						Language.JPN => "ねをはる",
						Language.GER => "Verwurzler",
						Language.FRE => "Racines",
						Language.ITA => "Radicamento",
						Language.SPN => "Arraigo",
						Language.KOR => "뿌리박기",
						Language.CHN_SIM => "扎根",
						Language.CHN_TRA => "扎根",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.INSTRUCT:
					return lang switch {
						Language.ENG => "Instruct",
						Language.JPN => "さいはい",
						Language.GER => "Kommando",
						Language.FRE => "Sommation",
						Language.ITA => "Imposizione",
						Language.SPN => "Mandato",
						Language.KOR => "지휘",
						Language.CHN_SIM => "号令",
						Language.CHN_TRA => "號令",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ION_DELUGE:
					return lang switch {
						Language.ENG => "Ion Deluge",
						Language.JPN => "プラズマシャワー",
						Language.GER => "Plasmaschauer",
						Language.FRE => "DélugePlasma",
						Language.ITA => "Pioggiaplasma",
						Language.SPN => "Cortina Plasma",
						Language.KOR => "플라스마샤워",
						Language.CHN_SIM => "等离子浴",
						Language.CHN_TRA => "等離子浴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.IRON_DEFENSE:
					return lang switch {
						Language.ENG => "Iron Defense",
						Language.JPN => "てっぺき",
						Language.GER => "Eisenabwehr",
						Language.FRE => "Mur de Fer",
						Language.ITA => "Ferroscudo",
						Language.SPN => "Defensa Férrea",
						Language.KOR => "철벽",
						Language.CHN_SIM => "铁壁",
						Language.CHN_TRA => "鐵壁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.IRON_HEAD:
					return lang switch {
						Language.ENG => "Iron Head",
						Language.JPN => "アイアンヘッド",
						Language.GER => "Eisenschädel",
						Language.FRE => "Tête de Fer",
						Language.ITA => "Metaltestata",
						Language.SPN => "Cabeza de Hierro",
						Language.KOR => "아이언헤드",
						Language.CHN_SIM => "铁头",
						Language.CHN_TRA => "鐵頭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.IRON_TAIL:
					return lang switch {
						Language.ENG => "Iron Tail",
						Language.JPN => "アイアンテール",
						Language.GER => "Eisenschweif",
						Language.FRE => "Queue de Fer",
						Language.ITA => "Codacciaio",
						Language.SPN => "Cola Férrea",
						Language.KOR => "아이언테일",
						Language.CHN_SIM => "铁尾",
						Language.CHN_TRA => "鐵尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.JAW_LOCK:
					return lang switch {
						Language.ENG => "Jaw Lock",
						Language.JPN => "くらいつ",
						Language.GER => "Fesselbiss",
						Language.FRE => "Croque Fort",
						Language.ITA => "Morsostretto",
						Language.SPN => "Presa Maxilar",
						Language.KOR => "물고버티기",
						Language.CHN_SIM => "紧咬不放",
						Language.CHN_TRA => "緊咬不放",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.JET_PUNCH:
					return lang switch {
						Language.ENG => "Jet Punch",
						Language.JPN => "ジェットパン",
						Language.GER => "Düsenhieb",
						Language.FRE => "Poing Sonique",
						Language.ITA => "Pugnojet",
						Language.SPN => "Puño Jet",
						Language.KOR => "제트펀치",
						Language.CHN_SIM => "喷射拳",
						Language.CHN_TRA => "噴射拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.JUDGMENT:
					return lang switch {
						Language.ENG => "Judgment",
						Language.JPN => "さばきのつぶて",
						Language.GER => "Urteilskraft",
						Language.FRE => "Jugement",
						Language.ITA => "Giudizio",
						Language.SPN => "Sentencia",
						Language.KOR => "심판의뭉치",
						Language.CHN_SIM => "制裁光砾",
						Language.CHN_TRA => "制裁光礫",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.JUMP_KICK:
					return lang switch {
						Language.ENG => "Jump Kick",
						Language.JPN => "とびげり",
						Language.GER => "Sprungkick",
						Language.FRE => "Pied Sauté",
						Language.ITA => "Calciosalto",
						Language.SPN => "Patada Salto",
						Language.KOR => "점프킥",
						Language.CHN_SIM => "飞踢",
						Language.CHN_TRA => "飛踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.JUNGLE_HEALING:
					return lang switch {
						Language.ENG => "Jungle Healing",
						Language.JPN => "ジャングルヒー",
						Language.GER => "Dschungelheilung",
						Language.FRE => "Selve Salvatrice",
						Language.ITA => "Giunglacura",
						Language.SPN => "Cura Selvática",
						Language.KOR => "정글힐",
						Language.CHN_SIM => "丛林治疗",
						Language.CHN_TRA => "叢林治療",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.KARATE_CHOP:
					return lang switch {
						Language.ENG => "Karate Chop",
						Language.JPN => "からてチョップ",
						Language.GER => "Karateschlag",
						Language.FRE => "Poing-Karaté",
						Language.ITA => "Colpokarate",
						Language.SPN => "Golpe Karate",
						Language.KOR => "태권당수",
						Language.CHN_SIM => "空手劈",
						Language.CHN_TRA => "空手劈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.KINESIS:
					return lang switch {
						Language.ENG => "Kinesis",
						Language.JPN => "スプーンまげ",
						Language.GER => "Psykraft",
						Language.FRE => "Télékinésie",
						Language.ITA => "Cinèsi",
						Language.SPN => "Kinético",
						Language.KOR => "숟가락휘기",
						Language.CHN_SIM => "折弯汤匙",
						Language.CHN_TRA => "折彎湯匙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.KING_S_SHIELD:
					return lang switch {
						Language.ENG => "King's Shield",
						Language.JPN => "キングシールド",
						Language.GER => "Königsschild",
						Language.FRE => "Bouclier Royal",
						Language.ITA => "Scudo Reale",
						Language.SPN => "Escudo Real",
						Language.KOR => "킹실드",
						Language.CHN_SIM => "王者盾牌",
						Language.CHN_TRA => "王者盾牌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.KNOCK_OFF:
					return lang switch {
						Language.ENG => "Knock Off",
						Language.JPN => "はたきおとす",
						Language.GER => "Abschlag",
						Language.FRE => "Sabotage",
						Language.ITA => "Privazione",
						Language.SPN => "Desarme",
						Language.KOR => "탁쳐서떨구기",
						Language.CHN_SIM => "拍落",
						Language.CHN_TRA => "拍落",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.KOWTOW_CLEAVE:
					return lang switch {
						Language.ENG => "Kowtow Cleave",
						Language.JPN => "ドゲザ",
						Language.GER => "Kniefallspalter",
						Language.FRE => "Génusection",
						Language.ITA => "Genufendente",
						Language.SPN => "Genufendiente",
						Language.KOR => "도각참",
						Language.CHN_SIM => "仆刀",
						Language.CHN_TRA => "仆斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LAND_S_WRATH:
					return lang switch {
						Language.ENG => "Lang's Wrath",
						Language.JPN => "グランドフォース",
						Language.GER => "Bodengewalt",
						Language.FRE => "Force Chtonienne",
						Language.ITA => "Forza Tellurica",
						Language.SPN => "Fuerza Telúrica",
						Language.KOR => "그라운드포스",
						Language.CHN_SIM => "大地神力",
						Language.CHN_TRA => "大地神力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LASER_FOCUS:
					return lang switch {
						Language.ENG => "Laser Focus",
						Language.JPN => "とぎすます",
						Language.GER => "Konzentration",
						Language.FRE => "Affilage",
						Language.ITA => "Concentrazione",
						Language.SPN => "Aguzar",
						Language.KOR => "예민해지기",
						Language.CHN_SIM => "磨砺",
						Language.CHN_TRA => "磨礪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LASH_OUT:
					return lang switch {
						Language.ENG => "Lash Out",
						Language.JPN => "うっぷんばら",
						Language.GER => "Frustventil",
						Language.FRE => "Cent Rancunes",
						Language.ITA => "Sfogarabbia",
						Language.SPN => "Desahogo",
						Language.KOR => "분풀이",
						Language.CHN_SIM => "泄愤",
						Language.CHN_TRA => "洩憤",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LAST_RESORT:
					return lang switch {
						Language.ENG => "Last Resort",
						Language.JPN => "とっておき",
						Language.GER => "Zuflucht",
						Language.FRE => "Dernier Recours",
						Language.ITA => "Ultimascelta",
						Language.SPN => "Última Baza",
						Language.KOR => "비장의무기",
						Language.CHN_SIM => "珍藏",
						Language.CHN_TRA => "珍藏",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LAST_RESPECTS:
					return lang switch {
						Language.ENG => "Last Respects",
						Language.JPN => "おはかまい",
						Language.GER => "Letzte Ehre",
						Language.FRE => "Hommage Posthume",
						Language.ITA => "Omaggio ai KO",
						Language.SPN => "Homenaje Póstumo",
						Language.KOR => "성묘",
						Language.CHN_SIM => "扫墓",
						Language.CHN_TRA => "掃墓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LAVA_PLUME:
					return lang switch {
						Language.ENG => "Lava Plume",
						Language.JPN => "ふんえん",
						Language.GER => "Flammensturm",
						Language.FRE => "Ébullilave",
						Language.ITA => "Lavasbuffo",
						Language.SPN => "Humareda",
						Language.KOR => "분연",
						Language.CHN_SIM => "喷烟",
						Language.CHN_TRA => "噴煙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEAF_BLADE:
					return lang switch {
						Language.ENG => "Leaf Blade",
						Language.JPN => "リーフブレード",
						Language.GER => "Laubklinge",
						Language.FRE => "Lame-Feuille",
						Language.ITA => "Fendifoglia",
						Language.SPN => "Hoja Aguda",
						Language.KOR => "리프블레이드",
						Language.CHN_SIM => "叶刃",
						Language.CHN_TRA => "葉刃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEAF_STORM:
					return lang switch {
						Language.ENG => "Leaf Storm",
						Language.JPN => "リーフストーム",
						Language.GER => "Blättersturm",
						Language.FRE => "Tempête Verte",
						Language.ITA => "Verdebufera",
						Language.SPN => "Lluevahojas",
						Language.KOR => "리프스톰",
						Language.CHN_SIM => "飞叶风暴",
						Language.CHN_TRA => "飛葉風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEAF_TORNADO:
					return lang switch {
						Language.ENG => "Leaf Tornado",
						Language.JPN => "グラスミキサー",
						Language.GER => "Grasmixer",
						Language.FRE => "Phytomixeur",
						Language.ITA => "Vorticerba",
						Language.SPN => "Ciclón de Hojas",
						Language.KOR => "그래스믹서",
						Language.CHN_SIM => "青草搅拌器",
						Language.CHN_TRA => "青草攪拌器",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEAFAGE:
					return lang switch {
						Language.ENG => "Leafage",
						Language.JPN => "このは",
						Language.GER => "Blattwerk",
						Language.FRE => "Feuillage",
						Language.ITA => "Fogliame",
						Language.SPN => "Follaje",
						Language.KOR => "나뭇잎",
						Language.CHN_SIM => "树叶",
						Language.CHN_TRA => "樹葉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEECH_LIFE:
					return lang switch {
						Language.ENG => "Leech Life",
						Language.JPN => "きゅうけつ",
						Language.GER => "Blutsauger",
						Language.FRE => "Vampirisme",
						Language.ITA => "Sanguisuga",
						Language.SPN => "Chupavidas",
						Language.KOR => "흡혈",
						Language.CHN_SIM => "汲取",
						Language.CHN_TRA => "吸血",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEECH_SEED:
					return lang switch {
						Language.ENG => "Leech Seed",
						Language.JPN => "やどりぎのタネ",
						Language.GER => "Egelsamen",
						Language.FRE => "Vampigraine",
						Language.ITA => "Parassiseme",
						Language.SPN => "Drenadoras",
						Language.KOR => "씨뿌리기",
						Language.CHN_SIM => "寄生种子",
						Language.CHN_TRA => "寄生種子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LEER:
					return lang switch {
						Language.ENG => "Leer",
						Language.JPN => "にらみつける",
						Language.GER => "Silberblick",
						Language.FRE => "Groz'Yeux",
						Language.ITA => "Fulmisguardo",
						Language.SPN => "Malicioso",
						Language.KOR => "째려보기",
						Language.CHN_SIM => "瞪眼",
						Language.CHN_TRA => "瞪眼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LICK:
					return lang switch {
						Language.ENG => "Lick",
						Language.JPN => "したでなめる",
						Language.GER => "Schlecker",
						Language.FRE => "Léchouille",
						Language.ITA => "Leccata",
						Language.SPN => "Lengüetazo",
						Language.KOR => "핥기",
						Language.CHN_SIM => "舌舔",
						Language.CHN_TRA => "舌舔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LIFE_DEW:
					return lang switch {
						Language.ENG => "Life Dew",
						Language.JPN => "いのちのしず",
						Language.GER => "Lebenstropfen",
						Language.FRE => "Fontaine de Vie",
						Language.ITA => "Goccia Vitale",
						Language.SPN => "Gota Vital",
						Language.KOR => "생명의물방울",
						Language.CHN_SIM => "生命水滴",
						Language.CHN_TRA => "生命水滴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LIGHT_OF_RUIN:
					return lang switch {
						Language.ENG => "Light of Ruin",
						Language.JPN => "はめつのひかり",
						Language.GER => "Lux Calamitatis",
						Language.FRE => "Lumière du Néant",
						Language.ITA => "Luce Nefasta",
						Language.SPN => "Luz Aniquiladora",
						Language.KOR => "파멸의빛",
						Language.CHN_SIM => "破灭之光",
						Language.CHN_TRA => "破滅之光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LIGHT_SCREEN:
					return lang switch {
						Language.ENG => "Light Screen",
						Language.JPN => "ひかりのかべ",
						Language.GER => "Lichtschild",
						Language.FRE => "Mur Lumière",
						Language.ITA => "Schermoluce",
						Language.SPN => "Pantalla Luz",
						Language.KOR => "빛의장막",
						Language.CHN_SIM => "光墙",
						Language.CHN_TRA => "光牆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LIQUIDATION:
					return lang switch {
						Language.ENG => "Liquidation",
						Language.JPN => "アクアブレイク",
						Language.GER => "Aquadurchstoß",
						Language.FRE => "Aqua-Brèche",
						Language.ITA => "Idrobreccia",
						Language.SPN => "Hidroariete",
						Language.KOR => "아쿠아브레이크",
						Language.CHN_SIM => "水流裂破",
						Language.CHN_TRA => "水流裂破",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LOCK_ON:
					return lang switch {
						Language.ENG => "Lock-On",
						Language.JPN => "ロックオン",
						Language.GER => "Zielschuss",
						Language.FRE => "Verrouillage",
						Language.ITA => "Localizza",
						Language.SPN => "Fijar Blanco",
						Language.KOR => "록온",
						Language.CHN_SIM => "锁定",
						Language.CHN_TRA => "鎖定",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LOVELY_KISS:
					return lang switch {
						Language.ENG => "Lovely Kiss",
						Language.JPN => "あくまのキッス",
						Language.GER => "Todeskuss",
						Language.FRE => "Grobisou",
						Language.ITA => "Demonbacio",
						Language.SPN => "Beso Amoroso",
						Language.KOR => "악마의키스",
						Language.CHN_SIM => "恶魔之吻",
						Language.CHN_TRA => "惡魔之吻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LOW_KICK:
					return lang switch {
						Language.ENG => "Low Kick",
						Language.JPN => "けたぐり",
						Language.GER => "Fußkick",
						Language.FRE => "Balayage",
						Language.ITA => "Colpo Basso",
						Language.SPN => "Patada Baja",
						Language.KOR => "안다리걸기",
						Language.CHN_SIM => "踢倒",
						Language.CHN_TRA => "踢倒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LOW_SWEEP:
					return lang switch {
						Language.ENG => "Low Sweep",
						Language.JPN => "ローキック",
						Language.GER => "Fußtritt",
						Language.FRE => "Balayette",
						Language.ITA => "Calciobasso",
						Language.SPN => "Puntapié",
						Language.KOR => "로킥",
						Language.CHN_SIM => "下盘踢",
						Language.CHN_TRA => "下盤踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LUCKY_CHANT:
					return lang switch {
						Language.ENG => "Lucky Chant",
						Language.JPN => "おまじない",
						Language.GER => "Beschwörung",
						Language.FRE => "Air Veinard",
						Language.ITA => "Fortuncanto",
						Language.SPN => "Conjuro",
						Language.KOR => "주술",
						Language.CHN_SIM => "幸运咒语",
						Language.CHN_TRA => "幸運咒語",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LUMINA_CRASH:
					return lang switch {
						Language.ENG => "Lumina Crash",
						Language.JPN => "ルミナコリジョ",
						Language.GER => "Lichteinschlag",
						Language.FRE => "Lumino-Impact",
						Language.ITA => "Fotocollisione",
						Language.SPN => "Fotocolisión",
						Language.KOR => "루미나콜리전",
						Language.CHN_SIM => "琉光冲激",
						Language.CHN_TRA => "琉光衝激",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LUNAR_BLESSING:
					return lang switch {
						Language.ENG => "Lunar Blessing",
						Language.JPN => "みかづきのいの",
						Language.GER => "Lunargebet",
						Language.FRE => "Prière Lunaire",
						Language.ITA => "Invocaluna",
						Language.SPN => "Plegaria Lunar",
						Language.KOR => "초승달의기도",
						Language.CHN_SIM => "新月祈祷",
						Language.CHN_TRA => "新月祈禱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LUNAR_DANCE:
					return lang switch {
						Language.ENG => "Lunar Dance",
						Language.JPN => "みかづきのまい",
						Language.GER => "Lunartanz",
						Language.FRE => "Danse-Lune",
						Language.ITA => "Lunardanza",
						Language.SPN => "Danza Lunar",
						Language.KOR => "초승달춤",
						Language.CHN_SIM => "新月舞",
						Language.CHN_TRA => "新月舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LUNGE:
					return lang switch {
						Language.ENG => "Lunge",
						Language.JPN => "とびかかる",
						Language.GER => "Anfallen",
						Language.FRE => "Furie-Bond",
						Language.ITA => "Assalto",
						Language.SPN => "Plancha",
						Language.KOR => "덤벼들기",
						Language.CHN_SIM => "猛扑",
						Language.CHN_TRA => "猛撲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.LUSTER_PURGE:
					return lang switch {
						Language.ENG => "Luster Purge",
						Language.JPN => "ラスターパージ",
						Language.GER => "Scheinwerfer",
						Language.FRE => "Lumi-Éclat",
						Language.ITA => "Abbagliante",
						Language.SPN => "Resplandor",
						Language.KOR => "러스터퍼지",
						Language.CHN_SIM => "洁净光芒",
						Language.CHN_TRA => "潔淨光芒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MACH_PUNCH:
					return lang switch {
						Language.ENG => "Mach Punch",
						Language.JPN => "マッハパンチ",
						Language.GER => "Tempohieb",
						Language.FRE => "Mach Punch",
						Language.ITA => "Pugnorapido",
						Language.SPN => "Ultrapuño",
						Language.KOR => "마하펀치",
						Language.CHN_SIM => "音速拳",
						Language.CHN_TRA => "音速拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGIC_COAT:
					return lang switch {
						Language.ENG => "Magic Coat",
						Language.JPN => "マジックコート",
						Language.GER => "Magiemantel",
						Language.FRE => "Reflet Magik",
						Language.ITA => "Magivelo",
						Language.SPN => "Capa Mágica",
						Language.KOR => "매직코트",
						Language.CHN_SIM => "魔法反射",
						Language.CHN_TRA => "魔法反射",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGIC_POWDER:
					return lang switch {
						Language.ENG => "Magic Powder",
						Language.JPN => "まほうのこ",
						Language.GER => "Magiepuder",
						Language.FRE => "Poudre Magique",
						Language.ITA => "Magipolvere",
						Language.SPN => "Polvo Mágico",
						Language.KOR => "마법가루",
						Language.CHN_SIM => "魔法粉",
						Language.CHN_TRA => "魔法粉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGIC_ROOM:
					return lang switch {
						Language.ENG => "Magic Room",
						Language.JPN => "マジックルーム",
						Language.GER => "Magieraum",
						Language.FRE => "Zone Magique",
						Language.ITA => "Magicozona",
						Language.SPN => "Zona Mágica",
						Language.KOR => "매직룸",
						Language.CHN_SIM => "魔法空间",
						Language.CHN_TRA => "魔法空間",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGICAL_LEAF:
					return lang switch {
						Language.ENG => "Magical Leaf",
						Language.JPN => "マジカルリーフ",
						Language.GER => "Zauberblatt",
						Language.FRE => "Feuillemagik",
						Language.ITA => "Fogliamagica",
						Language.SPN => "Hoja Mágica",
						Language.KOR => "매지컬리프",
						Language.CHN_SIM => "魔法叶",
						Language.CHN_TRA => "魔法葉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGMA_STORM:
					return lang switch {
						Language.ENG => "Magma Storm",
						Language.JPN => "マグマストーム",
						Language.GER => "Lavasturm",
						Language.FRE => "Vortex Magma",
						Language.ITA => "Magmaclisma",
						Language.SPN => "Lluvia Ígnea",
						Language.KOR => "마그마스톰",
						Language.CHN_SIM => "熔岩风暴",
						Language.CHN_TRA => "熔岩風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGNET_BOMB:
					return lang switch {
						Language.ENG => "Magnet Bomb",
						Language.JPN => "マグネットボム",
						Language.GER => "Magnetbombe",
						Language.FRE => "Bombaimant",
						Language.ITA => "Bombagnete",
						Language.SPN => "Bomba Imán",
						Language.KOR => "마그넷봄",
						Language.CHN_SIM => "磁铁炸弹",
						Language.CHN_TRA => "磁鐵炸彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGNET_RISE:
					return lang switch {
						Language.ENG => "Magnet Rise",
						Language.JPN => "でんじふゆう",
						Language.GER => "Magnetflug",
						Language.FRE => "Vol Magnétik",
						Language.ITA => "Magnetascesa",
						Language.SPN => "Levitón",
						Language.KOR => "전자부유",
						Language.CHN_SIM => "电磁飘浮",
						Language.CHN_TRA => "電磁飄浮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGNETIC_FLUX:
					return lang switch {
						Language.ENG => "Magnetic Flux",
						Language.JPN => "じばそうさ",
						Language.GER => "Magnetregler",
						Language.FRE => "Magné-Contrôle",
						Language.ITA => "Controllo Polare",
						Language.SPN => "Aura Magnética",
						Language.KOR => "자기장조작",
						Language.CHN_SIM => "磁场操控",
						Language.CHN_TRA => "磁場操控",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAGNITUDE:
					return lang switch {
						Language.ENG => "Magnitude",
						Language.JPN => "マグニチュード",
						Language.GER => "Intensität",
						Language.FRE => "Ampleur",
						Language.ITA => "Magnitudo",
						Language.SPN => "Magnitud",
						Language.KOR => "매그니튜드",
						Language.CHN_SIM => "震级",
						Language.CHN_TRA => "震級",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAKE_IT_RAIN:
					return lang switch {
						Language.ENG => "Make It Rain",
						Language.JPN => "ゴールドラッシ",
						Language.GER => "Goldrausch",
						Language.FRE => "Ruée d’Or",
						Language.ITA => "Corsa all’Oro",
						Language.SPN => "Fiebre Dorada",
						Language.KOR => "골드러시",
						Language.CHN_SIM => "淘金潮",
						Language.CHN_TRA => "淘金潮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MAT_BLOCK:
					return lang switch {
						Language.ENG => "Mat Block",
						Language.JPN => "たたみがえし",
						Language.GER => "Tatami-Schild",
						Language.FRE => "Tatamigaeshi",
						Language.ITA => "Ribaltappeto",
						Language.SPN => "Escudo Tatami",
						Language.KOR => "마룻바닥세워막기",
						Language.CHN_SIM => "掀榻榻米",
						Language.CHN_TRA => "掀榻榻米",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ME_FIRST:
					return lang switch {
						Language.ENG => "Me First",
						Language.JPN => "さきどり",
						Language.GER => "Egotrip",
						Language.FRE => "Moi d'Abord",
						Language.ITA => "Precedenza",
						Language.SPN => "Yo Primero",
						Language.KOR => "선취",
						Language.CHN_SIM => "抢先一步",
						Language.CHN_TRA => "搶先一步",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEAN_LOOK:
					return lang switch {
						Language.ENG => "Mean Look",
						Language.JPN => "くろいまなざし",
						Language.GER => "Horrorblick",
						Language.FRE => "Regard Noir",
						Language.ITA => "Malosguardo",
						Language.SPN => "Mal De Ojo",
						Language.KOR => "검은눈빛",
						Language.CHN_SIM => "黑色目光",
						Language.CHN_TRA => "黑色目光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEDITATE:
					return lang switch {
						Language.ENG => "Meditate",
						Language.JPN => "ヨガのポーズ",
						Language.GER => "Meditation",
						Language.FRE => "Yoga",
						Language.ITA => "Meditazione",
						Language.SPN => "Meditación",
						Language.KOR => "요가포즈",
						Language.CHN_SIM => "瑜伽姿势",
						Language.CHN_TRA => "瑜伽姿勢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEGA_DRAIN:
					return lang switch {
						Language.ENG => "Mega Drain",
						Language.JPN => "メガドレイン",
						Language.GER => "Megasauger",
						Language.FRE => "Méga-Sangsue",
						Language.ITA => "Megassorbimento",
						Language.SPN => "Megaagotar",
						Language.KOR => "메가드레인",
						Language.CHN_SIM => "超级吸取",
						Language.CHN_TRA => "超級吸取",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEGA_KICK:
					return lang switch {
						Language.ENG => "Mega Kick",
						Language.JPN => "メガトンキック",
						Language.GER => "Megakick",
						Language.FRE => "Ultimawashi",
						Language.ITA => "Megacalcio",
						Language.SPN => "Megapatada",
						Language.KOR => "메가톤킥",
						Language.CHN_SIM => "百万吨重踢",
						Language.CHN_TRA => "百萬噸重踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEGA_PUNCH:
					return lang switch {
						Language.ENG => "Mega Punch",
						Language.JPN => "メガトンパンチ",
						Language.GER => "Megahieb",
						Language.FRE => "Ultimapoing",
						Language.ITA => "Megapugno",
						Language.SPN => "Megapuño",
						Language.KOR => "메가톤펀치",
						Language.CHN_SIM => "百万吨重拳",
						Language.CHN_TRA => "百萬噸重拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEGAHORN:
					return lang switch {
						Language.ENG => "Megahorn",
						Language.JPN => "メガホーン",
						Language.GER => "Vielender",
						Language.FRE => "Mégacorne",
						Language.ITA => "Megacorno",
						Language.SPN => "Megacuerno",
						Language.KOR => "메가혼",
						Language.CHN_SIM => "超级角击",
						Language.CHN_TRA => "超級角擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MEMENTO:
					return lang switch {
						Language.ENG => "Memento",
						Language.JPN => "おきみやげ",
						Language.GER => "Memento-Mori",
						Language.FRE => "Souvenir",
						Language.ITA => "Memento",
						Language.SPN => "Legado",
						Language.KOR => "추억의선물",
						Language.CHN_SIM => "临别礼物",
						Language.CHN_TRA => "臨別禮物",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METAL_BURST:
					return lang switch {
						Language.ENG => "Metal Burst",
						Language.JPN => "メタルバースト",
						Language.GER => "Metallstoß",
						Language.FRE => "Fulmifer",
						Language.ITA => "Metalscoppio",
						Language.SPN => "Represión Metal",
						Language.KOR => "메탈버스트",
						Language.CHN_SIM => "金属爆炸",
						Language.CHN_TRA => "金屬爆炸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METAL_CLAW:
					return lang switch {
						Language.ENG => "Metal Claw",
						Language.JPN => "メタルクロー",
						Language.GER => "Metallklaue",
						Language.FRE => "Griffe Acier",
						Language.ITA => "Ferrartigli",
						Language.SPN => "Garra Metal",
						Language.KOR => "메탈클로",
						Language.CHN_SIM => "金属爪",
						Language.CHN_TRA => "金屬爪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METAL_SOUND:
					return lang switch {
						Language.ENG => "Metal Sound",
						Language.JPN => "きんぞくおん",
						Language.GER => "Metallsound",
						Language.FRE => "Strido-Son",
						Language.ITA => "Ferrostrido",
						Language.SPN => "Eco Metálico",
						Language.KOR => "금속음",
						Language.CHN_SIM => "金属音",
						Language.CHN_TRA => "金屬音",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METEOR_ASSAULT:
					return lang switch {
						Language.ENG => "Meteor Assault",
						Language.JPN => "スターアサル",
						Language.GER => "Sternensturm",
						Language.FRE => "Joute Astrale",
						Language.ITA => "Sfolgorassalto",
						Language.SPN => "Asalto Estelar",
						Language.KOR => "스타어설트",
						Language.CHN_SIM => "流星突击",
						Language.CHN_TRA => "流星突擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METEOR_BEAM:
					return lang switch {
						Language.ENG => "Meteor Beam",
						Language.JPN => "メテオビー",
						Language.GER => "Meteorstrahl",
						Language.FRE => "Laser Météore",
						Language.ITA => "Raggiometeora",
						Language.SPN => "Rayo Meteórico",
						Language.KOR => "메테오빔",
						Language.CHN_SIM => "流星光束",
						Language.CHN_TRA => "流星光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METEOR_MASH:
					return lang switch {
						Language.ENG => "Meteor Mash",
						Language.JPN => "コメットパンチ",
						Language.GER => "Sternenhieb",
						Language.FRE => "Poing Météor",
						Language.ITA => "Meteorpugno",
						Language.SPN => "Puño Meteoro",
						Language.KOR => "코멧펀치",
						Language.CHN_SIM => "彗星拳",
						Language.CHN_TRA => "彗星拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.METRONOME:
					return lang switch {
						Language.ENG => "Metronome",
						Language.JPN => "ゆびをふる",
						Language.GER => "Metronom",
						Language.FRE => "Métronome",
						Language.ITA => "Metronomo",
						Language.SPN => "Metrónomo",
						Language.KOR => "손가락흔들기",
						Language.CHN_SIM => "挥指",
						Language.CHN_TRA => "揮指",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MILK_DRINK:
					return lang switch {
						Language.ENG => "Milk Drink",
						Language.JPN => "ミルクのみ",
						Language.GER => "Milchgetränk",
						Language.FRE => "Lait à Boire",
						Language.ITA => "Buonlatte",
						Language.SPN => "Batido",
						Language.KOR => "우유마시기",
						Language.CHN_SIM => "喝牛奶",
						Language.CHN_TRA => "喝牛奶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIMIC:
					return lang switch {
						Language.ENG => "Mimic",
						Language.JPN => "ものまね",
						Language.GER => "Mimikry",
						Language.FRE => "Copie",
						Language.ITA => "Mimica",
						Language.SPN => "Mimético",
						Language.KOR => "흉내내기",
						Language.CHN_SIM => "模仿",
						Language.CHN_TRA => "模仿",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIND_BLOWN:
					return lang switch {
						Language.ENG => "Mind Blown",
						Language.JPN => "ビックリヘッド",
						Language.GER => "Knallkopf",
						Language.FRE => "Caboche-Kaboum",
						Language.ITA => "Sbalorditesta",
						Language.SPN => "Cabeza Sorpresa",
						Language.KOR => "깜짝헤드",
						Language.CHN_SIM => "惊爆大头",
						Language.CHN_TRA => "驚爆大頭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIND_READER:
					return lang switch {
						Language.ENG => "Mind Reader",
						Language.JPN => "こころのめ",
						Language.GER => "Willensleser",
						Language.FRE => "Lire-Esprit",
						Language.ITA => "Leggimente",
						Language.SPN => "Telépata",
						Language.KOR => "마음의눈",
						Language.CHN_SIM => "心之眼",
						Language.CHN_TRA => "心之眼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MINIMIZE:
					return lang switch {
						Language.ENG => "Minimize",
						Language.JPN => "ちいさくなる",
						Language.GER => "Komprimator",
						Language.FRE => "Lilliput",
						Language.ITA => "Minimizzato",
						Language.SPN => "Reducción",
						Language.KOR => "작아지기",
						Language.CHN_SIM => "变小",
						Language.CHN_TRA => "變小",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIRACLE_EYE:
					return lang switch {
						Language.ENG => "Miracle Eye",
						Language.JPN => "ミラクルアイ",
						Language.GER => "Wunderauge",
						Language.FRE => "Œil Miracle",
						Language.ITA => "Miracolvista",
						Language.SPN => "Gran Ojo",
						Language.KOR => "미라클아이",
						Language.CHN_SIM => "奇迹之眼",
						Language.CHN_TRA => "奇跡之眼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIRROR_COAT:
					return lang switch {
						Language.ENG => "Mirror Coat",
						Language.JPN => "ミラーコート",
						Language.GER => "Spiegelcape",
						Language.FRE => "Voile Miroir",
						Language.ITA => "Specchiovelo",
						Language.SPN => "Manto Espejo",
						Language.KOR => "미러코트",
						Language.CHN_SIM => "镜面反射",
						Language.CHN_TRA => "鏡面反射",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIRROR_MOVE:
					return lang switch {
						Language.ENG => "Mirror Move",
						Language.JPN => "オウムがえし",
						Language.GER => "Spiegeltrick",
						Language.FRE => "Mimique",
						Language.ITA => "Speculmossa",
						Language.SPN => "Mov. Espejo",
						Language.KOR => "따라하기",
						Language.CHN_SIM => "鹦鹉学舌",
						Language.CHN_TRA => "鸚鵡學舌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIRROR_SHOT:
					return lang switch {
						Language.ENG => "Mirror Shot",
						Language.JPN => "ミラーショット",
						Language.GER => "Spiegelsalve",
						Language.FRE => "Miroi-Tir",
						Language.ITA => "Cristalcolpo",
						Language.SPN => "Disparo Espejo",
						Language.KOR => "미러샷",
						Language.CHN_SIM => "镜光射击",
						Language.CHN_TRA => "鏡光射擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIST:
					return lang switch {
						Language.ENG => "Mist",
						Language.JPN => "しろいきり",
						Language.GER => "Weißnebel",
						Language.FRE => "Brume",
						Language.ITA => "Nebbia",
						Language.SPN => "Neblina",
						Language.KOR => "흰안개",
						Language.CHN_SIM => "白雾",
						Language.CHN_TRA => "白霧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MIST_BALL:
					return lang switch {
						Language.ENG => "Mist Ball",
						Language.JPN => "ミストボール",
						Language.GER => "Nebelball",
						Language.FRE => "Ball'Brume",
						Language.ITA => "Foschisfera",
						Language.SPN => "Bola Neblina",
						Language.KOR => "미스트볼",
						Language.CHN_SIM => "薄雾球",
						Language.CHN_TRA => "薄霧球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MISTY_EXPLOSION:
					return lang switch {
						Language.ENG => "Misty Explosion",
						Language.JPN => "ミストバース",
						Language.GER => "Nebelexplosion",
						Language.FRE => "Explo-Brume",
						Language.ITA => "Nebbioscoppio",
						Language.SPN => "Bruma Explosiva",
						Language.KOR => "미스트버스트",
						Language.CHN_SIM => "薄雾炸裂",
						Language.CHN_TRA => "薄霧炸裂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MISTY_TERRAIN:
					return lang switch {
						Language.ENG => "Misty Terrain",
						Language.JPN => "ミストフィールド",
						Language.GER => "Nebelfeld",
						Language.FRE => "Champ Brumeux",
						Language.ITA => "Campo Nebbioso",
						Language.SPN => "Campo de Niebla",
						Language.KOR => "미스트필드",
						Language.CHN_SIM => "薄雾场地",
						Language.CHN_TRA => "薄霧場地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MOONBLAST:
					return lang switch {
						Language.ENG => "Moonblast",
						Language.JPN => "ムーンフォース",
						Language.GER => "Mondgewalt",
						Language.FRE => "Pouvoir Lunaire",
						Language.ITA => "Forza Lunare",
						Language.SPN => "Fuerza Lunar",
						Language.KOR => "문포스",
						Language.CHN_SIM => "月亮之力",
						Language.CHN_TRA => "月亮之力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MOONGEIST_BEAM:
					return lang switch {
						Language.ENG => "Moongeist Beam",
						Language.JPN => "シャドーレイ",
						Language.GER => "Schattenstrahl",
						Language.FRE => "Rayon Spectral",
						Language.ITA => "Raggio d'Ombra",
						Language.SPN => "Rayo Umbrío",
						Language.KOR => "섀도레이",
						Language.CHN_SIM => "暗影之光",
						Language.CHN_TRA => "暗影之光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MOONLIGHT:
					return lang switch {
						Language.ENG => "Moonlight",
						Language.JPN => "つきのひかり",
						Language.GER => "Mondschein",
						Language.FRE => "Rayon Lune",
						Language.ITA => "Lucelunare",
						Language.SPN => "Luz Lunar",
						Language.KOR => "달빛",
						Language.CHN_SIM => "月光",
						Language.CHN_TRA => "月光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MORNING_SUN:
					return lang switch {
						Language.ENG => "Morning Sun",
						Language.JPN => "あさのひざし",
						Language.GER => "Morgengrauen",
						Language.FRE => "Aurore",
						Language.ITA => "Mattindoro",
						Language.SPN => "Sol Matinal",
						Language.KOR => "아침햇살",
						Language.CHN_SIM => "晨光",
						Language.CHN_TRA => "晨光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MORTAL_SPIN:
					return lang switch {
						Language.ENG => "Mortal Spin",
						Language.JPN => "キラースピ",
						Language.GER => "Letalwirbler",
						Language.FRE => "Toupie Éclat",
						Language.ITA => "Glitturbine",
						Language.SPN => "Giro Mortífero",
						Language.KOR => "킬러스핀",
						Language.CHN_SIM => "晶光转转",
						Language.CHN_TRA => "晶光轉轉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MOUNTAIN_GALE:
					return lang switch {
						Language.ENG => "Mountain Gale",
						Language.JPN => "ひょうざんおろ",
						Language.GER => "Frostfallwind",
						Language.FRE => "Bise Glaciaire",
						Language.ITA => "Soffio d’Iceberg",
						Language.SPN => "Viento Carámbano",
						Language.KOR => "빙산바람",
						Language.CHN_SIM => "冰山风",
						Language.CHN_TRA => "冰山風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MUD_BOMB:
					return lang switch {
						Language.ENG => "Mud Bomb",
						Language.JPN => "どろばくだん",
						Language.GER => "Schlammbombe",
						Language.FRE => "Boue-Bombe",
						Language.ITA => "Pantanobomba",
						Language.SPN => "Bomba Fango",
						Language.KOR => "진흙폭탄",
						Language.CHN_SIM => "泥巴炸弹",
						Language.CHN_TRA => "泥巴炸彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MUD_SHOT:
					return lang switch {
						Language.ENG => "Mud Shot",
						Language.JPN => "マッドショット",
						Language.GER => "Lehmschuss",
						Language.FRE => "Tir de Boue",
						Language.ITA => "Colpodifango",
						Language.SPN => "Disparo Lodo",
						Language.KOR => "머드샷",
						Language.CHN_SIM => "泥巴射击",
						Language.CHN_TRA => "泥巴射擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MUD_SPORT:
					return lang switch {
						Language.ENG => "Mud Sport",
						Language.JPN => "どろあそび",
						Language.GER => "Lehmsuhler",
						Language.FRE => "Lance-Boue",
						Language.ITA => "Fangata",
						Language.SPN => "Chapoteo Lodo",
						Language.KOR => "흙놀이",
						Language.CHN_SIM => "玩泥巴",
						Language.CHN_TRA => "玩泥巴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MUD_SLAP:
					return lang switch {
						Language.ENG => "Mud-Slap",
						Language.JPN => "どろかけ",
						Language.GER => "Lehmschelle",
						Language.FRE => "Coud'Boue",
						Language.ITA => "Fangosberla",
						Language.SPN => "Bofetón Lodo",
						Language.KOR => "진흙뿌리기",
						Language.CHN_SIM => "掷泥",
						Language.CHN_TRA => "擲泥",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MUDDY_WATER:
					return lang switch {
						Language.ENG => "Muddy Water",
						Language.JPN => "だくりゅう",
						Language.GER => "Lehmbrühe",
						Language.FRE => "Ocroupi",
						Language.ITA => "Fanghiglia",
						Language.SPN => "Agua Lodosa",
						Language.KOR => "탁류",
						Language.CHN_SIM => "浊流",
						Language.CHN_TRA => "濁流",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MULTI_ATTACK:
					return lang switch {
						Language.ENG => "Multi-Attack",
						Language.JPN => "マルチアタック",
						Language.GER => "Multi-Angriff",
						Language.FRE => "Coup Varia-Type",
						Language.ITA => "Multiattacco",
						Language.SPN => "Multiataque",
						Language.KOR => "멀티어택",
						Language.CHN_SIM => "多属性攻击",
						Language.CHN_TRA => "多屬性攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MYSTICAL_FIRE:
					return lang switch {
						Language.ENG => "Mystical Fire",
						Language.JPN => "マジカルフレイム",
						Language.GER => "Magieflamme",
						Language.FRE => "Feu Ensorcelé",
						Language.ITA => "Magifiamma",
						Language.SPN => "Llama Embrujada",
						Language.KOR => "매지컬플레임",
						Language.CHN_SIM => "魔法火焰",
						Language.CHN_TRA => "魔法火焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.MYSTICAL_POWER:
					return lang switch {
						Language.ENG => "Mystical Power",
						Language.JPN => "しんぴのちか",
						Language.GER => "Mythenkraft",
						Language.FRE => "Force Mystique",
						Language.ITA => "Forza Mistica",
						Language.SPN => "Poder Místico",
						Language.KOR => "신비의힘",
						Language.CHN_SIM => "神秘之力",
						Language.CHN_TRA => "神秘之力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NASTY_PLOT:
					return lang switch {
						Language.ENG => "Nasty Plot",
						Language.JPN => "わるだくみ",
						Language.GER => "Ränkeschmied",
						Language.FRE => "Machination",
						Language.ITA => "Congiura",
						Language.SPN => "Maquinación",
						Language.KOR => "나쁜음모",
						Language.CHN_SIM => "诡计",
						Language.CHN_TRA => "詭計",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NATURAL_GIFT:
					return lang switch {
						Language.ENG => "Natural Gift",
						Language.JPN => "しぜんのめぐみ",
						Language.GER => "Beerenkräfte",
						Language.FRE => "Don Naturel",
						Language.ITA => "Dononaturale",
						Language.SPN => "Don Natural",
						Language.KOR => "자연의은혜",
						Language.CHN_SIM => "自然之恩",
						Language.CHN_TRA => "自然之恩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NATURE_POWER:
					return lang switch {
						Language.ENG => "Nature Power",
						Language.JPN => "しぜんのちから",
						Language.GER => "Natur-Kraft",
						Language.FRE => "Force-Nature",
						Language.ITA => "Naturforza",
						Language.SPN => "Adaptación",
						Language.KOR => "자연의힘",
						Language.CHN_SIM => "自然之力",
						Language.CHN_TRA => "自然之力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NATURE_S_MADNESS:
					return lang switch {
						Language.ENG => "Nature's Madness",
						Language.JPN => "しぜんのいかり",
						Language.GER => "Naturzorn",
						Language.FRE => "Ire de la Nature",
						Language.ITA => "Ira della Natura",
						Language.SPN => "Furia Natural",
						Language.KOR => "자연의분노",
						Language.CHN_SIM => "自然之怒",
						Language.CHN_TRA => "自然之怒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NEEDLE_ARM:
					return lang switch {
						Language.ENG => "Needle Arm",
						Language.JPN => "ニードルアーム",
						Language.GER => "Nietenranke",
						Language.FRE => "Poing Dard",
						Language.ITA => "Pugnospine",
						Language.SPN => "Brazo Pincho",
						Language.KOR => "바늘팔",
						Language.CHN_SIM => "尖刺臂",
						Language.CHN_TRA => "尖刺臂",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NIGHT_DAZE:
					return lang switch {
						Language.ENG => "Night Daze",
						Language.JPN => "ナイトバースト",
						Language.GER => "Nachtflut",
						Language.FRE => "Explonuit",
						Language.ITA => "Urtoscuro",
						Language.SPN => "Pulso Noche",
						Language.KOR => "나이트버스트",
						Language.CHN_SIM => "暗黑爆破",
						Language.CHN_TRA => "暗黑爆破",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NIGHT_SHADE:
					return lang switch {
						Language.ENG => "Night Shade",
						Language.JPN => "ナイトヘッド",
						Language.GER => "Nachtnebel",
						Language.FRE => "Ombre Nocturne",
						Language.ITA => "Ombra Notturna",
						Language.SPN => "Tinieblas",
						Language.KOR => "나이트헤드",
						Language.CHN_SIM => "黑夜魔影",
						Language.CHN_TRA => "黑夜魔影",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NIGHT_SLASH:
					return lang switch {
						Language.ENG => "Night Slash",
						Language.JPN => "つじぎり",
						Language.GER => "Nachthieb",
						Language.FRE => "Tranche-Nuit",
						Language.ITA => "Nottesferza",
						Language.SPN => "Tajo Umbrío",
						Language.KOR => "깜짝베기",
						Language.CHN_SIM => "暗袭要害",
						Language.CHN_TRA => "暗襲要害",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NIGHTMARE:
					return lang switch {
						Language.ENG => "Nightmare",
						Language.JPN => "あくむ",
						Language.GER => "Nachtmahr",
						Language.FRE => "Cauchemar",
						Language.ITA => "Incubo",
						Language.SPN => "Pesadilla",
						Language.KOR => "악몽",
						Language.CHN_SIM => "恶梦",
						Language.CHN_TRA => "惡夢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NO_RETREAT:
					return lang switch {
						Language.ENG => "No Retreat",
						Language.JPN => "はいすいのじ",
						Language.GER => "Finalformation",
						Language.FRE => "Ultime Bastion",
						Language.ITA => "Spalle al Muro",
						Language.SPN => "Bastión Final",
						Language.KOR => "배수의진",
						Language.CHN_SIM => "背水一战",
						Language.CHN_TRA => "背水一戰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NOBLE_ROAR:
					return lang switch {
						Language.ENG => "Noble Roar",
						Language.JPN => "おたけび",
						Language.GER => "Kampfgebrüll",
						Language.FRE => "Râle Mâle",
						Language.ITA => "Urlo",
						Language.SPN => "Rugido de Guerra",
						Language.KOR => "부르짖기",
						Language.CHN_SIM => "战吼",
						Language.CHN_TRA => "戰吼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.NUZZLE:
					return lang switch {
						Language.ENG => "Nuzzle",
						Language.JPN => "ほっぺすりすり",
						Language.GER => "Wangenrubbler",
						Language.FRE => "Frotte-Frimousse",
						Language.ITA => "Elettrococcola",
						Language.SPN => "Moflete Estático",
						Language.KOR => "볼부비부비",
						Language.CHN_SIM => "蹭蹭脸颊",
						Language.CHN_TRA => "蹭蹭臉頰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OBLIVION_WING:
					return lang switch {
						Language.ENG => "Oblivion Wing",
						Language.JPN => "デスウイング",
						Language.GER => "Unheilsschwingen",
						Language.FRE => "Mort-Ailes",
						Language.ITA => "Ali del Fato",
						Language.SPN => "Ala Mortífera",
						Language.KOR => "데스윙",
						Language.CHN_SIM => "归天之翼",
						Language.CHN_TRA => "死亡之翼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OBSTRUCT:
					return lang switch {
						Language.ENG => "Obstruct",
						Language.JPN => "ブロッキン",
						Language.GER => "Abblocker",
						Language.FRE => "Blocage",
						Language.ITA => "Sbarramento",
						Language.SPN => "Obstrucción",
						Language.KOR => "블로킹",
						Language.CHN_SIM => "拦堵",
						Language.CHN_TRA => "攔堵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OCTAZOOKA:
					return lang switch {
						Language.ENG => "Octazooka",
						Language.JPN => "オクタンほう",
						Language.GER => "Octazooka",
						Language.FRE => "Octazooka",
						Language.ITA => "Octazooka",
						Language.SPN => "Pulpocañón",
						Language.KOR => "대포무노포",
						Language.CHN_SIM => "章鱼桶炮",
						Language.CHN_TRA => "章魚桶炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OCTOLOCK:
					return lang switch {
						Language.ENG => "Octolock",
						Language.JPN => "たこがた",
						Language.GER => "Octoklammer",
						Language.FRE => "Octoprise",
						Language.ITA => "Tentacolock",
						Language.SPN => "Octopresa",
						Language.KOR => "문어굳히기",
						Language.CHN_SIM => "蛸固",
						Language.CHN_TRA => "蛸固",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ODOR_SLEUTH:
					return lang switch {
						Language.ENG => "Odor Sleuth",
						Language.JPN => "かぎわける",
						Language.GER => "Schnüffler",
						Language.FRE => "Flair",
						Language.ITA => "Segugio",
						Language.SPN => "Rastreo",
						Language.KOR => "냄새구별",
						Language.CHN_SIM => "气味侦测",
						Language.CHN_TRA => "氣味偵測",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OMINOUS_WIND:
					return lang switch {
						Language.ENG => "Ominous Wind",
						Language.JPN => "あやしいかぜ",
						Language.GER => "Unheilböen",
						Language.FRE => "Vent Mauvais",
						Language.ITA => "Funestovento",
						Language.SPN => "Viento Aciago",
						Language.KOR => "괴상한바람",
						Language.CHN_SIM => "奇异之风",
						Language.CHN_TRA => "奇異之風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ORDER_UP:
					return lang switch {
						Language.ENG => "Order Up",
						Language.JPN => "いっちょうあが",
						Language.GER => "Auftischen",
						Language.FRE => "Plat du Jour",
						Language.ITA => "Alta Cucina",
						Language.SPN => "Oído Cocina",
						Language.KOR => "한판내기",
						Language.CHN_SIM => "上菜",
						Language.CHN_TRA => "上菜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ORIGIN_PULSE:
					return lang switch {
						Language.ENG => "Origin Pulse",
						Language.JPN => "こんげんのはどう",
						Language.GER => "Ursprungswoge",
						Language.FRE => "Onde Originelle",
						Language.ITA => "Primopulsar",
						Language.SPN => "Pulso Primigenio",
						Language.KOR => "근원의파동",
						Language.CHN_SIM => "根源波动",
						Language.CHN_TRA => "根源波動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OUTRAGE:
					return lang switch {
						Language.ENG => "Outrage",
						Language.JPN => "げきりん",
						Language.GER => "Wutanfall",
						Language.FRE => "Colère",
						Language.ITA => "Oltraggio",
						Language.SPN => "Enfado",
						Language.KOR => "역린",
						Language.CHN_SIM => "逆鳞",
						Language.CHN_TRA => "逆鱗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OVERDRIVE:
					return lang switch {
						Language.ENG => "Overdrive",
						Language.JPN => "オーバードライ",
						Language.GER => "Overdrive",
						Language.FRE => "Overdrive",
						Language.ITA => "Overdrive",
						Language.SPN => "Amplificador",
						Language.KOR => "오버드라이브",
						Language.CHN_SIM => "破音",
						Language.CHN_TRA => "破音",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.OVERHEAT:
					return lang switch {
						Language.ENG => "Overheat",
						Language.JPN => "オーバーヒート",
						Language.GER => "Hitzekoller",
						Language.FRE => "Surchauffe",
						Language.ITA => "Vampata",
						Language.SPN => "Sofoco",
						Language.KOR => "오버히트",
						Language.CHN_SIM => "过热",
						Language.CHN_TRA => "過熱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PAIN_SPLIT:
					return lang switch {
						Language.ENG => "Pain Split",
						Language.JPN => "いたみわけ",
						Language.GER => "Leidteiler",
						Language.FRE => "Balance",
						Language.ITA => "Malcomune",
						Language.SPN => "Divide Dolor",
						Language.KOR => "아픔나누기",
						Language.CHN_SIM => "分担痛楚",
						Language.CHN_TRA => "分擔痛楚",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PARABOLIC_CHARGE:
					return lang switch {
						Language.ENG => "Parabolic Charge",
						Language.JPN => "パラボラチャージ",
						Language.GER => "Parabolladung",
						Language.FRE => "Parabocharge",
						Language.ITA => "Caricaparabola",
						Language.SPN => "Carga Parábola",
						Language.KOR => "파라볼라차지",
						Language.CHN_SIM => "抛物面充电",
						Language.CHN_TRA => "拋物面充電",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PARTING_SHOT:
					return lang switch {
						Language.ENG => "Parting Shot",
						Language.JPN => "すてゼリフ",
						Language.GER => "Abgangstirade",
						Language.FRE => "Dernier Mot",
						Language.ITA => "Monito",
						Language.SPN => "Última Palabra",
						Language.KOR => "막말내뱉기",
						Language.CHN_SIM => "抛下狠话",
						Language.CHN_TRA => "拋下狠話",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PAY_DAY:
					return lang switch {
						Language.ENG => "Pay Day",
						Language.JPN => "ネコにこばん",
						Language.GER => "Zahltag",
						Language.FRE => "Jackpot",
						Language.ITA => "Giornopaga",
						Language.SPN => "Día de Pago",
						Language.KOR => "고양이돈받기",
						Language.CHN_SIM => "聚宝功",
						Language.CHN_TRA => "聚寶功",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PAYBACK:
					return lang switch {
						Language.ENG => "Payback",
						Language.JPN => "しっぺがえし",
						Language.GER => "Gegenstoß",
						Language.FRE => "Représailles",
						Language.ITA => "Rivincita",
						Language.SPN => "Vendetta",
						Language.KOR => "보복",
						Language.CHN_SIM => "以牙还牙",
						Language.CHN_TRA => "以牙還牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PECK:
					return lang switch {
						Language.ENG => "Peck",
						Language.JPN => "つつく",
						Language.GER => "Schnabel",
						Language.FRE => "Picpic",
						Language.ITA => "Beccata",
						Language.SPN => "Picotazo",
						Language.KOR => "쪼기",
						Language.CHN_SIM => "啄",
						Language.CHN_TRA => "啄",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PERISH_SONG:
					return lang switch {
						Language.ENG => "Perish Song",
						Language.JPN => "ほろびのうた",
						Language.GER => "Abgesang",
						Language.FRE => "Requiem",
						Language.ITA => "Ultimocanto",
						Language.SPN => "Canto Mortal",
						Language.KOR => "멸망의노래",
						Language.CHN_SIM => "终焉之歌",
						Language.CHN_TRA => "滅亡之歌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PETAL_BLIZZARD:
					return lang switch {
						Language.ENG => "Petal Blizzard",
						Language.JPN => "はなふぶき",
						Language.GER => "Blütenwirbel",
						Language.FRE => "Tempête Florale",
						Language.ITA => "Fiortempesta",
						Language.SPN => "Tormenta Floral",
						Language.KOR => "꽃보라",
						Language.CHN_SIM => "落英缤纷",
						Language.CHN_TRA => "落英繽紛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PETAL_DANCE:
					return lang switch {
						Language.ENG => "Petal Dance",
						Language.JPN => "はなびらのまい",
						Language.GER => "Blättertanz",
						Language.FRE => "Danse-Fleur",
						Language.ITA => "Petalodanza",
						Language.SPN => "Danza Pétalo",
						Language.KOR => "꽃잎댄스",
						Language.CHN_SIM => "花瓣舞",
						Language.CHN_TRA => "花瓣舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PHANTOM_FORCE:
					return lang switch {
						Language.ENG => "Phantom Force",
						Language.JPN => "ゴーストダイブ",
						Language.GER => "Phantomkraft",
						Language.FRE => "Hantise",
						Language.ITA => "Spettrotuffo",
						Language.SPN => "Golpe Fantasma",
						Language.KOR => "고스트다이브",
						Language.CHN_SIM => "潜灵奇袭",
						Language.CHN_TRA => "潛靈奇襲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PHOTON_GEYSER:
					return lang switch {
						Language.ENG => "Photon Geyser",
						Language.JPN => "フォトンゲイザー",
						Language.GER => "Photonen-Geysir",
						Language.FRE => "Photo-Geyser",
						Language.ITA => "Geyser Fotonico",
						Language.SPN => "Géiser Fotónico",
						Language.KOR => "포톤가이저",
						Language.CHN_SIM => "光子喷涌",
						Language.CHN_TRA => "光子噴湧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PIN_MISSILE:
					return lang switch {
						Language.ENG => "Pin Missile",
						Language.JPN => "ミサイルばり",
						Language.GER => "Nadelrakete",
						Language.FRE => "Dard-Nuée",
						Language.ITA => "Missilspillo",
						Language.SPN => "Pin Misil",
						Language.KOR => "바늘미사일",
						Language.CHN_SIM => "飞弹针",
						Language.CHN_TRA => "飛彈針",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PLASMA_FISTS:
					return lang switch {
						Language.ENG => "Plasma Fists",
						Language.JPN => "プラズマフィスト",
						Language.GER => "Plasmafäuste",
						Language.FRE => "Plasma Punch",
						Language.ITA => "Pugni Plasma",
						Language.SPN => "Puños Plasma",
						Language.KOR => "플라스마피스트",
						Language.CHN_SIM => "等离子闪电拳",
						Language.CHN_TRA => "等離子閃電拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PLAY_NICE:
					return lang switch {
						Language.ENG => "Play Nice",
						Language.JPN => "なかよくする",
						Language.GER => "Kameradschaft",
						Language.FRE => "Camaraderie",
						Language.ITA => "Simpatia",
						Language.SPN => "Camaradería",
						Language.KOR => "친해지기",
						Language.CHN_SIM => "和睦相处",
						Language.CHN_TRA => "和睦相處",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PLAY_ROUGH:
					return lang switch {
						Language.ENG => "Play Rough",
						Language.JPN => "じゃれつく",
						Language.GER => "Knuddler",
						Language.FRE => "Câlinerie",
						Language.ITA => "Carineria",
						Language.SPN => "Carantoña",
						Language.KOR => "치근거리기",
						Language.CHN_SIM => "嬉闹",
						Language.CHN_TRA => "嬉鬧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PLUCK:
					return lang switch {
						Language.ENG => "Pluck",
						Language.JPN => "ついばむ",
						Language.GER => "Pflücker",
						Language.FRE => "Picore",
						Language.ITA => "Spennata",
						Language.SPN => "Picoteo",
						Language.KOR => "쪼아대기",
						Language.CHN_SIM => "啄食",
						Language.CHN_TRA => "啄食",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POISON_FANG:
					return lang switch {
						Language.ENG => "Poison Fang",
						Language.JPN => "どくどくのキバ",
						Language.GER => "Giftzahn",
						Language.FRE => "Crochet Venin",
						Language.ITA => "Velenodenti",
						Language.SPN => "Colmillo Ven",
						Language.KOR => "맹독엄니",
						Language.CHN_SIM => "剧毒牙",
						Language.CHN_TRA => "劇毒牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POISON_GAS:
					return lang switch {
						Language.ENG => "Poison Gas",
						Language.JPN => "どくガス",
						Language.GER => "Giftwolke",
						Language.FRE => "Gaz Toxik",
						Language.ITA => "Velenogas",
						Language.SPN => "Gas Venenoso",
						Language.KOR => "독가스",
						Language.CHN_SIM => "毒瓦斯",
						Language.CHN_TRA => "毒瓦斯",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POISON_JAB:
					return lang switch {
						Language.ENG => "Poison Jab",
						Language.JPN => "どくづき",
						Language.GER => "Gifthieb",
						Language.FRE => "Direct Toxik",
						Language.ITA => "Velenpuntura",
						Language.SPN => "Puya Nociva",
						Language.KOR => "독찌르기",
						Language.CHN_SIM => "毒击",
						Language.CHN_TRA => "毒擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POISON_POWDER:
					return lang switch {
						Language.ENG => "Poison Powder",
						Language.JPN => "どくのこな",
						Language.GER => "Giftpuder",
						Language.FRE => "Poudre Toxik",
						Language.ITA => "Velenpolvere",
						Language.SPN => "Polvo Veneno",
						Language.KOR => "독가루",
						Language.CHN_SIM => "毒粉",
						Language.CHN_TRA => "毒粉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POISON_STING:
					return lang switch {
						Language.ENG => "Poison Sting",
						Language.JPN => "どくばり",
						Language.GER => "Giftstachel",
						Language.FRE => "Dard-Venin",
						Language.ITA => "Velenospina",
						Language.SPN => "Picotazo Ven",
						Language.KOR => "독침",
						Language.CHN_SIM => "毒针",
						Language.CHN_TRA => "毒針",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POISON_TAIL:
					return lang switch {
						Language.ENG => "Poison Tail",
						Language.JPN => "ポイズンテール",
						Language.GER => "Giftschweif",
						Language.FRE => "Queue-Poison",
						Language.ITA => "Velenocoda",
						Language.SPN => "Cola Veneno",
						Language.KOR => "포이즌테일",
						Language.CHN_SIM => "毒尾",
						Language.CHN_TRA => "毒尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POLLEN_PUFF:
					return lang switch {
						Language.ENG => "Pollen Puff",
						Language.JPN => "かふんだんご",
						Language.GER => "Pollenknödel",
						Language.FRE => "Boule Pollen",
						Language.ITA => "Sferapolline",
						Language.SPN => "Bola de Polen",
						Language.KOR => "꽃가루경단",
						Language.CHN_SIM => "花粉团",
						Language.CHN_TRA => "花粉團",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POLTERGEIST:
					return lang switch {
						Language.ENG => "Poltergeist",
						Language.JPN => "ポルターガイス",
						Language.GER => "Poltergeist",
						Language.FRE => "Esprit Frappeur",
						Language.ITA => "Poltergeist",
						Language.SPN => "Poltergeist",
						Language.KOR => "폴터가이스트",
						Language.CHN_SIM => "灵骚",
						Language.CHN_TRA => "靈騷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POPULATION_BOMB:
					return lang switch {
						Language.ENG => "Population Bomb",
						Language.JPN => "ネズミざ",
						Language.GER => "Mäuseplage",
						Language.FRE => "Prolifération",
						Language.ITA => "Infestazione",
						Language.SPN => "Proliferación",
						Language.KOR => "찍찍베기",
						Language.CHN_SIM => "鼠数儿",
						Language.CHN_TRA => "鼠數兒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POUNCE:
					return lang switch {
						Language.ENG => "Pounce",
						Language.JPN => "とびつ",
						Language.GER => "Anspringen",
						Language.FRE => "Bond",
						Language.ITA => "Balzo",
						Language.SPN => "Brinco",
						Language.KOR => "달려들기",
						Language.CHN_SIM => "虫扑",
						Language.CHN_TRA => "蟲撲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POUND:
					return lang switch {
						Language.ENG => "Pound",
						Language.JPN => "はたく",
						Language.GER => "Pfund",
						Language.FRE => "Écras'Face",
						Language.ITA => "Botta",
						Language.SPN => "Destructor",
						Language.KOR => "막치기",
						Language.CHN_SIM => "拍击",
						Language.CHN_TRA => "拍擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWDER:
					return lang switch {
						Language.ENG => "Powder",
						Language.JPN => "ふんじん",
						Language.GER => "Pulverschleuder",
						Language.FRE => "Nuée de Poudre",
						Language.ITA => "Pulviscoppio",
						Language.SPN => "Polvo Explosivo",
						Language.KOR => "분진",
						Language.CHN_SIM => "粉尘",
						Language.CHN_TRA => "粉塵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWDER_SNOW:
					return lang switch {
						Language.ENG => "Powder Snow",
						Language.JPN => "こなゆき",
						Language.GER => "Pulverschnee",
						Language.FRE => "Poudreuse",
						Language.ITA => "Polneve",
						Language.SPN => "Nieve Polvo",
						Language.KOR => "눈싸라기",
						Language.CHN_SIM => "细雪",
						Language.CHN_TRA => "細雪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_GEM:
					return lang switch {
						Language.ENG => "Power Gem",
						Language.JPN => "パワージェム",
						Language.GER => "Juwelenkraft",
						Language.FRE => "Rayon Gemme",
						Language.ITA => "Gemmoforza",
						Language.SPN => "Joya de Luz",
						Language.KOR => "파워젬",
						Language.CHN_SIM => "力量宝石",
						Language.CHN_TRA => "力量寶石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_SHIFT:
					return lang switch {
						Language.ENG => "Power Shift",
						Language.JPN => "パワーシフ",
						Language.GER => "Kraftwechsel",
						Language.FRE => "Échange Force",
						Language.ITA => "Scambioforza",
						Language.SPN => "Cambiapoder",
						Language.KOR => "파워시프트",
						Language.CHN_SIM => "力量转换",
						Language.CHN_TRA => "力量轉換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_SPLIT:
					return lang switch {
						Language.ENG => "Power Split",
						Language.JPN => "パワーシェア",
						Language.GER => "Kraftteiler",
						Language.FRE => "Partage Force",
						Language.ITA => "Pariattacco",
						Language.SPN => "Isofuerza",
						Language.KOR => "파워셰어",
						Language.CHN_SIM => "力量平分",
						Language.CHN_TRA => "力量平分",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_SWAP:
					return lang switch {
						Language.ENG => "Power Swap",
						Language.JPN => "パワースワップ",
						Language.GER => "Krafttausch",
						Language.FRE => "Permuforce",
						Language.ITA => "Barattoforza",
						Language.SPN => "Cambia Fuerza",
						Language.KOR => "파워스왑",
						Language.CHN_SIM => "力量互换",
						Language.CHN_TRA => "力量互換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_TRICK:
					return lang switch {
						Language.ENG => "Power Trick",
						Language.JPN => "パワートリック",
						Language.GER => "Krafttrick",
						Language.FRE => "Astuce Force",
						Language.ITA => "Ingannoforza",
						Language.SPN => "Truco Fuerza",
						Language.KOR => "파워트릭",
						Language.CHN_SIM => "力量戏法",
						Language.CHN_TRA => "力量戲法",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_TRIP:
					return lang switch {
						Language.ENG => "Power Trip",
						Language.JPN => "つけあがる",
						Language.GER => "Überheblichkeit",
						Language.FRE => "Arrogance",
						Language.ITA => "Tracotanza",
						Language.SPN => "Chulería",
						Language.KOR => "기어오르기",
						Language.CHN_SIM => "嚣张",
						Language.CHN_TRA => "囂張",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_WHIP:
					return lang switch {
						Language.ENG => "Power Whip",
						Language.JPN => "パワーウィップ",
						Language.GER => "Blattgeißel",
						Language.FRE => "Mégafouet",
						Language.ITA => "Vigorcolpo",
						Language.SPN => "Latigazo",
						Language.KOR => "파워휩",
						Language.CHN_SIM => "强力鞭打",
						Language.CHN_TRA => "強力鞭打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.POWER_UP_PUNCH:
					return lang switch {
						Language.ENG => "Power-Up Punch",
						Language.JPN => "グロウパンチ",
						Language.GER => "Steigerungshieb",
						Language.FRE => "Poing Boost",
						Language.ITA => "Crescipugno",
						Language.SPN => "Puño Incremento",
						Language.KOR => "그로우펀치",
						Language.CHN_SIM => "增强拳",
						Language.CHN_TRA => "增強拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PRECIPICE_BLADES:
					return lang switch {
						Language.ENG => "Precipice Blades",
						Language.JPN => "だんがいのつるぎ",
						Language.GER => "Abgrundsklinge",
						Language.FRE => "Lame Pangéenne",
						Language.ITA => "Spade Telluriche",
						Language.SPN => "Filo del Abismo",
						Language.KOR => "단애의칼",
						Language.CHN_SIM => "断崖之剑",
						Language.CHN_TRA => "斷崖之劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PRESENT:
					return lang switch {
						Language.ENG => "Present",
						Language.JPN => "プレゼント",
						Language.GER => "Geschenk",
						Language.FRE => "Cadeau",
						Language.ITA => "Regalino",
						Language.SPN => "Presente",
						Language.KOR => "프레젠트",
						Language.CHN_SIM => "礼物",
						Language.CHN_TRA => "禮物",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PRISMATIC_LASER:
					return lang switch {
						Language.ENG => "Prismatic Laser",
						Language.JPN => "プリズムレーザー",
						Language.GER => "Prisma-Laser",
						Language.FRE => "Laser Prisme",
						Language.ITA => "Prismalaser",
						Language.SPN => "Láser Prisma",
						Language.KOR => "프리즘레이저",
						Language.CHN_SIM => "棱镜镭射",
						Language.CHN_TRA => "稜鏡鐳射",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PROTECT:
					return lang switch {
						Language.ENG => "Protect",
						Language.JPN => "まもる",
						Language.GER => "Schutzschild",
						Language.FRE => "Abri",
						Language.ITA => "Protezione",
						Language.SPN => "Protección",
						Language.KOR => "방어",
						Language.CHN_SIM => "守住",
						Language.CHN_TRA => "守住",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYBEAM:
					return lang switch {
						Language.ENG => "Psybeam",
						Language.JPN => "サイケこうせん",
						Language.GER => "Psystrahl",
						Language.FRE => "Rafale Psy",
						Language.ITA => "Psicoraggio",
						Language.SPN => "Psicorrayo",
						Language.KOR => "환상빔",
						Language.CHN_SIM => "幻象光线",
						Language.CHN_TRA => "幻象光線",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYBLADE:
					return lang switch {
						Language.ENG => "Psyblade",
						Language.JPN => "サイコブレイ",
						Language.GER => "Psychoschneide",
						Language.FRE => "Lame Psychique",
						Language.ITA => "Psicolama",
						Language.SPN => "Psicohojas",
						Language.KOR => "사이코블레이드",
						Language.CHN_SIM => "精神剑",
						Language.CHN_TRA => "精神劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCH_UP:
					return lang switch {
						Language.ENG => "Psych Up",
						Language.JPN => "じこあんじ",
						Language.GER => "Psycho-Plus",
						Language.FRE => "Boost",
						Language.ITA => "Psicamisù",
						Language.SPN => "Más Psique",
						Language.KOR => "자기암시",
						Language.CHN_SIM => "自我暗示",
						Language.CHN_TRA => "自我暗示",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCHIC:
					return lang switch {
						Language.ENG => "Psychic",
						Language.JPN => "サイコキネシス",
						Language.GER => "Psychokinese",
						Language.FRE => "Psyko",
						Language.ITA => "Psichico",
						Language.SPN => "Psíquico",
						Language.KOR => "사이코키네시스",
						Language.CHN_SIM => "精神强念",
						Language.CHN_TRA => "精神強念",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCHIC_FANGS:
					return lang switch {
						Language.ENG => "Psychic Fangs",
						Language.JPN => "サイコファング",
						Language.GER => "Psychobeißer",
						Language.FRE => "Psycho-Croc",
						Language.ITA => "Psicozanna",
						Language.SPN => "Psicocolmillo",
						Language.KOR => "사이코팽",
						Language.CHN_SIM => "精神之牙",
						Language.CHN_TRA => "精神之牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCHIC_TERRAIN:
					return lang switch {
						Language.ENG => "Psychic Terrain",
						Language.JPN => "サイコフィールド",
						Language.GER => "Psychofeld",
						Language.FRE => "Champ Psychique",
						Language.ITA => "Campo Psichico",
						Language.SPN => "Campo Psíquico",
						Language.KOR => "사이코필드",
						Language.CHN_SIM => "精神场地",
						Language.CHN_TRA => "精神場地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCHO_BOOST:
					return lang switch {
						Language.ENG => "Psycho Boost",
						Language.JPN => "サイコブースト",
						Language.GER => "Psyschub",
						Language.FRE => "Psycho Boost",
						Language.ITA => "Psicoslancio",
						Language.SPN => "Psicoataque",
						Language.KOR => "사이코부스트",
						Language.CHN_SIM => "精神突进",
						Language.CHN_TRA => "精神突進",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCHO_CUT:
					return lang switch {
						Language.ENG => "Psycho Cut",
						Language.JPN => "サイコカッター",
						Language.GER => "Psychoklinge",
						Language.FRE => "Coupe Psycho",
						Language.ITA => "Psicotaglio",
						Language.SPN => "Psicocorte",
						Language.KOR => "사이코커터",
						Language.CHN_SIM => "精神利刃",
						Language.CHN_TRA => "精神利刃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYCHO_SHIFT:
					return lang switch {
						Language.ENG => "Psycho Shift",
						Language.JPN => "サイコシフト",
						Language.GER => "Psybann",
						Language.FRE => "Échange Psy",
						Language.ITA => "Psicotrasfer",
						Language.SPN => "Psicocambio",
						Language.KOR => "사이코시프트",
						Language.CHN_SIM => "精神转移",
						Language.CHN_TRA => "精神轉移",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYSHIELD_BASH:
					return lang switch {
						Language.ENG => "Psyshield Bash",
						Language.JPN => "バリアーラッシ",
						Language.GER => "Barrierenstoß",
						Language.FRE => "Sprint Bouclier",
						Language.ITA => "Barrierassalto",
						Language.SPN => "Asalto Barrera",
						Language.KOR => "배리어러시",
						Language.CHN_SIM => "屏障猛攻",
						Language.CHN_TRA => "屏障猛攻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYSHOCK:
					return lang switch {
						Language.ENG => "Psyshock",
						Language.JPN => "サイコショック",
						Language.GER => "Psychoschock",
						Language.FRE => "Choc Psy",
						Language.ITA => "Psicoshock",
						Language.SPN => "Psicocarga",
						Language.KOR => "사이코쇼크",
						Language.CHN_SIM => "精神冲击",
						Language.CHN_TRA => "精神衝擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYSTRIKE:
					return lang switch {
						Language.ENG => "Psystrike",
						Language.JPN => "サイコブレイク",
						Language.GER => "Psychostoß",
						Language.FRE => "Frappe Psy",
						Language.ITA => "Psicobotta",
						Language.SPN => "Onda Mental",
						Language.KOR => "사이코브레이크",
						Language.CHN_SIM => "精神击破",
						Language.CHN_TRA => "精神擊破",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PSYWAVE:
					return lang switch {
						Language.ENG => "Psywave",
						Language.JPN => "サイコウェーブ",
						Language.GER => "Psywelle",
						Language.FRE => "Vague Psy",
						Language.ITA => "Psiconda",
						Language.SPN => "Psicoonda",
						Language.KOR => "사이코웨이브",
						Language.CHN_SIM => "精神波",
						Language.CHN_TRA => "精神波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PUNISHMENT:
					return lang switch {
						Language.ENG => "Punishment",
						Language.JPN => "おしおき",
						Language.GER => "Strafattacke",
						Language.FRE => "Punition",
						Language.ITA => "Punizione",
						Language.SPN => "Castigo",
						Language.KOR => "혼내기",
						Language.CHN_SIM => "惩罚",
						Language.CHN_TRA => "懲罰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PURIFY:
					return lang switch {
						Language.ENG => "Purify",
						Language.JPN => "じょうか",
						Language.GER => "Läuterung",
						Language.FRE => "Purification",
						Language.ITA => "Purificazione",
						Language.SPN => "Purificación",
						Language.KOR => "정화",
						Language.CHN_SIM => "净化",
						Language.CHN_TRA => "淨化",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PURSUIT:
					return lang switch {
						Language.ENG => "Pursuit",
						Language.JPN => "おいうち",
						Language.GER => "Verfolgung",
						Language.FRE => "Poursuite",
						Language.ITA => "Inseguimento",
						Language.SPN => "Persecución",
						Language.KOR => "따라가때리기",
						Language.CHN_SIM => "追打",
						Language.CHN_TRA => "追打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.PYRO_BALL:
					return lang switch {
						Language.ENG => "Pyro Ball",
						Language.JPN => "かえんボー",
						Language.GER => "Feuerball",
						Language.FRE => "Ballon Brûlant",
						Language.ITA => "Palla Infuocata",
						Language.SPN => "Balón Ígneo",
						Language.KOR => "화염볼",
						Language.CHN_SIM => "火焰球",
						Language.CHN_TRA => "火焰球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.QUASH:
					return lang switch {
						Language.ENG => "Quash",
						Language.JPN => "さきおくり",
						Language.GER => "Verzögerung",
						Language.FRE => "À la Queue",
						Language.ITA => "Spintone",
						Language.SPN => "Último Lugar",
						Language.KOR => "순서미루기",
						Language.CHN_SIM => "延后",
						Language.CHN_TRA => "延後",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.QUICK_ATTACK:
					return lang switch {
						Language.ENG => "Quick Attack",
						Language.JPN => "でんこうせっか",
						Language.GER => "Ruckzuckhieb",
						Language.FRE => "Vive-attaque",
						Language.ITA => "Attacco Rapido",
						Language.SPN => "Ataque Rápido",
						Language.KOR => "전광석화",
						Language.CHN_SIM => "电光一闪",
						Language.CHN_TRA => "電光一閃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.QUICK_GUARD:
					return lang switch {
						Language.ENG => "Quick Guard",
						Language.JPN => "ファストガード",
						Language.GER => "Rapidschutz",
						Language.FRE => "Prévention",
						Language.ITA => "Anticipo",
						Language.SPN => "Anticipo",
						Language.KOR => "패스트가드",
						Language.CHN_SIM => "快速防守",
						Language.CHN_TRA => "快速防守",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.QUIVER_DANCE:
					return lang switch {
						Language.ENG => "Quiver Dance",
						Language.JPN => "ちょうのまい",
						Language.GER => "Falterreigen",
						Language.FRE => "Papillodanse",
						Language.ITA => "Eledanza",
						Language.SPN => "Danza Aleteo",
						Language.KOR => "나비춤",
						Language.CHN_SIM => "蝶舞",
						Language.CHN_TRA => "蝶舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAGE:
					return lang switch {
						Language.ENG => "Rage",
						Language.JPN => "いかり",
						Language.GER => "Raserei",
						Language.FRE => "Frénésie",
						Language.ITA => "Ira",
						Language.SPN => "Furia",
						Language.KOR => "분노",
						Language.CHN_SIM => "愤怒",
						Language.CHN_TRA => "憤怒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAGE_FIST:
					return lang switch {
						Language.ENG => "Rage Fist",
						Language.JPN => "ふんどのこぶ",
						Language.GER => "Zornesfaust",
						Language.FRE => "Poing de Colère",
						Language.ITA => "Pugno Furibondo",
						Language.SPN => "Puño Furia",
						Language.KOR => "분노의주먹",
						Language.CHN_SIM => "愤怒之拳",
						Language.CHN_TRA => "憤怒之拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAGE_POWDER:
					return lang switch {
						Language.ENG => "Rage Powder",
						Language.JPN => "いかりのこな",
						Language.GER => "Wutpulver",
						Language.FRE => "Poudre Fureur",
						Language.ITA => "Polverabbia",
						Language.SPN => "Polvo Ira",
						Language.KOR => "분노가루",
						Language.CHN_SIM => "愤怒粉",
						Language.CHN_TRA => "憤怒粉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAGING_BULL:
					return lang switch {
						Language.ENG => "Raging Bull",
						Language.JPN => "レイジングブ",
						Language.GER => "Rasender Stier",
						Language.FRE => "Taurogne",
						Language.ITA => "Scatenatoro",
						Language.SPN => "Furia Taurina",
						Language.KOR => "레이징불",
						Language.CHN_SIM => "怒牛",
						Language.CHN_TRA => "怒牛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAGING_FURY:
					return lang switch {
						Language.ENG => "Raging Fury",
						Language.JPN => "だいふんげ",
						Language.GER => "Flammenwut",
						Language.FRE => "Grand Courroux",
						Language.ITA => "Ira Furente",
						Language.SPN => "Erupción de Ira",
						Language.KOR => "대격분",
						Language.CHN_SIM => "大愤慨",
						Language.CHN_TRA => "大憤慨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAIN_DANCE:
					return lang switch {
						Language.ENG => "Rain Dance",
						Language.JPN => "あまごい",
						Language.GER => "Regentanz",
						Language.FRE => "Danse Pluie",
						Language.ITA => "Pioggiadanza",
						Language.SPN => "Danza Lluvia",
						Language.KOR => "비바라기",
						Language.CHN_SIM => "求雨",
						Language.CHN_TRA => "求雨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAPID_SPIN:
					return lang switch {
						Language.ENG => "Rapid Spin",
						Language.JPN => "こうそくスピン",
						Language.GER => "Turbodreher",
						Language.FRE => "Tour Rapide",
						Language.ITA => "Rapigiro",
						Language.SPN => "Giro Rápido",
						Language.KOR => "고속스핀",
						Language.CHN_SIM => "高速旋转",
						Language.CHN_TRA => "高速旋轉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAZOR_LEAF:
					return lang switch {
						Language.ENG => "Razor Leaf",
						Language.JPN => "はっぱカッター",
						Language.GER => "Rasierblatt",
						Language.FRE => "Tranch'Herbe",
						Language.ITA => "Foglielama",
						Language.SPN => "Hoja Afilada",
						Language.KOR => "잎날가르기",
						Language.CHN_SIM => "飞叶快刀",
						Language.CHN_TRA => "飛葉快刀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAZOR_SHELL:
					return lang switch {
						Language.ENG => "Razor Shell",
						Language.JPN => "シェルブレード",
						Language.GER => "Kalkklinge",
						Language.FRE => "Coquilame",
						Language.ITA => "Conchilama",
						Language.SPN => "Concha Filo",
						Language.KOR => "셸블레이드",
						Language.CHN_SIM => "贝壳刃",
						Language.CHN_TRA => "貝殼刃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RAZOR_WIND:
					return lang switch {
						Language.ENG => "Razor Wind",
						Language.JPN => "かまいたち",
						Language.GER => "Klingensturm",
						Language.FRE => "Coupe-Vent",
						Language.ITA => "Ventagliente",
						Language.SPN => "Viento Cortante",
						Language.KOR => "칼바람",
						Language.CHN_SIM => "旋风刀",
						Language.CHN_TRA => "旋風刀",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RECOVER:
					return lang switch {
						Language.ENG => "Recover",
						Language.JPN => "じこさいせい",
						Language.GER => "Genesung",
						Language.FRE => "Soin",
						Language.ITA => "Ripresa",
						Language.SPN => "Recuperación",
						Language.KOR => "HP회복",
						Language.CHN_SIM => "自我再生",
						Language.CHN_TRA => "自我再生",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RECYCLE:
					return lang switch {
						Language.ENG => "Recycle",
						Language.JPN => "リサイクル",
						Language.GER => "Aufbereitung",
						Language.FRE => "Recyclage",
						Language.ITA => "Riciclo",
						Language.SPN => "Reciclaje",
						Language.KOR => "리사이클",
						Language.CHN_SIM => "回收利用",
						Language.CHN_TRA => "回收利用",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REFLECT:
					return lang switch {
						Language.ENG => "Reflect",
						Language.JPN => "リフレクター",
						Language.GER => "Reflektor",
						Language.FRE => "Protection",
						Language.ITA => "Riflesso",
						Language.SPN => "Reflejo",
						Language.KOR => "리플렉터",
						Language.CHN_SIM => "反射壁",
						Language.CHN_TRA => "反射壁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REFLECT_TYPE:
					return lang switch {
						Language.ENG => "Reflect Type",
						Language.JPN => "ミラータイプ",
						Language.GER => "Typenspiegel",
						Language.FRE => "Copie Type",
						Language.ITA => "Riflettipo",
						Language.SPN => "Clonatipo",
						Language.KOR => "미러타입",
						Language.CHN_SIM => "镜面属性",
						Language.CHN_TRA => "鏡面屬性",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REFRESH:
					return lang switch {
						Language.ENG => "Refresh",
						Language.JPN => "リフレッシュ",
						Language.GER => "Heilung",
						Language.FRE => "Régénération",
						Language.ITA => "Rinfrescata",
						Language.SPN => "Alivio",
						Language.KOR => "리프레시",
						Language.CHN_SIM => "焕然一新",
						Language.CHN_TRA => "煥然一新",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RELIC_SONG:
					return lang switch {
						Language.ENG => "Relic Song",
						Language.JPN => "いにしえのうた",
						Language.GER => "Urgesang",
						Language.FRE => "Chant Antique",
						Language.ITA => "Cantoantico",
						Language.SPN => "Canto Arcaico",
						Language.KOR => "옛노래",
						Language.CHN_SIM => "古老之歌",
						Language.CHN_TRA => "古老之歌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REST:
					return lang switch {
						Language.ENG => "Rest",
						Language.JPN => "ねむる",
						Language.GER => "Erholung",
						Language.FRE => "Repos",
						Language.ITA => "Riposo",
						Language.SPN => "Descanso",
						Language.KOR => "잠자기",
						Language.CHN_SIM => "睡觉",
						Language.CHN_TRA => "睡覺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RETALIATE:
					return lang switch {
						Language.ENG => "Retaliate",
						Language.JPN => "かたきうち",
						Language.GER => "Heimzahlung",
						Language.FRE => "Vengeance",
						Language.ITA => "Nemesi",
						Language.SPN => "Represalia",
						Language.KOR => "원수갚기",
						Language.CHN_SIM => "报仇",
						Language.CHN_TRA => "報仇",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RETURN:
					return lang switch {
						Language.ENG => "Return",
						Language.JPN => "おんがえし",
						Language.GER => "Rückkehr",
						Language.FRE => "Retour",
						Language.ITA => "Ritorno",
						Language.SPN => "Retribución",
						Language.KOR => "은혜갚기",
						Language.CHN_SIM => "报恩",
						Language.CHN_TRA => "報恩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REVELATION_DANCE:
					return lang switch {
						Language.ENG => "Revelation Dance",
						Language.JPN => "めざめるダンス",
						Language.GER => "Wecktanz",
						Language.FRE => "Danse Éveil",
						Language.ITA => "Mutadanza",
						Language.SPN => "Danza Despertar",
						Language.KOR => "잠재댄스",
						Language.CHN_SIM => "觉醒之舞",
						Language.CHN_TRA => "覺醒之舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REVENGE:
					return lang switch {
						Language.ENG => "Revenge",
						Language.JPN => "リベンジ",
						Language.GER => "Vergeltung",
						Language.FRE => "Vendetta",
						Language.ITA => "Vendetta",
						Language.SPN => "Desquite",
						Language.KOR => "리벤지",
						Language.CHN_SIM => "报复",
						Language.CHN_TRA => "報復",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REVERSAL:
					return lang switch {
						Language.ENG => "Reversal",
						Language.JPN => "きしかいせい",
						Language.GER => "Gegenschlag",
						Language.FRE => "Contre",
						Language.ITA => "Contropiede",
						Language.SPN => "Inversión",
						Language.KOR => "기사회생",
						Language.CHN_SIM => "绝处逢生",
						Language.CHN_TRA => "起死回生",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.REVIVAL_BLESSING:
					return lang switch {
						Language.ENG => "Revival Blessing",
						Language.JPN => "さいきのいの",
						Language.GER => "Vitalsegen",
						Language.FRE => "Second Souffle",
						Language.ITA => "Preghiera Vitale",
						Language.SPN => "Plegaria Vital",
						Language.KOR => "회생의기도",
						Language.CHN_SIM => "复生祈祷",
						Language.CHN_TRA => "復生祈禱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RISING_VOLTAGE:
					return lang switch {
						Language.ENG => "Rising Voltage",
						Language.JPN => "ライジングボル",
						Language.GER => "Hochspannung",
						Language.FRE => "Monte-Tension",
						Language.ITA => "Elettroimpennata",
						Language.SPN => "Alto Voltaje",
						Language.KOR => "라이징볼트",
						Language.CHN_SIM => "电力上升",
						Language.CHN_TRA => "電力上升",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROAR:
					return lang switch {
						Language.ENG => "Roar",
						Language.JPN => "ほえる",
						Language.GER => "Brüller",
						Language.FRE => "Hurlement",
						Language.ITA => "Boato",
						Language.SPN => "Rugido",
						Language.KOR => "울부짖기",
						Language.CHN_SIM => "吼叫",
						Language.CHN_TRA => "吼叫",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROAR_OF_TIME:
					return lang switch {
						Language.ENG => "Roar of Time",
						Language.JPN => "ときのほうこう",
						Language.GER => "Zeitenlärm",
						Language.FRE => "Hurle-Temps",
						Language.ITA => "Fragortempo",
						Language.SPN => "Distorsión",
						Language.KOR => "시간의포효",
						Language.CHN_SIM => "时光咆哮",
						Language.CHN_TRA => "時光咆哮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_BLAST:
					return lang switch {
						Language.ENG => "Rock Blast",
						Language.JPN => "ロックブラスト",
						Language.GER => "Felswurf",
						Language.FRE => "Boule Roc",
						Language.ITA => "Cadutamassi",
						Language.SPN => "Pedrada",
						Language.KOR => "록블라스트",
						Language.CHN_SIM => "岩石爆击",
						Language.CHN_TRA => "岩石爆擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_CLIMB:
					return lang switch {
						Language.ENG => "Rock Climb",
						Language.JPN => "ロッククライム",
						Language.GER => "Kraxler",
						Language.FRE => "Escalade",
						Language.ITA => "Scalaroccia",
						Language.SPN => "Treparrocas",
						Language.KOR => "록클라임",
						Language.CHN_SIM => "攀岩",
						Language.CHN_TRA => "攀岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_POLISH:
					return lang switch {
						Language.ENG => "Rock Polish",
						Language.JPN => "ロックカット",
						Language.GER => "Steinpolitur",
						Language.FRE => "Poliroche",
						Language.ITA => "Lucidatura",
						Language.SPN => "Pulimento",
						Language.KOR => "록커트",
						Language.CHN_SIM => "岩石打磨",
						Language.CHN_TRA => "岩石打磨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_SLIDE:
					return lang switch {
						Language.ENG => "Rock Slide",
						Language.JPN => "いわなだれ",
						Language.GER => "Steinhagel",
						Language.FRE => "Éboulement",
						Language.ITA => "Frana",
						Language.SPN => "Avalancha",
						Language.KOR => "스톤샤워",
						Language.CHN_SIM => "岩崩",
						Language.CHN_TRA => "岩崩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_SMASH:
					return lang switch {
						Language.ENG => "Rock Smash",
						Language.JPN => "いわくだき",
						Language.GER => "Zertrümmerer",
						Language.FRE => "Éclate-Roc",
						Language.ITA => "Spaccaroccia",
						Language.SPN => "Golpe Roca",
						Language.KOR => "바위깨기",
						Language.CHN_SIM => "碎岩",
						Language.CHN_TRA => "碎岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_THROW:
					return lang switch {
						Language.ENG => "Rock Throw",
						Language.JPN => "いわおとし",
						Language.GER => "Steinwurf",
						Language.FRE => "Jet-Pierres",
						Language.ITA => "Sassata",
						Language.SPN => "Lanzarrocas",
						Language.KOR => "돌떨구기",
						Language.CHN_SIM => "落石",
						Language.CHN_TRA => "落石",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_TOMB:
					return lang switch {
						Language.ENG => "Rock Tomb",
						Language.JPN => "がんせきふうじ",
						Language.GER => "Felsgrab",
						Language.FRE => "Tomberoche",
						Language.ITA => "Rocciotomba",
						Language.SPN => "Tumba Rocas",
						Language.KOR => "암석봉인",
						Language.CHN_SIM => "岩石封锁",
						Language.CHN_TRA => "岩石封鎖",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROCK_WRECKER:
					return lang switch {
						Language.ENG => "Rock Wrecker",
						Language.JPN => "がんせきほう",
						Language.GER => "Felswerfer",
						Language.FRE => "Roc-Boulet",
						Language.ITA => "Devastomasso",
						Language.SPN => "Romperrocas",
						Language.KOR => "암석포",
						Language.CHN_SIM => "岩石炮",
						Language.CHN_TRA => "岩石炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROLE_PLAY:
					return lang switch {
						Language.ENG => "Role Play",
						Language.JPN => "なりきり",
						Language.GER => "Rollentausch",
						Language.FRE => "Imitation",
						Language.ITA => "Giocodiruolo",
						Language.SPN => "Imitación",
						Language.KOR => "역할",
						Language.CHN_SIM => "扮演",
						Language.CHN_TRA => "扮演",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROLLING_KICK:
					return lang switch {
						Language.ENG => "Rolling Kick",
						Language.JPN => "まわしげり",
						Language.GER => "Fegekick",
						Language.FRE => "Mawashi Geri",
						Language.ITA => "Calciorullo",
						Language.SPN => "Patada Giro",
						Language.KOR => "돌려차기",
						Language.CHN_SIM => "回旋踢",
						Language.CHN_TRA => "迴旋踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROLLOUT:
					return lang switch {
						Language.ENG => "Rollout",
						Language.JPN => "ころがる",
						Language.GER => "Walzer",
						Language.FRE => "Roulade",
						Language.ITA => "Rotolamento",
						Language.SPN => "Desenrollar",
						Language.KOR => "구르기",
						Language.CHN_SIM => "滚动",
						Language.CHN_TRA => "滾動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROOST:
					return lang switch {
						Language.ENG => "Roost",
						Language.JPN => "はねやすめ",
						Language.GER => "Ruheort",
						Language.FRE => "Atterrissage",
						Language.ITA => "Trespolo",
						Language.SPN => "Respiro",
						Language.KOR => "날개쉬기",
						Language.CHN_SIM => "羽栖",
						Language.CHN_TRA => "羽棲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROTOTILLER:
					return lang switch {
						Language.ENG => "Rototiller",
						Language.JPN => "たがやす",
						Language.GER => "Pflüger",
						Language.FRE => "Fertilisation",
						Language.ITA => "Aracampo",
						Language.SPN => "Fertilizante",
						Language.KOR => "일구기",
						Language.CHN_SIM => "耕地",
						Language.CHN_TRA => "耕地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ROUND:
					return lang switch {
						Language.ENG => "Round",
						Language.JPN => "りんしょう",
						Language.GER => "Kanon",
						Language.FRE => "Chant Canon",
						Language.ITA => "Coro",
						Language.SPN => "Canon",
						Language.KOR => "돌림노래",
						Language.CHN_SIM => "轮唱",
						Language.CHN_TRA => "輪唱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.RUINATION:
					return lang switch {
						Language.ENG => "Ruination",
						Language.JPN => "カタストロフ",
						Language.GER => "Verderben",
						Language.FRE => "Cataclysme",
						Language.ITA => "Catastrofe",
						Language.SPN => "Calamidad",
						Language.KOR => "카타스트로피",
						Language.CHN_SIM => "大灾难",
						Language.CHN_TRA => "大災難",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SACRED_FIRE:
					return lang switch {
						Language.ENG => "Sacred Fire",
						Language.JPN => "せいなるほのお",
						Language.GER => "Läuterfeuer",
						Language.FRE => "Feu Sacré",
						Language.ITA => "Magifuoco",
						Language.SPN => "Fuego Sagrado",
						Language.KOR => "성스러운불꽃",
						Language.CHN_SIM => "神圣之火",
						Language.CHN_TRA => "神聖之火",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SACRED_SWORD:
					return lang switch {
						Language.ENG => "Sacred Sword",
						Language.JPN => "せいなるつるぎ",
						Language.GER => "Sanctoklinge",
						Language.FRE => "Lame Sainte",
						Language.ITA => "Spadasolenne",
						Language.SPN => "Espada Santa",
						Language.KOR => "성스러운칼",
						Language.CHN_SIM => "圣剑",
						Language.CHN_TRA => "聖劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SAFEGUARD:
					return lang switch {
						Language.ENG => "Safeguard",
						Language.JPN => "しんぴのまもり",
						Language.GER => "Bodyguard",
						Language.FRE => "Rune Protect",
						Language.ITA => "Salvaguardia",
						Language.SPN => "Velo Sagrado",
						Language.KOR => "신비의부적",
						Language.CHN_SIM => "神秘守护",
						Language.CHN_TRA => "神秘守護",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SALT_CURE:
					return lang switch {
						Language.ENG => "Salt Cure",
						Language.JPN => "しおづ",
						Language.GER => "Pökelsalz",
						Language.FRE => "Salaison",
						Language.ITA => "Sotto Sale",
						Language.SPN => "Salazón",
						Language.KOR => "소금절이",
						Language.CHN_SIM => "盐腌",
						Language.CHN_TRA => "鹽醃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SAND_ATTACK:
					return lang switch {
						Language.ENG => "Sand Attack",
						Language.JPN => "すなかけ",
						Language.GER => "Sandwirbel",
						Language.FRE => "Jet de Sable",
						Language.ITA => "Turbosabbia",
						Language.SPN => "Ataque Arena",
						Language.KOR => "모래뿌리기",
						Language.CHN_SIM => "泼沙",
						Language.CHN_TRA => "潑沙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SAND_TOMB:
					return lang switch {
						Language.ENG => "Sand Tomb",
						Language.JPN => "すなじごく",
						Language.GER => "Sandgrab",
						Language.FRE => "Tourbi-Sable",
						Language.ITA => "Sabbiotomba",
						Language.SPN => "Bucle Arena",
						Language.KOR => "모래지옥",
						Language.CHN_SIM => "流沙深渊",
						Language.CHN_TRA => "流沙地獄",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SANDSEAR_STORM:
					return lang switch {
						Language.ENG => "Sandsear Storm",
						Language.JPN => "ねっさのあら",
						Language.GER => "Wüstenorkan",
						Language.FRE => "Typhon Pyrosable",
						Language.ITA => "Tempesta Ardente",
						Language.SPN => "Simún de Arena",
						Language.KOR => "열사의폭풍",
						Language.CHN_SIM => "热沙风暴",
						Language.CHN_TRA => "熱沙風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SANDSTORM:
					return lang switch {
						Language.ENG => "Sandstorm",
						Language.JPN => "すなあらし",
						Language.GER => "Sandsturm",
						Language.FRE => "Tempête de Sable",
						Language.ITA => "Terrempesta",
						Language.SPN => "Tormenta Arena",
						Language.KOR => "모래바람",
						Language.CHN_SIM => "沙暴",
						Language.CHN_TRA => "沙暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SCALD:
					return lang switch {
						Language.ENG => "Scald",
						Language.JPN => "ねっとう",
						Language.GER => "Siedewasser",
						Language.FRE => "Ébullition",
						Language.ITA => "Idrovampata",
						Language.SPN => "Escaldar",
						Language.KOR => "열탕",
						Language.CHN_SIM => "热水",
						Language.CHN_TRA => "熱水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SCALE_SHOT:
					return lang switch {
						Language.ENG => "Scale Shot",
						Language.JPN => "スケイルショッ",
						Language.GER => "Schuppenschuss",
						Language.FRE => "Rafale Écailles",
						Language.ITA => "Squamacolpo",
						Language.SPN => "Ráfaga Escamas",
						Language.KOR => "스케일샷",
						Language.CHN_SIM => "鳞射",
						Language.CHN_TRA => "鱗射",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SCARY_FACE:
					return lang switch {
						Language.ENG => "Scary Face",
						Language.JPN => "こわいかお",
						Language.GER => "Grimasse",
						Language.FRE => "Grimace",
						Language.ITA => "Visotruce",
						Language.SPN => "Cara Susto",
						Language.KOR => "겁나는얼굴",
						Language.CHN_SIM => "可怕面孔",
						Language.CHN_TRA => "鬼面",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SCORCHING_SANDS:
					return lang switch {
						Language.ENG => "Scorching Sands",
						Language.JPN => "ねっさのだい",
						Language.GER => "Brandsand",
						Language.FRE => "Sable Ardent",
						Language.ITA => "Sabbiardente",
						Language.SPN => "Arenas Ardientes",
						Language.KOR => "열사의대지",
						Language.CHN_SIM => "热沙大地",
						Language.CHN_TRA => "熱沙大地",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SCRATCH:
					return lang switch {
						Language.ENG => "Scratch",
						Language.JPN => "ひっかく",
						Language.GER => "Kratzer",
						Language.FRE => "Griffe",
						Language.ITA => "Graffio",
						Language.SPN => "Arañazo",
						Language.KOR => "할퀴기",
						Language.CHN_SIM => "抓",
						Language.CHN_TRA => "抓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SCREECH:
					return lang switch {
						Language.ENG => "Screech",
						Language.JPN => "いやなおと",
						Language.GER => "Kreideschrei",
						Language.FRE => "Grincement",
						Language.ITA => "Stridio",
						Language.SPN => "Chirrido",
						Language.KOR => "싫은소리",
						Language.CHN_SIM => "刺耳声",
						Language.CHN_TRA => "刺耳聲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SEARING_SHOT:
					return lang switch {
						Language.ENG => "Searing Shot",
						Language.JPN => "かえんだん",
						Language.GER => "Flammenball",
						Language.FRE => "Incendie",
						Language.ITA => "Sparafuoco",
						Language.SPN => "Bomba Ígnea",
						Language.KOR => "화염탄",
						Language.CHN_SIM => "火焰弹",
						Language.CHN_TRA => "火焰彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SECRET_POWER:
					return lang switch {
						Language.ENG => "Secret Power",
						Language.JPN => "ひみつのちから",
						Language.GER => "Geheimpower",
						Language.FRE => "Force Cachée",
						Language.ITA => "Forzasegreta",
						Language.SPN => "Daño Secreto",
						Language.KOR => "비밀의힘",
						Language.CHN_SIM => "秘密之力",
						Language.CHN_TRA => "秘密之力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SECRET_SWORD:
					return lang switch {
						Language.ENG => "Secret Sword",
						Language.JPN => "しんぴのつるぎ",
						Language.GER => "Mystoschwert",
						Language.FRE => "Lame Ouinte",
						Language.ITA => "Spadamistica",
						Language.SPN => "Sable Místico",
						Language.KOR => "신비의칼",
						Language.CHN_SIM => "神秘之剑",
						Language.CHN_TRA => "神秘之劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SEED_BOMB:
					return lang switch {
						Language.ENG => "Seed Bomb",
						Language.JPN => "タネばくだん",
						Language.GER => "Samenbomben",
						Language.FRE => "Canon Graine",
						Language.ITA => "Semebomba",
						Language.SPN => "Bomba Germen",
						Language.KOR => "씨폭탄",
						Language.CHN_SIM => "种子炸弹",
						Language.CHN_TRA => "種子炸彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SEED_FLARE:
					return lang switch {
						Language.ENG => "Seed Flare",
						Language.JPN => "シードフレア",
						Language.GER => "Schocksamen",
						Language.FRE => "Fulmigraine",
						Language.ITA => "Infuriaseme",
						Language.SPN => "Fogonazo",
						Language.KOR => "시드플레어",
						Language.CHN_SIM => "种子闪光",
						Language.CHN_TRA => "種子閃光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SEISMIC_TOSS:
					return lang switch {
						Language.ENG => "Seismic Toss",
						Language.JPN => "ちきゅうなげ",
						Language.GER => "Geowurf",
						Language.FRE => "Frappe Atlas",
						Language.ITA => "Movim. Sismico",
						Language.SPN => "Mov. Sísmico",
						Language.KOR => "지구던지기",
						Language.CHN_SIM => "地球上投",
						Language.CHN_TRA => "地球上投",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SELF_DESTRUCT:
					return lang switch {
						Language.ENG => "Self-Destruct",
						Language.JPN => "じばく",
						Language.GER => "Finale",
						Language.FRE => "Destruction",
						Language.ITA => "Autodistruz.",
						Language.SPN => "Autodestruc",
						Language.KOR => "자폭",
						Language.CHN_SIM => "玉石俱碎",
						Language.CHN_TRA => "自爆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHADOW_BALL:
					return lang switch {
						Language.ENG => "Shadow Ball",
						Language.JPN => "シャドーボール",
						Language.GER => "Spukball",
						Language.FRE => "Ball'Ombre",
						Language.ITA => "Palla Ombra",
						Language.SPN => "Bola Sombra",
						Language.KOR => "섀도볼",
						Language.CHN_SIM => "暗影球",
						Language.CHN_TRA => "暗影球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHADOW_BONE:
					return lang switch {
						Language.ENG => "Shadow Bone",
						Language.JPN => "シャドーボーン",
						Language.GER => "Schattenknochen",
						Language.FRE => "Os'Ombre",
						Language.ITA => "Ossotetro",
						Language.SPN => "Hueso Sombrío",
						Language.KOR => "섀도본",
						Language.CHN_SIM => "暗影之骨",
						Language.CHN_TRA => "暗影之骨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHADOW_CLAW:
					return lang switch {
						Language.ENG => "Shadow Claw",
						Language.JPN => "シャドークロー",
						Language.GER => "Dunkelklaue",
						Language.FRE => "Griffe Ombre",
						Language.ITA => "Ombrartigli",
						Language.SPN => "Garra Umbría",
						Language.KOR => "섀도클로",
						Language.CHN_SIM => "暗影爪",
						Language.CHN_TRA => "暗影爪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHADOW_FORCE:
					return lang switch {
						Language.ENG => "Shadow Force",
						Language.JPN => "シャドーダイブ",
						Language.GER => "Schemenkraft",
						Language.FRE => "Revenant",
						Language.ITA => "Oscurotuffo",
						Language.SPN => "Golpe Umbrío",
						Language.KOR => "섀도다이브",
						Language.CHN_SIM => "暗影潜袭",
						Language.CHN_TRA => "暗影潛襲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHADOW_PUNCH:
					return lang switch {
						Language.ENG => "Shadow Punch",
						Language.JPN => "シャドーパンチ",
						Language.GER => "Finsterfaust",
						Language.FRE => "Poing Ombre",
						Language.ITA => "Pugnodombra",
						Language.SPN => "Puño Sombra",
						Language.KOR => "섀도펀치",
						Language.CHN_SIM => "暗影拳",
						Language.CHN_TRA => "暗影拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHADOW_SNEAK:
					return lang switch {
						Language.ENG => "Shadow Sneak",
						Language.JPN => "かげうち",
						Language.GER => "Schattenstoß",
						Language.FRE => "Ombre Portée",
						Language.ITA => "Furtivombra",
						Language.SPN => "Sombra Vil",
						Language.KOR => "야습",
						Language.CHN_SIM => "影子偷袭",
						Language.CHN_TRA => "影子偷襲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHARPEN:
					return lang switch {
						Language.ENG => "Sharpen",
						Language.JPN => "かくばる",
						Language.GER => "Schärfer",
						Language.FRE => "Affûtage",
						Language.ITA => "Affilatore",
						Language.SPN => "Afilar",
						Language.KOR => "각지기",
						Language.CHN_SIM => "棱角化",
						Language.CHN_TRA => "稜角化",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHED_TAIL:
					return lang switch {
						Language.ENG => "Shed Tail",
						Language.JPN => "しっぽき",
						Language.GER => "Schwanzabwurf",
						Language.FRE => "Queulonage",
						Language.ITA => "Tagliacoda",
						Language.SPN => "Autotomía",
						Language.KOR => "꼬리자르기",
						Language.CHN_SIM => "断尾",
						Language.CHN_TRA => "斷尾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHEER_COLD:
					return lang switch {
						Language.ENG => "Sheer Cold",
						Language.JPN => "ぜったいれいど",
						Language.GER => "Eiseskälte",
						Language.FRE => "Glaciation",
						Language.ITA => "Purogelo",
						Language.SPN => "Frío Polar",
						Language.KOR => "절대영도",
						Language.CHN_SIM => "绝对零度",
						Language.CHN_TRA => "絕對零度",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHELL_SIDE_ARM:
					return lang switch {
						Language.ENG => "Shell Side Arm",
						Language.JPN => "シェルアーム",
						Language.GER => "Muschelwaffe",
						Language.FRE => "Kokiyarme",
						Language.ITA => "Armaguscio",
						Language.SPN => "Moluscañón",
						Language.KOR => "셸암즈",
						Language.CHN_SIM => "臂贝武器",
						Language.CHN_TRA => "臂貝武器",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHELL_SMASH:
					return lang switch {
						Language.ENG => "Shell Smash",
						Language.JPN => "からをやぶる",
						Language.GER => "Hausbruch",
						Language.FRE => "Exuviation",
						Language.ITA => "Gettaguscio",
						Language.SPN => "Rompecoraza",
						Language.KOR => "껍질깨기",
						Language.CHN_SIM => "破壳",
						Language.CHN_TRA => "破殼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHELL_TRAP:
					return lang switch {
						Language.ENG => "Shell Trap",
						Language.JPN => "トラップシェル",
						Language.GER => "Panzerfalle",
						Language.FRE => "Carapiège",
						Language.ITA => "Gusciotrappola",
						Language.SPN => "Coraza Trampa",
						Language.KOR => "트랩셸",
						Language.CHN_SIM => "陷阱甲壳",
						Language.CHN_TRA => "陷阱甲殼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHELTER:
					return lang switch {
						Language.ENG => "Shelter",
						Language.JPN => "たてこも",
						Language.GER => "Refugium",
						Language.FRE => "Mur Fumigène",
						Language.ITA => "Barricata",
						Language.SPN => "Retracción",
						Language.KOR => "농성",
						Language.CHN_SIM => "闭关",
						Language.CHN_TRA => "閉關",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHIFT_GEAR:
					return lang switch {
						Language.ENG => "Shift Gear",
						Language.JPN => "ギアチェンジ",
						Language.GER => "Gangwechsel",
						Language.FRE => "Changement Vitesse",
						Language.ITA => "Cambiomarcia",
						Language.SPN => "Cambio de Marcha",
						Language.KOR => "기어체인지",
						Language.CHN_SIM => "换档",
						Language.CHN_TRA => "換檔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHOCK_WAVE:
					return lang switch {
						Language.ENG => "Shock Wave",
						Language.JPN => "でんげきは",
						Language.GER => "Schockwelle",
						Language.FRE => "Onde de Choc",
						Language.ITA => "Ondashock",
						Language.SPN => "Onda Voltio",
						Language.KOR => "전격파",
						Language.CHN_SIM => "电击波",
						Language.CHN_TRA => "電擊波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SHORE_UP:
					return lang switch {
						Language.ENG => "Shore Up",
						Language.JPN => "すなあつめ",
						Language.GER => "Sandsammler",
						Language.FRE => "Amass'Sable",
						Language.ITA => "Sabbiaccumulo",
						Language.SPN => "Recogearena",
						Language.KOR => "모래모으기",
						Language.CHN_SIM => "集沙",
						Language.CHN_TRA => "集沙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SIGNAL_BEAM:
					return lang switch {
						Language.ENG => "Signal Beam",
						Language.JPN => "シグナルビーム",
						Language.GER => "Ampelleuchte",
						Language.FRE => "Rayon Signal",
						Language.ITA => "Segnoraggio",
						Language.SPN => "Doble Rayo",
						Language.KOR => "시그널빔",
						Language.CHN_SIM => "信号光束",
						Language.CHN_TRA => "信號光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SILK_TRAP:
					return lang switch {
						Language.ENG => "Silk Trap",
						Language.JPN => "スレッドトラッ",
						Language.GER => "Fadenfalle",
						Language.FRE => "Piège de Fil",
						Language.ITA => "Telatrappola",
						Language.SPN => "Telatrampa",
						Language.KOR => "스레드트랩",
						Language.CHN_SIM => "线阱",
						Language.CHN_TRA => "線阱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SILVER_WIND:
					return lang switch {
						Language.ENG => "Silver Wind",
						Language.JPN => "ぎんいろのかぜ",
						Language.GER => "Silberhauch",
						Language.FRE => "Vent Argenté",
						Language.ITA => "Ventargenteo",
						Language.SPN => "Viento Plata",
						Language.KOR => "은빛바람",
						Language.CHN_SIM => "银色旋风",
						Language.CHN_TRA => "銀色旋風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SIMPLE_BEAM:
					return lang switch {
						Language.ENG => "Simple Beam",
						Language.JPN => "シンプルビーム",
						Language.GER => "Wankelstrahl",
						Language.FRE => "Rayon Simple",
						Language.ITA => "Ondisinvolta",
						Language.SPN => "Onda Simple",
						Language.KOR => "심플빔",
						Language.CHN_SIM => "单纯光束",
						Language.CHN_TRA => "單純光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SING:
					return lang switch {
						Language.ENG => "Sing",
						Language.JPN => "うたう",
						Language.GER => "Gesang",
						Language.FRE => "Berceuse",
						Language.ITA => "Canto",
						Language.SPN => "Canto",
						Language.KOR => "노래하기",
						Language.CHN_SIM => "唱歌",
						Language.CHN_TRA => "唱歌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKETCH:
					return lang switch {
						Language.ENG => "Sketch",
						Language.JPN => "スケッチ",
						Language.GER => "Nachahmer",
						Language.FRE => "Gribouille",
						Language.ITA => "Schizzo",
						Language.SPN => "Esquema",
						Language.KOR => "스케치",
						Language.CHN_SIM => "写生",
						Language.CHN_TRA => "寫生",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKILL_SWAP:
					return lang switch {
						Language.ENG => "Skill Swap",
						Language.JPN => "スキルスワップ",
						Language.GER => "Wertewechsel",
						Language.FRE => "Échange",
						Language.ITA => "Baratto",
						Language.SPN => "Intercambio",
						Language.KOR => "스킬스왑",
						Language.CHN_SIM => "特性互换",
						Language.CHN_TRA => "特性互換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKITTER_SMACK:
					return lang switch {
						Language.ENG => "Skitter Smack",
						Language.JPN => "はいよるいちげ",
						Language.GER => "Krabbelkracher",
						Language.FRE => "Ravage Rampant",
						Language.ITA => "Strisciacolpo",
						Language.SPN => "Golpe Rastrero",
						Language.KOR => "엄습하는일격",
						Language.CHN_SIM => "爬击",
						Language.CHN_TRA => "爬擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKULL_BASH:
					return lang switch {
						Language.ENG => "Skull Bash",
						Language.JPN => "ロケットずつき",
						Language.GER => "Schädelwumme",
						Language.FRE => "Coud'Krâne",
						Language.ITA => "Capocciata",
						Language.SPN => "Cabezazo",
						Language.KOR => "로켓박치기",
						Language.CHN_SIM => "火箭头锤",
						Language.CHN_TRA => "火箭頭錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKY_ATTACK:
					return lang switch {
						Language.ENG => "Sky Attack",
						Language.JPN => "ゴッドバード",
						Language.GER => "Himmelsfeger",
						Language.FRE => "Piqué",
						Language.ITA => "Aeroattacco",
						Language.SPN => "Ataque Aéreo",
						Language.KOR => "불새",
						Language.CHN_SIM => "神鸟猛击",
						Language.CHN_TRA => "神鳥猛擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKY_DROP:
					return lang switch {
						Language.ENG => "Sky Drop",
						Language.JPN => "フリーフォール",
						Language.GER => "Freier Fall",
						Language.FRE => "Chute Libre",
						Language.ITA => "Cadutalibera",
						Language.SPN => "Caída Libre",
						Language.KOR => "프리폴",
						Language.CHN_SIM => "自由落体",
						Language.CHN_TRA => "自由落體",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SKY_UPPERCUT:
					return lang switch {
						Language.ENG => "Sky Uppercut",
						Language.JPN => "スカイアッパー",
						Language.GER => "Himmelhieb",
						Language.FRE => "Stratopercut",
						Language.ITA => "Stramontante",
						Language.SPN => "Gancho Alto",
						Language.KOR => "스카이어퍼",
						Language.CHN_SIM => "冲天拳",
						Language.CHN_TRA => "衝天拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLACK_OFF:
					return lang switch {
						Language.ENG => "Slack Off",
						Language.JPN => "なまける",
						Language.GER => "Tagedieb",
						Language.FRE => "Paresse",
						Language.ITA => "Pigro",
						Language.SPN => "Relajo",
						Language.KOR => "게으름피우기",
						Language.CHN_SIM => "偷懒",
						Language.CHN_TRA => "偷懶",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLAM:
					return lang switch {
						Language.ENG => "Slam",
						Language.JPN => "たたきつける",
						Language.GER => "Slam",
						Language.FRE => "Souplesse",
						Language.ITA => "Schianto",
						Language.SPN => "Atizar",
						Language.KOR => "힘껏치기",
						Language.CHN_SIM => "摔打",
						Language.CHN_TRA => "摔打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLASH:
					return lang switch {
						Language.ENG => "Slash",
						Language.JPN => "きりさく",
						Language.GER => "Schlitzer",
						Language.FRE => "Tranche",
						Language.ITA => "Lacerazione",
						Language.SPN => "Cuchillada",
						Language.KOR => "베어가르기",
						Language.CHN_SIM => "劈开",
						Language.CHN_TRA => "劈開",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLEEP_POWDER:
					return lang switch {
						Language.ENG => "Sleep Powder",
						Language.JPN => "ねむりごな",
						Language.GER => "Schlafpuder",
						Language.FRE => "Poudre Dodo",
						Language.ITA => "Sonnifero",
						Language.SPN => "Somnífero",
						Language.KOR => "수면가루",
						Language.CHN_SIM => "催眠粉",
						Language.CHN_TRA => "催眠粉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLEEP_TALK:
					return lang switch {
						Language.ENG => "Sleep Talk",
						Language.JPN => "ねごと",
						Language.GER => "Schlafrede",
						Language.FRE => "Blabla Dodo",
						Language.ITA => "Sonnolalia",
						Language.SPN => "Sonámbulo",
						Language.KOR => "잠꼬대",
						Language.CHN_SIM => "梦话",
						Language.CHN_TRA => "夢話",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLUDGE:
					return lang switch {
						Language.ENG => "Sludge",
						Language.JPN => "ヘドロこうげき",
						Language.GER => "Schlammbad",
						Language.FRE => "Détritus",
						Language.ITA => "Fango",
						Language.SPN => "Residuos",
						Language.KOR => "오물공격",
						Language.CHN_SIM => "污泥攻击",
						Language.CHN_TRA => "污泥攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLUDGE_BOMB:
					return lang switch {
						Language.ENG => "Sludge Bomb",
						Language.JPN => "ヘドロばくだん",
						Language.GER => "Matschbombe",
						Language.FRE => "Bomb-Beurk",
						Language.ITA => "Fangobomba",
						Language.SPN => "Bomba Lodo",
						Language.KOR => "오물폭탄",
						Language.CHN_SIM => "污泥炸弹",
						Language.CHN_TRA => "污泥炸彈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SLUDGE_WAVE:
					return lang switch {
						Language.ENG => "Sludge Wave",
						Language.JPN => "ヘドロウェーブ",
						Language.GER => "Schlammwoge",
						Language.FRE => "Cradovague",
						Language.ITA => "Fangonda",
						Language.SPN => "Onda Tóxica",
						Language.KOR => "오물웨이브",
						Language.CHN_SIM => "污泥波",
						Language.CHN_TRA => "污泥波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SMACK_DOWN:
					return lang switch {
						Language.ENG => "Smack Down",
						Language.JPN => "うちおとす",
						Language.GER => "Katapult",
						Language.FRE => "Anti-Air",
						Language.ITA => "Abbattimento",
						Language.SPN => "Antiaéreo",
						Language.KOR => "떨어뜨리기",
						Language.CHN_SIM => "击落",
						Language.CHN_TRA => "擊落",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SMART_STRIKE:
					return lang switch {
						Language.ENG => "Smart Strike",
						Language.JPN => "スマートホーン",
						Language.GER => "Schmalhorn",
						Language.FRE => "Estocorne",
						Language.ITA => "Sottilcorno",
						Language.SPN => "Cuerno Certero",
						Language.KOR => "스마트혼",
						Language.CHN_SIM => "修长之角",
						Language.CHN_TRA => "修長之角",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SMELLING_SALTS:
					return lang switch {
						Language.ENG => "Smelling Salts",
						Language.JPN => "きつけ",
						Language.GER => "Riechsalz",
						Language.FRE => "Stimulant",
						Language.ITA => "Maniereforti",
						Language.SPN => "Estímulo",
						Language.KOR => "정신차리기",
						Language.CHN_SIM => "清醒",
						Language.CHN_TRA => "清醒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SMOG:
					return lang switch {
						Language.ENG => "Smog",
						Language.JPN => "スモッグ",
						Language.GER => "Smog",
						Language.FRE => "Purédpois",
						Language.ITA => "Smog",
						Language.SPN => "Polución",
						Language.KOR => "스모그",
						Language.CHN_SIM => "浊雾",
						Language.CHN_TRA => "濁霧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SMOKESCREEN:
					return lang switch {
						Language.ENG => "Smokescreen",
						Language.JPN => "えんまく",
						Language.GER => "Rauchwolke",
						Language.FRE => "Brouillard",
						Language.ITA => "Muro di Fumo",
						Language.SPN => "Pantalla Humo",
						Language.KOR => "연막",
						Language.CHN_SIM => "烟幕",
						Language.CHN_TRA => "煙幕",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SNAP_TRAP:
					return lang switch {
						Language.ENG => "Snap Trap",
						Language.JPN => "トラバサ",
						Language.GER => "Fangeisen",
						Language.FRE => "Troquenard",
						Language.ITA => "Tagliola",
						Language.SPN => "Cepo",
						Language.KOR => "집게덫",
						Language.CHN_SIM => "捕兽夹",
						Language.CHN_TRA => "捕獸夾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SNARL:
					return lang switch {
						Language.ENG => "Snarl",
						Language.JPN => "バークアウト",
						Language.GER => "Standpauke",
						Language.FRE => "Aboiement",
						Language.ITA => "Urlorabbia",
						Language.SPN => "Alarido",
						Language.KOR => "바크아웃",
						Language.CHN_SIM => "大声咆哮",
						Language.CHN_TRA => "大聲咆哮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SNATCH:
					return lang switch {
						Language.ENG => "Snatch",
						Language.JPN => "よこどり",
						Language.GER => "Übernahme",
						Language.FRE => "Saisie",
						Language.ITA => "Scippo",
						Language.SPN => "Robo",
						Language.KOR => "가로채기",
						Language.CHN_SIM => "化为己用",
						Language.CHN_TRA => "搶奪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SNIPE_SHOT:
					return lang switch {
						Language.ENG => "Snipe Shot",
						Language.JPN => "ねらいう",
						Language.GER => "Präzisionsschuss",
						Language.FRE => "Tir de Précision",
						Language.ITA => "Tiromirato",
						Language.SPN => "Disparo Certero",
						Language.KOR => "노려맞히기",
						Language.CHN_SIM => "狙击",
						Language.CHN_TRA => "狙擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SNORE:
					return lang switch {
						Language.ENG => "Snore",
						Language.JPN => "いびき",
						Language.GER => "Schnarcher",
						Language.FRE => "Ronflement",
						Language.ITA => "Russare",
						Language.SPN => "Ronquido",
						Language.KOR => "코골기",
						Language.CHN_SIM => "打鼾",
						Language.CHN_TRA => "打鼾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SNOWSCAPE:
					return lang switch {
						Language.ENG => "Snowscape",
						Language.JPN => "ゆきげし",
						Language.GER => "Schneelandschaft",
						Language.FRE => "Chute de Neige",
						Language.ITA => "Vista Innevata",
						Language.SPN => "Paisaje Nevado",
						Language.KOR => "설경",
						Language.CHN_SIM => "雪景",
						Language.CHN_TRA => "雪景",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SOAK:
					return lang switch {
						Language.ENG => "Soak",
						Language.JPN => "みずびたし",
						Language.GER => "Überflutung",
						Language.FRE => "Détrempage",
						Language.ITA => "Inondazione",
						Language.SPN => "Anegar",
						Language.KOR => "물붓기",
						Language.CHN_SIM => "浸水",
						Language.CHN_TRA => "浸水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SOFT_BOILED:
					return lang switch {
						Language.ENG => "Soft-Boiled",
						Language.JPN => "タマゴうみ",
						Language.GER => "Weichei",
						Language.FRE => "E-Coque",
						Language.ITA => "Covauova",
						Language.SPN => "Amortiguador",
						Language.KOR => "알낳기",
						Language.CHN_SIM => "生蛋",
						Language.CHN_TRA => "生蛋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SOLAR_BEAM:
					return lang switch {
						Language.ENG => "Solar Beam",
						Language.JPN => "ソーラービーム",
						Language.GER => "Solarstrahl",
						Language.FRE => "Lance-Soleil",
						Language.ITA => "Solarraggio",
						Language.SPN => "Rayo Solar",
						Language.KOR => "솔라빔",
						Language.CHN_SIM => "日光束",
						Language.CHN_TRA => "日光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SOLAR_BLADE:
					return lang switch {
						Language.ENG => "Solar Blade",
						Language.JPN => "ソーラーブレード",
						Language.GER => "Solarklinge",
						Language.FRE => "Lame Solaire",
						Language.ITA => "Lama Solare",
						Language.SPN => "Cuchilla Solar",
						Language.KOR => "솔라블레이드",
						Language.CHN_SIM => "日光刃",
						Language.CHN_TRA => "日光刃",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SONIC_BOOM:
					return lang switch {
						Language.ENG => "Sonic Boom",
						Language.JPN => "ソニックブーム",
						Language.GER => "Ultraschall",
						Language.FRE => "Sonicboom",
						Language.ITA => "Sonicboom",
						Language.SPN => "Bomba Sónica",
						Language.KOR => "소닉붐",
						Language.CHN_SIM => "音爆",
						Language.CHN_TRA => "音爆",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPACIAL_REND:
					return lang switch {
						Language.ENG => "Spacial Rend",
						Language.JPN => "あくうせつだん",
						Language.GER => "Raumschlag",
						Language.FRE => "Spatio-Rift",
						Language.ITA => "Fendispazio",
						Language.SPN => "Corte Vacío",
						Language.KOR => "공간절단",
						Language.CHN_SIM => "亚空裂斩",
						Language.CHN_TRA => "亞空裂斬",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPARK:
					return lang switch {
						Language.ENG => "Spark",
						Language.JPN => "スパーク",
						Language.GER => "Funkensprung",
						Language.FRE => "Étincelle",
						Language.ITA => "Scintilla",
						Language.SPN => "Chispa",
						Language.KOR => "스파크",
						Language.CHN_SIM => "电光",
						Language.CHN_TRA => "電光",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPARKLING_ARIA:
					return lang switch {
						Language.ENG => "Sparkling Aria",
						Language.JPN => "うたかたのアリア",
						Language.GER => "Schaumserenade",
						Language.FRE => "Aria de l'Écume",
						Language.ITA => "Canto Effimero",
						Language.SPN => "Aria Burbuja",
						Language.KOR => "물거품아리아",
						Language.CHN_SIM => "泡影的咏叹调",
						Language.CHN_TRA => "泡影的詠歎調",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPECTRAL_THIEF:
					return lang switch {
						Language.ENG => "Spectral Thief",
						Language.JPN => "シャドースチール",
						Language.GER => "Diebesschatten",
						Language.FRE => "Clepto-Mânes",
						Language.ITA => "Ombrafurto",
						Language.SPN => "Robasombra",
						Language.KOR => "섀도스틸",
						Language.CHN_SIM => "暗影偷盗",
						Language.CHN_TRA => "暗影偷盜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPEED_SWAP:
					return lang switch {
						Language.ENG => "Speed Swap",
						Language.JPN => "スピードスワップ",
						Language.GER => "Initiativetausch",
						Language.FRE => "Permuvitesse",
						Language.ITA => "Velociscambio",
						Language.SPN => "Cambia Velocidad",
						Language.KOR => "스피드스왑",
						Language.CHN_SIM => "速度互换",
						Language.CHN_TRA => "速度互換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPICY_EXTRACT:
					return lang switch {
						Language.ENG => "Spicy Extract",
						Language.JPN => "ハバネロエキ",
						Language.GER => "Chili-Essenz",
						Language.FRE => "Habanerage",
						Language.ITA => "Essenza Piccante",
						Language.SPN => "Extracto Picante",
						Language.KOR => "하바네로엑기스",
						Language.CHN_SIM => "辣椒精华",
						Language.CHN_TRA => "辣椒精華",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIDER_WEB:
					return lang switch {
						Language.ENG => "Spider Web",
						Language.JPN => "クモのす",
						Language.GER => "Spinnennetz",
						Language.FRE => "Toile",
						Language.ITA => "Ragnatela",
						Language.SPN => "Telaraña",
						Language.KOR => "거미집",
						Language.CHN_SIM => "蛛网",
						Language.CHN_TRA => "蛛網",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIKE_CANNON:
					return lang switch {
						Language.ENG => "Spike Cannon",
						Language.JPN => "とげキャノン",
						Language.GER => "Dornkanone",
						Language.FRE => "Picanon",
						Language.ITA => "Sparalance",
						Language.SPN => "Clavo Cañón",
						Language.KOR => "가시대포",
						Language.CHN_SIM => "尖刺加农炮",
						Language.CHN_TRA => "尖刺加農炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIKES:
					return lang switch {
						Language.ENG => "Spikes",
						Language.JPN => "まきびし",
						Language.GER => "Stachler",
						Language.FRE => "Picots",
						Language.ITA => "Punte",
						Language.SPN => "Púas",
						Language.KOR => "압정뿌리기",
						Language.CHN_SIM => "撒菱",
						Language.CHN_TRA => "撒菱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIKY_SHIELD:
					return lang switch {
						Language.ENG => "Spiky Shield",
						Language.JPN => "ニードルガード",
						Language.GER => "Schutzstacheln",
						Language.FRE => "Pico-Défense",
						Language.ITA => "Agodifesa",
						Language.SPN => "Barrera Espinosa",
						Language.KOR => "니들가드",
						Language.CHN_SIM => "尖刺防守",
						Language.CHN_TRA => "尖刺防守",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIN_OUT:
					return lang switch {
						Language.ENG => "Spin Out",
						Language.JPN => "ホイールスピ",
						Language.GER => "Reifendrehung",
						Language.FRE => "Dérapage",
						Language.ITA => "Slittaruote",
						Language.SPN => "Quemarrueda",
						Language.KOR => "휠스핀",
						Language.CHN_SIM => "疾速转轮",
						Language.CHN_TRA => "疾速轉輪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIRIT_BREAK:
					return lang switch {
						Language.ENG => "Spirit Break",
						Language.JPN => "ソウルクラッシ",
						Language.GER => "Seelenbruch",
						Language.FRE => "Choc Émotionnel",
						Language.ITA => "Frantumanima",
						Language.SPN => "Choque Anímico",
						Language.KOR => "소울크래시",
						Language.CHN_SIM => "灵魂冲击",
						Language.CHN_TRA => "靈魂衝擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIRIT_SHACKLE:
					return lang switch {
						Language.ENG => "Spirit Shackle",
						Language.JPN => "かげぬい",
						Language.GER => "Schattenfessel",
						Language.FRE => "Tisse Ombre",
						Language.ITA => "Cucitura d'Ombra",
						Language.SPN => "Puntada Sombría",
						Language.KOR => "그림자꿰매기",
						Language.CHN_SIM => "缝影",
						Language.CHN_TRA => "縫影",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPIT_UP:
					return lang switch {
						Language.ENG => "Spit Up",
						Language.JPN => "はきだす",
						Language.GER => "Entfessler",
						Language.FRE => "Relâche",
						Language.ITA => "Sfoghenergia",
						Language.SPN => "Escupir",
						Language.KOR => "토해내기",
						Language.CHN_SIM => "喷出",
						Language.CHN_TRA => "噴出",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPITE:
					return lang switch {
						Language.ENG => "Spite",
						Language.JPN => "うらみ",
						Language.GER => "Groll",
						Language.FRE => "Dépit",
						Language.ITA => "Dispetto",
						Language.SPN => "Rencor",
						Language.KOR => "원한",
						Language.CHN_SIM => "怨恨",
						Language.CHN_TRA => "怨恨",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPLASH:
					return lang switch {
						Language.ENG => "Splash",
						Language.JPN => "はねる",
						Language.GER => "Platscher",
						Language.FRE => "Trempette",
						Language.ITA => "Splash",
						Language.SPN => "Salpicadura",
						Language.KOR => "튀어오르기",
						Language.CHN_SIM => "跃起",
						Language.CHN_TRA => "躍起",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPORE:
					return lang switch {
						Language.ENG => "Spore",
						Language.JPN => "キノコのほうし",
						Language.GER => "Pilzspore",
						Language.FRE => "Spore",
						Language.ITA => "Spora",
						Language.SPN => "Espora",
						Language.KOR => "버섯포자",
						Language.CHN_SIM => "蘑菇孢子",
						Language.CHN_TRA => "蘑菇孢子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPOTLIGHT:
					return lang switch {
						Language.ENG => "Spotlight",
						Language.JPN => "スポットライト",
						Language.GER => "Rampenlicht",
						Language.FRE => "Projecteur",
						Language.ITA => "Riflettore",
						Language.SPN => "Foco",
						Language.KOR => "스포트라이트",
						Language.CHN_SIM => "聚光灯",
						Language.CHN_TRA => "聚光燈",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SPRINGTIDE_STORM:
					return lang switch {
						Language.ENG => "Springtide Storm",
						Language.JPN => "はるのあら",
						Language.GER => "Frühlingsorkan",
						Language.FRE => "Typhon Passionné",
						Language.ITA => "Tempesta Zefirea",
						Language.SPN => "Ciclón Primavera",
						Language.KOR => "봄의폭풍",
						Language.CHN_SIM => "阳春风暴",
						Language.CHN_TRA => "陽春風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STEALTH_ROCK:
					return lang switch {
						Language.ENG => "Stealth Rock",
						Language.JPN => "ステルスロック",
						Language.GER => "Tarnsteine",
						Language.FRE => "Piège de Roc",
						Language.ITA => "Levitoroccia",
						Language.SPN => "Trampa Rocas",
						Language.KOR => "스텔스록",
						Language.CHN_SIM => "隐形岩",
						Language.CHN_TRA => "隱形岩",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STEAM_ERUPTION:
					return lang switch {
						Language.ENG => "Steam Eruption",
						Language.JPN => "スチームバースト",
						Language.GER => "Dampfschwall",
						Language.FRE => "Jet de Vapeur",
						Language.ITA => "Vaporscoppio",
						Language.SPN => "Chorro de Vapor",
						Language.KOR => "스팀버스트",
						Language.CHN_SIM => "蒸汽爆炸",
						Language.CHN_TRA => "蒸汽爆炸",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STEAMROLLER:
					return lang switch {
						Language.ENG => "Steamroller",
						Language.JPN => "ハードローラー",
						Language.GER => "Quetschwalze",
						Language.FRE => "Bulldoboule",
						Language.ITA => "Rulloduro",
						Language.SPN => "Rodillo Púas",
						Language.KOR => "하드롤러",
						Language.CHN_SIM => "疯狂滚压",
						Language.CHN_TRA => "瘋狂滾壓",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STEEL_BEAM:
					return lang switch {
						Language.ENG => "Steel Beam",
						Language.JPN => "てっていこうせ",
						Language.GER => "Stahlstrahl",
						Language.FRE => "Métalaser",
						Language.ITA => "Raggio d’Acciaio",
						Language.SPN => "Metaláser",
						Language.KOR => "철제광선",
						Language.CHN_SIM => "铁蹄光线",
						Language.CHN_TRA => "鐵蹄光線",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STEEL_ROLLER:
					return lang switch {
						Language.ENG => "Steel Roller",
						Language.JPN => "アイアンローラ",
						Language.GER => "Eisenwalze",
						Language.FRE => "Métalliroue",
						Language.ITA => "Ferrorullo",
						Language.SPN => "Allanador Férreo",
						Language.KOR => "아이언롤러",
						Language.CHN_SIM => "铁滚轮",
						Language.CHN_TRA => "鐵滾輪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STEEL_WING:
					return lang switch {
						Language.ENG => "Steel Wing",
						Language.JPN => "はがねのつばさ",
						Language.GER => "Stahlflügel",
						Language.FRE => "Aile d'Acier",
						Language.ITA => "Alacciaio",
						Language.SPN => "Ala De Acero",
						Language.KOR => "강철날개",
						Language.CHN_SIM => "钢翼",
						Language.CHN_TRA => "鋼翼",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STICKY_WEB:
					return lang switch {
						Language.ENG => "Sticky Web",
						Language.JPN => "ねばねばネット",
						Language.GER => "Klebenetz",
						Language.FRE => "Toile Gluante",
						Language.ITA => "Rete Vischiosa",
						Language.SPN => "Red Viscosa",
						Language.KOR => "끈적끈적네트",
						Language.CHN_SIM => "黏黏网",
						Language.CHN_TRA => "黏黏網",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STOCKPILE:
					return lang switch {
						Language.ENG => "Stockpile",
						Language.JPN => "たくわえる",
						Language.GER => "Horter",
						Language.FRE => "Stockage",
						Language.ITA => "Accumulo",
						Language.SPN => "Reserva",
						Language.KOR => "비축하기",
						Language.CHN_SIM => "蓄力",
						Language.CHN_TRA => "蓄力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STOMP:
					return lang switch {
						Language.ENG => "Stomp",
						Language.JPN => "ふみつけ",
						Language.GER => "Stampfer",
						Language.FRE => "Écrasement",
						Language.ITA => "Pestone",
						Language.SPN => "Pisotón",
						Language.KOR => "짓밟기",
						Language.CHN_SIM => "踩踏",
						Language.CHN_TRA => "踩踏",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STOMPING_TANTRUM:
					return lang switch {
						Language.ENG => "Stomping Tantrum",
						Language.JPN => "じたんだ",
						Language.GER => "Fruststampfer",
						Language.FRE => "Trépignement",
						Language.ITA => "Battipiedi",
						Language.SPN => "Pataleta",
						Language.KOR => "분함의발구르기",
						Language.CHN_SIM => "跺脚",
						Language.CHN_TRA => "跺腳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STONE_AXE:
					return lang switch {
						Language.ENG => "Stone Axe",
						Language.JPN => "がんせきアック",
						Language.GER => "Felsaxt",
						Language.FRE => "Hache de Pierre",
						Language.ITA => "Rocciascure",
						Language.SPN => "Hachazo Pétreo",
						Language.KOR => "암석액스",
						Language.CHN_SIM => "岩斧",
						Language.CHN_TRA => "岩斧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STONE_EDGE:
					return lang switch {
						Language.ENG => "Stone Edge",
						Language.JPN => "ストーンエッジ",
						Language.GER => "Steinkante",
						Language.FRE => "Lame de Roc",
						Language.ITA => "Pietrataglio",
						Language.SPN => "Roca Afilada",
						Language.KOR => "스톤에지",
						Language.CHN_SIM => "尖石攻击",
						Language.CHN_TRA => "尖石攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STORED_POWER:
					return lang switch {
						Language.ENG => "Stored Power",
						Language.JPN => "アシストパワー",
						Language.GER => "Kraftvorrat",
						Language.FRE => "Force Ajoutée",
						Language.ITA => "Veicolaforza",
						Language.SPN => "Poder Reserva",
						Language.KOR => "어시스트파워",
						Language.CHN_SIM => "辅助力量",
						Language.CHN_TRA => "輔助力量",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STORM_THROW:
					return lang switch {
						Language.ENG => "Storm Throw",
						Language.JPN => "やまあらし",
						Language.GER => "Bergsturm",
						Language.FRE => "Yama Arashi",
						Language.ITA => "Tempestretta",
						Language.SPN => "Llave Corsé",
						Language.KOR => "업어후리기",
						Language.CHN_SIM => "山岚摔",
						Language.CHN_TRA => "山嵐摔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STRANGE_STEAM:
					return lang switch {
						Language.ENG => "Strange Steam",
						Language.JPN => "ワンダースチー",
						Language.GER => "Wunderdampf",
						Language.FRE => "Vapeur Féérique",
						Language.ITA => "Vapore Incantato",
						Language.SPN => "Cautivapor",
						Language.KOR => "원더스팀",
						Language.CHN_SIM => "神奇蒸汽",
						Language.CHN_TRA => "神奇蒸汽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STRENGTH:
					return lang switch {
						Language.ENG => "Strength",
						Language.JPN => "かいりき",
						Language.GER => "Stärke",
						Language.FRE => "Force",
						Language.ITA => "Forza",
						Language.SPN => "Fuerza",
						Language.KOR => "괴력",
						Language.CHN_SIM => "怪力",
						Language.CHN_TRA => "怪力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STRENGTH_SAP:
					return lang switch {
						Language.ENG => "Strength Sap",
						Language.JPN => "ちからをすいとる",
						Language.GER => "Kraftabsorber",
						Language.FRE => "Vol-Force",
						Language.ITA => "Assorbiforza",
						Language.SPN => "Absorbefuerza",
						Language.KOR => "힘흡수",
						Language.CHN_SIM => "吸取力量",
						Language.CHN_TRA => "吸取力量",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STRING_SHOT:
					return lang switch {
						Language.ENG => "String Shot",
						Language.JPN => "いとをはく",
						Language.GER => "Fadenschuss",
						Language.FRE => "Sécrétion",
						Language.ITA => "Millebave",
						Language.SPN => "Disp. Demora",
						Language.KOR => "실뿜기",
						Language.CHN_SIM => "吐丝",
						Language.CHN_TRA => "吐絲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STRUGGLE:
					return lang switch {
						Language.ENG => "Struggle",
						Language.JPN => "わるあがき",
						Language.GER => "Verzweifler",
						Language.FRE => "Lutte",
						Language.ITA => "Scontro",
						Language.SPN => "Forcejeo",
						Language.KOR => "발버둥",
						Language.CHN_SIM => "挣扎",
						Language.CHN_TRA => "掙扎",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STRUGGLE_BUG:
					return lang switch {
						Language.ENG => "Struggle Bug",
						Language.JPN => "むしのていこう",
						Language.GER => "Käfertrutz",
						Language.FRE => "Survinsecte",
						Language.ITA => "Entomoblocco",
						Language.SPN => "Estoicismo",
						Language.KOR => "벌레의저항",
						Language.CHN_SIM => "虫之抵抗",
						Language.CHN_TRA => "蟲之抵抗",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STUFF_CHEEKS:
					return lang switch {
						Language.ENG => "Stuff Cheeks",
						Language.JPN => "ほおば",
						Language.GER => "Backenstopfer",
						Language.FRE => "Garde-à-Joues",
						Language.ITA => "Riempiguance",
						Language.SPN => "Atiborramiento",
						Language.KOR => "볼가득넣기",
						Language.CHN_SIM => "大快朵颐",
						Language.CHN_TRA => "大快朵頤",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.STUN_SPORE:
					return lang switch {
						Language.ENG => "Stun Spore",
						Language.JPN => "しびれごな",
						Language.GER => "Stachelspore",
						Language.FRE => "Para-Spore",
						Language.ITA => "Paralizzante",
						Language.SPN => "Paralizador",
						Language.KOR => "저리가루",
						Language.CHN_SIM => "麻痹粉",
						Language.CHN_TRA => "麻痺粉",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUBMISSION:
					return lang switch {
						Language.ENG => "Submission",
						Language.JPN => "じごくぐるま",
						Language.GER => "Überroller",
						Language.FRE => "Sacrifice",
						Language.ITA => "Sottomissione",
						Language.SPN => "Sumisión",
						Language.KOR => "지옥의바퀴",
						Language.CHN_SIM => "深渊翻滚",
						Language.CHN_TRA => "地獄翻滾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUBSTITUTE:
					return lang switch {
						Language.ENG => "Substitute",
						Language.JPN => "みがわり",
						Language.GER => "Delegator",
						Language.FRE => "Clonage",
						Language.ITA => "Sostituto",
						Language.SPN => "Sustituto",
						Language.KOR => "대타출동",
						Language.CHN_SIM => "替身",
						Language.CHN_TRA => "替身",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUCKER_PUNCH:
					return lang switch {
						Language.ENG => "Sucker Punch",
						Language.JPN => "ふいうち",
						Language.GER => "Tiefschlag",
						Language.FRE => "Coup Bas",
						Language.ITA => "Sbigoattacco",
						Language.SPN => "Golpe Bajo",
						Language.KOR => "기습",
						Language.CHN_SIM => "突袭",
						Language.CHN_TRA => "突襲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUNNY_DAY:
					return lang switch {
						Language.ENG => "Sunny Day",
						Language.JPN => "にほんばれ",
						Language.GER => "Sonnentag",
						Language.FRE => "Zénith",
						Language.ITA => "Giornodisole",
						Language.SPN => "Día Soleado",
						Language.KOR => "쾌청",
						Language.CHN_SIM => "大晴天",
						Language.CHN_TRA => "大晴天",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUNSTEEL_STRIKE:
					return lang switch {
						Language.ENG => "Sunsteel Strike",
						Language.JPN => "メテオドライブ",
						Language.GER => "Stahlgestirn",
						Language.FRE => "Choc Météore",
						Language.ITA => "Astrocarica",
						Language.SPN => "Meteoimpacto",
						Language.KOR => "메테오드라이브",
						Language.CHN_SIM => "流星闪冲",
						Language.CHN_TRA => "流星閃衝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUPER_FANG:
					return lang switch {
						Language.ENG => "Super Fang",
						Language.JPN => "いかりのまえば",
						Language.GER => "Superzahn",
						Language.FRE => "Croc Fatal",
						Language.ITA => "Superzanna",
						Language.SPN => "Superdiente",
						Language.KOR => "분노의앞니",
						Language.CHN_SIM => "愤怒门牙",
						Language.CHN_TRA => "憤怒門牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUPERPOWER:
					return lang switch {
						Language.ENG => "Superpower",
						Language.JPN => "ばかぢから",
						Language.GER => "Kraftkoloss",
						Language.FRE => "Surpuissance",
						Language.ITA => "Troppoforte",
						Language.SPN => "Fuerza Bruta",
						Language.KOR => "엄청난힘",
						Language.CHN_SIM => "蛮力",
						Language.CHN_TRA => "蠻力",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SUPERSONIC:
					return lang switch {
						Language.ENG => "Supersonic",
						Language.JPN => "ちょうおんぱ",
						Language.GER => "Superschall",
						Language.FRE => "Ultrason",
						Language.ITA => "Supersuono",
						Language.SPN => "Supersónico",
						Language.KOR => "초음파",
						Language.CHN_SIM => "超音波",
						Language.CHN_TRA => "超音波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SURF:
					return lang switch {
						Language.ENG => "Surf",
						Language.JPN => "なみのり",
						Language.GER => "Surfer",
						Language.FRE => "Surf",
						Language.ITA => "Surf",
						Language.SPN => "Surf",
						Language.KOR => "파도타기",
						Language.CHN_SIM => "冲浪",
						Language.CHN_TRA => "衝浪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SURGING_STRIKES:
					return lang switch {
						Language.ENG => "Surging Strikes",
						Language.JPN => "すいりゅうれん",
						Language.GER => "Trefferschwall",
						Language.FRE => "Torrent de Coups",
						Language.ITA => "Idroraffica",
						Language.SPN => "Azote Torrencial",
						Language.KOR => "수류연타",
						Language.CHN_SIM => "水流连打",
						Language.CHN_TRA => "水流連打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWAGGER:
					return lang switch {
						Language.ENG => "Swagger",
						Language.JPN => "いばる",
						Language.GER => "Angeberei",
						Language.FRE => "Vantardise",
						Language.ITA => "Bullo",
						Language.SPN => "Contoneo",
						Language.KOR => "뽐내기",
						Language.CHN_SIM => "虚张声势",
						Language.CHN_TRA => "虛張聲勢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWALLOW:
					return lang switch {
						Language.ENG => "Swallow",
						Language.JPN => "のみこむ",
						Language.GER => "Verzehrer",
						Language.FRE => "Avale",
						Language.ITA => "Intoenergia",
						Language.SPN => "Tragar",
						Language.KOR => "꿀꺽",
						Language.CHN_SIM => "吞下",
						Language.CHN_TRA => "吞下",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWEET_KISS:
					return lang switch {
						Language.ENG => "Sweet Kiss",
						Language.JPN => "てんしのキッス",
						Language.GER => "Bitterkuss",
						Language.FRE => "Doux Baiser",
						Language.ITA => "Dolcebacio",
						Language.SPN => "Beso Dulce",
						Language.KOR => "천사의키스",
						Language.CHN_SIM => "天使之吻",
						Language.CHN_TRA => "天使之吻",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWEET_SCENT:
					return lang switch {
						Language.ENG => "Sweet Scent",
						Language.JPN => "あまいかおり",
						Language.GER => "Lockduft",
						Language.FRE => "Doux Parfum",
						Language.ITA => "Profumino",
						Language.SPN => "Dulce Aroma",
						Language.KOR => "달콤한향기",
						Language.CHN_SIM => "甜甜香气",
						Language.CHN_TRA => "甜甜香氣",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWIFT:
					return lang switch {
						Language.ENG => "Swift",
						Language.JPN => "スピードスター",
						Language.GER => "Sternschauer",
						Language.FRE => "Météores",
						Language.ITA => "Comete",
						Language.SPN => "Rapidez",
						Language.KOR => "스피드스타",
						Language.CHN_SIM => "高速星星",
						Language.CHN_TRA => "高速星星",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWITCHEROO:
					return lang switch {
						Language.ENG => "Switcheroo",
						Language.JPN => "すりかえ",
						Language.GER => "Wechseldich",
						Language.FRE => "Passe-Passe",
						Language.ITA => "Rapidscambio",
						Language.SPN => "Trapicheo",
						Language.KOR => "바꿔치기",
						Language.CHN_SIM => "掉包",
						Language.CHN_TRA => "掉包",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SWORDS_DANCE:
					return lang switch {
						Language.ENG => "Swords Dance",
						Language.JPN => "つるぎのまい",
						Language.GER => "Schwerttanz",
						Language.FRE => "Danse-Lames",
						Language.ITA => "Danzaspada",
						Language.SPN => "Danza Espada",
						Language.KOR => "칼춤",
						Language.CHN_SIM => "剑舞",
						Language.CHN_TRA => "劍舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SYNCHRONOISE:
					return lang switch {
						Language.ENG => "Synchronoise",
						Language.JPN => "シンクロノイズ",
						Language.GER => "Synchrolärm",
						Language.FRE => "Synchropeine",
						Language.ITA => "Sincrumore",
						Language.SPN => "Sincrorruido",
						Language.KOR => "싱크로노이즈",
						Language.CHN_SIM => "同步干扰",
						Language.CHN_TRA => "同步干擾",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.SYNTHESIS:
					return lang switch {
						Language.ENG => "Synthesis",
						Language.JPN => "こうごうせい",
						Language.GER => "Synthese",
						Language.FRE => "Synthèse",
						Language.ITA => "Sintesi",
						Language.SPN => "Síntesis",
						Language.KOR => "광합성",
						Language.CHN_SIM => "光合作用",
						Language.CHN_TRA => "光合作用",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TACKLE:
					return lang switch {
						Language.ENG => "Tackle",
						Language.JPN => "たいあたり",
						Language.GER => "Tackle",
						Language.FRE => "Charge",
						Language.ITA => "Azione",
						Language.SPN => "Placaje",
						Language.KOR => "몸통박치기",
						Language.CHN_SIM => "撞击",
						Language.CHN_TRA => "撞擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAIL_GLOW:
					return lang switch {
						Language.ENG => "Tail Glow",
						Language.JPN => "ほたるび",
						Language.GER => "Schweifglanz",
						Language.FRE => "Lumiqueue",
						Language.ITA => "Codadiluce",
						Language.SPN => "Ráfaga",
						Language.KOR => "반딧불",
						Language.CHN_SIM => "萤火",
						Language.CHN_TRA => "螢火",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAIL_SLAP:
					return lang switch {
						Language.ENG => "Tail Slap",
						Language.JPN => "スイープビンタ",
						Language.GER => "Kehrschelle",
						Language.FRE => "Plumo-Queue",
						Language.ITA => "Spazzasberla",
						Language.SPN => "Plumerazo",
						Language.KOR => "스위프뺨치기",
						Language.CHN_SIM => "扫尾拍打",
						Language.CHN_TRA => "掃尾拍打",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAIL_WHIP:
					return lang switch {
						Language.ENG => "Tail Whip",
						Language.JPN => "しっぽをふる",
						Language.GER => "Rutenschlag",
						Language.FRE => "Mimi-Queue",
						Language.ITA => "Colpocoda",
						Language.SPN => "Látigo",
						Language.KOR => "꼬리흔들기",
						Language.CHN_SIM => "摇尾巴",
						Language.CHN_TRA => "搖尾巴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAILWIND:
					return lang switch {
						Language.ENG => "Tailwind",
						Language.JPN => "おいかぜ",
						Language.GER => "Rückenwind",
						Language.FRE => "Vent Arrière",
						Language.ITA => "Ventoincoda",
						Language.SPN => "Viento Afín",
						Language.KOR => "순풍",
						Language.CHN_SIM => "顺风",
						Language.CHN_TRA => "順風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAKE_DOWN:
					return lang switch {
						Language.ENG => "Take Down",
						Language.JPN => "とっしん",
						Language.GER => "Bodycheck",
						Language.FRE => "Bélier",
						Language.ITA => "Riduttore",
						Language.SPN => "Derribo",
						Language.KOR => "돌진",
						Language.CHN_SIM => "猛撞",
						Language.CHN_TRA => "猛撞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAKE_HEART:
					return lang switch {
						Language.ENG => "Take Heart",
						Language.JPN => "ブレイブチャー",
						Language.GER => "Mutschub",
						Language.FRE => "Extravaillance",
						Language.ITA => "Baldimpulso",
						Language.SPN => "Bálsamo Osado",
						Language.KOR => "브레이브차지",
						Language.CHN_SIM => "勇气填充",
						Language.CHN_TRA => "勇氣填充",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAR_SHOT:
					return lang switch {
						Language.ENG => "Tar Shot",
						Language.JPN => "タールショッ",
						Language.GER => "Teerschuss",
						Language.FRE => "Goudronnage",
						Language.ITA => "Colpocatrame",
						Language.SPN => "Alquitranazo",
						Language.KOR => "타르샷",
						Language.CHN_SIM => "沥青射击",
						Language.CHN_TRA => "瀝青射擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TAUNT:
					return lang switch {
						Language.ENG => "Taunt",
						Language.JPN => "ちょうはつ",
						Language.GER => "Verhöhner",
						Language.FRE => "Provoc",
						Language.ITA => "Provocazione",
						Language.SPN => "Mofa",
						Language.KOR => "도발",
						Language.CHN_SIM => "挑衅",
						Language.CHN_TRA => "挑釁",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TEARFUL_LOOK:
					return lang switch {
						Language.ENG => "Tearful Look",
						Language.JPN => "なみだめ",
						Language.GER => "Tränendrüse",
						Language.FRE => "Larme à l'Œil",
						Language.ITA => "Occhionilucidi",
						Language.SPN => "Ojos Llorosos",
						Language.KOR => "눈물그렁그렁",
						Language.CHN_SIM => "泪眼汪汪",
						Language.CHN_TRA => "淚眼汪汪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TEATIME:
					return lang switch {
						Language.ENG => "Teatime",
						Language.JPN => "おちゃか",
						Language.GER => "Teatime",
						Language.FRE => "Thérémonie",
						Language.ITA => "Ora del Tè",
						Language.SPN => "Hora del Té",
						Language.KOR => "다과회",
						Language.CHN_SIM => "茶会",
						Language.CHN_TRA => "茶會",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TECHNO_BLAST:
					return lang switch {
						Language.ENG => "Techno Blast",
						Language.JPN => "テクノバスター",
						Language.GER => "Techblaster",
						Language.FRE => "Techno-Buster",
						Language.ITA => "Tecnobotto",
						Language.SPN => "Tecno Shock",
						Language.KOR => "테크노버스터",
						Language.CHN_SIM => "高科技光炮",
						Language.CHN_TRA => "高科技光炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TEETER_DANCE:
					return lang switch {
						Language.ENG => "Teeter Dance",
						Language.JPN => "フラフラダンス",
						Language.GER => "Taumeltanz",
						Language.FRE => "Danse-Folle",
						Language.ITA => "Strampadanza",
						Language.SPN => "Danza Caos",
						Language.KOR => "흔들흔들댄스",
						Language.CHN_SIM => "摇晃舞",
						Language.CHN_TRA => "搖晃舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TELEKINESIS:
					return lang switch {
						Language.ENG => "Telekinesis",
						Language.JPN => "テレキネシス",
						Language.GER => "Telekinese",
						Language.FRE => "Lévikinésie",
						Language.ITA => "Telecinesi",
						Language.SPN => "Telequinesis",
						Language.KOR => "텔레키네시스",
						Language.CHN_SIM => "意念移物",
						Language.CHN_TRA => "意念移物",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TELEPORT:
					return lang switch {
						Language.ENG => "Teleport",
						Language.JPN => "テレポート",
						Language.GER => "Teleport",
						Language.FRE => "Téléport",
						Language.ITA => "Teletrasporto",
						Language.SPN => "Teletransporte",
						Language.KOR => "순간이동",
						Language.CHN_SIM => "瞬间移动",
						Language.CHN_TRA => "瞬間移動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TERRAIN_PULSE:
					return lang switch {
						Language.ENG => "Terrain Pulse",
						Language.JPN => "だいちのはど",
						Language.GER => "Feldimpuls",
						Language.FRE => "Champlification",
						Language.ITA => "Campopulsar",
						Language.SPN => "Pulso de Campo",
						Language.KOR => "대지의파동",
						Language.CHN_SIM => "大地波动",
						Language.CHN_TRA => "大地波動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THIEF:
					return lang switch {
						Language.ENG => "Thief",
						Language.JPN => "どろぼう",
						Language.GER => "Raub",
						Language.FRE => "Larcin",
						Language.ITA => "Furto",
						Language.SPN => "Ladrón",
						Language.KOR => "도둑질",
						Language.CHN_SIM => "小偷",
						Language.CHN_TRA => "小偷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THOUSAND_ARROWS:
					return lang switch {
						Language.ENG => "Thousand Arrows",
						Language.JPN => "サウザンアロー",
						Language.GER => "Tausend Pfeile",
						Language.FRE => "Myria-Flèches",
						Language.ITA => "Mille Frecce",
						Language.SPN => "Mil Flechas",
						Language.KOR => "사우전드애로",
						Language.CHN_SIM => "千箭齐发",
						Language.CHN_TRA => "千箭齊發",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THOUSAND_WAVES:
					return lang switch {
						Language.ENG => "Thousand Waves",
						Language.JPN => "サウザンウェーブ",
						Language.GER => "Tausend Wellen",
						Language.FRE => "Myria-Vagues",
						Language.ITA => "Mille Onde",
						Language.SPN => "Mil Temblores",
						Language.KOR => "사우전드웨이브",
						Language.CHN_SIM => "千波激荡",
						Language.CHN_TRA => "千波激盪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THRASH:
					return lang switch {
						Language.ENG => "Thrash",
						Language.JPN => "あばれる",
						Language.GER => "Fuchtler",
						Language.FRE => "Mania",
						Language.ITA => "Colpo",
						Language.SPN => "Golpe",
						Language.KOR => "난동부리기",
						Language.CHN_SIM => "大闹一番",
						Language.CHN_TRA => "大鬧一番",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THROAT_CHOP:
					return lang switch {
						Language.ENG => "Throat Chop",
						Language.JPN => "じごくづき",
						Language.GER => "Neck Strike",
						Language.FRE => "Exécu-Son",
						Language.ITA => "Colpo Infernale",
						Language.SPN => "Golpe Mordaza",
						Language.KOR => "지옥찌르기",
						Language.CHN_SIM => "深渊突刺",
						Language.CHN_TRA => "地獄突刺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDER:
					return lang switch {
						Language.ENG => "Thunder",
						Language.JPN => "かみなり",
						Language.GER => "Donner",
						Language.FRE => "Fatal-Foudre",
						Language.ITA => "Tuono",
						Language.SPN => "Trueno",
						Language.KOR => "번개",
						Language.CHN_SIM => "打雷",
						Language.CHN_TRA => "打雷",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDER_CAGE:
					return lang switch {
						Language.ENG => "Thunder Cage",
						Language.JPN => "サンダープリズ",
						Language.GER => "Blitzgefängnis",
						Language.FRE => "Voltageôle",
						Language.ITA => "Elettrogabbia",
						Language.SPN => "Electrojaula",
						Language.KOR => "썬더프리즌",
						Language.CHN_SIM => "雷电囚笼",
						Language.CHN_TRA => "雷電囚籠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDER_FANG:
					return lang switch {
						Language.ENG => "Thunder Fang",
						Language.JPN => "かみなりのキバ",
						Language.GER => "Donnerzahn",
						Language.FRE => "Crocs Éclair",
						Language.ITA => "Fulmindenti",
						Language.SPN => "Colmillo Rayo",
						Language.KOR => "번개엄니",
						Language.CHN_SIM => "雷电牙",
						Language.CHN_TRA => "雷電牙",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDER_PUNCH:
					return lang switch {
						Language.ENG => "Thunder Punch",
						Language.JPN => "かみなりパンチ",
						Language.GER => "Donnerschlag",
						Language.FRE => "Poing-Éclair",
						Language.ITA => "Tuonopugno",
						Language.SPN => "Puño Trueno",
						Language.KOR => "번개펀치",
						Language.CHN_SIM => "雷电拳",
						Language.CHN_TRA => "雷電拳",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDER_SHOCK:
					return lang switch {
						Language.ENG => "Thunder Shock",
						Language.JPN => "でんきショック",
						Language.GER => "Donnerschock",
						Language.FRE => "Éclair",
						Language.ITA => "Tuonoshock",
						Language.SPN => "Impactrueno",
						Language.KOR => "전기쇼크",
						Language.CHN_SIM => "电击",
						Language.CHN_TRA => "電擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDER_WAVE:
					return lang switch {
						Language.ENG => "Thunder Wave",
						Language.JPN => "でんじは",
						Language.GER => "Donnerwelle",
						Language.FRE => "Cage-Éclair",
						Language.ITA => "Tuononda",
						Language.SPN => "Onda Trueno",
						Language.KOR => "전기자석파",
						Language.CHN_SIM => "电磁波",
						Language.CHN_TRA => "電磁波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDERBOLT:
					return lang switch {
						Language.ENG => "Thunderbolt",
						Language.JPN => "１０まんボルト",
						Language.GER => "Donnerblitz",
						Language.FRE => "Tonnerre",
						Language.ITA => "Fulmine",
						Language.SPN => "Rayo",
						Language.KOR => "10만볼트",
						Language.CHN_SIM => "十万伏特",
						Language.CHN_TRA => "十萬伏特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.THUNDEROUS_KICK:
					return lang switch {
						Language.ENG => "Thunderous Kick",
						Language.JPN => "らいめいげ",
						Language.GER => "Donnernder Tritt",
						Language.FRE => "Coup Fulgurant",
						Language.ITA => "Calcio Tonante",
						Language.SPN => "Patada Relámpago",
						Language.KOR => "천둥차기",
						Language.CHN_SIM => "雷鸣蹴击",
						Language.CHN_TRA => "雷鳴蹴擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TICKLE:
					return lang switch {
						Language.ENG => "Tickle",
						Language.JPN => "くすぐる",
						Language.GER => "Spaßkanone",
						Language.FRE => "Chatouille",
						Language.ITA => "Solletico",
						Language.SPN => "Cosquillas",
						Language.KOR => "간지르기",
						Language.CHN_SIM => "挠痒",
						Language.CHN_TRA => "搔癢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TIDY_UP:
					return lang switch {
						Language.ENG => "Tidy Up",
						Language.JPN => "おかたづ",
						Language.GER => "Aufräumen",
						Language.FRE => "Grand Nettoyage",
						Language.ITA => "Pulizie",
						Language.SPN => "Limpieza General",
						Language.KOR => "정리정돈",
						Language.CHN_SIM => "大扫除",
						Language.CHN_TRA => "大掃除",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TOPSY_TURVY:
					return lang switch {
						Language.ENG => "Topsy-Turvy",
						Language.JPN => "ひっくりかえす",
						Language.GER => "Invertigo",
						Language.FRE => "Renversement",
						Language.ITA => "Sottosopra",
						Language.SPN => "Reversión",
						Language.KOR => "뒤집어엎기",
						Language.CHN_SIM => "颠倒",
						Language.CHN_TRA => "顛倒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TORCH_SONG:
					return lang switch {
						Language.ENG => "Torch Song",
						Language.JPN => "フレアソン",
						Language.GER => "Loderlied",
						Language.FRE => "Chant Flamboyant",
						Language.ITA => "Canzone Ardente",
						Language.SPN => "Canto Ardiente",
						Language.KOR => "플레어송",
						Language.CHN_SIM => "闪焰高歌",
						Language.CHN_TRA => "閃焰高歌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TORMENT:
					return lang switch {
						Language.ENG => "Torment",
						Language.JPN => "いちゃもん",
						Language.GER => "Folterknecht",
						Language.FRE => "Tourmente",
						Language.ITA => "Attaccalite",
						Language.SPN => "Tormento",
						Language.KOR => "트집",
						Language.CHN_SIM => "无理取闹",
						Language.CHN_TRA => "無理取鬧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TOXIC:
					return lang switch {
						Language.ENG => "Toxic",
						Language.JPN => "どくどく",
						Language.GER => "Toxin",
						Language.FRE => "Toxik",
						Language.ITA => "Tossina",
						Language.SPN => "Tóxico",
						Language.KOR => "맹독",
						Language.CHN_SIM => "剧毒",
						Language.CHN_TRA => "劇毒",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TOXIC_SPIKES:
					return lang switch {
						Language.ENG => "Toxic Spikes",
						Language.JPN => "どくびし",
						Language.GER => "Giftspitzen",
						Language.FRE => "Pics Toxik",
						Language.ITA => "Fielepunte",
						Language.SPN => "Púas Tóxicas",
						Language.KOR => "독압정",
						Language.CHN_SIM => "毒菱",
						Language.CHN_TRA => "毒菱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TOXIC_THREAD:
					return lang switch {
						Language.ENG => "Toxic Thread",
						Language.JPN => "どくのいと",
						Language.GER => "Giftfaden",
						Language.FRE => "Fil Toxique",
						Language.ITA => "Velenotela",
						Language.SPN => "Hilo Venenoso",
						Language.KOR => "독실",
						Language.CHN_SIM => "毒丝",
						Language.CHN_TRA => "毒絲",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRAILBLAZE:
					return lang switch {
						Language.ENG => "Trailblaze",
						Language.JPN => "くさわ",
						Language.GER => "Wegbereiter",
						Language.FRE => "Désherbaffe",
						Language.ITA => "Apripista",
						Language.SPN => "Abrecaminos",
						Language.KOR => "개척하기",
						Language.CHN_SIM => "起草",
						Language.CHN_TRA => "起草",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRANSFORM:
					return lang switch {
						Language.ENG => "Transform",
						Language.JPN => "へんしん",
						Language.GER => "Wandler",
						Language.FRE => "Morphing",
						Language.ITA => "Trasformazione",
						Language.SPN => "Transformación",
						Language.KOR => "변신",
						Language.CHN_SIM => "变身",
						Language.CHN_TRA => "變身",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRI_ATTACK:
					return lang switch {
						Language.ENG => "Tri Attack",
						Language.JPN => "トライアタック",
						Language.GER => "Triplette",
						Language.FRE => "Triplattaque",
						Language.ITA => "Tripletta",
						Language.SPN => "Triataque",
						Language.KOR => "트라이어택",
						Language.CHN_SIM => "三重攻击",
						Language.CHN_TRA => "三重攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRICK:
					return lang switch {
						Language.ENG => "Trick",
						Language.JPN => "トリック",
						Language.GER => "Trickbetrug",
						Language.FRE => "Tourmagik",
						Language.ITA => "Raggiro",
						Language.SPN => "Truco",
						Language.KOR => "트릭",
						Language.CHN_SIM => "戏法",
						Language.CHN_TRA => "戲法",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRICK_ROOM:
					return lang switch {
						Language.ENG => "Trick Room",
						Language.JPN => "トリックルーム",
						Language.GER => "Bizarroraum",
						Language.FRE => "Distorsion",
						Language.ITA => "Distortozona",
						Language.SPN => "Espacio Raro",
						Language.KOR => "트릭룸",
						Language.CHN_SIM => "戏法空间",
						Language.CHN_TRA => "戲法空間",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRICK_OR_TREAT:
					return lang switch {
						Language.ENG => "Trick-or-Treat",
						Language.JPN => "ハロウィン",
						Language.GER => "Halloween",
						Language.FRE => "Halloween",
						Language.ITA => "Halloween",
						Language.SPN => "Halloween",
						Language.KOR => "핼러윈",
						Language.CHN_SIM => "万圣夜",
						Language.CHN_TRA => "萬聖夜",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRIPLE_ARROWS:
					return lang switch {
						Language.ENG => "Triple Arrows",
						Language.JPN => "３ぼんの",
						Language.GER => "Drillingspfeile",
						Language.FRE => "Triple Flèche",
						Language.ITA => "Triplodardo",
						Language.SPN => "Triple Flecha",
						Language.KOR => "3연화살",
						Language.CHN_SIM => "三连箭",
						Language.CHN_TRA => "三連箭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRIPLE_AXEL:
					return lang switch {
						Language.ENG => "Triple Axel",
						Language.JPN => "トリプルアクセ",
						Language.GER => "Dreifach-Axel",
						Language.FRE => "Triple Axel",
						Language.ITA => "Triplo Axel",
						Language.SPN => "Triple Axel",
						Language.KOR => "트리플악셀",
						Language.CHN_SIM => "三旋击",
						Language.CHN_TRA => "三旋擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRIPLE_DIVE:
					return lang switch {
						Language.ENG => "Triple Dive",
						Language.JPN => "トリプルダイ",
						Language.GER => "Tauchtriade",
						Language.FRE => "Triple Plongeon",
						Language.ITA => "Triplo Tuffo",
						Language.SPN => "Triple Inmersión",
						Language.KOR => "트리플다이브",
						Language.CHN_SIM => "三连钻",
						Language.CHN_TRA => "三連鑽",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRIPLE_KICK:
					return lang switch {
						Language.ENG => "Triple Kick",
						Language.JPN => "トリプルキック",
						Language.GER => "Dreifachkick",
						Language.FRE => "Triple Pied",
						Language.ITA => "Triplocalcio",
						Language.SPN => "Triple Patada",
						Language.KOR => "트리플킥",
						Language.CHN_SIM => "三连踢",
						Language.CHN_TRA => "三連踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TROP_KICK:
					return lang switch {
						Language.ENG => "Trop Kick",
						Language.JPN => "トロピカルキック",
						Language.GER => "Tropenkick",
						Language.FRE => "Botte Sucrette",
						Language.ITA => "Tropicalcio",
						Language.SPN => "Patada Tropica",
						Language.KOR => "트로피컬킥",
						Language.CHN_SIM => "热带踢",
						Language.CHN_TRA => "熱帶踢",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TRUMP_CARD:
					return lang switch {
						Language.ENG => "Trump Card",
						Language.JPN => "きりふだ",
						Language.GER => "Trumpfkarte",
						Language.FRE => "Atout",
						Language.ITA => "Asso",
						Language.SPN => "As Oculto",
						Language.KOR => "마지막수단",
						Language.CHN_SIM => "王牌",
						Language.CHN_TRA => "王牌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TWIN_BEAM:
					return lang switch {
						Language.ENG => "Twin Beam",
						Language.JPN => "ツインビー",
						Language.GER => "Doppelstrahl",
						Language.FRE => "Double Laser",
						Language.ITA => "Doppioraggio",
						Language.SPN => "Láser Doble",
						Language.KOR => "트윈빔",
						Language.CHN_SIM => "双光束",
						Language.CHN_TRA => "雙光束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TWINEEDLE:
					return lang switch {
						Language.ENG => "Twineedle",
						Language.JPN => "ダブルニードル",
						Language.GER => "Duonadel",
						Language.FRE => "Double-Dard",
						Language.ITA => "Doppio Ago",
						Language.SPN => "Doble Ataque",
						Language.KOR => "더블니들",
						Language.CHN_SIM => "双针",
						Language.CHN_TRA => "雙針",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.TWISTER:
					return lang switch {
						Language.ENG => "Twister",
						Language.JPN => "たつまき",
						Language.GER => "Windhose",
						Language.FRE => "Ouragan",
						Language.ITA => "Tornado",
						Language.SPN => "Ciclón",
						Language.KOR => "회오리",
						Language.CHN_SIM => "龙卷风",
						Language.CHN_TRA => "龍捲風",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.U_TURN:
					return lang switch {
						Language.ENG => "U-turn",
						Language.JPN => "とんぼがえり",
						Language.GER => "Kehrtwende",
						Language.FRE => "Demi-Tour",
						Language.ITA => "Retromarcia",
						Language.SPN => "Ida y Vuelta",
						Language.KOR => "유턴",
						Language.CHN_SIM => "急速折返",
						Language.CHN_TRA => "急速折返",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.UPROAR:
					return lang switch {
						Language.ENG => "Uproar",
						Language.JPN => "さわぐ",
						Language.GER => "Aufruhr",
						Language.FRE => "Brouhaha",
						Language.ITA => "Baraonda",
						Language.SPN => "Alboroto",
						Language.KOR => "소란피기",
						Language.CHN_SIM => "吵闹",
						Language.CHN_TRA => "吵鬧",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.V_CREATE:
					return lang switch {
						Language.ENG => "V-create",
						Language.JPN => "Ｖジェネレート",
						Language.GER => "V-Generator",
						Language.FRE => "Coup Victoire",
						Language.ITA => "Generatore V",
						Language.SPN => "V de Fuego",
						Language.KOR => "V제너레이트",
						Language.CHN_SIM => "Ｖ热焰",
						Language.CHN_TRA => "Ｖ熱焰",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VACUUM_WAVE:
					return lang switch {
						Language.ENG => "Vacuum Wave",
						Language.JPN => "しんくうは",
						Language.GER => "Vakuumwelle",
						Language.FRE => "Onde Vide",
						Language.ITA => "Vuotonda",
						Language.SPN => "Onda Vacío",
						Language.KOR => "진공파",
						Language.CHN_SIM => "真空波",
						Language.CHN_TRA => "真空波",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VENOM_DRENCH:
					return lang switch {
						Language.ENG => "Venom Drench",
						Language.JPN => "ベノムトラップ",
						Language.GER => "Giftfalle",
						Language.FRE => "Piège de Venin",
						Language.ITA => "Velenotrappola",
						Language.SPN => "Trampa Venenosa",
						Language.KOR => "베놈트랩",
						Language.CHN_SIM => "毒液陷阱",
						Language.CHN_TRA => "毒液陷阱",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VENOSHOCK:
					return lang switch {
						Language.ENG => "Venoshock",
						Language.JPN => "ベノムショック",
						Language.GER => "Giftschock",
						Language.FRE => "Choc Venin",
						Language.ITA => "Velenoshock",
						Language.SPN => "Cargatóxica",
						Language.KOR => "베놈쇼크",
						Language.CHN_SIM => "毒液冲击",
						Language.CHN_TRA => "毒液衝擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VICTORY_DANCE:
					return lang switch {
						Language.ENG => "Victory Dance",
						Language.JPN => "しょうりのま",
						Language.GER => "Siegestanz",
						Language.FRE => "Danse Victoire",
						Language.ITA => "Danzavittoria",
						Language.SPN => "Danza Triunfal",
						Language.KOR => "승리의춤",
						Language.CHN_SIM => "胜利之舞",
						Language.CHN_TRA => "勝利之舞",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VINE_WHIP:
					return lang switch {
						Language.ENG => "Vine Whip",
						Language.JPN => "つるのムチ",
						Language.GER => "Rankenhieb",
						Language.FRE => "Fouet Lianes",
						Language.ITA => "Frustata",
						Language.SPN => "Látigo Cepa",
						Language.KOR => "덩굴채찍",
						Language.CHN_SIM => "藤鞭",
						Language.CHN_TRA => "藤鞭",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VISE_GRIP:
					return lang switch {
						Language.ENG => "Vise Grip",
						Language.JPN => "はさむ",
						Language.GER => "Klammer",
						Language.FRE => "Force Poigne",
						Language.ITA => "Presa",
						Language.SPN => "Agarre",
						Language.KOR => "찝기",
						Language.CHN_SIM => "夹住",
						Language.CHN_TRA => "夾住",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VITAL_THROW:
					return lang switch {
						Language.ENG => "Vital Throw",
						Language.JPN => "あてみなげ",
						Language.GER => "Überwurf",
						Language.FRE => "Corps Perdu",
						Language.ITA => "Vitaltiro",
						Language.SPN => "Tiro Vital",
						Language.KOR => "받아던지기",
						Language.CHN_SIM => "借力摔",
						Language.CHN_TRA => "借力摔",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VOLT_SWITCH:
					return lang switch {
						Language.ENG => "Volt Switch",
						Language.JPN => "ボルトチェンジ",
						Language.GER => "Voltwechsel",
						Language.FRE => "Change Éclair",
						Language.ITA => "Invertivolt",
						Language.SPN => "Voltiocambio",
						Language.KOR => "볼트체인지",
						Language.CHN_SIM => "伏特替换",
						Language.CHN_TRA => "伏特替換",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.VOLT_TACKLE:
					return lang switch {
						Language.ENG => "Volt Tackle",
						Language.JPN => "ボルテッカー",
						Language.GER => "Volttackle",
						Language.FRE => "Électacle",
						Language.ITA => "Locomovolt",
						Language.SPN => "Placaje Eléctrico",
						Language.KOR => "볼트태클",
						Language.CHN_SIM => "伏特攻击",
						Language.CHN_TRA => "伏特攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WAKE_UP_SLAP:
					return lang switch {
						Language.ENG => "Wake-Up Slap",
						Language.JPN => "めざましビンタ",
						Language.GER => "Weckruf",
						Language.FRE => "Réveil Forcé",
						Language.ITA => "Svegliopacca",
						Language.SPN => "Espabila",
						Language.KOR => "잠깨움뺨치기",
						Language.CHN_SIM => "唤醒巴掌",
						Language.CHN_TRA => "喚醒巴掌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATER_GUN:
					return lang switch {
						Language.ENG => "Water Gun",
						Language.JPN => "みずでっぽう",
						Language.GER => "Aquaknarre",
						Language.FRE => "Pistolet à O",
						Language.ITA => "Pistolacqua",
						Language.SPN => "Pistola Agua",
						Language.KOR => "물대포",
						Language.CHN_SIM => "水枪",
						Language.CHN_TRA => "水槍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATER_PLEDGE:
					return lang switch {
						Language.ENG => "Water Pledge",
						Language.JPN => "みずのちかい",
						Language.GER => "Wassersäulen",
						Language.FRE => "Aire d'Eau",
						Language.ITA => "Acquapatto",
						Language.SPN => "Voto Agua",
						Language.KOR => "물의맹세",
						Language.CHN_SIM => "水之誓约",
						Language.CHN_TRA => "水之誓約",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATER_PULSE:
					return lang switch {
						Language.ENG => "Water Pulse",
						Language.JPN => "みずのはどう",
						Language.GER => "Aquawelle",
						Language.FRE => "Vibraqua",
						Language.ITA => "Idropulsar",
						Language.SPN => "Hidropulso",
						Language.KOR => "물의파동",
						Language.CHN_SIM => "水之波动",
						Language.CHN_TRA => "水之波動",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATER_SHURIKEN:
					return lang switch {
						Language.ENG => "Water Shuriken",
						Language.JPN => "みずしゅりけん",
						Language.GER => "Wasser-Shuriken",
						Language.FRE => "Sheauriken",
						Language.ITA => "Acqualame",
						Language.SPN => "Shuriken de Agua",
						Language.KOR => "물수리검",
						Language.CHN_SIM => "飞水手里剑",
						Language.CHN_TRA => "飛水手裡劍",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATER_SPORT:
					return lang switch {
						Language.ENG => "Water Sport",
						Language.JPN => "みずあそび",
						Language.GER => "Nassmacher",
						Language.FRE => "Tourniquet",
						Language.ITA => "Docciascudo",
						Language.SPN => "Hidrochorro",
						Language.KOR => "물놀이",
						Language.CHN_SIM => "玩水",
						Language.CHN_TRA => "玩水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATER_SPOUT:
					return lang switch {
						Language.ENG => "Water Spout",
						Language.JPN => "しおふき",
						Language.GER => "Fontränen",
						Language.FRE => "Giclédo",
						Language.ITA => "Zampillo",
						Language.SPN => "Salpicar",
						Language.KOR => "해수스파우팅",
						Language.CHN_SIM => "喷水",
						Language.CHN_TRA => "噴水",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WATERFALL:
					return lang switch {
						Language.ENG => "Waterfall",
						Language.JPN => "たきのぼり",
						Language.GER => "Kaskade",
						Language.FRE => "Cascade",
						Language.ITA => "Cascata",
						Language.SPN => "Cascada",
						Language.KOR => "폭포오르기",
						Language.CHN_SIM => "攀瀑",
						Language.CHN_TRA => "攀瀑",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WAVE_CRASH:
					return lang switch {
						Language.ENG => "Wave Crash",
						Language.JPN => "ウェーブタック",
						Language.GER => "Wellentackle",
						Language.FRE => "Aquatacle",
						Language.ITA => "Ondaschianto",
						Language.SPN => "Envite Acuático",
						Language.KOR => "웨이브태클",
						Language.CHN_SIM => "波动冲",
						Language.CHN_TRA => "波動衝",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WEATHER_BALL:
					return lang switch {
						Language.ENG => "Weather Ball",
						Language.JPN => "ウェザーボール",
						Language.GER => "Meteorologe",
						Language.FRE => "Ball'Météo",
						Language.ITA => "Palla Clima",
						Language.SPN => "Meteorobola",
						Language.KOR => "웨더볼",
						Language.CHN_SIM => "气象球",
						Language.CHN_TRA => "氣象球",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WHIRLPOOL:
					return lang switch {
						Language.ENG => "Whirlpool",
						Language.JPN => "うずしお",
						Language.GER => "Whirlpool",
						Language.FRE => "Siphon",
						Language.ITA => "Mulinello",
						Language.SPN => "Torbellino",
						Language.KOR => "바다회오리",
						Language.CHN_SIM => "潮旋",
						Language.CHN_TRA => "潮旋",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WHIRLWIND:
					return lang switch {
						Language.ENG => "Whirlwind",
						Language.JPN => "ふきとばし",
						Language.GER => "Wirbelwind",
						Language.FRE => "Cyclone",
						Language.ITA => "Turbine",
						Language.SPN => "Remolino",
						Language.KOR => "날려버리기",
						Language.CHN_SIM => "吹飞",
						Language.CHN_TRA => "吹飛",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WICKED_BLOW:
					return lang switch {
						Language.ENG => "Wicked Blow",
						Language.JPN => "あんこくきょう",
						Language.GER => "Finstertreffer",
						Language.FRE => "Poing Obscur",
						Language.ITA => "Pugnotenebra",
						Language.SPN => "Golpe Oscuro",
						Language.KOR => "암흑강타",
						Language.CHN_SIM => "暗冥强击",
						Language.CHN_TRA => "暗冥強擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WIDE_GUARD:
					return lang switch {
						Language.ENG => "Wide Guard",
						Language.JPN => "ワイドガード",
						Language.GER => "Rundumschutz",
						Language.FRE => "Garde Large",
						Language.ITA => "Bodyguard",
						Language.SPN => "Vastaguardia",
						Language.KOR => "와이드가드",
						Language.CHN_SIM => "广域防守",
						Language.CHN_TRA => "廣域防守",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WILD_CHARGE:
					return lang switch {
						Language.ENG => "Wild Charge",
						Language.JPN => "ワイルドボルト",
						Language.GER => "Stromstoß",
						Language.FRE => "Éclair Fou",
						Language.ITA => "Sprizzalampo",
						Language.SPN => "Voltio Cruel",
						Language.KOR => "와일드볼트",
						Language.CHN_SIM => "疯狂伏特",
						Language.CHN_TRA => "瘋狂伏特",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WILDBOLT_STORM:
					return lang switch {
						Language.ENG => "Wildbolt Storm",
						Language.JPN => "かみなりあら",
						Language.GER => "Donnerorkan",
						Language.FRE => "Typhon Fulgurant",
						Language.ITA => "Tempesta Tonante",
						Language.SPN => "Electormenta",
						Language.KOR => "번개폭풍",
						Language.CHN_SIM => "鸣雷风暴",
						Language.CHN_TRA => "鳴雷風暴",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WILL_O_WISP:
					return lang switch {
						Language.ENG => "Will-O-Wisp",
						Language.JPN => "おにび",
						Language.GER => "Irrlicht",
						Language.FRE => "Feu Follet",
						Language.ITA => "Fuocofatuo",
						Language.SPN => "Fuego Fatuo",
						Language.KOR => "도깨비불",
						Language.CHN_SIM => "磷火",
						Language.CHN_TRA => "鬼火",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WING_ATTACK:
					return lang switch {
						Language.ENG => "Wing Attack",
						Language.JPN => "つばさでうつ",
						Language.GER => "Flügelschlag",
						Language.FRE => "Cru-Aile",
						Language.ITA => "Attacco d'Ala",
						Language.SPN => "Ataque Ala",
						Language.KOR => "날개치기",
						Language.CHN_SIM => "翅膀攻击",
						Language.CHN_TRA => "翅膀攻擊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WISH:
					return lang switch {
						Language.ENG => "Wish",
						Language.JPN => "ねがいごと",
						Language.GER => "Wunschtraum",
						Language.FRE => "Vœu",
						Language.ITA => "Desiderio",
						Language.SPN => "Deseo",
						Language.KOR => "희망사항",
						Language.CHN_SIM => "祈愿",
						Language.CHN_TRA => "祈願",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WITHDRAW:
					return lang switch {
						Language.ENG => "Withdraw",
						Language.JPN => "からにこもる",
						Language.GER => "Panzerschutz",
						Language.FRE => "Repli",
						Language.ITA => "Ritirata",
						Language.SPN => "Refugio",
						Language.KOR => "껍질에숨기",
						Language.CHN_SIM => "缩入壳中",
						Language.CHN_TRA => "縮入殼中",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WONDER_ROOM:
					return lang switch {
						Language.ENG => "Wonder Room",
						Language.JPN => "ワンダールーム",
						Language.GER => "Wunderraum",
						Language.FRE => "Zone Étrange",
						Language.ITA => "Mirabilzona",
						Language.SPN => "Zona Extraña",
						Language.KOR => "원더룸",
						Language.CHN_SIM => "奇妙空间",
						Language.CHN_TRA => "奇妙空間",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WOOD_HAMMER:
					return lang switch {
						Language.ENG => "Wood Hammer",
						Language.JPN => "ウッドハンマー",
						Language.GER => "Holzhammer",
						Language.FRE => "Martobois",
						Language.ITA => "Mazzuolegno",
						Language.SPN => "Mazazo",
						Language.KOR => "우드해머",
						Language.CHN_SIM => "木槌",
						Language.CHN_TRA => "木槌",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WORK_UP:
					return lang switch {
						Language.ENG => "Work Up",
						Language.JPN => "ふるいたてる",
						Language.GER => "Kraftschub",
						Language.FRE => "Rengorgement",
						Language.ITA => "Cuordileone",
						Language.SPN => "Avivar",
						Language.KOR => "분발",
						Language.CHN_SIM => "自我激励",
						Language.CHN_TRA => "自我激勵",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WORRY_SEED:
					return lang switch {
						Language.ENG => "Worry Seed",
						Language.JPN => "なやみのタネ",
						Language.GER => "Sorgensamen",
						Language.FRE => "Soucigraine",
						Language.ITA => "Affannoseme",
						Language.SPN => "Abatidoras",
						Language.KOR => "고민씨",
						Language.CHN_SIM => "烦恼种子",
						Language.CHN_TRA => "煩惱種子",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WRAP:
					return lang switch {
						Language.ENG => "Wrap",
						Language.JPN => "まきつく",
						Language.GER => "Wickel",
						Language.FRE => "Ligotage",
						Language.ITA => "Avvolgibotta",
						Language.SPN => "Constricción",
						Language.KOR => "김밥말이",
						Language.CHN_SIM => "紧束",
						Language.CHN_TRA => "緊束",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.WRING_OUT:
					return lang switch {
						Language.ENG => "Wring Out",
						Language.JPN => "しぼりとる",
						Language.GER => "Auswringen",
						Language.FRE => "Essorage",
						Language.ITA => "Strizzata",
						Language.SPN => "Estrujón",
						Language.KOR => "쥐어짜기",
						Language.CHN_SIM => "绞紧",
						Language.CHN_TRA => "絞緊",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.X_SCISSOR:
					return lang switch {
						Language.ENG => "X-Scissor",
						Language.JPN => "シザークロス",
						Language.GER => "Kreuzschere",
						Language.FRE => "Plaie-Croix",
						Language.ITA => "Forbice X",
						Language.SPN => "Tijera X",
						Language.KOR => "시저크로스",
						Language.CHN_SIM => "十字剪",
						Language.CHN_TRA => "十字剪",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.YAWN:
					return lang switch {
						Language.ENG => "Yawn",
						Language.JPN => "あくび",
						Language.GER => "Gähner",
						Language.FRE => "Bâillement",
						Language.ITA => "Sbadiglio",
						Language.SPN => "Bostezo",
						Language.KOR => "하품",
						Language.CHN_SIM => "哈欠",
						Language.CHN_TRA => "哈欠",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ZAP_CANNON:
					return lang switch {
						Language.ENG => "Zap Cannon",
						Language.JPN => "でんじほう",
						Language.GER => "Blitzkanone",
						Language.FRE => "Élecanon",
						Language.ITA => "Falcecannone",
						Language.SPN => "Electrocañón",
						Language.KOR => "전자포",
						Language.CHN_SIM => "电磁炮",
						Language.CHN_TRA => "電磁炮",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ZEN_HEADBUTT:
					return lang switch {
						Language.ENG => "Zen Headbutt",
						Language.JPN => "しねんのずつき",
						Language.GER => "Zen-Kopfstoß",
						Language.FRE => "Psykoud'Boul",
						Language.ITA => "Cozzata Zen",
						Language.SPN => "Cabezazo Zen",
						Language.KOR => "사념의박치기",
						Language.CHN_SIM => "意念头锤",
						Language.CHN_TRA => "意念頭錘",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				case BattleMoveID.ZING_ZAP:
					return lang switch {
						Language.ENG => "Zing Zap",
						Language.JPN => "びりびりちくちく",
						Language.GER => "Elektropikser",
						Language.FRE => "Électrikipik",
						Language.ITA => "Elettropizzico",
						Language.SPN => "Electropunzada",
						Language.KOR => "찌리리따끔따끔",
						Language.CHN_SIM => "麻麻刺刺",
						Language.CHN_TRA => "麻麻刺刺",
						_ => throw new LanguageNotRecognizedException(lang),
					};
				default:
					throw new MoveNotRecognizedException(move);
			}
		}
	}
}
