using System;
using System.Collections.Generic;

namespace blazor_wasm_todo.Models
{
    public class Note
    {
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public Note(string title)
        {
            this.Title = title;
            this.DateTime = DateTime.Now;
        }

        //why binding for input not working
        public Note(string title, bool done)
        {
            this.Title = title;
            this.IsDone = done;
            this.DateTime = DateTime.Now;
        }

        public static List<Note> GetData()
        {
            return new List<Note>()
            {
                new Note("Купить хлеб", true),
                new Note("Дочитать книгу"),
                new Note("Выучить ангуляр"),
                new Note("Познать цзен")
            };
        }
    }
}



