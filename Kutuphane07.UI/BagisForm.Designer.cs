
namespace Kutuphane07.UI
{
    partial class BagisForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.dtpBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.nudSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnBagisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kutuphane07.UI.Properties.Resources.book;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(95, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basım Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yazar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Açıklama";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(106, 213);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(171, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Location = new System.Drawing.Point(106, 160);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(171, 20);
            this.dtpBasimTarihi.TabIndex = 3;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(106, 186);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(171, 21);
            this.cmbTur.TabIndex = 4;
            // 
            // nudSayfaSayisi
            // 
            this.nudSayfaSayisi.Location = new System.Drawing.Point(106, 239);
            this.nudSayfaSayisi.Name = "nudSayfaSayisi";
            this.nudSayfaSayisi.Size = new System.Drawing.Size(171, 20);
            this.nudSayfaSayisi.TabIndex = 5;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(106, 134);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(171, 20);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(105, 265);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(171, 100);
            this.txtAciklama.TabIndex = 2;
            // 
            // btnBagisYap
            // 
            this.btnBagisYap.Location = new System.Drawing.Point(202, 371);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(75, 23);
            this.btnBagisYap.TabIndex = 6;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseVisualStyleBackColor = true;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);
            // 
            // BagisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 405);
            this.Controls.Add(this.btnBagisYap);
            this.Controls.Add(this.nudSayfaSayisi);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.dtpBasimTarihi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BagisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BagisForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.DateTimePicker dtpBasimTarihi;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnBagisYap;
    }
}