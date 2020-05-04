
using TTPoint.Models.Player;

namespace TTPoint.Models.Game
{
    class SingleGame : Game
    {
        public TtPlayer Player_1 { get; set; } = new TtPlayer();
        public TtPlayer Player_2 { get; set; } = new TtPlayer();
    }
}
