using System;

namespace SystemSpecification.ComputerProfile
{
    public class ComputerProfileModel
    {
        public ComputerProfileModel()
        {
            ProfileDate = DateTime.Now.ToString("MM/dd/yyyy H:mm");
        }
        public string ComputerName { get; set; }
        public string Workgroup { get; set; }
        public string ProfileDate { get; set; }
        public string WindowsLogOn { get; set; }
    }
}
