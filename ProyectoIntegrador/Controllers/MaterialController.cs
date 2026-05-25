using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Controllers
{
    internal class MaterialController
    {
        MaterialRepository repository = new MaterialRepository();

        public void Guardar(Material material)
        {
            repository.Guardar(material);
        }

        public List<Material> Leer()
        {
            return repository.Leer();
        }

        public void Eliminar(string id)
        {
            repository.Eliminar(id);
        }
    }
}
