using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace proje2Böncelikuyruk
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQ thePQ = new PriorityQ(5);
            thePQ.insert(30);
            thePQ.insert(50);
            thePQ.insert(10);
            thePQ.insert(40);
            thePQ.insert(20);

            while (!thePQ.isEmpty())
            {
                long item = thePQ.remove();
                Console.WriteLine(item + "");
            }
            Console.ReadLine();
        }
        class PriorityQ
        {
            private int maxSize;
            private long[] queArray;
            private int nItems;

            public PriorityQ(int s)
            {
                maxSize = s;
                queArray = new long[maxSize];
                nItems = 0;
            }
            public void insert(long item)
            {
                int j;
                if (nItems == 0)
                {
                    queArray[++nItems] =item;
                }
                else
                {
                    for (j = nItems - 1; j >= 0; --j)
                    {
                        if (item > queArray[j])
                            queArray[j + 1] = queArray[j];
                        else break;
                    } queArray[j + 1] = item;
                    nItems++;
                }
            }
            public long remove()
            { return queArray[--nItems]; }
            public bool isEmpty()
            { return (nItems == 0); }
            public bool isFull()
            { return (nItems == maxSize); }
        }
    }
}
