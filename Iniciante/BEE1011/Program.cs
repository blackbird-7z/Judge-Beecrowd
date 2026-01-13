using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        // Usamos double para evitar o estouro de memória no cálculo do cubo
        double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pi = 3.14159;

        double volume = (4.0 / 3) * pi * Math.Pow(R, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}