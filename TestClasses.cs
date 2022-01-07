using System;
namespace Chapter1App
{
    public class TestClasses
    {
        class Parent
        {
            protected Parent()
            {
                Console.WriteLine("Child");
            }

            public virtual void Run()
            {
                Console.WriteLine("Base.Run");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("Parent");
            }

            public int counter = 0;

            public static Child operator ++(Child a)
            {
                a.counter++;
                return a;
            }

            public static Child operator +(Child a, int b)
            {
                var res = new Child();
                res.counter = a.counter + b;
                return res;
            }
            public static bool operator ==(Child a, int b)
            {
                return a.counter == b;
            }
            public static bool operator !=(Child a, int b)
            {
                return a.counter != b;
            }

            public override void Run()
            {
                Console.WriteLine("Child.Run1");
                base.Run();
                Console.WriteLine("Child.Run2");
            }
        }

        public abstract class ClassA
        {
            public int counter = 0;
            public abstract int getCount();
        }
        public interface ClassI
        {
            int getI();
        }

        public class TestAI : ClassA, ClassI
        {
            public TestAI()
            {
                
            }
            public int getI()
            {
                return 10;
            }

            public override int getCount()
            {
                return 20;
            }
        }
        public static void Foo()
        {
            // var p = new Child();
            // for (int q = 0; q < 10; q++)
            // {
            //     p=p+2;
            // }
            //
            // Console.WriteLine(p.counter);
            //
            // Parent p1 = p;
            // p1.Run();
            var q = new TestAI();
            ClassI a = q;
            ClassA a1 = q;
            Console.WriteLine(a.getI());
            Console.WriteLine(a1.getCount());
        }
    }
}