using AngleSharp.Dom;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.DriverContext;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.Reports;
using Automation.Framework.Core.WebUI.Selenium.WebDrivers;
using Automation.Framework.Core.WebUI.WebElements;
using BoDi;
using Microsoft.Extensions.DependencyInjection;

namespace Automation.Framework.Core.WebUI.DIContainer
{
    public class CoreContainerConfig
    {
        public static IServiceProvider ConfigureService()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IDefaultVariables, DefaultVariables>();
            serviceCollection.AddSingleton<ILogging, Logging>();
            serviceCollection.AddSingleton<IGlobalProperties, GlobalProperties>();
            serviceCollection.AddSingleton<IExtentFeatureReport, ExtentFeatureReport>();
            serviceCollection.AddTransient<IExtentReport, ExtentReport>();
            return serviceCollection.BuildServiceProvider();
        }

        public static IObjectContainer SetContainer(IObjectContainer iobjectContainer)
        {
            iobjectContainer.RegisterTypeAs<ChromeWebDriver, IChromeWebDriver>();
            iobjectContainer.RegisterTypeAs<FirefoxWebDriver, IFirefoxWebDriver>();
            iobjectContainer.RegisterTypeAs<Driver, IDriver>();
            iobjectContainer.RegisterTypeAs<AtBy, IAtBy>();
            iobjectContainer.RegisterTypeAs<AtWebElement, IAtWebElement>();
            return iobjectContainer;
        }
    }
}
