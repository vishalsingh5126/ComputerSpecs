using System;
using System.Management;

namespace SystemSpecification.ComputerProfile
{
    public class ComputerProfile
    {
        public ComputerProfileModel GetComputerProfile()
        {
            ComputerProfileModel computerProfileModel = new ComputerProfileModel();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                computerProfileModel.ComputerName = Convert.ToString(queryObj["Name"] + " (in " + Convert.ToString(queryObj["Workgroup"]) + ")");
                computerProfileModel.WindowsLogOn = Convert.ToString(queryObj["UserName"]);
            }
            return computerProfileModel;
        }

    }
}
