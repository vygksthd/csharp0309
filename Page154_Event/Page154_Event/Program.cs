using System;

namespace Page154_Event
{
    class EventPublisher
    {
        public delegate void MyEventHandler();
        public event MyEventHandler MyEvent;
        public void Do()
        {
            MyEvent?.Invoke();
        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventPublisher.MyEventHandler(doAction);
            p.Do();
        }
        static void doAction()
        {
            Console.WriteLine("MyEvent라는 이벤트 발생...");
        }
    }
}
