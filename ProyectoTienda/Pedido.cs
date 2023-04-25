using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda
{
    internal class Pedido
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string Cliente { get; set; }
        public double Total { get; set; }

        public Pedido(string nombre, int cantidad, double precio, string cliente)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Cliente = cliente;
            this.Total = 0;
        }
    }
}
