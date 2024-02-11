//using System.ComponentModel.DataAnnotations;
using FluentValidation;
using TasksManager.Domain.Enums;

namespace TasksManager.Domain.Entities
{
    public class TaskManagement
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Título requerido")]
        //[MaxLength(100)]
        public string? Title { get; set; }
        //[Required(ErrorMessage = "Descripción requerida")]
        //[MaxLength(200)]
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        //[EnumDataType(typeof(State), ErrorMessage = "Seleccione un estado")]
        public State State { get; set; }
    }
    public class TaskManagenentValidator : AbstractValidator<TaskManagement>
    {
        public TaskManagenentValidator() 
        {
            RuleFor(tm => tm.Title)
              .NotNull().WithMessage("Título requerido")
              .NotEmpty().WithMessage("Título requerido")
              .MinimumLength(10).WithMessage("Título mínimo 10 cars")
              .MaximumLength(100).WithMessage("Título máximo 100 cars");
            RuleFor(tm => tm.Description)
                .NotNull().WithMessage("Descripción requerida")
                .NotEmpty().WithMessage("Descripción requerida")
                .MinimumLength(10).WithMessage("Título mínimo 10 cars")
                .MaximumLength(200).WithMessage("Título máximo 200 cars");
            RuleFor(tm => tm.CreatedAt).NotEmpty().WithMessage("Fecha necesitada");
            RuleFor(tm => tm.State)
                .NotEmpty().WithMessage("Estado requerido");
            RuleFor(tm => tm.State)
                .IsInEnum().WithMessage("Estado requerido");
        }
    }
}
