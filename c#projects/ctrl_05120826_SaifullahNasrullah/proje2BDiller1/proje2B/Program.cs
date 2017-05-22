using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace proje2B
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            List<progDil> listeb = new List<progDil>();
            for (int i = 1; i <= 5; ++i)
            {
                listeb = new List<progDil>();
                int sayi=fibinacci(i);
                for (int j = 1; j <=sayi; ++j)
                {
                    listeb.Add(new progDil());
                }
                liste.AddRange(listeb);
                Console.WriteLine(liste.Add(listeb));
            }
            Console.ReadLine();
        }
        static int fibinacci(int index)
        {
            int a = 0, b = 1;
            for (int i = 1; i <= 4; ++i)
            {
                index = a + b;
                a = b;
                b = index;
            }
            return index;
        }
    }
}
