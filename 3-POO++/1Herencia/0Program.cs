using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //              Persona
            //          /      |      \
            //      Lider  Developer  Tester

            Persona p1 = new Persona();
            Lider l1 = new Lider();
            Developer d1 = new Developer();
            Tester t1 = new Tester();

            p1.Nombre = "Agustín Ezequiel";
            l1.Apellido = "Benítez";
            d1.Legajo = 2408;
            t1.Legajo = 2408;

            /* Lider, Developer y Tester heredan de Persona, por lo que disponen de los
               miembros accesibles heredados de la clase base; en este ejemplo, sus propiedades
               Nombre, Apellido y Legajo. */
        }
    }
}