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
    public partial class frmCuenta : Form
    {
        N_CUENTA Negocio = new N_CUENTA();
        E_CUENTA Entidad = new E_CUENTA();
        public frmCuenta()
        {
            InitializeComponent();
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet1.CUENTA' Puede moverla o quitarla según sea necesario.
            this.cUENTATableAdapter.Fill(this.gESTION_PEDIDODataSet1.CUENTA);
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.gESTION_PEDIDODataSet.CLIENTE);

        }

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
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

        private void MinimizarFormulario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void validarBalance(KeyPressEventArgs e)
        {
            
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr" + ex);
            }
            
        }

        private void montoIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarBalance(e);
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                Entidad.IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                Entidad.BalanceCuenta = Convert.ToInt32(textBalance.Text.ToUpper());
                Entidad.Num_Cuenta = Convert.ToInt32(textNumeroCuenta.Text.ToUpper());
                Negocio.insertarCuenta(Entidad);
                MessageBox.Show("Se creo la cuenta");
                this.cUENTATableAdapter.Fill(this.gESTION_PEDIDODataSet1.CUENTA);
                limpiarCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la cuenta" + ex);
            }
            limpiarCaja();
            
        }

        private void btnAgregarMonto_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad.IdCuenta = Convert.ToInt32(comboBoxCuenta.SelectedValue);
                Entidad.BalanceCuenta = Convert.ToInt32(textMontoIngreso.Text);
                Negocio.AñadirMonto(Entidad);
                MessageBox.Show("Se agrego el monto");
                textMontoIngreso.Focus();

                limpiarCaja2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el monto" + ex);
            }
            limpiarCaja();

        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad.IdCuenta = Convert.ToInt32(comboBoxCuenta.SelectedValue);
                Negocio.EliminarCuenta(Entidad);
                MessageBox.Show("Se elimino correctamente la cuenta");
                this.cUENTATableAdapter.Fill(this.gESTION_PEDIDODataSet1.CUENTA);
                limpiarCaja2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo borrar la cuenta" + ex);
            }
        }

        private void limpiarCaja()
        {
            
            textBalance.Clear();
            textNumeroCuenta.Clear();
            textMontoIngreso.Clear();
            textBalance.Focus();
        }

        private void limpiarCaja2()
        {
            textMontoIngreso.Clear();
            textMontoIngreso.Focus();
        }

       
    }
}
