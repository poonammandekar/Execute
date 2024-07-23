using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction
{
    public interface ILoginPage
    {
        void LoginWithValidCredentials(string username, string password);
        void LoginWithInValidCredentials(string username, string password);

    }
}
