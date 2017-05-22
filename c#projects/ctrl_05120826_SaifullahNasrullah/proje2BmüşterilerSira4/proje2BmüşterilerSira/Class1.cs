using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2BmüşterilerSira
{
    class Queue
    {
        private int maxSize;
        private long[] queArray;
        private int front;
        private int rear;
        private int nItems;
        //--------------------------------------------------------------
        public Queue(int s) // constructor
        {
            maxSize = s;
            queArray = new long[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }
        public void insert(long j) // put item at rear of queue
        {
            if (rear == maxSize - 1) // deal with wraparound
                rear = -1;
            queArray[++rear] = j; // increment rear and insert
            nItems++; // one more item
        }
        //--------------------------------------------------------------
        public long remove() // take item from front of queue
        {
            long temp = queArray[front++]; // get value and incr front
            if (front == maxSize) // deal with wraparound
                front = 0;
            nItems--; // one less item
            return temp;
        }
        //--------------------------------------------------------------
        public long peekFront() // peek at front of queue
        {
            return queArray[front];
        }
        //--------------------------------------------------------------
        public bool isEmpty() // true if queue is empty
        {
            return (nItems == 0);
        }
        //--------------------------------------------------------------
        public bool isFull() // true if queue is full
        {
            return (nItems == maxSize);
        }
        //--------------------------------------------------------------
        public int size() // number of items in queue
        {
            return nItems;
        }
    }
//--------------------------------------------------------------------------------------------------------------------
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
                queArray[++nItems] = item;
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
//--------------------------------------------------------------------------------------------------------------------------------------
    class StackX
    {
        private int maxSize; // size of stack array
        private long[] stackArray;
        private int top; // top of stack

        public StackX(int s)
        {
            maxSize = s;
            stackArray = new long[maxSize];
            top = -1;
        }
        public void push(long j)
        {
            stackArray[++top] = j;
        }
        public long pop()
        {
            return stackArray[top--];
        }
        public long peek()
        {
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return top == -1;
        }
        public long isFull()
        {
            return top = maxSize;
        }

    }

}
