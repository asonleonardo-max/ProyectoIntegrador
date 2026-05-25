using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;
using ProyectoIntegrador.Validator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormCliente : Form
    {
        ClienteController controller = new ClienteController();
        string idSeleccionado = "";

        public FormCliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.Rows.Clear();

            List<Cliente> lista = controller.Leer();
            int numero = 1;

            foreach (Cliente cliente in lista)
            {
                int fila = dgvClientes.Rows.Add();
                dgvClientes.Rows[fila].Cells["colNumero"].Value = numero;
                dgvClientes.Rows[fila].Cells["Id"].Value = cliente.Id;
                dgvClientes.Rows[fila].Cells["colNombre"].Value = cliente.Nombre;
                dgvClientes.Rows[fila].Cells["colIdentificacion"].Value = cliente.Identificacion;
                dgvClientes.Rows[fila].Cells["colTelefono"].Value = cliente.Telefono;
                dgvClientes.Rows[fila].Cells["colCorreo"].Value = cliente.Correo;
                numero++;
            }
        }

        private void Limpiar()
        {
            idSeleccionado = "";
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow == null || dgvClientes.CurrentRow.IsNewRow)
                return;

            idSeleccionado = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvClientes.CurrentRow.Cells["colNombre"].Value.ToString();
            txtIdentificacion.Text = dgvClientes.CurrentRow.Cells["colIdentificacion"].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells["colTelefono"].Value.ToString();
            txtCorreo.Text = dgvClientes.CurrentRow.Cells["colCorreo"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Id = idSeleccionado == "" ? Guid.NewGuid().ToString() : idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Identificacion = txtIdentificacion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };

            List<Cliente> listaExistente = controller.Leer();
            string error = ClienteValidator.Validar(cliente, listaExistente);

            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            controller.Guardar(cliente);
            MessageBox.Show(idSeleccionado == "" ? "Cliente guardado" : "Cliente actualizado");

            Limpiar();
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == "")
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controller.Eliminar(idSeleccionado);
                MessageBox.Show("Cliente eliminado");
                Limpiar();
                CargarClientes();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
