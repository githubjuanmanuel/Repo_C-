using System;
using System.IO;
namespace Codificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ArchivoEscritura = new StreamWriter("D:\\Juan Manuel\\Ejercicios c·\\Decodificado\\Final.txt"); //Crea o abre un archivo para escritura
            StreamReader ArchivoLectura = new StreamReader("D:\\Juan Manuel\\Ejercicios c·\\Decodificado\\Inicial.txt"); // Abre un archivo para lectura
            // inicializacion de variables
            string frase = "";
            int cont1 = 0, cont0 = 0;

            frase = ArchivoLectura.ReadToEnd(); //Lee todo el contenido del archivo
            ArchivoLectura.Close(); // Cierra el archivo de lectura
            char[] freaseToCharArray = frase.ToCharArray(); // Convierte todo el texto en un arreglo de caracteres para separar cada letra

            var PrimerChar = ConvertToBinary(freaseToCharArray[0]); // Convierte la primera letra en su representacion en binario 

            // Ciclo para aplicar la regla de codificacion al primer caracter cambia los 1 por 0 y viceversa y se escribe en el archivo
            for (int i = 0; i < PrimerChar.Length; i++)
            {
                if (PrimerChar[i] == 0)
                    ArchivoEscritura.Write(1);
                else
                    ArchivoEscritura.Write(0);
            }
            //Contar cantidad de 1 del primer caracter
            cont1 = ContarUnos(freaseToCharArray[0]);

            //Codificar el resto del mesaje

            for (int i = 1; i < freaseToCharArray.Length; i++)
            { //Convertir a binario un caracter

                var BinaryArray = ConvertToBinary(freaseToCharArray[i]);
                // Con base en la cantidad de 1 del caracter anterior se hallan los 0
                cont0 = 8 - cont1;

                //Aplica la regla de codificacion 
                var BinaryCode = Codifica(cont0, cont1, BinaryArray);
                // Se cuentan la cantida de 1 del caracter actual 
                cont1 = ContarUnos(freaseToCharArray[i]);

                for (int j = 0; j < BinaryCode.Length; j++)
                {
                    ArchivoEscritura.Write(BinaryCode[j]);
                }

            }

            ArchivoEscritura.Close();  // Cierra el archivo de escritura.
            Console.WriteLine("El archivo fue codificado");
            Console.ReadKey();
        }

        // Funcion que aplica la regal de codificacion
        public static int[] Codifica(int cont0, int cont1, int[] vector)
        {
            int offset = 0;
            // Evaluar la cantidad de 1s y de 0s
            if (cont0 < cont1)
                offset = 1;
            else if (cont0 > cont1)
                offset = 2;
            else
                offset = 3;
            // Realizar la codificacion dentro del arreglo
            for (int i = offset - 1; i < 8; i += offset)
            {
                if (vector[i] == 1)
                    vector[i] = 0;
                else
                    vector[i] = 1;
            }
            return vector;
        }

        //Funcion que convierte un caracter a binario
        public static int[] ConvertToBinary(char character)
        {
            int cont = 7, residuo;
            int caracter = Convert.ToInt32(character); // se halla el correpsondiete codigo ASCII que presenta al caracter
            int[] ArrayBits = { 0, 0, 0, 0, 0, 0, 0, 0 }; // se crea un arreglo de 8 incialmente con todos la valores en 0
            // Se realiza la conversion a binario
            while (cont >= 0)
            {
                residuo = caracter % 2;
                caracter /= 2;
                ArrayBits[cont] = residuo;
                cont--;
            }
            return ArrayBits;

        }

        //Funcion que cuenta la cantidad de 1
        public static int ContarUnos(char caracter)
        {
            int[] vector = ConvertToBinary(caracter);

            int cont = 0;
            for (int j = 0; j < 8; j++)
            {
                if (vector[j] == 1)
                    cont++;
            }
            return cont;
        }

    }
}
