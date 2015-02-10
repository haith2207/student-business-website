namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STAFFS")]
    public partial class STAFF
    {
        public STAFF()
        {
            EMPLOYERs = new HashSet<EMPLOYER>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STAFF_SEQ { get; set; }

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

        [StringLength(50)]
        public string EMAIL { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual ICollection<EMPLOYER> EMPLOYERs { get; set; }
    }
}
