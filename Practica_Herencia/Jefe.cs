using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Herencia
{
    internal class Jefe : Persona
    {
        private double Salario = 0;
        public Jefe(string nombre, string apellido, string cedula, string direccion) : base(nombre, apellido, cedula, direccion)
        {
        }
        public virtual void setSalario(double salario)
        {
            Salario = salario;
        }
        public double getSalario()
        {
            return Salario;
        }
    }
}
