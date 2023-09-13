using KahveSiparisSimulasyonu.Enums;
using KahveSiparisSimulasyonu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Personeller
{
    public abstract class Personel: IPersonel
    {
        public Gorev Gorev { get; set; }

        public Personel(Gorev gorev)
        {
            Gorev = gorev;
        }


        /// <summary>
        ///  Personellerin iş yoksa molaya çıkmasını sağlayan abstract metottur.Abstract metot kullanmak için personellerin ortak metodu olarak gösterdim. Kasa personeli ve Servis personeli sınıflarında override edeceğim.
        /// </summary>
        /// <param name="value"></param>
        public abstract void MolayaCik(object value);
       
    }
}