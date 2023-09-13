using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.KahveMenusu
{
    public class Latte : Menu
    {
        public Latte(Boyut urunBoyutu, Tip icecekTipi)
        {
            HazirlanmaSuresiDk = 3;
            UrunBoyutu = urunBoyutu;
            BegenilmeOraniYuzde = 95;
            IcecekTipi = icecekTipi;
        }
    }
}
