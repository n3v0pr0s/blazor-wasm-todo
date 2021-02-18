using System;

namespace blazor_wasm_todo.DTO
{
    public class Note
    {
        public int id { get; set; }
        public string text { get; set; }
        public DateTime create_datetime { get; set; }
        public bool is_done { get; set; }
        public int board_id { get; set; }

        public Note(string text, int board_id)
        {
            this.text = text;
            this.create_datetime = DateTime.UtcNow;
            this.is_done = false;
            this.board_id = board_id;
        }
    }
}



