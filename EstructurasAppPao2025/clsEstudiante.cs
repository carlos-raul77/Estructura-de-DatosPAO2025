using System;

public record Paciente(string Nombre, string Cedula, string Fecha, string Especialidad);

public class Agenda
{
    private Paciente[] turnos;
    private int contador;

    public Agenda(int capacidad)
    {
        turnos = new Paciente[capacidad];
        contador = 0;
    }

    public void AgregarTurno()
    {
        if (contador >= turnos.Length)
        {
            Console.WriteLine("Agenda llena.");
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Cédula: ");
        string cedula = Console.ReadLine();
        Console.Write("Fecha del turno: ");
        string fecha = Console.ReadLine();
        Console.Write("Especialidad: ");
        string especialidad = Console.ReadLine();

        turnos[contador++] = new Paciente(nombre, cedula, fecha, especialidad);
        Console.WriteLine("Turno registrado con éxito.");
    }

    public void MostrarTurnos()
    {
        Console.WriteLine("\n--- Turnos Registrados ---");
        for (int i = 0; i < contador; i++)
        {
            var p = turnos[i];
            Console.WriteLine($"{i + 1}. {p.Nombre} | {p.Cedula} | {p.Fecha} | {p.Especialidad}");
        }
    }

    public void BuscarTurno()
    {
        Console.Write("\nIngrese el nombre del paciente: ");
        string nombre = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < contador; i++)
        {
            if (turnos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                var p = turnos[i];
                Console.WriteLine($"Encontrado: {p.Nombre} | {p.Cedula} | {p.Fecha} | {p.Especialidad}");
                encontrado = true;
            }
        }

        if (!encontrado)
            Console.WriteLine("No se encontró el turno.");
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda(100);
        int opcion;

        do
        {
            Console.WriteLine("\n--- Menú de Agenda Clínica ---");
            Console.WriteLine("1. Agregar turno");
            Console.WriteLine("2. Mostrar turnos");
            Console.WriteLine("3. Buscar turno por nombre");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: agenda.AgregarTurno(); break;
                case 2: agenda.MostrarTurnos(); break;
                case 3: agenda.BuscarTurno(); break;
            }
        } while (opcion != 0);
    }
}
