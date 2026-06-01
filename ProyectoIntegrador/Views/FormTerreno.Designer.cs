namespace ProyectoIntegrador.Views
{
    partial class FormTerreno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTerreno));
            txtCoordenadaX = new TextBox();
            txtCoordenadaY = new TextBox();
            txtCoordenadaZ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbVolumen = new Label();
            label4 = new Label();
            btnGuardar = new PictureBox();
            btnEliminar = new PictureBox();
            btnCerrar = new PictureBox();
            lstCoordenadas = new ListBox();
            btnAgregar = new PictureBox();
            btnCalcular = new PictureBox();
            txtNombre = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).BeginInit();
            SuspendLayout();
            // 
            // txtCoordenadaX
            // 
            txtCoordenadaX.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCoordenadaX.Location = new Point(297, 330);
            txtCoordenadaX.Name = "txtCoordenadaX";
            txtCoordenadaX.Size = new Size(258, 34);
            txtCoordenadaX.TabIndex = 0;
            // 
            // txtCoordenadaY
            // 
            txtCoordenadaY.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCoordenadaY.Location = new Point(297, 419);
            txtCoordenadaY.Name = "txtCoordenadaY";
            txtCoordenadaY.Size = new Size(258, 34);
            txtCoordenadaY.TabIndex = 1;
            // 
            // txtCoordenadaZ
            // 
            txtCoordenadaZ.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCoordenadaZ.Location = new Point(297, 512);
            txtCoordenadaZ.Name = "txtCoordenadaZ";
            txtCoordenadaZ.Size = new Size(258, 34);
            txtCoordenadaZ.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 330);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 3;
            label1.Text = "Coordenada X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 422);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 4;
            label2.Text = "Coordenada Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 515);
            label3.Name = "label3";
            label3.Size = new Size(168, 31);
            label3.TabIndex = 5;
            label3.Text = "Coordenada Z:";
            // 
            // lbVolumen
            // 
            lbVolumen.AutoSize = true;
            lbVolumen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVolumen.Location = new Point(64, 619);
            lbVolumen.Name = "lbVolumen";
            lbVolumen.Size = new Size(202, 25);
            lbVolumen.TabIndex = 10;
            lbVolumen.Text = "Volumen calculado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(537, 68);
            label4.Name = "label4";
            label4.Size = new Size(397, 47);
            label4.TabIndex = 11;
            label4.Text = "Calculo del terreno";
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(64, 845);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 72);
            btnGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            btnGuardar.TabIndex = 29;
            btnGuardar.TabStop = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(402, 845);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 72);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 30;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1369, 864);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 53);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 31;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lstCoordenadas
            // 
            lstCoordenadas.FormattingEnabled = true;
            lstCoordenadas.Location = new Point(947, 196);
            lstCoordenadas.Name = "lstCoordenadas";
            lstCoordenadas.Size = new Size(296, 184);
            lstCoordenadas.TabIndex = 32;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(180, 845);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(72, 72);
            btnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregar.TabIndex = 33;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.Location = new Point(285, 845);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 72);
            btnCalcular.SizeMode = PictureBoxSizeMode.Zoom;
            btnCalcular.TabIndex = 34;
            btnCalcular.TabStop = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(297, 259);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 34);
            txtNombre.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 262);
            label5.Name = "label5";
            label5.Size = new Size(107, 31);
            label5.TabIndex = 37;
            label5.Text = "Nombre:";
            // 
            // FormTerreno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1500, 950);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(lstCoordenadas);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(lbVolumen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCoordenadaZ);
            Controls.Add(txtCoordenadaY);
            Controls.Add(txtCoordenadaX);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTerreno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTerreno";
            ((System.ComponentModel.ISupportInitialize)btnGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCoordenadaX;
        private TextBox txtCoordenadaY;
        private TextBox txtCoordenadaZ;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbVolumen;
        private Label label4;
        private PictureBox btnGuardar;
        private PictureBox btnEliminar;
        private PictureBox btnCerrar;
        private ListBox lstCoordenadas;
        private PictureBox btnAgregar;
        private PictureBox btnCalcular;
        private TextBox txtNombre;
        private Label label5;

    }
}