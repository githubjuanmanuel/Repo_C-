
using Practica_Herencia;


List<Persona> Personas = new List<Persona>();

int respuesta = 0;
int respuesta2 = 0;
string nombre = "";
string apellido = "";
string cedula = "";
string direccion = "";
string nombre_jefe = "";
double salario = 0;
double Valor_Hora = 0;
double Valor_Hora_Ex = 0;
double Num_Horas = 0;
double porcentaje = 0;
double valor_venta = 0;

Console.WriteLine("**Bienvenido**");
Console.WriteLine("¿Deseas una persona (Si = 1/ No = 2)?");
respuesta = int.Parse(Console.ReadLine());

while (respuesta != 2)
{
    Console.WriteLine("¿Deseas ingresar:\n-Un trabajador con pago fijo (1)\n-Un trabajador por horas (2)\n-Un trabajador por comisión (3)\n-Un jefe (4)?");
    respuesta2 = int.Parse(Console.ReadLine());

    Console.WriteLine("---------------------------------------------------------------------");
    Console.Write("Ingresa el nombre: ");
    nombre = Console.ReadLine();
    Console.Write("Ingresa el apellido: ");
    apellido = Console.ReadLine();
    Console.Write("Ingresa la direccion : ");
    direccion = Console.ReadLine();
    Console.Write("Ingresa la cedula: ");
    cedula = Console.ReadLine();
    Console.WriteLine("---------------------------------------------------------------------");

    switch (respuesta2)
    {
        case 1:
            T_Fijo trabajador_F = new T_Fijo(nombre, apellido, cedula, direccion);
            Console.WriteLine("Ingresa el nombre del jefe");
            nombre_jefe = Console.ReadLine();
            Console.WriteLine("Ingrese el salario");
            salario = double.Parse(Console.ReadLine());
            trabajador_F.setSalario(salario);
            trabajador_F.setNombre_Jefe(nombre_jefe);
            Personas.Add(trabajador_F);
            break;

        case 2:
            T_Por_Horas trabajador_H = new T_Por_Horas(nombre, apellido, cedula, direccion);

            Console.WriteLine("Ingresa el nombre del jefe");
            nombre_jefe = Console.ReadLine();
            trabajador_H.setNombre_Jefe(nombre_jefe);
            Console.WriteLine("Ingresa el valor de hora normal");
            Valor_Hora = double.Parse(Console.ReadLine());
            trabajador_H.setValor_Hora(Valor_Hora);
            Console.WriteLine("Ingresa el valor de hora extra");
            Valor_Hora_Ex = double.Parse(Console.ReadLine());
            trabajador_H.setValor_Hora_Ex(Valor_Hora_Ex);
            Console.WriteLine("Ingresa el total de horas trabajadas");
            Num_Horas = double.Parse(Console.ReadLine());
            trabajador_H.setNum_Horas(Num_Horas);

            trabajador_H.Hallar_Salario();

            Personas.Add(trabajador_H);
            break;

        case 3:
            T_Comisionista trabajador_C = new T_Comisionista(nombre, apellido, cedula, direccion);
            Console.WriteLine("Ingresa el nombre del jefe");
            nombre_jefe = Console.ReadLine();
            trabajador_C.setNombre_Jefe(nombre_jefe);
            Console.WriteLine("Ingrese el valor total de las ventas");
            valor_venta = double.Parse(Console.ReadLine());
            trabajador_C.setValor_Venta(valor_venta);
            Console.WriteLine("Ingresa el porcentaje de la comisión");
            porcentaje = double.Parse(Console.ReadLine());
            trabajador_C.setPorcentaje(porcentaje);

            trabajador_C.Hallar_Salario();

            break;

        case 4:
            Jefe jefe = new Jefe(nombre, apellido, cedula, direccion);
            Console.WriteLine("Ingresa el salario");
            salario = double.Parse(Console.ReadLine());
            jefe.setSalario(salario);
            break;

    }
    Console.WriteLine("¿Deseas ingresar otra persona (Si = 1/ No = 2)?");
    respuesta = int.Parse(Console.ReadLine());
    foreach (Persona persona in Personas)
    {
        Console.WriteLine(persona.getNombre);
        Console.WriteLine(persona.getApellido);
        Console.WriteLine(persona.getCedula);
        Console.WriteLine(persona.getDireccion);
        Console.WriteLine(persona.getSalario());
    }
}