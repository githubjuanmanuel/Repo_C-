using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas_objeto
{

    public class Program
    {
        static void Main(string[] args)
        {

            int respuesta = 0;

            List<Persona> lista_Personas = new List<Persona>();

            do
            {
                Console.WriteLine("Bienvenido \n Deseas registrarte oprime 1 \n Deseas iniciar sesion oprime 2 \n Deseas salir oprime 3");
                respuesta = int.Parse(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        int id;
                        string user, password;
                        Console.WriteLine("Crea un id");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Crea un usuario");
                        user = Console.ReadLine();

                        Console.WriteLine("Crea tu contraseña");
                        password = Console.ReadLine();

                        Persona person = new Persona(id, user, password);
                        Console.WriteLine("---Usuario Registrado---");
                        Console.WriteLine("");
                        lista_Personas.Add(person);
                        break;
                    case 2:

                        string usuario;
                        string contrasena;


                        Console.WriteLine("Ingrese el usuario");
                        usuario = Console.ReadLine();

                        Console.WriteLine("Ingrese la contraseña");
                        contrasena = Console.ReadLine();

                        foreach (Persona persona in lista_Personas)
                        {
                            if (persona.User == usuario && persona.Password == contrasena)
                            {
                                Console.WriteLine("Bienvenido");
                                break;
                            }
                            
                        }
                        break;

                    default:
                        Console.WriteLine("Hasta pronto");
                        break;
                }

            } while(respuesta == 1 || respuesta == 2);



            Console.ReadKey();
        }

    }
}
