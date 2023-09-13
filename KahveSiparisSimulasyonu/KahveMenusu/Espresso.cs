using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.KahveMenusu
{
    public class Espresso : Menu
    {
        public Espresso(Boyut urunBoyutu, Tip icecekTipi)
        {
            HazirlanmaSuresiDk = 2;
            UrunBoyutu = urunBoyutu;
            BegenilmeOraniYuzde = 90;
            IcecekTipi = icecekTipi;
        }
    }
}
