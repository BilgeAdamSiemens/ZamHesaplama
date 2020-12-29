using System;

namespace ConsoleApp2
{
    class Program
    {
        public double MaasHesapla(int cocuksayisi, double maas)
        {
            double zam = 0;
            if (cocuksayisi == 1)
            {
                zam = maas * 0.05;
                Console.WriteLine("Yapılacak zam oranı 5% zam tutarı {0}", zam);
                return zam + maas;
            }

            if (cocuksayisi == 2)
            {
                zam = maas * 0.10;
                Console.WriteLine("Yapılacak zam oranı 5% zam tutarı {0}", zam);
                return zam + maas;
            }

            if (cocuksayisi >= 3)
            {
                zam = maas * 0.15;
                Console.WriteLine("Yapılacak zam oranı 5% zam tutarı {0}", zam);
                return zam + maas;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Geçersiz giriş");
            }
        }

        static void Main(string[] args)
        {
            double alinanMaas = 0;
            Program p = new Program();
            Console.WriteLine("Kaç çocuklu çalışan için zam hesaplanacak ?");
            int cevap = int.Parse(Console.ReadLine());
            if (cevap == 1)
            {
                Console.WriteLine("Maaş tutarını girin: ");
                alinanMaas = double.Parse(Console.ReadLine());
                Console.WriteLine(p.MaasHesapla(cevap, alinanMaas));
            }

            if (cevap == 2)
            {
                Console.WriteLine("Maaş tutarını girin: ");
                alinanMaas = double.Parse(Console.ReadLine());
                Console.WriteLine(p.MaasHesapla(cevap, alinanMaas));
            }

            if (cevap >= 3)
            {
                Console.WriteLine("Maaş tutarını girin: ");
                alinanMaas = double.Parse(Console.ReadLine());
                Console.WriteLine(p.MaasHesapla(cevap, alinanMaas));
            }

            if (cevap == 0)
            {
                Console.WriteLine("Toplam çalışan sayısı :");
                double calisan = int.Parse(Console.ReadLine());
                Console.WriteLine("1 ve 2 çocuğu olan çalışan sayısı: ");
                double cocuklu = int.Parse(Console.ReadLine());
                Console.WriteLine("Çocuksuz çalışanın aldığı maaşı girin : ");
                double cocuksuzMaas = double.Parse(Console.ReadLine());
                double cocuksuzZam = (cocuksuzMaas / 100) * (cocuklu / calisan) * 10;
                Console.WriteLine("Çocuksuz çalışanın alacağı zam {0}", cocuksuzMaas + cocuksuzZam);
            }
        }
    }
}


// dışarıdan çalışan sayısı alınacak 
// her çalışanın kaç çocuğu var alınacak
// bir şirkette çalışanlarına zam yapılacak. zam oranı çalışanın çocuk sayısına göre belirlenecek 
// 1 çocuk varsa 5%
// 2 çocuk varsa 10%
// 3 çocuk varsa 15%
// çocuğu yoksa 
// 1 ve 2 çocuklu kişilerin aritmetik ortalaması zam olarak yapılacak