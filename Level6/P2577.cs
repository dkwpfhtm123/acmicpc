using System;

namespace Fake.Acmicpc.Level5
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/2577
    /// </summary>
    class P2577
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int[] count = new int[10];

            for (int i = 0; i < count.Length; i++)
                count[i] = 0;

            var result = a * b * c;

            int cipher = 10;
            int ciphernumber = 0;

            while (result % cipher != result)
            {
                cipher *= 10;
                ciphernumber++;
            }

            int checkCipher = 10;

            for (int i = 0; i < ciphernumber; i++)
            {
                var num = (result / checkCipher) % 10;

                if (num == 1)
                    count[1] += 1;
                else if (num == 2)
                    count[2] += 1;
                else if (num == 3)
                    count[3] += 1;
                else if (num == 4)
                    count[4] += 1;
                else if (num == 5)
                    count[5] += 1;
                else if (num == 6)
                    count[6] += 1;
                else if (num == 7)
                    count[7] += 1;
                else if (num == 8)
                    count[8] += 1;
                else if (num == 9)
                    count[9] += 1;
                else
                    count[0] += 1;

                checkCipher *= 10;
            }

            for (int i = 0; i < count.Length; i++)
                Console.WriteLine(count[i]);
        }
    }
}
