using Billetes;
internal class Program
{
    private static void Main(string[] args)
    {
        Euro billeteEuro = 10;
        Peso billetePeso;
        Dolar billeteDolar = 10;

        Console.WriteLine("*********** CONVERSION A PESOS **********");
        Console.WriteLine("-------------------------------------------");
        billetePeso = (Peso)billeteEuro;
        Console.WriteLine($"{billeteEuro.Cantidad} euros a Pesos: {billetePeso.Cantidad}");

        billetePeso = (Peso)billeteDolar;
        Console.WriteLine($"{billeteDolar.Cantidad} dolares a Pesos: {billetePeso.Cantidad}\n");


        Console.WriteLine("*********** CONVERSION A DOLARES **********");
        Console.WriteLine("-------------------------------------------");
        billetePeso = 5000;
        billeteDolar = (Dolar)billetePeso;
        Console.WriteLine($"{billetePeso.Cantidad} Pesos convertidos a Dolares: {billeteDolar.Cantidad}");

        billeteDolar = (Dolar)billeteEuro;
        Console.WriteLine($"{billeteEuro.Cantidad} euros a Dolares: {billeteDolar.Cantidad}\n");

        Console.WriteLine("*********** CONVERSION A EUROS **********");
        Console.WriteLine("-------------------------------------------");

        billeteEuro = (Euro)billetePeso;
        Console.WriteLine($"{billetePeso.Cantidad} Pesos convertidos a Euros: {billeteEuro.Cantidad}");

        billeteDolar = 10;
        billeteEuro = (Euro)billeteDolar;
        Console.WriteLine($"{billeteDolar.Cantidad} Dolares convertidos a Euros: {billeteEuro.Cantidad}");
    }
}