using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
namespace StaffManagement.Attributes
{
    public class MaxFileSizeAttribute:ValidationAttribute
    {
        private readonly int maxFileSizeKB;
        private readonly int maxFileSize;

        public MaxFileSizeAttribute(int maxFileSizeKB)
        {
            this.maxFileSizeKB = maxFileSizeKB;
            this.maxFileSize = maxFileSizeKB * 1024;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if(file.Length> maxFileSizeKB)
                {
                    return new ValidationResult($"The result size exceeds the limit allowed {maxFileSize}KB");
                }
            }
            return ValidationResult.Success;
        }
    }
}
