using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herramientas_II
{
    internal class Personaje : Objeto_Grafico
    {
        int velocidad;
        

        public Personaje() 
        {
            Velocidad = 5;
        }
        public Personaje(int x, int y, string nombre, int w, int h)
            : base(x, y, nombre, w, h)
        {
            velocidad = 5;
        }

        public int Velocidad { get => velocidad; set => velocidad = value; }

        public virtual void Disparar() { }
        
    }
}
