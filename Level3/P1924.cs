using System;
using System.Collections.Generic;

namespace Fake.Acmicpc.Level3
{
    /// <summary>
    /// SUCCESS https://www.acmicpc.net/problem/1924
    /// </summary>
    class P1924
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var month = int.Parse(input[0]);
            var day = int.Parse(input[1]);

            var totalDays = 0;

            for (int i = 1; i < month; i++)
            {
                if (i == 4 || i == 6 || i == 9 || i == 11)
                    totalDays += 30;
                else if (i == 2)
                    totalDays += 28;
                else
                    totalDays += 31;
            }

            totalDays += day;

            var result = totalDays % 7;

            var dayweek = new List<string> { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

            Console.WriteLine(dayweek[result]);
        }
    }
}
