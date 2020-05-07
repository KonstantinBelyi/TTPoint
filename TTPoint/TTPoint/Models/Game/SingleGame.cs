
using TTPoint.Models.Player;

namespace TTPoint.Models.Game
{
    class SingleGame : Game
    {
        public TtPlayer Player1 { get; set; } = new TtPlayer();
        public TtPlayer Player2 { get; set; } = new TtPlayer();
    }
}
