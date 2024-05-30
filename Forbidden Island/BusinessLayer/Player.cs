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
        //private List<Player> PlayerColour { get; set; }
        private List<Player> RedInventory { get; set; }
        private List<Player> BlueInventory { get; set; }
        private List<Player> YellowInventory { get; set; }
        private List<Player> GreenInventory { get; set; }
        private Action Action { get; set; }
        //database
        private int Role { get; set; }
        private int Position { get; set; }
        private bool Active { get; set; }
        
        public void CollectTreasure()
        {

        }
        public void GiveTCard()
        {

        }
    }
}
