using System;

namespace Chapter1App
{
    public class Array
    {
        public static void Foo()
        {
            Console.WriteLine("Array.Foo() called");
            int[] arrInt = new int[4];
            arrInt[0] = 1;
            arrInt[1] = 2;
            arrInt[2] = 3;
            arrInt[3] = 4;

            int[] arrInt2 = new int[4]{0, 1, 2, 3};


            int[,,] numbers = new int[,,] {{{1,2},{2,3}}, {{1,2},{2,3}},{{1,2},{2,3}}, {{1,2},{2,3}}};
            
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    for (int dep = 0; dep < numbers.GetLength(2); dep++)
                    {
                        Console.Write(numbers[row, col, dep]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}