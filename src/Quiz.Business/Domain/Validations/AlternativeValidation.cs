using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain.Validations
{
    public class AlternativeValidation : AbstractValidator<Alternative>
    {
        public AlternativeValidation()
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("A propriedade {PropertyName} deve ser preenchida");

            RuleFor(c => c.QuestionId)
                .NotEmpty().WithMessage("A propriedade {PropertyName} deve ser preenchida");

            RuleFor(c => c.IsCorrect)
                .NotNull().WithMessage("A propriedade {PropertyName} deve ser preenchida");
        }
    }
}
