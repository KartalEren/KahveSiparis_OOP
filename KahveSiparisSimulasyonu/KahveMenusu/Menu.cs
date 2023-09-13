using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.KahveMenusu
{
    public abstract class Menu:Urun
    {
        public Icecek Icecek { get; set; }

        public decimal FiyatTL { get; set; }

        public decimal BuyukBoyFiyatFarkiTL { get; set; } = 12;

        public int MenuHazirlikSuresi { get; set; }

        public List<Urun> MenuUrunleri { get; set; }

        public Tip IcecekTipi { get; set; }
      
    }
}
