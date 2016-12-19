using System;

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
            //string builder 사용

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                var points = 0;
                var total = 0;

                for (int k = 0; k < input.Length; k++)
                {
                    if (input[k] == 'O')
                    {
                        points++;
                        total += points;
                    }
                    else
                        points = 0;
                }

                result += total.ToString();
                result += "\n";
            }

            Console.WriteLine(result);
        }
    }
}
