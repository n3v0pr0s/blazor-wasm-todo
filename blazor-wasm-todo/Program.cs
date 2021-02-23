using blazor_wasm_todo.Services;
using blazor_wasm_todo.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace blazor_wasm_todo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            builder.Services.AddHttpClient<IBoardService, BoardService>(client =>
                 client.BaseAddress = new Uri("https://roadmap-todo-api.herokuapp.com/"));
                 //client.BaseAddress = new Uri("https://localhost:5001/"));             


            builder.Services.AddHttpClient<INoteService, NoteService>(client =>
                 client.BaseAddress = new Uri("https://roadmap-todo-api.herokuapp.com/"));
                 //client.BaseAddress = new Uri("https://localhost:5001/"));




            await builder.Build().RunAsync();
        }
    }
}
