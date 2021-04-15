using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrePedido : Form
    {
        
  
        public frmPrePedido()
        {
            InitializeComponent();
        }

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmPedido frmPedido = new frmPedido();

            frmPedido.idcliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
            
            frmPedido.balance = Convert.ToInt32(comboBoxCuenta.SelectedValue);

            frmPedido.numeroCuenta= Convert.ToInt32(comboBoxCuenta.Text);
            

            if (frmPedido.balance > 0)
            {
                this.Hide();
                frmPedido.Show();
            }
            else 
            {
                MessageBox.Show("Escoja una tarjeta con dinero o añada monto a su cuenta");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void frmPrePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet6.CUENTA' Puede moverla o quitarla según sea necesario.
            this.cUENTATableAdapter.Fill(this.gESTION_PEDIDODataSet6.CUENTA);
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet5.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.gESTION_PEDIDODataSet5.CLIENTE);

        }

    
    }
}
