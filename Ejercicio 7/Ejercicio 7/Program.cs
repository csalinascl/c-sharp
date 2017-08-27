using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    /// <summary>
    /// 7) Diseñar un algoritmo y construir un programa que permita 
    /// ingresar una cadena de caracteres por teclado, lea el ancho 
    /// de esta cadena y lo muestre en pantalla, transforme todas 
    /// las minúsculas de la cadena en mayúsculas.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Escribe algo a continuación...");
            var cadena = Console.ReadLine();
            Console.WriteLine($"\nEscribiste: " + cadena.ToUpper() + "\n \ncon un largo de: " + cadena.Length + " caracteres");
            Console.ReadKey();
        }
    }
}
