using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string Content { get; set; }
        public bool Image { get; set; }
        public string? ImagePath { get; set; }
        public DateTime UploadDate { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
