using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que reciba la calificación numérica de un estudiante y 
             * muestre la letra equivalente de la calificación (A, B, C, D, F) 
             * utilizando sentencias if.
             * 
             */
            Console.WriteLine("ingrese su calificacion");
            float calificacion=float.Parse(Console.ReadLine());
            if (calificacion <= 4)
            {
                Console.WriteLine("F");
            }
            else if (calificacion <= 5)
            {
                Console.WriteLine("D");
            }
            else if (calificacion <= 6)
            {
                Console.WriteLine("C");
            }
            else if (calificacion <= 8)
            {
                Console.WriteLine("B");
            }else if (calificacion > 9)
            {
                Console.WriteLine("A");
            }
            Console.ReadKey(); 
            
        }
    }
}
