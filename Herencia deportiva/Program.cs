using BibliotecaEquipo;

internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador1 = new Jugador(4256872, "Julian Alvarez", 170, 80);
        Jugador jugador2 = new Jugador(4122522, "Enzo Fernandez", 90, 30);

        DirectorTecnico dt = new DirectorTecnico(29592542, "Marcelo Gallardo");
        DirectorTecnico dt2 = new DirectorTecnico(3201211, "Martin Demichelis");

        Console.WriteLine(jugador1.MostrarDatos());
        Console.WriteLine(dt.MostrarDatos());
        Console.WriteLine("/===========================================================\n");
        if (jugador1 == jugador2)
        {
            Console.WriteLine($"Son jugadores iguales:\n{jugador1.Nombre} y {jugador2.Nombre}");
        }
        else
        {
            Console.WriteLine($"Son jugadores dintintos:\n{jugador1.Nombre} y {jugador2.Nombre}");
        }
        Console.WriteLine("/===========================================================\n");
        if (dt == dt2)
        {
            Console.WriteLine($"Son dts iguales: \n{dt.Nombre} y {dt2.Nombre}");
        }
        else
        {
            Console.WriteLine($"Son dts dintintos: \n{dt.Nombre} y {dt2.Nombre}");
        }
        Console.WriteLine("/===========================================================\n");
        Equipo river = new Equipo(2, "River Plate");

        if (river + jugador1 && river + jugador2)
        {
            Console.WriteLine($"\nJugador {jugador1.Nombre} y jugador {jugador2.Nombre} agregados con exito");
        }
    }
}