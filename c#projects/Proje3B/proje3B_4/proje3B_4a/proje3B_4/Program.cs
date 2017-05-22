using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3B_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int boyut = 5;
            SimpleSort arr = new SimpleSort(boyut);

            for (int i = 0; i < boyut; i++)
            {
                int eleman = rnd.Next(1000);
                arr.insert(eleman);
            }
            arr.display();
            Console.WriteLine("\nDizideki elemanları sıralama..\n");
            arr.selectionSort();

            arr.display();
            Console.ReadKey();
        }
    }
}
