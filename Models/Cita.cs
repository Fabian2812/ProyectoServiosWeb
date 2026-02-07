using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cita
{
    [Key]
    public int CitaId { get; set; }

    public DateTime Fecha { get; set; }
    public TimeSpan Hora { get; set; }
    public string Estado { get; set; }

    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    [ForeignKey("Servicio")]
    public int ServicioId { get; set; }
    public Servicio Servicio { get; set; }

    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}
