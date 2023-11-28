using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Usuarios : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            panel1 = new Panel();
            label9 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtIdUsuario = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEstatus = new TextBox();
            txtContraseña = new TextBox();
            dgvUsuarios = new DataGridView();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 61);
            panel1.TabIndex = 138;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(421, 8);
            label9.Name = "label9";
            label9.Size = new Size(155, 38);
            label9.TabIndex = 0;
            label9.Text = "Usuarios";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(41, 217);
            Label3.Name = "Label3";
            Label3.Size = new Size(63, 19);
            Label3.TabIndex = 145;
            Label3.Text = "E-mail:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(41, 78);
            Label1.Name = "Label1";
            Label1.Size = new Size(88, 19);
            Label1.TabIndex = 139;
            Label1.Text = "Id Usuario:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(41, 112);
            Label2.Name = "Label2";
            Label2.Size = new Size(77, 19);
            Label2.TabIndex = 140;
            Label2.Text = "Nombre:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(40, 186);
            Label4.Name = "Label4";
            Label4.Size = new Size(78, 19);
            Label4.TabIndex = 141;
            Label4.Text = "Telefono:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(41, 250);
            Label5.Name = "Label5";
            Label5.Size = new Size(56, 19);
            Label5.TabIndex = 142;
            Label5.Text = "Status:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(41, 149);
            Label6.Name = "Label6";
            Label6.Size = new Size(87, 19);
            Label6.TabIndex = 143;
            Label6.Text = "Dirección:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(41, 282);
            Label7.Name = "Label7";
            Label7.Size = new Size(102, 19);
            Label7.TabIndex = 144;
            Label7.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(164, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 22);
            txtEmail.TabIndex = 152;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(164, 149);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(358, 22);
            txtDireccion.TabIndex = 150;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdUsuario.Location = new Point(164, 77);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(358, 22);
            txtIdUsuario.TabIndex = 146;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(164, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 147;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(164, 186);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(358, 22);
            txtTelefono.TabIndex = 148;
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(164, 250);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 149;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(164, 285);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(358, 22);
            txtContraseña.TabIndex = 151;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.Control;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(552, 68);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(470, 244);
            dgvUsuarios.TabIndex = 153;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(707, 341);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 34);
            btnLimpiar.TabIndex = 156;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(707, 427);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 34);
            btnEditar.TabIndex = 155;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(707, 384);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(96, 34);
            btnAñadir.TabIndex = 154;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(470, 341);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 166;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 341);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 165;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(309, 414);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 34);
            btnBuscar.TabIndex = 164;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(459, 414);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 163;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1034, 502);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtEstatus);
            Controls.Add(txtContraseña);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(panel1);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(Usuarios_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private Panel panel1;
        private Label label9;
        internal Label Label3;
        internal Label Label1;
        internal Label Label2;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal TextBox txtEmail;
        internal TextBox txtDireccion;
        internal TextBox txtIdUsuario;
        internal TextBox txtNombre;
        internal TextBox txtTelefono;
        internal TextBox txtEstatus;
        internal TextBox txtContraseña;
        internal DataGridView dgvUsuarios;
        internal Button btnLimpiar;
        internal Button btnEditar;
        internal Button btnAñadir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        internal Button btnBuscar;
        internal Button btnEliminar;
    }
}