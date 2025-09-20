using System.ComponentModel.DataAnnotations;

namespace RazorPages_Practice_purpose_.Data;

public class Employee
{
    public int Id { get; set; } //primary key
    
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Position is required")]
    [StringLength(100, ErrorMessage = "Position cannot exceed 100 characters")]
    public string Position { get; set; } = string.Empty;
}
