using System;
using System.Collections.Generic;
using System.Text;

namespace TTPoint.Models
{
    class Game
    {
        public Player Player_1 { get; set; } = new Player();
        public Player Player_2 { get; set; } = new Player();
        public DateTime Date { get; set; } = DateTime.Now.Date;
    }
}
