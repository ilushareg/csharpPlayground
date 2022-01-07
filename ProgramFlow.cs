using System;
using System.Runtime.InteropServices;

namespace Chapter1App
{
    public class  ProgramFlow
    {
        public static void Foo()
        {
            Console.WriteLine("ProgramFlow.Foo() called");

            
            switch("one")
            {
                case "one":
                    //case block
                    Console.WriteLine(2);
                    break;
                
                case "two":
                       
                    //case block
                    Console.WriteLine("constant");
                    break;
                default:
                    //default case block
                    Console.WriteLine("default");
                    break; 
            }

            for (var s1 = 0; ++s1 < 10;)
            {
                Console.WriteLine(s1);
            }
        }
    }
}