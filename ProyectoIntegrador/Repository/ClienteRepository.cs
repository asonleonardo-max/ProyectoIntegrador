using ProyectoIntegrador.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Repository
{
    internal class ClienteRepository
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.json");

        JsonRepository<Cliente> repository = new JsonRepository<Cliente>(filePath);

        public List<Cliente> Leer()
        {
            return repository.Leer();
        }

        public void Guardar(List<Cliente> lista)
        {
            repository.Guardar(lista);
        }
    }
}