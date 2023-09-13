using KahveSiparisSimulasyonu.Interfaces;
using KahveSiparisSimulasyonu.KahveMenusu;
using KahveSiparisSimulasyonu.Personeller;
using KahveSiparisSimulasyonu.Urunler.EkUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu
{
    public class Kasa : IKasa
    {
        public List<KasaPersoneli> KasaPersoneli { get; set; }

        private List<Menu> gunlukRapor;
        private List<YanUrun> yanUrunGunlukRapor;


        public List<Menu> GunlukRapor//Kapsulleme yapıldı
        {
            get
            { return this.gunlukRapor; }
            set
            { this.gunlukRapor = value; }
        }



        public List<YanUrun> YanUrunGunlukRapor//Kapsulleme yapıldı.
        {
            get
            { return this.yanUrunGunlukRapor; }
            set
            { this.yanUrunGunlukRapor = value; }
        }



        public Kasa()
        {
            gunlukRapor = new List<Menu>();//kasa oluşunca sipariş listesinide oluşturmuş olduk.
            yanUrunGunlukRapor = new List<YanUrun>();
            IslemListdenOku();
        }





        ~Kasa()//Deserialization
        {
            GunlukRaporIsleminiListeyeKaydet();
            GunlukYanUrunlerIsleminiListeyeKaydet();
        }





        /// <summary>
        /// Bu metot günlük alınan standart kahvelerin listesini kaydeder.
        /// </summary>
        public void GunlukRaporIsleminiListeyeKaydet()
        {
            StreamWriter writer = new StreamWriter("GunlukRaporKayıtListesi.json");
            writer.Write(JsonSerializer.Serialize(GunlukRapor));
            writer.Flush();
            writer.Close();
        }





        /// <summary>
        /// Bu metot alınan yan ürünlerin listesini kaydeder.(Ekstra şurup soğuk süt, sıcak süt vs...)
        /// </summary>
        public void GunlukYanUrunlerIsleminiListeyeKaydet()
        {
            StreamWriter writer = new StreamWriter("YanUrunGunlukRaporKayıtListesi.json");
            writer.Write(JsonSerializer.Serialize(YanUrunGunlukRapor));
            writer.Flush();
            writer.Close();
        }

     


        /// <summary>
        /// Bu metot ise kayda alınan verilerin geri çağırılması için oluşturulmuştur.
        /// </summary>
        public void IslemListdenOku()
        {
            StreamReader readerGunlukRapor = new StreamReader("GunlukRapor.json");
            string json1 = readerGunlukRapor.ReadToEnd();
            readerGunlukRapor.Close();
            this.GunlukRapor = JsonSerializer.Deserialize<List<Menu>>(json1);


            StreamReader readerYanUrunGunlukRapor = new StreamReader("YanUrunGunlukRapor.json");
            string json2 = readerYanUrunGunlukRapor.ReadToEnd();
            readerYanUrunGunlukRapor.Close();
            this.YanUrunGunlukRapor = JsonSerializer.Deserialize<List<YanUrun>>(json1);

        }











    }
}
