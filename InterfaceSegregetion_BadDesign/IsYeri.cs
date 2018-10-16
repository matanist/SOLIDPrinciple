using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregetion_BadDesign
{
    public class IsYeri : IKonut
    {
        public string Adres { get; set; }
        public int OdaSayisi { get; set; }
        public int MutfakSayisi { get; set; }
    }
}
