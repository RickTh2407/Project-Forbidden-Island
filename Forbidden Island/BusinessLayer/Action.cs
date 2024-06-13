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
        private ActionType ActionType { get; set; }

        public int DrainFlood(int actionCount)
        {
            actionCount -= 1;
            // Logic to turn flooded IslandTile to normal
            return actionCount;
        }

        public void CheckTreasureAmount()
        {
            // Implement logic to check treasure amount
        }

        public void ExecuteAction(Game game, ActionType actionType, object parameter = null)
        {
            switch (actionType)
            {
                case ActionType.Move:
                    var direction = (MoveDirection)parameter;
                    game.MovePlayer(direction);
                    break;
                case ActionType.DrainFlood:
                    game.ToggleDeflood();
                    break;
                case ActionType.CollectTreasure:
                    game.CurrentPlayer.CollectTreasure();
                    break;
                case ActionType.GiveTreasureCard:
                    var otherPlayer = (Player)parameter;
                    game.CurrentPlayer.GiveTreasureCard(otherPlayer);
                    break;
            }
        }
    }
}
