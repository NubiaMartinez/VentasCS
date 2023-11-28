using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Clientes : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            panel1 = new Panel();
            label9 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            Label5 = new Label();
            Label2 = new Label();
            Label6 = new Label();
            Label4 = new Label();
            txtIdModificar = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtIdCliente = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            Label8 = new Label();
            Label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 61);
            panel1.TabIndex = 92;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(409, 9);
            label9.Name = "label9";
            label9.Size = new Size(140, 38);
            label9.TabIndex = 0;
            label9.Text = "Clientes";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(256, 218);
            Label3.Name = "Label3";
            Label3.Size = new Size(59, 19);
            Label3.TabIndex = 98;
            Label3.Text = "E-mail";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(255, 77);
            Label1.Name = "Label1";
            Label1.Size = new Size(84, 19);
            Label1.TabIndex = 93;
            Label1.Text = "Id cliente:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(255, 250);
            Label5.Name = "Label5";
            Label5.Size = new Size(56, 19);
            Label5.TabIndex = 96;
            Label5.Text = "Status:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(256, 109);
            Label2.Name = "Label2";
            Label2.Size = new Size(77, 19);
            Label2.TabIndex = 94;
            Label2.Text = "Nombre:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(255, 146);
            Label6.Name = "Label6";
            Label6.Size = new Size(87, 19);
            Label6.TabIndex = 97;
            Label6.Text = "Dirección:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(255, 183);
            Label4.Name = "Label4";
            Label4.Size = new Size(78, 19);
            Label4.TabIndex = 95;
            Label4.Text = "Telefono:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(349, 315);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 106;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(349, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 22);
            txtEmail.TabIndex = 103;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(349, 146);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(358, 22);
            txtDireccion.TabIndex = 101;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(349, 74);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(358, 22);
            txtIdCliente.TabIndex = 99;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(349, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 100;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(349, 183);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(358, 22);
            txtTelefono.TabIndex = 102;
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(349, 247);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 104;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(349, 282);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 105;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.Transparent;
            Label8.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(224, 282);
            Label8.Name = "Label8";
            Label8.Size = new Size(115, 19);
            Label8.TabIndex = 107;
            Label8.Text = "Id UModificar:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(248, 318);
            Label7.Name = "Label7";
            Label7.Size = new Size(85, 19);
            Label7.TabIndex = 108;
            Label7.Text = "Id UCrear:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(90, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 112;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 111;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(79, 168);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 34);
            btnBuscar.TabIndex = 110;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(79, 291);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 109;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 356);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(940, 153);
            dgvClientes.TabIndex = 113;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(800, 114);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 34);
            btnLimpiar.TabIndex = 116;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(800, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 34);
            btnEditar.TabIndex = 115;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ForeColor = SystemColors.ActiveCaptionText;
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(800, 157);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(96, 34);
            btnAñadir.TabIndex = 114;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(964, 521);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvClientes);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(Label7);
            Controls.Add(Label8);
            Controls.Add(txtIdModificar);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtIdCliente);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtEstatus);
            Controls.Add(txtIdCrear);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(Label5);
            Controls.Add(Label2);
            Controls.Add(Label6);
            Controls.Add(Label4);
            Controls.Add(panel1);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            Load += new EventHandler(Clientes_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private Panel panel1;
        private Label label9;
        internal Label Label3;
        internal Label Label1;
        internal Label Label5;
        internal Label Label2;
        internal Label Label6;
        internal Label Label4;
        internal TextBox txtIdModificar;
        internal TextBox txtEmail;
        internal TextBox txtDireccion;
        internal TextBox txtIdCliente;
        internal TextBox txtNombre;
        internal TextBox txtTelefono;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal Label Label8;
        internal Label Label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnEliminar;
        internal DataGridView dgvClientes;
        internal Button btnLimpiar;
        internal Button btnEditar;
        internal Button btnAñadir;
    }
}