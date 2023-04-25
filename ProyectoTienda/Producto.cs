using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
       public string Sucursal { get; set; }

        public Producto(string _nombre, int _cantidad, double _precio, string sucursal)
        {
            this.Nombre = _nombre;
            this.Cantidad = _cantidad;
            this.Precio = _precio;
            this.Sucursal = sucursal;
        }

        
    }
}
