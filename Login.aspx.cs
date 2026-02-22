using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;




namespace ProyectoServiosWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string hash = HashPassword(password);

            using (var db = new AppDbContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u =>
                    u.Email == email &&
                    u.PasswordHash == hash &&
                    u.Estado == true
                );

                if (usuario != null)
                {
                    Session["UsuarioId"] = usuario.UsuarioId;
                    Session["Nombre"] = usuario.Nombre;
                    Session["Rol"] = usuario.Rol;

                    lblMensaje.Text = "Sesión iniciada para: " + usuario.Nombre;
                }
                else
                {
                    lblMensaje.Text = "Credenciales incorrectas";
                }
            }
        }
        private string HashPassword(string password)
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