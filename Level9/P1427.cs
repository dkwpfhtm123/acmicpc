using System;

namespace Fake.Acmicpc.Level9
{
    /// <summary>
    /// SUCCESS https://www.acmicpc.net/problem/1427
    /// </summary>
    class P1427
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i].ToString());
            }

            Sort(array);
        }

        static void Sort(int[] array)
        {
            for (int k = array.Length; k > 0; k--)
            {
                for (int i = 1; i < k; i++)
                {
                    if (array[i] > array[i - 1]) // 숫자가 작으면 끝으로 밀려남
                    {
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]);
        }
    }
}
