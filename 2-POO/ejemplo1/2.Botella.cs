using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //Botella: Capacidad, Color, Material
        //ATRIBUTOS o MIEMBROS
        private int capacidad;
        private string color;
        private string material;

        // CLASE 5 - ESTADO ACTUAL DE LA BOTELLA
        private int cantidadActual;

        // CLASE 4 - CONSTRUCTOR: COLOR Y MATERIAL SE DEFINEN AL CREAR LA BOTELLA
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;

            // CLASE 5 - ESTADO INICIAL
            capacidad = 100;
            cantidadActual = 0;
        }

        // CLASE 4 - SOBRECARGA DEL CONSTRUCTOR
        public Botella()
        {
        }

        // CLASE 4 - PROPIEDAD DE SOLO LECTURA
        public string Material
        {
            get { return material; }
        }

        /* CLASE 2 - PROPIEDAD: miembro de una clase que permite controlar el acceso de lectura (get) y/o escritura (set)
           a un dato utilizando una sintaxis similar a la de una variable, cortesía de C#. */

        // ORIGINALMENTE LA PROPIEDAD PERMITÍA LECTURA Y ESCRITURA
        /*
        public int Capacidad
        {
            set { capacidad = value; }
            get { return capacidad; }
        }
        */

        // CLASE 5 - LA CAPACIDAD AHORA SOLO PUEDE CONSULTARSE DESDE AFUERA
        public int Capacidad
        {
            get { return capacidad; }
        }

        // CLASE 5 - PROPIEDAD DE SOLO LECTURA DEL ESTADO ACTUAL
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        // CLASE 5 - MÉTODO: COMPORTAMIENTO DE LA BOTELLA
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }

            cantidadActual = 100;
            return 50;
        }

        // CLASE 6 - SOBRECARGA DEL MÉTODO RECARGAR
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }

        // CLASE 4 - DESTRUCTOR
        ~Botella()
        {
        }
    }
}