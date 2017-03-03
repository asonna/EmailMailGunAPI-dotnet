[How to set up gmail api.](https://developers.google.com/gmail/api/quickstart/dotnet)
[Gmail developer console.](https://console.developers.google.com/apis/credentials/)


//Mailgun code to be retrieved later for other projects
public static RestResponse SendSimpleMessage() {
    RestClient client = new RestClient();
    client.BaseUrl = "https://api.mailgun.net/v3";
    client.Authenticator =
           new HttpBasicAuthenticator("api",
                                      "key-10f7799a2bcff1673f24dd16f4511525");
    RestRequest request = new RestRequest();
    request.AddParameter("domain",
                        "sandboxd3f09273d54e44cdbdffed400986ab09.mailgun.org", ParameterType.UrlSegment);
    request.Resource = "{domain}/messages";
    request.AddParameter("from", "Mailgun Sandbox <postmaster@sandboxd3f09273d54e44cdbdffed400986ab09.mailgun.org>");
    request.AddParameter("to", "Annie Sonna <nsab42@yahoo.com>");
    request.AddParameter("subject", "Hello Annie Sonna");
    request.AddParameter("text", "Congratulations Annie Sonna, you just sent an email with Mailgun!  You are truly awesome!  You can see a record of this email in your logs: https://mailgun.com/cp/log .  You can send up to 300 emails/day from this sandbox server.  Next, you should add your own domain so you can send 10,000 emails/month for free.");
    request.Method = Method.POST;
    return client.Execute(request);
}
