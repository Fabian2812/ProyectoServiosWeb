namespace ProyectoServiosWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            if (!context.Usuarios.Any(u => u.Email == "admin@admin.com"))
            {
                context.Usuarios.Add(new Usuario
                {
                    Nombre = "Administrador",
                    Email = "admin@admin.com",
                    PasswordHash = HashPassword("Admin123"),
                    Rol = "ADMIN",
                    Estado = true
                });

                context.SaveChanges();
            }
        }
        private static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

    }
}
