
namespace Punto_de_Venta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuario_text = new System.Windows.Forms.TextBox();
            this.contrasena_text = new System.Windows.Forms.TextBox();
            this.usuario_label = new System.Windows.Forms.Label();
            this.Contrasena_label = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario_text
            // 
            this.Usuario_text.Location = new System.Drawing.Point(34, 36);
            this.Usuario_text.Name = "Usuario_text";
            this.Usuario_text.Size = new System.Drawing.Size(188, 20);
            this.Usuario_text.TabIndex = 0;
            // 
            // contrasena_text
            // 
            this.contrasena_text.Location = new System.Drawing.Point(34, 115);
            this.contrasena_text.Name = "contrasena_text";
            this.contrasena_text.Size = new System.Drawing.Size(188, 20);
            this.contrasena_text.TabIndex = 1;
            this.contrasena_text.UseSystemPasswordChar = true;
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.Location = new System.Drawing.Point(34, 17);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(46, 13);
            this.usuario_label.TabIndex = 2;
            this.usuario_label.Text = "Usuario:";
            // 
            // Contrasena_label
            // 
            this.Contrasena_label.AutoSize = true;
            this.Contrasena_label.Location = new System.Drawing.Point(34, 89);
            this.Contrasena_label.Name = "Contrasena_label";
            this.Contrasena_label.Size = new System.Drawing.Size(64, 13);
            this.Contrasena_label.TabIndex = 3;
            this.Contrasena_label.Text = "Contraseña:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(147, 165);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(34, 165);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Cerrar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 255);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.Contrasena_label);
            this.Controls.Add(this.usuario_label);
            this.Controls.Add(this.contrasena_text);
            this.Controls.Add(this.Usuario_text);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario_text;
        private System.Windows.Forms.TextBox contrasena_text;
        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label Contrasena_label;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_salir;
    }
}

