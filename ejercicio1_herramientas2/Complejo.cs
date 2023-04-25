using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_herramientas2
{
    internal class Complejo
    {
        //Se declaran las variables
        double num1;
        double num2;

        //Constructor por defecto que inicializa las variables en 0
        public Complejo()
        {
            num1= 0;
            num2= 0;
        }
        //Constructor para darle el valor que llega a las variables 
        public Complejo(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double getNum1() { return num1; }
        public double getNum2() { return num2; }

        //Metodos sumar, restar, multiplicar y dividir
        public string sumar(Complejo num1,Complejo num2)
        {
            //Se inicializan las variables
            double sum1 = 0;
            double sum2 = 0;
            string numfinal = "";

            //Suma para hayar los resultados
            sum1 = num1.num1 + num2.num1;
            sum2 = num2.num2 + num1.num2;

            //Validacion en caso de numero negativo
            if (sum2 < 0)
            {
                numfinal = sum1.ToString() + sum2.ToString() + "i";
            }
            else
            {
                numfinal = sum1.ToString() + "+" + sum2.ToString() + "i";
            }
            

            return numfinal;    
        }
        public string restar(Complejo num1, Complejo num2)
        {
            //Se inicializan las variables
            double resta1 = 0;
            double resta2 = 0;
            string numFinal = "";

            //Resta para hayar los resultador
            resta1 = num1.num1 - num2.num1;
            resta2 = num1.num2 - num2.num2;

            //Validacion en caso de numero negativo
            if (resta2 < 0)
            {
                numFinal = resta1.ToString() + resta2.ToString() + "i";
            }
            else
            {
                numFinal = resta1.ToString() +"+"+ resta2.ToString() + "i";
            }
            return numFinal;
        }
        public string multiplicar(Complejo num1, Complejo num2)
        {
            //Se inicializan las variables
            double multi1 = 0;
            double multi2 = 0;
            double multi3 = 0;
            double multi4 = 0;
            double suma1 = 0;
            double suma2 = 0;
            string numFinal = "";

            //Los procesos de multiplicación y suma para hayar los resultados
            multi1= num1.num1 * num2.num1;
            multi2= num1.num1 * num2.num2;
            multi3 = num1.num2 * num2.num1;
            multi4 = num1.num2 * num2.num2;
            suma1 = multi1 + (multi4 * (-1));
            suma2 = multi2 + multi3;

            //Validacion en caso de numero negativo
            if (suma2 < 0)
            {
                numFinal = suma1.ToString() + suma2.ToString() + "i";
            }
            else
            {
                numFinal = suma1.ToString() + "+" + suma2.ToString() + "i";
            }
            
            return numFinal;
        }

        public string dividir(Complejo num1, Complejo num2)
        {
            //Se inicializan las variables
            double multi1 = 0;
            double multi2 = 0;
            double multi3 = 0;
            double multi4 = 0;
            double suma1 = 0;
            double suma2 = 0;
            double suma3 = 0;
            string numFinal = "";

            //Los procesos de multiplicación y suma para hayar los diferentes resultados
            multi1 = num1.num1 * num2.num1;
            multi2 = num1.num1 * (num2.num2*(-1));
            multi3 = num1.num2 * num2.num1;
            multi4 = num1.num2 * (num2.num2 * (-1));

            suma1 = multi1 + (multi4 * (-1));
            suma2 = multi2 + multi3;
            suma3 = (num2.num1* num2.num1) - (num2.num2 * num2.num2)*(-1);
            //Se crean 2 objetos para poder crear las fracciones 
            Complejo complejo1 = new Complejo(suma1,suma3);
            Complejo complejo2 = new Complejo(suma2,suma3);
            
            //Validacion en caso de numero negativo
            if (suma3 < 0 || suma2 < 0)
            {
                //Se hayan y simplifican las fraccion, al final queda el resultado final
                numFinal = "(" + Simplificar(complejo1).num1.ToString() + " / " + Simplificar(complejo1).num2.ToString() + ")" + "-" + "(" + Simplificar(complejo2).num1.ToString() + " / " + Simplificar(complejo2).num2.ToString() + ")" + "i";
            }
            else
            {
                numFinal = "("+Simplificar(complejo1).num1.ToString() + " / " + Simplificar(complejo1).num2.ToString()+")" +"+"+ "(" + Simplificar(complejo2).num1.ToString() + " / " + Simplificar(complejo2).num2.ToString()+")"+"i";
            }
            
            return numFinal;
        }
        //Funciones

        //Funcion para simplificar
        Complejo Simplificar(Complejo numero)
        {
            //Se llama a la funcion CalcularMCD para el máximo comun divisor
            double mcd = CalcularMCD(numero.num1, numero.num2);
            
            //Se simplifican los numeros
            numero.num1 /= mcd;
            numero.num2 /= mcd;

            //Validacion en caso de numero negativo
            if (numero.num1 < 0)
            {
                numero.num1 *= (-1);
            }
            else if (numero.num2 <0)
            {
                numero.num2 *= (-1);
            }

            return numero;
        }
        //Funcion para calcular el máximo comun divisor
        double CalcularMCD(double numero1, double numero2)
        {
            double resultado;
            double a = Math.Max(numero1, numero2);
            double b = Math.Min(numero1, numero2);
            do //ciclo para las iteraciones
            {
                resultado = b;  // Guardamos el divisor en el resultado
                b = a % b;      //Guardamos el resto en el divisor
                a = resultado;  //El divisor para al dividendo
            }
            while
            (b != 0);
            return resultado;
        }

    }
}
