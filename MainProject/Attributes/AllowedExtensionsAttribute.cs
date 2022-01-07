using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace StaffManagement.Attributes
{
    public class AllowedExtensionsAttribute:ValidationAttribute
    {
        private readonly string[] extensions;

        public AllowedExtensionsAttribute(string[] extensions)
        {
            this.extensions = extensions;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult($"Only files with a valid extensions({string.Join(",", extensions)}) are allowed");
                }
            }
            return ValidationResult.Success;
        }
    }
}
