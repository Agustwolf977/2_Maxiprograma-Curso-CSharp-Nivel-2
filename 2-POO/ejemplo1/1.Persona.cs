using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        // CLASE 5 - CONSTRUCTOR
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        // CLASE 2 - MÉTODOS PARA ACCEDER A UN ATRIBUTO PRIVADO
        public void setEdad(int e)
        { 
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        // CLASE 5 - COMPORTAMIENTO DEL OBJETO
        public string saludar()
        {
            return "Hola soy... " + nombre;
        }

        // CLASE 6 - SOBRECARGA DE MÉTODOS
        public string saludar(string personaje)
        {
            return "Hola " + personaje + ", soy " + nombre;
        }

    }
}