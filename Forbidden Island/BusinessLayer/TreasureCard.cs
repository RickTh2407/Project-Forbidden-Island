using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class TreasureCard
    {
        private List<TreasureCard> CardCollection {get;set;}
        private Treasure Treasure { get; set; }
        //database
        private int TreasureCardId { get; set; }
        private string TreasureCardType { get; set; }
        
    }
}
