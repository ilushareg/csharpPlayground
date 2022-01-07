using System;
using System.Collections.Generic;

namespace Chapter1App
{
    public class TestEvents
    {
        public event Action<IEnumerable<object>> onSelectionChange;

        static public void Foo()
        {
            TestEvents t = new TestEvents();
            t.onSelectionChange += objects => t.OnAction(objects);
            List<object> l = new List<object>();
            l.Add("test");
            l.Add("test1");
            
            t.onSelectionChange(l);
        }

        public void OnAction(IEnumerable<object> objects)
        {
            foreach (var obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}