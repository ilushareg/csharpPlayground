using System;
using System.Linq;

namespace Chapter1App
{
    public class TestStruct
    {
        public struct ExampleStruct
        {
            public int a;
            public float b;
            public double c;
            public ExampleStruct(params int[] val)
            {
                foreach (var q in val.AsEnumerable())
                {
                    Console.WriteLine(q);
                }
                a = 4;
                b = 0.0f;
                c = 0.0f;
            }

        };


        public static void Foo()
        {
            ExampleStruct st = new ExampleStruct(2,2,3,5,6);
            ExampleStruct st1;
            
        }
    }
}