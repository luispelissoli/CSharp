using System;
using System.Globalization;
namespace CalcValorLanche
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
              seguir, calcule e mostre o valor da conta a pagar.

                Código      Especificação       Preço
                1           Cachorro Quente     R$ 4.00
                2           X-Salada            R$ 4.50
                3           X-Bacon             R$ 5.00
                4           Torrada Simples     R$ 2.00
                5           Refrigerante        R$ 1.50
            */

            int cod, qtd;
            double total=0.0;

            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            if (cod == 1)
            {
                total = qtd * 4.00;
            }
            if (cod == 2)
            {
                total = qtd * 4.50;
            }
            if (cod == 3)
            {
                total = qtd * 5.00;
            }
            if (cod == 4)
            {
                total = qtd * 2.00;
            }
            if (cod == 5)
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
