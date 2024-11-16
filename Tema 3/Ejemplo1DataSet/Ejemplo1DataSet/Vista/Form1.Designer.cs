namespace Ejemplo1DataSet.Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrar = new Button();
            dataGridView1 = new DataGridView();
            gb1 = new GroupBox();
            btnConectar = new Button();
            lblPuerto = new Label();
            lblIpServidor = new Label();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtBoxPuerto = new TextBox();
            txtBoxIp = new TextBox();
            txtBoxContraseña = new TextBox();
            txtBoxUsuario = new TextBox();
            gb2 = new GroupBox();
            BtnInsertar = new Button();
            txtBoxEmail = new TextBox();
            txtBoxTelefono = new TextBox();
            txtBoxApellidos = new TextBox();
            txtBoxNombre = new TextBox();
            txtBoxDni = new TextBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Enabled = false;
            btnMostrar.Location = new Point(350, 285);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(704, 104);
            dataGridView1.TabIndex = 1;
            // 
            // gb1
            // 
            gb1.Controls.Add(btnConectar);
            gb1.Controls.Add(lblPuerto);
            gb1.Controls.Add(lblIpServidor);
            gb1.Controls.Add(lblContraseña);
            gb1.Controls.Add(lblUsuario);
            gb1.Controls.Add(txtBoxPuerto);
            gb1.Controls.Add(txtBoxIp);
            gb1.Controls.Add(txtBoxContraseña);
            gb1.Controls.Add(txtBoxUsuario);
            gb1.Location = new Point(31, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(353, 259);
            gb1.TabIndex = 2;
            gb1.TabStop = false;
            gb1.Text = "conectar";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(119, 221);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 8;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(24, 181);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(52, 20);
            lblPuerto.TabIndex = 7;
            lblPuerto.Text = "Puerto";
            // 
            // lblIpServidor
            // 
            lblIpServidor.AutoSize = true;
            lblIpServidor.Location = new Point(24, 131);
            lblIpServidor.Name = "lblIpServidor";
            lblIpServidor.Size = new Size(80, 20);
            lblIpServidor.TabIndex = 6;
            lblIpServidor.Text = "IP Servidor";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(24, 77);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(24, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtBoxPuerto
            // 
            txtBoxPuerto.Location = new Point(119, 174);
            txtBoxPuerto.Name = "txtBoxPuerto";
            txtBoxPuerto.Size = new Size(125, 27);
            txtBoxPuerto.TabIndex = 3;
            txtBoxPuerto.Text = "3306";
            // 
            // txtBoxIp
            // 
            txtBoxIp.Location = new Point(119, 124);
            txtBoxIp.Name = "txtBoxIp";
            txtBoxIp.Size = new Size(125, 27);
            txtBoxIp.TabIndex = 2;
            txtBoxIp.Text = "127.0.0.1";
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Location = new Point(119, 74);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.Size = new Size(125, 27);
            txtBoxContraseña.TabIndex = 1;
            txtBoxContraseña.Text = "dam2";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(119, 26);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(125, 27);
            txtBoxUsuario.TabIndex = 0;
            txtBoxUsuario.Text = "root";
            // 
            // gb2
            // 
            gb2.Controls.Add(BtnInsertar);
            gb2.Controls.Add(txtBoxEmail);
            gb2.Controls.Add(txtBoxTelefono);
            gb2.Controls.Add(txtBoxApellidos);
            gb2.Controls.Add(txtBoxNombre);
            gb2.Controls.Add(txtBoxDni);
            gb2.Controls.Add(lblEmail);
            gb2.Controls.Add(lblTelefono);
            gb2.Controls.Add(lblApellidos);
            gb2.Controls.Add(lblNombre);
            gb2.Controls.Add(lblDni);
            gb2.Location = new Point(426, 12);
            gb2.Name = "gb2";
            gb2.Size = new Size(348, 259);
            gb2.TabIndex = 3;
            gb2.TabStop = false;
            gb2.Text = "Añadir";
            // 
            // BtnInsertar
            // 
            BtnInsertar.Enabled = false;
            BtnInsertar.Location = new Point(129, 221);
            BtnInsertar.Name = "BtnInsertar";
            BtnInsertar.Size = new Size(94, 29);
            BtnInsertar.TabIndex = 10;
            BtnInsertar.Text = "Insertar";
            BtnInsertar.UseVisualStyleBackColor = true;
            BtnInsertar.Click += BtnInsertar_Click;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(157, 161);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(125, 27);
            txtBoxEmail.TabIndex = 9;
            txtBoxEmail.Text = "zxc@zxc.es";
            // 
            // txtBoxTelefono
            // 
            txtBoxTelefono.Location = new Point(157, 128);
            txtBoxTelefono.Name = "txtBoxTelefono";
            txtBoxTelefono.Size = new Size(125, 27);
            txtBoxTelefono.TabIndex = 8;
            txtBoxTelefono.Text = "678345123";
            // 
            // txtBoxApellidos
            // 
            txtBoxApellidos.Location = new Point(157, 95);
            txtBoxApellidos.Name = "txtBoxApellidos";
            txtBoxApellidos.Size = new Size(125, 27);
            txtBoxApellidos.TabIndex = 7;
            txtBoxApellidos.Text = "Garcia gurierrez";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(157, 62);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(125, 27);
            txtBoxNombre.TabIndex = 6;
            txtBoxNombre.Text = "Pedro";
            // 
            // txtBoxDni
            // 
            txtBoxDni.Location = new Point(157, 29);
            txtBoxDni.Name = "txtBoxDni";
            txtBoxDni.Size = new Size(125, 27);
            txtBoxDni.TabIndex = 5;
            txtBoxDni.Text = "34512368C";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(49, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-MAIL";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(49, 135);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(49, 102);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(49, 36);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gb2);
            Controls.Add(gb1);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrar;
        private DataGridView dataGridView1;
        private GroupBox gb1;
        private Label lblPuerto;
        private Label lblIpServidor;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtBoxPuerto;
        private TextBox txtBoxIp;
        private TextBox txtBoxContraseña;
        private TextBox txtBoxUsuario;
        private Button btnConectar;
        private GroupBox gb2;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblApellidos;
        private Label lblNombre;
        private Label lblDni;
        private TextBox txtBoxTelefono;
        private TextBox txtBoxApellidos;
        private TextBox txtBoxNombre;
        private TextBox txtBoxDni;
        private TextBox txtBoxEmail;
        private Button BtnInsertar;
    }
}
