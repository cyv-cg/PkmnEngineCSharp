using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleEvents;

using PkmnEngine.Strings;

using System.Collections.Generic;

namespace PkmnEngine {
	public static class ItemEffects {
		public static (BattleEvent callback, sbyte priority) gItemEvents(Item item, Callback cb) {
			if (ItemEvents.ContainsKey(item) && ItemEvents[item].ContainsKey(cb)) {
				return ItemEvents[item][cb];
			}
			else {
				return (null, 0);
			}
		}

		// Lets give it up for static typing and the cursed syntax it leads to!!!
		// For real tho, this is *super* prone to logical errors.
		private static readonly Dictionary<Item, Dictionary<Callback, (BattleEvent callback, sbyte priority)>> ItemEvents = new() { {
		
			Item.SAFETY_GOGGLES,
			new Dictionary<Callback, (BattleEvent, sbyte)>() {
				{
					Callback.OnCheckIsDamagedByHail,
					(Item_SafetyGoggles_OnCheckIsDamagedByHail, 0)
				},
				{
					Callback.OnCheckIsDamagedBySandstorm,
					(Item_SafetyGoggles_OnCheckIsDamagedBySandstorm, 0)
				}
			}
		},
		{
			Item.AIR_BALLOON,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsUngrounded,
				(Item_AirBalloon_OnCheckIsUngrounded, 0)
			}}
		},
		{
			Item.IRON_BALL,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {{
				Callback.OnCheckIsGrounded,
				(Item_IronBall_OnCheckIsGrounded, 0)
			}}
		},
		{
			Item.GRISEOUS_ORB,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_GriseousOrb_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.RUSTED_SWORD,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_RustedSword_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.RUSTED_SHIELD,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_RustedShield_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BOOSTER_ENERGY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_BoosterEnergy_OnTryRemoveItem, 0)
				}
			}
		},
		#region Memories, Plates, Drives, Mega Stones 
		{
			Item.BUG_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ICE_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.DARK_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.FIRE_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ROCK_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.FAIRY_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GHOST_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GRASS_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.STEEL_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.WATER_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.DRAGON_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.FLYING_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GROUND_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.POISON_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.PSYCHIC_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ELECTRIC_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.FIGHTING_MEMORY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Memory_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SKY_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ZAP_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.FIST_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.IRON_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MIND_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.PIXIE_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BLANK_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.DRACO_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.DREAD_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.EARTH_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.FLAME_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.STONE_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.TOXIC_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ICICLE_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.INSECT_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.LEGEND_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MEADOW_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SPLASH_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SPOOKY_PLATE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Plate_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BURN_DRIVE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Drive_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.DOUSE_DRIVE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Drive_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.CHILL_DRIVE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Drive_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SHOCK_DRIVE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Drive_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GENGARITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Gengarite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GARDEVOIRITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Gardevoirite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.AMPHAROSITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Ampharosite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.VENUSAURITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Venusaurite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.CHARIZARDITE_X,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_CharizarditeX_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BLASTOISINITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Blastoisinite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MEWTWONITE_X,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_MewtwoniteX_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MEWTWONITE_Y,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_MewtwoniteY_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BLAZIKENITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Blazikenite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MEDICHAMITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Medichamite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.HOUNDOOMINITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Houndoominite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.AGGRONITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Aggronite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BANETTITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Banettite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.TYRANITARITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Tyranitarite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SCIZORITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Scizorite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.PINSIRITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Pinsirite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.AERODACTYLITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Aerodactylite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.LUCARIONITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Lucarionite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ABOMASITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Abomasite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.KANGASKHANITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Kangaskhanite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GYARADOSITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Gyaradosite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ABSOLITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Absolite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.CHARIZARDITE_Y,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_CharizarditeY_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ALAKAZITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Alakazite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.HERACRONITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Heracronite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MAWILITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Mawilite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.MANECTITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Manectite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GARCHOMPITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Garchompite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.LATIASITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Latiasite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.LATIOSITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Latiosite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SWAMPERTITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Swampertite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SCEPTILITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Sceptilite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SABLENITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Sablenite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.ALTARIANITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Altarianite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GALLADITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Galladite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.AUDINITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Audinite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.METAGROSSITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Metagrossite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SHARPEDONITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Sharpedonite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SLOWBRONITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Slowbronite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.STEELIXITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Steelixite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.PIDGEOTITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Pidgeotite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.GLALITITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Glalitite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.DIANCITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Diancite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.CAMERUPTITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Cameruptite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.LOPUNNITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Lopunnite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.SALAMENCITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Salamencite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BEEDRILLITE,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_Beedrillite_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.RED_ORB,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_RedOrb_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.BLUE_ORB,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_BlueOrb_OnTryRemoveItem, 0)
				}
			}
		},
		{
			Item.JADE_ORB,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.OnTryRemoveItem,
					(Item_JadeOrb_OnTryRemoveItem, 0)
				}
			}
		}
		#endregion

		
		};
	}
}