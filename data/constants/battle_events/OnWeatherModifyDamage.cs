using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;

using PkmnEngine.Strings;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnWeatherModifyDamageParams {
		public OnWeatherModifyDamageParams(BattleState state, BattleMoveID moveID, BattleMon attacker, BattleMon defender) {
			this.state = state;
			this.moveID = moveID;
			this.attacker = attacker;
			this.defender = defender;
		}
		public BattleState state;
		public BattleMoveID moveID;
		public BattleMon attacker;
		public BattleMon defender;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Weather_HarshSunlight_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			if (args.moveID == BattleMoveID.HYDRO_STEAM && args.attacker.HeldItem != Item.UTILITY_UMBRELLA) {
				return 1.5f;
			}
			if (args.defender.HeldItem == Item.UTILITY_UMBRELLA) {
				return 1;
			}
			if (move.moveType == Type.FIRE) {
				// Sunny Day fire boost
				return FieldConditions.WEATHER_DAMAGE_BOOST;
			}
			if (move.moveType == Type.WATER) {
				// Sunny Day water suppress
				return FieldConditions.WEATHER_DAMAGE_REDUCTION;
			}

			return 1;
		}
		public static async Task<object> Weather_Rain_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			if (args.defender.HeldItem == Item.UTILITY_UMBRELLA) {
				return 1;
			}
			if (move.moveType == Type.WATER) {
				// Sunny Day fire boost
				return FieldConditions.WEATHER_DAMAGE_BOOST;
			}
			if (move.moveType == Type.FIRE) {
				// Sunny Day water suppress
				return FieldConditions.WEATHER_DAMAGE_REDUCTION;
			}

			return 1;
		}

		public static async Task<object> Terrain_Electric_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			// Boost damage of electric type moves used by grounded mons while electric terrain is active.
			if (args.attacker.IsGrounded(args.state) && args.state.Terrain.Condition == Condition.TERRAIN_ELECTRIC && move.moveType == Type.ELECTRIC) {
				return FieldConditions.TERRAIN_DAMAGE_BOOST;
			}

			return 1f;
		}
		public static async Task<object> Terrain_Grassy_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			float multiplier = 1f;

			// Boost damage of grass type moves used by grounded mons while grassy terrain is active.
			if (args.attacker.IsGrounded(args.state) && args.state.Terrain.Condition == Condition.TERRAIN_GRASSY && move.moveType == Type.GRASS) {
				multiplier *= FieldConditions.TERRAIN_DAMAGE_BOOST;
			}
			// Grounded mons take reduced damage from bulldoze, earthquake, and magnitude while grassy terrain is active.
			if (args.defender.IsGrounded(args.state) && (args.moveID == BattleMoveID.BULLDOZE || args.moveID == BattleMoveID.EARTHQUAKE || args.moveID == BattleMoveID.MAGNITUDE)) {
				multiplier *= FieldConditions.TERRAIN_DAMAGE_REDUCTION;
			}

			return multiplier;
		}
		public static async Task<object> Terrain_Misty_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			// Reduce damage of dragon type moves taken by grounded mons while misty terrain is active.
			if (args.defender.IsGrounded(args.state) && args.state.Terrain.Condition == Condition.TERRAIN_MISTY && move.moveType == Type.DRAGON) {
				return FieldConditions.TERRAIN_DAMAGE_REDUCTION;
			}

			return 1f;
		}
		public static async Task<object> Terrain_Psychic_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			// Boost damage of psychic type moves used by grounded mons while psychic terrain is active.
			if (args.attacker.IsGrounded(args.state) && args.state.Terrain.Condition == Condition.TERRAIN_PSYCHIC && move.moveType == Type.PSYCHIC) {
				return FieldConditions.TERRAIN_DAMAGE_BOOST;
			}

			return 1f;
		}		

		public static async Task<object> Condition_WaterSport_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);
			if (move.moveType == Type.FIRE) {
				return FieldConditions.WATER_SPORT_MULTIPLIER;
			}
			return 1f;
		}
		public static async Task<object> Condition_MudSport_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams args = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(args.moveID);
			if (move.moveType == Type.ELECTRIC) {
				return FieldConditions.MUD_SPORT_MULTIPLIER;
			}
			return 1f;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}