using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                 Vehiculo
            //              /     |     \
            //           Auto  Camioneta  Moto
            //          /    \
            // AutoUrbano  AutoDeportivo

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();

            v1.Motor = "Toyota 2.0 Dynamic Force";

         /* v1.CargaMaxima = 10;  // NO ES POSIBLE porque CargaMaxima no es un miembro de Vehiculo.
                                     Es una propiedad declarada específicamente en Camioneta. */

            c1.Motor = "Toyota 2.0 Dynamic Force"; // Camioneta hereda Motor de Vehiculo.
            c1.CargaMaxima = 10;                   // CargaMaxima pertenece específicamente a Camioneta.

            Vehiculo v2 = new Camioneta();  /* La variable v2 es de tipo Vehiculo, pero guarda una referencia a un objeto Camioneta.
                                               Esto es posible porque Camioneta hereda de Vehiculo: una Camioneta ES un Vehiculo. */
        }
    }
}