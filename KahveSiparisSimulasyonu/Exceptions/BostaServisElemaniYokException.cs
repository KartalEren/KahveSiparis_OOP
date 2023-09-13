using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisSimulasyonu.Exceptions
{
  public class BostaServisElemaniYokException:Exception
    {
        public BostaServisElemaniYokException() : base("Boşta servis elemanı yok. Lütfen bekleyiniz!")
        {

        }
    }
}
