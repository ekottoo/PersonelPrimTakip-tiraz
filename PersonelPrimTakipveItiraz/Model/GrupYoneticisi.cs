using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class GrupYoneticisi
    {
        public int GrupYoneticisiId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TakimLideriId { get; set; }
        public TakimLideri TakimLideri { get; set; }
    }
}
