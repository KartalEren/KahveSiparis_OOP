using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.KahveMenusu
{
    public abstract class Icecek : Urun
    {
        public Tip IcecekTipi { get; set; }
    }
}
