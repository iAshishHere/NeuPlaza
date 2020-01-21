using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Question
    {
        public long Id { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public bool AcceptanceStatus { get; set; }
        public DateTime CreatedDate { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public List<Comment> Comments { get; set; }
        public List<TagDetail> TagDetails { get; set; }
        public List<Point> Points { get; set; }
    }
}
