using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public int UsuarioId { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string Rol { get; set; }

    public bool Estado { get; set; }
}
