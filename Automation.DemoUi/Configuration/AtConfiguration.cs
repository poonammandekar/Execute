using Automation.Framework.Core.WebUI.Abstraction;
using Microsoft.Extensions.Configuration;
using Automation.Framework.Core.WebUI.Runner;
using Microsoft.Extensions.DependencyInjection;
using Automation.DemoUi.WebAbstraction;

namespace Automation.DemoUi.Configuration
{
    public class AtConfiguration : IAtConfiguration
    {
        IConfiguration _iconfiguration;
        public AtConfiguration()
        {
            IDefaultVariables idefaultVariables = SpecflowRunner._iserviceProvider.GetRequiredService<IDefaultVariables>();
            _iconfiguration = new ConfigurationBuilder().AddJsonFile(idefaultVariables.getAppplicationConfigjson).Build();
        }

        public string GetConfiguration(string key)
        {
            return _iconfiguration[key];
        }
    }


}
