using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ASOCIACIÓN: una clase se relaciona con otra porque contiene uno de sus objetos.
               A diferencia de la herencia, la relación no es "ES", sino "TIENE". */

            Auto a1 = new Auto();
            Motor m1 = new Motor();


            /* AGREGACIÓN: el Motor fue creado como un objeto independiente y luego se lo
               asignamos al Auto. Ambos objetos pueden existir independientemente. */

            a1.Motor = m1;

            Console.ReadKey();
        }
    }
}