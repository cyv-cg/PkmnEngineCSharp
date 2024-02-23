using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleEvents;

using PkmnEngine.Strings;

using System.Collections.Generic;

namespace PkmnEngine {
	public static class SpeciesEffects {
		public static (BattleEvent callback, sbyte priority) gSpeciesEvents(Species species, Callback cb) {
			if (SpeciesEvents.ContainsKey(species) && SpeciesEvents[species].ContainsKey(cb)) {
				return SpeciesEvents[species][cb];
			}
			else {
				return (null, 0);
			}
		}

		// Lets give it up for static typing and the cursed syntax it leads to!!!
		// For real tho, this is *super* prone to logical errors.
		private static readonly Dictionary<Species, Dictionary<Callback, (BattleEvent callback, sbyte priority)>> SpeciesEvents = new() { 
		{
			Species.MINIOR_METEOR_FORM,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnTryAddNonVolatile,
				(Ability_Immunity_OnTryAddNonVolatile, 0)
			}}
		}
		
		};
	}
}