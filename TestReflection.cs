using System;
using System.Reflection;

namespace Chapter1App
{
    interface IWrapper
    {
        void Set(object val);
    }

    public class WrapperInt:IWrapper
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
    public class TestReflection
    {
        public int testint = new int();
        static public void Foo()
        {
            var instance = new TestReflection();
            instance.testint = 10;
            var info = instance.GetType().GetField("testint");
            Console.WriteLine(instance.testint);
            instance.testint
            Console.WriteLine(instance.testint);

            
            object testobj = 12;

            IWrapper wrapper = new WrapperInt(ref instance.testint);
            wrapper.Set(testobj);            

            Console.WriteLine(instance.testint);
        }
    }
}