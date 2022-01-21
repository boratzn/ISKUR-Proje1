
namespace Degiskenler
{
    partial class Form2
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
            this.btnTupple = new System.Windows.Forms.Button();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.tbYas = new System.Windows.Forms.TextBox();
            this.tbTcKimlikNo = new System.Windows.Forms.TextBox();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTupple
            // 
            this.btnTupple.Location = new System.Drawing.Point(12, 117);
            this.btnTupple.Name = "btnTupple";
            this.btnTupple.Size = new System.Drawing.Size(100, 23);
            this.btnTupple.TabIndex = 0;
            this.btnTupple.Text = "Tupple Buton";
            this.btnTupple.UseVisualStyleBackColor = true;
            this.btnTupple.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(13, 13);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(100, 20);
            this.tbIsim.TabIndex = 1;
            // 
            // tbYas
            // 
            this.tbYas.Location = new System.Drawing.Point(13, 39);
            this.tbYas.Name = "tbYas";
            this.tbYas.Size = new System.Drawing.Size(100, 20);
            this.tbYas.TabIndex = 1;
            // 
            // tbTcKimlikNo
            // 
            this.tbTcKimlikNo.Location = new System.Drawing.Point(12, 65);
            this.tbTcKimlikNo.Name = "tbTcKimlikNo";
            this.tbTcKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.tbTcKimlikNo.TabIndex = 1;
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(12, 91);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(100, 20);
            this.tbMaas.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.tbMaas);
            this.Controls.Add(this.tbTcKimlikNo);
            this.Controls.Add(this.tbYas);
            this.Controls.Add(this.tbIsim);
            this.Controls.Add(this.btnTupple);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTupple;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.TextBox tbYas;
        private System.Windows.Forms.TextBox tbTcKimlikNo;
        private System.Windows.Forms.TextBox tbMaas;
    }
}