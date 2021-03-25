using System;

namespace DiferencaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            int x, b, c, d, diferenca;

            x = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = ((x * b) - (c * d));

            Console.WriteLine("DIFERENCA = " + diferenca);

        }
    }
}
