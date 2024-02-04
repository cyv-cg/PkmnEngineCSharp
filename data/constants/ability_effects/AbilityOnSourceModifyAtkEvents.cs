using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public static partial class AbilityEffects {
		private static object Heatproof_OnSourceModifyAtk(object p) {
			OnSourceModifyAtkParams cbParams = ValidateParams<OnSourceModifyAtkParams>(p);

			if (cbParams.move.moveType == Type.FIRE) {
				return 0.5f;
			}
			return 1.0f;
		}
	}
}