using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose_GoodDesign
{
    public class AracSatisYoneticisi
    {
        
        public AracSatisYoneticisi(IArac arac)
        {
            _arac = arac;
        }

        public IArac _arac
        {
            get;set;
        }

        public string SatisYap()
        {
            return _arac.SatisYap();
        }

    }
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine(new AracSatisYoneticisi(new BinekArac()).SatisYap()); //Binek araç satışı yapıldı. 
            Console.WriteLine(new AracSatisYoneticisi(new TicariArac()).SatisYap()); //Ticari araç satışı yapıldı. 
            Console.WriteLine(new AracSatisYoneticisi(new SporArac()).SatisYap()); //Spor araç satışı yapıldı. 
            
        }
    }
    
}
