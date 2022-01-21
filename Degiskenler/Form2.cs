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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Tuple Türü
            /*
            C# 7.0 ile birlikte geliştiriilmiş bir yapıdır.
            Tek bir syntax üzerinden birden fazla değişkeni gruplayarak kullanmamızı sağlar.

            (string isim, int yas, string tcKimlikNo) kisi = ("bora", 27, "12345678910");
            (decimal maas, decimal vergi, decimal prim) bordro = (1000, 100, 250);

            tbIsim.Text = kisi.isim;
            tbYas.Text = kisi.yas.ToString();
            tbTcKimlikNo.Text = kisi.tcKimlikNo;
            tbMaas.Text = ((bordro.maas - bordro.vergi) + bordro.prim).ToString();
             */

            #endregion

            #region Literal
            /*
             int lsayi1 = 1_000_000;
             MessageBox.Show(lsayi1.ToString());
             */
            #endregion

            #region Checked
            //Default değer atama
            //int x = int.MaxValue;
            //int y = default;
            //int z = 20;
            //bool b = (bool)default;
            //byte c = (byte)default;

            //Eğer ki dönüşümde bir veri kaybı, veri taşması, verinin aldığı değeri manipüle eden bir durum varsa checked arkadaş bunu kontrol eder.
            //checked
            //{
            //    c = (byte)z; //Veride sıkıntı varsa hata verir.
            //    MessageBox.Show(c.ToString());
            //    unchecked //Veride sıkıntı olsa bile işlem devam eder.
            //    {
            //        x += 20;
            //        MessageBox.Show(x.ToString());
            //    }

            //}
            #endregion

            #region Değişmezler Const
            /*
             Bazı değişkenlerimi değişmez olarak adersleyebilirim. Çünkü değişmemesi gereken bir değer eğer ki herhangi biri tarafından değştirilse ciddi hatalara sebep olabilir.
            Özünde const lar statictir ve ramde static olarak adreslenir.
             */
            const decimal pi = 3.14m; //Decimal tanımlarının yanına m harfini eklemeliyiz
            #endregion

            #region Araştırılacak Konular
            // Deep copy
            // Shollow copy
            // Ram in 5 bölümü araştır. 2 makale oku
            #endregion

        }
    }
}
