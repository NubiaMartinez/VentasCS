using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Ventas : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            MenuStrip1 = new MenuStrip();
            DetalleComprasToolStripMenuItem = new ToolStripMenuItem();
            DetalleComprasToolStripMenuItem.Click += new EventHandler(DetalleComprasToolStripMenuItem_Click);
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            Label10 = new Label();
            Label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            txtIdCliente = new TextBox();
            txtIdModificar = new TextBox();
            txtIVA = new TextBox();
            txtIdVenta = new TextBox();
            txtFecha = new TextBox();
            txtSubtotal = new TextBox();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            dgvVentas = new DataGridView();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            MenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { DetalleComprasToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(990, 29);
            MenuStrip1.TabIndex = 94;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // DetalleComprasToolStripMenuItem
            // 
            DetalleComprasToolStripMenuItem.Name = "DetalleComprasToolStripMenuItem";
            DetalleComprasToolStripMenuItem.Size = new Size(125, 25);
            DetalleComprasToolStripMenuItem.Text = "Detalle Ventas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 61);
            panel1.TabIndex = 137;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(412, 10);
            label9.Name = "label9";
            label9.Size = new Size(120, 38);
            label9.TabIndex = 0;
            label9.Text = "Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 357);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 145;
            label1.Text = "Id UModificar:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(12, 324);
            Label10.Name = "Label10";
            Label10.Size = new Size(85, 19);
            Label10.TabIndex = 144;
            Label10.Text = "Id UCrear:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(12, 213);
            Label3.Name = "Label3";
            Label3.Size = new Size(75, 19);
            Label3.TabIndex = 143;
            Label3.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 138;
            label2.Text = "Id Venta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 139;
            label4.Text = "Fecha:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(12, 250);
            Label5.Name = "Label5";
            Label5.Size = new Size(56, 19);
            Label5.TabIndex = 140;
            Label5.Text = "Status:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(12, 173);
            Label6.Name = "Label6";
            Label6.Size = new Size(40, 19);
            Label6.TabIndex = 141;
            Label6.Text = "IVA:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(12, 289);
            Label7.Name = "Label7";
            Label7.Size = new Size(84, 19);
            Label7.TabIndex = 142;
            Label7.Text = "Id cliente:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(137, 289);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(358, 22);
            txtIdCliente.TabIndex = 151;
            txtIdCliente.UseSystemPasswordChar = true;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(137, 357);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 153;
            txtIdModificar.UseSystemPasswordChar = true;
            // 
            // txtIVA
            // 
            txtIVA.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIVA.Location = new Point(137, 176);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(358, 22);
            txtIVA.TabIndex = 148;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdVenta.Location = new Point(137, 104);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(358, 22);
            txtIdVenta.TabIndex = 146;
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(137, 139);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(358, 22);
            txtFecha.TabIndex = 147;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(137, 213);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(358, 22);
            txtSubtotal.TabIndex = 149;
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(137, 250);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 150;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(137, 324);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 152;
            txtIdCrear.UseSystemPasswordChar = true;
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = SystemColors.ButtonFace;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(514, 104);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(466, 275);
            dgvVentas.TabIndex = 154;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(709, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 34);
            btnLimpiar.TabIndex = 157;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(709, 479);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 34);
            btnEditar.TabIndex = 156;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(709, 436);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(97, 34);
            btnAñadir.TabIndex = 155;
            btnAñadir.Text = "Agregar";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(387, 406);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 170;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 406);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 169;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(226, 479);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 34);
            btnBuscar.TabIndex = 168;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(376, 479);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 167;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(990, 572);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvVentas);
            Controls.Add(txtIdCliente);
            Controls.Add(txtIdModificar);
            Controls.Add(txtIVA);
            Controls.Add(txtIdVenta);
            Controls.Add(txtFecha);
            Controls.Add(txtSubtotal);
            Controls.Add(txtEstatus);
            Controls.Add(txtIdCrear);
            Controls.Add(label1);
            Controls.Add(Label10);
            Controls.Add(Label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(Label5);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(panel1);
            Controls.Add(MenuStrip1);
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(Ventas_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem DetalleComprasToolStripMenuItem;
        private Panel panel1;
        private Label label9;
        internal Label label1;
        internal Label Label10;
        internal Label Label3;
        internal Label label2;
        internal Label label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal TextBox txtIdCliente;
        internal TextBox txtIdModificar;
        internal TextBox txtIVA;
        internal TextBox txtIdVenta;
        internal TextBox txtFecha;
        internal TextBox txtSubtotal;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal DataGridView dgvVentas;
        internal Button btnLimpiar;
        internal Button btnEditar;
        internal Button btnAñadir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnEliminar;
    }
}