using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnSourceModifySpAtkParams {
		public OnSourceModifySpAtkParams(BattleMove move) {
			this.move = move;
		}
		public BattleMove move;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_Heatproof_OnSourceModifySpAtk(object p) {
			OnSourceModifySpAtkParams args = ValidateParams<OnSourceModifySpAtkParams>(p);

			if (args.move.moveType == Type.FIRE) {
				return 0.5f;
			}
			return 1.0f;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}