using PersonelPrimTakipveItiraz.Model;
using PersonelPrimTakipveItiraz.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelPrimTakipveItiraz
{
    public partial class frmGorusmeDetay : Form
    {
        private Cagri cagri;
        public frmGorusmeDetay(Cagri cagri)
        {
            this.cagri = cagri;
            InitializeComponent();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            var gorusmeDetay = rch_GorusmeDetayi.Text;
            var baslamaSaati = txt_BaslamaSaati.Text;
            var bitisSaati = txt_BitisSaati.Text;
            var durum = cmb_Durum.SelectedItem?.ToString();
            var tarih = DateTime.Now;
            var musteriAdi = txtMusteriAdi.Text;
            var musteriSoyAdi = txtMusteriSoyadi.Text;
            var gorusmeKonusu = cmbGorusmeKonusu.SelectedItem?.ToString();

            AsistanManager asistanManager = new AsistanManager();
            var control =  asistanManager.AddGorusmeDetay(StaticVeriables.Asistan.Asistan_Id, gorusmeDetay,tarih, TimeSpan.Parse(baslamaSaati), TimeSpan.Parse(bitisSaati), durum, musteriAdi,musteriSoyAdi,gorusmeKonusu);
            if (control)
            {
                var cagriDurumu = "";
                if (durum == "Tamamlandı")
                {
                    cagriDurumu = "Tamamlandı";
                }
                else
                {
                    cagriDurumu = "Tamamlanmadı";
                }
               var controlKayit =  asistanManager.UpdateCallStatusAndResponseDate(cagri.CagriId, DateTime.Now, cagriDurumu);
                if (controlKayit)
                {
                    MessageBox.Show("İşleminiz tamamlandı.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İşleminiz tamamlanamadı.");

                }
            }


        }
    }
}
