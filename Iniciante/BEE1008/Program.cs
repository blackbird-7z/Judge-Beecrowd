using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int NUMBER = int.Parse(Console.ReadLine());
        int HOURS = int.Parse(Console.ReadLine());
        double VALUE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double SALARY = VALUE * HOURS;

        Console.WriteLine("NUMBER = " + NUMBER);
        Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));

    }

}