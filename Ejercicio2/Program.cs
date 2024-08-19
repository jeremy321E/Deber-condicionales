using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que calcule las raíces de una ecuación de segundo
             * grado cuyos coeficientes son a, b y c. Utilice el método matemático
             * Sqrt de la clase Math del espacio de nombres System, que calcula la
             * raíz cuadrada de un número que no puede ser negativo y aplicable sobre
             * un tipo de dato double,
             * 
             */
            int a=1;
            float b=2;
            int c=3;
            double raiz = (Math.Sqrt(Math.Pow(b,2)- 4 * a * c)) / 2 * a;

            double res=-b -raiz;
            double res1=-b +raiz;
            Console.WriteLine($"solucion uno es {res} y solucion dos es {res1}");
        }
    }
}
