using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColmSheehan.Models
{
    public class DB
    {
         public static List<Recommendation> recommendations = new List<Recommendation>()
        {
            new Recommendation()
            {
                Author = "Sam Lally",
                Text = "He's a nice guy",
                Email = "123@123.ie"
            },
            new Recommendation()
            {
                Author = "Andrea V",
                Text = "He's a cool guy",
                Email = "123@123.ie"
            },
            new Recommendation()
            {
                Author = "Andrea Rossi",
                Text = "He's a decent guy",
                Email = "123@123.ie"
            },

        };



    }
    public class Recommendation
    {
        public class OnlyPositive : ValidationAttribute
            {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
                String text = (String)value;
                if (text != null && text.Contains("bad"))
                {
                    return new ValidationResult("Please don't leave negative reviews");
                }
                return ValidationResult.Success;
                /*Recommendation rec = (Recommendation)value;

            if (rec.Author == "Colm")
            {
                return new ValidationResult("You can't reccomend yourself");
            }
            return ValidationResult.Success;*/
        }
    }
        
        [Display(Name = "Author of the Review")]
        [Required(ErrorMessage = "We do not allow anonymous reviews")]
        [StringLength(50, MinimumLength = 3)]
        public string Author { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [OnlyPositive]
        public string Text { get; set; }
    }
}
