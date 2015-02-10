namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIME")]
    public partial class TIME
    {
        public TIME()
        {
            APPLICANTS = new HashSet<APPLICANT>();
            JOBS = new HashSet<JOB>();
        }

        [Key]
        public int TIME_SEQ { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public virtual ICollection<APPLICANT> APPLICANTS { get; set; }

        public virtual ICollection<JOB> JOBS { get; set; }
    }
}
