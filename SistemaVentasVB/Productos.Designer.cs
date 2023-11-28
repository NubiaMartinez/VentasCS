using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Productos : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            MenuStrip1 = new MenuStrip();
            MarcaToolStripMenuItem = new ToolStripMenuItem();
            MarcaToolStripMenuItem.Click += new EventHandler(MarcaToolStripMenuItem_Click);
            CategoriaToolStripMenuItem = new ToolStripMenuItem();
            CategoriaToolStripMenuItem.Click += new EventHandler(CategoriaToolStripMenuItem_Click);
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            Label10 = new Label();
            Label8 = new Label();
            Label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label11 = new Label();
            txtIdCategoria = new TextBox();
            txtIdMarca = new TextBox();
            txtIdModificar = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtIdProducto = new TextBox();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            dgvProductos = new DataGridView();
            MenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { MarcaToolStripMenuItem, CategoriaToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(829, 29);
            MenuStrip1.TabIndex = 90;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // MarcaToolStripMenuItem
            // 
            MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem";
            MarcaToolStripMenuItem.Size = new Size(67, 25);
            MarcaToolStripMenuItem.Text = "Marca";
            // 
            // CategoriaToolStripMenuItem
            // 
            CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem";
            CategoriaToolStripMenuItem.Size = new Size(93, 25);
            CategoriaToolStripMenuItem.Text = "Categoria";
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
            label9.Location = new Point(296, 10);
            label9.Name = "label9";
            label9.Size = new Size(175, 38);
            label9.TabIndex = 0;
            label9.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 410);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 147;
            label1.Text = "Id UModificar:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(214, 377);
            Label10.Name = "Label10";
            Label10.Size = new Size(85, 19);
            Label10.TabIndex = 146;
            Label10.Text = "Id UCrear:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.Transparent;
            Label8.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(210, 345);
            Label8.Name = "Label8";
            Label8.Size = new Size(108, 19);
            Label8.TabIndex = 145;
            Label8.Text = "Id categoría:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(214, 210);
            Label3.Name = "Label3";
            Label3.Size = new Size(54, 19);
            Label3.TabIndex = 144;
            Label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 104);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 138;
            label2.Text = "Id producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 139);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 139;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(214, 244);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 140;
            label5.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(214, 277);
            label6.Name = "label6";
            label6.Size = new Size(56, 19);
            label6.TabIndex = 141;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(214, 173);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 142;
            label7.Text = "Precio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(214, 310);
            label11.Name = "label11";
            label11.Size = new Size(85, 19);
            label11.TabIndex = 143;
            label11.Text = "Id marca:";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCategoria.Location = new Point(324, 344);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(358, 22);
            txtIdCategoria.TabIndex = 155;
            // 
            // txtIdMarca
            // 
            txtIdMarca.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdMarca.Location = new Point(324, 312);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(358, 22);
            txtIdMarca.TabIndex = 154;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(324, 409);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 157;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(324, 244);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(358, 22);
            txtDescripcion.TabIndex = 152;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(324, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(358, 22);
            txtPrecio.TabIndex = 150;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.Location = new Point(324, 103);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(358, 22);
            txtIdProducto.TabIndex = 148;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(324, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 149;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(324, 212);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(358, 22);
            txtStock.TabIndex = 151;
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(324, 276);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 153;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(324, 376);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 156;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(719, 186);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 34);
            btnLimpiar.TabIndex = 160;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(719, 272);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 34);
            btnEditar.TabIndex = 159;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(719, 229);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(98, 34);
            btnAñadir.TabIndex = 158;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 164;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 163;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(52, 198);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 34);
            btnBuscar.TabIndex = 162;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(52, 321);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 161;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ButtonFace;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 455);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(781, 149);
            dgvProductos.TabIndex = 165;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(829, 616);
            Controls.Add(dgvProductos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(txtIdCategoria);
            Controls.Add(txtIdMarca);
            Controls.Add(txtIdModificar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtIdProducto);
            Controls.Add(txtNombre);
            Controls.Add(txtStock);
            Controls.Add(txtEstatus);
            Controls.Add(txtIdCrear);
            Controls.Add(label1);
            Controls.Add(Label10);
            Controls.Add(Label8);
            Controls.Add(Label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(MenuStrip1);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            Load += new EventHandler(Productos_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem MarcaToolStripMenuItem;
        internal ToolStripMenuItem CategoriaToolStripMenuItem;
        private Panel panel1;
        private Label label9;
        internal Label label1;
        internal Label Label10;
        internal Label Label8;
        internal Label Label3;
        internal Label label2;
        internal Label label4;
        internal Label label5;
        internal Label label6;
        internal Label label7;
        internal Label label11;
        internal TextBox txtIdCategoria;
        internal TextBox txtIdMarca;
        internal TextBox txtIdModificar;
        internal TextBox txtDescripcion;
        internal TextBox txtPrecio;
        internal TextBox txtIdProducto;
        internal TextBox txtNombre;
        internal TextBox txtStock;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal Button btnLimpiar;
        internal Button btnEditar;
        internal Button btnAñadir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnEliminar;
        internal DataGridView dgvProductos;
    }
}