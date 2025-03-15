using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using EZCom.Application.Interfaces;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Interfaces.Services;


namespace Application.Common.Validators
{
    public class RegistrationValidator : AbstractValidator<UserDTO>
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationValidator(IRegistrationService registrationService)
        {
            _registrationService = registrationService ?? throw new ArgumentNullException(nameof(registrationService));

            RuleFor(user => user.First_name)
                .NotEmpty().WithMessage("First Name is required")
                .MaximumLength(50).WithMessage("First Name must be at most 50 characters");

            RuleFor(user => user.Last_name)
                .NotEmpty().WithMessage("Last Name is required")
                .MaximumLength(50).WithMessage("Last Name must be at most 50 characters");

            RuleFor(user => user.Login)
                .NotEmpty().WithMessage("Login is required")
                .Matches("^[a-zA-Z0-9]+$").WithMessage("Login can only contain letters and numbers")
                .MustAsync(async (login, cancellation) => await _registrationService.IsLoginUnique(login))
                .WithMessage("Login is already taken");

            RuleFor(user => user.E_mail)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format")
                .MustAsync(async (email, cancellation) => await _registrationService.IsEmailUnique(email))
                .WithMessage("Email is already registered");

            RuleFor(user => user.Phone_number)
                .NotEmpty().WithMessage("Phone Number is required")
                .Matches(@"^\+?[0-9]{10,15}$").WithMessage("Invalid phone number format")
                .MustAsync(async (phone, cancellation) => await _registrationService.IsPhoneNumberUnique(phone))
                .WithMessage("Phone number is already registered");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
                .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter")
                .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter")
                .Matches(@"\d").WithMessage("Password must contain at least one digit")
                .Matches(@"[\W_]").WithMessage("Password must contain at least one special character (!@#$%^&* etc.)");

            RuleFor(user => user.Date_of_birthday)
                .NotEmpty().WithMessage("Date of Birth is required")
                .LessThan(DateTime.Now).WithMessage("Date of Birth must be in the past")
                .Must(BeAtLeast18YearsOld).WithMessage("User must be at least 18 years old");
        }

        private bool BeAtLeast18YearsOld(DateTime dateOfBirth)
        {
            return dateOfBirth <= DateTime.Now.AddYears(-18);
        }
    }

}
