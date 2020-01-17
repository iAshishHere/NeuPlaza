using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Answer
    {
        public long Id { get; set; }
        public User UserId { get; set; }
        public string AnswerContent { get; set; }
        public bool AcceptanceStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
