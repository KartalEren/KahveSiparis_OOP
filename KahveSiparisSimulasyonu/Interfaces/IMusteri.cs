using KahveSiparisSimulasyonu.Enums;
using KahveSiparisSimulasyonu.KahveMenusu;
using KahveSiparisSimulasyonu.Personeller;
using KahveSiparisSimulasyonu.Urunler.EkUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Interfaces
{
    public interface IMusteri
    {

        Menu SiparisVer();
        void ToplamUcretiOde(KasaPersoneli kasaPersoneli, Menu menu, YanUrun yanUrunler, OdemeYontemleri odemeYontemleri);
        void SiparisiTeslimAl(ServisPersoneli servisPersoneli);
        YanUrun YanUrunSiparisVer();
        void SiradaBekle();
    }
}
