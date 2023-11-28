using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Categorias : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            panel1 = new Panel();
            label4 = new Label();
            Label3 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtIdModificar = new TextBox();
            txtDescripcion = new TextBox();
            txtIdCategoria = new TextBox();
            txtNombre = new TextBox();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            dgvCategoria = new DataGridView();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 61);
            panel1.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(383, 9);
            label4.Name = "label4";
            label4.Size = new Size(185, 38);
            label4.TabIndex = 0;
            label4.Text = "Categorías";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(238, 254);
            Label3.Name = "Label3";
            Label3.Size = new Size(107, 19);
            Label3.TabIndex = 92;
            Label3.Text = "Id modificar:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(238, 222);
            label12.Name = "label12";
            label12.Size = new Size(73, 19);
            label12.TabIndex = 93;
            label12.Text = "Id crear:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(238, 188);
            label11.Name = "label11";
            label11.Size = new Size(56, 19);
            label11.TabIndex = 94;
            label11.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(238, 149);
            label10.Name = "label10";
            label10.Size = new Size(104, 19);
            label10.TabIndex = 95;
            label10.Text = "Descripción:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(238, 115);
            label9.Name = "label9";
            label9.Size = new Size(77, 19);
            label9.TabIndex = 96;
            label9.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(238, 79);
            label8.Name = "label8";
            label8.Size = new Size(108, 19);
            label8.TabIndex = 97;
            label8.Text = "Id categoría:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(351, 254);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 103;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(351, 149);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(358, 22);
            txtDescripcion.TabIndex = 100;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCategoria.Location = new Point(351, 77);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(358, 22);
            txtIdCategoria.TabIndex = 98;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(351, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 99;
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(351, 185);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 101;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(351, 219);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 102;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(21, 300);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(870, 146);
            dgvCategoria.TabIndex = 104;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(783, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 68);
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(774, 153);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 34);
            btnBuscar.TabIndex = 106;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(84, 87);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 34);
            btnLimpiar.TabIndex = 110;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(84, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 34);
            btnEliminar.TabIndex = 109;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(84, 173);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(92, 34);
            btnEditar.TabIndex = 108;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(84, 130);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(92, 34);
            btnAñadir.TabIndex = 107;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(903, 468);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(btnBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(dgvCategoria);
            Controls.Add(txtIdModificar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIdCategoria);
            Controls.Add(txtNombre);
            Controls.Add(txtEstatus);
            Controls.Add(txtIdCrear);
            Controls.Add(Label3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(Categorias_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private Panel panel1;
        private Label label4;
        internal Label Label3;
        internal Label label12;
        internal Label label11;
        internal Label label10;
        internal Label label9;
        internal Label label8;
        internal TextBox txtIdModificar;
        internal TextBox txtDescripcion;
        internal TextBox txtIdCategoria;
        internal TextBox txtNombre;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal DataGridView dgvCategoria;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnLimpiar;
        internal Button btnEliminar;
        internal Button btnEditar;
        internal Button btnAñadir;
    }
}