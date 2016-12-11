using System;

namespace Fake.Acmicpc.Level4
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/1110
    /// </summary>
    class P1110
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var result = 0;
            var ten = input / 10;
            var one = input % 10;

            var cycle = 0;

            for (; input != result; cycle++)
            {
                var temp = ten + one;
                ten = one;
                one = temp % 10;
                result = ten * 10 + one;
            }

            Console.WriteLine(cycle);
        }
    }
}
