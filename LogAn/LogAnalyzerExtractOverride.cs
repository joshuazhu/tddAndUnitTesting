using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn;

namespace LogAnalyzerExtractOverride
{
    public class LogAnalyzerExtractOverride
    {
        public bool IsValidLogFileName(string fileName)
        {
            return this.IsValid(fileName) && fileName.Length > 5;
        }

        protected virtual bool IsValid(string fileName)
        {
            var mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }
}
