namespace PkmnEngine {
	public static class Natures {
		public const byte NUM_NATURES = 25;
		public static sbyte[] gNatureStatTable(Nature nature) {
			return nature switch {
				Nature.HARDY => new sbyte[]		{0,	0,	0,	0,		0,		0},
				Nature.LONELY => new sbyte[]	{0,	+1,	-1,	0,		0,		0},
				Nature.BRAVE => new sbyte[]		{0,	+1,	0,	0,		0,		-1},
				Nature.ADAMANT => new sbyte[]	{0,	+1,	0,	-1,		0,		0},
				Nature.NAUGHTY => new sbyte[]	{0,	+1,	0,	0,		-1,		0},
				Nature.BOLD => new sbyte[]		{0,	-1,	+1,	0,		0,		0},
				Nature.DOCILE => new sbyte[]	{0,	0,	0,	0,		0,		0},
				Nature.RELAXED => new sbyte[]	{0,	0,	+1,	0,		0,		-1},
				Nature.IMPISH => new sbyte[]	{0,	0,	+1,	-1,		0,		0},
				Nature.LAX => new sbyte[]		{0,	0,	+1,	0,		-1,		0},
				Nature.TIMID => new sbyte[]		{0,	-1,	0,	0,		0,		+1},
				Nature.HASTY => new sbyte[]		{0,	0,	-1,	0,		0,		+1},
				Nature.SERIOUS => new sbyte[]	{0,	0,	0,	0,		0,		0},
				Nature.JOLLY => new sbyte[]		{0,	0,	0,	-1,		0,		+1},
				Nature.NAIVE => new sbyte[]		{0,	0,	0,	0,		-1,		+1},
				Nature.MODEST => new sbyte[]	{0,	-1,	0,	+1,		0,		0},
				Nature.MILD => new sbyte[]		{0,	0,	-1,	+1,		0,		0},
				Nature.QUIET => new sbyte[]		{0,	0,	0,	+1,		0,		-1},
				Nature.BASHFUL => new sbyte[]	{0,	0,	0,	0,		0,		0},
				Nature.RASH => new sbyte[]		{0,	0,	0,	+1,		-1,		0},
				Nature.CALM => new sbyte[]		{0,	-1,	0,	0,		+1,		0},
				Nature.GENTLE => new sbyte[]	{0,	0,	-1,	0,		+1,		0},
				Nature.SASSY => new sbyte[]		{0,	0,	0,	0,		+1,		-1},
				Nature.CAREFUL => new sbyte[]	{0,	0,	0,	-1,		+1,		0},
				Nature.QUIRKY => new sbyte[]	{0,	0,	0,	0,		0,		0},
				_ => throw new System.ArgumentException()
			};
		}
	}

	public enum Nature {
		HARDY,
		LONELY,
		BRAVE,
		ADAMANT,
		NAUGHTY,
		BOLD,
		DOCILE,
		RELAXED,
		IMPISH,
		LAX,
		TIMID,
		HASTY,
		SERIOUS,
		JOLLY,
		NAIVE,
		MODEST,
		MILD,
		QUIET,
		BASHFUL,
		RASH,
		CALM,
		GENTLE,
		SASSY,
		CAREFUL,
		QUIRKY
	};
}