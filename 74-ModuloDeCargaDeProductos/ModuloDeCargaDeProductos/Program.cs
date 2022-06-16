using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloDeCargaDeProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Modulo de carga de datos");

            Console.WriteLine("Informe la cantidad de dispositivos que desea ingresar:");

            int Cantidad = Convert.ToInt32(Console.ReadLine());

            List<CargaDeDatos> ListadoTipos = new List<CargaDeDatos>();

            List<CargaDeDatos> ListadoCompleto = new List<CargaDeDatos>();

            for (int i=0; i<Cantidad; i++)
            {
                CargaDeDatos Producto = new CargaDeDatos();

                Console.WriteLine("Ingrese el tipo de dispositivo (mother, procesador, memoroia, fuente, gabinete, etc.)");

                Producto.TipoDispositivo = Console.ReadLine();

                Console.WriteLine("Ingrese la marca:");

                Producto.Marca = Console.ReadLine();

                Console.WriteLine("Ingrese el modelo:");

                Producto.Modelo = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de serie: ");

                Producto.NumSerie = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el precio:");

                Producto.Precio = Convert.ToInt32(Console.ReadLine());

                ListadoTipos.Add(Producto);

                ListadoCompleto.Add(Producto);
            }

            Console.WriteLine("Ingrese el listado que desea ver: 'TIPO' o 'COMPLETO':");

            string acceso = Console.ReadLine();

            switch (acceso.ToUpper())
            {
                case "TIPO":
                    Console.WriteLine("Listado por tipo:");
                    for (int i = 0; i < ListadoTipos.Count; i++)
                    {
                        CargaDeDatos j = ListadoTipos[i];
                        Console.WriteLine(j.ListadoPorTipo());
                    }
                    break;
                case "COMPLETO":
                    Console.WriteLine("Listado completo:");
                    for (int i = 0; i < ListadoCompleto.Count; i++)
                    {
                        CargaDeDatos j = ListadoCompleto[i];
                        Console.WriteLine(j.ListadoCompleto());
                    }
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
