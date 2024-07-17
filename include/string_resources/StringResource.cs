using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine.Strings {
	public class StringResource {
		public StringResource(string key, u8 numParams) {
			Key = key;
			NumParams = numParams;
		}

		public string Key { get; private set; }
		public u8 NumParams { get; private set; }
		
		public enum Namespace {
			BATTLE_COMMON,
			STAT,
			ABILITY,
			ITEM,
			MOVE,
			TYPE,
			SPECIES
		}
	}

}