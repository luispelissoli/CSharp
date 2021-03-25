using System;
using System.Globalization;

namespace CalculosArea
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
               mostre:
               a) a área do triângulo retângulo que tem A por base e C por altura.
               b) a área do círculo de raio C. (pi = 3.14159)
               c) a área do trapézio que tem A e B por bases e C por altura.
               d) a área do quadrado que tem lado B.
               e) a área do retângulo que tem lados A e B.
            */

            double  a, b, c;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // Calculo da área do triângulo retângulo que tem A por base e C por altura.

            double areaTriRet;
            areaTriRet = (a * c) / 2;

            // Calculo da área do círculo de raio C. (pi = 3.14159)

            double pi = 3.14159, areaCirculo;
            areaCirculo = pi * (c * c);

            // Calculo da área do trapézio que tem A e B por bases e C por altura.

            double areaTrapezio;
            areaTrapezio = ((a + b) * c) / 2;

            //Calculo da área do quadrado que tem lado B.

            double areaQuadrado;
            areaQuadrado = b * b;

            //Calculo da área do retângulo que tem lados A e B.

            double areaRetangulo;
            areaRetangulo = a * b;

            //Exibindo os Resultados

            Console.WriteLine("TRIANGULO: " + areaTriRet.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
