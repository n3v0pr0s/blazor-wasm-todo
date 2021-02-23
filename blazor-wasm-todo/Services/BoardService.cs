using blazor_wasm_todo.DTO;
using blazor_wasm_todo.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace blazor_wasm_todo.Services
{
    public class BoardService : IBoardService
    {
        private readonly HttpClient client;
        public BoardService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Board>> GetBoards()
        {
            return await client.GetJsonAsync<Board[]>("api/Boards");
        }

        public async Task AddBoard(Board board)
        {
            await client.PostJsonAsync("api/Boards", board);
        }

        public async Task RemoveBoard(int id)
        {
            await client.DeleteAsync($"api/Boards/{id}");
        }
    }
}
