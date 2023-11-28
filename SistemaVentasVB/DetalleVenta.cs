using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class DetalleVenta
    {
        private BODetalleVenta dventa = new BODetalleVenta();
        private bool etiqueta = true;

        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarDVentas();
        }
        public void Limpiar()
        {
            txtIdDetalleVenta.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
            txtIdProducto.Clear();
            txtIdVenta.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from DetalleVenta where Id_DetalleVenta = @Id_DetalleVenta", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleVenta", txtIdDetalleVenta.Text));
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
                        txtIdVenta.Text = dt.Rows[0][4].ToString();
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

            if (string.IsNullOrEmpty(txtIdDetalleVenta.Text))
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
            if (string.IsNullOrEmpty(txtIdVenta.Text))
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
                etiqueta = Conversions.ToBoolean(dventa.RegistrarDVenta(Conversions.ToInteger(txtIdVenta.Text), Conversions.ToInteger(txtCantidad.Text), Conversions.ToDouble(txtTotal.Text), Conversions.ToInteger(txtIdProducto.Text), Conversions.ToInteger(txtIdVenta.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
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

            if (string.IsNullOrEmpty(txtIdDetalleVenta.Text))
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
            if (string.IsNullOrEmpty(txtIdVenta.Text))
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
                etiqueta = Conversions.ToBoolean(dventa.ModificarDVenta(Conversions.ToInteger(txtIdVenta.Text), Conversions.ToInteger(txtCantidad.Text), Conversions.ToDouble(txtTotal.Text), Conversions.ToInteger(txtIdProducto.Text), Conversions.ToInteger(txtIdVenta.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
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

            if (string.IsNullOrEmpty(txtIdDetalleVenta.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(dventa.EliminarDVenta(Conversions.ToInteger(txtIdVenta.Text)));
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
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM DetalleVentas", cnn);
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
            dgvDVenta.DataSource = dt;
        }

    }
}