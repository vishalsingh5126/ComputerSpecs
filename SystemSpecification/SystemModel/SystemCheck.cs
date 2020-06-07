using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.SystemModel
{
    public class SystemCheck
    {
        public SystemModel GetSystemModelDetails()
        {
            SystemModel systemModel = new SystemModel();
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_ComputerSystemProduct");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemModel.SerialNumber = Convert.ToString(queryObj["IdentifyingNumber"]).Trim();
                systemModel.ManufacturerAndModel = Convert.ToString(queryObj["Vendor"]).Trim() + " " +
                    Convert.ToString(queryObj["Name"]).Trim() + " " + Convert.ToString(queryObj["Version"]).Trim();
            }
            GetChassisAndTag(systemModel);
            return systemModel;
        }
        private SystemModel GetChassisAndTag(SystemModel systemModel)
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_SystemEnclosure");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                if (queryObj["ChassisTypes"] == null)
                    systemModel.EnclosureType = "Unknown";
                else
                {
                    UInt16[] arrChassisTypes = (UInt16[])(queryObj["ChassisTypes"]);
                    foreach (UInt16 arrValue in arrChassisTypes)
                    {
                        systemModel.EnclosureType = ChassisInfo.GetChassisDetails(arrValue).Trim();
                        break;
                    }
                }
                systemModel.AssetTag = Convert.ToString(queryObj["SMBIOSAssetTag"]).Trim();
            }
            return systemModel;
        }
    }
}
