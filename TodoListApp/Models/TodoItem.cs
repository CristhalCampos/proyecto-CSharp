using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Task { get; set; } = "";

        public bool IsCompleted { get; set; } = false;
    }
}
