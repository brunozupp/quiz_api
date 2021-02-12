using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain
{
    public class Question : Entity
    {
        public string Description { get; set; }

        public List<Alternative> Alternatives { get; set; }
    }
}
