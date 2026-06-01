namespace ProyectoIntegrador.Views
{
    partial class FormCotizacion
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCotizacion));
            label1 = new Label();
            label2 = new Label();
            cbListaMateriales = new ComboBox();
            cbListaClientes = new ComboBox();
            label5 = new Label();
            dateFecha = new DateTimePicker();
            label6 = new Label();
            checkBoxEstado = new CheckBox();
            dgvCotizacion = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colClienteId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colMaterialId = new DataGridViewTextBoxColumn();
            colMaterial = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colIVA = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewCheckBoxColumn();
            label3 = new Label();
            numCantidad = new NumericUpDown();
            btnGuardar = new PictureBox();
            btnEliminar = new PictureBox();
            btnCerrar = new PictureBox();
            label4 = new Label();
            cbListaTerrenos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCotizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 252);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 499);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 1;
            label2.Text = "Material:";
            // 
            // cbListaMateriales
            // 
            cbListaMateriales.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaMateriales.FormattingEnabled = true;
            cbListaMateriales.Location = new Point(253, 491);
            cbListaMateriales.Name = "cbListaMateriales";
            cbListaMateriales.Size = new Size(308, 39);
            cbListaMateriales.TabIndex = 4;
            // 
            // cbListaClientes
            // 
            cbListaClientes.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaClientes.FormattingEnabled = true;
            cbListaClientes.Location = new Point(253, 249);
            cbListaClientes.Name = "cbListaClientes";
            cbListaClientes.Size = new Size(308, 39);
            cbListaClientes.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 343);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 11;
            label5.Text = "Fecha:";
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateFecha.Location = new Point(253, 337);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(308, 38);
            dateFecha.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(559, 69);
            label6.Name = "label6";
            label6.Size = new Size(383, 40);
            label6.TabIndex = 13;
            label6.Text = "Resgrito de cotización";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEstado.Location = new Point(95, 670);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(106, 35);
            checkBoxEstado.TabIndex = 14;
            checkBoxEstado.Text = "Estado";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // dgvCotizacion
            // 
            dgvCotizacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCotizacion.Columns.AddRange(new DataGridViewColumn[] { colId, colClienteId, colCliente, colMaterialId, colMaterial, colCantidad, colPrecio, colSubtotal, colIVA, colTotal, colFecha, colEstado });
            dgvCotizacion.Location = new Point(620, 194);
            dgvCotizacion.Name = "dgvCotizacion";
            dgvCotizacion.RowHeadersVisible = false;
            dgvCotizacion.RowHeadersWidth = 51;
            dgvCotizacion.Size = new Size(820, 502);
            dgvCotizacion.TabIndex = 15;
            dgvCotizacion.CellClick += dgvCotizacion_CellClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colClienteId
            // 
            colClienteId.DataPropertyName = "ClienteId";
            colClienteId.HeaderText = "ClienteId";
            colClienteId.MinimumWidth = 6;
            colClienteId.Name = "colClienteId";
            colClienteId.Visible = false;
            colClienteId.Width = 125;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "ClienteNombre";
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.Width = 125;
            // 
            // colMaterialId
            // 
            colMaterialId.DataPropertyName = "MaterialId";
            colMaterialId.HeaderText = "MaterialId";
            colMaterialId.MinimumWidth = 6;
            colMaterialId.Name = "colMaterialId";
            colMaterialId.Visible = false;
            colMaterialId.Width = 125;
            // 
            // colMaterial
            // 
            colMaterial.DataPropertyName = "NombreMaterial";
            colMaterial.HeaderText = "Material";
            colMaterial.MinimumWidth = 6;
            colMaterial.Name = "colMaterial";
            colMaterial.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.NullValue = null;
            colCantidad.DefaultCellStyle = dataGridViewCellStyle1;
            colCantidad.HeaderText = "Cantidad (m³)";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            colPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            colPrecio.HeaderText = "Precio/m³";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // colSubtotal
            // 
            colSubtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            colSubtotal.DefaultCellStyle = dataGridViewCellStyle3;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 125;
            // 
            // colIVA
            // 
            colIVA.DataPropertyName = "IVA";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            colIVA.DefaultCellStyle = dataGridViewCellStyle4;
            colIVA.HeaderText = "IVA (19%)";
            colIVA.MinimumWidth = 6;
            colIVA.Name = "colIVA";
            colIVA.Width = 125;
            // 
            // colTotal
            // 
            colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            colTotal.DefaultCellStyle = dataGridViewCellStyle5;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.Width = 125;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle6.Format = "g";
            dataGridViewCellStyle6.NullValue = null;
            colFecha.DefaultCellStyle = dataGridViewCellStyle6;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.Width = 125;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Activa";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 579);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 16;
            label3.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCantidad.Location = new Point(253, 577);
            numCantidad.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.ReadOnly = true;
            numCantidad.Size = new Size(308, 38);
            numCantidad.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(73, 823);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 70);
            btnGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            btnGuardar.TabIndex = 18;
            btnGuardar.TabStop = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(205, 821);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 72);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 28;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1392, 860);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(76, 59);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 29;
            btnCerrar.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 423);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 30;
            label4.Text = "Terreno:";
            // 
            // cbListaTerrenos
            // 
            cbListaTerrenos.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaTerrenos.FormattingEnabled = true;
            cbListaTerrenos.Location = new Point(253, 420);
            cbListaTerrenos.Name = "cbListaTerrenos";
            cbListaTerrenos.Size = new Size(308, 39);
            cbListaTerrenos.TabIndex = 31;
            cbListaTerrenos.SelectedIndexChanged += CbListaTerrenos_SelectedIndexChanged;
            // 
            // FormCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 950);
            Controls.Add(cbListaTerrenos);
            Controls.Add(label4);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(numCantidad);
            Controls.Add(label3);
            Controls.Add(dgvCotizacion);
            Controls.Add(checkBoxEstado);
            Controls.Add(label6);
            Controls.Add(dateFecha);
            Controls.Add(label5);
            Controls.Add(cbListaClientes);
            Controls.Add(cbListaMateriales);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCotizacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCotizacion";
            ((System.ComponentModel.ISupportInitialize)dgvCotizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbListaMateriales;
        private ComboBox cbListaClientes;
        private Label label5;
        private DateTimePicker dateFecha;
        private Label label6;
        private CheckBox checkBoxEstado;
        private DataGridView dgvCotizacion;
        private Label label3;
        private NumericUpDown numCantidad;
        private PictureBox btnGuardar;
        private PictureBox btnEliminar;
        private PictureBox btnCerrar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colClienteId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colMaterialId;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colIVA;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewCheckBoxColumn colEstado;
        private Label label4;
        private ComboBox cbListaTerrenos;
    }
}