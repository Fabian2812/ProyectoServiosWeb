using System.ComponentModel.DataAnnotations;

public class Servicio
{
    [Key]
    public int ServicioId { get; set; }

    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int DuracionMinutos { get; set; }
    public decimal Costo { get; set; }
    public bool Estado { get; set; }
}
