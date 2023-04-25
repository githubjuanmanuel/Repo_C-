using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda
{
    internal class Trabajador
    {
        public string Roll { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string sucursal { get; set; }

        public Trabajador(string roll, string nombre, string usuario, string contrasena, string sucursal)
        {
            this.Roll = roll;
            this.Nombre = nombre;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
            this.sucursal = sucursal;
        }

        
    }
}
