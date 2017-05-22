using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3B_4
{
    class SimpleSort
    {
         public Int32[] dizi;
        public int boyut;

        public SimpleSort(int Boyut)
        {
            dizi = new Int32[Boyut];
            boyut = 0;
        }

        public void insert(int eklenen)
        {
            dizi[boyut] = eklenen;
            boyut++;
        }
        
        public void display()
        {
            Console.WriteLine("Dizideki Elemanlar: \n"
                            + "-------------------");
            for (int i = 0; i < boyut; i++)
                Console.WriteLine(dizi[i] + "  ");
        }
        public void selectionSort()
        {
            int indeks = 0;
            for (int i = 0; i < boyut-1; i++)
            {
                indeks = i;
                for (int j = i+1; j < boyut; j++)
                {
                    if (dizi[j] < dizi[indeks])
                        indeks = j;
                }
                if(indeks != i)
                    taşıma(i, indeks);
            }
        }

        public void taşıma(int a, int b)
        {
            Int32 geçici = dizi[a];
            dizi[a] = dizi[b];
            dizi[b] = geçici;
        }
    }
}
