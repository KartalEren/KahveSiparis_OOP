using KahveSiparisSimulasyonu.Enums;
using KahveSiparisSimulasyonu.Exceptions;
using KahveSiparisSimulasyonu.Interfaces;
using KahveSiparisSimulasyonu.KahveMenusu;
using KahveSiparisSimulasyonu.Urunler.EkUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Personeller
{
    public class KasaPersoneli : Personel, IKasaPersoneli
    {
        private bool buyukBoyMu;
        private bool servisElemanlariBosMu;
        private bool buyukBoyIsterMisin;
        private bool yanUrunIsterMisin;

        private List<Menu> Siparisler = new List<Menu>();
        private List<YanUrun> YanUrunSiparisleri;
        private bool yanUrunVarMi;

        public KasaPersoneli() : base(Gorev.KasaPersoneli)
        {
            Siparisler = new List<Menu>();
        }


        public Kasa Kasa { get; set; }



        /// <summary>
        /// Kasa personelinin, müşteriden sipariş almasını sağlyan metottur.
        /// </summary>
        /// <param name="musteri"></param>
        /// <exception cref="BostaServisElemaniYokException"></exception>
        public void MusteridenSiparisAl(Musteri musteri)
        
        {
            
            if (!servisElemanlariBosMu)
            {
                throw new BostaServisElemaniYokException();
            }
            if (buyukBoyIsterMisin)
            {
               
                KahveBoyutunuDegistir(musteri.SiparisVer());
            }
            Siparisler.Add(musteri.SiparisVer());//anlık sipariş listesi
            Kasa.GunlukRapor.Add(musteri.SiparisVer());
        }




        /// <summary>
        /// Kahve boyutunu değiştiren metottur.
        /// </summary>
        /// <param name="menu"></param>
        public void KahveBoyutunuDegistir(Menu menu)
        {
            if (buyukBoyIsterMisin)
            {
                menu.Icecek.UrunBoyutu = Boyut.Tall;
                menu.MenuUrunleri[1].UrunBoyutu = Boyut.Tall;
            }
            else
            {
                menu.Icecek.UrunBoyutu = Boyut.Venti;
                menu.MenuUrunleri[1].UrunBoyutu = Boyut.Venti;
            }
               
        }




        /// <summary>
        /// Müşteriden alınan siparişi, Servis personeline yönlendiren metottur.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="YeniSiparisYokException"></exception>
        public Menu SiparisiIlet()
        {
            if (Siparisler.Count == 0)
            {
                throw new YeniSiparisYokException();
            }
            Menu yenisiparis = Siparisler[0];
            Siparisler.Remove(yenisiparis);
            return yenisiparis;
        }



        /// <summary>
        /// Müşteriden yan ürün siparişi aldıran metottur.
        /// </summary>
        /// <param name="musteri"></param>
        public void MusteridenYanUrunSiparisAl(Musteri musteri)
        {
            YanUrunSiparisleri.Add(musteri.YanUrunSiparisVer());
            Kasa.YanUrunGunlukRapor.Add(musteri.YanUrunSiparisVer());
        }




        /// <summary>
        /// Müşteriden alınan yan ürünleri, Servis personesine yönlendiren metottur.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="YeniSiparisYokException"></exception>
        public YanUrun YanUrunSiparisiIlet()
        {
            if (YanUrunSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();
            }
            YanUrun yenisiparis = YanUrunSiparisleri[0];
            YanUrunSiparisleri.Remove(yenisiparis);
            return yenisiparis;
        }




        /// <summary>
        /// Toplam ücretin ödendiği metottur.
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="yanUrunler"></param>
        /// <returns></returns>
        public decimal ToplamMenuUcretiniAl(Menu menu, YanUrun yanUrunler)
        {
            decimal fiyat = menu.FiyatTL;

            if (buyukBoyMu)
            {
                fiyat += menu.BuyukBoyFiyatFarkiTL;
            }
            if (yanUrunVarMi)
            {
                fiyat += yanUrunler.FiyatTL;
            }

            return fiyat;
        }





        /// <summary>
        /// Personellerin elinde iş varsa işe geri çağıran metottur.
        /// </summary>
        /// <returns></returns>
        public KasaPersoneli MoladanDon()
        {
            KasaPersoneli kasaPersoneli = new KasaPersoneli();
            return kasaPersoneli;
        }




        /// <summary>
        /// Personellerin elinde iş yoksa molaya çıkaran metottur.
        /// </summary>
        /// <param name="value"></param>
        public override void MolayaCik(object value)
        {
            value = null;
        }






    }
}
