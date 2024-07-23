using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Runner;
using BoDi;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Hooks
{
    [Binding]
    public class SpecflowBase
    {
        IGlobalProperties _iglobalProperties;
        IChromeWebDriver _ichromeWebDriver;
        IFirefoxWebDriver _ifirefoxDriver;
        IDriver _idriver;
        public SpecflowBase(IChromeWebDriver ichromeWebDriver, IFirefoxWebDriver ifirefoxWebDriver)
        {
            _ichromeWebDriver = ichromeWebDriver;
            _ifirefoxDriver = ifirefoxWebDriver;
        }

        [BeforeScenario(Order = 2)]
        public void BeforeScenario(IObjectContainer iobjectContainer, ScenarioContext sc, FeatureContext fc)
        {
            _idriver = iobjectContainer.Resolve<IDriver>();
            IExtentReport extentReport = (IExtentReport)fc["iextentreport"];
            extentReport.CreateScenario(sc.ScenarioInfo.Title);
        }

        [AfterStep]
        public void AfterSteps(ScenarioContext sc, FeatureContext fs)
        {
            IExtentReport extentReport = (IExtentReport)fs["iextentreport"];
            if (sc.TestError != null)
            {
                string base64 = null;
                base64 = _idriver.GetScreenShot();
                extentReport.Fail(sc.StepContext.StepInfo.Text, base64);
            }
            else
            {
                IGlobalProperties iglobalProperties = SpecflowRunner._iserviceProvider.GetRequiredService<IGlobalProperties>();
                string base64 = null;
                if (iglobalProperties.stepscreenshot)
                {
                    base64 = _idriver.GetScreenShot();
                }
                extentReport.Pass(sc.StepContext.StepInfo.Text, base64);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IExtentFeatureReport extentFeatureReport = SpecflowRunner._iserviceProvider.GetRequiredService<IExtentFeatureReport>();
            extentFeatureReport.FlushExtent();
            Thread.Sleep(2000);
            _idriver.CloseBrowser();
        }
    }
}
