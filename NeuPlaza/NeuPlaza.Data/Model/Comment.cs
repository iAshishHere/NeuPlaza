using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Comment
    {
        public long Id { get; set; }
        public User UserId { get; set; }
        public string CommentContent { get; set; }
        public Question QuestionId { get; set; }
        public Answer AnswerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
