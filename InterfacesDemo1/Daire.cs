using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo1
{
    class Daire : IDaire, IHesapla
    {
        public double Yaricap { get; set; }
        public double PiSayiDegeri { get; set; }

        public double AlanHesapla()
        {
            return PiSayiDegeri * (Yaricap * Yaricap);
        }

        public double CevreHesapla()
        {
            return 2 * PiSayiDegeri * Yaricap;
        }
    }
}
