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
        [Display(Name = "Tiêu Đề")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Mô Tả Công Việc")]
        public string JobDescription { get; set; }

        [Required]
        [Display(Name = "Yêu Cầu Công Việc")]
        public string JobRequiments { get; set; }
        
    }

}