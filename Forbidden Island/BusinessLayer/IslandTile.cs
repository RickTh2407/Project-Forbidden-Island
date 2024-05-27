using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class IslandTile
    {
        //24 tiles from database
        private List<IslandTile> NIslandCollection { get; set; }
        //2 sandbag tiles from database
        private List<IslandTile> SIslandCollection { get; set; }
        //3 heli-extraction tiles from database
        private List<IslandTile> HIslandCollection { get; set; }
        //5 treasure tiles 
        private List<IslandTile> TIslandCollection { get; set; }
        //database
        private int IslandId { get; set; }
        private string IslandName { get; set; }
        private string IslandType { get; set; }
        //not database
        private int IslandPosition { get; set; }
        private bool Flooded { get; set; } = false;

        public void TurnFlooded(bool flooded)
        {
            Flooded = flooded;
        }
    }
}
