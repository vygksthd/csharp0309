using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page140_Delegate
{    
    class Delegate
    {
        private delegate int OnjSum(int i, int j);
        static void Main(string[] args)
        {
            OnjSum myMethod = new OnjSum(Delegate.Sum);
            Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
        }
        static int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
