using Automation.DemoUi.Configuration;
using Automation.DemoUi.WebAbstraction;
using Automation.DemoUI.Pages;
using Automation.DemoUI.Steps;
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.DIContainer;
using BoDi;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Container
{
    [Binding]
    public class ContainerConfig
    {

        [BeforeScenario(Order = 1)]
        public void BeforeScenario(IObjectContainer iobjectContainer)
        {

            iobjectContainer.RegisterTypeAs<AtConfiguration, IAtConfiguration>();
            iobjectContainer.RegisterTypeAs<LoginPage, ILoginPage>();
            iobjectContainer.RegisterTypeAs<LoginSteps, ILoginSteps>();
            iobjectContainer = CoreContainerConfig.SetContainer(iobjectContainer);
        }
    }
}
