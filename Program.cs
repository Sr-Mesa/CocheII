using System;

namespace CocheII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca, modelo;
            int opcion=0, velocidad = 0, cantidad=0;

            Console.WriteLine("Cual es la marca?");
            marca= Console.ReadLine();

            Console.WriteLine("Cual es el modelo?");
            modelo = Console.ReadLine();

            Coche coche = new Coche(marca, modelo,velocidad);

            do
            {

                Console.WriteLine("----MENU----");
                Console.WriteLine("1.Acelerar coche");
                Console.WriteLine("2.Frenar coche");
                Console.WriteLine("3.Mostrar informacion");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cual es la cantidad a la que va a incrementar  la velocidad del coche?");
                        cantidad = int.Parse(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            
                            Console.WriteLine("La velociada actual del coche es de: " + coche.Acelerar(cantidad)+"km/h");
                        }
                        else
                        {
                            Console.WriteLine("Al acelerar no se pueden poner numeros negativos");
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("Cual es la cantidad a la que va a decrementar la velocidad del coche?");
                        cantidad = int.Parse(Console.ReadLine());

                        
                            Console.WriteLine("La velocidad actual es: " + coche.Frenar(cantidad)+"km/h");
                        
                        
                        break;
                    case 3:

                        Console.WriteLine(coche.MostrarInfo());
                        break;
                    default:
                        Console.WriteLine("Adios pues");
                        break;
                }
                cantidad = 0;
            } while (opcion<4);
        }
    }
}
