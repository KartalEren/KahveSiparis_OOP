using KahveSiparisSimulasyonu.Enums;
using KahveSiparisSimulasyonu.Urunler.EkUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Urunler.YanUrunler
{
    public abstract class EkUrun: YanUrun
    {

        public YanUrunlerGrubu YanUrunlerGrubu { get; set; }


        public EkUrun(YanUrunlerGrubu yanUrunlerGrubu)
        {
            YanUrunlerGrubu = yanUrunlerGrubu;
        }
    }
}
