using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class SunumKonuları
    {
        string[] konular;
        int[] kapasite;
        Ogrenci[,] currentOgrenciler;
        int[] currentCount;
        public SunumKonuları()
        {
            konular = new string[10] {"Genetik Algoritmalar", "Bulanık Mantık","Makine Öğrenmesi",
             "Öngörüye Dayalı Analitik","Zeki Sistemler","Uzman Sistemler", "Doğal Dil İşleme",
             "Robotbilimde Yapay Zeka" , "Veri Madenciliği" ," Karınca Kolonisi Algoritmaları" };
            kapasite = new int[10] {4,4,4,4,4,4,3,3,3,3 };
            currentCount= Enumerable.Repeat(0,10).ToArray();//initializing the integer array with a single value
            currentOgrenciler = new Ogrenci[10,4];
            for (int i = 0; i < 10; i++) for (int j = 0; j < 4; j++) currentOgrenciler[i, j] = null;
        }
        public void balacedDistribution(Ogrenci[] ogrenciler)
        {
            int sayi = 0;
            int[] mevcut = Enumerable.Repeat(0,10).ToArray();
            while (sayi != ogrenciler.Length)
            {
                for (int i = 0; i < kapasite.Length; i++)
                {
                    currentCount[i]++;
                    currentOgrenciler[i, mevcut[i]++] = ogrenciler[sayi];
                    if((++sayi) == ogrenciler.Length)
                        break;
                }
            }
        }
        public void printCountsAndInfos(Form1 form)
        {
            for (int i = 0; i < konular.Length; i++)
            {
                string konu = konular[i];
                form.printToListBox(konu);
                for (int j = 0; j < 4; j++)
                {
                    if (currentOgrenciler[i, j] != null)
                        form.printToListBox("   "+(j+1)+"." +currentOgrenciler[i, j].ad + " " + currentOgrenciler[i, j].soyad);
                }
            }
        }
    }
}
