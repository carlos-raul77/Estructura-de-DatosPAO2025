using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main()
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}