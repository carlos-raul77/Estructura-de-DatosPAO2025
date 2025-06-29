using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Ingrese 6 números ganadores de la lotería:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            numeros.Sort();

            Console.WriteLine("\nNúmeros ganadores ordenados:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
        }
    }
}