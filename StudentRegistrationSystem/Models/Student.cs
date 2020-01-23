using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegistrationSystem.Models
{
    public class Student
    {
        public int id { get; set; }

        [Display(Name ="Student Photo")]
        public byte[] photo { get; set; }

        [Required(ErrorMessage ="First Name is required to complete the form")]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public String firstName { get; set; }

        [Required(ErrorMessage = "Father's Name is required to complete the form")]
        [StringLength(255)]
        [Display(Name = "Father's Name")]
        public String fatherName { get; set; }

        [Required(ErrorMessage = "Grandfather's Name is required to complete the form")]
        [StringLength(255)]
        [Display(Name = "Grand Father's Name")]
        public String grandFatherName { get; set; }

        [Required(ErrorMessage = "Age is required to complete the form")]
        [Display(Name = "Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Gender is required to complete the form")]
        [StringLength(255)]
        [Display(Name = "Gender")]
        public String gender { get; set; }

        [Display(Name = "Bio")]
        public String bio { get; set; }

        [StringLength(255)]
        [Display(Name = "Region")]
        public String region { get; set; }

        [Required(ErrorMessage = "City is required to complete the form")]
        [StringLength(255)]
        [Display(Name = "City")]
        public String city { get; set; }

        [Required(ErrorMessage = "Sub-city is required to complete the form")]
        [StringLength(255)]
        [Display(Name = "Sub-city")]
        public String subcity { get; set; }

        [Display(Name = "Woreda")]
        public int woreda { get; set; }

        [StringLength(255)]
        [Display(Name = "House No.")]
        public String houseNo { get; set; }

        [Required(ErrorMessage = "Phone No. is required to complete the form")]
        [Phone]
        [Display(Name = "Phone No.")]
        public String phoneNo { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public String email { get; set; }

    }
}