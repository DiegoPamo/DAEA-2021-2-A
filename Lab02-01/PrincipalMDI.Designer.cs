
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.regVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.regCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.repVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.repCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.repInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.repProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.repUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.repClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.deportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regVentas,
            this.regCompras});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // deportesToolStripMenuItem
            // 
            this.deportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repVentas,
            this.repCompras,
            this.repInventario,
            this.repProveedores,
            this.repUsuarios,
            this.repClientes});
            this.deportesToolStripMenuItem.Name = "deportesToolStripMenuItem";
            this.deportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.deportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(224, 26);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(224, 26);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuManClientes.Text = "Clientes";
            // 
            // regVentas
            // 
            this.regVentas.Name = "regVentas";
            this.regVentas.Size = new System.Drawing.Size(224, 26);
            this.regVentas.Text = "Registrar Venta";
            // 
            // regCompras
            // 
            this.regCompras.Name = "regCompras";
            this.regCompras.Size = new System.Drawing.Size(224, 26);
            this.regCompras.Text = "Registrar Compra";
            // 
            // repVentas
            // 
            this.repVentas.Name = "repVentas";
            this.repVentas.Size = new System.Drawing.Size(253, 26);
            this.repVentas.Text = "Reporte de ventas";
            // 
            // repCompras
            // 
            this.repCompras.Name = "repCompras";
            this.repCompras.Size = new System.Drawing.Size(253, 26);
            this.repCompras.Text = "Reporte de compras";
            // 
            // repInventario
            // 
            this.repInventario.Name = "repInventario";
            this.repInventario.Size = new System.Drawing.Size(253, 26);
            this.repInventario.Text = "Inventario de productos";
            // 
            // repProveedores
            // 
            this.repProveedores.Name = "repProveedores";
            this.repProveedores.Size = new System.Drawing.Size(253, 26);
            this.repProveedores.Text = "Reporte de proveedores";
            // 
            // repUsuarios
            // 
            this.repUsuarios.Name = "repUsuarios";
            this.repUsuarios.Size = new System.Drawing.Size(253, 26);
            this.repUsuarios.Text = "Reporte de usuarios";
            // 
            // repClientes
            // 
            this.repClientes.Name = "repClientes";
            this.repClientes.Size = new System.Drawing.Size(253, 26);
            this.repClientes.Text = "Reporte de clientes";
            // 
            // mnuSisSalir
            // 
            this.mnuSisSalir.Name = "mnuSisSalir";
            this.mnuSisSalir.Size = new System.Drawing.Size(224, 26);
            this.mnuSisSalir.Text = "Salir del Sistema";
            this.mnuSisSalir.Click += new System.EventHandler(this.mnuSisSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regVentas;
        private System.Windows.Forms.ToolStripMenuItem regCompras;
        private System.Windows.Forms.ToolStripMenuItem deportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repVentas;
        private System.Windows.Forms.ToolStripMenuItem repCompras;
        private System.Windows.Forms.ToolStripMenuItem repInventario;
        private System.Windows.Forms.ToolStripMenuItem repProveedores;
        private System.Windows.Forms.ToolStripMenuItem repUsuarios;
        private System.Windows.Forms.ToolStripMenuItem repClientes;
    }
}