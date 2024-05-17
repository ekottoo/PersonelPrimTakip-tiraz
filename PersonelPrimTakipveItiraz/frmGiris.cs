using PersonelPrimTakipveItiraz.Model;
using PersonelPrimTakipveItiraz.Sql;

namespace PersonelPrimTakipveItiraz
{
    public partial class frm_Anasayfa : Form
    {
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            AuthenticationManager sqlGirisDogrulama = new AuthenticationManager();
            var obj = sqlGirisDogrulama.GetUserInfo(txt_email.Text, txt_sifre.Text);
            if (obj is Asistan)
            {
                frmAsistan frmAsistan = new frmAsistan((Asistan)obj);
                frmAsistan.Show();
                StaticVeriables.Asistan = (Asistan)obj;
            }
            else if (obj is TakimLideri)
            {
                StaticVeriables.TakimLideri = (TakimLideri)obj;
                frmTakimLideri frmTakimLideri = new frmTakimLideri((TakimLideri)obj);
                frmTakimLideri.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý Bulunamadý.");

            }

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
