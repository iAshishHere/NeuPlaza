using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Model
{
    public class Tag
    {
        public long Id { get; set; }
        public string TagName { get; set; }

        public List<TagDetail> TagDetails { get; set; }
    }
}
