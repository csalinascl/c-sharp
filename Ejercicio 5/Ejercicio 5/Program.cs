using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    /// <summary>
    /// 5) Diseñar un algoritmo y construir un programa que pida por teclado 
    /// tres números; si el primero es negativo, debe imprimir el 
    /// producto de los tres y si no lo es, imprimirá la suma.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = default(int);
            var num2 = default(int);
            var num3 = default(int);
            var temp = default(int);
            num1 = getNum(1);
            num2 = getNum(2);
            num3 = getNum(3);
            if (num1 < 0)
            {
                Console.WriteLine($"Producto de los tres números: {num1 * num2 * num3}");
            }
            else
            {
                Console.WriteLine($"Suma de los tres números: {num1 + num2 + num3}");

            }
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
