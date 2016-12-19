using System;

namespace Fake.Acmicpc.Level9
{
    /// <summary>
    /// SUCCESS https://www.acmicpc.net/problem/2750
    /// </summary>
    class P2750
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = int.Parse(Console.ReadLine());

            for (int k = count; k > 0; k--)
            {
                for (int i = 1; i < k; i++)
                {
                    var temp = array[i];
                    if (temp < array[i - 1])
                    {
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine(array[i]);
        }
    }
}
