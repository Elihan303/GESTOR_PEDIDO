using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class N_FACTURA
    {
        D_FACTURA Dato = new D_FACTURA();
        public void insertarFactura(E_FACTURA Factura)
        {
            Dato.InsertarFactura(Factura);
        }

        public void eliminarFactura(E_FACTURA Factura) 
        {
            Dato.EliminarFactura(Factura);
        }

        public void listarFactura(E_FACTURA Factura) 
        {
            Dato.InsertarFactura(Factura);
        }
        public void SeleccionarFactura(E_FACTURA Factura) 
        {
            Dato.SeleccionarFactura(Factura);
        }


    }
}
