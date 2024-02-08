using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnDamageParams {
		public OnDamageParams(BattleMon bm, u16 damage, bool force, bool direct) {
			this.bm = bm;
			this.damage = damage;
			this.force = force;
			this.direct = direct;
		}
		public BattleMon bm;
		public u16 damage;
		public bool force;
		public bool direct;
	}
	
	internal static partial class BattleEvents {
		public static object Ability_Heatproof_OnDamage(object p) {
			OnDamageParams cbParams = ValidateParams<OnDamageParams>(p);

			if (cbParams.bm.HasStatus(Status.BURN)) {
				return cbParams.damage / 2;
			}
			return cbParams.damage;
		}
		public static object Ability_PoisonHeal_OnDamage(object p) {
			OnDamageParams cbParams = ValidateParams<OnDamageParams>(p);

			u16 healAmount = cbParams.bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE);
			if (cbParams.bm.HasStatus(Status.POISON, Status.TOXIC)) {
				cbParams.bm.HealMon(ref healAmount, false);
			}
			return 1;
		}

		public static object Status_Rage_OnDamage(object p) {
			OnDamageParams cbParams = ValidateParams<OnDamageParams>(p);

			// If the last move the mon used was Rage, increase it's attack by 1 stage.
			if (cbParams.bm.HasStatus(Status.RAGE) && cbParams.direct) {
				MoveEffects.ChangeStat(null, cbParams.bm, 1, Stat.ATTACK);
			}

			return 1;
		}
	}
}