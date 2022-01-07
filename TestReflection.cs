using System;

namespace Chapter1App
{
    interface IWrapper
    {
        void Set(object val);
    }

    public class WrapperInt : IWrapper
    {
        private int? pointer;
        public WrapperInt(ref int val)
        {
            pointer = val;
        }

        public void Set(object val)
        {
            pointer = (int)val;
        }
    }
    public class Assigner
    {
        //Func<int> assigner;
        public Action<int> assignerFunc;
        public Assigner(Action<int> f)
        {
            assignerFunc = f;
        }
        public void Set(int val)
        {
            assignerFunc.Invoke((val));
        }
    }
    public class TestReflection
    {
        public int testint = new int();
        static public void Foo()
        {
            Assigner a;
            {
                var instance = new TestReflection();
                instance.testint = 10;
                var info = instance.GetType().GetField("testint");
                Console.WriteLine(instance.testint);
                int? tmp = 25;
                instance.testint = (int)(object)(tmp);
                Console.WriteLine(instance.testint);
                TestAssign(ref instance.testint);
                Console.WriteLine(instance.testint);


                object testobj = 12;

                IWrapper wrapper = new WrapperInt(ref instance.testint);
                wrapper.Set(testobj);

                Console.WriteLine(instance.testint);
                a = new Assigner((x) => { instance.testint = x; });
            }
            a.Set(101);
            //Console.WriteLine(instance.testint);
        }
        static public void TestAssign(ref int val)
        {
            int? tmp = 99;
            val = (int)(object)(tmp);

        }
    }
}