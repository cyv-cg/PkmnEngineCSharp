using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

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
		public static object Ability_Adaptability_OnModifyStab(object p) {
			OnModifyStabParams cbParams = ValidateParams<OnModifyStabParams>(p);

			if (cbParams.bm.HasType(cbParams.moveType)) {
				return 2.0f;
			}
			return DamageCalc.SAME_TYPE_ATTACK_BONUS;
		}
	}
}