using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public static partial class AbilityEffects {
		private static object Adaptability_OnModifyStab(object p) {
			OnModifyStabParams cbParams = ValidateParams<OnModifyStabParams>(p);

			if (cbParams.bm.HasType(cbParams.moveType)) {
				return 2.0f;
			}
			return DamageCalc.SAME_TYPE_ATTACK_BONUS;
		}
	}
}