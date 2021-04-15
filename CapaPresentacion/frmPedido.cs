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
    public partial class frmPedido : Form
    {
        E_CUENTA EntidadCuenta = new E_CUENTA();
        N_CUENTA NegocioCuenta = new N_CUENTA();
        N_PRODUCTO NegocioProducto = new N_PRODUCTO();
        E_PRODUCTO EntidadProducto = new E_PRODUCTO();

        N_PEDIDO NegocioPedido = new N_PEDIDO();
        E_PEDIDO EntidadPedido = new E_PEDIDO();

        N_FACTURA NegocioFactura = new N_FACTURA();
        E_FACTURA EntidadFactura = new E_FACTURA();

        public int idcliente;
        public int balance;
        public int cantidad;
        public string idProducto;
        public int numeroCuenta;
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet4.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.gESTION_PEDIDODataSet4.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet3.CUENTA' Puede moverla o quitarla según sea necesario.
            this.cUENTATableAdapter.Fill(this.gESTION_PEDIDODataSet3.CUENTA);
            // TODO: esta línea de código carga datos en la tabla 'gESTION_PEDIDODataSet2.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.gESTION_PEDIDODataSet2.CLIENTE);

            mostrarBuscarTabla("");
            accionesTabla();
            Console.WriteLine(idcliente);
            Console.WriteLine(balance);
            txtBalance.Text = balance.ToString();
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

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        public void mostrarBuscarTabla(string buscar)
        {
            tablaProducto.DataSource = NegocioProducto.ListarProducto(buscar);
            tablaProducto.ClearSelection();
        }
        private void accionesTabla()
        {
            tablaProducto.Columns[0].Visible = false;
            tablaProducto.ClearSelection();
        }
        private void limpiarCaja()
        {
            textNombre.Clear();
            textPrecio.Clear();
            textStock.Clear();
            textCantidad.Clear();
            textCantidad.Focus();
        }


        private void text_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(text_buscar.Text);
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            if (tablaProducto.SelectedRows.Count > 0)
            {
                idProducto = tablaProducto.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = tablaProducto.CurrentRow.Cells[1].Value.ToString();
                textPrecio.Text = tablaProducto.CurrentRow.Cells[2].Value.ToString();
                textStock.Text = tablaProducto.CurrentRow.Cells[3].Value.ToString();
                cantidad = Convert.ToInt32(tablaProducto.CurrentRow.Cells[3].Value);
                tablaProducto.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla producto");
            }

        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            string valor1 = textNombre.Text;
            string valor2 = textCantidad.Text;

            if (valor1 == "")
            {
                MessageBox.Show("Seleccione un producto");
            }
            else if (valor2 == "")
            {
                MessageBox.Show("Digite la cantidad que desea obtener ");
            }
            else
            {
                int valor3 = Convert.ToInt32(textCantidad.Text);
                if (valor3 > cantidad)
                {

                    MessageBox.Show("Digite una cantidad disponible de stock");
                }
                else
                {
                    int n = tablaPedido.Rows.Add();
                    tablaPedido.Rows[n].Cells[0].Value = idProducto;
                    tablaPedido.Rows[n].Cells[1].Value = textNombre.Text;
                    tablaPedido.Rows[n].Cells[2].Value = textPrecio.Text;
                    tablaPedido.Rows[n].Cells[3].Value = textCantidad.Text;
                    limpiarCaja();
                    tablaPedido.ClearSelection();
                }
            }



        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {

            int montoFactura = 0;
            int montoPedido = 0;
            int Precio;
            int Cantidad;
            int totalCantidad = 0;
            string tipoFactura;
            //foreach factura
            foreach (DataGridViewRow row in tablaPedido.Rows)
            {
                Precio = Convert.ToInt32(row.Cells["Column3"].Value);
                Cantidad = Convert.ToInt32(row.Cells["Column4"].Value);
                totalCantidad += cantidad;
                montoFactura += Cantidad * Precio;

            }

            if (totalCantidad > 20)
            {
                tipoFactura = "Compuesta";
            }
            else
            {
                tipoFactura = "Simple";
            }

            //buscar cuenta
          

            //validar si el balance es suficientes para pagar la factura
            if (balance >= montoFactura)
            {

                //restar balance a la cuenta
                balance = balance - montoFactura;
                EntidadCuenta.Num_Cuenta = numeroCuenta;
                EntidadCuenta.BalanceCuenta = montoFactura;
                Console.WriteLine(EntidadCuenta.BalanceCuenta);
                NegocioCuenta.DisminuirCuenta(EntidadCuenta);

                //insertardo factura
               
                EntidadFactura.TipoFactura = tipoFactura;
                EntidadFactura.IdCliente = idcliente;
                EntidadFactura.Monto = montoFactura;
                NegocioFactura.insertarFactura(EntidadFactura);

                //obtener valor de factura 
                NegocioFactura.SeleccionarFactura(EntidadFactura);
              

                //foreach pedido
                foreach (DataGridViewRow row in tablaPedido.Rows)
                {
                    Precio = Convert.ToInt32(row.Cells["Column3"].Value);
                    Cantidad = Convert.ToInt32(row.Cells["Column4"].Value);
                    montoPedido = Cantidad * Precio;

                    EntidadPedido.IdFactura = EntidadFactura.LastId;
                    EntidadPedido.IdProducto = Convert.ToInt32(row.Cells["Column1"].Value);
                    EntidadPedido.Cantidad = Convert.ToInt32(row.Cells["Column4"].Value);
                    EntidadPedido.Precio = Convert.ToInt32(row.Cells["Column3"].Value);
                    EntidadPedido.Monto = montoPedido;

                    NegocioPedido.insertarPedido(EntidadPedido);

                    



                }

                //foreach disminuir stock
                foreach (DataGridViewRow row in tablaPedido.Rows)
                {
                    EntidadProducto.IdProducto= Convert.ToInt32(row.Cells["Column1"].Value);
                    EntidadProducto.StockProducto = Convert.ToInt32(row.Cells["Column4"].Value);
                    NegocioProducto.ReducirStockProducto(EntidadProducto);
          
                }


                tablaPedido.Rows.Clear();
                tablaPedido.ClearSelection();
                mostrarBuscarTabla("");
                accionesTabla();
                txtBalance.Text = balance.ToString();
                MessageBox.Show("Se ha generado su pedido con exito");
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta que tenga dinero suficiente o recargue su cuenta");
                tablaPedido.Rows.Clear();
            }

            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in tablaPedido.SelectedRows) { 
                tablaPedido.Rows.Remove(row);
            }
            tablaPedido.ClearSelection();
        }
    }
}
