using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExam
{
    class AddClass
    {        
        public static AddClass operator + (AddClass op1, AddClass op2)
        {
            AddClass a = new AddClass();
            a.val = op1.val + op2.val;
            return a;
        }
        public int val { get; set; }    //자동구현속성
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddClass a1 = new AddClass(); a1.val = 1;
            AddClass a2 = new AddClass(); a2.val = 2;
            AddClass a3 = a1 + a2;
            Console.WriteLine(a3.val);
        }
    }
}