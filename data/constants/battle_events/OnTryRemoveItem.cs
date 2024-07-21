using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTryRemoveItemParams {
		public OnTryRemoveItemParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_StickyHold_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Mons with Sticky Hold can still have their item stolen if they are fainted.
			if (args.bm.HasStatus(Status.FAINTED)) {
				return true;
			}

			return false;
		}
		public static async Task<object> Ability_Multitype_OnTryRemoveItem(object p) {
			return false;
		}

		public static async Task<object> Item_GriseousOrb_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Griseous orb cannot be stolen from Giratina.
			if (args.bm.Species == Species.GIRATINA_ALTERED_FORME || args.bm.Species == Species.GIRATINA_ORIGIN_FORME) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Plate_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Plates cannot be stolen from Arceus.
			if (args.bm.Species == Species.ARCEUS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Drive_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Drives cannot be stolen from Genesect.
			if (args.bm.Species == Species.GENESECT) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Memory_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Memories cannot be stolen from Silvally.
			if (args.bm.Species == Species.SILVALLY) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_RustedSword_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Rusted Sword cannot be stolen from Zacian.
			if (args.bm.Species == Species.ZACIAN_CROWNED_SWORD || args.bm.Species == Species.ZACIAN_HERO_OF_MANY_BATTLES) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_RustedShield_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Rusted Shield cannot be stolen from Zamazenta.
			if (args.bm.Species == Species.ZAMAZENTA_CROWNED_SHIELD || args.bm.Species == Species.ZAMAZENTA_HERO_OF_MANY_BATTLES) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_BoosterEnergy_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			// Booster Energy cannot be stolen from paradox pokemon.
			switch (args.bm.Species) {
				case Species.GREAT_TUSK:
				case Species.SCREAM_TAIL:
				case Species.BRUTE_BONNET:
				case Species.FLUTTER_MANE:
				case Species.SLITHER_WING:
				case Species.SANDY_SHOCKS:
				case Species.ROARING_MOON:
				case Species.WALKING_WAKE:
				//case Species.GOUGING_FIRE:
				//case Species.RAGING_BOLT:
				case Species.IRON_TREADS:
				case Species.IRON_BUNDLE:
				case Species.IRON_HANDS:
				case Species.IRON_JUGULIS:
				case Species.IRON_MOTH:
				case Species.IRON_THORNS:
				case Species.IRON_VALIANT:
				case Species.IRON_LEAVES:
				//case Species.IRON_BOULDER:
				//case Species.IRON_CROWN:
					return false;
				default:
					return true;
			};
		}
		//public static async Task<object> Item_Mask_OnTryRemoveItem(object p) {
		//	OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

		//	// Masks cannot be stolen from Ogerpon.
		//	if (args.bm.Species == Species.OGERPON) {
		//		return false;
		//	}

		//	return true;
		//}
		#region Mega Stones
		public static async Task<object> Item_Gengarite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GENGAR || args.bm.Species == Species.GENGAR_MEGA_GENGAR) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Gardevoirite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GARDEVOIR || args.bm.Species == Species.GARDEVOIR_MEGA_GARDEVOIR) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Ampharosite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.AMPHAROS || args.bm.Species == Species.AMPHAROS_MEGA_AMPHAROS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Venusaurite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.VENUSAUR || args.bm.Species == Species.VENUSAUR_MEGA_VENUSAUR) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_CharizarditeX_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.CHARIZARD || args.bm.Species == Species.CHARIZARD_MEGA_CHARIZARD_X) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Blastoisinite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.BLASTOISE || args.bm.Species == Species.BLASTOISE_MEGA_BLASTOISE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_MewtwoniteX_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.MEWTWO || args.bm.Species == Species.MEWTWO_MEGA_MEWTWO_X) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_MewtwoniteY_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.MEWTWO || args.bm.Species == Species.MEWTWO_MEGA_MEWTWO_Y) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Blazikenite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.BLAZIKEN || args.bm.Species == Species.BLAZIKEN_MEGA_BLAZIKEN) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Medichamite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.MEDICHAM || args.bm.Species == Species.MEDICHAM_MEGA_MEDICHAM) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Houndoominite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.HOUNDOOM || args.bm.Species == Species.HOUNDOOM_MEGA_HOUNDOOM) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Aggronite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.AGGRON || args.bm.Species == Species.AGGRON_MEGA_AGGRON) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Banettite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.BANETTE || args.bm.Species == Species.BANETTE_MEGA_BANETTE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Tyranitarite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.TYRANITAR || args.bm.Species == Species.TYRANITAR_MEGA_TYRANITAR) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Scizorite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SCIZOR || args.bm.Species == Species.SCIZOR_MEGA_SCIZOR) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Pinsirite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.PINSIR || args.bm.Species == Species.PINSIR_MEGA_PINSIR) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Aerodactylite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.AERODACTYL || args.bm.Species == Species.AERODACTYL_MEGA_AERODACTYL) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Lucarionite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.LUCARIO || args.bm.Species == Species.LUCARIO_MEGA_LUCARIO) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Abomasite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.ABOMASNOW || args.bm.Species == Species.ABOMASNOW_MEGA_ABOMASNOW) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Kangaskhanite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.KANGASKHAN || args.bm.Species == Species.KANGASKHAN_MEGA_KANGASKHAN) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Gyaradosite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GYARADOS || args.bm.Species == Species.GYARADOS_MEGA_GYARADOS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Absolite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.ABSOL || args.bm.Species == Species.ABSOL_MEGA_ABSOL) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_CharizarditeY_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.CHARIZARD || args.bm.Species == Species.CHARIZARD_MEGA_CHARIZARD_Y) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Alakazite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.ALAKAZAM || args.bm.Species == Species.ALAKAZAM_MEGA_ALAKAZAM) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Heracronite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.HERACROSS || args.bm.Species == Species.HERACROSS_MEGA_HERACROSS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Mawilite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.MAWILE || args.bm.Species == Species.MAWILE_MEGA_MAWILE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Manectite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.MANECTRIC || args.bm.Species == Species.MANECTRIC_MEGA_MANECTRIC) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Garchompite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GARCHOMP || args.bm.Species == Species.GARCHOMP_MEGA_GARCHOMP) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Latiasite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.LATIAS || args.bm.Species == Species.LATIAS_MEGA_LATIAS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Latiosite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.LATIOS || args.bm.Species == Species.LATIOS_MEGA_LATIOS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Swampertite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SWAMPERT || args.bm.Species == Species.SWAMPERT_MEGA_SWAMPERT) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Sceptilite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SCEPTILE || args.bm.Species == Species.SCEPTILE_MEGA_SCEPTILE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Sablenite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SABLEYE || args.bm.Species == Species.SABLEYE_MEGA_SABLEYE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Altarianite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.ALTARIA || args.bm.Species == Species.ALTARIA_MEGA_ALTARIA) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Galladite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GALLADE || args.bm.Species == Species.GALLADE_MEGA_GALLADE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Audinite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.AUDINO || args.bm.Species == Species.AUDINO_MEGA_AUDINO) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Metagrossite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.METAGROSS || args.bm.Species == Species.METAGROSS_MEGA_METAGROSS) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Sharpedonite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SHARPEDO || args.bm.Species == Species.SHARPEDO_MEGA_SHARPEDO) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Slowbronite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SLOWBRO || args.bm.Species == Species.SLOWBRO_MEGA_SLOWBRO) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Steelixite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.STEELIX || args.bm.Species == Species.STEELIX_MEGA_STEELIX) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Pidgeotite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.PIDGEOT || args.bm.Species == Species.PIDGEOT_MEGA_PIDGEOT) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Glalitite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GLALIE || args.bm.Species == Species.GLALIE_MEGA_GLALIE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Diancite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.DIANCIE || args.bm.Species == Species.DIANCIE_MEGA_DIANCIE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Cameruptite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.CAMERUPT || args.bm.Species == Species.CAMERUPT_MEGA_CAMERUPT) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Lopunnite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.LOPUNNY || args.bm.Species == Species.LOPUNNY_MEGA_LOPUNNY) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Salamencite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.SALAMENCE || args.bm.Species == Species.SALAMENCE_MEGA_SALAMENCE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_Beedrillite_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.BEEDRILL || args.bm.Species == Species.BEEDRILL_MEGA_BEEDRILL) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_RedOrb_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.GROUDON || args.bm.Species == Species.GROUDON_PRIMAL_GROUDON) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_BlueOrb_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.KYOGRE || args.bm.Species == Species.KYOGRE_PRIMAL_KYOGRE) {
				return false;
			}

			return true;
		}
		public static async Task<object> Item_JadeOrb_OnTryRemoveItem(object p) {
			OnTryRemoveItemParams args = ValidateParams<OnTryRemoveItemParams>(p);

			if (args.bm.Species == Species.RAYQUAZA || args.bm.Species == Species.RAYQUAZA_MEGA_RAYQUAZA) {
				return false;
			}

			return true;
		}
		#endregion
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}