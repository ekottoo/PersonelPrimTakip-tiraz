using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{
    public class Takim
    {
        public int TakimId { get; set; }
        public string TakimAd { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
    }
}
