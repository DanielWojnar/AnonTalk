using AnonTalk.DTO;
using AnonTalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Services
{
    public class CommentService : ICommentService
    {
        private readonly IHttpClientService _client;
        public CommentService(IHttpClientService client)
        {
            _client = client;
        }

        public async Task<bool> AddComment(CommentForm commentForm, Guid postId)
        {
            var uri = "Comment/AddComment";
            var hasImage = commentForm.Image != null;
            string imageBase64 = null;
            if (hasImage)
            {
                var buffer = new byte[commentForm.Image.Size];
                await commentForm.Image.OpenReadStream().ReadAsync(buffer);
                imageBase64 = Convert.ToBase64String(buffer);
            }
            var newComment = new CommentReturnDTO()
            {
                Content = commentForm.Content,
                Image = hasImage,
                ImageBase64 = imageBase64,
                PostId = postId,
            };
            var result = await _client.Post(newComment, uri);
            return result;
        }
    }
}
