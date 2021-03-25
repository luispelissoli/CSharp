using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
                 Lembrando que, por definição, fatorial de 0 é 1.
            */

            int n, x, fat=1;

            n = int.Parse(Console.ReadLine());
            x = n;
            if (n == 0)
            {
                fat = 1;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    fat *= x;
                    x--;
                }
            }
            Console.WriteLine(fat);
        }
    }
}
