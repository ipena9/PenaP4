using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaP4.Models.Resume
{
    public class ResumeViewModel
    {
        public List<Education> EducationItems { get; set; }
        public List<Experience> ExperinceItems { get; set; }
        public List<Skill> SkillItems { get; set; }
        public string Preamble { get; set; }

        public ResumeViewModel()
        {

        }


    }

}
