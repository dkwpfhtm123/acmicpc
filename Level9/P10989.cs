using System;

namespace Fake.Acmicpc.Level9
{
    class P10989
    {
        /// <summary>
        /// FAILED https://www.acmicpc.net/problem/9426
        /// </summary>

        static int MAX = 10000;

        static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            var array = new int[inputCount];

            var arrayCount = new int[inputCount + 1]; // 숫자의 등장횟수를 저장 //\ 모듈호 ㅏ먼저하기 값ㅅ정

            for (int i = 0; i < inputCount; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                arrayCount[i] = 0; // 등장횟수 초기화
            }

            for (int i = 0; i < inputCount; i++)
            {
                arrayCount[array[i]]++; // 어떤숫자가 몇번 등장했는지 구하기
            }

            var arrayCountSum = new int[inputCount + 1]; // 누적합
            arrayCountSum[0] = arrayCount[0]; // 첫번째 누적합 = 처음 숫자의 개수

            for (int i = 1; i <= inputCount; i++)
            {
                arrayCountSum[i] = arrayCountSum[i - 1] + arrayCount[i]; // 누적합 구하기
            }

            var result = new int[inputCount + 1];
            for (int i = inputCount; i > 0; i--) //--
            {
                result[arrayCountSum[array[i]]] = array[i];
                arrayCountSum[array[i]]--;
            }

            for (int i = 1; i <= inputCount; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
