using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    /// <summary>
    /// 6) Diseñar un algoritmo y construir un programa que 
    /// lea un número, en caso de que ese número sea 0 o 
    /// menor que 0, terminará el algoritmo imprimiendo antes 
    /// un mensaje de error, si es mayor que 0, se deberá 
    /// calcular su cuadrado, visualizando el número que ha 
    /// tecleado el usuario y su resultado (“Del numero X, 
    /// su potencia es X y su raíz X”).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = default(int);
            num1 = getNum(1);
            if (num1 <= 0)
            {
                Console.WriteLine($"Ingresa un número mayor a 0, no {num1}");
            }
            else
            {
                Console.WriteLine($"El cuadrado de {num1} es: {num1^2}");
                Console.WriteLine($"Su raíz cuadrada:" + Math.Sqrt(num1));
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
