using System;
internal class Program
{
    private static void Main(string[] args)
    {
        const int n = 4;
        const int m = 5;
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = (i + 1) * 10 + (j + 1);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "   ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            int sorOsszeg = 0;
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
                sorOsszeg += matrix[i, j];
            }
            Console.WriteLine(sorOsszeg);
        }

        for (int i = 0; i < m; i++)
        {
            int oszlopOsszeg = 0;
            for (int j = 0; j < n; j++)
            {
                oszlopOsszeg += matrix[j, i];
            }
            Console.Write(oszlopOsszeg + "\t");
        }
        Console.WriteLine();

        //atlozgatas

        int foatloOsszege = 0;
        for (int i = 0; i < n; i++)
        {
            foatloOsszege += matrix[i, i];
        }
        Console.WriteLine("Főátló összege: "+ foatloOsszege);


        int mellekatloOsszege = 0;
        for (int i = 0; i < n; i++)
        {
            mellekatloOsszege += matrix[i, 3-i];
        }
        Console.WriteLine("Főátló összege: "+ mellekatloOsszege);

        int foatloFelettiElemek = 0;
        for (int i = 0; i < m-1; i++)
        {
            for (int j = i+1; j < m; j++)
            {
                foatloFelettiElemek += matrix[i,j];
            }
        }
        Console.WriteLine("Főátlősdi felett: "+foatloFelettiElemek);

        int foatloAlattiElemek = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < i; j++)
            {
                foatloAlattiElemek += matrix[i, j];
            }
        }
        Console.WriteLine("Főátló alatt: "+foatloAlattiElemek);




    }
}