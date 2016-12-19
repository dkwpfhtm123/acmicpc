using System;

namespace Fake.Acmicpc.Level2
{
    class P2839
    {
        /// <summary>
        /// FALSE https://www.acmicpc.net/problem/2839
        /// </summary>
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var result = 0;

            if (input % 5 == 0)
            {
                var five = input / 5;
                result += five;
            }
            else if (input % 3 == 0)
            {
                var three = input / 3;
                var five = three / 5;
                if (five > 0)
                {
                    result += five * 3;
                    result += three % 5;
                }
                else
                {
                    result += three;
                }
            }
            else if ((input % 5 % 3) == 0 )
            {
                result += input / 5;
                result += input % 5 / 3;
            }
            else if(input % 8 == 0)
            {
                result += input / 8 * 2;
            }
            else
            {
                result = -1;
            }

            Console.WriteLine(result);
        }
    }
}
