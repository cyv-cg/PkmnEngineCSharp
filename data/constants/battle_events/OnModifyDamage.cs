using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;
using System.Threading.Tasks;

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
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Condition_Reflect_OnModifyDamage(object p) {
			OnModifyDamageParams args = ValidateParams<OnModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);
			if (args.defender != args.attacker && move.moveCat == MoveCategory.PHYSICAL && !args.mods.isCrit) {
				return 0.66f;
			}

			return 1f;
		}
		public static async Task<object> Condition_LightScreen_OnModifyDamage(object p) {
			OnModifyDamageParams args = ValidateParams<OnModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);
			if (args.defender != args.attacker && move.moveCat == MoveCategory.SPECIAL && !args.mods.isCrit) {
				return 0.66f;
			}

			return 1f;
		}
		public static async Task<object> Condition_AuroraVeil_OnModifyDamage(object p) {
			OnModifyDamageParams args = ValidateParams<OnModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);
			// Reduction does not stack on top of Reflect/Light Screen.
			if (args.state.SideHasCondition(args.side, Condition.REFLECT) && move.moveCat == MoveCategory.PHYSICAL) {
				return 1f;
			}
			if (args.state.SideHasCondition(args.side, Condition.REFLECT) && move.moveCat == MoveCategory.SPECIAL) {
				return 1f;
			}
			if (args.defender != args.attacker && move.moveCat != MoveCategory.STATUS && !args.mods.isCrit) {
				return 0.66f;
			}

			return 1f;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	} 
}