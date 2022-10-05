using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ebenal
{

    enum DeskMaterials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }

    internal class Desk
    {
        public readonly int maxWidth = 96;
        public readonly int minWidth = 24;
        public readonly int maxDepth = 48;
        public readonly int minDepth = 12;
    }
}
