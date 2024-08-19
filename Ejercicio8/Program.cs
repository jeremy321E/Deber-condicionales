using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que solicite al usuario su edad y determine si tiene
             * la edad suficiente para votar utilizando sentencias if. El programa debe
             * mostrar un mensaje indicando si el usuario puede votar o no.
             */

            Console.WriteLine("ingrese su edad");
            int edad=int.Parse(Console.ReadLine());
            string res=  (edad > 19) ? "si puede votar" : "no puedes votar";
            Console.WriteLine(res);




        }
    }
}
