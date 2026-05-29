using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;
using ProyectoIntegrador.Validator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormMaterial : Form
    {
        MaterialController controller = new MaterialController();

        string idSeleccionado = "";

        public FormMaterial()
        {
            InitializeComponent();
            CargarMateriales();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCosto.Text.Trim(), out double costo))
            {
                MessageBox.Show("El costo debe ser un número válido");
                return;
            }

            Material material = new Material
            {
                Id = idSeleccionado == "" ? Guid.NewGuid().ToString() : idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                CostoPorMetroCubico = costo
            };

            string error = MaterialValidator.Validar(material);
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            if (idSeleccionado == "")
            {
                controller.Guardar(material);
                MessageBox.Show("Material guardado");
            }
            else
            {
                controller.Actualizar(material); // ✅ Actualiza en lugar de duplicar
                MessageBox.Show("Material actualizado");
            }

            Limpiar();
            CargarMateriales();
        }


        // Eliminar 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == "")
            {
                MessageBox.Show("Seleccione un material de la lista");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este material?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controller.Eliminar(idSeleccionado);
                MessageBox.Show("Material eliminado");
                Limpiar();
                CargarMateriales();
            }
        }
        

        private void Limpiar()
        {
            idSeleccionado = "";
            txtNombre.Clear();
            txtCosto.Clear();
        }

        private void CargarMateriales()
        {
            dgvMateriales.Rows.Clear();

            List<Material> lista = controller.Leer();

            int contador = 1;

            foreach (Material material in lista)
            {
                int fila = dgvMateriales.Rows.Add();

                dgvMateriales.Rows[fila].Cells["colNumero"].Value = contador;
                dgvMateriales.Rows[fila].Cells["Id"].Value = material.Id;
                dgvMateriales.Rows[fila].Cells["colTipoMaterial"].Value = material.Nombre;
                dgvMateriales.Rows[fila].Cells["colCosto"].Value = material.CostoPorMetroCubico;

                contador++;
            }
        }

        private void dgvMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMateriales.CurrentRow != null)
            {
                idSeleccionado =
                    dgvMateriales.CurrentRow.Cells["Id"].Value.ToString();

                txtNombre.Text =
                    dgvMateriales.CurrentRow.Cells["colTipoMaterial"].Value.ToString();

                txtCosto.Text =
                    dgvMateriales.CurrentRow.Cells["colCosto"].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}