
namespace Degiskenler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTcKimlikNo = new System.Windows.Forms.TextBox();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnBilgileriYazdir = new System.Windows.Forms.Button();
            this.lbxPersonelBilgiler = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Değişkenler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(13, 99);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(142, 23);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sayıları Topla";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCinsiyet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBilgileriYazdir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTcKimlikNo);
            this.groupBox1.Controls.Add(this.tbMaas);
            this.groupBox1.Location = new System.Drawing.Point(338, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(86, 80);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(140, 20);
            this.tbMaas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet";
            // 
            // tbTcKimlikNo
            // 
            this.tbTcKimlikNo.Location = new System.Drawing.Point(86, 52);
            this.tbTcKimlikNo.MaxLength = 11;
            this.tbTcKimlikNo.Name = "tbTcKimlikNo";
            this.tbTcKimlikNo.Size = new System.Drawing.Size(140, 20);
            this.tbTcKimlikNo.TabIndex = 1;
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(86, 26);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(140, 20);
            this.tbAdSoyad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tc Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ad Soyad";
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(86, 110);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(140, 21);
            this.cbxCinsiyet.TabIndex = 4;
            // 
            // btnBilgileriYazdir
            // 
            this.btnBilgileriYazdir.Location = new System.Drawing.Point(21, 138);
            this.btnBilgileriYazdir.Name = "btnBilgileriYazdir";
            this.btnBilgileriYazdir.Size = new System.Drawing.Size(205, 35);
            this.btnBilgileriYazdir.TabIndex = 2;
            this.btnBilgileriYazdir.Text = "Bilgileri Yazdır";
            this.btnBilgileriYazdir.UseVisualStyleBackColor = true;
            this.btnBilgileriYazdir.Click += new System.EventHandler(this.btnBilgileriYazdir_Click);
            // 
            // lbxPersonelBilgiler
            // 
            this.lbxPersonelBilgiler.FormattingEnabled = true;
            this.lbxPersonelBilgiler.Location = new System.Drawing.Point(338, 265);
            this.lbxPersonelBilgiler.Name = "lbxPersonelBilgiler";
            this.lbxPersonelBilgiler.Size = new System.Drawing.Size(273, 121);
            this.lbxPersonelBilgiler.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Personel Bilgileri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.lbxPersonelBilgiler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTcKimlikNo;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.Button btnBilgileriYazdir;
        private System.Windows.Forms.ListBox lbxPersonelBilgiler;
        private System.Windows.Forms.Label label7;
    }
}

