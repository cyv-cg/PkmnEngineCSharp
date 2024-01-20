using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;

namespace PkmnEngine.BattleControllers {
	public interface IBattleController {
		public Task<u64> HandleInputChooseAction(Battle battle, BattleState state, u8 slot);
		public Task<u64> MenuSelectSwitchToMon(Battle battle, BattleState state, u8 slot);
		public Task<u64>  MenuSelectUseMove(Battle battle, BattleState state, u8 slot);
	}
}