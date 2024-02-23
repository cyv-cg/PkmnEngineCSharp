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
	public readonly struct NextTurnEvent {
		public NextTurnEvent(BattleEvent battleEvent, OnNextTurnParams args) {
			this.battleEvent = battleEvent;
			this.args = args;
		}
		public readonly BattleEvent battleEvent;
		public readonly OnNextTurnParams args;
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
		OnModifySpd,
		OnSourceModifyAtk,
		OnSourceModifySpAtk,
		OnFieldModifyAcc,
		OnDamage,
		OnResidual,
		OnFieldResidual,
		OnSideResidual,
		OnStart,
		OnEnd,
		OnModifyCritRatio,
		OnSourceModifyCritRatio,
		OnWeatherModifyDamage,
		OnModifyDamage,
		OnStatusImmunityCheck,
		OnTryMove,
		OnTrySelectMove,
		OnTrySetWeather,
		OnTryAddNonVolatile,
		OnTryChangeStat,
		OnWeatherSet,
		DurationCallback,
		OnNextTurn,
	}
}