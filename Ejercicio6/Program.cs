using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribe un programa que solicite al usuario un número que represente
             * un día de la semana (1 para lunes, 2 para martes, etc.) y muestre 
             * el nombre completo del día correspondiente
             */
            Console.WriteLine("Ingrese un dia de la semana");
            int dia=int.Parse(Console.ReadLine());
            string res = "";
            switch (dia) {
                case 1:res = "lunes";break;
                case 2: res = "martes"; break;
                case 3: res = "miercoles"; break;
                case 4: res = "jueves"; break;
                case 5: res = "viernes"; break;
                case 6: res = "sabado"; break;
                case 7: res = "domingo"; break;
                default: res = "dia no valido"; break;
            }
            Console.WriteLine(res);
            Console.ReadKey();  
        }
    }
}
