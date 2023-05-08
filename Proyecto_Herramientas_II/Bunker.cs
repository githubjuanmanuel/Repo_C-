using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herramientas_II
{
    internal class Bunker : Objeto_Grafico
    {
        //int integridad = 6;
        public Bunker() { }
        public Bunker(int x, int y) : base(x, y, "Bunker1", 78, 50) { }
    }
}
