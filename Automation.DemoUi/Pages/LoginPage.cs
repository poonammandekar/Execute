using Automation.DemoUi.WebAbstraction;
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Automation.DemoUI.Pages
{

    public class LoginPage : TestBase, ILoginPage
    {
        IWebDriver _iwebDriver;
        IDriver _idrivers;
        IAtConfiguration _iatConfiguration;
        IAtBy byUserName => GetBy(LocatorType.Xpath, "//input[@id='user-name']");
        IAtWebElement UserName => _idrivers.FindElement(byUserName);
        IAtBy byPassword => GetBy(LocatorType.Xpath, "//input[@id='password']");
        IAtWebElement Password => _idrivers.FindElement(byPassword);
        IAtBy byLogin => GetBy(LocatorType.Xpath, "//input[@id='login-button']");
        IAtWebElement Login => _idrivers.FindElement(byLogin);
        public LoginPage(IAtConfiguration iatConfiguration, IDriver iDriver, IObjectContainer objectContainer)
            : base(objectContainer)
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _idrivers = iDriver;
            _iwebDriver = iDriver.GetWebDriver();
            _iwebDriver.Manage().Window.Maximize();
            _iatConfiguration = iatConfiguration;
        }
        public void LoginWithValidCredentials(string username, string password)
        {
            string url = _iatConfiguration.GetConfiguration("url");
            _idrivers.NavigateTo(url);
            Thread.Sleep(2000);

            UserName.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();
        }

        public void LoginWithInValidCredentials(string username, string password)
        {
            _idrivers.NavigateTo(_iatConfiguration.GetConfiguration("url"));
            Thread.Sleep(3000);
            UserName.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();
        }
    }
}
