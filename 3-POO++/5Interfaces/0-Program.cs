using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canario canario = new Canario();
            Aguila aguila = new Aguila();

            // La lista puede agrupar objetos de clases diferentes porque todos implementan
            // el mismo contrato IFlyable.

            List<IFlyable> voladores = new List<IFlyable>();

            voladores.Add(canario);
            voladores.Add(aguila);

            foreach (IFlyable item in voladores)
            {
                Console.WriteLine(item.Volar());
            }

            Console.ReadKey();
        }
    }
}