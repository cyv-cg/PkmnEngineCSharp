using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnResidualParams {
		public OnResidualParams(Battle battle, BattleState state, BattleMon bm) {
			this.battle = battle;
			this.state = state;
			this.bm = bm;
		}
		public Battle battle;
		public BattleState state;
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
		public static object Status_Burn_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 damage = cbParams.bm.GetPercentOfMaxHp(StatusEffects.BURN_CHIP_DAMAGE);
			cbParams.bm.DamageMon(ref damage, true, false);
			MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_ITS_BURN, cbParams.bm.GetName()));
			return null;
		}
		public static object Status_Poison_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 damage = cbParams.bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE);
			cbParams.bm.DamageMon(ref damage, true, false);
			if (damage > 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_POISON, cbParams.bm.GetName()));
			}
			return null;
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
			return null;
		}

		public static object Status_AquaRing_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.A_VEIL_OF_WATER_RESTORED_MONS_HP, cbParams.bm.GetName()));
			u16 healAmount = cbParams.bm.GetPercentOfMaxHp(StatusEffects.AQUA_RING_HEAL_AMOUNT);
			cbParams.bm.HealMon(ref healAmount, false);

			return null;
		}
		public static object Status_Seeded_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 healAmount = cbParams.bm.GetPercentOfMaxHp(StatusEffects.LEECH_SEED_DRAIN_AMOUNT);
			cbParams.bm.DamageMon(ref healAmount, true, false);
			BattleMon monSeededBy = cbParams.battle.GetMonInSlot(cbParams.state, (u8)cbParams.bm.GetStatusParam(StatusParam.SLOT_SEEDED_BY));
			if (monSeededBy != null) {
				monSeededBy.HealMon(ref healAmount, false);
				MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_HP_WAS_SAPPED_BY_LEECH_SEED, cbParams.bm.GetName()));
			}

			return null;
		}
		public static object Status_SaltCure_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 damage = (cbParams.bm.HasType(Type.WATER) || cbParams.bm.HasType(Type.STEEL)) ? cbParams.bm.GetPercentOfMaxHp(0.25f) : cbParams.bm.GetPercentOfMaxHp(0.125f);
			cbParams.bm.DamageMon(ref damage, true, false);
			MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_BEING_SALT_CURED, cbParams.bm.GetName()));

			return null;
		}
		public static object Status_Curse_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u16 damage = cbParams.bm.GetPercentOfMaxHp(0.25f);
			cbParams.bm.DamageMon(ref damage, true, false);
			MessageBox(Lang.GetBattleMessage(BattleMessage.MON_AFFLICTED_BY_CURSE, cbParams.bm.GetName()));

			return null;
		}
		public static object Status_ThroatChop_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u8 count = (u8)cbParams.bm.GetStatusParam(StatusParam.THROAT_CHOP);
			if (count == 0) {
				cbParams.bm.RemoveStatus(Status.THROAT_CHOP);
			}
			cbParams.bm.DecrementStatusParam(StatusParam.THROAT_CHOP);

			return null;
		}
		public static object Status_Taunt_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			u8 count = (u8)cbParams.bm.GetStatusParam(StatusParam.TAUNT);
			if (count == 0) {
				cbParams.bm.RemoveStatus(Status.THROAT_CHOP);
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SHOOK_OFF_THE_TAUNT, cbParams.bm.GetName()));
			}
			cbParams.bm.DecrementStatusParam(StatusParam.TAUNT);

			return null;
		}
		public static object Status_Encore_OnResidual(object p) {
			OnResidualParams cbParams = ValidateParams<OnResidualParams>(p);

			if (cbParams.bm.GetStatusParam(StatusParam.ENCORE_TURNS) == 0) {
				cbParams.bm.RemoveStatus(Status.ENCORE);
				MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_ENCORE_ENDED, cbParams.bm.GetName()));
			}
			cbParams.bm.DecrementStatusParam(StatusParam.ENCORE_TURNS);

			return null;
		}
	} 
}