using Data.Entities;
using FluentValidation;

namespace Domain.Validation;

public class LocationValidator:AbstractValidator<Location>
{
    public LocationValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name must be at least 3 characters");
        RuleFor(x => x.Name).MaximumLength(100).WithMessage("Name must be at most 100 characters");
        RuleFor(x => x.Longitude).NotEmpty().WithMessage("Longitude is required");
        RuleFor(x => x.Longitude).GreaterThan(-180).WithMessage("Longitude must be greater than -180");
        RuleFor(x=>x.Longitude).LessThan(180).WithMessage("Longitude must be less than 180");
        RuleFor(x=>x.Latitude).NotEmpty().WithMessage("Latitude is required");
        RuleFor(x=>x.Latitude).GreaterThan(-90).WithMessage("Latitude must be greater than -90");
        RuleFor(x=>x.Latitude).LessThan(90).WithMessage("Latitude must be less than 90");
    }
}