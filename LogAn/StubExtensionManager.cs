using LogAn;

namespace LogAnalyzerConstuctorInject
{
    public class StubExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}