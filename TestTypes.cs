using System;

namespace Chapter1App
{
    public class TestTypes
    {
        public static class Stat
        {
            static Stat()
            {
                Stat1.Foo();                
                Console.WriteLine("Stat");
            }

            public static void Foo()
            {
                a = 10;
            }
            private static int a = 0;

        }
        public static class Stat1
        {
            static Stat1()
            {
                Stat.Foo();
                Console.WriteLine("Stat1");
            }

            public static void Foo()
            {
                a = 15;
            }
            private static int a = 0;

        }
        public static void Foo()
        {
            Stat.Foo();
            Stat1.Foo();
            //anonymous
            var VarName = new {Name = "aaa", Age = 22};

            //dynamic

            var a = 0;
            //a = "qweasd"; //ERROR
            dynamic b = 0;
            b = "qweasd"; //No Error
            //a = a + b;
            try
            {
                a = a + b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
//                throw;
            }

        }
    }
}