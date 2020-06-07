using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.Processor
{
    public class ArchitectureInfo
    {
        public static string GetArchitectureInfo(int architectureId)
        {
            string architecture = "";
            switch (architectureId)
            {
                case 0:
                    architecture = "32 bit ready";
                    break;
                case 1:
                    architecture = "MIPS ready";
                    break;
                case 2:
                    architecture = "3Alpha ready";
                    break;
                case 3:
                    architecture = "PowerPC ready";
                    break;
                case 5:
                    architecture = "ARM ready";
                    break;
                case 6:
                    architecture = "ia64 ready";
                    break;
                case 9:
                    architecture = "64 bit ready";
                    break;
                default: architecture = "unknown";
                    break;
            }
            return architecture;
        }
    }
}
