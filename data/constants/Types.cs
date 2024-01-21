using System;

namespace PkmnEngine {
	public static class Types {
		private const string INVALID_TYPE_GIVEN_ERROR_MESSAGE = "How did we get here?";

		// normally effective
		public const float EFF_NORMAL = 1f;
		// not very effective
		public const float EFF_NVE = 0.5f;
		// super effective
		public const float EFF_SPE = 2f;
		// does not effect
		public const float EFF_IMMUNE = 0f;

		// 18 types + NONE
		public const byte NUM_TYPES = 19;
		
		/// <summary>
		/// Looks up the type effectiveness between given types.
		/// </summary>
		/// <param name="attackingType">Type of the attacking move.</param>
		/// <param name="defendingType">Type of the mon getting hit by the move.</param>
		/// <returns>0, 0.5, 1, or 2.</returns>
		public static float gTypeEffectivenessMult(Type attackingType, Type defendingType) {
			return attackingType switch
			{
				Type.NONE => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NORMAL,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.FIGHTING => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NVE,
					Type.POISON => EFF_NVE,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_SPE,
					Type.BUG => EFF_NVE,
					Type.GHOST => EFF_IMMUNE,
					Type.STEEL => EFF_SPE,
					Type.NORMAL => EFF_SPE,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NVE,
					Type.ICE => EFF_SPE,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_SPE,
					Type.FAIRY => EFF_NVE,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.FLYING => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_SPE,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NVE,
					Type.BUG => EFF_SPE,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_SPE,
					Type.ELECTRIC => EFF_NVE,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.POISON => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NVE,
					Type.GROUND => EFF_NVE,
					Type.ROCK => EFF_NVE,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_IMMUNE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_SPE,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_SPE,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.GROUND => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_IMMUNE,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_SPE,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_SPE,
					Type.BUG => EFF_NVE,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_SPE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_SPE,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NVE,
					Type.ELECTRIC => EFF_SPE,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.ROCK => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_SPE,
					Type.POISON => EFF_NVE,
					Type.GROUND => EFF_NVE,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_SPE,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_SPE,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_SPE,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.BUG => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NVE,
					Type.FLYING => EFF_NVE,
					Type.POISON => EFF_NVE,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NVE,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NVE,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_SPE,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_SPE,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_SPE,
					Type.FAIRY => EFF_NVE,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.GHOST => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_SPE,
					Type.STEEL => EFF_NORMAL,
					Type.NORMAL => EFF_IMMUNE,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_SPE,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NVE,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.STEEL => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_SPE,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NVE,
					Type.WATER => EFF_NVE,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NVE,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_SPE,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_SPE,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.NORMAL => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NVE,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_IMMUNE,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.FIRE => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NVE,
					Type.BUG => EFF_SPE,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_SPE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NVE,
					Type.WATER => EFF_NVE,
					Type.GRASS => EFF_SPE,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_SPE,
					Type.DRAGON => EFF_NVE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.WATER => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_SPE,
					Type.ROCK => EFF_SPE,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NORMAL,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_SPE,
					Type.WATER => EFF_NVE,
					Type.GRASS => EFF_NVE,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NVE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.GRASS => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NVE,
					Type.POISON => EFF_NVE,
					Type.GROUND => EFF_SPE,
					Type.ROCK => EFF_SPE,
					Type.BUG => EFF_NVE,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NVE,
					Type.WATER => EFF_SPE,
					Type.GRASS => EFF_NVE,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NVE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.ELECTRIC => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_SPE,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_IMMUNE,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NORMAL,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_SPE,
					Type.GRASS => EFF_NVE,
					Type.ELECTRIC => EFF_NVE,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NVE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.PSYCHIC => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_SPE,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_SPE,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NVE,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NORMAL,
					Type.DARK => EFF_IMMUNE,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.ICE => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_SPE,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_SPE,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NVE,
					Type.WATER => EFF_NVE,
					Type.GRASS => EFF_SPE,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NVE,
					Type.DRAGON => EFF_SPE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.DRAGON => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NORMAL,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_NORMAL,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_SPE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_IMMUNE,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.DARK => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_NVE,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NORMAL,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_SPE,
					Type.STEEL => EFF_NORMAL,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NORMAL,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_SPE,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_NVE,
					Type.DARK => EFF_NORMAL,
					Type.FAIRY => EFF_NVE,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				Type.FAIRY => defendingType switch
				{
					Type.NONE => EFF_NORMAL,
					Type.FIGHTING => EFF_SPE,
					Type.FLYING => EFF_NORMAL,
					Type.POISON => EFF_NVE,
					Type.GROUND => EFF_NORMAL,
					Type.ROCK => EFF_NORMAL,
					Type.BUG => EFF_NORMAL,
					Type.GHOST => EFF_NORMAL,
					Type.STEEL => EFF_NVE,
					Type.NORMAL => EFF_NORMAL,
					Type.FIRE => EFF_NVE,
					Type.WATER => EFF_NORMAL,
					Type.GRASS => EFF_NORMAL,
					Type.ELECTRIC => EFF_NORMAL,
					Type.PSYCHIC => EFF_SPE,
					Type.ICE => EFF_NORMAL,
					Type.DRAGON => EFF_SPE,
					Type.DARK => EFF_SPE,
					Type.FAIRY => EFF_NORMAL,
					_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE)
				},
				_ => throw new ArgumentException(INVALID_TYPE_GIVEN_ERROR_MESSAGE),
			};
		}
	}

	public enum Type {
		NONE,
		FIGHTING,
		FLYING,
		POISON,
		GROUND,
		ROCK,
		BUG,
		GHOST,
		STEEL,
		NORMAL,
		FIRE,
		WATER,
		GRASS,
		ELECTRIC,
		PSYCHIC,
		ICE,
		DRAGON,
		DARK,
		FAIRY
	};
}