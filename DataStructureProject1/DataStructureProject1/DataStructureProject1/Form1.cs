using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataStructureProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Custom Datagrid Initialize
            
            dg1995.ColumnCount = 32;
            dg1995.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg1995.Columns[0].HeaderText = "Aylar";
            dg1995.Columns[0].Width = 100;

            dg1996.ColumnCount = 32;
            dg1996.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg1996.Columns[0].HeaderText = "Aylar";
            dg1996.Columns[0].Width = 100;

            dg1997.ColumnCount = 32;
            dg1997.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg1997.Columns[0].HeaderText = "Aylar";
            dg1997.Columns[0].Width = 100;

            for (int i = 1; i < 32; i++)
            {
                dg1995.Columns[i].HeaderText = i.ToString();
                dg1996.Columns[i].HeaderText = i.ToString();
                dg1997.Columns[i].HeaderText = i.ToString();
            }

            string[] mounts = { "Ocak", "Şubat", "Mart","Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylük", "Ekim", "Kasım", "Aralık" };

            for (int i = 0; i < 12; i++)
            {
                dg1995.Rows.Add(new DataGridViewRow());
                dg1995.Rows[i].Cells[0].Value = mounts[i];

                dg1996.Rows.Add(new DataGridViewRow());
                dg1996.Rows[i].Cells[0].Value = mounts[i];

                dg1997.Rows.Add(new DataGridViewRow());
                dg1997.Rows[i].Cells[0].Value = mounts[i];
            }

            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGeneratDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Üretilen Tarih : "+ DateGenerator.GetDate().ToShortDateString()), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
