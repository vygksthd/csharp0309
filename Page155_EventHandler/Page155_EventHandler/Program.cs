using System;

namespace Page155_EventHandler
{
    class EventPublisher
    {
        public event EventHandler MyEvent;
        public void Do()
        {
            if(MyEvent != null)
            {
                MyEvent(null, null);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            p.Do();
        }

        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생...");
        }
    }
}
