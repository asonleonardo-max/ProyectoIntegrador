using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using ProyectoIntegrador.Views;
using System.Security.Cryptography;
using System.Text;

namespace ProyectoIntegrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InicializarAdmin();
            Application.Run(new FormLogin());
        }

        static void InicializarAdmin()
        {

            UsuarioRepository repository = new UsuarioRepository();

            if (repository.Leer().Count == 0)
            {
                Usuario admin = new Usuario
                {
                    Id = "1",
                    Nombre = "Administrador",
                    NombreUsuario = "admin",
                    Password = HashPassword("1234"),
                    Rol = "Admin",
                    Activo = true
                };

                repository.Guardar(new List<Usuario> { admin });

            }
        }

        static string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] bytes = Encoding.UTF8.GetBytes(password);

            byte[] hash = sha256.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}