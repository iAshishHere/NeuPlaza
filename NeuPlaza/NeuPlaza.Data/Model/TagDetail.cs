using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class TagDetail
    {
        public long Id { get; set; }
        public Tag TagId { get; set; }
        public Question QuestionId { get; set; }
    }
}
