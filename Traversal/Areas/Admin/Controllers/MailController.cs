using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
//using System.Net.Mail;
using Traversal.Models;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversal22@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom); // mailin kimden geldiği


            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo); // mailin kime gideceği

            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodybuilder.ToMessageBody(); // Mailin içeriği

            //mimeMessage.Body = mailRequest.Body.
            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient Client = new SmtpClient();
            Client.Connect("smtp.gmail.com", 587, false);

            Client.Authenticate("traversal22@gmail.com", "zobc kcom znct ixlk"/*şifresi*/);

            Client.Send(mimeMessage);
            Client.Disconnect(true);
            return View();
        }
    }//traversal22@gmail.com
}
