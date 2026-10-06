using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLASE 8 - STRING
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            // CLASE 8 - PROPIEDAD LENGTH: CANTIDAD DE CARACTERES DEL STRING
            int cant = nombre.Length;

            Console.WriteLine($"Cantidad de caracteres: {cant}");

            // CLASE 8 - MÉTODOS TOUPPER Y TOLOWER
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());

            // CLASE 8 - PARA CONSERVAR EL RESULTADO SE REASIGNA EL STRING
            nombre = nombre.ToUpper();

            Console.WriteLine($"Nombre reasignado: {nombre}");

            // CLASE 8 - MÉTODO REPLACE
            nombre = nombre.Replace('A', 'E');

            Console.WriteLine($"Nombre después de Replace: {nombre}");

            // CLASE 8 - SOBRECARGA DE REPLACE: RECIBE DOS STRING
            nombre = nombre.Replace("E", "XXX");

            Console.WriteLine($"Nombre después de Replace con string: {nombre}");


            Console.WriteLine(nombre);

            Console.ReadKey();
        }
    }
}