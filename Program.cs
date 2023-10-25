using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_prob05
{
    internal class Program
    
        {
            static Dictionary<string, int> ventas = new Dictionary<string, int>();

            static void Main(string[] args)
            {
                int opcion;

                do
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("Productos de mPhone");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Ventas de mPhone 3000");
                    Console.WriteLine("2: Ventas de mPad 3500");
                    Console.WriteLine("3: Ventas de MAPBrook 3800");
                    Console.WriteLine("4: Ventas de mWatch 8000");
                    Console.WriteLine("5: Salir");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                RealizarVenta("mPhone 3000");
                                break;
                            case 2:
                                RealizarVenta("mPad 3500");
                                break;
                            case 3:
                                RealizarVenta("MAPBrook 3800");
                                break;
                            case 4:
                                RealizarVenta("mWatch 8000");
                                break;
                            case 5:
                                MostrarEstadisticasFinales();
                                Console.WriteLine("¡Hasta Luego!");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                    }

                    if (opcion != 5)
                    {
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                    }

                } while (opcion != 5);
            }

            static void RealizarVenta(string producto)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar venta de:");
                Console.WriteLine("================================");
                Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
                Console.WriteLine("1: Sí");
                Console.WriteLine("2: No");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion) && opcion == 1)
                {
                    Console.Write("Ingrese la cantidad de ventas a registrar: ");
                    if (int.TryParse(Console.ReadLine(), out int ventasNuevas))
                    {
                        if (!ventas.ContainsKey(producto))
                        {
                            ventas[producto] = 0;
                        }
                        ventas[producto] += ventasNuevas;
                        Console.WriteLine($"Se registraron {ventasNuevas} ventas de {producto}.");
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida. No se registraron ventas.");
                    }
                }
                else
                {
                    Console.WriteLine("No se registraron ventas.");
                }
            }

            static void MostrarEstadisticasFinales()
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Reporte Final");
                Console.WriteLine("================================");
                Console.WriteLine("Productos Vendidos | Cantidad");
                Console.WriteLine("--------------------------------");
                int totalVentas = 0;

                foreach (var producto in ventas)
                {
                    Console.WriteLine($"{producto.Key} | {producto.Value}");
                    totalVentas += producto.Value;
                }

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Total | {totalVentas}");
                Console.WriteLine("================================");
            }
        }

    }


