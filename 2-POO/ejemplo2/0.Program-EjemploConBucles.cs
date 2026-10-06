using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CLASE 3 - SEGUNDA ETAPA: MISMO PROBLEMA, AHORA CON UN VECTOR DE OBJETOS

namespace ejemplo2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
//          Primer lote con 10 registros de productos, cada producto tiene:
//           - Código Artículo (3 dígitos no correlativos)
//           - Precio
//           - Código de Marca (1 a 10)
//          Segundo lote con las ventas de la semana. Cada venta tiene:
//           - Código  Artículo
//           - Cantidad
//           - Código Cliente (1 a 100)
//          Este lote corta con código de cliente cero.

            // CLASE 3 - VECTOR DE OBJETOS: SE CREAN 10 POSICIONES PARA REFERENCIAS A ARTÍCULO
            Artículo[] articulos = new Artículo[10];

            // CLASE 3 - PRIMER LOTE: SE CARGAN LOS 10 OBJETOS ARTÍCULOS
            for (int i = 0; i < articulos.Length; i++)
            {
                // CORRECCIÓN NECESARIA: EL VECTOR CREA LAS POSICIONES, NO LOS OBJETOS.
                articulos[i] = new Artículo();

                Console.WriteLine("INGRESE LOS DATOS DEL PRODUCTO:");
                Console.Write("Ingrese Código:");
                articulos[i].CodArticulo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Precio:");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.Write("Marca (1 a 10):");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }

            // CLASE 3 - SEGUNDO LOTE: LAS VENTAS SE PROCESAN UNA POR UNA
            Venta venta = new Venta();

            Console.WriteLine("Ingrese Una Venta:");
            Console.Write("Código Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            

            while (venta.CodigoCliente != 0)
            {
                Console.Write("Código Artículo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // aquí se procesa la venta actual...

                // Se pide nuevamente el código de cliente para continuar o finalizar el lote.

                Console.WriteLine("Ingrese Otra Venta:");
                Console.Write("Código Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }      

            Console.ReadKey();
        }
    }
}