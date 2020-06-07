using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.OperatingSystem
{
    public class InstalledOS
    {
        public InstalledOSModel GetOSDetails()
        {
            InstalledOSModel installedOSModel = new InstalledOSModel();
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            installedOSModel.Version = Convert.ToString(registryKey.GetValue("ReleaseId")).Trim();
            installedOSModel.BuildVersion = Convert.ToString(registryKey.GetValue("UBR")).Trim();
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                installedOSModel.Name = Convert.ToString(queryObj["Caption"]).Trim();
                installedOSModel.InstallDate = Convert.ToDateTime(ManagementDateTimeConverter.ToDateTime(Convert.ToString(queryObj["InstallDate"]))).ToString("MM/dd/yyyy H:mm");
                installedOSModel.Build = Convert.ToString(queryObj["BuildNumber"]).Trim();
                installedOSModel.systemBit = Convert.ToString(queryObj["OSArchitecture"]).Trim();
            }
            return installedOSModel;
        }
    }
}
