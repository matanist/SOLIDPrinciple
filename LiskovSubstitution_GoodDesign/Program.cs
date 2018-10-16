using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_GoodDesign
{
    public class Program
    {
        static string MesajGonderveRaporla(IMesaj mesaj)
        {
            return mesaj.Gonder()+" \n"+mesaj.Raporla();
        }
        
        static void Main()
        {
            var smsMesaj = new SMSMesaj();
            Console.WriteLine(MesajGonderveRaporla(smsMesaj));
            var mailMesaj = new MailMesaj();
            Console.WriteLine(MesajGonderveRaporla(mailMesaj));
            var baskaUygulamaMesaj = new BaskaUygulamaMesaj();
            Console.WriteLine(MesajGonderveRaporla(baskaUygulamaMesaj));
        }
    }
}
