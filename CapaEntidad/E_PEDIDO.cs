using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_PEDIDO
    {
       private int _IdFactura;
       private int _IdProducto;
       private int _Cantidad;
       private int _Precio;
       private int _Monto;

        public int IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
        public int Monto { get => _Monto; set => _Monto = value; }
    }
}
