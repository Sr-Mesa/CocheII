using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheII
{
    internal class Coche
    {
        //Atributos
        string marca;
        string modelo;
        int velocidad;

        public Coche(string marca, string modelo, int velocidad)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.velocidad = velocidad;
        }

        //Metodos
        public int Acelerar(int cantidad)
        {
            this.velocidad += cantidad;
            return this.velocidad;
        }

        public int Frenar(int cantidad)
        {
            if (cantidad <= this.velocidad)
            {
                this.velocidad -= cantidad;
                return this.velocidad;
            }
            else
            {

                this.velocidad=0;
                
               
            }
            return this.velocidad;
        }

        public string MostrarInfo()
        {
            return "Marca: "+ this.marca +"\nModelo: " + this.modelo +"\nVelocidad: " + this.velocidad+"km/h";
        }
    }
}
