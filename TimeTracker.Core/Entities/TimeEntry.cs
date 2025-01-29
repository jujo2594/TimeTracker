using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Core.Entities
{
    public class TimeEntry
    {
        public int Id { get; set; }
        //Colocando "required" hacemos el campo "Project" obligatorio, haciendo que cada vez que tengamos una entrada, debemos establecer un "Project"
        public required string Project { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime? End{ get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
    }
}
