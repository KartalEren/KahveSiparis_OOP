using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Urunler.YanUrunler
{
    public class SogukSut : EkUrun
    {
        public SogukSut():base(YanUrunlerGrubu.SogukSut)
        {
            FiyatTL = 8;
        }
    }
}
