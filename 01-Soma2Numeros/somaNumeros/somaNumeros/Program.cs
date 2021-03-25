using System;

namespace somaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa */

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = x + y;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
