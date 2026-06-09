namespace ProyectoIntegrador.Views
{
    partial class FormFactura
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            label1 = new Label();
            cbListaCotizaciones = new ComboBox();
            label3 = new Label();
            dgvFactura = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNumero = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colMaterial = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewCheckBoxColumn();
            btnCerrar = new PictureBox();
            btnImprimir = new PictureBox();
            btnFactura = new PictureBox();
            lblCliente = new Label();
            lblMaterial = new Label();
            lblVolumen = new Label();
            lblSubtotal = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            btnCambiarEstado = new PictureBox();
            txtFiltroCliente = new TextBox();
            dtpFiltroFecha = new DateTimePicker();
            cbFiltroEstado = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnImprimir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCambiarEstado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 229);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione Cotización";
            // 
            // cbListaCotizaciones
            // 
            cbListaCotizaciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaCotizaciones.FormattingEnabled = true;
            cbListaCotizaciones.Location = new Point(335, 226);
            cbListaCotizaciones.Name = "cbListaCotizaciones";
            cbListaCotizaciones.Size = new Size(250, 33);
            cbListaCotizaciones.TabIndex = 2;
            cbListaCotizaciones.SelectedIndexChanged += CbListaCotizaciones_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(624, 71);
            label3.Name = "label3";
            label3.Size = new Size(252, 47);
            label3.TabIndex = 7;
            label3.Text = "Facturación";
            // 
            // dgvFactura
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { colId, colNumero, colCliente, colMaterial, colTotal, colFecha, colEstado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvFactura.DefaultCellStyle = dataGridViewCellStyle4;
            dgvFactura.Location = new Point(706, 428);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(754, 312);
            dgvFactura.TabIndex = 8;
            dgvFactura.CellClick += DgvFactura_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "N° Factura";
            colNumero.MinimumWidth = 6;
            colNumero.Name = "colNumero";
            colNumero.Width = 125;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.Width = 125;
            // 
            // colMaterial
            // 
            colMaterial.HeaderText = "Material";
            colMaterial.MinimumWidth = 6;
            colMaterial.Name = "colMaterial";
            colMaterial.Width = 125;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.Width = 125;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.Width = 125;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Resizable = DataGridViewTriState.True;
            colEstado.SortMode = DataGridViewColumnSortMode.Automatic;
            colEstado.Width = 125;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1361, 872);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 53);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 31;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new Point(164, 853);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(82, 72);
            btnImprimir.SizeMode = PictureBoxSizeMode.Zoom;
            btnImprimir.TabIndex = 32;
            btnImprimir.TabStop = false;
            btnImprimir.Click += BtnImprimir_Click;
            // 
            // btnFactura
            // 
            btnFactura.Cursor = Cursors.Hand;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.Location = new Point(40, 853);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(82, 72);
            btnFactura.SizeMode = PictureBoxSizeMode.Zoom;
            btnFactura.TabIndex = 33;
            btnFactura.TabStop = false;
            btnFactura.Click += BtnFactura_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(128, 292);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(103, 29);
            lblCliente.TabIndex = 34;
            lblCliente.Text = "Cliente:";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterial.Location = new Point(123, 355);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(114, 29);
            lblMaterial.TabIndex = 35;
            lblMaterial.Text = "Material:";
            // 
            // lblVolumen
            // 
            lblVolumen.AutoSize = true;
            lblVolumen.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolumen.Location = new Point(120, 416);
            lblVolumen.Name = "lblVolumen";
            lblVolumen.Size = new Size(122, 29);
            lblVolumen.TabIndex = 36;
            lblVolumen.Text = "Volumen:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(123, 477);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(116, 29);
            lblSubtotal.TabIndex = 37;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIVA.Location = new Point(148, 546);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(59, 29);
            lblIVA.TabIndex = 38;
            lblIVA.Text = "IVA:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(138, 613);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 29);
            lblTotal.TabIndex = 39;
            lblTotal.Text = "Total:";
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Cursor = Cursors.Hand;
            btnCambiarEstado.Image = (Image)resources.GetObject("btnCambiarEstado.Image");
            btnCambiarEstado.Location = new Point(295, 857);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(75, 68);
            btnCambiarEstado.SizeMode = PictureBoxSizeMode.Zoom;
            btnCambiarEstado.TabIndex = 40;
            btnCambiarEstado.TabStop = false;
            btnCambiarEstado.Click += BtnCambiarEstado_Click;
            // 
            // txtFiltroCliente
            // 
            txtFiltroCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltroCliente.Location = new Point(973, 192);
            txtFiltroCliente.Name = "txtFiltroCliente";
            txtFiltroCliente.Size = new Size(250, 30);
            txtFiltroCliente.TabIndex = 41;
            // 
            // dtpFiltroFecha
            // 
            dtpFiltroFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFiltroFecha.Location = new Point(973, 259);
            dtpFiltroFecha.Name = "dtpFiltroFecha";
            dtpFiltroFecha.Size = new Size(250, 30);
            dtpFiltroFecha.TabIndex = 42;
            // 
            // cbFiltroEstado
            // 
            cbFiltroEstado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFiltroEstado.FormattingEnabled = true;
            cbFiltroEstado.Items.AddRange(new object[] { "Todos", "Activa", "Inactiva" });
            cbFiltroEstado.Location = new Point(973, 330);
            cbFiltroEstado.Name = "cbFiltroEstado";
            cbFiltroEstado.Size = new Size(250, 33);
            cbFiltroEstado.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(973, 130);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 44;
            label2.Text = "Filtrar por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(850, 186);
            label4.Name = "label4";
            label4.Size = new Size(91, 31);
            label4.TabIndex = 45;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(850, 255);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 46;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(850, 330);
            label6.Name = "label6";
            label6.Size = new Size(90, 31);
            label6.TabIndex = 47;
            label6.Text = "Estado:";
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFiltrar.Location = new Point(1270, 192);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(94, 30);
            BtnFiltrar.TabIndex = 48;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = true;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1500, 950);
            Controls.Add(BtnFiltrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cbFiltroEstado);
            Controls.Add(dtpFiltroFecha);
            Controls.Add(txtFiltroCliente);
            Controls.Add(btnCambiarEstado);
            Controls.Add(lblTotal);
            Controls.Add(lblIVA);
            Controls.Add(lblSubtotal);
            Controls.Add(lblVolumen);
            Controls.Add(lblMaterial);
            Controls.Add(lblCliente);
            Controls.Add(btnFactura);
            Controls.Add(btnImprimir);
            Controls.Add(btnCerrar);
            Controls.Add(dgvFactura);
            Controls.Add(label3);
            Controls.Add(cbListaCotizaciones);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFactura";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnImprimir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCambiarEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbListaCotizaciones;
        private Label label3;
        private DataGridView dgvFactura;
        private PictureBox btnCerrar;
        private PictureBox btnImprimir;
        private PictureBox btnFactura;
        private Label lblCliente;
        private Label lblMaterial;
        private Label lblVolumen;
        private Label lblSubtotal;
        private Label lblIVA;
        private Label lblTotal;
        private PictureBox btnCambiarEstado;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewCheckBoxColumn colEstado;
        private TextBox txtFiltroCliente;
        private DateTimePicker dtpFiltroFecha;
        private ComboBox cbFiltroEstado;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnFiltrar;
    }
}