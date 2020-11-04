using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Kısa Kenar: ");
            //double kisaKenar = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Uzun Kenar: ");
            //double uzunKenar = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Şekil (k: kare, d: dikdörtgen): ");
            //string sekil = Console.ReadLine();

            Console.WriteLine(" Şekil seç \n 1: Kare \n 2: Dikdörtgen \n 3: Üçgen \n 4: Daire");
            switch (Console.ReadLine())
            {
                case "1":
                    Kare kare = new Kare();
                    Console.WriteLine(" Seçiminiz Kare. Lütfen değerleri giriniz.");
                    Console.Write(" Kısa Kenar: ");                    
                    kare.KisaKenar = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Uzun Kenar: ");
                    kare.UzunKenar = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Karenin Alanı: " + kare.AlanHesapla() + "\n Karenin Çevresi: " + kare.CevreHesapla());
                    break;
                case "2":
                    Dikdortgen dikdortgen = new Dikdortgen();
                    Console.WriteLine(" Seçiminiz Dikdörtgen. Lütfen değerleri giriniz.");
                    Console.Write(" Kısa Kenar: ");
                    dikdortgen.KisaKenar = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Uzun Kenar: ");
                    dikdortgen.UzunKenar = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla() + "\n Dikdörtgenin Çevresi: " + dikdortgen.CevreHesapla());
                    break;
                case "3":
                    Ucgen ucgen = new Ucgen();
                    Console.WriteLine(" Seçiminiz Üçgen. Lütfen değerleri giriniz.");
                    Console.Write(" Genişlik: ");
                    ucgen.Genislik = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Yükseklik: ");
                    ucgen.Yukseklik = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Üçgenin Alanı: " + ucgen.AlanHesapla() + "\n Üçgenin Çevresi: " + ucgen.CevreHesapla());
                    break;
                case "4":
                    Daire daire = new Daire();
                    Console.WriteLine(" Seçiminiz Daire. Lütfen değerleri giriniz.");
                    Console.Write(" Yarıçap: ");
                    daire.Yaricap = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Pi Değeri: ");
                    daire.PiSayiDegeri = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Dairenin Alanı: " + daire.AlanHesapla() + "\n Dairenin Çevresi: " + daire.CevreHesapla());
                    break;
                default:
                    Console.WriteLine(" Hatalı seçim yaptınız!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
