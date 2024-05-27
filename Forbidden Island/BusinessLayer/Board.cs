using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Board
    {
        private int Difficulty { get; set; }
        private int Floodmeter { get; set; } = 0;
        private Random Random { get; set; }
        private IslandTile IslandTile { get; set; }
        private TreasureCard TreasureCard { get; set; }
        private Treasure Treasure { get; set; }

        
        public void SetupGame()
        {

        }
        public void MeterFunction()
        {

        }
    }
}
