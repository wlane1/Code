using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
     public class FormHandler
    {
        public void Handle(string toAddress)
        {
            MailSender mailsender = new MailSender();
            mailsender.Send(toAddress, "This is non-ninject example.");
        }
    }
}
