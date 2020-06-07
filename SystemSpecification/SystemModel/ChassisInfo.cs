using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.SystemModel
{
    /*Reference https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-systemenclosure*/
    public class ChassisInfo
    {
        public static string GetChassisDetails(int ChassisNumber)
        {
            string chassisType = "";
            switch (ChassisNumber)
            {
                case 1:
                    chassisType = "Other";
                    break;
                case 2:
                    chassisType = "Unknown";
                    break;
                case 3:
                    chassisType = "Desktop";
                    break;
                case 4:
                    chassisType = "Low Profile Desktop";
                    break;
                case 5:
                    chassisType = "Pizza Box";
                    break;
                case 6:
                    chassisType = "Mini Tower";
                    break;
                case 7:
                    chassisType = "Tower";
                    break;
                case 8:
                    chassisType = "Portable";
                    break;
                case 9:
                    chassisType = "Laptop";
                    break;
                case 10:
                    chassisType = "Notebook";
                    break;
                case 11:
                    chassisType = "Hand Held";
                    break;
                case 12:
                    chassisType = "Docking Station";
                    break;
                case 13:
                    chassisType = "All in One";
                    break;
                case 14:
                    chassisType = "Sub Notebook";
                    break;
                case 15:
                    chassisType = "Space-Saving";
                    break;
                case 16:
                    chassisType = "Lunch Box";
                    break;
                case 17:
                    chassisType = "Main System Chassis";
                    break;
                case 18:
                    chassisType = "Expansion Chassis";
                    break;
                case 19:
                    chassisType = "SubChassis";
                    break;
                case 20:
                    chassisType = "Bus Expansion Chassis";
                    break;
                case 21:
                    chassisType = "Peripheral Chassis";
                    break;
                case 22:
                    chassisType = "Storage Chassis";
                    break;
                case 23:
                    chassisType = "Rack Mount Chassis";
                    break;
                case 24:
                    chassisType = "Sealed-Case PC";
                    break;
                default:
                    chassisType = "Unknown";
                    break;
            }
            return chassisType;
        }
    }
}
