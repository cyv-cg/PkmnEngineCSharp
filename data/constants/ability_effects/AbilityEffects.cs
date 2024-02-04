using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Collections.Generic;

namespace PkmnEngine {
	public static partial class AbilityEffects {
		private static T ValidateParams<T>(object p) {
			if (p.GetType() != typeof(T)) {
				throw new System.ArgumentException($"Expected {typeof(T)}, received {p.GetType()}.");
			}
			return (T)p;
		}

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
				Adaptability_OnModifyStab
			}}
		}, 
		{
			Ability.GUTS,
			new Dictionary<Callback, BattleEvent>() {{ 
				Callback.OnModifyAtk,
				Guts_OnModifyAtk
			}}
		}, 
		{
			Ability.HEATPROOF,
			new Dictionary<Callback, BattleEvent>() {{
				Callback.OnSourceModifyAtk, 
				Heatproof_OnSourceModifyAtk
			}, {
				Callback.OnSourceModifySpAtk,
				Heatproof_OnSourceModifySpAtk
			}, {
				Callback.OnDamage,
				Heatproof_OnDamage
			}}
		},

		
		};
	}
}