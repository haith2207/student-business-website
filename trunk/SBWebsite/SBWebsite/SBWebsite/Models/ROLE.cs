namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROLES")]
    public partial class ROLE
    {
        public ROLE()
        {
            ACCOUNTS = new HashSet<ACCOUNT>();
        }

        [Key]
        public int ROLE_SEQ { get; set; }

        [StringLength(50)]
        public string ROLE_NAME { get; set; }

        public virtual ICollection<ACCOUNT> ACCOUNTS { get; set; }
    }
}
