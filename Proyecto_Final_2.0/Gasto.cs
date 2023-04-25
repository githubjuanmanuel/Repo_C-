using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_2._0
{
    internal class Gasto
    {
        public string Usuario { get; set; }
        public double CantidadGasto { get; set; }
        
        public Gasto(string usuario_,double gasto_)
        {
            this.Usuario = usuario_;
            this.CantidadGasto = gasto_;
            
        }
    }
}
