using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class N_PRODUCTO
    {
        D_PRODUCTO Dato= new D_PRODUCTO();
        public List<E_PRODUCTO> ListarProducto(string buscar)
        {
            return  Dato.ListarProducto(buscar);
        }
        public void InsertarProducto(E_PRODUCTO Producto)
        {
            Dato.InsertarProducto(Producto);
        }
        public void EditarProducto(E_PRODUCTO Producto)
        {
            Dato.EditarProducto(Producto);
        }
        public void EliminandoProducto(E_PRODUCTO Producto)
        {
            Dato.EliminarProducto(Producto);
        }

        public void ReducirStockProducto(E_PRODUCTO Producto) 
        {
            Dato.ReducirStockProducto(Producto);
        }

    }
}
