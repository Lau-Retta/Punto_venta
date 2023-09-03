
namespace Punto_de_Venta.forms
{
    partial class Ventan_Clientes
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Tbox_email = new System.Windows.Forms.TextBox();
            this.Tbox_dni = new System.Windows.Forms.TextBox();
            this.Tbox_apellido = new System.Windows.Forms.TextBox();
            this.Tbox_nombre = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_dni = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.bnt_modificar = new System.Windows.Forms.Button();
            this.bnt_agregar = new System.Windows.Forms.Button();
            this.Grid_clientes = new System.Windows.Forms.DataGridView();
            this.Tbox_Ncliente = new System.Windows.Forms.TextBox();
            this.label_nCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(680, 391);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(102, 32);
            this.btn_cerrar.TabIndex = 27;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Tbox_email
            // 
            this.Tbox_email.Location = new System.Drawing.Point(505, 328);
            this.Tbox_email.Name = "Tbox_email";
            this.Tbox_email.Size = new System.Drawing.Size(101, 20);
            this.Tbox_email.TabIndex = 26;
            // 
            // Tbox_dni
            // 
            this.Tbox_dni.Location = new System.Drawing.Point(387, 328);
            this.Tbox_dni.Name = "Tbox_dni";
            this.Tbox_dni.Size = new System.Drawing.Size(101, 20);
            this.Tbox_dni.TabIndex = 25;
            // 
            // Tbox_apellido
            // 
            this.Tbox_apellido.Location = new System.Drawing.Point(267, 328);
            this.Tbox_apellido.Name = "Tbox_apellido";
            this.Tbox_apellido.Size = new System.Drawing.Size(101, 20);
            this.Tbox_apellido.TabIndex = 24;
            // 
            // Tbox_nombre
            // 
            this.Tbox_nombre.Location = new System.Drawing.Point(148, 328);
            this.Tbox_nombre.Name = "Tbox_nombre";
            this.Tbox_nombre.Size = new System.Drawing.Size(101, 20);
            this.Tbox_nombre.TabIndex = 23;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(502, 303);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 21;
            this.label_email.Text = "Email:";
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Location = new System.Drawing.Point(384, 303);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(29, 13);
            this.label_dni.TabIndex = 20;
            this.label_dni.Text = "DNI:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(145, 303);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_nombre.TabIndex = 18;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(264, 303);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(47, 13);
            this.label_apellido.TabIndex = 19;
            this.label_apellido.Text = "Apellido:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(250, 387);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(96, 36);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // bnt_modificar
            // 
            this.bnt_modificar.Location = new System.Drawing.Point(134, 387);
            this.bnt_modificar.Name = "bnt_modificar";
            this.bnt_modificar.Size = new System.Drawing.Size(96, 36);
            this.bnt_modificar.TabIndex = 16;
            this.bnt_modificar.Text = "Modificar";
            this.bnt_modificar.UseVisualStyleBackColor = true;
            this.bnt_modificar.Click += new System.EventHandler(this.bnt_modificar_Click);
            // 
            // bnt_agregar
            // 
            this.bnt_agregar.Location = new System.Drawing.Point(19, 387);
            this.bnt_agregar.Name = "bnt_agregar";
            this.bnt_agregar.Size = new System.Drawing.Size(96, 36);
            this.bnt_agregar.TabIndex = 15;
            this.bnt_agregar.Text = "Agregar";
            this.bnt_agregar.UseVisualStyleBackColor = true;
            this.bnt_agregar.Click += new System.EventHandler(this.bnt_agregar_Click);
            // 
            // Grid_clientes
            // 
            this.Grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_clientes.Location = new System.Drawing.Point(12, 12);
            this.Grid_clientes.Name = "Grid_clientes";
            this.Grid_clientes.Size = new System.Drawing.Size(763, 258);
            this.Grid_clientes.TabIndex = 14;
            // 
            // Tbox_Ncliente
            // 
            this.Tbox_Ncliente.Location = new System.Drawing.Point(19, 328);
            this.Tbox_Ncliente.Name = "Tbox_Ncliente";
            this.Tbox_Ncliente.Size = new System.Drawing.Size(101, 20);
            this.Tbox_Ncliente.TabIndex = 30;
            // 
            // label_nCliente
            // 
            this.label_nCliente.AutoSize = true;
            this.label_nCliente.Location = new System.Drawing.Point(16, 303);
            this.label_nCliente.Name = "label_nCliente";
            this.label_nCliente.Size = new System.Drawing.Size(92, 13);
            this.label_nCliente.TabIndex = 29;
            this.label_nCliente.Text = "Código de cliente:";
            // 
            // Ventan_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbox_Ncliente);
            this.Controls.Add(this.label_nCliente);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Tbox_email);
            this.Controls.Add(this.Tbox_dni);
            this.Controls.Add(this.Tbox_apellido);
            this.Controls.Add(this.Tbox_nombre);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.bnt_modificar);
            this.Controls.Add(this.bnt_agregar);
            this.Controls.Add(this.Grid_clientes);
            this.Name = "Ventan_Clientes";
            this.Text = "Ventan_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox Tbox_email;
        private System.Windows.Forms.TextBox Tbox_dni;
        private System.Windows.Forms.TextBox Tbox_apellido;
        private System.Windows.Forms.TextBox Tbox_nombre;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button bnt_modificar;
        private System.Windows.Forms.Button bnt_agregar;
        private System.Windows.Forms.DataGridView Grid_clientes;
        private System.Windows.Forms.TextBox Tbox_Ncliente;
        private System.Windows.Forms.Label label_nCliente;
    }
}