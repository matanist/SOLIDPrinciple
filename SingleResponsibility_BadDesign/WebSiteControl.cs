using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_BadDesign
{
    public class WebSiteControl
    {
        public string Login()
        {
            //Login işlemlerinin yapıldığı yer. 
            return "Login İşlemleri Yapıldı";
        }
        public string Log()
        {
            //Loglama işlemlerinin yapıldığı yer. 
            return "Loglama işlemleri yapıldı";
        }
        public string Email()
        {
            //Email işlemlerinin yapıldığı yer. 
            return "Email başarı ile gönderildi";
        }
        public string SMS()
        {
            //Sms işlemlerinin yapıldığı yer. 
            return "SMS başarı ile gönderildi.";
        }
    }
}
