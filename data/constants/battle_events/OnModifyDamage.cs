using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnModifyDamageParams {
		public OnModifyDamageParams(Battle battle, BattleState state, u8 side, BattleMon attacker, BattleMon defender, BattleMoveID moveID, DamageCalc.Mods mods) {
			this.battle = battle;
			this.state = state;
			this.side = side;
			this.attacker = attacker;
			this.defender = defender;
			this.moveID = moveID;
			this.mods = mods;
		}
		public Battle battle;
		public BattleState state;
		public u8 side;
		public BattleMon attacker;
		public BattleMon defender;
		public BattleMoveID moveID;
		public DamageCalc.Mods mods;
	}
	
	internal static partial class BattleEvents {
		public static object Condition_Reflect_OnModifyDamage(object p) {
			OnModifyDamageParams cbParams = ValidateParams<OnModifyDamageParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);
			if (cbParams.defender != cbParams.attacker && move.moveCat == MoveCategory.PHYSICAL && !cbParams.mods.isCrit) {
				return 0.66f;
			}

			return 1f;
		}
		public static object Condition_LightScreen_OnModifyDamage(object p) {
			OnModifyDamageParams cbParams = ValidateParams<OnModifyDamageParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);
			if (cbParams.defender != cbParams.attacker && move.moveCat == MoveCategory.SPECIAL && !cbParams.mods.isCrit) {
				return 0.66f;
			}

			return 1f;
		}
		public static object Condition_AuroraVeil_OnModifyDamage(object p) {
			OnModifyDamageParams cbParams = ValidateParams<OnModifyDamageParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);
			// Reduction does not stack on top of Reflect/Light Screen.
			if (cbParams.state.SideHasCondition(cbParams.side, Condition.REFLECT) && move.moveCat == MoveCategory.PHYSICAL) {
				return 1f;
			}
			if (cbParams.state.SideHasCondition(cbParams.side, Condition.REFLECT) && move.moveCat == MoveCategory.SPECIAL) {
				return 1f;
			}
			if (cbParams.defender != cbParams.attacker && move.moveCat != MoveCategory.STATUS && !cbParams.mods.isCrit) {
				return 0.66f;
			}

			return 1f;
		}
	} 
}