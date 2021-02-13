using Quiz.Business.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain
{
    public class Question : Entity
    {
        public string Description { get; set; }

        public QuestionLevel QuestionLevel { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Alternative> Alternatives { get; set; }
    }
}
