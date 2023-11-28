using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class Productos
    {
        private BOProductos producto = new BOProductos();
        private bool etiqueta = true;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        public void Limpiar()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtDescripcion.Clear();
            txtEstatus.Clear();
            txtIdMarca.Clear();
            txtIdCategoria.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from Productos where Id_Producto = @Id_Producto", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Producto", txtIdProducto.Text));
            using (var sda = new SqlDataAdapter())
            {
                sda.SelectCommand = cmd;
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    if (Conversions.ToBoolean(dt.Rows.Count))
                    {
                        txtNombre.Text = dt.Rows[0][1].ToString();
                        txtPrecio.Text = dt.Rows[0][2].ToString();
                        txtStock.Text = dt.Rows[0][3].ToString();
                        txtDescripcion.Text = dt.Rows[0][4].ToString();
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.Rows[0][5], true, false)))
                        {
                            txtEstatus.Text = 1.ToString();
                        }
                        else
                        {
                            txtEstatus.Text = 0.ToString();
                        }
                        txtIdMarca.Text = dt.Rows[0][6].ToString();
                        txtIdCategoria.Text = dt.Rows[0][7].ToString();
                        txtIdCrear.Text = dt.Rows[0][8].ToString();
                        txtIdModificar.Text = dt.Rows[0][9].ToString();
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

            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEstatus.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdCategoria.Text))
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
                etiqueta = Conversions.ToBoolean(producto.RegistrarProducto(Conversions.ToInteger(txtIdProducto.Text), txtNombre.Text, Conversions.ToDouble(txtPrecio.Text), Conversions.ToInteger(txtStock.Text), txtDescripcion.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdMarca.Text), Conversions.ToInteger(txtIdCategoria.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarProductos();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtEstatus.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtIdCategoria.Text))
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
                etiqueta = Conversions.ToBoolean(producto.ModificarProducto(Conversions.ToInteger(txtIdProducto.Text), txtNombre.Text, Conversions.ToDouble(txtPrecio.Text), Conversions.ToInteger(txtStock.Text), txtDescripcion.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdMarca.Text), Conversions.ToInteger(txtIdCategoria.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarProductos();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                valido = false;
            }

            if (valido)
            {
                etiqueta = Conversions.ToBoolean(producto.EliminarProducto(Conversions.ToInteger(txtIdProducto.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarProductos();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }
        public void MostrarProductos()
        {
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Productos", cnn);
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
            dgvProductos.DataSource = dt;
        }

        private void MarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Marcas.Show();
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Categorias.Show();
        }
    }
}