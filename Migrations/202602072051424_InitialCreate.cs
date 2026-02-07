namespace ProyectoServiosWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.Time(nullable: false, precision: 6),
                        Estado = c.String(),
                        ClienteId = c.Int(nullable: false),
                        ServicioId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Servicios", t => t.ServicioId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.ServicioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(),
                        NombreCompleto = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        DuracionMinutos = c.Int(nullable: false),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false),
                        Rol = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Citas", "ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.Citas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Citas", new[] { "UsuarioId" });
            DropIndex("dbo.Citas", new[] { "ServicioId" });
            DropIndex("dbo.Citas", new[] { "ClienteId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Servicios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Citas");
        }
    }
}
