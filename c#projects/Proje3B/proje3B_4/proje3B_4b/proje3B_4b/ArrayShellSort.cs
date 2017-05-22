using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3B_4b
{
    class ArrayShellSort
    {
        public Int32[] dizi;
        public int boyut;

        public ArrayShellSort(int Boyut)
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

        public void shellSort()
        {
            int inner, outer;
            int temp;
            int h = 1;
            while (h <= boyut / 3)
                h = h * 3 + 1;
            while (h > 0)
            {
                for (outer = h; outer < boyut; outer++)
                {
                    temp = dizi[outer];
                    inner = outer;
                    while (inner > h - 1 && dizi[inner - h] >= temp)
                    {
                        dizi[inner] = dizi[inner - h];
                        inner -= h;
                    }
                    dizi[inner] = temp;
                } 
                h = (h - 1) / 3;
            } 
        } 
    }
}
