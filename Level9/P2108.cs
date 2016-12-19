using System;

namespace Fake.Acmicpc.Level9
{
    class P2108
    {
        static void Main(string[] args)
        {

            var count = int.Parse(Console.ReadLine()); // 홀수
            var array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Avearage(array);
            Middle(array);
            ManyNumber(array);
            Max_Min(array);
        }

        // 빠르게 정렬하는 방법을 못품

        static void Avearage(int[] array)
        {

        }

        static void Middle(int[] array)
        {

        }

        static void ManyNumber(int[] array)
        {

        }

        static void Max_Min(int[] array)
        {

        }
    }
}
