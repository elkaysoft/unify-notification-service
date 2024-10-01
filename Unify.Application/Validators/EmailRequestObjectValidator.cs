using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Application.Requests;

namespace Unify.Application.Validators
{
    public class EmailRequestObjectValidator: AbstractValidator<EmailRequestDto>
    {
        public EmailRequestObjectValidator()
        {
            RuleFor(x => x.Recepient).NotEmpty().NotNull().WithMessage("Email recipient(s) is required");
            RuleFor(x => x.Sender).NotEmpty().NotNull().WithMessage("Email Sender is required");
            RuleFor(x => x.Body ).NotEmpty().NotNull().WithMessage("Email content is required");
            RuleFor(x => x.Subject).NotNull().WithMessage("Email subject is required");
        }
    }
}
