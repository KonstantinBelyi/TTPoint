
using TTPoint.Models.Player;

namespace TTPoint.Models.Game
{
    class PairGame : Game
    {
        public TtTeam Team1 { get; set; } = new TtTeam();
        public TtTeam Team2 { get; set; } = new TtTeam();
    }
}
