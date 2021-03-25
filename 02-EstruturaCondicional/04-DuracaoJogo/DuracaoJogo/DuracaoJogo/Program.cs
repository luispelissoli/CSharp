using System;

namespace DuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
              começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            */

            int hIni, hFim, hTotal = 0;

            string[] vet = Console.ReadLine().Split(' ');
            hIni = int.Parse(vet[0]);
            hFim = int.Parse(vet[1]);

            if (hIni > hFim)
            {
                hFim += 24;
                hTotal = hFim - hIni;
            }
            else if (hIni < hFim)
            {
                hTotal = hFim - hIni;
            }

            else if (hIni == hFim)
            {
                hTotal = 24;
            }

            Console.WriteLine("O JOGO DUROU  " + hTotal + " HORA(S)");
        }
    }
}
