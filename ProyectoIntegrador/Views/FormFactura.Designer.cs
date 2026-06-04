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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            label1 = new Label();
            cbListaCotizaciones = new ComboBox();
            label3 = new Label();
            dgvFactura = new DataGridView();
            btnGuardar = new PictureBox();
            btnEliminar = new PictureBox();
            btnCerrar = new PictureBox();
            btnImprimir = new PictureBox();
            btnFactura = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnImprimir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFactura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 268);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Cotización";
            // 
            // cbListaCotizaciones
            // 
            cbListaCotizaciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListaCotizaciones.FormattingEnabled = true;
            cbListaCotizaciones.Location = new Point(349, 265);
            cbListaCotizaciones.Name = "cbListaCotizaciones";
            cbListaCotizaciones.Size = new Size(250, 33);
            cbListaCotizaciones.TabIndex = 2;
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
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(707, 244);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(754, 477);
            dgvFactura.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(44, 853);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 72);
            btnGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            btnGuardar.TabIndex = 29;
            btnGuardar.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(178, 853);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 72);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 30;
            btnEliminar.TabStop = false;
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
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new Point(442, 853);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(82, 72);
            btnImprimir.SizeMode = PictureBoxSizeMode.Zoom;
            btnImprimir.TabIndex = 32;
            btnImprimir.TabStop = false;
            // 
            // btnFactura
            // 
            btnFactura.Cursor = Cursors.Hand;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.Location = new Point(311, 853);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(82, 72);
            btnFactura.SizeMode = PictureBoxSizeMode.Zoom;
            btnFactura.TabIndex = 33;
            btnFactura.TabStop = false;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1500, 950);
            Controls.Add(btnFactura);
            Controls.Add(btnImprimir);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvFactura);
            Controls.Add(label3);
            Controls.Add(cbListaCotizaciones);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFactura";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnImprimir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbListaCotizaciones;
        private Label label3;
        private DataGridView dgvFactura;
        private PictureBox btnGuardar;
        private PictureBox btnEliminar;
        private PictureBox btnCerrar;
        private PictureBox btnImprimir;
        private PictureBox btnFactura;
    }
}