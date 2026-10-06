using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program1
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

            // CLASE 3 - PRIMERA ETAPA: CREACIÓN Y USO DE UN OBJETO ARTÍCULO

            Artículo a1 = new Artículo();
            a1.CodArticulo = 123;

            a1.CodigoMarca = 5;

            Console.ReadKey();
        }
    }
}