using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public static class BattleMoves {
		public const u16 NUM_MOVES = (u16)BattleMoveID.MOVES_NR_ITEMS;

		#region flags
			public const u32 MOVE_TARGET_SELECTED				= 0;		// Any adjacent to the user, not user
			public const u32 MOVE_TARGET_DEPENDS				= 1 << 0;	// 
			public const u32 MOVE_TARGET_USER_OR_SELECTED		= 1 << 1;	// User or any adjacent
			public const u32 MOVE_TARGET_RANDOM					= 1 << 2;	// Random opponent
			public const u32 MOVE_TARGET_BOTH					= 1 << 3;	// 
			public const u32 MOVE_TARGET_USER					= 1 << 4;	// User only
			public const u32 MOVE_TARGET_FOES_AND_ALLY			= 1 << 5;	// Adjacent opponents and all allies, not self
			public const u32 MOVE_TARGET_OPPONENTS_FIELD		= 1 << 6;	// Adjacent opponents, not allies
			public const u32 MOVE_TARGET_SELECTED_OPPONENT		= 1 << 7;	// Selected opponent, but not ally
			public const u32 MOVE_TARGET_USER_OR_ALLY			= 1 << 8;	// User or an ally, not opponent
			public const u32 MOVE_TARGET_SELECTED_ALLY			= 1 << 9;	// Ally, not user or opponent
			public const u32 MOVE_TARGET_ANY_NOT_USER			= 1 << 10;	// Any opponent or ally, not user
			public const u32 MOVE_TARGET_USER_FIELD				= 1 << 11;	// All allies
			public const u32 MOVE_TARGET_ALL					= 1 << 12;	// All mons on field
			public const u32 MOVE_TARGET_ANY					= 1 << 13;	// Any one mon
			public const u32 MOVE_TARGET_ALL_OPPONENTS			= 1 << 14;	// Every opponent, no allies
			public const u32 MOVE_TARGET_USER_FIELD_AND_PARTY	= 1 << 15; // All allies and all mons in the user's party

		[System.Flags] public enum Flag : ulong {
			MAKES_CONTACT				= 1L << 0,
			PROTECT_AFFECTED			= 1L << 1,
			MAGIC_COAT_AFFECTED			= 1L << 2,
			SNATCH_AFFECTED				= 1L << 3,
			MIRROR_MOVE_AFFECTED		= 1L << 4,
			KINGS_ROCK_AFFECTED			= 1L << 5,
			BULLETPROOF_AFFECTED		= 1L << 6,
			SHARPNESS_AFFECTED			= 1L << 7,
			MEGA_LAUNCHER_AFFECTED		= 1L << 8,
			BIG_ROOT_AFFECTED			= 1L << 9,
			LIQUID_OOZE_AFFECTED		= 1L << 10,
			WIND_MOVE					= 1L << 11,
			SOUND_MOVE					= 1L << 12,
			USABLE_OUT_OF_BATTLE		= 1L << 13,
			PUNCH_MOVE					= 1L << 14,
			BITE_MOVE					= 1L << 15,
			PULSE_MOVE					= 1L << 16,
			GRAVITY_AFFECTED			= 1L << 17,
			HIGH_CRITICAL				= 1L << 18,
			HIGH_CRITICAL2				= 1L << 19,
			ALWAYS_CRITICAL				= 1L << 20,
			ALWAYS_HIT					= 1L << 21,
			IGNORE_TYPE_EFF				= 1L << 22,
			CHIP_AWAY					= 1L << 23,
			THAWS_USER					= 1L << 24,
			ALWAYS_HIT_RAIN				= 1L << 25,
			ALWAYS_HIT_HAIL				= 1L << 26,
			USABLE_WHILE_ASLEEP			= 1L << 27,
			HITS_SEMI_INVUL_GROUND		= 1L << 28,
			HITS_SEMI_INVUL_AIR			= 1L << 29,
			HITS_SEMI_INVUL_WATER		= 1L << 30,
			HITS_SEMI_INVUL_PHANTOM		= 1L << 31,
			ACC_LOSS_IN_SUNLIGHT		= 1L << 32,
			PROTECTS					= 1L << 33,
			CHARGING_TURN				= 1L << 34,
			SEMI_INVUL_TURN				= 1L << 35,
			UNUSABLE_BY_SLEEP_TALK		= 1L << 36,
			CANNOT_BE_SKETCHED			= 1L << 37,
			HITS_UNGROUNDED				= 1L << 38,
			CANNOT_USE_MOVE_TWICE		= 1L << 39,
			DOUBLE_DAMAGE_MINIMIZE		= 1L << 40,
		}
		#endregion
	
		/// <summary>
		/// Gets the move detains from a given ID.
		/// </summary>
		/// <param name="move">ID of the move to look up.</param>
		/// <returns>BattleMove corresponding to the given ID.</returns>
		public static BattleMove gBattleMoves(BattleMoveID move) {
			return move switch {
				BattleMoveID.NONE => Definitions.MOVE_NONE,
				BattleMoveID.ABSORB => Definitions.MOVE_ABSORB,
				BattleMoveID.ACCELEROCK => Definitions.MOVE_ACCELEROCK,
				BattleMoveID.ACID => Definitions.MOVE_ACID,
				BattleMoveID.ACID_ARMOR => Definitions.MOVE_ACID_ARMOR,
				BattleMoveID.ACID_SPRAY => Definitions.MOVE_ACID_SPRAY,
				BattleMoveID.ACROBATICS => Definitions.MOVE_ACROBATICS,
				BattleMoveID.ACUPRESSURE => Definitions.MOVE_ACUPRESSURE,
				BattleMoveID.AERIAL_ACE => Definitions.MOVE_AERIAL_ACE,
				BattleMoveID.AEROBLAST => Definitions.MOVE_AEROBLAST,
				BattleMoveID.AFTER_YOU => Definitions.MOVE_AFTER_YOU,
				BattleMoveID.AGILITY => Definitions.MOVE_AGILITY,
				BattleMoveID.AIR_CUTTER => Definitions.MOVE_AIR_CUTTER,
				BattleMoveID.AIR_SLASH => Definitions.MOVE_AIR_SLASH,
				BattleMoveID.ALLY_SWITCH => Definitions.MOVE_ALLY_SWITCH,
				BattleMoveID.AMNESIA => Definitions.MOVE_AMNESIA,
				BattleMoveID.ANCHOR_SHOT => Definitions.MOVE_ANCHOR_SHOT,
				BattleMoveID.ANCIENT_POWER => Definitions.MOVE_ANCIENT_POWER,
				BattleMoveID.APPLE_ACID => Definitions.MOVE_APPLE_ACID,
				BattleMoveID.AQUA_CUTTER => Definitions.MOVE_AQUA_CUTTER,
				BattleMoveID.AQUA_JET => Definitions.MOVE_AQUA_JET,
				BattleMoveID.AQUA_RING => Definitions.MOVE_AQUA_RING,
				BattleMoveID.AQUA_STEP => Definitions.MOVE_AQUA_STEP,
				BattleMoveID.AQUA_TAIL => Definitions.MOVE_AQUA_TAIL,
				BattleMoveID.ARM_THRUST => Definitions.MOVE_ARM_THRUST,
				BattleMoveID.ARMOR_CANNON => Definitions.MOVE_ARMOR_CANNON,
				BattleMoveID.AROMATHERAPY => Definitions.MOVE_AROMATHERAPY,
				BattleMoveID.AROMATIC_MIST => Definitions.MOVE_AROMATIC_MIST,
				BattleMoveID.ASSIST => Definitions.MOVE_ASSIST,
				BattleMoveID.ASSURANCE => Definitions.MOVE_ASSURANCE,
				BattleMoveID.ASTONISH => Definitions.MOVE_ASTONISH,
				BattleMoveID.ASTRAL_BARRAGE => Definitions.MOVE_ASTRAL_BARRAGE,
				BattleMoveID.ATTACK_ORDER => Definitions.MOVE_ATTACK_ORDER,
				BattleMoveID.ATTRACT => Definitions.MOVE_ATTRACT,
				BattleMoveID.AURA_SPHERE => Definitions.MOVE_AURA_SPHERE,
				BattleMoveID.AURA_WHEEL => Definitions.MOVE_AURA_WHEEL,
				BattleMoveID.AURORA_BEAM => Definitions.MOVE_AURORA_BEAM,
				BattleMoveID.AURORA_VEIL => Definitions.MOVE_AURORA_VEIL,
				BattleMoveID.AUTOTOMIZE => Definitions.MOVE_AUTOTOMIZE,
				BattleMoveID.AVALANCHE => Definitions.MOVE_AVALANCHE,
				BattleMoveID.AXE_KICK => Definitions.MOVE_AXE_KICK,
				BattleMoveID.BABY_DOLL_EYES => Definitions.MOVE_BABY_DOLL_EYES,
				BattleMoveID.BANEFUL_BUNKER => Definitions.MOVE_BANEFUL_BUNKER,
				BattleMoveID.BARB_BARRAGE => Definitions.MOVE_BARB_BARRAGE,
				BattleMoveID.BARRAGE => Definitions.MOVE_BARRAGE,
				BattleMoveID.BARRIER => Definitions.MOVE_BARRIER,
				BattleMoveID.BATON_PASS => Definitions.MOVE_BATON_PASS,
				BattleMoveID.BEAK_BLAST => Definitions.MOVE_BEAK_BLAST,
				BattleMoveID.BEAT_UP => Definitions.MOVE_BEAT_UP,
				BattleMoveID.BEHEMOTH_BASH => Definitions.MOVE_BEHEMOTH_BASH,
				BattleMoveID.BEHEMOTH_BLADE => Definitions.MOVE_BEHEMOTH_BLADE,
				BattleMoveID.BELCH => Definitions.MOVE_BELCH,
				BattleMoveID.BELLY_DRUM => Definitions.MOVE_BELLY_DRUM,
				BattleMoveID.BESTOW => Definitions.MOVE_BESTOW,
				BattleMoveID.BIDE => Definitions.MOVE_BIDE,
				BattleMoveID.BIND => Definitions.MOVE_BIND,
				BattleMoveID.BITE => Definitions.MOVE_BITE,
				BattleMoveID.BITTER_BLADE => Definitions.MOVE_BITTER_BLADE,
				BattleMoveID.BITTER_MALICE => Definitions.MOVE_BITTER_MALICE,
				BattleMoveID.BLAST_BURN => Definitions.MOVE_BLAST_BURN,
				BattleMoveID.BLAZE_KICK => Definitions.MOVE_BLAZE_KICK,
				BattleMoveID.BLEAKWIND_STORM => Definitions.MOVE_BLEAKWIND_STORM,
				BattleMoveID.BLIZZARD => Definitions.MOVE_BLIZZARD,
				BattleMoveID.BLOCK => Definitions.MOVE_BLOCK,
				BattleMoveID.BLUE_FLARE => Definitions.MOVE_BLUE_FLARE,
				BattleMoveID.BODY_PRESS => Definitions.MOVE_BODY_PRESS,
				BattleMoveID.BODY_SLAM => Definitions.MOVE_BODY_SLAM,
				BattleMoveID.BOLT_BEAK => Definitions.MOVE_BOLT_BEAK,
				BattleMoveID.BOLT_STRIKE => Definitions.MOVE_BOLT_STRIKE,
				BattleMoveID.BONE_CLUB => Definitions.MOVE_BONE_CLUB,
				BattleMoveID.BONE_RUSH => Definitions.MOVE_BONE_RUSH,
				BattleMoveID.BONEMERANG => Definitions.MOVE_BONEMERANG,
				BattleMoveID.BOOMBURST => Definitions.MOVE_BOOMBURST,
				BattleMoveID.BOUNCE => Definitions.MOVE_BOUNCE,
				BattleMoveID.BRANCH_POKE => Definitions.MOVE_BRANCH_POKE,
				BattleMoveID.BRAVE_BIRD => Definitions.MOVE_BRAVE_BIRD,
				BattleMoveID.BREAKING_SWIPE => Definitions.MOVE_BREAKING_SWIPE,
				BattleMoveID.BRICK_BREAK => Definitions.MOVE_BRICK_BREAK,
				BattleMoveID.BRINE => Definitions.MOVE_BRINE,
				BattleMoveID.BRUTAL_SWING => Definitions.MOVE_BRUTAL_SWING,
				BattleMoveID.BUBBLE => Definitions.MOVE_BUBBLE,
				BattleMoveID.BUBBLE_BEAM => Definitions.MOVE_BUBBLE_BEAM,
				BattleMoveID.BUG_BITE => Definitions.MOVE_BUG_BITE,
				BattleMoveID.BUG_BUZZ => Definitions.MOVE_BUG_BUZZ,
				BattleMoveID.BULK_UP => Definitions.MOVE_BULK_UP,
				BattleMoveID.BULLDOZE => Definitions.MOVE_BULLDOZE,
				BattleMoveID.BULLET_PUNCH => Definitions.MOVE_BULLET_PUNCH,
				BattleMoveID.BULLET_SEED => Definitions.MOVE_BULLET_SEED,
				BattleMoveID.BURN_UP => Definitions.MOVE_BURN_UP,
				BattleMoveID.BURNING_JEALOUSY => Definitions.MOVE_BURNING_JEALOUSY,
				BattleMoveID.CALM_MIND => Definitions.MOVE_CALM_MIND,
				BattleMoveID.CAMOUFLAGE => Definitions.MOVE_CAMOUFLAGE,
				BattleMoveID.CAPTIVATE => Definitions.MOVE_CAPTIVATE,
				BattleMoveID.CEASELESS_EDGE => Definitions.MOVE_CEASELESS_EDGE,
				BattleMoveID.CHARGE => Definitions.MOVE_CHARGE,
				BattleMoveID.CHARGE_BEAM => Definitions.MOVE_CHARGE_BEAM,
				BattleMoveID.CHARM => Definitions.MOVE_CHARM,
				BattleMoveID.CHATTER => Definitions.MOVE_CHATTER,
				BattleMoveID.CHILLING_WATER => Definitions.MOVE_CHILLING_WATER,
				BattleMoveID.CHILLY_RECEPTION => Definitions.MOVE_CHILLY_RECEPTION,
				BattleMoveID.CHIP_AWAY => Definitions.MOVE_CHIP_AWAY,
				BattleMoveID.CHLOROBLAST => Definitions.MOVE_CHLOROBLAST,
				BattleMoveID.CIRCLE_THROW => Definitions.MOVE_CIRCLE_THROW,
				BattleMoveID.CLAMP => Definitions.MOVE_CLAMP,
				BattleMoveID.CLANGING_SCALES => Definitions.MOVE_CLANGING_SCALES,
				BattleMoveID.CLANGOROUS_SOUL => Definitions.MOVE_CLANGOROUS_SOUL,
				BattleMoveID.CLEAR_SMOG => Definitions.MOVE_CLEAR_SMOG,
				BattleMoveID.CLOSE_COMBAT => Definitions.MOVE_CLOSE_COMBAT,
				BattleMoveID.COACHING => Definitions.MOVE_COACHING,
				BattleMoveID.COIL => Definitions.MOVE_COIL,
				BattleMoveID.COLLISION_COURSE => Definitions.MOVE_COLLISION_COURSE,
				BattleMoveID.COMET_PUNCH => Definitions.MOVE_COMET_PUNCH,
				BattleMoveID.COMEUPPANCE => Definitions.MOVE_COMEUPPANCE,
				BattleMoveID.CONFIDE => Definitions.MOVE_CONFIDE,
				BattleMoveID.CONFUSE_RAY => Definitions.MOVE_CONFUSE_RAY,
				BattleMoveID.CONFUSION => Definitions.MOVE_CONFUSION,
				BattleMoveID.CONSTRICT => Definitions.MOVE_CONSTRICT,
				BattleMoveID.CONVERSION => Definitions.MOVE_CONVERSION,
				BattleMoveID.CONVERSION_2 => Definitions.MOVE_CONVERSION_2,
				BattleMoveID.COPYCAT => Definitions.MOVE_COPYCAT,
				BattleMoveID.CORE_ENFORCER => Definitions.MOVE_CORE_ENFORCER,
				BattleMoveID.CORROSIVE_GAS => Definitions.MOVE_CORROSIVE_GAS,
				BattleMoveID.COSMIC_POWER => Definitions.MOVE_COSMIC_POWER,
				BattleMoveID.COTTON_GUARD => Definitions.MOVE_COTTON_GUARD,
				BattleMoveID.COTTON_SPORE => Definitions.MOVE_COTTON_SPORE,
				BattleMoveID.COUNTER => Definitions.MOVE_COUNTER,
				BattleMoveID.COURT_CHANGE => Definitions.MOVE_COURT_CHANGE,
				BattleMoveID.COVET => Definitions.MOVE_COVET,
				BattleMoveID.CRABHAMMER => Definitions.MOVE_CRABHAMMER,
				BattleMoveID.CRAFTY_SHIELD => Definitions.MOVE_CRAFTY_SHIELD,
				BattleMoveID.CROSS_CHOP => Definitions.MOVE_CROSS_CHOP,
				BattleMoveID.CROSS_POISON => Definitions.MOVE_CROSS_POISON,
				BattleMoveID.CRUNCH => Definitions.MOVE_CRUNCH,
				BattleMoveID.CRUSH_CLAW => Definitions.MOVE_CRUSH_CLAW,
				BattleMoveID.CRUSH_GRIP => Definitions.MOVE_CRUSH_GRIP,
				BattleMoveID.CURSE => Definitions.MOVE_CURSE,
				BattleMoveID.CUT => Definitions.MOVE_CUT,
				BattleMoveID.DARK_PULSE => Definitions.MOVE_DARK_PULSE,
				BattleMoveID.DARK_VOID => Definitions.MOVE_DARK_VOID,
				BattleMoveID.DARKEST_LARIAT => Definitions.MOVE_DARKEST_LARIAT,
				BattleMoveID.DAZZLING_GLEAM => Definitions.MOVE_DAZZLING_GLEAM,
				BattleMoveID.DECORATE => Definitions.MOVE_DECORATE,
				BattleMoveID.DEFEND_ORDER => Definitions.MOVE_DEFEND_ORDER,
				BattleMoveID.DEFENSE_CURL => Definitions.MOVE_DEFENSE_CURL,
				BattleMoveID.DEFOG => Definitions.MOVE_DEFOG,
				BattleMoveID.DESTINY_BOND => Definitions.MOVE_DESTINY_BOND,
				BattleMoveID.DETECT => Definitions.MOVE_DETECT,
				BattleMoveID.DIAMOND_STORM => Definitions.MOVE_DIAMOND_STORM,
				BattleMoveID.DIG => Definitions.MOVE_DIG,
				BattleMoveID.DIRE_CLAW => Definitions.MOVE_DIRE_CLAW,
				BattleMoveID.DISABLE => Definitions.MOVE_DISABLE,
				BattleMoveID.DISARMING_VOICE => Definitions.MOVE_DISARMING_VOICE,
				BattleMoveID.DISCHARGE => Definitions.MOVE_DISCHARGE,
				BattleMoveID.DIVE => Definitions.MOVE_DIVE,
				BattleMoveID.DIZZY_PUNCH => Definitions.MOVE_DIZZY_PUNCH,
				BattleMoveID.DOODLE => Definitions.MOVE_DOODLE,
				BattleMoveID.DOOM_DESIRE => Definitions.MOVE_DOOM_DESIRE,
				BattleMoveID.DOUBLE_HIT => Definitions.MOVE_DOUBLE_HIT,
				BattleMoveID.DOUBLE_IRON_BASH => Definitions.MOVE_DOUBLE_IRON_BASH,
				BattleMoveID.DOUBLE_KICK => Definitions.MOVE_DOUBLE_KICK,
				BattleMoveID.DOUBLE_SHOCK => Definitions.MOVE_DOUBLE_SHOCK,
				BattleMoveID.DOUBLE_SLAP => Definitions.MOVE_DOUBLE_SLAP,
				BattleMoveID.DOUBLE_TEAM => Definitions.MOVE_DOUBLE_TEAM,
				BattleMoveID.DOUBLE_EDGE => Definitions.MOVE_DOUBLE_EDGE,
				BattleMoveID.DRACO_METEOR => Definitions.MOVE_DRACO_METEOR,
				BattleMoveID.DRAGON_ASCENT => Definitions.MOVE_DRAGON_ASCENT,
				BattleMoveID.DRAGON_BREATH => Definitions.MOVE_DRAGON_BREATH,
				BattleMoveID.DRAGON_CLAW => Definitions.MOVE_DRAGON_CLAW,
				BattleMoveID.DRAGON_DANCE => Definitions.MOVE_DRAGON_DANCE,
				BattleMoveID.DRAGON_DARTS => Definitions.MOVE_DRAGON_DARTS,
				BattleMoveID.DRAGON_ENERGY => Definitions.MOVE_DRAGON_ENERGY,
				BattleMoveID.DRAGON_HAMMER => Definitions.MOVE_DRAGON_HAMMER,
				BattleMoveID.DRAGON_PULSE => Definitions.MOVE_DRAGON_PULSE,
				BattleMoveID.DRAGON_RAGE => Definitions.MOVE_DRAGON_RAGE,
				BattleMoveID.DRAGON_RUSH => Definitions.MOVE_DRAGON_RUSH,
				BattleMoveID.DRAGON_TAIL => Definitions.MOVE_DRAGON_TAIL,
				BattleMoveID.DRAIN_PUNCH => Definitions.MOVE_DRAIN_PUNCH,
				BattleMoveID.DRAINING_KISS => Definitions.MOVE_DRAINING_KISS,
				BattleMoveID.DREAM_EATER => Definitions.MOVE_DREAM_EATER,
				BattleMoveID.DRILL_PECK => Definitions.MOVE_DRILL_PECK,
				BattleMoveID.DRILL_RUN => Definitions.MOVE_DRILL_RUN,
				BattleMoveID.DRUM_BEATING => Definitions.MOVE_DRUM_BEATING,
				BattleMoveID.DUAL_CHOP => Definitions.MOVE_DUAL_CHOP,
				BattleMoveID.DUAL_WINGBEAT => Definitions.MOVE_DUAL_WINGBEAT,
				BattleMoveID.DYNAMAX_CANNON => Definitions.MOVE_DYNAMAX_CANNON,
				BattleMoveID.DYNAMIC_PUNCH => Definitions.MOVE_DYNAMIC_PUNCH,
				BattleMoveID.EARTH_POWER => Definitions.MOVE_EARTH_POWER,
				BattleMoveID.EARTHQUAKE => Definitions.MOVE_EARTHQUAKE,
				BattleMoveID.ECHOED_VOICE => Definitions.MOVE_ECHOED_VOICE,
				BattleMoveID.EERIE_IMPULSE => Definitions.MOVE_EERIE_IMPULSE,
				BattleMoveID.EERIE_SPELL => Definitions.MOVE_EERIE_SPELL,
				BattleMoveID.EGG_BOMB => Definitions.MOVE_EGG_BOMB,
				BattleMoveID.ELECTRIC_TERRAIN => Definitions.MOVE_ELECTRIC_TERRAIN,
				BattleMoveID.ELECTRIFY => Definitions.MOVE_ELECTRIFY,
				BattleMoveID.ELECTRO_BALL => Definitions.MOVE_ELECTRO_BALL,
				BattleMoveID.ELECTRO_DRIFT => Definitions.MOVE_ELECTRO_DRIFT,
				BattleMoveID.ELECTROWEB => Definitions.MOVE_ELECTROWEB,
				BattleMoveID.EMBARGO => Definitions.MOVE_EMBARGO,
				BattleMoveID.EMBER => Definitions.MOVE_EMBER,
				BattleMoveID.ENCORE => Definitions.MOVE_ENCORE,
				BattleMoveID.ENDEAVOR => Definitions.MOVE_ENDEAVOR,
				BattleMoveID.ENDURE => Definitions.MOVE_ENDURE,
				BattleMoveID.ENERGY_BALL => Definitions.MOVE_ENERGY_BALL,
				BattleMoveID.ENTRAINMENT => Definitions.MOVE_ENTRAINMENT,
				BattleMoveID.ERUPTION => Definitions.MOVE_ERUPTION,
				BattleMoveID.ESPER_WING => Definitions.MOVE_ESPER_WING,
				BattleMoveID.ETERNABEAM => Definitions.MOVE_ETERNABEAM,
				BattleMoveID.EXPANDING_FORCE => Definitions.MOVE_EXPANDING_FORCE,
				BattleMoveID.EXPLOSION => Definitions.MOVE_EXPLOSION,
				BattleMoveID.EXTRASENSORY => Definitions.MOVE_EXTRASENSORY,
				BattleMoveID.EXTREME_SPEED => Definitions.MOVE_EXTREME_SPEED,
				BattleMoveID.FACADE => Definitions.MOVE_FACADE,
				BattleMoveID.FAIRY_LOCK => Definitions.MOVE_FAIRY_LOCK,
				BattleMoveID.FAIRY_WIND => Definitions.MOVE_FAIRY_WIND,
				BattleMoveID.FAKE_OUT => Definitions.MOVE_FAKE_OUT,
				BattleMoveID.FAKE_TEARS => Definitions.MOVE_FAKE_TEARS,
				BattleMoveID.FALSE_SURRENDER => Definitions.MOVE_FALSE_SURRENDER,
				BattleMoveID.FALSE_SWIPE => Definitions.MOVE_FALSE_SWIPE,
				BattleMoveID.FEATHER_DANCE => Definitions.MOVE_FEATHER_DANCE,
				BattleMoveID.FEINT => Definitions.MOVE_FEINT,
				BattleMoveID.FEINT_ATTACK => Definitions.MOVE_FEINT_ATTACK,
				BattleMoveID.FELL_STINGER => Definitions.MOVE_FELL_STINGER,
				BattleMoveID.FIERY_DANCE => Definitions.MOVE_FIERY_DANCE,
				BattleMoveID.FIERY_WRATH => Definitions.MOVE_FIERY_WRATH,
				BattleMoveID.FILLET_AWAY => Definitions.MOVE_FILLET_AWAY,
				BattleMoveID.FINAL_GAMBIT => Definitions.MOVE_FINAL_GAMBIT,
				BattleMoveID.FIRE_BLAST => Definitions.MOVE_FIRE_BLAST,
				BattleMoveID.FIRE_FANG => Definitions.MOVE_FIRE_FANG,
				BattleMoveID.FIRE_LASH => Definitions.MOVE_FIRE_LASH,
				BattleMoveID.FIRE_PLEDGE => Definitions.MOVE_FIRE_PLEDGE,
				BattleMoveID.FIRE_PUNCH => Definitions.MOVE_FIRE_PUNCH,
				BattleMoveID.FIRE_SPIN => Definitions.MOVE_FIRE_SPIN,
				BattleMoveID.FIRST_IMPRESSION => Definitions.MOVE_FIRST_IMPRESSION,
				BattleMoveID.FISHIOUS_REND => Definitions.MOVE_FISHIOUS_REND,
				BattleMoveID.FISSURE => Definitions.MOVE_FISSURE,
				BattleMoveID.FLAIL => Definitions.MOVE_FLAIL,
				BattleMoveID.FLAME_BURST => Definitions.MOVE_FLAME_BURST,
				BattleMoveID.FLAME_CHARGE => Definitions.MOVE_FLAME_CHARGE,
				BattleMoveID.FLAME_WHEEL => Definitions.MOVE_FLAME_WHEEL,
				BattleMoveID.FLAMETHROWER => Definitions.MOVE_FLAMETHROWER,
				BattleMoveID.FLARE_BLITZ => Definitions.MOVE_FLARE_BLITZ,
				BattleMoveID.FLASH => Definitions.MOVE_FLASH,
				BattleMoveID.FLASH_CANNON => Definitions.MOVE_FLASH_CANNON,
				BattleMoveID.FLATTER => Definitions.MOVE_FLATTER,
				BattleMoveID.FLEUR_CANNON => Definitions.MOVE_FLEUR_CANNON,
				BattleMoveID.FLING => Definitions.MOVE_FLING,
				BattleMoveID.FLIP_TURN => Definitions.MOVE_FLIP_TURN,
				BattleMoveID.FLORAL_HEALING => Definitions.MOVE_FLORAL_HEALING,
				BattleMoveID.FLOWER_SHIELD => Definitions.MOVE_FLOWER_SHIELD,
				BattleMoveID.FLOWER_TRICK => Definitions.MOVE_FLOWER_TRICK,
				BattleMoveID.FLY => Definitions.MOVE_FLY,
				BattleMoveID.FLYING_PRESS => Definitions.MOVE_FLYING_PRESS,
				BattleMoveID.FOCUS_BLAST => Definitions.MOVE_FOCUS_BLAST,
				BattleMoveID.FOCUS_ENERGY => Definitions.MOVE_FOCUS_ENERGY,
				BattleMoveID.FOCUS_PUNCH => Definitions.MOVE_FOCUS_PUNCH,
				BattleMoveID.FOLLOW_ME => Definitions.MOVE_FOLLOW_ME,
				BattleMoveID.FORCE_PALM => Definitions.MOVE_FORCE_PALM,
				BattleMoveID.FORESIGHT => Definitions.MOVE_FORESIGHT,
				BattleMoveID.FOREST_S_CURSE => Definitions.MOVE_FOREST_S_CURSE,
				BattleMoveID.FOUL_PLAY => Definitions.MOVE_FOUL_PLAY,
				BattleMoveID.FREEZE_SHOCK => Definitions.MOVE_FREEZE_SHOCK,
				BattleMoveID.FREEZE_DRY => Definitions.MOVE_FREEZE_DRY,
				BattleMoveID.FREEZING_GLARE => Definitions.MOVE_FREEZING_GLARE,
				BattleMoveID.FRENZY_PLANT => Definitions.MOVE_FRENZY_PLANT,
				BattleMoveID.FROST_BREATH => Definitions.MOVE_FROST_BREATH,
				BattleMoveID.FRUSTRATION => Definitions.MOVE_FRUSTRATION,
				BattleMoveID.FURY_ATTACK => Definitions.MOVE_FURY_ATTACK,
				BattleMoveID.FURY_CUTTER => Definitions.MOVE_FURY_CUTTER,
				BattleMoveID.FURY_SWIPES => Definitions.MOVE_FURY_SWIPES,
				BattleMoveID.FUSION_BOLT => Definitions.MOVE_FUSION_BOLT,
				BattleMoveID.FUSION_FLARE => Definitions.MOVE_FUSION_FLARE,
				BattleMoveID.FUTURE_SIGHT => Definitions.MOVE_FUTURE_SIGHT,
				BattleMoveID.GASTRO_ACID => Definitions.MOVE_GASTRO_ACID,
				BattleMoveID.GEAR_GRIND => Definitions.MOVE_GEAR_GRIND,
				BattleMoveID.GEAR_UP => Definitions.MOVE_GEAR_UP,
				BattleMoveID.GEOMANCY => Definitions.MOVE_GEOMANCY,
				BattleMoveID.GIGA_DRAIN => Definitions.MOVE_GIGA_DRAIN,
				BattleMoveID.GIGA_IMPACT => Definitions.MOVE_GIGA_IMPACT,
				BattleMoveID.GIGATON_HAMMER => Definitions.MOVE_GIGATON_HAMMER,
				BattleMoveID.GLACIAL_LANCE => Definitions.MOVE_GLACIAL_LANCE,
				BattleMoveID.GLACIATE => Definitions.MOVE_GLACIATE,
				BattleMoveID.GLAIVE_RUSH => Definitions.MOVE_GLAIVE_RUSH,
				BattleMoveID.GLARE => Definitions.MOVE_GLARE,
				BattleMoveID.GRASS_KNOT => Definitions.MOVE_GRASS_KNOT,
				BattleMoveID.GRASS_PLEDGE => Definitions.MOVE_GRASS_PLEDGE,
				BattleMoveID.GRASS_WHISTLE => Definitions.MOVE_GRASS_WHISTLE,
				BattleMoveID.GRASSY_TERRAIN => Definitions.MOVE_GRASSY_TERRAIN,
				BattleMoveID.GRAV_APPLE => Definitions.MOVE_GRAV_APPLE,
				BattleMoveID.GRAVITY => Definitions.MOVE_GRAVITY,
				BattleMoveID.GROWL => Definitions.MOVE_GROWL,
				BattleMoveID.GROWTH => Definitions.MOVE_GROWTH,
				BattleMoveID.GRUDGE => Definitions.MOVE_GRUDGE,
				BattleMoveID.GUARD_SPLIT => Definitions.MOVE_GUARD_SPLIT,
				BattleMoveID.GUARD_SWAP => Definitions.MOVE_GUARD_SWAP,
				BattleMoveID.GUILLOTINE => Definitions.MOVE_GUILLOTINE,
				BattleMoveID.GUNK_SHOT => Definitions.MOVE_GUNK_SHOT,
				BattleMoveID.GUST => Definitions.MOVE_GUST,
				BattleMoveID.GYRO_BALL => Definitions.MOVE_GYRO_BALL,
				BattleMoveID.HAIL => Definitions.MOVE_HAIL,
				BattleMoveID.HAMMER_ARM => Definitions.MOVE_HAMMER_ARM,
				BattleMoveID.HAPPY_HOUR => Definitions.MOVE_HAPPY_HOUR,
				BattleMoveID.HARDEN => Definitions.MOVE_HARDEN,
				BattleMoveID.HAZE => Definitions.MOVE_HAZE,
				BattleMoveID.HEAD_CHARGE => Definitions.MOVE_HEAD_CHARGE,
				BattleMoveID.HEAD_SMASH => Definitions.MOVE_HEAD_SMASH,
				BattleMoveID.HEADBUTT => Definitions.MOVE_HEADBUTT,
				BattleMoveID.HEADLONG_RUSH => Definitions.MOVE_HEADLONG_RUSH,
				BattleMoveID.HEAL_BELL => Definitions.MOVE_HEAL_BELL,
				BattleMoveID.HEAL_BLOCK => Definitions.MOVE_HEAL_BLOCK,
				BattleMoveID.HEAL_ORDER => Definitions.MOVE_HEAL_ORDER,
				BattleMoveID.HEAL_PULSE => Definitions.MOVE_HEAL_PULSE,
				BattleMoveID.HEALING_WISH => Definitions.MOVE_HEALING_WISH,
				BattleMoveID.HEART_STAMP => Definitions.MOVE_HEART_STAMP,
				BattleMoveID.HEART_SWAP => Definitions.MOVE_HEART_SWAP,
				BattleMoveID.HEAT_CRASH => Definitions.MOVE_HEAT_CRASH,
				BattleMoveID.HEAT_WAVE => Definitions.MOVE_HEAT_WAVE,
				BattleMoveID.HEAVY_SLAM => Definitions.MOVE_HEAVY_SLAM,
				BattleMoveID.HELPING_HAND => Definitions.MOVE_HELPING_HAND,
				BattleMoveID.HEX => Definitions.MOVE_HEX,
				BattleMoveID.HIDDEN_POWER => Definitions.MOVE_HIDDEN_POWER,
				BattleMoveID.HIGH_HORSEPOWER => Definitions.MOVE_HIGH_HORSEPOWER,
				BattleMoveID.HIGH_JUMP_KICK => Definitions.MOVE_HIGH_JUMP_KICK,
				BattleMoveID.HOLD_BACK => Definitions.MOVE_HOLD_BACK,
				BattleMoveID.HONE_CLAWS => Definitions.MOVE_HONE_CLAWS,
				BattleMoveID.HORN_ATTACK => Definitions.MOVE_HORN_ATTACK,
				BattleMoveID.HORN_DRILL => Definitions.MOVE_HORN_DRILL,
				BattleMoveID.HORN_LEECH => Definitions.MOVE_HORN_LEECH,
				BattleMoveID.HOWL => Definitions.MOVE_HOWL,
				BattleMoveID.HURRICANE => Definitions.MOVE_HURRICANE,
				BattleMoveID.HYDRO_CANNON => Definitions.MOVE_HYDRO_CANNON,
				BattleMoveID.HYDRO_PUMP => Definitions.MOVE_HYDRO_PUMP,
				BattleMoveID.HYDRO_STEAM => Definitions.MOVE_HYDRO_STEAM,
				BattleMoveID.HYPER_BEAM => Definitions.MOVE_HYPER_BEAM,
				BattleMoveID.HYPER_DRILL => Definitions.MOVE_HYPER_DRILL,
				BattleMoveID.HYPER_FANG => Definitions.MOVE_HYPER_FANG,
				BattleMoveID.HYPER_VOICE => Definitions.MOVE_HYPER_VOICE,
				BattleMoveID.HYPERSPACE_FURY => Definitions.MOVE_HYPERSPACE_FURY,
				BattleMoveID.HYPERSPACE_HOLE => Definitions.MOVE_HYPERSPACE_HOLE,
				BattleMoveID.HYPNOSIS => Definitions.MOVE_HYPNOSIS,
				BattleMoveID.ICE_BALL => Definitions.MOVE_ICE_BALL,
				BattleMoveID.ICE_BEAM => Definitions.MOVE_ICE_BEAM,
				BattleMoveID.ICE_BURN => Definitions.MOVE_ICE_BURN,
				BattleMoveID.ICE_FANG => Definitions.MOVE_ICE_FANG,
				BattleMoveID.ICE_HAMMER => Definitions.MOVE_ICE_HAMMER,
				BattleMoveID.ICE_PUNCH => Definitions.MOVE_ICE_PUNCH,
				BattleMoveID.ICE_SHARD => Definitions.MOVE_ICE_SHARD,
				BattleMoveID.ICE_SPINNER => Definitions.MOVE_ICE_SPINNER,
				BattleMoveID.ICICLE_CRASH => Definitions.MOVE_ICICLE_CRASH,
				BattleMoveID.ICICLE_SPEAR => Definitions.MOVE_ICICLE_SPEAR,
				BattleMoveID.ICY_WIND => Definitions.MOVE_ICY_WIND,
				BattleMoveID.IMPRISON => Definitions.MOVE_IMPRISON,
				BattleMoveID.INCINERATE => Definitions.MOVE_INCINERATE,
				BattleMoveID.INFERNAL_PARADE => Definitions.MOVE_INFERNAL_PARADE,
				BattleMoveID.INFERNO => Definitions.MOVE_INFERNO,
				BattleMoveID.INFESTATION => Definitions.MOVE_INFESTATION,
				BattleMoveID.INGRAIN => Definitions.MOVE_INGRAIN,
				BattleMoveID.INSTRUCT => Definitions.MOVE_INSTRUCT,
				BattleMoveID.ION_DELUGE => Definitions.MOVE_ION_DELUGE,
				BattleMoveID.IRON_DEFENSE => Definitions.MOVE_IRON_DEFENSE,
				BattleMoveID.IRON_HEAD => Definitions.MOVE_IRON_HEAD,
				BattleMoveID.IRON_TAIL => Definitions.MOVE_IRON_TAIL,
				BattleMoveID.JAW_LOCK => Definitions.MOVE_JAW_LOCK,
				BattleMoveID.JET_PUNCH => Definitions.MOVE_JET_PUNCH,
				BattleMoveID.JUDGMENT => Definitions.MOVE_JUDGMENT,
				BattleMoveID.JUMP_KICK => Definitions.MOVE_JUMP_KICK,
				BattleMoveID.JUNGLE_HEALING => Definitions.MOVE_JUNGLE_HEALING,
				BattleMoveID.KARATE_CHOP => Definitions.MOVE_KARATE_CHOP,
				BattleMoveID.KINESIS => Definitions.MOVE_KINESIS,
				BattleMoveID.KING_S_SHIELD => Definitions.MOVE_KING_S_SHIELD,
				BattleMoveID.KNOCK_OFF => Definitions.MOVE_KNOCK_OFF,
				BattleMoveID.KOWTOW_CLEAVE => Definitions.MOVE_KOWTOW_CLEAVE,
				BattleMoveID.LAND_S_WRATH => Definitions.MOVE_LAND_S_WRATH,
				BattleMoveID.LASER_FOCUS => Definitions.MOVE_LASER_FOCUS,
				BattleMoveID.LASH_OUT => Definitions.MOVE_LASH_OUT,
				BattleMoveID.LAST_RESORT => Definitions.MOVE_LAST_RESORT,
				BattleMoveID.LAST_RESPECTS => Definitions.MOVE_LAST_RESPECTS,
				BattleMoveID.LAVA_PLUME => Definitions.MOVE_LAVA_PLUME,
				BattleMoveID.LEAF_BLADE => Definitions.MOVE_LEAF_BLADE,
				BattleMoveID.LEAF_STORM => Definitions.MOVE_LEAF_STORM,
				BattleMoveID.LEAF_TORNADO => Definitions.MOVE_LEAF_TORNADO,
				BattleMoveID.LEAFAGE => Definitions.MOVE_LEAFAGE,
				BattleMoveID.LEECH_LIFE => Definitions.MOVE_LEECH_LIFE,
				BattleMoveID.LEECH_SEED => Definitions.MOVE_LEECH_SEED,
				BattleMoveID.LEER => Definitions.MOVE_LEER,
				BattleMoveID.LICK => Definitions.MOVE_LICK,
				BattleMoveID.LIFE_DEW => Definitions.MOVE_LIFE_DEW,
				BattleMoveID.LIGHT_OF_RUIN => Definitions.MOVE_LIGHT_OF_RUIN,
				BattleMoveID.LIGHT_SCREEN => Definitions.MOVE_LIGHT_SCREEN,
				BattleMoveID.LIQUIDATION => Definitions.MOVE_LIQUIDATION,
				BattleMoveID.LOCK_ON => Definitions.MOVE_LOCK_ON,
				BattleMoveID.LOVELY_KISS => Definitions.MOVE_LOVELY_KISS,
				BattleMoveID.LOW_KICK => Definitions.MOVE_LOW_KICK,
				BattleMoveID.LOW_SWEEP => Definitions.MOVE_LOW_SWEEP,
				BattleMoveID.LUCKY_CHANT => Definitions.MOVE_LUCKY_CHANT,
				BattleMoveID.LUMINA_CRASH => Definitions.MOVE_LUMINA_CRASH,
				BattleMoveID.LUNAR_BLESSING => Definitions.MOVE_LUNAR_BLESSING,
				BattleMoveID.LUNAR_DANCE => Definitions.MOVE_LUNAR_DANCE,
				BattleMoveID.LUNGE => Definitions.MOVE_LUNGE,
				BattleMoveID.LUSTER_PURGE => Definitions.MOVE_LUSTER_PURGE,
				BattleMoveID.MACH_PUNCH => Definitions.MOVE_MACH_PUNCH,
				BattleMoveID.MAGIC_COAT => Definitions.MOVE_MAGIC_COAT,
				BattleMoveID.MAGIC_POWDER => Definitions.MOVE_MAGIC_POWDER,
				BattleMoveID.MAGIC_ROOM => Definitions.MOVE_MAGIC_ROOM,
				BattleMoveID.MAGICAL_LEAF => Definitions.MOVE_MAGICAL_LEAF,
				BattleMoveID.MAGMA_STORM => Definitions.MOVE_MAGMA_STORM,
				BattleMoveID.MAGNET_BOMB => Definitions.MOVE_MAGNET_BOMB,
				BattleMoveID.MAGNET_RISE => Definitions.MOVE_MAGNET_RISE,
				BattleMoveID.MAGNETIC_FLUX => Definitions.MOVE_MAGNETIC_FLUX,
				BattleMoveID.MAGNITUDE => Definitions.MOVE_MAGNITUDE,
				BattleMoveID.MAKE_IT_RAIN => Definitions.MOVE_MAKE_IT_RAIN,
				BattleMoveID.MAT_BLOCK => Definitions.MOVE_MAT_BLOCK,
				BattleMoveID.ME_FIRST => Definitions.MOVE_ME_FIRST,
				BattleMoveID.MEAN_LOOK => Definitions.MOVE_MEAN_LOOK,
				BattleMoveID.MEDITATE => Definitions.MOVE_MEDITATE,
				BattleMoveID.MEGA_DRAIN => Definitions.MOVE_MEGA_DRAIN,
				BattleMoveID.MEGA_KICK => Definitions.MOVE_MEGA_KICK,
				BattleMoveID.MEGA_PUNCH => Definitions.MOVE_MEGA_PUNCH,
				BattleMoveID.MEGAHORN => Definitions.MOVE_MEGAHORN,
				BattleMoveID.MEMENTO => Definitions.MOVE_MEMENTO,
				BattleMoveID.METAL_BURST => Definitions.MOVE_METAL_BURST,
				BattleMoveID.METAL_CLAW => Definitions.MOVE_METAL_CLAW,
				BattleMoveID.METAL_SOUND => Definitions.MOVE_METAL_SOUND,
				BattleMoveID.METEOR_ASSAULT => Definitions.MOVE_METEOR_ASSAULT,
				BattleMoveID.METEOR_BEAM => Definitions.MOVE_METEOR_BEAM,
				BattleMoveID.METEOR_MASH => Definitions.MOVE_METEOR_MASH,
				BattleMoveID.METRONOME => Definitions.MOVE_METRONOME,
				BattleMoveID.MILK_DRINK => Definitions.MOVE_MILK_DRINK,
				BattleMoveID.MIMIC => Definitions.MOVE_MIMIC,
				BattleMoveID.MIND_BLOWN => Definitions.MOVE_MIND_BLOWN,
				BattleMoveID.MIND_READER => Definitions.MOVE_MIND_READER,
				BattleMoveID.MINIMIZE => Definitions.MOVE_MINIMIZE,
				BattleMoveID.MIRACLE_EYE => Definitions.MOVE_MIRACLE_EYE,
				BattleMoveID.MIRROR_COAT => Definitions.MOVE_MIRROR_COAT,
				BattleMoveID.MIRROR_MOVE => Definitions.MOVE_MIRROR_MOVE,
				BattleMoveID.MIRROR_SHOT => Definitions.MOVE_MIRROR_SHOT,
				BattleMoveID.MIST => Definitions.MOVE_MIST,
				BattleMoveID.MIST_BALL => Definitions.MOVE_MIST_BALL,
				BattleMoveID.MISTY_EXPLOSION => Definitions.MOVE_MISTY_EXPLOSION,
				BattleMoveID.MISTY_TERRAIN => Definitions.MOVE_MISTY_TERRAIN,
				BattleMoveID.MOONBLAST => Definitions.MOVE_MOONBLAST,
				BattleMoveID.MOONGEIST_BEAM => Definitions.MOVE_MOONGEIST_BEAM,
				BattleMoveID.MOONLIGHT => Definitions.MOVE_MOONLIGHT,
				BattleMoveID.MORNING_SUN => Definitions.MOVE_MORNING_SUN,
				BattleMoveID.MORTAL_SPIN => Definitions.MOVE_MORTAL_SPIN,
				BattleMoveID.MOUNTAIN_GALE => Definitions.MOVE_MOUNTAIN_GALE,
				BattleMoveID.MUD_BOMB => Definitions.MOVE_MUD_BOMB,
				BattleMoveID.MUD_SHOT => Definitions.MOVE_MUD_SHOT,
				BattleMoveID.MUD_SPORT => Definitions.MOVE_MUD_SPORT,
				BattleMoveID.MUD_SLAP => Definitions.MOVE_MUD_SLAP,
				BattleMoveID.MUDDY_WATER => Definitions.MOVE_MUDDY_WATER,
				BattleMoveID.MULTI_ATTACK => Definitions.MOVE_MULTI_ATTACK,
				BattleMoveID.MYSTICAL_FIRE => Definitions.MOVE_MYSTICAL_FIRE,
				BattleMoveID.MYSTICAL_POWER => Definitions.MOVE_MYSTICAL_POWER,
				BattleMoveID.NASTY_PLOT => Definitions.MOVE_NASTY_PLOT,
				BattleMoveID.NATURAL_GIFT => Definitions.MOVE_NATURAL_GIFT,
				BattleMoveID.NATURE_POWER => Definitions.MOVE_NATURE_POWER,
				BattleMoveID.NATURE_S_MADNESS => Definitions.MOVE_NATURE_S_MADNESS,
				BattleMoveID.NEEDLE_ARM => Definitions.MOVE_NEEDLE_ARM,
				BattleMoveID.NIGHT_DAZE => Definitions.MOVE_NIGHT_DAZE,
				BattleMoveID.NIGHT_SHADE => Definitions.MOVE_NIGHT_SHADE,
				BattleMoveID.NIGHT_SLASH => Definitions.MOVE_NIGHT_SLASH,
				BattleMoveID.NIGHTMARE => Definitions.MOVE_NIGHTMARE,
				BattleMoveID.NO_RETREAT => Definitions.MOVE_NO_RETREAT,
				BattleMoveID.NOBLE_ROAR => Definitions.MOVE_NOBLE_ROAR,
				BattleMoveID.NUZZLE => Definitions.MOVE_NUZZLE,
				BattleMoveID.OBLIVION_WING => Definitions.MOVE_OBLIVION_WING,
				BattleMoveID.OBSTRUCT => Definitions.MOVE_OBSTRUCT,
				BattleMoveID.OCTAZOOKA => Definitions.MOVE_OCTAZOOKA,
				BattleMoveID.OCTOLOCK => Definitions.MOVE_OCTOLOCK,
				BattleMoveID.ODOR_SLEUTH => Definitions.MOVE_ODOR_SLEUTH,
				BattleMoveID.OMINOUS_WIND => Definitions.MOVE_OMINOUS_WIND,
				BattleMoveID.ORDER_UP => Definitions.MOVE_ORDER_UP,
				BattleMoveID.ORIGIN_PULSE => Definitions.MOVE_ORIGIN_PULSE,
				BattleMoveID.OUTRAGE => Definitions.MOVE_OUTRAGE,
				BattleMoveID.OVERDRIVE => Definitions.MOVE_OVERDRIVE,
				BattleMoveID.OVERHEAT => Definitions.MOVE_OVERHEAT,
				BattleMoveID.PAIN_SPLIT => Definitions.MOVE_PAIN_SPLIT,
				BattleMoveID.PARABOLIC_CHARGE => Definitions.MOVE_PARABOLIC_CHARGE,
				BattleMoveID.PARTING_SHOT => Definitions.MOVE_PARTING_SHOT,
				BattleMoveID.PAY_DAY => Definitions.MOVE_PAY_DAY,
				BattleMoveID.PAYBACK => Definitions.MOVE_PAYBACK,
				BattleMoveID.PECK => Definitions.MOVE_PECK,
				BattleMoveID.PERISH_SONG => Definitions.MOVE_PERISH_SONG,
				BattleMoveID.PETAL_BLIZZARD => Definitions.MOVE_PETAL_BLIZZARD,
				BattleMoveID.PETAL_DANCE => Definitions.MOVE_PETAL_DANCE,
				BattleMoveID.PHANTOM_FORCE => Definitions.MOVE_PHANTOM_FORCE,
				BattleMoveID.PHOTON_GEYSER => Definitions.MOVE_PHOTON_GEYSER,
				BattleMoveID.PIN_MISSILE => Definitions.MOVE_PIN_MISSILE,
				BattleMoveID.PLASMA_FISTS => Definitions.MOVE_PLASMA_FISTS,
				BattleMoveID.PLAY_NICE => Definitions.MOVE_PLAY_NICE,
				BattleMoveID.PLAY_ROUGH => Definitions.MOVE_PLAY_ROUGH,
				BattleMoveID.PLUCK => Definitions.MOVE_PLUCK,
				BattleMoveID.POISON_FANG => Definitions.MOVE_POISON_FANG,
				BattleMoveID.POISON_GAS => Definitions.MOVE_POISON_GAS,
				BattleMoveID.POISON_JAB => Definitions.MOVE_POISON_JAB,
				BattleMoveID.POISON_POWDER => Definitions.MOVE_POISON_POWDER,
				BattleMoveID.POISON_STING => Definitions.MOVE_POISON_STING,
				BattleMoveID.POISON_TAIL => Definitions.MOVE_POISON_TAIL,
				BattleMoveID.POLLEN_PUFF => Definitions.MOVE_POLLEN_PUFF,
				BattleMoveID.POLTERGEIST => Definitions.MOVE_POLTERGEIST,
				BattleMoveID.POPULATION_BOMB => Definitions.MOVE_POPULATION_BOMB,
				BattleMoveID.POUNCE => Definitions.MOVE_POUNCE,
				BattleMoveID.POUND => Definitions.MOVE_POUND,
				BattleMoveID.POWDER => Definitions.MOVE_POWDER,
				BattleMoveID.POWDER_SNOW => Definitions.MOVE_POWDER_SNOW,
				BattleMoveID.POWER_GEM => Definitions.MOVE_POWER_GEM,
				BattleMoveID.POWER_SHIFT => Definitions.MOVE_POWER_SHIFT,
				BattleMoveID.POWER_SPLIT => Definitions.MOVE_POWER_SPLIT,
				BattleMoveID.POWER_SWAP => Definitions.MOVE_POWER_SWAP,
				BattleMoveID.POWER_TRICK => Definitions.MOVE_POWER_TRICK,
				BattleMoveID.POWER_TRIP => Definitions.MOVE_POWER_TRIP,
				BattleMoveID.POWER_WHIP => Definitions.MOVE_POWER_WHIP,
				BattleMoveID.POWER_UP_PUNCH => Definitions.MOVE_POWER_UP_PUNCH,
				BattleMoveID.PRECIPICE_BLADES => Definitions.MOVE_PRECIPICE_BLADES,
				BattleMoveID.PRESENT => Definitions.MOVE_PRESENT,
				BattleMoveID.PRISMATIC_LASER => Definitions.MOVE_PRISMATIC_LASER,
				BattleMoveID.PROTECT => Definitions.MOVE_PROTECT,
				BattleMoveID.PSYBEAM => Definitions.MOVE_PSYBEAM,
				BattleMoveID.PSYBLADE => Definitions.MOVE_PSYBLADE,
				BattleMoveID.PSYCH_UP => Definitions.MOVE_PSYCH_UP,
				BattleMoveID.PSYCHIC => Definitions.MOVE_PSYCHIC,
				BattleMoveID.PSYCHIC_FANGS => Definitions.MOVE_PSYCHIC_FANGS,
				BattleMoveID.PSYCHIC_TERRAIN => Definitions.MOVE_PSYCHIC_TERRAIN,
				BattleMoveID.PSYCHO_BOOST => Definitions.MOVE_PSYCHO_BOOST,
				BattleMoveID.PSYCHO_CUT => Definitions.MOVE_PSYCHO_CUT,
				BattleMoveID.PSYCHO_SHIFT => Definitions.MOVE_PSYCHO_SHIFT,
				BattleMoveID.PSYSHIELD_BASH => Definitions.MOVE_PSYSHIELD_BASH,
				BattleMoveID.PSYSHOCK => Definitions.MOVE_PSYSHOCK,
				BattleMoveID.PSYSTRIKE => Definitions.MOVE_PSYSTRIKE,
				BattleMoveID.PSYWAVE => Definitions.MOVE_PSYWAVE,
				BattleMoveID.PUNISHMENT => Definitions.MOVE_PUNISHMENT,
				BattleMoveID.PURIFY => Definitions.MOVE_PURIFY,
				BattleMoveID.PURSUIT => Definitions.MOVE_PURSUIT,
				BattleMoveID.PYRO_BALL => Definitions.MOVE_PYRO_BALL,
				BattleMoveID.QUASH => Definitions.MOVE_QUASH,
				BattleMoveID.QUICK_ATTACK => Definitions.MOVE_QUICK_ATTACK,
				BattleMoveID.QUICK_GUARD => Definitions.MOVE_QUICK_GUARD,
				BattleMoveID.QUIVER_DANCE => Definitions.MOVE_QUIVER_DANCE,
				BattleMoveID.RAGE => Definitions.MOVE_RAGE,
				BattleMoveID.RAGE_FIST => Definitions.MOVE_RAGE_FIST,
				BattleMoveID.RAGE_POWDER => Definitions.MOVE_RAGE_POWDER,
				BattleMoveID.RAGING_BULL => Definitions.MOVE_RAGING_BULL,
				BattleMoveID.RAGING_FURY => Definitions.MOVE_RAGING_FURY,
				BattleMoveID.RAIN_DANCE => Definitions.MOVE_RAIN_DANCE,
				BattleMoveID.RAPID_SPIN => Definitions.MOVE_RAPID_SPIN,
				BattleMoveID.RAZOR_LEAF => Definitions.MOVE_RAZOR_LEAF,
				BattleMoveID.RAZOR_SHELL => Definitions.MOVE_RAZOR_SHELL,
				BattleMoveID.RAZOR_WIND => Definitions.MOVE_RAZOR_WIND,
				BattleMoveID.RECOVER => Definitions.MOVE_RECOVER,
				BattleMoveID.RECYCLE => Definitions.MOVE_RECYCLE,
				BattleMoveID.REFLECT => Definitions.MOVE_REFLECT,
				BattleMoveID.REFLECT_TYPE => Definitions.MOVE_REFLECT_TYPE,
				BattleMoveID.REFRESH => Definitions.MOVE_REFRESH,
				BattleMoveID.RELIC_SONG => Definitions.MOVE_RELIC_SONG,
				BattleMoveID.REST => Definitions.MOVE_REST,
				BattleMoveID.RETALIATE => Definitions.MOVE_RETALIATE,
				BattleMoveID.RETURN => Definitions.MOVE_RETURN,
				BattleMoveID.REVELATION_DANCE => Definitions.MOVE_REVELATION_DANCE,
				BattleMoveID.REVENGE => Definitions.MOVE_REVENGE,
				BattleMoveID.REVERSAL => Definitions.MOVE_REVERSAL,
				BattleMoveID.REVIVAL_BLESSING => Definitions.MOVE_REVIVAL_BLESSING,
				BattleMoveID.RISING_VOLTAGE => Definitions.MOVE_RISING_VOLTAGE,
				BattleMoveID.ROAR => Definitions.MOVE_ROAR,
				BattleMoveID.ROAR_OF_TIME => Definitions.MOVE_ROAR_OF_TIME,
				BattleMoveID.ROCK_BLAST => Definitions.MOVE_ROCK_BLAST,
				BattleMoveID.ROCK_CLIMB => Definitions.MOVE_ROCK_CLIMB,
				BattleMoveID.ROCK_POLISH => Definitions.MOVE_ROCK_POLISH,
				BattleMoveID.ROCK_SLIDE => Definitions.MOVE_ROCK_SLIDE,
				BattleMoveID.ROCK_SMASH => Definitions.MOVE_ROCK_SMASH,
				BattleMoveID.ROCK_THROW => Definitions.MOVE_ROCK_THROW,
				BattleMoveID.ROCK_TOMB => Definitions.MOVE_ROCK_TOMB,
				BattleMoveID.ROCK_WRECKER => Definitions.MOVE_ROCK_WRECKER,
				BattleMoveID.ROLE_PLAY => Definitions.MOVE_ROLE_PLAY,
				BattleMoveID.ROLLING_KICK => Definitions.MOVE_ROLLING_KICK,
				BattleMoveID.ROLLOUT => Definitions.MOVE_ROLLOUT,
				BattleMoveID.ROOST => Definitions.MOVE_ROOST,
				BattleMoveID.ROTOTILLER => Definitions.MOVE_ROTOTILLER,
				BattleMoveID.ROUND => Definitions.MOVE_ROUND,
				BattleMoveID.RUINATION => Definitions.MOVE_RUINATION,
				BattleMoveID.SACRED_FIRE => Definitions.MOVE_SACRED_FIRE,
				BattleMoveID.SACRED_SWORD => Definitions.MOVE_SACRED_SWORD,
				BattleMoveID.SAFEGUARD => Definitions.MOVE_SAFEGUARD,
				BattleMoveID.SALT_CURE => Definitions.MOVE_SALT_CURE,
				BattleMoveID.SAND_ATTACK => Definitions.MOVE_SAND_ATTACK,
				BattleMoveID.SAND_TOMB => Definitions.MOVE_SAND_TOMB,
				BattleMoveID.SANDSEAR_STORM => Definitions.MOVE_SANDSEAR_STORM,
				BattleMoveID.SANDSTORM => Definitions.MOVE_SANDSTORM,
				BattleMoveID.SCALD => Definitions.MOVE_SCALD,
				BattleMoveID.SCALE_SHOT => Definitions.MOVE_SCALE_SHOT,
				BattleMoveID.SCARY_FACE => Definitions.MOVE_SCARY_FACE,
				BattleMoveID.SCORCHING_SANDS => Definitions.MOVE_SCORCHING_SANDS,
				BattleMoveID.SCRATCH => Definitions.MOVE_SCRATCH,
				BattleMoveID.SCREECH => Definitions.MOVE_SCREECH,
				BattleMoveID.SEARING_SHOT => Definitions.MOVE_SEARING_SHOT,
				BattleMoveID.SECRET_POWER => Definitions.MOVE_SECRET_POWER,
				BattleMoveID.SECRET_SWORD => Definitions.MOVE_SECRET_SWORD,
				BattleMoveID.SEED_BOMB => Definitions.MOVE_SEED_BOMB,
				BattleMoveID.SEED_FLARE => Definitions.MOVE_SEED_FLARE,
				BattleMoveID.SEISMIC_TOSS => Definitions.MOVE_SEISMIC_TOSS,
				BattleMoveID.SELF_DESTRUCT => Definitions.MOVE_SELF_DESTRUCT,
				BattleMoveID.SHADOW_BALL => Definitions.MOVE_SHADOW_BALL,
				BattleMoveID.SHADOW_BONE => Definitions.MOVE_SHADOW_BONE,
				BattleMoveID.SHADOW_CLAW => Definitions.MOVE_SHADOW_CLAW,
				BattleMoveID.SHADOW_FORCE => Definitions.MOVE_SHADOW_FORCE,
				BattleMoveID.SHADOW_PUNCH => Definitions.MOVE_SHADOW_PUNCH,
				BattleMoveID.SHADOW_SNEAK => Definitions.MOVE_SHADOW_SNEAK,
				BattleMoveID.SHARPEN => Definitions.MOVE_SHARPEN,
				BattleMoveID.SHED_TAIL => Definitions.MOVE_SHED_TAIL,
				BattleMoveID.SHEER_COLD => Definitions.MOVE_SHEER_COLD,
				BattleMoveID.SHELL_SIDE_ARM => Definitions.MOVE_SHELL_SIDE_ARM,
				BattleMoveID.SHELL_SMASH => Definitions.MOVE_SHELL_SMASH,
				BattleMoveID.SHELL_TRAP => Definitions.MOVE_SHELL_TRAP,
				BattleMoveID.SHELTER => Definitions.MOVE_SHELTER,
				BattleMoveID.SHIFT_GEAR => Definitions.MOVE_SHIFT_GEAR,
				BattleMoveID.SHOCK_WAVE => Definitions.MOVE_SHOCK_WAVE,
				BattleMoveID.SHORE_UP => Definitions.MOVE_SHORE_UP,
				BattleMoveID.SIGNAL_BEAM => Definitions.MOVE_SIGNAL_BEAM,
				BattleMoveID.SILK_TRAP => Definitions.MOVE_SILK_TRAP,
				BattleMoveID.SILVER_WIND => Definitions.MOVE_SILVER_WIND,
				BattleMoveID.SIMPLE_BEAM => Definitions.MOVE_SIMPLE_BEAM,
				BattleMoveID.SING => Definitions.MOVE_SING,
				BattleMoveID.SKETCH => Definitions.MOVE_SKETCH,
				BattleMoveID.SKILL_SWAP => Definitions.MOVE_SKILL_SWAP,
				BattleMoveID.SKITTER_SMACK => Definitions.MOVE_SKITTER_SMACK,
				BattleMoveID.SKULL_BASH => Definitions.MOVE_SKULL_BASH,
				BattleMoveID.SKY_ATTACK => Definitions.MOVE_SKY_ATTACK,
				BattleMoveID.SKY_DROP => Definitions.MOVE_SKY_DROP,
				BattleMoveID.SKY_UPPERCUT => Definitions.MOVE_SKY_UPPERCUT,
				BattleMoveID.SLACK_OFF => Definitions.MOVE_SLACK_OFF,
				BattleMoveID.SLAM => Definitions.MOVE_SLAM,
				BattleMoveID.SLASH => Definitions.MOVE_SLASH,
				BattleMoveID.SLEEP_POWDER => Definitions.MOVE_SLEEP_POWDER,
				BattleMoveID.SLEEP_TALK => Definitions.MOVE_SLEEP_TALK,
				BattleMoveID.SLUDGE => Definitions.MOVE_SLUDGE,
				BattleMoveID.SLUDGE_BOMB => Definitions.MOVE_SLUDGE_BOMB,
				BattleMoveID.SLUDGE_WAVE => Definitions.MOVE_SLUDGE_WAVE,
				BattleMoveID.SMACK_DOWN => Definitions.MOVE_SMACK_DOWN,
				BattleMoveID.SMART_STRIKE => Definitions.MOVE_SMART_STRIKE,
				BattleMoveID.SMELLING_SALTS => Definitions.MOVE_SMELLING_SALTS,
				BattleMoveID.SMOG => Definitions.MOVE_SMOG,
				BattleMoveID.SMOKESCREEN => Definitions.MOVE_SMOKESCREEN,
				BattleMoveID.SNAP_TRAP => Definitions.MOVE_SNAP_TRAP,
				BattleMoveID.SNARL => Definitions.MOVE_SNARL,
				BattleMoveID.SNATCH => Definitions.MOVE_SNATCH,
				BattleMoveID.SNIPE_SHOT => Definitions.MOVE_SNIPE_SHOT,
				BattleMoveID.SNORE => Definitions.MOVE_SNORE,
				BattleMoveID.SNOWSCAPE => Definitions.MOVE_SNOWSCAPE,
				BattleMoveID.SOAK => Definitions.MOVE_SOAK,
				BattleMoveID.SOFT_BOILED => Definitions.MOVE_SOFT_BOILED,
				BattleMoveID.SOLAR_BEAM => Definitions.MOVE_SOLAR_BEAM,
				BattleMoveID.SOLAR_BLADE => Definitions.MOVE_SOLAR_BLADE,
				BattleMoveID.SONIC_BOOM => Definitions.MOVE_SONIC_BOOM,
				BattleMoveID.SPACIAL_REND => Definitions.MOVE_SPACIAL_REND,
				BattleMoveID.SPARK => Definitions.MOVE_SPARK,
				BattleMoveID.SPARKLING_ARIA => Definitions.MOVE_SPARKLING_ARIA,
				BattleMoveID.SPECTRAL_THIEF => Definitions.MOVE_SPECTRAL_THIEF,
				BattleMoveID.SPEED_SWAP => Definitions.MOVE_SPEED_SWAP,
				BattleMoveID.SPICY_EXTRACT => Definitions.MOVE_SPICY_EXTRACT,
				BattleMoveID.SPIDER_WEB => Definitions.MOVE_SPIDER_WEB,
				BattleMoveID.SPIKE_CANNON => Definitions.MOVE_SPIKE_CANNON,
				BattleMoveID.SPIKES => Definitions.MOVE_SPIKES,
				BattleMoveID.SPIKY_SHIELD => Definitions.MOVE_SPIKY_SHIELD,
				BattleMoveID.SPIN_OUT => Definitions.MOVE_SPIN_OUT,
				BattleMoveID.SPIRIT_BREAK => Definitions.MOVE_SPIRIT_BREAK,
				BattleMoveID.SPIRIT_SHACKLE => Definitions.MOVE_SPIRIT_SHACKLE,
				BattleMoveID.SPIT_UP => Definitions.MOVE_SPIT_UP,
				BattleMoveID.SPITE => Definitions.MOVE_SPITE,
				BattleMoveID.SPLASH => Definitions.MOVE_SPLASH,
				BattleMoveID.SPORE => Definitions.MOVE_SPORE,
				BattleMoveID.SPOTLIGHT => Definitions.MOVE_SPOTLIGHT,
				BattleMoveID.SPRINGTIDE_STORM => Definitions.MOVE_SPRINGTIDE_STORM,
				BattleMoveID.STEALTH_ROCK => Definitions.MOVE_STEALTH_ROCK,
				BattleMoveID.STEAM_ERUPTION => Definitions.MOVE_STEAM_ERUPTION,
				BattleMoveID.STEAMROLLER => Definitions.MOVE_STEAMROLLER,
				BattleMoveID.STEEL_BEAM => Definitions.MOVE_STEEL_BEAM,
				BattleMoveID.STEEL_ROLLER => Definitions.MOVE_STEEL_ROLLER,
				BattleMoveID.STEEL_WING => Definitions.MOVE_STEEL_WING,
				BattleMoveID.STICKY_WEB => Definitions.MOVE_STICKY_WEB,
				BattleMoveID.STOCKPILE => Definitions.MOVE_STOCKPILE,
				BattleMoveID.STOMP => Definitions.MOVE_STOMP,
				BattleMoveID.STOMPING_TANTRUM => Definitions.MOVE_STOMPING_TANTRUM,
				BattleMoveID.STONE_AXE => Definitions.MOVE_STONE_AXE,
				BattleMoveID.STONE_EDGE => Definitions.MOVE_STONE_EDGE,
				BattleMoveID.STORED_POWER => Definitions.MOVE_STORED_POWER,
				BattleMoveID.STORM_THROW => Definitions.MOVE_STORM_THROW,
				BattleMoveID.STRANGE_STEAM => Definitions.MOVE_STRANGE_STEAM,
				BattleMoveID.STRENGTH => Definitions.MOVE_STRENGTH,
				BattleMoveID.STRENGTH_SAP => Definitions.MOVE_STRENGTH_SAP,
				BattleMoveID.STRING_SHOT => Definitions.MOVE_STRING_SHOT,
				BattleMoveID.STRUGGLE => Definitions.MOVE_STRUGGLE,
				BattleMoveID.STRUGGLE_BUG => Definitions.MOVE_STRUGGLE_BUG,
				BattleMoveID.STUFF_CHEEKS => Definitions.MOVE_STUFF_CHEEKS,
				BattleMoveID.STUN_SPORE => Definitions.MOVE_STUN_SPORE,
				BattleMoveID.SUBMISSION => Definitions.MOVE_SUBMISSION,
				BattleMoveID.SUBSTITUTE => Definitions.MOVE_SUBSTITUTE,
				BattleMoveID.SUCKER_PUNCH => Definitions.MOVE_SUCKER_PUNCH,
				BattleMoveID.SUNNY_DAY => Definitions.MOVE_SUNNY_DAY,
				BattleMoveID.SUNSTEEL_STRIKE => Definitions.MOVE_SUNSTEEL_STRIKE,
				BattleMoveID.SUPER_FANG => Definitions.MOVE_SUPER_FANG,
				BattleMoveID.SUPERPOWER => Definitions.MOVE_SUPERPOWER,
				BattleMoveID.SUPERSONIC => Definitions.MOVE_SUPERSONIC,
				BattleMoveID.SURF => Definitions.MOVE_SURF,
				BattleMoveID.SURGING_STRIKES => Definitions.MOVE_SURGING_STRIKES,
				BattleMoveID.SWAGGER => Definitions.MOVE_SWAGGER,
				BattleMoveID.SWALLOW => Definitions.MOVE_SWALLOW,
				BattleMoveID.SWEET_KISS => Definitions.MOVE_SWEET_KISS,
				BattleMoveID.SWEET_SCENT => Definitions.MOVE_SWEET_SCENT,
				BattleMoveID.SWIFT => Definitions.MOVE_SWIFT,
				BattleMoveID.SWITCHEROO => Definitions.MOVE_SWITCHEROO,
				BattleMoveID.SWORDS_DANCE => Definitions.MOVE_SWORDS_DANCE,
				BattleMoveID.SYNCHRONOISE => Definitions.MOVE_SYNCHRONOISE,
				BattleMoveID.SYNTHESIS => Definitions.MOVE_SYNTHESIS,
				BattleMoveID.TACKLE => Definitions.MOVE_TACKLE,
				BattleMoveID.TAIL_GLOW => Definitions.MOVE_TAIL_GLOW,
				BattleMoveID.TAIL_SLAP => Definitions.MOVE_TAIL_SLAP,
				BattleMoveID.TAIL_WHIP => Definitions.MOVE_TAIL_WHIP,
				BattleMoveID.TAILWIND => Definitions.MOVE_TAILWIND,
				BattleMoveID.TAKE_DOWN => Definitions.MOVE_TAKE_DOWN,
				BattleMoveID.TAKE_HEART => Definitions.MOVE_TAKE_HEART,
				BattleMoveID.TAR_SHOT => Definitions.MOVE_TAR_SHOT,
				BattleMoveID.TAUNT => Definitions.MOVE_TAUNT,
				BattleMoveID.TEARFUL_LOOK => Definitions.MOVE_TEARFUL_LOOK,
				BattleMoveID.TEATIME => Definitions.MOVE_TEATIME,
				BattleMoveID.TECHNO_BLAST => Definitions.MOVE_TECHNO_BLAST,
				BattleMoveID.TEETER_DANCE => Definitions.MOVE_TEETER_DANCE,
				BattleMoveID.TELEKINESIS => Definitions.MOVE_TELEKINESIS,
				BattleMoveID.TELEPORT => Definitions.MOVE_TELEPORT,
				BattleMoveID.TERRAIN_PULSE => Definitions.MOVE_TERRAIN_PULSE,
				BattleMoveID.THIEF => Definitions.MOVE_THIEF,
				BattleMoveID.THOUSAND_ARROWS => Definitions.MOVE_THOUSAND_ARROWS,
				BattleMoveID.THOUSAND_WAVES => Definitions.MOVE_THOUSAND_WAVES,
				BattleMoveID.THRASH => Definitions.MOVE_THRASH,
				BattleMoveID.THROAT_CHOP => Definitions.MOVE_THROAT_CHOP,
				BattleMoveID.THUNDER => Definitions.MOVE_THUNDER,
				BattleMoveID.THUNDER_CAGE => Definitions.MOVE_THUNDER_CAGE,
				BattleMoveID.THUNDER_FANG => Definitions.MOVE_THUNDER_FANG,
				BattleMoveID.THUNDER_PUNCH => Definitions.MOVE_THUNDER_PUNCH,
				BattleMoveID.THUNDER_SHOCK => Definitions.MOVE_THUNDER_SHOCK,
				BattleMoveID.THUNDER_WAVE => Definitions.MOVE_THUNDER_WAVE,
				BattleMoveID.THUNDERBOLT => Definitions.MOVE_THUNDERBOLT,
				BattleMoveID.THUNDEROUS_KICK => Definitions.MOVE_THUNDEROUS_KICK,
				BattleMoveID.TICKLE => Definitions.MOVE_TICKLE,
				BattleMoveID.TIDY_UP => Definitions.MOVE_TIDY_UP,
				BattleMoveID.TOPSY_TURVY => Definitions.MOVE_TOPSY_TURVY,
				BattleMoveID.TORCH_SONG => Definitions.MOVE_TORCH_SONG,
				BattleMoveID.TORMENT => Definitions.MOVE_TORMENT,
				BattleMoveID.TOXIC => Definitions.MOVE_TOXIC,
				BattleMoveID.TOXIC_SPIKES => Definitions.MOVE_TOXIC_SPIKES,
				BattleMoveID.TOXIC_THREAD => Definitions.MOVE_TOXIC_THREAD,
				BattleMoveID.TRAILBLAZE => Definitions.MOVE_TRAILBLAZE,
				BattleMoveID.TRANSFORM => Definitions.MOVE_TRANSFORM,
				BattleMoveID.TRI_ATTACK => Definitions.MOVE_TRI_ATTACK,
				BattleMoveID.TRICK => Definitions.MOVE_TRICK,
				BattleMoveID.TRICK_ROOM => Definitions.MOVE_TRICK_ROOM,
				BattleMoveID.TRICK_OR_TREAT => Definitions.MOVE_TRICK_OR_TREAT,
				BattleMoveID.TRIPLE_ARROWS => Definitions.MOVE_TRIPLE_ARROWS,
				BattleMoveID.TRIPLE_AXEL => Definitions.MOVE_TRIPLE_AXEL,
				BattleMoveID.TRIPLE_DIVE => Definitions.MOVE_TRIPLE_DIVE,
				BattleMoveID.TRIPLE_KICK => Definitions.MOVE_TRIPLE_KICK,
				BattleMoveID.TROP_KICK => Definitions.MOVE_TROP_KICK,
				BattleMoveID.TRUMP_CARD => Definitions.MOVE_TRUMP_CARD,
				BattleMoveID.TWIN_BEAM => Definitions.MOVE_TWIN_BEAM,
				BattleMoveID.TWINEEDLE => Definitions.MOVE_TWINEEDLE,
				BattleMoveID.TWISTER => Definitions.MOVE_TWISTER,
				BattleMoveID.U_TURN => Definitions.MOVE_U_TURN,
				BattleMoveID.UPROAR => Definitions.MOVE_UPROAR,
				BattleMoveID.V_CREATE => Definitions.MOVE_V_CREATE,
				BattleMoveID.VACUUM_WAVE => Definitions.MOVE_VACUUM_WAVE,
				BattleMoveID.VENOM_DRENCH => Definitions.MOVE_VENOM_DRENCH,
				BattleMoveID.VENOSHOCK => Definitions.MOVE_VENOSHOCK,
				BattleMoveID.VICTORY_DANCE => Definitions.MOVE_VICTORY_DANCE,
				BattleMoveID.VINE_WHIP => Definitions.MOVE_VINE_WHIP,
				BattleMoveID.VISE_GRIP => Definitions.MOVE_VISE_GRIP,
				BattleMoveID.VITAL_THROW => Definitions.MOVE_VITAL_THROW,
				BattleMoveID.VOLT_SWITCH => Definitions.MOVE_VOLT_SWITCH,
				BattleMoveID.VOLT_TACKLE => Definitions.MOVE_VOLT_TACKLE,
				BattleMoveID.WAKE_UP_SLAP => Definitions.MOVE_WAKE_UP_SLAP,
				BattleMoveID.WATER_GUN => Definitions.MOVE_WATER_GUN,
				BattleMoveID.WATER_PLEDGE => Definitions.MOVE_WATER_PLEDGE,
				BattleMoveID.WATER_PULSE => Definitions.MOVE_WATER_PULSE,
				BattleMoveID.WATER_SHURIKEN => Definitions.MOVE_WATER_SHURIKEN,
				BattleMoveID.WATER_SPORT => Definitions.MOVE_WATER_SPORT,
				BattleMoveID.WATER_SPOUT => Definitions.MOVE_WATER_SPOUT,
				BattleMoveID.WATERFALL => Definitions.MOVE_WATERFALL,
				BattleMoveID.WAVE_CRASH => Definitions.MOVE_WAVE_CRASH,
				BattleMoveID.WEATHER_BALL => Definitions.MOVE_WEATHER_BALL,
				BattleMoveID.WHIRLPOOL => Definitions.MOVE_WHIRLPOOL,
				BattleMoveID.WHIRLWIND => Definitions.MOVE_WHIRLWIND,
				BattleMoveID.WICKED_BLOW => Definitions.MOVE_WICKED_BLOW,
				BattleMoveID.WIDE_GUARD => Definitions.MOVE_WIDE_GUARD,
				BattleMoveID.WILD_CHARGE => Definitions.MOVE_WILD_CHARGE,
				BattleMoveID.WILDBOLT_STORM => Definitions.MOVE_WILDBOLT_STORM,
				BattleMoveID.WILL_O_WISP => Definitions.MOVE_WILL_O_WISP,
				BattleMoveID.WING_ATTACK => Definitions.MOVE_WING_ATTACK,
				BattleMoveID.WISH => Definitions.MOVE_WISH,
				BattleMoveID.WITHDRAW => Definitions.MOVE_WITHDRAW,
				BattleMoveID.WONDER_ROOM => Definitions.MOVE_WONDER_ROOM,
				BattleMoveID.WOOD_HAMMER => Definitions.MOVE_WOOD_HAMMER,
				BattleMoveID.WORK_UP => Definitions.MOVE_WORK_UP,
				BattleMoveID.WORRY_SEED => Definitions.MOVE_WORRY_SEED,
				BattleMoveID.WRAP => Definitions.MOVE_WRAP,
				BattleMoveID.WRING_OUT => Definitions.MOVE_WRING_OUT,
				BattleMoveID.X_SCISSOR => Definitions.MOVE_X_SCISSOR,
				BattleMoveID.YAWN => Definitions.MOVE_YAWN,
				BattleMoveID.ZAP_CANNON => Definitions.MOVE_ZAP_CANNON,
				BattleMoveID.ZEN_HEADBUTT => Definitions.MOVE_ZEN_HEADBUTT,
				BattleMoveID.ZING_ZAP => Definitions.MOVE_ZING_ZAP,
				_ => throw new Strings.MoveNotRecognizedException(move)
			};
		}

		static class Definitions {
			public static BattleMove MOVE_NONE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NONE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 0,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ 0,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.NONE,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ABSORB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BIG_ROOT_AFFECTED | Flag.LIQUID_OOZE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ACCELEROCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ACID {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED_OPPONENT,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ACID_ARMOR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ACID_SPRAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT2,
						/*moveType =*/ Type.POISON,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ACROBATICS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ACROBATICS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 55,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ACUPRESSURE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RANDOMUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_OR_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_AERIAL_ACE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.SHARPNESS_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.MAKES_CONTACT
					);
				}
			}
			public static BattleMove MOVE_AEROBLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 100,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_AFTER_YOU {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.AFTERYOU,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_AGILITY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPEEDUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AIR_CUTTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 60,
						/*accuracy =*/ 95,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AIR_SLASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 75,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ALLY_SWITCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ALLYSWITCH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 2,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_AMNESIA {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALDEFENSEUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ANCHOR_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.TRAP,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ANCIENT_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ALLSTATSUP,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_APPLE_ACID {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AQUA_CUTTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.HIGH_CRITICAL | Flag.SHARPNESS_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AQUA_JET {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AQUA_RING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.AQUARING,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AQUA_STEP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDUP,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AQUA_TAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 90,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ARM_THRUST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 15,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ARMOR_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFANDSPDEFDOWN,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AROMATHERAPY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CURENONVOLATILESTATUSHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AROMATIC_MIST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALDEFENSEUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ASSIST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ASSIST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK
					);
				}
			}
			public static BattleMove MOVE_ASSURANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ASSURANCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ASTONISH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 30,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ASTRAL_BARRAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ATTACK_ORDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.HIGH_CRITICAL | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ATTRACT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTRACT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.IGNORE_TYPE_EFF
					);
				}
			}
			public static BattleMove MOVE_AURA_SPHERE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 80,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.PULSE_MOVE | Flag.MEGA_LAUNCHER_AFFECTED | Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AURA_WHEEL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDUP,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 110,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AURORA_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AURORA_VEIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.AURORAVEIL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AUTOTOMIZE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.AUTOTOMIZE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AVALANCHE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.AVALANCHE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -4,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_AXE_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.JUMPKICK,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 120,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BABY_DOLL_EYES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BANEFUL_BUNKER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BANEFULBUNKER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_BARB_BARRAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BARBBARRAGE,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BARRAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 15,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BARRIER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BATON_PASS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BATONPASS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_BEAK_BLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BEAKBLAST,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -3,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BEAT_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BEATUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BEHEMOTH_BASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BEHEMOTH_BLADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BELCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BELCH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 120,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BELLY_DRUM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BELLYDRUM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BESTOW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BESTOW,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BIDE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BIDE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_BIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 15,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BITE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BITE_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BITTER_BLADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.HEALHALF,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BIG_ROOT_AFFECTED | Flag.SHARPNESS_AFFECTED | Flag.LIQUID_OOZE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BITTER_MALICE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BLAST_BURN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BLAZE_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 85,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_BLEAKWIND_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 100,
						/*accuracy =*/ 80,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.ALWAYS_HIT_RAIN
					);
				}
			}
			public static BattleMove MOVE_BLIZZARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 110,
						/*accuracy =*/ 70,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.WIND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT_HAIL
					);
				}
			}
			public static BattleMove MOVE_BLOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BLUE_FLARE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 130,
						/*accuracy =*/ 85,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BODY_PRESS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BODYPRESS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BODY_SLAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BOLT_BEAK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BOLTBEAK,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BOLT_STRIKE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 130,
						/*accuracy =*/ 85,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BONE_CLUB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 65,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BONE_RUSH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 25,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BONEMERANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 50,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BOOMBURST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 140,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BOUNCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BOUNCE,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 85,
						/*accuracy =*/ 85,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_BRANCH_POKE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BRAVE_BIRD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILTHIRDDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BREAKING_SWIPE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BRICK_BREAK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PSYCHICFANGS,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BRINE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BRINE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BRUTAL_SWING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BUBBLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BUBBLE_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BUG_BITE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BUGBITE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BUG_BUZZ {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_BULK_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BULKUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BULLDOZE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_GROUND
					);
				}
			}
			public static BattleMove MOVE_BULLET_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BULLET_SEED {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 25,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BURN_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNUP,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 130,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_BURNING_JEALOUSY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNINGJEALOUSY,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CALM_MIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CALMMIND,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CAMOUFLAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CAMOUFLAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CAPTIVATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CAPTIVATE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CEASELESS_EDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 65,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CHARGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CHARGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CHARGE_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKUP,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 50,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 70,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CHARM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CHATTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.CANNOT_BE_SKETCHED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_CHILLING_WATER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CHILLY_RECEPTION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CHILLYRECEPTION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_CHIP_AWAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CHIPAWAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHIP_AWAY
					);
				}
			}
			public static BattleMove MOVE_CHLOROBLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECOILHALFMAXHP,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 150,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CIRCLE_THROW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SWITCHTONEXTHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 60,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -6,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CLAMP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.WATER,
						/*power =*/ 35,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CLANGING_SCALES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWN,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_CLANGOROUS_SOUL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CLANGOROUSSOUL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_CLEAR_SMOG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.HAZE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 50,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CLOSE_COMBAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFANDSPDEFDOWN,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COACHING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKANDDEFUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_COIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKDEFACCUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COLLISION_COURSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COLLISIONCOURSE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COMET_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 18,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COMEUPPANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COMEUPPANCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CONFIDE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_CONFUSE_RAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CONFUSION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CONSTRICT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 10,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CONVERSION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CONVERSION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CONVERSION_2 {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CONVERSION2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_COPYCAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COPYCAT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK
					);
				}
			}
			public static BattleMove MOVE_CORE_ENFORCER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.COREENFORCER,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CORROSIVE_GAS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CORROSIVEGAS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COSMIC_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COSMICPOWER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COTTON_GUARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP3,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			// TODO: Grass-type Pokémon, Pokémon with Overcoat, and Pokémon holding the Safety Goggles are now immune to Cotton Spore.
			public static BattleMove MOVE_COTTON_SPORE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPEEDDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COUNTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COUNTER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ -5,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.IGNORE_TYPE_EFF
					);
				}
			}
			public static BattleMove MOVE_COURT_CHANGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COURTCHANGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_COVET {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.THIEF,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CRABHAMMER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 100,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED |Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CRAFTY_SHIELD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PROTECT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 3,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_CROSS_CHOP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 100,
						/*accuracy =*/ 80,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CROSS_POISON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_CRUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BITE_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CRUSH_CLAW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 75,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CRUSH_GRIP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CRUSHGRIP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_CURSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CURSE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_CUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 50,
						/*accuracy =*/ 95,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_DARK_PULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PULSE_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DARK_VOID {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 50,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DARKEST_LARIAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CHIPAWAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHIP_AWAY
					);
				}
			}
			public static BattleMove MOVE_DAZZLING_GLEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DECORATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKANDSPATKUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_DEFEND_ORDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFANDSPDEFUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DEFENSE_CURL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSECURL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DEFOG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFOG,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_DESTINY_BOND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DESTINYBOND,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_DETECT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PROTECT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_DIAMOND_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEUP2,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 100,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DIG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DIG,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.USABLE_OUT_OF_BATTLE | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_DIRE_CLAW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DIRECLAW,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DISABLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DISABLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DISARMING_VOICE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 40,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_DISCHARGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DIVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DIVE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.USABLE_OUT_OF_BATTLE | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_DIZZY_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOODLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOODLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED_OPPONENT,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			// TODO: Damage dealt snapshots stats and has no type, cannot crit
			public static BattleMove MOVE_DOOM_DESIRE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FUTURESIGHT,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 140,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_HIT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 35,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_IRON_BASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 30,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_SHOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DOUBLESHOCK,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_SLAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 15,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_TEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EVASIONUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DOUBLE_EDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILTHIRDDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRACO_METEOR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWN2,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 130,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_ASCENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFANDSPDEFDOWN,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_BREATH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_CLAW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DRAGONDANCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			// TODO: If targeting an opponent when there are multiple opponents, Dragon Darts' first strike targets the original target and its second strike targets the other opponent. If either the original target or its ally would take no damage from Dragon Darts, both strikes are directed at the other Pokémon instead. If Dragon Darts targets an ally, both hits will hit that ally. Wide Guard does not affect Dragon Darts.
			public static BattleMove MOVE_DRAGON_DARTS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_ENERGY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ERUPTION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_HAMMER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_PULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PULSE_MOVE | Flag.MEGA_LAUNCHER_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_RAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DRAGONRAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_RUSH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 100,
						/*accuracy =*/ 75,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAGON_TAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SWITCHTONEXTHIT,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 60,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -6,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAIN_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.LIQUID_OOZE_AFFECTED | Flag.BIG_ROOT_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRAINING_KISS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB75PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.LIQUID_OOZE_AFFECTED | Flag.BIG_ROOT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DREAM_EATER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DREAMEATER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.BIG_ROOT_AFFECTED | Flag.LIQUID_OOZE_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRILL_PECK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED_OPPONENT,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRILL_RUN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 80,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DRUM_BEATING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DUAL_CHOP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 40,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DUAL_WINGBEAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 40,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DYNAMAX_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_DYNAMIC_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 100,
						/*accuracy =*/ 50,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EARTH_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EARTHQUAKE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EARTHQUAKE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_GROUND
					);
				}
			}
			public static BattleMove MOVE_ECHOED_VOICE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ECHOEDVOICE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_EERIE_IMPULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EERIE_SPELL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.EERIESPELL,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_EGG_BOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 100,
						/*accuracy =*/ 75,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ELECTRIC_TERRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ELECTRICTERRAIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ELECTRIFY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ELECTRIFY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ELECTRO_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ELECTROBALL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ELECTRO_DRIFT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.COLLISIONCOURSE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ELECTROWEB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 55,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EMBARGO {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EMBARGO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EMBER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ENCORE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ENCORE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ENDEAVOR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ENDEAVOR,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ENDURE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ENDURE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ENERGY_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ENTRAINMENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOODLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ERUPTION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ERUPTION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ESPER_WING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDUP,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_ETERNABEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 160,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EXPANDING_FORCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EXPANDINGFORCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EXPLOSION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EXPLOSION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 250,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EXTRASENSORY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_EXTREME_SPEED {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 2,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FACADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FACADE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FAIRY_LOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FAIRYLOCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FAIRY_WIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FAKE_OUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FAKEOUT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 3,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FAKE_TEARS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FALSE_SURRENDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 80,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FALSE_SWIPE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FALSESWIPE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FEATHER_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FEINT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FEINT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 30,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 2,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			// TODO: Will not trigger effects involving contact
			public static BattleMove MOVE_FEINT_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FELL_STINGER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FELLSTINGER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIERY_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKUP,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIERY_WRATH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FILLET_AWAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FILLETAWAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FINAL_GAMBIT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FINALGAMBIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRE_BLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 110,
						/*accuracy =*/ 85,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRE_FANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BITE,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 65,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BITE_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRE_LASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRE_PLEDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FIREPLEDGE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRE_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PUNCH_MOVE | Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRE_SPIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FIRESPIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 35,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FIRST_IMPRESSION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FAKEOUT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 2,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FISHIOUS_REND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FISHIOUSREND,
						/*moveType =*/ Type.WATER,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BITE_MOVE | Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FISSURE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OHKO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 30,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.HITS_SEMI_INVUL_GROUND
					);
				}
			}
			public static BattleMove MOVE_FLAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLAIL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLAME_BURST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLAMEBURST,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLAME_CHARGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDUP,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLAME_WHEEL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.THAWS_USER
					);
				}
			}
			public static BattleMove MOVE_FLAMETHROWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLARE_BLITZ {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILTHIRDDEALT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.THAWS_USER
					);
				}
			}
			public static BattleMove MOVE_FLASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_FLASH_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLATTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLATTER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLEUR_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWN2,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 130,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLING,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLIP_TURN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.UTURN,
						/*moveType =*/ Type.WATER,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLORAL_HEALING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLORALHEALING,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_FLOWER_SHIELD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLOWERSHIELD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_FLOWER_TRICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 70,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FLY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 90,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED_OPPONENT,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.USABLE_OUT_OF_BATTLE | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_FLYING_PRESS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 100,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FOCUS_BLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 120,
						/*accuracy =*/ 70,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FOCUS_ENERGY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FOCUSENERGY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FOCUS_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FOCUSPUNCH,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -3,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FOLLOW_ME {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FOLLOWME,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 2,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_FORCE_PALM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FORESIGHT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FORESIGHT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_FOREST_S_CURSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FORESTSCURSE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FOUL_PLAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FOULPLAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 95,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FREEZE_SHOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FREEZESHOCK,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 140,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_FREEZE_DRY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FREEZING_GLARE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FRENZY_PLANT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FROST_BREATH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 60,
						/*accuracy =*/ 90,
						/*pp =*/ 0,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.ALWAYS_CRITICAL | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FRUSTRATION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FRUSTRATION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FURY_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 15,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FURY_CUTTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FURYCUTTER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 40,
						/*accuracy =*/ 95,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SHARPNESS_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FURY_SWIPES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 18,
						/*accuracy =*/ 80,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FUSION_BOLT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FUSIONBOLT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FUSION_FLARE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FUSIONFLARE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_FUTURE_SIGHT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FUTURESIGHT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_GASTRO_ACID {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GASTROACID,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GEAR_GRIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 50,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GEAR_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GEARUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GEOMANCY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GEOMANCY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_GIGA_DRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.LIQUID_OOZE_AFFECTED | Flag.BIG_ROOT_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GIGA_IMPACT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GIGATON_HAMMER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 160,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CANNOT_USE_MOVE_TWICE
					);
				}
			}
			public static BattleMove MOVE_GLACIAL_LANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GLACIATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 65,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GLAIVE_RUSH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.GLAIVERUSH,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GLARE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GRASS_KNOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GRASSKNOT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GRASS_PLEDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.GRASSPLEDGE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GRASS_WHISTLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 55,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_GRASSY_TERRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GRASSYTERRAIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_GRAV_APPLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GRAVAPPLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GRAVITY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GRAVITY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_GROWL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_GROWTH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GROWTH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GRUDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GRUDGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_GUARD_SPLIT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GUARDSPLIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_GUARD_SWAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GUARDSWAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_GUILLOTINE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OHKO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 30,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GUNK_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 120,
						/*accuracy =*/ 80,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_GUST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GUST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_AIR
					);
				}
			}
			public static BattleMove MOVE_GYRO_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GYROBALL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BULLETPROOF_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HAIL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_HAMMER_ARM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWN,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 100,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HAPPY_HOUR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HAPPYHOUR,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_HARDEN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HAZE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HAZE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_HEAD_CHARGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILQUARTERDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEAD_SMASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILHALFDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 150,
						/*accuracy =*/ 80,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEADBUTT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEADLONG_RUSH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFANDSPDEFDOWN,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEAL_BELL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CURENONVOLATILESTATUSHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD_AND_PARTY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_HEAL_BLOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALBLOCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEAL_ORDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALHALF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEAL_PULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALHALFHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PULSE_MOVE | Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEALING_WISH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALINGWISH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEART_STAMP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEART_SWAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEARTSWAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_HEAT_CRASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEAVYSLAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEAT_WAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 95,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HEAVY_SLAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEAVYSLAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HELPING_HAND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HELPINGHAND,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.HITS_SEMI_INVUL_GROUND | Flag.HITS_SEMI_INVUL_WATER | Flag.HITS_SEMI_INVUL_AIR
					);
				}
			}
			public static BattleMove MOVE_HEX {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEX,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HIDDEN_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIDDENPOWER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HIGH_HORSEPOWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 95,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HIGH_JUMP_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.JUMPKICK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 130,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.GRAVITY_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HOLD_BACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FALSESWIPE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HONE_CLAWS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKDEFACCUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HORN_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HORN_DRILL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OHKO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 30,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HORN_LEECH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.LIQUID_OOZE_AFFECTED | Flag.BIG_ROOT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HOWL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_HURRICANE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GUST,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 110,
						/*accuracy =*/ 70,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_AIR | Flag.ALWAYS_HIT_RAIN
					);
				}
			}
			public static BattleMove MOVE_HYDRO_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYDRO_PUMP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 110,
						/*accuracy =*/ 80,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYDRO_STEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HYDROSTEAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYPER_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYPER_DRILL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYPER_FANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.BITE_MOVE
					);
				}
			}
			public static BattleMove MOVE_HYPER_VOICE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYPERSPACE_FURY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HYPERSPACEFURY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 100,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_HYPERSPACE_HOLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_HYPNOSIS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 60,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ROLLOUT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 30,
						/*accuracy =*/ 90,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_BURN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ICEBURN,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 140,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_ICE_FANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BITE,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 65,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.BITE_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_HAMMER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWN2,
						/*moveType =*/ Type.ICE,
						/*power =*/ 100,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_SHARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICE_SPINNER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CLEARTERRAIN,
						/*moveType =*/ Type.ICE,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICICLE_CRASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 85,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICICLE_SPEAR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 25,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ICY_WIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 55,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_IMPRISON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.IMPRISON,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_INCINERATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.INCINERATE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_INFERNAL_PARADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.INFERNALPARADE,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_INFERNO {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 100,
						/*accuracy =*/ 50,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_INFESTATION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.INFESTATION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_INGRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.INGRAIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_INSTRUCT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.INSTRUCT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ION_DELUGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.IONDELUGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_IRON_DEFENSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_IRON_HEAD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_IRON_TAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 100,
						/*accuracy =*/ 75,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_JAW_LOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.TRAP,
						/*moveType =*/ Type.DARK,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_JET_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_JUDGMENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.JUDGMENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_JUMP_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.JUMPKICK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 100,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.GRAVITY_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_JUNGLE_HEALING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.JUNGLEHEALING,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_KARATE_CHOP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_KINESIS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 80,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_KING_S_SHIELD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.KINGSSHIELD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_KNOCK_OFF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.KNOCKOFF,
						/*moveType =*/ Type.DARK,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_KOWTOW_CLEAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 85,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LAND_S_WRATH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LASER_FOCUS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LASERFOCUS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LASH_OUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.LASHOUT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LAST_RESORT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LASTRESORT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 140,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LAST_RESPECTS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LASTRESPECTS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LAVA_PLUME {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEAF_BLADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEAF_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWN2,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 130,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEAF_TORNADO {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 65,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEAFAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEECH_LIFE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BIG_ROOT_AFFECTED | Flag.LIQUID_OOZE_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEECH_SEED {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LEECHSEED,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LEER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 30,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LIFE_DEW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALQUARTER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LIGHT_OF_RUIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILHALFDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 140,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LIGHT_SCREEN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LIGHTSCREEN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LIQUIDATION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LOCK_ON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LOCKON,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LOVELY_KISS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 75,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LOW_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LOWKICK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LOW_SWEEP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LUCKY_CHANT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LUCKYCHANT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LUMINA_CRASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT2,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LUNAR_BLESSING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LUNARBLESSING,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LUNAR_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LUNARDANCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LUNGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_LUSTER_PURGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MACH_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGIC_COAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MAGICCOAT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_MAGIC_POWDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MAGICPOWDER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGIC_ROOM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MAGICROOM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGICAL_LEAF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGMA_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 100,
						/*accuracy =*/ 75,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGNET_BOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGNET_RISE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MAGNETRISE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGNETIC_FLUX {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFANDSPDEFUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAGNITUDE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MAGNITUDE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_GROUND
					);
				}
			}
			public static BattleMove MOVE_MAKE_IT_RAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.MAKEITRAIN,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MAT_BLOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MATBLOCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ME_FIRST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MEFIRST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEAN_LOOK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MEANLOOK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEDITATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEGA_DRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.BIG_ROOT_AFFECTED | Flag.LIQUID_OOZE_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEGA_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 120,
						/*accuracy =*/ 70,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEGA_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEGAHORN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 120,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MEMENTO {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MEMENTO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_METAL_BURST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.METALBURST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_METAL_CLAW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKUP,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 50,
						/*accuracy =*/ 95,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_METAL_SOUND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 85,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_METEOR_ASSAULT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_METEOR_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.METEORBEAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 120,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_METEOR_MASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKUP,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 90,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_METRONOME {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.METRONOME,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK
					);
				}
			}
			public static BattleMove MOVE_MILK_DRINK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALHALF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED | Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_MIMIC {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MIRRORMOVE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_MIND_BLOWN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MINDBLOWN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MIND_READER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LOCKON,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MINIMIZE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MINIMIZE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MIRACLE_EYE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MIRACLEEYE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MIRROR_COAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MIRRORCOAT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ -5,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MIRROR_MOVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MIRRORMOVE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.CANNOT_BE_SKETCHED | Flag.UNUSABLE_BY_SLEEP_TALK
					);
				}
			}
			public static BattleMove MOVE_MIRROR_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 65,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MIST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MIST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MIST_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MISTY_EXPLOSION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MISTYEXPLOSION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MISTY_TERRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MISTYTERRAIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_MOONBLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 95,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MOONGEIST_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.MOONGEISTBEAM,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MOONLIGHT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SYNTHESIS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MORNING_SUN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SYNTHESIS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MORTAL_SPIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RAPIDSPIN,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 30,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MOUNTAIN_GALE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 100,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MUD_BOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 65,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MUD_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 55,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MUD_SPORT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MUDSPORT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_MUD_SLAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MUDDY_WATER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 90,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MULTI_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.MULTIATTACK,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MYSTICAL_FIRE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKUP,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_MYSTICAL_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MYSTICALPOWER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 70,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NASTY_PLOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALATTACKUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NATURAL_GIFT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.NATURALGIFT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NATURE_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.NATUREPOWER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_NATURE_S_MADNESS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.NATURESMADNESS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NEEDLE_ARM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NIGHT_DAZE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 85,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 40,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NIGHT_SHADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LEVELDAMAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NIGHT_SLASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NIGHTMARE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.NIGHTMARE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NO_RETREAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.NORETREAT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_NOBLE_ROAR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKANDSPATKDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_NUZZLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OBLIVION_WING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB75PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OBSTRUCT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OBSTRUCT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_OCTAZOOKA {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 65,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OCTOLOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OCTOLOCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ODOR_SLEUTH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ODORSLEUTH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OMINOUS_WIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ALLSTATSUP,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ORDER_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ORDERUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ORIGIN_PULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 110,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MEGA_LAUNCHER_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OUTRAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OUTRAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OVERDRIVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_OVERHEAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWN2,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 130,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PAIN_SPLIT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PAINSPLIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT | Flag.IGNORE_TYPE_EFF
					);
				}
			}
			public static BattleMove MOVE_PARABOLIC_CHARGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ABSORB50PERCENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.LIQUID_OOZE_AFFECTED | Flag.BIG_ROOT_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PARTING_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PARTINGSHOT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PAY_DAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PAYDAY,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PAYBACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PAYBACK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PECK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 35,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PERISH_SONG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PERISHSONG,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_PETAL_BLIZZARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PETAL_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OUTRAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PHANTOM_FORCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PHANTOMFORCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_PHOTON_GEYSER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PHOTONGEYSER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PIN_MISSILE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 25,
						/*accuracy =*/ 95,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PLASMA_FISTS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PLASMAFISTS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PLAY_NICE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_PLAY_ROUGH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 90,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PLUCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PLUCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POISON_FANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.TOXIC,
						/*moveType =*/ Type.POISON,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BITE_MOVE | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POISON_GAS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POISONHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POISON_JAB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POISON_POWDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POISONHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 75,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POISON_STING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 15,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POISON_TAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POLLEN_PUFF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POLLENPUFF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POLTERGEIST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POLTERGEIST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 110,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POPULATION_BOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POPULATIONBOMB,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 20,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POUNCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POUND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POWDER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWDER_SNOW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FREEZEHIT,
						/*moveType =*/ Type.ICE,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_GEM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_SHIFT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POWERSHIFT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_SPLIT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POWERSPLIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_POWER_SWAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POWERSWAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_TRICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POWERTRICK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_TRIP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PUNISHMENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_WHIP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 120,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_POWER_UP_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKUP,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PRECIPICE_BLADES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 120,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PRESENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PRESENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PRISMATIC_LASER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 160,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PROTECT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PROTECT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_PSYBEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYBLADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYBLADE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYCH_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYCHUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_PSYCHIC {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYCHIC_FANGS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYCHICFANGS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BITE_MOVE
					);
				}
			}
			public static BattleMove MOVE_PSYCHIC_TERRAIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYCHICTERRAIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_PSYCHO_BOOST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWN2,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 140,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYCHO_CUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYCHO_SHIFT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYCHOSHIFT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYSHIELD_BASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEUP,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 70,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYSHOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYSHOCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYSTRIKE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PSYSHOCK,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PSYWAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PSYWAVE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PUNISHMENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PUNISHMENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PURIFY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PURIFY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PURSUIT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PURSUIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_PYRO_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 120,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.BULLETPROOF_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.THAWS_USER
					);
				}
			}
			public static BattleMove MOVE_QUASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.QUASH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_QUICK_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_QUICK_GUARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.QUICKGUARD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 3,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_QUIVER_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPATKSPDEFSPDUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAGE_FIST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RAGEFIST,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAGE_POWDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FOLLOWME,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 2,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_RAGING_BULL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PSYCHICFANGS,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAGING_FURY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OUTRAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAIN_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RAINDANCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_RAPID_SPIN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RAPIDSPIN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAZOR_LEAF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 55,
						/*accuracy =*/ 95,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.HIGH_CRITICAL | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAZOR_SHELL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 75,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RAZOR_WIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RAZORWIND,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HIGH_CRITICAL | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_RECOVER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALHALF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RECYCLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECYCLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REFLECT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REFLECT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REFLECT_TYPE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REFLECTTYPE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REFRESH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REFRESH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RELIC_SONG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RETALIATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RETALIATE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RETURN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RETURN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REVELATION_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REVELATIONDANCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REVENGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REVENGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -4,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REVERSAL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FLAIL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_REVIVAL_BLESSING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.REVIVALBLESSING,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 1,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_RISING_VOLTAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RISINGVOLTAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROAR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROAR,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -6,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_ROAR_OF_TIME {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_BLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 25,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_CLIMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 90,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_POLISH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPEEDUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_SLIDE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 75,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_SMASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_THROW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 50,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_TOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 60,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROCK_WRECKER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECHARGE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 150,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROLE_PLAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROLEPLAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ROLLING_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 60,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROLLOUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROLLOUT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 30,
						/*accuracy =*/ 90,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			// If a Flying-type Pokémon successfully uses Roost, 
			// until the end of the turn, its Flying type is ignored 
			// when it is hit by attacks. 
			// If the Pokémon has another type, only that 
			// type is considered; if the Pokémon is a pure 
			// Flying type, all attacks will be normally effective 
			// against it.
			public static BattleMove MOVE_ROOST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROOST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ROTOTILLER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROTOTILLER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_ROUND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROUND,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_RUINATION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SUPERFANG,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SACRED_FIRE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKANDTHAWHIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 100,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 50,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SACRED_SWORD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CHIPAWAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHIP_AWAY | Flag.SHARPNESS_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SAFEGUARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SAFEGUARD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SALT_CURE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SALTCURE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SAND_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SAND_TOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 35,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SANDSEAR_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 100,
						/*accuracy =*/ 80,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.ALWAYS_HIT_RAIN
					);
				}
			}
			public static BattleMove MOVE_SANDSTORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SANDSTORM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_SCALD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKANDTHAWHIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SCALE_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SCALESHOT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 25,
						/*accuracy =*/ 90,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SCARY_FACE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPEEDDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SCORCHING_SANDS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SCORCHINGSANDS,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.THAWS_USER
					);
				}
			}
			public static BattleMove MOVE_SCRATCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SCREECH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 85,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_SEARING_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SECRET_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SECRETPOWER,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SECRET_SWORD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SECRETSWORD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SEED_BOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SEED_FLARE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT2,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 120,
						/*accuracy =*/ 85,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 40,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SEISMIC_TOSS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.LEVELDAMAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SELF_DESTRUCT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EXPLOSION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 200,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHADOW_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALDEFENSEDOWNHIT,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHADOW_BONE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 85,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHADOW_CLAW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHADOW_FORCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SHADOWFORCE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_SHADOW_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHADOW_SNEAK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHARPEN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHED_TAIL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SUBSTITUTE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_SHEER_COLD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OHKO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 30,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHELL_SIDE_ARM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SHELLSIDEARM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHELL_SMASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SHELLSMASH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHELL_TRAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SHELLTRAP,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ -3,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHELTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHIFT_GEAR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SHIFTGEAR,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHOCK_WAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SHORE_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SHOREUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SIGNAL_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SILK_TRAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SILKTRAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_SILVER_WIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ALLSTATSUP,
						/*moveType =*/ Type.BUG,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SIMPLE_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SIMPLEBEAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 55,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_SKETCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SKETCH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 1,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.CANNOT_BE_SKETCHED | Flag.UNUSABLE_BY_SLEEP_TALK | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_SKILL_SWAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SKILLSWAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SKITTER_SMACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 70,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SKULL_BASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SKULLBASH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 130,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_SKY_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SKYATTACK,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 140,
						/*accuracy =*/ 90,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.CHARGING_TURN | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_SKY_DROP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SKYDROP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SEMI_INVUL_TURN
					);
				}
			}
			public static BattleMove MOVE_SKY_UPPERCUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GUST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 85,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_AIR
					);
				}
			}
			public static BattleMove MOVE_SLACK_OFF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALHALF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SLAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 75,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SLASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SLEEP_POWDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 75,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SLEEP_TALK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPTALK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.CANNOT_BE_SKETCHED | Flag.USABLE_WHILE_ASLEEP | Flag.UNUSABLE_BY_SLEEP_TALK
					);
				}
			}
			public static BattleMove MOVE_SLUDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SLUDGE_BOMB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.BULLETPROOF_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SLUDGE_WAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 95,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SMACK_DOWN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SMACKDOWN,
						/*secondaryEffect =*/ MoveEffectID.GROUNDHIT,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_AIR
					);
				}
			}
			public static BattleMove MOVE_SMART_STRIKE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 70,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SMELLING_SALTS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SMELLINGSALTS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SMOG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 30,
						/*accuracy =*/ 70,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 40,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SMOKESCREEN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ACCURACYDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SNAP_TRAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 35,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SNARL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*moveType =*/ Type.DARK,
						/*power =*/ 55,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SNATCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SNATCH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 40,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_SNIPE_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SNIPESHOT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_SNORE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SNORE,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.SOUND_MOVE | Flag.USABLE_WHILE_ASLEEP
					);
				}
			}
			public static BattleMove MOVE_SNOWSCAPE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SNOWSCAPE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_SOAK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SOAK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SOFT_BOILED {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HEALHALF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED | Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_SOLAR_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SOLARBEAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_SOLAR_BLADE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SOLARBEAM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 125,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.CHARGING_TURN
					);
				}
			}
			public static BattleMove MOVE_SONIC_BOOM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SONICBOOM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPACIAL_REND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 100,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.HIGH_CRITICAL2 | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPARK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPARKLING_ARIA {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CUREBURNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPECTRAL_THIEF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECTRALTHIEF,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPEED_SWAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPEEDSWAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_SPICY_EXTRACT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPICYEXTRACT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_SPIDER_WEB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPIDERWEB,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPIKE_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPIKES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPIKES,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL_OPPONENTS,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPIKY_SHIELD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPIKYSHIELD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 4,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECTS
					);
				}
			}
			public static BattleMove MOVE_SPIN_OUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWN2,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPIRIT_BREAK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPIRIT_SHACKLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.TRAP,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPIT_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPITUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPITE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPITE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPLASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPLASH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_SPORE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SLEEPHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPOTLIGHT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.FOLLOWME,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 3,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SPRINGTIDE_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 100,
						/*accuracy =*/ 80,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STEALTH_ROCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STEALTHROCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL_OPPONENTS,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STEAM_ERUPTION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STEAMERUPTION,
						/*secondaryEffect =*/ MoveEffectID.BURNHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 110,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.THAWS_USER
					);
				}
			}
			public static BattleMove MOVE_STEAMROLLER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.DOUBLE_DAMAGE_MINIMIZE
					);
				}
			}
			public static BattleMove MOVE_STEEL_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.RECOILHALFMAXHP,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 140,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STEEL_ROLLER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CLEARTERRAIN,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 130,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STEEL_WING {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEUP,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 70,
						/*accuracy =*/ 90,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STICKY_WEB {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STICKYWEB,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL_OPPONENTS,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STOCKPILE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STOCKPILE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STOMP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STOMPING_TANTRUM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.STOMPINGTANTRUM,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STONE_AXE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.STEALTHROCK,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 65,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STONE_EDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 100,
						/*accuracy =*/ 80,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.HIGH_CRITICAL | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STORED_POWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STOREDPOWER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 20,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STORM_THROW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.ALWAYS_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STRANGE_STEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 90,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STRENGTH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STRENGTH_SAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STRENGTHSAP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STRING_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPEEDDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 95,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STRUGGLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STRUGGLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NONE,
						/*power =*/ 50,
						/*accuracy =*/ 0,
						/*pp =*/ 255,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_RANDOM,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.CANNOT_BE_SKETCHED | Flag.UNUSABLE_BY_SLEEP_TALK | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STRUGGLE_BUG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKDOWNHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STUFF_CHEEKS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.STUFFCHEEKS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_STUN_SPORE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 75,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUBMISSION {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILQUARTERDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 80,
						/*accuracy =*/ 80,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUBSTITUTE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SUBSTITUTE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUCKER_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SUCKERPUNCH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUNNY_DAY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SUNNYDAY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_SUNSTEEL_STRIKE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SUNSTEELSTRIKE,
						/*moveType =*/ Type.STEEL,
						/*power =*/ 100,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUPER_FANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SUPERFANG,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUPERPOWER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATKDEFDOWN,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SUPERSONIC {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 55,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SOUND_MOVE | Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SURF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SURF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_WATER
					);
				}
			}
			public static BattleMove MOVE_SURGING_STRIKES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SURGINGSTRIKES,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 25,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.ALWAYS_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_SWAGGER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SWAGGER,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SWALLOW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SWALLOW,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SWEET_KISS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FAIRY,
						/*power =*/ 0,
						/*accuracy =*/ 75,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SWEET_SCENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.EVASIONDOWNHIT2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_SWIFT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 60,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SWITCHEROO {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SWITCHEROO,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SWORDS_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATTACKUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SYNCHRONOISE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SYNCHRONOISE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_SYNTHESIS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SYNTHESIS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TACKLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAIL_GLOW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SPECIALATTACKUP2,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAIL_SLAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 25,
						/*accuracy =*/ 85,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAIL_WHIP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAILWIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TAILWIND,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAKE_DOWN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILQUARTERDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 90,
						/*accuracy =*/ 85,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAKE_HEART {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TAKEHEART,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAR_SHOT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TARSHOT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TAUNT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TAUNT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TEARFUL_LOOK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TEARFULLOOK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_TEATIME {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TEATIME,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_TECHNO_BLAST {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TECHNOBLAST,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TEETER_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_FOES_AND_ALLY,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TELEKINESIS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TELEKINESIS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TELEPORT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TELEPORT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.USABLE_OUT_OF_BATTLE
					);
				}
			}
			public static BattleMove MOVE_TERRAIN_PULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TERRAINPULSE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.MEGA_LAUNCHER_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THIEF {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.THIEF,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THOUSAND_ARROWS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.THOUSANDARROWS,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_AIR | Flag.HITS_UNGROUNDED | Flag.IGNORE_TYPE_EFF
					);
				}
			}
			public static BattleMove MOVE_THOUSAND_WAVES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.THOUSANDWAVES,
						/*moveType =*/ Type.GROUND,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THRASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.OUTRAGE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THROAT_CHOP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.THROATCHOP,
						/*moveType =*/ Type.DARK,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THUNDER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 110,
						/*accuracy =*/ 70,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.HITS_SEMI_INVUL_AIR | Flag.ALWAYS_HIT_RAIN | Flag.ACC_LOSS_IN_SUNLIGHT
					);
				}
			}
			public static BattleMove MOVE_THUNDER_CAGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 80,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THUNDER_FANG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BITE,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 65,
						/*accuracy =*/ 95,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.BITE_MOVE
					);
				}
			}
			public static BattleMove MOVE_THUNDER_PUNCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 75,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THUNDER_SHOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THUNDER_WAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THUNDERBOLT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_THUNDEROUS_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.DEFENSEDOWNHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TICKLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TICKLE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TIDY_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TIDYUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_TOPSY_TURVY {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TOPSYTURVY,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_TORCH_SONG {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPECIALATTACKUP,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_TORMENT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TORMENT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TOXIC {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TOXICHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TOXIC_SPIKES {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TOXICSPIKES,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL_OPPONENTS,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TOXIC_THREAD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.POISONHIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDDOWNHIT,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRAILBLAZE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.SPEEDUP,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRANSFORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRANSFORM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.IGNORE_TYPE_EFF
					);
				}
			}
			public static BattleMove MOVE_TRI_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.TRIATTACK,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRICK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRICK_ROOM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRICKROOM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 7,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRICK_OR_TREAT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRICKORTREAT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GHOST,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRIPLE_ARROWS {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.TRIPLEARROWS,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HIGH_CRITICAL
					);
				}
			}
			public static BattleMove MOVE_TRIPLE_AXEL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRIPLEAXEL,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ICE,
						/*power =*/ 20,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRIPLE_DIVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRIPLEDIVE,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 30,
						/*accuracy =*/ 95,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRIPLE_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRIPLEKICK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 10,
						/*accuracy =*/ 90,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TROP_KICK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.ATTACKDOWNHIT,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TRUMP_CARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.TRUMPCARD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_TWIN_BEAM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TWINEEDLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DOUBLEHIT,
						/*secondaryEffect =*/ MoveEffectID.POISONHIT,
						/*moveType =*/ Type.BUG,
						/*power =*/ 25,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_TWISTER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.GUST,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.DRAGON,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.HITS_SEMI_INVUL_AIR
					);
				}
			}
			public static BattleMove MOVE_U_TURN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.UTURN,
						/*moveType =*/ Type.BUG,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_UPROAR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.UPROAR,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.UNUSABLE_BY_SLEEP_TALK | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.SOUND_MOVE
					);
				}
			}
			public static BattleMove MOVE_V_CREATE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.VCREATE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 180,
						/*accuracy =*/ 95,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VACUUM_WAVE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VENOM_DRENCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.VENOMDRENCH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VENOSHOCK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.VENOSHOCK,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.POISON,
						/*power =*/ 65,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VICTORY_DANCE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKDEFSPDUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VINE_WHIP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 45,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VISE_GRIP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 55,
						/*accuracy =*/ 100,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VITAL_THROW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 70,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -1,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.ALWAYS_HIT | Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VOLT_SWITCH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.UTURN,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_VOLT_TACKLE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILTHIRDDEALT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 10,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WAKE_UP_SLAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WAKEUPSLAP,
						/*secondaryEffect =*/ MoveEffectID.WAKEUPHIT,
						/*moveType =*/ Type.FIGHTING,
						/*power =*/ 70,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WATER_GUN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 40,
						/*accuracy =*/ 100,
						/*pp =*/ 25,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WATER_PLEDGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.WATERPLEDGE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WATER_PULSE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.CONFUSEHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WATER_SHURIKEN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.MULTIHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 15,
						/*accuracy =*/ 100,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 1,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WATER_SPORT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WATERSPORT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ 0
					);
				}
			}
			public static BattleMove MOVE_WATER_SPOUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ERUPTION,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 150,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WATERFALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.WATER,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WAVE_CRASH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILTHIRDDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WEATHER_BALL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.WEATHERBALL,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 50,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WHIRLPOOL {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.SURF,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.WATER,
						/*power =*/ 35,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.HITS_SEMI_INVUL_WATER
					);
				}
			}
			public static BattleMove MOVE_WHIRLWIND {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ROAR,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ -6,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.HITS_SEMI_INVUL_AIR | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_WICKED_BLOW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.DARK,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.ALWAYS_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WIDE_GUARD {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WIDEGUARD,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ROCK,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER_FIELD,
						/*priority =*/ 3,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WILD_CHARGE {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILQUARTERDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 90,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WILDBOLT_STORM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 100,
						/*accuracy =*/ 80,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_OPPONENTS_FIELD,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED | Flag.ALWAYS_HIT_RAIN
					);
				}
			}
			public static BattleMove MOVE_WILL_O_WISP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.BURNHIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FIRE,
						/*power =*/ 0,
						/*accuracy =*/ 85,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WING_ATTACK {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.FLYING,
						/*power =*/ 60,
						/*accuracy =*/ 100,
						/*pp =*/ 35,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ANY_NOT_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WISH {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WISH,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WITHDRAW {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.DEFENSEUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.WATER,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 40,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WONDER_ROOM {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WONDERROOM,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_ALL,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WOOD_HAMMER {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.RECOILTHIRDDEALT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 120,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WORK_UP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.ATKANDSPATKUP,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 30,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_USER,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.SNATCH_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WORRY_SEED {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WORRYSEED,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.GRASS,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WRAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.BIND,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 15,
						/*accuracy =*/ 90,
						/*pp =*/ 20,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_WRING_OUT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.WRINGOUT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 100,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_X_SCISSOR {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.BUG,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.SHARPNESS_AFFECTED | Flag.HIGH_CRITICAL | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.KINGS_ROCK_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_YAWN {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.YAWN,
						/*secondaryEffect =*/ MoveEffectID.NONE,
						/*moveType =*/ Type.NORMAL,
						/*power =*/ 0,
						/*accuracy =*/ 0,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.STATUS,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MAGIC_COAT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED | Flag.ALWAYS_HIT
					);
				}
			}
			public static BattleMove MOVE_ZAP_CANNON {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.PARALYZEHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 120,
						/*accuracy =*/ 50,
						/*pp =*/ 5,
						/*secondaryEffectChance =*/ 100,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.SPECIAL,
						/*flags =*/ Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ZEN_HEADBUTT {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.PSYCHIC,
						/*power =*/ 80,
						/*accuracy =*/ 90,
						/*pp =*/ 15,
						/*secondaryEffectChance =*/ 20,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}
			public static BattleMove MOVE_ZING_ZAP {
				get {
					return new BattleMove(
						/*primaryEffect =*/ MoveEffectID.HIT,
						/*secondaryEffect =*/ MoveEffectID.FLINCHHIT,
						/*moveType =*/ Type.ELECTRIC,
						/*power =*/ 80,
						/*accuracy =*/ 100,
						/*pp =*/ 10,
						/*secondaryEffectChance =*/ 30,
						/*target =*/ MOVE_TARGET_SELECTED,
						/*priority =*/ 0,
						/*moveCat =*/ MoveCategory.PHYSICAL,
						/*flags =*/ Flag.MAKES_CONTACT | Flag.PROTECT_AFFECTED | Flag.MIRROR_MOVE_AFFECTED
					);
				}
			}

		}
	}

	public enum MoveCategory {
		PHYSICAL,
		SPECIAL,
		STATUS,
		NONE
	};

	public struct MoveEffectParams {
		public MoveEffectParams(Battle battle, BattleState state, BattleMon attacker, BattleMon target, BattleMove move, BattleMoveID moveID, u8 slotAttacker, u8 slotTarget, u8 numTargets, u8 actionIndex, bool isPrimaryEffect, u16 i_flags) {
            this.battle = battle;
            this.state = state;
            this.attacker = attacker;
            this.target = target;
            this.move = move;
            this.moveID = moveID;
            this.slotAttacker = slotAttacker;
            this.slotTarget = slotTarget;
            this.numTargets = numTargets;
            this.actionIndex = actionIndex;
            this.isPrimaryEffect = isPrimaryEffect;
            this.i_flags = i_flags;
        }

		public readonly Battle battle;
		public readonly BattleState state;
		public readonly BattleMon attacker;
		public readonly BattleMon target;
		public readonly BattleMove move;
		public readonly BattleMoveID moveID;
		public readonly u8 slotAttacker;
		public readonly u8 slotTarget;
		public readonly u8 numTargets;
		public readonly u8 actionIndex;
		public bool isPrimaryEffect;
		public u16 i_flags;
	};

	public class BattleMove {
		public BattleMove(MoveEffectID primaryEffect, MoveEffectID secondaryEffect, Type moveType, u8 power, u8 accuracy, u8 pp, u8 secondaryEffectChance, u32 target, sbyte priority, MoveCategory moveCat, BattleMoves.Flag flags)
        {
            this.primaryEffect = primaryEffect;
            this.secondaryEffect = secondaryEffect;
            this.moveType = moveType;
            this.power = power;
            this.accuracy = accuracy;
            this.pp = pp;
            this.secondaryEffectChance = secondaryEffectChance;
            this.target = target;
            this.priority = priority;
            this.moveCat = moveCat;
            this.flags = flags;
        }

		public readonly MoveEffectID primaryEffect;
		public readonly MoveEffectID secondaryEffect;
		public readonly Type moveType;
		public readonly u8 power;
		public readonly u8 accuracy;
		public readonly u8 pp;
		public readonly u8 secondaryEffectChance;
		public readonly u32 target;
		public readonly sbyte priority;
		public readonly MoveCategory moveCat;
		public readonly BattleMoves.Flag flags;
	};

	public enum BattleMoveID {
		NONE,
		//10_000_000_VOLT_THUNDERBOLT,
		ABSORB,
		ACCELEROCK,
		ACID,
		ACID_ARMOR,
		//ACID_DOWNPOUR,
		ACID_SPRAY,
		ACROBATICS,
		ACUPRESSURE,
		AERIAL_ACE,
		AEROBLAST,
		AFTER_YOU,
		AGILITY,
		AIR_CUTTER,
		AIR_SLASH,
		//ALL_OUT_PUMMELING,
		ALLY_SWITCH,
		AMNESIA,
		ANCHOR_SHOT,
		ANCIENT_POWER,
		APPLE_ACID,
		AQUA_CUTTER,
		AQUA_JET,
		AQUA_RING,
		AQUA_STEP,
		AQUA_TAIL,
		ARM_THRUST,
		ARMOR_CANNON,
		AROMATHERAPY,
		AROMATIC_MIST,
		ASSIST,
		ASSURANCE,
		ASTONISH,
		ASTRAL_BARRAGE,
		ATTACK_ORDER,
		ATTRACT,
		AURA_SPHERE,
		AURA_WHEEL,
		AURORA_BEAM,
		AURORA_VEIL,
		AUTOTOMIZE,
		AVALANCHE,
		AXE_KICK,
		BABY_DOLL_EYES,
		//BADDY_BAD,
		BANEFUL_BUNKER,
		BARB_BARRAGE,
		BARRAGE,
		BARRIER,
		BATON_PASS,
		BEAK_BLAST,
		BEAT_UP,
		BEHEMOTH_BASH,
		BEHEMOTH_BLADE,
		BELCH,
		BELLY_DRUM,
		BESTOW,
		BIDE,
		BIND,
		BITE,
		BITTER_BLADE,
		BITTER_MALICE,
		//BLACK_HOLE_ECLIPSE,
		BLAST_BURN,
		BLAZE_KICK,
		//BLAZING_TORQUE,
		BLEAKWIND_STORM,
		BLIZZARD,
		BLOCK,
		//BLOOM_DOOM,
		BLUE_FLARE,
		BODY_PRESS,
		BODY_SLAM,
		BOLT_BEAK,
		BOLT_STRIKE,
		BONE_CLUB,
		BONE_RUSH,
		BONEMERANG,
		BOOMBURST,
		BOUNCE,
		//BOUNCY_BUBBLE,
		BRANCH_POKE,
		BRAVE_BIRD,
		BREAKING_SWIPE,
		//BREAKNECK_BLITZ,
		BRICK_BREAK,
		BRINE,
		BRUTAL_SWING,
		BUBBLE,
		BUBBLE_BEAM,
		BUG_BITE,
		BUG_BUZZ,
		BULK_UP,
		BULLDOZE,
		BULLET_PUNCH,
		BULLET_SEED,
		BURN_UP,
		BURNING_JEALOUSY,
		//BUZZY_BUZZ,
		CALM_MIND,
		CAMOUFLAGE,
		CAPTIVATE,
		//CATASTROPIKA,
		CEASELESS_EDGE,
		//CELEBRATE,
		CHARGE,
		CHARGE_BEAM,
		CHARM,
		CHATTER,
		CHILLING_WATER,
		CHILLY_RECEPTION,
		CHIP_AWAY,
		CHLOROBLAST,
		CIRCLE_THROW,
		CLAMP,
		CLANGING_SCALES,
		CLANGOROUS_SOUL,
		//CLANGOROUS_SOULBLAZE,
		CLEAR_SMOG,
		CLOSE_COMBAT,
		COACHING,
		COIL,
		COLLISION_COURSE,
		//COMBAT_TORQUE,
		COMET_PUNCH,
		COMEUPPANCE,
		CONFIDE,
		CONFUSE_RAY,
		CONFUSION,
		CONSTRICT,
		//CONTINENTAL_CRUSH,
		CONVERSION,
		CONVERSION_2,
		COPYCAT,
		CORE_ENFORCER,
		//CORKSCREW_CRASH,
		CORROSIVE_GAS,
		COSMIC_POWER,
		COTTON_GUARD,
		COTTON_SPORE,
		COUNTER,
		COURT_CHANGE,
		COVET,
		CRABHAMMER,
		CRAFTY_SHIELD,
		CROSS_CHOP,
		CROSS_POISON,
		CRUNCH,
		CRUSH_CLAW,
		CRUSH_GRIP,
		CURSE,
		CUT,
		DARK_PULSE,
		DARK_VOID,
		DARKEST_LARIAT,
		DAZZLING_GLEAM,
		DECORATE,
		DEFEND_ORDER,
		DEFENSE_CURL,
		DEFOG,
		DESTINY_BOND,
		DETECT,
		//DEVASTATING_DRAKE,
		DIAMOND_STORM,
		DIG,
		DIRE_CLAW,
		DISABLE,
		DISARMING_VOICE,
		DISCHARGE,
		DIVE,
		DIZZY_PUNCH,
		DOODLE,
		DOOM_DESIRE,
		DOUBLE_HIT,
		DOUBLE_IRON_BASH,
		DOUBLE_KICK,
		DOUBLE_SHOCK,
		DOUBLE_SLAP,
		DOUBLE_TEAM,
		DOUBLE_EDGE,
		DRACO_METEOR,
		DRAGON_ASCENT,
		DRAGON_BREATH,
		DRAGON_CLAW,
		DRAGON_DANCE,
		DRAGON_DARTS,
		DRAGON_ENERGY,
		DRAGON_HAMMER,
		DRAGON_PULSE,
		DRAGON_RAGE,
		DRAGON_RUSH,
		DRAGON_TAIL,
		DRAIN_PUNCH,
		DRAINING_KISS,
		DREAM_EATER,
		DRILL_PECK,
		DRILL_RUN,
		DRUM_BEATING,
		DUAL_CHOP,
		DUAL_WINGBEAT,
		DYNAMAX_CANNON,
		DYNAMIC_PUNCH,
		EARTH_POWER,
		EARTHQUAKE,
		ECHOED_VOICE,
		EERIE_IMPULSE,
		EERIE_SPELL,
		EGG_BOMB,
		ELECTRIC_TERRAIN,
		ELECTRIFY,
		ELECTRO_BALL,
		ELECTRO_DRIFT,
		ELECTROWEB,
		EMBARGO,
		EMBER,
		ENCORE,
		ENDEAVOR,
		ENDURE,
		ENERGY_BALL,
		ENTRAINMENT,
		ERUPTION,
		ESPER_WING,
		ETERNABEAM,
		EXPANDING_FORCE,
		EXPLOSION,
		EXTRASENSORY,
		//EXTREME_EVOBOOST,
		EXTREME_SPEED,
		FACADE,
		FAIRY_LOCK,
		FAIRY_WIND,
		FAKE_OUT,
		FAKE_TEARS,
		FALSE_SURRENDER,
		FALSE_SWIPE,
		FEATHER_DANCE,
		FEINT,
		FEINT_ATTACK,
		FELL_STINGER,
		FIERY_DANCE,
		FIERY_WRATH,
		FILLET_AWAY,
		FINAL_GAMBIT,
		FIRE_BLAST,
		FIRE_FANG,
		FIRE_LASH,
		FIRE_PLEDGE,
		FIRE_PUNCH,
		FIRE_SPIN,
		FIRST_IMPRESSION,
		FISHIOUS_REND,
		FISSURE,
		FLAIL,
		FLAME_BURST,
		FLAME_CHARGE,
		FLAME_WHEEL,
		FLAMETHROWER,
		FLARE_BLITZ,
		FLASH,
		FLASH_CANNON,
		FLATTER,
		FLEUR_CANNON,
		FLING,
		FLIP_TURN,
		//FLOATY_FALL,
		FLORAL_HEALING,
		FLOWER_SHIELD,
		FLOWER_TRICK,
		FLY,
		FLYING_PRESS,
		FOCUS_BLAST,
		FOCUS_ENERGY,
		FOCUS_PUNCH,
		FOLLOW_ME,
		FORCE_PALM,
		FORESIGHT,
		FOREST_S_CURSE,
		FOUL_PLAY,
		FREEZE_SHOCK,
		FREEZE_DRY,
		FREEZING_GLARE,
		//FREEZY_FROST,
		FRENZY_PLANT,
		FROST_BREATH,
		FRUSTRATION,
		FURY_ATTACK,
		FURY_CUTTER,
		FURY_SWIPES,
		FUSION_BOLT,
		FUSION_FLARE,
		FUTURE_SIGHT,
		//G_MAX_BEFUDDLE,
		//G_MAX_CANNONADE,
		//G_MAX_CENTIFERNO,
		//G_MAX_CHI_STRIKE,
		//G_MAX_CUDDLE,
		//G_MAX_DEPLETION,
		//G_MAX_DRUM_SOLO,
		//G_MAX_FINALE,
		//G_MAX_FIREBALL,
		//G_MAX_FOAM_BURST,
		//G_MAX_GOLD_RUSH,
		//G_MAX_GRAVITAS,
		//G_MAX_HYDROSNIPE,
		//G_MAX_MALODOR,
		//G_MAX_MELTDOWN,
		//G_MAX_ONE_BLOW,
		//G_MAX_RAPID_FLOW,
		//G_MAX_REPLENISH,
		//G_MAX_RESONANCE,
		//G_MAX_SANDBLAST,
		//G_MAX_SMITE,
		//G_MAX_SNOOZE,
		//G_MAX_STEELSURGE,
		//G_MAX_STONESURGE,
		//G_MAX_STUN_SHOCK,
		//G_MAX_SWEETNESS,
		//G_MAX_TARTNESS,
		//G_MAX_TERROR,
		//G_MAX_VINE_LASH,
		//G_MAX_VOLCALITH,
		//G_MAX_VOLT_CRASH,
		//G_MAX_WILDFIRE,
		//G_MAX_WIND_RAGE,
		GASTRO_ACID,
		GEAR_GRIND,
		GEAR_UP,
		//GENESIS_SUPERNOVA,
		GEOMANCY,
		GIGA_DRAIN,
		GIGA_IMPACT,
		GIGATON_HAMMER,
		//GIGAVOLT_HAVOC,
		GLACIAL_LANCE,
		GLACIATE,
		GLAIVE_RUSH,
		GLARE,
		//GLITZY_GLOW,
		GRASS_KNOT,
		GRASS_PLEDGE,
		GRASS_WHISTLE,
		//GRASSY_GLIDE,
		GRASSY_TERRAIN,
		GRAV_APPLE,
		GRAVITY,
		GROWL,
		GROWTH,
		GRUDGE,
		GUARD_SPLIT,
		GUARD_SWAP,
		//GUARDIAN_OF_ALOLA,
		GUILLOTINE,
		GUNK_SHOT,
		GUST,
		GYRO_BALL,
		HAIL,
		HAMMER_ARM,
		HAPPY_HOUR,
		HARDEN,
		HAZE,
		HEAD_CHARGE,
		HEAD_SMASH,
		HEADBUTT,
		HEADLONG_RUSH,
		HEAL_BELL,
		HEAL_BLOCK,
		HEAL_ORDER,
		HEAL_PULSE,
		HEALING_WISH,
		HEART_STAMP,
		HEART_SWAP,
		HEAT_CRASH,
		HEAT_WAVE,
		HEAVY_SLAM,
		HELPING_HAND,
		HEX,
		HIDDEN_POWER,
		HIGH_HORSEPOWER,
		HIGH_JUMP_KICK,
		HOLD_BACK,
		//HOLD_HANDS,
		HONE_CLAWS,
		HORN_ATTACK,
		HORN_DRILL,
		HORN_LEECH,
		HOWL,
		HURRICANE,
		HYDRO_CANNON,
		HYDRO_PUMP,
		HYDRO_STEAM,
		//HYDRO_VORTEX,
		HYPER_BEAM,
		HYPER_DRILL,
		HYPER_FANG,
		HYPER_VOICE,
		HYPERSPACE_FURY,
		HYPERSPACE_HOLE,
		HYPNOSIS,
		ICE_BALL,
		ICE_BEAM,
		ICE_BURN,
		ICE_FANG,
		ICE_HAMMER,
		ICE_PUNCH,
		ICE_SHARD,
		ICE_SPINNER,
		ICICLE_CRASH,
		ICICLE_SPEAR,
		ICY_WIND,
		IMPRISON,
		INCINERATE,
		INFERNAL_PARADE,
		INFERNO,
		//INFERNO_OVERDRIVE,
		INFESTATION,
		INGRAIN,
		INSTRUCT,
		ION_DELUGE,
		IRON_DEFENSE,
		IRON_HEAD,
		IRON_TAIL,
		JAW_LOCK,
		JET_PUNCH,
		JUDGMENT,
		JUMP_KICK,
		JUNGLE_HEALING,
		KARATE_CHOP,
		KINESIS,
		KING_S_SHIELD,
		KNOCK_OFF,
		KOWTOW_CLEAVE,
		LAND_S_WRATH,
		LASER_FOCUS,
		LASH_OUT,
		LAST_RESORT,
		LAST_RESPECTS,
		LAVA_PLUME,
		LEAF_BLADE,
		LEAF_STORM,
		LEAF_TORNADO,
		LEAFAGE,
		LEECH_LIFE,
		LEECH_SEED,
		LEER,
		//LET_S_SNUGGLE_FOREVER,
		LICK,
		LIFE_DEW,
		LIGHT_OF_RUIN,
		LIGHT_SCREEN,
		//LIGHT_THAT_BURNS_THE_SKY,
		LIQUIDATION,
		LOCK_ON,
		LOVELY_KISS,
		LOW_KICK,
		LOW_SWEEP,
		LUCKY_CHANT,
		LUMINA_CRASH,
		LUNAR_BLESSING,
		LUNAR_DANCE,
		LUNGE,
		LUSTER_PURGE,
		MACH_PUNCH,
		MAGIC_COAT,
		MAGIC_POWDER,
		MAGIC_ROOM,
		MAGICAL_LEAF,
		//MAGICAL_TORQUE,
		MAGMA_STORM,
		MAGNET_BOMB,
		MAGNET_RISE,
		MAGNETIC_FLUX,
		MAGNITUDE,
		MAKE_IT_RAIN,
		//MALICIOUS_MOONSAULT,
		MAT_BLOCK,
		//MAX_AIRSTREAM,
		//MAX_DARKNESS,
		//MAX_FLARE,
		//MAX_FLUTTERBY,
		//MAX_GEYSER,
		//MAX_GUARD,
		//MAX_HAILSTORM,
		//MAX_KNUCKLE,
		//MAX_LIGHTNING,
		//MAX_MINDSTORM,
		//MAX_OOZE,
		//MAX_OVERGROWTH,
		//MAX_PHANTASM,
		//MAX_QUAKE,
		//MAX_ROCKFALL,
		//MAX_STARFALL,
		//MAX_STEELSPIKE,
		//MAX_STRIKE,
		//MAX_WYRMWIND,
		ME_FIRST,
		MEAN_LOOK,
		MEDITATE,
		MEGA_DRAIN,
		MEGA_KICK,
		MEGA_PUNCH,
		MEGAHORN,
		MEMENTO,
		//MENACING_MOONRAZE_MAELSTROM,
		METAL_BURST,
		METAL_CLAW,
		METAL_SOUND,
		METEOR_ASSAULT,
		METEOR_BEAM,
		METEOR_MASH,
		METRONOME,
		MILK_DRINK,
		MIMIC,
		MIND_BLOWN,
		MIND_READER,
		MINIMIZE,
		MIRACLE_EYE,
		MIRROR_COAT,
		MIRROR_MOVE,
		MIRROR_SHOT,
		MIST,
		MIST_BALL,
		MISTY_EXPLOSION,
		MISTY_TERRAIN,
		MOONBLAST,
		MOONGEIST_BEAM,
		MOONLIGHT,
		MORNING_SUN,
		MORTAL_SPIN,
		MOUNTAIN_GALE,
		MUD_BOMB,
		MUD_SHOT,
		MUD_SPORT,
		MUD_SLAP,
		MUDDY_WATER,
		MULTI_ATTACK,
		MYSTICAL_FIRE,
		MYSTICAL_POWER,
		NASTY_PLOT,
		NATURAL_GIFT,
		NATURE_POWER,
		NATURE_S_MADNESS,
		NEEDLE_ARM,
		//NEVER_ENDING_NIGHTMARE,
		NIGHT_DAZE,
		NIGHT_SHADE,
		NIGHT_SLASH,
		NIGHTMARE,
		NO_RETREAT,
		NOBLE_ROAR,
		//NOXIOUS_TORQUE,
		NUZZLE,
		OBLIVION_WING,
		OBSTRUCT,
		//OCEANIC_OPERETTA,
		OCTAZOOKA,
		OCTOLOCK,
		ODOR_SLEUTH,
		OMINOUS_WIND,
		ORDER_UP,
		ORIGIN_PULSE,
		OUTRAGE,
		OVERDRIVE,
		OVERHEAT,
		PAIN_SPLIT,
		PARABOLIC_CHARGE,
		PARTING_SHOT,
		PAY_DAY,
		PAYBACK,
		PECK,
		PERISH_SONG,
		PETAL_BLIZZARD,
		PETAL_DANCE,
		PHANTOM_FORCE,
		PHOTON_GEYSER,
		//PIKA_PAPOW,
		PIN_MISSILE,
		PLASMA_FISTS,
		PLAY_NICE,
		PLAY_ROUGH,
		PLUCK,
		POISON_FANG,
		POISON_GAS,
		POISON_JAB,
		POISON_POWDER,
		POISON_STING,
		POISON_TAIL,
		POLLEN_PUFF,
		POLTERGEIST,
		POPULATION_BOMB,
		POUNCE,
		POUND,
		POWDER,
		POWDER_SNOW,
		POWER_GEM,
		POWER_SHIFT,
		POWER_SPLIT,
		POWER_SWAP,
		POWER_TRICK,
		POWER_TRIP,
		POWER_WHIP,
		POWER_UP_PUNCH,
		PRECIPICE_BLADES,
		PRESENT,
		PRISMATIC_LASER,
		PROTECT,
		PSYBEAM,
		PSYBLADE,
		PSYCH_UP,
		PSYCHIC,
		PSYCHIC_FANGS,
		PSYCHIC_TERRAIN,
		PSYCHO_BOOST,
		PSYCHO_CUT,
		PSYCHO_SHIFT,
		PSYSHIELD_BASH,
		PSYSHOCK,
		PSYSTRIKE,
		PSYWAVE,
		//PULVERIZING_PANCAKE,
		PUNISHMENT,
		PURIFY,
		PURSUIT,
		PYRO_BALL,
		QUASH,
		QUICK_ATTACK,
		QUICK_GUARD,
		QUIVER_DANCE,
		RAGE,
		RAGE_FIST,
		RAGE_POWDER,
		RAGING_BULL,
		RAGING_FURY,
		RAIN_DANCE,
		RAPID_SPIN,
		RAZOR_LEAF,
		RAZOR_SHELL,
		RAZOR_WIND,
		RECOVER,
		RECYCLE,
		REFLECT,
		REFLECT_TYPE,
		REFRESH,
		RELIC_SONG,
		REST,
		RETALIATE,
		RETURN,
		REVELATION_DANCE,
		REVENGE,
		REVERSAL,
		REVIVAL_BLESSING,
		RISING_VOLTAGE,
		ROAR,
		ROAR_OF_TIME,
		ROCK_BLAST,
		ROCK_CLIMB,
		ROCK_POLISH,
		ROCK_SLIDE,
		ROCK_SMASH,
		ROCK_THROW,
		ROCK_TOMB,
		ROCK_WRECKER,
		ROLE_PLAY,
		ROLLING_KICK,
		ROLLOUT,
		ROOST,
		ROTOTILLER,
		ROUND,
		RUINATION,
		SACRED_FIRE,
		SACRED_SWORD,
		SAFEGUARD,
		SALT_CURE,
		SAND_ATTACK,
		SAND_TOMB,
		SANDSEAR_STORM,
		SANDSTORM,
		//SAPPY_SEED,
		//SAVAGE_SPIN_OUT,
		SCALD,
		SCALE_SHOT,
		SCARY_FACE,
		SCORCHING_SANDS,
		SCRATCH,
		SCREECH,
		SEARING_SHOT,
		//SEARING_SUNRAZE_SMASH,
		SECRET_POWER,
		SECRET_SWORD,
		SEED_BOMB,
		SEED_FLARE,
		SEISMIC_TOSS,
		SELF_DESTRUCT,
		SHADOW_BALL,
		SHADOW_BONE,
		SHADOW_CLAW,
		SHADOW_FORCE,
		SHADOW_PUNCH,
		SHADOW_SNEAK,
		SHARPEN,
		//SHATTERED_PSYCHE,
		SHED_TAIL,
		SHEER_COLD,
		SHELL_SIDE_ARM,
		SHELL_SMASH,
		SHELL_TRAP,
		SHELTER,
		SHIFT_GEAR,
		SHOCK_WAVE,
		SHORE_UP,
		SIGNAL_BEAM,
		SILK_TRAP,
		SILVER_WIND,
		SIMPLE_BEAM,
		SING,
		//SINISTER_ARROW_RAID,
		//SIZZLY_SLIDE,
		SKETCH,
		SKILL_SWAP,
		SKITTER_SMACK,
		SKULL_BASH,
		SKY_ATTACK,
		SKY_DROP,
		SKY_UPPERCUT,
		SLACK_OFF,
		SLAM,
		SLASH,
		SLEEP_POWDER,
		SLEEP_TALK,
		SLUDGE,
		SLUDGE_BOMB,
		SLUDGE_WAVE,
		SMACK_DOWN,
		SMART_STRIKE,
		SMELLING_SALTS,
		SMOG,
		SMOKESCREEN,
		SNAP_TRAP,
		SNARL,
		SNATCH,
		SNIPE_SHOT,
		SNORE,
		SNOWSCAPE,
		SOAK,
		SOFT_BOILED,
		SOLAR_BEAM,
		SOLAR_BLADE,
		SONIC_BOOM,
		//SOUL_STEALING_7_STAR_STRIKE,
		SPACIAL_REND,
		SPARK,
		SPARKLING_ARIA,
		//SPARKLY_SWIRL,
		SPECTRAL_THIEF,
		SPEED_SWAP,
		SPICY_EXTRACT,
		SPIDER_WEB,
		SPIKE_CANNON,
		SPIKES,
		SPIKY_SHIELD,
		SPIN_OUT,
		SPIRIT_BREAK,
		SPIRIT_SHACKLE,
		SPIT_UP,
		SPITE,
		SPLASH,
		//SPLINTERED_STORMSHARDS,
		//SPLISHY_SPLASH,
		SPORE,
		SPOTLIGHT,
		SPRINGTIDE_STORM,
		STEALTH_ROCK,
		STEAM_ERUPTION,
		STEAMROLLER,
		STEEL_BEAM,
		STEEL_ROLLER,
		STEEL_WING,
		STICKY_WEB,
		STOCKPILE,
		//STOKED_SPARKSURFER,
		STOMP,
		STOMPING_TANTRUM,
		STONE_AXE,
		STONE_EDGE,
		STORED_POWER,
		STORM_THROW,
		STRANGE_STEAM,
		STRENGTH,
		STRENGTH_SAP,
		STRING_SHOT,
		STRUGGLE,
		STRUGGLE_BUG,
		STUFF_CHEEKS,
		STUN_SPORE,
		SUBMISSION,
		SUBSTITUTE,
		//SUBZERO_SLAMMER,
		SUCKER_PUNCH,
		SUNNY_DAY,
		SUNSTEEL_STRIKE,
		SUPER_FANG,
		SUPERPOWER,
		SUPERSONIC,
		//SUPERSONIC_SKYSTRIKE,
		SURF,
		SURGING_STRIKES,
		SWAGGER,
		SWALLOW,
		SWEET_KISS,
		SWEET_SCENT,
		SWIFT,
		SWITCHEROO,
		SWORDS_DANCE,
		SYNCHRONOISE,
		SYNTHESIS,
		TACKLE,
		TAIL_GLOW,
		TAIL_SLAP,
		TAIL_WHIP,
		TAILWIND,
		TAKE_DOWN,
		TAKE_HEART,
		TAR_SHOT,
		TAUNT,
		TEARFUL_LOOK,
		TEATIME,
		TECHNO_BLAST,
		//TECTONIC_RAGE,
		TEETER_DANCE,
		TELEKINESIS,
		TELEPORT,
		//TERA_BLAST,
		TERRAIN_PULSE,
		THIEF,
		THOUSAND_ARROWS,
		THOUSAND_WAVES,
		THRASH,
		THROAT_CHOP,
		THUNDER,
		THUNDER_CAGE,
		THUNDER_FANG,
		THUNDER_PUNCH,
		THUNDER_SHOCK,
		THUNDER_WAVE,
		THUNDERBOLT,
		THUNDEROUS_KICK,
		TICKLE,
		TIDY_UP,
		TOPSY_TURVY,
		TORCH_SONG,
		TORMENT,
		TOXIC,
		TOXIC_SPIKES,
		TOXIC_THREAD,
		TRAILBLAZE,
		TRANSFORM,
		TRI_ATTACK,
		TRICK,
		TRICK_ROOM,
		TRICK_OR_TREAT,
		TRIPLE_ARROWS,
		TRIPLE_AXEL,
		TRIPLE_DIVE,
		TRIPLE_KICK,
		TROP_KICK,
		TRUMP_CARD,
		TWIN_BEAM,
		TWINEEDLE,
		//TWINKLE_TACKLE,
		TWISTER,
		U_TURN,
		UPROAR,
		V_CREATE,
		VACUUM_WAVE,
		//VEEVEE_VOLLEY,
		VENOM_DRENCH,
		VENOSHOCK,
		VICTORY_DANCE,
		VINE_WHIP,
		VISE_GRIP,
		VITAL_THROW,
		VOLT_SWITCH,
		VOLT_TACKLE,
		WAKE_UP_SLAP,
		WATER_GUN,
		WATER_PLEDGE,
		WATER_PULSE,
		WATER_SHURIKEN,
		WATER_SPORT,
		WATER_SPOUT,
		WATERFALL,
		WAVE_CRASH,
		WEATHER_BALL,
		WHIRLPOOL,
		WHIRLWIND,
		WICKED_BLOW,
		//WICKED_TORQUE,
		WIDE_GUARD,
		WILD_CHARGE,
		WILDBOLT_STORM,
		WILL_O_WISP,
		WING_ATTACK,
		WISH,
		WITHDRAW,
		WONDER_ROOM,
		WOOD_HAMMER,
		WORK_UP,
		WORRY_SEED,
		WRAP,
		WRING_OUT,
		X_SCISSOR,
		YAWN,
		ZAP_CANNON,
		ZEN_HEADBUTT,
		ZING_ZAP,
		//ZIPPY_ZAP
		MOVES_NR_ITEMS
	};
}