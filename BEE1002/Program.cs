using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pi5 = Math.Round(Math.PI, 5); // Pegar apenas 5 casas decimais após o ponto.
        double area = pi5 * n * n;

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }
}