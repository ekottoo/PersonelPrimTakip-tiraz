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
    public partial class frmTakimLideri : Form
    {
        TakimLideri TakimLideri { get; set; }
        public frmTakimLideri(TakimLideri takimLideri)
        {
            TakimLideri = takimLideri;
            InitializeComponent();
        }

        private void frmTakimLideri_Load(object sender, EventArgs e)
        {
            TakimLideriManager takimLideriManager = new TakimLideriManager();
            // DataGridView'e sütunları ekle
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "İtiraz Detayı";
            buttonColumn.Text = "Görüntüle";
            buttonColumn.Name = "btnDetay";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            dataGridView1.DataSource = takimLideriManager.GetItirazlarByTakimLideriId(TakimLideri.TakimLideriId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // İtiraz detayı butonuna tıklanıp tıklanmadığını kontrol et
            if (e.ColumnIndex == dataGridView1.Columns["btnDetay"].Index && e.RowIndex >= 0)
            {
             
                int itirazId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["itiraz_id"].Value);
            
                
                string itirazDurummu = dataGridView1.Rows[e.RowIndex].Cells["İtiraz Durum"].Value.ToString();
                if(itirazDurummu == "Bekliyor")
                {
                    frmItirazCevap frmItirazCevap = new frmItirazCevap(itirazId);
                    frmItirazCevap.FormClosed += FrmItirazCevap_Closed;
                    frmItirazCevap.Show();
                }
                else
                {
                    MessageBox.Show("İtiraz zaten cevaplanmış.");
                }

            }
        }

        private void FrmItirazCevap_Closed(object sender, FormClosedEventArgs e)
        {
            TakimLideriManager takimLideriManager = new TakimLideriManager();

            dataGridView1.DataSource = takimLideriManager.GetItirazlarByTakimLideriId(TakimLideri.TakimLideriId);
            dataGridView1.Refresh();
        }
    }
}
