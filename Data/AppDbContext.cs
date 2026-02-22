using System.Data.Entity;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("PostgresConnection")
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Cita> Citas { get; set; }
}
