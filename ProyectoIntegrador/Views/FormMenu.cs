using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormMenu : Form
    {
        private string rol;

        private Form formularioActivo = null;

        private void AbriFormulario(Form formularioHijo)
        {

            if (formularioActivo != null)
            {
                formularioActivo.Dispose();

            }

            formularioActivo = formularioHijo;

            formularioHijo.MdiParent = this;
            formularioHijo.Show();
        }

        public FormMenu(Usuario usuario)
        {
            InitializeComponent();

            label1.Text = "Bienvenido: " + usuario.Nombre;

            if (usuario.Rol == "Usuario")
            {
                btnUsuarios.Visible = false;
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbriFormulario(new FormUsuario());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbriFormulario(new FormCliente());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            AbriFormulario(new FormMaterial());
        }

        private void btnTerreno_Click(object sender, EventArgs e)
        {
            AbriFormulario(new FormTerreno());
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            AbriFormulario(new FormCotizacion());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            formFactura.Show();

        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();

            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Height.ToString());
            int y = this.Bottom - this.btnCerrarSeccion.Size.Height - Barra.Size.Height;
            btnCerrarSeccion.Location = new Point(0, y);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();

            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
