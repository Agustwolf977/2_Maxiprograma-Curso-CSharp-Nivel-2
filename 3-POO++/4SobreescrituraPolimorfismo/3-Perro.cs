using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Perro : AnimalDomestico
    {

        /* AHORA HEMOS usado "override" PARA SOBREESCRIBIR EL MÉTODO "Comunicarse" DE LA CLASE BASE "Animal", POR LO QUE
           LA CLASE "Perro" PUEDE DAR UNA RESPUESTA PROPIA, O DISTINTA DE LA CLASE BASE */
        public override string Comunicarse()
        {
            return "guau... guau...";
        }
    }
}