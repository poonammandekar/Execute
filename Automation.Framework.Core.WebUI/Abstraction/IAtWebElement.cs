using OpenQA.Selenium;

namespace Automation.Framework.Core.WebUI.Abstraction
{
    public interface IAtWebElement
    {
        void Click();
        void SendKeys(string text);
        void Set(IWebDriver iwebDriver, IAtBy iatBy);
        void ClearText();
        string GetText();
        string GetAttribute(string attributeName);
        void MouseHover();
        bool IsDisplayed();
        void DoubleClick();
        void ClickWithJs();
        IWebElement GetElement();
    }
}
