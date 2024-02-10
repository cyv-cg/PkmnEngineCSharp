using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Collections.Generic;

namespace PkmnEngine {
	internal static partial class BattleEvents {
		private static T ValidateParams<T>(object p) {
			if (p.GetType() != typeof(T)) {
				throw new System.ArgumentException($"Expected {typeof(T)}, received {p.GetType()}.");
			}
			return (T)p;
		}
	}

	public delegate object BattleEvent(object callbackParams);

	public readonly struct EventHandler {
		public EventHandler(BattleEvent callback, EffectType effect, sbyte priority) {
			this.callback = callback;
			this.effect = effect;
			this.priority = priority;
		}
		public readonly BattleEvent callback;
		public readonly EffectType effect;
		public readonly sbyte priority;
	}

	public struct DurationCallbackParams {
		public DurationCallbackParams(BattleMon source) {
			this.source = source;
		}
		public BattleMon source;
	}

	public enum EffectType {
		ABILITY,
		STATUS,
		ITEM,
		SPECIES,
		SIDE,
		WEATHER,
		TERRAIN,
		CONDITION,
	}

	public enum Callback {
		OnModifyStab,
		OnModifyEffectiveness,
		OnModifyAtk,
		OnModifyDef,
		OnModifySpAtk,
		OnModifySpDef,
		OnSourceModifyAtk,
		OnSourceModifySpAtk,
		OnFieldModifyAcc,
		OnDamage,
		OnResidual,
		OnStart,
		OnEnd,
		OnModifyCritRatio,
		OnSourceModifyCritRatio,
		OnWeatherModifyDamage,
		OnFieldResidual,
		OnStatusImmunityCheck,
		OnTryMoveCheck,
		OnTrySetWeatherCheck,
		OnWeatherSet,
		DurationCallback,
	}
}