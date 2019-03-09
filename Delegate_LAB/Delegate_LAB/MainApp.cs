////LAB 1
//using System;

//namespace Delegate_LAB
//{
//    delegate void OnjDelegate(int a, int b);

//    class MainApp
//    {
//        static void Plus(int a, int b)
//        {
//            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
//        }
//        static void Minus(int a, int b)
//        {
//            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
//        }
//        static void Multiplication(int a, int b)
//        {
//            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
//        }
//        static void Division(int a, int b)
//        {
//            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
//        }

//        static void Main()
//        {
//            Console.WriteLine("두 수를 n, m의 형태로 입력하세요");
//            string str = Console.ReadLine();
//            string[] sArr = str.Split(',');
//            int n = int.Parse(sArr[0]);
//            int m = int.Parse(sArr[1]);

//            OnjDelegate CallBack = MainApp.Plus;
//            CallBack += MainApp.Minus;
//            CallBack += MainApp.Multiplication;
//            CallBack += MainApp.Division;

//            CallBack(n, m);
//        }
//    }
//}


////LAB 2
//using System;
//public delegate void Callback();
//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass my = new MyClass();
//        //Direct call
//        my.MyMethod1();
//        my.MyMethod2();
//        Console.WriteLine("------------");
//        // Call via a delegate
//        // MyClass의 GetCallback(Callback callBack) 메소드를 호출하여
//        // MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요
//        my.GetCallback(my.MyMethod1);
//        my.GetCallback(my.MyMethod2);
//    }
//}
//public class MyClass
//{
//    public MyClass() { }
//    public void GetCallback(Callback callBack)
//    {
//        callBack();
//    }
//    public void MyMethod1()
//    {
//        Console.WriteLine("My Method 1");
//    }
//    public void MyMethod2()
//    {
//        Console.WriteLine("My Method 2");
//    }
//}


////LAB 3
//using System;
//using System.IO;
//namespace DelegateAppl
//{
//    class PrintString
//    {
//        static FileStream fs;
//        static StreamWriter sw;
//        // 델리게이트 선언
//        public delegate void printString(string ps);
//    // 콘솔화면에 출력
//    public static void WriteToScreen(string str)
//        {
//            Console.WriteLine("The String is: {0}", str);
//        }
//        //파일에 출력
//        public static void WriteToFile(string s)
//        {
//            fs = new FileStream("d:\\message.txt",
//            FileMode.Append, FileAccess.Write);
//            sw = new StreamWriter(fs);
//            sw.WriteLine(s);
//            sw.Flush();
//            sw.Close();
//            fs.Close();
//        }
//        // 델리게이트를 인자로 받아 실행
//        // 결국 델리게이트가 참조하는 메소드 실행된다.
//        public static void sendString(printString ps)
//        {
//            ps("The String is: Hello Korea~");
//        }
//        static void Main(string[] args)
//        {
//            printString ps1 = new printString(WriteToScreen);
//            printString ps2 = new printString(WriteToFile);
//            sendString(ps1);
//            sendString(ps2);
//            Console.ReadKey();
//        }
//    }
//}


////LAB 4
//using System;
//using System.Windows.Forms;

//delegate void DisplayMessage(string message);
//public class TestCustomDelegate
//{
//    public static void Main()
//    {
//        DisplayMessage messageTarget;
//        if (Environment.GetCommandLineArgs().Length > 1)
//            messageTarget = ShowWindowsMessage;
//        else
//            messageTarget = Console.WriteLine;
//        messageTarget("Hello, World!");
//    }
//    private static void ShowWindowsMessage(string message)
//    {
//        MessageBox.Show(message);
//    }
//}


//LAB 5
using System;

delegate void OnjDelegate(string str);

class MainApp
{
    static void Main()
    {
        string str = Console.ReadLine();
        char[] uchar = str.ToCharArray();
        int count = 0;
        foreach (char c in uchar)
        {
            uchar[count] = ToUpper(c);
            count++;
        }
        foreach (char c in uchar)
        {
            Console.Write(c);
        }
    }
    static char ToUpper(char a)
    {
        char newa = a;
        if (a > 96 && a < 123)
        {
            newa = (char)(a - 32);
        }
        return newa;
    }
}