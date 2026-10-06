using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea
{
    internal class Telefono
    {
     // private string marca;
     // private string modelo;
     // private string numeroTelefonico;
        private int codigoOperador; // (1, 2 o 3)

    //  ASI PARA LA AUTOPROPIEDAD (VERSION CORTA)      //   ASI PARA SU VERSION DESARROLLADA (VERSION LARGA)
        public Telefono(string marca, string modelo)   //   public Telefono(string marca, string modelo)
        {                                              //   {
            this.Marca = marca;                        //       this.marca = marca;
            this.Modelo = modelo;                      //       this.modelo = modelo;
                                                       //
        // "this" referencia a la propiedad            //      "this" referencia directamente al atibuto
        }                                              //   }

        public string Marca { get; }                   //   public string Marca
        public string Modelo { get; }                  //   {
                                                       //       get { return marca; }
                                                       //   }
                                                       //
                                                       //   public string Modelo
                                                       //   {
                                                       //       get { return modelo; }
                                                       //   }
        public string NumeroTelefonico { get; set; }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value == 1 || value == 2 || value == 3) codigoOperador = value;
                else codigoOperador = 0;
            }
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}