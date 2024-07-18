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
		}

		
		};
	}
}