using System.ComponentModel.DataAnnotations;

namespace Project1.DTOs
{
    public class CreateTaskDTO
    {
        [Required(ErrorMessage = "El título de la tarea es obligatorio.")]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
