using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregetion_GoodDesign
{
    public interface ITemelKonut
    {
        string Adres { get; set; }
        int OdaSayisi { get; set; }

    }
}
