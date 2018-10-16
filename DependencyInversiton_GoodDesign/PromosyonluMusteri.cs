using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversiton_GoodDesign
{
    public class PromosyonluMusteriIslemleri : IMusteriIslemleri
    {
        public decimal FiyatHesapla() => 3.5m;

        public string MusteriBul() => "Müşteri Bulundu";
    }
}
