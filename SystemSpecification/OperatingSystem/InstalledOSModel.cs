using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.OperatingSystem
{
    public class InstalledOSModel
    {
        public string Name { get; set; }
        public string systemBit { get; set; }
        public string Version { get; set; }
        public string Build { get; set; }
        public string InstallLanguage { get; set; }
        public string CurrentLanguage { get; set; }
        public string InstallDate { get; set; }
        public string BuildVersion { get; set; }
    }
}
