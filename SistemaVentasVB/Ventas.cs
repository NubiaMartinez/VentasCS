using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class Ventas
    {
        private BOVentas venta = new BOVentas();
        private bool etiqueta = true;

        public Ventas()
        {
            InitializeComponent();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            MostrarVentas();
        }
        public void Limpiar()
        {
            txtIdVenta.Clear();
            txtFecha.Clear();
            txtIVA.Clear();
            txtSubtotal.Clear();
            txtEstatus.Clear();
            txtIdCliente.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from Ventas where Id_Venta = @Id_Venta", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Venta", txtIdVenta.Text));
            using (var sda = new SqlDataAdapter())
            {
                sda.SelectCommand = cmd;
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    if (Conversions.ToBoolean(dt.Rows.Count))
                    {
                        txtFecha.Text = dt.Rows[0][1].ToString();
                        txtIVA.Text = dt.Rows[0][2].ToString();
                        txtSubtotal.Text = dt.Rows[0][3].ToString();
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.Rows[0][4], true, false)))
                        {
                            txtEstatus.Text = 1.ToString();
                        }
                        else
                        {
                            txtEstatus.Text = 0.ToString();
                        }
                        txtIdCliente.Text = dt.Rows[0][5].ToString();
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

            if (string.IsNullOrEmpty(txtIdVenta.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtFecha.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIVA.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtSubtotal.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEstatus.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdCliente.Text))
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
                etiqueta = Conversions.ToBoolean(venta.RegistrarVenta(Conversions.ToInteger(txtIdVenta.Text), Conversions.ToDate(txtFecha.Text), Conversions.ToDouble(txtIVA.Text), Conversions.ToDouble(txtSubtotal.Text), Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCliente.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarVentas();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdVenta.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtFecha.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIVA.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtSubtotal.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEstatus.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdCliente.Text))
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
                etiqueta = Conversions.ToBoolean(venta.ModificarVenta(Conversions.ToInteger(txtIdVenta.Text), Conversions.ToDate(txtFecha.Text), Conversions.ToDouble(txtIVA.Text), Conversions.ToDouble(txtSubtotal.Text), Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCliente.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarVentas();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdVenta.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(venta.EliminarVenta(Conversions.ToInteger(txtIdVenta.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarVentas();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }
        public void MostrarVentas()
        {
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Ventas", cnn);
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
            dgvVentas.DataSource = dt;
        }

        private void DetalleComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DetalleVenta.ShowDialog();
        }
    }
}