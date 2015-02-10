namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APPLICANTS")]
    public partial class APPLICANT
    {
        public APPLICANT()
        {
            JOB_APPLICANTS = new HashSet<JOB_APPLICANTS>();
            SUGGESTIONS = new HashSet<SUGGESTION>();
            JOB_CATEGORIES = new HashSet<JOB_CATEGORIES>();
            TIMEs = new HashSet<TIME>();
            SKILLS = new HashSet<SKILL>();
        }

        [Key]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [StringLength(50)]
        public string LAST_NAME { get; set; }

        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        public string EMAIL { get; set; }

        public int AGE { get; set; }

        public string linkCV { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual ICollection<JOB_APPLICANTS> JOB_APPLICANTS { get; set; }

        public virtual ICollection<SUGGESTION> SUGGESTIONS { get; set; }

        public virtual ICollection<JOB_CATEGORIES> JOB_CATEGORIES { get; set; }

        public virtual ICollection<TIME> TIMEs { get; set; }

        public virtual ICollection<SKILL> SKILLS { get; set; }
    }
}
