using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnCheckIsDamagedBySandstormParams {
		public OnCheckIsDamagedBySandstormParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_SandForce_OnCheckIsDamagedBySandstorm(object p) {
			OnCheckIsDamagedBySandstormParams args = ValidateParams<OnCheckIsDamagedBySandstormParams>(p);
			return args.bm.ability != Ability.SAND_FORCE;
		}
		public static async Task<object> Ability_SandRush_OnCheckIsDamagedBySandstorm(object p) {
			OnCheckIsDamagedBySandstormParams args = ValidateParams<OnCheckIsDamagedBySandstormParams>(p);
			return args.bm.ability != Ability.SAND_RUSH;
		}
		public static async Task<object> Ability_SandVeil_OnCheckIsDamagedBySandstorm(object p) {
			OnCheckIsDamagedBySandstormParams args = ValidateParams<OnCheckIsDamagedBySandstormParams>(p);
			return args.bm.ability != Ability.SAND_VEIL;
		}
		public static async Task<object> Ability_Overcoat_OnCheckIsDamagedBySandstorm(object p) {
			OnCheckIsDamagedBySandstormParams args = ValidateParams<OnCheckIsDamagedBySandstormParams>(p);
			return args.bm.ability != Ability.OVERCOAT;
		}

		public static async Task<object> Item_SafetyGoggles_OnCheckIsDamagedBySandstorm(object p) {
			OnCheckIsDamagedBySandstormParams args = ValidateParams<OnCheckIsDamagedBySandstormParams>(p);
			return false;
		}

		public static async Task<object> Status_SemiInvulnerableTurn_OnCheckIsDamagedBySandstorm(object p) {
			OnCheckIsDamagedBySandstormParams args = ValidateParams<OnCheckIsDamagedBySandstormParams>(p);
			return args.bm.GetStatusParam(StatusParam.SEMI_INVULNERABLE) switch {
				StatusEffects.SEMI_INVULNERABLE_GROUND or StatusEffects.SEMI_INVULNERABLE_WATER or StatusEffects.SEMI_INVULNERABLE_PHANTOM => false,
				StatusEffects.SEMI_INVULNERABLE_AIR => true,
				_ => true,
			};
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}