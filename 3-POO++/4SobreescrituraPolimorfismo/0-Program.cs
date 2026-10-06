using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "Peludita";

            Perro p1 = new Perro();
            p1.Nombre = "Lola";


            /* Como Perro, Pez, Canario, Gato y Aguila derivan de Animal, sus objetos pueden almacenarse en una List<Animal>. */

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            
            animales.Add(new Pez());   /* También podemos crear el objeto directamente al agregarlo a la lista,
                                          sin guardar previamente su referencia en una variable. */
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());


         /* Animal a1 = g1;               // g1, a1 y g8 contienen referencias al mismo objeto Gato. El casteo no crea un nuevo objeto: permite volver
            Gato g8 = (Gato)a1;              a tratar como Gato la referencia que estaba guardada en una variable de tipo Animal.
            g8.Nombre = "Flaquitta";
            Console.WriteLine(g1.Nombre); */


            /* POLIMORFISMO: Podemos tratar distintos objetos derivados como Animal y llamar al mismo método Comunicarse(). Gracias a virtual y override,
               se ejecutará la implementación correspondiente al tipo real del objeto. */

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.Comunicarse());
            }

            Console.ReadKey();
        }
    }
}