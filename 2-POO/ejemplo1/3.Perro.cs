using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //Perro: Nombre, Color, Origen
        //ATRIBUTOS o MIEMBROS
        private string nombre;
        private string color;
        private string origen;

        // CLASE 2 - EJERCICIO DE PRÁCTICA: PROPIEDAD
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}