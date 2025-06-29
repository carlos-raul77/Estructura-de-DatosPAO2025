using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            Dictionary<string, float> notas = new Dictionary<string, float>();

            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Ingrese la nota de {asignatura}: ");
                float nota = float.Parse(Console.ReadLine());
                notas[asignatura] = nota;
            }

            Console.WriteLine("\nNotas registradas:");
            foreach (var item in notas)
            {
                Console.WriteLine($"En {item.Key} has sacado {item.Value}");
            }
        }
    }
}