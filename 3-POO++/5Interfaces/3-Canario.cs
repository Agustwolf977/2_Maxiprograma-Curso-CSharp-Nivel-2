using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    // Canario hereda de AnimalDomestico e implementa el contrato IFlyable.
    internal class Canario : AnimalDomestico, IFlyable
    {
        public string Volar()
        {
            return "El canario vuela...";
        }
    }
}