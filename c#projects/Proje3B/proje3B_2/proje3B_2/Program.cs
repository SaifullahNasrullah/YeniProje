using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace proje3B_2
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
            Hashtable hstb = new Hashtable();
            ÜrünNesnesi obje = new ÜrünNesnesi();
            Console.WriteLine("Ürünleri hashtable,e eklenmesi:\n");
            for (int i = 0; i < ürünler.Length; ++i)
            {
                string[] parçalama = ürünler[i].Split(',');
                obje.adı = parçalama[0];
                obje.marka = parçalama[1];
                obje.model = parçalama[2];
                obje.miktar = Convert.ToInt32(parçalama[3]);
                obje.maliyet = Convert.ToDouble(parçalama[4]);
                obje.satişFiyat = Convert.ToDouble(parçalama[5]);
                hstb.Add(parçalama[0], obje);
                Console.WriteLine( obje.adı+ " markasi "+ obje.marka+ " modeli "+ obje.model+ " miktari " +obje.miktar
                                  +" maliyeti " +obje.maliyet+ " satış fiyatı " +obje.satişFiyat+"\n");

            }
            Console.WriteLine("Ürünlerin %5 indirimlerimle güncel hali :\n");
            Console.WriteLine("--------------------------------------------");
            foreach (DictionaryEntry indis in hstb)
            {
                ÜrünNesnesi newproduct = new ÜrünNesnesi();
                newproduct = (ÜrünNesnesi)indis.Value;
                double yeniFiyat = obje.fiyatGüncelle(newproduct);
                Console.WriteLine(newproduct.ürünAdı + " Markası: " + newproduct.marka + " Modeli: " + newproduct.model
                        + " Miktarı: " + newproduct.miktar + " Maliyeti: " + newproduct.maliyet + " Satış Fiyatı: " + newproduct.satişFiyat
                        + " İndirimli Fiyatı: " + yeniFiyat);
            }
            Console.ReadKey();
        }
    }
}
