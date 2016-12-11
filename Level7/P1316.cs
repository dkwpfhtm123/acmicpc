using System;

namespace Fake.Acmicpc.Level7
{
    /// <summary>
    /// FAILED https://www.acmicpc.net/problem/1316
    /// </summary>
    class P1316
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var total = 0;

            for (int n = 0; n < count; n++)
            {
                var input = Console.ReadLine();

                var startASCII = 0;
                var check = true;

                for (int ASCII = 97; ASCII <= 122; ASCII++) // 97 = a , 122 = z
                {
                    var startNum = 0;
                    var alphabetCount = 0;

                    for (int i = 0; i < input.Length; i++)
                    {
                        var inputASCII = (int)input[i]; // 아스키코드 전환

                        if (inputASCII == ASCII)
                        {
                            if (startNum == 0)
                                startNum = i; // 알파벳이 시작하는 곳
                            startASCII = ASCII; // 어떤 알파벳인지 받음
                            alphabetCount++; // 단어안의 알파벳 개수
                        }
                    }

                    for (int i = 0; i < alphabetCount; i++)
                    {
                        var y = (int)input[startNum + i]; // 알파벳이 시작하는곳부터 알파벳 갯수만큼 확인
                        if (y != startASCII)
                            check = false; // 하나라도 아닐경우 false 전환
                    }
                }

                if (check == true)
                    total++;
            }

            Console.WriteLine(total);
        }
    }
}
