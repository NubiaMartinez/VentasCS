using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Label1 = new Label();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            btnAcceder.Click += new EventHandler(btnAcceder_Click);
            Label2 = new Label();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(79, 194);
            Label1.Name = "Label1";
            Label1.Size = new Size(69, 19);
            Label1.TabIndex = 0;
            Label1.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(167, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 26);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.White;
            btnAcceder.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(197, 285);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(100, 34);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Ingresar";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(54, 235);
            Label2.Name = "Label2";
            Label2.Size = new Size(102, 19);
            Label2.TabIndex = 3;
            Label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(167, 194);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 26);
            txtUsuario.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 61);
            panel1.TabIndex = 96;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(193, 8);
            label9.Name = "label9";
            label9.Size = new Size(103, 38);
            label9.TabIndex = 0;
            label9.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(455, 367);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(txtUsuario);
            Controls.Add(Label2);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(Label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(Login_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox txtPassword;
        internal Button btnAcceder;
        internal Label Label2;
        internal TextBox txtUsuario;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
    }
}