using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class N_PEDIDO
    {
        D_PEDIDO Dato = new D_PEDIDO();

        public void insertarPedido(E_PEDIDO Pedido) 
        {
            Dato.InsertarPedida(Pedido);
        }

    }
}
