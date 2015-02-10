namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JOBS")]
    public partial class JOB
    {
        public JOB()
        {
            JOB_APPLICANTS = new HashSet<JOB_APPLICANTS>();
            SUGGESTIONS = new HashSet<SUGGESTION>();
            JOB_CATEGORIES = new HashSet<JOB_CATEGORIES>();
            TIMEs = new HashSet<TIME>();
            SKILLS = new HashSet<SKILL>();
        }

        [Key]
        public int JOB_SEQ { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        [StringLength(150)]
        public string NAME { get; set; }

        [StringLength(1500)]
        public string DESCRIPTIONS { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        public int? CANDIDATE_QUANTITY { get; set; }

        public bool? STATUS { get; set; }

        public int? AGE { get; set; }

        public virtual EMPLOYER EMPLOYER { get; set; }

        public virtual ICollection<JOB_APPLICANTS> JOB_APPLICANTS { get; set; }

        public virtual ICollection<SUGGESTION> SUGGESTIONS { get; set; }

        public virtual ICollection<JOB_CATEGORIES> JOB_CATEGORIES { get; set; }

        public virtual ICollection<TIME> TIMEs { get; set; }

        public virtual ICollection<SKILL> SKILLS { get; set; }
    }
}
