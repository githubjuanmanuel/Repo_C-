using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Herencia
{
    internal class Trabajador : Persona
    {
        private string Nombre_Jefe = "";
        private double Salario = 0;
        public Trabajador(string nombre, string apellido, string cedula, string direccion) : base(nombre, apellido, cedula, direccion)
        {
        }
        
        public void setNombre_Jefe(string nombre)
        {
            Nombre_Jefe = nombre;
        }
        public string getNombre_Jefe()
        {
            return Nombre_Jefe;
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
