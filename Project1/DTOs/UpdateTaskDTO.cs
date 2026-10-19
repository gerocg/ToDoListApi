using System.ComponentModel.DataAnnotations;

namespace Project1.DTOs
{
    public class UpdateTaskDTO
    {
        [Required(ErrorMessage = "El título es obligatorio.")]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
}
