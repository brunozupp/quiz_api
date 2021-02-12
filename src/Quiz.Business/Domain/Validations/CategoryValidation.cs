using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain.Validations
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
