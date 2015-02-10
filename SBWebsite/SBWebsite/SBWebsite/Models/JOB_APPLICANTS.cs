namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_APPLICANTS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string USER_APPLICANT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JOB_SEQ { get; set; }

        public DateTime? APPLY_TIME { get; set; }

        public bool? status { get; set; }

        public virtual APPLICANT APPLICANT { get; set; }

        public virtual JOB JOB { get; set; }
    }
}
