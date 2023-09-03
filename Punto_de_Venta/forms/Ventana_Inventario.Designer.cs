
namespace Punto_de_Venta.forms
{
    partial class Ventana_Inventario
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
            this.Grid_inventario = new System.Windows.Forms.DataGridView();
            this.bnt_agregar = new System.Windows.Forms.Button();
            this.bnt_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label_producto = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.Tbox_id = new System.Windows.Forms.TextBox();
            this.Tbox_producto = new System.Windows.Forms.TextBox();
            this.Tbox_catg = new System.Windows.Forms.TextBox();
            this.Tbox_precio = new System.Windows.Forms.TextBox();
            this.Tbox_cant = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.TBox_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_inventario
            // 
            this.Grid_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_inventario.Location = new System.Drawing.Point(12, 12);
            this.Grid_inventario.Name = "Grid_inventario";
            this.Grid_inventario.Size = new System.Drawing.Size(763, 258);
            this.Grid_inventario.TabIndex = 0;
            // 
            // bnt_agregar
            // 
            this.bnt_agregar.Location = new System.Drawing.Point(12, 371);
            this.bnt_agregar.Name = "bnt_agregar";
            this.bnt_agregar.Size = new System.Drawing.Size(96, 36);
            this.bnt_agregar.TabIndex = 1;
            this.bnt_agregar.Text = "Agregar";
            this.bnt_agregar.UseVisualStyleBackColor = true;
            this.bnt_agregar.Click += new System.EventHandler(this.bnt_agregar_Click);
            // 
            // bnt_modificar
            // 
            this.bnt_modificar.Location = new System.Drawing.Point(127, 371);
            this.bnt_modificar.Name = "bnt_modificar";
            this.bnt_modificar.Size = new System.Drawing.Size(96, 36);
            this.bnt_modificar.TabIndex = 2;
            this.bnt_modificar.Text = "Modificar";
            this.bnt_modificar.UseVisualStyleBackColor = true;
            this.bnt_modificar.Click += new System.EventHandler(this.bnt_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(243, 371);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(96, 36);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(19, 287);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "id:";
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(257, 287);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(55, 13);
            this.label_categoria.TabIndex = 5;
            this.label_categoria.Text = "Categoria:";
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Location = new System.Drawing.Point(138, 287);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(53, 13);
            this.label_producto.TabIndex = 5;
            this.label_producto.Text = "Producto:";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(377, 287);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(40, 13);
            this.label_precio.TabIndex = 6;
            this.label_precio.Text = "Precio:";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(495, 287);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(52, 13);
            this.label_cantidad.TabIndex = 7;
            this.label_cantidad.Text = "Cantidad:";
            // 
            // Tbox_id
            // 
            this.Tbox_id.Location = new System.Drawing.Point(22, 312);
            this.Tbox_id.Name = "Tbox_id";
            this.Tbox_id.Size = new System.Drawing.Size(101, 20);
            this.Tbox_id.TabIndex = 8;
            // 
            // Tbox_producto
            // 
            this.Tbox_producto.Location = new System.Drawing.Point(141, 312);
            this.Tbox_producto.Name = "Tbox_producto";
            this.Tbox_producto.Size = new System.Drawing.Size(101, 20);
            this.Tbox_producto.TabIndex = 9;
            // 
            // Tbox_catg
            // 
            this.Tbox_catg.Location = new System.Drawing.Point(260, 312);
            this.Tbox_catg.Name = "Tbox_catg";
            this.Tbox_catg.Size = new System.Drawing.Size(101, 20);
            this.Tbox_catg.TabIndex = 10;
            // 
            // Tbox_precio
            // 
            this.Tbox_precio.Location = new System.Drawing.Point(380, 312);
            this.Tbox_precio.Name = "Tbox_precio";
            this.Tbox_precio.Size = new System.Drawing.Size(101, 20);
            this.Tbox_precio.TabIndex = 11;
            // 
            // Tbox_cant
            // 
            this.Tbox_cant.Location = new System.Drawing.Point(498, 312);
            this.Tbox_cant.Name = "Tbox_cant";
            this.Tbox_cant.Size = new System.Drawing.Size(101, 20);
            this.Tbox_cant.TabIndex = 12;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(673, 375);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(102, 32);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // TBox_codigo
            // 
            this.TBox_codigo.Location = new System.Drawing.Point(619, 312);
            this.TBox_codigo.Name = "TBox_codigo";
            this.TBox_codigo.Size = new System.Drawing.Size(101, 20);
            this.TBox_codigo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // Ventana_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBox_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Tbox_cant);
            this.Controls.Add(this.Tbox_precio);
            this.Controls.Add(this.Tbox_catg);
            this.Controls.Add(this.Tbox_producto);
            this.Controls.Add(this.Tbox_id);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.bnt_modificar);
            this.Controls.Add(this.bnt_agregar);
            this.Controls.Add(this.Grid_inventario);
            this.Name = "Ventana_Inventario";
            this.Text = "Ventana_Inventario";
        
            ((System.ComponentModel.ISupportInitialize)(this.Grid_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_inventario;
        private System.Windows.Forms.Button bnt_agregar;
        private System.Windows.Forms.Button bnt_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.TextBox Tbox_id;
        private System.Windows.Forms.TextBox Tbox_producto;
        private System.Windows.Forms.TextBox Tbox_catg;
        private System.Windows.Forms.TextBox Tbox_precio;
        private System.Windows.Forms.TextBox Tbox_cant;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox TBox_codigo;
        private System.Windows.Forms.Label label1;
    }
}