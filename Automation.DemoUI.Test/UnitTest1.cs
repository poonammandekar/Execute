using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.DIContainer;
using Microsoft.Extensions.DependencyInjection;


namespace Automation.DemoUI.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Logging logging = new Logging();
            IServiceProvider serviceProvider = CoreContainerConfig.ConfigureService();
            IGlobalProperties globalProperties = serviceProvider.GetRequiredService<IGlobalProperties>();

            ////globalProperties.Configuration();
            //ILogging logging = serviceProvider.GetRequiredService<ILogging>();
            //logging.Warning("Hello World!");
            //logging.Information("Information");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }




}