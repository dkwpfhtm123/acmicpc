using System;

namespace Fake.Acmicpc.Level4
{
    /// <summary>
    /// SUCCESS https://www.acmicpc.net/problem/1546
    /// </summary>
    static class P1546
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var values = Console.ReadLine().Split(' ');

            var grades = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
                grades[i] = int.Parse(values[i]);

            var max = 0;
            for (int i = 0; i < count; i++)
            {
                if (max < grades[i])
                    max = grades[i];
            }

            var result = 0.0;
            for (int i = 0; i < count; i++)
                result += ((double)grades[i] / max) * 100;

            Console.WriteLine("{0:F2}", result / count);
        }
    }
}