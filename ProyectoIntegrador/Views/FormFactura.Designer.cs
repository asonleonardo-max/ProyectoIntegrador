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
            label1 = new Label();
            label2 = new Label();
            cbListaCotizaciones = new ComboBox();
            btnGenerarFactura = new Button();
            btnConsultarFacturas = new Button();
            btnCambiarEstadoFactura = new Button();
            lstHistorialFacturas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 87);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Cotización";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 189);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Estado Factura";
            // 
            // cbListaCotizaciones
            // 
            cbListaCotizaciones.FormattingEnabled = true;
            cbListaCotizaciones.Location = new Point(219, 87);
            cbListaCotizaciones.Name = "cbListaCotizaciones";
            cbListaCotizaciones.Size = new Size(151, 28);
            cbListaCotizaciones.TabIndex = 2;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(437, 367);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(94, 29);
            btnGenerarFactura.TabIndex = 3;
            btnGenerarFactura.Text = "Facturar";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // btnConsultarFacturas
            // 
            btnConsultarFacturas.Location = new Point(591, 367);
            btnConsultarFacturas.Name = "btnConsultarFacturas";
            btnConsultarFacturas.Size = new Size(141, 29);
            btnConsultarFacturas.TabIndex = 4;
            btnConsultarFacturas.Text = "Consultar Factura";
            btnConsultarFacturas.UseVisualStyleBackColor = true;
            // 
            // btnCambiarEstadoFactura
            // 
            btnCambiarEstadoFactura.Location = new Point(219, 189);
            btnCambiarEstadoFactura.Name = "btnCambiarEstadoFactura";
            btnCambiarEstadoFactura.Size = new Size(85, 29);
            btnCambiarEstadoFactura.TabIndex = 5;
            btnCambiarEstadoFactura.Text = "Cambiar";
            btnCambiarEstadoFactura.UseVisualStyleBackColor = true;
            // 
            // lstHistorialFacturas
            // 
            lstHistorialFacturas.FormattingEnabled = true;
            lstHistorialFacturas.Location = new Point(437, 42);
            lstHistorialFacturas.Name = "lstHistorialFacturas";
            lstHistorialFacturas.Size = new Size(295, 244);
            lstHistorialFacturas.TabIndex = 6;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstHistorialFacturas);
            Controls.Add(btnCambiarEstadoFactura);
            Controls.Add(btnConsultarFacturas);
            Controls.Add(btnGenerarFactura);
            Controls.Add(cbListaCotizaciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFactura";
            Text = "FormFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbListaCotizaciones;
        private Button btnGenerarFactura;
        private Button btnConsultarFacturas;
        private Button btnCambiarEstadoFactura;
        private ListBox lstHistorialFacturas;
    }
}