using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Urunler.YanUrunler
{
   public class Surup : EkUrun
    {

        public Surup():base(YanUrunlerGrubu.Surup)
        {
            FiyatTL = 15;
        }
    }
}
