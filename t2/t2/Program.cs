using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arbolbbp arbolEmpleados = new arbolbbp();

            int opcion;

            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("======== MENU ======");
                Console.WriteLine("====================");
                Console.WriteLine("1) Agregar");
                Console.WriteLine("2) Listar1 InOrden");
                Console.WriteLine("3) Listar2 PosOrden");
                Console.WriteLine("4) Mayores de cierta Antiguedad");
                Console.WriteLine("5) Penultimo");
                Console.WriteLine("9) Fin");
                Console.WriteLine("===================");
                Console.Write("Opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Codigo: ");
                        int codigo = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Antiguedad: ");
                        int antiguedad = int.Parse(Console.ReadLine());

                        empleado emp = new empleado(codigo, nombre, antiguedad);

                        arbolEmpleados.Agrega(emp);

                        Console.WriteLine("Empleado agregado.");
                        break;

                    case 2:

                        arbolEmpleados.MuestraInCodigo();
                        break;

                    case 3:

                        arbolEmpleados.MuestraPosAntiguedad();
                        break;

                    case 4:

                        Console.Write("Ingrese antiguedad: ");
                        int ant = int.Parse(Console.ReadLine());

                        int cantidad = arbolEmpleados.MayoresA(ant);

                        Console.WriteLine($"Cantidad de empleados mayores a {ant}: {cantidad}");
                        break;

                    case 5:

                        Console.WriteLine("Penultimo empleado segun codigo:");
                        Console.WriteLine(arbolEmpleados.Penultimo());
                        break;

                    case 9:

                        Console.WriteLine("Fin del programa.");
                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta.");
                        break;
                }

            } while (opcion != 9);

        }
    }
}
