using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
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
	}

	public enum Callback {
		OnModifyStab,
		OnModifyAtk,
		OnModifySpAtk,
		OnSourceModifyAtk,
		OnSourceModifySpAtk,
		OnDamage
	}

	#region Params structs
	public struct OnModifyStabParams {
		public OnModifyStabParams(BattleMon bm, Type moveType) {
            this.bm = bm;
            this.moveType = moveType;
        }
		public BattleMon bm;
		public Type moveType;
	}
	public struct OnModifyAtkParams {
		public OnModifyAtkParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	public struct OnModifySpAtkParams {
		public OnModifySpAtkParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	public struct OnSourceModifyAtkParams {
		public OnSourceModifyAtkParams(BattleMove move) {
            this.move = move;
        }
		public BattleMove move;
	}
	public struct OnSourceModifySpAtkParams {
		public OnSourceModifySpAtkParams(BattleMove move) {
            this.move = move;
        }
		public BattleMove move;
	}
	public struct OnDamageParams {
		public OnDamageParams(u16 damage, Status status) {
            this.damage = damage;
            this.status = status;
        }
		public u16 damage;
		public Status status;
	}
	#endregion
}