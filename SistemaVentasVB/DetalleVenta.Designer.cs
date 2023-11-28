using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DetalleVenta : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleVenta));
            panel1 = new Panel();
            label9 = new Label();
            Label1 = new Label();
            txtIdVenta = new TextBox();
            Label10 = new Label();
            txtIdModificar = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            txtIdDetalleVenta = new TextBox();
            Label4 = new Label();
            txtCantidad = new TextBox();
            txtTotal = new TextBox();
            Label5 = new Label();
            txtIdProducto = new TextBox();
            txtIdCrear = new TextBox();
            Label7 = new Label();
            dgvDVenta = new DataGridView();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 61);
            panel1.TabIndex = 136;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(368, 8);
            label9.Name = "label9";
            label9.Size = new Size(220, 38);
            label9.TabIndex = 0;
            label9.Text = "Detalle Venta";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(225, 295);
            Label1.Name = "Label1";
            Label1.Size = new Size(93, 16);
            Label1.TabIndex = 150;
            Label1.Text = "Id modificar:";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdVenta.Location = new Point(354, 224);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(358, 22);
            txtIdVenta.TabIndex = 141;
            txtIdVenta.UseSystemPasswordChar = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(255, 262);
            Label10.Name = "Label10";
            Label10.Size = new Size(67, 16);
            Label10.TabIndex = 149;
            Label10.Text = "Id Crear:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(354, 292);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 143;
            txtIdModificar.UseSystemPasswordChar = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(255, 154);
            Label3.Name = "Label3";
            Label3.Size = new Size(48, 16);
            Label3.TabIndex = 148;
            Label3.Text = "Total:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(255, 78);
            Label2.Name = "Label2";
            Label2.Size = new Size(79, 16);
            Label2.TabIndex = 144;
            Label2.Text = "Id Detalle:";
            // 
            // txtIdDetalleVenta
            // 
            txtIdDetalleVenta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdDetalleVenta.Location = new Point(354, 78);
            txtIdDetalleVenta.Name = "txtIdDetalleVenta";
            txtIdDetalleVenta.Size = new Size(358, 22);
            txtIdDetalleVenta.TabIndex = 137;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(255, 116);
            Label4.Name = "Label4";
            Label4.Size = new Size(74, 16);
            Label4.TabIndex = 145;
            Label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(354, 113);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(358, 22);
            txtCantidad.TabIndex = 138;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(354, 148);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(358, 22);
            txtTotal.TabIndex = 139;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(244, 188);
            Label5.Name = "Label5";
            Label5.Size = new Size(90, 16);
            Label5.TabIndex = 146;
            Label5.Text = "Id producto:";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.Location = new Point(354, 185);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(358, 22);
            txtIdProducto.TabIndex = 140;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(354, 259);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 142;
            txtIdCrear.UseSystemPasswordChar = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(255, 224);
            Label7.Name = "Label7";
            Label7.Size = new Size(67, 16);
            Label7.TabIndex = 147;
            Label7.Text = "Id venta:";
            // 
            // dgvDVenta
            // 
            dgvDVenta.BackgroundColor = SystemColors.ButtonFace;
            dgvDVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVenta.Location = new Point(30, 347);
            dgvDVenta.Name = "dgvDVenta";
            dgvDVenta.Size = new Size(895, 146);
            dgvDVenta.TabIndex = 151;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(790, 127);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 34);
            btnLimpiar.TabIndex = 154;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(790, 213);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 34);
            btnEditar.TabIndex = 153;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(790, 170);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(97, 34);
            btnAñadir.TabIndex = 152;
            btnAñadir.Text = "Agregar";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 158;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 157;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(63, 159);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 34);
            btnBuscar.TabIndex = 156;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(63, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 155;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(952, 514);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvDVenta);
            Controls.Add(Label1);
            Controls.Add(txtIdVenta);
            Controls.Add(Label10);
            Controls.Add(txtIdModificar);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(txtIdDetalleVenta);
            Controls.Add(Label4);
            Controls.Add(txtCantidad);
            Controls.Add(txtTotal);
            Controls.Add(Label5);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdCrear);
            Controls.Add(Label7);
            Controls.Add(panel1);
            Name = "DetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(DetalleVenta_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private Panel panel1;
        private Label label9;
        internal Label Label1;
        internal TextBox txtIdVenta;
        internal Label Label10;
        internal TextBox txtIdModificar;
        internal Label Label3;
        internal Label Label2;
        internal TextBox txtIdDetalleVenta;
        internal Label Label4;
        internal TextBox txtCantidad;
        internal TextBox txtTotal;
        internal Label Label5;
        internal TextBox txtIdProducto;
        internal TextBox txtIdCrear;
        internal Label Label7;
        internal DataGridView dgvDVenta;
        internal Button btnLimpiar;
        internal Button btnEditar;
        internal Button btnAñadir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnEliminar;
    }
}