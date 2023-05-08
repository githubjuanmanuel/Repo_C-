using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herramientas_II
{
    internal class Laser : Objeto_Grafico
    {
        public Laser() { }
        public Laser(int x, int y) : base(x,y,"Laser",10,30){ }

        public void MoveUp()
        {
            do
            {
                Posy -= 12;
            } while (Posy!=0);
        }
    }
}
