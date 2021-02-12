using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain.Validations
{
    public class QuestionValidation : AbstractValidator<Question>
    {
        public QuestionValidation()
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .MinimumLength(10).WithMessage("A pergunta precisa ter no mínimo 10 letras");
        }

    }
}
