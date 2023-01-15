using AnonTalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Services
{
    public interface IPostService
    {
        public Task<List<PostLimited>> GetPostsByBoardId(string boardId);
        public Task<Post> GetPostById(Guid postId);
        public Task<bool> AddPost(PostForm postForm, string boardId);
    }
}
