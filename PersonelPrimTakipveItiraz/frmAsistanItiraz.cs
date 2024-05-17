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
    public partial class frmAsistanItiraz : Form
    {
        private int asistanId, primId;
        private AsistanManager asistanManager;
        public frmAsistanItiraz(int asistanId, int primId)
        {
            this.asistanId = asistanId;
            this.primId = primId;
            this.asistanManager = new AsistanManager();
            InitializeComponent();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
          var control = asistanManager.EkleItiraz(asistanId, primId,DateTime.Today,rchAciklama.Text,"Bekliyor");
            if (control)
            {

                var emails = asistanManager.GetGrupYoneticisiEmailsByAsistanId(asistanId);

                if (emails != null)
                {
                    foreach ( var email in emails )
                    {
                        EmailHelper emailHelper = new EmailHelper();
                       var a = emailHelper.SendEmail("ealbayy.06@gmail.com", "Prim İtiraz", "Prim hakkında yeni bir itiraz aldınız lütfen sistemden kontrol ediniz.");
                    }
                }
                MessageBox.Show("İtirazınız başarıyla gönderildi.");
                this.Close();
            }

        }

        private void frmAsistanItiraz_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
