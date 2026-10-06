using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    // Aguila hereda de AnimalSalvaje e implementa el contrato IFlyable.
    internal class Aguila : AnimalSalvaje, IFlyable
    {
        public string Volar()
        {
            return "El águila vuela...";
        }
    }
}