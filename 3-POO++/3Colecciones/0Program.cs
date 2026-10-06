using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones
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

            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Blanco";

            List<Camioneta> listaCamionetas = new List<Camioneta>();   /* Aquí aparece una colección de tipo List<T>. A diferencia de un vector, su tamaño
                                                                          puede crecer o reducirse dinámicamente. En este caso, <Camioneta> indica que
                                                                          la lista almacenará elementos de tipo Camioneta. */

            listaCamionetas.Add(c1);  // AGREGAMOS LOS OBJETOS A LA LISTA
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

         /* Console.WriteLine($"La Cantidad de Camionetas es: {listaCamionetas.Count}");   // "Count" indica la cantidad de elementos que contiene la colección. */


         /* listaCamionetas[1].Color = "Verde";    // Ambas formas modifican el mismo objeto Camioneta, porque c2 y
            c2.Color = "Verde";                       listaCamionetas[1] contienen referencias al mismo objeto. */


         /* Console.WriteLine($"El Color es: {listaCamionetas[1].Color}");   // Accedemos mediante el índice [1] a un elemento de la lista y luego a su propiedad Color. */


         // listaCamionetas.Remove(c3);   // Remove elimina de la lista el elemento indicado.


         // Console.WriteLine($"La Cantidad de Camionetas es: {listaCamionetas.Count}");   // Probamos otra vez


            
            /* Recorremos todos los elementos de la lista. En cada vuelta, item hace referencia
               a una de las Camionetas almacenadas en listaCamionetas. */

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine($"Color: {item.Color}");
            }

            Console.ReadKey();

        }
    }
}