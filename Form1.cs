using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TansiyonTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

            int ktMinimum = 7;
            int ktMaximum = 11;

            int btMinimum = 10;
            int btMaximum = 14;

            lbDataList.Items.Clear();
            lbAnormalData.Items.Clear();
            foreach (var t in Tansiyon.TansiyonVerileri)
            {
                lbDataList.Items.Add($"Tansiyonunuz {t.Tarih} tarihinde {t.Buyuk}-{t.Kucuk}");
                if (t.Buyuk > btMaximum || t.Buyuk < btMinimum)
                {
                    lbAnormalData.Items.Add($"{t.Tarih} tarihinde Büyük tansiyonunuz {t.Buyuk}-{t.Kucuk} ile Referans aralığı dışındadır.");
                }
                if (t.Kucuk > ktMaximum || t.Kucuk < ktMinimum)
                {
                    lbAnormalData.Items.Add($"{t.Tarih} tarihinde Küçük tansiyonunuz {t.Buyuk}-{t.Kucuk} ile Referans aralığı dışındadır.");
                }
            }
        }
    }
}
