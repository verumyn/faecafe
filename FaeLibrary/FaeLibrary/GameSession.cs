using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeLibrary
{
    internal class GameSession
    {
        Player CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Sue";
            CurrentPlayer.Gold = 10000;
        }
    }
}
