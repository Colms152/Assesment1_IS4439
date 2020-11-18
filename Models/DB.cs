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
                Id = 1,
                Author = "Sam Lally",
                Text = "He's a nice guy",
                Email = "123@123.ie",
                Age = 40
            },
            new Recommendation()
            {
                 Id = 2,
                Author = "Andrea V",
                Text = "He's a cool guy",
                Email = "123@123.ie",
                Age = 67
            },
            new Recommendation()
            {
                Id = 3,
                Author = "Andrea Rossi",
                Text = "He's a decent guy",
                Email = "123@123.ie",
                Age = 21
            },

        };



    }
    public class Recommendation :IValidatableObject
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
                
        }
    }


        [Required]
        public int Id { get; set; }
        
        [Display(Name = "Author of the Review")]
        [Required(ErrorMessage = "We do not allow anonymous reviews")]
        [StringLength(50, MinimumLength = 3)]
        public string Author { get; set; }
        
        [EmailAddress]
        [Required(ErrorMessage = "Please Input an email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please Input a reccomendation")]
        [OnlyPositive]
        public string Text { get; set; }
        
        [Required(ErrorMessage = "Please Input an Age")]
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Author == "Colm")
            {
                yield return new ValidationResult("We don't allow self recomendations. If you are a differnt user please input your second name too", new[] { "Andrea" });
            };
            if (this.Email.Contains("isis.org"))
                yield return new ValidationResult("Your organisation isn't allowed to leave reviews", new[] { "Email" });
        }
    }
}
