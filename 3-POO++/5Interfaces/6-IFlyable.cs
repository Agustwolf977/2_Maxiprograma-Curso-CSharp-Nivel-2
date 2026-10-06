using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal interface IFlyable
    {
        // La interfaz funciona como un contrato: define QUÉ deben poder hacer
        // las clases que la implementen, pero cada clase determina CÓMO hacerlo.
        string Volar();
    }
}