using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Question
    {
        public long Id { get; set; }
        public User UserId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public bool AcceptanceStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
