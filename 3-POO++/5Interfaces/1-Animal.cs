using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Animal
    {
        
        // "virtual" permite que las clases derivadas sobrescriban este método mediante "override".
        public virtual string Comunicarse()
        {
            return "ruido... ruido...";
        }
    }
}