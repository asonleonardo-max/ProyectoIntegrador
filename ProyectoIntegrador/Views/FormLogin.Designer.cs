namespace ProyectoIntegrador.Views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            btnIniciar = new Button();
            btnRegistrar = new Button();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkOlvideContrasena = new LinkLabel();
            btnMostrarContrasena = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            Barra = new Panel();
            PanelLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarContrasena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            Barra.SuspendLayout();
            PanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(103, 381);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(561, 30);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 343);
            label1.Name = "label1";
            label1.Size = new Size(130, 36);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 431);
            label2.Name = "label2";
            label2.Size = new Size(180, 36);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(103, 464);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(561, 30);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "1234";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIniciar
            // 
            btnIniciar.BackgroundImageLayout = ImageLayout.Zoom;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(103, 613);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(561, 74);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlText;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(103, 717);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(561, 74);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(297, 71);
            label5.Name = "label5";
            label5.Size = new Size(217, 70);
            label5.TabIndex = 10;
            label5.Text = "LOGIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(103, 431);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 332);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // linkOlvideContrasena
            // 
            linkOlvideContrasena.AutoSize = true;
            linkOlvideContrasena.Cursor = Cursors.Hand;
            linkOlvideContrasena.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkOlvideContrasena.Location = new Point(187, 817);
            linkOlvideContrasena.Name = "linkOlvideContrasena";
            linkOlvideContrasena.Size = new Size(403, 32);
            linkOlvideContrasena.TabIndex = 14;
            linkOlvideContrasena.TabStop = true;
            linkOlvideContrasena.Text = "¿Ha olvidado tu contraseña?";
            linkOlvideContrasena.LinkClicked += linkOlvideContrasena_LinkClicked;
            // 
            // btnMostrarContrasena
            // 
            btnMostrarContrasena.Cursor = Cursors.Hand;
            btnMostrarContrasena.Image = (Image)resources.GetObject("btnMostrarContrasena.Image");
            btnMostrarContrasena.Location = new Point(670, 464);
            btnMostrarContrasena.Name = "btnMostrarContrasena";
            btnMostrarContrasena.Size = new Size(37, 33);
            btnMostrarContrasena.SizeMode = PictureBoxSizeMode.Zoom;
            btnMostrarContrasena.TabIndex = 15;
            btnMostrarContrasena.TabStop = false;
            btnMostrarContrasena.MouseDown += btnMostrarContrasena_MouseDown;
            btnMostrarContrasena.MouseUp += btnMostrarContrasena_MouseUp;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1032, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 16;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(994, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 30);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 17;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // Barra
            // 
            Barra.BackColor = SystemColors.ControlDark;
            Barra.Controls.Add(btnMinimizar);
            Barra.Controls.Add(btnCerrar);
            Barra.Dock = DockStyle.Top;
            Barra.Location = new Point(0, 0);
            Barra.Name = "Barra";
            Barra.Size = new Size(1081, 32);
            Barra.TabIndex = 18;
            // 
            // PanelLogin
            // 
            PanelLogin.BackColor = SystemColors.MenuBar;
            PanelLogin.Controls.Add(label5);
            PanelLogin.Controls.Add(txtUsuario);
            PanelLogin.Controls.Add(btnMostrarContrasena);
            PanelLogin.Controls.Add(label1);
            PanelLogin.Controls.Add(linkOlvideContrasena);
            PanelLogin.Controls.Add(label2);
            PanelLogin.Controls.Add(pictureBox2);
            PanelLogin.Controls.Add(txtPassword);
            PanelLogin.Controls.Add(pictureBox3);
            PanelLogin.Controls.Add(btnRegistrar);
            PanelLogin.Controls.Add(btnIniciar);
            PanelLogin.Location = new Point(144, 33);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(793, 886);
            PanelLogin.TabIndex = 19;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1081, 918);
            Controls.Add(PanelLogin);
            Controls.Add(Barra);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarContrasena).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            Barra.ResumeLayout(false);
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Button btnIniciar;
        private Button btnRegistrar;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private LinkLabel linkOlvideContrasena;
        private PictureBox btnMostrarContrasena;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel Barra;
        private Panel PanelLogin;
    }
}