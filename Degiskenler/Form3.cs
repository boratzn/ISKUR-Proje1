using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ComboboxSifirla();
            IslemsonuclariSifirla();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int elmaMktr = Convert.ToInt32(tbElma.Text);
            int armutMktr = Convert.ToInt32(tbArmut.Text);
            int muzMktr = Convert.ToInt32(tbMuz.Text);
            int kirazMktr = Convert.ToInt32(tbKiraz.Text);
            int portakalMktr = Convert.ToInt32(tbPortakal.Text);

            double elmaFiyat = elmaMktr * Convert.ToDouble(cbxElma.Text);
            double armutFiyat = armutMktr * Convert.ToDouble(cbxArmut.Text);
            double muzFiyat = muzMktr * Convert.ToDouble(cbxMuz.Text);
            double kirazFiyat = kirazMktr * Convert.ToDouble(cbxKiraz.Text);
            double portakalFiyat = portakalMktr * Convert.ToDouble(cbxPortakal.Text);

            double toplamTutar = elmaFiyat + armutFiyat + muzFiyat + kirazFiyat + portakalFiyat;

            int kdv = Convert.ToInt32(cbxKDV.Text);
            int iskonto = Convert.ToInt32(cbxIskonto.Text);

            double netTutar = toplamTutar + (toplamTutar * kdv) / 100 - (toplamTutar*iskonto)/100;

            lblToplamTutarİslem.Text = toplamTutar.ToString();
            lblKdv.Text = cbxKDV.Text;
            lblIskonto.Text = cbxIskonto.Text;
            lblNetTutar.Text = netTutar.ToString();

            lblToplamTutar.Text = netTutar.ToString();
        }

        private void btnYeniIslem_Click(object sender, EventArgs e)
        {
            TextboxSifirla();
            ComboboxSifirla();
            IslemsonuclariSifirla();
        }

        public void IslemsonuclariSifirla()
        {
            lblToplamTutarİslem.Text = "0";
            lblKdv.Text = "0";
            lblIskonto.Text = "0";
            lblNetTutar.Text = "0";
            lblToplamTutar.Text = "0";
        }

        public void TextboxSifirla()
        {
            tbElma.Clear();
            tbArmut.Clear();
            tbMuz.Clear();
            tbKiraz.Clear();
            tbPortakal.Clear();

        }

        public void ComboboxSifirla()
        {
            cbxElma.Text = "";
            cbxArmut.Text = "";
            cbxMuz.Text = "";
            cbxKiraz.Text = "";
            cbxPortakal.Text = "";
            cbxKDV.Text = "";
            cbxIskonto.Text = "";
        }
    }
}
