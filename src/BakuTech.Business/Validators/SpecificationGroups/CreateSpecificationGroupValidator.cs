using FluentValidation;
using BakuTech.Business.DTOs.SpecificationGroups;

namespace BakuTech.Business.Validators.SpecificationGroups;

public class CreateSpecificationGroupValidator : AbstractValidator<CreateSpecificationGroupDto>
{
    public CreateSpecificationGroupValidator()
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

        RuleFor(x => x.DisplayOrder)
            .GreaterThanOrEqualTo(0);
    }
}
