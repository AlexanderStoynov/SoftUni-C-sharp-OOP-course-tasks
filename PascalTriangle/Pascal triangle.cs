using System;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];

            for (int i = 0; i < triangle.Length; i++)
            {

                triangle[i] = new long[i + 1];
                for (int j = 0; j < 1 + i; j++)
                {

                    if (j == 0)
                    {
                        triangle[i][j] = 1;
                        continue;
                    }

                    else if (j == triangle[i].Length - 1)
                    {
                        triangle[i][j] = 1;
                        continue;
                    }


                    else if (triangle.Length > 1)
                    {
                        long first = triangle[i - 1][j - 1];
                        long second = triangle[i - 1][j];
                        triangle[i][j] = first + second;
                    }
                }
            }

            for (int i = 0; i < triangle.Length; i++)
            {
                Console.WriteLine(String.Join(" ", triangle[i]));
            }
        }
    }
}
