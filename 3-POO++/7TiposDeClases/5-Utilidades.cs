using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposDeClases
{
    internal static class Utilidades
    {
        // Una clase static no se instancia: sus miembros se utilizan directamente
        // mediante el nombre de la clase y también deben ser static.

        public static void Saludar()
        {
            Console.WriteLine("Hola desde Utilidades");
        }
    }
}