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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tansiyon t = new Tansiyon();
            t.Kucuk = Convert.ToInt32(txtKucuk.Text);
            t.Buyuk = Convert.ToInt32(txtBuyuk.Text);
            t.Tarih = dtpTarih.Value;

            Tansiyon.TansiyonVerileri.Add(t);

            this.Close();
        }
    }
}
