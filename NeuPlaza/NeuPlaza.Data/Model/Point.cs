using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Point
    {
        public long Id { get; set; }
        public User UserId { get; set; }
        public Question QuestionId { get; set; }
        public Answer AnswerId { get; set; }
        public bool Upvote { get; set; }
        public bool Downvote { get; set; }
        public bool AcceptedAnswer { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
