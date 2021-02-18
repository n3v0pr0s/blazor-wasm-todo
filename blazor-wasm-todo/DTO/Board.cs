namespace blazor_wasm_todo.DTO
{
    public class Board
    {
        public int id { get; set; }
        public string name { get; set; }

        public Board(string name)
        {
            this.name = name;
        }
    }
}
