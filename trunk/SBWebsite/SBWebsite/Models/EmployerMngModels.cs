using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace SBWebsite.Models
{
    public class EmployerMngModels
    {

    }

    public class CreateJobViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
    }

}