

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Venta
    {
        //- Código  Artículo
        //- Cantidad
        //- Código Cliente (1 a 100)

        // CLASE 3 - AUTO-PROPIEDADES
        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
    }
}