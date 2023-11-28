using System;

namespace SistemaVentasVB
{
    public partial class Inicio
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.Login.Hide();
        }
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Usuarios.ShowDialog();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Proveedores.ShowDialog();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Productos.Show();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Ventas.Show();
        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Compras.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Clientes.Show();
        }
    }
}