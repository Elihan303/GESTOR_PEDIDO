using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocios
{
    public class N_CLIENTE
    {
         D_CLIENTE Dato = new D_CLIENTE();
        public List<E_CLIENTE> ListarCliente(string buscar)
        {
            return Dato.ListarCliente(buscar);
        }
        public void InsertarCliente(E_CLIENTE Cliente)
        {
            Dato.InsertarCliente(Cliente);
        }
        public void EditarCliente(E_CLIENTE Cliente)
        {
            Dato.EditarCliente(Cliente);
        }
        public void EliminandoCliente(E_CLIENTE Cliente)
        {
            Dato.EliminarCliente(Cliente);
        }
    }
}
