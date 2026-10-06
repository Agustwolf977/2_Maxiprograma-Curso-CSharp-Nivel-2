using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }


        // Sobrescribimos ToString(), un método heredado originalmente de la clase object.
        public override string ToString()
        {
            return "Animal Doméstico";
        }
    }
}