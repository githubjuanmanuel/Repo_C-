using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Herencia
{
    internal class T_Por_Horas : Trabajador
    {
        private double Valor_Hora = 0;
        private double Valor_Hora_Ex = 0;
        private double Num_Horas = 0;
        public T_Por_Horas(string nombre, string apellido, string cedula, string direccion) : base(nombre, apellido, cedula, direccion)
        {
        }

        public void setValor_Hora(double valor_hora)
        {
            Valor_Hora = valor_hora;
        }
        public void setValor_Hora_Ex(double valor_hora_ex)
        {
            Valor_Hora_Ex = valor_hora_ex;
        }
        public void setNum_Horas(double num_horas) 
        {
            Num_Horas = num_horas;        
        }
        public double getValor_Hora()
        {
            return Valor_Hora;
        }
        public double getValor_Hora_Ex()
        {
            return Valor_Hora_Ex;
        }
        public double getNum_Horas()
        {
            return Num_Horas;
        }

        public void Hallar_Salario()
        {
            double horas_Extra = 0;
            double salario_base = 0;
            double salario_extra = 0;
            double salario_total = 0;
            if (Num_Horas > 0 && Num_Horas <= 40)
            {
                salario_base = Num_Horas * Valor_Hora;
                salario_total = salario_base;
                setSalario(salario_total);
            }else if (Num_Horas > 0 && Num_Horas > 40)
            {
                horas_Extra = Num_Horas - 40;
                salario_base = 40 * Valor_Hora;
                salario_extra = horas_Extra* Valor_Hora_Ex;
                salario_total = salario_base + salario_extra;
                setSalario(salario_total);
            }
         
        }
    }
}
