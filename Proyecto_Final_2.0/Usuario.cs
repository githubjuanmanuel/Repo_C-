using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_2._0
{
    public class Usuario
    {
        public string User { get; set; }
        public string Password { get; set; }
        public double Presupuesto { get; set; }

        public Usuario(string user, string password, double presupuesto)
        {
            this.User = user;
            this.Password = password;
            this.Presupuesto = presupuesto;
        }
    }
}
