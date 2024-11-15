namespace Ejemplo3DataSet
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
            textBoxServidor = new TextBox();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            textBoxPuerto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConectar = new Button();
            SuspendLayout();
            // 
            // textBoxServidor
            // 
            textBoxServidor.Location = new Point(42, 33);
            textBoxServidor.Name = "textBoxServidor";
            textBoxServidor.Size = new Size(125, 27);
            textBoxServidor.TabIndex = 0;
            textBoxServidor.Text = "127.0.0.1";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(42, 66);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(125, 27);
            textBoxUsuario.TabIndex = 1;
            textBoxUsuario.Text = "root";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(42, 99);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(125, 27);
            textBoxContraseña.TabIndex = 2;
            textBoxContraseña.Text = "dam2";
            // 
            // textBoxPuerto
            // 
            textBoxPuerto.Location = new Point(42, 132);
            textBoxPuerto.Name = "textBoxPuerto";
            textBoxPuerto.Size = new Size(125, 27);
            textBoxPuerto.TabIndex = 3;
            textBoxPuerto.Text = "3306";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 73);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 106);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 139);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Puerto";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(332, 73);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 8;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 189);
            Controls.Add(btnConectar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPuerto);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxServidor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxServidor;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private TextBox textBoxPuerto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConectar;
    }
}
