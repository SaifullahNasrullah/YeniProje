using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ürünler ={"Dizüstü bilgisayar,Bilgisayar,Dell,XPS 13 9333 intel core i5,10,3799,5927",
                                   "Buzdolabı,Beyaz eşya,Regal,CoolRGL 3000,45,699,929",
                                   "LandCruiser,Araba,Toyota,Prado,5,20000,250000",
                                   "iphone,Telefon,Apple,iphone 5s 16 GB,17,1150,2500",
                                   "Piyano,Müzik Alet,Kawai,GX-5,15,12000,87000"};
            Tree ağaç = new Tree();


            Console.WriteLine("Ürünlerin İlk Hali:" +
                            "\n-------------------\n");
            for (int i = 0; i < 5; i++)
            {
                ÜrünNesnesi ürünNesnesi = new ÜrünNesnesi();
                string[] properties = ürünler[i].Split(',');//Dizideki her indeksini ,e göre ayırıyor...
                ürünNesnesi.ürünAdı = properties[0];
                ürünNesnesi.kategori = properties[1];
                ürünNesnesi.marka = properties[2];
                ürünNesnesi.model = properties[3];
                ürünNesnesi.miktar = Convert.ToInt32(properties[4]); //to int
                ürünNesnesi.maliyet = Convert.ToDouble(properties[5]); //to double
                ürünNesnesi.satışFiyatı = Convert.ToDouble(properties[6]);
                ürünNesnesi.yazdir();
                ağaç.insert(ürünNesnesi);
            }
            Console.WriteLine("\nÜrünlerin isimlerine Göre Sıralanması: "+
                              "\n--------------------------------------------\n");
            ağaç.inOrder(ağaç.getRoot());

            Console.WriteLine("\nİstatistikler:" +
                              "\n--------------");
            Console.WriteLine("\tAğacın Derinliği: " + ağaç.FindDepthOfTree(ağaç.getRoot())
                            + "\n\tAğacın Eleman Sayısı: " + ağaç.düğümSayısı
                            + "\n\tAğacın Düğümlerinin Derinlik Ortalaması: " + (double)(ağaç.sumOfDepth(ağaç.getRoot()) / ağaç.düğümSayısı)
                            + "\n\tToplam Kar Miktarı: " + ağaç.karToplamı);
            Console.ReadKey();

        }
    }
}
