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
            txtCoordenadaX = new TextBox();
            txtCoordenadaY = new TextBox();
            txtCoordenadaZ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcularVolumenTerreno = new Button();
            btnLimpiarCoordenadas = new Button();
            lstCoordenadasTerreno = new ListBox();
            btnAgregarCoordenada = new Button();
            lblResultadoVolumen = new Label();
            SuspendLayout();
            // 
            // txtCoordenadaX
            // 
            txtCoordenadaX.Location = new Point(205, 86);
            txtCoordenadaX.Name = "txtCoordenadaX";
            txtCoordenadaX.Size = new Size(125, 27);
            txtCoordenadaX.TabIndex = 0;
            // 
            // txtCoordenadaY
            // 
            txtCoordenadaY.Location = new Point(205, 163);
            txtCoordenadaY.Name = "txtCoordenadaY";
            txtCoordenadaY.Size = new Size(125, 27);
            txtCoordenadaY.TabIndex = 1;
            // 
            // txtCoordenadaZ
            // 
            txtCoordenadaZ.Location = new Point(205, 237);
            txtCoordenadaZ.Name = "txtCoordenadaZ";
            txtCoordenadaZ.Size = new Size(125, 27);
            txtCoordenadaZ.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 93);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 3;
            label1.Text = "Coordenada en X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 170);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "Coordenada en Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 244);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 5;
            label3.Text = "Coordenada en Z";
            // 
            // btnCalcularVolumenTerreno
            // 
            btnCalcularVolumenTerreno.Location = new Point(345, 362);
            btnCalcularVolumenTerreno.Name = "btnCalcularVolumenTerreno";
            btnCalcularVolumenTerreno.Size = new Size(94, 29);
            btnCalcularVolumenTerreno.TabIndex = 6;
            btnCalcularVolumenTerreno.Text = "Calcular";
            btnCalcularVolumenTerreno.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCoordenadas
            // 
            btnLimpiarCoordenadas.Location = new Point(502, 362);
            btnLimpiarCoordenadas.Name = "btnLimpiarCoordenadas";
            btnLimpiarCoordenadas.Size = new Size(94, 29);
            btnLimpiarCoordenadas.TabIndex = 7;
            btnLimpiarCoordenadas.Text = "Limpiar";
            btnLimpiarCoordenadas.UseVisualStyleBackColor = true;
            // 
            // lstCoordenadasTerreno
            // 
            lstCoordenadasTerreno.FormattingEnabled = true;
            lstCoordenadasTerreno.Location = new Point(388, 72);
            lstCoordenadasTerreno.Name = "lstCoordenadasTerreno";
            lstCoordenadasTerreno.Size = new Size(341, 244);
            lstCoordenadasTerreno.TabIndex = 8;
            // 
            // btnAgregarCoordenada
            // 
            btnAgregarCoordenada.Location = new Point(656, 362);
            btnAgregarCoordenada.Name = "btnAgregarCoordenada";
            btnAgregarCoordenada.Size = new Size(94, 29);
            btnAgregarCoordenada.TabIndex = 9;
            btnAgregarCoordenada.Text = "Agregar";
            btnAgregarCoordenada.UseVisualStyleBackColor = true;
            // 
            // lblResultadoVolumen
            // 
            lblResultadoVolumen.AutoSize = true;
            lblResultadoVolumen.Font = new Font("Rockwell", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoVolumen.Location = new Point(57, 318);
            lblResultadoVolumen.Name = "lblResultadoVolumen";
            lblResultadoVolumen.Size = new Size(172, 20);
            lblResultadoVolumen.TabIndex = 10;
            lblResultadoVolumen.Text = "Volumen calculado:";
            // 
            // FormTerreno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoVolumen);
            Controls.Add(btnAgregarCoordenada);
            Controls.Add(lstCoordenadasTerreno);
            Controls.Add(btnLimpiarCoordenadas);
            Controls.Add(btnCalcularVolumenTerreno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCoordenadaZ);
            Controls.Add(txtCoordenadaY);
            Controls.Add(txtCoordenadaX);
            Name = "FormTerreno";
            Text = "FormTerreno";
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
        private Button btnCalcularVolumenTerreno;
        private Button btnLimpiarCoordenadas;
        private ListBox lstCoordenadasTerreno;
        private Button btnAgregarCoordenada;
        private Label lblResultadoVolumen;
    }
}