using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace MvcApplicationTest.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string GetString()
        {
            return "Hello World is old now. It&rsquo;s time for wassup bro ;)";
            ///testing git hub //testes push
            //testing pull
        }
        //Changes at remote side
        //second change at remote

        public void SendExtractInformationByEmail()
        {
            MailMessage extractMessage = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.factset.com");
            extractMessage.From = new MailAddress("mokumar@factset.com");
            extractMessage.To.Add("mokumar@factset.com");
            extractMessage.Subject = "Extract Information";
            client.Port = 25;
            //client.Credentials = new System.Net.NetworkCredential("me", "password");
            //client.EnableSsl = true;

            client.Send(extractMessage);
        }
    }
}
