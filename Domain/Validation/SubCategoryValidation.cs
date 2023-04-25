using Data.Entities;
using FluentValidation;

namespace Domain.Validation;

public class SubCategoryValidation: AbstractValidator<SubCategory>
{
    public SubCategoryValidation()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name must be at least 3 characters");
        RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name must be at most 50 characters");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        RuleFor(x => x.Description).MinimumLength(3).WithMessage("Description must be at least 3 characters");
        RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Description must be at most 1000 characters");
        RuleFor(x => x.Schema).NotEmpty().WithMessage("Category is required");
        RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category is required");
    }
    
}