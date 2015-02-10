namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNTS")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        public int ROLE_SEQ { get; set; }

        [Required]
        [StringLength(50)]
        public string PASSWORD { get; set; }

        public bool? STATUS { get; set; }

        public virtual ROLE ROLE { get; set; }

        public virtual APPLICANT APPLICANT { get; set; }

        public virtual EMPLOYER EMPLOYER { get; set; }

        public virtual STAFF STAFF { get; set; }
    }
}
