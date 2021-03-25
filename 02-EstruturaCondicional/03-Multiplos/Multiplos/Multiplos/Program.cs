using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
              Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
              ordem crescente ou decrescente.
            */

            int a, b, c = 0, mult;
            double div;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a > b)
            {
                c = a;
                a = b;
                b = c;

                div = (int)b / a;
                mult = (int)div * a;
            }
            else
            {
                div = (int)b / a;
                mult = (int)div * a;
            }

            if (mult == b)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
