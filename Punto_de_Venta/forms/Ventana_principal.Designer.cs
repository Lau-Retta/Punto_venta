
namespace Punto_de_Venta
{
    partial class Ventana_principal
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosYDescuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripTbox_impuesto = new System.Windows.Forms.ToolStripTextBox();
            this.descuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripTbox_descuento = new System.Windows.Forms.ToolStripTextBox();
            this.menu_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grid_principal = new System.Windows.Forms.DataGridView();
            this.factura = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.Tbox_nameCliente = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.Label();
            this.N_subtotal = new System.Windows.Forms.Label();
            this.N_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbox_factura = new System.Windows.Forms.TextBox();
            this.Tbox_CProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_cant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.TBox_impu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbox_descu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbox_Ccliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.impresion = new System.Drawing.Printing.PrintDocument();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIstorialaDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(697, 411);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 35);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.menu_usuarios,
            this.inventarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestosYDescuentoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // impuestosYDescuentoToolStripMenuItem
            // 
            this.impuestosYDescuentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestoToolStripMenuItem,
            this.descuentoToolStripMenuItem});
            this.impuestosYDescuentoToolStripMenuItem.Name = "impuestosYDescuentoToolStripMenuItem";
            this.impuestosYDescuentoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.impuestosYDescuentoToolStripMenuItem.Text = "Impuestos y descuento";
            // 
            // impuestoToolStripMenuItem
            // 
            this.impuestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripTbox_impuesto});
            this.impuestoToolStripMenuItem.Name = "impuestoToolStripMenuItem";
            this.impuestoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.impuestoToolStripMenuItem.Text = "Impuesto";
            // 
            // StripTbox_impuesto
            // 
            this.StripTbox_impuesto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StripTbox_impuesto.Name = "StripTbox_impuesto";
            this.StripTbox_impuesto.Size = new System.Drawing.Size(100, 23);
            this.StripTbox_impuesto.Text = "0,21";
            this.StripTbox_impuesto.TextChanged += new System.EventHandler(this.impuestoYDescuentoChange);
            // 
            // descuentoToolStripMenuItem
            // 
            this.descuentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripTbox_descuento});
            this.descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            this.descuentoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.descuentoToolStripMenuItem.Text = "Descuento";
            // 
            // StripTbox_descuento
            // 
            this.StripTbox_descuento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StripTbox_descuento.Name = "StripTbox_descuento";
            this.StripTbox_descuento.Size = new System.Drawing.Size(100, 23);
            this.StripTbox_descuento.Text = "0";
            this.StripTbox_descuento.TextChanged += new System.EventHandler(this.impuestoYDescuentoChange);
            // 
            // menu_usuarios
            // 
            this.menu_usuarios.Name = "menu_usuarios";
            this.menu_usuarios.Size = new System.Drawing.Size(64, 20);
            this.menu_usuarios.Text = "Usuarios";
            this.menu_usuarios.Click += new System.EventHandler(this.menu_usuarios_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Grid_principal
            // 
            this.Grid_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_principal.Location = new System.Drawing.Point(124, 70);
            this.Grid_principal.Name = "Grid_principal";
            this.Grid_principal.Size = new System.Drawing.Size(686, 214);
            this.Grid_principal.TabIndex = 2;
            // 
            // factura
            // 
            this.factura.AutoSize = true;
            this.factura.Location = new System.Drawing.Point(121, 27);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(46, 13);
            this.factura.TabIndex = 3;
            this.factura.Text = "Factura:";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(572, 24);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(42, 13);
            this.Cliente.TabIndex = 4;
            this.Cliente.Text = "Cliente:";
            // 
            // Tbox_nameCliente
            // 
            this.Tbox_nameCliente.Location = new System.Drawing.Point(632, 24);
            this.Tbox_nameCliente.Name = "Tbox_nameCliente";
            this.Tbox_nameCliente.Size = new System.Drawing.Size(185, 20);
            this.Tbox_nameCliente.TabIndex = 5;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.Location = new System.Drawing.Point(121, 291);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(75, 16);
            this.Subtotal.TabIndex = 7;
            this.Subtotal.Text = "Sub Total";
            // 
            // N_subtotal
            // 
            this.N_subtotal.AutoSize = true;
            this.N_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_subtotal.Location = new System.Drawing.Point(121, 307);
            this.N_subtotal.Name = "N_subtotal";
            this.N_subtotal.Size = new System.Drawing.Size(71, 31);
            this.N_subtotal.TabIndex = 8;
            this.N_subtotal.Text = "0.00";
            // 
            // N_Total
            // 
            this.N_Total.AutoSize = true;
            this.N_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Total.Location = new System.Drawing.Point(119, 381);
            this.N_Total.Name = "N_Total";
            this.N_Total.Size = new System.Drawing.Size(101, 46);
            this.N_Total.TabIndex = 10;
            this.N_Total.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total:";
            // 
            // Tbox_factura
            // 
            this.Tbox_factura.Location = new System.Drawing.Point(169, 27);
            this.Tbox_factura.Name = "Tbox_factura";
            this.Tbox_factura.Size = new System.Drawing.Size(107, 20);
            this.Tbox_factura.TabIndex = 11;
            // 
            // Tbox_CProducto
            // 
            this.Tbox_CProducto.Location = new System.Drawing.Point(410, 310);
            this.Tbox_CProducto.Name = "Tbox_CProducto";
            this.Tbox_CProducto.Size = new System.Drawing.Size(107, 20);
            this.Tbox_CProducto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Códgio de producto:";
            // 
            // Tbox_cant
            // 
            this.Tbox_cant.Location = new System.Drawing.Point(532, 310);
            this.Tbox_cant.Name = "Tbox_cant";
            this.Tbox_cant.Size = new System.Drawing.Size(107, 20);
            this.Tbox_cant.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad:";
            // 
            // btn_facturar
            // 
            this.btn_facturar.Location = new System.Drawing.Point(697, 294);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(115, 104);
            this.btn_facturar.TabIndex = 16;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(410, 348);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(229, 41);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Agragar producto";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // TBox_impu
            // 
            this.TBox_impu.Location = new System.Drawing.Point(342, 290);
            this.TBox_impu.Name = "TBox_impu";
            this.TBox_impu.Size = new System.Drawing.Size(47, 20);
            this.TBox_impu.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "impuesto: %";
            // 
            // Tbox_descu
            // 
            this.Tbox_descu.Location = new System.Drawing.Point(342, 320);
            this.Tbox_descu.Name = "Tbox_descu";
            this.Tbox_descu.Size = new System.Drawing.Size(47, 20);
            this.Tbox_descu.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descuento: %";
            // 
            // Tbox_Ccliente
            // 
            this.Tbox_Ccliente.Location = new System.Drawing.Point(19, 167);
            this.Tbox_Ccliente.Name = "Tbox_Ccliente";
            this.Tbox_Ccliente.Size = new System.Drawing.Size(75, 20);
            this.Tbox_Ccliente.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cod.  Cliente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(19, 193);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // impresion
            // 
            this.impresion.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimir);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hIstorialaDeFacturasToolStripMenuItem,
            this.graficoDeVentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // hIstorialaDeFacturasToolStripMenuItem
            // 
            this.hIstorialaDeFacturasToolStripMenuItem.Name = "hIstorialaDeFacturasToolStripMenuItem";
            this.hIstorialaDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hIstorialaDeFacturasToolStripMenuItem.Text = "HIstoriala de facturas";
            // 
            // graficoDeVentasToolStripMenuItem
            // 
            this.graficoDeVentasToolStripMenuItem.Name = "graficoDeVentasToolStripMenuItem";
            this.graficoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.graficoDeVentasToolStripMenuItem.Text = "Grafico de ventas";
            this.graficoDeVentasToolStripMenuItem.Click += new System.EventHandler(this.graficoDeVentasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Punto_de_Venta.Properties.Resources.icono_de_venta_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Ventana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.Tbox_Ccliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tbox_descu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBox_impu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.Tbox_cant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbox_CProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbox_factura);
            this.Controls.Add(this.N_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.N_subtotal);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Tbox_nameCliente);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.factura);
            this.Controls.Add(this.Grid_principal);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventana_principal";
            this.Text = "Ventana_principal";
            this.Load += new System.EventHandler(this.Ventana_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_usuarios;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.DataGridView Grid_principal;
        private System.Windows.Forms.Label factura;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.TextBox Tbox_nameCliente;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label N_subtotal;
        private System.Windows.Forms.Label N_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbox_factura;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.TextBox Tbox_CProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_cant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox TBox_impu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbox_descu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbox_Ccliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem impuestosYDescuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox StripTbox_impuesto;
        private System.Windows.Forms.ToolStripMenuItem descuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox StripTbox_descuento;
        private System.Drawing.Printing.PrintDocument impresion;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIstorialaDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoDeVentasToolStripMenuItem;
    }
}