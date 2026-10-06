using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    internal class Auto
    {
        /* COMPOSICIÓN: el Chasis se crea como parte de la construcción del Auto.
           En este ejemplo, el Auto nace con su propio Chasis. */

        public Auto()
        {
            Chasis = new Chasis();
        }

        public Motor Motor { get; set; }

        public Chasis Chasis { get; }
    }
}