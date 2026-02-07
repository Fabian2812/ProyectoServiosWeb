using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int ClienteId { get; set; }

    public string Identificacion { get; set; }
    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
}
