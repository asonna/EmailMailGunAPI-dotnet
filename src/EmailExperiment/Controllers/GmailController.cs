//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using EmailExperiment.Models;
//using Google.Apis.Gmail.v1;
//using Google.Apis.Gmail.v1.Data;
//using Google.Apis.Auth.OAuth2;
//using System.IO;

//// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//namespace EmailExperiment.Controllers
//{
//    public class GmailController : Controller
//    {
//        // GET: /<controller>/
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult SendMessage(string recipient, string subject, string text)
//        {
//            UserCredential credential;

//            using (var stream =
//                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
//            {
//                string credPath = Environment.GetFolderPath(
//                    Environment.SpecialFolder.Personal);
//                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

//                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
//                    GoogleClientSecrets.Load(stream).Secrets,
//                    Scopes,
//                    "user",
//                    CancellationToken.None,
//                    new FileDataStore(credPath, true)).Result;
//                Console.WriteLine("Credential file saved to: " + credPath);
//            }

//            // Create Gmail API service.
//            GmailService service = new GmailService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = ApplicationName,
//            });

//            // Define parameters of request.
//            UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List("me");

//            // List labels.
//            IList<Label> labels = request.Execute().Labels;
//            Console.WriteLine("Labels:");
//            if (labels != null && labels.Count > 0)
//            {
//                foreach (var labelItem in labels)
//                {
//                    Console.WriteLine("{0}", labelItem.Name);
//                }
//            }
//            else
//            {
//                Console.WriteLine("No labels found.");
//            }
//            Console.Read();

//            Email.SendGmailMessage(new GmailService(), "levibibo@gmail.com", newMessage);
//            return Content("Message sent.");
//        }
//    }
//}
