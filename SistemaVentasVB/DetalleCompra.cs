using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class DetalleCompra
    {
        private BODetalleCompra dcompra = new BODetalleCompra();
        private bool etiqueta = true;

        public DetalleCompra()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarDVentas();
        }
        public void Limpiar()
        {
            txtIdDetalleCompra.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
            txtIdProducto.Clear();
            txtIdCompra.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJL;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from DetalleCompra where Id_DetalleCompra = @Id_DetalleCompra", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleCompra", txtIdDetalleCompra.Text));
            using (var sda = new SqlDataAdapter())
            {
                sda.SelectCommand = cmd;
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    if (Conversions.ToBoolean(dt.Rows.Count))
                    {
                        txtCantidad.Text = dt.Rows[0][1].ToString();
                        txtTotal.Text = dt.Rows[0][2].ToString();
                        txtIdProducto.Text = dt.Rows[0][3].ToString();
                        txtIdCompra.Text = dt.Rows[0][4].ToString();
                        txtIdCrear.Text = dt.Rows[0][5].ToString();
                        txtIdModificar.Text = dt.Rows[0][6].ToString();
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

            if (string.IsNullOrEmpty(txtIdDetalleCompra.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdCompra.Text))
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
                etiqueta = Conversions.ToBoolean(dcompra.RegistrarDCompra(Conversions.ToInteger(txtIdCompra.Text), Conversions.ToInteger(txtCantidad.Text), Conversions.ToDouble(txtTotal.Text), Conversions.ToInteger(txtIdProducto.Text), Conversions.ToInteger(txtIdCompra.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarDVentas();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdDetalleCompra.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdCompra.Text))
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
                etiqueta = Conversions.ToBoolean(dcompra.ModificarDCompra(Conversions.ToInteger(txtIdCompra.Text), Conversions.ToInteger(txtCantidad.Text), Conversions.ToDouble(txtTotal.Text), Conversions.ToInteger(txtIdProducto.Text), Conversions.ToInteger(txtIdCompra.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarDVentas();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdDetalleCompra.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(dcompra.EliminarDCompra(Conversions.ToInteger(txtIdCompra.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarDVentas();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }
        public void MostrarDVentas()
        {
            var cnn = new SqlConnection("Server=Server=LAPTOP-I2RJCKLJL;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM DetalleCompras", cnn);
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
            dgvDCompra.DataSource = dt;
        }
    }
}