using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            */
            int numero, positivo;

            numero = int.Parse(Console.ReadLine());
            
            if((numero%2) == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
