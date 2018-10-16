using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregetion_GoodDesign
{
    public class IsYeri : ITemelKonut
    {
        public string Adres { get; set; }
        public int OdaSayisi { get; set; }
    }
}
