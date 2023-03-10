using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Models
{
    public class PostForm
    {
        [StringLength(60, ErrorMessage = "Title too long (60 character limit).")]
        public string? Title { get; set; }
        [Required]
        [StringLength(1500, MinimumLength = 3, ErrorMessage = "Comment need to be bettwen 3 and 1500 characters long")]
        public string Content { get; set; }
        public IBrowserFile Image { get; set; }
    }
}
