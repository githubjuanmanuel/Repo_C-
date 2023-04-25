using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            List<Pedido> List_Pedidos = new List<Pedido>();
            List<Cliente> List_Clientes = new List<Cliente>();
            List<Producto> List_Producto = new List<Producto>();
            List<Trabajador> list_Trabajador = new List<Trabajador>();

            do
            {
                Console.WriteLine("Bienvenido \n deseas regitrarte (1)\n deseas iniciarsesion(2)\n deseas salir (3)");
                respuesta = int.Parse(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        string nombre, roll, usuario, contra, sucursal;
                        Console.WriteLine("Ingresa tu roll (A = administrador, V = vendedor, R = Repartidor)");
                        roll = Console.ReadLine();
                        
                        Console.WriteLine("Ingresa tu nombre");
                        nombre = Console.ReadLine();
                        
                        Console.WriteLine("Crea un usuario");
                        usuario = Console.ReadLine();
                        
                        Console.WriteLine("Crea la contraseña");
                        contra = Console.ReadLine();
                        
                        Console.WriteLine("Ingresa la sucursal a la que perteneces (Naranja, Mango, Mora, Guineo, Auyama, Banano)");
                        sucursal = Console.ReadLine();

                        Trabajador trabajador = new Trabajador(roll,nombre, usuario, contra, sucursal);
                        list_Trabajador.Add(trabajador);

                        Console.WriteLine("---Usuario Registrado---");
                        Console.WriteLine();
                        break;
                    case 2:
                        string user;
                        string password;
                        string respuesta2;

                        Console.WriteLine("Ingresa el usuario");
                        user = Console.ReadLine();

                        Console.WriteLine("Ingresa la contraseña");
                        password = Console.ReadLine();


                        foreach (Trabajador trabajador1 in list_Trabajador)
                        {
                            if (trabajador1.Usuario != user || trabajador1.Contrasena != password)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Usuario o contraseña errado");
                                Console.WriteLine();
                            }
                            else if (trabajador1.Usuario == user && trabajador1.Contrasena == password)
                            {
                                Console.WriteLine("Bienvenido");
                                Console.WriteLine();
                                switch (trabajador1.Roll)
                                {
                                    case "A":
                                        int respuesta3;

                                        Console.WriteLine("Deseas: \n Agregar un producto = 1\n Modificar la cantidad de algún producto = 2\n Generar Factura = 3\n Salir = 4 ");
                                        respuesta3 = int.Parse(Console.ReadLine());
                                        do
                                        {

                                            Console.WriteLine();
                                            switch (respuesta3)
                                            {
                                                case 1:
                                                    string nombreProducto, ProductoSucursal;
                                                    int cantidadProducto;
                                                    double precioProducto;
                                                    Console.WriteLine("Deseas ingresar algún producto");
                                                    respuesta2 = Console.ReadLine();
                                                    while (respuesta2 == "Si" || respuesta2 == "si")
                                                    {
                                                        Console.WriteLine();
                                                        Console.WriteLine("Ingresa la sucursal (Naranja, Mango, Mora, Guineo, Auyama, Banano)");
                                                        ProductoSucursal = Console.ReadLine();

                                                        Console.WriteLine("Ingresa el nombre");
                                                        nombreProducto = Console.ReadLine();

                                                        Console.WriteLine("ingresa la cantidad");
                                                        cantidadProducto = int.Parse(Console.ReadLine());

                                                        Console.WriteLine("Ingresa el precio");
                                                        precioProducto = double.Parse(Console.ReadLine());

                                                        Producto producto = new Producto(nombreProducto, cantidadProducto, precioProducto, ProductoSucursal);
                                                        List_Producto.Add(producto);

                                                        Console.WriteLine("Producto ingresado");
                                                        Console.WriteLine("Deseas ingresar otro producto");
                                                        respuesta2 = Console.ReadLine();
                                                        Console.WriteLine();
                                                    }

                                                    break;
                                                case 2:

                                                    string nameProduct, LocalProducto;
                                                    Console.WriteLine("Ingresa el nombre del producto que deseas modificar");
                                                    nameProduct = Console.ReadLine();
                                                    Console.WriteLine("Ingresa la sucursal del producto que quiere modificar (Naranja, Mango, Mora, Guineo, Auyama, Banano)");
                                                    LocalProducto = Console.ReadLine();
                                                    foreach (Producto producto in List_Producto)
                                                    {
                                                        int answer;
                                                        if (producto.Nombre == nameProduct && producto.Sucursal == LocalProducto)
                                                        {
                                                            Console.WriteLine("Deseas\n Modificar la cantidad = 1\n Modificar el precio = 2");
                                                            answer = int.Parse(Console.ReadLine());
                                                            switch (answer)
                                                            {
                                                                case 1:
                                                                    int nuevaCantidad;
                                                                    Console.WriteLine("Cantidad actual: " + producto.Cantidad);
                                                                    Console.WriteLine("Ingresa la nueva cantidad");
                                                                    nuevaCantidad = int.Parse(Console.ReadLine());

                                                                    producto.Cantidad = nuevaCantidad;
                                                                    Console.WriteLine("La nueva cantidad es: " + producto.Cantidad);
                                                                    break;
                                                                case 2:
                                                                    Console.WriteLine("Cantidad actual: " + producto.Precio);
                                                                    double nuevoPrecio;
                                                                    Console.WriteLine("Ingresa el nuevo precio");
                                                                    nuevoPrecio = double.Parse(Console.ReadLine());

                                                                    producto.Precio = nuevoPrecio;
                                                                    Console.WriteLine("El nuevo precio es: " + producto.Precio);
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Producto no disponible");
                                                        }
                                                    }
                                                    break;
                                                case 3:
                                                    string NombreProducto, respuesta4, local2, cliente, direccion, telefono;
                                                    int cantidad;
                                                    double valor;
                                                    double valortotal = 0;

                                                    

                                                    Console.WriteLine("Ingrese el nombre del cliente");
                                                    cliente = Console.ReadLine();

                                                    Console.WriteLine("Ingrese la direccion");
                                                    direccion = Console.ReadLine();
                                                    
                                                    Console.WriteLine("Ingrese el telefono");
                                                    telefono = Console.ReadLine();


                                                    Cliente cliente1 = new Cliente(cliente,direccion,telefono);
                                                    List_Clientes.Add(cliente1);
                                                    

                                                    do
                                                    {
                                                        Console.WriteLine("Ingrese el nombre de producto");
                                                        NombreProducto = Console.ReadLine();
                                                        Console.WriteLine("Ingresa la sucursal (Naranja, Mango, Mora, Guineo, Auyama, Banano)");
                                                        local2 = Console.ReadLine();
                                                        

                                                        foreach (Producto producto in List_Producto)
                                                        {
                                                            if (producto.Nombre == NombreProducto && producto.Sucursal == local2)
                                                            {
                                                                Console.WriteLine("Ingrese la cantidad");
                                                                cantidad = int.Parse(Console.ReadLine());
                                                                valor = producto.Precio * cantidad;
                                                                producto.Cantidad = producto.Cantidad - cantidad;
                                                                valortotal = valortotal + valor;
                                                                Pedido pedido = new Pedido(producto.Nombre,cantidad, producto.Precio, cliente);
                                                                List_Pedidos.Add(pedido);
                                                            }
                                                            else if (producto.Nombre != NombreProducto || producto.Sucursal != local2)
                                                            {
                                                                Console.WriteLine("Producto no disponible");
                                                            }
                                                           

                                                        }
                                                        Console.WriteLine("Deseas ingresar otro producto");
                                                        respuesta4 = Console.ReadLine();
                                                    } while (respuesta4 == "Si" || respuesta4 == "si");
                                                    Console.WriteLine("Facturando...");

                                                    
                                                    Console.WriteLine();
                                                    foreach (Cliente i in List_Clientes)
                                                    {
                                                        Console.WriteLine("Cliente: " + i.NombreCliente);
                                                        Console.WriteLine("Direccion: " + i.Direccion);
                                                        Console.WriteLine("Telefono: " + i.Telefono);
                                                        foreach (Pedido pedido in List_Pedidos)
                                                        {
                                                            if(pedido.Cliente == i.NombreCliente)
                                                            {
                                                                Console.WriteLine("Producto: "+ pedido.Nombre);
                                                                Console.WriteLine("cantidad: " + pedido.Cantidad);
                                                                Console.WriteLine("Valor: " + pedido.Precio);

                                                            }
                                                            pedido.Total = valortotal;
                                                        }
                                                    }
                                                    
                                                    Console.WriteLine("El valor total de la compra es: " + valortotal);
                                                    break;
                                                default:
                                                    break;
                                            }
                                            Console.WriteLine("Deseas: \n Agregar un producto = 1\n Modificar la cantidad de algún producto = 2\n Generar Factura = 3\n Salir = 4 ");
                                            respuesta3 = int.Parse(Console.ReadLine());
                                        } while (respuesta3 == 1 || respuesta3 == 2 || respuesta3 == 3);

                                      
                                        
                                        break;
                                    case "V":
                                        string product, local, answer2;
                                        do
                                        {
                                            Console.WriteLine("Ingresa el nombre del producto");
                                            product = Console.ReadLine();
                                            Console.WriteLine("Ingresa la sucursal (Naranja, Mango, Mora, Guineo, Auyama, Banano)");
                                            local = Console.ReadLine();
                                            foreach (Producto producto in List_Producto)
                                            {
                                                if (producto.Nombre == product && producto.Sucursal == local)
                                                {
                                                    Console.WriteLine("Nombre: " + producto.Nombre);
                                                    Console.WriteLine("Cantidad: " + producto.Cantidad);
                                                    Console.WriteLine("Precio: " + producto.Precio);
                                                    Console.WriteLine();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Producto no disponible");
                                                    Console.WriteLine();
                                                }
                                            }
                                            Console.WriteLine("Quieres buscar otro producto");
                                            answer2 = Console.ReadLine();
                                        } while (answer2 == "Si" || answer2 == "si");
                                        break;

                                    case "R":
                                        if (List_Clientes.Count == 0)
                                        {
                                            Console.WriteLine("Aún no hay pedidos   ");
                                        }
                                        foreach(Cliente cliente in List_Clientes)
                                        {

                                            Console.WriteLine("Cliente: " + cliente.NombreCliente);
                                            Console.WriteLine("Cliente: " + cliente.Direccion);
                                            Console.WriteLine("Cliente: " + cliente.Telefono);
                                            foreach (Pedido pedido in List_Pedidos)
                                            {
                                                if(pedido.Cliente == cliente.NombreCliente)
                                                {
                                                    Console.WriteLine("Producto: " + pedido.Nombre);
                                                    Console.WriteLine("Producto: " + pedido.Cantidad);
                                                    Console.WriteLine("Producto: " + pedido.Precio);

                                                }
                                                Console.WriteLine("El total es: " + pedido.Total);
                                            }
                                        }
                                        break;
                                    default:

                                        break;
                                }

                            }
                        }
                        break;

                            
                    default :
                        
                        break;
                }

            } while (respuesta == 1 || respuesta == 2);

        }
        
    }
}
