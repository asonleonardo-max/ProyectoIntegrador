namespace ProyectoIntegrador.Views
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxActivo = new CheckBox();
            label5 = new Label();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnCerrar = new PictureBox();
            btnCambiarEstado = new PictureBox();
            btnGuardar = new PictureBox();
            btnEliminar = new PictureBox();
            linkRestablecerContrasena = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCambiarEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(91, 270);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(353, 30);
            txtNombre.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(91, 353);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(353, 30);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(91, 438);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(353, 30);
            txtContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 241);
            label1.Name = "label1";
            label1.Size = new Size(96, 26);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 327);
            label2.Name = "label2";
            label2.Size = new Size(94, 26);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 408);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxActivo.Location = new Point(91, 516);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(96, 30);
            checkBoxActivo.TabIndex = 11;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(559, 49);
            label5.Name = "label5";
            label5.Size = new Size(344, 40);
            label5.TabIndex = 18;
            label5.Text = "Registro de usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Numero, Nombre, NombreUsuario, Rol, Activo });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.Location = new Point(632, 186);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 28;
            dgvUsuarios.Size = new Size(621, 441);
            dgvUsuarios.TabIndex = 19;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Numero
            // 
            Numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Numero.FillWeight = 83.42246F;
            Numero.HeaderText = "N°";
            Numero.MinimumWidth = 40;
            Numero.Name = "Numero";
            Numero.Width = 59;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.FillWeight = 107.716438F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreUsuario.FillWeight = 99.43055F;
            NombreUsuario.HeaderText = "Usuario";
            NombreUsuario.MinimumWidth = 6;
            NombreUsuario.Name = "NombreUsuario";
            // 
            // Rol
            // 
            Rol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Rol.FillWeight = 58.0011559F;
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.Width = 66;
            // 
            // Activo
            // 
            Activo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Activo.FillWeight = 41.4293976F;
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.Width = 67;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(91, 401);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1274, 715);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(83, 52);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 23;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Cursor = Cursors.Hand;
            btnCambiarEstado.Image = (Image)resources.GetObject("btnCambiarEstado.Image");
            btnCambiarEstado.Location = new Point(356, 637);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(75, 68);
            btnCambiarEstado.SizeMode = PictureBoxSizeMode.Zoom;
            btnCambiarEstado.TabIndex = 24;
            btnCambiarEstado.TabStop = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(93, 637);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 68);
            btnGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            btnGuardar.TabIndex = 25;
            btnGuardar.TabStop = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(224, 637);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 68);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 26;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // linkRestablecerContrasena
            // 
            linkRestablecerContrasena.AutoSize = true;
            linkRestablecerContrasena.Cursor = Cursors.Hand;
            linkRestablecerContrasena.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkRestablecerContrasena.Location = new Point(51, 727);
            linkRestablecerContrasena.Name = "linkRestablecerContrasena";
            linkRestablecerContrasena.Size = new Size(450, 22);
            linkRestablecerContrasena.TabIndex = 27;
            linkRestablecerContrasena.TabStop = true;
            linkRestablecerContrasena.Text = "¿Desea restablecer la contraseña de un usuario?";
            linkRestablecerContrasena.LinkClicked += linkRestablecerContrasena_LinkClicked_1;
            // 
            // FormUsuario
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1400, 800);
            Controls.Add(linkRestablecerContrasena);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvUsuarios);
            Controls.Add(label5);
            Controls.Add(checkBoxActivo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCambiarEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxActivo;
        private Button btnRestablecerPassword;
        private Label label5;
        private DataGridView dgvUsuarios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox btnCerrar;
        private PictureBox btnCambiarEstado;
        private PictureBox btnGuardar;
        private PictureBox btnEliminar;
        private LinkLabel linkRestablecerContrasena;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewCheckBoxColumn Activo;
    }
}