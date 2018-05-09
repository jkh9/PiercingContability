namespace ContabilidadPiercingsWF
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.btnIngreso = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGasto = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pCompraVenta = new System.Windows.Forms.Panel();
            this.comprasDiarias = new ContabilidadPiercingsWF.ComprasDiarias();
            this.ventasDiarias = new ContabilidadPiercingsWF.VentasDiarias();
            this.pantallaCompras = new ContabilidadPiercingsWF.PantallaCompras();
            this.pantallaVentas = new ContabilidadPiercingsWF.PantallaVentas(ventasDiarias);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pCompraVenta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(618, 540);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(366, 70);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // btnGasto
            // 
            this.btnGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGasto.FlatAppearance.BorderSize = 0;
            this.btnGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGasto.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGasto.Location = new System.Drawing.Point(618, 464);
            this.btnGasto.Name = "btnGasto";
            this.btnGasto.Size = new System.Drawing.Size(366, 70);
            this.btnGasto.TabIndex = 3;
            this.btnGasto.Text = "Gasto";
            this.btnGasto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGasto.UseVisualStyleBackColor = false;
            this.btnGasto.Click += new System.EventHandler(this.btnGasto_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(0, 611);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 51);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Location = new System.Drawing.Point(350, 611);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(250, 51);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(954, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pCompraVenta
            // 
            this.pCompraVenta.Controls.Add(this.comprasDiarias);
            this.pCompraVenta.Controls.Add(this.pantallaVentas);
            this.pCompraVenta.Controls.Add(this.pantallaCompras);
            this.pCompraVenta.Location = new System.Drawing.Point(0, 32);
            this.pCompraVenta.Name = "pCompraVenta";
            this.pCompraVenta.Size = new System.Drawing.Size(600, 580);
            this.pCompraVenta.TabIndex = 4;
            // 
            // comprasDiarias
            // 
            this.comprasDiarias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.comprasDiarias.Location = new System.Drawing.Point(0, 0);
            this.comprasDiarias.Name = "comprasDiarias";
            this.comprasDiarias.Size = new System.Drawing.Size(600, 580);
            this.comprasDiarias.TabIndex = 0;
            // 
            // ventasDiarias
            // 
            this.ventasDiarias.Aux = null;
            this.ventasDiarias.BackColor = System.Drawing.Color.White;
            this.ventasDiarias.Location = new System.Drawing.Point(0, 0);
            this.ventasDiarias.Name = "ventasDiarias";
            this.ventasDiarias.Size = new System.Drawing.Size(366, 425);
            this.ventasDiarias.TabIndex = 0;
            // 
            // pantallaVentas
            // 
            this.pantallaVentas.Location = new System.Drawing.Point(0, 0);
            this.pantallaVentas.Name = "pantallaVentas";
            this.pantallaVentas.Size = new System.Drawing.Size(700, 580);
            this.pantallaVentas.TabIndex = 3;
            // 
            // pantallaCompras
            // 
            this.pantallaCompras.Location = new System.Drawing.Point(0, 0);
            this.pantallaCompras.Name = "pantallaCompras";
            this.pantallaCompras.Size = new System.Drawing.Size(700, 580);
            this.pantallaCompras.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(248, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 50);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(600, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 70);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ventasDiarias);
            this.panel3.Location = new System.Drawing.Point(618, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 425);
            this.panel3.TabIndex = 9;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.pCompraVenta);
            this.Controls.Add(this.btnGasto);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilidad de piercings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pCompraVenta.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.Button btnGasto;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pCompraVenta;
        private ComprasDiarias comprasDiarias;
        private PantallaVentas pantallaVentas;
        private PantallaCompras pantallaCompras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private VentasDiarias ventasDiarias;
    }
}

