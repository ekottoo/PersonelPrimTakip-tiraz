using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class Yetkilendirme
    {
        public int YetkilendirmeId { get; set; }
        public int KullaniciId { get; set; }
        public string Yetki { get; set; }
        public Asistan Kullanici { get; set; }
    }
}
