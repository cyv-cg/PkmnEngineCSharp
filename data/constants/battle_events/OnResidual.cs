using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnResidualParams {
		public OnResidualParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
		public static object Status_Burn_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 damage = cbParams.bm.GetPercentOfMaxHp(StatusEffects.BURN_CHIP_DAMAGE);
			cbParams.bm.DamageMon(ref damage, false, false);
			MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_ITS_BURN, cbParams.bm.GetName()));
			return 1;
		}
		public static object Status_Poison_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 damage = cbParams.bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE);
			cbParams.bm.DamageMon(ref damage, true, false);
			if (damage > 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_POISON, cbParams.bm.GetName()));
			}
			return damage;
		}
		public static object Status_Toxic_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			// Toxic deals damage starting at a set percentage, and grows by that percentage every turn.
			u16 baseDamage = cbParams.bm.GetPercentOfMaxHp(StatusEffects.TOXIC_CHIP_DAMAGE);
			u16 totalDamage;
			// Accumulation is capped at 15 stacks.
			if (cbParams.bm.GetStatusParam(StatusParam.TOXIC_BUILDUP) < 15) {
				cbParams.bm.IncrementStatusParam(StatusParam.TOXIC_BUILDUP);
			}
			// Stack additional damage by number of turns afflicted.
			totalDamage = (u16)(baseDamage * cbParams.bm.GetStatusParam(StatusParam.TOXIC_BUILDUP));
			cbParams.bm.DamageMon(ref totalDamage, true, false);
			if (baseDamage > 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_POISON, cbParams.bm.GetName()));
			}
			return totalDamage;
		}
	} 
}