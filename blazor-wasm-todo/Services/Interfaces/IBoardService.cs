using blazor_wasm_todo.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazor_wasm_todo.Services.Interfaces
{
    public interface IBoardService
    {
        Task<IEnumerable<Board>> GetBoards();
        Task AddBoard(Board board);
    }
}
