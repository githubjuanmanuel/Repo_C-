
using ejercicio1_herramientas2;
using System;   

//Se declaran las variables
double num1 = 0;
double num2 = 0;
double num3 = 0;
double num4 = 0;
int respuesta = 0;

//Se asignan los valores de las variables
Console.WriteLine("Hola");
Console.WriteLine("Ingresa el primer numero real");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el primer numero imaginario");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el segundo numero real");
num3 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el segundo numero imaginario \n");
num4 = double.Parse(Console.ReadLine());

//Se muestran los 2 números complejos
Console.WriteLine("Los numeros son complejos son: \n"+ num1+"+"+ num2+"i");
Console.WriteLine(num3+ "+"+ num4+ "i \n");

//Se crean 2 objetos cada uno conforma un número complejos
Complejo PrimerNum = new Complejo(num1, num2);

Complejo SegundoNum = new Complejo(num3, num4);

//Menu de acciones
Console.WriteLine("Deseas\n"+" Suma = 0\n"+ " Resta = 1\n" + " Multiplicar = 2\n"+ " Dividir = 3\n"+ "salir = 4\n");
respuesta = int.Parse(Console.ReadLine());

//ciclo para realizar acciones con el número
do
{
    //Los posibles casos para realiza con los números, en base a la respuesta
    switch (respuesta)
    {
        case 0:
            //Caso suma
            Console.WriteLine("\nEl resultado de la suma es: " + PrimerNum.sumar(PrimerNum, SegundoNum));
            break;
        case 1:
            //Caso resta
            Console.WriteLine("\nEl resultado de la resta es: " + PrimerNum.restar(PrimerNum, SegundoNum));
            break;
        case 2:
            //Caso multiplicación
            Console.WriteLine("\nEl resultado de la multplicación es: " + PrimerNum.multiplicar(PrimerNum, SegundoNum));
            break;
        case 3:
            //Caso división
            Console.WriteLine("\nEl resultado de la división es: " + PrimerNum.dividir(PrimerNum, SegundoNum));
            break;
        case 4:
            //Caso no hacer nada y salir
            break;

    }

    //Vuelve y se muestra el menu
    Console.WriteLine("Deseas\n" + " Suma = 0\n" + " Resta = 1\n" + " Multiplicar = 2\n" + " Dividir = 3\n" + "salir = 4\n");
    respuesta = int.Parse(Console.ReadLine());

} while (respuesta != 4);
