using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExam2
{
    class Adder1
    {
        public int val { get; set; }
        public static Adder3 operator + (Adder1 a1, Adder2 a2)
        {
            Adder3 a3 = new Adder3();
            a3.val = a1.val + a2.val;
            return a3;
        }
    }
    class Adder2
    {
        public int val { get; set; }
    }
    class Adder3
    {
        public int val { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adder1 a1 = new Adder1(); a1.val = 1;
            Adder2 a2 = new Adder2(); a2.val = 2;
            Adder3 a3 = a1 + a2;
            Console.WriteLine(a3.val);
        }
    }
}
