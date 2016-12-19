using System;

namespace Fake.Acmicpc.Level9
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/2751
    /// 병렬정렬 코드 이해 불가
    /// </summary>

    class P2751
    {
        static void Main(string[] args)
        {
        /*    var count = int.Parse(Console.ReadLine());

            var array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = int.Parse(Console.ReadLine()); */

            var test = new int[] { '5', '4', '3', '2', '1' };

            MergeSort(test, 0, 5 - 1);

            foreach (var i in test)
                Console.WriteLine(i);
        }

        static void merge(int[] array, int left, int mid, int end)
        {
            var low = left;
            var high = mid + 1;

            var temp = new int[array.Length];
            var tempnum = left;

            while (low <= high && high <= end)
            {
                if (array[low] < array[high])
                {
                    temp[tempnum] = array[low];
                    low++;
                }
                else
                {
                    temp[tempnum] = array[high];
                    high++;
                }
                tempnum++;
            }

            if (low > high)
            {
                for (int i = high; i <= end; i++)
                {
                    temp[tempnum] = array[i];
                    tempnum++;
                }
            }
            else
            {
                for (int i = low; i <= high; i++)
                {
                    temp[tempnum] = array[i];
                    tempnum++;
                }
            }

            for (int i = low; i <= end; i++)
                array[i] = temp[i];
        }

        static void MergeSort(int[] array, int left, int right)
        {
            // (left == right가 아니면) == (인자가 1개가 아니면) 분할 실행
            if (left < right)
            {
                var mid = (left + right) / 2;

                // mid 기준으로 2개로 나눔
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                merge(array, left, mid, right);
            }
        }
    }
}