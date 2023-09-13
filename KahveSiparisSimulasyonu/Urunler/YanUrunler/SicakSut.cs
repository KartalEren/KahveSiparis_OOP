using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Urunler.YanUrunler
{
   public class SicakSut : EkUrun
    {
        public SicakSut():base(YanUrunlerGrubu.SicakSut)
        {
            FiyatTL = 10; 
        }
    }
}
