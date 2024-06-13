using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Player
    {
        private string Name { get; set; }
        private List<TreasureCard> Inventory { get;  set; }
        private int ActionCount { get; set; }
        private Role Role { get; set; }
        private int Position { get; set; }
        private bool Active { get; set; }

        public Player(string name)
        {
            Name = name;
            Inventory = new List<TreasureCard>();
            ActionCount = 3;
            Active = true;
        }

        public void Move(MoveDirection direction, Board board)
        {
            // Implement move logic based on player's role and direction
            // Ensure moves adhere to game rules (e.g., no movement to flooded/vanished tiles)
        }

        public void CollectTreasure()
        {
            // Implement logic to collect treasure
        }

        public void GiveTreasureCard(Player otherPlayer)
        {
            // Implement logic to give treasure card to another player
        }

        public void DrawInitialTreasureCards()
        {
            // Implement logic to draw initial treasure cards
        }

        public bool CanCollectTreasure(Board board)
        {
            // Implement logic to check if player can collect treasure
            return false;
        }

        public bool CanGiveTreasureCard(Player recipient)
        {
            // Implement logic to check if player can give treasure card
            return false;
        }
    }
}
