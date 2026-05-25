using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Validator;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormCambiarPassword : Form
    {
        UsuarioController controller = new UsuarioController();

        public FormCambiarPassword()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string actual = txtContrasenaActual.Text.Trim();
            string nueva = txtContrasenaNueva.Text.Trim();
            string confirmar = txtComfimarContrasena.Text.Trim();

            // VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(actual) ||
                string.IsNullOrWhiteSpace(nueva) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Debe completar todos los campos solicitados");
                return;
            }

            // VALIDAR CONTRASEÑA ACTUAL
            if (string.IsNullOrWhiteSpace(actual))
            {
                MessageBox.Show("Por favor ingrese su contraseña actual");

                return;
            }

            // VALIDAR SEGURIDAD DE LA NUEVA CONTRASEÑA
            string mensaje = UsuarioValidator.ValidarPassword(nueva);

            if (mensaje != string.Empty)
            {
                MessageBox.Show(mensaje);

                return;
            }

            // VALIDAR CONFIRMACIÓN
            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor verifique la información ingresada");
                return;
            }

            // CAMBIAR PASSWORD
            bool cambiado = controller.CambiarPassword(usuario, actual, nueva);

            if (cambiado)
            {
                MessageBox.Show("Contraseña actualizada correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña actual incorrectos");
            }
        }

        private void linkRestablecerContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacte a un administrador para restablecer su contraseña");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormCambiarPassword_Load(object sender, EventArgs e)
        {
            panelContrasena.Left = (this.ClientSize.Width - panelContrasena.Width) / 2;
            panelContrasena.Top = (this.ClientSize.Height - panelContrasena.Height) / 2;
        }

        private void btnMostrarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasenaActual.UseSystemPasswordChar = false;
        }

        private void btnMostrarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasenaActual.UseSystemPasswordChar = true;
        }

        private void btnContrasenaNueva_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasenaNueva.UseSystemPasswordChar = false;
        }

        private void btnContrasenaNueva_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasenaNueva.UseSystemPasswordChar = true;
        }

        private void btnConfirmarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtComfimarContrasena.UseSystemPasswordChar = false;
        }

        private void btnConfirmarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtComfimarContrasena.UseSystemPasswordChar = true;
        }
    }
}
