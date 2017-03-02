using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailExperiment.Models
{
    public class EnvironmentVariables
    {
        public static string MailgunKey = "{{MAILGUN-API-KEY}}";
        public static string MailgunDomain = "{{MAILGUN-DOMAIN}}";
        public static string GmailClientId = "{{GMAIL-CLIENT-ID}}"; //Not working yet
        
    }
}
