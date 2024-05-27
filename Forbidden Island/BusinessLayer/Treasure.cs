using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Treasure
    {
        private List<Treasure> TreasureCollection { get; set; }
        private bool TreasureCollected { get; set; } = false;
        //database
        private int TreasureId { get; set; }
        private string TreasureType { get; set; }
    }
}
