using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace EmailExperiment.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Body { get; set; }
        public static void SendMailgunMessage(string recipient, string subject, string text)
        {
            RestClient client = new RestClient("https://api.mailgun.net/v3");
            client.Authenticator =
                new HttpBasicAuthenticator("api",
                                            $"{EnvironmentVariables.MailgunKey}");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", $"{EnvironmentVariables.MailgunDomain}", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", $"Email Experiment Website <mailgun@{EnvironmentVariables.MailgunDomain}>");
            request.AddParameter("to", $"{recipient}");
            request.AddParameter("subject", $"{subject}");
            request.AddParameter("text", $"{text}");
            request.Method = Method.POST;
            
            client.ExecuteAsync(request, response =>
            {
                Debug.WriteLine("******************" + recipient);
                Debug.WriteLine(response);
            });

            Debug.WriteLine("test");
        }

        //public static Message SendGmailMessage(GmailService service, string userId, Message email)
        //{
        //    //RestClient client = new RestClient("https://www.googleapis.com");
        //    //client.Authenticator =
        //    //    new HttpBasicAuthenticator("api",
        //    //                                $"{EnvironmentVariables.MailgunKey}");
        //    //RestRequest request = new RestRequest();
        //    //request.AddParameter("domain", $"{EnvironmentVariables.MailgunDomain}", ParameterType.UrlSegment);
        //    //request.Resource = "{domain}/messages";
        //    //request.AddParameter("from", $"Excited User <mailgun@{EnvironmentVariables.MailgunDomain}>");
        //    //request.AddParameter("to", $"{recipient}");
        //    request.AddParameter("subject", $"{subject}");
        //    //request.AddParameter("text", $"{text}");
        //    //request.Method = Method.POST;

        //    //client.ExecuteAsync(request, response =>
        //    //{
        //    //    Debug.WriteLine(response);
        //    //});

        //    try
        //    {
        //        return service.Users.Messages.Send(email, userId).Execute();
        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine(e);
        //    }

        //    return null;
        //}
    }
}
