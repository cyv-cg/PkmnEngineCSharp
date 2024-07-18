using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Collections.Generic;

using static PkmnEngine.Global;

using static PkmnEngine.BaseStats;
using static PkmnEngine.ExpGroups;
using static PkmnEngine.LevelupLearnsets;
using static PkmnEngine.BattleMoves;
using static PkmnEngine.Natures;

using PkmnEngine.Strings;
using Godot;
using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public class BoxMon : ISerializable<BoxMon> {
		public Buffer Write() {

			Buffer buffer = new Buffer();

			buffer.AddValue((u16)Species);
			buffer.AddValue(Personality);
			buffer.AddValue(OtId);
			buffer.AddValue(OtName, MAX_NAME_LENGTH);
			buffer.AddValue((u8)Language);
			buffer.AddValue(Checksum);

			buffer.AddValue(IsWild);
			buffer.AddValue(HasHiddenAbility);

			buffer.AddValue(HpIV);
			buffer.AddValue(AtkIV);
			buffer.AddValue(DefIV);
			buffer.AddValue(SpAtkIV);
			buffer.AddValue(SpDefIV);
			buffer.AddValue(SpdIV);

			return buffer;
		}
		public static BoxMon Load(Buffer data) {
			return new BoxMon {
				Species		= (Species)data.Read16(),
				Personality	= data.Read32(),
				OtId		= data.Read32(),
				OtName		= data.ReadString(MAX_NAME_LENGTH),
				Language	= (Language)data.Read8(),
				Checksum	= data.Read64(),

				IsWild				= data.ReadBool(),
				HasHiddenAbility	= data.ReadBool(),

				HpIV	= data.Read8(),
				AtkIV	= data.Read8(),
				DefIV	= data.Read8(),
				SpAtkIV	= data.Read8(),
				SpDefIV	= data.Read8(),
				SpdIV	= data.Read8()
			};
		}

		public BoxMon() {
			this.Species = Species.NONE;
			this.HpIV = 0;
			this.AtkIV = 0;
			this.DefIV = 0;
			this.SpAtkIV = 0;
			this.SpDefIV = 0;
			this.SpdIV = 0;
			this.Personality = 0;
			this.OtId = 0;
			this.IsWild = false;
			this.HasHiddenAbility = false;
			this.Checksum = 0;
		}

		public BoxMon(Species species, bool hasFixedIv, u8[] fixedIv, bool hasFixedPersonality, u32 fixedPersonality, OtIdType otIdType, u32 fixedOtId)
		{
			this.IsWild = false;
			this.Species = species;

			u32 personality;
			if (hasFixedPersonality) {
				personality = fixedPersonality;
			}
			else {
				personality = Random32();
			}
			this.Personality = personality;

			u32 value;
			switch (otIdType) {
				case OtIdType.RANDOM_NO_SHINY: {
					u32 shinyValue;
					do {
						value = Random32();
						shinyValue = GetShinyValue(value, personality);
					} while (shinyValue < SHINY_ODDS);
					break;
				}
				case OtIdType.PRESET:
					value = fixedOtId;
					break;
				case OtIdType.PLAYER:
					value = gSaveBlock.trainerID;
					break;
				default:
					throw new System.ArgumentException();
			}
			this.OtId = value;

			if (hasFixedIv) {
				this.HpIV		= fixedIv[(u8)Stat.HIT_POINTS];
				this.AtkIV		= fixedIv[(u8)Stat.ATTACK];
				this.DefIV		= fixedIv[(u8)Stat.DEFENSE];
				this.SpAtkIV	= fixedIv[(u8)Stat.SPECIAL_ATTACK];
				this.SpDefIV	= fixedIv[(u8)Stat.SPECIAL_DEFENSE];
				this.SpdIV		= fixedIv[(u8)Stat.SPEED];
			}
			else {
				this.HpIV		= (u8)(Random16() & MAX_IV_MASK);
				this.AtkIV		= (u8)(Random16() & MAX_IV_MASK);
				this.DefIV		= (u8)(Random16() & MAX_IV_MASK);
				this.SpAtkIV	= (u8)(Random16() & MAX_IV_MASK);
				this.SpDefIV	= (u8)(Random16() & MAX_IV_MASK);
				this.SpdIV		= (u8)(Random16() & MAX_IV_MASK);
			}

			// TODO: the rest of this
			this.Checksum = CalculateChecksum();
			this.Language = gSaveBlock.language;
			//this.OtName = gSaveBlock.profile.Name;
			this.OtName = "";
			this.HasHiddenAbility = false;
			//value = GetCurrentRegionMapSectionId();
			//SetBoxMonData(boxMon, MON_DATA_MET_LOCATION, &value);
			//SetBoxMonData(mon, MON_DATA_MET_LEVEL, &level);
			//SetBoxMonData(boxMon, MON_DATA_MET_GAME, &gGameVersion);
			//value = ITEM_POKE_BALL;
			//SetBoxMonData(boxMon, MON_DATA_POKEBALL, &value);
			//SetBoxMonData(boxMon, MON_DATA_OT_GENDER, &gSaveBlock.playerGender);
		}

		public Species Species { get; private set; }
		public u32 Personality { get; private set; }
		public u32 OtId { get; private set; }
		public string OtName { get; private set; }
		public Language Language { get; private set; }
		// u8 isBadEgg:1;
		// u8 hasSpecies:1;
		// u8 isEgg:1;
		// u8 unused:5;
		// u8 markings;
		public u64 Checksum { get; private set; }
		// u8 unknown;
		public bool IsWild { get; private set; }

		public bool HasHiddenAbility { get; private set; }

		public u8 HpIV { get; private set; }
		public u8 AtkIV { get; private set; }
		public u8 DefIV { get; private set; }
		public u8 SpAtkIV { get; private set; }
		public u8 SpDefIV { get; private set; }
		public u8 SpdIV { get; private set; }

		/// <summary>
		/// Generates a checksum for the BoxMon.
		/// </summary>
		/// <returns>The calculated checksum.</returns>
		public u64 CalculateChecksum()
		{
			u64 checksum = 0;
			// 5 bits from each IV, 30 total.
			checksum += (u64)HpIV		<< 59;
			checksum += (u64)AtkIV 		<< 54;
			checksum += (u64)DefIV 		<< 49;
			checksum += (u64)SpAtkIV	<< 44;
			checksum += (u64)SpDefIV	<< 39;
			checksum += (u64)SpdIV		<< 34;
			// 32 bits from personality.
			checksum += Personality << 2;
			// Add OT ID to the left half.
			checksum += (u64)OtId << 32;
			// Species ID to the right half.
			checksum += (u64)Species;
			return checksum;
		}

		#region overrides
		public bool Equals(BoxMon obj) {
			return this.Write().ToString() == obj.Write().ToString();
		}
		#endregion
	}

	public class Pokemon : ISerializable<Pokemon> {
		public Buffer Write() {
			Buffer buffer = new Buffer();

			buffer.AddValue(Box);

			buffer.AddValue(level);
			buffer.AddValue(exp);
			
			buffer.AddValue(Nickname, MAX_NAME_LENGTH);

			buffer.AddValue(status);
			buffer.AddValue(friendship);

			buffer.AddValue(maxHp);
			buffer.AddValue(hp);
			buffer.AddValue(atk);
			buffer.AddValue(def);
			buffer.AddValue(spAtk);
			buffer.AddValue(spDef);
			buffer.AddValue(spd);

			buffer.AddValue(hpEV);
			buffer.AddValue(atkEV);
			buffer.AddValue(defEV);
			buffer.AddValue(spAtkEV);
			buffer.AddValue(spDefEV);
			buffer.AddValue(spdEV);

			for (u8 i = 0; i < MAX_MOVES; i++) {
				buffer.AddValue((u16)Moves[i]);
				buffer.AddValue(MaxPP[i]);
				buffer.AddValue(PP[i]);
			}

			return buffer;
		}
		public static Pokemon Load(Buffer data) {
			Pokemon mon = new Pokemon();

			mon.Box = BoxMon.Load(data.ReadBuffer());

			mon.level	= data.Read8();
			mon.exp		= data.Read32();

			mon.Nickname = data.ReadString(MAX_NAME_LENGTH);

			mon.status		= data.Read8();
			mon.friendship	= data.Read8();

			mon.maxHp	= data.Read16();
			mon.hp		= data.Read16();
			mon.atk		= data.Read16();
			mon.def		= data.Read16();
			mon.spAtk	= data.Read16();
			mon.spDef	= data.Read16();
			mon.spd		= data.Read16();

			mon.hpEV	= data.Read8();
			mon.atkEV	= data.Read8();
			mon.defEV	= data.Read8();
			mon.spAtkEV	= data.Read8();
			mon.spDefEV	= data.Read8();
			mon.spdEV	= data.Read8();

			for (u8 i = 0; i < MAX_MOVES; i++) {
				mon.Moves[i]	= (BattleMoveID)data.Read16();
				mon.MaxPP[i]	= data.Read8();
				mon.PP[i]		= data.Read8();
			}
				
			return mon;
		}

		public Pokemon() {
			this.Moves = new BattleMoveID[MAX_MOVES];
			this.MaxPP = new u8[MAX_MOVES];
			this.PP = new u8[MAX_MOVES];
		}
		
		public Pokemon(Species species, u8 level, bool hasFixedIv, u8[] fixedIv, bool hasFixedPersonality, u32 fixedPersonality, OtIdType otIdType, u32 fixedOtId) 
		{
			this.Box = new BoxMon(species, hasFixedIv, fixedIv, hasFixedPersonality, fixedPersonality, otIdType, fixedOtId);

			SetNickname("");
			this.friendship = gBaseStats(species).baseFriendship;

			this.level = level;
			this.exp = gExperienceTables(gBaseStats(species).growth, level);

			this.status = 0;

			this.Moves = new BattleMoveID[MAX_MOVES];
			this.MaxPP = new u8[MAX_MOVES];
			this.PP = new u8[MAX_MOVES];

			CalculateStats();
			GiveInitialMoveset();
		}

		public const u8 MAX_MOVES = 4;

		public BoxMon Box { get; private set; }

		public u8 level;
		public u32 exp;
		public u32 ExpToNextLevel {
			get {
				if (level == MAX_LEVEL) {
					return 0;
				}
				u32 expForNextLevel = gExperienceTables(gBaseStats(Box.Species).growth, (u8)(level + 1));
				return expForNextLevel - exp;
			}
		}

		private string _nickname;
		public string Nickname {
			get {
				return _nickname;
			}
			private set {
				_nickname = value;
			}
		}

		/// @brief Non-volatile status condition.
		/// @note 00000000 none
		/// @note 00000001 burn
		/// @note 00000010 freeze
		/// @note 00000100 paralysis
		/// @note 00001000 poison
		/// @note 00010000 toxic
		/// @note 00100000 sleep
		/// @note 10000000 fainted
		public u8 status;

		public u16 maxHp;
		public u16 hp;
		public u16 atk;
		public u16 def;
		public u16 spAtk;
		public u16 spDef;
		public u16 spd;

		public BattleMoveID[] Moves { get; private set; }
		public u8[] MaxPP { get; private set; }
		public u8[] PP { get; private set; }

		public u8 hpEV;
		public u8 atkEV;
		public u8 defEV;
		public u8 spAtkEV;
		public u8 spDefEV;
		public u8 spdEV;

		public u8 friendship;

		#region Properties
		/// <summary>
		/// Calculates a mon's nature based on its personality.
		/// </summary>
		public Nature Nature { 
			get { 
				return (Nature)(((Box.Personality & 0x000FF000) >> 4) % NUM_NATURES);
			}
		}
		/// <summary>
		/// Determines a mon's gender based on its personality and species's gender ratio.
		/// </summary>
		public u8 Gender {
			get {
				u8 ratio = gBaseStats(Box.Species).genderRatio;
				switch (ratio) {
					case UNGENDERED:
						return MON_GENDERLESS;
					case PERCENT_FEMALE_0:
						return MON_MALE;
					case PERCENT_FEMALE_100:
						return MON_FEMALE;
				}

				// Grab an arbitrary byte from the personality and determine gender based on that.
				u8 val = (u8)(Box.Personality & 0xFF000000 >> 6);
				if (val <= gBaseStats(Box.Species).genderRatio) {
					return MON_FEMALE;
				}
				return MON_MALE;
			}
		}

		/// <summary>
		/// Uses a mon's personality to calculate its ability.
		/// Returns hidden ability if and only if specified in the BoxMon class and the species has one.
		/// </summary>
		//public Ability Ability {
		//	get {
		//		if (Box.HasHiddenAbility && gBaseStats(Box.Species).hiddenAbility != Ability.NONE) {
		//			return gBaseStats(Box.Species).hiddenAbility;
		//		}
		//		if (gBaseStats(Box.Species).ability2 == Ability.NONE || (Box.Personality & 1) != 0) {
		//			return gBaseStats(Box.Species).ability1;
		//		}
		//		else {
		//			return gBaseStats(Box.Species).ability2;
		//		}
		//	}
		//}
		public Ability Ability;

		/// <summary>
		/// Calculates a mon's Hidden Power type based on its personality.
		/// Cannot return Type.NONE or Type.NORMAL.
		/// </summary>
		public Type HiddenPowerType {
			get {
				Type type = Type.NORMAL;
				u8 i = 0;
				while (type == Type.NORMAL || type == Type.NONE) {
					type = (Type)((Box.Personality >> i) % Types.NUM_TYPES);
					i++;
				}
				return type;
			}
		}
		#endregion

		/// <summary>
		/// Give mon up to 4 moves that it can know at it's current level.
		/// </summary>
		private void GiveInitialMoveset()
		{
			Species species = Box.Species;
			BattleMoveID[] elligibleMoves = GetMovesUnderLevel(species, level);

			// Randomly pick *up to* MAX_MOVES moves in the mon's levelup learnset.
			for (u8 i = 0; i < MAX_MOVES; i++) {
				u8 index;
				u8 moveLevel;
				do {
					index = (u8)(Random16() % elligibleMoves.Length);
					moveLevel = MoveLevel(gLevelupLearnsets(species)[index]);
				} while (moveLevel == 0 || moveLevel > level);
				BattleMoveID move = MoveID(gLevelupLearnsets(species)[index]);
				GiveMove(move);
			}
		}
		/// <summary>
		/// Gets a list of all the moves a species can learn at or below a given level.
		/// </summary>
		/// <param name="species">Species whose levelup learnset to check.</param>
		/// <param name="level">Level at or under which to look for.</param>
		/// <returns>Array of move IDs.</returns>
		public static BattleMoveID[] GetMovesUnderLevel(Species species, u8 level)
		{

			List<BattleMoveID> moves = new List<BattleMoveID>();

			int n = gLevelupLearnsets(species).Length;
			for (u8 i = 0; i < n; i++) {
				if (MoveLevel(gLevelupLearnsets(species)[i]) <= level) {
					moves.Add(MoveID(gLevelupLearnsets(species)[i]));
				}
				else {
					break;
				}
			}
			return moves.ToArray();
		}

		/// <summary>
		/// Sets the mon's nickname.
		/// </summary>
		/// <param name="nickname">Name which to set, up to Global.MAX_NAME_LENGTH chars.</param>
		public void SetNickname(string nickname)
		{
			if (nickname.Length > MAX_NAME_LENGTH) {
				Nickname = nickname.Substring(0, MAX_NAME_LENGTH);
			}
			else {
				Nickname = nickname;
			}
		}
		/// <summary>
		/// Gets the name of the species in this mon's language.
		/// </summary>
		/// <returns>Localized species name.</returns>
		public string GetSpeciesName()
		{
			StringResource.Namespace strings = StringResource.Namespace.SPECIES;
			return Lang.GetString(strings, Lang.GetStringResourceWithKey(strings, Box.Species.ToString()), Box.Language);
		}
		/// <summary>
		/// Gets the name of a given Pokemon. If the mon has a nickname, gets that; otherwise returns the localized species name.
		/// </summary>
		/// <returns>Nickname if available, species name otherwise.</returns>
		public string GetName()
		{
			if (string.IsNullOrEmpty(Nickname)) {
				return GetSpeciesName();
			}
			else {
				return Nickname;
			}
		}


		#region Stat calculation
		/// <summary>
		/// Calculates the stat values for a Pokemon.
		/// </summary>		
		private void CalculateStats()
		{
			Species species	= Box.Species;
			u8 level		= this.level;
			u16 oldMaxHP	= maxHp;
			u16 currentHP	= hp;
			u8 hpEV			= this.hpEV;
			u8 hpIV			= Box.HpIV;
			u8 attackEV		= atkEV;
			u8 attackIV		= Box.AtkIV;
			u8 defenseEV	= defEV;
			u8 defenseIV	= Box.DefIV;
			u8 spAttackEV	= spAtkEV;
			u8 spAttackIV	= Box.SpAtkIV;
			u8 spDefenseEV	= spDefEV;
			u8 spDefenseIV	= Box.SpDefIV;
			u8 speedEV		= spdEV;
			u8 speedIV		= Box.SpdIV;
			u16 newMaxHP;

			if (species == Species.SHEDINJA) {
				newMaxHP = 1;
			}
			else {
				newMaxHP = CalcHP(species, level, hpEV, hpIV);
			}

			//gBattleScripting.levelUpHP = newMaxHP - oldMaxHP;
			// if (gBattleScripting.levelUpHP == 0)
			//     gBattleScripting.levelUpHP = 1;

			this.maxHp	= newMaxHP;
			this.atk	= CalcStat(Nature, gBaseStats(species).baseAtk, level, attackEV, attackIV, Stat.ATTACK);
			this.def	= CalcStat(Nature, gBaseStats(species).baseDef, level, defenseEV, defenseIV, Stat.DEFENSE);
			this.spAtk	= CalcStat(Nature, gBaseStats(species).baseSpAtk, level, spAttackEV, spAttackIV, Stat.SPECIAL_ATTACK);
			this.spDef	= CalcStat(Nature, gBaseStats(species).baseSpDef, level, spDefenseEV, spDefenseIV, Stat.SPECIAL_DEFENSE);
			this.spd	= CalcStat(Nature, gBaseStats(species).baseSpd, level, speedEV, speedIV, Stat.SPEED);

			if (species == Species.SHEDINJA)
			{
				if (currentHP != 0 || oldMaxHP == 0)
					currentHP = 1;
				else
					return;
			}
			else
			{
				if (currentHP == 0 && oldMaxHP == 0)
					currentHP = newMaxHP;
				else if (currentHP != 0) {
					// currentHP is unintentionally able to become <= 0 after the instruction below. 
					// This causes the pomeg berry glitch.
					currentHP += (u16)(newMaxHP - oldMaxHP);
					//#ifdef BUGFIX
					if (currentHP <= 0)
						currentHP = 1;
					//#endif
				}
				else
					return;
			}

			hp = currentHP;
		}
		
		/// <summary>
		/// Calculates a mon's max HP value.
		/// </summary>
		/// <param name="species">Mon's species.</param>
		/// <param name="level">Mon's current level.</param>
		/// <param name="hpEV">Mon's HP EV.</param>
		/// <param name="hpIV">Mon's HP IV.</param>
		/// <returns>Calculated max HP.</returns>
		public static u16 CalcHP(Species species, u8 level, u8 hpEV, u8 hpIV)
		{
			u16 curHp = (u16)(2 * gBaseStats(species).baseHp + hpIV);
			return (u16)(((curHp + hpEV / 4) * level / 100) + level + 10);
		}
		/// <summary>
		/// Calculates the value of a given stat.
		/// </summary>
		/// <param name="nature">Mon's nature.</param>
		/// <param name="baseValue">Base value of the stat for the mon's species.</param>
		/// <param name="level">Mon's current level.</param>
		/// <param name="ev">Mon's EV for the stat.</param>
		/// <param name="iv">Mon's IV for the stat.</param>
		/// <param name="statIndex">Stat to calculate.</param>
		/// <returns>The calculated value for the stat.</returns>
		public static u16 CalcStat(Nature nature, u16 baseValue, u8 level, u8 ev, u8 iv, Stat statIndex)
		{
			u16 n = (u16)(((2 * baseValue + iv + ev / 4) * level / 100) + 5);
			n = ModifyStatByNature(nature, n, statIndex);
			return n;
		}
		/// <summary>
		/// @brief Calculates a mon's modified stat based on its nature.
		/// </summary>
		/// <param name="nature">Mon's nature.</param>
		/// <param name="n">Unmodified value of the stat.</param>
		/// <param name="statIndex">Stat to modify.</param>
		/// <returns></returns>
		public static u16 ModifyStatByNature(Nature nature, u16 n, Stat statIndex)
		{
			if (statIndex <= Stat.HIT_POINTS || statIndex > Stat.SPEED) {
				return n;
			}

			return gNatureStatTable(nature)[(u8)statIndex] switch
			{
				1 => (u16)(n * 110 / 100),
				-1 => (u16)(n * 90 / 100),
				_ => n,
			};
		}
		#endregion

		/// <summary>
		/// Determines if a mon knows a given move.
		/// </summary>
		/// <param name="move">ID of the move to check.</param>
		/// <returns>True if the mon knows the given move, false otherwise.</returns>
		public bool KnowsMove(BattleMoveID move)
		{
			for (u8 i = 0; i < MAX_MOVES; i++) {
				if (Moves[i] == move) {
					return true;
				}
			}
			return false;
		}
		/// <summary>
		/// Puts the given move into the first available move slot a mon has. Does nothing if the mon already knows the given move.
		/// </summary>
		/// <param name="move">ID of the move to give.</param>
		public void GiveMove(BattleMoveID move)
		{
			if (KnowsMove(move)) {
				return;
			}

			for (u8 i = 0; i < MAX_MOVES; i++) {
				BattleMoveID existingMove = Moves[i];
				if (existingMove == BattleMoveID.NONE) {
					Moves[i]	= move;
					PP[i]		= gBattleMoves(move).pp;
					MaxPP[i]	= gBattleMoves(move).pp;
					break;
				}
			}
		}
		/// <summary>
		/// Replaces the move in a given slot.
		/// </summary>
		/// <param name="moveSlot">Slot of the move to replace.</param>
		/// <param name="newMove">ID of the new move.</param>
		public void ReplaceMove(u8 moveSlot, BattleMoveID newMove)
		{
			if (moveSlot >= MAX_MOVES) {
				throw new System.ArgumentOutOfRangeException();
			}
			Moves[moveSlot]	= newMove;
			PP[moveSlot]	= gBattleMoves(newMove).pp;
			MaxPP[moveSlot]	= gBattleMoves(newMove).pp;
		}

		#region overrides
		public bool Equals(Pokemon obj) {
			return this.Write().ToString() == obj.Write().ToString();
		}
		#endregion
	}

	public class BattleMon : ISerializable<BattleMon> {
		[System.Flags] public enum Flag {
			RECEIVED_DAMAGE_THIS_TURN	= 1 << 0,	// Marks whether or not the mon has taken damage in the current turn.
			JUST_SWITCHED_IN			= 1 << 1,	// Marks if the mon just entered / has gotten to act yet.
			STAT_INCREASED_THIS_TURN	= 1 << 2,	// Marks if the mon had any stat increase this turn.
			MON_INDUCED_SEMI_INVUL		= 1 << 3	// Marks if the mon initiated the semi-invulnerable state it is in.
		}
		//public const u32 BM_FLAG_RECEIVED_DAMAGE_THIS_TURN	= 1 << 0; // Marks whether or not the mon has taken damage in the current turn.
		//public const u32 BM_FLAG_JUST_SWITCHED_IN 			= 1 << 1; // Marks if the mon just entered / has gotten to act yet.
		//public const u32 BM_FLAG_STAT_INCREASED_THIS_TURN	= 1 << 2; // Marks if the mon had any stat increase this turn.
		//public const u32 BM_FLAG_MON_INDUCED_SEMI_INVUL		= 1 << 3; // Marks if the mon initiated the semi-invulnerable state it is in.

		public Buffer Write() {
			Buffer data = new Buffer();

			data.AddValue(Mon);
			data.AddValue((u16)Species);

			data.AddValue(Side);

			data.AddValue(MaxHP);
			data.AddValue(HP);
			data.AddValue(Atk);
			data.AddValue(Def);
			data.AddValue(SpAtk);
			data.AddValue(SpDef);
			data.AddValue(Spd);

			data.AddValue((u16)ability);

			data.AddValue((u8)types.Count);
			for (u8 i = 0; i < types.Count; i++) {
				data.AddValue((u8)types[i]);
			}

			data.AddValue(weight);

			data.AddValue((u16)HeldItem);

			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				data.AddValue((u16)moves[i]);
				data.AddValue(pp[i]);
				data.AddValue(maxPP[i]);
			}

			data.AddValue((u32)flags);

			data.AddValue((u8)status.Count);
			foreach (Status key in status.Keys) {
				data.AddValue((u16)key);
				data.AddValue(status[key]);
			}
			data.AddValue((u8)statusParams.Count);
			foreach (StatusParam key in statusParams.Keys) {
				data.AddValue((u16)key);
				data.AddValue(statusParams[key]);
			}

			data.AddValue(AttackStages);
			data.AddValue(DefenseStages);
			data.AddValue(SpecialAttackStages);
			data.AddValue(SpecialDefenseStages);
			data.AddValue(SpeedStages);
			data.AddValue(AccuracyStages);
			data.AddValue(EvasivenessStages);

			return data;
		}
		public static BattleMon Load(Buffer data) {
			BattleMon bm = new BattleMon();

			bm.Mon		= Pokemon.Load(data.ReadBuffer());
			bm.Species	= (Species)data.Read16();

			bm.Side		= data.Read8();

			bm.MaxHP	= data.Read16();
			bm.HP		= data.Read16();
			bm.Atk		= data.Read16();
			bm.Def		= data.Read16();
			bm.SpAtk	= data.Read16();
			bm.SpDef	= data.Read16();
			bm.Spd		= data.Read16();

			bm.ability	= (Ability)data.Read16();

			u8 typeCount = data.Read8();
			bm.types = new List<Type>();
			for (u8 i = 0; i < typeCount; i++) {
				bm.types.Add((Type)data.Read8());
			}

			bm.weight	= data.ReadFloat();

			bm.HeldItem	= (Item)data.Read16();

			bm.moves	= new BattleMoveID[Pokemon.MAX_MOVES];
			bm.pp		= new u8[Pokemon.MAX_MOVES];
			bm.maxPP	= new u8[Pokemon.MAX_MOVES];
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				bm.moves[i]	= (BattleMoveID)data.Read16();
				bm.pp[i]	= data.Read8();
				bm.maxPP[i]	= data.Read8();
			}

			bm.flags = (Flag)data.Read32();

			u8 statusCount = data.Read8();
			bm.status = new Dictionary<Status, bool>();
			for (u8 i = 0; i < statusCount; i++) {
				Status key = (Status)data.Read16();
				bm.status[key] = data.ReadBool();
			}
			u8 statusParamCount = data.Read8();
			bm.statusParams = new Dictionary<StatusParam, u16>();
			for (u8 i = 0; i < statusParamCount; i++) {
				StatusParam key = (StatusParam)data.Read16();
				bm.statusParams[key] = data.Read16();
			}

			bm.AttackStages			= data.Reads8();
			bm.DefenseStages			= data.Reads8();
			bm.SpecialAttackStages	= data.Reads8();
			bm.SpecialDefenseStages	= data.Reads8();
			bm.SpeedStages			= data.Reads8();
			bm.AccuracyStages			= data.Reads8();
			bm.EvasivenessStages		= data.Reads8();

			return bm;
		}

		private BattleMon() { }
		public BattleMon(Pokemon src, u8 side) {
			this.Mon		= src;
			this.Species	= src.Box.Species;
			this.MaxHP		= src.maxHp;
			this.HP			= src.hp;
			this.Atk		= src.atk;
			this.Def		= src.def;
			this.SpAtk		= src.spAtk;
			this.SpDef		= src.spDef;
			this.Spd		= src.spd;
			this.ability	= src.Ability;

			this.types = new List<Type>();
			this.types.Add(gBaseStats(Species).type1);
			this.types.Add(gBaseStats(Species).type2);
			
			this.weight		= gBaseStats(Species).weight;

			this.moves	= new BattleMoveID[Pokemon.MAX_MOVES];
			this.pp		= new u8[Pokemon.MAX_MOVES];
			this.maxPP	= new u8[Pokemon.MAX_MOVES];
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				this.moves[i]	= src.Moves[i];
				this.pp[i]		= src.PP[i];
				this.maxPP[i]	= src.MaxPP[i];
			}

			this.Side = side;
			this.flags = 0;
			
			this.status = new Dictionary<Status, bool>();
			this.statusParams = new Dictionary<StatusParam, u16>();
		}
		
		public Pokemon Mon { get; private set; }
		public Species Species { get; private set; }

		public u8 Side { get; private set; }

		public u16 MaxHP { get; set; }
		public u16 HP { get; set; }
		public u16 Atk { get; set; }
		public u16 Def { get; set; }
		public u16 SpAtk { get; set; }
		public u16 SpDef { get; set; }
		public u16 Spd { get; set; }

		private double _healthPercent = -1;
		public double HealthPercent { 
			get {
				if (_healthPercent < 0) {
					_healthPercent = (float)HP / MaxHP;
				}
				return _healthPercent;
			} 
			private set {
				_healthPercent = value;
			} 
		}

		public List<Type> types;
		public Ability ability;
		public float weight;

		public Item HeldItem { get; private set; }

		public BattleMoveID[] moves;
		public u8[] pp;
		public u8[] maxPP;
		
		private Flag flags;

		public delegate Task BattleMonEventHandler(BattleMon bm);
		public BattleMonEventHandler OnMonFainted { get; set; }
		
		private Dictionary<Status, bool> status;
		public Dictionary<StatusParam, u16> statusParams;
		public Status[] Statuses { get {
				List<Status> statuses = new List<Status>();
				foreach (Status s in status.Keys) {
					if (status[s]) {
						statuses.Add(s);
					}
				}
				return statuses.ToArray();
			}
		}

		public sbyte AttackStages { get; private set; }
		public sbyte DefenseStages { get; private set; }
		public sbyte SpecialAttackStages { get; private set; }
		public sbyte SpecialDefenseStages { get; private set; }
		public sbyte SpeedStages { get; private set; }
		public sbyte AccuracyStages { get; private set; }
		public sbyte EvasivenessStages { get; private set; }

		public void SetStatStage(Stat stat, sbyte stage) {
			stage = (sbyte)Mathf.Clamp(stage, MIN_STAT_STAGE, MAX_STAT_STAGE);
			switch (stat) {
				case Stat.ATTACK:			AttackStages = stage;			break;
				case Stat.DEFENSE:			DefenseStages = stage;			break;
				case Stat.SPECIAL_ATTACK:	SpecialAttackStages = stage;	break;
				case Stat.SPECIAL_DEFENSE:	SpecialDefenseStages = stage;	break;
				case Stat.SPEED:			SpeedStages = stage;			break;
				case Stat.ACCURACY:			AccuracyStages = stage;			break;
				case Stat.EVASION:			EvasivenessStages = stage;		break;
			}
		}

		public void ChangeSpecies(Species species) {
			this.Species = species;
		}

		public u16 EffMaxHp(BattleState state) {
			return MaxHP;
		}
		public u16 EffHp(BattleState state) {
			return HP;
		}
		public u16 EffAtk(BattleState state) {
			u16 atk = (u16)(Atk * DamageCalc.GetEffectiveStatMultiplier(AttackStages, Stat.ATTACK));
			atk = (u16)(atk * Battle.RunEventChain(Callback.OnModifyAtk, this, new OnModifySpdParams(state, this)).Result);
			return atk;
		}
		public u16 EffDef(BattleState state) {
			u16 def = (u16)(Def * DamageCalc.GetEffectiveStatMultiplier(DefenseStages, Stat.DEFENSE));
			return def;
		}
		public u16 EffSpAtk(BattleState state) {
			return (u16)(SpAtk * DamageCalc.GetEffectiveStatMultiplier(SpecialAttackStages, Stat.SPECIAL_ATTACK));
		}
		public u16 EffSpDef(BattleState state) {
			u16 spDef = (u16)(SpDef * DamageCalc.GetEffectiveStatMultiplier(SpecialDefenseStages, Stat.SPECIAL_DEFENSE));
			return spDef;
		}
		public u16 GetEffectiveSpd(BattleState state) {
			u16 spd = Spd;
			spd = (u16)(spd * DamageCalc.GetEffectiveStatMultiplier(SpeedStages, Stat.SPEED));
			spd = (u16)(spd * Battle.RunEventChain(Callback.OnModifySpd, this, new OnModifySpdParams(state, this)).Result);
			return spd;
		}

		/// <summary>
		/// Wrapper for Pokemon.GetName()
		/// </summary>
		/// <returns>Nickname if available, species name otherwise.</returns>
		public string GetName() {
			return Mon.GetName();
		}

		/// <summary>
		/// Replaces the move in a given slot.
		/// </summary>
		/// <param name="moveSlot">Slot of the move to replace.</param>
		/// <param name="newMove">ID of the new move.</param>
		public void ReplaceMove(u8 moveSlot, BattleMoveID newMove) {
			if (moveSlot >= Pokemon.MAX_MOVES) {
				throw new System.ArgumentOutOfRangeException();
			}
			moves[moveSlot]	= newMove;
			pp[moveSlot]	= gBattleMoves(newMove).pp;
			maxPP[moveSlot]	= gBattleMoves(newMove).pp;
		}
		public bool KnowsMove(BattleMoveID moveID) {
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				if (moves[i] == moveID) {
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Damages mon.
		/// Note: 'damage' will be changed to the actual amount of HP subtracted, even if the passed value is different.
		/// Sources of indirect damage include: burn/poison/confusion/etc., field hazards, bind, etc. (https://pokemondb.net/pokebase/171940/what-are-the-techniques-that-cause-indirect-damage)
		/// </summary>
		/// <param name="state">The current BattleState.</param>
		/// <param name="damage">The amound of damage to deal.</param>
		/// <param name="force">If force, all checks will be bypassed and HP will be set indiscriminantly.</param>
		/// <param name="direct">Whether or not the damage is direct.</param>
		/// <returns>True if the mon's HP > 0 after the damage, and false if not.</returns>
		public async Task<bool> DamageMon(U16 damage, bool force, bool direct, params string[] detailMessages) {			
			damage.Value = (u16)Mathf.Min(HP, damage.Value);

			bool doDamage = force || await Battle.RunEventCheck(Callback.OnDamage, this, new OnDamageParams(this, damage, force, direct));

			if (!doDamage) {
				return true;
			}

			// Immediately set the HP value.
			HP = (u16)(HP - damage.Value);
			// Set up stuff for constant linear interpolation and ONLY interpolate the percent.
			// This is only for display purposes so the healthbar updates smoothly.
			float t = 0;
			float startVal = (float)HealthPercent;
			float finalVal = (float)HP / MaxHP;
			// Do the actual interpolation
			while (Math.Abs(HealthPercent - finalVal) > EPSILON) {
				HealthPercent = startVal + t * (finalVal - startVal);
				t += HP_CHANGE_SPEED;
				if (t > 1) {
					t = 1;
				}
				await Task.Delay(10);
			}
			// Hard set the percent to the final value to catch any differences left by the interpolation.
			HealthPercent = finalVal;

			// Mark that the mon has received damage this turn.
			SetFlag(Flag.RECEIVED_DAMAGE_THIS_TURN);

			// Display additional details about the damage here.
			// For things like "It's super effective!" and such.
			// Doing it here allows those details to display before OnMonFainted gets invoked.
			if (detailMessages.Length > 0) {
				foreach (string s in detailMessages) {
					if (s == null) {
						continue;
					}
					await MessageBox(s);
				}
			}

			bool fainted = HP == 0;

			if (fainted) {
				GiveStatus(Status.FAINTED);
				await OnMonFainted?.Invoke(this);
			}
			
			return !fainted;
		}

		/// <summary>
		/// Restores mon's HP. 
		/// Note: 'amount' will be changed to the amount of HP restored, even if the passed value is different.
		/// </summary>
		/// <param name="state">Current BattleState.</param>
		/// <param name="amount">The amount of HP to restore.</param>
		/// <param name="force">If force, all checks will be bypassed and HP will be set indiscriminantly.</param>
		/// <returns>True if HP is successfully restored.</returns>
		public async Task<bool> HealMon(U16 amount, bool force) {
			u16 oldHp = HP;

			amount.Value = (u16)Mathf.Min(amount.Value, MaxHP - HP);

			// Immediately set the HP value.
			HP = (u16)(HP + amount.Value);
			// Set up stuff for constant linear interpolation and ONLY interpolate the percent.
			// This is only for display purposes so the healthbar updates smoothly.
			float t = 0;
			float startVal = (float)HealthPercent;
			float finalVal = (float)HP / MaxHP;
			// Do the actual interpolation
			while (Math.Abs(HealthPercent - finalVal) > EPSILON) {
				HealthPercent = startVal + t * (finalVal - startVal);
				t += HP_CHANGE_SPEED;
				if (t > 1) {
					t = 1;
				}
				await Task.Delay(10);
			}
			// Hard set the percent to the final value to catch any differences left by the interpolation.
			HealthPercent = finalVal;

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_HAD_ITS_HP_RESTORED, this);
			await MessageBox(Lang.GetString(StringResource.Namespace.BATTLE_COMMON, contextString, GetName()));
			return HP > oldHp;
		}

		/// <summary>
		/// Determines if a mon is available for battle.
		/// </summary>
		/// <returns>True if the mon can battle.</returns>
		public bool IsAvailable()
		{
			if (Mon == null) {
				return false;
			}

			if (Mon.Box.Species == Species.NONE) {
				return false;
			}
			if (HasStatus(Status.FAINTED)) {
				return false;
			}
			return true;
		}

		public bool IsActive(Battle battle) {
			foreach (BattleMon bm in battle.GetAllActiveMons()) {
				if (bm != null && bm.Equals(this)) {
					return true;
				}
			}
			return false;
		}

		/// @brief Determines if a mon's ability activates.
		/// @param state the current BattleState
		/// @param bm the mon whose ability to check
		/// @param ability the ability to check
		/// @param b_popup whether or not to display the activation
		/// @return true if the mon's ability successfully activates
		public bool AbilityProc(Ability ability, bool popup) {
			// https://bulbapedia.bulbagarden.net/wiki/Ignoring_Abilities#Ignorable_Abilities
			// TODO: Apparently only certain abilities can be negated???
			if (HasStatus(Status.ABILITY_SUPPRESSION)) {
				return false;
			}

			if (this.ability == ability) {
				if (popup) {
					AbilityPopup(this, this.ability);
				}
				return true;
			}

			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="status"></param>
		public void GiveStatus(Status status) {
			this.status[status] = true;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="status"></param>
		public void RemoveStatus(Status status) {
			if (HasStatus(status)) {
				this.status[status] = false;
			}
		}
		/// <summary>
		/// Determines if the mon has one or more of the given statuses.
		/// </summary>
		/// <param name="status"></param>
		/// <returns></returns>
		public bool HasStatus(params Status[] status) {
			foreach (Status s in status) {
				if (this.status.ContainsKey(s) && this.status[s]) {
					return true;
				}
			}
			return false;
		}

		public bool IsAsleep() {
			return HasStatus(Status.SLEEP) || Battle.RunEventCheck(Callback.OnCheckAsleep, this, new OnCheckAsleepParams(this), invert: true).Result;
		}
		public bool IsPoisoned() {
			return HasStatus(Status.POISON) || HasStatus(Status.TOXIC);
		}

		public void SetStatusParam(StatusParam param, u16 value) {
			statusParams[param] = value;
		}
		public u16 GetStatusParam(StatusParam param) {
			if (statusParams.ContainsKey(param)) {
				return statusParams[param];
			}
			else {
				return 0;
			}
		}
		public void IncrementStatusParam(StatusParam param) {
			if (statusParams.ContainsKey(param)) {
				SetStatusParam(param, (u16)(GetStatusParam(param) + 1));
			}
		}
		public void DecrementStatusParam(StatusParam param) {
			if (statusParams.ContainsKey(param)) {
				SetStatusParam(param, (u16)(GetStatusParam(param) - 1));
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public bool HasType(Type type) {
			foreach (Type t in this.types) {
				if (t == type) {
					return true;
				}
			}
			return false;
		}

		public void SetFlag(Flag bmFlag) {
			this.flags |= bmFlag;
		}
		public void RemoveFlag(Flag bmFlag) {
			this.flags &= ~bmFlag;
		}
		public bool HasFlag(Flag bmFlag) {
			return (this.flags & bmFlag) != 0;
		}

		public bool CanBeInflictedWithNVStatus(BattleState state, Status status) {
			// TODO: A Pokémon behind a substitute cannot be poisoned, except due to Synchronize or a held Toxic Orb.
			
			return Battle.RunEventCheck(Callback.OnTryAddNonVolatile, state, new OnTryAddNonVolatileParams(state, this, status)).Result;
		}
		public bool CanBeBurned(BattleState state) {
			if (!CanBeInflictedWithNVStatus(state, Status.BURN)) {
				return false;
			}

			// Fire type pokemon cannot be burned.
			if (HasType(Type.FIRE)) {
				return false;
			}

			return true;
		}
		public bool CanBeFrozen(BattleState state) {
			if (!CanBeInflictedWithNVStatus(state, Status.FREEZE)) {
				return false;
			}

			// Ice type pokemon cannot be frozen.
			return !HasType(Type.ICE);
		}
		public bool CanBeParalyzed(BattleState state) {
			if (!CanBeInflictedWithNVStatus(state, Status.PARALYSIS)) {
				return false;
			}

			// Electric type pokemon cannot be paralyzed.
			return !HasType(Type.ELECTRIC);
		}
		public bool CanBePoisoned(BattleState state) {
			if (!CanBeInflictedWithNVStatus(state, Status.POISON)) {
				return false;
			}

			// TODO: Pokémon with the Ability Pastel Veil will prevent itself and its allies from being poisoned.
			
			// A Pokémon that is currently Poison-type or Steel-type cannot become poisoned, except by Pokémon with the Corrosion Ability.
			if (HasType(Type.POISON) || HasType(Type.STEEL)) {
				return false;
			}

			return true;
		}
		public bool CanFallAsleep(BattleState state) {
			// Also determines if a mon is affected by Yawn.

			if (!CanBeInflictedWithNVStatus(state, Status.SLEEP)) {
				return false;
			}

			return true;
		}
		public bool CanBeConfused(BattleState state) {
			if (!CanBeInflictedWithNVStatus(state, Status.CONFUSION)) {
				return false;
			}
			
			return true;
		}

		/// <summary>
		/// Determines if a given mon can be damaged by hail.
		/// </summary>
		/// <returns>True if the mon can be damaged by hail, false if not.</returns>
		public bool DamagedByHail() {
			// Ice types are not damaged.
			if (HasType(Type.ICE)) {
				return false;
			}
			return Battle.RunEventCheck(Callback.OnCheckIsDamagedByHail, this, new OnCheckIsDamagedByHailParams(this)).Result;
		}
		/// <summary>
		/// Determines the mon can be damaged by a sandstorm.
		/// </summary>
		/// <returns>True if the mon can be damaged by sandstorm, false if not.</returns>
		public bool DamagedBySandstorm() {
			// Rock, steel, and ground types are not damaged.
			if (HasType(Type.ROCK) || HasType(Type.STEEL) || HasType(Type.GROUND)) {
				return false;
			}
			// All other mons are damaged by sandstorm.
			return Battle.RunEventCheck(Callback.OnCheckIsDamagedBySandstorm, this, new OnCheckIsDamagedBySandstormParams(this)).Result;
		}

		public bool IsGrounded(BattleState state) {
			// By default, grounded Pokémon are simply those that are not ungrounded. 
			// However, there are also several effects that will negate a Pokémon's ungrounded status, making it grounded.
			// A Pokémon will be grounded if any of the following apply:

			// It is holding an Iron Ball.
			// It is under the effect of Ingrain, Smack Down, or Thousand Arrows.
			// Gravity is in effect.
			if (Battle.RunEventCheck(Callback.OnCheckIsGrounded, this, new OnCheckIsGroundedParams(this), invert: true).Result) {
				return true;
			}


			// A Pokémon is ungrounded if any of the following apply (and there is no effect that makes it grounded):

			// It has the Flying type.
			// It has the Ability Levitate.
			// It is holding an Air Balloon.
			// It is under the effect of Magnet Rise or Telekinesis.
			if (HasType(Type.FLYING) || Battle.RunEventCheck(Callback.OnCheckIsUngrounded, this, new OnCheckIsUngroundedParams(this), invert: true).Result) {
				return false;
			}

			// All other mons are assumed to be grounded.
			return true;
		}

		public bool CanUseMove(Battle battle, BattleState state, u8 moveSlot, bool print) {
			BattleMove move = gBattleMoves(moves[moveSlot]);

			// Can't use the No-No move :)
			if (moves[moveSlot] == BattleMoveID.NONE) {
				return false;
			}

			// If the move's PP is zero, the move cannot be selected.
			if (pp[moveSlot] == 0) {
				return false;
			}

			// Stop moves that can't be used twice in a row.
			if ((gBattleMoves(moves[moveSlot]).flags & BattleMoves.Flag.CANNOT_USE_MOVE_TWICE) != 0 && GetStatusParam(StatusParam.LAST_USED_MOVE) == moveSlot) {
				if (print) {
					MessageBox(Lang.GetString(StringResource.Namespace.BATTLE_COMMON, BATTLE_COMMON.YOU_CANT_USE_MOVE_TWICE_IN_A_ROW, Lang.GetMoveName(moves[moveSlot])));
				}
				return false;
			}

			return Battle.RunEventCheck(Callback.OnTrySelectMove, this, new OnTrySelectMoveParams(battle, state, this, moves[moveSlot], moveSlot, print)).Result;
		}

		public u16 GetPercentOfMaxHp(float percent) {
			return (u16)(MaxHP * percent);
		}
		public u16 GetPercentOfCurrHp(float percent) {
			return (u16)(HP * percent);
		}

		#region overrides
		public bool Equals(BattleMon obj) {
			return this.Write().Equals(obj.Write());
		}
		public override string ToString() {
			return GetName();
		}
		#endregion
	}
}