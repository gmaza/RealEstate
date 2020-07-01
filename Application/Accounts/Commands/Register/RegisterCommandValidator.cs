using Application.Common.Interfaces;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Accounts.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        private readonly IIdentityService _identityService;

        public RegisterCommandValidator(IIdentityService identityService)
        {
            _identityService = identityService;

            RuleFor(v => v.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email")
                .MaximumLength(200).WithMessage("Email must not exceed 200 characters.")
                .MustAsync(BeUniqueEmail).WithMessage("The user with this email already exists.");

            RuleFor(v => v.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password must contain more than 8 characters")
                .Matches("[A-Z]").WithMessage("Password must contain at least 1 upper case character")
                .Matches("[a-z]").WithMessage("Password must contain at least 1 lower case character")
                .Matches("[0-9]").WithMessage("Password must contain at least 1 digit");

            RuleFor(v => v.ConfirmPassword)
                .Equal(v => v.Password).WithMessage("Passwords do not match");
        }

        public async Task<bool> BeUniqueEmail(string email, CancellationToken cancellationToken)
        {
            return !(await _identityService.UserWithEmailExists(email));
        }
    }
}
