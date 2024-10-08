﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify.Application.Exceptions
{
    public class ValidationException: Exception
    {
        public List<string> validationErrors { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            validationErrors = new List<string>();

            foreach(var validationError in validationResult.Errors)
            {
                validationErrors.Add(validationError.ErrorMessage);
            }
        }
    }
}
