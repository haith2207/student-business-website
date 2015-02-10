namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYER")]
    public partial class EMPLOYER
    {
        public EMPLOYER()
        {
            JOBS = new HashSet<JOB>();
        }

        [Key]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        [StringLength(150)]
        public string NAME { get; set; }

        [StringLength(300)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string PHONE { get; set; }

        [StringLength(1500)]
        public string DESCRIPTIONS { get; set; }

        [StringLength(50)]
        public string STAFF_APPROVE { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual STAFF STAFF { get; set; }

        public virtual ICollection<JOB> JOBS { get; set; }
    }
}
