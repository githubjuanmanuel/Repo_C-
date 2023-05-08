using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herramientas_II
{
    internal class Alienigena : Personaje
    {
        public Alienigena() { }
        public Alienigena(int x, int y) : base(x,y,"alien1",50,50) { }

        public override void MoveRight()
        {
            Posx += Velocidad;
            SetPos(Posx, Posy);
            MoveLeft();
        }
        public override void MoveLeft()
        {
            Posx -= Velocidad;
            SetPos(Posx, Posy);
            
        }
        public void MoveDown()
        {
            Posy += Velocidad;
            MoveRight();
        }
        

    }
}
