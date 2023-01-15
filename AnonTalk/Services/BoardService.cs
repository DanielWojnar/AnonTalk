using AnonTalk.DTO;
using AnonTalk.Models;
using AutoMapper;

namespace AnonTalk.Services
{
    public class BoardService : IBoardService
    {
        public readonly IHttpClientService _client;
        public readonly IMapper _mapper;
        public BoardService(IHttpClientService client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }
        
        public async Task<List<Board>> GetBoards()
        {
            var boardDtos = await _client.Get<List<BoardReceiveDTO>>("Board/GetBoards");
            if(boardDtos == null)
            {
                return null;
            }
            var boards = _mapper.Map<List<Board>>(boardDtos);
            return boards;
        }
    }
}
