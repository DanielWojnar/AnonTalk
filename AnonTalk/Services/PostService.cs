using AnonTalk.DTO;
using AnonTalk.Models;
using AutoMapper;

namespace AnonTalk.Services
{
    public class PostService : IPostService
    {
        public readonly IHttpClientService _client;
        public readonly IMapper _mapper;
        public PostService(IHttpClientService client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        public async Task<List<PostLimited>> GetPostsByBoardId(string boardId)
        {
            var uri = "Post/GetPostsByBoardId/" + boardId;
            var postLimitedDtos = await _client.Get<List<PostLimitedReceiveDTO>>(uri);
            var postsLimited = _mapper.Map<List<PostLimited>>(postLimitedDtos);
            return postsLimited;
        }

        public async Task<Post> GetPostById(Guid postId)
        {
            var uri = "Post/GetPostById/" + postId;
            var postDto = await _client.Get<PostReceiveDTO>(uri);
            var post = _mapper.Map<Post>(postDto);
            return post;
        }

        public async Task<bool> AddPost(PostForm postForm, string boardId)
        {
            var uri = "Post/AddPost";
            var hasImage = postForm.Image != null;
            string imageBase64 = null;
            if (hasImage)
            {
                var buffer = new byte[postForm.Image.Size];
                await postForm.Image.OpenReadStream().ReadAsync(buffer);
                imageBase64 = Convert.ToBase64String(buffer);
            }
            var newPost = new PostReturnDTO()
            {
                Title = postForm.Title,
                Content = postForm.Content,
                Image = hasImage,
                ImageBase64 = imageBase64,
                BoardId = boardId,
            };
            var result = await _client.Post(newPost, uri);
            return result;
        }
    }
}
