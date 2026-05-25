namespace ProyectoIntegrador.Views
{
    partial class FormMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterial));
            txtNombre = new TextBox();
            txtCosto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvMateriales = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            btnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnEliminar = new PictureBox();
            btnGuardar = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(141, 356);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(419, 30);
            txtNombre.TabIndex = 0;
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCosto.Location = new Point(141, 461);
            txtCosto.Margin = new Padding(4, 3, 4, 3);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(419, 30);
            txtCosto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 327);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 26);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 432);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 26);
            label2.TabIndex = 3;
            label2.Text = "Costo:";
            // 
            // dgvMateriales
            // 
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriales.Columns.AddRange(new DataGridViewColumn[] { colNumero, Id, colNombre, colCosto });
            dgvMateriales.Location = new Point(644, 186);
            dgvMateriales.Margin = new Padding(4, 3, 4, 3);
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.RowHeadersVisible = false;
            dgvMateriales.RowHeadersWidth = 51;
            dgvMateriales.Size = new Size(684, 411);
            dgvMateriales.TabIndex = 6;
            dgvMateriales.CellClick += dgvMateriales_CellClick;
            // 
            // colNumero
            // 
            colNumero.FillWeight = 30F;
            colNumero.HeaderText = "N°";
            colNumero.MinimumWidth = 6;
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo por m³";
            colCosto.MinimumWidth = 6;
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1258, 718);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 53);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 24;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(142, 429);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(309, 630);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 72);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 27;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(142, 630);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 72);
            btnGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            btnGuardar.TabIndex = 28;
            btnGuardar.TabStop = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(522, 57);
            label3.Name = "label3";
            label3.Size = new Size(356, 44);
            label3.TabIndex = 29;
            label3.Text = "Registro Materiales";
            // 
            // FormMaterial
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1400, 800);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            Controls.Add(dgvMateriales);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCosto);
            Controls.Add(txtNombre);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMaterial";
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCosto;
        private Label label1;
        private Label label2;
        private DataGridView dgvMateriales;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnEliminar;
        private PictureBox btnGuardar;
        private Label label3;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCosto;
    }
}