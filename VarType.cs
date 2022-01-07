using System;

namespace Chapter1App
{
    public class VarType
    {
        private class TestVal
        {
            public TestVal()
            {
                
            }
        }
        
        public static void Foo()
        {
            Console.WriteLine("VarType.Foo() called");
            var a = 1;
            //a = 1.0f;

        }        
    }
}