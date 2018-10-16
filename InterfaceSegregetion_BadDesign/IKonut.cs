using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregetion_BadDesign
{
    public interface IKonut
    {
        string Adres { get; set; }
        int OdaSayisi { get; set; }
        int MutfakSayisi { get; set; }

    }
}
