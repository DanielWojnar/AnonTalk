using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.DTO
{
    public class CommentReturnDTO
    {
        public string Content { get; set; }
        public bool Image { get; set; }
        public string? ImageBase64 { get; set; }
        public Guid PostId { get; set; }
    }
}
