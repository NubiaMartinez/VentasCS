using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVentasVB
{

    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection("Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true");
            conn.Open();
            string query = "select * from Usuarios where NombreUsuario= '" + txtUsuario.Text + "' and Contraseña= '" + txtPassword.Text + "'";
            var cmd = new SqlCommand(query, conn);
            var rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                MessageBox.Show("Acceso Exitoso");
                My.MyProject.Forms.Inicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuario no existe o los datos son incorrectos.");
            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}