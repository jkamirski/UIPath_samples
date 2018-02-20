using GmailSend;
using System.Activities.Presentation.Metadata;

namespace UiPath_External_Dll
{
    public class MailClass
    {
        
        public string GetMessage()
        {
            return "Let's send a mail with UiPath!";
        }

        public void SendMailWithUiPath(string username,string password, string subject, string message,string[] to,string[] cc)
        {
            gmail gmail = new gmail();
            gmail.auth(username,password);
            gmail.Subject = subject;
            gmail.Message = message;
            foreach(string t in to){
                gmail.To = t;
            }
            foreach(string c in cc){
                gmail.Cc = c;
            }
            gmail.send();
        }

    }

    // Declare dummy register metadata class to force UiPath to load this assembly
    public class RegisterMetadata : IRegisterMetadata
    {
        public void Register()
        {

        }
    }


}
