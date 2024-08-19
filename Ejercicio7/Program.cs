using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que genere un número aleatorio entre 1 y 100 y le
             * pida al usuario que adivine el número. El programa debe dar pistas al
             * usuario (mayor que, menor que, igual) hasta que logre adivinar el 
             * número correcto.
             * 
             */
            Random rnd = new Random();
            int random = rnd.Next(100);
            bool encontrado = false;
            Console.WriteLine($"numero aleatorio {random}");
            Console.WriteLine("ingrese un numero aletorio entre 0-100");
            int numero = int.Parse(Console.ReadLine());
            while (!encontrado)
            {
                    if (numero > random)
                    {
                        Console.WriteLine("el numero deber ser menor");
                    }
                    else if (numero < random)
                    {
                        Console.WriteLine("el numero debe ser mayor");
                    }
                    else if (numero == random)
                    {
                        Console.WriteLine("felicidades numero encontrado");
                        encontrado = true;
                    break;
                    }
                Console.WriteLine("ingrese un numero aletorio entre 0-100");
              numero = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Gracias por jugar");
            Console.ReadKey();
        }
    }
}
