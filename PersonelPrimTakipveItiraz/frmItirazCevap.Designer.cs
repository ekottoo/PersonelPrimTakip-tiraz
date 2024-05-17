namespace PersonelPrimTakipveItiraz
{
    partial class frmItirazCevap
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
            cmbDurum = new ComboBox();
            rchAciklama = new RichTextBox();
            label3 = new Label();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "İtiraz Durumu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 127);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "İtiraza Cevap:";
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Bekliyor", "Onaylandı", "Reddedildi" });
            cmbDurum.Location = new Point(150, 64);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(328, 23);
            cmbDurum.TabIndex = 2;
            // 
            // rchAciklama
            // 
            rchAciklama.Location = new Point(150, 124);
            rchAciklama.Name = "rchAciklama";
            rchAciklama.Size = new Size(561, 244);
            rchAciklama.TabIndex = 3;
            rchAciklama.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(297, 9);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 4;
            label3.Text = "İTİRAZA CEVAP VER";
            // 
            // btnGonder
            // 
            btnGonder.BackColor = Color.LightGreen;
            btnGonder.FlatStyle = FlatStyle.Flat;
            btnGonder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGonder.Location = new Point(543, 388);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(159, 50);
            btnGonder.TabIndex = 7;
            btnGonder.Text = "GÖNDER";
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // frmItirazCevap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGonder);
            Controls.Add(label3);
            Controls.Add(rchAciklama);
            Controls.Add(cmbDurum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmItirazCevap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İtirazı Cevapla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDurum;
        private RichTextBox rchAciklama;
        private Label label3;
        private Button btnGonder;
    }
}