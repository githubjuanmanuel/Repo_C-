using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_2._0
{
    internal class Presupuesto
    {
        public string User { get; set; }
        public double PresupuestoPersona { get; set; }
        public Presupuesto(string user,double presupuestoPersona)
        {
            this.PresupuestoPersona = presupuestoPersona;
        }
    }
}
