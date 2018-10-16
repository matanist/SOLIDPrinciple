using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversiton_GoodDesign
{
    public class OzelGunRezervsayonIslemleri : IRezervasyonIslemleri
    {
        public string RezervasyonYap() => "Özel gün için rezervasyon yapıldı";
        
    }
}
