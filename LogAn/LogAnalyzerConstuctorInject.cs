using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn;

namespace LogAnalyzerConstuctorInject
{
    public class LogAnalyzerConstuctorInject
    {
        private IExtensionManager manager;

        public LogAnalyzerConstuctorInject()
        {
            manager = new FileExtensionManager();
        }

        //constructor injection
        public LogAnalyzerConstuctorInject(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            FileExtensionManager mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }
}
