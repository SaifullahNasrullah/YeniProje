using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random rastgele = new Random();
        Ogrenci[] ogrenciler;
        SunumKonuları sunumKonulari;
        public Form1()
        {
            InitializeComponent();
        }

        public void adVer(int KisiSay)
        {
            ogrenciler = new Ogrenci[KisiSay];
            listView1.Items.Clear();
            string[] ad = { "Mehemed", "Sencer", "Mazlum", "Zerdest", "Roeen", "Evîn", "Şevîn", "Zana", "Abuzer", "Mahsûm", "Dîlan", "Selma", "Arjîn", "Rojhat", "Cegerxwîn", "Celadet", "Furkan", "Jînda", "Baran", "Rohullah" };
            string[] soyad = { "Çay", "Birek", "Muhammad Ali", "Dastageerzada", "Haşimi", "Nasrullah", "Akün", "Kombers", "Soran", "Kurmanc", "Goran", "Kerboran", "Dêrik", "Amedî", "Bername", "Kevçî", "Botan", "Serhed", "Behdînan", "Tolhildan" };

            for (int i = 0; i < KisiSay; i++)
            {
                int index1 = rastgele.Next(ad.Length);
                int index2 = rastgele.Next(soyad.Length);
                ListViewItem item = new ListViewItem(ad[index1]);
                item.SubItems.Add(soyad[index2]);
                ogrenciler[i] = new Ogrenci(ad[index1], soyad[index2]);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adVer(Convert.ToInt32(numericUpDown1.Value));
        }

        public void printToListBox(string str)
        {
            listBox1.Items.Add(str);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            sunumKonulari = new SunumKonuları();
            listBox1.Items.Clear();
            sunumKonulari.balacedDistribution(ogrenciler);
            sunumKonulari.printCountsAndInfos(this);
        }
    }
}
