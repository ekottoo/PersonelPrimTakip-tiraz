namespace PersonelPrimTakipveItiraz
{
    partial class frmAsistanItiraz
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
            lblTarih = new Label();
            label3 = new Label();
            rchAciklama = new RichTextBox();
            btnKayitEt = new Button();
            label4 = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 0;
            label1.Text = "İtiraz Et";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Tarih:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTarih.Location = new Point(180, 119);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(14, 20);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "t";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 160);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 3;
            label3.Text = "Açıklama:";
            // 
            // rchAciklama
            // 
            rchAciklama.Location = new Point(193, 165);
            rchAciklama.Name = "rchAciklama";
            rchAciklama.Size = new Size(502, 163);
            rchAciklama.TabIndex = 4;
            rchAciklama.Text = "";
            // 
            // btnKayitEt
            // 
            btnKayitEt.BackColor = Color.LightGreen;
            btnKayitEt.FlatStyle = FlatStyle.Flat;
            btnKayitEt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitEt.Location = new Point(536, 372);
            btnKayitEt.Name = "btnKayitEt";
            btnKayitEt.Size = new Size(159, 50);
            btnKayitEt.TabIndex = 7;
            btnKayitEt.Text = "GÖNDER";
            btnKayitEt.UseVisualStyleBackColor = false;
            btnKayitEt.Click += btnKayitEt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(97, 81);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 8;
            label4.Text = "Durum:";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDurum.Location = new Point(180, 85);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(64, 20);
            lblDurum.TabIndex = 9;
            lblDurum.Text = "Bekliyor";
            // 
            // frmAsistanItiraz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurum);
            Controls.Add(label4);
            Controls.Add(btnKayitEt);
            Controls.Add(rchAciklama);
            Controls.Add(label3);
            Controls.Add(lblTarih);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAsistanItiraz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asistan İtiraz";
            Load += frmAsistanItiraz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblTarih;
        private Label label3;
        private RichTextBox rchAciklama;
        private Button btnKayitEt;
        private Label label4;
        private Label lblDurum;
    }
}