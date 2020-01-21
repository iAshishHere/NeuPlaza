using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Point
    {
        public long Id { get; set; }
        public bool Upvote { get; set; }
        public bool Downvote { get; set; }
        public bool AcceptedAnswer { get; set; }
        public DateTime CreatedAt { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long QuestionId { get; set; }
        public Question Question { get; set; }

        public long AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
