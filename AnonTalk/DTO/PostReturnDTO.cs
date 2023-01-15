using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.DTO
{
    public class PostReturnDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Image { get; set; }
        public string ImageBase64 { get; set; }
        public string BoardId { get; set; }
    }
}
