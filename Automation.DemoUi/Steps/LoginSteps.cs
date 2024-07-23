using Automation.DemoUi.WebAbstraction;
using Automation.DemoUI.Pages;
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using BoDi;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps
{
    [Binding]
    public class LoginSteps : ILoginSteps
    {
        LoginPage loginPage;
        IAtConfiguration _iatConfiguration;
        ILoginPage _iloginPage;
        public LoginSteps(IAtConfiguration iatConfiguration, IDriver iDriver, IObjectContainer iobjectContainer, ILoginPage iloginPage)
        {

            _iatConfiguration = iatConfiguration;
            _iloginPage = iloginPage;

        }

        [Given(@"login with valid credentials")]
        public void GivenLoginWithValidCredentials()
        {
            _iloginPage.LoginWithValidCredentials(_iatConfiguration.GetConfiguration("username")
                , _iatConfiguration.GetConfiguration("password"));
        }

        [Given(@"login with Invalid credentials")]
        public void GivenLoginWithInvalidCredentials()
        {
            _iloginPage.LoginWithInValidCredentials("", "");
        }


    }
}
