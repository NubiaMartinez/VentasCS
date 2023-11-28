using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class Usuarios
    {
        private BOUsuarios usuario = new BOUsuarios();
        private bool etiqueta = true;

        public Usuarios()
        {
            InitializeComponent();
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        public void MostrarUsuarios()
        {
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Usuarios", cnn);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            try
            {
                cnn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            // Mostrar los datos en el DataGridView
            dgvUsuarios.DataSource = dt;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJL;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from Usuarios where Id_Usuario = @Id_Usuario", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", txtIdUsuario.Text));
            using (var sda = new SqlDataAdapter())
            {
                sda.SelectCommand = cmd;
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    if (Conversions.ToBoolean(dt.Rows.Count))
                    {
                        txtNombre.Text = dt.Rows[0][1].ToString();
                        txtDireccion.Text = dt.Rows[0][2].ToString();
                        txtTelefono.Text = dt.Rows[0][3].ToString();
                        txtEmail.Text = dt.Rows[0][4].ToString();
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.Rows[0][5], true, false)))
                        {
                            txtEstatus.Text = 1.ToString();
                        }
                        else
                        {
                            txtEstatus.Text = 0.ToString();
                        }
                        txtContraseña.Text = dt.Rows[0][6].ToString();
                    }
                }
            }

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEstatus.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(usuario.RegistrarUsuario(Conversions.ToInteger(txtIdUsuario.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, Conversions.ToInteger(txtEstatus.Text), txtContraseña.Text));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarUsuarios();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEstatus.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(usuario.ModificarUsuario(Conversions.ToInteger(txtIdUsuario.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, Conversions.ToInteger(txtEstatus.Text), txtContraseña.Text));
                Interaction.MsgBox("La informacion se ha modificado con Exito");
                Limpiar();
                MostrarUsuarios();
            }
            else
            {
                Interaction.MsgBox("No se ha podido modificar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                valido = false;
            }

            if (valido)
            {
                etiqueta = Conversions.ToBoolean(usuario.EliminarUsuario(Conversions.ToInteger(txtIdUsuario.Text)));
                Interaction.MsgBox("La informacion se ha eliminado con Exito");
                Limpiar();
                MostrarUsuarios();
            }
            else
            {
                Interaction.MsgBox("No se ha podido eliminar la informacion.");
            }
        }

        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value is not null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
        public void Limpiar()
        {
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtEstatus.Clear();
            txtContraseña.Clear();
        }
    }
}