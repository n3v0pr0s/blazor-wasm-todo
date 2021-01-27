using System;
using System.Collections.Generic;

namespace blazor_wasm_todo.Models
{
    public class Board
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public IEnumerable<Note> Notes { get; set; }

        public Board(string name)
        {
            this.Guid = Guid.NewGuid();
            this.Name = name;
            this.Notes = new List<Note>();
        }

        public static List<Board> GetBoards()
        {
            return new List<Board>
            {
                new Board("Pet-projects"),
                new Board("Production"),
                new Board("Technologies"),
                new Board("Books")

            };
        }
    }
}
