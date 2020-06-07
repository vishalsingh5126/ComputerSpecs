using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.Processor
{
    public class ProcessorCheck
    {
        public ProcessorModel GetProcessorDetails()
        {
            ProcessorModel processorModel = new ProcessorModel();

            ManagementObjectSearcher searcher =
                  new ManagementObjectSearcher("root\\CIMV2",
                  "SELECT * FROM Win32_Processor");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                processorModel.Architecture = ArchitectureInfo.GetArchitectureInfo(Convert.ToInt32(queryObj["Architecture"]));
                processorModel.MaxClockSpeed = Math.Round(Convert.ToDouble(queryObj["MaxClockSpeed"])/1000,2).ToString()+ " GHz";
                processorModel.Name = Convert.ToString(queryObj["Name"]);
                processorModel.Cores = Convert.ToInt32(queryObj["NumberOfCores"]);
                processorModel.LogicalProcessors = Convert.ToInt32(queryObj["NumberOfLogicalProcessors"]);
            }
            GetCacheSize(processorModel);
            return processorModel;
        }
        private ProcessorModel GetCacheSize(ProcessorModel processorModel)
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_CacheMemory");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                string purpose = Convert.ToString(queryObj["Purpose"]).Trim();
                if (purpose.ToLower().Contains("l1"))
                    processorModel.PrimaryCache = Convert.ToString(queryObj["MaxCacheSize"]);
                if (purpose.ToLower().Contains("l2"))
                    processorModel.SecondaryCache = Convert.ToString(queryObj["MaxCacheSize"]);
                if (purpose.ToLower().Contains("l3"))
                    processorModel.TertiaryCache = Convert.ToString(queryObj["MaxCacheSize"]);
            }
            return processorModel;
        }
    }
}
