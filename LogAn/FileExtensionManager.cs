using System;
using LogAnalyzerConstuctorInject;

namespace LogAn
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("No filename provided!");
            }
            if (!fileName.EndsWith(".SLF"))
            {
                return false;
            }
            return true;
        }
    }
}