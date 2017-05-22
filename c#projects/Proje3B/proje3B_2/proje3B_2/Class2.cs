using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3B_2
{
    class ÜrünNesnesi
    {
        public string adı, marka, model;
        public int miktar;
        public double maliyet, satişFiyat;
        public double fiyatGüncelle(ÜrünNesnesi ürün)
        {
            return ürün.satişFiyat * 0.95;
        }

        public string ürünAdı { get; set; }
    }
}
