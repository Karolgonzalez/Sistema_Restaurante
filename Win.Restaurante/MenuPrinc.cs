using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Restaurante
{
    public partial class MenuPrinc : Form
    {
        public MenuPrinc()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAgregarProductos = new FormAgregarProductos();
            FormAgregarProductos.MdiParent = this;
            FormAgregarProductos.Show();
        }

        private void MenuPrinc_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var FormLogin = new Login();
            FormLogin.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAgregar = new FormAgregarO();
            FormAgregar.MdiParent = this;
            FormAgregar.Show();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormCancelar = new FormCancelarO();
            FormCancelar.MdiParent = this;
            FormCancelar.Show();
        }

        private void estatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormEstado = new FormEstadoO();
            FormEstado.MdiParent = this;
            FormEstado.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormEliminarProductos = new FormEliminarProductos();
            FormEliminarProductos.MdiParent = this;
            FormEliminarProductos.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var FormVentas = new FormVentas();
            FormVentas.MdiParent = this;
            FormVentas.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormCompras = new FormCompras();
            FormCompras.MdiParent = this;
            FormCompras.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormPagos = new FormPagos();
            FormPagos.MdiParent = this;
            FormPagos.Show();
        }
    }
}
