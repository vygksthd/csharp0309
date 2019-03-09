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
            Action myHello = SayHelloKr;
            SayHello(myHello);
            myHello = SayHelloEn;
            SayHello(myHello);
        }
        static void SayHello(Action hello)
        {
            hello();
        }
        static void SayHelloKr()
        {
            Console.WriteLine("안녕...");
        }
        static void SayHelloEn()
        {
            Console.WriteLine("Hello...");
        }
    }
}
