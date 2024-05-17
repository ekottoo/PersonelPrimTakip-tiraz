using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class Cagri
    {
        public int CagriId { get; set; }
        public int AsistanId { get; set; }
        public string Konu { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime CevaplamaTarihi { get; set; }
        public string Durum { get; set; }
    }
}
