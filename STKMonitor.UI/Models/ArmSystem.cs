using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STKMonitor.UI.Models
{
    public class ArmSystem
    {
        public Camps Camp { get; set; }
        public string Name { get; set; }
        public List<Behaviour> Behaviours { get; set; }
    }
}
