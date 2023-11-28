using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class Proveedores
    {
        private BOProveedores proveedor = new BOProveedores();
        private bool etiqueta = true;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
        }
        public void Limpiar()
        {
            txtIdProveedor.Clear();
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
            var cmd = new SqlCommand("select * from Proveedores where Id_Proveedor = @Id_Proveedor", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", txtIdProveedor.Text));
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

            if (string.IsNullOrEmpty(txtIdProveedor.Text))
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
                etiqueta = Conversions.ToBoolean(proveedor.RegistrarProveedor(Conversions.ToInteger(txtIdProveedor.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarProveedores();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdProveedor.Text))
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
                etiqueta = Conversions.ToBoolean(proveedor.ModificarProveedor(Conversions.ToInteger(txtIdProveedor.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha modificado con Exito");
                Limpiar();
                MostrarProveedores();
            }
            else
            {
                Interaction.MsgBox("No se ha podido modificar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdProveedor.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(proveedor.EliminarProveedor(Conversions.ToInteger(txtIdProveedor.Text)));
                Interaction.MsgBox("La informacion se ha modificado con Exito");
                Limpiar();
                MostrarProveedores();
            }
            else
            {
                Interaction.MsgBox("No se ha podido modificar la informacion.");
            }
        }
        public void MostrarProveedores()
        {
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Proveedores", cnn);
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
            dgvProveedores.DataSource = dt;
        }
    }
}