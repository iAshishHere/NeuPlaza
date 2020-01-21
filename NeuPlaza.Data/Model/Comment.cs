using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Comment
    {
        public long Id { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreatedAt { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long QuestionId { get; set; }
        public Question Question { get; set; }

        public long AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
