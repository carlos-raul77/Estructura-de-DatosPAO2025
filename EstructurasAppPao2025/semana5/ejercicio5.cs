using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            numeros.Reverse();

            Console.WriteLine("Números del 10 al 1:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}