using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herramientas_II
{
    internal class Canon : Personaje
    {
       public Canon() { Velocidad = 10; }
        public Canon(int x, int y) : base(x,y,"Canon",72,30) { Velocidad = 10; }
        
        

        public override void MoveLeft()
        {
            Posx = Posx - Velocidad;
            SetPos(Posx, Posy);
        }
        public override void MoveRight()
        {
            Posx = Posx + Velocidad;
            SetPos(Posx, Posy);
        }

        

    }
}
