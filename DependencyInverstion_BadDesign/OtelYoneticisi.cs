using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInverstion_BadDesign
{
    public class OtelYoneticisi
    {
        public MusteriIslemleri MusteriIslemleri
        {
            get;set;
        }

        public RezervasyonIslemleri RezervasyonIslemleri
        {
            get;set;
        }
        public void Islemler()
        {
            MusteriIslemleri = new MusteriIslemleri();
            RezervasyonIslemleri = new RezervasyonIslemleri();
            //İşlemler. 
        }
    }
}
