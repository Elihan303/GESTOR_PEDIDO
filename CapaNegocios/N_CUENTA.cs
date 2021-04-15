using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocios
{
    public class N_CUENTA
    {
        D_CUENTA Dato = new D_CUENTA();

        public void insertarCuenta(E_CUENTA Cuenta) 
        {
            Dato.InsertarCuenta(Cuenta);
        }
        public void AñadirMonto(E_CUENTA Cuenta)
        {
            Dato.AñadirMonto(Cuenta);
        }
       

        public List<E_CUENTA> ListarCuenta(string buscar)
        {
            return Dato.ListarCuenta ( buscar);
        }

        public void DisminuirCuenta(E_CUENTA Cuenta) 
        {
            Dato.DisminuirCuenta(Cuenta);
        }
        public void EliminarCuenta(E_CUENTA Cuenta) 
        {
            Dato.EliminarCuenta(Cuenta);
        }


    }
}
