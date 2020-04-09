using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STKMonitor.UI.Models
{
    public enum Camps
    {
        Red,
        Blue
    }
    public class Behaviour
    {
        public int? StartTime { get; set; }
        public int? LastTime { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public Camps Camp { get; set; }
    }
}
