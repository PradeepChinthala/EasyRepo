using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using System;
using System.Security;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Steps
{
    [Binding]
    public class CreateAccountSteps
    {

        SecureString _username;
        SecureString _password;
        SecureString _mfaSecretKey;
        Uri _xrmUri;
        public CreateAccountSteps()
        {
         _username = System.Configuration.ConfigurationManager.AppSettings["OnlineUsername"].ToSecureString();
         _password = System.Configuration.ConfigurationManager.AppSettings["OnlinePassword"].ToSecureString();
         _mfaSecretKey = System.Configuration.ConfigurationManager.AppSettings["MfaSecretKey"].ToSecureString();
        _xrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["OnlineCrmUrl"].ToString());

    }

        [Given(@"WEB Test Create New Account")]
        public void WebTestCreateNe()
        {

            (new CreateAccount()).WEBTestCreateNewAccount();
           
            
            //var client = new WebClient(TestSettings.Options);
            //using (var xrmApp = new XrmApp(client))
            //{
            //    xrmApp.OnlineLogin.Login(_xrmUri, _username, _password);

            //    xrmApp.Navigation.OpenApp(UCIAppName.Sales);

            //    xrmApp.Navigation.OpenSubArea("Sales", "Accounts");

            //    xrmApp.CommandBar.ClickCommand("New");

            //    xrmApp.Entity.SetValue("name", TestSettings.GetRandomString(5, 15));

            //    xrmApp.Entity.Save();

            //}
        }
    }
}
