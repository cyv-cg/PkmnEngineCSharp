using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public static partial class AbilityEffects {
		private static object Heatproof_OnDamage(object p) {
			OnDamageParams cbParams = ValidateParams<OnDamageParams>(p);

			if (cbParams.status == Status.BURN) {
				return cbParams.damage / 2;
			}
			return cbParams.damage;
		}
	}
}