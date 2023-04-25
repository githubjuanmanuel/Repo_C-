using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Herencia
{
    internal class T_Fijo : Trabajador
    {
        public T_Fijo(string nombre, string apellido, string cedula, string direccion) : base(nombre, apellido, cedula, direccion)
        {
        }


    }
}
