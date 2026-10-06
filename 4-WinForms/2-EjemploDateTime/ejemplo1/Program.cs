using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime es un struct y, por lo tanto, un tipo valor.

            // Fecha y hora actuales del sistema.
            DateTime fecha = DateTime.Now;

            Console.WriteLine($"Fecha y Hora Actual: {fecha}");

            // También podemos crear una fecha determinada mediante su constructor:
            DateTime otraFecha = new DateTime(2004, 4, 1);

            Console.WriteLine($"Otra Fecha: {otraFecha.ToString("dd/MM/yyyy")}");

            // DateTime permite realizar operaciones con fechas.
            Console.WriteLine($"5 días después: {fecha.AddDays(5)}");

            // Podemos obtener solamente partes del DateTime.
            Console.WriteLine($"Día: {fecha.Day}");
            Console.WriteLine($"Mes: {fecha.Month}");
            Console.WriteLine($"Año: {fecha.Year}");

            // Distintas formas de representar el valor como texto.
            Console.WriteLine($"Fecha Corta: {fecha.ToShortDateString()}");
            Console.WriteLine($"Hora Corta: {fecha.ToShortTimeString()}");
            Console.WriteLine($"Formato Personalizado: {fecha.ToString("dd/MM/yyyy")}");

            Console.ReadKey();
        }
    }
}