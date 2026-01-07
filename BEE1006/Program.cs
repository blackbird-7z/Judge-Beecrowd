using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        // Conteúdo sobre médias ponderadas:
        // https://pt.wikipedia.org/wiki/M%C3%A9dia_aritm%C3%A9tica_ponderada

        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pesoNotaA = 2.0;
        double pesoNotaB = 3.0;
        double pesoNotaC = 5.0;

        double MEDIA = (A * pesoNotaA + B * pesoNotaB + C * pesoNotaC) / (pesoNotaA + pesoNotaB + pesoNotaC);

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
    }

}