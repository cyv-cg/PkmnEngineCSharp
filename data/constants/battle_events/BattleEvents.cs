using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

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
		public EventHandler(BattleEvent callback, EffectType effect) {
			this.callback = callback;
			this.effect = effect;
		}
		public readonly BattleEvent callback;
		public readonly EffectType effect;
	}

	public enum EffectType {
		ABILITY,
		STATUS,
		MOVE,
	}

	public enum Callback {
		OnModifyStab,
		OnModifyAtk,
		OnModifySpAtk,
		OnSourceModifyAtk,
		OnSourceModifySpAtk,
		OnDamage,
		OnResidual,
	}
}