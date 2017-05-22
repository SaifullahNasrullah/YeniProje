using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue theQueue = new Queue(5);//yapılandırıcı
            theQueue.inset(10);
            theQueue.inset(20);
            theQueue.inset(30);
            theQueue.inset(40);
            for (int i = 0; i < 3;++i)
                theQueue.remove();

            theQueue.inset(50);
            theQueue.inset(60);
            theQueue.inset(70);
            theQueue.inset(80);

            while (!theQueue.BosMu())
            {
                long num = theQueue.remove();
                Console.WriteLine(num);
                Console.WriteLine();
            } Console.ReadLine();
        }
        class Queue
        {
            private int maxSize;
            private long[] queArray;
            private int baş;
            private int son;
            private int elemanSay;

            public Queue(int s)
            {
                maxSize = s;
                queArray = new long[maxSize];
                baş = 0;
                son = -1;
                elemanSay = 0;
            }
            public void inset(long j)
            {
                if (son == maxSize - 1)
                    son = -1;
                queArray[++son] = j;
                elemanSay++;
            }
            public long remove()
            {
                long temp = queArray[baş++];
                if (baş == maxSize)
                    baş = 0;
                elemanSay--;
                return temp;
            }
            public long peekFront()
            {
                return queArray[baş];
            }
            public bool BosMu()
            {
                return elemanSay == 0;
            }
            public bool doluMu()
            {
                return elemanSay == maxSize;
            }
            public int size()
            {
                return elemanSay;
            }
        }
    }
}
