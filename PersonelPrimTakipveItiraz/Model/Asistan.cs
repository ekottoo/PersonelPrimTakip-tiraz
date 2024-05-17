using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Model
{


    public class Asistan
    {
        public int Asistan_Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Kullanici_Id { get; set; }
        public int Sicil_Numarasi { get; set; }
    }

}
