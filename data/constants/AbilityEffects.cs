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
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
				(async (object p) => { return false; /*idfk*/ }, 0)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
			}}
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
		}

		
		};
	}
}