using System;
using System.Globalization;
namespace areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
              casas decimais conforme exemplos.
              Fórmula da área: area = π . raio2
              Considere o valor de π = 3.14159
            */

            double pi = 3.14159, r, a;
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = pi * (r * a);

            Console.WriteLine("A="+area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
