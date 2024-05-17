namespace PersonelPrimTakipveItiraz
{
    partial class frmGorusmeDetay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rch_GorusmeDetayi = new RichTextBox();
            label5 = new Label();
            txt_BaslamaSaati = new TextBox();
            txt_BitisSaati = new TextBox();
            cmb_Durum = new ComboBox();
            btnKayitEt = new Button();
            txtMusteriSoyadi = new TextBox();
            label6 = new Label();
            txtMusteriAdi = new TextBox();
            label7 = new Label();
            cmbGorusmeKonusu = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 134);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Görüşme Detayı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 266);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Başlama Saati:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 301);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Bitiş Saati:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 333);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Durum:";
            // 
            // rch_GorusmeDetayi
            // 
            rch_GorusmeDetayi.Location = new Point(186, 73);
            rch_GorusmeDetayi.Name = "rch_GorusmeDetayi";
            rch_GorusmeDetayi.Size = new Size(412, 142);
            rch_GorusmeDetayi.TabIndex = 4;
            rch_GorusmeDetayi.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(217, 9);
            label5.Name = "label5";
            label5.Size = new Size(188, 30);
            label5.TabIndex = 5;
            label5.Text = "GÖRÜŞME DETAYI";
            // 
            // txt_BaslamaSaati
            // 
            txt_BaslamaSaati.Location = new Point(186, 258);
            txt_BaslamaSaati.Name = "txt_BaslamaSaati";
            txt_BaslamaSaati.Size = new Size(172, 23);
            txt_BaslamaSaati.TabIndex = 6;
            // 
            // txt_BitisSaati
            // 
            txt_BitisSaati.Location = new Point(186, 298);
            txt_BitisSaati.Name = "txt_BitisSaati";
            txt_BitisSaati.Size = new Size(172, 23);
            txt_BitisSaati.TabIndex = 7;
            // 
            // cmb_Durum
            // 
            cmb_Durum.FormattingEnabled = true;
            cmb_Durum.Items.AddRange(new object[] { "Tamamlandı", "Takip ediliyor", "Sorun çözülemedi" });
            cmb_Durum.Location = new Point(186, 333);
            cmb_Durum.Name = "cmb_Durum";
            cmb_Durum.Size = new Size(172, 23);
            cmb_Durum.TabIndex = 8;
            // 
            // btnKayitEt
            // 
            btnKayitEt.BackColor = Color.LightGreen;
            btnKayitEt.FlatStyle = FlatStyle.Flat;
            btnKayitEt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitEt.Location = new Point(439, 301);
            btnKayitEt.Name = "btnKayitEt";
            btnKayitEt.Size = new Size(159, 50);
            btnKayitEt.TabIndex = 9;
            btnKayitEt.Text = "KAYIT ET";
            btnKayitEt.UseVisualStyleBackColor = false;
            btnKayitEt.Click += btnKayitEt_Click;
            // 
            // txtMusteriSoyadi
            // 
            txtMusteriSoyadi.Location = new Point(186, 427);
            txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            txtMusteriSoyadi.Size = new Size(172, 23);
            txtMusteriSoyadi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 430);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Müşteri Soyadı:";
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(186, 395);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(172, 23);
            txtMusteriAdi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 398);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Müşteri Adı:";
            // 
            // cmbGorusmeKonusu
            // 
            cmbGorusmeKonusu.FormattingEnabled = true;
            cmbGorusmeKonusu.Items.AddRange(new object[] { "Arıza", "Talep", "Bilgi" });
            cmbGorusmeKonusu.Location = new Point(186, 362);
            cmbGorusmeKonusu.Name = "cmbGorusmeKonusu";
            cmbGorusmeKonusu.Size = new Size(172, 23);
            cmbGorusmeKonusu.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 362);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 14;
            label8.Text = "Görüşme Konusu:";
            // 
            // frmGorusmeDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 548);
            Controls.Add(cmbGorusmeKonusu);
            Controls.Add(label8);
            Controls.Add(txtMusteriAdi);
            Controls.Add(label7);
            Controls.Add(txtMusteriSoyadi);
            Controls.Add(label6);
            Controls.Add(btnKayitEt);
            Controls.Add(cmb_Durum);
            Controls.Add(txt_BitisSaati);
            Controls.Add(txt_BaslamaSaati);
            Controls.Add(label5);
            Controls.Add(rch_GorusmeDetayi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGorusmeDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGorusmeDetay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox rch_GorusmeDetayi;
        private Label label5;
        private TextBox txt_BaslamaSaati;
        private TextBox txt_BitisSaati;
        private ComboBox cmb_Durum;
        private Button btnKayitEt;
        private TextBox txtMusteriSoyadi;
        private Label label6;
        private TextBox txtMusteriAdi;
        private Label label7;
        private ComboBox cmbGorusmeKonusu;
        private Label label8;
    }
}