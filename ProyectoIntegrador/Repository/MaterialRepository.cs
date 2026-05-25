using ProyectoIntegrador.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Repository
{
    internal class MaterialRepository
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "materiales.json");

        JsonRepository<Material> repository = new JsonRepository<Material>(filePath);

        public void Guardar(Material material)
        {
            List<Material> lista = Leer();

            lista.Add(material);

            repository.Guardar(lista);
        }

        public List<Material> Leer()
        {
            return repository.Leer();
        }

        public void Eliminar(string id)
        {
            List<Material> lista = Leer();
            lista.RemoveAll(m => m.Id == id);
            repository.Guardar(lista);
        }
    }
}