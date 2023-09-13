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
    public interface IServisPersoneli
    {

        void KasaPersonelindenSiparisAl(KasaPersoneli kasaPersoneli);
        Menu SiparisHazirlaVeTeslimEt();
        void KasaPersonelindenYanUrunSiparisAl(KasaPersoneli kasaPersoneli);
        YanUrun YanUrunlerSiparisHazirlaVeTeslimEt();
        ServisPersoneli MoladanDon();




    }
}
