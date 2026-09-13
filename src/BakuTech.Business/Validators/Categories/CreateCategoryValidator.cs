using FluentValidation;
using BakuTech.Business.DTOs.Categories;

namespace BakuTech.Business.Validators.Categories;

public sealed class CreateCategoryValidator : AbstractValidator<CreateCategoryDto>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.NameAz)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.NameEn)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.NameRu)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.SlugAz)
            .NotEmpty()
            .MaximumLength(250);

        RuleFor(x => x.SlugEn)
            .NotEmpty()
            .MaximumLength(250);

        RuleFor(x => x.SlugRu)
            .NotEmpty()
            .MaximumLength(250);

        RuleFor(x => x.DescriptionAz)
            .MaximumLength(2000);

        RuleFor(x => x.DescriptionEn)
            .MaximumLength(2000);

        RuleFor(x => x.DescriptionRu)
            .MaximumLength(2000);
    }
}
