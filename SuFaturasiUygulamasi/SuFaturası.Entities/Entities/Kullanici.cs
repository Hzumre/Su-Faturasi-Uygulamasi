using SuFaturası.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuFaturası.Entities.Entities
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public double SonIndex { get; set; }
        public double IlkIndex { get; set; }
        public KullanimYeri KullanimYeri { get; set; }

        public virtual List<SuFaturasi> SuFaturasilar { get; set; }
    }
}
