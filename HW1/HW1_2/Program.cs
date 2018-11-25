// Написать программу для решения следующей задачи.
// В первый день пловец проплыл 3 км. В каждый следующий день он проплывал на 10% больше, чем в предыдущий.
//     а) В какой по счету день пловец начнет проплывать более 5 км?
//     б) К какому дню он суммарно проплывет более 30 км? 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = 3;
            double sumLenght = lenght;
            int countDayForMoreFivekm = 1;
            int countDayForSumMoreThirtykm = 1;
            double percent = 0.1;
            Console.WriteLine("В первый день пловец проплыл 3 км.");
            Console.WriteLine("В каждый следующий день он проплывал на 10% больше, чем в предыдущий.");
            while (sumLenght <= 30d && lenght <= 5d)
            {
                lenght = lenght + lenght * percent;
                sumLenght += lenght;
                if (lenght <= 5d)
                    countDayForMoreFivekm++;
                if (sumLenght <= 30d)
                    countDayForSumMoreThirtykm++;
            }
            Console.WriteLine($"Пловец начнет проплывать более 5 км через {countDayForMoreFivekm} дней");
            Console.WriteLine($"Пловец суммарно проплывет более 30 км через {countDayForSumMoreThirtykm} дней");
            Console.ReadKey();
        }
    }
}
