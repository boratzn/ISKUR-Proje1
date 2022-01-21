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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Değişkenler
            /*
                - En kritik konudur ve bellek nesnesidir.
                - İhtiyaç duyma nedenimiz veriyi doğru bir şekilde işleyebilmemiz için programlama dilinde verileri biz ram de adresleyerek tutmak zorundayız. Yazılımdaki temel amaç veriyi doğru işlemek ve işletmektir.
                - İşte bu noktada karşımıza değişkenler çıkmaktadır. Örneğin bir yaş değerini yada fatura numarası değerini yaılım dilinde karşılayabilmek için ilk önce ram de buna karşılık ayırır ve sonra ilgili değişkene türünüde bilinçli bir şekilde oluşturarak atarız.
                - C# ta bir değişkene ilk değeri atamak zorunludur.
                - Garbage collection ile ram yazılım dilinde oluşturduğumuz  değişkenlerin atamalarını otomatik olarak yapar. Örneğin siz bir değişken oluşturduğunuzda şayet kullanılmadıysa GC bunu silecektir.
                - Primitive type, value type ve referans type mevcuttur.
                - pt : byte x = 0;
                - value int x1 = 123;
                - ref type : string isim = "bora";
                - değişkenler kendi aralarında mantıksal, metinsel, sayısal ve ondalıklı olacak şekilde kategorilere ayırılırlar. Örneğin string referans tipli metinsel bir türdür.
                - Tüm türler ramde 5 yerde saklanır  bunlardan en önemlisi stack ve heap tir.
                - Diğerleri ise register, static ve constant
                - Ram in çalışma prensibi ise fifo(ilk giren ilk çıkar)
                - ÖNEMLİ!!!!!!!!!: Değişkenlere anlamsız isimlendirmeler yapılmaz
                - Değişkenlerde özel karakterler kullanılmaz. %,#, ! gibi
                - Değişken isimleri sayısal bir değerle başlayamaz.
                - Aynı scope içerisinde birden fazla aynı isme sahip değişken olamaz.
             */
            #endregion
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            MessageBox.Show((sayi1 + sayi2).ToString());
        }

        private void btnBilgileriYazdir_Click(object sender, EventArgs e)
        {
            string adSoyad = tbAdSoyad.Text;
            string tcKimlik = tbTcKimlikNo.Text;
            decimal maas = Convert.ToDecimal(tbMaas.Text);
            string cinsiyet = cbxCinsiyet.Text;

            lbxPersonelBilgiler.Items.Add(adSoyad);
            lbxPersonelBilgiler.Items.Add(tcKimlik);
            lbxPersonelBilgiler.Items.Add(maas);
            lbxPersonelBilgiler.Items.Add(cinsiyet);
        }
    }
}
