using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose_BadDesign
{
    public class AracSatisYoneticisi
    {
        public Arac Arac
        {
            get;set;
        }

        //AracSatisYoneticisi'nin SatisYap adında bir metodu olsun. 
        public string SatisYap()
        {
            if (Arac is BinekArac)
            {
               return (Arac as BinekArac).SatisYap();
            }
            if (Arac is TicariArac)
            {
                return (Arac as TicariArac).SatisYap();
            }
            return String.Empty;

        }
    }
}
