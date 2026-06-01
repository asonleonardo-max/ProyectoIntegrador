using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Repository
{
    internal class TerrenoRepository
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "terrenos.json");

        JsonRepository<Terreno> repository = new JsonRepository<Terreno>(filePath);

        public List<Terreno> Leer()
        {
            return repository.Leer();
        }

        public void Guardar(Terreno terreno)
        {
            List<Terreno> lista = Leer();
            lista.Add(terreno);
            repository.Guardar(lista);
        }

        public void Eliminar(string id)
        {
            List<Terreno> lista = Leer();
            lista.RemoveAll(t => t.Id == id);
            repository.Guardar(lista);
        }
    }
}
