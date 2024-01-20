using static PkmnEngine.Global;

namespace PkmnEngine.Strings {
	public static class AbilityNames {
		public static string gAbilityNames(Ability ability, Language lang) {
			switch (ability) {
				case Ability.NONE:
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
				case Ability.ADAPTABILITY:
					return lang switch {
						Language.ENG => "Adaptability",
						Language.JPN => "てきおうりょく",
						Language.GER => "Anpassung",
						Language.FRE => "Adaptabilité",
						Language.ITA => "Adattabilità",
						Language.SPN => "Adaptable",
						Language.KOR => "적응력",
						Language.CHN_SIM => "适应力",
						Language.CHN_TRA => "適應力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.AERILATE:
					return lang switch {
						Language.ENG => "Aerilate",
						Language.JPN => "スカイスキン",
						Language.GER => "Zenithaut",
						Language.FRE => "Peau Céleste",
						Language.ITA => "Pellecielo",
						Language.SPN => "Piel Celeste",
						Language.KOR => "스카이스킨",
						Language.CHN_SIM => "飞行皮肤",
						Language.CHN_TRA => "飛行皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.AFTERMATH:
					return lang switch {
						Language.ENG => "Aftermath",
						Language.JPN => "ゆうばく",
						Language.GER => "Finalschlag",
						Language.FRE => "Boom Final",
						Language.ITA => "Scoppio",
						Language.SPN => "Resquicio",
						Language.KOR => "유폭",
						Language.CHN_SIM => "诱爆",
						Language.CHN_TRA => "引爆",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.AIR_LOCK:
					return lang switch {
						Language.ENG => "Air Lock",
						Language.JPN => "エアロック",
						Language.GER => "Klimaschutz",
						Language.FRE => "Air Lock",
						Language.ITA => "Riparo",
						Language.SPN => "Bucle Aire",
						Language.KOR => "에어록",
						Language.CHN_SIM => "气闸",
						Language.CHN_TRA => "氣閘",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ANALYTIC:
					return lang switch {
						Language.ENG => "Analytic",
						Language.JPN => "アナライズ",
						Language.GER => "Analyse",
						Language.FRE => "Analyste",
						Language.ITA => "Ponderazione",
						Language.SPN => "Cálculo Final",
						Language.KOR => "애널라이즈",
						Language.CHN_SIM => "分析",
						Language.CHN_TRA => "分析",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ANGER_POINT:
					return lang switch {
						Language.ENG => "Anger Point",
						Language.JPN => "いかりのつぼ",
						Language.GER => "Kurzschluss",
						Language.FRE => "Colérique",
						Language.ITA => "Grancollera",
						Language.SPN => "Irascible",
						Language.KOR => "분노의경혈",
						Language.CHN_SIM => "愤怒穴位",
						Language.CHN_TRA => "憤怒穴位",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ANGER_SHELL:
					return lang switch {
						Language.ENG => "Anger Shell",
						Language.JPN => "いかりのこうら",
						Language.GER => "Wutpanzer",
						Language.FRE => "Courroupace",
						Language.ITA => "Iraguscio",
						Language.SPN => "Coraza Ira",
						Language.KOR => "분노의껍질",
						Language.CHN_SIM => "愤怒甲壳",
						Language.CHN_TRA => "憤怒甲殼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ANTICIPATION:
					return lang switch {
						Language.ENG => "Anticipation",
						Language.JPN => "きけんよち",
						Language.GER => "Vorahnung",
						Language.FRE => "Anticipation",
						Language.ITA => "Presagio",
						Language.SPN => "Anticipación",
						Language.KOR => "위험예지",
						Language.CHN_SIM => "危险预知",
						Language.CHN_TRA => "危險預知",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ARENA_TRAP:
					return lang switch {
						Language.ENG => "Arena Trap",
						Language.JPN => "ありじごく",
						Language.GER => "Ausweglos",
						Language.FRE => "Piège Sable",
						Language.ITA => "Trappoarena",
						Language.SPN => "Trampa Arena",
						Language.KOR => "개미지옥",
						Language.CHN_SIM => "沙穴",
						Language.CHN_TRA => "沙穴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ARMOR_TAIL:
					return lang switch {
						Language.ENG => "Armor Tail",
						Language.JPN => "テイルアーマー",
						Language.GER => "Schweifrüstung",
						Language.FRE => "Armure Caudale",
						Language.ITA => "Codarmatura",
						Language.SPN => "Cola Armadura",
						Language.KOR => "테일아머",
						Language.CHN_SIM => "尾甲",
						Language.CHN_TRA => "尾甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.AROMA_VEIL:
					return lang switch {
						Language.ENG => "Aroma Veil",
						Language.JPN => "アロマベール",
						Language.GER => "Dufthülle",
						Language.FRE => "Aroma-Voile",
						Language.ITA => "Aromavelo",
						Language.SPN => "Velo Aroma",
						Language.KOR => "아로마베일",
						Language.CHN_SIM => "芳香幕",
						Language.CHN_TRA => "芳香幕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.AS_ONE:
					return lang switch {
						Language.ENG => "As One",
						Language.JPN => "じんばいったい",
						Language.GER => "Reitgespann",
						Language.FRE => "Osmose Équine",
						Language.ITA => "Sintonia Equina",
						Language.SPN => "Unidad Ecuestre",
						Language.KOR => "혼연일체",
						Language.CHN_SIM => "人马一体",
						Language.CHN_TRA => "人馬一體",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.AURA_BREAK:
					return lang switch {
						Language.ENG => "Aura Break",
						Language.JPN => "オーラブレイク",
						Language.GER => "Aura-Umkehr",
						Language.FRE => "Aura Inversée",
						Language.ITA => "Frangiaura",
						Language.SPN => "Rompeaura",
						Language.KOR => "오라브레이크",
						Language.CHN_SIM => "气场破坏",
						Language.CHN_TRA => "氣場破壞",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BAD_DREAMS:
					return lang switch {
						Language.ENG => "Bad Dreams",
						Language.JPN => "ナイトメア",
						Language.GER => "Alptraum",
						Language.FRE => "Mauvais Rêve",
						Language.ITA => "Sogniamari",
						Language.SPN => "Mal Sueño",
						Language.KOR => "나이트메어",
						Language.CHN_SIM => "梦魇",
						Language.CHN_TRA => "夢魘",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BALL_FETCH:
					return lang switch {
						Language.ENG => "Ball Fetch",
						Language.JPN => "たまひろい",
						Language.GER => "Apport",
						Language.FRE => "Ramasse Ball",
						Language.ITA => "Raccattapalle",
						Language.SPN => "Recogebolas",
						Language.KOR => "볼줍기",
						Language.CHN_SIM => "捡球",
						Language.CHN_TRA => "撿球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BATTERY:
					return lang switch {
						Language.ENG => "Battery",
						Language.JPN => "バッテリー",
						Language.GER => "Batterie",
						Language.FRE => "Batterie",
						Language.ITA => "Batteria",
						Language.SPN => "Batería",
						Language.KOR => "배터리",
						Language.CHN_SIM => "蓄电池",
						Language.CHN_TRA => "蓄電池",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BATTLE_ARMOR:
					return lang switch {
						Language.ENG => "Battle Armor",
						Language.JPN => "カブトアーマー",
						Language.GER => "Kampfpanzer",
						Language.FRE => "Armurbaston",
						Language.ITA => "Lottascudo",
						Language.SPN => "Armadura Batalla",
						Language.KOR => "전투무장",
						Language.CHN_SIM => "战斗盔甲",
						Language.CHN_TRA => "戰鬥盔甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BATTLE_BOND:
					return lang switch {
						Language.ENG => "Battle Bond",
						Language.JPN => "きずなへんげ",
						Language.GER => "Freundschaftsakt",
						Language.FRE => "Synergie",
						Language.ITA => "Morfosintonia",
						Language.SPN => "Fuerte Afecto",
						Language.KOR => "유대변화",
						Language.CHN_SIM => "牵绊变身",
						Language.CHN_TRA => "牽絆變身",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BEADS_OF_RUIN:
					return lang switch {
						Language.ENG => "Beads of Ruin",
						Language.JPN => "わざわいのたま",
						Language.GER => "Unheilsjuwelen",
						Language.FRE => "Perles du Fléau",
						Language.ITA => "Monile Nefasto",
						Language.SPN => "Abalorio Debacle",
						Language.KOR => "재앙의구슬",
						Language.CHN_SIM => "灾祸之玉",
						Language.CHN_TRA => "災禍之玉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BEAST_BOOST:
					return lang switch {
						Language.ENG => "Beast Boost",
						Language.JPN => "ビーストブースト",
						Language.GER => "Bestien-Boost",
						Language.FRE => "Boost Chimère",
						Language.ITA => "Ultraboost",
						Language.SPN => "Ultraimpulso",
						Language.KOR => "비스트부스트",
						Language.CHN_SIM => "异兽提升",
						Language.CHN_TRA => "異獸提升",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BERSERK:
					return lang switch {
						Language.ENG => "Berserk",
						Language.JPN => "ぎゃくじょう",
						Language.GER => "Wutausbruch",
						Language.FRE => "Dracolère",
						Language.ITA => "Furore",
						Language.SPN => "Cólera",
						Language.KOR => "발끈",
						Language.CHN_SIM => "怒火冲天",
						Language.CHN_TRA => "怒火沖天",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BIG_PECKS:
					return lang switch {
						Language.ENG => "Big Pecks",
						Language.JPN => "はとむね",
						Language.GER => "Brustbieter",
						Language.FRE => "Cœur de Coq",
						Language.ITA => "Pettinfuori",
						Language.SPN => "Sacapecho",
						Language.KOR => "부풀린가슴",
						Language.CHN_SIM => "健壮胸肌",
						Language.CHN_TRA => "健壯胸肌",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BLAZE:
					return lang switch {
						Language.ENG => "Blaze",
						Language.JPN => "もうか",
						Language.GER => "Großbrand",
						Language.FRE => "Brasier",
						Language.ITA => "Aiutofuoco",
						Language.SPN => "Mar Llamas",
						Language.KOR => "맹화",
						Language.CHN_SIM => "猛火",
						Language.CHN_TRA => "猛火",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.BULLETPROOF:
					return lang switch {
						Language.ENG => "Bulletproof",
						Language.JPN => "ぼうだん",
						Language.GER => "Kugelsicher",
						Language.FRE => "Pare-Balles",
						Language.ITA => "Antiproiettile",
						Language.SPN => "Antibalas",
						Language.KOR => "방탄",
						Language.CHN_SIM => "防弹",
						Language.CHN_TRA => "防彈",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CHEEK_POUCH:
					return lang switch {
						Language.ENG => "Cheek Pouch",
						Language.JPN => "ほおぶくろ",
						Language.GER => "Backentaschen",
						Language.FRE => "Bajoues",
						Language.ITA => "Guancegonfie",
						Language.SPN => "Carrillo",
						Language.KOR => "볼주머니",
						Language.CHN_SIM => "颊囊",
						Language.CHN_TRA => "頰囊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CHILLING_NEIGH:
					return lang switch {
						Language.ENG => "Chilling Neigh",
						Language.JPN => "しろのいななき",
						Language.GER => "Helles Wiehern",
						Language.FRE => "Blanche Ruade",
						Language.ITA => "Nitrito Bianco",
						Language.SPN => "Relincho Blanco",
						Language.KOR => "백의울음",
						Language.CHN_SIM => "苍白嘶鸣",
						Language.CHN_TRA => "蒼白嘶鳴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CHLOROPHYLL:
					return lang switch {
						Language.ENG => "Chlorophyll",
						Language.JPN => "ようりょくそ",
						Language.GER => "Chlorophyll",
						Language.FRE => "Chlorophylle",
						Language.ITA => "Clorofilla",
						Language.SPN => "Clorofila",
						Language.KOR => "엽록소",
						Language.CHN_SIM => "叶绿素",
						Language.CHN_TRA => "葉綠素",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CLEAR_BODY:
					return lang switch {
						Language.ENG => "Clear Body",
						Language.JPN => "クリアボディ",
						Language.GER => "Neutraltorso",
						Language.FRE => "Corps Sain",
						Language.ITA => "Corpochiaro",
						Language.SPN => "Cuerpo Puro",
						Language.KOR => "클리어바디",
						Language.CHN_SIM => "恒净之躯",
						Language.CHN_TRA => "恆淨之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CLOUD_NINE:
					return lang switch {
						Language.ENG => "Cloud Nine",
						Language.JPN => "ノーてんき",
						Language.GER => "Wolke Sieben",
						Language.FRE => "Ciel Gris",
						Language.ITA => "Antimeteo",
						Language.SPN => "Aclimatación",
						Language.KOR => "날씨부정",
						Language.CHN_SIM => "无关天气",
						Language.CHN_TRA => "無關天氣",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COLOR_CHANGE:
					return lang switch {
						Language.ENG => "Color Change",
						Language.JPN => "へんしょく",
						Language.GER => "Farbwechsel",
						Language.FRE => "Déguisement",
						Language.ITA => "Cambiacolore",
						Language.SPN => "Cambio Color",
						Language.KOR => "변색",
						Language.CHN_SIM => "变色",
						Language.CHN_TRA => "變色",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COMATOSE:
					return lang switch {
						Language.ENG => "Comatose",
						Language.JPN => "ぜったいねむり",
						Language.GER => "Dauerschlaf",
						Language.FRE => "Hypersommeil",
						Language.ITA => "Sonno Assoluto",
						Language.SPN => "Letargo Perenne",
						Language.KOR => "절대안깸",
						Language.CHN_SIM => "绝对睡眠",
						Language.CHN_TRA => "絕對睡眠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COMMANDER:
					return lang switch {
						Language.ENG => "Commander",
						Language.JPN => "しれいとう",
						Language.GER => "Kommandant",
						Language.FRE => "Commandant",
						Language.ITA => "Torre di Comando",
						Language.SPN => "Comandar",
						Language.KOR => "사령탑",
						Language.CHN_SIM => "发号施令",
						Language.CHN_TRA => "發號施令",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COMPETITIVE:
					return lang switch {
						Language.ENG => "Competitive",
						Language.JPN => "かちき",
						Language.GER => "Unbeugsamkeit",
						Language.FRE => "Battant",
						Language.ITA => "Tenacia",
						Language.SPN => "Tenacidad",
						Language.KOR => "승기",
						Language.CHN_SIM => "好胜",
						Language.CHN_TRA => "好勝",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COMPOUND_EYES:
					return lang switch {
						Language.ENG => "Compound Eyes",
						Language.JPN => "ふくがん",
						Language.GER => "Facettenauge",
						Language.FRE => "Œil Composé",
						Language.ITA => "Insettocchi",
						Language.SPN => "Ojo Compuesto",
						Language.KOR => "복안",
						Language.CHN_SIM => "复眼",
						Language.CHN_TRA => "複眼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CONTRARY:
					return lang switch {
						Language.ENG => "Contrary",
						Language.JPN => "あまのじゃく",
						Language.GER => "Umkehrung",
						Language.FRE => "Contestation",
						Language.ITA => "Inversione",
						Language.SPN => "Respondón",
						Language.KOR => "심술꾸러기",
						Language.CHN_SIM => "唱反调",
						Language.CHN_TRA => "唱反調",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CORROSION:
					return lang switch {
						Language.ENG => "Corrosion",
						Language.JPN => "ふしょく",
						Language.GER => "Korrosion",
						Language.FRE => "Corrosion",
						Language.ITA => "Corrosione",
						Language.SPN => "Corrosión",
						Language.KOR => "부식",
						Language.CHN_SIM => "腐蚀",
						Language.CHN_TRA => "腐蝕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COSTAR:
					return lang switch {
						Language.ENG => "Costar",
						Language.JPN => "きょうえん",
						Language.GER => "Synchronauftritt",
						Language.FRE => "Collab",
						Language.ITA => "Coprotagonismo",
						Language.SPN => "Unísono",
						Language.KOR => "협연",
						Language.CHN_SIM => "同台共演",
						Language.CHN_TRA => "同台共演",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.COTTON_DOWN:
					return lang switch {
						Language.ENG => "Cotton Down",
						Language.JPN => "わたげ",
						Language.GER => "Wollflaum",
						Language.FRE => "Effilochage",
						Language.ITA => "Lanugine",
						Language.SPN => "Pelusa",
						Language.KOR => "솜털",
						Language.CHN_SIM => "棉絮",
						Language.CHN_TRA => "棉絮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CUD_CHEW:
					return lang switch {
						Language.ENG => "Cud Chew",
						Language.JPN => "はんすう",
						Language.GER => "Wiederkäuer",
						Language.FRE => "Ruminant",
						Language.ITA => "Ruminante",
						Language.SPN => "Rumia",
						Language.KOR => "되새김질",
						Language.CHN_SIM => "反刍",
						Language.CHN_TRA => "反芻",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CURIOUS_MEDICINE:
					return lang switch {
						Language.ENG => "Curious Medicine",
						Language.JPN => "きみょうなくすり",
						Language.GER => "Kuriose Arznei",
						Language.FRE => "Breuvage Suspect",
						Language.ITA => "Stranofarmaco",
						Language.SPN => "Medicina Extraña",
						Language.KOR => "기묘한약",
						Language.CHN_SIM => "怪药",
						Language.CHN_TRA => "怪藥",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CURSED_BODY:
					return lang switch {
						Language.ENG => "Cursed Body",
						Language.JPN => "のろわれボディ",
						Language.GER => "Tastfluch",
						Language.FRE => "Corps Maudit",
						Language.ITA => "Corpofunesto",
						Language.SPN => "Cuerpo Maldito",
						Language.KOR => "저주받은바디",
						Language.CHN_SIM => "咒术之躯",
						Language.CHN_TRA => "詛咒之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.CUTE_CHARM:
					return lang switch {
						Language.ENG => "Cute Charm",
						Language.JPN => "メロメロボディ",
						Language.GER => "Charmebolzen",
						Language.FRE => "Joli Sourire",
						Language.ITA => "Incantevole",
						Language.SPN => "Gran Encanto",
						Language.KOR => "헤롱헤롱바디",
						Language.CHN_SIM => "迷人之躯",
						Language.CHN_TRA => "迷人之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DAMP:
					return lang switch {
						Language.ENG => "Damp",
						Language.JPN => "しめりけ",
						Language.GER => "Feuchtigkeit",
						Language.FRE => "Moiteur",
						Language.ITA => "Umidità",
						Language.SPN => "Humedad",
						Language.KOR => "습기",
						Language.CHN_SIM => "湿气",
						Language.CHN_TRA => "濕氣",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DANCER:
					return lang switch {
						Language.ENG => "Dancer",
						Language.JPN => "おどりこ",
						Language.GER => "Tänzer",
						Language.FRE => "Danseuse",
						Language.ITA => "Sincrodanza",
						Language.SPN => "Pareja de Baile",
						Language.KOR => "무희",
						Language.CHN_SIM => "舞者",
						Language.CHN_TRA => "舞者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DARK_AURA:
					return lang switch {
						Language.ENG => "Dark Aura",
						Language.JPN => "ダークオーラ",
						Language.GER => "Dunkelaura",
						Language.FRE => "Aura Ténébreuse",
						Language.ITA => "Auratetra",
						Language.SPN => "Aura Oscura",
						Language.KOR => "다크오라",
						Language.CHN_SIM => "暗黑气场",
						Language.CHN_TRA => "暗黑氣場",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DAUNTLESS_SHIELD:
					return lang switch {
						Language.ENG => "Dauntless Shield",
						Language.JPN => "ふくつのたて",
						Language.GER => "Wackerer Schild",
						Language.FRE => "Égide Inflexible",
						Language.ITA => "Scudo Saldo",
						Language.SPN => "Escudo Recio",
						Language.KOR => "불굴의방패",
						Language.CHN_SIM => "不屈之盾",
						Language.CHN_TRA => "不屈之盾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DAZZLING:
					return lang switch {
						Language.ENG => "Dazzling",
						Language.JPN => "ビビッドボディ",
						Language.GER => "Buntkörper",
						Language.FRE => "Corps Coloré",
						Language.ITA => "Corposgargiante",
						Language.SPN => "Cuerpo Vívido",
						Language.KOR => "비비드바디",
						Language.CHN_SIM => "鲜艳之躯",
						Language.CHN_TRA => "鮮艷之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DEFEATIST:
					return lang switch {
						Language.ENG => "Defeatist",
						Language.JPN => "よわき",
						Language.GER => "Schwächling",
						Language.FRE => "Défaitiste",
						Language.ITA => "Sconforto",
						Language.SPN => "Flaqueza",
						Language.KOR => "무기력",
						Language.CHN_SIM => "软弱",
						Language.CHN_TRA => "軟弱",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DEFIANT:
					return lang switch {
						Language.ENG => "Defiant",
						Language.JPN => "まけんき",
						Language.GER => "Siegeswille",
						Language.FRE => "Acharné",
						Language.ITA => "Agonismo",
						Language.SPN => "Competitivo",
						Language.KOR => "오기",
						Language.CHN_SIM => "不服输",
						Language.CHN_TRA => "不服輸",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DELTA_STREAM:
					return lang switch {
						Language.ENG => "Delta Stream",
						Language.JPN => "デルタストリーム",
						Language.GER => "Delta-Wind",
						Language.FRE => "Souffle Delta",
						Language.ITA => "Flusso Delta",
						Language.SPN => "Ráfaga Delta",
						Language.KOR => "델타스트림",
						Language.CHN_SIM => "德尔塔气流",
						Language.CHN_TRA => "德爾塔氣流",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DESOLATE_LAND:
					return lang switch {
						Language.ENG => "Desolate Land",
						Language.JPN => "おわりのだいち",
						Language.GER => "Endland",
						Language.FRE => "Terre Finale",
						Language.ITA => "Terra Estrema",
						Language.SPN => "Tierra del Ocaso",
						Language.KOR => "끝의대지",
						Language.CHN_SIM => "终结之地",
						Language.CHN_TRA => "終結之地",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DISGUISE:
					return lang switch {
						Language.ENG => "Disguise",
						Language.JPN => "ばけのかわ",
						Language.GER => "Kostümspuk",
						Language.FRE => "Fantômasque",
						Language.ITA => "Fantasmanto",
						Language.SPN => "Disfraz",
						Language.KOR => "탈",
						Language.CHN_SIM => "画皮",
						Language.CHN_TRA => "畫皮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DOWNLOAD:
					return lang switch {
						Language.ENG => "Download",
						Language.JPN => "ダウンロード",
						Language.GER => "Download",
						Language.FRE => "Télécharge",
						Language.ITA => "Download",
						Language.SPN => "Descarga",
						Language.KOR => "다운로드",
						Language.CHN_SIM => "下载",
						Language.CHN_TRA => "下載",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DRAGON_S_MAW:
					return lang switch {
						Language.ENG => "Dragon's Maw",
						Language.JPN => "りゅうのあぎと",
						Language.GER => "Drachenkiefer",
						Language.FRE => "Dent de Dragon",
						Language.ITA => "Dragomascelle",
						Language.SPN => "Mandíbula Dragón",
						Language.KOR => "용의턱",
						Language.CHN_SIM => "龙颚",
						Language.CHN_TRA => "龍顎",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DRIZZLE:
					return lang switch {
						Language.ENG => "Drizzle",
						Language.JPN => "あめふらし",
						Language.GER => "Niesel",
						Language.FRE => "Crachin",
						Language.ITA => "Piovischio",
						Language.SPN => "Llovizna",
						Language.KOR => "잔비",
						Language.CHN_SIM => "降雨",
						Language.CHN_TRA => "降雨",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DROUGHT:
					return lang switch {
						Language.ENG => "Drought",
						Language.JPN => "ひでり",
						Language.GER => "Dürre",
						Language.FRE => "Sécheresse",
						Language.ITA => "Siccità",
						Language.SPN => "Sequía",
						Language.KOR => "가뭄",
						Language.CHN_SIM => "日照",
						Language.CHN_TRA => "日照",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.DRY_SKIN:
					return lang switch {
						Language.ENG => "Dry Skin",
						Language.JPN => "かんそうはだ",
						Language.GER => "Trockenheit",
						Language.FRE => "Peau Sèche",
						Language.ITA => "Pellearsa",
						Language.SPN => "Piel Seca",
						Language.KOR => "건조피부",
						Language.CHN_SIM => "干燥皮肤",
						Language.CHN_TRA => "乾燥皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.EARLY_BIRD:
					return lang switch {
						Language.ENG => "Early Bird",
						Language.JPN => "はやおき",
						Language.GER => "Frühwecker",
						Language.FRE => "Matinal",
						Language.ITA => "Sveglialampo",
						Language.SPN => "Madrugar",
						Language.KOR => "일찍기상",
						Language.CHN_SIM => "早起",
						Language.CHN_TRA => "早起",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.EARTH_EATER:
					return lang switch {
						Language.ENG => "Earth Eater",
						Language.JPN => "どしょく",
						Language.GER => "Bodenschmaus",
						Language.FRE => "Absorbe-Terre",
						Language.ITA => "Mangiaterra",
						Language.SPN => "Geofagia",
						Language.KOR => "흙먹기",
						Language.CHN_SIM => "食土",
						Language.CHN_TRA => "食土",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.EFFECT_SPORE:
					return lang switch {
						Language.ENG => "Effect Spore",
						Language.JPN => "ほうし",
						Language.GER => "Sporenwirt",
						Language.FRE => "Pose Spore",
						Language.ITA => "Spargispora",
						Language.SPN => "Efecto Espora",
						Language.KOR => "포자",
						Language.CHN_SIM => "孢子",
						Language.CHN_TRA => "孢子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ELECTRIC_SURGE:
					return lang switch {
						Language.ENG => "Electric Surge",
						Language.JPN => "エレキメイカー",
						Language.GER => "Elektro-Erzeuger",
						Language.FRE => "Créa-Élec",
						Language.ITA => "Elettrogenesi",
						Language.SPN => "Electrogénesis",
						Language.KOR => "일렉트릭메이커",
						Language.CHN_SIM => "电气制造者",
						Language.CHN_TRA => "電氣製造者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ELECTROMORPHOSIS:
					return lang switch {
						Language.ENG => "Electromorphosis",
						Language.JPN => "でんきにかえる",
						Language.GER => "Dynamo",
						Language.FRE => "Grecharge",
						Language.ITA => "Convertivolt",
						Language.SPN => "Dinamo",
						Language.KOR => "전기로바꾸기",
						Language.CHN_SIM => "电力转换",
						Language.CHN_TRA => "電力轉換",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.EMERGENCY_EXIT:
					return lang switch {
						Language.ENG => "Emergency Exit",
						Language.JPN => "ききかいひ",
						Language.GER => "Rückzug",
						Language.FRE => "Repli Tactique",
						Language.ITA => "Passoindietro",
						Language.SPN => "Retirada",
						Language.KOR => "위기회피",
						Language.CHN_SIM => "危险回避",
						Language.CHN_TRA => "危險迴避",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FAIRY_AURA:
					return lang switch {
						Language.ENG => "Fairy Aura",
						Language.JPN => "フェアリーオーラ",
						Language.GER => "Feenaura",
						Language.FRE => "Aura Féérique",
						Language.ITA => "Aurafolletto",
						Language.SPN => "Aura Feérica",
						Language.KOR => "페어리오라",
						Language.CHN_SIM => "妖精气场",
						Language.CHN_TRA => "妖精氣場",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FILTER:
					return lang switch {
						Language.ENG => "Filter",
						Language.JPN => "フィルター",
						Language.GER => "Filter",
						Language.FRE => "Filtre",
						Language.ITA => "Filtro",
						Language.SPN => "Filtro",
						Language.KOR => "필터",
						Language.CHN_SIM => "过滤",
						Language.CHN_TRA => "過濾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FLAME_BODY:
					return lang switch {
						Language.ENG => "Flame Body",
						Language.JPN => "ほのおのからだ",
						Language.GER => "Flammkörper",
						Language.FRE => "Corps Ardent",
						Language.ITA => "Corpodifuoco",
						Language.SPN => "Cuerpo Llama",
						Language.KOR => "불꽃몸",
						Language.CHN_SIM => "火焰之躯",
						Language.CHN_TRA => "火焰之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FLARE_BOOST:
					return lang switch {
						Language.ENG => "Flare Boost",
						Language.JPN => "ねつぼうそう",
						Language.GER => "Hitzewahn",
						Language.FRE => "Rage Brûlure",
						Language.ITA => "Bruciaimpeto",
						Language.SPN => "Ímpetu Ardiente",
						Language.KOR => "열폭주",
						Language.CHN_SIM => "受热激升",
						Language.CHN_TRA => "受熱激升",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FLASH_FIRE:
					return lang switch {
						Language.ENG => "Flash Fire",
						Language.JPN => "もらいび",
						Language.GER => "Feuerfänger",
						Language.FRE => "Torche",
						Language.ITA => "Fuocardore",
						Language.SPN => "Absorbe Fuego",
						Language.KOR => "타오르는불꽃",
						Language.CHN_SIM => "引火",
						Language.CHN_TRA => "引火",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FLOWER_GIFT:
					return lang switch {
						Language.ENG => "Flower Gift",
						Language.JPN => "フラワーギフト",
						Language.GER => "Pflanzengabe",
						Language.FRE => "Don Floral",
						Language.ITA => "Regalfiore",
						Language.SPN => "Don Floral",
						Language.KOR => "플라워기프트",
						Language.CHN_SIM => "花之礼",
						Language.CHN_TRA => "花之禮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FLOWER_VEIL:
					return lang switch {
						Language.ENG => "Flower Veil",
						Language.JPN => "フラワーベール",
						Language.GER => "Blütenhülle",
						Language.FRE => "Flora-Voile",
						Language.ITA => "Fiorvelo",
						Language.SPN => "Velo Flor",
						Language.KOR => "플라워베일",
						Language.CHN_SIM => "花幕",
						Language.CHN_TRA => "花幕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FLUFFY:
					return lang switch {
						Language.ENG => "Fluffy",
						Language.JPN => "もふもふ",
						Language.GER => "Flauschigkeit",
						Language.FRE => "Boule de Poils",
						Language.ITA => "Morbidone",
						Language.SPN => "Peluche",
						Language.KOR => "복슬복슬",
						Language.CHN_SIM => "毛茸茸",
						Language.CHN_TRA => "毛茸茸",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FORECAST:
					return lang switch {
						Language.ENG => "Forecast",
						Language.JPN => "てんきや",
						Language.GER => "Prognose",
						Language.FRE => "Météo",
						Language.ITA => "Previsioni",
						Language.SPN => "Predicción",
						Language.KOR => "기분파",
						Language.CHN_SIM => "阴晴不定",
						Language.CHN_TRA => "陰晴不定",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FOREWARN:
					return lang switch {
						Language.ENG => "Forewarn",
						Language.JPN => "よちむ",
						Language.GER => "Vorwarnung",
						Language.FRE => "Prédiction",
						Language.ITA => "Premonizione",
						Language.SPN => "Alerta",
						Language.KOR => "예지몽",
						Language.CHN_SIM => "预知梦",
						Language.CHN_TRA => "預知夢",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FRIEND_GUARD:
					return lang switch {
						Language.ENG => "Friend Guard",
						Language.JPN => "フレンドガード",
						Language.GER => "Freundeshut",
						Language.FRE => "Garde Amie",
						Language.ITA => "Amicoscudo",
						Language.SPN => "Compiescolta",
						Language.KOR => "프렌드가드",
						Language.CHN_SIM => "友情防守",
						Language.CHN_TRA => "友情防守",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FRISK:
					return lang switch {
						Language.ENG => "Frisk",
						Language.JPN => "おみとおし",
						Language.GER => "Schnüffler",
						Language.FRE => "Fouille",
						Language.ITA => "Indagine",
						Language.SPN => "Cacheo",
						Language.KOR => "통찰",
						Language.CHN_SIM => "察觉",
						Language.CHN_TRA => "察覺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FULL_METAL_BODY:
					return lang switch {
						Language.ENG => "Full Metal Body",
						Language.JPN => "メタルプロテクト",
						Language.GER => "Metallprotektor",
						Language.FRE => "Métallo-Garde",
						Language.ITA => "Metalprotezione",
						Language.SPN => "Guardia Metálica",
						Language.KOR => "메탈프로텍트",
						Language.CHN_SIM => "金属防护",
						Language.CHN_TRA => "金屬防護",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.FUR_COAT:
					return lang switch {
						Language.ENG => "Fur Coat",
						Language.JPN => "ファーコート",
						Language.GER => "Fellkleid",
						Language.FRE => "Toison Épaisse",
						Language.ITA => "Foltopelo",
						Language.SPN => "Pelaje Recio",
						Language.KOR => "퍼코트",
						Language.CHN_SIM => "毛皮大衣",
						Language.CHN_TRA => "毛皮大衣",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GALE_WINGS:
					return lang switch {
						Language.ENG => "Gale Wings",
						Language.JPN => "はやてのつばさ",
						Language.GER => "Orkanschwingen",
						Language.FRE => "Ailes Bourrasque",
						Language.ITA => "Aliraffica",
						Language.SPN => "Alas Vendaval",
						Language.KOR => "질풍날개",
						Language.CHN_SIM => "疾风之翼",
						Language.CHN_TRA => "疾風之翼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GALVANIZE:
					return lang switch {
						Language.ENG => "Galvanize",
						Language.JPN => "エレキスキン",
						Language.GER => "Elektrohaut",
						Language.FRE => "Peau Électrique",
						Language.ITA => "Pellelettro",
						Language.SPN => "Piel Eléctrica",
						Language.KOR => "일렉트릭스킨",
						Language.CHN_SIM => "电气皮肤",
						Language.CHN_TRA => "電氣皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GLUTTONY:
					return lang switch {
						Language.ENG => "Gluttony",
						Language.JPN => "くいしんぼう",
						Language.GER => "Völlerei",
						Language.FRE => "Gloutonnerie",
						Language.ITA => "Voracità",
						Language.SPN => "Gula",
						Language.KOR => "먹보",
						Language.CHN_SIM => "贪吃鬼",
						Language.CHN_TRA => "貪吃鬼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GOOD_AS_GOLD:
					return lang switch {
						Language.ENG => "Good as Gold",
						Language.JPN => "おうごんのからだ",
						Language.GER => "Goldkörper",
						Language.FRE => "Corps en Or",
						Language.ITA => "Corpo Aureo",
						Language.SPN => "Cuerpo Áureo",
						Language.KOR => "황금몸",
						Language.CHN_SIM => "黄金之躯",
						Language.CHN_TRA => "黃金之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GOOEY:
					return lang switch {
						Language.ENG => "Gooey",
						Language.JPN => "ぬめぬめ",
						Language.GER => "Viskosität",
						Language.FRE => "Poisseux",
						Language.ITA => "Viscosità",
						Language.SPN => "Baba",
						Language.KOR => "미끈미끈",
						Language.CHN_SIM => "黏滑",
						Language.CHN_TRA => "黏滑",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GORILLA_TACTICS:
					return lang switch {
						Language.ENG => "Gorilla Tactics",
						Language.JPN => "ごりむちゅう",
						Language.GER => "Affenfokus",
						Language.FRE => "Entêtement",
						Language.ITA => "Vigorilla",
						Language.SPN => "Monotema",
						Language.KOR => "무아지경",
						Language.CHN_SIM => "一猩一意",
						Language.CHN_TRA => "一猩一意",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GRASS_PELT:
					return lang switch {
						Language.ENG => "Grass Pelt",
						Language.JPN => "くさのけがわ",
						Language.GER => "Pflanzenpelz",
						Language.FRE => "Toison Herbue",
						Language.ITA => "Peloderba",
						Language.SPN => "Manto Frondoso",
						Language.KOR => "풀모피",
						Language.CHN_SIM => "草之毛皮",
						Language.CHN_TRA => "草之毛皮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GRASSY_SURGE:
					return lang switch {
						Language.ENG => "Grassy Surge",
						Language.JPN => "グラスメイカー",
						Language.GER => "Gras-Erzeuger",
						Language.FRE => "Créa-Herbe",
						Language.ITA => "Erbogenesi",
						Language.SPN => "Herbogénesis",
						Language.KOR => "그래스메이커",
						Language.CHN_SIM => "青草制造者",
						Language.CHN_TRA => "青草製造者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GRIM_NEIGH:
					return lang switch {
						Language.ENG => "Grim Neigh",
						Language.JPN => "くろのいななき",
						Language.GER => "Dunkles Wiehern",
						Language.FRE => "Sombre Ruade",
						Language.ITA => "Nitrito Nero",
						Language.SPN => "Relincho Negro",
						Language.KOR => "흑의울음",
						Language.CHN_SIM => "漆黑嘶鸣",
						Language.CHN_TRA => "漆黑嘶鳴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GUARD_DOG:
					return lang switch {
						Language.ENG => "Guard Dog",
						Language.JPN => "ばんけん",
						Language.GER => "Wachhund",
						Language.FRE => "Chien de Garde",
						Language.ITA => "Cane da Guardia",
						Language.SPN => "Perro Guardián",
						Language.KOR => "파수견",
						Language.CHN_SIM => "看门犬",
						Language.CHN_TRA => "看門犬",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GULP_MISSILE:
					return lang switch {
						Language.ENG => "Gulp Missile",
						Language.JPN => "うのミサイル",
						Language.GER => "Würggeschoss",
						Language.FRE => "Dégobage",
						Language.ITA => "Inghiottimissile",
						Language.SPN => "Tragamisil",
						Language.KOR => "그대로꿀꺽미사일",
						Language.CHN_SIM => "一口导弹",
						Language.CHN_TRA => "一口飛彈",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.GUTS:
					return lang switch {
						Language.ENG => "Guts",
						Language.JPN => "こんじょう",
						Language.GER => "Adrenalin",
						Language.FRE => "Cran",
						Language.ITA => "Dentistretti",
						Language.SPN => "Agallas",
						Language.KOR => "근성",
						Language.CHN_SIM => "毅力",
						Language.CHN_TRA => "毅力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HADRON_ENGINE:
					return lang switch {
						Language.ENG => "Hadron Engine",
						Language.JPN => "ハドロンエンジン",
						Language.GER => "Hadronen-Motor",
						Language.FRE => "Moteur à Hadrons",
						Language.ITA => "Motore Adronico",
						Language.SPN => "Motor Hadrónico",
						Language.KOR => "하드론엔진",
						Language.CHN_SIM => "强子引擎",
						Language.CHN_TRA => "強子引擎",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HARVEST:
					return lang switch {
						Language.ENG => "Harvest",
						Language.JPN => "しゅうかく",
						Language.GER => "Reiche Ernte",
						Language.FRE => "Récolte",
						Language.ITA => "Coglibacche",
						Language.SPN => "Cosecha",
						Language.KOR => "수확",
						Language.CHN_SIM => "收获",
						Language.CHN_TRA => "收穫",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HEALER:
					return lang switch {
						Language.ENG => "Healer",
						Language.JPN => "いやしのこころ",
						Language.GER => "Heilherz",
						Language.FRE => "Cœur Soin",
						Language.ITA => "Curacuore",
						Language.SPN => "Alma Cura",
						Language.KOR => "치유의마음",
						Language.CHN_SIM => "治愈之心",
						Language.CHN_TRA => "治癒之心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HEATPROOF:
					return lang switch {
						Language.ENG => "Heatproof",
						Language.JPN => "たいねつ",
						Language.GER => "Hitzeschutz",
						Language.FRE => "Ignifugé",
						Language.ITA => "Antifuoco",
						Language.SPN => "Ignífugo",
						Language.KOR => "내열",
						Language.CHN_SIM => "耐热",
						Language.CHN_TRA => "耐熱",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HEAVY_METAL:
					return lang switch {
						Language.ENG => "Heavy Metal",
						Language.JPN => "ヘヴィメタル",
						Language.GER => "Schwermetall",
						Language.FRE => "Heavy Metal",
						Language.ITA => "Metalpesante",
						Language.SPN => "Metal Pesado",
						Language.KOR => "헤비메탈",
						Language.CHN_SIM => "重金属",
						Language.CHN_TRA => "重金屬",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HONEY_GATHER:
					return lang switch {
						Language.ENG => "Honey Gather",
						Language.JPN => "みつあつめ",
						Language.GER => "Honigmaul",
						Language.FRE => "Cherche Miel",
						Language.ITA => "Mielincetta",
						Language.SPN => "Recogemiel",
						Language.KOR => "꿀모으기",
						Language.CHN_SIM => "采蜜",
						Language.CHN_TRA => "採蜜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HUGE_POWER:
					return lang switch {
						Language.ENG => "Huge Power",
						Language.JPN => "ちからもち",
						Language.GER => "Kraftkoloss",
						Language.FRE => "Coloforce",
						Language.ITA => "Macroforza",
						Language.SPN => "Potencia",
						Language.KOR => "천하장사",
						Language.CHN_SIM => "大力士",
						Language.CHN_TRA => "大力士",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HUNGER_SWITCH:
					return lang switch {
						Language.ENG => "Hunger Switch",
						Language.JPN => "はらぺこスイッチ",
						Language.GER => "Heißhunger",
						Language.FRE => "Déclic Fringale",
						Language.ITA => "Pancialterna",
						Language.SPN => "Mutapetito",
						Language.KOR => "꼬르륵스위치",
						Language.CHN_SIM => "饱了又饿",
						Language.CHN_TRA => "飽了又餓",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HUSTLE:
					return lang switch {
						Language.ENG => "Hustle",
						Language.JPN => "はりきり",
						Language.GER => "Übereifer",
						Language.FRE => "Agitation",
						Language.ITA => "Tuttafretta",
						Language.SPN => "Entusiasmo",
						Language.KOR => "의욕",
						Language.CHN_SIM => "活力",
						Language.CHN_TRA => "活力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HYDRATION:
					return lang switch {
						Language.ENG => "Hydration",
						Language.JPN => "うるおいボディ",
						Language.GER => "Hydration",
						Language.FRE => "Hydratation",
						Language.ITA => "Idratazione",
						Language.SPN => "Hidratación",
						Language.KOR => "촉촉바디",
						Language.CHN_SIM => "湿润之躯",
						Language.CHN_TRA => "濕潤之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.HYPER_CUTTER:
					return lang switch {
						Language.ENG => "Hyper Cutter",
						Language.JPN => "かいりきバサミ",
						Language.GER => "Scherenmacht",
						Language.FRE => "Hyper Cutter",
						Language.ITA => "Ipertaglio",
						Language.SPN => "Corte Fuerte",
						Language.KOR => "괴력집게",
						Language.CHN_SIM => "怪力钳",
						Language.CHN_TRA => "怪力鉗",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ICE_BODY:
					return lang switch {
						Language.ENG => "Ice Body",
						Language.JPN => "アイスボディ",
						Language.GER => "Eishaut",
						Language.FRE => "Corps Gel",
						Language.ITA => "Corpogelo",
						Language.SPN => "Gélido",
						Language.KOR => "아이스바디",
						Language.CHN_SIM => "冰冻之躯",
						Language.CHN_TRA => "冰凍之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ICE_FACE:
					return lang switch {
						Language.ENG => "Ice Face",
						Language.JPN => "アイスフェイス",
						Language.GER => "Tiefkühlkopf",
						Language.FRE => "Tête de Gel",
						Language.ITA => "Gelofaccia",
						Language.SPN => "Cara de Hielo",
						Language.KOR => "아이스페이스",
						Language.CHN_SIM => "结冻头",
						Language.CHN_TRA => "結凍頭",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ICE_SCALES:
					return lang switch {
						Language.ENG => "Ice Scales",
						Language.JPN => "こおりのりんぷん",
						Language.GER => "Eisflügelstaub",
						Language.FRE => "Écailles Glacées",
						Language.ITA => "Geloscaglie",
						Language.SPN => "Escama de Hielo",
						Language.KOR => "얼음인분",
						Language.CHN_SIM => "冰鳞粉",
						Language.CHN_TRA => "冰鱗粉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ILLUMINATE:
					return lang switch {
						Language.ENG => "Illuminate",
						Language.JPN => "はっこう",
						Language.GER => "Erleuchtung",
						Language.FRE => "Lumiattirance",
						Language.ITA => "Risplendi",
						Language.SPN => "Iluminación",
						Language.KOR => "발광",
						Language.CHN_SIM => "发光",
						Language.CHN_TRA => "發光",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ILLUSION:
					return lang switch {
						Language.ENG => "Illusion",
						Language.JPN => "イリュージョン",
						Language.GER => "Trugbild",
						Language.FRE => "Illusion",
						Language.ITA => "Illusione",
						Language.SPN => "Ilusión",
						Language.KOR => "일루전",
						Language.CHN_SIM => "幻觉",
						Language.CHN_TRA => "幻覺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.IMMUNITY:
					return lang switch {
						Language.ENG => "Immunity",
						Language.JPN => "めんえき",
						Language.GER => "Immunität",
						Language.FRE => "Vaccin",
						Language.ITA => "Immunità",
						Language.SPN => "Inmunidad",
						Language.KOR => "면역",
						Language.CHN_SIM => "免疫",
						Language.CHN_TRA => "免疫",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.IMPOSTER:
					return lang switch {
						Language.ENG => "Imposter",
						Language.JPN => "かわりもの",
						Language.GER => "Doppelgänger",
						Language.FRE => "Imposteur",
						Language.ITA => "Sosia",
						Language.SPN => "Impostor",
						Language.KOR => "괴짜",
						Language.CHN_SIM => "变身者",
						Language.CHN_TRA => "變身者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.INFILTRATOR:
					return lang switch {
						Language.ENG => "Infiltrator",
						Language.JPN => "すりぬけ",
						Language.GER => "Schwebedurch",
						Language.FRE => "Infiltration",
						Language.ITA => "Intrapasso",
						Language.SPN => "Allanamiento",
						Language.KOR => "틈새포착",
						Language.CHN_SIM => "穿透",
						Language.CHN_TRA => "穿透",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.INNARDS_OUT:
					return lang switch {
						Language.ENG => "Innards Out",
						Language.JPN => "とびだすなかみ",
						Language.GER => "Magenkrempler",
						Language.FRE => "Expuls'Organes",
						Language.ITA => "Espellinterno",
						Language.SPN => "Revés",
						Language.KOR => "내용물분출",
						Language.CHN_SIM => "飞出的内在物",
						Language.CHN_TRA => "飛出的內在物",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.INNER_FOCUS:
					return lang switch {
						Language.ENG => "Inner Focus",
						Language.JPN => "せいしんりょく",
						Language.GER => "Konzentrator",
						Language.FRE => "Attention",
						Language.ITA => "Forza Interiore",
						Language.SPN => "Foco Interno",
						Language.KOR => "정신력",
						Language.CHN_SIM => "精神力",
						Language.CHN_TRA => "精神力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.INSOMNIA:
					return lang switch {
						Language.ENG => "Insomnia",
						Language.JPN => "ふみん",
						Language.GER => "Insomnia",
						Language.FRE => "Insomnia",
						Language.ITA => "Insonnia",
						Language.SPN => "Insomnio",
						Language.KOR => "불면",
						Language.CHN_SIM => "不眠",
						Language.CHN_TRA => "不眠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.INTIMIDATE:
					return lang switch {
						Language.ENG => "Intimidate",
						Language.JPN => "いかく",
						Language.GER => "Bedroher",
						Language.FRE => "Intimidation",
						Language.ITA => "Prepotenza",
						Language.SPN => "Intimidación",
						Language.KOR => "위협",
						Language.CHN_SIM => "威吓",
						Language.CHN_TRA => "威嚇",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.INTREPID_SWORD:
					return lang switch {
						Language.ENG => "Intrepid Sword",
						Language.JPN => "ふとうのけん",
						Language.GER => "Kühnes Schwert",
						Language.FRE => "Lame Indomptable",
						Language.ITA => "Spada Indomita",
						Language.SPN => "Espada Indómita",
						Language.KOR => "불요의검",
						Language.CHN_SIM => "不挠之剑",
						Language.CHN_TRA => "不撓之劍",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.IRON_BARBS:
					return lang switch {
						Language.ENG => "Iron Barbs",
						Language.JPN => "てつのトゲ",
						Language.GER => "Eisenstachel",
						Language.FRE => "Épine de Fer",
						Language.ITA => "Spineferrate",
						Language.SPN => "Punta Acero",
						Language.KOR => "철가시",
						Language.CHN_SIM => "铁刺",
						Language.CHN_TRA => "鐵刺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.IRON_FIST:
					return lang switch {
						Language.ENG => "Iron Fist",
						Language.JPN => "てつのこぶし",
						Language.GER => "Eisenfaust",
						Language.FRE => "Poing de Fer",
						Language.ITA => "Ferropugno",
						Language.SPN => "Puño Férreo",
						Language.KOR => "철주먹",
						Language.CHN_SIM => "铁拳",
						Language.CHN_TRA => "鐵拳",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.JUSTIFIED:
					return lang switch {
						Language.ENG => "Justified",
						Language.JPN => "せいぎのこころ",
						Language.GER => "Redlichkeit",
						Language.FRE => "Cœur Noble",
						Language.ITA => "Giustizia",
						Language.SPN => "Justiciero",
						Language.KOR => "정의의마음",
						Language.CHN_SIM => "正义之心",
						Language.CHN_TRA => "正義之心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.KEEN_EYE:
					return lang switch {
						Language.ENG => "Keen Eye",
						Language.JPN => "するどいめ",
						Language.GER => "Adlerauge",
						Language.FRE => "Regard Vif",
						Language.ITA => "Sguardofermo",
						Language.SPN => "Vista Lince",
						Language.KOR => "날카로운눈",
						Language.CHN_SIM => "锐利目光",
						Language.CHN_TRA => "銳利目光",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.KLUTZ:
					return lang switch {
						Language.ENG => "Klutz",
						Language.JPN => "ぶきよう",
						Language.GER => "Tollpatsch",
						Language.FRE => "Maladresse",
						Language.ITA => "Impaccio",
						Language.SPN => "Zoquete",
						Language.KOR => "서투름",
						Language.CHN_SIM => "笨拙",
						Language.CHN_TRA => "笨拙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LEAF_GUARD:
					return lang switch {
						Language.ENG => "Leaf Guard",
						Language.JPN => "リーフガード",
						Language.GER => "Floraschild",
						Language.FRE => "Feuille Garde",
						Language.ITA => "Fogliamanto",
						Language.SPN => "Defensa Hoja",
						Language.KOR => "리프가드",
						Language.CHN_SIM => "叶子防守",
						Language.CHN_TRA => "葉子防守",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LEVITATE:
					return lang switch {
						Language.ENG => "Levitate",
						Language.JPN => "ふゆう",
						Language.GER => "Schwebe",
						Language.FRE => "Lévitation",
						Language.ITA => "Levitazione",
						Language.SPN => "Levitación",
						Language.KOR => "부유",
						Language.CHN_SIM => "飘浮",
						Language.CHN_TRA => "飄浮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LIBERO:
					return lang switch {
						Language.ENG => "Libero",
						Language.JPN => "リベロ",
						Language.GER => "Libero",
						Language.FRE => "Libéro",
						Language.ITA => "Libero",
						Language.SPN => "Líbero",
						Language.KOR => "리베로",
						Language.CHN_SIM => "自由者",
						Language.CHN_TRA => "自由者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LIGHT_METAL:
					return lang switch {
						Language.ENG => "Light Metal",
						Language.JPN => "ライトメタル",
						Language.GER => "Leichtmetall",
						Language.FRE => "Light Metal",
						Language.ITA => "Metalleggero",
						Language.SPN => "Metal Liviano",
						Language.KOR => "라이트메탈",
						Language.CHN_SIM => "轻金属",
						Language.CHN_TRA => "輕金屬",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LIGHTNING_ROD:
					return lang switch {
						Language.ENG => "Lightning Rod",
						Language.JPN => "ひらいしん",
						Language.GER => "Blitzfänger",
						Language.FRE => "Paratonnerre",
						Language.ITA => "Parafulmine",
						Language.SPN => "Pararrayos",
						Language.KOR => "피뢰침",
						Language.CHN_SIM => "避雷针",
						Language.CHN_TRA => "避雷針",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LIMBER:
					return lang switch {
						Language.ENG => "Limber",
						Language.JPN => "じゅうなん",
						Language.GER => "Flexibilität",
						Language.FRE => "Échauffement",
						Language.ITA => "Scioltezza",
						Language.SPN => "Flexibilidad",
						Language.KOR => "유연",
						Language.CHN_SIM => "柔软",
						Language.CHN_TRA => "柔軟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LINGERING_AROMA:
					return lang switch {
						Language.ENG => "Lingering Aroma",
						Language.JPN => "とれないにおい",
						Language.GER => "Duftschwade",
						Language.FRE => "Odeur Tenace",
						Language.ITA => "Odore Tenace",
						Language.SPN => "Olor Persistente",
						Language.KOR => "가시지않는향기",
						Language.CHN_SIM => "甩不掉的气味",
						Language.CHN_TRA => "甩不掉的氣味",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LIQUID_OOZE:
					return lang switch {
						Language.ENG => "Liquid Ooze",
						Language.JPN => "ヘドロえき",
						Language.GER => "Kloakensoße",
						Language.FRE => "Suintement",
						Language.ITA => "Melma",
						Language.SPN => "Lodo Líquido",
						Language.KOR => "해감액",
						Language.CHN_SIM => "污泥浆",
						Language.CHN_TRA => "污泥漿",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LIQUID_VOICE:
					return lang switch {
						Language.ENG => "Liquid Voice",
						Language.JPN => "うるおいボイス",
						Language.GER => "Plätscherstimme",
						Language.FRE => "Hydrata-Son",
						Language.ITA => "Idrovoce",
						Language.SPN => "Voz Fluida",
						Language.KOR => "촉촉보이스",
						Language.CHN_SIM => "湿润之声",
						Language.CHN_TRA => "濕潤之聲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.LONG_REACH:
					return lang switch {
						Language.ENG => "Long Reach",
						Language.JPN => "えんかく",
						Language.GER => "Langstrecke",
						Language.FRE => "Longue Portée",
						Language.ITA => "Distacco",
						Language.SPN => "Remoto",
						Language.KOR => "원격",
						Language.CHN_SIM => "远隔",
						Language.CHN_TRA => "遠隔",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MAGIC_BOUNCE:
					return lang switch {
						Language.ENG => "Magic Bounce",
						Language.JPN => "マジックミラー",
						Language.GER => "Magiespiegel",
						Language.FRE => "Miroir Magik",
						Language.ITA => "Magispecchio",
						Language.SPN => "Espejo Mágico",
						Language.KOR => "매직미러",
						Language.CHN_SIM => "魔法镜",
						Language.CHN_TRA => "魔法鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MAGIC_GUARD:
					return lang switch {
						Language.ENG => "Magic Guard",
						Language.JPN => "マジックガード",
						Language.GER => "Magieschild",
						Language.FRE => "Garde Magik",
						Language.ITA => "Magicscudo",
						Language.SPN => "Muro Mágico",
						Language.KOR => "매직가드",
						Language.CHN_SIM => "魔法防守",
						Language.CHN_TRA => "魔法防守",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MAGICIAN:
					return lang switch {
						Language.ENG => "Magician",
						Language.JPN => "マジシャン",
						Language.GER => "Zauberer",
						Language.FRE => "Magicien",
						Language.ITA => "Prestigiatore",
						Language.SPN => "Prestidigitador",
						Language.KOR => "매지션",
						Language.CHN_SIM => "魔术师",
						Language.CHN_TRA => "魔術師",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MAGMA_ARMOR:
					return lang switch {
						Language.ENG => "Magma Armor",
						Language.JPN => "マグマのよろい",
						Language.GER => "Magmapanzer",
						Language.FRE => "Armumagma",
						Language.ITA => "Magmascudo",
						Language.SPN => "Escudo Magma",
						Language.KOR => "마그마의무장",
						Language.CHN_SIM => "熔岩铠甲",
						Language.CHN_TRA => "熔岩鎧甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MAGNET_PULL:
					return lang switch {
						Language.ENG => "Magnet Pull",
						Language.JPN => "じりょく",
						Language.GER => "Magnetfalle",
						Language.FRE => "Magnépiège",
						Language.ITA => "Magnetismo",
						Language.SPN => "Imán",
						Language.KOR => "자력",
						Language.CHN_SIM => "磁力",
						Language.CHN_TRA => "磁力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MARVEL_SCALE:
					return lang switch {
						Language.ENG => "Marvel Scale",
						Language.JPN => "ふしぎなうろこ",
						Language.GER => "Notschutz",
						Language.FRE => "Écaille Spéciale",
						Language.ITA => "Pelledura",
						Language.SPN => "Escama Especial",
						Language.KOR => "이상한비늘",
						Language.CHN_SIM => "神奇鳞片",
						Language.CHN_TRA => "神奇鱗片",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MEGA_LAUNCHER:
					return lang switch {
						Language.ENG => "Mega Launcher",
						Language.JPN => "メガランチャー",
						Language.GER => "Megawumme",
						Language.FRE => "Méga Blaster",
						Language.ITA => "Megalancio",
						Language.SPN => "Megadisparador",
						Language.KOR => "메가런처",
						Language.CHN_SIM => "超级发射器",
						Language.CHN_TRA => "超級發射器",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MERCILESS:
					return lang switch {
						Language.ENG => "Merciless",
						Language.JPN => "ひとでなし",
						Language.GER => "Quälerei",
						Language.FRE => "Cruauté",
						Language.ITA => "Spietatezza",
						Language.SPN => "Ensañamiento",
						Language.KOR => "무도한행동",
						Language.CHN_SIM => "不仁不义",
						Language.CHN_TRA => "不仁不義",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MIMICRY:
					return lang switch {
						Language.ENG => "Mimicry",
						Language.JPN => "ぎたい",
						Language.GER => "Mimese",
						Language.FRE => "Mimétisme",
						Language.ITA => "Mimetismo",
						Language.SPN => "Mimetismo",
						Language.KOR => "의태",
						Language.CHN_SIM => "拟态",
						Language.CHN_TRA => "擬態",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MINUS:
					return lang switch {
						Language.ENG => "Minus",
						Language.JPN => "マイナス",
						Language.GER => "Minus",
						Language.FRE => "Minus",
						Language.ITA => "Meno",
						Language.SPN => "Menos",
						Language.KOR => "마이너스",
						Language.CHN_SIM => "负电",
						Language.CHN_TRA => "負電",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MIRROR_ARMOR:
					return lang switch {
						Language.ENG => "Mirror Armor",
						Language.JPN => "ミラーアーマー",
						Language.GER => "Spiegelrüstung",
						Language.FRE => "Armure Miroir",
						Language.ITA => "Blindospecchio",
						Language.SPN => "Coraza Reflejo",
						Language.KOR => "미러아머",
						Language.CHN_SIM => "镜甲",
						Language.CHN_TRA => "鏡甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MISTY_SURGE:
					return lang switch {
						Language.ENG => "Misty Surge",
						Language.JPN => "ミストメイカー",
						Language.GER => "Nebel-Erzeuger",
						Language.FRE => "Créa-Brume",
						Language.ITA => "Nebbiogenesi",
						Language.SPN => "Nebulogénesis",
						Language.KOR => "미스트메이커",
						Language.CHN_SIM => "薄雾制造者",
						Language.CHN_TRA => "薄霧製造者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MOLD_BREAKER:
					return lang switch {
						Language.ENG => "Mold Breaker",
						Language.JPN => "かたやぶり",
						Language.GER => "Überbrückung",
						Language.FRE => "Brise Moule",
						Language.ITA => "Rompiforma",
						Language.SPN => "Rompemoldes",
						Language.KOR => "틀깨기",
						Language.CHN_SIM => "破格",
						Language.CHN_TRA => "破格",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MOODY:
					return lang switch {
						Language.ENG => "Moody",
						Language.JPN => "ムラっけ",
						Language.GER => "Gefühlswippe",
						Language.FRE => "Lunatique",
						Language.ITA => "Altalena",
						Language.SPN => "Veleta",
						Language.KOR => "변덕쟁이",
						Language.CHN_SIM => "心情不定",
						Language.CHN_TRA => "心情不定",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MOTOR_DRIVE:
					return lang switch {
						Language.ENG => "Motor Drive",
						Language.JPN => "でんきエンジン",
						Language.GER => "Starthilfe",
						Language.FRE => "Motorisé",
						Language.ITA => "Elettrorapid",
						Language.SPN => "Electromotor",
						Language.KOR => "전기엔진",
						Language.CHN_SIM => "电气引擎",
						Language.CHN_TRA => "電氣引擎",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MOXIE:
					return lang switch {
						Language.ENG => "Moxie",
						Language.JPN => "じしんかじょう",
						Language.GER => "Hochmut",
						Language.FRE => "Impudence",
						Language.ITA => "Arroganza",
						Language.SPN => "Autoestima",
						Language.KOR => "자기과신",
						Language.CHN_SIM => "自信过度",
						Language.CHN_TRA => "自信過度",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MULTISCALE:
					return lang switch {
						Language.ENG => "Multiscale",
						Language.JPN => "マルチスケイル",
						Language.GER => "Multischuppe",
						Language.FRE => "Multiécaille",
						Language.ITA => "Multisquame",
						Language.SPN => "Compensación",
						Language.KOR => "멀티스케일",
						Language.CHN_SIM => "多重鳞片",
						Language.CHN_TRA => "多重鱗片",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MULTITYPE:
					return lang switch {
						Language.ENG => "Multitype",
						Language.JPN => "マルチタイプ",
						Language.GER => "Variabilität",
						Language.FRE => "Multitype",
						Language.ITA => "Multitipo",
						Language.SPN => "Multitipo",
						Language.KOR => "멀티타입",
						Language.CHN_SIM => "多属性",
						Language.CHN_TRA => "多屬性",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MUMMY:
					return lang switch {
						Language.ENG => "Mummy",
						Language.JPN => "ミイラ",
						Language.GER => "Mumie",
						Language.FRE => "Momie",
						Language.ITA => "Mummia",
						Language.SPN => "Momia",
						Language.KOR => "미라",
						Language.CHN_SIM => "木乃伊",
						Language.CHN_TRA => "木乃伊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.MYCELIUM_MIGHT:
					return lang switch {
						Language.ENG => "Mycelium Might",
						Language.JPN => "きんしのちから",
						Language.GER => "Myzelienkraft",
						Language.FRE => "Force Fongique",
						Language.ITA => "Micoforza",
						Language.SPN => "Poder Fúngico",
						Language.KOR => "균사의힘",
						Language.CHN_SIM => "菌丝之力",
						Language.CHN_TRA => "菌絲之力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.NATURAL_CURE:
					return lang switch {
						Language.ENG => "Natural Cure",
						Language.JPN => "しぜんかいふく",
						Language.GER => "Innere Kraft",
						Language.FRE => "Médic Nature",
						Language.ITA => "Alternacura",
						Language.SPN => "Cura Natural",
						Language.KOR => "자연회복",
						Language.CHN_SIM => "自然回复",
						Language.CHN_TRA => "自然回復",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.NEUROFORCE:
					return lang switch {
						Language.ENG => "Neuroforce",
						Language.JPN => "ブレインフォース",
						Language.GER => "Zerebralmacht",
						Language.FRE => "Cérébro-Force",
						Language.ITA => "Cerebroforza",
						Language.SPN => "Fuerza Cerebral",
						Language.KOR => "브레인포스",
						Language.CHN_SIM => "脑核之力",
						Language.CHN_TRA => "腦核之力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.NEUTRALIZING_GAS:
					return lang switch {
						Language.ENG => "Neutralizing Gas",
						Language.JPN => "かがくへんかガス",
						Language.GER => "Reaktionsgas",
						Language.FRE => "Gaz Inhibiteur",
						Language.ITA => "Gas Reagente",
						Language.SPN => "Gas Reactivo",
						Language.KOR => "화학변화가스",
						Language.CHN_SIM => "化学变化气体",
						Language.CHN_TRA => "化學變化氣體",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.NO_GUARD:
					return lang switch {
						Language.ENG => "No Guard",
						Language.JPN => "ノーガード",
						Language.GER => "Schildlos",
						Language.FRE => "Annule Garde",
						Language.ITA => "Nullodifesa",
						Language.SPN => "Indefenso",
						Language.KOR => "노가드",
						Language.CHN_SIM => "无防守",
						Language.CHN_TRA => "無防守",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.NORMALIZE:
					return lang switch {
						Language.ENG => "Normalize",
						Language.JPN => "ノーマルスキン",
						Language.GER => "Regulierung",
						Language.FRE => "Normalise",
						Language.ITA => "Normalità",
						Language.SPN => "Normalidad",
						Language.KOR => "노말스킨",
						Language.CHN_SIM => "一般皮肤",
						Language.CHN_TRA => "一般皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.OBLIVIOUS:
					return lang switch {
						Language.ENG => "Oblivious",
						Language.JPN => "どんかん",
						Language.GER => "Dösigkeit",
						Language.FRE => "Benêt",
						Language.ITA => "Indifferenza",
						Language.SPN => "Despiste",
						Language.KOR => "둔감",
						Language.CHN_SIM => "迟钝",
						Language.CHN_TRA => "遲鈍",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.OPPORTUNIST:
					return lang switch {
						Language.ENG => "Opportunist",
						Language.JPN => "びんじょう",
						Language.GER => "Profiteur",
						Language.FRE => "Opportuniste",
						Language.ITA => "Scrocco",
						Language.SPN => "Oportunista",
						Language.KOR => "편승",
						Language.CHN_SIM => "跟风",
						Language.CHN_TRA => "跟風",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ORICHALCUM_PULSE:
					return lang switch {
						Language.ENG => "Orichalcum Pulse",
						Language.JPN => "ひひいろのこどう",
						Language.GER => "Orichalkum-Puls",
						Language.FRE => "Pouls Orichalque",
						Language.ITA => "Ritmo d’Oricalco",
						Language.SPN => "Latido Oricalco",
						Language.KOR => "진홍빛고동",
						Language.CHN_SIM => "绯红脉动",
						Language.CHN_TRA => "緋紅脈動",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.OVERCOAT:
					return lang switch {
						Language.ENG => "Overcoat",
						Language.JPN => "ぼうじん",
						Language.GER => "Wetterfest",
						Language.FRE => "Envelocape",
						Language.ITA => "Copricapo",
						Language.SPN => "Funda",
						Language.KOR => "방진",
						Language.CHN_SIM => "防尘",
						Language.CHN_TRA => "防塵",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.OVERGROW:
					return lang switch {
						Language.ENG => "Overgrow",
						Language.JPN => "しんりょく",
						Language.GER => "Notdünger",
						Language.FRE => "Engrais",
						Language.ITA => "Erbaiuto",
						Language.SPN => "Espesura",
						Language.KOR => "심록",
						Language.CHN_SIM => "茂盛",
						Language.CHN_TRA => "茂盛",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.OWN_TEMPO:
					return lang switch {
						Language.ENG => "Own Tempo",
						Language.JPN => "マイペース",
						Language.GER => "Tempomacher",
						Language.FRE => "Tempo Perso",
						Language.ITA => "Mente Locale",
						Language.SPN => "Ritmo Propio",
						Language.KOR => "마이페이스",
						Language.CHN_SIM => "我行我素",
						Language.CHN_TRA => "我行我素",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PARENTAL_BOND:
					return lang switch {
						Language.ENG => "Parental Bond",
						Language.JPN => "おやこあい",
						Language.GER => "Familienbande",
						Language.FRE => "Amour Filial",
						Language.ITA => "Amorefiliale",
						Language.SPN => "Amor Filial",
						Language.KOR => "부자유친",
						Language.CHN_SIM => "亲子爱",
						Language.CHN_TRA => "親子愛",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PASTEL_VEIL:
					return lang switch {
						Language.ENG => "Pastel Veil",
						Language.JPN => "パステルベール",
						Language.GER => "Pastellhülle",
						Language.FRE => "Voile Pastel",
						Language.ITA => "Pastelvelo",
						Language.SPN => "Velo Pastel",
						Language.KOR => "파스텔베일",
						Language.CHN_SIM => "粉彩护幕",
						Language.CHN_TRA => "粉彩護幕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PERISH_BODY:
					return lang switch {
						Language.ENG => "Perish Body",
						Language.JPN => "ほろびのボディ",
						Language.GER => "Unheilskörper",
						Language.FRE => "Corps Condamné",
						Language.ITA => "Ultimotocco",
						Language.SPN => "Cuerpo Mortal",
						Language.KOR => "멸망의바디",
						Language.CHN_SIM => "灭亡之躯",
						Language.CHN_TRA => "滅亡之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PICKPOCKET:
					return lang switch {
						Language.ENG => "Pickpocket",
						Language.JPN => "わるいてぐせ",
						Language.GER => "Langfinger",
						Language.FRE => "Pickpocket",
						Language.ITA => "Arraffalesto",
						Language.SPN => "Hurto",
						Language.KOR => "나쁜손버릇",
						Language.CHN_SIM => "顺手牵羊",
						Language.CHN_TRA => "順手牽羊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PICKUP:
					return lang switch {
						Language.ENG => "Pickup",
						Language.JPN => "ものひろい",
						Language.GER => "Mitnahme",
						Language.FRE => "Ramassage",
						Language.ITA => "Raccolta",
						Language.SPN => "Recogida",
						Language.KOR => "픽업",
						Language.CHN_SIM => "捡拾",
						Language.CHN_TRA => "撿拾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PIXILATE:
					return lang switch {
						Language.ENG => "Pixilate",
						Language.JPN => "フェアリースキン",
						Language.GER => "Feenschicht",
						Language.FRE => "Peau Féérique",
						Language.ITA => "Pellefolletto",
						Language.SPN => "Piel Feérica",
						Language.KOR => "페어리스킨",
						Language.CHN_SIM => "妖精皮肤",
						Language.CHN_TRA => "妖精皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PLUS:
					return lang switch {
						Language.ENG => "Plus",
						Language.JPN => "プラス",
						Language.GER => "Plus",
						Language.FRE => "Plus",
						Language.ITA => "Più",
						Language.SPN => "Más",
						Language.KOR => "플러스",
						Language.CHN_SIM => "正电",
						Language.CHN_TRA => "正電",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.POISON_HEAL:
					return lang switch {
						Language.ENG => "Poison Heal",
						Language.JPN => "ポイズンヒール",
						Language.GER => "Aufheber",
						Language.FRE => "Soin Poison",
						Language.ITA => "Velencura",
						Language.SPN => "Antídoto",
						Language.KOR => "포이즌힐",
						Language.CHN_SIM => "毒疗",
						Language.CHN_TRA => "毒療",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.POISON_POINT:
					return lang switch {
						Language.ENG => "Poison Point",
						Language.JPN => "どくのトゲ",
						Language.GER => "Giftdorn",
						Language.FRE => "Point Poison",
						Language.ITA => "Velenopunto",
						Language.SPN => "Punto Tóxico",
						Language.KOR => "독가시",
						Language.CHN_SIM => "毒刺",
						Language.CHN_TRA => "毒刺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.POISON_TOUCH:
					return lang switch {
						Language.ENG => "Poison Touch",
						Language.JPN => "どくしゅ",
						Language.GER => "Giftgriff",
						Language.FRE => "Toxitouche",
						Language.ITA => "Velentocco",
						Language.SPN => "Toque Tóxico",
						Language.KOR => "독수",
						Language.CHN_SIM => "毒手",
						Language.CHN_TRA => "毒手",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.POWER_CONSTRUCT:
					return lang switch {
						Language.ENG => "Power Construct",
						Language.JPN => "スワームチェンジ",
						Language.GER => "Scharwandel",
						Language.FRE => "Rassemblement",
						Language.ITA => "Sciamefusione",
						Language.SPN => "Agrupamiento",
						Language.KOR => "스웜체인지",
						Language.CHN_SIM => "群聚变形",
						Language.CHN_TRA => "群聚變形",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.POWER_OF_ALCHEMY:
					return lang switch {
						Language.ENG => "Power of Alchemy",
						Language.JPN => "かがくのちから",
						Language.GER => "Chemiekraft",
						Language.FRE => "Osmose",
						Language.ITA => "Forza Chimica",
						Language.SPN => "Reacción Química",
						Language.KOR => "화학의힘",
						Language.CHN_SIM => "化学之力",
						Language.CHN_TRA => "化學之力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.POWER_SPOT:
					return lang switch {
						Language.ENG => "Power Spot",
						Language.JPN => "パワースポット",
						Language.GER => "Kraftquelle",
						Language.FRE => "Cercle d’Énergie",
						Language.ITA => "Fonte Energetica",
						Language.SPN => "Fuente Energía",
						Language.KOR => "파워스폿",
						Language.CHN_SIM => "能量点",
						Language.CHN_TRA => "能量點",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PRANKSTER:
					return lang switch {
						Language.ENG => "Prankster",
						Language.JPN => "いたずらごころ",
						Language.GER => "Strolch",
						Language.FRE => "Farceur",
						Language.ITA => "Burla",
						Language.SPN => "Bromista",
						Language.KOR => "짓궂은마음",
						Language.CHN_SIM => "恶作剧之心",
						Language.CHN_TRA => "惡作劇之心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PRESSURE:
					return lang switch {
						Language.ENG => "Pressure",
						Language.JPN => "プレッシャー",
						Language.GER => "Erzwinger",
						Language.FRE => "Pression",
						Language.ITA => "Pressione",
						Language.SPN => "Presión",
						Language.KOR => "프레셔",
						Language.CHN_SIM => "压迫感",
						Language.CHN_TRA => "壓迫感",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PRIMORDIAL_SEA:
					return lang switch {
						Language.ENG => "Primordial Sea",
						Language.JPN => "はじまりのうみ",
						Language.GER => "Urmeer",
						Language.FRE => "Mer Primaire",
						Language.ITA => "Mare Primordiale",
						Language.SPN => "Mar del Albor",
						Language.KOR => "시작의바다",
						Language.CHN_SIM => "始源之海",
						Language.CHN_TRA => "始源之海",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PRISM_ARMOR:
					return lang switch {
						Language.ENG => "Prism Armor",
						Language.JPN => "プリズムアーマー",
						Language.GER => "Prismarüstung",
						Language.FRE => "Prisme-Armure",
						Language.ITA => "Scudoprisma",
						Language.SPN => "Armadura Prisma",
						Language.KOR => "프리즘아머",
						Language.CHN_SIM => "棱镜装甲",
						Language.CHN_TRA => "稜鏡裝甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PROPELLER_TAIL:
					return lang switch {
						Language.ENG => "Propeller Tail",
						Language.JPN => "スクリューおびれ",
						Language.GER => "Schraubflosse",
						Language.FRE => "Propulseur",
						Language.ITA => "Elicopinna",
						Language.SPN => "Hélice Caudal",
						Language.KOR => "스크루지느러미",
						Language.CHN_SIM => "螺旋尾鳍",
						Language.CHN_TRA => "螺旋尾鰭",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PROTEAN:
					return lang switch {
						Language.ENG => "Protean",
						Language.JPN => "へんげんじざい",
						Language.GER => "Wandlungskunst",
						Language.FRE => "Protéen",
						Language.ITA => "Mutatipo",
						Language.SPN => "Mutatipo",
						Language.KOR => "변환자재",
						Language.CHN_SIM => "变幻自如",
						Language.CHN_TRA => "變幻自如",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PROTOSYNTHESIS:
					return lang switch {
						Language.ENG => "Protosynthesis",
						Language.JPN => "こだいかっせい",
						Language.GER => "Paläosynthese",
						Language.FRE => "Paléosynthèse",
						Language.ITA => "Paleoattivazione",
						Language.SPN => "Paleosíntesis",
						Language.KOR => "고대활성",
						Language.CHN_SIM => "古代活性",
						Language.CHN_TRA => "古代活性",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PSYCHIC_SURGE:
					return lang switch {
						Language.ENG => "Psychic Surge",
						Language.JPN => "サイコメイカー",
						Language.GER => "Psycho-Erzeuger",
						Language.FRE => "Créa-Psy",
						Language.ITA => "Psicogenesi",
						Language.SPN => "Psicogénesis",
						Language.KOR => "사이코메이커",
						Language.CHN_SIM => "精神制造者",
						Language.CHN_TRA => "精神製造者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PUNK_ROCK:
					return lang switch {
						Language.ENG => "Punk Rock",
						Language.JPN => "パンクロック",
						Language.GER => "Punk Rock",
						Language.FRE => "Punk Rock",
						Language.ITA => "Punk Rock",
						Language.SPN => "Punk Rock",
						Language.KOR => "펑크록",
						Language.CHN_SIM => "庞克摇滚",
						Language.CHN_TRA => "龐克搖滾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PURE_POWER:
					return lang switch {
						Language.ENG => "Pure Power",
						Language.JPN => "ヨガパワー",
						Language.GER => "Mentalkraft",
						Language.FRE => "Force Pure",
						Language.ITA => "Forzapura",
						Language.SPN => "Energía pura",
						Language.KOR => "순수한힘",
						Language.CHN_SIM => "瑜伽之力",
						Language.CHN_TRA => "瑜伽之力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.PURIFYING_SALT:
					return lang switch {
						Language.ENG => "Purifying Salt",
						Language.JPN => "きよめのしお",
						Language.GER => "Läutersalz",
						Language.FRE => "Sel Purificateur",
						Language.ITA => "Sale Purificante",
						Language.SPN => "Sal Purificadora",
						Language.KOR => "정화의소금",
						Language.CHN_SIM => "洁净之盐",
						Language.CHN_TRA => "潔淨之鹽",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.QUARK_DRIVE:
					return lang switch {
						Language.ENG => "Quark Drive",
						Language.JPN => "クォークチャージ",
						Language.GER => "Quantenantrieb",
						Language.FRE => "Charge Quantique",
						Language.ITA => "Carica Quark",
						Language.SPN => "Carga Cuark",
						Language.KOR => "쿼크차지",
						Language.CHN_SIM => "夸克充能",
						Language.CHN_TRA => "夸克充能",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.QUEENLY_MAJESTY:
					return lang switch {
						Language.ENG => "Queenly Majesty",
						Language.JPN => "じょおうのいげん",
						Language.GER => "Majestät",
						Language.FRE => "Prestance Royale",
						Language.ITA => "Regalità",
						Language.SPN => "Regia Presencia",
						Language.KOR => "여왕의위엄",
						Language.CHN_SIM => "女王的威严",
						Language.CHN_TRA => "女王的威嚴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.QUICK_DRAW:
					return lang switch {
						Language.ENG => "Quick Draw",
						Language.JPN => "クイックドロウ",
						Language.GER => "Schnellschuss",
						Language.FRE => "Tir Vif",
						Language.ITA => "Colpolesto",
						Language.SPN => "Mano Rápida",
						Language.KOR => "퀵드로",
						Language.CHN_SIM => "速击",
						Language.CHN_TRA => "速擊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.QUICK_FEET:
					return lang switch {
						Language.ENG => "Quick Feet",
						Language.JPN => "はやあし",
						Language.GER => "Rasanz",
						Language.FRE => "Pied Véloce",
						Language.ITA => "Piedisvelti",
						Language.SPN => "Pies Rápidos",
						Language.KOR => "속보",
						Language.CHN_SIM => "飞毛腿",
						Language.CHN_TRA => "飛毛腿",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RAIN_DISH:
					return lang switch {
						Language.ENG => "Rain Dish",
						Language.JPN => "あめうけざら",
						Language.GER => "Regengenuss",
						Language.FRE => "Cuvette",
						Language.ITA => "Copripioggia",
						Language.SPN => "Cura Lluvia",
						Language.KOR => "젖은접시",
						Language.CHN_SIM => "雨盘",
						Language.CHN_TRA => "雨盤",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RATTLED:
					return lang switch {
						Language.ENG => "Rattled",
						Language.JPN => "びびり",
						Language.GER => "Hasenfuß",
						Language.FRE => "Phobique",
						Language.ITA => "Paura",
						Language.SPN => "Cobardía",
						Language.KOR => "주눅",
						Language.CHN_SIM => "胆怯",
						Language.CHN_TRA => "膽怯",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RECEIVER:
					return lang switch {
						Language.ENG => "Receiver",
						Language.JPN => "レシーバー",
						Language.GER => "Receiver",
						Language.FRE => "Receveur",
						Language.ITA => "Ricezione",
						Language.SPN => "Receptor",
						Language.KOR => "리시버",
						Language.CHN_SIM => "接球手",
						Language.CHN_TRA => "接球手",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RECKLESS:
					return lang switch {
						Language.ENG => "Reckless",
						Language.JPN => "すてみ",
						Language.GER => "Achtlos",
						Language.FRE => "Téméraire",
						Language.ITA => "Temerarietà",
						Language.SPN => "Audaz",
						Language.KOR => "이판사판",
						Language.CHN_SIM => "舍身",
						Language.CHN_TRA => "捨身",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.REFRIGERATE:
					return lang switch {
						Language.ENG => "Refrigerate",
						Language.JPN => "フリーズスキン",
						Language.GER => "Frostschicht",
						Language.FRE => "Peau Gelée",
						Language.ITA => "Pellegelo",
						Language.SPN => "Piel Helada",
						Language.KOR => "프리즈스킨",
						Language.CHN_SIM => "冰冻皮肤",
						Language.CHN_TRA => "冰凍皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.REGENERATOR:
					return lang switch {
						Language.ENG => "Regenerator",
						Language.JPN => "さいせいりょく",
						Language.GER => "Belebekraft",
						Language.FRE => "Régé-Force",
						Language.ITA => "Rigenergia",
						Language.SPN => "Regeneración",
						Language.KOR => "재생력",
						Language.CHN_SIM => "再生力",
						Language.CHN_TRA => "再生力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RIPEN:
					return lang switch {
						Language.ENG => "Ripen",
						Language.JPN => "じゅくせい",
						Language.GER => "Heranreifen",
						Language.FRE => "Mûrissement",
						Language.ITA => "Maturazione",
						Language.SPN => "Maduración",
						Language.KOR => "숙성",
						Language.CHN_SIM => "熟成",
						Language.CHN_TRA => "熟成",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RIVALRY:
					return lang switch {
						Language.ENG => "Rivalry",
						Language.JPN => "とうそうしん",
						Language.GER => "Rivalität",
						Language.FRE => "Rivalité",
						Language.ITA => "Antagonismo",
						Language.SPN => "Rivalidad",
						Language.KOR => "투쟁심",
						Language.CHN_SIM => "斗争心",
						Language.CHN_TRA => "鬥爭心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RKS_SYSTEM:
					return lang switch {
						Language.ENG => "RKS System",
						Language.JPN => "ＡＲシステム",
						Language.GER => "Alpha-System",
						Language.FRE => "Système Alpha",
						Language.ITA => "Sistema Primevo",
						Language.SPN => "Sistema Alfa",
						Language.KOR => "AR시스템",
						Language.CHN_SIM => "ＡＲ系统",
						Language.CHN_TRA => "ＡＲ系統",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ROCK_HEAD:
					return lang switch {
						Language.ENG => "Rock Head",
						Language.JPN => "いしあたま",
						Language.GER => "Steinhaupt",
						Language.FRE => "Tête de Roc",
						Language.ITA => "Testadura",
						Language.SPN => "Cabeza Roca",
						Language.KOR => "돌머리",
						Language.CHN_SIM => "坚硬脑袋",
						Language.CHN_TRA => "堅硬腦袋",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ROCKY_PAYLOAD:
					return lang switch {
						Language.ENG => "Rocky Payload",
						Language.JPN => "いわはこび",
						Language.GER => "Steinträger",
						Language.FRE => "Porte-Roche",
						Language.ITA => "Portamassi",
						Language.SPN => "Transportarrocas",
						Language.KOR => "바위나르기",
						Language.CHN_SIM => "搬岩",
						Language.CHN_TRA => "搬岩",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ROUGH_SKIN:
					return lang switch {
						Language.ENG => "Rough Skin",
						Language.JPN => "さめはだ",
						Language.GER => "Rauhaut",
						Language.FRE => "Peau Dure",
						Language.ITA => "Cartavetro",
						Language.SPN => "Piel Tosca",
						Language.KOR => "까칠한피부",
						Language.CHN_SIM => "粗糙皮肤",
						Language.CHN_TRA => "粗糙皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.RUN_AWAY:
					return lang switch {
						Language.ENG => "Run Away",
						Language.JPN => "にげあし",
						Language.GER => "Angsthase",
						Language.FRE => "Fuite",
						Language.ITA => "Fugafacile",
						Language.SPN => "Fuga",
						Language.KOR => "도주",
						Language.CHN_SIM => "逃跑",
						Language.CHN_TRA => "逃跑",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SAND_FORCE:
					return lang switch {
						Language.ENG => "Sand Force",
						Language.JPN => "すなのちから",
						Language.GER => "Sandgewalt",
						Language.FRE => "Force Sable",
						Language.ITA => "Silicoforza",
						Language.SPN => "Poder Arena",
						Language.KOR => "모래의힘",
						Language.CHN_SIM => "沙之力",
						Language.CHN_TRA => "沙之力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SAND_RUSH:
					return lang switch {
						Language.ENG => "Sand Rush",
						Language.JPN => "すなかき",
						Language.GER => "Sandscharrer",
						Language.FRE => "Baigne Sable",
						Language.ITA => "Remasabbia",
						Language.SPN => "Ímpetu Arena",
						Language.KOR => "모래헤치기",
						Language.CHN_SIM => "拨沙",
						Language.CHN_TRA => "撥沙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SAND_SPIT:
					return lang switch {
						Language.ENG => "Sand Spit",
						Language.JPN => "すなはき",
						Language.GER => "Sandspeier",
						Language.FRE => "Expul’Sable",
						Language.ITA => "Sputasabbia",
						Language.SPN => "Expulsarena",
						Language.KOR => "모래뿜기",
						Language.CHN_SIM => "吐沙",
						Language.CHN_TRA => "吐沙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SAND_STREAM:
					return lang switch {
						Language.ENG => "Sand Stream",
						Language.JPN => "すなおこし",
						Language.GER => "Sandsturm",
						Language.FRE => "Sable Volant",
						Language.ITA => "Sabbiafiume",
						Language.SPN => "Chorro Arena",
						Language.KOR => "모래날림",
						Language.CHN_SIM => "扬沙",
						Language.CHN_TRA => "揚沙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SAND_VEIL:
					return lang switch {
						Language.ENG => "Sand Veil",
						Language.JPN => "すながくれ",
						Language.GER => "Sandschleier",
						Language.FRE => "Voile Sable",
						Language.ITA => "Sabbiavelo",
						Language.SPN => "Velo Arena",
						Language.KOR => "모래숨기",
						Language.CHN_SIM => "沙隐",
						Language.CHN_TRA => "沙隱",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SAP_SIPPER:
					return lang switch {
						Language.ENG => "Sap Sipper",
						Language.JPN => "そうしょく",
						Language.GER => "Vegetarier",
						Language.FRE => "Herbivore",
						Language.ITA => "Mangiaerba",
						Language.SPN => "Herbívoro",
						Language.KOR => "초식",
						Language.CHN_SIM => "食草",
						Language.CHN_TRA => "食草",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SCHOOLING:
					return lang switch {
						Language.ENG => "Schooling",
						Language.JPN => "ぎょぐん",
						Language.GER => "Fischschwarm",
						Language.FRE => "Banc",
						Language.ITA => "Banco",
						Language.SPN => "Banco",
						Language.KOR => "어군",
						Language.CHN_SIM => "鱼群",
						Language.CHN_TRA => "魚群",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SCRAPPY:
					return lang switch {
						Language.ENG => "Scrappy",
						Language.JPN => "きもったま",
						Language.GER => "Rauflust",
						Language.FRE => "Querelleur",
						Language.ITA => "Nervisaldi",
						Language.SPN => "Intrépido",
						Language.KOR => "배짱",
						Language.CHN_SIM => "胆量",
						Language.CHN_TRA => "膽量",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SCREEN_CLEANER:
					return lang switch {
						Language.ENG => "Screen Cleaner",
						Language.JPN => "バリアフリー",
						Language.GER => "Hemmungslos",
						Language.FRE => "Brise-Barrière",
						Language.ITA => "Annullabarriere",
						Language.SPN => "Antibarrera",
						Language.KOR => "배리어프리",
						Language.CHN_SIM => "除障",
						Language.CHN_TRA => "除障",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SEED_SOWER:
					return lang switch {
						Language.ENG => "Seed Sower",
						Language.JPN => "こぼれダネ",
						Language.GER => "Streusaat",
						Language.FRE => "Semencier",
						Language.ITA => "Spargisemi",
						Language.SPN => "Disemillar",
						Language.KOR => "넘치는씨",
						Language.CHN_SIM => "掉出种子",
						Language.CHN_TRA => "掉出種子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SERENE_GRACE:
					return lang switch {
						Language.ENG => "Serene Grace",
						Language.JPN => "てんのめぐみ",
						Language.GER => "Edelmut",
						Language.FRE => "Sérénité",
						Language.ITA => "Leggiadro",
						Language.SPN => "Dicha",
						Language.KOR => "하늘의은총",
						Language.CHN_SIM => "天恩",
						Language.CHN_TRA => "天恩",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHADOW_SHIELD:
					return lang switch {
						Language.ENG => "Shadow Shield",
						Language.JPN => "ファントムガード",
						Language.GER => "Phantomschutz",
						Language.FRE => "Spectro-Bouclier",
						Language.ITA => "Spettroguardia",
						Language.SPN => "Guardia Espectro",
						Language.KOR => "스펙터가드",
						Language.CHN_SIM => "幻影防守",
						Language.CHN_TRA => "幻影防守",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHADOW_TAG:
					return lang switch {
						Language.ENG => "Shadow Tag",
						Language.JPN => "かげふみ",
						Language.GER => "Wegsperre",
						Language.FRE => "Marque Ombre",
						Language.ITA => "Pedinombra",
						Language.SPN => "Sombra Trampa",
						Language.KOR => "그림자밟기",
						Language.CHN_SIM => "踩影",
						Language.CHN_TRA => "踩影",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHARPNESS:
					return lang switch {
						Language.ENG => "Sharpness",
						Language.JPN => "きれあじ",
						Language.GER => "Scharfkantig",
						Language.FRE => "Incisif",
						Language.ITA => "Affilama",
						Language.SPN => "Cortante",
						Language.KOR => "예리함",
						Language.CHN_SIM => "锋锐",
						Language.CHN_TRA => "鋒銳",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHED_SKIN:
					return lang switch {
						Language.ENG => "Shed Skin",
						Language.JPN => "だっぴ",
						Language.GER => "Expidermis",
						Language.FRE => "Mue",
						Language.ITA => "Muta",
						Language.SPN => "Mudar",
						Language.KOR => "탈피",
						Language.CHN_SIM => "蜕皮",
						Language.CHN_TRA => "蛻皮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHEER_FORCE:
					return lang switch {
						Language.ENG => "Sheer Force",
						Language.JPN => "ちからずく",
						Language.GER => "Rohe Gewalt",
						Language.FRE => "Sans Limite",
						Language.ITA => "Forzabruta",
						Language.SPN => "Potencia Bruta",
						Language.KOR => "우격다짐",
						Language.CHN_SIM => "强行",
						Language.CHN_TRA => "強行",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHELL_ARMOR:
					return lang switch {
						Language.ENG => "Shell Armor",
						Language.JPN => "シェルアーマー",
						Language.GER => "Panzerhaut",
						Language.FRE => "Coque Armure",
						Language.ITA => "Guscioscudo",
						Language.SPN => "Caparazón",
						Language.KOR => "조가비갑옷",
						Language.CHN_SIM => "硬壳盔甲",
						Language.CHN_TRA => "硬殼盔甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHIELD_DUST:
					return lang switch {
						Language.ENG => "Shield Dust",
						Language.JPN => "りんぷん",
						Language.GER => "Puderabwehr",
						Language.FRE => "Écran Poudre",
						Language.ITA => "Polvoscudo",
						Language.SPN => "Polvo Escudo",
						Language.KOR => "인분",
						Language.CHN_SIM => "鳞粉",
						Language.CHN_TRA => "鱗粉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SHIELDS_DOWN:
					return lang switch {
						Language.ENG => "Shields Down",
						Language.JPN => "リミットシールド",
						Language.GER => "Limitschild",
						Language.FRE => "Bouclier-Carcan",
						Language.ITA => "Scudosoglia",
						Language.SPN => "Escudo Limitado",
						Language.KOR => "리밋실드",
						Language.CHN_SIM => "界限盾壳",
						Language.CHN_TRA => "界限盾殼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SIMPLE:
					return lang switch {
						Language.ENG => "Simple",
						Language.JPN => "たんじゅん",
						Language.GER => "Wankelmut",
						Language.FRE => "Simple",
						Language.ITA => "Disinvoltura",
						Language.SPN => "Simple",
						Language.KOR => "단순",
						Language.CHN_SIM => "单纯",
						Language.CHN_TRA => "單純",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SKILL_LINK:
					return lang switch {
						Language.ENG => "Skill Link",
						Language.JPN => "スキルリンク",
						Language.GER => "Wertelink",
						Language.FRE => "Multi-Coups",
						Language.ITA => "Abillegame",
						Language.SPN => "Encadenado",
						Language.KOR => "스킬링크",
						Language.CHN_SIM => "连续攻击",
						Language.CHN_TRA => "連續攻擊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SLOW_START:
					return lang switch {
						Language.ENG => "Slow Start",
						Language.JPN => "スロースタート",
						Language.GER => "Saumselig",
						Language.FRE => "Début Calme",
						Language.ITA => "Lentoinizio",
						Language.SPN => "Inicio Lento",
						Language.KOR => "슬로스타트",
						Language.CHN_SIM => "慢启动",
						Language.CHN_TRA => "慢啟動",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SLUSH_RUSH:
					return lang switch {
						Language.ENG => "Slush Rush",
						Language.JPN => "ゆきかき",
						Language.GER => "Schneescharrer",
						Language.FRE => "Chasse-Neige",
						Language.ITA => "Spalaneve",
						Language.SPN => "Quitanieves",
						Language.KOR => "눈치우기",
						Language.CHN_SIM => "拨雪",
						Language.CHN_TRA => "撥雪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SNIPER:
					return lang switch {
						Language.ENG => "Sniper",
						Language.JPN => "スナイパー",
						Language.GER => "Superschütze",
						Language.FRE => "Sniper",
						Language.ITA => "Cecchino",
						Language.SPN => "Francotirador",
						Language.KOR => "스나이퍼",
						Language.CHN_SIM => "狙击手",
						Language.CHN_TRA => "狙擊手",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SNOW_CLOAK:
					return lang switch {
						Language.ENG => "Snow Cloak",
						Language.JPN => "ゆきがくれ",
						Language.GER => "Schneemantel",
						Language.FRE => "Rideau Neige",
						Language.ITA => "Mantelneve",
						Language.SPN => "Manto Níveo",
						Language.KOR => "눈숨기",
						Language.CHN_SIM => "雪隐",
						Language.CHN_TRA => "雪隱",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SNOW_WARNING:
					return lang switch {
						Language.ENG => "Snow Warning",
						Language.JPN => "ゆきふらし",
						Language.GER => "Hagelalarm",
						Language.FRE => "Alerte Neige",
						Language.ITA => "Scendineve",
						Language.SPN => "Nevada",
						Language.KOR => "눈퍼뜨리기",
						Language.CHN_SIM => "降雪",
						Language.CHN_TRA => "降雪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SOLAR_POWER:
					return lang switch {
						Language.ENG => "Solar Power",
						Language.JPN => "サンパワー",
						Language.GER => "Solarkraft",
						Language.FRE => "Force Soleil",
						Language.ITA => "Solarpotere",
						Language.SPN => "Poder Solar",
						Language.KOR => "선파워",
						Language.CHN_SIM => "太阳之力",
						Language.CHN_TRA => "太陽之力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SOLID_ROCK:
					return lang switch {
						Language.ENG => "Solid Rock",
						Language.JPN => "ハードロック",
						Language.GER => "Felskern",
						Language.FRE => "Solide Roc",
						Language.ITA => "Solidroccia",
						Language.SPN => "Roca Sólida",
						Language.KOR => "하드록",
						Language.CHN_SIM => "坚硬岩石",
						Language.CHN_TRA => "堅硬岩石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SOUL_HEART:
					return lang switch {
						Language.ENG => "Soul-Heart",
						Language.JPN => "ソウルハート",
						Language.GER => "Seelenherz",
						Language.FRE => "Animacœur",
						Language.ITA => "Cuoreanima",
						Language.SPN => "Coránima",
						Language.KOR => "소울하트",
						Language.CHN_SIM => "魂心",
						Language.CHN_TRA => "魂心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SOUNDPROOF:
					return lang switch {
						Language.ENG => "Soundproof",
						Language.JPN => "ぼうおん",
						Language.GER => "Lärmschutz",
						Language.FRE => "Anti-Bruit",
						Language.ITA => "Antisuono",
						Language.SPN => "Insonorizar",
						Language.KOR => "방음",
						Language.CHN_SIM => "隔音",
						Language.CHN_TRA => "隔音",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SPEED_BOOST:
					return lang switch {
						Language.ENG => "Speed Boost",
						Language.JPN => "かそく",
						Language.GER => "Temposchub",
						Language.FRE => "Turbo",
						Language.ITA => "Acceleratore",
						Language.SPN => "Impulso",
						Language.KOR => "가속",
						Language.CHN_SIM => "加速",
						Language.CHN_TRA => "加速",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STAKEOUT:
					return lang switch {
						Language.ENG => "Stakeout",
						Language.JPN => "はりこみ",
						Language.GER => "Beschattung",
						Language.FRE => "Filature",
						Language.ITA => "Sorveglianza",
						Language.SPN => "Vigilante",
						Language.KOR => "잠복",
						Language.CHN_SIM => "蹲守",
						Language.CHN_TRA => "監視",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STALL:
					return lang switch {
						Language.ENG => "Stall",
						Language.JPN => "あとだし",
						Language.GER => "Zeitspiel",
						Language.FRE => "Frein",
						Language.ITA => "Rallentatore",
						Language.SPN => "Rezagado",
						Language.KOR => "시간벌기",
						Language.CHN_SIM => "慢出",
						Language.CHN_TRA => "慢出",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STALWART:
					return lang switch {
						Language.ENG => "Stalwart",
						Language.JPN => "すじがねいり",
						Language.GER => "Stahlrückgrat",
						Language.FRE => "Nerfs d’Acier",
						Language.ITA => "Volontà di Ferro",
						Language.SPN => "Acérrimo",
						Language.KOR => "굳건한신념",
						Language.CHN_SIM => "坚毅",
						Language.CHN_TRA => "堅毅",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STAMINA:
					return lang switch {
						Language.ENG => "Stamina",
						Language.JPN => "じきゅうりょく",
						Language.GER => "Zähigkeit",
						Language.FRE => "Endurance",
						Language.ITA => "Sopportazione",
						Language.SPN => "Firmeza",
						Language.KOR => "지구력",
						Language.CHN_SIM => "持久力",
						Language.CHN_TRA => "持久力",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STANCE_CHANGE:
					return lang switch {
						Language.ENG => "Stance Change",
						Language.JPN => "バトルスイッチ",
						Language.GER => "Taktikwechsel",
						Language.FRE => "Déclic Tactique",
						Language.ITA => "Accendilotta",
						Language.SPN => "Cambio Táctico",
						Language.KOR => "배틀스위치",
						Language.CHN_SIM => "战斗切换",
						Language.CHN_TRA => "戰鬥切換",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STATIC:
					return lang switch {
						Language.ENG => "Static",
						Language.JPN => "せいでんき",
						Language.GER => "Statik",
						Language.FRE => "Statik",
						Language.ITA => "Statico",
						Language.SPN => "Elec. Estática",
						Language.KOR => "정전기",
						Language.CHN_SIM => "静电",
						Language.CHN_TRA => "靜電",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STEADFAST:
					return lang switch {
						Language.ENG => "Steadfast",
						Language.JPN => "ふくつのこころ",
						Language.GER => "Felsenfest",
						Language.FRE => "Impassible",
						Language.ITA => "Cuordeciso",
						Language.SPN => "Impasible",
						Language.KOR => "불굴의마음",
						Language.CHN_SIM => "不屈之心",
						Language.CHN_TRA => "不屈之心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STEAM_ENGINE:
					return lang switch {
						Language.ENG => "Steam Engine",
						Language.JPN => "じょうききかん",
						Language.GER => "Dampfantrieb",
						Language.FRE => "Turbine",
						Language.ITA => "Vapormacchina",
						Language.SPN => "Combustible",
						Language.KOR => "증기기관",
						Language.CHN_SIM => "蒸汽机",
						Language.CHN_TRA => "蒸汽機",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STEELWORKER:
					return lang switch {
						Language.ENG => "Steelworker",
						Language.JPN => "はがねつかい",
						Language.GER => "Stahlprofi",
						Language.FRE => "Expert Acier",
						Language.ITA => "Tempracciaio",
						Language.SPN => "Acero Templado",
						Language.KOR => "강철술사",
						Language.CHN_SIM => "钢能力者",
						Language.CHN_TRA => "鋼能力者",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STEELY_SPIRIT:
					return lang switch {
						Language.ENG => "Steely Spirit",
						Language.JPN => "はがねのせいしん",
						Language.GER => "Stählerner Wille",
						Language.FRE => "Boost Acier",
						Language.ITA => "Spiritoferreo",
						Language.SPN => "Alma Acerada",
						Language.KOR => "강철정신",
						Language.CHN_SIM => "钢之意志",
						Language.CHN_TRA => "鋼之意志",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STENCH:
					return lang switch {
						Language.ENG => "Stench",
						Language.JPN => "あくしゅう",
						Language.GER => "Duftnote",
						Language.FRE => "Puanteur",
						Language.ITA => "Tanfo",
						Language.SPN => "Hedor",
						Language.KOR => "악취",
						Language.CHN_SIM => "恶臭",
						Language.CHN_TRA => "惡臭",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STICKY_HOLD:
					return lang switch {
						Language.ENG => "Sticky Hold",
						Language.JPN => "ねんちゃく",
						Language.GER => "Wertehalter",
						Language.FRE => "Glue",
						Language.ITA => "Antifurto",
						Language.SPN => "Viscosidad",
						Language.KOR => "점착",
						Language.CHN_SIM => "黏着",
						Language.CHN_TRA => "黏著",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STORM_DRAIN:
					return lang switch {
						Language.ENG => "Storm Drain",
						Language.JPN => "よびみず",
						Language.GER => "Sturmsog",
						Language.FRE => "Lavabo",
						Language.ITA => "Acquascolo",
						Language.SPN => "Colector",
						Language.KOR => "마중물",
						Language.CHN_SIM => "引水",
						Language.CHN_TRA => "引水",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STRONG_JAW:
					return lang switch {
						Language.ENG => "Strong Jaw",
						Language.JPN => "がんじょうあご",
						Language.GER => "Titankiefer",
						Language.FRE => "Prognathe",
						Language.ITA => "Ferromascella",
						Language.SPN => "Mandíbula Fuerte",
						Language.KOR => "옹골찬턱",
						Language.CHN_SIM => "强壮之颚",
						Language.CHN_TRA => "強壯之顎",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.STURDY:
					return lang switch {
						Language.ENG => "Sturdy",
						Language.JPN => "がんじょう",
						Language.GER => "Robustheit",
						Language.FRE => "Fermeté",
						Language.ITA => "Vigore",
						Language.SPN => "Robustez",
						Language.KOR => "옹골참",
						Language.CHN_SIM => "结实",
						Language.CHN_TRA => "結實",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SUCTION_CUPS:
					return lang switch {
						Language.ENG => "Suction Cups",
						Language.JPN => "きゅうばん",
						Language.GER => "Saugnapf",
						Language.FRE => "Ventouse",
						Language.ITA => "Ventose",
						Language.SPN => "Ventosas",
						Language.KOR => "흡반",
						Language.CHN_SIM => "吸盘",
						Language.CHN_TRA => "吸盤",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SUPER_LUCK:
					return lang switch {
						Language.ENG => "Super Luck",
						Language.JPN => "きょううん",
						Language.GER => "Glückspilz",
						Language.FRE => "Chanceux",
						Language.ITA => "Supersorte",
						Language.SPN => "Afortunado",
						Language.KOR => "대운",
						Language.CHN_SIM => "超幸运",
						Language.CHN_TRA => "超幸運",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SUPREME_OVERLORD:
					return lang switch {
						Language.ENG => "Supreme Overlord",
						Language.JPN => "そうだいしょう",
						Language.GER => "Feldherr",
						Language.FRE => "Général Suprême",
						Language.ITA => "Generale Supremo",
						Language.SPN => "General Supremo",
						Language.KOR => "총대장",
						Language.CHN_SIM => "大将",
						Language.CHN_TRA => "大將",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SURGE_SURFER:
					return lang switch {
						Language.ENG => "Surge Surfer",
						Language.JPN => "サーフテール",
						Language.GER => "Surf-Schweif",
						Language.FRE => "Surf Caudal",
						Language.ITA => "Codasurf",
						Language.SPN => "Cola Surf",
						Language.KOR => "서핑테일",
						Language.CHN_SIM => "冲浪之尾",
						Language.CHN_TRA => "衝浪之尾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SWARM:
					return lang switch {
						Language.ENG => "Swarm",
						Language.JPN => "むしのしらせ",
						Language.GER => "Hexaplaga",
						Language.FRE => "Essaim",
						Language.ITA => "Aiutinsetto",
						Language.SPN => "Enjambre",
						Language.KOR => "벌레의알림",
						Language.CHN_SIM => "虫之预感",
						Language.CHN_TRA => "蟲之預感",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SWEET_VEIL:
					return lang switch {
						Language.ENG => "Sweet Veil",
						Language.JPN => "スイートベール",
						Language.GER => "Zuckerhülle",
						Language.FRE => "Gluco-Voile",
						Language.ITA => "Dolcevelo",
						Language.SPN => "Velo Dulce",
						Language.KOR => "스위트베일",
						Language.CHN_SIM => "甜幕",
						Language.CHN_TRA => "甜幕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SWIFT_SWIM:
					return lang switch {
						Language.ENG => "Swift Swim",
						Language.JPN => "すいすい",
						Language.GER => "Wassertempo",
						Language.FRE => "Glissade",
						Language.ITA => "Nuotovelox",
						Language.SPN => "Nado Rápido",
						Language.KOR => "쓱쓱",
						Language.CHN_SIM => "悠游自如",
						Language.CHN_TRA => "悠游自如",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SWORD_OF_RUIN:
					return lang switch {
						Language.ENG => "Sword of Ruin",
						Language.JPN => "わざわいのつるぎ",
						Language.GER => "Unheilsschwert",
						Language.FRE => "Épée du Fléau",
						Language.ITA => "Spada Nefasta",
						Language.SPN => "Espada Debacle",
						Language.KOR => "재앙의검",
						Language.CHN_SIM => "灾祸之剑",
						Language.CHN_TRA => "災禍之劍",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SYMBIOSIS:
					return lang switch {
						Language.ENG => "Symbiosis",
						Language.JPN => "きょうせい",
						Language.GER => "Nutznießer",
						Language.FRE => "Symbiose",
						Language.ITA => "Simbiosi",
						Language.SPN => "Simbiosis",
						Language.KOR => "공생",
						Language.CHN_SIM => "共生",
						Language.CHN_TRA => "共生",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.SYNCHRONIZE:
					return lang switch {
						Language.ENG => "Synchronize",
						Language.JPN => "シンクロ",
						Language.GER => "Synchro",
						Language.FRE => "Synchro",
						Language.ITA => "Sincronismo",
						Language.SPN => "Sincronía",
						Language.KOR => "싱크로",
						Language.CHN_SIM => "同步",
						Language.CHN_TRA => "同步",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TABLETS_OF_RUIN:
					return lang switch {
						Language.ENG => "Tablets of Ruin",
						Language.JPN => "わざわいのおふだ",
						Language.GER => "Unheilstafeln",
						Language.FRE => "Bois du Fléau",
						Language.ITA => "Amuleto Nefasto",
						Language.SPN => "Tablilla Debacle",
						Language.KOR => "재앙의목간",
						Language.CHN_SIM => "灾祸之简",
						Language.CHN_TRA => "災禍之簡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TANGLED_FEET:
					return lang switch {
						Language.ENG => "Tangled Feet",
						Language.JPN => "ちどりあし",
						Language.GER => "Fußangel",
						Language.FRE => "Pieds Confus",
						Language.ITA => "Intricopiedi",
						Language.SPN => "Tumbos",
						Language.KOR => "갈지자걸음",
						Language.CHN_SIM => "蹒跚",
						Language.CHN_TRA => "蹣跚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TANGLING_HAIR:
					return lang switch {
						Language.ENG => "Tangling Hair",
						Language.JPN => "カーリーヘアー",
						Language.GER => "Lockenkopf",
						Language.FRE => "Mèche Rebelle",
						Language.ITA => "Boccolidoro",
						Language.SPN => "Rizos Rebeldes",
						Language.KOR => "컬리헤어",
						Language.CHN_SIM => "卷发",
						Language.CHN_TRA => "捲髮",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TECHNICIAN:
					return lang switch {
						Language.ENG => "Technician",
						Language.JPN => "テクニシャン",
						Language.GER => "Techniker",
						Language.FRE => "Technicien",
						Language.ITA => "Tecnico",
						Language.SPN => "Experto",
						Language.KOR => "테크니션",
						Language.CHN_SIM => "技术高手",
						Language.CHN_TRA => "技術高手",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TELEPATHY:
					return lang switch {
						Language.ENG => "Telepathy",
						Language.JPN => "テレパシー",
						Language.GER => "Telepathie",
						Language.FRE => "Télépathe",
						Language.ITA => "Telepatia",
						Language.SPN => "Telepatía",
						Language.KOR => "텔레파시",
						Language.CHN_SIM => "心灵感应",
						Language.CHN_TRA => "心靈感應",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TERAVOLT:
					return lang switch {
						Language.ENG => "Teravolt",
						Language.JPN => "テラボルテージ",
						Language.GER => "Teravolt",
						Language.FRE => "Téra-Voltage",
						Language.ITA => "Teravolt",
						Language.SPN => "Terravoltaje",
						Language.KOR => "테라볼티지",
						Language.CHN_SIM => "兆级电压",
						Language.CHN_TRA => "兆級電壓",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.THERMAL_EXCHANGE:
					return lang switch {
						Language.ENG => "Thermal Exchange",
						Language.JPN => "ねつこうかん",
						Language.GER => "Thermowandel",
						Language.FRE => "Thermodynamique",
						Language.ITA => "Termoscambio",
						Language.SPN => "Termoconversión",
						Language.KOR => "열교환",
						Language.CHN_SIM => "热交换",
						Language.CHN_TRA => "熱交換",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.THICK_FAT:
					return lang switch {
						Language.ENG => "Thick Fat",
						Language.JPN => "あついしぼう",
						Language.GER => "Speckschicht",
						Language.FRE => "Isograisse",
						Language.ITA => "Grassospesso",
						Language.SPN => "Sebo",
						Language.KOR => "두꺼운지방",
						Language.CHN_SIM => "厚脂肪",
						Language.CHN_TRA => "厚脂肪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TINTED_LENS:
					return lang switch {
						Language.ENG => "Tinted Lens",
						Language.JPN => "いろめがね",
						Language.GER => "Aufwertung",
						Language.FRE => "Lentiteintée",
						Language.ITA => "Lentifumé",
						Language.SPN => "Cromolente",
						Language.KOR => "색안경",
						Language.CHN_SIM => "有色眼镜",
						Language.CHN_TRA => "有色眼鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TORRENT:
					return lang switch {
						Language.ENG => "Torrent",
						Language.JPN => "げきりゅう",
						Language.GER => "Sturzbach",
						Language.FRE => "Torrent",
						Language.ITA => "Acquaiuto",
						Language.SPN => "Torrente",
						Language.KOR => "급류",
						Language.CHN_SIM => "激流",
						Language.CHN_TRA => "激流",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TOUGH_CLAWS:
					return lang switch {
						Language.ENG => "Tough Claws",
						Language.JPN => "かたいツメ",
						Language.GER => "Krallenwucht",
						Language.FRE => "Griffe Dure",
						Language.ITA => "Unghiedure",
						Language.SPN => "Garra Dura",
						Language.KOR => "단단한발톱",
						Language.CHN_SIM => "硬爪",
						Language.CHN_TRA => "硬爪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TOXIC_BOOST:
					return lang switch {
						Language.ENG => "Toxic Boost",
						Language.JPN => "どくぼうそう",
						Language.GER => "Giftwahn",
						Language.FRE => "Rage Poison",
						Language.ITA => "Velenimpeto",
						Language.SPN => "Ímpetu Tóxico",
						Language.KOR => "독폭주",
						Language.CHN_SIM => "中毒激升",
						Language.CHN_TRA => "中毒激升",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TOXIC_DEBRIS:
					return lang switch {
						Language.ENG => "Toxic Debris",
						Language.JPN => "どくげしょう",
						Language.GER => "Giftbelag",
						Language.FRE => "Dépôt Toxique",
						Language.ITA => "Mantossina",
						Language.SPN => "Capa Tóxica",
						Language.KOR => "독치장",
						Language.CHN_SIM => "毒满地",
						Language.CHN_TRA => "毒滿地",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TRACE:
					return lang switch {
						Language.ENG => "Trace",
						Language.JPN => "トレース",
						Language.GER => "Fährte",
						Language.FRE => "Calque",
						Language.ITA => "Traccia",
						Language.SPN => "Rastro",
						Language.KOR => "트레이스",
						Language.CHN_SIM => "复制",
						Language.CHN_TRA => "複製",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TRANSISTOR:
					return lang switch {
						Language.ENG => "Transistor",
						Language.JPN => "トランジスタ",
						Language.GER => "Transistor",
						Language.FRE => "Transistor",
						Language.ITA => "Transistor",
						Language.SPN => "Transistor",
						Language.KOR => "트랜지스터",
						Language.CHN_SIM => "电晶体",
						Language.CHN_TRA => "電晶體",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TRIAGE:
					return lang switch {
						Language.ENG => "Triage",
						Language.JPN => "ヒーリングシフト",
						Language.GER => "Heilwandel",
						Language.FRE => "Prioguérison",
						Language.ITA => "Primacura",
						Language.SPN => "Primer Auxilio",
						Language.KOR => "힐링시프트",
						Language.CHN_SIM => "先行治疗",
						Language.CHN_TRA => "先行治療",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TRUANT:
					return lang switch {
						Language.ENG => "Truant",
						Language.JPN => "なまけ",
						Language.GER => "Schnarchnase",
						Language.FRE => "Absentéisme",
						Language.ITA => "Pigrone",
						Language.SPN => "Ausente",
						Language.KOR => "게으름",
						Language.CHN_SIM => "懒惰",
						Language.CHN_TRA => "懶惰",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.TURBOBLAZE:
					return lang switch {
						Language.ENG => "Turboblaze",
						Language.JPN => "ターボブレイズ",
						Language.GER => "Turbobrand",
						Language.FRE => "TurboBrasier",
						Language.ITA => "Piroturbina",
						Language.SPN => "Turbollama",
						Language.KOR => "터보블레이즈",
						Language.CHN_SIM => "涡轮火焰",
						Language.CHN_TRA => "渦輪火焰",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.UNAWARE:
					return lang switch {
						Language.ENG => "Unaware",
						Language.JPN => "てんねん",
						Language.GER => "Unkenntnis",
						Language.FRE => "Inconscient",
						Language.ITA => "Imprudenza",
						Language.SPN => "Ignorante",
						Language.KOR => "천진",
						Language.CHN_SIM => "纯朴",
						Language.CHN_TRA => "純樸",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.UNBURDEN:
					return lang switch {
						Language.ENG => "Unburden",
						Language.JPN => "かるわざ",
						Language.GER => "Entlastung",
						Language.FRE => "Délestage",
						Language.ITA => "Agiltecnica",
						Language.SPN => "Liviano",
						Language.KOR => "곡예",
						Language.CHN_SIM => "轻装",
						Language.CHN_TRA => "輕裝",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.UNNERVE:
					return lang switch {
						Language.ENG => "Unnerve",
						Language.JPN => "きんちょうかん",
						Language.GER => "Anspannung",
						Language.FRE => "Tension",
						Language.ITA => "Agitazione",
						Language.SPN => "Nerviosismo",
						Language.KOR => "긴장감",
						Language.CHN_SIM => "紧张感",
						Language.CHN_TRA => "緊張感",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.UNSEEN_FIST:
					return lang switch {
						Language.ENG => "Unseen Fist",
						Language.JPN => "ふかしのこぶし",
						Language.GER => "Verborgene Faust",
						Language.FRE => "Poing Invisible",
						Language.ITA => "Pugni Invisibili",
						Language.SPN => "Puño Invisible",
						Language.KOR => "보이지않는주먹",
						Language.CHN_SIM => "无形拳",
						Language.CHN_TRA => "無形拳",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.VESSEL_OF_RUIN:
					return lang switch {
						Language.ENG => "Vessel of Ruin",
						Language.JPN => "わざわいのうつわ",
						Language.GER => "Unheilsgefäß",
						Language.FRE => "Urne du Fléau",
						Language.ITA => "Vaso Nefasto",
						Language.SPN => "Caldero Debacle",
						Language.KOR => "재앙의그릇",
						Language.CHN_SIM => "灾祸之鼎",
						Language.CHN_TRA => "災禍之鼎",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.VICTORY_STAR:
					return lang switch {
						Language.ENG => "Victory Star",
						Language.JPN => "しょうりのほし",
						Language.GER => "Triumphstern",
						Language.FRE => "Victorieux",
						Language.ITA => "Vittorstella",
						Language.SPN => "Tinovictoria",
						Language.KOR => "승리의별",
						Language.CHN_SIM => "胜利之星",
						Language.CHN_TRA => "勝利之星",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.VITAL_SPIRIT:
					return lang switch {
						Language.ENG => "Vital Spirit",
						Language.JPN => "やるき",
						Language.GER => "Munterkeit",
						Language.FRE => "Esprit Vital",
						Language.ITA => "Spiritovivo",
						Language.SPN => "Espíritu Vital",
						Language.KOR => "의기양양",
						Language.CHN_SIM => "干劲",
						Language.CHN_TRA => "幹勁",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.VOLT_ABSORB:
					return lang switch {
						Language.ENG => "Volt Absorb",
						Language.JPN => "ちくでん",
						Language.GER => "Voltabsorber",
						Language.FRE => "Absorb Volt",
						Language.ITA => "Assorbivolt",
						Language.SPN => "Absorbe Elec",
						Language.KOR => "축전",
						Language.CHN_SIM => "蓄电",
						Language.CHN_TRA => "蓄電",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WANDERING_SPIRIT:
					return lang switch {
						Language.ENG => "Wandering Spirit",
						Language.JPN => "さまようたましい",
						Language.GER => "Rastlose Seele",
						Language.FRE => "Âme Vagabonde",
						Language.ITA => "Anima Errante",
						Language.SPN => "Alma Errante",
						Language.KOR => "떠도는영혼",
						Language.CHN_SIM => "游魂",
						Language.CHN_TRA => "遊魂",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WATER_ABSORB:
					return lang switch {
						Language.ENG => "Water Absorb",
						Language.JPN => "ちょすい",
						Language.GER => "H2O-Absorber",
						Language.FRE => "Absorb Eau",
						Language.ITA => "Assorbacqua",
						Language.SPN => "Absorbe Agua",
						Language.KOR => "저수",
						Language.CHN_SIM => "储水",
						Language.CHN_TRA => "儲水",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WATER_BUBBLE:
					return lang switch {
						Language.ENG => "Water Bubble",
						Language.JPN => "すいほう",
						Language.GER => "Wasserblase",
						Language.FRE => "Aquabulle",
						Language.ITA => "Bolladacqua",
						Language.SPN => "Pompa",
						Language.KOR => "수포",
						Language.CHN_SIM => "水泡",
						Language.CHN_TRA => "水泡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WATER_COMPACTION:
					return lang switch {
						Language.ENG => "Water Compaction",
						Language.JPN => "みずがため",
						Language.GER => "Verklumpen",
						Language.FRE => "Sable Humide",
						Language.ITA => "Idrorinforzo",
						Language.SPN => "Hidrorrefuerzo",
						Language.KOR => "꾸덕꾸덕굳기",
						Language.CHN_SIM => "遇水凝固",
						Language.CHN_TRA => "遇水凝固",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WATER_VEIL:
					return lang switch {
						Language.ENG => "Water Veil",
						Language.JPN => "みずのベール",
						Language.GER => "Aquahülle",
						Language.FRE => "Ignifu-Voile",
						Language.ITA => "Idrovelo",
						Language.SPN => "Velo Agua",
						Language.KOR => "수의베일",
						Language.CHN_SIM => "水幕",
						Language.CHN_TRA => "水幕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WEAK_ARMOR:
					return lang switch {
						Language.ENG => "Weak Armor",
						Language.JPN => "くだけるよろい",
						Language.GER => "Bruchrüstung",
						Language.FRE => "Armurouillée",
						Language.ITA => "Sottilguscio",
						Language.SPN => "Armadura Frágil",
						Language.KOR => "깨어진갑옷",
						Language.CHN_SIM => "碎裂铠甲",
						Language.CHN_TRA => "碎裂鎧甲",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WELL_BAKED_BODY:
					return lang switch {
						Language.ENG => "Well-Baked Body",
						Language.JPN => "こんがりボディ",
						Language.GER => "Knusperkruste",
						Language.FRE => "Bien Cuit",
						Language.ITA => "Bentostato",
						Language.SPN => "Cuerpo Horneado",
						Language.KOR => "노릇노릇바디",
						Language.CHN_SIM => "焦香之躯",
						Language.CHN_TRA => "焦香之軀",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WHITE_SMOKE:
					return lang switch {
						Language.ENG => "White Smoke",
						Language.JPN => "しろいけむり",
						Language.GER => "Pulverrauch",
						Language.FRE => "Écran Fumée",
						Language.ITA => "Fumochiaro",
						Language.SPN => "Humo Blanco",
						Language.KOR => "하얀연기",
						Language.CHN_SIM => "白色烟雾",
						Language.CHN_TRA => "白色煙霧",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WIMP_OUT:
					return lang switch {
						Language.ENG => "Wimp Out",
						Language.JPN => "にげごし",
						Language.GER => "Reißaus",
						Language.FRE => "Escampette",
						Language.ITA => "Fuggifuggi",
						Language.SPN => "Huida",
						Language.KOR => "도망태세",
						Language.CHN_SIM => "跃跃欲逃",
						Language.CHN_TRA => "躍躍欲逃",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WIND_POWER:
					return lang switch {
						Language.ENG => "Wind Power",
						Language.JPN => "ふうりょくでんき",
						Language.GER => "Windkraft",
						Language.FRE => "Turbine Éolienne",
						Language.ITA => "Energia Eolica",
						Language.SPN => "Energía Eólica",
						Language.KOR => "풍력발전",
						Language.CHN_SIM => "风力发电",
						Language.CHN_TRA => "風力發電",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WIND_RIDER:
					return lang switch {
						Language.ENG => "Wind Rider",
						Language.JPN => "かぜのり",
						Language.GER => "Windreiter",
						Language.FRE => "Aéroporté",
						Language.ITA => "Vento Propizio",
						Language.SPN => "Surcavientos",
						Language.KOR => "바람타기",
						Language.CHN_SIM => "乘风",
						Language.CHN_TRA => "乘風",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WONDER_GUARD:
					return lang switch {
						Language.ENG => "Wonder Guard",
						Language.JPN => "ふしぎなまもり",
						Language.GER => "Wunderwache",
						Language.FRE => "Garde Mystik",
						Language.ITA => "Magidifesa",
						Language.SPN => "Superguarda",
						Language.KOR => "불가사의부적",
						Language.CHN_SIM => "神奇守护",
						Language.CHN_TRA => "神奇守護",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.WONDER_SKIN:
					return lang switch {
						Language.ENG => "Wonder Skin",
						Language.JPN => "ミラクルスキン",
						Language.GER => "Wunderhaut",
						Language.FRE => "Peau Miracle",
						Language.ITA => "Splendicute",
						Language.SPN => "Piel Milagro",
						Language.KOR => "미라클스킨",
						Language.CHN_SIM => "奇迹皮肤",
						Language.CHN_TRA => "奇跡皮膚",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ZEN_MODE:
					return lang switch {
						Language.ENG => "Zen Mode",
						Language.JPN => "ダルマモード",
						Language.GER => "Trance-Modus",
						Language.FRE => "Mode Transe",
						Language.ITA => "Stato Zen",
						Language.SPN => "Modo Daruma",
						Language.KOR => "달마모드",
						Language.CHN_SIM => "达摩模式",
						Language.CHN_TRA => "達摩模式",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Ability.ZERO_TO_HERO:
					return lang switch {
						Language.ENG => "Zero to Hero",
						Language.JPN => "マイティチェンジ",
						Language.GER => "Superwechsel",
						Language.FRE => "Supermutation",
						Language.ITA => "Supercambio",
						Language.SPN => "Cambio Heroico",
						Language.KOR => "마이티체인지",
						Language.CHN_SIM => "全能变身",
						Language.CHN_TRA => "全能變身",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				default:
					throw new System.ArgumentException();
			};
		}
	}
}