using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace proje3B_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ürünler ={"Dizüstü bilgisayar,Dell,XPS 13 9333 intel core i5,10,3799,5927",
                                   "Buzdolabı,Regal,CoolRGL 3000,45,699,929",
                                   "LandCruiser,Toyota,Prado,5,20000,250000",
                                   "iphone,Apple,iphone 5s 16 GB,17,1150,2500",
                                   "Piyano,Kawai,GX-5,15,12000,87000"};

            Heap heap = new Heap(5);
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                String[] parçaÜrün = ürünler[i].Split(',');
                heap.insert(Convert.ToInt32(parçaÜrün[4]));
            }
            Console.WriteLine("Yerleştirilen Maliyat:\n");
            heap.displayHeap();
            for (int i = 0; i < 2; i++)
            {
                heap.remove();
                arrayList.Add(heap.removedPrice);
            }
            Console.Write("\nMaliyeti En Düşük iki Ürün: ");
            foreach (int i in arrayList)
                Console.Write(i + "  ");
            Console.ReadKey();
        }
    }
}
