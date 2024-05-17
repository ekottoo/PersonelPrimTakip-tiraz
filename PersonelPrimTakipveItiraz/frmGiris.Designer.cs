namespace PersonelPrimTakipveItiraz
{
    partial class frm_Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_sifre = new TextBox();
            Email = new Label();
            label3 = new Label();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 42);
            label1.TabIndex = 0;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(738, 50);
            label2.TabIndex = 1;
            label2.Text = "PERSONEL PRİM TAKİP VE İTİRAZ SİSTEMİ";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(307, 172);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(367, 23);
            txt_email.TabIndex = 2;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(307, 224);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(367, 23);
            txt_sifre.TabIndex = 3;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Email.Location = new Point(225, 179);
            Email.Name = "Email";
            Email.Size = new Size(63, 21);
            Email.TabIndex = 4;
            Email.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(239, 222);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.LightGreen;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(515, 273);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(159, 50);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // frm_Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Controls.Add(btnGiris);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(txt_sifre);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Prim Takip ve İtiraz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_sifre;
        private Label Email;
        private Label label3;
        private Button btnGiris;
    }
}
