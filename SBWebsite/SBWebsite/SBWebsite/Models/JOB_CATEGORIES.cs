namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_CATEGORIES
    {
        public JOB_CATEGORIES()
        {
            APPLICANTS = new HashSet<APPLICANT>();
            JOBS = new HashSet<JOB>();
        }

        [Key]
        public int JOB_CATEGORY_SEQ { get; set; }

        [Required]
        public string NAME { get; set; }

        public virtual ICollection<APPLICANT> APPLICANTS { get; set; }

        public virtual ICollection<JOB> JOBS { get; set; }
    }
}
