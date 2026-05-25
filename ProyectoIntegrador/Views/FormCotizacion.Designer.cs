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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbListaMateriales = new ComboBox();
            cbListaClientes = new ComboBox();
            txtVolumenCalculado = new TextBox();
            txtCostoTotal = new TextBox();
            btnCalcularCostoCotizacion = new Button();
            btnGenerarCotizacion = new Button();
            btnConsultarCotizaciones = new Button();
            lstHistorialCotizaciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 66);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 135);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el Material";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 208);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Volumen Calculado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 270);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Costo Total";
            // 
            // cbListaMateriales
            // 
            cbListaMateriales.FormattingEnabled = true;
            cbListaMateriales.Location = new Point(255, 135);
            cbListaMateriales.Name = "cbListaMateriales";
            cbListaMateriales.Size = new Size(167, 28);
            cbListaMateriales.TabIndex = 4;
            // 
            // cbListaClientes
            // 
            cbListaClientes.FormattingEnabled = true;
            cbListaClientes.Location = new Point(255, 66);
            cbListaClientes.Name = "cbListaClientes";
            cbListaClientes.Size = new Size(167, 28);
            cbListaClientes.TabIndex = 5;
            // 
            // txtVolumenCalculado
            // 
            txtVolumenCalculado.Location = new Point(255, 197);
            txtVolumenCalculado.Name = "txtVolumenCalculado";
            txtVolumenCalculado.Size = new Size(167, 27);
            txtVolumenCalculado.TabIndex = 6;
            // 
            // txtCostoTotal
            // 
            txtCostoTotal.Location = new Point(255, 263);
            txtCostoTotal.Name = "txtCostoTotal";
            txtCostoTotal.Size = new Size(167, 27);
            txtCostoTotal.TabIndex = 7;
            // 
            // btnCalcularCostoCotizacion
            // 
            btnCalcularCostoCotizacion.Location = new Point(269, 369);
            btnCalcularCostoCotizacion.Name = "btnCalcularCostoCotizacion";
            btnCalcularCostoCotizacion.Size = new Size(120, 29);
            btnCalcularCostoCotizacion.TabIndex = 8;
            btnCalcularCostoCotizacion.Text = "Calcular Costo";
            btnCalcularCostoCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnGenerarCotizacion
            // 
            btnGenerarCotizacion.Location = new Point(424, 369);
            btnGenerarCotizacion.Name = "btnGenerarCotizacion";
            btnGenerarCotizacion.Size = new Size(144, 29);
            btnGenerarCotizacion.TabIndex = 9;
            btnGenerarCotizacion.Text = "Generar Cotización";
            btnGenerarCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCotizaciones
            // 
            btnConsultarCotizaciones.Location = new Point(610, 369);
            btnConsultarCotizaciones.Name = "btnConsultarCotizaciones";
            btnConsultarCotizaciones.Size = new Size(154, 29);
            btnConsultarCotizaciones.TabIndex = 10;
            btnConsultarCotizaciones.Text = "Consultar Cotización";
            btnConsultarCotizaciones.UseVisualStyleBackColor = true;
            // 
            // lstHistorialCotizaciones
            // 
            lstHistorialCotizaciones.FormattingEnabled = true;
            lstHistorialCotizaciones.Location = new Point(464, 66);
            lstHistorialCotizaciones.Name = "lstHistorialCotizaciones";
            lstHistorialCotizaciones.Size = new Size(307, 224);
            lstHistorialCotizaciones.TabIndex = 11;
            // 
            // FormCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstHistorialCotizaciones);
            Controls.Add(btnConsultarCotizaciones);
            Controls.Add(btnGenerarCotizacion);
            Controls.Add(btnCalcularCostoCotizacion);
            Controls.Add(txtCostoTotal);
            Controls.Add(txtVolumenCalculado);
            Controls.Add(cbListaClientes);
            Controls.Add(cbListaMateriales);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCotizacion";
            Text = "FormCotizacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbListaMateriales;
        private ComboBox cbListaClientes;
        private TextBox txtVolumenCalculado;
        private TextBox txtCostoTotal;
        private Button btnCalcularCostoCotizacion;
        private Button btnGenerarCotizacion;
        private Button btnConsultarCotizaciones;
        private ListBox lstHistorialCotizaciones;
    }
}