using System;

namespace conversaoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculartempo();

        }
        static void Calculartempo()
        {
            Console.Clear();
            int time, timeHours, timeMinutes, timeSeconds;

            Console.WriteLine("Qual tempo você deseja calcular?");
            time = int.Parse(Console.ReadLine());
            Console.WriteLine($"{time} segundos");

            timeHours = time / 3600;
            //ex: 556 seg / 3660 = 0,1544

            timeSeconds = time - (timeHours * 3600);
            // 556 - (0,15 * 3600) = 556 - 540 = 16

            timeMinutes = timeSeconds / 60;
            // 16/60 =0,26

            timeSeconds = timeSeconds - (timeMinutes * 60);




            Console.WriteLine($"{timeHours}:{timeMinutes}:{timeSeconds}");

        }

    }
}

