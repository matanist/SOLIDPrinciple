using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversiton_GoodDesign
{
    public class OtelYoneticisi
    {
        public IMusteriIslemleri IMusteriIslemleri
        {
            get;set;
        }

        public IRezervasyonIslemleri IRezervasyonIslemleri
        {
            get;set;
        }
        public string Islemler(IMusteriIslemleri musteriIslemleri,IRezervasyonIslemleri rezervasyonIslemleri)
        {
            var message = musteriIslemleri.MusteriBul() + " " + musteriIslemleri.FiyatHesapla() + " " + rezervasyonIslemleri.RezervasyonYap();
            return message;
        }
    }
    public class Program
    {
        static void Main()
        {
            var yeniMusteri = new PromosyonluMusteriIslemleri();
            var yeniRezervasyon = new OzelGunRezervsayonIslemleri();
            var otelYoneticisi = new OtelYoneticisi();
            Console.WriteLine(otelYoneticisi.Islemler(yeniMusteri, yeniRezervasyon));
        }
    }
}
