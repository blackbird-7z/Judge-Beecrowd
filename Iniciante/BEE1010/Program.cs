using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        // Configura o ponto como separador padrão neste programa/thread.
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        string[] A = Console.ReadLine().Split(' ');
        string[] B = Console.ReadLine().Split(' ');

        double[] vetA = new double[A.Length];
        double[] vetB = new double[B.Length];


        for (int i = 0; i < A.Length; i++)
        {
            vetA[i] = double.Parse(A[i]);
        }

        for (int i = 0; i < B.Length; i++)
        {
            vetB[i] = double.Parse(B[i]);
        }

        double Total = vetA[1] * vetA[2] + vetB[1] * vetB[2];


        Console.WriteLine("VALOR A PAGAR: R$ " + Total.ToString("F2"));

    }

}