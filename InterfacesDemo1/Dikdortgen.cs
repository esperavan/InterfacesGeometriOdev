using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo1
{
    class Dikdortgen : IDortgen, IHesapla
    {
        public double KisaKenar { get; set; } // proterty
        public double UzunKenar { get; set; }
        public double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
        public double CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}
