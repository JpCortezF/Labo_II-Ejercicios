using Biblioteca;
internal class Program
{
    private static void Main(string[] args)
    {
        Automovil auto = new Automovil(4, 4, EColor.Negro, 5, 3);
        Camion camion = new Camion(6, 2, EColor.Gris, 15, 1000);
        Moto moto = new Moto(2, 0, EColor.Rojo, 399);

        Console.WriteLine("| //       Automovil       // |");
        Console.WriteLine(auto.MostrarVehiculoTerrestre());
        Console.WriteLine("| //       Camion       // |");
        Console.WriteLine(camion.MostrarVehiculoTerrestre());
        Console.WriteLine("| //       Moto       // |");
        Console.WriteLine(moto.MostrarVehiculoTerrestre());
    }
}