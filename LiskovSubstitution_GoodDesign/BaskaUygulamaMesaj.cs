using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_GoodDesign
{
    public class BaskaUygulamaMesaj : IMesaj
    {
        public string Gonder() => "BaskaUygulamaMesaj mesaj gönderildi";

        public string Raporla() => $"{DateTime.Now} zamanında BaskaUygulamaMesaj mesaj gönderildi";
    }
}
