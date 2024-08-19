using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrolla un programa que solicite al usuario su peso y altura,
             * y luego calcule su índice de masa corporal (IMC)  para clasificar 
             * su estado de peso 
             * 
             */

            Console.WriteLine("Calculadora de Índice de Masa Corporal (IMC)");

                // Solicitar peso
                Console.Write("Ingrese su peso en kilogramos: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                // Solicitar altura
                Console.Write("Ingrese su altura en metros: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                // Calcular IMC
                double imc = CalcularIMC(peso, altura);

                // Mostrar resultado
                Console.WriteLine($"\nSu IMC es: {imc:F2}");
                Console.WriteLine($"Clasificación: {ClasificarIMC(imc)}");
            }

            static double CalcularIMC(double peso, double altura)
            {
                return peso / (altura * altura);
            }

            static string ClasificarIMC(double imc)
            {
                if (imc < 18.5)
                    return "Bajo peso";
                else if (imc < 25)
                    return "Peso normal";
                else if (imc < 30)
                    return "Sobrepeso";
                else
                    return "Obesidad";
            }
        
   
    }
}
