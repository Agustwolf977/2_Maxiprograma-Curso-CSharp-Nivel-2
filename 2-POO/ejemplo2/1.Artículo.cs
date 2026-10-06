using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Artículo
    {
        //- Código Artículo (3 dígitos no correlativos)
        //- Precio
        //- Código de Marca (1 a 10)

        //ATRIBUTOS o MIEMBROS

        //private int codArticulo;

        // CLASE 3 - AUTO-PROPIEDAD
        public int CodArticulo { get; set; } /* FORMA SIMPLIFICADA DE DEFINIR UNA PROPIEDAD:
                                       el compilador genera automáticamente un campo de respaldo.
                                       En Visual Studio puede generarse escribiendo "prop" y presionando
                                       dos veces la tecla Tab. */
        //private float precio;

        // CLASE 3 - AUTO-PROPIEDAD
        public float Precio { get; set; }

        private int codMarca;

        // CLASE 3 - PROPIEDAD DESARROLLADA
        // A diferencia de una auto-propiedad, permite agregar lógica dentro del set y del get.
        public int CodigoMarca
        {
            get
            { 
                return codMarca;
            }

            set
            {
                if (value > 0 && value < 11) codMarca = value;
                else codMarca = -1;
            }
        }
    }
}