using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

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
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Status_Burn_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);


			U16 damage = new(args.bm.GetPercentOfMaxHp(StatusEffects.BURN_CHIP_DAMAGE));

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_WAS_HURT_BY_BURN, args.bm);
			await args.bm.DamageMon(damage, true, false, Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			
			return null;
		}
		public static async Task<object> Status_Poison_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			U16 damage = new(args.bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE));

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_HURT_BY_POISON, args.bm);
			await args.bm.DamageMon(damage, true, false, damage.Value > 0 ? Lang.GetString(STRINGS, contextString, args.bm.GetName()) : null);
			
			return null;
		}
		public static async Task<object> Status_Toxic_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			// Toxic deals damage starting at a set percentage, and grows by that percentage every turn.
			u16 baseDamage = args.bm.GetPercentOfMaxHp(StatusEffects.TOXIC_CHIP_DAMAGE);
			U16 totalDamage;
			// Accumulation is capped at 15 stacks.
			if (args.bm.GetStatusParam(StatusParam.TOXIC_BUILDUP) < 15) {
				args.bm.IncrementStatusParam(StatusParam.TOXIC_BUILDUP);
			}
			// Stack additional damage by number of turns afflicted.
			totalDamage = new((u16)(baseDamage * args.bm.GetStatusParam(StatusParam.TOXIC_BUILDUP)));

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_HURT_BY_POISON, args.bm);
			await args.bm.DamageMon(totalDamage, true, false, totalDamage.Value > 0 ? Lang.GetString(STRINGS, contextString, args.bm.GetName()) : null);
			
			return null;
		}

		public static async Task<object> Status_AquaRing_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.A_VEIL_OF_WATER_RESTORED_MONS_HP, args.bm);
			await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			U16 healAmount = new(args.bm.GetPercentOfMaxHp(StatusEffects.AQUA_RING_HEAL_AMOUNT));
			await args.bm.HealMon(healAmount, false);

			return null;
		}
		public static async Task<object> Status_Seeded_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			U16 healAmount = new(args.bm.GetPercentOfMaxHp(StatusEffects.LEECH_SEED_DRAIN_AMOUNT));

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MONS_HP_WAS_SAPPED_BY_LEECH_SEED, args.bm);
			await args.bm.DamageMon(healAmount, true, false, Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			BattleMon monSeededBy = args.battle.GetMonInSlot(args.state, (u8)args.bm.GetStatusParam(StatusParam.SLOT_SEEDED_BY));
			
			if (monSeededBy != null) {
				await monSeededBy.HealMon(healAmount, false);
			}

			return null;
		}
		public static async Task<object> Status_SaltCure_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			U16 damage = new((args.bm.HasType(Type.WATER) || args.bm.HasType(Type.STEEL)) ? args.bm.GetPercentOfMaxHp(0.25f) : args.bm.GetPercentOfMaxHp(0.125f));
			
			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_BEING_SALT_CURED, args.bm);
			await args.bm.DamageMon(damage, true, false, Lang.GetString(STRINGS, contextString, args.bm.GetName()));

			return null;
		}
		public static async Task<object> Status_Curse_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			U16 damage = new(args.bm.GetPercentOfMaxHp(0.25f));

			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_AFFLICTED_BY_CURSE, args.bm);
			await args.bm.DamageMon(damage, true, false, Lang.GetString(STRINGS, contextString, args.bm.GetName()));

			return null;
		}
		public static async Task<object> Status_ThroatChop_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			u8 count = (u8)args.bm.GetStatusParam(StatusParam.THROAT_CHOP);
			if (count == 0) {
				args.bm.RemoveStatus(Status.THROAT_CHOP);
			}
			args.bm.DecrementStatusParam(StatusParam.THROAT_CHOP);

			return null;
		}
		public static async Task<object> Status_Taunt_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			u8 count = (u8)args.bm.GetStatusParam(StatusParam.TAUNT);
			if (count == 0) {
				args.bm.RemoveStatus(Status.THROAT_CHOP);
				StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_SHOOK_OFF_THE_TAUNT, args.bm);
				await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			}
			args.bm.DecrementStatusParam(StatusParam.TAUNT);

			return null;
		}
		public static async Task<object> Status_Encore_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			if (args.bm.GetStatusParam(StatusParam.ENCORE_TURNS) == 0) {
				args.bm.RemoveStatus(Status.ENCORE);
				StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MONS_ENCORE_ENDED, args.bm);
				await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			}
			args.bm.DecrementStatusParam(StatusParam.ENCORE_TURNS);

			return null;
		}
		public static async Task<object> Status_Disable_OnResidual(object p) {
			OnResidualParams args = ValidateParams<OnResidualParams>(p);

			if (args.bm.GetStatusParam(StatusParam.DISABLE) == 0) {
				args.bm.RemoveStatus(Status.DISABLE);
				StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MONS_MOVE_NO_LONGER_DISABLED, args.bm);
				await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			}
			args.bm.DecrementStatusParam(StatusParam.DISABLE);

			return null;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	} 
}