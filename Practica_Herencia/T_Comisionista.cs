using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Herencia
{
    internal class T_Comisionista : Trabajador
    {
        private double Porcentaje_C = 0;
        private double Valor_Venta = 0;
        public T_Comisionista(string nombre, string apellido, string cedula, string direccion) : base(nombre, apellido, cedula, direccion)
        {
        }

        public void setPorcentaje (double porcentaje)
        {
            Porcentaje_C = porcentaje;
        }
        public void setValor_Venta(double valor_Venta)
        {
            Valor_Venta = valor_Venta;
        }
        public double getPorcentaje_C()
        {
            return Porcentaje_C;
        }
        public double getValor_Venta()
        {
            return Valor_Venta;
        }
        public void Hallar_Salario()
        {
            double comision = (Porcentaje_C * Valor_Venta) / (double)100;
            setSalario(comision);
        }
    }
}
