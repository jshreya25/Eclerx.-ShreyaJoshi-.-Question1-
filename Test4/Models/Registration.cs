using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test4.Models
{
    public class Registration
    {
        [Key]
        public int StudentId { get; set; }
        public String UserId { get; set; }
        public String Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public   String MobileNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}