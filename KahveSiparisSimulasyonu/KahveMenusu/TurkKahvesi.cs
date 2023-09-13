using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.KahveMenusu
{
    public class TurkKahvesi : Menu
    {
        public TurkKahvesi(Boyut urunBoyutu, Tip icecekTipi)
        {
            HazirlanmaSuresiDk = 1;
            UrunBoyutu = urunBoyutu;
            BegenilmeOraniYuzde = 98;
            IcecekTipi = icecekTipi;
        }
    }
}
