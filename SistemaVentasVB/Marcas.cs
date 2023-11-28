using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOSistemaVentasVB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaVentasVB
{

    public partial class Marcas
    {
        private BOMarca marca = new BOMarca();
        private bool etiqueta = true;

        public Marcas()
        {
            InitializeComponent();
        }
        private void Marcas_Load(object sender, EventArgs e)
        {
            MostrarMarca();
        }
        public void Limpiar()
        {
            txtIdMarca.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtEstatus.Clear();
            txtIdCrear.Clear();
            txtIdModificar.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;";
            var conn = new SqlConnection(conexion);
            conn.Open();
            var cmd = new SqlCommand("select * from Marca where Id_Marca = @Id_Marca", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Id_Marca", txtIdMarca.Text));
            using (var sda = new SqlDataAdapter())
            {
                sda.SelectCommand = cmd;
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    if (Conversions.ToBoolean(dt.Rows.Count))
                    {
                        txtNombre.Text = dt.Rows[0][1].ToString();
                        txtDescripcion.Text = dt.Rows[0][2].ToString();
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.Rows[0][3], true, false)))
                        {
                            txtEstatus.Text = 1.ToString();
                        }
                        else
                        {
                            txtEstatus.Text = 0.ToString();
                        }
                        txtIdCrear.Text = dt.Rows[0][4].ToString();
                        txtIdModificar.Text = dt.Rows[0][5].ToString();
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

            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
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
                etiqueta = Conversions.ToBoolean(marca.RegistrarMarcas(Conversions.ToInteger(txtIdMarca.Text), txtNombre.Text, txtDescripcion.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarMarca();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
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
                etiqueta = Conversions.ToBoolean(marca.ModificarMarcas(Conversions.ToInteger(txtIdMarca.Text), txtNombre.Text, txtDescripcion.Text, Conversions.ToInteger(txtEstatus.Text), Conversions.ToInteger(txtIdCrear.Text), Conversions.ToInteger(txtIdModificar.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarMarca();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                valido = false;
            }
            if (valido)
            {
                etiqueta = Conversions.ToBoolean(marca.EliminarMarcas(Conversions.ToInteger(txtIdMarca.Text)));
                Interaction.MsgBox("La informacion se ha registrado con Exito");
                Limpiar();
                MostrarMarca();
            }
            else
            {
                Interaction.MsgBox("No se ha podido registrar la informacion.");
            }
        }
        public void MostrarMarca()
        {
            var cnn = new SqlConnection("Server=LAPTOP-I2RJCKLJL;Database=VENTAS; Integrated Security=True;");
            var cmd = new SqlCommand("SELECT * FROM Marca", cnn);
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
            dgvMarcas.DataSource = dt;
        }
    }
}