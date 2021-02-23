using blazor_wasm_todo.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazor_wasm_todo.Services.Interfaces
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetNotesByBoardId(int id);
        Task AddNote(Note note);
        Task StatusChange(Note note);
        Task RemoveNote(int id);
        Task RemoveAllNotesByBoardId(int id);
    }
}
