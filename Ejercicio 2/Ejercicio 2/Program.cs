using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /// <summary>
    /// 2) Diseñar un algoritmo y construir un programa que lea dos números, 
    /// luego calcule y escriba el valor de su suma, resta, producto y división.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = default(int);
            var num2 = default(int);
            num1 = getNum(1);
            num2 = getNum(2);
            Console.WriteLine($"Números: {num1}, {num2}");
            Console.WriteLine($"Suma: {num1 + num2}");
            Console.WriteLine($"Resta: {num1 - num2}");
            Console.WriteLine($"Prod: {num1 * num2}");
            Console.WriteLine($"Div: {num1 / num2}");
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
