using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormLogin : Form

    {
        UsuarioController controller = new UsuarioController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            Usuario usuarioEncontrado = controller.Login(usuario, password);

            if (usuarioEncontrado != null)
            {
                MessageBox.Show("Bienvenido " + usuarioEncontrado.Nombre);

                FormMenu menu = new FormMenu(usuarioEncontrado);

                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor contactar a un administrador para poderse registrar");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void linkOlvideContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            FormCambiarPassword formCambiarPassword = new FormCambiarPassword();
            formCambiarPassword.ShowDialog();
            this.Show();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMostrarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnMostrarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PanelLogin.Left = (this.ClientSize.Width - PanelLogin.Width) / 2;
            PanelLogin.Top = (this.ClientSize.Height - PanelLogin.Height) / 2;
                
        }
    }
    
}
