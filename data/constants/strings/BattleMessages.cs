namespace PkmnEngine.Strings {
	public static class BattleMessages {
		public static string gBattleMessageText(BattleMessage message, Language lang) {
			switch (message) {
				case BattleMessage.MON_USED_MOVE:
					return lang switch {
						Language.ENG => "\\$ used \\$!",
						Language.JPN => "\\$は\\$を{使|つか}った！",
						Language.GER => "\\$ setzten \\$ ein.",
						Language.FRE => "\\$ utilisent \\$!",
						Language.ITA => "\\$ usano \\$!",
						Language.SPN => "¡\\$ han usado \\$!",
						Language.KOR => "\\$ \\$ 썼다!",
						Language.CHN_SIM => "\\$使用了\\$！",
						Language.CHN_TRA => "\\$使用了\\$！",
						_ => throw new System.ArgumentException()
					};
				// TODO: This message is only for development testing.
				case BattleMessage.MON_TOOK_DAMAGE:
					return lang switch {
						Language.ENG => "\\$ took \\$ damage!",
						Language.JPN => "\\$ took \\$ damage!",
						Language.GER => "\\$ took \\$ damage!",
						Language.FRE => "\\$ took \\$ damage!",
						Language.ITA => "\\$ took \\$ damage!",
						Language.SPN => "\\$ took \\$ damage!",
						Language.KOR => "\\$ took \\$ damage!",
						Language.CHN_SIM => "\\$ took \\$ damage!",
						Language.CHN_TRA => "\\$ took \\$ damage!",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_RESTORED_HP:
					return lang switch {
						Language.ENG => "\\$ had its HP restored.",
						Language.JPN => "\\$の{体力|たいりょく}が{回復|かいふく}した！",
						Language.GER => "KP von \\$ wurden aufgefrischt!",
						Language.FRE => "\\$ récupère des PV !",
						Language.ITA => "\\$ ha recuperato dei PS!",
						Language.SPN => "¡\\$ ha recuperado PS!",
						Language.KOR => "\\$의 체력이 회복되었다!",
						Language.CHN_SIM => "\\$的体力回复了！",
						Language.CHN_TRA => "\\$的體力回復了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_FAINTED:
					return lang switch {
						Language.ENG => "\\$ fainted!",
						Language.JPN => "\\$はたおれた！",
						Language.GER => "\\$ wurde besiegt!",
						Language.FRE => "\\$ est K.O.!",
						Language.ITA => "\\$ non ha più energie!",
						Language.SPN => "¡\\$ se ha debilitado!",
						Language.KOR => "\\$ 쓰러졌다!",
						Language.CHN_SIM => "\\$倒下了！",
						Language.CHN_TRA => "\\$倒下了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.CRITICAL_HIT:
					return lang switch {
						Language.ENG => "A critical hit!",
						Language.JPN => "{急所|きゅうしょ}に{当|あ}たった！",
						Language.GER => "Ein Volltreffer!",
						Language.FRE => "Coup critique!",
						Language.ITA => "Brutto colpo!",
						Language.SPN => "¡Un golpe crítico!",
						Language.KOR => "급소에 맞았다!",
						Language.CHN_SIM => "击中了要害！",
						Language.CHN_TRA => "擊中了要害！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_AVOIDED_ATTACK:
					return lang switch {
						Language.ENG => "\\$ avoided the attack!",
						Language.JPN => "\\$には{当|あ}たらなかった！",
						Language.GER => "Die Attacke hat \\$ verfehlt!",
						Language.FRE => "\\$ évite l’attaque !",
						Language.ITA => "\\$ evita l’attacco!",
						Language.SPN => "¡\\$ ha evitado el ataque!",
						Language.KOR => "\\$에게는 맞지 않았다!",
						Language.CHN_SIM => "没有击中\\$！",
						Language.CHN_TRA => "沒有擊中\\$！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SUNLIGHT_BECAME_HARSH:
					return lang switch {
						Language.ENG => "The sunlight turned harsh!",
						Language.JPN => "{日差|ひざ}しが{強|つよ}くなった！",
						Language.GER => "Das Sonnenlicht wird stärker!",
						Language.FRE => "Les rayons du soleil brillent !",
						Language.ITA => "La luce solare diventa intensa!",
						Language.SPN => "¡El sol pega fuerte!",
						Language.KOR => "햇살이 강해졌다!",
						Language.CHN_SIM => "日照变强了！",
						Language.CHN_TRA => "日照變強了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STARTED_RAINING:
					return lang switch {
						Language.ENG => "It started to rain!",
						Language.JPN => "{雨|あめ}が{降|ふ}り{始|はじ}めた！",
						Language.GER => "Es fängt an zu regnen!",
						Language.FRE => "Il commence à pleuvoir !",
						Language.ITA => "Inizia a piovere!",
						Language.SPN => "¡Ha empezado a llover!",
						Language.KOR => "비가 내리기 시작했다!",
						Language.CHN_SIM => "开始下雨了！",
						Language.CHN_TRA => "開始下雨了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SANDSTORM_KICKED_UP:
					return lang switch {
						Language.ENG => "A sandstorm kicked up!",
						Language.JPN => "{砂|すな}あらしが{吹|ふ}き{始|はじ}めた！",
						Language.GER => "Ein Sandsturm kommt auf!",
						Language.FRE => "Une tempête de sable se prépare !",
						Language.ITA => "Inizia una tempesta di sabbia!",
						Language.SPN => "¡Se ha desatado una tormenta de arena!",
						Language.KOR => "모래바람이 불기 시작했다!",
						Language.CHN_SIM => "开始刮沙暴了！",
						Language.CHN_TRA => "開始刮沙暴了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STARTED_HAILING:
					return lang switch {
						Language.ENG => "It started to hail!",
						Language.JPN => "あられが{降|ふ}り{始|はじ}めた！",
						Language.GER => "Es fängt an zu hageln!",
						Language.FRE => "Il commence à grêler !",
						Language.ITA => "Inizia a grandinare!",
						Language.SPN => "¡Ha empezado a granizar!",
						Language.KOR => "싸라기눈이 내리기 시작했다!",
						Language.CHN_SIM => "开始下冰雹了！",
						Language.CHN_TRA => "開始下冰雹了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.FOG_CREPT_UP:
					return lang switch {
						Language.ENG => "Fog crept up as thick as soup!",
						Language.JPN => "{霧|きり}がただよいはじめた！",
						Language.GER => "Ein dichter Nebel breitet sich aus!",
						Language.FRE => "Le brouillard devient épais...",
						Language.ITA => "La nebbia comincia ad addensarsi!",
						Language.SPN => "¡La niebla empieza a cubrir la zona!",
						Language.KOR => "안개가 자욱이 끼기 시작했다!",
						Language.CHN_SIM => "开始起雾了！",
						Language.CHN_TRA => "開始起霧了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STARTED_SNOWING:
					return lang switch {
						Language.ENG => "It started to snow!",
						Language.JPN => "{雪|ゆき}が{降|ふ}り{始|はじ}めた！",
						Language.GER => "Es fängt an zu schneien!",
						Language.FRE => "Il commence à neiger !",
						Language.ITA => "Inizia a nevicare!",
						Language.SPN => "¡Ha empezado a nevar!",
						Language.KOR => "눈이 내리기 시작했다!",
						Language.CHN_SIM => "开始下雪了！",
						Language.CHN_TRA => "開始下雪了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SUNLIGHT_BECAME_EXTREMELY_HARSH:
					return lang switch {
						Language.ENG => "The sunlight turned extremely harsh!",
						Language.JPN => "{日差|ひざ}しがとても{強|つよ}くなった！",
						Language.GER => "Das Sonnenlicht wird sehr viel stärker!",
						Language.FRE => "Les rayons du soleil s’intensifient !",
						Language.ITA => "La luce solare diventa accecante!",
						Language.SPN => "¡El sol que hace ahora es realmente abrasador!",
						Language.KOR => "햇살이 아주 강해졌다!",
						Language.CHN_SIM => "日照变得非常强了！",
						Language.CHN_TRA => "日照變得非常強！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.HEAVY_RAIN_STARTED:
					return lang switch {
						Language.ENG => "A heavy rain began to fall!",
						Language.JPN => "{強|つよ}い{雨|あめ}が{降|ふ}り{始|はじ}めた！",
						Language.GER => "Es fängt an, in Strömen zu regnen!",
						Language.FRE => "Une pluie battante s’abat soudainement !",
						Language.ITA => "È scoppiato un acquazzone!",
						Language.SPN => "¡Ha empezado a diluviar!",
						Language.KOR => "강한 비가 내리기 시작했다!",
						Language.CHN_SIM => "开始下起了暴雨！",
						Language.CHN_TRA => "開始下起了暴雨！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MYSTERIOUS_WIND_APPEARED:
					return lang switch {
						Language.ENG => "Mysterious strong winds are protecting Flying-type Pokémon!",
						Language.JPN => "{謎|なぞ}の{乱気流|らんきりゅう}がひこうポケモンを{護|まも}る！",
						Language.GER => "Alle Flug-Pokémon werden von rätselhaften Luftströmungen geschützt!",
						Language.FRE => "Un vent mystérieux enveloppe les Pokémon de type Vol !",
						Language.ITA => "Una corrente d’aria misteriosa protegge i Pokémon di tipo Volante!",
						Language.SPN => "¡Las misteriosas turbulencias protegen a los Pokémon de tipo Volador!",
						Language.KOR => "수수께끼의 난기류가 비행포켓몬을 지킨다!",
						Language.CHN_SIM => "神秘的乱流保护着飞行属性宝可梦！",
						Language.CHN_TRA => "神秘的亂流保護著飛行屬性寶可夢！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SUNLIGHT_FADED:
					return lang switch {
						Language.ENG => "The harsh sunlight faded.",
						Language.JPN => "{日差|ひざ}しが{元|もと}に{戻|もど}った！",
						Language.GER => "Das Sonnenlicht verliert an Intensität!",
						Language.FRE => "Les rayons du soleil s’affaiblissent !",
						Language.ITA => "La luce solare torna normale!",
						Language.SPN => "¡El sol vuelve a brillar como siempre!",
						Language.KOR => "햇살이 원래대로 되돌아왔다!",
						Language.CHN_SIM => "日照复原了！",
						Language.CHN_TRA => "日照復原了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.RAIN_STOPPED:
					return lang switch {
						Language.ENG => "The rain stopped.",
						Language.JPN => "{雨|あめ}が{上|あ}がった！",
						Language.GER => "Es hört auf zu regnen!",
						Language.FRE => "La pluie s’est arrêtée !",
						Language.ITA => "Smette di piovere!",
						Language.SPN => "¡Ha dejado de llover!",
						Language.KOR => "비가 그쳤다!",
						Language.CHN_SIM => "雨停了！",
						Language.CHN_TRA => "雨停了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SANDSTORM_SUBSIDED:
					return lang switch {
						Language.ENG => "The sandstorm subsided.",
						Language.JPN => "{砂|すな}あらしがおさまった！",
						Language.GER => "Der Sandsturm legt sich!",
						Language.FRE => "La tempête de sable se calme !",
						Language.ITA => "La tempesta di sabbia cessa!",
						Language.SPN => "¡La tormenta de arena ha amainado!",
						Language.KOR => "모래바람이 가라앉았다!",
						Language.CHN_SIM => "沙暴停止了！",
						Language.CHN_TRA => "沙暴停止了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.HAIL_STOPPED:
					return lang switch {
						Language.ENG => "The hail stopped.",
						Language.JPN => "あられが{止|や}んだ！",
						Language.GER => "Es hört auf zu hageln!",
						Language.FRE => "La grêle s’est arrêtée !",
						Language.ITA => "Smette di grandinare!",
						Language.SPN => "¡Ha dejado de granizar!",
						Language.KOR => "싸라기눈이 그쳤다!",
						Language.CHN_SIM => "冰雹不下了！",
						Language.CHN_TRA => "冰雹不下了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.FOG_LIFTED:
					return lang switch {
						Language.ENG => "The fog lifted.",
						Language.JPN => "{霧|きり}が{晴|は}れた！",
						Language.GER => "Der Nebel verschwindet!",
						Language.FRE => "Le brouillard s’est dissipé !",
						Language.ITA => "La nebbia si dirada!",
						Language.SPN => "¡La niebla se ha disipado!",
						Language.KOR => "안개가 걷혔다!",
						Language.CHN_SIM => "雾散开了！",
						Language.CHN_TRA => "霧散開了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SNOW_STOPPED:
					return lang switch {
						Language.ENG => "The snow stopped.",
						Language.JPN => "{雪|ゆき}が{止|や}んだ！",
						Language.GER => "Es hört auf zu schneien!",
						Language.FRE => "La neige s’est arrêtée !",
						Language.ITA => "Smette di nevicare!",
						Language.SPN => "¡Ha dejado de nevar!",
						Language.KOR => "눈이 그쳤다!",
						Language.CHN_SIM => "雪停了！",
						Language.CHN_TRA => "雪不下了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EXTREME_SUNLIGHT_FADED:
					return lang switch {
						Language.ENG => "The extremely harsh sunlight faded.",
						Language.JPN => "{日差|ひざ}しが{元|もと}に{戻|もど}った！",
						Language.GER => "Das Sonnenlicht verliert an Intensität!",
						Language.FRE => "Les rayons du soleil s’affaiblissent !",
						Language.ITA => "La luce solare torna normale!",
						Language.SPN => "¡El sol vuelve a brillar como siempre!",
						Language.KOR => "햇살이 원래대로 되돌아왔다!",
						Language.CHN_SIM => "日照复原了！",
						Language.CHN_TRA => "日照復原了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.HEAVY_RAIN_STOPPED:
					return lang switch {
						Language.ENG => "The heavy rain has lifted!",
						Language.JPN => "{強|つよ}い{雨|あめ}があがった！",
						Language.GER => "Der strömende Regen hat aufgehört!",
						Language.FRE => "La pluie battante s’est arrêtée...",
						Language.ITA => "Smette di piovere!",
						Language.SPN => "Ha dejado de diluviar.",
						Language.KOR => "강한 비가 그쳤다!",
						Language.CHN_SIM => "暴雨停了！",
						Language.CHN_TRA => "暴雨停了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MYSTERIOUS_WIND_DISAPPEARED:
					return lang switch {
						Language.ENG => "The mysterious strong winds have dissipated!",
						Language.JPN => "{謎|なぞ}の{乱気流|らんきりゅう}がおさまった！",
						Language.GER => "Die rätselhaften Luftströmungen haben sich wieder gelegt!",
						Language.FRE => "Le vent mystérieux s’est dissipé...",
						Language.ITA => "La corrente d’aria misteriosa si placa!",
						Language.SPN => "Las misteriosas turbulencias han amainado.",
						Language.KOR => "수수께끼의 난기류가 가라앉았다!",
						Language.CHN_SIM => "神秘的乱流停止了！",
						Language.CHN_TRA => "神秘的亂流停止了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EXTREME_SUNLIGHT_NOT_LESSENED:
					return lang switch {
						Language.ENG => "The extremely harsh sunlight was not lessened at all!",
						Language.JPN => "{非常|ひじょう}に{厳|きび}しい{日差|ひざ}しはまったく{和|やわ}らいでいない！",
						Language.GER => "Das extrem harte Sonnenlicht wurde nicht im Geringsten gemildert!",
						Language.FRE => "La lumière extrêmement dure du soleil ne s'est pas atténuée du tout !",
						Language.ITA => "La luce del sole, estremamente intensa, non si è affatto attenuata!",
						Language.SPN => "La luz del sol, extremadamente dura, no disminuyó en absoluto.",
						Language.KOR => "극도로 강렬한 햇빛은 전혀 줄어들지 않았습니다!",
						Language.CHN_SIM => "极其刺眼的阳光却没有丝毫减弱！",
						Language.CHN_TRA => "極其刺眼的陽光卻沒有絲毫減弱！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.HEAVY_RAIN_NOT_LESSENED:
					return lang switch {
						Language.ENG => "There is no relief from this heavy rain!",
						Language.JPN => "この{大雨|おおあめ}から{解放|かいほう}されることはない！",
						Language.GER => "Es gibt keine Erleichterung bei diesem starken Regen!",
						Language.FRE => "Ces pluies diluviennes n'ont pas de répit !",
						Language.ITA => "Non c'è sollievo da questa pioggia battente!",
						Language.SPN => "Esta lluvia torrencial no da tregua.",
						Language.KOR => "이 폭우에 안심할 수 없습니다!",
						Language.CHN_SIM => "这场大雨丝毫没有缓解！",
						Language.CHN_TRA => "這場大雨絲毫沒有緩解！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STRONG_WINDS_NOT_LESSENED:
					return lang switch {
						Language.ENG => "The mysterious strong winds blow on regardless!",
						Language.JPN => "{謎|なぞ}の{強風|きょうふう}は{関係|かんけい}なく{吹|ふ}き{続|つづ}ける！",
						Language.GER => "Die mysteriösen starken Winde wehen trotzdem weiter!",
						Language.FRE => "Les mystérieux vents forts soufflent malgré tout !",
						Language.ITA => "I misteriosi e forti venti soffiano senza sosta!",
						Language.SPN => "Los fuertes vientos misteriosos soplan a pesar de todo.",
						Language.KOR => "신비한 강풍이 거침없이 불어옵니다!",
						Language.CHN_SIM => "神秘的强风不顾一切地吹来！",
						Language.CHN_TRA => "神秘的強風不顧一切地吹來！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_BURNED:
					return lang switch {
						Language.ENG => "\\$ was burned!",
						Language.JPN => "\\$はやけどを{負|お}った！",
						Language.GER => "\\$ erleidet Verbrennungen!",
						Language.FRE => "\\$ est brûlé!",
						Language.ITA => "\\$ è stato scottato!",
						Language.SPN => "¡\\$ se ha quemado!",
						Language.KOR => "\\$ 화상을 입었다!",
						Language.CHN_SIM => "\\$被灼伤了！",
						Language.CHN_TRA => "\\$被灼傷了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ALREADY_BURNED:
					return lang switch {
						Language.ENG => "\\$ is already burned!",
						Language.JPN => "\\$はすでにやけどを{負|お}っている",
						Language.GER => "\\$ leidet bereits unter Verbrennungen!",
						Language.FRE => "\\$ est déjà brûlé.",
						Language.ITA => "\\$ è già scottato.",
						Language.SPN => "¡\\$ ya está quemado!",
						Language.KOR => "\\$ 이미 화상을 입은 상태다.",
						Language.CHN_SIM => "\\$已经被灼伤了。",
						Language.CHN_TRA => "\\$已經被灼傷了。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CURED_OF_BURN:
					return lang switch {
						Language.ENG => "\\$’s burn was cured!",
						Language.JPN => "\\$のやけどが{治|なお}った！",
						Language.GER => "Die Verbrennungen von \\$ wurden geheilt!",
						Language.FRE => "\\$ n’est plus brûlé !",
						Language.ITA => "\\$ guarisce dalla scottatura!",
						Language.SPN => "¡\\$ ya no tiene quemaduras!",
						Language.KOR => "\\$의 화상이 나았다!",
						Language.CHN_SIM => "\\$的灼伤治愈了！",
						Language.CHN_TRA => "\\$的灼傷痊癒了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_FROZEN:
					return lang switch {
						Language.ENG => "\\$ was frozen solid!",
						Language.JPN => "\\$は{凍|こお}りついた！",
						Language.GER => "\\$ erstarrt zu Eis!",
						Language.FRE => "\\$ est gelé!",
						Language.ITA => "\\$ è stato congelato!",
						Language.SPN => "¡\\$ ha sido congelado!",
						Language.KOR => "\\$ 얼어붙었다!",
						Language.CHN_SIM => "\\$冻住了！",
						Language.CHN_TRA => "\\$凍住了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ALREADY_FROZEN:
					return lang switch {
						Language.ENG => "\\$ is already frozen solid!",
						Language.JPN => "\\$はすでに{凍|こお}っている",
						Language.GER => "\\$ ist bereits eingefroren!",
						Language.FRE => "\\$ est déjà gelé.",
						Language.ITA => "\\$ è già congelato.",
						Language.SPN => "¡\\$ ya está congelado!",
						Language.KOR => "\\$ 이미 얼어 있다.",
						Language.CHN_SIM => "\\$已经冻住了。",
						Language.CHN_TRA => "\\$已經凍住了。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_THAWED_OUT:
					return lang switch {
						Language.ENG => "\\$ thawed out!",
						Language.JPN => "\\$のこおりが{溶|と}けた！",
						Language.GER => "\\$ wurde aufgetaut!",
						Language.FRE => "\\$ n’est plus gelé!",
						Language.ITA => "\\$ non è più congelato!",
						Language.SPN => "¡\\$ ya no está congelado!",
						Language.KOR => "\\$의 얼음이 녹았다!",
						Language.CHN_SIM => "\\$的冰冻被融化了！",
						Language.CHN_TRA => "\\$的冰凍融化了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_PARALYZED:
					return lang switch {
						Language.ENG => "\\$ is paralyzed, so it may be unable to move!",
						Language.JPN => "\\$はまひして{技|わざ}がでにくくなった！",
						Language.GER => "\\$ ist paralysiert! Es kann eventuell nicht handeln!",
						Language.FRE => "\\$ est paralysé! Il aura du mal à attaquer!",
						Language.ITA => "\\$ è stato paralizzato! Forse non riuscirà ad agire!",
						Language.SPN => "¡\\$ sufre parálisis! Quizá no se pueda mover.",
						Language.KOR => "\\$ 마비되어 기술이 나오기 어려워졌다!",
						Language.CHN_SIM => "\\$麻痹了， 很难使出招式！",
						Language.CHN_TRA => "\\$麻痺了， 不易使出招式！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ALREADY_PARALYZED:
					return lang switch {
						Language.ENG => "\\$ is already paralyzed!",
						Language.JPN => "\\$はすでにまひしている",
						Language.GER => "\\$ ist bereits paralysiert!",
						Language.FRE => "\\$ est déjà paralysé.",
						Language.ITA => "\\$ è già paralizzato!",
						Language.SPN => "¡\\$ ya está paralizado!",
						Language.KOR => "\\$ 이미 마비되어 있다.",
						Language.CHN_SIM => "\\$已经麻痹了。",
						Language.CHN_TRA => "\\$已經麻痺了。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CURED_OF_PARALYSIS:
					return lang switch {
						Language.ENG => "\\$ was cured of paralysis!",
						Language.JPN => "\\$の{体|からだ}のしびれがとれた！",
						Language.GER => "\\$Die Paralyse von \\$ wurde aufgehoben!",
						Language.FRE => "\\$ n’est plus paralysé.",
						Language.ITA => "\\$ guarisce dalla paralisi.",
						Language.SPN => "\\$ se ha curado de la parálisis.",
						Language.KOR => "\\$의 몸저림이 풀렸다!",
						Language.CHN_SIM => "\\$身体的麻痹状态消除了！",
						Language.CHN_TRA => "\\$身上的麻痺解除了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_POISONED:
					return lang switch {
						Language.ENG => "\\$ was poisoned!",
						Language.JPN => "\\$に{毒|どく}をあびせた！",
						Language.GER => "\\$ wurde vergiftet!",
						Language.FRE => "\\$ est aspergé de poison!",
						Language.ITA => "\\$ viene cosparso di veleno!",
						Language.SPN => "¡\\$ ha resultado envenenado!",
						Language.KOR => "\\$에게 독을 퍼뜨렸다!",
						Language.CHN_SIM => "让\\$中毒了！",
						Language.CHN_TRA => "讓\\$中毒了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_BADLY_POISONED:
					return lang switch {
						Language.ENG => "\\$ was badly poisoned!",
						Language.JPN => "\\$は{猛毒|もうどく}をあびた！",
						Language.GER => "\\$ wurde schwer vergiftet!",
						Language.FRE => "\\$ est gravement empoisonné!",
						Language.ITA => "\\$ è stato iperavvelenato!",
						Language.SPN => "¡\\$ ha sido gravemente envenenado!",
						Language.KOR => "\\$의 몸에 맹독이 퍼졌다!",
						Language.CHN_SIM => "\\$中剧毒了！",
						Language.CHN_TRA => "\\$中劇毒了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ALREADY_POISONED:
					return lang switch {
						Language.ENG => "\\$ is already poisoned!",
						Language.JPN => "\\$はすでに{毒|どく}をあびている",
						Language.GER => "\\$ ist bereits vergiftet!",
						Language.FRE => "\\$ est déjà empoisonné.",
						Language.ITA => "\\$ è già avvelenato.",
						Language.SPN => "¡\\$ ya está envenenado!",
						Language.KOR => "\\$ 이미 몸에 독이 퍼진 상태다.",
						Language.CHN_SIM => "\\$已经中毒了。",
						Language.CHN_TRA => "\\$已經中毒了。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CURED_OF_POISON:
					return lang switch {
						Language.ENG => "\\$ was cured of its poisoning!",
						Language.JPN => "\\$のどくはきれいさっぱりなくなった！",
						Language.GER => "\\$Die Vergiftung von \\$ wurde geheilt!",
						Language.FRE => "\\$ n’est plus empoisonné.",
						Language.ITA => "\\$ guarisce dall’avvelenamento.",
						Language.SPN => "\\$ se ha curado del envenenamiento.",
						Language.KOR => "\\$의 독은 말끔하게 해독됐다!",
						Language.CHN_SIM => "\\$的毒消失得干干净净！",
						Language.CHN_TRA => "\\$中的毒消失得一乾二淨了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_FELL_ASLEEP:
					return lang switch {
						Language.ENG => "\\$ fell asleep!",
						Language.JPN => "\\$は{眠|ねむ}ってしまった！",
						Language.GER => "\\$ ist eingeschlafen!",
						Language.FRE => "\\$ s’est endormi!",
						Language.ITA => "\\$ si è addormentato!",
						Language.SPN => "¡\\$ se ha dormido!",
						Language.KOR => "\\$ 잠들어 버렸다!",
						Language.CHN_SIM => "\\$睡着了！",
						Language.CHN_TRA => "\\$睡著了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ALREADY_ASLEEP:
					return lang switch {
						Language.ENG => "\\$ is already asleep!",
						Language.JPN => "\\$はすでに{眠|ねむ}っている",
						Language.GER => "\\$ schläft bereits!",
						Language.FRE => "\\$ dort déjà.",
						Language.ITA => "\\$ sta già dormendo!",
						Language.SPN => "¡\\$ ya está dormido!",
						Language.KOR => "\\$ 이미 잠들어 있다.",
						Language.CHN_SIM => "\\$已经睡着了。",
						Language.CHN_TRA => "\\$已經睡著了。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WOKE_UP:
					return lang switch {
						Language.ENG => "\\$ woke up!",
						Language.JPN => "\\$は{目|め}を{覚|さ}ました！",
						Language.GER => "\\$ ist aufgewacht!",
						Language.FRE => "\\$ se réveille !",
						Language.ITA => "\\$ si è svegliato!",
						Language.SPN => "¡\\$ se ha despertado!",
						Language.KOR => "\\$ 눈을 떴다!",
						Language.CHN_SIM => "\\$醒过来了！",
						Language.CHN_TRA => "\\$醒過來了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_CONFUSED:
					return lang switch {
						Language.ENG => "\\$ became confused!",
						Language.JPN => "\\$は{混乱|こんらん}した！",
						Language.GER => "\\$ wurde verwirrt!",
						Language.FRE => "Ça rend \\$ confus!",
						Language.ITA => "\\$ entra in stato di confusione!",
						Language.SPN => "¡\\$ se ha quedado confuso!",
						Language.KOR => "\\$ 혼란에 빠졌다!",
						Language.CHN_SIM => "\\$混乱了！",
						Language.CHN_TRA => "\\$混亂了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ALREADY_CONFUSED:
					return lang switch {
						Language.ENG => "\\$ is already confused!",
						Language.JPN => "\\$はすでに{混乱|こんらん}している",
						Language.GER => "\\$ ist bereits verwirrt!",
						Language.FRE => "\\$ est déjà confus !",
						Language.ITA => "\\$ è già confuso!",
						Language.SPN => "¡\\$ ya está confuso!",
						Language.KOR => "\\$ 이미 혼란에 빠져 있다.",
						Language.CHN_SIM => "\\$已经混乱了。",
						Language.CHN_TRA => "\\$已經混亂了。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SNAPPED_OUT_OF_CONFUSION:
					return lang switch {
						Language.ENG => "\\$ snapped out of its confusion!",
						Language.JPN => "\\$の{混乱|こんらん}が{解|と}けた！",
						Language.GER => "\\$ ist nicht mehr verwirrt!",
						Language.FRE => "\\$ n’est plus confus!",
						Language.ITA => "\\$ non è più confuso!",
						Language.SPN => "¡\\$ ya no está confuso!",
						Language.KOR => "\\$의 혼란이 풀렸다!",
						Language.CHN_SIM => "\\$的混乱解除了！",
						Language.CHN_TRA => "\\$的 混亂解除了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SUPER_EFFECTIVE:
					return lang switch {
						Language.ENG => "It’s super effective!",
						Language.JPN => "{効果|こうか}はバツグンだ！",
						Language.GER => "Das ist sehr effektiv!",
						Language.FRE => "C’est super efficace!",
						Language.ITA => "È superefficace!",
						Language.SPN => "¡Es supereficaz!",
						Language.KOR => "효과가 굉장했다!",
						Language.CHN_SIM => "效果绝佳！",
						Language.CHN_TRA => "效果絕佳！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.NOT_VERY_EFFECTIVE:
					return lang switch {
						Language.ENG => "It’s not very effective...",
						Language.JPN => "{効果|こうか}は{今|いま}ひとつのようだ……",
						Language.GER => "Das ist nicht sehr effektiv...",
						Language.FRE => "Ce n’est pas très efficace...",
						Language.ITA => "Non è molto efficace...",
						Language.SPN => "No es muy eficaz...",
						Language.KOR => "효과가 별로인 듯하다...",
						Language.CHN_SIM => "好像效果不好……",
						Language.CHN_TRA => "好像效果不好……",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.IMMUNE:
					return lang switch {
						Language.ENG => "It doesn’t affect \\$...",
						Language.JPN => "\\$には{効果|こうか}がないようだ…",
						Language.GER => "Es hat keine Wirkung auf \\$...",
						Language.FRE => "Ça n’affecte pas \\$...",
						Language.ITA => "Non ha effetto su \\$...",
						Language.SPN => "No afecta a \\$...",
						Language.KOR => "\\$에게는 효과가 없는 것 같다...",
						Language.CHN_SIM => "对于\\$，好像没有效果……",
						Language.CHN_TRA => "對於\\$，好像沒有效果……",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.ATTACK_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s Attack rose!",
						Language.JPN => "\\$の{攻撃|こうげき}が{上|あ}がった！",
						Language.GER => "Angriff von \\$ steigt!",
						Language.FRE => "$L’Attaque \\$ augmente !",
						Language.ITA => "L’Attacco di \\$ aumenta!",
						Language.SPN => "¡El Ataque de \\$ ha aumentado!",
						Language.KOR => "\\$의 공격이 올라갔다!",
						Language.CHN_SIM => "\\$的攻击提高了！",
						Language.CHN_TRA => "\\$的攻擊提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ATTACK_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Attack rose sharply!",
						Language.JPN => "\\$の{攻撃|こうげき}がぐーんと{上|あ}がった！",
						Language.GER => "Angriff von \\$ steigt stark!",
						Language.FRE => "\\$L’Attaque \\$\\$ augmente beaucoup !",
						Language.ITA => "L’Attacco di \\$ aumenta di molto!",
						Language.SPN => "¡El Ataque de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 공격이 크게 올라갔다!",
						Language.CHN_SIM => "\\$的攻击大幅提高了！",
						Language.CHN_TRA => "\\$的攻擊大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ATTACK_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Attack rose drastically!",
						Language.JPN => "\\$の{攻撃|こうげき}がぐぐーんと{上|あ}がった！",
						Language.GER => "Angriff von \\$ steigt drastisch!",
						Language.FRE => "L’Attaque \\$ augmente énormément !",
						Language.ITA => "L’Attacco di \\$ aumenta moltissimo!",
						Language.SPN => "¡El Ataque de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 공격이 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的攻击巨幅提高了！",
						Language.CHN_TRA => "\\$的攻擊極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.DEFENSE_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s Defense rose!",
						Language.JPN => "\\$の{防御|ぼうぎょ}が{上|あ}がった！",
						Language.GER => "Verteidigung von \\$ steigt!",
						Language.FRE => "La Défense \\$ augmente !",
						Language.ITA => "La Difesa di \\$ aumenta!",
						Language.SPN => "¡La Defensa de \\$ ha aumentado!",
						Language.KOR => "\\$의 방어가 올라갔다!",
						Language.CHN_SIM => "\\$的防御提高了！",
						Language.CHN_TRA => "\\$的防禦提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.DEFENSE_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Defense rose sharply!",
						Language.JPN => "\\$の{防御|ぼうぎょ}がぐーんと{上|あ}がった！",
						Language.GER => "Verteidigung von \\$ steigt stark!",
						Language.FRE => "La Défense \\$ augmente beaucoup !",
						Language.ITA => "La Difesa di \\$ aumenta di molto!",
						Language.SPN => "¡La Defensa de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 방어가 크게 올라갔다!",
						Language.CHN_SIM => "\\$的防御大幅提高了！",
						Language.CHN_TRA => "\\$的防禦大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.DEFENSE_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Defense rose drastically!",
						Language.JPN => "\\$の{防御|ぼうぎょ}がぐぐーんと{上|あ}がった！",
						Language.GER => "Verteidigung von \\$ steigt drastisch!",
						Language.FRE => "La Défense \\$ augmente énormément !",
						Language.ITA => "La Difesa di \\$ aumenta moltissimo!",
						Language.SPN => "¡La Defensa de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 방어가 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的防御巨幅提高了！",
						Language.CHN_TRA => "\\$的防禦極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SPECIAL_ATTACK_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk rose!",
						Language.JPN => "\\$の{特攻|とくこう}が{上|あ}がった！",
						Language.GER => "Spezial-Angriff von \\$ steigt!",
						Language.FRE => "L’Attaque Spéciale \\$ augmente !",
						Language.ITA => "L’Attacco Speciale di \\$ aumenta!",
						Language.SPN => "¡El Ataque Especial de \\$ ha aumentado!",
						Language.KOR => "\\$의 특수공격이 올라갔다!",
						Language.CHN_SIM => "\\$的特攻提高了！",
						Language.CHN_TRA => "\\$的特攻提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_ATTACK_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk rose sharply!",
						Language.JPN => "\\$の{特攻|とくこう}がぐーんと{上|あ}がった！",
						Language.GER => "Spezial-Angriff von \\$ steigt stark!",
						Language.FRE => "L’Attaque Spéciale \\$ augmente beaucoup !",
						Language.ITA => "L’Attacco Speciale di \\$ aumenta di molto!",
						Language.SPN => "¡El Ataque Especial de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 특수공격이 크게 올라갔다!",
						Language.CHN_SIM => "\\$的特攻大幅提高了！",
						Language.CHN_TRA => "\\$的特攻大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_ATTACK_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk rose drastically!",
						Language.JPN => "\\$の{特攻|とくこう}がぐぐーんと{上|あ}がった！",
						Language.GER => "Spezial-Angriff von \\$ steigt drastisch!",
						Language.FRE => "L’Attaque Spéciale \\$ augmente énormément !",
						Language.ITA => "L’Attacco Speciale di \\$ aumenta moltissimo!",
						Language.SPN => "¡El Ataque Especial de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 특수공격이 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的特攻巨幅提高了！",
						Language.CHN_TRA => "\\$的特攻極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SPECIAL_DEFENSE_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def rose!",
						Language.JPN => "\\$の{特防|とくぼう}が{上|あ}がった！",
						Language.GER => "Spezial-Verteidigung von \\$ steigt!",
						Language.FRE => "La Défense Spéciale \\$ augmente !",
						Language.ITA => "La Difesa Speciale di \\$ aumenta!",
						Language.SPN => "¡La Defensa Especial de \\$ ha aumentado!",
						Language.KOR => "\\$의 특수방어가 올라갔다!",
						Language.CHN_SIM => "\\$的特防提高了！",
						Language.CHN_TRA => "\\$的特防提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_DEFENSE_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def rose sharply!",
						Language.JPN => "\\$の{特防|とくぼう}がぐーんと{上|あ}がった！",
						Language.GER => "Spezial-Verteidigung von \\$ steigt stark!",
						Language.FRE => "La Défense Spéciale \\$ augmente beaucoup !",
						Language.ITA => "La Difesa Speciale di \\$ aumenta di molto!",
						Language.SPN => "¡La Defensa Especial de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 특수방어가 크게 올라갔다!",
						Language.CHN_SIM => "\\$的特防大幅提高了！",
						Language.CHN_TRA => "\\$的特防大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_DEFENSE_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def rose drastically!",
						Language.JPN => "\\$の{特防|とくぼう}がぐぐーんと{上|あ}がった！",
						Language.GER => "Spezial-Verteidigung von \\$ steigt drastisch!",
						Language.FRE => "La Défense Spéciale \\$ augmente énormément !",
						Language.ITA => "La Difesa Speciale di \\$ aumenta moltissimo!",
						Language.SPN => "¡La Defensa Especial de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 특수방어가 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的特防巨幅提高了！",
						Language.CHN_TRA => "\\$的特防極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SPEED_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s Speed rose!",
						Language.JPN => "\\$の{素早|すばや}さが{上|あ}がった！",
						Language.GER => "Initiative von \\$ steigt!",
						Language.FRE => "La Vitesse \\$ augmente !",
						Language.ITA => "La Velocità di \\$ aumenta!",
						Language.SPN => "¡La Velocidad de \\$ ha aumentado!",
						Language.KOR => "\\$의 스피드가 올라갔다!",
						Language.CHN_SIM => "\\$的速度提高了！",
						Language.CHN_TRA => "\\$的速度提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPEED_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Speed rose sharply!",
						Language.JPN => "\\$の{素早|すばや}さがぐーんと{上|あ}がった！",
						Language.GER => "Initiative von \\$ steigt stark!",
						Language.FRE => "La Vitesse \\$ augmente beaucoup !",
						Language.ITA => "La Velocità di \\$ aumenta di molto!",
						Language.SPN => "¡La Velocidad de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 스피드가 크게 올라갔다!",
						Language.CHN_SIM => "\\$的速度大幅提高了！",
						Language.CHN_TRA => "\\$的速度大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPEED_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Speed rose drastically!",
						Language.JPN => "\\$の{素早|すばや}さがぐぐーんと{上|あ}がった！",
						Language.GER => "Initiative von \\$ steigt drastisch!",
						Language.FRE => "La Vitesse \\$ augmente énormément !",
						Language.ITA => "La Velocità di \\$ aumenta moltissimo!",
						Language.SPN => "¡La Velocidad de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 스피드가 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的速度巨幅提高了！",
						Language.CHN_TRA => "\\$的速度極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.ACCURACY_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s accuracy rose!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}が{上|あ}がった！",
						Language.GER => "Genauigkeit von \\$ steigt!",
						Language.FRE => "La Précision \\$ augmente !",
						Language.ITA => "La precisione di \\$ aumenta!",
						Language.SPN => "¡La Precisión de \\$ ha aumentado!",
						Language.KOR => "\\$의 명중률이 올라갔다!",
						Language.CHN_SIM => "\\$的命中率提高了！",
						Language.CHN_TRA => "\\$的命中率提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ACCURACY_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s accuracy rose sharply!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}がぐーんと{上|あ}がった！",
						Language.GER => "Genauigkeit von \\$ steigt stark!",
						Language.FRE => "La Précision \\$ augmente beaucoup !",
						Language.ITA => "La precisione di \\$ aumenta di molto!",
						Language.SPN => "¡La Precisión de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 명중률이 크게 올라갔다!",
						Language.CHN_SIM => "\\$的命中率大幅提高了！",
						Language.CHN_TRA => "\\$的命中率大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ACCURACY_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s accuracy rose drastically!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}がぐぐーんと{上|あ}がった！",
						Language.GER => "Genauigkeit von \\$ steigt drastisch!",
						Language.FRE => "La Précision \\$ augmente énormément !",
						Language.ITA => "La precisione di \\$ aumenta moltissimo!",
						Language.SPN => "¡La Precisión de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 명중률이 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的命中率巨幅提高了！",
						Language.CHN_TRA => "\\$的命中率極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.EVASION_INCREASED:
					return lang switch {
						Language.ENG => "\\$’s evasiveness rose!",
						Language.JPN => "\\$の{回避率|かいひりつ}が{上|あ}がった！",
						Language.GER => "Ausweichwert von \\$ steigt!",
						Language.FRE => "L’Esquive \\$ augmente !",
						Language.ITA => "L’elusione di \\$ aumenta!",
						Language.SPN => "¡La Evasión de \\$ ha aumentado!",
						Language.KOR => "\\$의 회피율이 올라갔다!",
						Language.CHN_SIM => "\\$的闪避率提高了！",
						Language.CHN_TRA => "\\$的閃避率提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EVASION_INCREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s evasiveness rose sharply!",
						Language.JPN => "\\$の{回避率|かいひりつ}がぐーんと{上|あ}がった！",
						Language.GER => "Ausweichwert von \\$ steigt stark!",
						Language.FRE => "L’Esquive \\$ augmente beaucoup !",
						Language.ITA => "L’elusione di \\$ aumenta di molto!",
						Language.SPN => "¡La Evasión de \\$ ha aumentado mucho!",
						Language.KOR => "\\$의 회피율이 크게 올라갔다!",
						Language.CHN_SIM => "\\$的闪避率大幅提高了！",
						Language.CHN_TRA => "\\$的閃避率大幅提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EVASION_INCREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s evasiveness rose drastically!",
						Language.JPN => "\\$の{回避率|かいひりつ}がぐぐーんと{上|あ}がった！",
						Language.GER => "Ausweichwert von \\$ steigt drastisch!",
						Language.FRE => "L’Esquive \\$ augmente énormément !",
						Language.ITA => "L’elusione di \\$ aumenta moltissimo!",
						Language.SPN => "¡La Evasión de \\$ ha aumentado muchísimo!",
						Language.KOR => "\\$의 회피율이 매우 크게 올라갔다!",
						Language.CHN_SIM => "\\$的闪避率巨幅提高了！",
						Language.CHN_TRA => "\\$的閃避率極大幅提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.ATTACK_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s Attack fell!",
						Language.JPN => "\\$の{攻撃|こうげき}が{下|さ}がった！",
						Language.GER => "Angriff von \\$ sinkt!",
						Language.FRE => "L’Attaque \\$ baisse !",
						Language.ITA => "L’Attacco di \\$ diminuisce!",
						Language.SPN => "¡El Ataque de \\$ ha disminuido!",
						Language.KOR => "\\$의 공격이 떨어졌다!",
						Language.CHN_SIM => "\\$的攻击降低了！",
						Language.CHN_TRA => "\\$的攻擊降低了！\\$’s Attack harshly fell!",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ATTACK_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Attack harshly fell!",
						Language.JPN => "\\$の{攻撃|こうげき}ががくっと{下|さ}がった！",
						Language.GER => "Angriff von \\$ sinkt stark!",
						Language.FRE => "L’Attaque \\$ baisse beaucoup !",
						Language.ITA => "L’Attacco di \\$ diminuisce di molto!",
						Language.SPN => "¡El Ataque de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 공격이 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的攻击大幅降低了！",
						Language.CHN_TRA => "\\$的攻擊大幅降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ATTACK_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Attack severely fell!",
						Language.JPN => "\\$の{攻撃|こうげき}ががくーんと{下|さ}がった！",
						Language.GER => "Angriff von \\$ sinkt drastisch!",
						Language.FRE => "L’Attaque \\$ baisse énormément !",
						Language.ITA => "L’Attacco di \\$ cala drasticamente!",
						Language.SPN => "¡El Ataque de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 공격이 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的攻击巨幅降低了！",
						Language.CHN_TRA => "\\$的攻擊極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.DEFENSE_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s Defense fell!",
						Language.JPN => "\\$の{防御|ぼうぎょ}が{下|さ}がった！",
						Language.GER => "Verteidigung von \\$ sinkt!",
						Language.FRE => "La Défense \\$ baisse !",
						Language.ITA => "La Difesa di \\$ diminuisce!",
						Language.SPN => "¡La Defensa de \\$ ha disminuido!",
						Language.KOR => "\\$의 방어가 떨어졌다!",
						Language.CHN_SIM => "\\$的防御降低了！",
						Language.CHN_TRA => "\\$的防禦降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.DEFENSE_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Defense harshly fell!",
						Language.JPN => "\\$の{防御|ぼうぎょ}ががくっと{下|さ}がった！",
						Language.GER => "Verteidigung von \\$ sinkt stark!",
						Language.FRE => "La Défense \\$ baisse beaucoup !",
						Language.ITA => "La Difesa di \\$ diminuisce di molto!",
						Language.SPN => "¡La Defensa de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 방어가 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的防御大幅降低了！",
						Language.CHN_TRA => "\\$的防禦大幅降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.DEFENSE_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Defense severely fell!",
						Language.JPN => "\\$の{防御|ぼうぎょ}ががくーんと{下|さ}がった！",
						Language.GER => "Verteidigung von \\$ sinkt drastisch!",
						Language.FRE => "La Défense \\$ baisse énormément !",
						Language.ITA => "La Difesa di \\$ cala drasticamente!",
						Language.SPN => "¡La Defensa de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 방어가 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的防御巨幅降低了！",
						Language.CHN_TRA => "\\$的防禦極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SPECIAL_ATTACK_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk fell!",
						Language.JPN => "\\$の{特攻|とくこう}が{下|さ}がった！",
						Language.GER => "Spezial-Angriff von \\$ sinkt!",
						Language.FRE => "L’Attaque Spéciale \\$ baisse !",
						Language.ITA => "L’Attacco Speciale di \\$ diminuisce!",
						Language.SPN => "¡El Ataque Especial de \\$ ha disminuido!",
						Language.KOR => "\\$의 특수공격이 떨어졌다!",
						Language.CHN_SIM => "\\$的特攻降低了！",
						Language.CHN_TRA => "\\$的特攻降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_ATTACK_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk harshly fell!",
						Language.JPN => "\\$の{特攻|とくこう}ががくっと{下|さ}がった！",
						Language.GER => "Spezial-Angriff von \\$ sinkt stark!",
						Language.FRE => "L’Attaque Spéciale \\$ baisse beaucoup !",
						Language.ITA => "L’Attacco Speciale di \\$ diminuisce di molto!",
						Language.SPN => "¡El Ataque Especial de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 특수공격이 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的特攻大幅降低了！",
						Language.CHN_TRA => "\\$的特攻大幅降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_ATTACK_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk severely fell!",
						Language.JPN => "\\$の{特攻|とくこう}ががくーんと{下|さ}がった！",
						Language.GER => "Spezial-Angriff von \\$ sinkt drastisch!",
						Language.FRE => "L’Attaque Spéciale \\$ baisse énormément !",
						Language.ITA => "L’Attacco Speciale di \\$ cala drasticamente!",
						Language.SPN => "¡El Ataque Especial de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 특수공격이 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的特攻巨幅降低了！",
						Language.CHN_TRA => "\\$的特攻極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SPECIAL_DEFENSE_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def fell!",
						Language.JPN => "\\$の{特防|とくぼう}が{下|さ}がった！",
						Language.GER => "Spezial-Verteidigung von \\$ sinkt!",
						Language.FRE => "La Défense Spéciale \\$ baisse !",
						Language.ITA => "La Difesa Speciale di \\$ diminuisce!",
						Language.SPN => "¡La Defensa Especial de \\$ ha disminuido!",
						Language.KOR => "\\$의 특수방어가 떨어졌다!",
						Language.CHN_SIM => "\\$的特防降低了！",
						Language.CHN_TRA => "\\$的特防降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_DEFENSE_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def harshly fell!",
						Language.JPN => "\\$の{特防|とくぼう}ががくっと{下|さ}がった！",
						Language.GER => "Spezial-Verteidigung von \\$ sinkt stark!",
						Language.FRE => "La Défense Spéciale \\$ baisse beaucoup !",
						Language.ITA => "La Difesa Speciale di \\$ diminuisce di molto!",
						Language.SPN => "¡La Defensa Especial de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 특수방어가 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的特防大幅降低了！",
						Language.CHN_TRA => "\\$的特防大幅降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_DEFENSE_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def severely fell!",
						Language.JPN => "\\$の{特防|とくぼう}ががくーんと{下|さ}がった！",
						Language.GER => "Spezial-Verteidigung von \\$ sinkt drastisch!",
						Language.FRE => "La Défense Spéciale \\$ baisse énormément !",
						Language.ITA => "La Difesa Speciale di \\$ cala drasticamente!",
						Language.SPN => "¡La Defensa Especial de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 특수방어가 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的特防巨幅降低了！",
						Language.CHN_TRA => "\\$的特防極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.SPEED_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s Speed fell!",
						Language.JPN => "\\$の{素早|すばや}さが{下|さ}がった！",
						Language.GER => "Initiative von \\$ sinkt!",
						Language.FRE => "La Vitesse \\$ baisse !",
						Language.ITA => "La Velocità di \\$ diminuisce!",
						Language.SPN => "¡La Velocidad de \\$ ha disminuido!",
						Language.KOR => "\\$의 스피드가 떨어졌다!",
						Language.CHN_SIM => "\\$的速度降低了！",
						Language.CHN_TRA => "\\$的速度降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPEED_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s Speed harshly fell!",
						Language.JPN => "\\$の{素早|すばや}さががくっと{下|さ}がった！",
						Language.GER => "Initiative von \\$ sinkt stark!",
						Language.FRE => "La Vitesse \\$ baisse beaucoup !",
						Language.ITA => "La Velocità di \\$ diminuisce di molto!",
						Language.SPN => "¡La Velocidad de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 스피드가 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的速度大幅降低了！",
						Language.CHN_TRA => "\\$的速度大幅降低了",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPEED_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s Speed severely fell!",
						Language.JPN => "\\$の{素早|すばや}さががくーんと{下|さ}がった！",
						Language.GER => "Initiative von \\$ sinkt drastisch!",
						Language.FRE => "La Vitesse \\$ baisse énormément !",
						Language.ITA => "La Velocità di \\$ cala drasticamente!",
						Language.SPN => "¡La Velocidad de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 스피드가 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的速度巨幅降低了！",
						Language.CHN_TRA => "\\$的速度極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.ACCURACY_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s accuracy fell!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}が{下|さ}がった！",
						Language.GER => "Genauigkeit von \\$ sinkt!",
						Language.FRE => "La Précision \\$ baisse !",
						Language.ITA => "La precisione di \\$ diminuisce!",
						Language.SPN => "¡La Precisión de \\$ ha disminuido!",
						Language.KOR => "\\$의 명중률이 떨어졌다!",
						Language.CHN_SIM => "\\$的命中率降低了！",
						Language.CHN_TRA => "\\$的命中率降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ACCURACY_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s accuracy harshly fell!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}ががくっと{下|さ}がった！",
						Language.GER => "Genauigkeit von \\$ sinkt stark!",
						Language.FRE => "La Précision \\$ baisse beaucoup !",
						Language.ITA => "La precisione di \\$ diminuisce di molto!",
						Language.SPN => "¡La Precisión de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 명중률이 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的命中率大幅降低了！",
						Language.CHN_TRA => "\\$的命中率大幅降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ACCURACY_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s accuracy severely fell!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}ががくーんと{下|さ}がった！",
						Language.GER => "Genauigkeit von \\$ sinkt drastisch!",
						Language.FRE => "La Précision \\$ baisse énormément !",
						Language.ITA => "La precisione di \\$ cala drasticamente!",
						Language.SPN => "¡La Precisión de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 명중률이 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的命中率巨幅降低了！",
						Language.CHN_TRA => "\\$的命中率極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.EVASION_DECREASED:
					return lang switch {
						Language.ENG => "\\$’s evasiveness fell!",
						Language.JPN => "\\$の{回避率|かいひりつ}が{下|さ}がった！",
						Language.GER => "Ausweichwert von \\$ sinkt!",
						Language.FRE => "L’Esquive \\$ baisse !",
						Language.ITA => "L’elusione di \\$ diminuisce!",
						Language.SPN => "¡La Evasión de \\$ ha disminuido!",
						Language.KOR => "\\$의 회피율이 떨어졌다!",
						Language.CHN_SIM => "\\$的闪避率降低了！",
						Language.CHN_TRA => "\\$的閃避率降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EVASION_DECREASED_SHARPLY:
					return lang switch {
						Language.ENG => "\\$’s evasiveness harshly fell!",
						Language.JPN => "\\$の{回避率|かいひりつ}ががくっと{下|さ}がった！",
						Language.GER => "Ausweichwert von \\$ sinkt stark!",
						Language.FRE => "L’Esquive \\$ baisse beaucoup !",
						Language.ITA => "L’elusione di \\$ diminuisce di molto!",
						Language.SPN => "¡La Evasión de \\$ ha disminuido mucho!",
						Language.KOR => "\\$의 회피율이 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的闪避率大幅降低了！",
						Language.CHN_TRA => "\\$的閃避率大幅降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EVASION_DECREASED_DRASTICALLY:
					return lang switch {
						Language.ENG => "\\$’s evasiveness severely fell!",
						Language.JPN => "\\$の{回避率|かいひりつ}ががくーんと{下|さ}がった！",
						Language.GER => "Ausweichwert von \\$ sinkt drastisch!",
						Language.FRE => "L’Esquive \\$ baisse énormément !",
						Language.ITA => "L’elusione di \\$ cala drasticamente!",
						Language.SPN => "¡La Evasión de \\$ ha disminuido muchísimo!",
						Language.KOR => "\\$의 회피율이 매우 크게 떨어졌다!",
						Language.CHN_SIM => "\\$的闪避率巨幅降低了！",
						Language.CHN_TRA => "\\$的閃避率極大幅降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.ATTACK_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s Attack won’t go any higher!",
						Language.JPN => "\\$の{攻撃|こうげき}はもう{上|あ}がらない！",
						Language.GER => "Angriff von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "L’Attaque \\$ ne peut plus augmenter !",
						Language.ITA => "L’Attacco di \\$ non può aumentare di più!",
						Language.SPN => "¡El Ataque de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 공격은 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的攻击已经无法再提高了！",
						Language.CHN_TRA => "\\$的攻擊已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.DEFENSE_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s Defense won’t go any higher!",
						Language.JPN => "\\$の{防御|ぼうぎょ}はもう{上|あ}がらない！",
						Language.GER => "Verteidigung von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "La Défense \\$ ne peut plus augmenter !",
						Language.ITA => "La Difesa di \\$ non può aumentare di più!",
						Language.SPN => "¡La Defensa de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 방어는 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的防御已经无法再提高了！",
						Language.CHN_TRA => "\\$的防禦已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_ATTACK_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk won’t go any higher!",
						Language.JPN => "\\$の{特攻|とくこう}はもう{上|あ}がらない！",
						Language.GER => "Spezial-Angriff von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "L’Attaque Spéciale \\$ ne peut plus augmenter !",
						Language.ITA => "L’Attacco Speciale di \\$ non può aumentare di più!",
						Language.SPN => "¡El Ataque Especial de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 특수공격은 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的特攻已经无法再提高了！",
						Language.CHN_TRA => "\\$的特攻已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_DEFENSE_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def won’t go any higher!",
						Language.JPN => "\\$の{特防|とくぼう}はもう{上|あ}がらない！",
						Language.GER => "Spezial-Verteidigung von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "La Défense Spéciale \\$ ne peut plus augmenter !",
						Language.ITA => "La Difesa Speciale di \\$ non può aumentare di più!",
						Language.SPN => "¡La Defensa Especial de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 특수방어는 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的特防已经无法再提高了！",
						Language.CHN_TRA => "\\$的特防已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPEED_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s Speed won’t go any higher!",
						Language.JPN => "\\$の{素早|すばや}さはもう{上|あ}がらない！",
						Language.GER => "Initiative von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "La Vitesse \\$ ne peut plus augmenter !",
						Language.ITA => "La Velocità di \\$ non può aumentare di più!",
						Language.SPN => "¡La Velocidad de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 스피드는 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的速度已经无法再提高了！",
						Language.CHN_TRA => "\\$的速度已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ACCURACY_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s accuracy won’t go any higher!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}はもう{上|あ}がらない！",
						Language.GER => "Genauigkeit von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "La Précision \\$ ne peut plus augmenter !",
						Language.ITA => "La precisione di \\$ non può aumentare di più!",
						Language.SPN => "¡La Precisión de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 명중률은 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的命中率已经无法再提高了！",
						Language.CHN_TRA => "\\$的命中率已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EVASION_AT_MAX:
					return lang switch {
						Language.ENG => "\\$’s evasiveness won’t go any higher!",
						Language.JPN => "\\$の{回避率|かいひりつ}はもう{上|あ}がらない！",
						Language.GER => "Ausweichwert von \\$ kann nicht weiter erhöht werden!",
						Language.FRE => "L’Esquive \\$ ne peut plus augmenter !",
						Language.ITA => "L’elusione di \\$ non può aumentare di più!",
						Language.SPN => "¡La Evasión de \\$ no puede aumentar más!",
						Language.KOR => "\\$의 회피율은 더 올라가지 않는다!",
						Language.CHN_SIM => "\\$的闪避率已经无法再提高了！",
						Language.CHN_TRA => "\\$的閃避率已經無法再提高了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.ATTACK_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s Attack won’t go any lower!",
						Language.JPN => "\\$の{攻撃|こうげき}はもう{下|さ}がらない！",
						Language.GER => "Angriff von \\$ kann nicht weiter sinken!",
						Language.FRE => "L’Attaque \\$ ne peut plus baisser !",
						Language.ITA => "L’Attacco di \\$ non può diminuire di più!",
						Language.SPN => "¡El Ataque de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 공격은 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的攻击已经无法再降低了！",
						Language.CHN_TRA => "\\$的攻擊已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.DEFENSE_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s Defense won’t go any lower!",
						Language.JPN => "\\$の{防御|ぼうぎょ}はもう{下|さ}がらない！",
						Language.GER => "Verteidigung von \\$ kann nicht weiter sinken!",
						Language.FRE => "La Défense \\$ ne peut plus baisser !",
						Language.ITA => "La Difesa di \\$ non può diminuire di più!",
						Language.SPN => "¡La Defensa de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 방어는 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的防御已经无法再降低了！",
						Language.CHN_TRA => "\\$的防禦已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_ATTACK_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s Sp. Atk won’t go any lower!",
						Language.JPN => "\\$の{特攻|とくこう}はもう{下|さ}がらない！",
						Language.GER => "Spezial-Angriff von \\$ kann nicht weiter sinken!",
						Language.FRE => "L’Attaque Spéciale \\$ ne peut plus baisser !",
						Language.ITA => "L’Attacco Speciale di \\$ non può diminuire di più!",
						Language.SPN => "¡El Ataque Especial de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 특수공격은 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的特攻已经无法再降低了！",
						Language.CHN_TRA => "\\$的特攻已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPECIAL_DEFENSE_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s Sp. Def won’t go any lower!",
						Language.JPN => "\\$の{特防|とくぼう}はもう{下|さ}がらない！",
						Language.GER => "Spezial-Verteidigung von \\$ kann nicht weiter sinken!",
						Language.FRE => "La Défense Spéciale \\$ ne peut plus baisser !",
						Language.ITA => "La Difesa Speciale di \\$ non può diminuire di più!",
						Language.SPN => "¡La Defensa Especial de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 특수방어는 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的特防已经无法再降低了！",
						Language.CHN_TRA => "\\$的特防已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SPEED_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s Speed won’t go any lower!",
						Language.JPN => "\\$の{素早|すばや}さはもう{下|さ}がらない！",
						Language.GER => "Initiative von \\$ kann nicht weiter sinken!",
						Language.FRE => "La Vitesse \\$ ne peut plus baisser !",
						Language.ITA => "La Velocità di \\$ non può diminuire di più!",
						Language.SPN => "¡La Velocidad de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 스피드는 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的速度已经无法再降低了！",
						Language.CHN_TRA => "\\$的速度已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ACCURACY_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s accuracy won’t go any lower!",
						Language.JPN => "\\$の{命中率|めいちゅうりつ}はもう{下|さ}がらない！",
						Language.GER => "Genauigkeit von \\$ kann nicht weiter sinken!",
						Language.FRE => "La Précision \\$ ne peut plus baisser !",
						Language.ITA => "La precisione di \\$ non può diminuire di più!",
						Language.SPN => "¡La Precisión de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 명중률은 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的命中率已经无法再降低了！",
						Language.CHN_TRA => "\\$的命中率已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.EVASION_AT_MIN:
					return lang switch {
						Language.ENG => "\\$’s evasiveness won’t go any lower!",
						Language.JPN => "\\$の{回避率|かいひりつ}はもう{下|さ}がらない！",
						Language.GER => "Ausweichwert von \\$ kann nicht weiter sinken!",
						Language.FRE => "L’Esquive \\$ ne peut plus baisser !",
						Language.ITA => "L’elusione di \\$ non può diminuire di più!",
						Language.SPN => "¡La Evasión de \\$ no puede disminuir más!",
						Language.KOR => "\\$의 회피율은 더 떨어지지 않는다!",
						Language.CHN_SIM => "\\$的闪避率已经无法再降低了！",
						Language.CHN_TRA => "\\$的閃避率已經無法再降低了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.MOVE_FAILED:
					return lang switch {
						Language.ENG => "But it failed!",
						Language.JPN => "しかしうまく{決|き}まらなかった！！",
						Language.GER => "Es ist fehlgeschlagen!",
						Language.FRE => "Mais cela échoue !",
						Language.ITA => "Ma fallisce!",
						Language.SPN => "¡Pero ha fallado!",
						Language.KOR => "그러나 실패하고 말았다!!",
						Language.CHN_SIM => "但是，没有起到效果！！",
						Language.CHN_TRA => "但是，沒有效果！！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_USE_MOVE:
					return lang switch {
						Language.ENG => "\\$ cannot use \\$!",
						Language.JPN => "\\$は\\$を{使|つか}えない！",
						Language.GER => "\\$ kann \\$ nicht einsetzen!",
						Language.FRE => "\\$ ne peut pas utiliser la capacité \\$ !",
						Language.ITA => "\\$ non può usare \\$!",
						Language.SPN => "¡\\$ no puede usar \\$!",
						Language.KOR => "\\$ \\$ 쓸 수 없다!",
						Language.CHN_SIM => "\\$无法使用\\$！",
						Language.CHN_TRA => "\\$無法使用\\$！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.STAT_CHANGES_ELIMINATED:
					return lang switch {
						Language.ENG => "All stat changes were eliminated!",
						Language.JPN => "{全|すべ}てのステータスが{元|もと}に{戻|もど}った！",
						Language.GER => "Alle Statusveränderungen wurden aufgehoben!",
						Language.FRE => "Les changements de stats ont tous été annulés !",
						Language.ITA => "Tutte le modifiche alle statistiche sono state annullate!",
						Language.SPN => "¡Se han anulado todos los cambios en las características!",
						Language.KOR => "모든 상태가 원래대로 되돌아왔다!",
						Language.CHN_SIM => "所有能力都复原了！",
						Language.CHN_TRA => "所有能力都復原了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STAT_CHANGES_REMOVED:
					return lang switch {
						Language.ENG => "\\$’s stat changes were removed!",
						Language.JPN => "\\$の{能力変化|のうりょくへんか}が{元|もと}に{戻|もど}った！",
						Language.GER => "Die Statusveränderungen von \\$ wurden aufgehoben!",
						Language.FRE => "\\$Les stats \\$ sont revenues à la normale !",
						Language.ITA => "Le statistiche di \\$ tornano alla normalità!",
						Language.SPN => "\\$¡Las características de \\$ han vuelto a sus valores originales!",
						Language.KOR => "\\$의 능력 변화가 원래대로 되돌아왔다!",
						Language.CHN_SIM => "\\$的能力变化消失了！",
						Language.CHN_TRA => "\\$的能力變化解除了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STAT_CHANGES_INVERTED:
					return lang switch {
						Language.ENG => "All stat changes on \\$ were inverted!",
						Language.JPN => "\\$は{能力変化|のうりょくへんか}がひっくりかえった！",
						Language.GER => "Alle Statusveränderungen von \\$ wurden invertiert!",
						Language.FRE => "\\$Les changements de stats \\$ sont inversés !",
						Language.ITA => "Le modifiche alle statistiche di \\$ vengono invertite!",
						Language.SPN => "¡Se han invertido los cambios en las características de \\$!",
						Language.KOR => "\\$ 능력 변화가 뒤집혔다!",
						Language.CHN_SIM => "\\$的能力变化颠倒过来了！",
						Language.CHN_TRA => "\\$的能力變化顛倒過來了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.HIT_N_TIMES:
					return lang switch {
						Language.ENG => "The Pokémon was hit \\$ times!",
						Language.JPN => "\\${回|かい}{当|あ}たった！",
						Language.GER => "\\$-mal getroffen!",
						Language.FRE => "Touché \\$ fois !",
						Language.ITA => "Colpi inflitti: \\$!",
						Language.SPN => "N.º de golpes: \\$.",
						Language.KOR => "\\$번 맞았다!",
						Language.CHN_SIM => "击中了\\$次！",
						Language.CHN_TRA => "擊中了\\$次！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_FLINCHED:
					return lang switch {
						Language.ENG => "\\$ flinched and couldn’t move!",
						Language.JPN => "\\$はひるんで{技|わざ}がだせない！",
						Language.GER => "\\$ ist zurückgeschreckt und kann nicht handeln!",
						Language.FRE => "\\$ a la trouille ! Il ne peut plus attaquer !",
						Language.ITA => "\\$ tentenna! Non può agire!",
						Language.SPN => "¡\\$ se ha amedrentado y no puede lanzar ningún ataque!",
						Language.KOR => "\\$ 풀이 죽어 기술을 쓸 수 없다!",
						Language.CHN_SIM => "\\$畏缩了，无法使出招式！",
						Language.CHN_TRA => "\\$畏縮了，無法使出招式！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_TRAPPED_MON:
					return lang switch {
						Language.ENG => "\\$ trapped \\$!",
						Language.JPN => "\\$は\\$に{閉|と}じこめられた！",
						Language.GER => "\\$ hat \\$ eingesperrt!",
						Language.FRE => "\\$ se fait emprisonner par \\$ !",
						Language.ITA => "\\$ intrappola \\$!",
						Language.SPN => "¡\\$ ha enjaulado a \\$!",
						Language.KOR => "\\$ \\$ 가두었다!",
						Language.CHN_SIM => "\\$被\\$困住了！",
						Language.CHN_TRA => "\\$被\\$困住了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CAN_NO_LONGER_ESCAPE:
					return lang switch {
						Language.ENG => "\\$ can no longer escape!",
						Language.JPN => "\\$はもう{逃|に}げられない！",
						Language.GER => "\\$ kann nicht mehr fliehen!",
						Language.FRE => "\\$ ne peut plus s’échapper !",
						Language.ITA => "\\$ non può più scappare!",
						Language.SPN => "¡\\$ ya no puede escapar!",
						Language.KOR => "\\$ 이제 도망칠 수 없다!",
						Language.CHN_SIM => "\\$已经无法逃走了！",
						Language.CHN_TRA => "\\$已經無法逃走了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HAVING_NIGHTMARE:
					return lang switch {
						Language.ENG => "\\$ began having a nightmare!",
						Language.JPN => "\\$は{悪夢|あくむ}を{見始|みはじ}めた！",
						Language.GER => "Nachtmahr sucht \\$ heim!",
						Language.FRE => "\\$ commence à cauchemarder !",
						Language.ITA => "\\$ ha un incubo!",
						Language.SPN => "¡\\$ se ha sumido en una pesadilla!",
						Language.KOR => "\\$ 악몽을 꾸기 시작했다!",
						Language.CHN_SIM => "\\$开始做恶梦了！",
						Language.CHN_TRA => "\\$開始做惡夢了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_LOCKED_IN_NIGHTMARE:
					return lang switch {
						Language.ENG => "\\$ is locked in a nightmare!",
						Language.JPN => "\\$は{悪夢|あくむ}にうなされている！",
						Language.GER => "Nachtmahr schadet \\$!",
						Language.FRE => "\\$ est prisonnier d’un cauchemar !",
						Language.ITA => "\\$ è prigioniero di un incubo!",
						Language.SPN => "¡\\$ está inmerso en una pesadilla!",
						Language.KOR => "\\$ 악몽에 시달리고 있다!",
						Language.CHN_SIM => "\\$正被恶梦缠身！",
						Language.CHN_TRA => "\\$正被惡夢纏身！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_PROTECTED_ITSELF:
					return lang switch {
						Language.ENG => "\\$ protected itself!",
						Language.JPN => "\\$は{守|まも}りの{体勢|たいせい}に{入|はい}った！",
						Language.GER => "\\$ schützt sich selbst!",
						Language.FRE => "\\$ est prêt à se protéger !",
						Language.ITA => "\\$ si è protetto!",
						Language.SPN => "¡\\$ se está protegiendo!",
						Language.KOR => "\\$ 방어 태세에 들어갔다!",
						Language.CHN_SIM => "\\$摆出了防守的架势！",
						Language.CHN_TRA => "\\$擺出了防守的架勢！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_GETTING_PUMPED:
					return lang switch {
						Language.ENG => "\\$ is getting pumped!",
						Language.JPN => "\\$は{張|は}り{切|き}っている！",
						Language.GER => "\\$ läuft zu Hochtouren auf!",
						Language.FRE => "\\$ est prêt à tout donner !",
						Language.ITA => "\\$ si prepara alla lotta!",
						Language.SPN => "¡\\$ se está preparando para luchar!",
						Language.KOR => "\\$ 의욕이 넘치고 있다!",
						Language.CHN_SIM => "\\$现在干劲十足！",
						Language.CHN_TRA => "\\$現在幹勁十足！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_COPIED_MONS_STAT_CHANGES:
					return lang switch {
						Language.ENG => "\\$ copied \\$’s stat changes!",
						Language.JPN => "\\$は\\$の{能力変化|のうりょくへんか}をコピーした！",
						Language.GER => "\\$ kopiert die Statusveränderungen von \\$!",
						Language.FRE => "\\$ copie les changements de stats \\$ !",
						Language.ITA => "\\$ copia le modifiche alle statistiche di \\$!",
						Language.SPN => "¡\\$ ha copiado los cambios en las características de \\$!",
						Language.KOR => "\\$의 능력 변화를 복사했다!",
						Language.CHN_SIM => "\\$复制了\\$的能力变化！",
						Language.CHN_TRA => "\\$複製了\\$的能力變化！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BECAME_CENTER_OF_ATTENTION:
					return lang switch {
						Language.ENG => "\\$ became the center of attention!",
						Language.JPN => "\\$は{注目|ちゅうもく}の{的|まと}になった！",
						Language.GER => "\\$ zieht alle Aufmerksamkeit auf sich!",
						Language.FRE => "\\$ devient le centre de l’attention !",
						Language.ITA => "\\$ è al centro dell’attenzione!",
						Language.SPN => "¡\\$ se ha convertido en el centro de atención!",
						Language.KOR => "\\$ 주목의 대상이 되었다!",
						Language.CHN_SIM => "\\$变得万众瞩目了！",
						Language.CHN_TRA => "\\$變得萬眾矚目了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CHARGING_POWER:
					return lang switch {
						Language.ENG => "\\$ began charging power!",
						Language.JPN => "\\$は{充電|じゅうでん}を{始|はじ}めた！",
						Language.GER => "\\$ lädt sich auf!",
						Language.FRE => "\\$ se charge en électricité !",
						Language.ITA => "\\$ si carica di elettricità!",
						Language.SPN => "¡\\$ ha comenzado a acumular energía!",
						Language.KOR => "\\$ 충전을 시작했다!",
						Language.CHN_SIM => "\\$开始充电了！",
						Language.CHN_TRA => "\\$開始充電了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_DAMAGED_BY_RECOIL:
					return lang switch {
						Language.ENG => "\\$ was damaged by the recoil!",
						Language.JPN => "\\$は{反動|はんどう}によるダメージを{受|う}けた！",
						Language.GER => "\\$ erleidet Schaden durch Rückstoß!",
						Language.FRE => "\\$ est blessé par le contrecoup !",
						Language.ITA => "\\$ ha subito il contraccolpo!",
						Language.SPN => "¡\\$ también se ha hecho daño!",
						Language.KOR => "\\$ 반동으로 데미지를 입었다!",
						Language.CHN_SIM => "\\$受到了反作用力造成的伤害！",
						Language.CHN_TRA => "\\$受到了反作用力造成的傷害！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.BELLY_DRUM:
					return lang switch {
						Language.ENG => "\\$ cut its own HP and maximized its Attack!",
						Language.JPN => "\\$は{体力|たいりょく}を{削|けず}ってパワー{全開|ぜんかい}！",
						Language.GER => "\\$ nutzt seine KP und maximiert dadurch seinen Angriffs-Wert!",
						Language.FRE => "\\$ sacrifie des PV et monte son Attaque au maximum !",
						Language.ITA => "\\$ riduce i suoi PS e aumenta al massimo il suo Attacco!",
						Language.SPN => "\\$¡\\$ ha sacrificado algunos PS y ha aumentado al máximo su Ataque!",
						Language.KOR => "\\$ 체력을 깎아서 풀 파워로 만들었다!",
						Language.CHN_SIM => "\\$削减了体力并释放了全部力量！",
						Language.CHN_TRA => "\\$削減體力並釋放了全部力量！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.REST:
					return lang switch {
						Language.ENG => "\\$ slept and restored its HP!",
						Language.JPN => "\\$は{眠|ねむ}って{元気|げんき}になった！",
						Language.GER => "\\$ hat im Schlaf Energie getankt!",
						Language.FRE => "\\$ a récupéré en dormant !",
						Language.ITA => "\\$ ha recuperato le energie durante il sonno!",
						Language.SPN => "¡\\$ se ha recuperado tras dormir un poco!",
						Language.KOR => "\\$ 잠이 들어 건강해졌다!",
						Language.CHN_SIM => "\\$睡着了，并且变得精力充沛！",
						Language.CHN_TRA => "\\$睡著了，變得精力充沛！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BECAME_NIMBLE:
					return lang switch {
						Language.ENG => "\\$ became nimble!",
						Language.JPN => "\\$は{身軽|みがる}になった！",
						Language.GER => "\\$ ist leichter geworden!",
						Language.FRE => "\\$ est devenu très vif !",
						Language.ITA => "\\$ diventa velocissimo!",
						Language.SPN => "¡\\$ es ahora más ligero!",
						Language.KOR => "\\$의 몸이 가벼워졌다!",
						Language.CHN_SIM => "\\$变得身轻如燕了！",
						Language.CHN_TRA => "\\$變得身輕如燕了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.NO_ONE_CAN_ESCAPE:
					return lang switch {
						Language.ENG => "No one will be able to run away during the next turn!",
						Language.JPN => "{次|つぎ}のターンは{逃|に}げられない！",
						Language.GER => "Während der nächsten Runde ist keine Flucht möglich!",
						Language.FRE => "Il sera impossible de fuir au tour suivant !",
						Language.ITA => "Nel prossimo turno sarà impossibile scappare!",
						Language.SPN => "Nadie podrá huir durante el próximo turno.",
						Language.KOR => "다음 턴은 도망갈 수 없다!",
						Language.CHN_SIM => "下回合无法逃走！",
						Language.CHN_TRA => "下回合無法逃走！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SWITCHED_STAT_CHANGES_WITH_TARGET:
					return lang switch {
						Language.ENG => "\\$ switched stat changes with its target!",
						Language.JPN => "\\$は{相手|あいて}と{自分|じぶん}の{能力変化|のうりょくへんか}を{入|い}れ{替|か}えた！",
						Language.GER => "\\$ tauscht die Statusveränderungen mit dem Ziel!",
						Language.FRE => "\\$ permute ses changements de stats avec ceux de sa cible !",
						Language.ITA => "\\$ scambia con il bersaglio le modifiche alle statistiche!",
						Language.SPN => "\\$¡\\$ ha intercambiado los cambios en sus características con el objetivo!",
						Language.KOR => "\\$ 상대와 자신의 능력 변화를 바꿨다!",
						Language.CHN_SIM => "\\$和对手互换了自己的能力变化！",
						Language.CHN_TRA => "\\$和對手互換了自身的能力變化！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HURLED_INTO_AIR:
					return lang switch {
						Language.ENG => "\\$ was hurled into the air!",
						Language.JPN => "\\$を{宙|ちゅう}に{浮|う}かせた！",
						Language.GER => "\\$ wurde zum Schweben gebracht!",
						Language.FRE => "\\$Ça fait léviter \\$ !",
						Language.ITA => "\\$ è stato lanciato in aria!",
						Language.SPN => "¡\\$ ha sido lanzado por los aires!",
						Language.KOR => "\\$ 허공에 띄웠다!",
						Language.CHN_SIM => "让\\$浮在了空中！",
						Language.CHN_TRA => "讓\\$浮在了空中！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BEGAN_LEVITATING:
					return lang switch {
						Language.ENG => "\\$ levitated with electromagnetism!",
						Language.JPN => "\\$は{電磁力|でんじりょく}で{浮|う}かびあがった！",
						Language.GER => "\\$ schwebt aufgrund von Elektromagnetismus!",
						Language.FRE => "\\$ lévite sur un champ magnétique !",
						Language.ITA => "\\$ si solleva in aria a causa dell’elettromagnetismo!",
						Language.SPN => "¡\\$ levita gracias a un campo electromagnético!",
						Language.KOR => "\\$ 전자력으로 떠올랐다!",
						Language.CHN_SIM => "\\$因电磁力浮了起来！",
						Language.CHN_TRA => "\\$因電磁力浮了起來！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BECAME_WEAKER_TO_FIRE:
					return lang switch {
						Language.ENG => "\\$ became weaker to fire!",
						Language.JPN => "\\$はほのおに{弱|よわ}くなった！",
						Language.GER => "\\$ ist nun schwach gegenüber Feuer-Attacken!",
						Language.FRE => "\\$ est maintenant vulnérable au feu !",
						Language.ITA => "\\$ è diventato vulnerabile al tipo Fuoco!",
						Language.SPN => "¡\\$ se ha vuelto débil ante el fuego!",
						Language.KOR => "\\$ 불꽃에 약해졌다!",
						Language.CHN_SIM => "\\$变得怕火了！",
						Language.CHN_TRA => "\\$變得怕火了！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.NOTHING_HAPPENED:
					return lang switch {
						Language.ENG => "But nothing happened!",
						Language.JPN => "しかしなにも{起|お}こらない！",
						Language.GER => "Nichts geschieht!",
						Language.FRE => "Mais rien ne se passe !",
						Language.ITA => "Ma non succede nulla!",
						Language.SPN => "¡Pero no ha tenido ningún efecto!",
						Language.KOR => "그러나 아무 일도 일어나지 않았다!",
						Language.CHN_SIM => "但是，什么也没有发生！",
						Language.CHN_TRA => "但是，什麼也沒有發生！",
						_ => throw new System.ArgumentException()
					};

				case BattleMessage.MON_IS_DROWSING:
					return lang switch {
						Language.ENG => "\\$ is drowsing!",
						Language.JPN => "\\$は{夢|ゆめ}うつつの{状態|じょうたい}！",
						Language.GER => "\\$ befindet sich im Halbschlaf!",
						Language.FRE => "\\$ est en Hypersommeil !",
						Language.ITA => "\\$ è in uno stato di dormiveglia!",
						Language.SPN => "¡\\$ está sumido en un profundo letargo!",
						Language.KOR => "\\$ 비몽사몽 상태!",
						Language.CHN_SIM => "\\$处于半梦半醒状态！",
						Language.CHN_TRA => "\\$處於半夢半醒狀態！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_RECHARGING:
					return lang switch {
						Language.ENG => "\\$ must recharge!",
						Language.JPN => "\\$は{攻撃|こうげき}の{反動|はんどう}で{動|うご}けない！",
						Language.GER => "\\$ kann sich wegen des Rückstoßes durch den Angriff nicht bewegen!",
						Language.FRE => "\\$Le contrecoup empêche \\$ de bouger !",
						Language.ITA => "\\$ deve ricaricarsi!",
						Language.SPN => "¡\\$ necesita recuperarse de su ataque!",
						Language.KOR => "\\$ 공격의 반동으로 움직일 수 없다!",
						Language.CHN_SIM => "\\$因攻击的反作用力而无法动弹！",
						Language.CHN_TRA => "\\$因攻擊的反作用力而無法動彈！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HURT_BY_ITS_BURN:
					return lang switch {
						Language.ENG => "\\$ was hurt by its burn!",
						Language.JPN => "\\$はやけどのダメージを{受|う}けた！",
						Language.GER => "Die Verbrennungen schaden \\$!",
						Language.FRE => "\\$ souffre de sa brûlure !",
						Language.ITA => "\\$ soffre per la scottatura!",
						Language.SPN => "¡\\$ se resiente de las quemaduras!",
						Language.KOR => "\\$ 화상 데미지를 입었다!",
						Language.CHN_SIM => "\\$受到了灼伤的伤害！",
						Language.CHN_TRA => "\\$受到了灼傷的傷害！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_PARALYZED_AND_CANT_MOVE:
					return lang switch {
						Language.ENG => "\\$ is paralyzed! It can’t move!",
						Language.JPN => "\\$は{体|からだ}がしびれて{動|うご}けない！",
						Language.GER => "\\$ ist paralysiert! Es kann nicht angreifen!",
						Language.FRE => "\\$ est paralysé ! Il n’a pas pu attaquer !",
						Language.ITA => "\\$ è paralizzato! Non può agire!",
						Language.SPN => "¡\\$ está paralizado! No se puede mover.",
						Language.KOR => "\\$ 몸이 저려서 움직일 수 없다!",
						Language.CHN_SIM => "\\$因身体麻痹而无法行动！",
						Language.CHN_TRA => "\\$因身體麻痺而無法行動！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_FROZEN_SOLID:
					return lang switch {
						Language.ENG => "\\$ is frozen solid!",
						Language.JPN => "\\$は{凍|こお}ってしまって{動|うご}けない！",
						Language.GER => "\\$ ist eingefroren und kann sich nicht bewegen!",
						Language.FRE => "\\$ est gelé ! Il ne peut plus attaquer !",
						Language.ITA => "\\$ è congelato! Non può agire!",
						Language.SPN => "¡\\$ está congelado! No se puede mover.",
						Language.KOR => "\\$ 얼어버려서 움직일 수 없다!",
						Language.CHN_SIM => "\\$因冻住了而无法行动！",
						Language.CHN_TRA => "\\$因凍住了而無法行動！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HURT_BY_POISON:
					return lang switch {
						Language.ENG => "\\$ was hurt by poison!",
						Language.JPN => "\\$は{毒|どく}のダメージを{受|う}けた！",
						Language.GER => "\\$ wird durch Gift verletzt!",
						Language.FRE => "\\$ souffre du poison !",
						Language.ITA => "\\$Il veleno ha effetto su \\$!",
						Language.SPN => "¡El veneno resta PS a \\$!",
						Language.KOR => "\\$ 독에 의한 데미지를 입었다!",
						Language.CHN_SIM => "\\$受到了毒的伤害！",
						Language.CHN_TRA => "\\$受到了毒的傷害！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_FAST_ASLEEP:
					return lang switch {
						Language.ENG => "\\$ is fast asleep.",
						Language.JPN => "\\$はぐうぐう{眠|ねむ}っている",
						Language.GER => "\\$ schläft tief und fest!",
						Language.FRE => "\\$ dort profondément.",
						Language.ITA => "\\$ dorme.",
						Language.SPN => "¡\\$ está dormido como un tronco!",
						Language.KOR => "\\$ 쿨쿨 잠들어 있다",
						Language.CHN_SIM => "\\$正在呼呼大睡。",
						Language.CHN_TRA => "\\$正在呼呼大睡。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HURT_BY_SANDSTORM:
					return lang switch {
						Language.ENG => "\\$ is buffeted by the sandstorm!",
						Language.JPN => "{砂|すな}あらしが\\$を{襲|おそ}う！",
						Language.GER => "Der Sandsturm fügt \\$ Schaden zu!",
						Language.FRE => "\\$La tempête de sable inflige des dégâts à \\$ !",
						Language.ITA => "\\$La tempesta di sabbia infligge danni a \\$!",
						Language.SPN => "¡La tormenta de arena zarandea a \\$!",
						Language.KOR => "모래바람이 \\$ 덮쳤다!",
						Language.CHN_SIM => "沙暴袭击了\\$！",
						Language.CHN_TRA => "沙暴襲擊了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HURT_BY_HAIL:
					return lang switch {
						Language.ENG => "\\$ is buffeted by the hail!",
						Language.JPN => "あられが\\$を{襲|おそ}う！",
						Language.GER => "\\$ wird von Hagelkörnern getroffen!",
						Language.FRE => "\\$La tempête de grêle inflige des dégâts à \\$ !",
						Language.ITA => "\\$La grandine infligge danni a \\$!",
						Language.SPN => "¡El granizo golpea a \\$!",
						Language.KOR => "싸라기눈이 \\$ 덮쳤다!",
						Language.CHN_SIM => "冰雹袭击了\\$！",
						Language.CHN_TRA => "冰雹襲擊了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_BE_BURNED:
					return lang switch {
						Language.ENG => "\\$ cannot be burned!",
						Language.JPN => "\\$はやけどにならない！",
						Language.GER => "\\$ kann keine Verbrennungen erleiden!",
						Language.FRE => "\\$ ne peut pas être brûlé !",
						Language.ITA => "\\$ non può essere scottato!",
						Language.SPN => "¡\\$ no se puede quemar!",
						Language.KOR => "\\$ 화상을 입지 않는다!",
						Language.CHN_SIM => "\\$不会被灼伤！",
						Language.CHN_TRA => "\\$不會被灼傷！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_BE_FROZEN:
					return lang switch {
						Language.ENG => "The opposing \\$ cannot be frozen solid!",
						Language.JPN => "{相手|あいて}の\\$は{凍|こお}らない！",
						Language.GER => "\\$ (Gegner) kann nicht eingefroren werden!",
						Language.FRE => "\\$\\$ ennemi ne peut pas être gelé !",
						Language.ITA => "\\$\\$ nemico non può essere congelato!",
						Language.SPN => "¡El \\$ enemigo no se puede quedar congelado!",
						Language.KOR => "상대 \\$ 얼지 않는다!",
						Language.CHN_SIM => "对手的\\$不会被冻住！",
						Language.CHN_TRA => "對手的\\$不會被凍住！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_BE_PARALYZED:
					return lang switch {
						Language.ENG => "The opposing \\$ cannot be paralyzed!",
						Language.JPN => "{相手|あいて}の\\$はまひにならない！",
						Language.GER => "\\$ (Gegner) kann nicht paralysiert werden!",
						Language.FRE => "\\$\\$ ennemi ne peut pas être paralysé !",
						Language.ITA => "\\$\\$ nemico non può essere paralizzato!",
						Language.SPN => "¡El \\$ enemigo no se puede quedar paralizado!",
						Language.KOR => "상대 \\$ 마비되지 않는다!",
						Language.CHN_SIM => "对手的\\$不会被麻痹！",
						Language.CHN_TRA => "對手的\\$不會被麻痺！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_BE_POISONED:
					return lang switch {
						Language.ENG => "The opposing \\$ cannot be poisoned!",
						Language.JPN => "{相手|あいて}の\\$は{毒|どく}にならない！",
						Language.GER => "Das Gift zeigt keine Wirkung bei \\$ (Gegner)!",
						Language.FRE => "\\$\\$ ennemi ne peut pas être empoisonné !",
						Language.ITA => "\\$\\$ nemico non può essere avvelenato!",
						Language.SPN => "¡El veneno no afecta al \\$ enemigo!",
						Language.KOR => "상대 \\$ 독에 중독되지 않는다!",
						Language.CHN_SIM => "对手的\\$不会中毒！",
						Language.CHN_TRA => "對手的\\$不會中毒！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_FALL_ASLEEP:
					return lang switch {
						Language.ENG => "The opposing \\$ stays awake!",
						Language.JPN => "{相手|あいて}の\\$は{眠|ねむ}らない！",
						Language.GER => "\\$ (Gegner) schläft nicht ein!",
						Language.FRE => "\\$\\$ ennemi ne s’endort pas !",
						Language.ITA => "\\$\\$ nemico rimane sveglio!",
						Language.SPN => "¡El \\$ enemigo no se puede dormir!",
						Language.KOR => "상대 \\$ 잠들지 않는다!",
						Language.CHN_SIM => "对手的\\$不会睡着！",
						Language.CHN_TRA => "對手的\\$不會睡著！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OHKO:
					return lang switch {
						Language.ENG => "It’s a one-hit KO!",
						Language.JPN => "{一撃必殺|いちげきひっさつ}！",
						Language.GER => "Ein K.O.-Treffer!",
						Language.FRE => "K.O. en un coup !",
						Language.ITA => "È un colpo da KO!",
						Language.SPN => "¡Es un golpe fulminante!",
						Language.KOR => "일격필살!",
						Language.CHN_SIM => "一击必杀！",
						Language.CHN_TRA => "一擊必殺！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.GRASSY_TERRAIN_START:
					return lang switch {
						Language.ENG => "Grass grew to cover the battlefield!",
						Language.JPN => "{足下|あしもと}に{草|くさ}がおいしげった！",
						Language.GER => "Dichtes Gras schießt aus dem Boden!",
						Language.FRE => "Un beau gazon pousse sur le terrain !",
						Language.ITA => "Ai piedi dei Pokémon cresce rigogliosa l’erba.",
						Language.SPN => "¡El terreno de combate se ha cubierto de hierba!",
						Language.KOR => "발밑에 풀이 무성해졌다!",
						Language.CHN_SIM => "脚下青草如茵！",
						Language.CHN_TRA => "腳下青草如茵！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.GRASSY_TERRAIN_END:
					return lang switch {
						Language.ENG => "The grass disappeared from the battlefield.",
						Language.JPN => "{足下|あしもと}の{草|くさ}が{消|き}え{去|さ}った！",
						Language.GER => "Das Grasfeld ist wieder verschwunden!",
						Language.FRE => "Le gazon disparaît...",
						Language.ITA => "L’erba sparisce.",
						Language.SPN => "La hierba ha desaparecido.",
						Language.KOR => "발밑의 풀이 사라졌다!",
						Language.CHN_SIM => "脚下的青草消失不见了！",
						Language.CHN_TRA => "腳下的青草消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MISTY_TERRAIN_START:
					return lang switch {
						Language.ENG => "Mist swirled around the battlefield!",
						Language.JPN => "{足下|あしもと}に{霧|きり}が{立|た}ち{込|こ}めた！",
						Language.GER => "Am Boden breitet sich dichter Nebel aus!",
						Language.FRE => "Le terrain se couvre de brume !",
						Language.ITA => "Ai piedi dei Pokémon si addensa la nebbia.",
						Language.SPN => "¡La niebla ha envuelto el terreno de combate!",
						Language.KOR => "발밑이 안개로 자욱해졌다!",
						Language.CHN_SIM => "脚下雾气缭绕！",
						Language.CHN_TRA => "腳下霧氣繚繞！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MISTY_TERRAIN_END:
					return lang switch {
						Language.ENG => "The mist disappeared from the battlefield.",
						Language.JPN => "{足下|あしもと}の{霧|きり}が{消|き}え{去|さ}った！",
						Language.GER => "Das Nebelfeld ist wieder verschwunden!",
						Language.FRE => "La brume qui recouvrait le terrain se dissipe...",
						Language.ITA => "La nebbia si dissolve.",
						Language.SPN => "La niebla se ha disipado.",
						Language.KOR => "발밑의 안개가 사라졌다!",
						Language.CHN_SIM => "脚下的雾气消失不见了！",
						Language.CHN_TRA => "腳下的霧氣消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ELECTRIC_TERRAIN_START:
					return lang switch {
						Language.ENG => "An electric current ran across the battlefield!",
						Language.JPN => "{足下|あしもと}に{電気|でんき}がかけめぐる！",
						Language.GER => "Elektrische Energie fließt durch den Boden!",
						Language.FRE => "De l’électricité parcourt le terrain !",
						Language.ITA => "Ai piedi dei Pokémon si accumula dell’elettricità.",
						Language.SPN => "¡Se ha formado un campo de corriente eléctrica en el terreno de combate!",
						Language.KOR => "발밑에 전기가 떠돌기 시작했다!",
						Language.CHN_SIM => "脚下电光飞闪！",
						Language.CHN_TRA => "腳下電流飛閃！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ELECTRIC_TERRAIN_END:
					return lang switch {
						Language.ENG => "The electricity disappeared from the battlefield.",
						Language.JPN => "{足下|あしもと}の{電気|でんき}が{消|き}え{去|さ}った！",
						Language.GER => "Das Elektrofeld ist wieder verschwunden!",
						Language.FRE => "L’électricité parcourant le terrain s’est dissipée...",
						Language.ITA => "L’elettricità svanisce.",
						Language.SPN => "El campo de corriente eléctrica ha desaparecido.",
						Language.KOR => "발밑의 전기가 사라졌다!",
						Language.CHN_SIM => "脚下的电光消失不见了！",
						Language.CHN_TRA => "腳下的電流消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PSYCHIC_TERRAIN_START:
					return lang switch {
						Language.ENG => "The battlefield got weird!",
						Language.JPN => "{足元|あしもと}が{不思議|ふしぎ}なじになった！",
						Language.GER => "Der Boden fühlt sich seltsam an!",
						Language.FRE => "Le sol se met à réagir de façon bizarre...",
						Language.ITA => "Nel campo si avverte una strana sensazione...",
						Language.SPN => "¡El terreno de combate se ha vuelto muy extraño!",
						Language.KOR => "발밑에서 이상한 느낌이 든다!",
						Language.CHN_SIM => "脚下传来了奇妙的感觉！",
						Language.CHN_TRA => "腳下傳來了奇妙的感覺！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PSYCHIC_TERRAIN_END:
					return lang switch {
						Language.ENG => "The weirdness disappeared from the battlefield!",
						Language.JPN => "{足元|あしもと}の{不思議感|ふしぎかん}が{消|き}え{去|さ}った！",
						Language.GER => "Das Psychofeld ist wieder verschwunden!",
						Language.FRE => "Le sol redevient normal !",
						Language.ITA => "La strana sensazione nel campo è svanita!",
						Language.SPN => "Ha desaparecido la extraña sensación que se percibía en el terreno de combate.",
						Language.KOR => "발밑의 이상한 느낌이 사라졌다!",
						Language.CHN_SIM => "脚下的奇妙感觉消失了！",
						Language.CHN_TRA => "腳下的奇妙感覺消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.GRASSY_TERRAIN_ACTIVE:
					return lang switch {
						Language.ENG => "The battlefield is covered with grass!",
						Language.JPN => "{足下|あしもと}に{草|くさ}がおいしげっている！",
						Language.GER => "Der Boden ist mit Gras bewachsen!",
						Language.FRE => "Un beau gazon recouvre le terrain !",
						Language.ITA => "Il terreno di lotta è ricoperto di erba!",
						Language.SPN => "¡El terreno de combate se está cubriendo de hierba!",
						Language.KOR => "발밑에 풀이 무성하다!",
						Language.CHN_SIM => "脚下的青草正在生长！",
						Language.CHN_TRA => "腳下青草如茵！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MISTY_TERRAIN_ACTIVE:
					return lang switch {
						Language.ENG => "Mist swirls around the battlefield!",
						Language.JPN => "{足下|あしもと}に{霧|きり}が{立|た}ち{込|こ}めている！",
						Language.GER => "Der Boden ist von Nebel überzogen!",
						Language.FRE => "Le terrain est couvert de brume !",
						Language.ITA => "Sul terreno di lotta cala la nebbia!",
						Language.SPN => "¡La niebla está envolviendo el terreno de combate!",
						Language.KOR => "발밑이 안개로 자욱하다!",
						Language.CHN_SIM => "脚下的雾气正在蔓延！",
						Language.CHN_TRA => "腳下霧氣繚繞！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ELECTRIC_TERRAIN_ACTIVE:
					return lang switch {
						Language.ENG => "An electric current is running across the battlefield!",
						Language.JPN => "{足下|あしもと}に{電気|でんき}がかけめぐっている！",
						Language.GER => "Der Boden ist elektrisch geladen!",
						Language.FRE => "De l’électricité parcourt le terrain !",
						Language.ITA => "Il terreno di lotta è elettrizzato!",
						Language.SPN => "¡Se está creando un campo eléctrico en el terreno de combate!",
						Language.KOR => "발밑에 전기가 떠돌고 있다!",
						Language.CHN_SIM => "脚下的电光正在闪烁！",
						Language.CHN_TRA => "腳下電流飛閃！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PSYCHIC_TERRAIN_ACTIVE:
					return lang switch {
						Language.ENG => "The battlefield seems weird!",
						Language.JPN => "{足元|あしもと}が{不思議|ふしぎ}な{感|かん}じだ！",
						Language.GER => "Der Boden strahlt eine seltsame Aura aus!",
						Language.FRE => "Le sol réagit de façon bizarre...",
						Language.ITA => "Sul terreno di lotta agiscono strane forze!",
						Language.SPN => "¡El terreno de combate se está volviendo muy extraño!",
						Language.KOR => "발밑의 느낌이 이상하다!",
						Language.CHN_SIM => "脚下传来阵阵奇妙的感觉！",
						Language.CHN_TRA => "腳下的感覺很奇妙！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SUNLIGHT_IS_HARSH:
					return lang switch {
						Language.ENG => "The sunlight is harsh!",
						Language.JPN => "{日差|ひざ}しが{強|つよ}い！",
						Language.GER => "Es ist sonnig!",
						Language.FRE => "Les rayons du soleil brillent !",
						Language.ITA => "La luce solare è intensa!",
						Language.SPN => "Hace mucho sol...",
						Language.KOR => "햇살이 강하다!",
						Language.CHN_SIM => "现在日照很强！",
						Language.CHN_TRA => "日照很強！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ITS_RAINING:
					return lang switch {
						Language.ENG => "It’s raining!",
						Language.JPN => "{雨|あめ}が{降|ふ}っている！",
						Language.GER => "Es regnet!",
						Language.FRE => "Il pleut !",
						Language.ITA => "Sta piovendo!",
						Language.SPN => "Está lloviendo...",
						Language.KOR => "비가 내리고 있다!",
						Language.CHN_SIM => "现在正在下雨！",
						Language.CHN_TRA => "現在正在下雨！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SANDSTORM_IS_RAGING:
					return lang switch {
						Language.ENG => "The sandstorm is raging!",
						Language.JPN => "{砂|すな}あらしが{吹|ふ}いている！",
						Language.GER => "Ein Sandsturm tobt!",
						Language.FRE => "Une tempête de sable fait rage !",
						Language.ITA => "Imperversa una tempesta di sabbia!",
						Language.SPN => "Se está desatando una tormenta de arena...",
						Language.KOR => "모래바람이 불고 있다!",
						Language.CHN_SIM => "现在正在刮沙暴！",
						Language.CHN_TRA => "現在正在刮沙暴！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ITS_HAILING:
					return lang switch {
						Language.ENG => "It’s hailing!",
						Language.JPN => "あられが{降|ふ}っている！",
						Language.GER => "Es hagelt!",
						Language.FRE => "Il grêle !",
						Language.ITA => "Sta grandinando!",
						Language.SPN => "Está granizando...",
						Language.KOR => "싸라기눈이 내리고 있다!",
						Language.CHN_SIM => "现在正在下冰雹！",
						Language.CHN_TRA => "現在正在下冰雹！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ITS_SNOWING:
					return lang switch {
						Language.ENG => "It’s snowing!",
						Language.JPN => "{雪|ゆき}が{降|ふ}っている！",
						Language.GER => "Es schneit!",
						Language.FRE => "Il neige !",
						Language.ITA => "Sta nevicando!",
						Language.SPN => "Está nevando...",
						Language.KOR => "눈이 내리고 있다!",
						Language.CHN_SIM => "现在正在下雪！",
						Language.CHN_TRA => "現在正在下雪！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.FIRE_ATTACK_FIZZLED_OUT:
					return lang switch {
						Language.ENG => "The Fire-type attack fizzled out in the heavy rain!",
						Language.JPN => "{強|つよ}い{雨|きょうでほ}のでほのおタイプの{影響攻撃|こうげき}がかき{消|け}された！",
						Language.GER => "Der strömende Regen löscht die Feuer-Attacke und macht sie wirkungslos!",
						Language.FRE => "La pluie battante empêche toute attaque de type Feu !",
						Language.ITA => "L’acquazzone neutralizza le mosse di tipo Fuoco!",
						Language.SPN => "¡El diluvio impide todos los ataques de tipo Fuego!",
						Language.KOR => "강한 비의 영향으로 불꽃타입의 공격이 사라졌다!",
						Language.CHN_SIM => "受暴雨的影响，火属性的攻击被扑灭了！",
						Language.CHN_TRA => "受暴雨的影響，火屬性的攻擊被撲滅了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.WATER_ATTACK_EVAPORATED:
					return lang switch {
						Language.ENG => "The Water-type attack evaporated in the extremely harsh sunlight!",
						Language.JPN => "{強|つよ}いしのでみずタイプのがした！",
						Language.GER => "Das intensive Sonnenlicht lässt die Wasser-Attacke verdampfen und macht sie wirkungslos!",
						Language.FRE => "Le soleil brille si intensément que toute attaque de type Eau s’évapore !",
						Language.ITA => "La luce solare accecante neutralizza le mosse di tipo Acqua!",
						Language.SPN => "El sol brilla con tanta intensidad que el agua se evapora, lo que afecta a los movimientos de tipo Agua.",
						Language.KOR => "강한 햇살의 영향으로 물타입의 공격이 증발했다!",
						Language.CHN_SIM => "受强日照的影响，水属性的攻击被蒸发了！",
						Language.CHN_TRA => "受強日照的影響，水屬性的攻擊被蒸發了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.WIND_WEAKENED_ATTACK:
					return lang switch {
						Language.ENG => "The mysterious strong winds weakened the attack!",
						Language.JPN => "{謎|なぞ}の{乱気流|らんきりゅう}が{攻撃|こうげき}を{弱|よわ}めた！",
						Language.GER => "Rätselhafte Luftströmungen haben den Angriff abgeschwächt!",
						Language.FRE => "Le vent mystérieux affaiblit l’attaque !",
						Language.ITA => "La corrente misteriosa indebolisce l’attacco!",
						Language.SPN => "¡Las misteriosas turbulencias atenúan el ataque!",
						Language.KOR => "수수께끼의 난기류가 공격을 약하게 만들었다!",
						Language.CHN_SIM => "神秘的乱流减弱了攻击！",
						Language.CHN_TRA => "神秘的亂流減弱了攻擊！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MYSTERIOUS_WIND_BLOWS_ON:
					return lang switch {
						Language.ENG => "The mysterious air current blows on!",
						Language.JPN => "{不思議|ふしぎ}な{気流|きりゅ}が{吹|ふ}き{荒|あら}れる！",
						Language.GER => "Der geheimnisvolle Luftstrom weht weiter!",
						Language.FRE => "Le mystérieux courant d'air souffle !",
						Language.ITA => "La misteriosa corrente d'aria continua a soffiare!",
						Language.SPN => "¡La misteriosa corriente de aire sigue soplando!",
						Language.KOR => "신비한 기류가 불어옵니다!",
						Language.CHN_SIM => "神秘氣流襲來！",
						Language.CHN_TRA => "神秘氣流襲來！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SHADOWY_AURA_APPEARED:
					return lang switch {
						Language.ENG => "A shadowy aura filled the sky!",
						Language.JPN => "{影|かげ}のようなオーラが{空|そら}を{満|み}たした！",
						Language.GER => "Eine schattenhafte Aura erfüllte den Himmel!",
						Language.FRE => "Une aura d'ombre remplit le ciel !",
						Language.ITA => "Un'aura d'ombra riempì il cielo!",
						Language.SPN => "¡Un aura sombría llenó el cielo!",
						Language.KOR => "어둠의 기운이 하늘을 가득 채웠습니다!",
						Language.CHN_SIM => "天空中弥漫着一股阴暗的气息！",
						Language.CHN_TRA => "天空中瀰漫著一股陰暗的氣息！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.SHADOWY_AURA_DISAPPEARED:
					return lang switch {
						Language.ENG => "The shadowy aura faded away!",
						Language.JPN => "{影|かげ}のようなオーラが{消|き}えていった！",
						Language.GER => "Die schattenhafte Aura verblasste!",
						Language.FRE => "L'aura d'ombre se dissipe !",
						Language.ITA => "L'aura oscura si è dissolta!",
						Language.SPN => "¡El aura sombría se desvaneció!",
						Language.KOR => "어둠의 기운이 사라졌습니다!",
						Language.CHN_SIM => "阴暗气息消散！",
						Language.CHN_TRA => "陰暗氣息消散！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.LIGHT_SHOWERED_FROM_SHADOWY_AURA:
					return lang switch {
						Language.ENG => "Bursts of light showered from the shadowy aura!",
						Language.JPN => "{影|かげ}のようなオーラから{光|ひかり}の{破片|はへん}がはじけた！",
						Language.GER => "Aus der schattenhaften Aura brechen Lichtsplitter hervor!",
						Language.FRE => "Des éclats de lumière jaillissent de l'aura d'ombre !",
						Language.ITA => "Dall'aura d'ombra si sprigionano frammenti di luce!",
						Language.SPN => "¡Disparos de luz estallan del aura sombría!",
						Language.KOR => "어둠의 기운에서 빛의 파편이 터져 나옵니다!",
						Language.CHN_SIM => "一道道光芒从黑暗气息中爆射而出！",
						Language.CHN_TRA => "一道道光芒從黑暗氣息中爆射而出！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.FLASHING_LIGHT_STRIKES_MON:
					return lang switch {
						Language.ENG => "The flashing light strikes \\$!",
						Language.JPN => "{閃光|せんこう}が\\$を{襲|おそ}う！",
						Language.GER => "Das blinkende Licht fällt \\$ auf!",
						Language.FRE => "La lumière clignotante frappe \\$ !",
						Language.ITA => "La luce lampeggiante colpisce \\$!",
						Language.SPN => "¡La luz intermitente golpea \\$!",
						Language.KOR => "깜박이는 불빛이 \\$를 강타합니다!",
						Language.CHN_SIM => "闪烁的光芒击中了\\$！",
						Language.CHN_TRA => "閃爍的光芒擊中了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WHIPPED_UP_A_WHIRLWIND:
					return lang switch {
						Language.ENG => "\\$ whipped up a whirlwind!",
						Language.JPN => "\\$の{周|まわ}りで{空気|くうき}が{渦|うず}を{巻|ま}く！",
						Language.GER => "\\$ erzeugt eine Windböe!",
						Language.FRE => "\\$ se prépare à lancer une bourrasque !",
						Language.ITA => "\\$ genera un uragano!",
						Language.SPN => "¡\\$ se prepara para lanzar una borrasca!",
						Language.KOR => "\\$의 주위에서 공기가 소용돌이친다!",
						Language.CHN_SIM => "\\$周围的空气产生了旋涡！",
						Language.CHN_TRA => "\\$周圍的空氣產生了旋渦！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SURROUNDED_ITSELF_WITH_A_VEIL_OF_WATER:
					return lang switch {
						Language.ENG => "\\$ surrounded itself with a veil of water!",
						Language.JPN => "\\$は{水|みず}のリングをまとった！",
						Language.GER => "\\$ umgibt sich mit einem Wasserring!",
						Language.FRE => "\\$ s’entoure d’un voile d’eau !",
						Language.ITA => "Un velo d’acqua avvolge \\$!",
						Language.SPN => "¡\\$ se ha rodeado de un manto de agua!",
						Language.KOR => "\\$ 물의 고리를 머금었다!",
						Language.CHN_SIM => "\\$套上了水环！",
						Language.CHN_TRA => "\\$套上了水環！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.A_VEIL_OF_WATER_RESTORED_MONS_HP:
					return lang switch {
						Language.ENG => "A veil of water restored \\$’s HP!",
						Language.JPN => "\\$は{水|みず}のリングで{体力|たいりょく}を{回復|かいふく}！",
						Language.GER => "Der Wasserring stellt KP von \\$ wieder her!",
						Language.FRE => "Le voile d’eau restaure les PV \\$ !",
						Language.ITA => "Un velo d’acqua fa recuperare PS a \\$!",
						Language.SPN => "¡\\$ ha recuperado algunos PS gracias al manto de agua que rodea su cuerpo!",
						Language.KOR => "\\$ 물의 고리로 체력을 회복했다!",
						Language.CHN_SIM => "\\$通过水环回复体力！",
						Language.CHN_TRA => "\\$透過水環回復了體力！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MONS_PP_WAS_REDUCED:
					return lang switch {
						Language.ENG => "\\$’s PP was reduced!",
						Language.JPN => "\\$のＰＰがへった！",
						Language.GER => "AP von \\$ wurden verringert!",
						Language.FRE => "Les PP \\$ baissent !",
						Language.ITA => "I PP di \\$ sono diminuiti!",
						Language.SPN => "¡\\$ ha perdido PP!",
						Language.KOR => "\\$의 PP가 줄었다!",
						Language.CHN_SIM => "\\$的ＰＰ减少了！",
						Language.CHN_TRA => "\\$的ＰＰ減少了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_TORMENTED:
					return lang switch {
						Language.ENG => "\\$ is tormented!",
						Language.JPN => "\\$はうなされている！",
						Language.GER => "\\$ ist in einem Alptraum gefangen!",
						Language.FRE => "\\$ a le sommeil agité !",
						Language.ITA => "\\$ ha il sonno irrequieto!",
						Language.SPN => "¡\\$ está inmerso en un sueño agitado!",
						Language.KOR => "\\$ 나이트메어 때문에 시달리고 있다!",
						Language.CHN_SIM => "\\$正被恶梦缠身！",
						Language.CHN_TRA => "\\$正被惡夢纏身！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_NO_LONGER_TORMENTED:
					return lang switch {
						Language.ENG => "\\$ is no longer tormented!",
						Language.JPN => "\\$のいちゃもんの{効果|こうか}が{切|き}れた！",
						Language.GER => "Folterknecht wirkt nicht mehr auf \\$!",
						Language.FRE => "Les tourments \\$ sont apaisés !",
						Language.ITA => "L’effetto di Attaccalite su \\$ è terminato!",
						Language.SPN => "¡\\$ ya no está atormentado!",
						Language.KOR => "\\$의 트집 효과가 떨어졌다!",
						Language.CHN_SIM => "\\$的无理取闹的效果消失了！",
						Language.CHN_TRA => "\\$的無理取鬧效果消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_USE_THE_SAME_MOVE_TWICE_DUE_TO_TORMENT:
					return lang switch {
						Language.ENG => "\\$ can’t use the same move twice in a row due to the torment!",
						Language.JPN => "\\$はいちゃもんをつけられたので{r続|つづ}けて{同|おな}じ{技|わざ}がだせない！",
						Language.GER => "\\$ kann aufgrund von Folterknecht die Attacke nicht zweimal hintereinander einsetzen!",
						Language.FRE => "Tourmenté, \\$ ne peut pas utiliser la même capacité deux fois de suite !",
						Language.ITA => "Attaccalite impedisce a \\$ di sferrare la stessa mossa più volte di fila!",
						Language.SPN => "¡\\$ está atormentado, por lo que no puede usar dos veces seguidas el mismo movimiento!",
						Language.KOR => "\\$ 트집을 잡혔기 때문에 계속해서 같은 기술을 쓸 수 없다!",
						Language.CHN_SIM => "\\$遭到了无理取闹，因此无法继续使出相同的招式！",
						Language.CHN_TRA => "\\$遭到了無理取鬧，因此無法繼續使出相同的招式！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.GUARD_SPLIT:
					return lang switch {
						Language.ENG => "\\$ shared its guard with the target!",
						Language.JPN => "\\$はおたがいのガードをシェアした！",
						Language.GER => "\\$ addiert seine Schutzkräfte mit jenen des Zieles und teilt sie gerecht auf!",
						Language.FRE => "\\$ additionne sa garde à celle de sa cible et les redistribue équitablement !",
						Language.ITA => "\\$ somma le sue capacità difensive con quelle del bersaglio e le ripartisce equamente!",
						Language.SPN => "¡\\$ suma su capacidad defensiva a la del objetivo y la reparte equitativamente!",
						Language.KOR => "\\$ 서로의 가드를 셰어했다!",
						Language.CHN_SIM => "\\$平分了各自的防守！",
						Language.CHN_TRA => "\\$平分了各自的防守！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.POWER_SPLIT:
					return lang switch {
						Language.ENG => "\\$ shared its power with the target!",
						Language.JPN => "\\$はおたがいのパワーをシェアした！",
						Language.GER => "\\$ addiert seine Kräfte mit jenen des Zieles und teilt sie gerecht auf!",
						Language.FRE => "\\$ additionne sa force à celle de sa cible et les redistribue équitablement !",
						Language.ITA => "\\$ somma le sue capacità offensive con quelle del bersaglio e le ripartisce equamente!",
						Language.SPN => "¡\\$ suma su capacidad ofensiva a la del objetivo y la reparte equitativamente!",
						Language.KOR => "\\$ 서로의 파워를 셰어했다!",
						Language.CHN_SIM => "\\$平分了各自的力量！",
						Language.CHN_TRA => "\\$平分了各自的力量！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.GUARD_SWAP:
					return lang switch {
						Language.ENG => "The wild \\$ switched all changes to its Defense and Sp. Def with its target!",
						Language.JPN => "{野生|やせい}の\\$は{相手|ぼうぎょ}と{自分|くぼう}のとの{防御特防r能力変化|うりょくへんか}を{入|い}れ{替|か}えた！",
						Language.GER => "\\$ (wild) tauscht Veränderungen an Verteidigung und Spezial-Verteidigung mit dem Ziel!",
						Language.FRE => "\\$ sauvage intervertit les changements de Défense et de Défense Spéciale avec ceux de sa cible !",
						Language.ITA => "\\$ selvatico scambia con il bersaglio le modifiche a Difesa e Difesa Speciale!",
						Language.SPN => "¡El \\$ salvaje ha intercambiado los cambios en la Defensa y Defensa Especial con los del objetivo!",
						Language.KOR => "야생 \\$ 상대와 자신의 방어와 특수방어의 능력 변화를 바꿨다!",
						Language.CHN_SIM => "野生的\\$和对手互换了自己的防御和特防的能力变化！",
						Language.CHN_TRA => "野生的\\$和對手互換了自身的防禦和特防的能力變化！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.POWER_SWAP:
					return lang switch {
						Language.ENG => "\\$ switched all changes to its Attack and Sp. Atk with its target!",
						Language.JPN => "\\$は{相手|あいて}と{自分|とくこう}のとの{攻撃特攻r能力変化|うりょくへんか}を{入|い}れ{替|か}えた！",
						Language.GER => "\\$ tauscht Veränderungen an Angriff und Spezial-Angriff mit dem Ziel!",
						Language.FRE => "\\$ intervertit les changements d’Attaque et d’Attaque Spéciale avec ceux de sa cible !",
						Language.ITA => "\\$ scambia con il bersaglio le modifiche ad Attacco e Attacco Speciale!",
						Language.SPN => "¡\\$ ha intercambiado los cambios en el Ataque y Ataque Especial con los del objetivo!",
						Language.KOR => "\\$ 상대와 자신의 공격과 특수공격의 능력 변화를 바꿨다!",
						Language.CHN_SIM => "\\$和对手互换了自己的攻击和特攻的能力变化！",
						Language.CHN_TRA => "\\$和對手互換了自身的攻擊和特攻的能力變化！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MONS_PERISH_COUNT_FELL_TO_N:
					return lang switch {
						Language.ENG => "\\$’s perish count fell to \\$!",
						Language.JPN => "\\$の{滅|ほろ}びのカウントが\\$になった！",
						Language.GER => "Abgesang von \\$ steht bei \\$!",
						Language.FRE => "Le compte à rebours de Requiem \\$ descend à \\$ !",
						Language.ITA => "Il conto alla rovescia di Ultimocanto per \\$ scende a \\$!",
						Language.SPN => "¡La cuenta atrás de Canto Mortal de \\$ ha bajado a \\$!",
						Language.KOR => "\\$의 멸망의 카운트가 \\$ 되었다!",
						Language.CHN_SIM => "\\$的灭亡计时变成\\$了！",
						Language.CHN_TRA => "\\$的滅亡計時變成\\$了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PERISH_SONG:
					return lang switch {
						Language.ENG => "All Pokémon that heard the song will faint in three turns!",
						Language.JPN => "ほろびのうたを{聴|き}いたポケモンは３ターン{後|ご}に{滅|ほろ}びてしまう！",
						Language.GER => "Alle Pokémon, die dem Abgesang gelauscht haben, gehen nach drei Runden K.O.!",
						Language.FRE => "Les Pokémon au combat seront K.O. dans trois tours !",
						Language.ITA => "Tutti i Pokémon che ascoltano Ultimocanto andranno KO dopo tre turni!",
						Language.SPN => "¡Los Pokémon que oigan Canto Mortal se debilitarán dentro de tres turnos!",
						Language.KOR => "멸망의노래를 들은 포켓몬은 3턴 후에 쓰러져 버린다!",
						Language.CHN_SIM => "听过灭亡之歌的宝可梦３回合后就会灭亡！",
						Language.CHN_TRA => "聽過滅亡之歌的寶可夢３回合後就會滅亡！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_TOOK_AIM_AT_MON:
					return lang switch {
						Language.ENG => "\\$ took aim at \\$!",
						Language.JPN => "\\$は\\$にねらいをさだめた！",
						Language.GER => "\\$ zielt auf \\$!",
						Language.FRE => "\\$ vise \\$ !",
						Language.ITA => "\\$ prende la mira su \\$!",
						Language.SPN => "¡\\$ tiene en su punto de mira a \\$!",
						Language.KOR => "\\$ 목표를 \\$로 결정했다!",
						Language.CHN_SIM => "\\$将目标对准了\\$！",
						Language.CHN_TRA => "\\$將目標對準了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MAGNITUDE_N:
					return lang switch {
						Language.ENG => "Magnitude \\$!",
						Language.JPN => "マグニチュード\\$！",
						Language.GER => "Intensität \\$!",
						Language.FRE => "Ampleur \\$ !",
						Language.ITA => "Magnitudo \\$!",
						Language.SPN => "¡Magnitud \\$!",
						Language.KOR => "매그니튜드\\$!",
						Language.CHN_SIM => "震级\\$！",
						Language.CHN_TRA => "震級\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BURROWED_UNDER_THE_GROUND:
					return lang switch {
						Language.ENG => "\\$ burrowed its way under the ground!",
						Language.JPN => "\\$は{地面|じめん}に{潜|もぐ}った！",
						Language.GER => "\\$ vergräbt sich in der Erde!",
						Language.FRE => "\\$ se cache dans le sol !",
						Language.ITA => "\\$ si nasconde sottoterra!",
						Language.SPN => "¡\\$ se ha ocultado bajo tierra!",
						Language.KOR => "\\$ 땅으로 파고들었다!",
						Language.CHN_SIM => "\\$钻入了地里！",
						Language.CHN_TRA => "\\$鑽進了地下！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_FLEW_UP_HIGH:
					return lang switch {
						Language.ENG => "\\$ flew up high!",
						Language.JPN => "\\$は{空高|そらたか}く{飛|と}びあがった！",
						Language.GER => "\\$ fliegt hoch empor!",
						Language.FRE => "\\$ s’envole !",
						Language.ITA => "\\$ vola in alto!",
						Language.SPN => "¡\\$ ha volado muy alto!",
						Language.KOR => "\\$ 하늘 높이 날아올랐다!",
						Language.CHN_SIM => "\\$飞向了高空！",
						Language.CHN_TRA => "\\$飛向了高空！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HID_UNDER_WATER:
					return lang switch {
						Language.ENG => "\\$ hid underwater!",
						Language.JPN => "\\$は{水中|すいちゅう}に{身|み}を{潜|ひそ}めた！",
						Language.GER => "\\$ taucht unter!",
						Language.FRE => "\\$ se cache sous l’eau !",
						Language.ITA => "\\$ sparisce sott’acqua!",
						Language.SPN => "¡\\$ se ha ocultado bajo el agua!",
						Language.KOR => "\\$ 물속에 몸을 숨겼다!",
						Language.CHN_SIM => "\\$潜入了水中！",
						Language.CHN_TRA => "\\$潛入了水中！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_VANISHED_INSTANTLY:
					return lang switch {
						Language.ENG => "\\$ vanished instantly!",
						Language.JPN => "\\$の{姿|す}が{一瞬|いっしゅん}にして{消|き}えた！",
						Language.GER => "\\$ verschwindet augenblicklich!",
						Language.FRE => "\\$ disparaît instantanément !",
						Language.ITA => "\\$ sparisce improvvisamente!",
						Language.SPN => "¡\\$ desaparece en un abrir y cerrar de ojos!",
						Language.KOR => "\\$의 모습이 일순간에 사라졌다!",
						Language.CHN_SIM => "\\$的身影瞬间消失了！",
						Language.CHN_TRA => "\\$的身影瞬間消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SPRANG_UP:
					return lang switch {
						Language.ENG => "\\$ sprang up!",
						Language.JPN => "\\$は{高|たか}く{飛|と}び{跳|は}ねた！",
						Language.GER => "\\$ springt hoch in die Luft!",
						Language.FRE => "\\$ se propulse dans les airs !",
						Language.ITA => "\\$ spicca un gran balzo!",
						Language.SPN => "¡\\$ ha saltado muy alto!",
						Language.KOR => "\\$ 높이 뛰어올랐다!",
						Language.CHN_SIM => "\\$高高地跳了起来！",
						Language.CHN_TRA => "\\$高高地跳了起來！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_TOOK_MON_INTO_THE_SKY:
					return lang switch {
						Language.ENG => "\\$ took \\$ into the sky!",
						Language.JPN => "\\$は\\$を{上空|じょうくう}に{連|つ}れ{去|さ}った！",
						Language.GER => "\\$ entführt \\$ in luftige Höhen!",
						Language.FRE => "\\$ emporte \\$ haut dans le ciel !",
						Language.ITA => "\\$ trascina in aria \\$!",
						Language.SPN => "¡\\$ se ha llevado a \\$ por los aires!",
						Language.KOR => "\\$ \\$ 상공으로 데려갔다!",
						Language.CHN_SIM => "\\$将\\$带上了高空！",
						Language.CHN_TRA => "\\$將\\$帶上了高空！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_FELL_STRAIGHT_DOWN:
					return lang switch {
						Language.ENG => "\\$ fell straight down!",
						Language.JPN => "\\$は{撃|う}ちとされてにちた！",
						Language.GER => "\\$ ist herabgestürzt!",
						Language.FRE => "Touché dans les airs, \\$ s’écrase au sol !",
						Language.ITA => "\\$ si schianta al suolo!",
						Language.SPN => "¡\\$ ha sido derribado y ha caído al suelo!",
						Language.KOR => "\\$ 떨어뜨리기를 당해서 땅에 떨어졌다!",
						Language.CHN_SIM => "\\$被击落，掉到了地面！",
						Language.CHN_TRA => "\\$被擊落，掉到了地面！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_TAILWIND_START:
					return lang switch {
						Language.ENG => "The Tailwind blew from behind your team!",
						Language.JPN => "{味方|みかた}に{追|お}い{風|かぜ}が{吹|ふ}き{始|はじ}めた！",
						Language.GER => "Die Pokémon, die auf deiner Seite kämpfen, erhalten Rückenwind!",
						Language.FRE => "Un vent arrière souffle sur votre équipe !",
						Language.ITA => "Comincia a soffiare Ventoincoda sulla tua squadra!",
						Language.SPN => "¡El viento sopla a favor de tu equipo!",
						Language.KOR => "우리 편에게 순풍이 불기 시작했다!",
						Language.CHN_SIM => "从我方身后吹起了顺风！",
						Language.CHN_TRA => "從我方身後吹起了順風！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ENEMY_TAILWIND_START:
					return lang switch {
						Language.ENG => "The Tailwind blew from behind the opposing team!",
						Language.JPN => "{相手|あいて}に{追|お}い{風|かぜ}が{吹|ふ}き{始|はじ}めた！",
						Language.GER => "Die gegnerischen Pokémon erhalten Rückenwind!",
						Language.FRE => "Un vent arrière souffle sur l’équipe ennemie !",
						Language.ITA => "Comincia a soffiare Ventoincoda sulla squadra avversaria!",
						Language.SPN => "¡El viento sopla a favor del equipo rival!",
						Language.KOR => "상대에게 순풍이 불기 시작했다!",
						Language.CHN_SIM => "从对手身后吹起了顺风！",
						Language.CHN_TRA => "從對手身後吹起了順風！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_TAILWIND_END:
					return lang switch {
						Language.ENG => "Your team’s Tailwind petered out!",
						Language.JPN => "{味方|みかた}の{追|お}い{風|かぜ}が{止|や}んだ！",
						Language.GER => "Der Rückenwind auf deiner Seite hat sich gelegt!",
						Language.FRE => "Le vent arrière soufflant sur votre équipe s’arrête !",
						Language.ITA => "Ventoincoda non soffia più sulla tua squadra!",
						Language.SPN => "Ha dejado de soplar el viento que favorecía a tu equipo.",
						Language.KOR => "우리 편의 순풍이 멈췄다!",
						Language.CHN_SIM => "我方的顺风停止了！",
						Language.CHN_TRA => "我方的順風停止了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ENEMY_TAILWIND_END:
					return lang switch {
						Language.ENG => "The opposing team’s Tailwind petered out!",
						Language.JPN => "{相手|あいて}の{追|お}い{風|かぜ}が{止|や}んだ！",
						Language.GER => "Der Rückenwind auf gegnerischer Seite hat sich gelegt!",
						Language.FRE => "Le vent arrière soufflant sur l’équipe ennemie s’arrête !",
						Language.ITA => "Ventoincoda non soffia più sulla squadra avversaria!",
						Language.SPN => "Ha dejado de soplar el viento que favorecía al equipo rival.",
						Language.KOR => "상대의 순풍이 멈췄다!",
						Language.CHN_SIM => "对手的顺风停止了！",
						Language.CHN_TRA => "對手的順風停止了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.THROAT_CHOP_PREVENTS_MON_FROM_USING_CERTAIN_MOVES:
					return lang switch {
						Language.ENG => "The effects of Throat Chop prevent \\$ from using certain moves!",
						Language.JPN => "\\$はじごくづきの{効果|こうか}で{技|わざ}が{出|だ}せない！",
						Language.GER => "\\$ kann die Attacke durch die Wirkung von Neck Strike nicht einsetzen!",
						Language.FRE => "Exécu-Son empêche \\$ d’utiliser la capacité !",
						Language.ITA => "Colpo Infernale impedisce a \\$ di usare la mossa!",
						Language.SPN => "¡El efecto de Golpe Mordaza impide a \\$ usar el movimiento!",
						Language.KOR => "\\$ 지옥찌르기 효과로 기술을 쓸 수 없다!",
						Language.CHN_SIM => "\\$因地狱突刺的效果无法使出招式！",
						Language.CHN_TRA => "\\$因地獄突刺的效果而無法使出招式！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_FELL_FOR_THE_TAUNT:
					return lang switch {
						Language.ENG => "\\$ fell for the taunt!",
						Language.JPN => "\\$は{挑発|ちょうはつ}に{乗|の}ってしまった！",
						Language.GER => "\\$ fällt auf Verhöhner herein!",
						Language.FRE => "\\$ répond à la Provoc !",
						Language.ITA => "\\$ è in balia di Provocazione!",
						Language.SPN => "¡\\$ se ha dejado engañar por una mofa!",
						Language.KOR => "\\$ 도발에 넘어가 버렸다!",
						Language.CHN_SIM => "\\$中了挑衅！",
						Language.CHN_TRA => "\\$中了挑釁！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANNOT_USE_MOVE_AFTER_THE_TAUNT:
					return lang switch {
						Language.ENG => "\\$ can’t use \\$ after the taunt!",
						Language.JPN => "\\$は{挑発|ちょうはつ}されて\\$がだせない！",
						Language.GER => "\\$ kann \\$ nach Verhöhner nicht einsetzen!",
						Language.FRE => "\\$ ne peut pas utiliser la capacité \\$ après la Provoc !",
						Language.ITA => "A causa di Provocazione \\$ non può usare \\$!",
						Language.SPN => "¡Se han mofado de \\$, por lo que no puede usar \\$!",
						Language.KOR => "\\$ 도발당한 상태라서 \\$ 쓸 수 없다!",
						Language.CHN_SIM => "\\$受到了挑衅，无法使出\\$！",
						Language.CHN_TRA => "\\$受到了挑釁，無法使出\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SHOOK_OFF_THE_TAUNT:
					return lang switch {
						Language.ENG => "\\$ shook off the taunt!",
						Language.JPN => "\\$は{挑発|ちょうはつ}の{効果|こうか}が{解|と}けた！",
						Language.GER => "Verhöhner wirkt nicht mehr auf \\$!",
						Language.FRE => "\\$ s’est remis de la Provoc !",
						Language.ITA => "Provocazione non ha più effetto su \\$!",
						Language.SPN => "¡\\$ ya se ha olvidado de la mofa!",
						Language.KOR => "\\$ 도발의 효과가 풀렸다!",
						Language.CHN_SIM => "\\$的挑衅效果解除了！",
						Language.CHN_TRA => "\\$的挑釁效果解除了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.WATER_SPORT_START:
					return lang switch {
						Language.ENG => "Fire’s power was weakened!",
						Language.JPN => "{炎|ほ}の{威力|いりょく}が{弱|よわ}まった！",
						Language.GER => "Die Stärke aller Feuer-Attacken wurde reduziert!",
						Language.FRE => "La puissance des capacités de type Feu est diminuée !",
						Language.ITA => "La potenza delle mosse di tipo Fuoco diminuisce!",
						Language.SPN => "¡La potencia de los ataques de fuego ha disminuido!",
						Language.KOR => "불꽃의 위력이 약해졌다!",
						Language.CHN_SIM => "火焰的威力减弱了！",
						Language.CHN_TRA => "火焰的威力減弱了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.WATER_SPORT_END:
					return lang switch {
						Language.ENG => "The effects of Water Sport have faded.",
						Language.JPN => "みずあそびの{効果|こうか}がなくなった！",
						Language.GER => "Nassmacher hört auf zu wirken!",
						Language.FRE => "L’effet de Tourniquet se dissipe !",
						Language.ITA => "L’effetto di Docciascudo è svanito!",
						Language.SPN => "Hidrochorro ha dejado de surtir efecto.",
						Language.KOR => "물놀이의 효과가 없어졌다!",
						Language.CHN_SIM => "玩水的效果消失了！",
						Language.CHN_TRA => "玩水的效果消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MUD_SPORT_START:
					return lang switch {
						Language.ENG => "Electricity’s power was weakened!",
						Language.JPN => "{電気|でんき}の{威力|いりょく}が{弱|よわ}まった！",
						Language.GER => "Die Stärke aller Elektro-Attacken wurde reduziert!",
						Language.FRE => "La puissance des capacités de type Électrik est diminuée !",
						Language.ITA => "La potenza delle mosse di tipo Elettro diminuisce!",
						Language.SPN => "¡La potencia de los movimientos eléctricos ha disminuido!",
						Language.KOR => "전기의 위력이 약해졌다!",
						Language.CHN_SIM => "电气的威力减弱了！",
						Language.CHN_TRA => "電氣的威力減弱了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MUD_SPORT_END:
					return lang switch {
						Language.ENG => "The effects of Mud Sport have faded.",
						Language.JPN => "どろあそびの{効果|こうか}がなくなった！",
						Language.GER => "Lehmsuhler hört auf zu wirken!",
						Language.FRE => "L’effet de Lance-Boue se dissipe !",
						Language.ITA => "L’effetto di Fangata è svanito!",
						Language.SPN => "Chapoteo Lodo ha dejado de surtir efecto.",
						Language.KOR => "흙놀이의 효과가 없어졌다!",
						Language.CHN_SIM => "玩泥巴的效果消失了！",
						Language.CHN_TRA => "玩泥巴的效果消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.CANNOT_USE_MOVE_TWICE_IN_A_ROW:
					return lang switch {
						Language.ENG => "You can’t use \\$ twice in a row!",
						Language.JPN => "\\$は２{回|かい}{続|つづ}けて{出|だ}すことができない！",
						Language.GER => "\\$ kann nicht zweimal hintereinander eingesetzt werden!",
						Language.FRE => "Vous ne pouvez pas utiliser \\$ deux fois d’affilée.",
						Language.ITA => "Non puoi usare \\$ due volte di fila!",
						Language.SPN => "¡No puedes usar \\$ dos veces seguidas!",
						Language.KOR => "\\$ 2번 연속으로 쓸 수 없다!",
						Language.CHN_SIM => "不能连续使出２次\\$！",
						Language.CHN_TRA => "無法連續２次使出\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BECAME_CLOAKED_IN_A_HARSH_LIGHT:
					return lang switch {
						Language.ENG => "\\$ became cloaked in a harsh light!",
						Language.JPN => "\\$を{激|はげ}しい{光|ひかり}が{包|つつ}む！",
						Language.GER => "\\$ leuchtet grell!",
						Language.FRE => "\\$ est entouré d’une lumière intense !",
						Language.ITA => "\\$ è avvolto da una luce intensa!",
						Language.SPN => "¡Un intenso halo rodea a \\$!",
						Language.KOR => "\\$ 세찬 빛이 감쌌다!",
						Language.CHN_SIM => "强光包围了\\$！",
						Language.CHN_TRA => "強光包圍了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_ABSORBED_LIGHT:
					return lang switch {
						Language.ENG => "\\$ absorbed light!",
						Language.JPN => "\\$は{光|ひかり}を{吸収|きゅうしゅう}した！",
						Language.GER => "\\$ absorbiert Sonnenlicht!",
						Language.FRE => "\\$ absorbe la lumière !",
						Language.ITA => "\\$ assorbe la luce!",
						Language.SPN => "¡\\$ ha absorbido la luz solar!",
						Language.KOR => "\\$ 빛을 흡수했다!",
						Language.CHN_SIM => "\\$吸收了光！",
						Language.CHN_TRA => "\\$吸收了光線！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CLOAKED_IN_FREEZING_LIGHT:
					return lang switch {
						Language.ENG => "\\$ became cloaked in a freezing light!",
						Language.JPN => "\\$は{冷|つめ}たいにまれた！",
						Language.GER => "\\$ wird von einem kühlen Licht umhüllt!",
						Language.FRE => "\\$ est baigné d’une lumière blafarde !",
						Language.ITA => "\\$ è avvolto da una luce fredda!",
						Language.SPN => "¡Una luz fría envuelve a \\$!",
						Language.KOR => "\\$ 차가운 빛에 둘러싸였다!",
						Language.CHN_SIM => "\\$被冷光包围了！",
						Language.CHN_TRA => "\\$被冷光包圍了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CLOAKED_IN_FREEZING_AIR:
					return lang switch {
						Language.ENG => "\\$ became cloaked in freezing air!",
						Language.JPN => "\\$は{凍|こご}える{空気|くうき}に{包|つつ}まれた！",
						Language.GER => "\\$ wird in klirrend kalte Luft gehüllt!",
						Language.FRE => "\\$ est entouré d’un air glacial !",
						Language.ITA => "\\$ è avvolto da un’atmosfera gelida!",
						Language.SPN => "¡Una ráfaga gélida envuelve a \\$!",
						Language.KOR => "\\$ 차디찬 공기에 둘러싸였다!",
						Language.CHN_SIM => "\\$被冰冻的空气包围了！",
						Language.CHN_TRA => "\\$被冰凍的空氣包圍了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_ABSORBING_POWER:
					return lang switch {
						Language.ENG => "\\$ is absorbing power!",
						Language.JPN => "\\$はパワーをためこんでいる！",
						Language.GER => "\\$ saugt Kraft in sich auf!",
						Language.FRE => "\\$ concentre son énergie !",
						Language.ITA => "\\$ accumula energia!",
						Language.SPN => "¡\\$ está acumulando energía!",
						Language.KOR => "\\$ 파워를 모으고 있다!",
						Language.CHN_SIM => "\\$正在积蓄力量！",
						Language.CHN_TRA => "\\$正在積蓄力量！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_OVERFLOWING_WITH_SPACE_POWER:
					return lang switch {
						Language.ENG => "\\$ is overflowing with space power!",
						Language.JPN => "\\$に{宇宙|うちゅう}の{力|ちから}があふれだす！",
						Language.GER => "Kosmische Kräfte strömen aus \\$!",
						Language.FRE => "La puissance du cosmos afflue dans le corps \\$ !",
						Language.ITA => "La forza dell’universo pervade \\$!",
						Language.SPN => "¡\\$ rebosa energía cósmica!",
						Language.KOR => "\\$에게서 우주의 힘이 넘쳐난다!",
						Language.CHN_SIM => "\\$身上溢出了宇宙之力！",
						Language.CHN_TRA => "\\$湧起了宇宙的力量！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_TUCKED_IN_ITS_HEAD:
					return lang switch {
						Language.ENG => "\\$ tucked in its head!",
						Language.JPN => "\\$は{首|くび}を{引|ひ}っこめた！",
						Language.GER => "\\$ zieht seinen Kopf ein!",
						Language.FRE => "\\$ baisse la tête !",
						Language.ITA => "\\$ abbassa la testa!",
						Language.SPN => "¡\\$ ha agachado la cabeza!",
						Language.KOR => "\\$ 목을 움츠렸다!",
						Language.CHN_SIM => "\\$把头缩了进去！",
						Language.CHN_TRA => "\\$把頭縮了進去！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MONS_MOVE_WAS_DISABLED:
					return lang switch {
						Language.ENG => "\\$’s \\$ was disabled!",
						Language.JPN => "\\$の\\$を{封|ふう}じこめた！",
						Language.GER => "\\$ von \\$ wurde blockiert!",
						Language.FRE => "La capacité \\$ \\$ est mise sous entrave !",
						Language.ITA => "La mossa \\$ di \\$ è stata bloccata!",
						Language.SPN => "¡Se ha anulado el movimiento \\$ de \\$!",
						Language.KOR => "\\$의 \\$ 봉인했다!",
						Language.CHN_SIM => "封住了\\$的\\$！",
						Language.CHN_TRA => "封住了\\$的\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_BRACED_ITSELF:
					return lang switch {
						Language.ENG => "\\$ braced itself!",
						Language.JPN => "\\$はこらえる{体勢|たいせい}に{入|はい}った！",
						Language.GER => "\\$ sammelt sich, um die nächste Attacke zu überstehen!",
						Language.FRE => "\\$ se prépare à encaisser les coups !",
						Language.ITA => "\\$ si prepara a ricevere il colpo!",
						Language.SPN => "¡\\$ se prepara para resistir los ataques!",
						Language.KOR => "\\$ 버티기 태세에 들어갔다!",
						Language.CHN_SIM => "\\$摆出了挺住攻击的架势！",
						Language.CHN_TRA => "\\$擺出了挺住攻擊的架勢！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_STORING_ENERGY:
					return lang switch {
						Language.ENG => "\\$ is storing energy!",
						Language.JPN => "\\$はがまんしている",
						Language.GER => "\\$ speichert Energie!",
						Language.FRE => "\\$ prend son mal en patience !",
						Language.ITA => "\\$ accumula energia!",
						Language.SPN => "¡\\$ está acumulando energía!",
						Language.KOR => "\\$ 참고 있다",
						Language.CHN_SIM => "\\$正在忍耐。",
						Language.CHN_TRA => "\\$正在忍耐。",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_UNLEASHED_ITS_ENERGY:
					return lang switch {
						Language.ENG => "\\$ unleashed its energy!",
						Language.JPN => "\\$のがまんが{解|と}かれた！",
						Language.GER => "\\$ setzt Energie frei!",
						Language.FRE => "\\$ perd patience et se déchaîne !",
						Language.ITA => "\\$ libera energia!",
						Language.SPN => "¡\\$ ha liberado la energía!",
						Language.KOR => "\\$의 참기가 풀렸다!",
						Language.CHN_SIM => "\\$的忍耐被解除了！",
						Language.CHN_TRA => "\\$的忍耐被解除了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_REFLECT:
					return lang switch {
						Language.ENG => "Reflect made the opposing team stronger against physical moves!",
						Language.JPN => "{相手|あいて}はリフレクターで{物理|ぶつり}に{強|つよ}くなった！",
						Language.GER => "Reflektor stärkt gegnerische Pokémon gegen physische Attacken!",
						Language.FRE => "Protection augmente la résistance de l’équipe ennemie aux capacités physiques !",
						Language.ITA => "La resistenza della squadra avversaria agli attacchi fisici aumenta grazie a Riflesso!",
						Language.SPN => "¡Reflejo ha aumentado la resistencia del equipo enemigo ante los ataques físicos!",
						Language.KOR => "상대는 리플렉터로 물리공격에 강해졌다!",
						Language.CHN_SIM => "反射壁使对手的物理抗性提高了！",
						Language.CHN_TRA => "反射壁使對手的物理抗性提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_REFLECT:
					return lang switch {
						Language.ENG => "Reflect made your team stronger against physical moves!",
						Language.JPN => "{味方|みかた}はリフレクターで{物理|ぶつり}に{強|つよ}くなった！",
						Language.GER => "Reflektor stärkt Pokémon auf deiner Seite gegen physische Attacken!",
						Language.FRE => "Protection augmente la résistance de l’équipe aux capacités physiques !",
						Language.ITA => "La resistenza della tua squadra agli attacchi fisici aumenta grazie a Riflesso!",
						Language.SPN => "¡Reflejo ha aumentado la resistencia de tu equipo ante los ataques físicos!",
						Language.KOR => "우리 편은 리플렉터로 물리공격에 강해졌다!",
						Language.CHN_SIM => "反射壁使我方的物理抗性提高了！",
						Language.CHN_TRA => "反射壁使我方的物理抗性提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_LIGHT_SCREEN:
					return lang switch {
						Language.ENG => "Light Screen made your team stronger against special moves!",
						Language.JPN => "{味方|みかた}はひかりのかべで{特殊|とくしゅ}に{強|つよ}くなった！",
						Language.GER => "Lichtschild stärkt Pokémon, die auf deiner Seite kämpfen, gegen Spezial-Attacken!",
						Language.FRE => "Mur Lumière augmente la résistance de l’équipe aux capacités spéciales !",
						Language.ITA => "La resistenza della tua squadra agli attacchi speciali aumenta grazie a Schermoluce!",
						Language.SPN => "¡Pantalla de Luz ha aumentado la resistencia de tu equipo ante los ataques especiales!",
						Language.KOR => "우리 편은 빛의장막으로 특수공격에 강해졌다!",
						Language.CHN_SIM => "光墙使我方的特殊抗性提高了！",
						Language.CHN_TRA => "光牆使我方的特殊抗性提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_LIGHT_SCREEN:
					return lang switch {
						Language.ENG => "Light Screen made the opposing team stronger against special moves!",
						Language.JPN => "{相手|あいて}はひかりのかべで{特殊|とくしゅ}に{強|つよ}くなった！",
						Language.GER => "Lichtschild stärkt gegnerische Pokémon gegen Spezial-Attacken!",
						Language.FRE => "Mur Lumière augmente la résistance de l’équipe ennemie aux capacités spéciales !",
						Language.ITA => "La resistenza della squadra avversaria agli attacchi speciali aumenta grazie a Schermoluce!",
						Language.SPN => "¡Pantalla de Luz ha aumentado la resistencia del equipo enemigo ante los ataques especiales!",
						Language.KOR => "상대는 빛의장막으로 특수공격에 강해졌다!",
						Language.CHN_SIM => "光墙使对手的特殊抗性提高了！",
						Language.CHN_TRA => "光牆使對手的特殊抗性提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_LIGHT_SCREEN_WORE_OFF:
					return lang switch {
						Language.ENG => "Your team’s Light Screen wore off!",
						Language.JPN => "{味方|みかた}のひかりのかべがなくなった！",
						Language.GER => "Lichtschild auf deiner Seite hört auf zu wirken!",
						Language.FRE => "Mur Lumière n’a plus d’effet sur l’équipe !",
						Language.ITA => "L’effetto di Schermoluce sulla tua squadra è finito!",
						Language.SPN => "El efecto de Pantalla de Luz en tu equipo se ha disipado.",
						Language.KOR => "우리 편의 빛의장막이 없어졌다!",
						Language.CHN_SIM => "我方的光墙消失了！",
						Language.CHN_TRA => "我方的光牆消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_LIGHT_SCREEN_WORE_OFF:
					return lang switch {
						Language.ENG => "The opposing team’s Light Screen wore off!",
						Language.JPN => "{相手|あいて}のひかりのかべがなくなった！",
						Language.GER => "Lichtschild der gegnerischen Pokémon hört auf zu wirken!",
						Language.FRE => "Mur Lumière n’a plus d’effet sur l’équipe ennemie !",
						Language.ITA => "L’effetto di Schermoluce sulla squadra avversaria è finito!",
						Language.SPN => "El efecto de Pantalla de Luz en el equipo enemigo se ha disipado.",
						Language.KOR => "상대의 빛의장막이 없어졌다!",
						Language.CHN_SIM => "对手的光墙消失了！",
						Language.CHN_TRA => "對手的光牆消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_REFLECT_WORE_OFF:
					return lang switch {
						Language.ENG => "Your team’s Reflect wore off!",
						Language.JPN => "{味方|みかた}のリフレクターがなくなった！",
						Language.GER => "Reflektor auf deiner Seite hört auf zu wirken!",
						Language.FRE => "Protection n’a plus d’effet sur l’équipe !",
						Language.ITA => "L’effetto di Riflesso sulla tua squadra è finito!",
						Language.SPN => "El efecto de Reflejo en tu equipo se ha disipado.",
						Language.KOR => "우리 편의 리플렉터가 없어졌다!",
						Language.CHN_SIM => "我方的反射壁消失了！",
						Language.CHN_TRA => "我方的反射壁消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_REFLECT_WORE_OFF:
					return lang switch {
						Language.ENG => "The opposing team’s Reflect wore off!",
						Language.JPN => "{相手|あいて}のリフレクターがなくなった！",
						Language.GER => "Reflektor der gegnerischen Pokémon hört auf zu wirken!",
						Language.FRE => "Protection n’a plus d’effet sur l’équipe ennemie !",
						Language.ITA => "L’effetto di Riflesso sulla squadra avversaria è finito!",
						Language.SPN => "El efecto de Reflejo en el equipo enemigo se ha disipado.",
						Language.KOR => "상대의 리플렉터가 없어졌다!",
						Language.CHN_SIM => "对手的反射壁消失了！",
						Language.CHN_TRA => "對手的反射壁消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_AURORA_VEIL:
					return lang switch {
						Language.ENG => "Aurora Veil made your team stronger against physical and special moves!",
						Language.JPN => "{味方|みかた}はオーロラベールで{物理|ぶつり}と{特殊|くしゅ}に{強|つよ}くなった！",
						Language.GER => "Auroraschleier stärkt Pokémon auf deiner Seite gegen physische und Spezial-Attacken!",
						Language.FRE => "Voile Aurore augmente la résistance des Pokémon de l’équipe aux capacités physiques et spéciales !",
						Language.ITA => "La resistenza della tua squadra agli attacchi fisici e speciali aumenta grazie a Velaurora!",
						Language.SPN => "¡Velo Aurora ha aumentado la resistencia de tu equipo ante los ataques físicos y especiales!",
						Language.KOR => "우리 편은 오로라베일로 물리공격과 특수공격에 강해졌다!",
						Language.CHN_SIM => "极光幕使我方的物理和特殊抗性提高了！",
						Language.CHN_TRA => "極光幕使我方的物理和特殊抗性提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_AURORA_VEIL:
					return lang switch {
						Language.ENG => "Aurora Veil made the opposing team stronger against physical and special moves!",
						Language.JPN => "{相手|あいて}はオーロラベールで{物理|ぶつり}と{特殊|くしゅ}に{強|つよ}くなった！",
						Language.GER => "Auroraschleier stärkt gegnerische Pokémon gegen physische und Spezial-Attacken!",
						Language.FRE => "Voile Aurore augmente la résistance des Pokémon de l’équipe ennemie aux capacités physiques et spéciales !",
						Language.ITA => "La resistenza della squadra avversaria agli attacchi fisici e speciali aumenta grazie a Velaurora!",
						Language.SPN => "¡Velo Aurora ha aumentado la resistencia del equipo enemigo ante los ataques físicos y especiales!",
						Language.KOR => "상대는 오로라베일로 물리공격과 특수공격에 강해졌다!",
						Language.CHN_SIM => "极光幕使对手的物理和特殊抗性提高了！",
						Language.CHN_TRA => "極光幕使對手的物理和特殊抗性提高了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.ALLY_AURORA_VEIL_WORE_OFF:
					return lang switch {
						Language.ENG => "Your team’s Aurora Veil wore off!",
						Language.JPN => "{味方|みかた}のオーロラベールがなくなった！",
						Language.GER => "Der Auroraschleier, der dein Team umgab, hat sich gelüftet!",
						Language.FRE => "Voile Aurore n’a plus d’effet sur l’équipe !",
						Language.ITA => "L’effetto di Velaurora sulla tua squadra è finito!",
						Language.SPN => "El efecto de Velo Aurora en tu equipo se ha disipado.",
						Language.KOR => "우리 편의 오로라베일이 없어졌다!",
						Language.CHN_SIM => "我方的极光幕消失了！",
						Language.CHN_TRA => "我方的極光幕消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_AURORA_VEIL_WORE_OFF:
					return lang switch {
						Language.ENG => "The opposing team’s Aurora Veil wore off!",
						Language.JPN => "{相手|あいて}のオーロラベールがなくなった！",
						Language.GER => "Der Auroraschleier, der das gegnerische Team umgab, hat sich gelüftet!",
						Language.FRE => "Voile Aurore n’a plus d’effet sur l’équipe ennemie !",
						Language.ITA => "L’effetto di Velaurora sulla squadra avversaria è finito!",
						Language.SPN => "El efecto de Velo Aurora en el equipo enemigo se ha disipado.",
						Language.KOR => "상대의 오로라베일이 없어졌다!",
						Language.CHN_SIM => "对手的极光幕消失了！",
						Language.CHN_TRA => "對手的極光幕消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PAIN_SPLIT:
					return lang switch {
						Language.ENG => "The battlers shared their pain!",
						Language.JPN => "おたがいの{体力|たいりょく}を{分|わ}かちあった！",
						Language.GER => "Die Kontrahenten teilen sich ihre KP!",
						Language.FRE => "Les adversaires partagent leurs PV !",
						Language.ITA => "I Pokémon si dividono i PS!",
						Language.SPN => "¡Los combatientes comparten sus PS!",
						Language.KOR => "서로의 체력을 나누어 가졌다!",
						Language.CHN_SIM => "均分了彼此的体力！",
						Language.CHN_TRA => "均分了彼此的體力！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SKETCHED_MOVE:
					return lang switch {
						Language.ENG => "\\$ sketched \\$!",
						Language.JPN => "\\$は\\$をスケッチした！",
						Language.GER => "\\$ ahmt die Attacke \\$ nach!",
						Language.FRE => "\\$ gribouille \\$ !",
						Language.ITA => "\\$ disegna uno schizzo della mossa \\$!",
						Language.SPN => "\\$¡\\$ ha usado Esquema para copiar \\$!",
						Language.KOR => "\\$ \\$ 스케치했다!",
						Language.CHN_SIM => "\\$对\\$进行了写生！",
						Language.CHN_TRA => "\\$對\\$進行了寫生！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_PUT_A_CURSE_ON_MON:
					return lang switch {
						Language.ENG => "\\$ cut its own HP and put a curse on \\$!",
						Language.JPN => "\\$は{自分|じぶん}の{体力|ろい}をって\\$にのろいをかけた！",
						Language.GER => "\\$ nimmt einen Teil seiner KP und legt einen Fluch auf \\$!",
						Language.FRE => "\\$ sacrifie des PV et lance une malédiction à \\$ !",
						Language.ITA => "\\$ riduce i suoi PS per lanciare una maledizione su \\$!",
						Language.SPN => "¡\\$ sacrifica algunos PS y maldice a \\$!",
						Language.KOR => "\\$ 자신의 체력을 깎아서 \\$에게 저주를 걸었다!",
						Language.CHN_SIM => "\\$削减了自己的体力，并诅咒了\\$！",
						Language.CHN_TRA => "\\$削減了自己的體力，並詛咒了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_AFFLICTED_BY_CURSE:
					return lang switch {
						Language.ENG => "\\$ is afflicted by the curse!",
						Language.JPN => "\\$はのろわれている！",
						Language.GER => "\\$ wurde durch den Fluch verletzt!",
						Language.FRE => "\\$ est touché par la malédiction !",
						Language.ITA => "\\$ è colpito dalla maledizione!",
						Language.SPN => "¡\\$ es víctima de una maldición!",
						Language.KOR => "\\$ 저주받고 있다!",
						Language.CHN_SIM => "\\$正受到诅咒！",
						Language.CHN_TRA => "\\$正受到詛咒！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.STONES_DUG_INTO_MON:
					return lang switch {
						Language.ENG => "Pointed stones dug into \\$!",
						Language.JPN => "\\$にとがった{岩|いわ}が{食|く}いこんだ！",
						Language.GER => "\\$ wird von spitzen Steinen getroffen!",
						Language.FRE => "Des pierres pointues transpercent \\$ !",
						Language.ITA => "Rocce aguzze colpiscono \\$!",
						Language.SPN => "¡Unas piedras puntiagudas han dañado a \\$!",
						Language.KOR => "\\$에게 뾰족한 바위가 박혔다!",
						Language.CHN_SIM => "尖锐的岩石扎进了\\$的体内！",
						Language.CHN_TRA => "尖銳的岩石扎進了\\$的體內！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_USED_STEALTH_ROCK:
					return lang switch {
						Language.ENG => "Pointed stones float in the air around your team!",
						Language.JPN => "{味方|みかた}の{周|まわ}りにとがったがただよいめた！",
						Language.GER => "Um die Pokémon auf deiner Seite schweben spitze Steine!",
						Language.FRE => "Des pierres pointues lévitent autour de votre équipe !",
						Language.ITA => "La tua squadra è circondata da rocce aguzze sospese in aria!",
						Language.SPN => "¡Tu equipo está rodeado de piedras puntiagudas!",
						Language.KOR => "우리 편 주변에 뾰족한 바위가 떠다니기 시작했다!",
						Language.CHN_SIM => "我方周围开始浮现出尖锐的岩石！",
						Language.CHN_TRA => "我方周圍開始浮現出尖銳的岩石！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_USED_STEALTH_ROCK:
					return lang switch {
						Language.ENG => "Pointed stones float in the air around the opposing team!",
						Language.JPN => "{相手|あいて}の{周|まわ}りにとがったがただよいめた！",
						Language.GER => "Um die Pokémon auf gegnerischer Seite schweben spitze Steine!",
						Language.FRE => "Des pierres pointues lévitent autour de l’équipe ennemie !",
						Language.ITA => "La squadra avversaria è circondata da rocce aguzze sospese in aria!",
						Language.SPN => "¡El equipo enemigo está rodeado de piedras puntiagudas!",
						Language.KOR => "상대의 주변에 뾰족한 바위가 떠다니기 시작했다!",
						Language.CHN_SIM => "对手周围开始浮现出尖锐的岩石！",
						Language.CHN_TRA => "對手周圍開始浮現出尖銳的岩石！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_STEALTH_ROCKS_DISAPPEAR:
					return lang switch {
						Language.ENG => "The pointed stones disappeared from around your team!",
						Language.JPN => "{味方|みかた}のりのステルスロックが{周消|き}え{去|さ}った！",
						Language.GER => "Die spitzen Steine auf deiner Seite sind verschwunden!",
						Language.FRE => "Les pierres pointues autour de votre équipe ont disparu !",
						Language.ITA => "Levitoroccia non ha più effetto sulla tua squadra!",
						Language.SPN => "Las piedras puntiagudas lanzadas a tu equipo han desaparecido.",
						Language.KOR => "우리 편 주변의 스텔스록이 사라졌다!",
						Language.CHN_SIM => "我方周围的隐形岩消失不见了！",
						Language.CHN_TRA => "我方周圍的隱形岩消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_STEALTH_ROCKS_DISAPPEAR:
					return lang switch {
						Language.ENG => "The pointed stones disappeared from around the opposing team!",
						Language.JPN => "{相手|あいて}のりのステルスロックが{周消|き}え{去|さ}った！",
						Language.GER => "Die spitzen Steine auf der gegnerischen Seite sind verschwunden!",
						Language.FRE => "Les pierres pointues autour de l’équipe ennemie ont disparu !",
						Language.ITA => "Levitoroccia non ha più effetto sulla squadra avversaria!",
						Language.SPN => "Las piedras puntiagudas lanzadas al equipo enemigo han desaparecido.",
						Language.KOR => "상대 주변의 스텔스록이 사라졌다!",
						Language.CHN_SIM => "对手周围的隐形岩消失不见了！",
						Language.CHN_TRA => "對手周圍的隱形岩消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_USED_TOXIC_SPIKES:
					return lang switch {
						Language.ENG => "Poison spikes were scattered on the ground all around your team!",
						Language.JPN => "{味方|みかた}の{足下|あしもと}にどくびしが{散|ち}らばった！",
						Language.GER => "Die Pokémon auf deiner Seite sind überall von giftigen Stacheln umgeben!",
						Language.FRE => "Des pics toxiques se répandent autour de votre équipe !",
						Language.ITA => "Ai piedi della tua squadra c’è una trappola di Fielepunte!",
						Language.SPN => "¡Tu equipo ha sido rodeado de púas tóxicas!",
						Language.KOR => "우리 편의 발밑에 독압정이 뿌려졌다!",
						Language.CHN_SIM => "我方脚下散落着毒菱！",
						Language.CHN_TRA => "我方腳下散落著毒菱！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_USED_TOXIC_SPIKES:
					return lang switch {
						Language.ENG => "Poison spikes were scattered on the ground all around the opposing team!",
						Language.JPN => "{相手|あいて}の{足下|あしもと}にどくびしが{散|ち}らばった！",
						Language.GER => "Die Pokémon auf gegnerischer Seite sind überall von giftigen Stacheln umgeben!",
						Language.FRE => "Des pics toxiques se répandent autour de l’équipe ennemie !",
						Language.ITA => "Ai piedi della squadra avversaria c’è una trappola di Fielepunte!",
						Language.SPN => "¡El equipo enemigo ha sido rodeado de púas tóxicas!",
						Language.KOR => "상대의 발밑에 독압정이 뿌려졌다!",
						Language.CHN_SIM => "对手脚下散落着毒菱！",
						Language.CHN_TRA => "對手腳下散落著毒菱！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_TOXIC_SPIKES_DISAPPEARED:
					return lang switch {
						Language.ENG => "The poison spikes disappeared from the ground around your team!",
						Language.JPN => "{味方|みかた}ののどくびしが{足下消|き}え{去|さ}った！",
						Language.GER => "Die giftigen Stacheln, die auf deiner Seite herumlagen, sind verschwunden!",
						Language.FRE => "Il n’y a plus de pics toxiques autour de votre équipe !",
						Language.ITA => "Ai piedi della tua squadra non c’è più la trappola di Fielepunte!",
						Language.SPN => "Las púas tóxicas lanzadas a tu equipo han desaparecido.",
						Language.KOR => "우리 편 발밑의 독압정이 사라졌다!",
						Language.CHN_SIM => "我方脚下的毒菱消失不见了！",
						Language.CHN_TRA => "我方腳下的毒菱消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_TOXIC_SPIKES_DISAPPEARED:
					return lang switch {
						Language.ENG => "The poison spikes disappeared from the ground around the opposing team!",
						Language.JPN => "{相手|あいて}ののどくびしが{足下消|き}え{去|さ}った！",
						Language.GER => "Die giftigen Stacheln, die auf der gegnerischen Seite herumlagen, sind verschwunden!",
						Language.FRE => "Il n’y a plus de pics toxiques autour de l’équipe ennemie !",
						Language.ITA => "Ai piedi della squadra avversaria non c’è più la trappola di Fielepunte!",
						Language.SPN => "Las púas tóxicas lanzadas al equipo enemigo han desaparecido.",
						Language.KOR => "상대 발밑의 독압정이 사라졌다!",
						Language.CHN_SIM => "对手脚下的毒菱消失不见了！",
						Language.CHN_TRA => "對手腳下的毒菱消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_USED_STICKY_WEB:
					return lang switch {
						Language.ENG => "A sticky web has been laid out on the ground around your team!",
						Language.JPN => "{味方|みかた}の{足下|あしもと}にねばねばネットががった！",
						Language.GER => "Am Boden um die Pokémon auf deiner Seite entspinnt sich ein Klebenetz!",
						Language.FRE => "Le terrain est couvert d’une toile gluante du côté de votre équipe !",
						Language.ITA => "Una Rete Vischiosa viene stesa ai piedi della tua squadra!",
						Language.SPN => "¡Una red viscosa se extiende a los pies de tu equipo!",
						Language.KOR => "우리 편 발밑에 끈적끈적네트가 펼쳐졌다!",
						Language.CHN_SIM => "我方的脚下延伸出了黏黏网！",
						Language.CHN_TRA => "我方的腳下張開了黏黏網！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_USED_STICKY_WEB:
					return lang switch {
						Language.ENG => "A sticky web has been laid out on the ground around the opposing team!",
						Language.JPN => "{相手|あいて}の{足下|あしもと}にねばねばネットががった！",
						Language.GER => "Am Boden um die Pokémon auf der gegnerischen Seite entspinnt sich ein Klebenetz!",
						Language.FRE => "Le terrain est couvert d’une toile gluante du côté de l’équipe ennemie !",
						Language.ITA => "Una Rete Vischiosa viene stesa ai piedi della squadra avversaria!",
						Language.SPN => "¡Una red viscosa se extiende a los pies del equipo rival!",
						Language.KOR => "상대 발밑에 끈적끈적네트가 펼쳐졌다!",
						Language.CHN_SIM => "对手的脚下延伸出了黏黏网！",
						Language.CHN_TRA => "對手的腳下張開了黏黏網！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_STICKY_WEB_DISAPPEARED:
					return lang switch {
						Language.ENG => "The sticky web has disappeared from the ground around you!",
						Language.JPN => "{味方|みかた}ののねばねばネットが{足下消|き}え{去|さ}った！",
						Language.GER => "Das Klebenetz auf deiner Seite ist wieder verschwunden!",
						Language.FRE => "La toile gluante du côté de votre équipe a disparu !",
						Language.ITA => "La Rete Vischiosa ai piedi della tua squadra svanisce!",
						Language.SPN => "La red viscosa que rodeaba a tu equipo ha desaparecido.",
						Language.KOR => "우리 편 발밑의 끈적끈적네트가 사라졌다!",
						Language.CHN_SIM => "我方脚下的黏黏网消失不见了！",
						Language.CHN_TRA => "我方腳下的黏黏網消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_STICKY_WEB_DISAPPEARED:
					return lang switch {
						Language.ENG => "The sticky web has disappeared from the ground around the opposing team!",
						Language.JPN => "{相手|あいて}ののねばねばネットが{足下消|き}え{去|さ}った！",
						Language.GER => "Das Klebenetz auf der gegnerischen Seite ist wieder verschwunden!",
						Language.FRE => "La toile gluante du côté de l’équipe ennemie a disparu !",
						Language.ITA => "La Rete Vischiosa ai piedi della squadra avversaria svanisce!",
						Language.SPN => "La red viscosa que rodeaba al equipo rival ha desaparecido.",
						Language.KOR => "상대 발밑의 끈적끈적네트가 사라졌다!",
						Language.CHN_SIM => "对手脚下的黏黏网消失不见了！",
						Language.CHN_TRA => "對手腳下的黏黏網消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_HURT_BY_SPIKES:
					return lang switch {
						Language.ENG => "\\$ was hurt by the spikes!",
						Language.JPN => "\\$はまきびしのダメージを{受|う}けた！",
						Language.GER => "\\$ wurde durch Stachler verletzt!",
						Language.FRE => "\\$ est blessé par les picots !",
						Language.ITA => "\\$ è colpito da Punte!",
						Language.SPN => "¡Las púas han herido a \\$!",
						Language.KOR => "\\$ 압정뿌리기의 데미지를 입었다!",
						Language.CHN_SIM => "\\$受到了撒菱的伤害！",
						Language.CHN_TRA => "\\$受到了撒菱的傷害！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_USED_SPIKES:
					return lang switch {
						Language.ENG => "Spikes were scattered on the ground all around the opposing team!",
						Language.JPN => "{相手|あいて}の{足下|あしもと}にまきびしが{散|ち}らばった！",
						Language.GER => "Die Pokémon auf gegnerischer Seite sind von Stacheln umgeben!",
						Language.FRE => "Des picots s’éparpillent autour de l’équipe ennemie !",
						Language.ITA => "Ai piedi della squadra avversaria c’è una trappola di Punte!",
						Language.SPN => "¡El equipo enemigo ha sido rodeado de púas!",
						Language.KOR => "상대의 발밑에 압정이 뿌려졌다!",
						Language.CHN_SIM => "对手脚下散落着撒菱！",
						Language.CHN_TRA => "對手腳下散落著撒菱！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_USED_SPIKES:
					return lang switch {
						Language.ENG => "Spikes were scattered on the ground all around your team!",
						Language.JPN => "{味方|みかた}の{足下|あしもと}にまきびしが{散|ち}らばった！",
						Language.GER => "Die Pokémon auf deiner Seite sind von Stacheln umgeben!",
						Language.FRE => "Des picots s’éparpillent autour de votre équipe !",
						Language.ITA => "Ai piedi della tua squadra c’è una trappola di Punte!",
						Language.SPN => "¡Tu equipo ha sido rodeado de púas!",
						Language.KOR => "우리 편의 발밑에 압정이 뿌려졌다!",
						Language.CHN_SIM => "我方脚下散落着撒菱！",
						Language.CHN_TRA => "我方腳下散落著撒菱！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_SPIKES_DISAPPEARED:
					return lang switch {
						Language.ENG => "The poison spikes disappeared from the ground around your team!",
						Language.JPN => "{味方|みかた}ののどくびしが{足下消|き}え{去|さ}った！",
						Language.GER => "Die giftigen Stacheln, die auf deiner Seite herumlagen, sind verschwunden!",
						Language.FRE => "Il n’y a plus de pics toxiques autour de votre équipe !",
						Language.ITA => "Ai piedi della tua squadra non c’è più la trappola di Fielepunte!",
						Language.SPN => "Las púas tóxicas lanzadas a tu equipo han desaparecido.",
						Language.KOR => "우리 편 발밑의 독압정이 사라졌다!",
						Language.CHN_SIM => "我方脚下的毒菱消失不见了！",
						Language.CHN_TRA => "我方腳下的毒菱消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_SPIKES_DISAPPEARED:
					return lang switch {
						Language.ENG => "The poison spikes disappeared from the ground around the opposing team!",
						Language.JPN => "{相手|あいて}ののどくびしが{足下消|き}え{去|さ}った！",
						Language.GER => "Die giftigen Stacheln, die auf der gegnerischen Seite herumlagen, sind verschwunden!",
						Language.FRE => "Il n’y a plus de pics toxiques autour de l’équipe ennemie !",
						Language.ITA => "Ai piedi della squadra avversaria non c’è più la trappola di Fielepunte!",
						Language.SPN => "Las púas tóxicas lanzadas al equipo enemigo han desaparecido.",
						Language.KOR => "상대 발밑의 독압정이 사라졌다!",
						Language.CHN_SIM => "对手脚下的毒菱消失不见了！",
						Language.CHN_TRA => "對手腳下的毒菱消失不見了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_PROTECTED_BY_SAFEGUARD:
					return lang switch {
						Language.ENG => "\\$ is protected by Safeguard!",
						Language.JPN => "\\$は{神秘|しんぴ}のベールに{守|まも}られている！",
						Language.GER => "Das Team von \\$ wird durch Bodyguard geschützt!",
						Language.FRE => "\\$ est protégé par la capacité Rune Protect !",
						Language.ITA => "Salvaguardia protegge \\$!",
						Language.SPN => "¡\\$ está protegido por Velo Sagrado!",
						Language.KOR => "\\$ 신비의 베일이 지켜주고 있다!",
						Language.CHN_SIM => "\\$正受到神秘之幕的保护！",
						Language.CHN_TRA => "\\$正受到神秘之幕的保護！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.PLAYER_NO_LONGER_PROTECTED_BY_SAFEGUARD:
					return lang switch {
						Language.ENG => "Your team is no longer protected by Safeguard!",
						Language.JPN => "{味方|みかた}を{包|つつ}んでいたのベールがなくなった！",
						Language.GER => "Der mystische Schleier, der dein Team umgab, hat sich gelüftet!",
						Language.FRE => "Votre équipe n’est plus protégée par le voile mystérieux !",
						Language.ITA => "La tua squadra non è più protetta da Salvaguardia!",
						Language.SPN => "El efecto de Velo Sagrado en tu equipo se ha disipado.",
						Language.KOR => "우리 편을 감싸던 신비의 베일이 없어졌다!",
						Language.CHN_SIM => "包围我方的神秘之幕消失了！",
						Language.CHN_TRA => "包圍我方的神秘之幕消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPONENT_NO_LONGER_PROTECTED_BY_SAFEGUARD:
					return lang switch {
						Language.ENG => "The opposing team is no longer protected by Safeguard!",
						Language.JPN => "{相手|あいて}を{包|つつ}んでいたのベールがなくなった！",
						Language.GER => "Der mystische Schleier, der das gegnerische Team umgab, hat sich gelüftet!",
						Language.FRE => "L’équipe ennemie n’est plus protégée par le voile !",
						Language.ITA => "La squadra avversaria non è più protetta da Salvaguardia!",
						Language.SPN => "El efecto de Velo Sagrado en el equipo enemigo se ha disipado.",
						Language.KOR => "상대를 감싸던 신비의 베일이 없어졌다!",
						Language.CHN_SIM => "包围对手的神秘之幕消失了！",
						Language.CHN_TRA => "包圍對手的神秘之幕消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_CONFUSED:
					return lang switch {
						Language.ENG => "\\$ is confused!",
						Language.JPN => "\\$は{混乱|こんらん}している！",
						Language.GER => "\\$ ist verwirrt!",
						Language.FRE => "\\$ est confus !",
						Language.ITA => "\\$ è confuso!",
						Language.SPN => "¡\\$ está confuso!",
						Language.KOR => "\\$ 혼란에 빠져 있다!",
						Language.CHN_SIM => "\\$正在混乱中！",
						Language.CHN_TRA => "\\$正在混亂中！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.IT_HURT_ITSELF_IN_ITS_CONFUSION:
					return lang switch {
						Language.ENG => "It hurt itself in its confusion!",
						Language.JPN => "わけもわからず{自分|じぶん}を{攻撃|こうげき}した！",
						Language.GER => "Es hat sich vor Verwirrung selbst verletzt!",
						Language.FRE => "Il se blesse dans sa confusion.",
						Language.ITA => "È così confuso da colpirsi da solo!",
						Language.SPN => "¡Está tan confuso que se ha herido a sí mismo!",
						Language.KOR => "영문도 모른 채 자신을 공격했다!",
						Language.CHN_SIM => "不知所以地攻击了自己！",
						Language.CHN_TRA => "不知所以地攻擊了自己！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SEALED_SHARED_MOVES:
					return lang switch {
						Language.ENG => "\\$ sealed any moves its target shares with it!",
						Language.JPN => "\\$は{相手|あいて}の{技|わざ}を{封印|ふういん}した！",
						Language.GER => "\\$ versiegelt jene gegnerischen Attacken, die es selbst auch beherrscht!",
						Language.FRE => "\\$ bloque les capacités en commun avec l’adversaire !",
						Language.ITA => "Le mosse del nemico conosciute anche da \\$ vengono bloccate!",
						Language.SPN => "¡Los movimientos de los oponentes que \\$ también conoce han sido sellados!",
						Language.KOR => "\\$ 상대의 기술을 봉인했다!",
						Language.CHN_SIM => "\\$封印了对手的招式！",
						Language.CHN_TRA => "\\$封印了對手的招式！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_CANT_USE_SEALED_MOVE:
					return lang switch {
						Language.ENG => "\\$ can’t use its sealed \\$!",
						Language.JPN => "\\$はふういんで\\$がだせない！",
						Language.GER => "\\$ kann die versiegelte Attacke \\$ nicht einsetzen!",
						Language.FRE => "\\$ ne peut pas utiliser la capacité bloquée \\$ !",
						Language.ITA => "\\$ non può usare la mossa \\$: è bloccata!",
						Language.SPN => "¡\\$ no puede usar el movimiento \\$ porque ha sido sellado!",
						Language.KOR => "\\$ 봉인 때문에 \\$ 쓸 수 없다!",
						Language.CHN_SIM => "\\$因封印而无法使出\\$！",
						Language.CHN_TRA => "\\$因封印而無法使出\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.YOUR_TEAM_BECAME_SHROUDED_IN_MIST:
					return lang switch {
						Language.ENG => "Your team became shrouded in mist!",
						Language.JPN => "{味方|みかた}は{白|しろ}い{霧|きり}に{包|つつ}まれた！",
						Language.GER => "Pokémon, die auf deiner Seite kämpfen, werden in Weißnebel gehüllt!",
						Language.FRE => "Votre équipe s’entoure de brume !",
						Language.ITA => "La tua squadra è avvolta dalla nebbia!",
						Language.SPN => "¡Una neblina ha cubierto a tu equipo!",
						Language.KOR => "우리 편은 흰안개에 둘러싸였다!",
						Language.CHN_SIM => "我方被白雾包围了！",
						Language.CHN_TRA => "我方被白霧包圍了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPOSING_TEAM_BECAME_SHROUDED_IN_MIST:
					return lang switch {
						Language.ENG => "The opposing team became shrouded in mist!",
						Language.JPN => "{相手|あいて}は{白|しろ}い{霧|きり}に{包|つつ}まれた！",
						Language.GER => "Gegnerische Pokémon werden in Weißnebel gehüllt!",
						Language.FRE => "L’équipe ennemie s’entoure de brume !",
						Language.ITA => "La squadra avversaria è avvolta dalla nebbia!",
						Language.SPN => "¡Una neblina ha cubierto al equipo enemigo!",
						Language.KOR => "상대는 흰안개에 둘러싸였다!",
						Language.CHN_SIM => "对手被白雾包围了！",
						Language.CHN_TRA => "對手被白霧包圍了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.YOUR_TEAM_NO_LONGER_PROTECTED_BY_MIST:
					return lang switch {
						Language.ENG => "Your team is no longer protected by mist!",
						Language.JPN => "{味方|みかた}を{包|つつ}んでいたいがなくなった！",
						Language.GER => "Der Weißnebel, der die Pokémon auf deiner Seite umgab, hat sich gelichtet!",
						Language.FRE => "La brume autour de l’équipe s’est dissipée !",
						Language.ITA => "La nebbia intorno alla tua squadra si è diradata!",
						Language.SPN => "Ha desaparecido el efecto de la neblina en tu equipo.",
						Language.KOR => "우리 편을 감싸던 흰안개가 없어졌다!",
						Language.CHN_SIM => "包围我方的白雾消失了！",
						Language.CHN_TRA => "包圍我方的白霧消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.OPPOSING_TEAM_NO_LONGER_PROTECTED_BY_MIST:
					return lang switch {
						Language.ENG => "The opposing team is no longer protected by mist!",
						Language.JPN => "{相手|あいて}を{包|つつ}んでいたいがなくなった！",
						Language.GER => "Der Weißnebel, der die gegnerischen Pokémon umgab, hat sich gelichtet!",
						Language.FRE => "La brume autour de l’équipe ennemie s’est dissipée !",
						Language.ITA => "La nebbia intorno alla squadra avversaria si è diradata!",
						Language.SPN => "Ha desaparecido el efecto de la neblina en el equipo enemigo.",
						Language.KOR => "상대를 감싸던 흰안개가 없어졌다!",
						Language.CHN_SIM => "包围对手的白雾消失了！",
						Language.CHN_TRA => "包圍對手的白霧消失了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_PROTECTED_BY_THE_MIST:
					return lang switch {
						Language.ENG => "\\$ is protected by the mist!",
						Language.JPN => "\\$は{白|しろ}いにられている！",
						Language.GER => "\\$ wird durch Weißnebel geschützt!",
						Language.FRE => "\\$ est protégé par la brume !",
						Language.ITA => "\\$ è protetto da un velo di nebbia!",
						Language.SPN => "¡\\$ está protegido por la neblina!",
						Language.KOR => "\\$ 흰안개가 지켜주고 있다!",
						Language.CHN_SIM => "\\$正受到白雾的保护！",
						Language.CHN_TRA => "\\$正受到白霧的保護！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_SWITCHED_ITS_ATTACK_AND_DEFENSE:
					return lang switch {
						Language.ENG => "\\$ switched its Attack and Defense!",
						Language.JPN => "\\$は{攻撃|こうげき}と{防御|ぼうぎょ}を{入|い}れ{替|か}えた！",
						Language.GER => "\\$ tauscht den Wert seines Angriffs mit dem seiner Verteidigung!",
						Language.FRE => "\\$ échange son Attaque et sa Défense !",
						Language.ITA => "\\$ inverte l’Attacco con la Difesa!",
						Language.SPN => "¡\\$ ha intercambiado el valor de su Ataque por el de su Defensa!",
						Language.KOR => "\\$ 공격과 방어를 바꿨다!",
						Language.CHN_SIM => "\\$互换了攻击和防御！",
						Language.CHN_TRA => "\\$互換了攻擊和防禦！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_TRANSFORMED_INTO_MON:
					return lang switch {
						Language.ENG => "\\$ transformed into \\$!",
						Language.JPN => "\\$は\\$に{変身|へんしん}した！",
						Language.GER => "\\$ verwandelt sich in \\$!",
						Language.FRE => "\\$ prend l’apparence \\$ !",
						Language.ITA => "\\$ assume le sembianze di \\$!",
						Language.SPN => "¡\\$ se ha transformado en \\$!",
						Language.KOR => "\\$ \\$로 변신했다!",
						Language.CHN_SIM => "\\$变身成了\\$！",
						Language.CHN_TRA => "\\$變身成了\\$！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_WAS_SEEDED:
					return lang switch {
						Language.ENG => "\\$ was seeded!",
						Language.JPN => "\\$に{種|たね}を{植|う}えつけた！",
						Language.GER => "\\$ wurde bepflanzt!",
						Language.FRE => "\\$ est infecté !",
						Language.ITA => "\\$ è pieno di semi!",
						Language.SPN => "¡\\$ ha sido infectado!",
						Language.KOR => "\\$에게 씨앗을 심었다!",
						Language.CHN_SIM => "将种子种植在了\\$身上！",
						Language.CHN_TRA => "將種子種植在了\\$身上！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MONS_HP_WAS_SAPPED_BY_LEECH_SEED:
					return lang switch {
						Language.ENG => "\\$’s health is sapped by Leech Seed!",
						Language.JPN => "やどりぎが\\$の{体力|たいりょく}を{奪|うば}う！",
						Language.GER => "\\$ wurden durch Egelsamen KP geraubt!",
						Language.FRE => "Vampigraine draine l’énergie \\$ !",
						Language.ITA => "Parassiseme sottrae energia a \\$!",
						Language.SPN => "¡Las drenadoras han restado salud a \\$!",
						Language.KOR => "씨뿌리기가 \\$의 체력을 빼앗는다!",
						Language.CHN_SIM => "寄生植物夺取了\\$的体力！",
						Language.CHN_TRA => "寄生植物奪取了\\$的體力！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_MUST_DO_AN_ENCORE:
					return lang switch {
						Language.ENG => "\\$ must do an encore!",
						Language.JPN => "\\$はアンコールを{受|う}けた！",
						Language.GER => "\\$ gibt eine Zugabe!",
						Language.FRE => "\\$ ! Encore une fois !",
						Language.ITA => "\\$ è colpito da Ripeti!",
						Language.SPN => "¡\\$ ha sufrido los efectos de Otra Vez!",
						Language.KOR => "\\$ 앵콜을 받았다!",
						Language.CHN_SIM => "\\$接受了再来一次！",
						Language.CHN_TRA => "\\$接受了再來一次！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MONS_ENCORE_ENDED:
					return lang switch {
						Language.ENG => "\\$’s encore ended!",
						Language.JPN => "\\$のアンコール{状態|じょうたい}が{解|と}けた！",
						Language.GER => "Die Zugabe von \\$ ist beendet!",
						Language.FRE => "\\$ n’a plus à répéter la même capacité !",
						Language.ITA => "L’effetto di Ripeti su \\$ è terminato!",
						Language.SPN => "¡\\$ ya no sufre los efectos de Otra Vez!",
						Language.KOR => "\\$의 앵콜 상태가 풀렸다!",
						Language.CHN_SIM => "\\$的再来一次状态解除了！",
						Language.CHN_TRA => "\\$的再來一次狀態解除了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_USED_DESTINY_BOND:
					return lang switch {
						Language.ENG => "\\$ is hoping to take its attacker down with it!",
						Language.JPN => "\\$は{相手|あいて}を{道連|みちづ}れにしようとしている！",
						Language.GER => "\\$ versucht, den Angreifer mit sich zu nehmen!",
						Language.FRE => "\\$ veut emmener son ennemi au tapis !",
						Language.ITA => "\\$ tenta di far subire a chi lo manda KO la sua stessa sorte!",
						Language.SPN => "¡\\$ intenta que el rival sufra su mismo destino!",
						Language.KOR => "\\$ 상대를 길동무로 삼으려 하고 있다!",
						Language.CHN_SIM => "\\$想和对手同归于尽！",
						Language.CHN_TRA => "\\$想和對手同歸於盡！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_TOOK_ITS_ATTACKER_DOWN_WITH_IT:
					return lang switch {
						Language.ENG => "\\$ took its attacker down with it!",
						Language.JPN => "\\$は{相手|あいて}を{道連|みちづ}れにした！",
						Language.GER => "\\$ nimmt den Angreifer mit sich!",
						Language.FRE => "\\$ emmène son adversaire au tapis !",
						Language.ITA => "\\$ trascina con sé il Pokémon che lo ha attaccato!",
						Language.SPN => "¡\\$ ha conseguido debilitar también a su rival!",
						Language.KOR => "\\$ 상대를 길동무로 삼았다!",
						Language.CHN_SIM => "\\$和对手同归于尽了！",
						Language.CHN_TRA => "\\$和對手同歸於盡了！",
						_ => throw new System.ArgumentException()
					};
				case BattleMessage.MON_IS_BEING_SALT_CURED:
					return lang switch {
						Language.ENG => "\\$ is being salt cured!",
						Language.JPN => "\\$はしおづけになった！",
						Language.GER => "\\$ wurde eingepökelt!",
						Language.FRE => "\\$ est couvert de sel !",
						Language.ITA => "\\$ è sotto sale!",
						Language.SPN => "¡\\$ está en salazón!",
						Language.KOR => "\\$ 소금에 절여졌다!,",
						Language.CHN_SIM => "\\$陷入了盐腌状态！",
						Language.CHN_TRA => "\\$被鹽醃了！",
						_ => throw new System.ArgumentException()
					};
				default:
					throw new System.ArgumentException();
			}
		}
	}

	public enum BattleMessage {
		MON_USED_MOVE,
		// !!!! DO NOT USE THIS OUTSIDE OF TESTING !!!!
		MON_TOOK_DAMAGE,
		MON_RESTORED_HP,
		MON_FAINTED,
		
		CRITICAL_HIT,
		MON_AVOIDED_ATTACK,

		SUNLIGHT_BECAME_HARSH,
		STARTED_RAINING,
		SANDSTORM_KICKED_UP,
		STARTED_HAILING,
		FOG_CREPT_UP,
		STARTED_SNOWING,
		SUNLIGHT_BECAME_EXTREMELY_HARSH,
		HEAVY_RAIN_STARTED,
		MYSTERIOUS_WIND_APPEARED,
		SHADOWY_AURA_APPEARED,
		SHADOWY_AURA_DISAPPEARED,
		LIGHT_SHOWERED_FROM_SHADOWY_AURA,
		FLASHING_LIGHT_STRIKES_MON,
		SUNLIGHT_FADED,
		RAIN_STOPPED,
		SANDSTORM_SUBSIDED,
		HAIL_STOPPED,
		FOG_LIFTED,
		SNOW_STOPPED,
		EXTREME_SUNLIGHT_FADED,
		HEAVY_RAIN_STOPPED,
		MYSTERIOUS_WIND_DISAPPEARED,
		EXTREME_SUNLIGHT_NOT_LESSENED,
		HEAVY_RAIN_NOT_LESSENED,
		STRONG_WINDS_NOT_LESSENED,
		MON_WAS_BURNED,
		MON_ALREADY_BURNED,
		MON_CURED_OF_BURN,
		MON_WAS_FROZEN,
		MON_ALREADY_FROZEN,
		MON_THAWED_OUT,
		MON_WAS_PARALYZED,
		MON_ALREADY_PARALYZED,
		MON_CURED_OF_PARALYSIS,
		MON_WAS_POISONED,
		MON_WAS_BADLY_POISONED,
		MON_ALREADY_POISONED,
		MON_CURED_OF_POISON,
		MON_FELL_ASLEEP,
		MON_ALREADY_ASLEEP,
		MON_WOKE_UP,

		MON_WAS_CONFUSED,
		MON_ALREADY_CONFUSED,
		MON_SNAPPED_OUT_OF_CONFUSION,

		SUPER_EFFECTIVE,
		NOT_VERY_EFFECTIVE,
		IMMUNE,



		ATTACK_INCREASED,
		ATTACK_INCREASED_SHARPLY,
		ATTACK_INCREASED_DRASTICALLY,
		DEFENSE_INCREASED,
		DEFENSE_INCREASED_SHARPLY,
		DEFENSE_INCREASED_DRASTICALLY,
		SPECIAL_ATTACK_INCREASED,
		SPECIAL_ATTACK_INCREASED_SHARPLY,
		SPECIAL_ATTACK_INCREASED_DRASTICALLY,
		SPECIAL_DEFENSE_INCREASED,
		SPECIAL_DEFENSE_INCREASED_SHARPLY,
		SPECIAL_DEFENSE_INCREASED_DRASTICALLY,
		SPEED_INCREASED,
		SPEED_INCREASED_SHARPLY,
		SPEED_INCREASED_DRASTICALLY,
		ACCURACY_INCREASED,
		ACCURACY_INCREASED_SHARPLY,
		ACCURACY_INCREASED_DRASTICALLY,
		EVASION_INCREASED,
		EVASION_INCREASED_SHARPLY,
		EVASION_INCREASED_DRASTICALLY,

		ATTACK_DECREASED,
		ATTACK_DECREASED_SHARPLY,
		ATTACK_DECREASED_DRASTICALLY,
		DEFENSE_DECREASED,
		DEFENSE_DECREASED_SHARPLY,
		DEFENSE_DECREASED_DRASTICALLY,
		SPECIAL_ATTACK_DECREASED,
		SPECIAL_ATTACK_DECREASED_SHARPLY,
		SPECIAL_ATTACK_DECREASED_DRASTICALLY,
		SPECIAL_DEFENSE_DECREASED,
		SPECIAL_DEFENSE_DECREASED_SHARPLY,
		SPECIAL_DEFENSE_DECREASED_DRASTICALLY,
		SPEED_DECREASED,
		SPEED_DECREASED_SHARPLY,
		SPEED_DECREASED_DRASTICALLY,
		ACCURACY_DECREASED,
		ACCURACY_DECREASED_SHARPLY,
		ACCURACY_DECREASED_DRASTICALLY,
		EVASION_DECREASED,
		EVASION_DECREASED_SHARPLY,
		EVASION_DECREASED_DRASTICALLY,

		ATTACK_AT_MAX,
		DEFENSE_AT_MAX,
		SPECIAL_ATTACK_AT_MAX,
		SPECIAL_DEFENSE_AT_MAX,
		SPEED_AT_MAX,
		ACCURACY_AT_MAX,
		EVASION_AT_MAX,

		ATTACK_AT_MIN,
		DEFENSE_AT_MIN,
		SPECIAL_ATTACK_AT_MIN,
		SPECIAL_DEFENSE_AT_MIN,
		SPEED_AT_MIN,
		ACCURACY_AT_MIN,
		EVASION_AT_MIN,

		MOVE_FAILED,
		MON_CANNOT_USE_MOVE,

		STAT_CHANGES_ELIMINATED,
		STAT_CHANGES_REMOVED,
		STAT_CHANGES_INVERTED,

		HIT_N_TIMES,
		MON_FLINCHED,
		MON_TRAPPED_MON,
		MON_CAN_NO_LONGER_ESCAPE,
		MON_HAVING_NIGHTMARE,
		MON_LOCKED_IN_NIGHTMARE,
		MON_PROTECTED_ITSELF,
		MON_GETTING_PUMPED,
		MON_COPIED_MONS_STAT_CHANGES,
		MON_BECAME_CENTER_OF_ATTENTION,
		MON_CHARGING_POWER,
		MON_DAMAGED_BY_RECOIL,
		BELLY_DRUM,
		REST,
		MON_BECAME_NIMBLE,
		NO_ONE_CAN_ESCAPE,
		MON_SWITCHED_STAT_CHANGES_WITH_TARGET,
		MON_HURLED_INTO_AIR,
		MON_BEGAN_LEVITATING,
		MON_BECAME_WEAKER_TO_FIRE,

		NOTHING_HAPPENED,

		MON_IS_DROWSING,
		MON_RECHARGING,

		MON_HURT_BY_ITS_BURN,
		MON_IS_PARALYZED_AND_CANT_MOVE,
		MON_IS_FROZEN_SOLID,
		MON_HURT_BY_POISON,
		MON_IS_FAST_ASLEEP,
		MON_HURT_BY_SANDSTORM,
		MON_HURT_BY_HAIL,
		MON_CANNOT_BE_BURNED,
		MON_CANNOT_BE_FROZEN,
		MON_CANNOT_BE_PARALYZED,
		MON_CANNOT_BE_POISONED,
		MON_CANNOT_FALL_ASLEEP,
		OHKO,
		GRASSY_TERRAIN_START,
		GRASSY_TERRAIN_END,
		MISTY_TERRAIN_START,
		MISTY_TERRAIN_END,
		ELECTRIC_TERRAIN_START,
		ELECTRIC_TERRAIN_END,
		PSYCHIC_TERRAIN_START,
		PSYCHIC_TERRAIN_END,
		GRASSY_TERRAIN_ACTIVE,
		MISTY_TERRAIN_ACTIVE,
		ELECTRIC_TERRAIN_ACTIVE,
		PSYCHIC_TERRAIN_ACTIVE,
		SUNLIGHT_IS_HARSH,
		ITS_RAINING,
		SANDSTORM_IS_RAGING,
		ITS_HAILING,
		ITS_SNOWING,
		FIRE_ATTACK_FIZZLED_OUT,
		WATER_ATTACK_EVAPORATED,
		WIND_WEAKENED_ATTACK,
		MON_WHIPPED_UP_A_WHIRLWIND,
		MYSTERIOUS_WIND_BLOWS_ON,
		MON_SURROUNDED_ITSELF_WITH_A_VEIL_OF_WATER,
		A_VEIL_OF_WATER_RESTORED_MONS_HP,
		MONS_PP_WAS_REDUCED,
		MON_IS_TORMENTED,
		MON_IS_NO_LONGER_TORMENTED,
		MON_CANNOT_USE_THE_SAME_MOVE_TWICE_DUE_TO_TORMENT,
		GUARD_SPLIT,
		POWER_SPLIT,
		GUARD_SWAP,
		POWER_SWAP,
		MONS_PERISH_COUNT_FELL_TO_N,
		PERISH_SONG,
		MON_TOOK_AIM_AT_MON,
		MAGNITUDE_N,
		MON_BURROWED_UNDER_THE_GROUND,
		MON_FLEW_UP_HIGH,
		MON_HID_UNDER_WATER,
		MON_VANISHED_INSTANTLY,
		MON_SPRANG_UP,
		MON_TOOK_MON_INTO_THE_SKY,
		MON_FELL_STRAIGHT_DOWN,
		ALLY_TAILWIND_START,
		ENEMY_TAILWIND_START,
		ALLY_TAILWIND_END,
		ENEMY_TAILWIND_END,
		THROAT_CHOP_PREVENTS_MON_FROM_USING_CERTAIN_MOVES,
		MON_FELL_FOR_THE_TAUNT,
		MON_CANNOT_USE_MOVE_AFTER_THE_TAUNT,
		MON_SHOOK_OFF_THE_TAUNT,
		WATER_SPORT_START,
		WATER_SPORT_END,
		MUD_SPORT_START,
		MUD_SPORT_END,
		CANNOT_USE_MOVE_TWICE_IN_A_ROW,
		MON_BECAME_CLOAKED_IN_A_HARSH_LIGHT,
		MON_ABSORBED_LIGHT,
		MON_CLOAKED_IN_FREEZING_LIGHT,
		MON_CLOAKED_IN_FREEZING_AIR,
		MON_IS_ABSORBING_POWER,
		MON_IS_OVERFLOWING_WITH_SPACE_POWER,
		MON_TUCKED_IN_ITS_HEAD,
		MONS_MOVE_WAS_DISABLED,
		MON_BRACED_ITSELF,
		MON_IS_STORING_ENERGY,
		MON_UNLEASHED_ITS_ENERGY,
		OPPONENT_REFLECT,
		ALLY_REFLECT,
		ALLY_LIGHT_SCREEN,
		OPPONENT_LIGHT_SCREEN,
		ALLY_LIGHT_SCREEN_WORE_OFF,
		OPPONENT_LIGHT_SCREEN_WORE_OFF,
		ALLY_REFLECT_WORE_OFF,
		OPPONENT_REFLECT_WORE_OFF,
		ALLY_AURORA_VEIL,
		OPPONENT_AURORA_VEIL,
		ALLY_AURORA_VEIL_WORE_OFF,
		OPPONENT_AURORA_VEIL_WORE_OFF,
		PAIN_SPLIT,
		MON_SKETCHED_MOVE,
		MON_PUT_A_CURSE_ON_MON,
		MON_AFFLICTED_BY_CURSE,
		STONES_DUG_INTO_MON,
		PLAYER_USED_STEALTH_ROCK,
		OPPONENT_USED_STEALTH_ROCK,
		PLAYER_STEALTH_ROCKS_DISAPPEAR,
		OPPONENT_STEALTH_ROCKS_DISAPPEAR,
		PLAYER_USED_TOXIC_SPIKES,
		OPPONENT_USED_TOXIC_SPIKES,
		PLAYER_TOXIC_SPIKES_DISAPPEARED,
		OPPONENT_TOXIC_SPIKES_DISAPPEARED,
		PLAYER_USED_STICKY_WEB,
		OPPONENT_USED_STICKY_WEB,
		PLAYER_STICKY_WEB_DISAPPEARED,
		OPPONENT_STICKY_WEB_DISAPPEARED,
		MON_HURT_BY_SPIKES,
		PLAYER_USED_SPIKES,
		OPPONENT_USED_SPIKES,
		PLAYER_SPIKES_DISAPPEARED,
		OPPONENT_SPIKES_DISAPPEARED,
		MON_PROTECTED_BY_SAFEGUARD,
		PLAYER_NO_LONGER_PROTECTED_BY_SAFEGUARD,
		OPPONENT_NO_LONGER_PROTECTED_BY_SAFEGUARD,
		MON_IS_CONFUSED,
		IT_HURT_ITSELF_IN_ITS_CONFUSION,
		MON_SEALED_SHARED_MOVES,
		MON_CANT_USE_SEALED_MOVE,
		YOUR_TEAM_BECAME_SHROUDED_IN_MIST,
		OPPOSING_TEAM_BECAME_SHROUDED_IN_MIST,
		YOUR_TEAM_NO_LONGER_PROTECTED_BY_MIST,
		OPPOSING_TEAM_NO_LONGER_PROTECTED_BY_MIST,
		MON_IS_PROTECTED_BY_THE_MIST,
		MON_SWITCHED_ITS_ATTACK_AND_DEFENSE,
		MON_TRANSFORMED_INTO_MON,
		MON_WAS_SEEDED,
		MONS_HP_WAS_SAPPED_BY_LEECH_SEED,
		MON_MUST_DO_AN_ENCORE,
		MONS_ENCORE_ENDED,
		MON_USED_DESTINY_BOND,
		MON_TOOK_ITS_ATTACKER_DOWN_WITH_IT,
		MON_IS_BEING_SALT_CURED,


		NR_ITEMS
	};
}