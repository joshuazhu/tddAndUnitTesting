using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn;

namespace LogAnalyzerPropInject
{
    public class LogAnalyzerPropInject
    {
        public LogAnalyzerPropInject ()
        {
            ExtensionManager = new FileExtensionManager();
        }

        public IExtensionManager ExtensionManager { get; set; }

        public bool IsValidLogFileName(string fileName)
        {
            return ExtensionManager.IsValid(fileName);
        }
    }
}
