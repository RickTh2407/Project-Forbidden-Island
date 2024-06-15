using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class IslandTile
    {
        private int IslandId { get; set; }
        private string Name { get; set; }
        private string Type { get; set; }
        private bool Flooded { get; set; } = false;
        private bool Disappeared { get; set; } = false;
        private int Position { get; set; }

        public void Flood()
        {
            Flooded = true;
        }

        public void DryUp()
        {
            if (Flooded)
            {
                Flooded = false;
            }
        }

        public void IsVanished()
        {
            if (Flooded)
            {
                Disappeared = true;
            }
        }
    }
}