namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SKILLS")]
    public partial class SKILL
    {
        public SKILL()
        {
            APPLICANTS = new HashSet<APPLICANT>();
            JOBS = new HashSet<JOB>();
        }

        [Key]
        public int SKILL_SEQ { get; set; }

        public string SKILL_NAME { get; set; }

        public string DESCRIPTIONS { get; set; }

        public virtual ICollection<APPLICANT> APPLICANTS { get; set; }

        public virtual ICollection<JOB> JOBS { get; set; }
    }
}
