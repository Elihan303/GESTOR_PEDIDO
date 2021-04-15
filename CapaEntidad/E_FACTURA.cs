using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_FACTURA
    {
        private int _IdFactura;
        private string _TipoFactura;
        private int _IdCliente;
        private int _Monto;
        private int _LastId;

        public int IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public string TipoFactura { get => _TipoFactura; set => _TipoFactura = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int Monto { get => _Monto; set => _Monto = value; }
        public int LastId { get => _LastId; set => _LastId = value; }
    }
}
