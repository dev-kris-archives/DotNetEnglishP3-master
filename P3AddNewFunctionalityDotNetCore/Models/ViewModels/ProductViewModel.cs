using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;

namespace P3AddNewFunctionalityDotNetCore.Models.ViewModels
{

    // Added attributes to validate input
    // Set validation for int fields
    public class ProductViewModel
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "ErrorMissingName")]
        public string Name { get; set; }

        
        public string Description { get; set; }

        
        public string Details { get; set; }

        [Required(ErrorMessage = "ErrorMissingStock"), Range(1, int.MaxValue, ErrorMessage = "Stock must be a valid number")]
        public string Stock { get; set; }

        [Required(ErrorMessage = "ErrorMissingPrice"), Range(1, int.MaxValue, ErrorMessage = "Price must be a valid number")]
        public string Price { get; set; }
    }
}
