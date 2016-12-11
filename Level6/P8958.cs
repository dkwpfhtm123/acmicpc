using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fake.Acmicpc.Level5
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/8958
    /// </summary>
    class P8958
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            string result = null;

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                var plus = 0;
                var total = 0;

                for (int y = 0; y < input.Length; y++)
                {
                    if (input[y] == 'O')
                        plus++;
                    else
                        plus = 0;

                    total += plus;
                }

                result += total.ToString();
                result += "\r\n";
            }

            Console.WriteLine(result);
        }
    }
}
