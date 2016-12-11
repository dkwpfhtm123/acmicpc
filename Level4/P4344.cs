using System;

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

            string outcome = null;

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var total = 0.0;
                var averageAboveStudents = 0.0;

                int students = int.Parse(input[0]);

                for (int z = 1; z <= students; z++)
                    total += int.Parse(input[z]);

                var average = total / students;

                for (int z = 1; z <= students; z++)
                    if (int.Parse(input[z]) > average)
                        averageAboveStudents++;

                outcome += string.Format("{0:F3}", ((averageAboveStudents / students) * 100));
            }

            Console.WriteLine(outcome);
        }
    }
}
