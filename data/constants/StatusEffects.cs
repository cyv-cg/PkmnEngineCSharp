using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleEvents;

using System.Collections.Generic;

namespace PkmnEngine {
	public static class StatusEffects {
		public const u16 NUM_STATUSES = (u16)Status.NR_ITEMS;
	
		public const float BURN_ATTACK_MULTIPLIER =	0.5f;
		public const float PARALYSIS_SPEED_MULTIPLIER = 0.5f;

		public const float PARALYSIS_PROC_CHANCE = 0.25f;
		public const float FREEZE_THAW_CHANCE = 0.2f;

		public const u8 SLEEP_MIN_TURNS = 1;
		public const u8 SLEEP_MAX_TURNS = 6;
		// TODO: this should not use the global Random16
		public static u8 GetRandSleepTurns() { return (u8)(Random16() % SLEEP_MAX_TURNS + SLEEP_MIN_TURNS); }

		public const float BURN_CHIP_DAMAGE	= 1.0f / 8;
		public const float POISON_CHIP_DAMAGE = 1.0f / 8;
		public const float TOXIC_CHIP_DAMAGE = 1.0f / 16;

		public const float AQUA_RING_HEAL_AMOUNT = 1.0f / 16;
		public const float LEECH_SEED_DRAIN_AMOUNT = 1.0f / 8;

		#region masks
		// Statuses that persist after battle and when not on field. A Pokemon cannot have more than one at a time.
		public static readonly Status[] STATUS_MASK_NON_VOLATILE = new Status[] {
			Status.FAINTED,
			Status.BURN,
			Status.FREEZE,
			Status.PARALYSIS,
			Status.POISON,
			Status.TOXIC,
			Status.SLEEP
		};
		
		// Statuses that do not persist off field and outside battle. A Pokemon can have any number of these at the same time.
		public static readonly Status[] STATUS_MASK_VOLATILE = new Status[] {
			Status.ABILITY_CHANGE,
			Status.ABILITY_SUPPRESSION,
			Status.TYPE_CHANGE,
			Status.MIMIC,
			Status.SUBSTITUTE,
			Status.TRANSFORMED,
			Status.ILLUSION,
			Status.BOUND,
			Status.CURSE,
			Status.NIGHTMARE,
			Status.PERISH_SONG,
			Status.SEEDED,
			Status.SALT_CURE,
			Status.AUTOTOMIZE,
			Status.IDENTIFIED,
			Status.MINIMIZE,
			Status.TAR_SHOT,
			Status.GROUNDED,
			Status.MAGNETIC_LEVITATION,
			Status.TELEKINESIS,
			Status.AQUA_RING,
			Status.ROOTING,
			Status.LASER_FOCUS,
			Status.TAKING_AIM,
			Status.DROWSY,
			Status.CHARGED,
			Status.STOCKPILE_COUNT,
			Status.DEFENSE_CURL,
			Status.CANT_ESCAPE,
			Status.NO_RETREAT,
			Status.OCTOLOCK,
			Status.DISABLE,
			Status.EMBARGO,
			Status.HEAL_BLOCK,
			Status.IMPRISON,
			Status.TAUNT,
			Status.THROAT_CHOP,
			Status.TORMENT,
			Status.CONFUSION,
			Status.INFATUATION,
			Status.GETTING_PUMPED,
			Status.GUARD_SPLIT,
			Status.POWER_SPLIT,
			Status.POWER_SHIFT,
			Status.SPEED_SWAP,
			Status.POWER_TRICK,
			Status.CHOICE_LOCK,
			Status.ENCORE,
			Status.RAMPAGE,
			Status.ROLLING,
			Status.MAKING_AN_UPROAR,
			Status.BIDE,
			Status.RECHARGING,
			Status.CHARGING_TURN,
			Status.SEMI_INVULNERABLE_TURN,
			Status.FLINCH,
			Status.BRACING,
			Status.CENTER_OF_ATTENTION,
			Status.MAGIC_COAT,
			Status.PROTECTION,
			Status.BANEFUL_BUNKER,
			Status.OBSTRUCT,
			Status.LUCKY_CHANT,
			Status.DESTINY_BOND
		};
		// These statuses are passed along when using Baton Pass.
		public static readonly Status[] STATUS_MASK_BATON_PASSABLE = new Status[] {
			Status.CONFUSION,
			Status.GETTING_PUMPED,
			Status.TAKING_AIM,
			Status.CANT_ESCAPE,
			Status.NO_RETREAT,
			Status.ABILITY_SUPPRESSION,
			Status.SEEDED,
			Status.CURSE,
			Status.SUBSTITUTE,
			Status.ROOTING,
			Status.POWER_TRICK,
			Status.HEAL_BLOCK,
			Status.EMBARGO,
			Status.PERISH_SONG,
			Status.MAGNETIC_LEVITATION,
			Status.AQUA_RING,
			Status.TELEKINESIS
		};
		// These effects pass at the end of the turn.
		public static readonly Status[] STATUS_MASK_TRANSIENT = new Status[] {
			Status.FLINCH,
			Status.BRACING,
			Status.CENTER_OF_ATTENTION,
			Status.MAGIC_COAT,
			Status.PROTECTION,
			Status.BANEFUL_BUNKER,
			Status.OBSTRUCT,
			Status.LUCKY_CHANT,
			Status.RAGE
		};
		#endregion

