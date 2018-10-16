using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_GoodDesign
{
    public class MailMesaj : IMesaj
    {
        public string Gonder() => "MailMesaj Gönderildi";

        public string Raporla() => $"{DateTime.Now} zamanında mail mesaj gönderildi";
    }
}
