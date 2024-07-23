

namespace Automation.Framework.Core.WebUI.Abstraction
{
    public interface ILogging
    {
        void Debug(string message);
        void Error(string message);
        void Fatal(string message);
        void Warning(string message);
        void Information(string message);
        void LogLevel(string loglevel);
    }
}
