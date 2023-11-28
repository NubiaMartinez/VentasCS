using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{
    public partial class Clientes
    {
        private BOClientes cliente = new BOClientes();
        private bool etiqueta = true;

        public Clientes()
        {
            InitializeComponent();
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        public void Limpiar()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtEstatus.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from Clientes where Id_Cliente = @Id_Cliente", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", txtIdCliente.Text));
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
                        txtIdCrear.Text = dt.Rows[0][6].ToString();
                        txtIdModificar.Text = dt.Rows[0][7].ToString();
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

            if (string.IsNullOrEmpty(txtIdCliente.Text))
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
            if (string.IsNullOrEmpty(txtIdCrear.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdModificar.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(cliente.RegistrarCliente(Conversions.ToInteger(txtIdCliente.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarClientes();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdCliente.Text))
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
            if (string.IsNullOrEmpty(txtIdCrear.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdModificar.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(cliente.ModificarCliente(Conversions.ToInteger(txtIdCliente.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha modificado con Exito");
                Limpiar();
                MostrarClientes();
            }
            else
            {
                Interaction.MsgBox("No se ha podido modificar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdCliente.Text))
            {
                valido = false;
            }

            if (valido)
            {
                etiqueta = Conversions.ToBoolean(cliente.EliminarCliente(Conversions.ToInteger(txtIdCliente.Text)));
                Interaction.MsgBox("La informacion se ha eliminado con Exito");
                Limpiar();
                MostrarClientes();
            }
            else
            {
                Interaction.MsgBox("No se ha podido eliminar la informacion.");
            }
        }
        public void MostrarClientes()
        {
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Clientes", cnn);
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
            dgvClientes.DataSource = dt;
        }
    }
}