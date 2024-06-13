using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Game
    {
        private Board Board { get; set; }

        public Game()
        {
            Board = new Board();
        }

        public void SetupGame(List<string> playerNames)
        {
            Board.SetupBoard(playerNames);
        }
    }
}