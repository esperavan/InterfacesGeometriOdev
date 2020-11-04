using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo1
{
    class Kare : IDortgen, IHesapla
    {
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }
        public double AlanHesapla()
        {
            UzunKenar = KisaKenar;
            return KisaKenar * UzunKenar;
        }
        public double CevreHesapla()
        {
            UzunKenar = KisaKenar;
            return 2 * (KisaKenar + UzunKenar);
        }

    }
}
