using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Answer
    {
        public long Id { get; set; }        
        public string AnswerContent { get; set; }
        public bool AcceptanceStatus { get; set; }
        public DateTime CreatedAt { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Point> Points { get; set; }
    }
}
