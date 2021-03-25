﻿using System;
using System.Globalization;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
                segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            */

            int n, numerador, denominador;
            double div;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                numerador = int.Parse(vet[0]);
                denominador = int.Parse(vet[1]);

                div = (double) numerador / denominador;

                if (denominador==0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
