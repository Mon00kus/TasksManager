using System.ComponentModel.DataAnnotations;
using TasksManager.Domain.Enums;

namespace TasksManager.Domain.Entities
{
    public class TaskManagement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Título requerido")]
        [MaxLength(100)]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Descripción requerida")]
        [MaxLength(200)]
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        [EnumDataType(typeof(State), ErrorMessage = "Seleccione un estado")]
        public State State { get; set; }
    }
}
