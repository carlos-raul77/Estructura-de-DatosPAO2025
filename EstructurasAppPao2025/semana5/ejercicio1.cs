using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main()
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            Console.WriteLine("Asignaturas del curso:");
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }
}