using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExplanation
{
    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 100000; i++)
            {
                obj(i);
            }
        }
    }
}
