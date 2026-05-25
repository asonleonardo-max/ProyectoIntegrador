using ProyectoIntegrador.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Validator
{
    internal class UsuarioValidator
    {
        public static string Validar(Usuario usuario, List<Usuario> listaExistente)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre))
                return "El nombre es obligatorio";

            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                return "El usuario es obligatorio";

            if (string.IsNullOrWhiteSpace(usuario.Password))
                return "La contraseña es obligatoria";

            if (string.IsNullOrWhiteSpace(usuario.Rol))
                return "El rol es obligatorio";

            if (usuario.Password.Length < 8)
                return "La contraseña debe tener mínimo 8 caracteres";

            if (!usuario.Password.Any(char.IsUpper))
                return "Debe tener al menos una mayúscula";

            if (!usuario.Password.Any(char.IsDigit))
                return "Debe tener al menos un número";

            if (!usuario.Password.Any(ch => "!@#$%^&*()_+-=.".Contains(ch)))
                return "Debe tener un carácter especial";

            Usuario? usuarioRepetido = listaExistente.Find(usuarioRegistrado =>
            usuarioRegistrado.NombreUsuario == usuario.NombreUsuario &&
            usuarioRegistrado.Id != usuario.Id
);

            if (usuarioRepetido != null)
                return "Ya existe un usuario con ese nombre de usuario";

            return string.Empty;
        }

        public static string ValidarPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Debe ingresar la nueva contraseña";

            if (password.Length < 8)
                return "La nueva contraseña debe tener mínimo 8 caracteres";

            if (!password.Any(char.IsUpper))
                return "La nueva contraseña debe contener al menos una mayúscula";

            if (!password.Any(char.IsDigit))
                return "La nueva contraseña debe contener al menos un número";

            if (!password.Any(ch => "!@#$%^&*()_+-=.".Contains(ch)))
                return "La nueva contraseña debe contener al menos un carácter especial";

            return string.Empty;
        }
    }
}
