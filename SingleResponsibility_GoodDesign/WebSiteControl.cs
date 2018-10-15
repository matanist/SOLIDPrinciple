using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_GoodDesign
{
    public class WebSiteControl
    {
        public SMS SMS { get; set; }

        public Log Log { get; set; }
        

        public Login Login { get; set; }
       

        public Email Email { get; set; }
        //Tüm işlemler yapılır. 
    }
}
