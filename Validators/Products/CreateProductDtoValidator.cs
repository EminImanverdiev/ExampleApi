using FluentValidation;
using WebApiAdvance.Entities.Dtos.Products;

namespace WebApiAdvance.Validators.Products
{
    public class CreateProductDtoValidator:AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Name field must not be empty!")
                .NotNull().WithMessage("Name filed must  not be null!")
                .MaximumLength(100)
                .MinimumLength(0); 
        }

    }
}
