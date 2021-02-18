using blazor_wasm_todo.DTO;
using blazor_wasm_todo.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace blazor_wasm_todo.Services
{
    public class NoteService : INoteService
    {
        private readonly HttpClient client;
        public NoteService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task AddNote(Note note)
        {
            await client.PostJsonAsync("api/Notes", note);
        }

        public async Task<IEnumerable<Note>> GetNotesByBoardId(int id)
        {
            return await client.GetJsonAsync<Note[]>($"api/Notes/ByBoardId/{id}");
        }

        public async Task RemoveAllNotesByBoardId(int id)
        {
            await client.DeleteAsync($"api/Notes/ByBoardId/{id}");
        }

        public async Task RemoveNote(int id)
        {
            await client.DeleteAsync($"api/Notes/{id}");
        }
    }
}
