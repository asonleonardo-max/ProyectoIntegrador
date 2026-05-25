using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Controllers
{
    internal class UsuarioController
    {
        UsuarioRepository repository = new UsuarioRepository();

        public void Guardar(Usuario usuario)
        {
            List<Usuario> lista = repository.Leer();

            usuario.Password = HashPassword(usuario.Password);

            lista.Add(usuario);

            repository.Guardar(lista);

            System.Windows.Forms.MessageBox.Show("Guardado ejecutado");
        }

        public List<Usuario> Leer()
        {
            return repository.Leer();
        }

        public Usuario Login(string nombreUsuario, string password)
        {
            List<Usuario> lista = repository.Leer();

            string passwordHash = HashPassword(password);

            foreach (Usuario usuario in lista)
            {
                if (usuario.NombreUsuario == nombreUsuario &&
                    usuario.Password == passwordHash)
                {
                    return usuario;
                }
            }

            return null;
        }

        public void CambiarEstado(string id)
        {
            List<Usuario> lista = repository.Leer();

            foreach (Usuario usuario in lista)
            {
                if (usuario.Id == id)
                {
                    usuario.Activo = !usuario.Activo;
                    break;
                }
            }

            repository.Guardar(lista);
        }

        private string HashPassword(string password)
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

        public bool CambiarPassword(string nombreUsuario, string passwordActual, string nuevaPassword)
        {
            List<Usuario> lista = repository.Leer();

            string actualHash = HashPassword(passwordActual);

            foreach (Usuario usuario in lista)
            {
                if (usuario.NombreUsuario == nombreUsuario &&
                    usuario.Password == actualHash)
                {
                    usuario.Password = HashPassword(nuevaPassword);
                    repository.Guardar(lista);
                    return true;
                }
            }

            return false;
        }

        private string GenerarPasswordTemporal()
        {
            string caracteres =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "!@#$%&*";

            Random random = new Random();

            string password = "";

            for (int i = 0; i < 10; i++)
            {
                int indice = random.Next(caracteres.Length);

                password += caracteres[indice];
            }

            return password;
        }

        public void Modificar(Usuario usuarioModificado)
        {
            List<Usuario> lista = repository.Leer();

            foreach (Usuario usuario in lista)
            {
                if (usuario.Id == usuarioModificado.Id)
                {
                    usuario.Nombre = usuarioModificado.Nombre;
                    usuario.NombreUsuario = usuarioModificado.NombreUsuario;
                    usuario.Rol = usuarioModificado.Rol;
                    usuario.Activo = usuarioModificado.Activo;

                    break;
                }
            }

            repository.Guardar(lista);
        }


        public void Eliminar(string id)
        {
            List<Usuario> lista = repository.Leer();

            Usuario usuarioEliminar = null;

            foreach (Usuario usuario in lista)
            {
                if (usuario.Id == id)
                {
                    usuarioEliminar = usuario;
                    break;
                }
            }

            if (usuarioEliminar != null)
            {
                lista.Remove(usuarioEliminar);

                repository.Guardar(lista);
            }
        }


        public string RestablecerPassword(string id)
        {
            List<Usuario> lista = repository.Leer();

            string temporal = GenerarPasswordTemporal();

            foreach (Usuario usuario in lista)
            {
                if (usuario.Id == id)
                {
                    usuario.Password = HashPassword(temporal);
                    break;
                }
            }

            repository.Guardar(lista);

            return temporal;
        }

    }
}
