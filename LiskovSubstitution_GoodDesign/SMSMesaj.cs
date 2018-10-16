using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_GoodDesign
{
    public class SMSMesaj : IMesaj
    {
        public string Gonder() => "SMSMesaj gönderildi";

        public string Raporla() => $"{DateTime.Now} zamanında mesaj gönderildi";
    }
}
