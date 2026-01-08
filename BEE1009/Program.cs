using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string Nome = Console.ReadLine();
        double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double VendasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double Total = SalarioFixo + VendasMes * 0.15;

        Console.WriteLine("TOTAL = R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));

    }

}