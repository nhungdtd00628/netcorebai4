using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore1.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "RollNumber")]
       
        public string RollNumber { get; set; }
        [Nhung("NhungFirstName")]
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "nhap ten")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "nhap ten")]
        public string LastName { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "nhap email")]
        public string Email { get; set; }
        [Display(Name = "CreateAt")]
        public DateTime CreateAt { get; set; }
        [Display(Name = "UpdateAt")]
        public DateTime UpdateAt { get; set; }
        [Display(Name = "Status")]
        public StudentStatus Status { get; set; }
        public Student()
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Gender = Gender.Male;
            this.Status = StudentStatus.Activated;
        }
    }
    public enum Gender
    {
        Male = 1,
        Female = 0,
        Orther = 2
    }
    public enum StudentStatus
    {
        Activated = 1,
        DeActivated = 0
    }
}
public class NhungAttribute : ValidationAttribute, IClientModelValidator
{
    private string _NhungFirstName;
    public NhungAttribute(string NhungFirstName)
    {
        _NhungFirstName = NhungFirstName;
    }

    

    public void AddValidation(ClientModelValidationContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }
        context.Attributes["data-val"] = "true";
        context.Attributes["data-val-nhung"] = "Messageloi";
        context.Attributes["data-val-nhung-nhungfirstname"] = _NhungFirstName;

    }
}
