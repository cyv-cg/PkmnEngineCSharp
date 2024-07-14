using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnModifyStabParams {
		public OnModifyStabParams(BattleMon bm, Type moveType) {
			this.bm = bm;
			this.moveType = moveType;
		}
		public BattleMon bm;
		public Type moveType;
	}

	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_Adaptability_OnModifyStab(object p) {
			OnModifyStabParams args = ValidateParams<OnModifyStabParams>(p);

			if (args.bm.HasType(args.moveType)) {
				return 2.0f;
			}
			return DamageCalc.SAME_TYPE_ATTACK_BONUS;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}