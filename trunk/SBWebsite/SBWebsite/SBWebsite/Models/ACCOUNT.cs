//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        public string USER_NAME { get; set; }
        public int ROLE_SEQ { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual ROLE ROLE { get; set; }
        public virtual APPLICANT APPLICANT { get; set; }
        public virtual EMPLOYER EMPLOYER { get; set; }
        public virtual STAFF STAFF { get; set; }
    }
}
