﻿using System;

namespace ValorQuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
                 começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
                 exemplo.
            */

            int n, a,b,c;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                a = i;
                b = i * i;
                c = i * i * i;

                Console.Write(a + " " + b + " " + c);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
