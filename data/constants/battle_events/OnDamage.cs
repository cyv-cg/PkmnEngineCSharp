using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnDamageParams {
		public OnDamageParams(BattleMon bm, U16 damage, bool force, bool direct) {
			this.bm = bm;
			this.damage = damage;
			this.force = force;
			this.direct = direct;
		}
		public BattleMon bm;
		public U16 damage;
		public bool force;
		public bool direct;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_Heatproof_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			if (args.bm.HasStatus(Status.BURN)) {
				return args.damage.Value /= 2;;
			}
			return true;
		}
		public static async Task<object> Ability_PoisonHeal_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			U16 healAmount = new(args.bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE));
			if (args.bm.HasStatus(Status.POISON, Status.TOXIC)) {
				await args.bm.HealMon(healAmount, false);
			}
			return false;
		}
		public static async Task<object> Ability_MagicGuard_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			if (!args.direct) {
				return false;
			}

			return true;
		}

		public static async Task<object> Status_Bracing_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			args.damage.Value = (u16)Math.Min(args.damage.Value, args.bm.HP - 1);

			return true;
		}
		public static async Task<object> Status_Rage_OnDamage(object p) {
			OnDamageParams args = ValidateParams<OnDamageParams>(p);

			// If the last move the mon used was Rage, increase it's attack by 1 stage.
			if (args.bm.HasStatus(Status.RAGE) && args.direct) {
				await MoveEffects.ChangeStat(null, args.bm, 1, Stat.ATTACK);
			}

			return true;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}