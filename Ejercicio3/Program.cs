using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que represente una pequeña calculadora.
             * Para ello, el programa pedirá dos números enteros y una operación
             * aritmética (que debe ser +, -, * o /) y mostrará el resultado 
             * correspondiente
             * 
             */
            Console.WriteLine("ingrese un primer numero entero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un segundo numero entero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese una operacion aritmetica");
            char letra=(char)(Console.Read());
            int res = 0;
            switch (letra) { 
            case '+':res = num1 + num2; break;
            case '-': res = num1 - num2; break;
            case '*': res = num1 * num2; break;
            case '/': res = num1 / num2; break;
            }
            Console.WriteLine($"el resultado de {num1} {letra} {num2} ={res}");
            Console.ReadKey();
        }
    }
}
