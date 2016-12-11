using System;
using System.Text;

namespace Fake.Acmicpc.Level4
{
    /// <summary>
     /// FAILED https://www.acmicpc.net/problem/4344
     /// </summary>
    class P4344
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var output = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                var inputStrings = Console.ReadLine().Split(' ');
                var input = new int[inputStrings.Length];

                for (var k = 0; k < inputStrings.Length; k++)
                    input[k] = int.Parse(inputStrings[k]);

                var total = 0;
                var students = input[0];

                for (int z = 1; z <= students; z++)
                    total += input[z];

                var average = total / students;
                var averageAboveStudents = 0;

                for (int z = 1; z <= students; z++)
                {
                    if (input[z] > average)
                        averageAboveStudents++;
                }

                output.AppendFormat("{0:F3}%", (((double)averageAboveStudents / students) * 100.0));
                output.AppendLine();
            }

            Console.WriteLine(output.ToString());
        }
    }
}
