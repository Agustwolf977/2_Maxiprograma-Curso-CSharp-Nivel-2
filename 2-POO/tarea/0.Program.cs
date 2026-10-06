using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hola! Cómo va?

Vamos a trabajar con lo aprendido en ésta unidad.
Te voy a dejar una serie de instrucciones para que vayas siguiendo y construyendo con el fin de poner en práctica
y ver funcionando lo visto hasta aquí.

1. Crear un proyecto de consola .Net Framework.
2. Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
3. Agregale los siguientes atributos:
   1-Modelo string.
   2-Marca string.
   3-NumeroTelefonico string.
   4-CodigoOperador int (1, 2 o 3).

4. Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
   1-Modelo: solo lectura. Es decir, solo get.
   2-Marca: solo lectura.
   3-NumeroTelefonico: lectura y escritura.
   4-CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.

5. Agregar Constructor que reciba Modelo y Marca.
6. Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
7. Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
8. Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
9. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

Estas cosas son las que hicimos con los ejemplos de Persona, Botella, Ventas; intenta ponerlos en práctica y si hay dudas, repasate
lo necesario. También podés consultar al foro de dudas.

Te propongo pensar alguna clase más, construirla y agregarle atributos, propiedades y métodos y hacer algunas pruebas; siempre teniendo
en mente que la idea es representar la realidad en lo digital.

No te olvides de la importancia de la práctica.

Saludos. */

namespace tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tl1 = new Telefono("SAMSUNG", "GALAXY A16");
            tl1.NumeroTelefonico = "+5493764884635";
            tl1.CodigoOperador = 1;

            // PUNTO 6: Mostrar en pantalla el estado del Telefono
            Console.WriteLine("--- ESTADO DEL TELÉFONO ---");
            Console.WriteLine("Marca: " + tl1.Marca);
            Console.WriteLine("Modelo: " + tl1.Modelo);
            Console.WriteLine("Número: " + tl1.NumeroTelefonico);
            Console.WriteLine("Cód. Operador: " + tl1.CodigoOperador);

            // PUNTO 9: Mostrar en pantalla el comportamiento (Métodos)
            Console.WriteLine("\n--- PROBANDO LLAMADAS ---");
            // Hay que envolver el método en un WriteLine porque devuelve un string
            Console.WriteLine(tl1.Llamar());
            Console.WriteLine(tl1.Llamar("Maximiliano Zar Fernandez"));

            Console.ReadKey(); // Pausa la consola para que puedas ver el resultado
        }
    }
}