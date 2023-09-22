using LibrarySumador;
internal class Program
{
    private static void Main(string[] args)
    {
        Sumador sumador = new Sumador();
        Sumador sumador2 = new Sumador();

        Console.WriteLine($"Suma string: {sumador.Sumar("hola", "bien?")}");
        Console.WriteLine($"Suma int: {sumador.Sumar(1, 5)}");
        Console.WriteLine($"Suma string: {sumador2.Sumar("sisi", "vos?")}");
        Console.WriteLine($"Cantidad de sumas: {sumador.CantidadSumas + sumador2.CantidadSumas}");

        bool result = sumador | sumador2;
        Console.WriteLine(result);
    }
}