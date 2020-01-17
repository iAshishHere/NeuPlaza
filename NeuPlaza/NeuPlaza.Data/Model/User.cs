using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string UserEmail { get; set; }
        public string LastName { get; set; }
        public string UserDetail { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
