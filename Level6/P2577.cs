using System;

namespace Fake.Acmicpc.Level5
{
    /// <summary>
    /// SUCCESS https://www.acmicpc.net/problem/2577
    /// </summary>
    class P2577
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Module((a * b * c).ToString());
        }

        static void Module(string result)
        {
            int[] count = new int[10];


            for (int i = 0; i < result.Length; i++)
            {
                var temp = int.Parse(result[i].ToString());
                count[temp]++;
            }

            for (int i = 0; i < count.Length; i++)
                Console.WriteLine(count[i]);
        }
    }
}
