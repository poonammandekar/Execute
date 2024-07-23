using Automation.Framework.Core.WebUI.Abstraction;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUi.WebAbstraction
{
    public interface IAtConfiguration
    {
        public string GetConfiguration(string key);
    }

}
