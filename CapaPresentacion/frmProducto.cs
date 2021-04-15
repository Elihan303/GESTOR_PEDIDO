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
    public partial class frmProducto : Form
    {
        private string idProducto;
        public bool Editarse= false;


        N_PRODUCTO Negocio = new N_PRODUCTO();
        E_PRODUCTO Entidad = new E_PRODUCTO();

        public frmProducto()
        {
            InitializeComponent();
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

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            
            tablaProducto.DataSource = Negocio.ListarProducto(buscar);
            tablaProducto.ClearSelection();
        }
        private void accionesTabla()
        {
            tablaProducto.Columns[0].Visible = false;
            //tablaProducto.Columns[1].Width = 60;
            //tablaProducto.Columns[2].Width = 170;
            tablaProducto.ClearSelection();
        }

        private void limpiarCaja()
        {
            Editarse = false;
            textNombre.Clear();
            textPrecio.Clear();
            textStock.Clear();
            textNombre.Focus();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

        private void text_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(text_buscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            limpiarCaja();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaProducto.SelectedRows.Count > 0)
            {
                Editarse = true;
                idProducto = tablaProducto.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = tablaProducto.CurrentRow.Cells[1].Value.ToString();
                textPrecio.Text = tablaProducto.CurrentRow.Cells[2].Value.ToString();
                textStock.Text = tablaProducto.CurrentRow.Cells[3].Value.ToString();

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
                    Entidad.NombreProducto = textNombre.Text.ToUpper();
                    Entidad.PrecioProducto = Convert.ToInt32(textPrecio.Text.ToUpper());
                    Entidad.StockProducto = Convert.ToInt32(textStock.Text.ToUpper());
                    Negocio.InsertarProducto(Entidad);
                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el producto" + ex);
                }


            }

            if (Editarse == true)
            {
                try
                {
                    Entidad.IdProducto = Convert.ToInt32(tablaProducto.CurrentRow.Cells[0].Value);
                    Entidad.NombreProducto = textNombre.Text.ToUpper();
                    Entidad.PrecioProducto = Convert.ToInt32(textPrecio.Text.ToUpper());
                    Entidad.StockProducto = Convert.ToInt32(textStock.Text.ToUpper());
                    Negocio.EditarProducto(Entidad);
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
            if (tablaProducto.SelectedRows.Count > 0)
            {
                Entidad.IdProducto = Convert.ToInt32(tablaProducto.CurrentRow.Cells[0].Value.ToString());
                Negocio.EliminandoProducto(Entidad);
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
