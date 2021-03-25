using System;

namespace NegativoOuPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            */

            int numero;

            numero = int.Parse(Console.ReadLine());

            if (numero<0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
