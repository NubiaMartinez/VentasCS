using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Marcas : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcas));
            label9 = new Label();
            panel1 = new Panel();
            Label3 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            txtIdCrear = new TextBox();
            txtEstatus = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtIdMarca = new TextBox();
            txtIdModificar = new TextBox();
            dgvMarcas = new DataGridView();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(359, 8);
            label9.Name = "label9";
            label9.Size = new Size(113, 38);
            label9.TabIndex = 0;
            label9.Text = "Marca";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 61);
            panel1.TabIndex = 97;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(194, 282);
            Label3.Name = "Label3";
            Label3.Size = new Size(115, 19);
            Label3.TabIndex = 113;
            Label3.Text = "ID UModificar:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(194, 102);
            Label1.Name = "Label1";
            Label1.Size = new Size(85, 19);
            Label1.TabIndex = 108;
            Label1.Text = "Id marca:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(194, 137);
            Label2.Name = "Label2";
            Label2.Size = new Size(77, 19);
            Label2.TabIndex = 109;
            Label2.Text = "Nombre:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(194, 210);
            Label5.Name = "Label5";
            Label5.Size = new Size(56, 19);
            Label5.TabIndex = 110;
            Label5.Text = "Status:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(194, 174);
            Label6.Name = "Label6";
            Label6.Size = new Size(104, 19);
            Label6.TabIndex = 111;
            Label6.Text = "Descripción:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(194, 247);
            Label7.Name = "Label7";
            Label7.Size = new Size(85, 19);
            Label7.TabIndex = 112;
            Label7.Text = "Id UCrear:";
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(313, 244);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 118;
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(313, 210);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 117;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(313, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 115;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(313, 174);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(358, 22);
            txtDescripcion.TabIndex = 116;
            // 
            // txtIdMarca
            // 
            txtIdMarca.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdMarca.Location = new Point(313, 102);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(358, 22);
            txtIdMarca.TabIndex = 114;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(313, 279);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 119;
            // 
            // dgvMarcas
            // 
            dgvMarcas.BackgroundColor = Color.White;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(1, 331);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.Size = new Size(855, 136);
            dgvMarcas.TabIndex = 120;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(718, 116);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 34);
            btnLimpiar.TabIndex = 123;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(718, 202);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 34);
            btnEditar.TabIndex = 122;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(718, 159);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(96, 34);
            btnAñadir.TabIndex = 121;
            btnAñadir.Text = "Agregar";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 162;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 161;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(38, 158);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 34);
            btnBuscar.TabIndex = 160;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(38, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 159;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Marcas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(857, 467);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvMarcas);
            Controls.Add(txtIdModificar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIdMarca);
            Controls.Add(txtNombre);
            Controls.Add(txtEstatus);
            Controls.Add(txtIdCrear);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(Label5);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(panel1);
            Name = "Marcas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marcas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(Marcas_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label9;
        private Panel panel1;
        internal Label Label3;
        internal Label Label1;
        internal Label Label2;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal TextBox txtIdCrear;
        internal TextBox txtEstatus;
        internal TextBox txtNombre;
        internal TextBox txtDescripcion;
        internal TextBox txtIdMarca;
        internal TextBox txtIdModificar;
        internal DataGridView dgvMarcas;
        internal Button btnLimpiar;
        internal Button btnEditar;
        internal Button btnAñadir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnEliminar;
    }
}