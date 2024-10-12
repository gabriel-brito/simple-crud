using System.ComponentModel.DataAnnotations;

namespace simple_crud.IO.User;

public class Input
{
    [Required(ErrorMessage = "Age is required")]
    [Range(18, 100, ErrorMessage = "Age must be between 18 and 120")]
    public required int Age { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    public required string Email { get; set; }
    public required string Group { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public required string Name { get; set; }
}
