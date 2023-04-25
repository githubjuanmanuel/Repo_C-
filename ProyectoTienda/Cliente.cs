using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda
{
    internal class Cliente
    {
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombreCliente, string direccion, string telefono)
        {
            this.NombreCliente = nombreCliente;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
