////예제 1
//using System;

//delegate int SumDeli(int i, int j);
//class DeliTest
//{
//    static void Main()
//    {
//        SumDeli s1 = DeliTest.Sum1;
//        SumDeli s2 = new SumDeli(DeliTest.Sum2);
//        S(s1);
//        S(s2);
//    }
//    static void S(SumDeli s)
//    {
//        Console.WriteLine(s(1, 2));
//    }
//    static int Sum1(int i, int j)
//    {
//        return i + j;
//    }
//    static int Sum2(int i, int j)
//    {
//        return i + j + 100;
//    }
//}


////예제2
//using System;
//class Program
//{
//    public delegate int MyDelegate(int i, int j);
//    public static void Main()
//    {
//        TakesADelegate(new MyDelegate(Add));
//        TakesADelegate(new MyDelegate(Minus));
//        TakesADelegate(new MyDelegate(Gop));
//        TakesADelegate(new MyDelegate(Nanugi));
//    }
//    public static void TakesADelegate(MyDelegate SomeFunction)
//    {
//        Console.WriteLine(SomeFunction(1, 2));
//    }
//    public static int Add(int i, int j)
//    {
//        return i + j;
//    }
//    public static int Minus(int i, int j)
//    {
//        return i - j;
//    }
//    public static int Gop(int i, int j)
//    {
//        return i * j;
//    }
//    public static int Nanugi(int i, int j)
//    {
//        return i / j;
//    }
//}


////예제3
//using System;
//class Program
//{
//    delegate void Deli(string s);

//    static void Main()
//    {
//        // Specify delegate with Lambda Expression
//        Deli d0 = (v) => Console.WriteLine(v);

//        //Invoke delegate. 
//        d0.Invoke("OJC");

//        // Specify delegate with new Constructor 
//        Deli d1 = new Deli(d);
//        d1.Invoke("OJC");

//        // Specify delegate with method name 
//        Deli d2 = d;
//        d2.Invoke("OJC");
//    }
//    static void d(string s)
//    {
//        Console.WriteLine(s);
//    }
//}


//예제4
using System;
using System.Collections.Generic;
using System.Text;

namespace deledatetest
{
    delegate void OnjDelegate(int a, int b);

    class MainApp
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        void Multiplication(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        void Division(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }

        static void Main()
        {
            MainApp m = new MainApp();
            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
                new OnjDelegate(MainApp.Plus),
                new OnjDelegate(MainApp.Minus),
                new OnjDelegate(m.Multiplication),
                new OnjDelegate(m.Division));
            CallBack(4, 3);
        }
    }
}