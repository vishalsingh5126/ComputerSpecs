using System;

namespace SystemSpecification.ComputerProfile
{
    public class ComputerProfileModel
    {
        public ComputerProfileModel()
        {
            ProfileDate = DateTime.Now.GetDateTimeFormats()[21];
        }
        public string ComputerName { get; set; }
        public string ProfileDate { get; set; }
        public string WindowsLogOn { get; set; }
    }
}
