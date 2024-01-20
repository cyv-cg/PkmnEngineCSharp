using System;

namespace PkmnEngine.Strings {
	public class LanguageNotRecognizedException : Exception {
		public const string ERROR_LANGUAGE_NOT_RECOGNIZED = "Language '@LANG' not recognized";
		public LanguageNotRecognizedException(Language language) : base(ERROR_LANGUAGE_NOT_RECOGNIZED.Replace("@LANG", language.ToString())) { }
	}

	public class SpeciesNotRecognizedException : Exception {
		public const string ERROR_SPECIES_NOT_RECOGNIZED = "Language '@SPECIES' not recognized";
		public SpeciesNotRecognizedException(Species species) : base(ERROR_SPECIES_NOT_RECOGNIZED.Replace("@SPECIES", species.ToString())) { }
	}

	public class MoveNotRecognizedException : Exception {
		public const string ERROR_MOVE_NOT_RECOGNIZED = "Language '@MOVE' not recognized";
		public MoveNotRecognizedException(BattleMoveID move) : base(ERROR_MOVE_NOT_RECOGNIZED.Replace("@MOVE", move.ToString())) { }
	}
}