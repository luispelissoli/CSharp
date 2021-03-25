using System;
using System.Globalization;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
                de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
                conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
                peso 5.
            */

            int n;
            double nota1, nota2, nota3, media = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
