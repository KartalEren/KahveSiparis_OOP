using KahveSiparisSimulasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu
{
    public abstract class Urun
    {
        public int HazirlanmaSuresiDk { get; set; }
        public int BegenilmeOraniYuzde { get; set; }
        public Boyut UrunBoyutu { get; set; }
    }
}
