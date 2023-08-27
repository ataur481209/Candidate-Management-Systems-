using System;
using System.Collections.Generic;

namespace work_01.Models
{
    public partial class Skill
    {
        public Skill()
        {
            CandidateSkills = new HashSet<CandidateSkill>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; } = null!;

        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; }
    }
}
