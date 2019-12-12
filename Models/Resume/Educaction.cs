using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaP4.Models.Resume
{
    public class Education
    {
        public string degree { get; set; }
        public int educationID { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public string School { get; set; }
    }
}
