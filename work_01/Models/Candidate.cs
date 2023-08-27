using System;
using System.Collections.Generic;

namespace work_01.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateSkills = new HashSet<CandidateSkill>();
        }

        public int CandidateId { get; set; }
        public string CandidateName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = null!;
        public string? Image { get; set; }
        public bool Fresher { get; set; }

        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; }
    }
}
