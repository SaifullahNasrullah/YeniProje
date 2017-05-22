using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2B2
{
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
