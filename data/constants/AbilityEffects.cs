using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleEvents;

using PkmnEngine.Strings;

using System.Collections.Generic;

namespace PkmnEngine {
	public static class AbilityEffects {
		public static (BattleEvent callback, sbyte priority) gAbilityEvents(Ability ability, Callback cb) {
			if (AbilityEvents.ContainsKey(ability) && AbilityEvents[ability].ContainsKey(cb)) {
				return AbilityEvents[ability][cb];
			}
			else {
				return (null, 0);
			}
		}

		// Lets give it up for static typing and the cursed syntax it leads to!!!
		// For real tho, this is *super* prone to logical errors.
		private static readonly Dictionary<Ability, Dictionary<Callback, (BattleEvent callback, sbyte priority)>> AbilityEvents = new() { {
		
			Ability.ADAPTABILITY,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnModifyStab,
				(Ability_Adaptability_OnModifyStab, 0)
			}}
		},
		{
			Ability.ICE_BODY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsDamagedByHail,
				(Ability_IceBody_OnCheckIsDamagedByHail, 0)
			}}
		},
		{
			Ability.SNOW_CLOAK,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsDamagedByHail,
				(Ability_SnowCloak_OnCheckIsDamagedByHail, 0)
			}}
		},
		{
			Ability.SAND_FORCE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsDamagedBySandstorm,
				(Ability_SandForce_OnCheckIsDamagedBySandstorm, 0)
			}}
		},
		{
			Ability.SAND_RUSH,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsDamagedBySandstorm,
				(Ability_SandRush_OnCheckIsDamagedBySandstorm, 0)
			}}
		},
		{
			Ability.SAND_VEIL,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsDamagedBySandstorm,
				(Ability_SandVeil_OnCheckIsDamagedBySandstorm, 0)
			}}
		},
		{
			Ability.OVERCOAT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnCheckIsDamagedByHail,
					(Ability_Overcoat_OnCheckIsDamagedByHail, 0)
				},
				{
					Callback.OnCheckIsDamagedBySandstorm,
					(Ability_Overcoat_OnCheckIsDamagedBySandstorm, 0)
				}
			}
		},
		{
			Ability.GUTS,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{ 
				Callback.OnModifyAtk,
				(Ability_Guts_OnModifyAtk, 5)
			}}
		}, 
		{
			Ability.HEATPROOF,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnSourceModifyAtk, 
				(Ability_Heatproof_OnSourceModifyAtk, 6)
			}, {
				Callback.OnSourceModifySpAtk,
				(Ability_Heatproof_OnSourceModifySpAtk, 5)
			}, {
				Callback.OnDamage,
				(Ability_Heatproof_OnDamage, 0)
			}}
		},
		{
			Ability.POISON_HEAL,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {{
				Callback.OnDamage,
				(Ability_PoisonHeal_OnDamage, 1)
			}}
		},
		{
			Ability.BATTLE_ARMOR,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnModifyCritRatio,
				(Ability_BattleArmor_OnSourceModifyCritRatio, 0)
			}}
		},
		{
			Ability.SHELL_ARMOR,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnModifyCritRatio,
				(Ability_BattleArmor_OnSourceModifyCritRatio, 0)
			}}
		},
		{
			Ability.SUPER_LUCK,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnModifyCritRatio,
				(Ability_SuperLuck_OnModifyCritRatio, 0)
			}}
		},
		{
			Ability.QUICK_FEET,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnModifySpd,
				(Ability_QuickFeet_OnModifySpd, 0)
			}}
		},
		{
			Ability.MAGIC_GUARD,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnDamage,
				(Ability_MagicGuard_OnDamage, 0)
			}}
		},
		{
			Ability.PURIFYING_SALT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
				(async (object p) => { return false; }, 0)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
			}}
		},
		{
			Ability.COMATOSE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryAddNonVolatile,
	#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
					(async (object p) => { return false; /*idfk*/ }, 0)
	#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
				},
				{
					Callback.OnCheckAsleep,
					(Ability_Comatose_OnCheckAsleep, 0)
				}
			}
		},
		{
			Ability.LEAF_GUARD,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
				(Ability_LeafGuard_OnTryAddNonVolatile, 0)
			}}
		},
		{
			Ability.IMMUNITY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
				(Ability_Immunity_OnTryAddNonVolatile, 0)
			}}
		},
		{
			Ability.INSOMNIA,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
				(Ability_Insomnia_OnTryAddNonVolatile, 0)
			}}
		},
		{
			Ability.VITAL_SPIRIT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
				(Ability_Insomnia_OnTryAddNonVolatile, 0)
			}}
		},
		{
			Ability.LEVITATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsUngrounded,
				(Ability_Levitate_OnCheckIsUngrounded, 0)
			}}
		},
		{
			Ability.STICKY_HOLD,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryRemoveItem,
				(Ability_StickyHold_OnTryRemoveItem, 0)
			}}
		},
		{
			Ability.MULTITYPE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Ability_Multitype_OnTryRemoveItem, 0)
				}
			}
		}

		
		};
	}
}