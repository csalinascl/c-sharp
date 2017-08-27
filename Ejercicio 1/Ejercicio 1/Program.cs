using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /// <summary>
    /// 1) Diseñar un algoritmo y construir un programa que solicite al usuario dos variables 
    /// numéricas número1 y número2, posterior a lo anterior, intercambie los valores de 
    /// ambas variables y muestre cuánto valen al final las dos variables.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = default(int);
            var num2 = default(int);
            var temp = default(int);
            num1 = getNum(1);
            num2 = getNum(2);
            temp = num2;
            num2 = num1;
            num1 = temp;
            Console.WriteLine($"Variable num1: {num1}, num2: {num2}");
            Console.ReadKey();
        }

        /// Comprobación de input gracias a Cristian Ormazábal
        static int getNum(int index)
        {
            Console.WriteLine($"Ingrese ún número {index}");
            int num = default(int);
            var line = default(string);
            while (!int.TryParse(line = Console.ReadLine(), out num))
                Console.WriteLine($"{line} no es un número");
            return num;
        }
    }
}
