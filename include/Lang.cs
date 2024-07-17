using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System;

using static PkmnEngine.Global;

namespace PkmnEngine.Strings {
	public static class Lang {
		public static string GetMonName(Species speciesID) {
			StringResource.Namespace strings = StringResource.Namespace.SPECIES;
			return GetString(strings, GetStringResourceWithKey(strings, speciesID.ToString()));
		}
		public static string GetMoveName(BattleMoveID moveID) {
			StringResource.Namespace strings = StringResource.Namespace.MOVE;
			return GetString(strings, GetStringResourceWithKey(strings, moveID.ToString()));
		}
		public static string GetAbilityName(Ability abilityID) {
			StringResource.Namespace strings = StringResource.Namespace.ABILITY;
			return GetString(strings, GetStringResourceWithKey(strings, abilityID.ToString()));
		}
		public static string GetStatName(Stat statID) {
			StringResource.Namespace strings = StringResource.Namespace.STAT;
			return GetString(strings, GetStringResourceWithKey(strings, statID.ToString()));
		}
		public static string GetTypeName(Type typeID) {
			StringResource.Namespace strings = StringResource.Namespace.TYPE;
			return GetString(strings, GetStringResourceWithKey(strings, typeID.ToString()));
		}
		public static string GetItemName(Item itemID) {
			StringResource.Namespace strings = StringResource.Namespace.ITEM;
			return GetString(strings, GetStringResourceWithKey(strings, itemID.ToString()));
		}

		/// <summary>
		/// Gets the text of a string resource in the default language.
		/// </summary>
		/// <param name="@namespace">Family of the string resource to fetch</param>
		/// <param name="@string">Resource of the desired text</param>
		/// <param name="values">Text used to replace mnemonics, if applicable</param>
		/// <returns>Translated string of the provided resource, with placeholder values fileld in.</returns>
		public static string GetString(StringResource.Namespace @namespace, StringResource @string, params string[] values) {
			if (values.Length > @string.NumParams) {
				throw new ArgumentException($"{values.Length} values provided, but only {@string.NumParams} are accepted.");
			}
			else if (values.Length < @string.NumParams) {
				throw new ArgumentException($"{values.Length} values provided, but {@string.NumParams} are required.");
			}

			string resource = @namespace switch {
				StringResource.Namespace.BATTLE_COMMON	=> BATTLE_COMMON	.resources[@string][gSaveBlock.language],
				StringResource.Namespace.STAT			=> STAT_NAMES		.resources[@string][gSaveBlock.language],
				StringResource.Namespace.ABILITY		=> ABILITY_NAMES	.resources[@string][gSaveBlock.language],
				StringResource.Namespace.ITEM			=> ITEM_NAMES		.resources[@string][gSaveBlock.language],
				StringResource.Namespace.MOVE			=> MOVE_NAMES		.resources[@string][gSaveBlock.language],
				StringResource.Namespace.SPECIES		=> SPECIES_NAMES	.resources[@string][gSaveBlock.language],
				StringResource.Namespace.TYPE			=> TYPE_NAMES		.resources[@string][gSaveBlock.language],
				_ => throw new ArgumentException($"String namespace '{@namespace}' not recognized")
			};

			for (u8 i = 0; i < values.Length; i++) {
				ReplaceMnemonic(ref resource, (u8)(i + 1), values[i]);
			}

			return resource;
		}
		/// <summary>
		/// Gets the text of a string resource in the given language.
		/// </summary>
		/// <param name="@namespace">Family of the string resource to fetch</param>
		/// <param name="@string">Resource of the desired text</param>
		/// <param name="languageOverride">Language to use instead of the default</param>
		/// <param name="values">Text used to replace mnemonics, if applicable</param>
		/// <returns>Translated string of the provided resource, with placeholder values fileld in.</returns>
		public static string GetString(StringResource.Namespace @namespace, StringResource @string, Language languageOverride, params string[] values) {
			if (values.Length > @string.NumParams) {
				throw new ArgumentException($"{values.Length} values provided, but only {@string.NumParams} are accepted.");
			}
			else if (values.Length < @string.NumParams) {
				throw new ArgumentException($"{values.Length} values provided, but {@string.NumParams} are required.");
			}

			string resource = @namespace switch {
				StringResource.Namespace.BATTLE_COMMON	=> BATTLE_COMMON	.resources[@string][languageOverride],
				StringResource.Namespace.STAT			=> STAT_NAMES		.resources[@string][languageOverride],
				StringResource.Namespace.ABILITY		=> ABILITY_NAMES	.resources[@string][languageOverride],
				StringResource.Namespace.ITEM			=> ITEM_NAMES		.resources[@string][languageOverride],
				StringResource.Namespace.MOVE			=> MOVE_NAMES		.resources[@string][languageOverride],
				StringResource.Namespace.SPECIES		=> SPECIES_NAMES	.resources[@string][languageOverride],
				StringResource.Namespace.TYPE			=> TYPE_NAMES		.resources[@string][languageOverride],
				_ => throw new ArgumentException($"String namespace '{@namespace}' not recognized")
			};

			for (u8 i = 0; i < values.Length; i++) {
				ReplaceMnemonic(ref resource, (u8)(i + 1), values[i]);
			}

			return resource;
		}

		/// <summary>
		/// Searches string namespace for a resource with the provided key.
		/// </summary>
		public static StringResource GetStringResourceWithKey(StringResource.Namespace @namespace, string key) {
			switch (@namespace) {
				case StringResource.Namespace.BATTLE_COMMON:
					foreach (StringResource resource in BATTLE_COMMON.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
				case StringResource.Namespace.STAT:
					foreach (StringResource resource in STAT_NAMES.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
				case StringResource.Namespace.ABILITY:
					foreach (StringResource resource in ABILITY_NAMES.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
				case StringResource.Namespace.ITEM:
					foreach (StringResource resource in ITEM_NAMES.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
				case StringResource.Namespace.MOVE:
					foreach (StringResource resource in MOVE_NAMES.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
				case StringResource.Namespace.SPECIES:
					foreach (StringResource resource in SPECIES_NAMES.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
				case StringResource.Namespace.TYPE:
					foreach (StringResource resource in TYPE_NAMES.resources.Keys) {
						if (resource.Key == key) {
							return resource;
						}
					}
					break;
			}

			throw new Exception($"No string with key '{key}' was found.");
		}

		/// <summary>
		/// Replaces a placeholder string value with real value.
		/// </summary>
		/// <param name="resource">Text containing the placeholder</param>
		/// <param name="n">Number of the placeholder within the string</param>
		/// <param name="value">String to insert</param>
		private static void ReplaceMnemonic(ref string resource, u8 n, string value) {
			resource = resource.Replace($"{{{n}}}", value);
		}
	}
}