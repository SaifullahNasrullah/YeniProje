using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2B2
{
    class Program
    {
        static void Main(string[] args)
        {
            StackX theStack = new StackX(10);
            theStack.push(20);
            theStack.push(40);
            theStack.push(60);
            theStack.push(80);
            while (!theStack.isEmpty())
            {
                long value = theStack.pop();
                Console.WriteLine(value);
                Console.WriteLine();
            } Console.ReadKey();
        }
    }
}
