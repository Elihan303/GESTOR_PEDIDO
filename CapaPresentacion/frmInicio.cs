using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void MinimizarFormulario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RestaurarFormulario_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized) 
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducto frmProducto = new frmProducto();
            frmProducto.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrePedido frmPrePepido = new frmPrePedido();
            frmPrePepido.Show();
           
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCuenta frmCuenta = new frmCuenta();
            frmCuenta.Show();
        }
    }
}
