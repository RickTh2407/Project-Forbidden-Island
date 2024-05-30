using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Action
    {
        private MoveDirection MoveDirection { get; set; }
        private int ActionCount { get; set; } = 3;

        public int DrainFlood(int actionCount)
        {
            actionCount = ActionCount;

            //Code where flooded Islandtile turns to normal
            actionCount = actionCount - 1;
            return actionCount;
        }
        public void CheckTreasureAmount()
        {

        }
    }
}
