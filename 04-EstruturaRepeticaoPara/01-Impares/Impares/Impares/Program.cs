﻿using System;

namespace Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
                X, se for o caso.
            */

            int x;

            x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
