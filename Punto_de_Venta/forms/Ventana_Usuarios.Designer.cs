
namespace Punto_de_Venta.forms
{
    partial class Ventana_Usuarios
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.Tbox_tel = new System.Windows.Forms.TextBox();
            this.Tbox_name = new System.Windows.Forms.TextBox();
            this.Tbox_id = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Tbox_apellido = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.GrupoBox_acceso = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_contrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbox_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbox_cuentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbox_dni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.GrupoBox_acceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(195, 376);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(166, 42);
            this.btn_modificar.TabIndex = 23;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(367, 376);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 42);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(23, 376);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(166, 42);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Tbox_tel
            // 
            this.Tbox_tel.Location = new System.Drawing.Point(23, 337);
            this.Tbox_tel.Name = "Tbox_tel";
            this.Tbox_tel.Size = new System.Drawing.Size(116, 20);
            this.Tbox_tel.TabIndex = 20;
            // 
            // Tbox_name
            // 
            this.Tbox_name.Location = new System.Drawing.Point(145, 298);
            this.Tbox_name.Name = "Tbox_name";
            this.Tbox_name.Size = new System.Drawing.Size(116, 20);
            this.Tbox_name.TabIndex = 19;
            // 
            // Tbox_id
            // 
            this.Tbox_id.Location = new System.Drawing.Point(23, 298);
            this.Tbox_id.Name = "Tbox_id";
            this.Tbox_id.Size = new System.Drawing.Size(116, 20);
            this.Tbox_id.TabIndex = 18;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(23, 12);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.Size = new System.Drawing.Size(755, 256);
            this.dgv_tabla.TabIndex = 16;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(612, 376);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(166, 42);
            this.btn_cerrar.TabIndex = 24;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Tbox_apellido
            // 
            this.Tbox_apellido.Location = new System.Drawing.Point(267, 298);
            this.Tbox_apellido.Name = "Tbox_apellido";
            this.Tbox_apellido.Size = new System.Drawing.Size(116, 20);
            this.Tbox_apellido.TabIndex = 25;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(20, 282);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 13);
            this.label_id.TabIndex = 26;
            this.label_id.Text = "Id:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(142, 282);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_nombre.TabIndex = 27;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(264, 282);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(47, 13);
            this.label_apellido.TabIndex = 28;
            this.label_apellido.Text = "Apellido:";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(20, 321);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(52, 13);
            this.label_tel.TabIndex = 29;
            this.label_tel.Text = "Teléfono:";
            // 
            // GrupoBox_acceso
            // 
            this.GrupoBox_acceso.Controls.Add(this.label1);
            this.GrupoBox_acceso.Controls.Add(this.Tbox_contrasena);
            this.GrupoBox_acceso.Controls.Add(this.label2);
            this.GrupoBox_acceso.Controls.Add(this.Tbox_usuario);
            this.GrupoBox_acceso.Location = new System.Drawing.Point(511, 287);
            this.GrupoBox_acceso.Name = "GrupoBox_acceso";
            this.GrupoBox_acceso.Size = new System.Drawing.Size(266, 83);
            this.GrupoBox_acceso.TabIndex = 30;
            this.GrupoBox_acceso.TabStop = false;
            this.GrupoBox_acceso.Text = "Información de acceso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Contraseña:";
            // 
            // Tbox_contrasena
            // 
            this.Tbox_contrasena.Location = new System.Drawing.Point(131, 39);
            this.Tbox_contrasena.Name = "Tbox_contrasena";
            this.Tbox_contrasena.Size = new System.Drawing.Size(116, 20);
            this.Tbox_contrasena.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Usuario:";
            // 
            // Tbox_usuario
            // 
            this.Tbox_usuario.Location = new System.Drawing.Point(9, 39);
            this.Tbox_usuario.Name = "Tbox_usuario";
            this.Tbox_usuario.Size = new System.Drawing.Size(116, 20);
            this.Tbox_usuario.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "DNI:";
            // 
            // Tbox_cuentas
            // 
            this.Tbox_cuentas.Location = new System.Drawing.Point(145, 337);
            this.Tbox_cuentas.Name = "Tbox_cuentas";
            this.Tbox_cuentas.Size = new System.Drawing.Size(116, 20);
            this.Tbox_cuentas.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de cuenta:";
            // 
            // Tbox_dni
            // 
            this.Tbox_dni.Location = new System.Drawing.Point(389, 298);
            this.Tbox_dni.Name = "Tbox_dni";
            this.Tbox_dni.Size = new System.Drawing.Size(116, 20);
            this.Tbox_dni.TabIndex = 33;
            // 
            // Ventana_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbox_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tbox_cuentas);
            this.Controls.Add(this.GrupoBox_acceso);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.Tbox_apellido);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.Tbox_tel);
            this.Controls.Add(this.Tbox_name);
            this.Controls.Add(this.Tbox_id);
            this.Controls.Add(this.dgv_tabla);
            this.Name = "Ventana_Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.GrupoBox_acceso.ResumeLayout(false);
            this.GrupoBox_acceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox Tbox_tel;
        private System.Windows.Forms.TextBox Tbox_name;
        private System.Windows.Forms.TextBox Tbox_id;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox Tbox_apellido;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.GroupBox GrupoBox_acceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_contrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbox_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbox_cuentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbox_dni;
    }
}