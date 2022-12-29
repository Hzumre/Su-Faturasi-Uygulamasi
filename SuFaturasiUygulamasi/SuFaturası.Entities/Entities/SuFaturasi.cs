using SuFaturası.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuFaturası.Entities.Entities
{
    public class SuFaturasi
    {
        public int SuFaturasiID { get; set; }
        public Kullanici Kullanici{ get; set; }

        public int KullaniciID { get; set; }



        public double KullanilanSuMiktari
        {
            get
            {
                double kullanilanSuMiktari = Kullanici.SonIndex - Kullanici.IlkIndex;
                return kullanilanSuMiktari;
            }
        }



        public double Tutar
        {
            get {

                double kullanilanSuMiktari = Kullanici.SonIndex - Kullanici.IlkIndex;
                double faturaTutari = Kullanici.KullanimYeri==KullanimYeri.Mesken ? kullanilanSuMiktari * 0.7 : kullanilanSuMiktari * 0.3;


                double atikSu = 0;

                if (Kullanici.KullanimYeri == KullanimYeri.Mesken)
                {
                    atikSu = kullanilanSuMiktari * 0.3 * 0.2;
                }

                return faturaTutari + atikSu;
                    
                }
            
        }


    }
}
