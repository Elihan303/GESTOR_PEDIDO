using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public class E_PRODUCTO
    {
        private int _IdProducto;
        private string _NombreProducto;
        private int _PrecioProducto;
        private int _StockProducto;
   

        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public int PrecioProducto { get => _PrecioProducto; set => _PrecioProducto = value; }
        public int StockProducto { get => _StockProducto; set => _StockProducto = value; }
    }
}
