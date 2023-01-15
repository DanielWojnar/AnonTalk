using AnonTalk.Models;

namespace AnonTalk.Services
{
    public interface IBoardService
    {
        public Task<List<Board>> GetBoards();
    }
}
