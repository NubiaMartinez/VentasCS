using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class Compras
    {
        private BOCompras compra = new BOCompras();
        private bool etiqueta = true;

        public Compras()
        {
            InitializeComponent();
        }
        private void Compras_Load(object sender, EventArgs e)
        {
            MostrarCompras();
        }
        public void Limpiar()
        {
            txtIdCompra.Clear();
            txtFecha.Clear();
            txtIVA.Clear();
            txtSubtotal.Clear();
            txtEstatus.Clear();
            txtIdProveedor.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from Compras where Id_Compra = @Id_Compra", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Compra", txtIdCompra.Text));
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
                        txtIdProveedor.Text = dt.Rows[0][5].ToString();
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

            if (string.IsNullOrEmpty(txtIdCompra.Text))
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
            if (string.IsNullOrEmpty(txtIdProveedor.Text))
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
                etiqueta = Conversions.ToBoolean(compra.RegistrarCompra(Conversions.ToInteger(txtIdCompra.Text), Conversions.ToDate(txtFecha.Text), Conversions.ToDouble(txtIVA.Text), Conversions.ToDouble(txtSubtotal.Text), Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdProveedor.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarCompras();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdCompra.Text))
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
            if (string.IsNullOrEmpty(txtIdProveedor.Text))
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
                etiqueta = Conversions.ToBoolean(compra.ModificarCompra(Conversions.ToInteger(txtIdCompra.Text), Conversions.ToDate(txtFecha.Text), Conversions.ToDouble(txtIVA.Text), Conversions.ToDouble(txtSubtotal.Text), Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdProveedor.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarCompras();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdCompra.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(compra.EliminarCompra(Conversions.ToInteger(txtIdCompra.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarCompras();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }
        public void MostrarCompras()
        {
            var cnn = new SqlConnection("Server=Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Compras", cnn);
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
            dgvCompras.DataSource = dt;
        }

        private void DetalleComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DetalleCompra.ShowDialog();
        }
    }
}