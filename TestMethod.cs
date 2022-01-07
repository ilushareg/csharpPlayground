using System;
namespace Chapter1App
{
    public class TestMethod
    {
        public static void testFoo(int a = 0, int b=1)
        {
            int k = b - a;
            Console.WriteLine("TestMethod k=" + k);
        }

        public static void testRef(ref int a)
        {
            a = a * 2;
        }

        public static void testOut(out int a)
        {
            a = 44;
        }

        public static int testParams(params int[] arg)
        {
            int res = 0;
            foreach (int q in arg)
            {
                res += q;
            }

            return res;
        }
            
        public static void Foo()
        {
            int test = 3;
            Console.WriteLine("Before testRef test=" + test);
            testRef(ref test);
            Console.WriteLine("After testRef test=" + test);

            int test1;
            testOut(out test1);
            Console.WriteLine("After testOut testOut=" + test1);
            
            testFoo(1, 5);
            testFoo(b:5, a:test);
            testFoo(1);
            testFoo();

            Console.WriteLine("testParams=" + testParams(1, 2));
            Console.WriteLine("testParams=" +  testParams(3, 5, 6));

        }
    }
}