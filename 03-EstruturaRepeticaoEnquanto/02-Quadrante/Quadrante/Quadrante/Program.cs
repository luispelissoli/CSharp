using System;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
                cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
                menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
            */

            int x=1, y=1;

            while ((x !=0) && (y != 0))
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if ((x > 0) && (y > 0))
                {
                    Console.WriteLine("Primeiro");
                }
                else if ((x < 0) && (y > 0))
                {
                    Console.WriteLine("Segundo");
                }
                else if ((x < 0) && (y < 0))
                {
                    Console.WriteLine("Terceiro");
                }
                else if ((x > 0) && (y < 0))
                {
                    Console.WriteLine("Quarto");
                }
            }
        }
    }
}
