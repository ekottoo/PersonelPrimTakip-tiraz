using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class PrimTakip
    {
        public int PrimId { get; set; }
        public int AsistanId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Miktar { get; set; }
    }
}
