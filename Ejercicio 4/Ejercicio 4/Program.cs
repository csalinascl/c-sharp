using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /// <summary>
    /// 4) Diseñar un algoritmo y construir un programa que lea 
    /// tres números distintos y nos diga cuál de ellos es el 
    /// mayor (recuerda usar la estructura condicional Si y los operadores 
    /// lógicos).
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
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} es mayor que {num2} y {num3}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} es mayor que {num1} y {num3}");

            }
            else
            {
                Console.WriteLine($"{num3} es mayor que {num1} y {num2}");
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
