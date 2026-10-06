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
            //Persona: Edad, Sueldo, Nombre

            //int edad;
            //float sueldo;
            //string nombre;

            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            // CLASE 2 - ORIGINALMENTE:
            // Persona p1 = new Persona();

            // CLASE 5 - EL NOMBRE SE DEFINE AL CREAR LA PERSONA
            Persona p1 = new Persona("Pepe");

            // CLASE 2 - ACCESO MEDIANTE MÉTODOS
            p1.setEdad(20);

            Console.WriteLine($"La Edad de la Persona es: {p1.getEdad()}");

            // CLASE 5 - COMPORTAMIENTO DEL OBJETO
            Console.WriteLine(p1.saludar());

            // CLASE 6 - SOBRECARGA DEL MÉTODO SALUDAR
            Console.WriteLine(p1.saludar("Maxi"));

            // CLASE 2 - ACCESO MEDIANTE PROPIEDAD
            /*
            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int algo = b1.Capacidad;

            Console.WriteLine($"La Capacidad de la Botella es: {b1.Capacidad}");
            */

            // CLASE 4 - CREACIÓN MEDIANTE CONSTRUCTOR - ORIGINALMENTE SE MODIFICABA LA CAPACIDAD DESDE AFUERA
            Botella b1 = new Botella("Rojo", "Plastico");

            Console.WriteLine($"El Material de la Botella es: {b1.Material}");

            // CLASE 5 - ESTADO INICIAL DE LA BOTELLA
            Console.WriteLine($"Capacidad: {b1.Capacidad}");
            Console.WriteLine($"Cantidad Actual: {b1.CantidadActual}");

            // CLASE 5 - COMPORTAMIENTO: LA BOTELLA SE ENCARGA DE RECARGARSE
            float monto = b1.recargar();

            Console.WriteLine($"Monto de la Recarga: {monto}");
            Console.WriteLine($"Cantidad Actual después de Recargar: {b1.CantidadActual}");

            // CLASE 6 - SOBRECARGA DEL MÉTODO RECARGAR
            Botella b2 = new Botella("Azul", "Vidrio");

            float montoParcial = b2.recargar(20);

            Console.WriteLine($"Monto de la Recarga Parcial: {montoParcial}");
            Console.WriteLine($"Cantidad Actual después de Recargar 20: {b2.CantidadActual}");

            // CLASE 2 - EJERCICIO DE PRÁCTICA: ACCESO MEDIANTE PROPIEDADES
            Perro pr1 = new Perro();
            pr1.Nombre = "Tobias";

            string otraCosa = pr1.Nombre;

            Console.WriteLine($"El Nombre del Perro es: {pr1.Nombre}");

            Console.ReadKey();
        }
    }
}