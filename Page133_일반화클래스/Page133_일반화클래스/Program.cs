﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page133_일반화클래스
{
    class Ojc<T>
    {
        private T[] ojcArr = new T[10];

        public T this[int i]
        {
            get { return ojcArr[i]; }
            set { ojcArr[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ojc<string> ojc1 = new Ojc<string>();
            ojc1[0] = "Hello, OJC";
            Console.WriteLine(ojc1[0]);

            Ojc<int> ojc2 = new Ojc<int>();
            ojc2[0] = 999;
            Console.WriteLine(ojc2[0]);
        }
    }
}
