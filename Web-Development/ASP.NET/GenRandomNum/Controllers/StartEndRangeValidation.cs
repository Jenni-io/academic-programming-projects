using GenRandomNum.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

// The AI prompmts I asked to figure this out:
// 1. How does custom Validation attributes work in a MVC application?
// 2. Why are the members readonly? 
// 3. How can I pass a int value from the model to the validation attribute?
// 4. Why is a property's type property info
// 5. What is ValidationResult.Success?
// 6. Why is the Validation a success if the passed values are null?
// 7. Could I also access the members of a class using the instance of a
// class instead of passing it through a property value using reflection?
// 

namespace GenRandomNum.Controllers
{
    public class StartEndRangeValidation : ValidationAttribute {

        // stores the name of passed property 
        private readonly string _startRange;

        // recives the name of starting property name
        public StartEndRangeValidation(string startRange)
        {
            _startRange = startRange;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Uses reflection to get the property info object of the starting property
            PropertyInfo startingRangeInfo = validationContext.ObjectType.GetProperty(_startRange);

            // Gets the actual val of the starting range info from the model instance 
            int start = (int)startingRangeInfo.GetValue(validationContext.ObjectInstance); 
            int end = Convert.ToInt32(value);

            // Validate logic: start cannot be greater than end
            if (start > end) { 
                return new ValidationResult(ErrorMessage ?? "Ending Range must be greater than or equal to Starting Range.");
            }
            return ValidationResult.Success;
        }
    }
}