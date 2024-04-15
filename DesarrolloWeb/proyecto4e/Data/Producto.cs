using System.ComponentModel.DataAnnotations;

namespace Tarea9.Data;

public class Producto
{
    [Required(ErrorMessage = "El numero es obligatorio")]
    public int? numero { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? nombre { get; set; }
    [Required(ErrorMessage = "El departamento es obligatorio")]
    public string? departamento { get; set; }
    
}