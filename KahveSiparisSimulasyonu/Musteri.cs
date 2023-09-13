using KahveSiparisSimulasyonu.Enums;
using KahveSiparisSimulasyonu.Interfaces;
using KahveSiparisSimulasyonu.KahveMenusu;
using KahveSiparisSimulasyonu.Personeller;
using KahveSiparisSimulasyonu.Urunler.EkUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu
{
    public class Musteri: IMusteri
    {
        public Menu MenuTipi { get; set; }

        public Menu Siparisim { get; set; }

        public YanUrun YanUrunlerTipi { get; set; }

        public decimal MusteriParasi { get; set; }

        public decimal KrediKartiBakiyesi { get; set; }


        /// <summary>
        /// Müşterinin sipariş vermesini sağlayan metottur.
        /// </summary>
        /// <returns></returns>
        public Menu SiparisVer()
        {
            return this.MenuTipi;//bunu da kasapersonelinde sipariş al kısmınada iki listeye de eklerdekn metot içinde metot şeklinde yaparız.
        }




        /// <summary>
        /// Müşterinin ücretini ödemesini sağlayan metottur.
        /// </summary>
        /// <param name="kasaPersoneli"></param>
        /// <param name="menu"></param>
        /// <param name="yanUrunler"></param>
        /// <param name="odemeYontemleri"></param>
        public void ToplamUcretiOde(KasaPersoneli kasaPersoneli, Menu menu, YanUrun yanUrunler, OdemeYontemleri odemeYontemleri)
        {
            if (OdemeYontemleri.Nakit == odemeYontemleri)
            {
                this.MusteriParasi -= kasaPersoneli.ToplamMenuUcretiniAl(Siparisim, YanUrunlerTipi);
                //proları buaya atadık normalde metot bizde 2 adet parametre istiyorduk, biz ToplamUcretiOde metodunda ektra 2 değişken tanımlamak yerine hazırdaki bu işlemleri yazdık, çünkü sipariş bizi aslında ToplamMenuUcretiniAl metodunda istenen menu ve yan urun değişkenlerini refere ederler 
            }
            else
            {
                this.KrediKartiBakiyesi -= kasaPersoneli.ToplamMenuUcretiniAl(Siparisim, YanUrunlerTipi);
            }
        }




        /// <summary>
        /// Müşterinin servis personelinden siparişi aldığı metottur.
        /// </summary>
        /// <param name="servisPersoneli"></param>
        public void SiparisiTeslimAl(ServisPersoneli servisPersoneli)
        {
            this.Siparisim = servisPersoneli.SiparisHazirlaVeTeslimEt();//burada aslında servis personelindeki SiparisHazirlaVeTeslimEt(); metodunu buranın Siparisim propuna atadık.(banka işleminde müşteri işlemini, işlemime atamak gibi arada direkt bağlantı yaptık yani.)
        }




        /// <summary>
        /// Yan ürün siparişi vermek için kullanılan metottur.
        /// </summary>
        /// <returns></returns>
        public YanUrun YanUrunSiparisVer()
        {
            return this.YanUrunlerTipi;
        }






        public void SiradaBekle()
        {

        }


    }
}
