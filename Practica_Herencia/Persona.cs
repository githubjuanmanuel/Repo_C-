using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Herencia
{
    abstract internal class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Cedula;
        private string Direccion;
        

        public Persona(string nombre, string apellido, string cedula, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Direccion = direccion;
        } 

       
        public string getNombre()
        {
            return Nombre;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public string getCedula()
        {
            return Cedula; 
        }
        public string getDireccion()
        {
            return Direccion;
        }
    }
}
