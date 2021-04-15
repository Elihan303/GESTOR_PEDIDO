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
    public partial class frmCliente : Form
    {
        private string idCliente;
        private bool Editarse = false;


        N_CLIENTE Negocio = new N_CLIENTE();
        E_CLIENTE Entidad = new E_CLIENTE();
        public frmCliente()
        {
            InitializeComponent();
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

     
        public void mostrarBuscarTabla(string buscar)
        {

            tablaCliente.DataSource = Negocio.ListarCliente(buscar);
            tablaCliente.ClearSelection();
        }
        private void accionesTabla()
        {
            tablaCliente.Columns[0].Visible = false;
            tablaCliente.ClearSelection();
        }

        private void limpiarCaja()
        {
            Editarse = false;
            textNombre.Clear();
            textDireccion.Clear();
            textTelefono.Clear();
            textEmail.Clear();
            textNombre.Focus();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            limpiarCaja();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCliente.SelectedRows.Count > 0)
            {
                Editarse = true;
                idCliente = tablaCliente.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = tablaCliente.CurrentRow.Cells[1].Value.ToString();
                textDireccion.Text = tablaCliente.CurrentRow.Cells[2].Value.ToString();
                textTelefono.Text = tablaCliente.CurrentRow.Cells[3].Value.ToString();
                textEmail.Text = tablaCliente.CurrentRow.Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    Entidad.NombreCliente = textNombre.Text.ToUpper();
                    Entidad.DireccionCliente = textDireccion.Text.ToUpper();
                    Entidad.TelefonoCliente = textTelefono.Text.ToUpper();
                    Entidad.EmailCliente = textEmail.Text.ToUpper();
                    Negocio.InsertarCliente(Entidad);
                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }


            }

            if (Editarse == true)
            {
                try
                {
                    Entidad.IdCliente = Convert.ToInt32(tablaCliente.CurrentRow.Cells[0].Value);
                    Entidad.NombreCliente = textNombre.Text.ToUpper();
                    Entidad.DireccionCliente = textDireccion.Text.ToUpper();
                    Entidad.TelefonoCliente = textTelefono.Text.ToUpper();
                    Entidad.EmailCliente = textEmail.Text.ToUpper();
                    Negocio.EditarCliente(Entidad);
                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaCliente.SelectedRows.Count > 0)
            {
                Entidad.IdCliente = Convert.ToInt32(tablaCliente.CurrentRow.Cells[0].Value.ToString());
                Negocio.EliminandoCliente(Entidad);
                MessageBox.Show("Se elimino el registro correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere eliminar");
            }
        }
    }
}
