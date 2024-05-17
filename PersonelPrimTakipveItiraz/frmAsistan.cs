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
    public partial class frmAsistan : Form
    {
        Asistan asistan;
        AsistanManager asistanManager;
        List<Cagri> Cagrilar;
        List<PrimTakip> primTakip;
        public frmAsistan(Asistan asistan)
        {
            this.asistan = asistan;

            InitializeComponent();
        }

        private void frmAsistan_Load(object sender, EventArgs e)
        {
            asistanManager = new AsistanManager();
            Cagrilar = asistanManager.CagrilariGetir(asistan.Asistan_Id);
            primTakip = asistanManager.ListelePrimTakip(asistan.Asistan_Id);
            dataGridView2.DataSource = primTakip;
            dataGridView1.DataSource = Cagrilar;
            dataGridView3.DataSource = asistanManager.CekItirazlar(asistan.Asistan_Id);
            AddButton();
            AddButtonPirimList();

        }
        private void AddButton()
        {

            // DataGridView'e buton sütunu ekle
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Yeni Çağrı";
            buttonColumn.Text = "Yeni Çağrı";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            // Buton tıklama olayını tanımla
            dataGridView1.CellContentClick += (sender, e) =>
            {
                // Sadece buton hücresindeki tıklamaları işle
                if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
                {
                    Cagri selectedCagri = (Cagri)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                    // Seçilen çağrıyı al
                    if (selectedCagri.Durum == "Tamamlandı")
                    {
                        MessageBox.Show("Uyarı Görüşme sonlandırılıp talep kapanmıştır.");
                        return;
                    }
                    frmGorusmeDetay frmGorusmeDetay = new frmGorusmeDetay(selectedCagri);
                    frmGorusmeDetay.FormClosed += FrmGorusmeDetay_Closed;
                    frmGorusmeDetay.Show();


                }
            };
        }
        // İkinci form kapatıldığında datagridi güncelle

        private void FrmGorusmeDetay_Closed(object sender, FormClosedEventArgs e)
        {
      
            dataGridView1.DataSource = asistanManager.CagrilariGetir(asistan.Asistan_Id);
            dataGridView1.Refresh();
        }

        private void AddButtonPirimList()
        {
            // DataGridView'e buton sütunu ekleme
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "İtiraz";
            btnColumn.Text = "İtiraz Et";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btnColumn);


            // Buton tıklama olayını tanımla
            dataGridView2.CellContentClick += (sender, e) =>
            {
                // Sadece buton hücresindeki tıklamaları işle
                if (e.ColumnIndex == dataGridView2.Columns[""].Index && e.RowIndex == 0)
                {
                    frmAsistanItiraz frmAsistanItiraz = new frmAsistanItiraz(Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value), Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value));
                    frmAsistanItiraz.Show();
                }
                else
                {
                    MessageBox.Show("Sadece son aya itiraz edebilirsiniz.");
                }
            };
        }
    }

    
}
