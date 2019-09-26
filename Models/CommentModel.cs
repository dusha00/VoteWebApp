using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteWebApp.Models
{
    public class CommentModel
    {
        public int ID { get; set; }
        public int TopicID { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
