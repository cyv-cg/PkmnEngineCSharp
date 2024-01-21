namespace PkmnEngine.Strings {
	public static class ItemNames {
		public static string gItemName(Item item, Language lang) {
			switch (item) {
				#region Hold items
				case Item.ABILITY_CAPSULE:
					return lang switch {
						Language.ENG => "Ability Capsule",
						Language.JPN => "とくせいカプセル",
						Language.GER => "Fähigkeiten-Kapsel",
						Language.FRE => "Pilule Talent",
						Language.ITA => "Capsula abilità",
						Language.SPN => "Cápsula Habilidad",
						Language.KOR => "특성캡슐",
						Language.CHN_SIM => "特性胶囊",
						Language.CHN_TRA => "特性膠囊",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ABOMASITE:
					return lang switch {
						Language.ENG => "Abomasite",
						Language.JPN => "ユキノオナイト",
						Language.GER => "Rexblisarnit",
						Language.FRE => "Blizzarite",
						Language.ITA => "Abomasnowite",
						Language.SPN => "Abomasnowita",
						Language.KOR => "눈설왕나이트",
						Language.CHN_SIM => "暴雪王进化石",
						Language.CHN_TRA => "暴雪王進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ABSOLITE:
					return lang switch {
						Language.ENG => "Absolite",
						Language.JPN => "アブソルナイト",
						Language.GER => "Absolnit",
						Language.FRE => "Absolite",
						Language.ITA => "Absolite",
						Language.SPN => "Absolita",
						Language.KOR => "앱솔나이트",
						Language.CHN_SIM => "阿勃梭鲁进化石",
						Language.CHN_TRA => "阿勃梭魯進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ABSORB_BULB:
					return lang switch {
						Language.ENG => "Absorb Bulb",
						Language.JPN => "きゅうこん",
						Language.GER => "Knolle",
						Language.FRE => "Bulbe",
						Language.ITA => "Bulbo",
						Language.SPN => "Tubérculo",
						Language.KOR => "구근",
						Language.CHN_SIM => "球根",
						Language.CHN_TRA => "球根",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ADAMANT_CRYSTAL:
					return lang switch {
						Language.ENG => "Adamant Crystal",
						Language.JPN => "だいこんごうだま",
						Language.GER => "Adamantkristall",
						Language.FRE => "Globe Adamant",
						Language.ITA => "Adamasferoide",
						Language.SPN => "Gran Diamansfera",
						Language.KOR => "큰금강옥",
						Language.CHN_SIM => "大金刚宝玉",
						Language.CHN_TRA => "大金剛寶玉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ADAMANT_ORB:
					return lang switch {
						Language.ENG => "Adamant Orb",
						Language.JPN => "こんごうだま",
						Language.GER => "Adamant-Orb",
						Language.FRE => "Orbe Adamant",
						Language.ITA => "Adamasfera",
						Language.SPN => "Diamansfera",
						Language.KOR => "금강옥",
						Language.CHN_SIM => "金刚宝珠",
						Language.CHN_TRA => "金剛寶珠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ADRENALINE_ORB:
					return lang switch {
						Language.ENG => "Adrenaline Orb",
						Language.JPN => "ビビリだま",
						Language.GER => "Zitter-Orb",
						Language.FRE => "Orbe Frousse",
						Language.ITA => "Fifasfera",
						Language.SPN => "Nerviosfera",
						Language.KOR => "주눅구슬",
						Language.CHN_SIM => "胆怯球",
						Language.CHN_TRA => "膽怯球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.AERODACTYLITE:
					return lang switch {
						Language.ENG => "Aerodactylite",
						Language.JPN => "プテラナイト",
						Language.GER => "Aerodactylonit",
						Language.FRE => "Ptéraïte",
						Language.ITA => "Aerodactylite",
						Language.SPN => "Aerodactylita",
						Language.KOR => "프테라나이트",
						Language.CHN_SIM => "化石翼龙进化石",
						Language.CHN_TRA => "化石翼龍進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.AGGRONITE:
					return lang switch {
						Language.ENG => "Aggronite",
						Language.JPN => "ボスゴドラナイト",
						Language.GER => "Stollossnit",
						Language.FRE => "Galekingite",
						Language.ITA => "Aggronite",
						Language.SPN => "Aggronita",
						Language.KOR => "보스로라나이트",
						Language.CHN_SIM => "波士可多拉进化石",
						Language.CHN_TRA => "波士可多拉進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.AIR_BALLOON:
					return lang switch {
						Language.ENG => "Air Balloon",
						Language.JPN => "ふうせん",
						Language.GER => "Luftballon",
						Language.FRE => "Ballon",
						Language.ITA => "Palloncino",
						Language.SPN => "Globo Helio",
						Language.KOR => "풍선",
						Language.CHN_SIM => "气球",
						Language.CHN_TRA => "氣球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ALAKAZITE:
					return lang switch {
						Language.ENG => "Alakazite",
						Language.JPN => "フーディナイト",
						Language.GER => "Simsalanit",
						Language.FRE => "Alakazamite",
						Language.ITA => "Alakazamite",
						Language.SPN => "Alakazamita",
						Language.KOR => "후디나이트",
						Language.CHN_SIM => "胡地进化石",
						Language.CHN_TRA => "胡地進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ALORAICHIUM_Z:
					return lang switch {
						Language.ENG => "Aloraichium Z",
						Language.JPN => "アロライＺ",
						Language.GER => "A-Raichunium Z",
						Language.FRE => "Aloraïzélite",
						Language.ITA => "Aloraicium Z",
						Language.SPN => "Alo-Raistal Z",
						Language.KOR => "알로라이Z",
						Language.CHN_SIM => "阿罗雷Ｚ",
						Language.CHN_TRA => "阿羅雷Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ALTARIANITE:
					return lang switch {
						Language.ENG => "Altarianite",
						Language.JPN => "チルタリスナイト",
						Language.GER => "Altarianit",
						Language.FRE => "Altarite",
						Language.ITA => "Altarite",
						Language.SPN => "Altarianita",
						Language.KOR => "파비코리나이트",
						Language.CHN_SIM => "七夕青鸟进化石",
						Language.CHN_TRA => "七夕青鳥進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.AMPHAROSITE:
					return lang switch {
						Language.ENG => "Ampharosite",
						Language.JPN => "デンリュウナイト",
						Language.GER => "Ampharosnit",
						Language.FRE => "Pharampite",
						Language.ITA => "Ampharosite",
						Language.SPN => "Ampharosita",
						Language.KOR => "전룡나이트",
						Language.CHN_SIM => "电龙进化石",
						Language.CHN_TRA => "電龍進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.AMULET_COIN:
					return lang switch {
						Language.ENG => "Amulet Coin",
						Language.JPN => "おまもりこばん",
						Language.GER => "Münzamulett",
						Language.FRE => "Pièce Rune",
						Language.ITA => "Monetamuleto",
						Language.SPN => "Moneda Amuleto",
						Language.KOR => "부적금화",
						Language.CHN_SIM => "护符金币",
						Language.CHN_TRA => "護符金幣",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ASSAULT_VEST:
					return lang switch {
						Language.ENG => "Assault Vest",
						Language.JPN => "とつげきチョッキ",
						Language.GER => "Offensivweste",
						Language.FRE => "Veste de Combat",
						Language.ITA => "Corpetto assalto",
						Language.SPN => "Chaleco Asalto",
						Language.KOR => "돌격조끼",
						Language.CHN_SIM => "突击背心",
						Language.CHN_TRA => "突擊背心",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.AUDINITE:
					return lang switch {
						Language.ENG => "Audinite",
						Language.JPN => "タブンネナイト",
						Language.GER => "Ohrdochnit",
						Language.FRE => "Nanméouïte",
						Language.ITA => "Audinite",
						Language.SPN => "Audinita",
						Language.KOR => "다부니나이트",
						Language.CHN_SIM => "差不多娃娃进化石",
						Language.CHN_TRA => "差不多娃娃進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BANETTITE:
					return lang switch {
						Language.ENG => "Banettite",
						Language.JPN => "ジュペッタナイト",
						Language.GER => "Banetteonit",
						Language.FRE => "Branettite",
						Language.ITA => "Banettite",
						Language.SPN => "Banettita",
						Language.KOR => "다크펫나이트",
						Language.CHN_SIM => "诅咒娃娃进化石",
						Language.CHN_TRA => "詛咒娃娃進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BEEDRILLITE:
					return lang switch {
						Language.ENG => "Beedrillite",
						Language.JPN => "スピアナイト",
						Language.GER => "Bibornit",
						Language.FRE => "Dardargnite",
						Language.ITA => "Beedrillite",
						Language.SPN => "Beedrillita",
						Language.KOR => "독침붕나이트",
						Language.CHN_SIM => "大针蜂进化石",
						Language.CHN_TRA => "大針蜂進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BERRY_SWEET:
					return lang switch {
						Language.ENG => "Berry Sweet",
						Language.JPN => "ベリーアメざいく",
						Language.GER => "Zucker-Beere",
						Language.FRE => "Baie en Sucre",
						Language.ITA => "Bonbonbosco",
						Language.SPN => "Confite Fruto",
						Language.KOR => "베리사탕공예",
						Language.CHN_SIM => "野莓糖饰",
						Language.CHN_TRA => "野莓糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BIG_ROOT:
					return lang switch {
						Language.ENG => "Big Root",
						Language.JPN => "おおきなねっこ",
						Language.GER => "Großwurzel",
						Language.FRE => "Grosse Racine",
						Language.ITA => "Granradice",
						Language.SPN => "Raíz Grande",
						Language.KOR => "큰뿌리",
						Language.CHN_SIM => "大根茎",
						Language.CHN_TRA => "大根莖",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BINDING_BAND:
					return lang switch {
						Language.ENG => "Binding Band",
						Language.JPN => "しめつけバンド",
						Language.GER => "Klammerband",
						Language.FRE => "Bande Étreinte",
						Language.ITA => "Legafascia",
						Language.SPN => "Banda Atadura",
						Language.KOR => "조임밴드",
						Language.CHN_SIM => "紧绑束带",
						Language.CHN_TRA => "緊綁束帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLACK_BELT:
					return lang switch {
						Language.ENG => "Black Belt",
						Language.JPN => "くろおび",
						Language.GER => "Schwarzgurt",
						Language.FRE => "Ceinture Noire",
						Language.ITA => "Cintura nera",
						Language.SPN => "Cinturón Negro",
						Language.KOR => "검은띠",
						Language.CHN_SIM => "黑带",
						Language.CHN_TRA => "黑帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLACK_GLASSES:
					return lang switch {
						Language.ENG => "Black Glasses",
						Language.JPN => "くろいメガネ",
						Language.GER => "Schattenbrille",
						Language.FRE => "Lunettes Noires",
						Language.ITA => "Occhialineri",
						Language.SPN => "Gafas de Sol",
						Language.KOR => "검은안경",
						Language.CHN_SIM => "黑色眼镜",
						Language.CHN_TRA => "黑色眼鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLACK_SLUDGE:
					return lang switch {
						Language.ENG => "Black Sludge",
						Language.JPN => "くろいヘドロ",
						Language.GER => "Giftschleim",
						Language.FRE => "Boue Noire",
						Language.ITA => "Fangopece",
						Language.SPN => "Lodo Negro",
						Language.KOR => "검은오물",
						Language.CHN_SIM => "黑色污泥",
						Language.CHN_TRA => "黑色污泥",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLANK_PLATE:
					return lang switch {
						Language.ENG => "Blank Plate",
						Language.JPN => "まっさらプレート",
						Language.GER => "Neutraltafel",
						Language.FRE => "Plaque Renouveau",
						Language.ITA => "Lastraripristino",
						Language.SPN => "Tabla Neutra",
						Language.KOR => "순백플레이트",
						Language.CHN_SIM => "净空石板",
						Language.CHN_TRA => "淨空石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLASTOISINITE:
					return lang switch {
						Language.ENG => "Blastoisinite",
						Language.JPN => "カメックスナイト",
						Language.GER => "Turtoknit",
						Language.FRE => "Tortankite",
						Language.ITA => "Blastoisite",
						Language.SPN => "Blastoisita",
						Language.KOR => "거북왕나이트",
						Language.CHN_SIM => "水箭龟进化石",
						Language.CHN_TRA => "水箭龜進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLAZIKENITE:
					return lang switch {
						Language.ENG => "Blazikenite",
						Language.JPN => "バシャーモナイト",
						Language.GER => "Lohgocknit",
						Language.FRE => "Braségalite",
						Language.ITA => "Blazikenite",
						Language.SPN => "Blazikenita",
						Language.KOR => "번치코나이트",
						Language.CHN_SIM => "火焰鸡进化石",
						Language.CHN_TRA => "火焰雞進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLUNDER_POLICY:
					return lang switch {
						Language.ENG => "Blunder Policy",
						Language.JPN => "からぶりほけん",
						Language.GER => "Fehlschlagschutz",
						Language.FRE => "Assurance Échec",
						Language.ITA => "Fiascopolizza",
						Language.SPN => "Seguro Fallo",
						Language.KOR => "허탕보험",
						Language.CHN_SIM => "打空保险",
						Language.CHN_TRA => "打空保險",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BRIGHT_POWDER:
					return lang switch {
						Language.ENG => "Bright Powder",
						Language.JPN => "ひかりのこな",
						Language.GER => "Blendpuder",
						Language.FRE => "Poudre Claire",
						Language.ITA => "Luminpolvere",
						Language.SPN => "Polvo Brillo",
						Language.KOR => "반짝가루",
						Language.CHN_SIM => "光粉",
						Language.CHN_TRA => "光粉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BUG_GEM:
					return lang switch {
						Language.ENG => "Bug Gem",
						Language.JPN => "むしのジュエル",
						Language.GER => "Käferjuwel",
						Language.FRE => "Joyau Insecte",
						Language.ITA => "Bijoucoleottero",
						Language.SPN => "Gema Bicho",
						Language.KOR => "벌레주얼",
						Language.CHN_SIM => "虫之宝石",
						Language.CHN_TRA => "蟲之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BUG_MEMORY:
					return lang switch {
						Language.ENG => "Bug Memory",
						Language.JPN => "バグメモリ",
						Language.GER => "Käfer-Disc",
						Language.FRE => "ROM Insecte",
						Language.ITA => "ROM Coleottero",
						Language.SPN => "Disco Bicho",
						Language.KOR => "버그메모리",
						Language.CHN_SIM => "虫子存储碟",
						Language.CHN_TRA => "蟲子記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BUGINIUM_Z:
					return lang switch {
						Language.ENG => "Buginium Z",
						Language.JPN => "ムシＺ",
						Language.GER => "Insectium Z",
						Language.FRE => "Insectozélite",
						Language.ITA => "Insectium Z",
						Language.SPN => "Insectostal Z",
						Language.KOR => "벌레Z",
						Language.CHN_SIM => "虫Ｚ",
						Language.CHN_TRA => "蟲Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BURN_DRIVE:
					return lang switch {
						Language.ENG => "Burn Drive",
						Language.JPN => "ブレイズカセット",
						Language.GER => "Flammenmodul",
						Language.FRE => "Module Pyro",
						Language.ITA => "Piromodulo",
						Language.SPN => "PiroROM",
						Language.KOR => "블레이즈카세트",
						Language.CHN_SIM => "火焰卡带",
						Language.CHN_TRA => "火焰卡帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CAMERUPTITE:
					return lang switch {
						Language.ENG => "Cameruptite",
						Language.JPN => "バクーダナイト",
						Language.GER => "Cameruptnit",
						Language.FRE => "Caméruptite",
						Language.ITA => "Cameruptite",
						Language.SPN => "Cameruptita",
						Language.KOR => "폭타나이트",
						Language.CHN_SIM => "喷火驼进化石",
						Language.CHN_TRA => "噴火駝進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CELL_BATTERY:
					return lang switch {
						Language.ENG => "Cell Battery",
						Language.JPN => "じゅうでんち",
						Language.GER => "Akku",
						Language.FRE => "Pile",
						Language.ITA => "Ricaripila",
						Language.SPN => "Pila",
						Language.KOR => "충전지",
						Language.CHN_SIM => "充电电池",
						Language.CHN_TRA => "充電電池",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHARCOAL:
					return lang switch {
						Language.ENG => "Charcoal",
						Language.JPN => "もくたん",
						Language.GER => "Holzkohle",
						Language.FRE => "Charbon",
						Language.ITA => "Carbonella",
						Language.SPN => "Carbón",
						Language.KOR => "목탄",
						Language.CHN_SIM => "木炭",
						Language.CHN_TRA => "木炭",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHARIZARDITE_X:
					return lang switch {
						Language.ENG => "Charizardite X",
						Language.JPN => "リザードナイトＸ",
						Language.GER => "Gluraknit X",
						Language.FRE => "Dracaufite X",
						Language.ITA => "Charizardite X",
						Language.SPN => "Charizardita X",
						Language.KOR => "리자몽나이트X",
						Language.CHN_SIM => "喷火龙进化石Ｘ",
						Language.CHN_TRA => "噴火龍進化石Ｘ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHARIZARDITE_Y:
					return lang switch {
						Language.ENG => "Charizardite Y",
						Language.JPN => "リザードナイトＹ",
						Language.GER => "Gluraknit Y",
						Language.FRE => "Dracaufite Y",
						Language.ITA => "Charizardite Y",
						Language.SPN => "Charizardita Y",
						Language.KOR => "리자몽나이트Y",
						Language.CHN_SIM => "喷火龙进化石Ｙ",
						Language.CHN_TRA => "噴火龍進化石Ｙ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHILL_DRIVE:
					return lang switch {
						Language.ENG => "Chill Drive",
						Language.JPN => "フリーズカセット",
						Language.GER => "Gefriermodul",
						Language.FRE => "Module Cryo",
						Language.ITA => "Gelomodulo",
						Language.SPN => "CrioROM",
						Language.KOR => "프리즈카세트",
						Language.CHN_SIM => "冰冻卡带",
						Language.CHN_TRA => "冰凍卡帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHIPPED_POT:
					return lang switch {
						Language.ENG => "Chipped Pot",
						Language.JPN => "かけたポット",
						Language.GER => "Löchrige Kanne",
						Language.FRE => "Théière Ébréchée",
						Language.ITA => "Teiera crepata",
						Language.SPN => "Tetera Rota",
						Language.KOR => "이빠진포트",
						Language.CHN_SIM => "缺损的茶壶",
						Language.CHN_TRA => "缺損的茶壺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHOICE_BAND:
					return lang switch {
						Language.ENG => "Choice Band",
						Language.JPN => "こだわりハチマキ",
						Language.GER => "Wahlband",
						Language.FRE => "Bandeau Choix",
						Language.ITA => "Bendascelta",
						Language.SPN => "Cinta Elección",
						Language.KOR => "구애머리띠",
						Language.CHN_SIM => "讲究头带",
						Language.CHN_TRA => "講究頭帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHOICE_SCARF:
					return lang switch {
						Language.ENG => "Choice Scarf",
						Language.JPN => "こだわりスカーフ",
						Language.GER => "Wahlschal",
						Language.FRE => "Mouchoir Choix",
						Language.ITA => "Stolascelta",
						Language.SPN => "Pañuelo Elección",
						Language.KOR => "구애스카프",
						Language.CHN_SIM => "讲究围巾",
						Language.CHN_TRA => "講究圍巾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHOICE_SPECS:
					return lang switch {
						Language.ENG => "Choice Specs",
						Language.JPN => "こだわりメガネ",
						Language.GER => "Wahlbrille",
						Language.FRE => "Lunettes Choix",
						Language.ITA => "Lentiscelta",
						Language.SPN => "Gafas Elección",
						Language.KOR => "구애안경",
						Language.CHN_SIM => "讲究眼镜",
						Language.CHN_TRA => "講究眼鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CLEANSE_TAG:
					return lang switch {
						Language.ENG => "Cleanse Tag",
						Language.JPN => "きよめのおふだ",
						Language.GER => "Schutzsticker",
						Language.FRE => "Rune Purifiante",
						Language.ITA => "Velopuro",
						Language.SPN => "Amuleto",
						Language.KOR => "순결의부적",
						Language.CHN_SIM => "洁净之符",
						Language.CHN_TRA => "潔淨之符",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CLOVER_SWEET:
					return lang switch {
						Language.ENG => "Clover Sweet",
						Language.JPN => "よつばアメざいく",
						Language.GER => "Zucker-Kleeblatt",
						Language.FRE => "Trèfle en Sucre",
						Language.ITA => "Bonbonfoglio",
						Language.SPN => "Confite Trébol",
						Language.KOR => "네잎사탕공예",
						Language.CHN_SIM => "幸运草糖饰",
						Language.CHN_TRA => "幸運草糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.COVERT_CLOAK:
					return lang switch {
						Language.ENG => "Covert Cloak",
						Language.JPN => "おんみつマント",
						Language.GER => "Tarnumhang",
						Language.FRE => "Cape Obscure",
						Language.ITA => "Anonimanto",
						Language.SPN => "Capa Furtiva",
						Language.KOR => "은밀망토",
						Language.CHN_SIM => "密探斗篷",
						Language.CHN_TRA => "密探斗篷",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CRACKED_POT:
					return lang switch {
						Language.ENG => "Cracked Pot",
						Language.JPN => "われたポット",
						Language.GER => "Rissige Kanne",
						Language.FRE => "Théière Fêlée",
						Language.ITA => "Teiera rotta",
						Language.SPN => "Tetera Agrietada",
						Language.KOR => "깨진포트",
						Language.CHN_SIM => "破裂的茶壶",
						Language.CHN_TRA => "破裂的茶壺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DAMP_ROCK:
					return lang switch {
						Language.ENG => "Damp Rock",
						Language.JPN => "しめったいわ",
						Language.GER => "Nassbrocken",
						Language.FRE => "Roche Humide",
						Language.ITA => "Rocciaumida",
						Language.SPN => "Roca Lluvia",
						Language.KOR => "축축한바위",
						Language.CHN_SIM => "潮湿岩石",
						Language.CHN_TRA => "潮濕岩石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DARK_GEM:
					return lang switch {
						Language.ENG => "Dark Gem",
						Language.JPN => "あくのジュエル",
						Language.GER => "Unlichtjuwel",
						Language.FRE => "Joyau Ténèbres",
						Language.ITA => "Bijoubuio",
						Language.SPN => "Gema Siniestro",
						Language.KOR => "악주얼",
						Language.CHN_SIM => "恶之宝石",
						Language.CHN_TRA => "惡之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DARK_MEMORY:
					return lang switch {
						Language.ENG => "Dark Memory",
						Language.JPN => "ダークメモリ",
						Language.GER => "Unlicht-Disc",
						Language.FRE => "ROM Ténèbres",
						Language.ITA => "ROM Buio",
						Language.SPN => "Disco Siniestro",
						Language.KOR => "다크메모리",
						Language.CHN_SIM => "黑暗存储碟",
						Language.CHN_TRA => "黑暗記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DARKINIUM_Z:
					return lang switch {
						Language.ENG => "Darkinium Z",
						Language.JPN => "アクＺ",
						Language.GER => "Noctium Z",
						Language.FRE => "Ténébrozélite",
						Language.ITA => "Obscurium Z",
						Language.SPN => "Nictostal Z",
						Language.KOR => "악Z",
						Language.CHN_SIM => "恶Ｚ",
						Language.CHN_TRA => "惡Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DECIDIUM_Z:
					return lang switch {
						Language.ENG => "Decidium Z",
						Language.JPN => "ジュナイパーＺ",
						Language.GER => "Silvarronium Z",
						Language.FRE => "Archézélite",
						Language.ITA => "Deciduenium Z",
						Language.SPN => "Dueyestal Z",
						Language.KOR => "모크나이퍼Z",
						Language.CHN_SIM => "狙射树枭Ｚ",
						Language.CHN_TRA => "狙射樹梟Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DEEP_SEA_SCALE:
					return lang switch {
						Language.ENG => "Deep Sea Scale",
						Language.JPN => "しんかいのウロコ",
						Language.GER => "Abyssschuppe",
						Language.FRE => "Écaille Océan",
						Language.ITA => "Squamabissi",
						Language.SPN => "Escama Marina",
						Language.KOR => "심해의비늘",
						Language.CHN_SIM => "深海鳞片",
						Language.CHN_TRA => "深海鱗片",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DEEP_SEA_TOOTH:
					return lang switch {
						Language.ENG => "Deep Sea Tooth",
						Language.JPN => "しんかいのキバ",
						Language.GER => "Abysszahn",
						Language.FRE => "Dent Océan",
						Language.ITA => "Dente abissi",
						Language.SPN => "Diente Marino",
						Language.KOR => "심해의이빨",
						Language.CHN_SIM => "深海之牙",
						Language.CHN_TRA => "深海之牙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DESTINY_KNOT:
					return lang switch {
						Language.ENG => "Destiny Knot",
						Language.JPN => "あかいいと",
						Language.GER => "Fatumknoten",
						Language.FRE => "Nœud Destin",
						Language.ITA => "Destincomune",
						Language.SPN => "Lazo Destino",
						Language.KOR => "빨간실",
						Language.CHN_SIM => "红线",
						Language.CHN_TRA => "紅線",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DIANCITE:
					return lang switch {
						Language.ENG => "Diancite",
						Language.JPN => "ディアンシナイト",
						Language.GER => "Diancienit",
						Language.FRE => "Diancite",
						Language.ITA => "Diancite",
						Language.SPN => "Diancita",
						Language.KOR => "디안시나이트",
						Language.CHN_SIM => "蒂安希进化石",
						Language.CHN_TRA => "蒂安希進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DOUSE_DRIVE:
					return lang switch {
						Language.ENG => "Douse Drive",
						Language.JPN => "アクアカセット",
						Language.GER => "Aquamodul",
						Language.FRE => "Module Aqua",
						Language.ITA => "Idromodulo",
						Language.SPN => "HidroROM",
						Language.KOR => "아쿠아카세트",
						Language.CHN_SIM => "水流卡带",
						Language.CHN_TRA => "水流卡帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DRACO_PLATE:
					return lang switch {
						Language.ENG => "Draco Plate",
						Language.JPN => "りゅうのプレート",
						Language.GER => "Dracotafel",
						Language.FRE => "Plaque Draco",
						Language.ITA => "Lastradrakon",
						Language.SPN => "Tabla Draco",
						Language.KOR => "용의플레이트",
						Language.CHN_SIM => "龙之石板",
						Language.CHN_TRA => "龍之石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DRAGON_FANG:
					return lang switch {
						Language.ENG => "Dragon Fang",
						Language.JPN => "りゅうのキバ",
						Language.GER => "Drachenzahn",
						Language.FRE => "Croc Dragon",
						Language.ITA => "Dente di drago",
						Language.SPN => "Colmillo Dragón",
						Language.KOR => "용의이빨",
						Language.CHN_SIM => "龙之牙",
						Language.CHN_TRA => "龍之牙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DRAGON_GEM:
					return lang switch {
						Language.ENG => "Dragon Gem",
						Language.JPN => "ドラゴンジュエル",
						Language.GER => "Drakojuwel",
						Language.FRE => "Joyau Dragon",
						Language.ITA => "Bijoudrago",
						Language.SPN => "Gema Dragón",
						Language.KOR => "드래곤주얼",
						Language.CHN_SIM => "龙之宝石",
						Language.CHN_TRA => "龍之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DRAGON_MEMORY:
					return lang switch {
						Language.ENG => "Dragon Memory",
						Language.JPN => "ドラゴンメモリ",
						Language.GER => "Drachen-Disc",
						Language.FRE => "ROM Dragon",
						Language.ITA => "ROM Drago",
						Language.SPN => "Disco Dragón",
						Language.KOR => "드래곤메모리",
						Language.CHN_SIM => "龙存储碟",
						Language.CHN_TRA => "龍記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DRAGONIUM_Z:
					return lang switch {
						Language.ENG => "Dragonium Z",
						Language.JPN => "ドラゴンＺ",
						Language.GER => "Dracium Z",
						Language.FRE => "Dracozélite",
						Language.ITA => "Draconium Z",
						Language.SPN => "Dracostal Z",
						Language.KOR => "드래곤Z",
						Language.CHN_SIM => "龙Ｚ",
						Language.CHN_TRA => "龍Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DREAD_PLATE:
					return lang switch {
						Language.ENG => "Dread Plate",
						Language.JPN => "こわもてプレート",
						Language.GER => "Furchttafel",
						Language.FRE => "Plaque Ombre",
						Language.ITA => "Lastratimore",
						Language.SPN => "Tabla Oscura",
						Language.KOR => "공포플레이트",
						Language.CHN_SIM => "恶颜石板",
						Language.CHN_TRA => "惡顏石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DROPPED_ITEM:
					return lang switch {
						Language.ENG => "Dropped Item",
						Language.JPN => "わすれもの",
						Language.GER => "Fundsache",
						Language.FRE => "Objet Trouvé",
						Language.ITA => "Oggetto perso",
						Language.SPN => "Objeto Perdido",
						Language.KOR => "잊은물건",
						Language.CHN_SIM => "遗忘物",
						Language.CHN_TRA => "遺忘物",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EARTH_PLATE:
					return lang switch {
						Language.ENG => "Earth Plate",
						Language.JPN => "だいちのプレート",
						Language.GER => "Erdtafel",
						Language.FRE => "Plaque Terre",
						Language.ITA => "Lastrageo",
						Language.SPN => "Tabla Terrax",
						Language.KOR => "대지플레이트",
						Language.CHN_SIM => "大地石板",
						Language.CHN_TRA => "大地石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EEVIUM_Z:
					return lang switch {
						Language.ENG => "Eevium Z",
						Language.JPN => "イーブイＺ",
						Language.GER => "Evolium Z",
						Language.FRE => "Évolizélite",
						Language.ITA => "Eevium Z",
						Language.SPN => "Eeveestal Z",
						Language.KOR => "이브이Z",
						Language.CHN_SIM => "伊布Ｚ",
						Language.CHN_TRA => "伊布Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EJECT_BUTTON:
					return lang switch {
						Language.ENG => "Eject Button",
						Language.JPN => "だっしゅつボタン",
						Language.GER => "Fluchtknopf",
						Language.FRE => "Bouton Fuite",
						Language.ITA => "Pulsantefuga",
						Language.SPN => "Botón Escape",
						Language.KOR => "탈출버튼",
						Language.CHN_SIM => "逃脱按键",
						Language.CHN_TRA => "逃脫按鍵",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EJECT_PACK:
					return lang switch {
						Language.ENG => "Eject Pack",
						Language.JPN => "だっしゅつパック",
						Language.GER => "Fluchttasche",
						Language.FRE => "Sac Fuite",
						Language.ITA => "Zainofuga",
						Language.SPN => "Mochila Escape",
						Language.KOR => "탈출팩",
						Language.CHN_SIM => "避难背包",
						Language.CHN_TRA => "避難背包",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ELECTRIC_GEM:
					return lang switch {
						Language.ENG => "Electric Gem",
						Language.JPN => "でんきのジュエル",
						Language.GER => "Elektrojuwel",
						Language.FRE => "Joyau Électrik",
						Language.ITA => "Bijouelettro",
						Language.SPN => "Gema Eléctrico",
						Language.KOR => "전기주얼",
						Language.CHN_SIM => "电之宝石",
						Language.CHN_TRA => "電之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ELECTRIC_MEMORY:
					return lang switch {
						Language.ENG => "Electric Memory",
						Language.JPN => "エレクトロメモリ",
						Language.GER => "Elektro-Disc",
						Language.FRE => "ROM Électrik",
						Language.ITA => "ROM Elettro",
						Language.SPN => "Disco Eléctrico",
						Language.KOR => "일렉트릭메모리",
						Language.CHN_SIM => "电子存储碟",
						Language.CHN_TRA => "電子記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ELECTRIC_SEED:
					return lang switch {
						Language.ENG => "Electric Seed",
						Language.JPN => "エレキシード",
						Language.GER => "Elektro-Samen",
						Language.FRE => "Graine Électrik",
						Language.ITA => "Elettroseme",
						Language.SPN => "Semilla Electro",
						Language.KOR => "일렉트릭시드",
						Language.CHN_SIM => "电气种子",
						Language.CHN_TRA => "電氣種子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ELECTRIUM_Z:
					return lang switch {
						Language.ENG => "Electrium Z",
						Language.JPN => "デンキＺ",
						Language.GER => "Voltium Z",
						Language.FRE => "Voltazélite",
						Language.ITA => "Electrium Z",
						Language.SPN => "Electrostal Z",
						Language.KOR => "전기Z",
						Language.CHN_SIM => "电Ｚ",
						Language.CHN_TRA => "電Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ELEVATOR_KEY:
					return lang switch {
						Language.ENG => "Elevator Key",
						Language.JPN => "エレベータのキー",
						Language.GER => "Liftschlüssel",
						Language.FRE => "Clé Ascenseur",
						Language.ITA => "Chiave ascensore",
						Language.SPN => "Llave del Ascensor",
						Language.KOR => "엘리베이터키",
						Language.CHN_SIM => "电梯钥匙",
						Language.CHN_TRA => "電梯鑰匙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EVERSTONE:
					return lang switch {
						Language.ENG => "Everstone",
						Language.JPN => "かわらずのいし",
						Language.GER => "Ewigstein",
						Language.FRE => "Pierre Stase",
						Language.ITA => "Pietrastante",
						Language.SPN => "Piedra Eterna",
						Language.KOR => "변함없는돌",
						Language.CHN_SIM => "不变之石",
						Language.CHN_TRA => "不變之石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EVIOLITE:
					return lang switch {
						Language.ENG => "Eviolite",
						Language.JPN => "しんかのきせき",
						Language.GER => "Evolith",
						Language.FRE => "Évoluroc",
						Language.ITA => "Evolcondensa",
						Language.SPN => "Mineral Evolutivo",
						Language.KOR => "진화의휘석",
						Language.CHN_SIM => "进化奇石",
						Language.CHN_TRA => "進化奇石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EXP_SHARE:
					return lang switch {
						Language.ENG => "Exp. Share",
						Language.JPN => "がくしゅうそうち",
						Language.GER => "EP-Teiler",
						Language.FRE => "Multi Exp",
						Language.ITA => "Condividi esperienza",
						Language.SPN => "Repartir Experiencia",
						Language.KOR => "학습장치",
						Language.CHN_SIM => "学习装置",
						Language.CHN_TRA => "學習裝置",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.EXPERT_BELT:
					return lang switch {
						Language.ENG => "Expert Belt",
						Language.JPN => "たつじんのおび",
						Language.GER => "Expertengurt",
						Language.FRE => "Ceinture Pro",
						Language.ITA => "Abilcintura",
						Language.SPN => "Cinta Experto",
						Language.KOR => "달인의띠",
						Language.CHN_SIM => "达人带",
						Language.CHN_TRA => "達人帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FAIRIUM_Z:
					return lang switch {
						Language.ENG => "Fairium Z",
						Language.JPN => "フェアリーＺ",
						Language.GER => "Sylphium Z",
						Language.FRE => "Nymphézélite",
						Language.ITA => "Follectium Z",
						Language.SPN => "Feeristal Z",
						Language.KOR => "페어리Z",
						Language.CHN_SIM => "妖精Ｚ",
						Language.CHN_TRA => "妖精Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FAIRY_MEMORY:
					return lang switch {
						Language.ENG => "Fairy Memory",
						Language.JPN => "フェアリーメモリ",
						Language.GER => "Feen-Disc",
						Language.FRE => "ROM Fée",
						Language.ITA => "ROM Folletto",
						Language.SPN => "Disco Hada",
						Language.KOR => "페어리메모리",
						Language.CHN_SIM => "妖精存储碟",
						Language.CHN_TRA => "妖精記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIGHTING_GEM:
					return lang switch {
						Language.ENG => "Fighting Gem",
						Language.JPN => "かくとうジュエル",
						Language.GER => "Kampfjuwel",
						Language.FRE => "Joyau Combat",
						Language.ITA => "Bijoulotta",
						Language.SPN => "Gema Lucha",
						Language.KOR => "격투주얼",
						Language.CHN_SIM => "格斗宝石",
						Language.CHN_TRA => "格鬥寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIGHTING_MEMORY:
					return lang switch {
						Language.ENG => "Fighting Memory",
						Language.JPN => "ファイトメモリ",
						Language.GER => "Kampf-Disc",
						Language.FRE => "ROM Combat",
						Language.ITA => "ROM Lotta",
						Language.SPN => "Disco Lucha",
						Language.KOR => "파이팅메모리",
						Language.CHN_SIM => "战斗存储碟",
						Language.CHN_TRA => "戰鬥記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIGHTINIUM_Z:
					return lang switch {
						Language.ENG => "Fightinium Z",
						Language.JPN => "カクトウＺ",
						Language.GER => "Battalium Z",
						Language.FRE => "Combazélite",
						Language.ITA => "Luctium Z",
						Language.SPN => "Lizastal Z",
						Language.KOR => "격투Z",
						Language.CHN_SIM => "格斗Ｚ",
						Language.CHN_TRA => "格鬥Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIRE_GEM:
					return lang switch {
						Language.ENG => "Fire Gem",
						Language.JPN => "ほのおのジュエル",
						Language.GER => "Feuerjuwel",
						Language.FRE => "Joyau Feu",
						Language.ITA => "Bijoufuoco",
						Language.SPN => "Gema Fuego",
						Language.KOR => "불꽃주얼",
						Language.CHN_SIM => "火之宝石",
						Language.CHN_TRA => "火之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIRE_MEMORY:
					return lang switch {
						Language.ENG => "Fire Memory",
						Language.JPN => "ファイヤーメモリ",
						Language.GER => "Feuer-Disc",
						Language.FRE => "ROM Feu",
						Language.ITA => "ROM Fuoco",
						Language.SPN => "Disco Fuego",
						Language.KOR => "파이어메모리",
						Language.CHN_SIM => "火焰存储碟",
						Language.CHN_TRA => "火焰記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIRIUM_Z:
					return lang switch {
						Language.ENG => "Firium Z",
						Language.JPN => "ホノオＺ",
						Language.GER => "Pyrium Z",
						Language.FRE => "Pyrozélite",
						Language.ITA => "Pirium Z",
						Language.SPN => "Pirostal Z",
						Language.KOR => "불꽃Z",
						Language.CHN_SIM => "火Ｚ",
						Language.CHN_TRA => "火Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIST_PLATE:
					return lang switch {
						Language.ENG => "Fist Plate",
						Language.JPN => "こぶしのプレート",
						Language.GER => "Fausttafel",
						Language.FRE => "Plaque Poing",
						Language.ITA => "Lastrapugno",
						Language.SPN => "Tabla Fuerte",
						Language.KOR => "주먹플레이트",
						Language.CHN_SIM => "拳头石板",
						Language.CHN_TRA => "拳頭石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLAME_ORB:
					return lang switch {
						Language.ENG => "Flame Orb",
						Language.JPN => "かえんだま",
						Language.GER => "Heiß-Orb",
						Language.FRE => "Orbe Flamme",
						Language.ITA => "Fiammosfera",
						Language.SPN => "Llamasfera",
						Language.KOR => "화염구슬",
						Language.CHN_SIM => "火焰宝珠",
						Language.CHN_TRA => "火焰寶珠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLAME_PLATE:
					return lang switch {
						Language.ENG => "Flame Plate",
						Language.JPN => "ひのたまプレート",
						Language.GER => "Feuertafel",
						Language.FRE => "Plaque Flamme",
						Language.ITA => "Lastrarogo",
						Language.SPN => "Tabla Llama",
						Language.KOR => "불구슬플레이트",
						Language.CHN_SIM => "火球石板",
						Language.CHN_TRA => "火球石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLOAT_STONE:
					return lang switch {
						Language.ENG => "Float Stone",
						Language.JPN => "かるいし",
						Language.GER => "Leichtstein",
						Language.FRE => "Pierrallégée",
						Language.ITA => "Pietralieve",
						Language.SPN => "Piedra Pómez",
						Language.KOR => "가벼운돌",
						Language.CHN_SIM => "轻石",
						Language.CHN_TRA => "輕石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLOWER_SWEET:
					return lang switch {
						Language.ENG => "Flower Sweet",
						Language.JPN => "おはなアメざいく",
						Language.GER => "Zucker-Blume",
						Language.FRE => "Fleur en Sucre",
						Language.ITA => "Bonbonfiore",
						Language.SPN => "Confite Flor",
						Language.KOR => "꽃사탕공예",
						Language.CHN_SIM => "花朵糖饰",
						Language.CHN_TRA => "花朵糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLYING_GEM:
					return lang switch {
						Language.ENG => "Flying Gem",
						Language.JPN => "ひこうのジュエル",
						Language.GER => "Flugjuwel",
						Language.FRE => "Joyau Vol",
						Language.ITA => "Bijouvolante",
						Language.SPN => "Gema Volador",
						Language.KOR => "비행주얼",
						Language.CHN_SIM => "飞行宝石",
						Language.CHN_TRA => "飛行寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLYING_MEMORY:
					return lang switch {
						Language.ENG => "Flying Memory",
						Language.JPN => "フライングメモリ",
						Language.GER => "Flug-Disc",
						Language.FRE => "ROM Vol",
						Language.ITA => "ROM Volante",
						Language.SPN => "Disco Volador",
						Language.KOR => "플라잉메모리",
						Language.CHN_SIM => "飞翔存储碟",
						Language.CHN_TRA => "飛翔記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FLYINIUM_Z:
					return lang switch {
						Language.ENG => "Flyinium Z",
						Language.JPN => "ヒコウＺ",
						Language.GER => "Aerium Z",
						Language.FRE => "Aérozélite",
						Language.ITA => "Volantium Z",
						Language.SPN => "Aerostal Z",
						Language.KOR => "비행Z",
						Language.CHN_SIM => "飞行Ｚ",
						Language.CHN_TRA => "飛行Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FOCUS_BAND:
					return lang switch {
						Language.ENG => "Focus Band",
						Language.JPN => "きあいのハチマキ",
						Language.GER => "Fokusband",
						Language.FRE => "Bandeau",
						Language.ITA => "Bandana",
						Language.SPN => "Cinta Aguante",
						Language.KOR => "기합의머리띠",
						Language.CHN_SIM => "气势头带",
						Language.CHN_TRA => "氣勢頭帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FOCUS_SASH:
					return lang switch {
						Language.ENG => "Focus Sash",
						Language.JPN => "きあいのタスキ",
						Language.GER => "Fokusgurt",
						Language.FRE => "Ceinture Force",
						Language.ITA => "Focalnastro",
						Language.SPN => "Banda Aguante",
						Language.KOR => "기합의띠",
						Language.CHN_SIM => "气势披带",
						Language.CHN_TRA => "氣勢披帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FULL_INCENSE:
					return lang switch {
						Language.ENG => "Full Incense",
						Language.JPN => "まんぷくおこう",
						Language.GER => "Lahmrauch",
						Language.FRE => "Encens Plein",
						Language.ITA => "Gonfioaroma",
						Language.SPN => "Incienso Lento",
						Language.KOR => "만복향로",
						Language.CHN_SIM => "饱腹薰香",
						Language.CHN_TRA => "飽腹薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GALLADITE:
					return lang switch {
						Language.ENG => "Galladite",
						Language.JPN => "エルレイドナイト",
						Language.GER => "Galagladinit",
						Language.FRE => "Gallamite",
						Language.ITA => "Galladite",
						Language.SPN => "Galladita",
						Language.KOR => "엘레이드나이트",
						Language.CHN_SIM => "艾路雷朵进化石",
						Language.CHN_TRA => "艾路雷朵進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GARCHOMPITE:
					return lang switch {
						Language.ENG => "Garchompite",
						Language.JPN => "ガブリアスナイト",
						Language.GER => "Knakracknit",
						Language.FRE => "Carchacrokite",
						Language.ITA => "Garchompite",
						Language.SPN => "Garchompita",
						Language.KOR => "한카리아스나이트",
						Language.CHN_SIM => "烈咬陆鲨进化石",
						Language.CHN_TRA => "烈咬陸鯊進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GARDEVOIRITE:
					return lang switch {
						Language.ENG => "Gardevoirite",
						Language.JPN => "サーナイトナイト",
						Language.GER => "Guardevoirnit",
						Language.FRE => "Gardevoirite",
						Language.ITA => "Gardevoirite",
						Language.SPN => "Gardevoirita",
						Language.KOR => "가디안나이트",
						Language.CHN_SIM => "沙奈朵进化石",
						Language.CHN_TRA => "沙奈朵進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GENGARITE:
					return lang switch {
						Language.ENG => "Gengarite",
						Language.JPN => "ゲンガナイト",
						Language.GER => "Gengarnit",
						Language.FRE => "Ectoplasmite",
						Language.ITA => "Gengarite",
						Language.SPN => "Gengarita",
						Language.KOR => "팬텀나이트",
						Language.CHN_SIM => "耿鬼进化石",
						Language.CHN_TRA => "耿鬼進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GHOST_GEM:
					return lang switch {
						Language.ENG => "Ghost Gem",
						Language.JPN => "ゴーストジュエル",
						Language.GER => "Geisterjuwel",
						Language.FRE => "Joyau Spectre",
						Language.ITA => "Bijouspettro",
						Language.SPN => "Gema Fantasma",
						Language.KOR => "고스트주얼",
						Language.CHN_SIM => "幽灵宝石",
						Language.CHN_TRA => "幽靈寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GHOST_MEMORY:
					return lang switch {
						Language.ENG => "Ghost Memory",
						Language.JPN => "ゴーストメモリ",
						Language.GER => "Geister-Disc",
						Language.FRE => "ROM Spectre",
						Language.ITA => "ROM Spettro",
						Language.SPN => "Disco Fantasma",
						Language.KOR => "고스트메모리",
						Language.CHN_SIM => "幽灵存储碟",
						Language.CHN_TRA => "幽靈記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GHOSTIUM_Z:
					return lang switch {
						Language.ENG => "Ghostium Z",
						Language.JPN => "ゴーストＺ",
						Language.GER => "Phantomium Z",
						Language.FRE => "Spectrozélite",
						Language.ITA => "Spectrium Z",
						Language.SPN => "Espectrostal Z",
						Language.KOR => "고스트Z",
						Language.CHN_SIM => "幽灵Ｚ",
						Language.CHN_TRA => "幽靈Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GLALITITE:
					return lang switch {
						Language.ENG => "Glalitite",
						Language.JPN => "オニゴーリナイト",
						Language.GER => "Firnontornit",
						Language.FRE => "Oniglalite",
						Language.ITA => "Glalite",
						Language.SPN => "Glalita",
						Language.KOR => "얼음귀신나이트",
						Language.CHN_SIM => "冰鬼护进化石",
						Language.CHN_TRA => "冰鬼護進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRASS_GEM:
					return lang switch {
						Language.ENG => "Grass Gem",
						Language.JPN => "くさのジュエル",
						Language.GER => "Pflanzenjuwel",
						Language.FRE => "Joyau Plante",
						Language.ITA => "Bijouerba",
						Language.SPN => "Gema Planta",
						Language.KOR => "풀주얼",
						Language.CHN_SIM => "草之宝石",
						Language.CHN_TRA => "草之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRASS_MEMORY:
					return lang switch {
						Language.ENG => "Grass Memory",
						Language.JPN => "グラスメモリ",
						Language.GER => "Pflanzen-Disc",
						Language.FRE => "ROM Plante",
						Language.ITA => "ROM Erba",
						Language.SPN => "Disco Planta",
						Language.KOR => "그래스메모리",
						Language.CHN_SIM => "青草存储碟",
						Language.CHN_TRA => "青草記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRASSIUM_Z:
					return lang switch {
						Language.ENG => "Grassium Z",
						Language.JPN => "クサＺ",
						Language.GER => "Botanium Z",
						Language.FRE => "Florazélite",
						Language.ITA => "Herbium Z",
						Language.SPN => "Fitostal Z",
						Language.KOR => "풀Z",
						Language.CHN_SIM => "草Ｚ",
						Language.CHN_TRA => "草Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRASSY_SEED:
					return lang switch {
						Language.ENG => "Grassy Seed",
						Language.JPN => "グラスシード",
						Language.GER => "Gras-Samen",
						Language.FRE => "Graine Herbe",
						Language.ITA => "Erbaseme",
						Language.SPN => "Semilla Hierba",
						Language.KOR => "그래스시드",
						Language.CHN_SIM => "青草种子",
						Language.CHN_TRA => "青草種子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRIP_CLAW:
					return lang switch {
						Language.ENG => "Grip Claw",
						Language.JPN => "ねばりのかぎづめ",
						Language.GER => "Griffklaue",
						Language.FRE => "Accro Griffe",
						Language.ITA => "Presartiglio",
						Language.SPN => "Garra Garfio",
						Language.KOR => "끈기갈고리손톱",
						Language.CHN_SIM => "紧缠钩爪",
						Language.CHN_TRA => "緊纏鉤爪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRISEOUS_CORE:
					return lang switch {
						Language.ENG => "Griseous Core",
						Language.JPN => "だいはっきんだま",
						Language.GER => "Platinumkristall",
						Language.FRE => "Globe Platiné",
						Language.ITA => "Grigiosferoide",
						Language.SPN => "Gran Griseosfera",
						Language.KOR => "큰백금옥",
						Language.CHN_SIM => "大白金宝玉",
						Language.CHN_TRA => "大白金寶玉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRISEOUS_ORB:
					return lang switch {
						Language.ENG => "Griseous Orb",
						Language.JPN => "はっきんだま",
						Language.GER => "Platinum-Orb",
						Language.FRE => "Orbe Platiné",
						Language.ITA => "Grigiosfera",
						Language.SPN => "Griseosfera",
						Language.KOR => "백금옥",
						Language.CHN_SIM => "白金宝珠",
						Language.CHN_TRA => "白金寶珠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRIT_DUST:
					return lang switch {
						Language.ENG => "Grit Dust",
						Language.JPN => "ガンバリのすな",
						Language.GER => "Leistungssand",
						Language.FRE => "Sable Effort",
						Language.ITA => "Sabbia impegno",
						Language.SPN => "Polvo Esfuerzo",
						Language.KOR => "노력의모래",
						Language.CHN_SIM => "奋斗沙",
						Language.CHN_TRA => "奮鬥沙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRIT_GRAVEL:
					return lang switch {
						Language.ENG => "Grit Gravel",
						Language.JPN => "ガンバリのじゃり",
						Language.GER => "Leistungskies",
						Language.FRE => "Cailloux Effort",
						Language.ITA => "Ghiaia impegno",
						Language.SPN => "Grava Esfuerzo",
						Language.KOR => "노력의자갈",
						Language.CHN_SIM => "奋斗砾",
						Language.CHN_TRA => "奮鬥礫",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRIT_PEBBLE:
					return lang switch {
						Language.ENG => "Grit Pebble",
						Language.JPN => "ガンバリのいし",
						Language.GER => "Leistungsstein",
						Language.FRE => "Pierre Effort",
						Language.ITA => "Pietra impegno",
						Language.SPN => "Piedra Esfuerzo",
						Language.KOR => "노력의돌",
						Language.CHN_SIM => "奋斗石",
						Language.CHN_TRA => "奮鬥石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRIT_ROCK:
					return lang switch {
						Language.ENG => "Grit Rock",
						Language.JPN => "ガンバリのいわ",
						Language.GER => "Leistungsfels",
						Language.FRE => "Rocher Effort",
						Language.ITA => "Roccia impegno",
						Language.SPN => "Roca Esfuerzo",
						Language.KOR => "노력의바위",
						Language.CHN_SIM => "奋斗岩",
						Language.CHN_TRA => "奮鬥岩",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GROUND_GEM:
					return lang switch {
						Language.ENG => "Ground Gem",
						Language.JPN => "じめんのジュエル",
						Language.GER => "Bodenjuwel",
						Language.FRE => "Joyau Sol",
						Language.ITA => "Bijouterra",
						Language.SPN => "Gema Tierra",
						Language.KOR => "땅주얼",
						Language.CHN_SIM => "地面宝石",
						Language.CHN_TRA => "地面寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GROUND_MEMORY:
					return lang switch {
						Language.ENG => "Ground Memory",
						Language.JPN => "グラウンドメモリ",
						Language.GER => "Boden-Disc",
						Language.FRE => "ROM Sol",
						Language.ITA => "ROM Terra",
						Language.SPN => "Disco Tierra",
						Language.KOR => "그라운드메모리",
						Language.CHN_SIM => "大地存储碟",
						Language.CHN_TRA => "大地記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GROUNDIUM_Z:
					return lang switch {
						Language.ENG => "Groundium Z",
						Language.JPN => "ジメンＺ",
						Language.GER => "Terrium Z",
						Language.FRE => "Terrazélite",
						Language.ITA => "Terrium Z",
						Language.SPN => "Geostal Z",
						Language.KOR => "땅Z",
						Language.CHN_SIM => "地面Ｚ",
						Language.CHN_TRA => "地面Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GRUBBY_HANKY:
					return lang switch {
						Language.ENG => "Grubby Hanky",
						Language.JPN => "よごれたハンカチ",
						Language.GER => "Schnäuztuch",
						Language.FRE => "Mouchoir Sale",
						Language.ITA => "Pezza sporca",
						Language.SPN => "Pañuelo Sucio",
						Language.KOR => "더러운손수건",
						Language.CHN_SIM => "脏手帕",
						Language.CHN_TRA => "髒手帕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GYARADOSITE:
					return lang switch {
						Language.ENG => "Gyaradosite",
						Language.JPN => "ギャラドスナイト",
						Language.GER => "Garadosnit",
						Language.FRE => "Léviatorite",
						Language.ITA => "Gyaradosite",
						Language.SPN => "Gyaradosita",
						Language.KOR => "갸라도스나이트",
						Language.CHN_SIM => "暴鲤龙进化石",
						Language.CHN_TRA => "暴鯉龍進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HARD_STONE:
					return lang switch {
						Language.ENG => "Hard Stone",
						Language.JPN => "かたいいし",
						Language.GER => "Granitstein",
						Language.FRE => "Pierre Dure",
						Language.ITA => "Pietradura",
						Language.SPN => "Piedra Dura",
						Language.KOR => "딱딱한돌",
						Language.CHN_SIM => "硬石头",
						Language.CHN_TRA => "硬石頭",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HEAT_ROCK:
					return lang switch {
						Language.ENG => "Heat Rock",
						Language.JPN => "あついいわ",
						Language.GER => "Heißbrocken",
						Language.FRE => "Roche Chaude",
						Language.ITA => "Rocciacalda",
						Language.SPN => "Roca Calor",
						Language.KOR => "뜨거운바위",
						Language.CHN_SIM => "炽热岩石",
						Language.CHN_TRA => "熾熱岩石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HEAVY_DUTY_BOOTS:
					return lang switch {
						Language.ENG => "Heavy-Duty Boots",
						Language.JPN => "あつぞこブーツ",
						Language.GER => "Plateauschuhe",
						Language.FRE => "Grosses Bottes",
						Language.ITA => "Scarponi robusti",
						Language.SPN => "Botas Gruesas",
						Language.KOR => "통굽부츠",
						Language.CHN_SIM => "厚底靴",
						Language.CHN_TRA => "厚底靴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HERACRONITE:
					return lang switch {
						Language.ENG => "Heracronite",
						Language.JPN => "ヘラクロスナイト",
						Language.GER => "Skarabornit",
						Language.FRE => "Scarhinoïte",
						Language.ITA => "Heracrossite",
						Language.SPN => "Heracrossita",
						Language.KOR => "헤라크로스나이트",
						Language.CHN_SIM => "赫拉克罗斯进化石",
						Language.CHN_TRA => "赫拉克羅斯進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HI_TECH_EARBUDS:
					return lang switch {
						Language.ENG => "Hi-tech Earbuds",
						Language.JPN => "すごいみみせん",
						Language.GER => "Top-Ohrenstöpsel",
						Language.FRE => "Bouchons Audio",
						Language.ITA => "Supertappi",
						Language.SPN => "Supertapones",
						Language.KOR => "대단한귀마개",
						Language.CHN_SIM => "厉害耳塞",
						Language.CHN_TRA => "厲害耳塞",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HONOR_OF_KALOS:
					return lang switch {
						Language.ENG => "Honor Of Kalos",
						Language.JPN => "カロスエンブレム",
						Language.GER => "Kalos-Emblem",
						Language.FRE => "Insigne de Kalos",
						Language.ITA => "Emblema di Kalos",
						Language.SPN => "Emblema de Kalos",
						Language.KOR => "칼로스엠블럼",
						Language.CHN_SIM => "卡洛斯勋章",
						Language.CHN_TRA => "卡洛斯勳章",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HOUNDOOMINITE:
					return lang switch {
						Language.ENG => "Houndoominite",
						Language.JPN => "ヘルガナイト",
						Language.GER => "Hundemonit",
						Language.FRE => "Démolossite",
						Language.ITA => "Houndoomite",
						Language.SPN => "Houndoomita",
						Language.KOR => "헬가나이트",
						Language.CHN_SIM => "黑鲁加进化石",
						Language.CHN_TRA => "黑魯加進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ICE_GEM:
					return lang switch {
						Language.ENG => "Ice Gem",
						Language.JPN => "こおりのジュエル",
						Language.GER => "Eisjuwel",
						Language.FRE => "Joyau Glace",
						Language.ITA => "Bijoughiaccio",
						Language.SPN => "Gema Hielo",
						Language.KOR => "얼음주얼",
						Language.CHN_SIM => "冰之宝石",
						Language.CHN_TRA => "冰之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ICE_MEMORY:
					return lang switch {
						Language.ENG => "Ice Memory",
						Language.JPN => "アイスメモリ",
						Language.GER => "Eis-Disc",
						Language.FRE => "ROM Glace",
						Language.ITA => "ROM Ghiaccio",
						Language.SPN => "Disco Hielo",
						Language.KOR => "아이스메모리",
						Language.CHN_SIM => "冰雪存储碟",
						Language.CHN_TRA => "冰雪記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ICICLE_PLATE:
					return lang switch {
						Language.ENG => "Icicle Plate",
						Language.JPN => "つららのプレート",
						Language.GER => "Frosttafel",
						Language.FRE => "Plaque Glace",
						Language.ITA => "Lastragelo",
						Language.SPN => "Tabla Helada",
						Language.KOR => "고드름플레이트",
						Language.CHN_SIM => "冰柱石板",
						Language.CHN_TRA => "冰柱石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ICIUM_Z:
					return lang switch {
						Language.ENG => "Icium Z",
						Language.JPN => "コオリＺ",
						Language.GER => "Glacium Z",
						Language.FRE => "Cryozélite",
						Language.ITA => "Glacium Z",
						Language.SPN => "Criostal Z",
						Language.KOR => "얼음Z",
						Language.CHN_SIM => "冰Ｚ",
						Language.CHN_TRA => "冰Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ICY_ROCK:
					return lang switch {
						Language.ENG => "Icy Rock",
						Language.JPN => "つめたいいわ",
						Language.GER => "Eisbrocken",
						Language.FRE => "Roche Glace",
						Language.ITA => "Rocciafredda",
						Language.SPN => "Roca Helada",
						Language.KOR => "차가운바위",
						Language.CHN_SIM => "冰冷岩石",
						Language.CHN_TRA => "冰冷岩石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.INCINIUM_Z:
					return lang switch {
						Language.ENG => "Incinium Z",
						Language.JPN => "ガオガエンＺ",
						Language.GER => "Fuegronium Z",
						Language.FRE => "Félinozélite",
						Language.ITA => "Incineronium Z",
						Language.SPN => "Incinostal Z",
						Language.KOR => "어흥염Z",
						Language.CHN_SIM => "炽焰咆哮虎Ｚ",
						Language.CHN_TRA => "熾焰咆哮虎Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.INSECT_PLATE:
					return lang switch {
						Language.ENG => "Insect Plate",
						Language.JPN => "たまむしプレート",
						Language.GER => "Käfertafel",
						Language.FRE => "Plaque Insecte",
						Language.ITA => "Lastrabaco",
						Language.SPN => "Tabla Bicho",
						Language.KOR => "비단벌레플레이트",
						Language.CHN_SIM => "玉虫石板",
						Language.CHN_TRA => "玉蟲石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.INTRIGUING_STONE:
					return lang switch {
						Language.ENG => "Intriguing Stone",
						Language.JPN => "すごそうないし",
						Language.GER => "Kurioser Stein",
						Language.FRE => "Pierre Insolite",
						Language.ITA => "Sasso suggestivo",
						Language.SPN => "Piedra Insólita",
						Language.KOR => "대단할듯한돌",
						Language.CHN_SIM => "似珍石",
						Language.CHN_TRA => "似珍石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.IRON_BALL:
					return lang switch {
						Language.ENG => "Iron Ball",
						Language.JPN => "くろいてっきゅう",
						Language.GER => "Eisenkugel",
						Language.FRE => "Balle Fer",
						Language.ITA => "Ferropalla",
						Language.SPN => "Bola Férrea",
						Language.KOR => "검은철구",
						Language.CHN_SIM => "黑色铁球",
						Language.CHN_TRA => "黑色鐵球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.IRON_PLATE:
					return lang switch {
						Language.ENG => "Iron Plate",
						Language.JPN => "こうてつプレート",
						Language.GER => "Eisentafel",
						Language.FRE => "Plaque Fer",
						Language.ITA => "Lastraferro",
						Language.SPN => "Tabla Acero",
						Language.KOR => "강철플레이트",
						Language.CHN_SIM => "钢铁石板",
						Language.CHN_TRA => "鋼鐵石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KANGASKHANITE:
					return lang switch {
						Language.ENG => "Kangaskhanite",
						Language.JPN => "ガルーラナイト",
						Language.GER => "Kangamanit",
						Language.FRE => "Kangourexite",
						Language.ITA => "Kangaskhanite",
						Language.SPN => "Kangaskhanita",
						Language.KOR => "캥카나이트",
						Language.CHN_SIM => "袋兽进化石",
						Language.CHN_TRA => "袋獸進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KINGS_ROCK:
					return lang switch {
						Language.ENG => "King's Rock",
						Language.JPN => "おうじゃのしるし",
						Language.GER => "King-Stein",
						Language.FRE => "Roche Royale",
						Language.ITA => "Roccia di re",
						Language.SPN => "Roca del Rey",
						Language.KOR => "왕의징표석",
						Language.CHN_SIM => "王者之证",
						Language.CHN_TRA => "王者之證",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KOMMONIUM_Z:
					return lang switch {
						Language.ENG => "Kommonium Z",
						Language.JPN => "ジャラランガＺ",
						Language.GER => "Grandirasium Z",
						Language.FRE => "Ékaïzélite",
						Language.ITA => "Kommonium Z",
						Language.SPN => "Kommostal Z",
						Language.KOR => "짜랑고우거Z",
						Language.CHN_SIM => "杖尾鳞甲龙Ｚ",
						Language.CHN_TRA => "杖尾鱗甲龍Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LAGGING_TAIL:
					return lang switch {
						Language.ENG => "Lagging Tail",
						Language.JPN => "こうこうのしっぽ",
						Language.GER => "Schwerschweif",
						Language.FRE => "Ralentiqueue",
						Language.ITA => "Rallentocoda",
						Language.SPN => "Cola Plúmbea",
						Language.KOR => "느림보꼬리",
						Language.CHN_SIM => "后攻之尾",
						Language.CHN_TRA => "後攻之尾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LATIASITE:
					return lang switch {
						Language.ENG => "Latiasite",
						Language.JPN => "ラティアスナイト",
						Language.GER => "Latiasnit",
						Language.FRE => "Latiasite",
						Language.ITA => "Latiasite",
						Language.SPN => "Latiasita",
						Language.KOR => "라티아스나이트",
						Language.CHN_SIM => "拉帝亚斯进化石",
						Language.CHN_TRA => "拉帝亞斯進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LATIOSITE:
					return lang switch {
						Language.ENG => "Latiosite",
						Language.JPN => "ラティオスナイト",
						Language.GER => "Latiosnit",
						Language.FRE => "Latiosite",
						Language.ITA => "Latiosite",
						Language.SPN => "Latiosita",
						Language.KOR => "라티오스나이트",
						Language.CHN_SIM => "拉帝欧斯进化石",
						Language.CHN_TRA => "拉帝歐斯進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LAX_INCENSE:
					return lang switch {
						Language.ENG => "Lax Incense",
						Language.JPN => "のんきのおこう",
						Language.GER => "Laxrauch",
						Language.FRE => "Encens Doux",
						Language.ITA => "Distraroma",
						Language.SPN => "Incienso Suave",
						Language.KOR => "무사태평향로",
						Language.CHN_SIM => "悠闲薰香",
						Language.CHN_TRA => "悠閒薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LEEK:
					return lang switch {
						Language.ENG => "Leek",
						Language.JPN => "ながねぎ",
						Language.GER => "Lauchstange",
						Language.FRE => "Poireau",
						Language.ITA => "Porro",
						Language.SPN => "Puerro",
						Language.KOR => "대파",
						Language.CHN_SIM => "大葱",
						Language.CHN_TRA => "大蔥",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LEFTOVERS:
					return lang switch {
						Language.ENG => "Leftovers",
						Language.JPN => "たべのこし",
						Language.GER => "Überreste",
						Language.FRE => "Restes",
						Language.ITA => "Avanzi",
						Language.SPN => "Restos",
						Language.KOR => "먹다남은음식",
						Language.CHN_SIM => "吃剩的东西",
						Language.CHN_TRA => "吃剩的東西",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LEGEND_PLATE:
					return lang switch {
						Language.ENG => "Legend Plate",
						Language.JPN => "レジェンドプレート",
						Language.GER => "Legendentafel",
						Language.FRE => "Plaque Légende",
						Language.ITA => "Lastraleggenda",
						Language.SPN => "Tabla Legendaria",
						Language.KOR => "레전드플레이트",
						Language.CHN_SIM => "传说石板",
						Language.CHN_TRA => "傳說石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LIFE_ORB:
					return lang switch {
						Language.ENG => "Life Orb",
						Language.JPN => "いのちのたま",
						Language.GER => "Leben-Orb",
						Language.FRE => "Orbe Vie",
						Language.ITA => "Assorbisfera",
						Language.SPN => "Vidasfera",
						Language.KOR => "생명의구슬",
						Language.CHN_SIM => "生命宝珠",
						Language.CHN_TRA => "生命寶珠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LIGHT_BALL:
					return lang switch {
						Language.ENG => "Light Ball",
						Language.JPN => "でんきだま",
						Language.GER => "Kugelblitz",
						Language.FRE => "Balle Lumière",
						Language.ITA => "Elettropalla",
						Language.SPN => "Bola Luminosa",
						Language.KOR => "전기구슬",
						Language.CHN_SIM => "电气球",
						Language.CHN_TRA => "電氣球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LIGHT_CLAY:
					return lang switch {
						Language.ENG => "Light Clay",
						Language.JPN => "ひかりのねんど",
						Language.GER => "Lichtlehm",
						Language.FRE => "Lumargile",
						Language.ITA => "Creta luce",
						Language.SPN => "Refleluz",
						Language.KOR => "빛의점토",
						Language.CHN_SIM => "光之黏土",
						Language.CHN_TRA => "光之黏土",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LOADED_DICE:
					return lang switch {
						Language.ENG => "Loaded Dice",
						Language.JPN => "いかさまダイス",
						Language.GER => "Gezinkter Würfel",
						Language.FRE => "Dé Pipé",
						Language.ITA => "Dado truccato",
						Language.SPN => "Dado Trucado",
						Language.KOR => "속임수주사위",
						Language.CHN_SIM => "机变骰子",
						Language.CHN_TRA => "老千骰子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LOOKER_TICKET:
					return lang switch {
						Language.ENG => "Looker Ticket",
						Language.JPN => "ハンサムチケット",
						Language.GER => "LeBelle-Ticket",
						Language.FRE => "Ticket Beladonis",
						Language.ITA => "Carta Bellocchio",
						Language.SPN => "Boleto Handsome",
						Language.KOR => "핸섬티켓",
						Language.CHN_SIM => "帅哥券",
						Language.CHN_TRA => "帥哥券",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LOPUNNITE:
					return lang switch {
						Language.ENG => "Lopunnite",
						Language.JPN => "ミミロップナイト",
						Language.GER => "Schlapornit",
						Language.FRE => "Lockpinite",
						Language.ITA => "Lopunnite",
						Language.SPN => "Lopunnita",
						Language.KOR => "이어롭나이트",
						Language.CHN_SIM => "长耳兔进化石",
						Language.CHN_TRA => "長耳兔進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LOVE_SWEET:
					return lang switch {
						Language.ENG => "Love Sweet",
						Language.JPN => "ハートアメざいく",
						Language.GER => "Zucker-Herz",
						Language.FRE => "Cœur en Sucre",
						Language.ITA => "Bonboncuore",
						Language.SPN => "Confite Corazón",
						Language.KOR => "하트사탕공예",
						Language.CHN_SIM => "爱心糖饰",
						Language.CHN_TRA => "愛心糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUCARIONITE:
					return lang switch {
						Language.ENG => "Lucarionite",
						Language.JPN => "ルカリオナイト",
						Language.GER => "Lucarionit",
						Language.FRE => "Lucarite",
						Language.ITA => "Lucarite",
						Language.SPN => "Lucarita",
						Language.KOR => "루카리오나이트",
						Language.CHN_SIM => "路卡利欧进化石",
						Language.CHN_TRA => "路卡利歐進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUCK_INCENSE:
					return lang switch {
						Language.ENG => "Luck Incense",
						Language.JPN => "こううんのおこう",
						Language.GER => "Glücksrauch",
						Language.FRE => "Encens Veine",
						Language.ITA => "Fortunaroma",
						Language.SPN => "Incienso Duplo",
						Language.KOR => "행운의향로",
						Language.CHN_SIM => "幸运薰香",
						Language.CHN_TRA => "幸運薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUCKY_EGG:
					return lang switch {
						Language.ENG => "Lucky Egg",
						Language.JPN => "しあわせタマゴ",
						Language.GER => "Glücks-Ei",
						Language.FRE => "Œuf Chance",
						Language.ITA => "Fortunuovo",
						Language.SPN => "Huevo Suerte",
						Language.KOR => "행복의알",
						Language.CHN_SIM => "幸运蛋",
						Language.CHN_TRA => "幸運蛋",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUCKY_PUNCH:
					return lang switch {
						Language.ENG => "Lucky Punch",
						Language.JPN => "ラッキーパンチ",
						Language.GER => "Lucky Punch",
						Language.FRE => "Poing Chance",
						Language.ITA => "Fortunpugno",
						Language.SPN => "Puño Suerte",
						Language.KOR => "럭키펀치",
						Language.CHN_SIM => "吉利拳",
						Language.CHN_TRA => "吉利拳",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUMINOUS_MOSS:
					return lang switch {
						Language.ENG => "Luminous Moss",
						Language.JPN => "ひかりごけ",
						Language.GER => "Leuchtmoos",
						Language.FRE => "Lichen Lumineux",
						Language.ITA => "Muschioluce",
						Language.SPN => "Musgo Brillante",
						Language.KOR => "빛이끼",
						Language.CHN_SIM => "光苔",
						Language.CHN_TRA => "光苔",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUNALIUM_Z:
					return lang switch {
						Language.ENG => "Lunalium Z",
						Language.JPN => "ルナアーラＺ",
						Language.GER => "Lunalium Z",
						Language.FRE => "Lunazélite",
						Language.ITA => "Lunalium Z",
						Language.SPN => "Lunalastal Z",
						Language.KOR => "루나아라Z",
						Language.CHN_SIM => "露奈雅拉Ｚ",
						Language.CHN_TRA => "露奈雅拉Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUSTROUS_GLOBE:
					return lang switch {
						Language.ENG => "Lustrous Globe",
						Language.JPN => "だいしらたま",
						Language.GER => "Weißkristall",
						Language.FRE => "Globe Perlé",
						Language.ITA => "Splendisferoide",
						Language.SPN => "Gran Lustresfera",
						Language.KOR => "큰백옥",
						Language.CHN_SIM => "大白宝玉",
						Language.CHN_TRA => "大白寶玉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUSTROUS_ORB:
					return lang switch {
						Language.ENG => "Lustrous Orb",
						Language.JPN => "しらたま",
						Language.GER => "Weiß-Orb",
						Language.FRE => "Orbe Perlé",
						Language.ITA => "Splendisfera",
						Language.SPN => "Lustresfera",
						Language.KOR => "백옥",
						Language.CHN_SIM => "白玉宝珠",
						Language.CHN_TRA => "白玉寶珠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LYCANIUM_Z:
					return lang switch {
						Language.ENG => "Lycanium Z",
						Language.JPN => "ルガルガンＺ",
						Language.GER => "Wolwerockium Z",
						Language.FRE => "Lougarozélite",
						Language.ITA => "Lycanrochium Z",
						Language.SPN => "Lycanrostal Z",
						Language.KOR => "루가루암Z",
						Language.CHN_SIM => "鬃岩狼人Ｚ",
						Language.CHN_TRA => "鬃岩狼人Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MACHO_BRACE:
					return lang switch {
						Language.ENG => "Macho Brace",
						Language.JPN => "きょうせいギプス",
						Language.GER => "Machoschiene",
						Language.FRE => "Bracelet Macho",
						Language.ITA => "Crescicappa",
						Language.SPN => "Brazal Firme",
						Language.KOR => "교정깁스",
						Language.CHN_SIM => "强制锻炼器",
						Language.CHN_TRA => "強制鍛鍊器",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MAGNET:
					return lang switch {
						Language.ENG => "Magnet",
						Language.JPN => "じしゃく",
						Language.GER => "Magnet",
						Language.FRE => "Aimant",
						Language.ITA => "Calamita",
						Language.SPN => "Imán",
						Language.KOR => "자석",
						Language.CHN_SIM => "磁铁",
						Language.CHN_TRA => "磁鐵",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MANECTITE:
					return lang switch {
						Language.ENG => "Manectite",
						Language.JPN => "ライボルトナイト",
						Language.GER => "Voltensonit",
						Language.FRE => "Élecsprintite",
						Language.ITA => "Manectricite",
						Language.SPN => "Manectricita",
						Language.KOR => "썬더볼트나이트",
						Language.CHN_SIM => "雷电兽进化石",
						Language.CHN_TRA => "雷電獸進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MARSHADIUM_Z:
					return lang switch {
						Language.ENG => "Marshadium Z",
						Language.JPN => "マーシャドーＺ",
						Language.GER => "Marshadownium Z",
						Language.FRE => "Marshadozélite",
						Language.ITA => "Marshadium Z",
						Language.SPN => "Marshastal Z",
						Language.KOR => "마샤도Z",
						Language.CHN_SIM => "玛夏多Ｚ",
						Language.CHN_TRA => "瑪夏多Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MAWILITE:
					return lang switch {
						Language.ENG => "Mawilite",
						Language.JPN => "クチートナイト",
						Language.GER => "Flunkifernit",
						Language.FRE => "Mysdibulite",
						Language.ITA => "Mawilite",
						Language.SPN => "Mawilita",
						Language.KOR => "입치트나이트",
						Language.CHN_SIM => "大嘴娃进化石",
						Language.CHN_TRA => "大嘴娃進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MEADOW_PLATE:
					return lang switch {
						Language.ENG => "Meadow Plate",
						Language.JPN => "みどりのプレート",
						Language.GER => "Wiesentafel",
						Language.FRE => "Plaque Herbe",
						Language.ITA => "Lastraprato",
						Language.SPN => "Tabla Pradal",
						Language.KOR => "초록플레이트",
						Language.CHN_SIM => "碧绿石板",
						Language.CHN_TRA => "碧綠石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MEDICHAMITE:
					return lang switch {
						Language.ENG => "Medichamite",
						Language.JPN => "チャーレムナイト",
						Language.GER => "Meditalisnit",
						Language.FRE => "Charminite",
						Language.ITA => "Medichamite",
						Language.SPN => "Medichamita",
						Language.KOR => "요가램나이트",
						Language.CHN_SIM => "恰雷姆进化石",
						Language.CHN_TRA => "恰雷姆進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MENTAL_HERB:
					return lang switch {
						Language.ENG => "Mental Herb",
						Language.JPN => "メンタルハーブ",
						Language.GER => "Mentalkraut",
						Language.FRE => "Herbe Mental",
						Language.ITA => "Mentalerba",
						Language.SPN => "Hierba Mental",
						Language.KOR => "멘탈허브",
						Language.CHN_SIM => "心灵香草",
						Language.CHN_TRA => "心靈香草",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.METAGROSSITE:
					return lang switch {
						Language.ENG => "Metagrossite",
						Language.JPN => "メタグロスナイト",
						Language.GER => "Metagrossnit",
						Language.FRE => "Métalossite",
						Language.ITA => "Metagrossite",
						Language.SPN => "Metagrossita",
						Language.KOR => "메타그로스나이트",
						Language.CHN_SIM => "巨金怪进化石",
						Language.CHN_TRA => "巨金怪進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.METAL_COAT:
					return lang switch {
						Language.ENG => "Metal Coat",
						Language.JPN => "メタルコート",
						Language.GER => "Metallmantel",
						Language.FRE => "Peau Métal",
						Language.ITA => "Metalcopertura",
						Language.SPN => "Revest. Metálico",
						Language.KOR => "금속코트",
						Language.CHN_SIM => "金属膜",
						Language.CHN_TRA => "金屬膜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.METAL_POWDER:
					return lang switch {
						Language.ENG => "Metal Powder",
						Language.JPN => "メタルパウダー",
						Language.GER => "Metallstaub",
						Language.FRE => "Poudre Métal",
						Language.ITA => "Metalpolvere",
						Language.SPN => "Polvo Metálico",
						Language.KOR => "금속파우더",
						Language.CHN_SIM => "金属粉",
						Language.CHN_TRA => "金屬粉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.METRONOME:
					return lang switch {
						Language.ENG => "Metronome",
						Language.JPN => "メトロノーム",
						Language.GER => "Metronom",
						Language.FRE => "Métronome",
						Language.ITA => "Plessimetro",
						Language.SPN => "Metrónomo",
						Language.KOR => "메트로놈",
						Language.CHN_SIM => "节拍器",
						Language.CHN_TRA => "節拍器",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MEWNIUM_Z:
					return lang switch {
						Language.ENG => "Mewnium Z",
						Language.JPN => "ミュウＺ",
						Language.GER => "Mewnium Z",
						Language.FRE => "Mewzélite",
						Language.ITA => "Mewnium Z",
						Language.SPN => "Mewstal Z",
						Language.KOR => "뮤Z",
						Language.CHN_SIM => "梦幻Ｚ",
						Language.CHN_TRA => "夢幻Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MEWTWONITE_X:
					return lang switch {
						Language.ENG => "Mewtwonite X",
						Language.JPN => "ミュウツナイトＸ",
						Language.GER => "Mewtunit X",
						Language.FRE => "Mewtwoïte X",
						Language.ITA => "Mewtwoite X",
						Language.SPN => "Mewtwoita X",
						Language.KOR => "뮤츠나이트X",
						Language.CHN_SIM => "超梦进化石Ｘ",
						Language.CHN_TRA => "超夢進化石Ｘ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MEWTWONITE_Y:
					return lang switch {
						Language.ENG => "Mewtwonite Y",
						Language.JPN => "ミュウツナイトＹ",
						Language.GER => "Mewtunit Y",
						Language.FRE => "Mewtwoïte Y",
						Language.ITA => "Mewtwoite Y",
						Language.SPN => "Mewtwoita Y",
						Language.KOR => "뮤츠나이트Y",
						Language.CHN_SIM => "超梦进化石Ｙ",
						Language.CHN_TRA => "超夢進化石Ｙ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MIMIKIUM_Z:
					return lang switch {
						Language.ENG => "Mimikium Z",
						Language.JPN => "ミミッキュＺ",
						Language.GER => "Mimigmium Z",
						Language.FRE => "Mimiquizélite",
						Language.ITA => "Mimikyum Z",
						Language.SPN => "Mimikyustal Z",
						Language.KOR => "따라큐Z",
						Language.CHN_SIM => "谜拟ＱＺ",
						Language.CHN_TRA => "謎擬ＱＺ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MIND_PLATE:
					return lang switch {
						Language.ENG => "Mind Plate",
						Language.JPN => "ふしぎのプレート",
						Language.GER => "Hirntafel",
						Language.FRE => "Plaque Esprit",
						Language.ITA => "Lastramente",
						Language.SPN => "Tabla Mental",
						Language.KOR => "이상한플레이트",
						Language.CHN_SIM => "神奇石板",
						Language.CHN_TRA => "神奇石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MIRACLE_SEED:
					return lang switch {
						Language.ENG => "Miracle Seed",
						Language.JPN => "きせきのタネ",
						Language.GER => "Wundersaat",
						Language.FRE => "Graine Miracle",
						Language.ITA => "Miracolseme",
						Language.SPN => "Semilla Milagro",
						Language.KOR => "기적의씨",
						Language.CHN_SIM => "奇迹种子",
						Language.CHN_TRA => "奇跡種子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MIRROR_HERB:
					return lang switch {
						Language.ENG => "Mirror Herb",
						Language.JPN => "ものまねハーブ",
						Language.GER => "Kopierkraut",
						Language.FRE => "Feuille Copieuse",
						Language.ITA => "Foglia carbone",
						Language.SPN => "Hierba Copia",
						Language.KOR => "흉내허브",
						Language.CHN_SIM => "模仿香草",
						Language.CHN_TRA => "模仿香草",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MISTY_SEED:
					return lang switch {
						Language.ENG => "Misty Seed",
						Language.JPN => "ミストシード",
						Language.GER => "Nebel-Samen",
						Language.FRE => "Graine Brume",
						Language.ITA => "Nebbiaseme",
						Language.SPN => "Semilla Bruma",
						Language.KOR => "미스트시드",
						Language.CHN_SIM => "薄雾种子",
						Language.CHN_TRA => "薄霧種子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MUSCLE_BAND:
					return lang switch {
						Language.ENG => "Muscle Band",
						Language.JPN => "ちからのハチマキ",
						Language.GER => "Muskelband",
						Language.FRE => "Bandeau Muscle",
						Language.ITA => "Muscolbanda",
						Language.SPN => "Cinta Fuerte",
						Language.KOR => "힘의머리띠",
						Language.CHN_SIM => "力量头带",
						Language.CHN_TRA => "力量頭帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MYSTIC_WATER:
					return lang switch {
						Language.ENG => "Mystic Water",
						Language.JPN => "しんぴのしずく",
						Language.GER => "Zauberwasser",
						Language.FRE => "Eau Mystique",
						Language.ITA => "Acqua magica",
						Language.SPN => "Agua Mística",
						Language.KOR => "신비의물방울",
						Language.CHN_SIM => "神秘水滴",
						Language.CHN_TRA => "神秘水滴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.NEVER_MELT_ICE:
					return lang switch {
						Language.ENG => "Never-Melt Ice",
						Language.JPN => "とけないこおり",
						Language.GER => "Ewiges Eis",
						Language.FRE => "Glace Éternelle",
						Language.ITA => "Gelomai",
						Language.SPN => "Antiderretir",
						Language.KOR => "녹지않는얼음",
						Language.CHN_SIM => "不融冰",
						Language.CHN_TRA => "不融冰",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.NORMAL_GEM:
					return lang switch {
						Language.ENG => "Normal Gem",
						Language.JPN => "ノーマルジュエル",
						Language.GER => "Normaljuwel",
						Language.FRE => "Joyau Normal",
						Language.ITA => "Bijounormale",
						Language.SPN => "Gema Normal",
						Language.KOR => "노말주얼",
						Language.CHN_SIM => "一般宝石",
						Language.CHN_TRA => "一般寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.NORMALIUM_Z:
					return lang switch {
						Language.ENG => "Normalium Z",
						Language.JPN => "ノーマルＺ",
						Language.GER => "Normium Z",
						Language.FRE => "Normazélite",
						Language.ITA => "Normium Z",
						Language.SPN => "Normastal Z",
						Language.KOR => "노말Z",
						Language.CHN_SIM => "一般Ｚ",
						Language.CHN_TRA => "一般Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ODD_INCENSE:
					return lang switch {
						Language.ENG => "Odd Incense",
						Language.JPN => "あやしいおこう",
						Language.GER => "Schrägrauch",
						Language.FRE => "Encens Bizarre",
						Language.ITA => "Bizzoaroma",
						Language.SPN => "Incienso Raro",
						Language.KOR => "괴상한향로",
						Language.CHN_SIM => "奇异薰香",
						Language.CHN_TRA => "奇異薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PASS_ORB:
					return lang switch {
						Language.ENG => "Pass Orb",
						Language.JPN => "デルダマ",
						Language.GER => "Transfer-Orb",
						Language.FRE => "Offrisphère",
						Language.ITA => "Passabilia",
						Language.SPN => "Regalosfera",
						Language.KOR => "딜구슬",
						Language.CHN_SIM => "释出之玉",
						Language.CHN_TRA => "釋出之玉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PIDGEOTITE:
					return lang switch {
						Language.ENG => "Pidgeotite",
						Language.JPN => "ピジョットナイト",
						Language.GER => "Taubossnit",
						Language.FRE => "Roucarnagite",
						Language.ITA => "Pidgeotite",
						Language.SPN => "Pidgeotita",
						Language.KOR => "피죤투나이트",
						Language.CHN_SIM => "大比鸟进化石",
						Language.CHN_TRA => "大比鳥進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PIKANIUM_Z:
					return lang switch {
						Language.ENG => "Pikanium Z",
						Language.JPN => "ピカチュウＺ",
						Language.GER => "Pikachium Z",
						Language.FRE => "Pikazélite",
						Language.ITA => "Pikacium Z",
						Language.SPN => "Pikastal Z",
						Language.KOR => "피카츄Z",
						Language.CHN_SIM => "皮卡丘Ｚ",
						Language.CHN_TRA => "皮卡丘Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PIKASHUNIUM_Z:
					return lang switch {
						Language.ENG => "Pikashunium Z",
						Language.JPN => "サトピカＺ",
						Language.GER => "Ash-Pikachium Z",
						Language.FRE => "Pikachazélite",
						Language.ITA => "Ashpikacium Z",
						Language.SPN => "Ash-Pikastal Z",
						Language.KOR => "지우피카Z",
						Language.CHN_SIM => "智皮卡Ｚ",
						Language.CHN_TRA => "智皮卡Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PINK_NECTAR:
					return lang switch {
						Language.ENG => "Pink Nectar",
						Language.JPN => "うすもものミツ",
						Language.GER => "Rosa Nektar",
						Language.FRE => "Nectar Rose",
						Language.ITA => "Nettare rosa",
						Language.SPN => "Néctar Rosa",
						Language.KOR => "연분홍꿀",
						Language.CHN_SIM => "桃粉色花蜜",
						Language.CHN_TRA => "桃粉色花蜜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PINSIRITE:
					return lang switch {
						Language.ENG => "Pinsirite",
						Language.JPN => "カイロスナイト",
						Language.GER => "Pinsirnit",
						Language.FRE => "Scarabruite",
						Language.ITA => "Pinsirite",
						Language.SPN => "Pinsirita",
						Language.KOR => "쁘사이저나이트",
						Language.CHN_SIM => "凯罗斯进化石",
						Language.CHN_TRA => "凱羅斯進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PIXIE_PLATE:
					return lang switch {
						Language.ENG => "Pixie Plate",
						Language.JPN => "せいれいプレート",
						Language.GER => "Feentafel",
						Language.FRE => "Plaque Pixie",
						Language.ITA => "Lastraspiritello",
						Language.SPN => "Tabla Duende",
						Language.KOR => "정령플레이트",
						Language.CHN_SIM => "妖精石板",
						Language.CHN_TRA => "妖精石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PLASMA_CARD:
					return lang switch {
						Language.ENG => "Plasma Card",
						Language.JPN => "プラズマカード",
						Language.GER => "Plasmakarte",
						Language.FRE => "Carte Plasma",
						Language.ITA => "Carta Plasma",
						Language.SPN => "Tarjeta Plasma",
						Language.KOR => "플라스마카드",
						Language.CHN_SIM => "等离子卡",
						Language.CHN_TRA => "等離子卡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POISON_BARB:
					return lang switch {
						Language.ENG => "Poison Barb",
						Language.JPN => "どくバリ",
						Language.GER => "Giftstich",
						Language.FRE => "Pic Venin",
						Language.ITA => "Velenaculeo",
						Language.SPN => "Flecha Venenosa",
						Language.KOR => "독바늘",
						Language.CHN_SIM => "毒针",
						Language.CHN_TRA => "毒針",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POISON_GEM:
					return lang switch {
						Language.ENG => "Poison Gem",
						Language.JPN => "どくのジュエル",
						Language.GER => "Giftjuwel",
						Language.FRE => "Joyau Poison",
						Language.ITA => "Bijouveleno",
						Language.SPN => "Gema Veneno",
						Language.KOR => "독주얼",
						Language.CHN_SIM => "毒之宝石",
						Language.CHN_TRA => "毒之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POISON_MEMORY:
					return lang switch {
						Language.ENG => "Poison Memory",
						Language.JPN => "ポイズンメモリ",
						Language.GER => "Gift-Disc",
						Language.FRE => "ROM Poison",
						Language.ITA => "ROM Veleno",
						Language.SPN => "Disco Veneno",
						Language.KOR => "포이즌메모리",
						Language.CHN_SIM => "毒存储碟",
						Language.CHN_TRA => "毒記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POISONIUM_Z:
					return lang switch {
						Language.ENG => "Poisonium Z",
						Language.JPN => "ドクＺ",
						Language.GER => "Toxium Z",
						Language.FRE => "Toxizélite",
						Language.ITA => "Venenium Z",
						Language.SPN => "Toxistal Z",
						Language.KOR => "독Z",
						Language.CHN_SIM => "毒Ｚ",
						Language.CHN_TRA => "毒Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_ANKLET:
					return lang switch {
						Language.ENG => "Power Anklet",
						Language.JPN => "パワーアンクル",
						Language.GER => "Machtkette",
						Language.FRE => "Chaîne Pouvoir",
						Language.ITA => "Vigorgliera",
						Language.SPN => "Franja Recia",
						Language.KOR => "파워앵클릿",
						Language.CHN_SIM => "力量护踝",
						Language.CHN_TRA => "力量護踝",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_BAND:
					return lang switch {
						Language.ENG => "Power Band",
						Language.JPN => "パワーバンド",
						Language.GER => "Machtband",
						Language.FRE => "Bandeau Pouvoir",
						Language.ITA => "Vigorbanda",
						Language.SPN => "Banda Recia",
						Language.KOR => "파워밴드",
						Language.CHN_SIM => "力量束带",
						Language.CHN_TRA => "力量束帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_BELT:
					return lang switch {
						Language.ENG => "Power Belt",
						Language.JPN => "パワーベルト",
						Language.GER => "Machtgurt",
						Language.FRE => "Ceinture Pouvoir",
						Language.ITA => "Vigorfascia",
						Language.SPN => "Cinto Recio",
						Language.KOR => "파워벨트",
						Language.CHN_SIM => "力量腰带",
						Language.CHN_TRA => "力量腰帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_BRACER:
					return lang switch {
						Language.ENG => "Power Bracer",
						Language.JPN => "パワーリスト",
						Language.GER => "Machtreif",
						Language.FRE => "Poignet Pouvoir",
						Language.ITA => "Vigorcerchio",
						Language.SPN => "Brazal Recio",
						Language.KOR => "파워리스트",
						Language.CHN_SIM => "力量护腕",
						Language.CHN_TRA => "力量護腕",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_HERB:
					return lang switch {
						Language.ENG => "Power Herb",
						Language.JPN => "パワフルハーブ",
						Language.GER => "Energiekraut",
						Language.FRE => "Herbe Pouvoir",
						Language.ITA => "Vigorerba",
						Language.SPN => "Hierba Única",
						Language.KOR => "파워풀허브",
						Language.CHN_SIM => "强力香草",
						Language.CHN_TRA => "強力香草",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_LENS:
					return lang switch {
						Language.ENG => "Power Lens",
						Language.JPN => "パワーレンズ",
						Language.GER => "Machtlinse",
						Language.FRE => "Lentille Pouvoir",
						Language.ITA => "Vigorlente",
						Language.SPN => "Lente Recia",
						Language.KOR => "파워렌즈",
						Language.CHN_SIM => "力量镜",
						Language.CHN_TRA => "力量鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_PLANT_PASS:
					return lang switch {
						Language.ENG => "Power Plant Pass",
						Language.JPN => "はつでんしょパス",
						Language.GER => "Kraftwerks-Pass",
						Language.FRE => "Passe Centrale",
						Language.ITA => "Pass centrale",
						Language.SPN => "Pase de la Central",
						Language.KOR => "발전소패스",
						Language.CHN_SIM => "发电厂通行证",
						Language.CHN_TRA => "發電廠通行證",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POWER_WEIGHT:
					return lang switch {
						Language.ENG => "Power Weight",
						Language.JPN => "パワーウエイト",
						Language.GER => "Machtgewicht",
						Language.FRE => "Poids Pouvoir",
						Language.ITA => "Vigorpeso",
						Language.SPN => "Pesa Recia",
						Language.KOR => "파워웨이트",
						Language.CHN_SIM => "力量负重",
						Language.CHN_TRA => "力量負重",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PRIMARIUM_Z:
					return lang switch {
						Language.ENG => "Primarium Z",
						Language.JPN => "アシレーヌＺ",
						Language.GER => "Primarenium Z",
						Language.FRE => "Oratozélite",
						Language.ITA => "Primarinium Z",
						Language.SPN => "Primastal Z",
						Language.KOR => "누리레느Z",
						Language.CHN_SIM => "西狮海壬Ｚ",
						Language.CHN_TRA => "西獅海壬Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PRISON_BOTTLE:
					return lang switch {
						Language.ENG => "Prison Bottle",
						Language.JPN => "いましめのツボ",
						Language.GER => "Banngefäß",
						Language.FRE => "Vase Scellé",
						Language.ITA => "Vaso del vincolo",
						Language.SPN => "Vasija Castigo",
						Language.KOR => "굴레의항아리",
						Language.CHN_SIM => "惩戒之壶",
						Language.CHN_TRA => "懲戒之壺",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PROFS_LETTER:
					return lang switch {
						Language.ENG => "Prof's Letter",
						Language.JPN => "はかせのてがみ",
						Language.GER => "Brief vom Prof",
						Language.FRE => "Lettre du Prof",
						Language.ITA => "Lettera del Prof",
						Language.SPN => "Carta Profesor",
						Language.KOR => "박사의편지",
						Language.CHN_SIM => "博士的信",
						Language.CHN_TRA => "博士的信",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PROTECTIVE_PADS:
					return lang switch {
						Language.ENG => "Protective Pads",
						Language.JPN => "ぼうごパット",
						Language.GER => "Schutzpolster",
						Language.FRE => "Pare-Effet",
						Language.ITA => "Smorzaurti",
						Language.SPN => "Paracontacto",
						Language.KOR => "방호패드",
						Language.CHN_SIM => "部位护具",
						Language.CHN_TRA => "部位護具",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PSYCHIC_GEM:
					return lang switch {
						Language.ENG => "Psychic Gem",
						Language.JPN => "エスパージュエル",
						Language.GER => "Psychojuwel",
						Language.FRE => "Joyau Psy",
						Language.ITA => "Bijoupsico",
						Language.SPN => "Gema Psíquico",
						Language.KOR => "에스퍼주얼",
						Language.CHN_SIM => "超能力宝石",
						Language.CHN_TRA => "超能力寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PSYCHIC_MEMORY:
					return lang switch {
						Language.ENG => "Psychic Memory",
						Language.JPN => "サイキックメモリ",
						Language.GER => "Psycho-Disc",
						Language.FRE => "ROM Psy",
						Language.ITA => "ROM Psico",
						Language.SPN => "Disco Psíquico",
						Language.KOR => "사이킥메모리",
						Language.CHN_SIM => "精神存储碟",
						Language.CHN_TRA => "精神記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PSYCHIC_SEED:
					return lang switch {
						Language.ENG => "Psychic Seed",
						Language.JPN => "サイコシード",
						Language.GER => "Psycho-Samen",
						Language.FRE => "Graine Psychique",
						Language.ITA => "Psicoseme",
						Language.SPN => "Semilla Psique",
						Language.KOR => "사이코시드",
						Language.CHN_SIM => "精神种子",
						Language.CHN_TRA => "精神種子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PSYCHIUM_Z:
					return lang switch {
						Language.ENG => "Psychium Z",
						Language.JPN => "エスパーＺ",
						Language.GER => "Psium Z",
						Language.FRE => "Psychézélite",
						Language.ITA => "Psichium Z",
						Language.SPN => "Psicostal Z",
						Language.KOR => "에스퍼Z",
						Language.CHN_SIM => "超能力Ｚ",
						Language.CHN_TRA => "超能力Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PURE_INCENSE:
					return lang switch {
						Language.ENG => "Pure Incense",
						Language.JPN => "きよめのおこう",
						Language.GER => "Scheuchrauch",
						Language.FRE => "Encens Pur",
						Language.ITA => "Puroaroma",
						Language.SPN => "Incienso Puro",
						Language.KOR => "순결의향로",
						Language.CHN_SIM => "洁净薰香",
						Language.CHN_TRA => "潔淨薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PURPLE_NECTAR:
					return lang switch {
						Language.ENG => "Purple Nectar",
						Language.JPN => "むらさきのミツ",
						Language.GER => "Purpurner Nektar",
						Language.FRE => "Nectar Mauve",
						Language.ITA => "Nettare viola",
						Language.SPN => "Néctar Violeta",
						Language.KOR => "보라꿀",
						Language.CHN_SIM => "兰紫色花蜜",
						Language.CHN_TRA => "蘭紫色花蜜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.QUICK_CLAW:
					return lang switch {
						Language.ENG => "Quick Claw",
						Language.JPN => "せんせいのツメ",
						Language.GER => "Flinkklaue",
						Language.FRE => "Vive Griffe",
						Language.ITA => "Rapidartiglio",
						Language.SPN => "Garra Rápida",
						Language.KOR => "선제공격손톱",
						Language.CHN_SIM => "先制之爪",
						Language.CHN_TRA => "先制之爪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.QUICK_POWDER:
					return lang switch {
						Language.ENG => "Quick Powder",
						Language.JPN => "スピードパウダー",
						Language.GER => "Flottstaub",
						Language.FRE => "Poudre Vite",
						Language.ITA => "Velopolvere",
						Language.SPN => "Polvo Veloz",
						Language.KOR => "스피드파우더",
						Language.CHN_SIM => "速度粉",
						Language.CHN_TRA => "速度粉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RAZOR_CLAW:
					return lang switch {
						Language.ENG => "Razor Claw",
						Language.JPN => "するどいツメ",
						Language.GER => "Scharfklaue",
						Language.FRE => "Griffe Rasoir",
						Language.ITA => "Affilartiglio",
						Language.SPN => "Garra Afilada",
						Language.KOR => "예리한손톱",
						Language.CHN_SIM => "锐利之爪",
						Language.CHN_TRA => "銳利之爪",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RAZOR_FANG:
					return lang switch {
						Language.ENG => "Razor Fang",
						Language.JPN => "するどいキバ",
						Language.GER => "Scharfzahn",
						Language.FRE => "Croc Rasoir",
						Language.ITA => "Affilodente",
						Language.SPN => "Colmillo Agudo",
						Language.KOR => "예리한이빨",
						Language.CHN_SIM => "锐利之牙",
						Language.CHN_TRA => "銳利之牙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RED_CARD:
					return lang switch {
						Language.ENG => "Red Card",
						Language.JPN => "レッドカード",
						Language.GER => "Rote Karte",
						Language.FRE => "Carton Rouge",
						Language.ITA => "Cartelrosso",
						Language.SPN => "Tarjeta Roja",
						Language.KOR => "레드카드",
						Language.CHN_SIM => "红牌",
						Language.CHN_TRA => "紅牌",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RED_NECTAR:
					return lang switch {
						Language.ENG => "Red Nectar",
						Language.JPN => "くれないのミツ",
						Language.GER => "Roter Nektar",
						Language.FRE => "Nectar Rouge",
						Language.ITA => "Nettare rosso",
						Language.SPN => "Néctar Rojo",
						Language.KOR => "다홍꿀",
						Language.CHN_SIM => "朱红色花蜜",
						Language.CHN_TRA => "朱紅色花蜜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RIBBON_SWEET:
					return lang switch {
						Language.ENG => "Ribbon Sweet",
						Language.JPN => "リボンアメざいく",
						Language.GER => "Zucker-Schleife",
						Language.FRE => "Ruban en Sucre",
						Language.ITA => "Bonbonfiocco",
						Language.SPN => "Confite Lazo",
						Language.KOR => "리본사탕공예",
						Language.CHN_SIM => "蝴蝶结糖饰",
						Language.CHN_TRA => "蝴蝶結糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RING_TARGET:
					return lang switch {
						Language.ENG => "Ring Target",
						Language.JPN => "ねらいのまと",
						Language.GER => "Zielscheibe",
						Language.FRE => "Point de Mire",
						Language.ITA => "Facilsaglio",
						Language.SPN => "Blanco",
						Language.KOR => "겨냥표적",
						Language.CHN_SIM => "标靶",
						Language.CHN_TRA => "標靶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROCK_GEM:
					return lang switch {
						Language.ENG => "Rock Gem",
						Language.JPN => "いわのジュエル",
						Language.GER => "Gesteinsjuwel",
						Language.FRE => "Joyau Roche",
						Language.ITA => "Bijouroccia",
						Language.SPN => "Gema Roca",
						Language.KOR => "바위주얼",
						Language.CHN_SIM => "岩石宝石",
						Language.CHN_TRA => "岩石寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROCK_INCENSE:
					return lang switch {
						Language.ENG => "Rock Incense",
						Language.JPN => "がんせきおこう",
						Language.GER => "Steinrauch",
						Language.FRE => "Encens Roc",
						Language.ITA => "Roccioaroma",
						Language.SPN => "Incienso Roca",
						Language.KOR => "암석향로",
						Language.CHN_SIM => "岩石薰香",
						Language.CHN_TRA => "岩石薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROCK_MEMORY:
					return lang switch {
						Language.ENG => "Rock Memory",
						Language.JPN => "ロックメモリ",
						Language.GER => "Gesteins-Disc",
						Language.FRE => "ROM Roche",
						Language.ITA => "ROM Roccia",
						Language.SPN => "Disco Roca",
						Language.KOR => "록메모리",
						Language.CHN_SIM => "岩石存储碟",
						Language.CHN_TRA => "岩石記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROCKIUM_Z:
					return lang switch {
						Language.ENG => "Rockium Z",
						Language.JPN => "イワＺ",
						Language.GER => "Petrium Z",
						Language.FRE => "Rocazélite",
						Language.ITA => "Petrium Z",
						Language.SPN => "Litostal Z",
						Language.KOR => "바위Z",
						Language.CHN_SIM => "岩石Ｚ",
						Language.CHN_TRA => "岩石Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROCKY_HELMET:
					return lang switch {
						Language.ENG => "Rocky Helmet",
						Language.JPN => "ゴツゴツメット",
						Language.GER => "Beulenhelm",
						Language.FRE => "Casque Brut",
						Language.ITA => "Bitorzolelmo",
						Language.SPN => "Casco Dentado",
						Language.KOR => "울퉁불퉁멧",
						Language.CHN_SIM => "凸凸头盔",
						Language.CHN_TRA => "凸凸頭盔",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROOM_SERVICE:
					return lang switch {
						Language.ENG => "Room Service",
						Language.JPN => "ルームサービス",
						Language.GER => "Bizarroservice",
						Language.FRE => "Chariot Distordu",
						Language.ITA => "Distorservizio",
						Language.SPN => "Servicio Raro",
						Language.KOR => "룸서비스",
						Language.CHN_SIM => "客房服务",
						Language.CHN_TRA => "客房服務",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROSE_INCENSE:
					return lang switch {
						Language.ENG => "Rose Incense",
						Language.JPN => "おはなのおこう",
						Language.GER => "Rosenrauch",
						Language.FRE => "Encens Fleur",
						Language.ITA => "Rosaroma",
						Language.SPN => "Incienso Floral",
						Language.KOR => "꽃향로",
						Language.CHN_SIM => "花朵薰香",
						Language.CHN_TRA => "花朵薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SABLENITE:
					return lang switch {
						Language.ENG => "Sablenite",
						Language.JPN => "ヤミラミナイト",
						Language.GER => "Zobirisnit",
						Language.FRE => "Ténéfixite",
						Language.ITA => "Sableyite",
						Language.SPN => "Sableynita",
						Language.KOR => "깜까미나이트",
						Language.CHN_SIM => "勾魂眼进化石",
						Language.CHN_TRA => "勾魂眼進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SAFETY_GOGGLES:
					return lang switch {
						Language.ENG => "Safety Goggles",
						Language.JPN => "ぼうじんゴーグル",
						Language.GER => "Schutzbrille",
						Language.FRE => "Lunettes Filtre",
						Language.ITA => "Visierantisabbia",
						Language.SPN => "Gafa Protectora",
						Language.KOR => "방진고글",
						Language.CHN_SIM => "防尘护目镜",
						Language.CHN_TRA => "防塵護目鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SALAMENCITE:
					return lang switch {
						Language.ENG => "Salamencite",
						Language.JPN => "ボーマンダナイト",
						Language.GER => "Brutalandanit",
						Language.FRE => "Drattakite",
						Language.ITA => "Salamencite",
						Language.SPN => "Salamencita",
						Language.KOR => "보만다나이트",
						Language.CHN_SIM => "暴飞龙进化石",
						Language.CHN_TRA => "暴飛龍進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SCEPTILITE:
					return lang switch {
						Language.ENG => "Sceptilite",
						Language.JPN => "ジュカインナイト",
						Language.GER => "Gewaldronit",
						Language.FRE => "Jungkite",
						Language.ITA => "Sceptilite",
						Language.SPN => "Sceptilita",
						Language.KOR => "나무킹나이트",
						Language.CHN_SIM => "蜥蜴王进化石",
						Language.CHN_TRA => "蜥蜴王進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SCIZORITE:
					return lang switch {
						Language.ENG => "Scizorite",
						Language.JPN => "ハッサムナイト",
						Language.GER => "Scheroxnit",
						Language.FRE => "Cizayoxite",
						Language.ITA => "Scizorite",
						Language.SPN => "Scizorita",
						Language.KOR => "핫삼나이트",
						Language.CHN_SIM => "巨钳螳螂进化石",
						Language.CHN_TRA => "巨鉗螳螂進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SCOPE_LENS:
					return lang switch {
						Language.ENG => "Scope Lens",
						Language.JPN => "ピントレンズ",
						Language.GER => "Scope-Linse",
						Language.FRE => "Lentilscope",
						Language.ITA => "Mirino",
						Language.SPN => "Periscopio",
						Language.KOR => "초점렌즈",
						Language.CHN_SIM => "焦点镜",
						Language.CHN_TRA => "焦點鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SEA_INCENSE:
					return lang switch {
						Language.ENG => "Sea Incense",
						Language.JPN => "うしおのおこう",
						Language.GER => "Seerauch",
						Language.FRE => "Encens Mer",
						Language.ITA => "Marearoma",
						Language.SPN => "Incienso Marino",
						Language.KOR => "바닷물향로",
						Language.CHN_SIM => "海潮薰香",
						Language.CHN_TRA => "海潮薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SHARP_BEAK:
					return lang switch {
						Language.ENG => "Sharp Beak",
						Language.JPN => "するどいくちばし",
						Language.GER => "Spitzer Schnabel",
						Language.FRE => "Bec Pointu",
						Language.ITA => "Beccaffilato",
						Language.SPN => "Pico Afilado",
						Language.KOR => "예리한부리",
						Language.CHN_SIM => "锐利鸟嘴",
						Language.CHN_TRA => "銳利鳥嘴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SHARPEDONITE:
					return lang switch {
						Language.ENG => "Sharpedonite",
						Language.JPN => "サメハダナイト",
						Language.GER => "Tohaidonit",
						Language.FRE => "Sharpedite",
						Language.ITA => "Sharpedite",
						Language.SPN => "Sharpedonita",
						Language.KOR => "샤크니아나이트",
						Language.CHN_SIM => "巨牙鲨进化石",
						Language.CHN_TRA => "巨牙鯊進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SHED_SHELL:
					return lang switch {
						Language.ENG => "Shed Shell",
						Language.JPN => "きれいなぬけがら",
						Language.GER => "Wechselhülle",
						Language.FRE => "Carapace Mue",
						Language.ITA => "Disfoguscio",
						Language.SPN => "Muda Concha",
						Language.KOR => "아름다운허물",
						Language.CHN_SIM => "美丽空壳",
						Language.CHN_TRA => "美麗空殼",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SHELL_BELL:
					return lang switch {
						Language.ENG => "Shell Bell",
						Language.JPN => "かいがらのすず",
						Language.GER => "Muschelglocke",
						Language.FRE => "Grelot Coque",
						Language.ITA => "Conchinella",
						Language.SPN => "Cascabel Concha",
						Language.KOR => "조개껍질방울",
						Language.CHN_SIM => "贝壳之铃",
						Language.CHN_TRA => "貝殼之鈴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SHOCK_DRIVE:
					return lang switch {
						Language.ENG => "Shock Drive",
						Language.JPN => "イナズマカセット",
						Language.GER => "Blitzmodul",
						Language.FRE => "Module Choc",
						Language.ITA => "Voltmodulo",
						Language.SPN => "FulgoROM",
						Language.KOR => "번개카세트",
						Language.CHN_SIM => "闪电卡带",
						Language.CHN_TRA => "閃電卡帶",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SILK_SCARF:
					return lang switch {
						Language.ENG => "Silk Scarf",
						Language.JPN => "シルクのスカーフ",
						Language.GER => "Seidenschal",
						Language.FRE => "Mouchoir Soie",
						Language.ITA => "Sciarpa seta",
						Language.SPN => "Pañuelo de Seda",
						Language.KOR => "실크스카프",
						Language.CHN_SIM => "丝绸围巾",
						Language.CHN_TRA => "絲綢圍巾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SILVER_POWDER:
					return lang switch {
						Language.ENG => "Silver Powder",
						Language.JPN => "ぎんのこな",
						Language.GER => "Silberstaub",
						Language.FRE => "Poudre Argentée",
						Language.ITA => "Argenpolvere",
						Language.SPN => "Polvo Plata",
						Language.KOR => "은빛가루",
						Language.CHN_SIM => "银粉",
						Language.CHN_TRA => "銀粉",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SKY_PLATE:
					return lang switch {
						Language.ENG => "Sky Plate",
						Language.JPN => "あおぞらプレート",
						Language.GER => "Wolkentafel",
						Language.FRE => "Plaque Ciel",
						Language.ITA => "Lastracielo",
						Language.SPN => "Tabla Cielo",
						Language.KOR => "푸른하늘플레이트",
						Language.CHN_SIM => "蓝天石板",
						Language.CHN_TRA => "藍天石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SLOWBRONITE:
					return lang switch {
						Language.ENG => "Slowbronite",
						Language.JPN => "ヤドランナイト",
						Language.GER => "Lahmusnit",
						Language.FRE => "Flagadossite",
						Language.ITA => "Slowbroite",
						Language.SPN => "Slowbronita",
						Language.KOR => "야도란나이트",
						Language.CHN_SIM => "呆壳兽进化石",
						Language.CHN_TRA => "呆殼獸進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SMOKE_BALL:
					return lang switch {
						Language.ENG => "Smoke Ball",
						Language.JPN => "けむりだま",
						Language.GER => "Rauchball",
						Language.FRE => "Boule Fumée",
						Language.ITA => "Palla fumo",
						Language.SPN => "Bola de Humo",
						Language.KOR => "연막탄",
						Language.CHN_SIM => "烟雾球",
						Language.CHN_TRA => "煙霧球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SMOOTH_ROCK:
					return lang switch {
						Language.ENG => "Smooth Rock",
						Language.JPN => "さらさらいわ",
						Language.GER => "Glattbrocken",
						Language.FRE => "Roche Lisse",
						Language.ITA => "Roccialiscia",
						Language.SPN => "Roca Suave",
						Language.KOR => "보송보송바위",
						Language.CHN_SIM => "沙沙岩石",
						Language.CHN_TRA => "沙沙岩石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SNORLIUM_Z:
					return lang switch {
						Language.ENG => "Snorlium Z",
						Language.JPN => "カビゴンＺ",
						Language.GER => "Relaxonium Z",
						Language.FRE => "Ronflézélite",
						Language.ITA => "Snorlactium Z",
						Language.SPN => "Snorlastal Z",
						Language.KOR => "잠만보Z",
						Language.CHN_SIM => "卡比兽Ｚ",
						Language.CHN_TRA => "卡比獸Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SNOWBALL:
					return lang switch {
						Language.ENG => "Snowball",
						Language.JPN => "ゆきだま",
						Language.GER => "Schneeball",
						Language.FRE => "Boule de Neige",
						Language.ITA => "Palla di neve",
						Language.SPN => "Bola de Nieve",
						Language.KOR => "눈덩이",
						Language.CHN_SIM => "雪球",
						Language.CHN_TRA => "雪球",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SOFT_SAND:
					return lang switch {
						Language.ENG => "Soft Sand",
						Language.JPN => "やわらかいすな",
						Language.GER => "Pudersand",
						Language.FRE => "Sable Doux",
						Language.ITA => "Sabbia soffice",
						Language.SPN => "Arena Fina",
						Language.KOR => "부드러운모래",
						Language.CHN_SIM => "柔软沙子",
						Language.CHN_TRA => "柔軟沙子",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SOLGANIUM_Z:
					return lang switch {
						Language.ENG => "Solganium Z",
						Language.JPN => "ソルガレオＺ",
						Language.GER => "Solgalium Z",
						Language.FRE => "Solgazélite",
						Language.ITA => "Solgaleium Z",
						Language.SPN => "Solgaleostal Z",
						Language.KOR => "솔가레오Z",
						Language.CHN_SIM => "索尔迦雷欧Ｚ",
						Language.CHN_TRA => "索爾迦雷歐Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SOOTHE_BELL:
					return lang switch {
						Language.ENG => "Soothe Bell",
						Language.JPN => "やすらぎのすず",
						Language.GER => "Sanftglocke",
						Language.FRE => "Grelot Zen",
						Language.ITA => "Calmanella",
						Language.SPN => "Cascabel Alivio",
						Language.KOR => "평온의방울",
						Language.CHN_SIM => "安抚之铃",
						Language.CHN_TRA => "安撫之鈴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SOUL_DEW:
					return lang switch {
						Language.ENG => "Soul Dew",
						Language.JPN => "こころのしずく",
						Language.GER => "Seelentau",
						Language.FRE => "Rosée Âme",
						Language.ITA => "Cuorugiada",
						Language.SPN => "Rocío Bondad",
						Language.KOR => "마음의물방울",
						Language.CHN_SIM => "心之水滴",
						Language.CHN_TRA => "心之水滴",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SPELL_TAG:
					return lang switch {
						Language.ENG => "Spell Tag",
						Language.JPN => "のろいのおふだ",
						Language.GER => "Bannsticker",
						Language.FRE => "Rune Sort",
						Language.ITA => "Spettrotarga",
						Language.SPN => "Hechizo",
						Language.KOR => "저주의부적",
						Language.CHN_SIM => "咒术之符",
						Language.CHN_TRA => "詛咒之符",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SPLASH_PLATE:
					return lang switch {
						Language.ENG => "Splash Plate",
						Language.JPN => "しずくプレート",
						Language.GER => "Wassertafel",
						Language.FRE => "Plaque Hydro",
						Language.ITA => "Lastraidro",
						Language.SPN => "Tabla Linfa",
						Language.KOR => "물방울플레이트",
						Language.CHN_SIM => "水滴石板",
						Language.CHN_TRA => "水滴石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SPOOKY_PLATE:
					return lang switch {
						Language.ENG => "Spooky Plate",
						Language.JPN => "もののけプレート",
						Language.GER => "Spuktafel",
						Language.FRE => "Plaque Fantôme",
						Language.ITA => "Lastratetra",
						Language.SPN => "Tabla Terror",
						Language.KOR => "원령플레이트",
						Language.CHN_SIM => "妖怪石板",
						Language.CHN_TRA => "妖怪石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STAR_SWEET:
					return lang switch {
						Language.ENG => "Star Sweet",
						Language.JPN => "スターアメざいく",
						Language.GER => "Zucker-Stern",
						Language.FRE => "Étoile en Sucre",
						Language.ITA => "Bonbonstella",
						Language.SPN => "Confite Estrella",
						Language.KOR => "스타사탕공예",
						Language.CHN_SIM => "星星糖饰",
						Language.CHN_TRA => "星星糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STEEL_GEM:
					return lang switch {
						Language.ENG => "Steel Gem",
						Language.JPN => "はがねのジュエル",
						Language.GER => "Stahljuwel",
						Language.FRE => "Joyau Acier",
						Language.ITA => "Bijouacciaio",
						Language.SPN => "Gema Acero",
						Language.KOR => "강철주얼",
						Language.CHN_SIM => "钢之宝石",
						Language.CHN_TRA => "鋼之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STEEL_MEMORY:
					return lang switch {
						Language.ENG => "Steel Memory",
						Language.JPN => "スチールメモリ",
						Language.GER => "Stahl-Disc",
						Language.FRE => "ROM Acier",
						Language.ITA => "ROM Acciaio",
						Language.SPN => "Disco Acero",
						Language.KOR => "스틸메모리",
						Language.CHN_SIM => "钢铁存储碟",
						Language.CHN_TRA => "鋼鐵記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STEELIUM_Z:
					return lang switch {
						Language.ENG => "Steelium Z",
						Language.JPN => "ハガネＺ",
						Language.GER => "Metallium Z",
						Language.FRE => "Métallozélite",
						Language.ITA => "Metallium Z",
						Language.SPN => "Metalostal Z",
						Language.KOR => "강철Z",
						Language.CHN_SIM => "钢Ｚ",
						Language.CHN_TRA => "鋼Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STEELIXITE:
					return lang switch {
						Language.ENG => "Steelixite",
						Language.JPN => "ハガネールナイト",
						Language.GER => "Stahlosnit",
						Language.FRE => "Steelixite",
						Language.ITA => "Steelixite",
						Language.SPN => "Steelixita",
						Language.KOR => "강철톤나이트",
						Language.CHN_SIM => "大钢蛇进化石",
						Language.CHN_TRA => "大鋼蛇進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STICKY_BARB:
					return lang switch {
						Language.ENG => "Sticky Barb",
						Language.JPN => "くっつきバリ",
						Language.GER => "Klettdorn",
						Language.FRE => "Piquants",
						Language.ITA => "Vischiopunta",
						Language.SPN => "Toxiestrella",
						Language.KOR => "끈적끈적바늘",
						Language.CHN_SIM => "附着针",
						Language.CHN_TRA => "附著針",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STONE_PLATE:
					return lang switch {
						Language.ENG => "Stone Plate",
						Language.JPN => "がんせきプレート",
						Language.GER => "Steintafel",
						Language.FRE => "Plaque Roc",
						Language.ITA => "Lastrapietra",
						Language.SPN => "Tabla Pétrea",
						Language.KOR => "암석플레이트",
						Language.CHN_SIM => "岩石石板",
						Language.CHN_TRA => "岩石石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STRAWBERRY_SWEET:
					return lang switch {
						Language.ENG => "Strawberry Sweet",
						Language.JPN => "いちごアメざいく",
						Language.GER => "Zucker-Erdbeere",
						Language.FRE => "Fraise en Sucre",
						Language.ITA => "Bonbonfragola",
						Language.SPN => "Confite Fresa",
						Language.KOR => "딸기사탕공예",
						Language.CHN_SIM => "草莓糖饰",
						Language.CHN_TRA => "草莓糖飾",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SWAMPERTITE:
					return lang switch {
						Language.ENG => "Swampertite",
						Language.JPN => "ラグラージナイト",
						Language.GER => "Sumpexnit",
						Language.FRE => "Laggronite",
						Language.ITA => "Swampertite",
						Language.SPN => "Swampertita",
						Language.KOR => "대짱이나이트",
						Language.CHN_SIM => "巨沼怪进化石",
						Language.CHN_TRA => "巨沼怪進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SWEET_APPLE:
					return lang switch {
						Language.ENG => "Sweet Apple",
						Language.JPN => "あまーいりんご",
						Language.GER => "Süßer Apfel",
						Language.FRE => "Pomme Sucrée",
						Language.ITA => "Dolcepomo",
						Language.SPN => "Manzana Dulce",
						Language.KOR => "달콤한사과",
						Language.CHN_SIM => "甜甜苹果",
						Language.CHN_TRA => "甜甜蘋果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SYRUPY_APPLE:
					return lang switch {
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TAPUNIUM_Z:
					return lang switch {
						Language.ENG => "Tapunium Z",
						Language.JPN => "カプＺ",
						Language.GER => "Kapium Z",
						Language.FRE => "Tokozélite",
						Language.ITA => "Tapium Z",
						Language.SPN => "Tapistal Z",
						Language.KOR => "카푸Z",
						Language.CHN_SIM => "卡璞Ｚ",
						Language.CHN_TRA => "卡璞Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TART_APPLE:
					return lang switch {
						Language.ENG => "Tart Apple",
						Language.JPN => "すっぱいりんご",
						Language.GER => "Saurer Apfel",
						Language.FRE => "Pomme Acidulée",
						Language.ITA => "Aspropomo",
						Language.SPN => "Manzana Ácida",
						Language.KOR => "새콤한사과",
						Language.CHN_SIM => "酸酸苹果",
						Language.CHN_TRA => "酸酸蘋果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TERRAIN_EXTENDER:
					return lang switch {
						Language.ENG => "Terrain Extender",
						Language.JPN => "グランドコート",
						Language.GER => "Feldbeschichtung",
						Language.FRE => "Champ’Duit",
						Language.ITA => "Fissacampo",
						Language.SPN => "Cubresuelos",
						Language.KOR => "그라운드코트",
						Language.CHN_SIM => "大地膜",
						Language.CHN_TRA => "大地膜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.THICK_CLUB:
					return lang switch {
						Language.ENG => "Thick Club",
						Language.JPN => "ふといホネ",
						Language.GER => "Kampfknochen",
						Language.FRE => "Masse Os",
						Language.ITA => "Osso spesso",
						Language.SPN => "Hueso Grueso",
						Language.KOR => "굵은뼈",
						Language.CHN_SIM => "粗骨头",
						Language.CHN_TRA => "粗骨頭",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.THROAT_SPRAY:
					return lang switch {
						Language.ENG => "Throat Spray",
						Language.JPN => "のどスプレー",
						Language.GER => "Halsspray",
						Language.FRE => "Spray Gorge",
						Language.ITA => "Spray gola",
						Language.SPN => "Espray Bucal",
						Language.KOR => "목스프레이",
						Language.CHN_SIM => "爽喉喷雾",
						Language.CHN_TRA => "爽喉噴霧",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TOXIC_ORB:
					return lang switch {
						Language.ENG => "Toxic Orb",
						Language.JPN => "どくどくだま",
						Language.GER => "Toxik-Orb",
						Language.FRE => "Orbe Toxique",
						Language.ITA => "Tossicsfera",
						Language.SPN => "Toxisfera",
						Language.KOR => "맹독구슬",
						Language.CHN_SIM => "剧毒宝珠",
						Language.CHN_TRA => "劇毒寶珠",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TOXIC_PLATE:
					return lang switch {
						Language.ENG => "Toxic Plate",
						Language.JPN => "もうどくプレート",
						Language.GER => "Gifttafel",
						Language.FRE => "Plaque Toxicité",
						Language.ITA => "Lastrafiele",
						Language.SPN => "Tabla Tóxica",
						Language.KOR => "맹독플레이트",
						Language.CHN_SIM => "剧毒石板",
						Language.CHN_TRA => "劇毒石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TWISTED_SPOON:
					return lang switch {
						Language.ENG => "Twisted Spoon",
						Language.JPN => "まがったスプーン",
						Language.GER => "Krummlöffel",
						Language.FRE => "Cuillère Tordue",
						Language.ITA => "Cucchiaio torto",
						Language.SPN => "Cuchara Torcida",
						Language.KOR => "휘어진스푼",
						Language.CHN_SIM => "弯曲的汤匙",
						Language.CHN_TRA => "彎曲的湯匙",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TYRANITARITE:
					return lang switch {
						Language.ENG => "Tyranitarite",
						Language.JPN => "バンギラスナイト",
						Language.GER => "Despotarnit",
						Language.FRE => "Tyranocivite",
						Language.ITA => "Tyranitarite",
						Language.SPN => "Tyranitarita",
						Language.KOR => "마기라스나이트",
						Language.CHN_SIM => "班基拉斯进化石",
						Language.CHN_TRA => "班基拉斯進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ULTRANECROZIUM_Z:
					return lang switch {
						Language.ENG => "Ultranecrozium Z",
						Language.JPN => "ウルトラネクロＺ",
						Language.GER => "Ultranecronium Z",
						Language.FRE => "Ultranécrozélite",
						Language.ITA => "Ultranecrozium Z",
						Language.SPN => "Ultranecrostal Z",
						Language.KOR => "울트라네크로Z",
						Language.CHN_SIM => "究极奈克洛Ｚ",
						Language.CHN_TRA => "究極奈克洛Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.UTILITY_UMBRELLA:
					return lang switch {
						Language.ENG => "Utility Umbrella",
						Language.JPN => "ばんのうがさ",
						Language.GER => "Allzweckschirm",
						Language.FRE => "Parapluie Solide",
						Language.ITA => "Superombrello",
						Language.SPN => "Parasol Multiuso",
						Language.KOR => "만능우산",
						Language.CHN_SIM => "万能伞",
						Language.CHN_TRA => "萬能傘",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.VENUSAURITE:
					return lang switch {
						Language.ENG => "Venusaurite",
						Language.JPN => "フシギバナイト",
						Language.GER => "Bisaflornit",
						Language.FRE => "Florizarrite",
						Language.ITA => "Venusaurite",
						Language.SPN => "Venusaurita",
						Language.KOR => "이상해꽃나이트",
						Language.CHN_SIM => "妙蛙花进化石",
						Language.CHN_TRA => "妙蛙花進化石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WATER_GEM:
					return lang switch {
						Language.ENG => "Water Gem",
						Language.JPN => "みずのジュエル",
						Language.GER => "Wasserjuwel",
						Language.FRE => "Joyau Eau",
						Language.ITA => "Bijouacqua",
						Language.SPN => "Gema Agua",
						Language.KOR => "물주얼",
						Language.CHN_SIM => "水之宝石",
						Language.CHN_TRA => "水之寶石",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WATER_MEMORY:
					return lang switch {
						Language.ENG => "Water Memory",
						Language.JPN => "ウオーターメモリ",
						Language.GER => "Wasser-Disc",
						Language.FRE => "ROM Eau",
						Language.ITA => "ROM Acqua",
						Language.SPN => "Disco Agua",
						Language.KOR => "워터메모리",
						Language.CHN_SIM => "清水存储碟",
						Language.CHN_TRA => "清水記憶碟",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WATERIUM_Z:
					return lang switch {
						Language.ENG => "Waterium Z",
						Language.JPN => "ミズＺ",
						Language.GER => "Aquium Z",
						Language.FRE => "Aquazélite",
						Language.ITA => "Idrium Z",
						Language.SPN => "Hidrostal Z",
						Language.KOR => "물Z",
						Language.CHN_SIM => "水Ｚ",
						Language.CHN_TRA => "水Ｚ",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WAVE_INCENSE:
					return lang switch {
						Language.ENG => "Wave Incense",
						Language.JPN => "さざなみのおこう",
						Language.GER => "Wellenrauch",
						Language.FRE => "Encens Vague",
						Language.ITA => "Ondaroma",
						Language.SPN => "Incienso Acua",
						Language.KOR => "잔물결향로",
						Language.CHN_SIM => "涟漪薰香",
						Language.CHN_TRA => "漣漪薰香",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WEAKNESS_POLICY:
					return lang switch {
						Language.ENG => "Weakness Policy",
						Language.JPN => "じゃくてんほけん",
						Language.GER => "Schwächenschutz",
						Language.FRE => "Vulné-Assurance",
						Language.ITA => "Vulneropolizza",
						Language.SPN => "Seguro Debilidad",
						Language.KOR => "약점보험",
						Language.CHN_SIM => "弱点保险",
						Language.CHN_TRA => "弱點保險",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WHITE_HERB:
					return lang switch {
						Language.ENG => "White Herb",
						Language.JPN => "しろいハーブ",
						Language.GER => "Schlohkraut",
						Language.FRE => "Herbe Blanche",
						Language.ITA => "Erbachiara",
						Language.SPN => "Hierba Blanca",
						Language.KOR => "하양허브",
						Language.CHN_SIM => "白色香草",
						Language.CHN_TRA => "白色香草",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WIDE_LENS:
					return lang switch {
						Language.ENG => "Wide Lens",
						Language.JPN => "こうかくレンズ",
						Language.GER => "Großlinse",
						Language.FRE => "Loupe",
						Language.ITA => "Grandelente",
						Language.SPN => "Lupa",
						Language.KOR => "광각렌즈",
						Language.CHN_SIM => "广角镜",
						Language.CHN_TRA => "廣角鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WISE_GLASSES:
					return lang switch {
						Language.ENG => "Wise Glasses",
						Language.JPN => "ものしりメガネ",
						Language.GER => "Schlaubrille",
						Language.FRE => "Lunettes Sages",
						Language.ITA => "Saviocchiali",
						Language.SPN => "Gafas Especiales",
						Language.KOR => "박식안경",
						Language.CHN_SIM => "博识眼镜",
						Language.CHN_TRA => "博識眼鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.YELLOW_NECTAR:
					return lang switch {
						Language.ENG => "Yellow Nectar",
						Language.JPN => "やまぶきのミツ",
						Language.GER => "Gelber Nektar",
						Language.FRE => "Nectar Jaune",
						Language.ITA => "Nettare giallo",
						Language.SPN => "Néctar Amarillo",
						Language.KOR => "진노랑꿀",
						Language.CHN_SIM => "金黄色花蜜",
						Language.CHN_TRA => "金黃色花蜜",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ZAP_PLATE:
					return lang switch {
						Language.ENG => "Zap Plate",
						Language.JPN => "いかずちプレート",
						Language.GER => "Blitztafel",
						Language.FRE => "Plaque Volt",
						Language.ITA => "Lastrasaetta",
						Language.SPN => "Tabla Trueno",
						Language.KOR => "우레플레이트",
						Language.CHN_SIM => "雷电石板",
						Language.CHN_TRA => "雷電石板",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ZOOM_LENS:
					return lang switch {
						Language.ENG => "Zoom Lens",
						Language.JPN => "フォーカスレンズ",
						Language.GER => "Zoomlinse",
						Language.FRE => "Lentille Zoom",
						Language.ITA => "Zoomlente",
						Language.SPN => "Telescopio",
						Language.KOR => "포커스렌즈",
						Language.CHN_SIM => "对焦镜",
						Language.CHN_TRA => "對焦鏡",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				#endregion
				#region Berries
				case Item.AGUAV_BERRY:
					return lang switch {
						Language.ENG => "Aguav Berry",
						Language.JPN => "バンジのみ",
						Language.GER => "Gauvebeere",
						Language.FRE => "Baie Gowav",
						Language.ITA => "Baccaguava",
						Language.SPN => "Baya Guaya",
						Language.KOR => "아바열매",
						Language.CHN_SIM => "乐芭果",
						Language.CHN_TRA => "樂芭果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.APICOT_BERRY:
					return lang switch {
						Language.ENG => "Apicot Berry",
						Language.JPN => "ズアのみ",
						Language.GER => "Apikobeere",
						Language.FRE => "Baie Abriko",
						Language.ITA => "Baccacocca",
						Language.SPN => "Baya Aricoc",
						Language.KOR => "규살열매",
						Language.CHN_SIM => "杏仔果",
						Language.CHN_TRA => "杏仔果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ASPEAR_BERRY:
					return lang switch {
						Language.ENG => "Aspear Berry",
						Language.JPN => "ナナシのみ",
						Language.GER => "Wilbirbeere",
						Language.FRE => "Baie Willia",
						Language.ITA => "Baccaperina",
						Language.SPN => "Baya Perasi",
						Language.KOR => "배리열매",
						Language.CHN_SIM => "利木果",
						Language.CHN_TRA => "利木果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BABIRI_BERRY:
					return lang switch {
						Language.ENG => "Babiri Berry",
						Language.JPN => "リリバのみ",
						Language.GER => "Babiribeere",
						Language.FRE => "Baie Babiri",
						Language.ITA => "Baccababiri",
						Language.SPN => "Baya Baribá",
						Language.KOR => "바리비열매",
						Language.CHN_SIM => "霹霹果",
						Language.CHN_TRA => "霹霹果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BELUE_BERRY:
					return lang switch {
						Language.ENG => "Belue Berry",
						Language.JPN => "ベリブのみ",
						Language.GER => "Myrtilbeere",
						Language.FRE => "Baie Myrte",
						Language.ITA => "Baccartillo",
						Language.SPN => "Baya Andano",
						Language.KOR => "루베열매",
						Language.CHN_SIM => "靛莓果",
						Language.CHN_TRA => "靛莓果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.BLUK_BERRY:
					return lang switch {
						Language.ENG => "Bluk Berry",
						Language.JPN => "ブリーのみ",
						Language.GER => "Morbbeere",
						Language.FRE => "Baie Remu",
						Language.ITA => "Baccamora",
						Language.SPN => "Baya Oram",
						Language.KOR => "블리열매",
						Language.CHN_SIM => "墨莓果",
						Language.CHN_TRA => "墨莓果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHARTI_BERRY:
					return lang switch {
						Language.ENG => "Charti Berry",
						Language.JPN => "ヨロギのみ",
						Language.GER => "Chiaribeere",
						Language.FRE => "Baie Charti",
						Language.ITA => "Baccaciofo",
						Language.SPN => "Baya Alcho",
						Language.KOR => "루미열매",
						Language.CHN_SIM => "草蚕果",
						Language.CHN_TRA => "草蠶果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHERI_BERRY:
					return lang switch {
						Language.ENG => "Cheri Berry",
						Language.JPN => "クラボのみ",
						Language.GER => "Amrenabeere",
						Language.FRE => "Baie Ceriz",
						Language.ITA => "Baccaliegia",
						Language.SPN => "Baya Zreza",
						Language.KOR => "버치열매",
						Language.CHN_SIM => "樱子果",
						Language.CHN_TRA => "櫻子果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHESTO_BERRY:
					return lang switch {
						Language.ENG => "Chesto Berry",
						Language.JPN => "カゴのみ",
						Language.GER => "Maronbeere",
						Language.FRE => "Baie Maron",
						Language.ITA => "Baccastagna",
						Language.SPN => "Baya Atania",
						Language.KOR => "유루열매",
						Language.CHN_SIM => "零余果",
						Language.CHN_TRA => "零餘果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHILAN_BERRY:
					return lang switch {
						Language.ENG => "Chilan Berry",
						Language.JPN => "ホズのみ",
						Language.GER => "Latchibeere",
						Language.FRE => "Baie Zalis",
						Language.ITA => "Baccacinlan",
						Language.SPN => "Baya Chilan",
						Language.KOR => "카리열매",
						Language.CHN_SIM => "灯浆果",
						Language.CHN_TRA => "燈漿果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CHOPLE_BERRY:
					return lang switch {
						Language.ENG => "Chople Berry",
						Language.JPN => "ヨプのみ",
						Language.GER => "Rospelbeere",
						Language.FRE => "Baie Pomroz",
						Language.ITA => "Baccarosmel",
						Language.SPN => "Baya Pomaro",
						Language.KOR => "로플열매",
						Language.CHN_SIM => "莲蒲果",
						Language.CHN_TRA => "蓮蒲果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.COBA_BERRY:
					return lang switch {
						Language.ENG => "Coba Berry",
						Language.JPN => "バコウのみ",
						Language.GER => "Kobabeere",
						Language.FRE => "Baie Cobaba",
						Language.ITA => "Baccababa",
						Language.SPN => "Baya Kouba",
						Language.KOR => "바코열매",
						Language.CHN_SIM => "棱瓜果",
						Language.CHN_TRA => "稜瓜果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.COLBUR_BERRY:
					return lang switch {
						Language.ENG => "Colbur Berry",
						Language.JPN => "ナモのみ",
						Language.GER => "Burleobeere",
						Language.FRE => "Baie Lampou",
						Language.ITA => "Baccaxan",
						Language.SPN => "Baya Dillo",
						Language.KOR => "마코열매",
						Language.CHN_SIM => "刺耳果",
						Language.CHN_TRA => "刺耳果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CORNN_BERRY:
					return lang switch {
						Language.ENG => "Cornn Berry",
						Language.JPN => "モコシのみ",
						Language.GER => "Saimbeere",
						Language.FRE => "Baie Siam",
						Language.ITA => "Baccavena",
						Language.SPN => "Baya Mais",
						Language.KOR => "수숙열매",
						Language.CHN_SIM => "玉黍果",
						Language.CHN_TRA => "玉黍果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.CUSTAP_BERRY:
					return lang switch {
						Language.ENG => "Custap Berry",
						Language.JPN => "イバンのみ",
						Language.GER => "Eipfelbeere",
						Language.FRE => "Baie Chérim",
						Language.ITA => "Baccacrela",
						Language.SPN => "Baya Chiri",
						Language.KOR => "애슈열매",
						Language.CHN_SIM => "释陀果",
						Language.CHN_TRA => "釋陀果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.DURIN_BERRY:
					return lang switch {
						Language.ENG => "Durin Berry",
						Language.JPN => "ドリのみ",
						Language.GER => "Durinbeere",
						Language.FRE => "Baie Durin",
						Language.ITA => "Baccadurian",
						Language.SPN => "Baya Rudion",
						Language.KOR => "두리열매",
						Language.CHN_SIM => "金枕果",
						Language.CHN_TRA => "金枕果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ENIGMA_BERRY:
					return lang switch {
						Language.ENG => "Enigma Berry",
						Language.JPN => "ナゾのみ",
						Language.GER => "Enigmabeere",
						Language.FRE => "Baie Enigma",
						Language.ITA => "Baccaenigma",
						Language.SPN => "Baya Enigma",
						Language.KOR => "의문열매",
						Language.CHN_SIM => "谜芝果",
						Language.CHN_TRA => "謎芝果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.FIGY_BERRY:
					return lang switch {
						Language.ENG => "Figy Berry",
						Language.JPN => "フィラのみ",
						Language.GER => "Giefebeere",
						Language.FRE => "Baie Figuy",
						Language.ITA => "Baccafico",
						Language.SPN => "Baya Higog",
						Language.KOR => "무화열매",
						Language.CHN_SIM => "勿花果",
						Language.CHN_TRA => "勿花果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GANLON_BERRY:
					return lang switch {
						Language.ENG => "Ganlon Berry",
						Language.JPN => "リュガのみ",
						Language.GER => "Linganbeere",
						Language.FRE => "Baie Lingan",
						Language.ITA => "Baccalongan",
						Language.SPN => "Baya Gonlan",
						Language.KOR => "용아열매",
						Language.CHN_SIM => "龙睛果",
						Language.CHN_TRA => "龍睛果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GOLDEN_NANAB_BERRY:
					return lang switch {
						Language.ENG => "Golden Nanab Berry",
						Language.JPN => "きんのナナのみ",
						Language.GER => "Goldene Nanabbeere",
						Language.FRE => "Baie Nanab dorée",
						Language.ITA => "Baccabana dorata",
						Language.SPN => "Baya Latano Dorada",
						Language.KOR => "황금 나나열매",
						Language.CHN_SIM => "金色蕉香果",
						Language.CHN_TRA => "金色蕉香果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GOLDEN_PINAP_BERRY:
					return lang switch {
						Language.ENG => "Golden Pinap Berry",
						Language.JPN => "きんのパイルのみ",
						Language.GER => "Goldene Sananabeere",
						Language.FRE => "Baie Nanana dorée",
						Language.ITA => "Baccananas dorata",
						Language.SPN => "Baya Pinia Dorada",
						Language.KOR => "황금 파인열매",
						Language.CHN_SIM => "金色凰梨果",
						Language.CHN_TRA => "金色凰梨果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GOLDEN_RAZZ_BERRY:
					return lang switch {
						Language.ENG => "Golden Razz Berry",
						Language.JPN => "きんのズリのみ",
						Language.GER => "Goldene Himmihbeere",
						Language.FRE => "Baie Framby dorée",
						Language.ITA => "Baccalampon dorata",
						Language.SPN => "Baya Frambu Dorada",
						Language.KOR => "황금 라즈열매",
						Language.CHN_SIM => "金色蔓莓果",
						Language.CHN_TRA => "金色蔓莓果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.GREPA_BERRY:
					return lang switch {
						Language.ENG => "Grepa Berry",
						Language.JPN => "ウブのみ",
						Language.GER => "Labrusbeere",
						Language.FRE => "Baie Résin",
						Language.ITA => "Baccauva",
						Language.SPN => "Baya Uvav",
						Language.KOR => "또뽀열매",
						Language.CHN_SIM => "萄葡果",
						Language.CHN_TRA => "萄葡果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HABAN_BERRY:
					return lang switch {
						Language.ENG => "Haban Berry",
						Language.JPN => "ハバンのみ",
						Language.GER => "Terirobeere",
						Language.FRE => "Baie Fraigo",
						Language.ITA => "Baccahaban",
						Language.SPN => "Baya Anjiro",
						Language.KOR => "하반열매",
						Language.CHN_SIM => "莓榴果",
						Language.CHN_TRA => "莓榴果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.HONDEW_BERRY:
					return lang switch {
						Language.ENG => "Hondew Berry",
						Language.JPN => "ロメのみ",
						Language.GER => "Honmelbeere",
						Language.FRE => "Baie Lonme",
						Language.ITA => "Baccamelon",
						Language.SPN => "Baya Meluce",
						Language.KOR => "로매열매",
						Language.CHN_SIM => "哈密果",
						Language.CHN_TRA => "哈密果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.IAPAPA_BERRY:
					return lang switch {
						Language.ENG => "Iapapa Berry",
						Language.JPN => "イアのみ",
						Language.GER => "Yapabeere",
						Language.FRE => "Baie Papaya",
						Language.ITA => "Baccapaia",
						Language.SPN => "Baya Pabaya",
						Language.KOR => "파야열매",
						Language.CHN_SIM => "芭亚果",
						Language.CHN_TRA => "芭亞果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.JABOCA_BERRY:
					return lang switch {
						Language.ENG => "Jaboca Berry",
						Language.JPN => "ジャポのみ",
						Language.GER => "Jabocabeere",
						Language.FRE => "Baie Jaboca",
						Language.ITA => "Baccajaba",
						Language.SPN => "Baya Jaboca",
						Language.KOR => "자보열매",
						Language.CHN_SIM => "嘉珍果",
						Language.CHN_TRA => "嘉珍果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KASIB_BERRY:
					return lang switch {
						Language.ENG => "Kasib Berry",
						Language.JPN => "カシブのみ",
						Language.GER => "Zitarzbeere",
						Language.FRE => "Baie Sédra",
						Language.ITA => "Baccacitrus",
						Language.SPN => "Baya Drasi",
						Language.KOR => "수불열매",
						Language.CHN_SIM => "佛柑果",
						Language.CHN_TRA => "佛柑果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KEBIA_BERRY:
					return lang switch {
						Language.ENG => "Kebia Berry",
						Language.JPN => "ビアーのみ",
						Language.GER => "Grarzbeere",
						Language.FRE => "Baie Kébia",
						Language.ITA => "Baccakebia",
						Language.SPN => "Baya Kebia",
						Language.KOR => "으름열매",
						Language.CHN_SIM => "通通果",
						Language.CHN_TRA => "通通果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KEE_BERRY:
					return lang switch {
						Language.ENG => "Kee Berry",
						Language.JPN => "アッキのみ",
						Language.GER => "Akibeere",
						Language.FRE => "Baie Éka",
						Language.ITA => "Baccalighia",
						Language.SPN => "Baya Biglia",
						Language.KOR => "악키열매",
						Language.CHN_SIM => "亚开果",
						Language.CHN_TRA => "亞開果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.KELPSY_BERRY:
					return lang switch {
						Language.ENG => "Kelpsy Berry",
						Language.JPN => "ネコブのみ",
						Language.GER => "Setangbeere",
						Language.FRE => "Baie Alga",
						Language.ITA => "Baccalga",
						Language.SPN => "Baya Algama",
						Language.KOR => "시마열매",
						Language.CHN_SIM => "藻根果",
						Language.CHN_TRA => "藻根果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LANSAT_BERRY:
					return lang switch {
						Language.ENG => "Lansat Berry",
						Language.JPN => "サンのみ",
						Language.GER => "Lansatbeere",
						Language.FRE => "Baie Lansat",
						Language.ITA => "Baccalangsa",
						Language.SPN => "Baya Zonlan",
						Language.KOR => "랑사열매",
						Language.CHN_SIM => "兰萨果",
						Language.CHN_TRA => "蘭薩果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LEPPA_BERRY:
					return lang switch {
						Language.ENG => "Leppa Berry",
						Language.JPN => "ヒメリのみ",
						Language.GER => "Jonagobeere",
						Language.FRE => "Baie Mepo",
						Language.ITA => "Baccamela",
						Language.SPN => "Baya Zanama",
						Language.KOR => "과사열매",
						Language.CHN_SIM => "苹野果",
						Language.CHN_TRA => "蘋野果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LIECHI_BERRY:
					return lang switch {
						Language.ENG => "Liechi Berry",
						Language.JPN => "チイラのみ",
						Language.GER => "Lydzibeere",
						Language.FRE => "Baie Lichii",
						Language.ITA => "Baccalici",
						Language.SPN => "Baya Lichi",
						Language.KOR => "치리열매",
						Language.CHN_SIM => "枝荔果",
						Language.CHN_TRA => "枝荔果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.LUM_BERRY:
					return lang switch {
						Language.ENG => "Lum Berry",
						Language.JPN => "ラムのみ",
						Language.GER => "Prunusbeere",
						Language.FRE => "Baie Prine",
						Language.ITA => "Baccaprugna",
						Language.SPN => "Baya Ziuela",
						Language.KOR => "리샘열매",
						Language.CHN_SIM => "木子果",
						Language.CHN_TRA => "木子果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MAGO_BERRY:
					return lang switch {
						Language.ENG => "Mago Berry",
						Language.JPN => "マゴのみ",
						Language.GER => "Magobeere",
						Language.FRE => "Baie Mago",
						Language.ITA => "Baccamango",
						Language.SPN => "Baya Ango",
						Language.KOR => "마고열매",
						Language.CHN_SIM => "芒芒果",
						Language.CHN_TRA => "芒芒果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MAGOST_BERRY:
					return lang switch {
						Language.ENG => "Magost Berry",
						Language.JPN => "ゴスのみ",
						Language.GER => "Magostbeere",
						Language.FRE => "Baie Mangou",
						Language.ITA => "Baccagostan",
						Language.SPN => "Baya Aostan",
						Language.KOR => "고스티열매",
						Language.CHN_SIM => "岳竹果",
						Language.CHN_TRA => "岳竹果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MARANGA_BERRY:
					return lang switch {
						Language.ENG => "Maranga Berry",
						Language.JPN => "タラプのみ",
						Language.GER => "Tarabeere",
						Language.FRE => "Baie Rangma",
						Language.ITA => "Baccapane",
						Language.SPN => "Baya Maranga",
						Language.KOR => "타라프열매",
						Language.CHN_SIM => "香罗果",
						Language.CHN_TRA => "香羅果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.MICLE_BERRY:
					return lang switch {
						Language.ENG => "Micle Berry",
						Language.JPN => "ミクルのみ",
						Language.GER => "Wunfrubeere",
						Language.FRE => "Baie Micle",
						Language.ITA => "Baccaracolo",
						Language.SPN => "Baya Lagro",
						Language.KOR => "미클열매",
						Language.CHN_SIM => "奇秘果",
						Language.CHN_TRA => "奇秘果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.NANAB_BERRY:
					return lang switch {
						Language.ENG => "Nanab Berry",
						Language.JPN => "ナナのみ",
						Language.GER => "Nanabbeere",
						Language.FRE => "Baie Nanab",
						Language.ITA => "Baccabana",
						Language.SPN => "Baya Latano",
						Language.KOR => "나나열매",
						Language.CHN_SIM => "蕉香果",
						Language.CHN_TRA => "蕉香果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.NOMEL_BERRY:
					return lang switch {
						Language.ENG => "Nomel Berry",
						Language.JPN => "ノメルのみ",
						Language.GER => "Tronzibeere",
						Language.FRE => "Baie Tronci",
						Language.ITA => "Baccalemon",
						Language.SPN => "Baya Monli",
						Language.KOR => "노멜열매",
						Language.CHN_SIM => "檬柠果",
						Language.CHN_TRA => "檬檸果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.OCCA_BERRY:
					return lang switch {
						Language.ENG => "Occa Berry",
						Language.JPN => "オッカのみ",
						Language.GER => "Koakobeere",
						Language.FRE => "Baie Chocco",
						Language.ITA => "Baccacao",
						Language.SPN => "Baya Caoca",
						Language.KOR => "오카열매",
						Language.CHN_SIM => "巧可果",
						Language.CHN_TRA => "巧可果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ORAN_BERRY:
					return lang switch {
						Language.ENG => "Oran Berry",
						Language.JPN => "オレンのみ",
						Language.GER => "Sinelbeere",
						Language.FRE => "Baie Oran",
						Language.ITA => "Baccarancia",
						Language.SPN => "Baya Aranja",
						Language.KOR => "오랭열매",
						Language.CHN_SIM => "橙橙果",
						Language.CHN_TRA => "橙橙果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PAMTRE_BERRY:
					return lang switch {
						Language.ENG => "Pamtre Berry",
						Language.JPN => "シーヤのみ",
						Language.GER => "Pallmbeere",
						Language.FRE => "Baie Palma",
						Language.ITA => "Baccapalma",
						Language.SPN => "Baya Plama",
						Language.KOR => "자야열매",
						Language.CHN_SIM => "椰木果",
						Language.CHN_TRA => "椰木果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PASSHO_BERRY:
					return lang switch {
						Language.ENG => "Passho Berry",
						Language.JPN => "イトケのみ",
						Language.GER => "Foepasbeere",
						Language.FRE => "Baie Pocpoc",
						Language.ITA => "Baccapasflo",
						Language.SPN => "Baya Pasio",
						Language.KOR => "꼬시개열매",
						Language.CHN_SIM => "千香果",
						Language.CHN_TRA => "千香果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PAYAPA_BERRY:
					return lang switch {
						Language.ENG => "Payapa Berry",
						Language.JPN => "ウタンのみ",
						Language.GER => "Pyapabeere",
						Language.FRE => "Baie Yapap",
						Language.ITA => "Baccapayapa",
						Language.SPN => "Baya Payapa",
						Language.KOR => "야파열매",
						Language.CHN_SIM => "福禄果",
						Language.CHN_TRA => "福祿果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PECHA_BERRY:
					return lang switch {
						Language.ENG => "Pecha Berry",
						Language.JPN => "モモンのみ",
						Language.GER => "Pirsifbeere",
						Language.FRE => "Baie Pêcha",
						Language.ITA => "Baccapesca",
						Language.SPN => "Baya Meloc",
						Language.KOR => "복슝열매",
						Language.CHN_SIM => "桃桃果",
						Language.CHN_TRA => "桃桃果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PERSIM_BERRY:
					return lang switch {
						Language.ENG => "Persim Berry",
						Language.JPN => "キーのみ",
						Language.GER => "Persimbeere",
						Language.FRE => "Baie Kika",
						Language.ITA => "Baccaki",
						Language.SPN => "Baya Caquic",
						Language.KOR => "시몬열매",
						Language.CHN_SIM => "柿仔果",
						Language.CHN_TRA => "柿仔果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PETAYA_BERRY:
					return lang switch {
						Language.ENG => "Petaya Berry",
						Language.JPN => "ヤタピのみ",
						Language.GER => "Tahaybeere",
						Language.FRE => "Baie Pitaye",
						Language.ITA => "Baccapitaya",
						Language.SPN => "Baya Yapati",
						Language.KOR => "야타비열매",
						Language.CHN_SIM => "龙火果",
						Language.CHN_TRA => "龍火果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.PINAP_BERRY:
					return lang switch {
						Language.ENG => "Pinap Berry",
						Language.JPN => "パイルのみ",
						Language.GER => "Sananabeere",
						Language.FRE => "Baie Nanana",
						Language.ITA => "Baccananas",
						Language.SPN => "Baya Pinia",
						Language.KOR => "파인열매",
						Language.CHN_SIM => "凰梨果",
						Language.CHN_TRA => "凰梨果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.POMEG_BERRY:
					return lang switch {
						Language.ENG => "Pomeg Berry",
						Language.JPN => "ザロクのみ",
						Language.GER => "Granabeere",
						Language.FRE => "Baie Grena",
						Language.ITA => "Baccagrana",
						Language.SPN => "Baya Grana",
						Language.KOR => "유석열매",
						Language.CHN_SIM => "榴石果",
						Language.CHN_TRA => "榴石果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.QUALOT_BERRY:
					return lang switch {
						Language.ENG => "Qualot Berry",
						Language.JPN => "タポルのみ",
						Language.GER => "Qualotbeere",
						Language.FRE => "Baie Qualot",
						Language.ITA => "Baccaloquat",
						Language.SPN => "Baya Ispero",
						Language.KOR => "파비열매",
						Language.CHN_SIM => "比巴果",
						Language.CHN_TRA => "比巴果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RABUTA_BERRY:
					return lang switch {
						Language.ENG => "Rabuta Berry",
						Language.JPN => "ラブタのみ",
						Language.GER => "Rabutabeere",
						Language.FRE => "Baie Rabuta",
						Language.ITA => "Baccambutan",
						Language.SPN => "Baya Rautan",
						Language.KOR => "라부탐열매",
						Language.CHN_SIM => "茸丹果",
						Language.CHN_TRA => "茸丹果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RAWST_BERRY:
					return lang switch {
						Language.ENG => "Rawst Berry",
						Language.JPN => "チーゴのみ",
						Language.GER => "Fragiabeere",
						Language.FRE => "Baie Fraive",
						Language.ITA => "Baccafrago",
						Language.SPN => "Baya Safre",
						Language.KOR => "복분열매",
						Language.CHN_SIM => "莓莓果",
						Language.CHN_TRA => "莓莓果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RAZZ_BERRY:
					return lang switch {
						Language.ENG => "Razz Berry",
						Language.JPN => "ズリのみ",
						Language.GER => "Himmihbeere",
						Language.FRE => "Baie Framby",
						Language.ITA => "Baccalampon",
						Language.SPN => "Baya Frambu",
						Language.KOR => "라즈열매",
						Language.CHN_SIM => "蔓莓果",
						Language.CHN_TRA => "蔓莓果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.RINDO_BERRY:
					return lang switch {
						Language.ENG => "Rindo Berry",
						Language.JPN => "リンドのみ",
						Language.GER => "Grindobeere",
						Language.FRE => "Baie Ratam",
						Language.ITA => "Baccarindo",
						Language.SPN => "Baya Tamar",
						Language.KOR => "린드열매",
						Language.CHN_SIM => "罗子果",
						Language.CHN_TRA => "羅子果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROSELI_BERRY:
					return lang switch {
						Language.ENG => "Roseli Berry",
						Language.JPN => "ロゼルのみ",
						Language.GER => "Hibisbeere",
						Language.FRE => "Baie Selro",
						Language.ITA => "Baccarcadè",
						Language.SPN => "Baya Hibis",
						Language.KOR => "로셀열매",
						Language.CHN_SIM => "洛玫果",
						Language.CHN_TRA => "洛玫果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.ROWAP_BERRY:
					return lang switch {
						Language.ENG => "Rowap Berry",
						Language.JPN => "レンブのみ",
						Language.GER => "Roselbeere",
						Language.FRE => "Baie Pommo",
						Language.ITA => "Baccaroam",
						Language.SPN => "Baya Magua",
						Language.KOR => "애터열매",
						Language.CHN_SIM => "雾莲果",
						Language.CHN_TRA => "霧蓮果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SALAC_BERRY:
					return lang switch {
						Language.ENG => "Salac Berry",
						Language.JPN => "カムラのみ",
						Language.GER => "Salkabeere",
						Language.FRE => "Baie Sailak",
						Language.ITA => "Baccasalak",
						Language.SPN => "Baya Aslac",
						Language.KOR => "캄라열매",
						Language.CHN_SIM => "沙鳞果",
						Language.CHN_TRA => "沙鱗果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SHUCA_BERRY:
					return lang switch {
						Language.ENG => "Shuca Berry",
						Language.JPN => "シュカのみ",
						Language.GER => "Schukebeere",
						Language.FRE => "Baie Jouca",
						Language.ITA => "Baccanaca",
						Language.SPN => "Baya Acardo",
						Language.KOR => "슈캐열매",
						Language.CHN_SIM => "腰木果",
						Language.CHN_TRA => "腰木果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SILVER_NANAB_BERRY:
					return lang switch {
						Language.ENG => "Silver Nanab Berry",
						Language.JPN => "ぎんのナナのみ",
						Language.GER => "Silberne Nanabbeere",
						Language.FRE => "Baie Nanab argentée",
						Language.ITA => "Baccabana argentata",
						Language.SPN => "Baya Latano Plateada",
						Language.KOR => "은 나나열매",
						Language.CHN_SIM => "银色蕉香果",
						Language.CHN_TRA => "銀色蕉香果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SILVER_PINAP_BERRY:
					return lang switch {
						Language.ENG => "Silver Pinap Berry",
						Language.JPN => "ぎんのパイルのみ",
						Language.GER => "Silberne Sananabeere",
						Language.FRE => "Baie Nanana argentée",
						Language.ITA => "Baccananas argentata",
						Language.SPN => "Baya Pinia Plateada",
						Language.KOR => "은 파인열매",
						Language.CHN_SIM => "银色凰梨果",
						Language.CHN_TRA => "銀色凰梨果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SILVER_RAZZ_BERRY:
					return lang switch {
						Language.ENG => "Silver Razz Berry",
						Language.JPN => "ぎんのズリのみ",
						Language.GER => "Silberne Himmihbeere",
						Language.FRE => "Baie Framby argentée",
						Language.ITA => "Baccalampon argentata",
						Language.SPN => "Baya Frambu Plateada",
						Language.KOR => "은 라즈열매",
						Language.CHN_SIM => "银色蔓莓果",
						Language.CHN_TRA => "銀色蔓莓果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SITRUS_BERRY:
					return lang switch {
						Language.ENG => "Sitrus Berry",
						Language.JPN => "オボンのみ",
						Language.GER => "Tsitrubeere",
						Language.FRE => "Baie Sitrus",
						Language.ITA => "Baccacedro",
						Language.SPN => "Baya Zidra",
						Language.KOR => "자뭉열매",
						Language.CHN_SIM => "文柚果",
						Language.CHN_TRA => "文柚果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.SPELON_BERRY:
					return lang switch {
						Language.ENG => "Spelon Berry",
						Language.JPN => "ノワキのみ",
						Language.GER => "Kiwanbeere",
						Language.FRE => "Baie Kiwan",
						Language.ITA => "Baccamelos",
						Language.SPN => "Baya Wikano",
						Language.KOR => "메호키열매",
						Language.CHN_SIM => "刺角果",
						Language.CHN_TRA => "刺角果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.STARF_BERRY:
					return lang switch {
						Language.ENG => "Starf Berry",
						Language.JPN => "スターのみ",
						Language.GER => "Krambobeere",
						Language.FRE => "Baie Frista",
						Language.ITA => "Baccambola",
						Language.SPN => "Baya Arabol",
						Language.KOR => "스타열매",
						Language.CHN_SIM => "星桃果",
						Language.CHN_TRA => "星桃果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TAMATO_BERRY:
					return lang switch {
						Language.ENG => "Tamato Berry",
						Language.JPN => "マトマのみ",
						Language.GER => "Tamotbeere",
						Language.FRE => "Baie Tamato",
						Language.ITA => "Baccamodoro",
						Language.SPN => "Baya Tamate",
						Language.KOR => "토망열매",
						Language.CHN_SIM => "茄番果",
						Language.CHN_TRA => "茄番果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.TANGA_BERRY:
					return lang switch {
						Language.ENG => "Tanga Berry",
						Language.JPN => "タンガのみ",
						Language.GER => "Tanigabeere",
						Language.FRE => "Baie Panga",
						Language.ITA => "Baccaitan",
						Language.SPN => "Baya Yecana",
						Language.KOR => "리체열매",
						Language.CHN_SIM => "扁樱果",
						Language.CHN_TRA => "扁櫻果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WACAN_BERRY:
					return lang switch {
						Language.ENG => "Wacan Berry",
						Language.JPN => "ソクノのみ",
						Language.GER => "Kerzalbeere",
						Language.FRE => "Baie Parma",
						Language.ITA => "Baccaparmen",
						Language.SPN => "Baya Gualot",
						Language.KOR => "초나열매",
						Language.CHN_SIM => "烛木果",
						Language.CHN_TRA => "燭木果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WATMEL_BERRY:
					return lang switch {
						Language.ENG => "Watmel Berry",
						Language.JPN => "カイスのみ",
						Language.GER => "Wasmelbeere",
						Language.FRE => "Baie Stekpa",
						Language.ITA => "Baccacomero",
						Language.SPN => "Baya Sambia",
						Language.KOR => "슈박열매",
						Language.CHN_SIM => "瓜西果",
						Language.CHN_TRA => "瓜西果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WEPEAR_BERRY:
					return lang switch {
						Language.ENG => "Wepear Berry",
						Language.JPN => "セシナのみ",
						Language.GER => "Nirbebeere",
						Language.FRE => "Baie Repoi",
						Language.ITA => "Baccapera",
						Language.SPN => "Baya Peragu",
						Language.KOR => "서배열매",
						Language.CHN_SIM => "西梨果",
						Language.CHN_TRA => "西梨果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.WIKI_BERRY:
					return lang switch {
						Language.ENG => "Wiki Berry",
						Language.JPN => "ウイのみ",
						Language.GER => "Wikibeere",
						Language.FRE => "Baie Wiki",
						Language.ITA => "Baccakiwi",
						Language.SPN => "Baya Wiki",
						Language.KOR => "위키열매",
						Language.CHN_SIM => "异奇果",
						Language.CHN_TRA => "異奇果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				case Item.YACHE_BERRY:
					return lang switch {
						Language.ENG => "Yache Berry",
						Language.JPN => "ヤチェのみ",
						Language.GER => "Kiroyabeere",
						Language.FRE => "Baie Nanone",
						Language.ITA => "Baccamoya",
						Language.SPN => "Baya Rimoya",
						Language.KOR => "플카열매",
						Language.CHN_SIM => "番荔果",
						Language.CHN_TRA => "番荔果",
						_ => throw new LanguageNotRecognizedException(lang)
					};
				#endregion
			}
			throw new System.ArgumentException($"Item '{item}' not recognized.");
		}
	}
}