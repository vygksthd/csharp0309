using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page140_Delegate
{    
    class Delegate
    { 
        static void Main(string[] args)
        {
            Action<int, int> myMethod = Sum;
            myMethod(10, 30);
        }
        static void Sum(int i, int j)
        {
            Console.WriteLine(i + j);
        }
    }
}
