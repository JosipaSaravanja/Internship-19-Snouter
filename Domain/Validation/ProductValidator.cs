using Data.Entities;

namespace Domain.Validation;
using FluentValidation;
public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name must be at least 3 characters");
        RuleFor(x => x.Name).MaximumLength(100).WithMessage("Name must be at most 100 characters");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        RuleFor(x => x.Description).MinimumLength(3).WithMessage("Description must be at least 3 characters");
        RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Description must be at most 1000 characters");
        RuleFor(x => x.Price).NotEmpty().WithMessage("Price is required");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        RuleFor(x => x.Price).LessThan(100000).WithMessage("Price must be less than 100000");
        RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category is required");
        RuleFor(x => x.SellerId).NotEmpty();
        RuleFor(x => x.LocationId).NotEmpty();
        RuleFor(x => x.SubCategoryId).NotEmpty();
        RuleFor(x => x.BuyerId).NotEmpty();
        RuleFor(x => x.isSold).NotEmpty();
        RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Image is required");
    }
    

}