using System;

namespace Fake.Acmicpc.Level7
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/2675
    /// </summary>
    class P2675
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            string result = null;

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var repeatCount = int.Parse(input[0]);
                string inputString = input[1];

                for (int factor = 0; factor < inputString.Length; factor++)
                {
                    for (int y = 0; y < repeatCount; y++)
                    {
                        result += inputString[factor];
                    }
                }

                result += "\n";
            }

            Console.WriteLine(result);
        }
    }
}
