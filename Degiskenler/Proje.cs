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
    public partial class Proje : Form
    {
        double gunlukCiro = 0;
        const int ciro = 500;
        double toplamTutar = 0;
        int urunNumara = 1;
        public Proje()
        {
            InitializeComponent();
            InitializeSettings();
        }
        
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (tbUrunAdi.Text != "" && tbMiktar.Text != "" && tbBirimTutar.Text != "" && cbxKdv.Text != "" && cbxIskonto.Text != "" && cbxPersonelIndirim.Text != "")
            {
                (string urunAdi, int miktar, double birimTutar, int kdv, int iskonto, int personelIndirim) siparis = (tbUrunAdi.Text, Convert.ToInt32(tbMiktar.Text), Convert.ToDouble(tbBirimTutar.Text), Convert.ToInt32(cbxKdv.Text), Convert.ToInt32(cbxIskonto.Text), Convert.ToInt32(cbxPersonelIndirim.Text));

                double tutar = siparis.miktar * siparis.birimTutar;
                double urunNetFiyat = tutar + (tutar * siparis.kdv) / 100 - (tutar * siparis.iskonto) / 100 - (tutar * siparis.personelIndirim) / 100;
                toplamTutar += urunNetFiyat;
                cbxFiyatListesi.Items.Add(urunNetFiyat);

                SepeteEkle(urunNumara, siparis.urunAdi, urunNetFiyat);
                lblSepetToplamTutar.Text = toplamTutar.ToString();
            }
            else
            {
                MessageBox.Show("Alışveriş ve Kesintiler Bölümündeki alanlar boş bırakılamaz.");
            }
            urunNumara++;
        }

        public void SepeteEkle(int fisNo,string urunAdi, double toplamTutar)
        {
            lbxSepetDetay.Items.Add(fisNo+ "\t" + urunAdi + "\t" + toplamTutar);
        }

        public void CiroKontrol()
        {
            if (gunlukCiro >= ciro)
            {
                lblDurum.Text = "Günlük Ciro Hedefine Ulaşıldı.";
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int selectedIdx = lbxSepetDetay.SelectedIndex;

            if (selectedIdx != -1)
            {
                toplamTutar -= Convert.ToDouble(cbxFiyatListesi.Items[selectedIdx-1]);
                lblSepetToplamTutar.Text = toplamTutar.ToString();
                lbxSepetDetay.Items.RemoveAt(selectedIdx);
                cbxFiyatListesi.Items.RemoveAt(selectedIdx-1);
            }
            else
            {
                MessageBox.Show("Ürün seçiniz!!!!");
            }
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            gunlukCiro += toplamTutar;
            lblGunlukCiro.Text = gunlukCiro.ToString();
            toplamTutar = 0;
            CiroKontrol();
            SepetiTemizle();
            InitializeSettings();
        }

        public void SepetiTemizle()
        {
            lbxSepetDetay.Items.Clear();
            lblSepetToplamTutar.Text = "0";
        }

        public void InitializeSettings()
        {
            lbxSepetDetay.Items.Add("Fiş No\tÜrün Adı\tNet Fiyat");
            tbCiroHedefi.Text = ciro.ToString();
            cbxIskonto.Text = cbxIskonto.Items[0].ToString();
            cbxPersonelIndirim.Text = cbxPersonelIndirim.Items[0].ToString();
        }
    }
}
