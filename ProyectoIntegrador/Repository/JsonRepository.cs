using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace ProyectoIntegrador.Repository
{
    internal class JsonRepository<T> where T : class
    {
        private string filePath;

        public JsonRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public List<T> Leer()
        {
            List<T> lista = new List<T>();

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string json = sr.ReadToEnd();

                        if (!string.IsNullOrWhiteSpace(json))
                        {
                            lista = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.Write("[]");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }

        public void Guardar(List<T> lista)
        {
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(lista, opciones);

                using (StreamWriter sw = new StreamWriter(filePath, append: false))
                {
                    sw.Write(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo:\n" + filePath + "\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}