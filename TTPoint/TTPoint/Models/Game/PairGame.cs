
using TTPoint.Models.Player;

namespace TTPoint.Models.Game
{
    class PairGame : Game
    {
        public TtCommand Command_1 { get; set; } = new TtCommand();
        public TtCommand Command_2 { get; set; } = new TtCommand();
    }
}
