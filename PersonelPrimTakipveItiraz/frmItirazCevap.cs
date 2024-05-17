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
    public partial class frmItirazCevap : Form
    {
        int itirazId;
        public frmItirazCevap(int itirazId)
        {
            InitializeComponent();
            this.itirazId = itirazId;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            var itirazCevabı = rchAciklama.Text.Trim();
            var durum = cmbDurum.SelectedItem?.ToString();

            TakimLideriManager takimLideriManager = new TakimLideriManager();
            takimLideriManager.UpdateItirazDurumVeCevap(itirazId, durum, itirazCevabı);
            MessageBox.Show("İtiraza cevap gönderildi.");
            this.Close();
        }
    }
}
