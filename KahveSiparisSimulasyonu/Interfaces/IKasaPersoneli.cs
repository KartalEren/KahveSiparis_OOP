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
    public interface IKasaPersoneli
    {

        void MusteridenSiparisAl(Musteri musteri);
        Menu SiparisiIlet();
        void KahveBoyutunuDegistir(Menu menu);
        void MusteridenYanUrunSiparisAl(Musteri musteri);
        YanUrun YanUrunSiparisiIlet();
        decimal ToplamMenuUcretiniAl(Menu menu, YanUrun yanUrunler);
        KasaPersoneli MoladanDon();





    }
}
