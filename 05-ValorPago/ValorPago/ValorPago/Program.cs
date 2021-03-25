using System;
using System.Globalization;

namespace ValorPago
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
                código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */

            int codigo1, quantidade1, codigo2, quantidade2;
            double valor1, valor2, valorTotal;

            string[] vet1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet1[0]);
            quantidade1 = int.Parse(vet1[1]);
            valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            quantidade2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorTotal = (quantidade1 * valor1) + (quantidade2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
