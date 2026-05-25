using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoIntegrador.Repository
{
    internal class UsuarioRepository
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.json");

        JsonRepository<Usuario> repository = new JsonRepository<Usuario>(filePath);

        public void Guardar(List<Usuario> lista)
        {
            repository.Guardar(lista);
        }

        public List<Usuario> Leer()
        {
            return repository.Leer();
        }
    }
}
