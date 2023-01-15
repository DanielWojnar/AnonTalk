using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.DTO
{
    public class CommentReceiveDTO
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public bool Image { get; set; }
        public string? ImagePath { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
