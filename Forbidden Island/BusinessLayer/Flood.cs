using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Flood
    {
        //24 flood cards from database
        private List<Flood> FloodCard { get; set; }
        //3 "The water rises!" cards
        private List<Flood> WaterRises { get; set; }
    }
}
