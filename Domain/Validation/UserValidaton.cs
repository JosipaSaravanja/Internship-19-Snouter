using Data.Entities;

namespace Domain.Validation;
using FluentValidation;
public class UserValidaton : AbstractValidator<User>
{
    public UserValidaton()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not valid");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
        RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters");
        RuleFor(x => x.Password).MaximumLength(100).WithMessage("Password must be at most 100 characters");
        RuleFor(x=>x.Bio).MaximumLength(1000).WithMessage("Bio must be at most 1000 characters");
    }

}