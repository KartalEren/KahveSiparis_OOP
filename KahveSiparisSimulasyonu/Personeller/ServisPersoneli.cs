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
    public class ServisPersoneli:Personel, IServisPersoneli
    {
        private bool yanUrunSiparisHazirMi;
        private List<Menu> ServisBolumuSiparisleri;
        private List<YanUrun> ServisBolumuYanUrunSiparisleri;




        public ServisPersoneli() : base(Gorev.KasaPersoneli)
        {
            ServisBolumuSiparisleri = new List<Menu>();
        }





        /// <summary>
        /// Kasadan gelen siparişleri alan metottur.
        /// </summary>
        /// <param name="kasaPersoneli"></param>
        public void KasaPersonelindenSiparisAl(KasaPersoneli kasaPersoneli)
        {
            try
            {
                Menu yeniSiparis = kasaPersoneli.SiparisiIlet();
                ServisBolumuSiparisleri.Add(yeniSiparis);
              
            }
            catch (YeniSiparisYokException)
            {
                MolayaCik(this);
            }
        }





        /// <summary>
        /// Siparişi hazırlayıp teslim edilmesini sağlayan metottur.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="YeniSiparisYokException"></exception>
        /// <exception cref="SiparisHazirDegilException"></exception>
        public Menu SiparisHazirlaVeTeslimEt()
        {

            if (ServisBolumuSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();
            }

            if (yanUrunSiparisHazirMi)
            {
                Menu hazirSiparis = ServisBolumuSiparisleri[0];

                ServisBolumuSiparisleri.Remove(hazirSiparis);
                return hazirSiparis;
            }
            else
            {
                throw new SiparisHazirDegilException();

            }
        }





        /// <summary>
        /// Kasadan yan ürün alınmasını sağlayan metottur.
        /// </summary>
        /// <param name="kasaPersoneli"></param>
        public void KasaPersonelindenYanUrunSiparisAl(KasaPersoneli kasaPersoneli)
        {
            try
            {
                ServisBolumuYanUrunSiparisleri.Add(kasaPersoneli.YanUrunSiparisiIlet());
            }
            catch (YeniSiparisYokException)
            {
                MolayaCik(this);
            }
        }






        /// <summary>
        /// Kasadan alınan yan ürünlerin teslim edilmesini sağlayan metottur.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="YeniSiparisYokException"></exception>
        /// <exception cref="SiparisHazirDegilException"></exception>
        public YanUrun YanUrunlerSiparisHazirlaVeTeslimEt()
        {

            if (ServisBolumuYanUrunSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();
            }

            if (yanUrunSiparisHazirMi)
            {
                YanUrun yanUrunHazirSiparis = ServisBolumuYanUrunSiparisleri[0];

                ServisBolumuYanUrunSiparisleri.Remove(yanUrunHazirSiparis);
                return yanUrunHazirSiparis;
            }
            else
            {
                throw new SiparisHazirDegilException();
            }

        }





        /// <summary>
        /// Personellerin elinde iş varsa işe geri çağıran metottur.
        /// </summary>
        /// <returns></returns>
        public ServisPersoneli MoladanDon()
        {
            ServisPersoneli servisPersoneli = new ServisPersoneli();
            return servisPersoneli;
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
