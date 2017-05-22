using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace proje2B
{
    class progDil
    {
        public string[] diller = { "Javascript", "SQL", "Java", "C#", "Php", "Python", "C++", "C", "Node.js", "AngularJS", "Ruby", "Objective-C" };
        public double[] oranlar = { 54.4, 48.0, 37.4, 31.6, 29.7, 23.8, 20.6, 16.4, 13.3, 13.3, 8.0, 7.8 };
        public string ad;
        public double oran;
        public progDil(string ad, double oran)
        {
            this.ad = ad;
            this.oran = oran;
        }
        public progDil()
        {
            Random rnd = new Random();
            int index = rnd.Next(diller.Length);
            this.ad = diller[index];
            this.oran = oranlar[index];
        }
    }
}
