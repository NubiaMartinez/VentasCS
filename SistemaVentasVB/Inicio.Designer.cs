using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Inicio : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            MSinicio = new MenuStrip();
            VentasToolStripMenuItem = new ToolStripMenuItem();
            VentasToolStripMenuItem.Click += new EventHandler(VentasToolStripMenuItem_Click);
            ComprasToolStripMenuItem = new ToolStripMenuItem();
            ComprasToolStripMenuItem.Click += new EventHandler(ComprasToolStripMenuItem_Click);
            ProductosToolStripMenuItem = new ToolStripMenuItem();
            ProductosToolStripMenuItem.Click += new EventHandler(ProductosToolStripMenuItem_Click);
            ClientesToolStripMenuItem = new ToolStripMenuItem();
            ClientesToolStripMenuItem.Click += new EventHandler(ClientesToolStripMenuItem_Click);
            ProveedoresToolStripMenuItem = new ToolStripMenuItem();
            ProveedoresToolStripMenuItem.Click += new EventHandler(ProveedoresToolStripMenuItem_Click);
            UsuariosToolStripMenuItem = new ToolStripMenuItem();
            UsuariosToolStripMenuItem.Click += new EventHandler(UsuariosToolStripMenuItem_Click);
            panel1 = new Panel();
            label9 = new Label();
            MSinicio.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MSinicio
            // 
            MSinicio.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSinicio.Items.AddRange(new ToolStripItem[] { VentasToolStripMenuItem, ComprasToolStripMenuItem, ProductosToolStripMenuItem, ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, UsuariosToolStripMenuItem });
            MSinicio.LayoutStyle = ToolStripLayoutStyle.Flow;
            MSinicio.Location = new Point(0, 0);
            MSinicio.Name = "MSinicio";
            MSinicio.Size = new Size(931, 29);
            MSinicio.TabIndex = 0;
            MSinicio.Text = "MenuStrip1";
            // 
            // VentasToolStripMenuItem
            // 
            VentasToolStripMenuItem.Name = "VentasToolStripMenuItem";
            VentasToolStripMenuItem.Size = new Size(70, 25);
            VentasToolStripMenuItem.Text = "Ventas";
            // 
            // ComprasToolStripMenuItem
            // 
            ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem";
            ComprasToolStripMenuItem.Size = new Size(87, 25);
            ComprasToolStripMenuItem.Text = "Compras";
            // 
            // ProductosToolStripMenuItem
            // 
            ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            ProductosToolStripMenuItem.Size = new Size(97, 25);
            ProductosToolStripMenuItem.Text = "Productos";
            // 
            // ClientesToolStripMenuItem
            // 
            ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            ClientesToolStripMenuItem.Size = new Size(80, 25);
            ClientesToolStripMenuItem.Text = "Clientes";
            // 
            // ProveedoresToolStripMenuItem
            // 
            ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem";
            ProveedoresToolStripMenuItem.Size = new Size(115, 25);
            ProveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // UsuariosToolStripMenuItem
            // 
            UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            UsuariosToolStripMenuItem.Size = new Size(84, 25);
            UsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 61);
            panel1.TabIndex = 137;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(425, 10);
            label9.Name = "label9";
            label9.Size = new Size(104, 38);
            label9.TabIndex = 0;
            label9.Text = "Inicio";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(931, 450);
            Controls.Add(panel1);
            Controls.Add(MSinicio);
            MainMenuStrip = MSinicio;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            MSinicio.ResumeLayout(false);
            MSinicio.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Load += new EventHandler(Inicio_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MenuStrip MSinicio;
        internal ToolStripMenuItem VentasToolStripMenuItem;
        internal ToolStripMenuItem ComprasToolStripMenuItem;
        internal ToolStripMenuItem ProductosToolStripMenuItem;
        internal ToolStripMenuItem ClientesToolStripMenuItem;
        internal ToolStripMenuItem ProveedoresToolStripMenuItem;
        internal ToolStripMenuItem UsuariosToolStripMenuItem;
        private Panel panel1;
        private Label label9;
    }
}