using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3B
{
    class ÜrünNesnesi
    {
        public string ürünAdı, marka, model, kategori;
        public int miktar;
        public double maliyet, satışFiyatı;
        public void yazdir()
        {
            Console.WriteLine(ürünAdı
                                   + "\n\tKategorisi: " + kategori
                                   + "\n\tMarkası: " +marka
                                   + "\n\tModeli: " + model
                                   + "\n\tMiktarı: " + miktar
                                   + "\n\tMaliyeti: " + maliyet
                                   + "\n\tSatış Fiyatı: " + satışFiyatı);
        }
    }
    // Düğüm Sınıfı
    class TreeNode
    {
        public ÜrünNesnesi ürün = null;//başlangıç için null alıyor..
        public TreeNode left;
        public TreeNode right;
        public void NodeGörüntüle()
        {
            ürün.yazdir();
        }
    }

    // Ağaç Sınıfı
    class Tree
    {
        private TreeNode root;//ağacın en üstteki düğümü yani ROOT düğümü
        public int düğümSayısı = 0;
        public int karToplamı = 0;
        //public ArrayList kar = new ArrayList();
        public Tree()
        {
            root = null;//ilkleme
        }
        public TreeNode getRoot()
        {
            return root;//en üst düğüm döndürülüyor..
        }
        // Agacın inOrder Dolasılması
        public void inOrder(TreeNode localRoot)
        {
            if (localRoot != null)
            {
                inOrder(localRoot.left);//sol çocuğunda çocuklarına bakılıyor. aynısı onun çocukları için de gerçekleşecek.(Recursive)
                localRoot.NodeGörüntüle();// O anki düğümün bilgileri yazdırılıyor..
                inOrder(localRoot.right);
            }
        }

        //Ağacın derinliğini hesaplama
        public int FindDepthOfTree(TreeNode n)
        {
            if (n == null) return 0;
            return (Math.Max(FindDepthOfTree(n.left), FindDepthOfTree(n.right)) + 1);
        }

        // derinlik toplamları hesaplama
       
        public int sumOfDepth(TreeNode n)
        {
            int leftDepth = 0, rightDepth = 0, sumDepth = 0;
            if (n == null)// null ise çocuğu da yoktur demek ki..
                return (0);
            leftDepth = sumOfDepth(n.left) + 1;//Sol ya da sağ çocuk kendi derinliğini bulurken kendini saymadığı için 1 ekledik..
            rightDepth = sumOfDepth(n.right) + 1;
            sumDepth = leftDepth + rightDepth;
            return (sumDepth++);
        }

        public void insert(ÜrünNesnesi ürün)
        {
            TreeNode newNode = new TreeNode();
            newNode.ürün = ürün;
            karToplamı += Convert.ToInt32(ürün.miktar * (ürün.satışFiyatı - ürün.maliyet));
            düğümSayısı++;

            if (root == null)
                root = newNode;
            else
            {
                TreeNode current = root;
                TreeNode parent;
                while (true)
                {
                    parent = current;
                    if (ürün.ürünAdı.CompareTo(current.ürün.ürünAdı) == -1)//compareTo fonksiyonu ilk veri daha küçükse -1, daha büyükse 1, eşitse 0 döndürür..
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }

        } 
    } 
}
