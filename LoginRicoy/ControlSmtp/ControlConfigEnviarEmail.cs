using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ControlSmtp
{
    public class ControlConfigEnviarEmail
    {
        public ControlConfigEnviarEmail(string tema , string titulo , string texto, string subtxt , string subbject , List<string> Sender)
        {
            useEditBody.tema = tema;
            useEditBody.titulo = titulo;

            useEditBody.subtext = subtxt;
            useEditBody.subsubject = subbject;

            useEditBody.texto = texto;

            var mailService = new SystemSupportMail();

            mailService.sendMail(Sender);
        }
    }
}
