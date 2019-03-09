using System;

namespace Page156_이벤트_데이터_넘기기
{
    class EventPublisherArgs : System.EventArgs
    {
        public string myEventData;

        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }

    class EventPublisher
    { 
        //public delegate void MyEventHandler(object sender, EventPublisherArgs e);
        public event EventHandler MyEvent;

        public void Do()
        {
            if (MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args);
            }
        }
    }

    class Subscriber
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
            Console.WriteLine("이벤트 매개변수 :" + ((EventPublisherArgs)e).myEventData);
        }
    }
}
