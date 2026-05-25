using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;
using ProyectoIntegrador.Validator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormUsuario : Form
    {
        UsuarioController controller = new UsuarioController();
        string idSeleccionado = "";

        public FormUsuario()
        {
            InitializeComponent();
            checkBoxActivo.Checked = true;
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            List<Usuario> lista = controller.Leer();

            int numero = 1;

            foreach (Usuario usuario in lista)
            {
                if (usuario.Rol.ToLower() == "admin")
                    continue;

                int fila = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[fila].Cells["Numero"].Value = numero;
                dgvUsuarios.Rows[fila].Cells["Id"].Value = usuario.Id;
                dgvUsuarios.Rows[fila].Cells["Nombre"].Value = usuario.Nombre;
                dgvUsuarios.Rows[fila].Cells["NombreUsuario"].Value = usuario.NombreUsuario;
                dgvUsuarios.Rows[fila].Cells["Rol"].Value = usuario.Rol;
                dgvUsuarios.Rows[fila].Cells["Activo"].Value = usuario.Activo;

                numero++;
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtContraseña.Enabled = true;
            checkBoxActivo.Checked = true;
            idSeleccionado = "";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            idSeleccionado = dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
            checkBoxActivo.Checked = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells["Activo"].Value);
            txtContraseña.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                NombreUsuario = txtUsuario.Text,
                Rol = "Usuario",
                Activo = checkBoxActivo.Checked
            };

            if (idSeleccionado == "")
            {
                usuario.Id = Guid.NewGuid().ToString();
                usuario.Password = txtContraseña.Text;

                List<Usuario> listaExistente = controller.Leer();
                string error = UsuarioValidator.Validar(usuario, listaExistente);


                if (error != "")
                {
                    MessageBox.Show(error);
                    return;
                }

                controller.Guardar(usuario);
                MessageBox.Show("Usuario guardado correctamente");
            }
            else
            {
                usuario.Id = idSeleccionado;
                controller.Modificar(usuario);
                MessageBox.Show("Usuario modificado correctamente");
            }

            Limpiar();
            CargarUsuarios();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            string id = dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString();
            controller.CambiarEstado(id);
            MessageBox.Show("Estado cambiado");
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == "")
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar este usuario?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                controller.Eliminar(idSeleccionado);
                MessageBox.Show("Usuario eliminado correctamente");
                Limpiar();
                CargarUsuarios();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRestablecerContrasena_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            string id = dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString();

            DialogResult resultado = MessageBox.Show(
                "¿Desea restablecer la contraseña de este usuario?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                string temporal = controller.RestablecerPassword(id);
                MessageBox.Show("Contraseña restablecida.\n\nContraseña temporal: [" + temporal + "]");
            }
        }
    }
}