using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Domain
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public List<Question> Questions { get; set; }
    }
}
