using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregetion_GoodDesign
{
    public class Ev : ITemelKonut, IMutfak
    {
        public int MutfakSayisi { get; set; }
        public string Adres { get; set; }
        public int OdaSayisi { get; set; }
    }
}
