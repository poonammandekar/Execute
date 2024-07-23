using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Abstraction
{
    public interface IGlobalProperties
    {
        public void Configuration();
        public string datasetlocation { get; set; }
        public string downloadedlocation { get; set; }
        public string browsertype { get; }
        bool stepscreenshot { get; }

        public string gridhuburl { get; }

    }
}
