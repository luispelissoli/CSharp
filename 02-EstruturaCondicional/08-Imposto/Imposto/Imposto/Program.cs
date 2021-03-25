using System;
using System.Globalization;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
                que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
                qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
                Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
                mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

                Renda                                           Imposto de Renda
                de 0.0 a R$ 2000.00                             Isento
                de R$ 2000.1 até R$ 3000.00                     08%
                de R$ 3000.1 até R$ 4500.00                     18%
                acima de R$ 4500.00                             28%

                Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
                salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
                de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
                duas casas decimais.
            */

            double salario, salImposto, valImposto, valImposto2, total, valImposto3;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else if ((salario > 2000.0) && (salario <= 3000.0))
            {
                salImposto = salario - 2000.0;
                valImposto = (salImposto * 8) / 100;
                Console.WriteLine("R$ " + valImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if ((salario > 3000.0) && (salario <= 4500.0))
            {
                salImposto = salario - 3000.0;
                valImposto = (1000 * 8) / 100;

                valImposto2 = (salImposto * 18) / 100;
                total = valImposto + valImposto2;

                Console.WriteLine("R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 4500.00)
            {
                salImposto = salario - 4500.0;
                valImposto = (1000 * 8) / 100;

                valImposto2 = (1500 * 18) / 100;

                valImposto3 = (salImposto * 28) / 100;

                total = valImposto + valImposto2+ valImposto3;
                Console.WriteLine("R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
