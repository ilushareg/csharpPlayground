using System;

namespace Chapter1App
{
    public class TestLoop
    {
        public static void Foo()
        {
            {
                int count = 1;
                do //Do not check condition on first iteration
                {
                    Console.WriteLine("TestLoop " + count);
                    count++;
                } while (count <= 5); //check condition: if true, do block execute
            }

            {
                for (int count = 1; count <= 5; count++)
                {
                    Console.WriteLine("TestLoop " + count);
                }

            }
            {
                int[] array = { 1, 2, 3, 4, 5 };
                foreach (int item in array)
                {
                    array[2] = 50;
                    Console.WriteLine(item);
                }
            }
        }
    }
}