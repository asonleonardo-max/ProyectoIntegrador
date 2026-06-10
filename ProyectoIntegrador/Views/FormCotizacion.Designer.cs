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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCotizacion));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            dgvDetalles = new DataGridView();
            lblSubtotal = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            btnAgregarMaterial = new PictureBox();
            btnQuitarMaterial = new PictureBox();
            colDetMaterialId = new DataGridViewTextBoxColumn();
            colDetMaterial = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetPrecio = new DataGridViewTextBoxColumn();
            colDetSubtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCotizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarMaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnQuitarMaterial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 163);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 410);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 1;
            label2.Text = "Material:";
            // 
            // cbListaMateriales
            // 
            cbListaMateriales.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaMateriales.FormattingEnabled = true;
            cbListaMateriales.Location = new Point(244, 402);
            cbListaMateriales.Name = "cbListaMateriales";
            cbListaMateriales.Size = new Size(308, 39);
            cbListaMateriales.TabIndex = 4;
            // 
            // cbListaClientes
            // 
            cbListaClientes.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaClientes.FormattingEnabled = true;
            cbListaClientes.Location = new Point(244, 160);
            cbListaClientes.Name = "cbListaClientes";
            cbListaClientes.Size = new Size(308, 39);
            cbListaClientes.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 254);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 11;
            label5.Text = "Fecha:";
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateFecha.Location = new Point(244, 248);
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
            checkBoxEstado.Location = new Point(86, 566);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(106, 35);
            checkBoxEstado.TabIndex = 14;
            checkBoxEstado.Text = "Estado";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // dgvCotizacion
            // 
            dgvCotizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCotizacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCotizacion.Columns.AddRange(new DataGridViewColumn[] { colId, colClienteId, colCliente, colSubtotal, colIVA, colTotal, colFecha, colEstado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCotizacion.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCotizacion.Location = new Point(648, 160);
            dgvCotizacion.Name = "dgvCotizacion";
            dgvCotizacion.RowHeadersVisible = false;
            dgvCotizacion.RowHeadersWidth = 51;
            dgvCotizacion.Size = new Size(820, 370);
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
            // 
            // colClienteId
            // 
            colClienteId.DataPropertyName = "ClienteId";
            colClienteId.HeaderText = "ClienteId";
            colClienteId.MinimumWidth = 6;
            colClienteId.Name = "colClienteId";
            colClienteId.Visible = false;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "ClienteNombre";
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            // 
            // colSubtotal
            // 
            colSubtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            colSubtotal.DefaultCellStyle = dataGridViewCellStyle2;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            // 
            // colIVA
            // 
            colIVA.DataPropertyName = "IVA";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            colIVA.DefaultCellStyle = dataGridViewCellStyle3;
            colIVA.HeaderText = "IVA (19%)";
            colIVA.MinimumWidth = 6;
            colIVA.Name = "colIVA";
            // 
            // colTotal
            // 
            colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            colFecha.DefaultCellStyle = dataGridViewCellStyle5;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Activa";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 490);
            label3.Name = "label3";
            label3.Size = new Size(151, 31);
            label3.TabIndex = 16;
            label3.Text = "Terreno (m³):";
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCantidad.Location = new Point(244, 488);
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
            btnGuardar.Location = new Point(26, 851);
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
            btnEliminar.Location = new Point(135, 851);
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
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 334);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 30;
            label4.Text = "Terreno:";
            // 
            // cbListaTerrenos
            // 
            cbListaTerrenos.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaTerrenos.FormattingEnabled = true;
            cbListaTerrenos.Location = new Point(244, 331);
            cbListaTerrenos.Name = "cbListaTerrenos";
            cbListaTerrenos.Size = new Size(308, 39);
            cbListaTerrenos.TabIndex = 31;
            cbListaTerrenos.SelectedIndexChanged += CbListaTerrenos_SelectedIndexChanged;
            // 
            // dgvDetalles
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colDetMaterialId, colDetMaterial, colDetCantidad, colDetPrecio, colDetSubtotal });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvDetalles.DefaultCellStyle = dataGridViewCellStyle10;
            dgvDetalles.Location = new Point(648, 579);
            dgvDetalles.Name = "dgvDetalles";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(578, 198);
            dgvDetalles.TabIndex = 32;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold);
            lblSubtotal.Location = new Point(91, 647);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(102, 30);
            lblSubtotal.TabIndex = 33;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold);
            lblIVA.Location = new Point(91, 696);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(52, 30);
            lblIVA.TabIndex = 34;
            lblIVA.Text = "IVA:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold);
            lblTotal.Location = new Point(91, 747);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 30);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "Total:";
            // 
            // btnAgregarMaterial
            // 
            btnAgregarMaterial.Cursor = Cursors.Hand;
            btnAgregarMaterial.Image = (Image)resources.GetObject("btnAgregarMaterial.Image");
            btnAgregarMaterial.Location = new Point(1280, 637);
            btnAgregarMaterial.Name = "btnAgregarMaterial";
            btnAgregarMaterial.Size = new Size(62, 51);
            btnAgregarMaterial.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregarMaterial.TabIndex = 36;
            btnAgregarMaterial.TabStop = false;
            btnAgregarMaterial.Click += btnAgregarMaterial_Click;
            // 
            // btnQuitarMaterial
            // 
            btnQuitarMaterial.Cursor = Cursors.Hand;
            btnQuitarMaterial.Image = (Image)resources.GetObject("btnQuitarMaterial.Image");
            btnQuitarMaterial.Location = new Point(1280, 725);
            btnQuitarMaterial.Name = "btnQuitarMaterial";
            btnQuitarMaterial.Size = new Size(62, 52);
            btnQuitarMaterial.SizeMode = PictureBoxSizeMode.Zoom;
            btnQuitarMaterial.TabIndex = 37;
            btnQuitarMaterial.TabStop = false;
            btnQuitarMaterial.Click += btnQuitarMaterial_Click;
            // 
            // colDetMaterialId
            // 
            colDetMaterialId.DataPropertyName = "MaterialId";
            colDetMaterialId.HeaderText = "MaterialId";
            colDetMaterialId.MinimumWidth = 6;
            colDetMaterialId.Name = "colDetMaterialId";
            colDetMaterialId.Visible = false;
            colDetMaterialId.Width = 125;
            // 
            // colDetMaterial
            // 
            colDetMaterial.DataPropertyName = "NombreMaterial";
            colDetMaterial.FillWeight = 86.95653F;
            colDetMaterial.HeaderText = "Material";
            colDetMaterial.MinimumWidth = 6;
            colDetMaterial.Name = "colDetMaterial";
            colDetMaterial.Width = 125;
            // 
            // colDetCantidad
            // 
            colDetCantidad.DataPropertyName = "Cantidad";
            colDetCantidad.FillWeight = 97.0332F;
            colDetCantidad.HeaderText = "Terreno (m³)";
            colDetCantidad.MinimumWidth = 6;
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.Width = 139;
            // 
            // colDetPrecio
            // 
            colDetPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            colDetPrecio.DefaultCellStyle = dataGridViewCellStyle8;
            colDetPrecio.FillWeight = 104.919281F;
            colDetPrecio.HeaderText = "Precio";
            colDetPrecio.MinimumWidth = 6;
            colDetPrecio.Name = "colDetPrecio";
            colDetPrecio.Width = 151;
            // 
            // colDetSubtotal
            // 
            colDetSubtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle9.Format = "C0";
            dataGridViewCellStyle9.NullValue = null;
            colDetSubtotal.DefaultCellStyle = dataGridViewCellStyle9;
            colDetSubtotal.FillWeight = 111.091019F;
            colDetSubtotal.HeaderText = "Subtotal";
            colDetSubtotal.MinimumWidth = 6;
            colDetSubtotal.Name = "colDetSubtotal";
            colDetSubtotal.Width = 160;
            // 
            // FormCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 950);
            Controls.Add(btnQuitarMaterial);
            Controls.Add(btnAgregarMaterial);
            Controls.Add(lblTotal);
            Controls.Add(lblIVA);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvDetalles);
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
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarMaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnQuitarMaterial).EndInit();
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
        private Label label4;
        private ComboBox cbListaTerrenos;
        private DataGridView dgvDetalles;
        private Label lblSubtotal;
        private Label lblIVA;
        private Label lblTotal;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colClienteId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colIVA;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewCheckBoxColumn colEstado;
        private PictureBox btnAgregarMaterial;
        private PictureBox btnQuitarMaterial;
        private DataGridViewTextBoxColumn colDetMaterialId;
        private DataGridViewTextBoxColumn colDetMaterial;
        private DataGridViewTextBoxColumn colDetCantidad;
        private DataGridViewTextBoxColumn colDetPrecio;
        private DataGridViewTextBoxColumn colDetSubtotal;
    }
}