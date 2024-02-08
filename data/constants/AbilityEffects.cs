using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Collections.Generic;

namespace PkmnEngine {
	public static class AbilityEffects {
		public static BattleEvent gAbilityEvents(Ability ability, Callback cb) {
			if (AbilityEvents.ContainsKey(ability) && AbilityEvents[ability].ContainsKey(cb)) {
				return AbilityEvents[ability][cb];
			}
			else {
				return null;
			}
		}

		// Lets give it up for static typing and the cursed syntax it leads to!!!
		// For real tho, this is *super* prone to logical errors.
		private static readonly Dictionary<Ability, Dictionary<Callback, BattleEvent>> AbilityEvents = new() { {
		
			Ability.ADAPTABILITY,
			new Dictionary<Callback, BattleEvent>() {{
				Callback.OnModifyStab,
				BattleEvents.Ability_Adaptability_OnModifyStab
			}}
		}, 
		{
			Ability.GUTS,
			new Dictionary<Callback, BattleEvent>() {{ 
				Callback.OnModifyAtk,
				BattleEvents.Ability_Guts_OnModifyAtk
			}}
		}, 
		{
			Ability.HEATPROOF,
			new Dictionary<Callback, BattleEvent>() {{
				Callback.OnSourceModifyAtk, 
				BattleEvents.Ability_Heatproof_OnSourceModifyAtk
			}, {
				Callback.OnSourceModifySpAtk,
				BattleEvents.Ability_Heatproof_OnSourceModifySpAtk
			}, {
				Callback.OnDamage,
				BattleEvents.Ability_Heatproof_OnDamage
			}}
		},
		{
			Ability.POISON_HEAL,
			new Dictionary<Callback, BattleEvent>() {{
				Callback.OnDamage,
				BattleEvents.Ability_PoisonHeal_OnDamage
			}}
		}

		
		};
	}
}