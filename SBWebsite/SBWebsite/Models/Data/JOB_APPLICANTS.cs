//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBWebsite.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class JOB_APPLICANTS
    {
        public string USER_APPLICANT { get; set; }
        public int JOB_SEQ { get; set; }
        public Nullable<System.DateTime> APPLY_TIME { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual APPLICANT APPLICANT { get; set; }
        public virtual JOB JOB { get; set; }
    }
}
