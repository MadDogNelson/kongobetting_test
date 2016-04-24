using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string mail_from = "kay@maddog-development.com";
                string mail_to = "kay.nelson@hotmail.se";
                string rubrik = "Test";
                string message = "Test";
                //
                //
                //

                using (var client = new System.Net.Mail.SmtpClient("localhost", 25))
                {
                    client.UseDefaultCredentials = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mail_from, mail_to, rubrik, message);
                }
                
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
