﻿using System;

namespace somaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa */

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
