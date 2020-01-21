using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class TagDetail
    {
        public long Id { get; set; }

        public long TagId { get; set; }
        public Tag Tag { get; set; }

        public long QuestionId { get; set; }
        public Question Question { get; set; }       
    }
}
