using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecification.Processor
{
    public class ProcessorModel
    {
        public string Name { get; set; }
        public string MaxClockSpeed { get; set; }
        public string PrimaryCache { get; set; }
        public string SecondaryCache { get; set; }
        public string TertiaryCache { get; set; }
        public string Architecture { get; set; }
        public int Cores { get; set; }
        public int LogicalProcessors { get; set; }
    }
}
