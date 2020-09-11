using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Reflection;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ControlSmtp
{
     public abstract class ControlMailServer
     {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool sll { get; set; }

        protected void inicializarSmtpClient()
        {
            smtpClient = new SmtpClient();

            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = sll;

            
           
        }

        public void sendMail(List<string> recebMail)
        {
            var mailMessage = new MailMessage();

            try
            {
                //Formato da mensagem.

                mailMessage.From = new MailAddress(senderMail);  // Quem vai enviar.
                //Quem vai receber a mensagem.
                foreach(var mail in recebMail)
                {
                    mailMessage.To.Add(mail);
                }
                //

                //Assunto da mensagem.
                mailMessage.Subject = useEditBody.subsubject;
                //

                //Corpo da mensagem.

                //Design Body : https://www.youtube.com/watch?v=gkJwFVj0TNE.

                //exemplo system :https://stackoverflow.com/questions/8628683/how-to-send-html-formatted-email.

                //exemplo adicionar um arquivo txt no resource :https://www.youtube.com/watch?v=lxbUcU4Q5Fk.
                Assembly asm = Assembly.GetExecutingAssembly();

                StreamReader reader = new StreamReader(asm.GetManifestResourceStream("Business.SmtpAcess.DesignHtmlEmail.txt"), Encoding.UTF8);

                string ler = reader.ReadToEnd();

                ler = ler.Replace("<h1>Tema</h1>","<h1>"+ useEditBody.tema+"</h1>");
                ler = ler.Replace("<h2>Titulo</h2>", "<h2>"+useEditBody.titulo+"</h2>");
                ler = ler.Replace("<p>Texto</p>", "<p>"+useEditBody.texto+"</p>");


                ler = ler.Replace(@"<a href='#' class='button'>Botão</a>", useEditBody.botao);
                ler = ler.Replace("<p>Sub-Texto</p>", "<p>" + useEditBody.subtext) + "</p>";

                mailMessage.IsBodyHtml = true;
                //
                mailMessage.Body = ler;

                reader.Close();
                //Prioridade da mensagem.
                 mailMessage.Priority = MailPriority.Normal;
                //

                //

                //Enviar a mensagem.
                smtpClient.Send(mailMessage);
                //
            }
            catch (Exception ex){      }
            finally
            {
                // fim do processo... 
                //Limpar variáveis.

                smtpClient.Dispose();
                mailMessage.Dispose();
                

                //
            }
        }
     }
}