		public const u8 SEMI_INVULNERABLE_GROUND	= 1 << 0;
		public const u8 SEMI_INVULNERABLE_AIR		= 1 << 1;
		public const u8 SEMI_INVULNERABLE_WATER		= 1 << 2;
		public const u8 SEMI_INVULNERABLE_PHANTOM	= 1 << 3;

		public static (BattleEvent callback, sbyte priority) gStatusEvents(Status status, Callback cb) {
			if (StatusEvents.ContainsKey(status) && StatusEvents[status].ContainsKey(cb)) {
				return StatusEvents[status][cb];
			}
			else {
				return (null, 0);
			}
		}

		private static readonly Dictionary<Status, Dictionary<Callback, (BattleEvent callback, sbyte priority)>> StatusEvents = new() { {
		
			Status.BURN,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnResidual,
				(Status_Burn_OnResidual, 10)
			}}
		},
		{
			Status.POISON,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnResidual,
				(Status_Poison_OnResidual, 9)
			}}
		},
		{
			Status.TOXIC,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnResidual,
				(Status_Toxic_OnResidual, 9)
			}}
		},
		{
			Status.AQUA_RING,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnResidual,
				(Status_AquaRing_OnResidual, 6)
			}}
		},
		{
			Status.SEEDED,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnResidual,
				(Status_Seeded_OnResidual, 8)
			}}
		},
		{
			Status.RAGE,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnDamage,
				(Status_Rage_OnDamage, 0)
			}}
		},
		{
			Status.PERISH_SONG,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnEnd,
				(Status_PerishSong_OnEnd, 24)
			}}
		},
		{
			Status.SALT_CURE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnResidual,
				(Status_SaltCure_OnResidual, 13)
			}}
		},
		{
			Status.CURSE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnResidual,
				(Status_Curse_OnResidual, 12)
			}}
		},
		{
			Status.LASER_FOCUS,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnModifyCritRatio,
					(Status_LaserFocus_OnModifyCritRatio, 0)
				}, 
				{
					Callback.OnEnd,
					(Status_LaserFocus_OnEnd, 0)
				}
			}
		},
		{
			Status.GETTING_PUMPED,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnModifyCritRatio,
				(Status_GettingPumped_OnModifyCritRatio, 0)
			}}
		}

		};
	}

	public enum StatusParam {
		PERISH_COUNT,			// Number of turns until the mon faints from Perish Song.
		MAGNETIC_LEVITATION,	// Turns remaining for Magnetic Levitation.
		TELEKINESIS,			// Turns remaining for Telekinesis.
		DISABLE,				// Turns remaining for Disable.
		DISABLED_SLOT,			// Stores the slot of the move that is disabled.
		HEAL_BLOCK,				// Turns remaining for Heal Block.
		TAUNT,					// Turns remaining for Taunt.
		THROAT_CHOP,			// Turns remaining for Throat Chop.
		ENCORE,					// Slot of the move the mon is forced to use.
		RAMPAGE,				// Turns remaining for rampage. (Outrage, Thrash, etc.)
		MAKING_AN_UPROAR,		// Turns remaining for Uproar.
		BIDE,					// Turns remaining for Bide charging.
		ENCORE_TURNS,			// Turns remaining for Encore.
		SEMI_INVULNERABLE,		// Type of semi-invulnerable turn the mon is in. (Fly, Dig, Dive, Phantom Force)
		LASER_FOCUS,			// If the mon is under the effect of Laser Focus.
		TAKING_AIM,				// If the mon is taking aim. (Lock On, etc.)
		DROWSING,				// If the mon is under the effect of Yawn.
		STOCKPILE_COUNT,		// Stockpile count.
		SLEEPING_TURNS,			// Number of turns the mon has been asleep.
		CONFUSED_TURNS,			// Number of turns the mon has been confused.
		SUCCESSIVE_PROTECTS,	// Counts how many times a protecting move has been used consecutively.
		LAST_USED_MOVE,			// Stores the slot of the last used move.
		SUCCESSIVE_MOVE_USES,	// Counts the number of times the same move has been used consecutively.
		LAST_TARGETED_MON,		// Stores the slot of the last targeted mon.
		BIDE_STARTING_HP,		// Stores the amount of HP the mon has when starting Bide.
		SLOT_SEEDED_BY,			// Stores the slot of the mon that seeded this mon.
		PHYS_DAMAGE_THIS_TURN,	// Stores the amount of physical damage taken this turn.
		SPEC_DAMAGE_THIS_TURN,	// Stores the amount of special damage taken this turn.
		LAST_MON_HIT_BY,		// Stores the slot of the last mon to attack this one.
		NV_STATUS_DURATION,		// How many turns a mon will be afflicted by a non-volatile status.
		TOXIC_BUILDUP,			// How many stacks toxic has build up for.
		NR_ITEMS
	};

	public enum Status {
		FAINTED,
		// Non-volatile
			BURN,
			FREEZE,
			PARALYSIS,
			POISON,
			TOXIC,
			SLEEP,
		// Volatile
			// Major
				ABILITY_CHANGE,
				ABILITY_SUPPRESSION,
				TYPE_CHANGE,
				MIMIC,
				SUBSTITUTE,
				TRANSFORMED,
				ILLUSION,
			// Damaging
				BOUND,
				CURSE,
				NIGHTMARE,
				PERISH_SONG,
				SEEDED,
				SALT_CURE,
			// Effectiveness
				AUTOTOMIZE,
				IDENTIFIED,
				MINIMIZE,
				TAR_SHOT,
			// Groundedness
				GROUNDED,
				MAGNETIC_LEVITATION,
				TELEKINESIS,
			// Healing
				AQUA_RING,
				ROOTING,
			// Next Turn
				LASER_FOCUS,
				TAKING_AIM,
				DROWSY,
			// Priming
				CHARGED,
				STOCKPILE_COUNT,
				DEFENSE_CURL,
				DESTINY_BOND,
			// Prevention
				CANT_ESCAPE,
				NO_RETREAT,
				OCTOLOCK,
				DISABLE,
				EMBARGO,
				HEAL_BLOCK,
				IMPRISON,
				TAUNT,
				THROAT_CHOP,
				TORMENT,
				CONFUSION,
				INFATUATION,
			// Stats
				GETTING_PUMPED,
				GUARD_SPLIT,
				POWER_SPLIT,
				POWER_SHIFT,
				SPEED_SWAP,
				POWER_TRICK,
			// Forced Move
				CHOICE_LOCK,
				ENCORE,
				RAMPAGE,
				ROLLING,
				MAKING_AN_UPROAR,
			// Multi-turn Move
				BIDE,
				RECHARGING,
				CHARGING_TURN,
				SEMI_INVULNERABLE_TURN,
			// Transient
				FLINCH,
				BRACING,
				CENTER_OF_ATTENTION,
				MAGIC_COAT,
				PROTECTION,
				BANEFUL_BUNKER,
				OBSTRUCT,
				LUCKY_CHANT,
				RAGE,
		NR_ITEMS // This one is just to keep track of the total number of bits needed to store statuses and should not be used.
	};
}