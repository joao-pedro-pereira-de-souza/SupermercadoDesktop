using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmtp
{
    public class SystemSupportMail:ControlMailServer
    {

        public  SystemSupportMail()
        {
            senderMail = "jpricoydesign@gmail.com";
            password = "jpDesign@Ricoy";
            host = "smtp.gmail.com";
            port = 587;
            sll = true;

            inicializarSmtpClient();
        }
    }
}
