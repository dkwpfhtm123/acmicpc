using System;
using System.Text;
using System.Collections.Generic;

namespace Fake.Acmicpc.Level9
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/1181
    /// </summary>
    class P1181
    {
        static void Main(string[] args)
        {
            /*        var count = int.Parse(Console.ReadLine());
                    var array = new string[count];

                    for (int i = 0; i < count; i++)
                    {
                        array[i] = Console.ReadLine();
                    } */

            var test = new List<string> { "but", "i", "wont", "hesitate", "no", "more", "no", "more", "it", "cannot", "wait", "im", "yours" };

            Sort(test);
        }

        static void Sort(List<string> array)
        {
            var result = new StringBuilder();

            for (int k = array.Count; k > 0; k--)
            {
                var same = false;

                for (int i = 1; i < k; i++)
                {
                    if (StringEqual(array[i], array[i - 1]))
                    {

                        same = true; // result에 추가하지 않고 k-1;
                    }
                    else if (array[i].Length < array[i - 1].Length) // 길이가 긴 인자를 끝으로 이동
                    {
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                    else if (IntEqual(array[i].Length, array[i - 1].Length) == true) // 길이가 같다면
                    {
                        for (int m = 0; m < array[i].Length; m++)
                        {
                            if (Convert.ToInt32(array[i][m]) < Convert.ToInt32(array[i - 1][m])) // 내용이 다르면 인자를 이동하고 for문 강제종료
                            {
                                var temp = array[i];
                                array[i] = array[i - 1];
                                array[i - 1] = temp;
                                break;
                            }
                        }
                    }
                }

                if (same == false)
                    result.AppendLine(array[k - 1]);
            }

            Console.WriteLine(result);
        }

        static bool IntEqual(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }

        static bool StringEqual(string a, string b)
        {
            if (a == b)
                return true;
            else
                return false;
        }


    }
}
