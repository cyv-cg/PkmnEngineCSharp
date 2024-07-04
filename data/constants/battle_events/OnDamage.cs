using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

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
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			if (args.bm.HasStatus(Status.BURN)) {
				return args.damage / 2;
			}
			return args.damage;
		}
		public static async Task<object> Ability_PoisonHeal_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			U16 healAmount = new(args.bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE));
			if (args.bm.HasStatus(Status.POISON, Status.TOXIC)) {
				await args.bm.HealMon(healAmount, false);
			}
			return 1;
		}

		public static async Task<object> Status_Rage_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			// If the last move the mon used was Rage, increase it's attack by 1 stage.
			if (args.bm.HasStatus(Status.RAGE) && args.direct) {
				await MoveEffects.ChangeStat(null, args.bm, 1, Stat.ATTACK);
			}

			return 1;
		}
	}
}