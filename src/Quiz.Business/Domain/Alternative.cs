using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain
{
    public class Alternative : Entity
    {
        public Guid QuestionId { get; set; }

        public string Description { get; set; }

        public bool IsCorrect { get; set; }
    }
}
