using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que a partir de tres valores enteros pedidos 
             * al usuario calcule su suma y su media
             * 
             */

            Console.WriteLine("ingrese un primer numero entero");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un segundo numero entero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un tercer numero entero");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"la suma es {num1 + num2 + num3}");
            Console.WriteLine($"la media es {(num1 + num2 + num3) / 3}");
        }
    }
}
