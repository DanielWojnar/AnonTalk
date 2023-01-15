using AnonTalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Services
{
    public interface ICommentService
    {
        public Task<bool> AddComment(CommentForm commentForm, Guid postId);
    }
}
