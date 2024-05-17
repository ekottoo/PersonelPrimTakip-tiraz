using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class Itirazlar
    {
        public int ItirazId { get; set; }
        public int AsistanId { get; set; }
        public int PrimId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
        public Asistan Asistan { get; set; }
    }
}
