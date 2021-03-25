using System;
using System.Globalization;

namespace salarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
               hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
               decimais.
            */

            int number, hours;
            double salary,valueHour;

            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = valueHour * hours;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
