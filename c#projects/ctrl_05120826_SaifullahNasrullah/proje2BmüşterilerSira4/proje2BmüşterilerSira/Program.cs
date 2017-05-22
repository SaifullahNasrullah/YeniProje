using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2BmüşterilerSira
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] beklemeSuresi = new double[15];
            Queue kuyruk = new Queue(15);
            Random rnd = new Random();

            for (int i = 0; i < (int)beklemeSuresi.Length; i++)
            {
                beklemeSuresi[i] = rnd.Next(10,75);
                beklemeSuresi[i] += rnd.NextDouble();
                kuyruk.insert((long)beklemeSuresi[i]);
            }
            Console.WriteLine("Kuyruk ile ekleniyor..");
            for (int i = 0; i < beklemeSuresi.Length;++i)
                Console.WriteLine(beklemeSuresi[i]);
            Console.WriteLine("Çıkarma işlemi başladı..");
            double çıkarılan, toplamçıkmış = 0;
            while (!kuyruk.isEmpty())
            {
                çıkarılan = kuyruk.remove();
                toplamçıkmış += çıkarılan;
            }
            double ortalam = toplamçıkmış / beklemeSuresi.Length;
            Console.WriteLine("Ortalama bekleme süresi kuyruk ile " + ortalam+" dakika");
//---------------------------------------------------------------------------------------------
            PriorityQ öncelik = new PriorityQ(15);
            for (int i = 0; i < (int)beklemeSuresi.Length; i++)
            {
                beklemeSuresi[i] = rnd.Next(10, 75);
                öncelik.insert((long)beklemeSuresi[i]);
            }
            Console.WriteLine("Öncelik Kuyruk ile ekleniyor..");
            for (int i = 0; i < beklemeSuresi.Length; ++i)
                  Console.WriteLine(beklemeSuresi[i]);

            double çıkarılan1, topÇıkmış = 0;
            Console.WriteLine("Çıkarma işlemi başladı..");
            while (!öncelik.isEmpty())
            {
                çıkarılan1 = öncelik.remove();
                topÇıkmış += çıkarılan1;
            }
            double ort1 = topÇıkmış / beklemeSuresi.Length;
            Console.WriteLine("Ortalama bekleme süresi öncelik kuyruk ile " + ort1+ " dakika");
//-------------------------------------------------------------------------------------------------------------
            StackX yığın = new StackX(15);
            for (int i = 0; i < (int)beklemeSuresi.Length; i++)
            {
                beklemeSuresi[i] = rnd.Next(10, 75);
                yığın.push((long)beklemeSuresi[i]);
            }
            Console.WriteLine("Yığın ile ekleniyor..");
            for (int i = 0; i < beklemeSuresi.Length; ++i)
                Console.WriteLine(beklemeSuresi[i]);
            double çıkarılan2,biten=0;
            while (!yığın.isEmpty())
            {
                çıkarılan2 = yığın.pop();
                biten += çıkarılan2;
            }
            double ortPop = biten / beklemeSuresi.Length;
            Console.WriteLine("Ortalama bekleme süresi yığın ile " + ortPop + " dakika");
            Console.ReadKey();
        }
    }
}
