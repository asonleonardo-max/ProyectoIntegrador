using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Validator
{
    internal class MaterialValidator
    {
        public static string Validar(Material material)
        {
            if (string.IsNullOrWhiteSpace(material.Nombre))
                return "El nombre del material es obligatorio";

            if (material.CostoPorMetroCubico <= 0)
                return "El costo debe ser mayor a 0";

            return string.Empty;
        }
    }
}
