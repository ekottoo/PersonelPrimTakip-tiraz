using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class GorusmeDetay
    {
        public int GorusmeId { get; set; }
        public int AsistanId { get; set; }
        public int MusteriId { get; set; }
        public string GorusmeDetayi { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan BaslamaSaati { get; set; }
        public TimeSpan BitisSaati { get; set; }
        public string Durum { get; set; }
        public Asistan Asistan { get; set; }
        public Musteri Musteri { get; set; }
    }
}
